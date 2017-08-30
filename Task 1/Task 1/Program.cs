using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter count of numbers in array: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            for(int i = 0; i < n; i++)
            {
                Console.Write("Enter {0} number: ", i + 1);
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Even numbers are: ");
            for (int i = 0; i < n; i++)
            {
                if (array[i] % 2 == 0)
                {
                    Console.Write(array[i] + " ");
                }                   
            }
            Console.Write("\nOdd numbers are: ");
            for (int i = 0; i < n; i++)
            {
                if (array[i] % 2 != 0)
                {
                    Console.Write(array[i] + " ");
                }                    
            }
            Console.ReadLine();
        }
    }
}
