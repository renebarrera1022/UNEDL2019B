using System;

namespace ExamenTercerParcial
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 6, 4, 1 };
            int temp;
            int n = 0;
            for (int j = 0; j <= a.Length - 2; j++)
            {
                for (int i = 0; i <= a.Length - 2; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        temp = a[i + 1];
                        a[i + 1] = a[i];
                        a[i] = temp;
                        n++;
                    }
                }
            }
            Console.WriteLine("Nuevo orden:");
            Console.Write("[");
            foreach (int p in a) { 
                Console.Write(p + ", ");
            }
            Console.Write("]");
            Console.Write("\nPrimer elemento: " + a[0]);
            Console.Write("\nUltimo elemento: " + a[2]);
            Console.Write("\nPermutas: " + n);
        }


    }
}
