using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число N=");
            int N = Convert.ToInt32(Console.ReadLine());
            int[,] mas = new int[N, N];
            //Random random = new Random();
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    mas[i, j] = 1 - (i + j) % 2; // random.Next(0, 2);
                    Console.Write("{0} ", mas[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
