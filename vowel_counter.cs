using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        string input = "Hello World";

        int count = 0;

        for (int i = 0; i < input.Length; i++)
        {
            char c = input[i];
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
            {
                count++;
            }
        }
        Console.WriteLine($"The number of vowels in {input} is + {count}");

    }
}
