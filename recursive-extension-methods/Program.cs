using System;

public class Program
{

static void Main(string[] args){
    //Recursive
    int result = 1;
    for (int i = 1; i < 5; i++)
        result = result * 3;
        Console.WriteLine(result);
        Islemler instance = new();
        Console.WriteLine(instance.Expo(3,4));
    //Extension Methods
    string expression = "Hello World";
    bool sonuc = expression.CheckSpaces();
    Console.WriteLine(sonuc);
    int [] dizi = {9, 3, 6, 2, 1, 5};
    dizi.SortArray();
    dizi.WriteOnScreen();
    if(sonuc)
    {
        Console.WriteLine(expression.RemoveSpaces());
        Console.WriteLine(expression.MakeUpperCase());
        Console.WriteLine(expression.MakeLowerCase());
    }

}
}
public class Islemler{
    public int Expo(int sayi, int us)
    {
        if (us < 2)
            return sayi;
        return Expo(sayi,us-1)*sayi;
    }
}

public static class Extension
{
    public static bool CheckSpaces(this string param)
    {
        return param.Contains(" ");
    }

    public static string RemoveSpaces(this string param)
    {
        string[] arr = param.Split(" ");
        return string.Join("", arr);
    }

    public static string MakeUpperCase(this string param)
    {
        return param.ToUpper();
    }
    public static string MakeLowerCase(this string param)
    {
        return param.ToLower();
    }   
    public static int[] SortArray(this int[] param)
    {
        Array.Sort(param);
        return param;
    }
    public static void WriteOnScreen(this int[] param)
    {
        foreach(int item in param)
        Console.WriteLine(item);
    }
}


//For Loop Power of a Number

/* long firstNumber; // Describe the first number
int secondNumber; // Describe the second number
firstNumber = Convert.ToInt32(Console.ReadLine()); // Take the first number from the user
secondNumber = Convert.ToInt32(Console.ReadLine()); // Take the second number from the user

long temp = firstNumber;

for (int i = 1; i < secondNumber; i++)
{
    Console.Write(firstNumber + " * " + temp + " =  ");
    firstNumber *= temp;
}
 */



// Recursive Power of a Number
