int hour = DateTime.Now.Hour;
Console.WriteLine("Greeting: ");
if(hour>=5)
{
    Console.WriteLine("Good Morning");
}
else if(hour>=12)
{
    Console.WriteLine("Good Afternoon");
}
else if(hour>=17)
{
    Console.WriteLine("Good Evening");
}
else
{
    Console.WriteLine("Good Night");
};

string sonuc = hour >= 5 ? "Good Morning" : hour >= 12 ? "Good Afternoon" : hour >= 17 ? "Good Evening" : "Good Night";
Console.WriteLine("One Line: " + sonuc);