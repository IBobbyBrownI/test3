using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива: ");
            int size;
            size = int.Parse(Console.ReadLine());
            int[] mas = new int[size];
            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                mas[i] = rand.Next(-9, 10);
            }
            Console.Write("Массив: |");
            for (int i = 0; i < size; i++)
            {
                Console.Write(mas[i] + " ");
            }
            Console.Write("|\n");
            int sum = 0;
            for (int i = 0; i < size; i++)
            {
                if (mas[i] < 0)
                {
                    sum += mas[i];
                }
            }
            Console.WriteLine("Суdwe: " + sum);
        }
    }
}
