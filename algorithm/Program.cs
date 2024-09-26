//Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
/* Console.WriteLine("Enter a number: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("Write" + number + "numbers: ");
int[] numbers = new int[number];
for (int i = 0; i < number; i++)
{
    numbers[i] = int.Parse(Console.ReadLine());
}
foreach (int num in numbers)
{
    if(num % 2 == 0 && num > 0)
    Console.WriteLine(num);
} */


//Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
/* Console.WriteLine("Enter first number: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Enter second number: ");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Write " + n + " numbers: ");
int[] numbers = new int[n];
for (int i = 0; i < n; i++)
{
    numbers[i] = int.Parse(Console.ReadLine());
}
foreach (int num in numbers)
{
    if(num % m == 0)
    Console.WriteLine(num);
} */

//Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
/* Console.WriteLine("Enter a number: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("Write " + number + " words: ");
string[] words = new string[number];
for (int i = 0; i < number; i++)
{
    words[i] = Console.ReadLine();
}
Array.Reverse(words);
foreach (string word in words)
{
    Console.WriteLine(word);
}
 */


// Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
 /* Console.WriteLine("Enter a sentence: ");
 string sentence = Console.ReadLine();
    string[] words = sentence.Split(' ');
    Console.WriteLine("Number of words in the sentence: " + words.Length);
    string sentenceWithNoSpace = sentence.Replace(" ", "");
    Console.WriteLine("Number of characters in the sentence: " + sentenceWithNoSpace.Length); */