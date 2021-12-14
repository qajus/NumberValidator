using System;

namespace NumberValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę całkowitą");
            var numberToValid = Getnumber();

            if(numberToValid % 2 ==0)
            {
                Console.WriteLine("Podana liczba jest parzysta");
            }
            else
            {
                Console.WriteLine("Podana liczbe jest nieparzysta");
            }

            Console.ReadLine();
        }

        private static int Getnumber()
        {
            while(true)
            {
                if(!int.TryParse(Console.ReadLine(), out int number))
                {
                    Console.WriteLine("Podany ciag naków nie jest liczbą całkowita. Podaj liczbe całkowita");
                    continue;
                }
                return number;
            }
        }
    }
}
