using System.Diagnostics.CodeAnalysis;

/*
string[] colors = new string[5];
string[] fruits = { "Apple", "Banana", "Cherry" };
int[] dizi;
dizi = new int[5];

Console.WriteLine(fruits[1]);
Console.WriteLine(dizi[1]);
Console.WriteLine(colors[1]);
*/

// Loops with Arrays
// Calculates the average of the values in the array
Console.WriteLine("Type in how many values you want to have in the array: ");
int arrayLength = int.Parse(Console.ReadLine());
int[] numbers = new int[arrayLength];
for (int i = 0; i < arrayLength; i++)
{
    Console.Write("Lütfen {0}. sayıyı girin:", i+1);
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}

int sum = 0;
foreach (var number in numbers)
{
   sum += number; 
}
Console.WriteLine("The sum of the numbers: " + sum);

Console.WriteLine("The average of the numbers: " + sum / arrayLength);

/*int[] sayiDizisi = new int[20];
int toplam = 0;
for (int i = 0; i < sayiDizisi.Length; i++)
  {
    Console.Write("Lütfen {0}. sayıyı girin:", i+1);
    sayiDizisi[i] = Convert.ToInt32(Console.ReadLine());
    toplam += sayiDizisi[i];
  }
double ortalama = toplam / 20;
Console.WriteLine("Sayıların ortalaması: " + ortalama);
Console.ReadLine();*/