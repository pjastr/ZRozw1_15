using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZRozw1_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] tablica = new int[5, 5];
            for(int i=0;i<5;i++)
            {
                for(int j=0;j<5;j++)
                {
                    tablica[i, j] = 3 * j + 4 * i - 23;
                }
            }
            Console.WriteLine("Pierwszy podpunkt");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i%2==0 && j%2==0)
                    {
                        Console.Write(tablica[i, j]+ " ");
                    }
                    
                }
                Console.WriteLine();
            }

            Console.WriteLine("Drugi podpunkt");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i != j)
                    {
                        Console.Write(tablica[i, j] + " ");
                    }

                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
