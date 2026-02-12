using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ricerca_elemento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quanti numeri vuoi inserire nell'array? ");
            int dimensione = int.Parse(Console.ReadLine());
            int[] array = creaArray(dimensione);

            int tentativi = 0;

            while (tentativi < 3)
            {

                Console.Write("quale valore vuoi cercare? ");
                int elemento = int.Parse(Console.ReadLine());

                int posizione = cercaElemento(array, elemento);

                if (esisteElemento(array, elemento) == true)
                {
                    Console.WriteLine($"L'elemento {elemento} esiste nell'array alla posizione {posizione}.");
                    tentativi = 0; 
                }
                else
                {
                    Console.WriteLine($"L'elemento {elemento} non esiste nell'array.");
                    tentativi++;
                }
            }

        }

        static int[] creaArray(int N)
        {
            int[] a = new int[N];

            for (int i = 0; i < N; i++)
            {
                Console.Write($"Scrvi il {i + 1}' elemento: ");
                a[i] = int.Parse(Console.ReadLine());
            }

            return a;
        }

        static int cercaElemento(int[] array, int elemento)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == elemento)
                {
                    return i;
                }
            }
            return -1;
        }

        static bool esisteElemento(int[] array, int elemento)
        {
            return cercaElemento(array, elemento) != -1;
        }
    }
}
