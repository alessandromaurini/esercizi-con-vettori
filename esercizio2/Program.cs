using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Carica un vettore di numeri.Stampa i numeri che si trovano in posizioni dispari e la loro somma e poi stampa i numeri che si trovano in posizioni pari e la loro somma.
            Console.WriteLine($"Scrivi un numero");
            int n = int.Parse(Console.ReadLine());
            int[] vettore = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Scrivi il {i+1}' numero");
                vettore[i] = int.Parse(Console.ReadLine());
            }
            int dispari = 0;
            int pari = 0; 
            for (int i = 0;i < vettore.Length; i++)
            {
                if (vettore[i] % 2 == 1)
                {
                    dispari = dispari + vettore[i];
                }
                else if (vettore[i] % 2 == 0)
                {
                    pari = pari + vettore[i];
                }
            }
            Console.WriteLine($"la somma dei numeri pari e': {pari}");
            Console.WriteLine($"la somma dei numeri dispari e': {dispari}");

            Console.ReadKey();
        }
            
    }
}
