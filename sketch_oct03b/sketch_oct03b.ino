// File: sketch_oct03b.ino
// Description: The simpiest sketch
// Environment: Arduino IDE
//
// MIT License
// Copyright (c) 2017 Valentyn N Sichkar
// github.com/sichkar-valentyn
//
// Reference to:
// [1] Valentyn N Sichkar. C# program to communicate with Arduino // GitHub platform [Electronic resource]. URL: https://github.com/sichkar-valentyn/C_Sharp_Windows_Form_data_transceiver (date of access: XX.XX.XXXX)

int b;

void setup() {
  // put your setup code here, to run once:
    pinMode(7,OUTPUT);
    Serial.begin(9600);
    delay(1000);
}

void loop() {
  // put your main code here, to run repeatedly:
  if(Serial.available() > 0) {
  b = Serial.read();
  if(b == 'r') {digitalWrite(7,HIGH); Serial.println("   LED ON");}
  if(b == 't') {digitalWrite(7,LOW); Serial.println("  LED OFF");}

  if(b == 'w') {
  Serial.println("Type the number you want to double");
  while (Serial.available() == 0) {}
  int i = Serial.read() - 48;
  while (Serial.available() == 0) {}
  int j = Serial.read() - 48;
  i = i * 10;
  i = i + j;
  Serial.println(i*i);
  delay(1000);
  }
  }
}
