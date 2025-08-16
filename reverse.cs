using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        int[] number = { 1, 2, 3, 4, 5 };
        int start = 0;
        int end = number.Length - 1;

        while (start < end)
        {
            int temp = number[start];
            number[start] = number[end];
            number[end] = temp;
            start++;
            end--;
        }
        for (int i = 0; i < number.Length; i++)
        {
            Console.Write(number[i]);
            if (i < number.Length - 1)
                Console.Write(", ");
        }
    }
}
