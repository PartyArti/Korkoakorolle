using System;

namespace korkoakorolle
{
        class Program
    {

        static double Alkupaaoma(double a)
        {
             double alkupaaoma = 0;
             Console.WriteLine("Syötä alkupääoma:");
            alkupaaoma = double.Parse(Console.ReadLine());
            return alkupaaoma;
        }

        static double Korko(double b)
        {
             double korko = 0;
             Console.WriteLine("Syötä vuosikorko prosentteina:");
            korko = double.Parse(Console.ReadLine());
            korko = korko*0.01;
            return korko;
        }

          static double Sijoitusaika(double c)
        {
             double sijaika = 0;
             Console.WriteLine("Syötä sijoitusaika vuosina:");
            sijaika = double.Parse(Console.ReadLine());
            return sijaika;
        }

          static double Kuukausisijoitus(double d)
        {
             double kksij = 0;
             Console.WriteLine("Syötä Kuukausisijoitus:");
            kksij = double.Parse(Console.ReadLine());
            return kksij;
        }


        static void Main(string[] args)
        {
          double a=0,b=0,c=0,tuotto=0;
          //double a=0,b=0,c=0,d=0,tuotto=0;
          double alkupaaoma = Alkupaaoma(a);
          double korko =Korko(b);
          double sijaika = Sijoitusaika(c);
          //double kksij = Kuukausisijoitus(d);

            //K (t) = k(0)x(1+p)^t
            tuotto = alkupaaoma*(Math.Pow((1 + korko),sijaika));
            Console.WriteLine("Tuotto on: ");
            Console.WriteLine(tuotto);
        }
    }
}
