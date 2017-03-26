using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigMoney
{
    class Program
    {
        static void Main(string[] args)
        {
            int galeoni, srpovi, knutovi, ukupnoKnutova = 0;

            Console.WriteLine("Upisite broj galeona: ");
            galeoni = int.Parse(Console.ReadLine());
            Console.WriteLine("Upisite broj srpova: ");
            srpovi = int.Parse(Console.ReadLine());
            Console.WriteLine("Upisite broj knutova: ");
            knutovi = int.Parse(Console.ReadLine());

            ukupnoKnutova = knutovi + SrpoviUKnutove(srpovi) + SrpoviUKnutove(GaleoniUSrpove(galeoni));
            Console.WriteLine("Ukupan broj novca izrazen u knutovima je " + ukupnoKnutova + ".");
        }
        public static int GaleoniUSrpove(int galeoni)
        {
            return galeoni * 17;
        }
        public static int SrpoviUKnutove(int srpovi)
        {
            return srpovi * 29;
        }
    }
}

 
