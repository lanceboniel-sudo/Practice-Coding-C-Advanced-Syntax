using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advance_syntax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 12, 5, 7, 20, 15 };
            int largest = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > largest)
                {
                    largest = numbers[i];
                }
            }
            Console.WriteLine("The largest number is " + largest);
        }
    }
}
