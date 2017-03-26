using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odgovaranje
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] brojeviMatej = new int [2];
            int[] brojeviDominik = new int[2];
            int i;

            Console.WriteLine("Unesite 2 broja kojih se Matej uspio sjetiti: ");
            for (i = 0; i < brojeviMatej.Count(); i++)
                brojeviMatej[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesite 2 broja kojih se Dominik uspio sjetiti: ");
            for (i = 0; i < brojeviDominik.Count(); i++)
                brojeviDominik[i] = int.Parse(Console.ReadLine());

            List<int> brojeviUsmeni = new List<int>(brojeviMatej);
            for (i = 0; i < brojeviDominik.Count(); i++)
            {
                if (brojeviDominik[i] != brojeviUsmeni[0] && brojeviDominik[i] != brojeviUsmeni[1])
                    brojeviUsmeni.Add(brojeviDominik[i]);
            }

            if (brojeviUsmeni.Count() != 3)
            {
                Console.WriteLine("SVI");
            }
            else
            {
                Sortiranje(brojeviUsmeni);
                Console.WriteLine("Redni brojevi ucenika koji ce usmeno odgovarati: ");
                foreach(int broj in brojeviUsmeni)
                    Console.WriteLine(broj);
            }
        }

        public static void Sortiranje(List<int> brojeviUsmeni)
        {
            int temp;
            for (int i = 0; i < brojeviUsmeni.Count() - 1; i++)
                for (int j = i + 1; j < brojeviUsmeni.Count(); j++)
                {
                    if (brojeviUsmeni[i] > brojeviUsmeni[j])
                    {
                        temp = brojeviUsmeni[i];
                        brojeviUsmeni[i] = brojeviUsmeni[j];
                        brojeviUsmeni[j] = temp;
                    }
                }
        }
    }
}
