// Finding the average of the numbers from 1 to the number entered by the user
Console.WriteLine("Birden, belirlediğiniz sayıya kadar olan sayıların ortalamasını bulmak.");
Console.WriteLine("Bir sayı giriniz: ");
int girdi = int.Parse(Console.ReadLine());
int sayac = 1;
int toplam = 0;
while(sayac <= girdi){
    toplam += sayac;
    sayac++;
}
Console.WriteLine("Average: " + (toplam/girdi));


//Finding the average of the 2 numbers entered by the user
Console.WriteLine("İki sayının ortalamasını bulmak.");
Console.WriteLine("İlk sayıyı giriniz: ");
double num1 = double.Parse(Console.ReadLine());
Console.WriteLine("İkinci sayıyı giriniz: ");
double num2 = double.Parse(Console.ReadLine());
Console.WriteLine("Average: " + (num1 + num2) / 2);

// A-Z characters
char letters = 'a';
while (letters <= 'z'){
    Console.Write(letters);
    letters++;
}
Console.WriteLine();
// Foreach
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
foreach (var car in cars)
{
    Console.Write(car + ", ");
}