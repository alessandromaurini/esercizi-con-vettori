using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ricerca_elemento
{
    internal class Program
    {
        /*
         Scrivere e testare nel main un programma che, dopo aver permesso all'utente di riempire un array di numeri interi di dimensione di sua scelta, 
         gli permetta di inserire dei valori e, dopo ogni valore, gli dice se esiste nell'array e, in tal caso, la sua posizione. 
         Il programma smette di ricercare valori dopo sono stati richiesti 3 valori non esistenti consecutivi.

        Il programma deve far uso delle seguenti funzioni:

        int[] creaArray (int N)
        int cercaElemento (int[] array, int elemento)

        NOTA: cercaElemento restituisce -1 se l'elemento non è stato trovato.

        In aggiunta, creare e testare una funzione che verifica se in un array un elemento esiste (restituendo true o false). La funzione ha la seguente sintassi:

        bool esisteElemento (int[] array, int elemento)
         */
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
