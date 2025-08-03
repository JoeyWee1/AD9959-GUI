// 2 level modulation on channel 0. 


# include <SPI.h>


const int CSB = 10;
const int IO_UPDATE = 4;
const int RESET = 2;
const int P0 = 7; //P0 is connected to channel 0 in 2 level modulation



void setup() {
  // put your setup code here, to run once:

// Set pinmodes:
pinMode(CSB,1);
pinMode(RESET,1);
pinMode(IO_UPDATE,1);
pinMode(P0,1);

// Set default values
digitalWrite(CSB,1);
digitalWrite(RESET,0);
digitalWrite(IO_UPDATE,0);
digitalWrite(P0,0);  //Default to frequency from FTW 0x04

//Start SPI transaction:
SPI.begin();
SPI.beginTransaction(SPISettings(125000, MSBFIRST, SPI_MODE0)); 
// SPI clock: 125kHz for voltage to reach 3.3V in level shifters
// SDIO_0 since we are using 2 wire mode. s


//Reset Device:
digitalWrite(RESET,1);
digitalWrite(RESET,0);
delay(1);



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


//Set PLL to 20x and pin 0 active

digitalWrite(CSB, LOW);
SPI.transfer(0x01); //function register 1 (FR1)
SPI.transfer(B11010000); //Set PLL to 20 and VCO to 1
SPI.transfer(B00000000); //The bits FR1[14:12] does not matter for 2 level modulation
//Modulation level bits FR1[9:8] is set to 00 for 2 level modulation
//No RU and RD needed so FR1[11:10] is set to [00]
SPI.transfer(0x00); 
digitalWrite(IO_UPDATE, HIGH);
digitalWrite(IO_UPDATE, LOW);
digitalWrite(CSB, HIGH); //Disable slave select
delay(1); // 1 millisecond delay for PLL to be activated


//Set frequency 1: FTW 0x04:
digitalWrite(CSB,0); 
SPI.transfer(0x04);
SPI.transfer(0x0A); // Frequency: 20MHz
SPI.transfer(0xAA);
SPI.transfer(0xAA);
SPI.transfer(0xAA);
// SPI.transfer(0x73);//frequency 225MHz
// SPI.transfer(0x33);
// SPI.transfer(0x33);
// SPI.transfer(0x33);
digitalWrite(IO_UPDATE,1);
digitalWrite(IO_UPDATE,0);
digitalWrite(CSB,1);

//Set frequency 2: Channel Word 1. 0x0A
digitalWrite(CSB,0);
SPI.transfer(0x0A);
SPI.transfer(0x0F);  // Frequency: 30MHz
SPI.transfer(0x5C);
SPI.transfer(0x28);
SPI.transfer(0xF6);
digitalWrite(IO_UPDATE,1);
digitalWrite(IO_UPDATE,0);
digitalWrite(CSB,1);



}

void loop() {
  // put your main code here, to run repeatedly:

digitalWrite(P0,1); //Register 0x0A is chosen
delay(1000);
digitalWrite(P0,0); //Register 0x04 is chosen
delay(1000);

}
