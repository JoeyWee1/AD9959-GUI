// Single Monotone. This code outputs a single frequency from channel 0.


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


//Enable Channel 0 only:
digitalWrite(CSB,0);
SPI.transfer(0x00);
SPI.transfer(0x10);
digitalWrite(CSB,1);

//Set monotone: 225MHz

digitalWrite(CSB,0);
SPI.transfer(0x04);
SPI.transfer(0x73);
SPI.transfer(0x33);
SPI.transfer(0x33);
SPI.transfer(0x33);
digitalWrite(IO_UPDATE,1);
digitalWrite(IO_UPDATE,0);
digitalWrite(CSB,1);

}

void loop() {
  // put your main code here, to run repeatedly:

}
