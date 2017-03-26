using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pec_
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Unesite broj komada hrane koji su uzela sva djeca: ");
            int brojKomadaHrane = int.Parse(Console.ReadLine());
            int majkaKazePrase = 0, i, j = 0, k, trenutniBrojKomadaHrane = 0;
            bool pronadenoIme = false;
            List<string> imenaDjece = new List<string>();

            List<int> brojacHrane = new List<int>();
            for (i = 0; i < brojKomadaHrane; i++)
                brojacHrane.Add(0);

            for(i=1;i<=brojKomadaHrane;i++)
            {
                pronadenoIme= false;
                string ime = Console.ReadLine();
                if (i == 1)
                {
                    imenaDjece.Add(ime);
                    brojacHrane[j]++;
                    trenutniBrojKomadaHrane++;
                    j++;
                    continue;
                }
                for (k = 0; k < imenaDjece.Count(); k++)
                {
                    if (ime == imenaDjece[k])
                    {
                        brojacHrane[k]++;
                        trenutniBrojKomadaHrane++;
                        if (brojacHrane[k] > (trenutniBrojKomadaHrane - brojacHrane[k]))
                            majkaKazePrase++;
                        pronadenoIme = true;
                    }              
                }
                if (!pronadenoIme)
                {
                    imenaDjece.Add(ime);
                    brojacHrane[k]++;
                    trenutniBrojKomadaHrane++;
                }
            }
            Console.WriteLine("Majka kaze "+majkaKazePrase+" puta nekom djetetu da je prase.");
        }
    }
}
