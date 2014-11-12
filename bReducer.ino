#define ANALOG_SENSOR_PIN  A0
#define DIGITAL_SENSOR_PIN 3

void setup()
{
  Serial.begin(9600);
}

void loop()
{
  Serial.println(analogRead(ANALOG_SENSOR_PIN));
  delay(100);
}
