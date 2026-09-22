using CatLife12E.Model;

namespace CatLife12E
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat margit = new Cat();
            margit.Nev = "Margit";
            margit.Suly = 4.5;
            margit.EhesE = true;

            //3par.
            Cat pamacs = new Cat("Pamacs", 6.8, false);

            //2p
            Cat cirmi = new Cat("Cirmi", 2.7);
            Console.WriteLine("Kiindulási állapot:");
            Console.WriteLine(margit.ToString());
            Console.WriteLine(pamacs.ToString());
            Console.WriteLine(cirmi.ToString());

            Console.WriteLine("Etetés utáni állapot: ");
            margit.Eszik(1.5);
            pamacs.Eszik(1.5);
            cirmi.Eszik(1.5);
            Console.WriteLine(margit.ToString());
            Console.WriteLine(pamacs.ToString());
            Console.WriteLine(cirmi.ToString());

            Console.WriteLine("Tesióra utáni állapot:");
            margit.Szalad();
            pamacs.Szalad();
            cirmi.Szalad();
            Console.WriteLine(margit.ToString());
            Console.WriteLine(pamacs.ToString());
            Console.WriteLine(cirmi.ToString());
        }
    }
}
