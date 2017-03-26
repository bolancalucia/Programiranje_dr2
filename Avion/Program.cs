using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avion
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] avioni = new string[5];
            int brojac = 0;

            for (int i = 0; i < avioni.Count(); i++)
            {
                Console.WriteLine("Unesite ime "+(i+1)+".aviona: ");
                avioni[i] = Console.ReadLine();
            }
            for (int i = 0; i < avioni.Count(); i++)
            {
                if (JeLiCIA(avioni[i]))
                    Console.WriteLine(i + 1);
                else brojac++;
            }
            if(brojac == 5)
                Console.WriteLine("CIA-in avion je pobjegao!");
        }

      /*  public static bool JeLiCIA(string avion)   // kako u zadatku nije naglašeno napisala sam dvije fje,1.koja sve charove pretvara u velika slova tako da se prihvaća i fbi i FBI i sve ostale kombinacije(fbI,FbI,...)
        {
            avion=avion.ToUpper();
            for (int j = 0; j < avion.Count() - 2; j++)
            {
                if (avion[j] == 'F' && avion[j + 1] == 'B' && avion[j + 2] == 'I')
                    return true;
            }
            return false;
        }
    */
        public static bool JeLiCIA(string avion) // i 2. koja prihvaća samo FBI
        {
            for (int j = 0; j < avion.Count() - 2; j++)
            {
                if (Char.ToUpper(avion[j])=='F' && Char.ToUpper(avion[j+1])=='B' && Char.ToUpper(avion[j+2])=='I')
                    return true;
            }
            return false;
        }    
    }
}
