using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_11_PolesUP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите элементы массива:");

            int[] nums = new int[n];

            for (int i = 0; i < n; i++)
            {
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < (n-1) - i; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        int more = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = more;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write($"{nums[i]}\t");
            }

            Console.ReadKey();
        }

    }
}
