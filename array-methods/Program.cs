int[] array = new int[] { 5, 2, 4, 1, 3 };
//*** Unorganized Array ***
Console.WriteLine("Unorganized Array:");
foreach (int i in array)
{
    Console.Write(i + " ");
}
Console.WriteLine();
//*** Organized Array ***
Console.WriteLine("Organized Array:");
Array.Sort(array);
foreach (int i in array)
{
    Console.Write(i + " ");
}
Console.WriteLine();
//*** Reverse Array ***
Console.WriteLine("Reverse Array:");
Array.Reverse(array);
foreach (int i in array)
{
    Console.Write(i + " ");
}
Console.WriteLine();
//*** IndexOf Array ***
Console.WriteLine("Index of 3: " + Array.IndexOf(array, 3));
//*** Resize Array ***
Array.Resize(ref array, 10);
Console.WriteLine("Resize Array:");
foreach (int i in array)
{
    Console.Write(i + " ");
}
Console.WriteLine();
//*** Clear Array ***
Console.WriteLine("Clear Array:");
Array.Clear(array, 0, array.Length);
foreach (int i in array)
{
    Console.Write(i + " ");
}
