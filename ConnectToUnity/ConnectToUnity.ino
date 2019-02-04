//pins
int analogPin0 = 0;
int analogPin1 = 1;
int analogPin2 = 2;

//vars
bool didReceive = false;

void setup() {
  pinMode(LED_BUILTIN, OUTPUT);
  digitalWrite(LED_BUILTIN, LOW);
  Serial.begin(57600);
  
  while (!Serial);
  Serial.println("found serial");
}

void loop() {
  if (didReceive) {
    digitalWrite(LED_BUILTIN, HIGH);
  }
}

void serialEvent() {
      didReceive = true;
}
