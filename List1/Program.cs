using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        List<string> davetliler = new List<string> 
        { "Bülent Ersoy", "Ajda Pekkan", "Ebru Gündeş", "Hadise", "Hande Yener", "Tarkan", "Funda Arar", "Demet Akalın" };
        //Davetli listesi oluşturuldu.

        Console.WriteLine("Davetli Listesi:"); //Davetlileri foreach kullanarak tek tek yazdırıyoruz.
        foreach (string davetli in davetliler)
        { 
            Console.WriteLine(davetli);
        }


    }
}

