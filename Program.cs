using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act._06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] celsius = new int[5];

            for (int i = 0; i < celsius.Length; i++)
            {
                Console.Write($"Enter temperature in Celsius {i + 1}: ");
                celsius[i] = int.Parse(Console.ReadLine());

                float fahrenheit = (celsius[i] * 9 / 5) + 32;
                Console.WriteLine($"Temperature in Fahrenheit: {fahrenheit}");
                Console.WriteLine("\n");
            }

            foreach (int temp in celsius)
            {
                if (temp < 15)
                {
                    Console.WriteLine("\nCold");
                }
                else if (temp < 15 && temp > 30)
                {
                    Console.WriteLine("\nWarm");
                }
                else
                {
                    Console.WriteLine("\nHot");
                }
            }
        }
    }
}
