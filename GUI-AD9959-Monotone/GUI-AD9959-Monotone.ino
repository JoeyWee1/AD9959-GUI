/*
Set 4 distinct frequencies on the AD9959 using the C# GUI
*/


# include <SPI.h>


const int CSB = 10;
const int IO_UPDATE = 4;
const int RESET = 2;

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


void setup() {
  // put your setup code here, to run once:
pinMode(CSB,1);
pinMode(RESET,1);
pinMode(IO_UPDATE,1);

// Set default values
digitalWrite(CSB,1);
digitalWrite(RESET,0);
digitalWrite(IO_UPDATE,0);

//Start serial communication between computer and Arduino
Serial.begin(9600);


//Start SPI transaction:
SPI.begin();
SPI.beginTransaction(SPISettings(125000, MSBFIRST, SPI_MODE0)); 
// SPI clock: 125kHz for voltage to reach 3.3V in level shifters
// SDIO_0 since we are using 2 wire mode. 

//Reset Device:
digitalWrite(RESET,1);
digitalWrite(RESET,0);
delay(1);

//Set PLL to 20x 

digitalWrite(CSB, LOW);
SPI.transfer(0x01); //function register 1 (FR1)
SPI.transfer(B11010000); //Set PLL to 20 and VCO to 1
SPI.transfer(B00000000);
SPI.transfer(0x00); 
digitalWrite(IO_UPDATE, HIGH);
digitalWrite(IO_UPDATE, LOW);
digitalWrite(CSB, HIGH); //Disable slave select
delay(1); // 1 millisecond delay for PLL to be activated

// //Set frequency of 20MHz
setChannelFrequency(0, 20000000);
digitalWrite(IO_UPDATE,HIGH);
digitalWrite(IO_UPDATE,LOW);


}

void loop() {

//To read incoming Serial data from C# GUI
if (Serial.available()) {
  String input = Serial.readStringUntil('\n');  // Get full command


  if (input.startsWith("FREQ")) {
    input.remove(0, 5); // Remove "FREQ," part
    uint32_t freqs[4] = {0}; //Create an array to store the 4 frequencies

    // Split the string into frequencies
    int index = 0; //index to track which channel we're storing

    //Parse 4 comma separated frequencies
    while (input.length() > 0 && index < 4) { //There is still text left in input string and have not filled 4 frequencies
      int commaIndex = input.indexOf(','); //Find the position of the next comma
      String part; //Store each number we extract
      if (commaIndex != -1) {
        //Extract the value before the comma
        part = input.substring(0, commaIndex); // The substring starts from 0 position and continues to length of commaIndex
        //Remove the value and comma from the input string
        input = input.substring(commaIndex + 1);  // The substring starts at the specified comma position +1 and continues till end of string
      } else {
        part = input;
        input = ""; //input.length() = 0
      }
      freqs[index++] = part.toInt(); //Store frequencies by converting string to integer
    }

    // Set each channel frequency
    for (int ch = 0; ch < 4; ch++) { //Loop runs 4 times for the 4 channels
      setChannelFrequency(ch, freqs[ch]);
    }

    // Apply settings
    digitalWrite(CSB,LOW);
    digitalWrite(IO_UPDATE, HIGH);
    digitalWrite(IO_UPDATE, LOW);
    digitalWrite(CSB,HIGH);
  }
}

}
