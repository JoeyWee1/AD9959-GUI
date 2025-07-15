// 2 level modulation on channel 0. 


# include <SPI.h>


const int CSB = 10;
const int IO_UPDATE = 4;
const int RESET = 2;
const int P0 = 8; //all 4 pins used for 16 level modulation
const int P1 = 7;
const int P2 = 6;
const int P3 = 5;


uint32_t calculateFTW(uint32_t frequencyHz) {
  /*
  Calculate the FTW frequency from an input intended frequency output
  */
  double systemClock = 500000000.0; // 500 MHz System Clock (20x PLL * 25 MHz reference)
  return (uint32_t)((frequencyHz * pow(2, 32)) / systemClock); 
}

void setChannelFrequency(int channel, uint32_t frequency) {
  uint32_t ftw = calculateFTW(frequency);

  //Array of the channel registers:
  uint8_t channel_registers[4] = {0x10,0x20,0x40,0x80};

  //Enable only selected channel
  digitalWrite(CSB,LOW);
  SPI.transfer(0x00); 
  SPI.transfer(channel_registers[channel]);
  digitalWrite(CSB,HIGH);

  //Set FTW correspondingly
  digitalWrite(CSB,LOW);
  SPI.transfer(0x04);
  SPI.transfer((ftw >> 24) & 0xFF);  // Byte 1 (MSB). Shift the bits 24 bits to the right and capture the last 8 bits
  SPI.transfer((ftw >> 16) & 0xFF);  // Byte 2
  SPI.transfer((ftw >> 8) & 0xFF);   // Byte 3
  SPI.transfer(ftw & 0xFF);          // Byte 4 (LSB)
  digitalWrite(CSB,HIGH);
}

void channelWordFrequency(int channelWord, uint32_t frequency) {
  uint32_t ftw = calculateFTW(frequency);

  //Array of the channel registers:
  uint8_t channel_word_registers[15] = {0x0A,0x0B,0x0C,0x0D,0x0E,0x0F,0x10,0x11,0x12,0x13,0x14,0x15,0x16,0x17,0x18};

  //Enable only channel 0
  digitalWrite(CSB,LOW);
  SPI.transfer(0x00); 
  SPI.transfer(0x10);
  digitalWrite(CSB,HIGH);

  //set channel word correpsondingly:
  digitalWrite(CSB,LOW);
  SPI.transfer(channel_word_registers[channelWord]);
  SPI.transfer((ftw >> 24) & 0xFF);  // Byte 1 (MSB). Shift the bits 24 bits to the right and capture the last 8 bits
  SPI.transfer((ftw >> 16) & 0xFF);  // Byte 2
  SPI.transfer((ftw >> 8) & 0xFF);   // Byte 3
  SPI.transfer(ftw & 0xFF);          // Byte 4 (LSB)
  digitalWrite(CSB,HIGH);
}

void setProfilePins(uint8_t profileIndex) {
  // profileIndex is 0–15 (0000–1111)
  // profileIndex & 0x08 compares each bit of the two numbers and outputs 1 iff both bits are 1. Otherwise it outputs 0. 
  // If it is nonzero it outputs high if is zero it outputs low
  // ? is a conditional operator that outputs TRUE : FALSE
  digitalWrite(P0, (profileIndex & 0x08) ? HIGH : LOW); // MSB 
  digitalWrite(P1, (profileIndex & 0x04) ? HIGH : LOW);
  digitalWrite(P2, (profileIndex & 0x02) ? HIGH : LOW);
  digitalWrite(P3, (profileIndex & 0x01) ? HIGH : LOW); // LSB

}


