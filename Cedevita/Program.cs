using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cedevita
{
    class Program
    {
        static void Main(string[] args)
        {
            int brojKutija;

            Console.WriteLine("Unesite broj kutija Cedevite: ");
            brojKutija = int.Parse(Console.ReadLine());

            if(brojKutija>0)
            {
                for (int i = 1; i <= brojKutija; i++) // for petlja ide od 1 radi rednih brojeva(potrebe zadatka)
                {                              // iako mozemo pisati petlju koja krece od 0 do i<brojKutija,a onda u uvjetima staviti (i+1)
                    if (i % 3 == 0 && i % 7 == 0)
                        Console.WriteLine("CEDEVITA");
                    else if (i % 3 == 0)
                        Console.WriteLine("CEDE");
                    else if (i % 7 == 0)
                        Console.WriteLine("VITA");
                    else
                        Console.WriteLine(i);
                }
            }
            else Console.WriteLine("Krivo unesen broj kutija");
        }
    }
}
