using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int v1, v2;
            // System.Console.WriteLine("Hello World!");
            Console.WriteLine("Inserisci il primo numero:");
            if (!int.TryParse(Console.ReadLine(), out v1))
            {
                Console.WriteLine("Errore nell'immissione del primo numero");
                System.Environment.Exit(1);
            }
            
            Console.WriteLine("Inserisci il secondo numero:");
            if (!int.TryParse(Console.ReadLine(), out v2))
            {
                Console.WriteLine("Errore nell'immissione del secondo numero");
                System.Environment.Exit(1);
            }

            System.Console.WriteLine("Il risultato della moltiplicazione è: {0}", 
                Multi(v1, v2));
        }
        static int Multi(int v1, int v2)
        {
            return v1 * v2;
        }
    }
}
