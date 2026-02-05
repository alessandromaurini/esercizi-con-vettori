using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crea un programma che carichi un vettore con N numeri e stampi quanti numeri uguali consecutivi ci sono.
            Console.WriteLine($"scrivi un numero");
            int n = int.Parse(Console.ReadLine());
            int[]vettore = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Scrivi il {i+1}' numero");
                vettore[i] = int.Parse(Console.ReadLine());
            }

            int consecutivi = 1;           
            int massimoConsecutivi = 1;    

            for (int i = 1; i < n; i++)
            {
                if (vettore[i] == vettore[i - 1])
                {
                    consecutivi++;
                    if (consecutivi > massimoConsecutivi)
                    {
                        massimoConsecutivi = consecutivi;
                    }
                }
                else
                {
                    consecutivi = 1;   
                }
            }

            Console.WriteLine($"Il massimo di numeri uguali consecutivi è: {massimoConsecutivi}");
            Console.ReadKey();
        }
    }
}
