int month = DateTime.Now.Month;
//Console.WriteLine(month);
//21.08.2024

//int month = 10;
switch (month)
{
    /*case 12 or 1 or 2:
        Console.WriteLine("Winter");
        break;*/

    case 12:
    case 1:
    case 2:
        Console.WriteLine("Winter");
        break;


    case 3 or 4 or 5:
        Console.WriteLine("Spring");
        break;
    case 6 or 7 or 8:
        Console.WriteLine("Summer");
        break;
    case 9 or 10 or 11:
        Console.WriteLine("Autumn (Fall)");
        break;
    default:
    break;
}