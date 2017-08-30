using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter count of numbers in array: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter {0} number: ", i + 1);
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Array: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }
            
            int min = array[0];
            int minPosition = 0;
            for (int i = 0; i < n; i++)
            {
                if(array[i] < min)
                {
                    min = array[i];
                    minPosition = i + 1;
                }                
            }
            Console.Write("\nThe minimum number of array: " + min);
            Console.Write("\nPosition of the minimum number of array: " + minPosition);

            int max = array[0];
            int maxPosition = 0;

            for (int i = 0; i < n; i++)
            {
                if(array[i] > max)
                {
                    max = array[i];
                    maxPosition = i + 1;
                }
            }
            Console.Write("\nThe maximum number of array: " + max);
            Console.Write("\nPosition of the maximum number of array: " + maxPosition);
            Console.ReadLine();
        }
    }
}
