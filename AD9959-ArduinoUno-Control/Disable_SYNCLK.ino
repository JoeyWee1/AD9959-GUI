// Disable SYNCLK so that we check there is an established communication between Arduino and AD9959


# include <SPI.h>


const int CSB = 10;
const int IO_UPDATE = 4;
const int RESET = 2;



void setup() {
  // put your setup code here, to run once:
pinMode(CSB,1);
pinMode(RESET,1);
pinMode(IO_UPDATE,1);

// Set default values
digitalWrite(CSB,1);
digitalWrite(RESET,0);
digitalWrite(IO_UPDATE,0);

//Start SPI transaction:
SPI.begin();
SPI.beginTransaction(SPISettings(125000, MSBFIRST, SPI_MODE0)); 
// SPI clock: 125kHz for voltage to reach 3.3V in level shifters
// SDIO_0 since we are using 2 wire mode. 

//Reset Device:
digitalWrite(RESET,1);
digitalWrite(RESET,0);
delay(1);

// Turn off syn_clk

digitalWrite(CSB,0);
SPI.transfer(0x01);
SPI.transfer(0x00);
SPI.transfer(0x00);
SPI.transfer(B00100000);
digitalWrite(IO_UPDATE,1);
digitalWrite(IO_UPDATE,0);
digitalWrite(CSB,1);

}

void loop() {
  // put your main code here, to run repeatedly:

}
