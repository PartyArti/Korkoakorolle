using System;

namespace korkoakorolle
{
    class Program
    {

        static void Alkupaaoma()
        {
             int alkupaaoma = 0;
             Console.WriteLine("Syötä alkupääoma:");
            alkupaaoma = int.Parse(Console.ReadLine());
        }

        static void Korko()
        {
             int korko = 0;
             Console.WriteLine("Syötä vuosikorko:");
            korko = int.Parse(Console.ReadLine());
        }

          static void Sijoitusaika()
        {
             int sijoitusaika = 0;
             Console.WriteLine("Syötä sijoitusaika vuosina:");
            sijoitusaika = int.Parse(Console.ReadLine());
        }

          static void Kuukausisijoitus()
        {
             int kksijoitus = 0;
             Console.WriteLine("Syötä vuosikorko:");
            kksijoitus = int.Parse(Console.ReadLine());
        }


        static void Main(string[] args)
        {
            Alkupaaoma();
            Korko();
            Sijoitusaika();
            Kuukausisijoitus();
        }
    }
}
