using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova
{
    internal class Program
    {
        static int[] array;
        static void Main(string[] args)
        {
            Console.WriteLine("--Prova di verifica di laboratorio--");
            int n;
            bool funzione = true;
            while (funzione)
            {
                menu();
                Console.Write("Cosa devi fare: ");
                int attivita = int.Parse(Console.ReadLine());
                switch (attivita)
                {
                    case 0:
                        Console.WriteLine("Alla prossima!");
                        funzione = false;
                        break;

                    case 1:
                        //Crea array
                        Console.Write("Da quanti elementi deve essere composto l'array: ");
                        n = int.Parse(Console.ReadLine());
                        bool nfunz = false;
                        while (!nfunz)
                        {
                            if (n >= 2)
                            {
                                nfunz = true;
                            }
                            else
                            {
                                Console.Write("Inserire un numero maggiore a 2! ");
                                n = int.Parse(Console.ReadLine());
                            }
                        }
                        array = creaArray(n);
                        Console.WriteLine("Attivita eseguita con successo!");
                        break;

                    case 2:
                        //Array dei multipli
                        if (array == null)
                        {
                            Console.WriteLine("Devi prima creare l'array!");
                            break;
                        }
                        else
                        {
                            arrayMultipli(array);
                            Console.WriteLine("Attivita eseguita con successo!");
                            break;
                        }

                    case 3:
                        //Stampare array
                        if (array == null)
                        {
                            Console.WriteLine("Devi prima creare l'array!");
                            break;
                        }
                        else
                        {
                            stampaArray(array);
                            Console.WriteLine("Attivita eseguita con successo!");
                            break;
                        }

                    case 4:
                        //Contare i multipli
                        if (array == null)
                        {
                            Console.WriteLine("Devi prima creare l'array!");
                            break;
                        }
                        else
                        {
                            Console.Write("Scrivi un numero: ");
                            int num = int.Parse(Console.ReadLine());
                            Console.WriteLine($"IL tuo numero: {num}, ha {contaMultipli(array, num)} multipli/o ");
                            Console.WriteLine("Attivita eseguita con successo!");
                            break;
                        }

                    case 5:
                        //Inserire un valore
                        if (array == null)
                        {
                            Console.WriteLine("Devi prima creare l'array!");
                            break;
                        }
                        else
                        {
                            Console.Write("Scrivi un numero: ");
                            int val = int.Parse(Console.ReadLine());
                            Console.WriteLine("Scrivi la posizione: ");
                            int pos = int.Parse(Console.ReadLine());
                            inserimentoValore(array, val, pos);
                            Console.WriteLine("Attivita eseguita con successo!");
                            break;
                        }

                    case 6:
                        //Array mescolato
                        Console.WriteLine("Attivita eseguita con successo!");
                        break;

                    default:
                        Console.WriteLine("Questo numero non e' valido!");
                        break;
                }
            }
        }

        static void menu()
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("0. Esci");
            Console.WriteLine("1. Crea array");
            Console.WriteLine("2. Array dei multipli");
            Console.WriteLine("3. Stampare array");
            Console.WriteLine("4. Contare i multipli");
            Console.WriteLine("5. Inserire un valore");
            Console.WriteLine("6. Array mescolato");
        }
        static int[] creaArray(int n)
        {
            int[] array = new int[n];
            return array;
        }
        static void stampaArray(int[] array)
        {
            Console.Write("Array: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                if (i < array.Length - 1)
                    Console.Write(", ");
            }
            Console.WriteLine();
        }
        static void arrayMultipli(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = n * (i + 1);
            }
        }
        static int contaMultipli(int[] array, int num)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % num == 0)
                {
                    count++;
                }
            }
            return count;
        }
        static void inserimentoValore(int[] array, int val, int pos)
        {
            for (int i = array.Length - 1; i >= pos; i--)
            {
                array[i] = array[i - 1];
            }

            array[pos - 1] = val;
        }
    }
}
