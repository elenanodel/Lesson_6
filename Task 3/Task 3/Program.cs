using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter count of numbers in array: ");
            int count = int.Parse(Console.ReadLine());

            string[] product = new string[count];
            for (int i = 0; i < count; i++)
            {
                Console.Write("Enter name of {0} product: ", i + 1);
                product[i] = Console.ReadLine();
            }

            int[] price = new int[count];
            for(int i = 0; i < count; i++)
            {
                Console.Write("Enter price for product {0}: ", i + 1);
                price[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter maximum price: ");
            int max = int.Parse(Console.ReadLine());
            Console.WriteLine("Products that cost lesser, than maximum price: ");
            for (int i = 0; i < count; i++)
            {
                if (price[i] < max)
                {
                    Console.WriteLine(product[i] + " " + price[i]);
                }             
            }

            Console.ReadLine();
        }
    }
}
