using System;

namespace lab3ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Ex 3
            Scrieti o functie care va determina daca un numar este sau nu patrat perfect. 
            Apelati-o si afisati-i rezultatu
            */
            Console.WriteLine("Introduceti numarul: ");
            int n = int.Parse(Console.ReadLine());


            if (PatratPerfect(n) == true)
            {
                Console.WriteLine($"{n} este patrat perfect");
            }
            else
            {
                Console.WriteLine($"{n} nu este patrat perfect");
            }

            static bool PatratPerfect(int n)
            {
                var radical = Math.Sqrt(n);
                if(radical%1 == 0)
                {
                    return true;
                }
                return false;
            }
        }
    }
}
