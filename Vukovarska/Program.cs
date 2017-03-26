using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vukovarska
{
    class Program
    {
        static void Main(string[] args)
        {
            int brojAutomobila, minimalanBrojLjudiUAutomobilu, brojLjudiUAutomobilu, brojacAutomobila=0;

            Console.WriteLine("Unesite broj automobila: ");
            brojAutomobila = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesite minimalan broj ljudi u automobilu: ");
            minimalanBrojLjudiUAutomobilu = int.Parse(Console.ReadLine());

            if (minimalanBrojLjudiUAutomobilu < 1 || minimalanBrojLjudiUAutomobilu > 5 || brojAutomobila < 1)
            {
                Console.WriteLine("Krivo unesen podatak.");
            }
            else
            {

                for (int i = 0; i < brojAutomobila; i++)
                {
                    Console.WriteLine("Unesite broj ljudi u " + (i + 1) + ". automobilu: ");
                    brojLjudiUAutomobilu = int.Parse(Console.ReadLine());
                    if (brojLjudiUAutomobilu < 1)
                    {
                        Console.WriteLine("Tko vozi automobil kad nema ljudi u njemu?!");
                        Console.WriteLine("Krivo unesen broj ljudi u automobilu.");
                    }
                    else if (brojLjudiUAutomobilu > 5)  //  pretpostavka da u svaki automobil moze najvise stati 5 ljudi
                    {
                        Console.WriteLine("Kako svi stanete u automobil?! To nije po propisima pa će Vas policija zaustaviti!");
                        Console.WriteLine("Krivo unesen broj ljudi u automobilu.");
                    }
                    else if (brojLjudiUAutomobilu >= minimalanBrojLjudiUAutomobilu)
                        brojacAutomobila++;
                }
                Console.WriteLine("Broj automobila koji su nastavili putovanje je " + brojacAutomobila + ".");
            }
        }
    }
}
