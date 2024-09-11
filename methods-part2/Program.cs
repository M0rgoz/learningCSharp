using System.ComponentModel;

class Program {
    static void Main(string[] args) {
        string sayi = "999";
        bool sonuc = int.TryParse(sayi, out int outSayi);
        if(sonuc){
            Console.WriteLine("Başarılı");
            Console.WriteLine(outSayi);
            }else{
            Console.WriteLine("Başarısız");
    }

    Methods methods = new Methods();
    methods.Topla(4, 5, out int toplam);
    Console.WriteLine(toplam);
    methods.WriteToConsole("Merhaba");
    methods.WriteToConsole("Merhaba", 5);
    methods.WriteToConsole("Merhaba", 5, true);
}
}

class Methods{
    public void Topla(int a, int b, out int toplam){
        toplam= a + b;
    }

    // Method Overloading
    public void WriteToConsole(string data){
        Console.WriteLine(data);
    }
    public void WriteToConsole(string data, int intData, bool boolData){
        Console.WriteLine(data + intData + boolData);
    }
    public void WriteToConsole(string data, int intData){
        Console.WriteLine(data + intData);
    }
}