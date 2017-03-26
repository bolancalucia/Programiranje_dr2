using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheVoice
{
    class Program
    {
        static void Main(string[] args)
        {
            int brojOkrenutihMentora;
            string [] mentoriPoSvidanju = new string[4];

            Console.WriteLine("Unesite imena mentora prema vašim preferencijama: ");
            for(int i = 0; i < mentoriPoSvidanju.Count(); i++)
            {
                mentoriPoSvidanju[i] = Console.ReadLine();
            }

            Console.WriteLine("Unesite broj mentora koji su se okrenuli: ");
            brojOkrenutihMentora = int.Parse(Console.ReadLine());
            if (brojOkrenutihMentora == 0)
                Console.WriteLine("Žao nam je,ali nitko od mentora se nije okrenuo.");
            else if (brojOkrenutihMentora > 4 || brojOkrenutihMentora < 0)
                Console.WriteLine("Unijeli ste pogrešan broj.");
            else
            {
                string[] okrenutiMentori = new string[brojOkrenutihMentora];

                for (int i = 0; i < okrenutiMentori.Count(); i++)
                {
                    okrenutiMentori[i] = Console.ReadLine();
                }
                IzborMentora(okrenutiMentori, mentoriPoSvidanju);
            }          
        }

        public static bool IzborMentora(string []okrenutiMentori,string []mentoriPoSvidanju)
        {
            for (int j = 0; j < mentoriPoSvidanju.Count(); j++)
                for (int i = 0; i < okrenutiMentori.Count(); i++)
                {
                    if (mentoriPoSvidanju[j] == okrenutiMentori[i])
                    {
                        Console.WriteLine(mentoriPoSvidanju[j]);
                        return true;
                    }
                }
            return false;
        }
    }
}