void setup() {
  // put your setup code here, to run once:

// Set pinmodes:
pinMode(CSB,OUTPUT);
pinMode(RESET,OUTPUT);
pinMode(IO_UPDATE,OUTPUT);
pinMode(P0,OUTPUT);
pinMode(P1,OUTPUT);
pinMode(P2,OUTPUT);
pinMode(P3,OUTPUT);


// Set default values
digitalWrite(CSB,HIGH);
digitalWrite(RESET,LOW);
digitalWrite(IO_UPDATE,LOW);
digitalWrite(P0,LOW);  //Default to frequency from FTW 0x04
digitalWrite(P1,LOW); 
digitalWrite(P2,LOW); 
digitalWrite(P3,LOW); 



//Start SPI transaction:
SPI.begin();
SPI.beginTransaction(SPISettings(125000, MSBFIRST, SPI_MODE0)); 
// SPI clock: 125kHz for voltage to reach 3.3V in level shifters
// SDIO_0 since we are using 2 wire mode. s


//Reset Device:
digitalWrite(RESET,1);
digitalWrite(RESET,0);
delay(1);


//Set PLL to 20x and pin 0 active

digitalWrite(CSB, LOW);
SPI.transfer(0x01); //function register 1 (FR1)
SPI.transfer(B11010000); //Set PLL to 20 and VCO to 1
SPI.transfer(B00000011); //The bits FR1[14:12] is set to x00 for 16 level modulation on CH0
//Modulation level bits FR1[9:8] is set to 11 for 16 level modulation
//No RU and RD needed so FR1[11:10] is set to [00]
SPI.transfer(0x00); 
digitalWrite(IO_UPDATE, HIGH);
digitalWrite(IO_UPDATE, LOW);
digitalWrite(CSB, HIGH); //Disable slave select
delay(1); // 1 millisecond delay for PLL to be activated


//Disable frequency modulation for the other 3 channels
digitalWrite(CSB,0);
SPI.transfer(0x00);
SPI.transfer(B11100000);
digitalWrite(CSB,1); 

digitalWrite(CSB,0);
SPI.transfer(0x03); //CFR
SPI.transfer(B00000000); //AFP is set to 00 for no modulation
SPI.transfer(0x03); //Linear sweep enable disabled. Full scale DAC current control
SPI.transfer(0x00); //Default is 0 for not clearing the phase accumlator
digitalWrite(IO_UPDATE,1);
digitalWrite(IO_UPDATE,0);
digitalWrite(CSB,1);


//Enable Channel 0 only:
digitalWrite(CSB,0);
SPI.transfer(0x00);
SPI.transfer(0x10);
digitalWrite(CSB,1); 


//Choose frequency modulation
digitalWrite(CSB,0);
SPI.transfer(0x03); //Channel Function Register (CFR)
SPI.transfer(B10000000); //AFP is selected for frequency modulation [10]
SPI.transfer(0x03); //Linear sweep enable disabled. Full scale DAC current control
SPI.transfer(0x00); //Default is 0 for not clearing the phase accumlator
digitalWrite(IO_UPDATE,1);
digitalWrite(IO_UPDATE,0);
digitalWrite(CSB,1);




//Set frequency 1: FTW 0x04:
setChannelFrequency(0,10000000); 




//Set frequency 2: Channel Word 1. 0x0A
channelWordFrequency(0,20000000); // This is profile pin 1

//Set frequency 3: Channel Word 2. 
channelWordFrequency(1,30000000);

channelWordFrequency(2,40000000);

channelWordFrequency(3,50000000);

channelWordFrequency(4,60000000);

channelWordFrequency(5,70000000);

channelWordFrequency(6,80000000);

channelWordFrequency(7,90000000);

channelWordFrequency(8,100000000);

channelWordFrequency(9,110000000);

channelWordFrequency(10,120000000); //Something wrong

channelWordFrequency(11,130000000);

channelWordFrequency(12,140000000);

channelWordFrequency(13,150000000);  

channelWordFrequency(14,160000000);//Something wrong



digitalWrite(IO_UPDATE,1);
digitalWrite(IO_UPDATE,0);

digitalWrite(P0,HIGH);
digitalWrite(P1,HIGH);
digitalWrite(P2,LOW);
digitalWrite(P3,HIGH);
}

void loop() {
  // put your main code here, to run repeatedly:

// for (uint8_t i = 0; i < 16; i++) {
//   setProfilePins(i);
//   delay(1000);


// }

// setProfilePins(0);


// setProfilePins(11);
// delay(3000);
// setProfilePins(15);
// delay(3000);
// setProfilePins(1);
// delay(3000);
}
