// See https://aka.ms/new-console-template for more information
int a = 12;
double b = (double)a;
Console.WriteLine((b).ToString("F2"));

byte c = (byte)a;
Console.WriteLine(c);

int d = 257;
Console.WriteLine((d).ToString("F2"));

float f = 3.9f;

int g = (int)f;
Console.WriteLine(g);

double h = 3.99;
double i = Math.Round(h);

Console.WriteLine(i);

// To.String methods

double dd = 35.6;
double mmm = Math.Round(dd);
string str = mmm.ToString();
double nnn = double.Parse(str);

Console.WriteLine("NNN:" + nnn);

// System.Convert methods


// Parse Method


char foo = '0';
double testy = (double)foo;
Console.WriteLine(testy);

Console.WriteLine((testy).ToString("F1"));

// **EXPLICIT CONVERSION TEST**

decimal dec = 10.5M;
float flyes = (float)dec;
Console.WriteLine(flyes);

string toByte = "100";
byte by = Convert.ToByte(toByte);
Console.WriteLine(by);
long longy = 1000000000000000000;
int inty = (int)longy;
Console.WriteLine(inty);
string stry = "5/10/2016";
/*
byte byty = Convert.ToByte(stry);
Console.WriteLine(byty);
decimal decy = decimal.Parse(stry);
Console.WriteLine(decy);
*/
int inty2 = Convert.ToInt32(stry);

string transform = inty2.ToString();
DateTime dt = Convert.ToDateTime(transform);
Console.WriteLine(dt);