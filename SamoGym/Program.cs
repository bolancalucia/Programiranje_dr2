using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamoGym
{
    class Program
    {
        static void Main(string[] args)
        {
            int snagaDarka, snagaMirka, snagaSlavka;

            Console.WriteLine("Unesite snagu Darka: ");
            snagaDarka = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesite snagu Mirka: ");
            snagaMirka = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesite snagu Slavka: ");
            snagaSlavka = int.Parse(Console.ReadLine());

            int razlikaDIM = RazlikaDvijuSnaga(snagaDarka, snagaMirka),
                razlikaMIS = RazlikaDvijuSnaga(snagaMirka, snagaSlavka),
                razlikaDIS = RazlikaDvijuSnaga(snagaDarka, snagaSlavka);

            if (razlikaDIM < razlikaMIS && razlikaDIM < razlikaDIS)
            {
                if (snagaDarka > snagaMirka)
                    Console.WriteLine("Darko Mirko");
                else
                    Console.WriteLine("Mirko Darko");
            }
            else if (razlikaMIS < razlikaDIM && razlikaMIS < razlikaDIS)
            {
                if (snagaSlavka > snagaMirka)
                    Console.WriteLine("Slavko Mirko");
                else
                    Console.WriteLine("Mirko Slavko");
            }
            else
            {
                if(snagaDarka > snagaSlavka)
                    Console.WriteLine("Darko Slavko");
                else
                    Console.WriteLine("Slavko Darko");
            }

        }

        public static int RazlikaDvijuSnaga(int snaga1, int snaga2)
        {
            return Math.Abs(snaga1 - snaga2);
        }
    }
}
