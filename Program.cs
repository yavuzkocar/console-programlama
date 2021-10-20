using System;

namespace console_programlama
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("isminizi giriniz");
            String name = Console.ReadLine();
            Console.WriteLine("soyisminizi giriniz");
            String surname = Console.ReadLine();
            Console.WriteLine("Merhaba " + name + " " + surname);
        }
    }
}
