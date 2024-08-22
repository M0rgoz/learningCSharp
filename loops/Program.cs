//oddSum and evenSum using for loop
int oddSum = 0;
int evenSum = 0;
for (int i = 1; i <= 10; i++)
{
    if(i%2 == 1)
        oddSum += i;
    else
        evenSum += i;
}
Console.WriteLine("Odd sum: " + oddSum);
Console.WriteLine("Even sum: " + evenSum);

//break and continue
for (int i = 1; i <= 15; i++)
{
    if(i == 3)
    break;
    Console.WriteLine(i);
}

for (int i = 1; i <= 20; i++)
{
    if(i == 3)
    continue;
    Console.WriteLine(i);
}