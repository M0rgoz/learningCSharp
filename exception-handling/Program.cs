// See https://aka.ms/new-console-template for more information
try
{
    Console.WriteLine("Enter an Integer: ");
    int num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Your Integer is: " + num);    
}
catch(Exception ex){
Console.WriteLine("Err: " + ex.Message.ToString());
}
finally
{
Console.WriteLine("Task Completed");        
}


try
{
    //int a = int.Parse(null);
    //int a = int.Parse("test");
    int a = int.Parse("-20000000000");
}
catch (ArgumentNullException ex)
{
    Console.WriteLine("Boş değer girdiniz.");
    Console.WriteLine(ex);
}
catch (FormatException ex)
{
    Console.WriteLine("Format tipi hatalı.");
    Console.WriteLine(ex);
}
catch (OverflowException ex)
{
    Console.WriteLine("Çok büyük ya da çok küçük miktarda bir veri girdiniz.");
    Console.WriteLine(ex);
}
finally{
    Console.WriteLine("İşlem Başarıyla Tamamlandı");
}