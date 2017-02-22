// Includes the Servo and lcd library
#include <Servo.h>. 
#include <LiquidCrystal.h>

//Defines lcd pins
LiquidCrystal lcd(7, 6, 5, 4, 3, 2);

// Defines Tirg and Echo pins of the Ultrasonic Sensor
const int trigPin = 10;
const int echoPin = 11;

//Defines piezo pin
const int piezoPin = 8;

// Variables for the duration the distance and Angle
long duration;
int distance;
int Angle;

int notes[] = {262, 462, 862, 1662, 3262}; // Enter here the notes you like

Servo myServo; // Creates a servo object to controll the servo motor

void setup() {
  lcd.begin(16, 2); //Initializing the intarface lcd Display, and specifies the dimensions (width and height) of the display
  pinMode(trigPin, OUTPUT); // Sets the trigPin as an Output
  pinMode(echoPin, INPUT); // Sets the echoPin as an Input
  Serial.begin(9600); //Begin a sirial communication with Arduino Ide
  myServo.attach(12); // Defines on which pin is the servo motor attached
  pinMode(piezoPin, OUTPUT);
}

void loop() {
  
  // rotates the servo motor from 15 to 165 degrees
  for(int i = 15; i <= 165; i++){  
    Angle=i;
    myServo.write(Angle);
    distance = calculateDistance();// Calls a function for calculating the distance measured by the Ultrasonic sensor for each degree
    beep(); //beep sequence
    lcdprint();    //lcd print 
    Sprint(); //Serial Monitor print
  }
  // Repeats the previous lines from 165 to 15 degrees
  for(int i = 165; i > 15; i--){  
    Angle=i;
    myServo.write(i);
    distance = calculateDistance();
    beep();
    lcdprint();
    Sprint();
  }
}

// Function for calculating the distance measured by the Ultrasonic sensor
int calculateDistance(){ 
  //cleat the trigPin to begin the measurment
  digitalWrite(trigPin, LOW); 
  delayMicroseconds(2);
  // Sets the trigPin on HIGH state for 10 micro seconds
  digitalWrite(trigPin, HIGH); 
  delayMicroseconds(10);
  digitalWrite(trigPin, LOW);
  duration = pulseIn(echoPin, HIGH); // Reads the echoPin, returns the sound wave travel time in microseconds
  //U(m/s)=dX(m)/dT(s) 
  //in this case Duration(time)= 2*Distance/SpeedOfSound=> 
  //Distance=SpeedOfSound*Duration/2
  // In dry air at 20 °C, the speed of sound is 343.2 m/s or 0.003432 m/Microsecond or 0,03434 cm/Microseconds
  distance= duration*0.034/2; 
  return distance;
}

void beep(){
  if(distance > 40){  // if the distance is longer than 40 cm dont make noise
    noTone(piezoPin);
    delay(10);
    noTone(piezoPin);
    delay(30);
  }
  else if (distance <= 40 && distance > 30){ //if the distance is between 30 and 40 cm 
    tone(piezoPin, notes[1]); // play the 1st note from the array for 10 milliseconds
    delay(10); 
    noTone(piezoPin);// then stop and wait for 30 millisecs
    delay(30);
  }
  else if (distance <= 30 && distance > 20){
    tone(piezoPin,notes[2]);
    delay(10);
    noTone(piezoPin);
    delay(30);
  }
  else if (distance <= 20 && distance > 10){
    tone(piezoPin,notes[3]);
    delay(10);
    noTone(piezoPin);
    delay(30);
  }
  else {
    tone(piezoPin,notes[4]);
    delay(10);
    noTone(piezoPin);
    delay(30);
  }
}
void lcdprint(){
  lcd.clear(); //Clear the display from previus data
  lcd.setCursor(0, 0); // set the cursor to column 0, line 0
  lcd.print("Angle: "); // print some text
  lcd.print(Angle);
  lcd.print("°");
  lcd.setCursor(0, 1);  // move the cursor to the second line
  lcd.print("Distance: ");
  lcd.print(distance);
  lcd.print(" cm");
}

void Sprint(){
  Serial.print(Angle); // Sends the current degree into the Serial Port
  Serial.print(","); // Sends addition character right next to the previous value needed later in the Processing IDE for indexing
  Serial.print(distance); // Sends the distance value into the Serial Port
  Serial.print("."); // Sends addition character right next to the previous value needed later in the Processing IDE for indexing
  }

