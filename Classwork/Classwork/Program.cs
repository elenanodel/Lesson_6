using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int[] mas = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write(mas[i] + " ");
            }

            int[] masNew = new int[mas.Length];

            for(int i = 0; i < mas.Length; i++)
            {
                masNew[i] = mas[i];
            }

            for (int i = 0; i < mas.Length; i++)
            {
                masNew[i] = mas[mas.Length-1-i];
                Console.Write(masNew[i] + " ");
            }*/

            /*int n;
            Console.Write("Input count of students: ");
            n = int.Parse(Console.ReadLine());

            int[] hight = new int[n];

            for( int i = 0; i < n; i++)
            {
                Console.Write("Input {0} student: ", i + 1);
                hight[i] = int.Parse(Console.ReadLine());
            }

            double midHight = 0;
            for (int i = 0; i < n; i++)
            {
                midHight = midHight + hight[i];
            }

            midHight = midHight / n;
            Console.Write("Middle hight = {0}", midHight);*/

            int n = 10;
            int[,] matrix = new int[n, n];

            matrix[0, 0] = 1;
            matrix[1, 1] = 1;
            matrix[2, 2] = 1;
            for (int a = 0; a < n; a++)
            {
                matrix[0 + a, 0 + a] = 1;
            }

            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write(matrix[j, i] + " ");
                }
                Console.WriteLine();
            }


            Console.ReadLine();
        }
    }
}
