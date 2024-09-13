using System;

public class Program
{

static void Main(string[] args){
    //Recursive
    int result = 1;
    for (int i = 0; i < 5; i++){
        result = result * 3;
        Console.WriteLine(result);
        Islemler instance = new Islemler();
        Console.WriteLine(instance.Expo(3, 4));
    }
}
}
public class Islemler{
    public int Expo(int sayi, int us){
        if (us < 2){
            return sayi;
        }
        return sayi * Expo(sayi, us - 1);
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
