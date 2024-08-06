// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Integers
byte Cracker11 = 0;
sbyte Cracker12 = 0;

short Cracker13 = 0;
ushort Cracker14 = 0;


int Cracker = 0;
Int16 Cracker2 = 0; 
Int32 Cracker3 = 0;
Int64 Cracker15 = 0;
uint Cracker7 = 0;

long Cracker4 = 0;
ulong Cracker16 = 0;

//Real numbers
float Cracker5 = 0;
double Cracker6 = 0;
decimal Cracker10 = 0;

//Text or String based
string Cracker1 = "TESTING";
char Cracker9 = 'T';

//Boolean
bool Cracker8 = true;

DateTime dt = DateTime.Now;
    Console.WriteLine(dt);

object o1 = "Hello";
object o2 = 22;
object o3 = 22.22;
object o4 = true;
object o5 = 'A';

//string stuff
string str1 = "John";
string str2 = "Doe";
string str3 = str1 + " " + str2;
Console.WriteLine(str3);

//Integer stuff

int num1 = 10;
int num2 = 20;
int num3 = num1 * num2;
Console.WriteLine(num3);

//boolean
bool b1 = 10 > 5; //true
bool b2 = 10 < 5; //false

//Variable Changes
string str4 = "20";
int num4 = 10;
int num5 = num4 + int.Parse(str4);
Console.WriteLine(num5);

string str5 = str4+num4.ToString();
Console.WriteLine(str5);

int num6 = num4 + Convert.ToInt32(str4);
Console.WriteLine(num6);

//DateTime
string datetime = DateTime.Now.ToString("dd.MM.yyyy");
Console.WriteLine(datetime);

string datetime1 = DateTime.Now.ToString("dd/MM/yyyy");
Console.WriteLine(datetime1);

string timeHourMinute = DateTime.Now.ToString("HH.mm");
Console.WriteLine(timeHourMinute);


