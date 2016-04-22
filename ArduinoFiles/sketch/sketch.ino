#include <PinChangeInt.h>
 
#define AIL_IN_PIN 3
#define ELE_IN_PIN 4
#define THR_IN_PIN 2
#define RUD_IN_PIN 5
#define AUX_IN_PIN 6
 
 
#define AIL_FLAG 1
#define ELE_FLAG 2
#define THR_FLAG 4
#define RUD_FLAG 8
#define AUX_FLAG 16
 
volatile uint8_t bUpdateFlagsShared;
 
volatile uint16_t unAIL_InShared;
volatile uint16_t unELE_InShared;
volatile uint16_t unTHR_InShared;
volatile uint16_t unRUD_InShared;
volatile uint16_t unAUX_InShared;
 
uint32_t ulAIL_Start;
uint32_t ulELE_Start;
uint32_t ulTHR_Start;
uint32_t ulRUD_Start;
uint32_t ulAUX_Start;
  int minJoy = 1076;
  int divJoy = 38;
  int maxJoy = 1936;
  int count = 0;
  String output = "";
  
  int16_t Rud = 0;
  int16_t Ail = 0;
  int16_t Thr = 0;
  int16_t Ele = 0;
  int16_t Aux = 0;
 
void setup()
{
  Serial.begin(9600);

  
  PCintPort::attachInterrupt(AIL_IN_PIN, isr_AIL, CHANGE); 
  PCintPort::attachInterrupt(ELE_IN_PIN, isr_ELE, CHANGE); 
  PCintPort::attachInterrupt(THR_IN_PIN, isr_THR, CHANGE);
  PCintPort::attachInterrupt(RUD_IN_PIN, isr_RUD, CHANGE);
  PCintPort::attachInterrupt(AUX_IN_PIN, isr_AUX, CHANGE);
}
 
void loop()
{
  static uint16_t unAIL_In;
  static uint16_t unELE_In;
  static uint16_t unTHR_In;
  static uint16_t unRUD_In;
  static uint16_t unAUX_In;
  // local copy of update flags
  static uint8_t bUpdateFlags;
 
  if (bUpdateFlagsShared)
  {
    noInterrupts();
 
    bUpdateFlags = bUpdateFlagsShared;
 
    if (bUpdateFlags & AIL_FLAG)
    {
      unAIL_In = unAIL_InShared;
    }
    if (bUpdateFlags & ELE_FLAG)
    {
      unELE_In = unELE_InShared;
    }
    if (bUpdateFlags & THR_FLAG)
    {
      unTHR_In = unTHR_InShared;
    }
    if (bUpdateFlags & RUD_FLAG)
    {
      unRUD_In = unRUD_InShared;
    }
    if (bUpdateFlags & AUX_FLAG)
    {
      unAUX_In = unAUX_InShared;
    }
 
    bUpdateFlagsShared = 0;
 
     bUpdateFlags = 0;
    interrupts();
  
    if (count == 10) {
      output = String(Thr/10) + ",";
      output += String(Rud/10) + ",";
      output += String(Ele/10) + ",";
      output += String(Ail/10) + ",";
      output += String(Aux/10) + "\n";
    Serial.print(output);
    count = 0;
    Rud = 0;
    Ail = 0;
    Thr = 0;
    Ele = 0;
    Aux = 0;
    output = "";
    } else {
      Thr+=unTHR_In;
      Rud+=unRUD_In;
      Ele+=unELE_In;
      Ail+=unAIL_In;
      Aux+=unAUX_In;
      count++;
    }
  }  
}
 
 
void isr_AIL()
{
  if(digitalRead(AIL_IN_PIN) == HIGH)
  { 
    ulAIL_Start = micros();
  }
  else
  {
    unAIL_InShared = (uint16_t)(micros() - ulAIL_Start);
    bUpdateFlagsShared |= AIL_FLAG;
  }
}
 
void isr_ELE()
{
  if(digitalRead(ELE_IN_PIN) == HIGH)
  { 
    ulELE_Start = micros();
  }
  else
  {
    unELE_InShared = (uint16_t)(micros() - ulELE_Start);
    bUpdateFlagsShared |= ELE_FLAG;
  }
}
 
void isr_THR()
{
  if(digitalRead(THR_IN_PIN) == HIGH)
  { 
    ulTHR_Start = micros();
  }
  else
  {
    unTHR_InShared = (uint16_t)(micros() - ulTHR_Start);
    bUpdateFlagsShared |= THR_FLAG;
  }
}
 
void isr_RUD()
{
  if(digitalRead(RUD_IN_PIN) == HIGH)
  { 
    ulRUD_Start = micros();
  }
  else
  {
    unRUD_InShared = (uint16_t)(micros() - ulRUD_Start);
    bUpdateFlagsShared |= RUD_FLAG;
  }
}
 
void isr_AUX()
{
  if(digitalRead(AUX_IN_PIN) == HIGH)
  { 
    ulAUX_Start = micros();
  }
  else
  {
    unAUX_InShared = (uint16_t)(micros() - ulAUX_Start);
    bUpdateFlagsShared |= AUX_FLAG;
  }
}
