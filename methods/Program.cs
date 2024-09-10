using System;
using System.IO;
using System.Linq;
//FORGOT ONE?

class program{

static void Main(string[] args){

    int a = 2;
    int b = 3;
    Console.WriteLine(a+b);
    Console.WriteLine("Int Toplamı: ");
    Console.WriteLine(Topla(a,b));

    Methods methods = new Methods();
    methods.WriteToConsole(Topla(a,b).ToString());
    methods.WriteToConsole(Convert.ToString(Topla(a,b)));
}


static int Topla(int deger1, int deger2){
    return deger1 + deger2;}
}

 class Methods{
    public void WriteToConsole(string data){
        Console.WriteLine(data);
    }
}