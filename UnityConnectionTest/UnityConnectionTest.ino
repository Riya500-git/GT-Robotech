#define SW 2
#define joy_x A0
#define joy_y A1

void setup() {
  // put your setup code here, to run once:
  Serial.begin(19200);
  pinMode(SW, INPUT_PULLUP);
  pinMode(joy_x, INPUT);
  pinMode(joy_y, INPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
  float joy_rx = analogRead(joy_x);
  float joy_ry = analogRead(joy_y);

  joy_rx = map(joy_rx, 1, 1024, -500, 500);
  joy_ry = map(joy_ry, 1, 1024, -500, 500);

  Serial.print(joy_rx);
  Serial.print(",");
  Serial.print(joy_ry);
  Serial.print(",");
  Serial.println(!digitalRead(SW));
}
