int min = 1100;
int max = 1900;
String text = "";

int vals[6] = {1500,1500,1500,1500,1500,1500};
int scale[6] = {20,40,50,20,10,30};
bool up[6] = {true,true,true,true,true,true};

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);  
}

void loop() {
  text = "";
  for (int i=0;i<6;i++)
  {
    text = text + String(vals[i]);
    if (i < 5)
    text = text + ", ";

    if (vals[i] >= max - scale[i])
      up[i] = false;
    if (vals[i] <= min + scale[i])
      up[i] = true;

    if (up[i] == true)
      vals[i] = vals[i] + scale[i];
    else
      vals[i] = vals[i] - scale[i];
  }
  
Serial.println(text);
delay(50);
}
