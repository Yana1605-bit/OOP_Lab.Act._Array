using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act._02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fruit = new string[5];
            int apple = 0;

            for (int i = 0; i < fruit.Length; i++)
            {
                Console.Write($"Enter a fruit {i + 1}: ");
                fruit[i] = Console.ReadLine().ToLower();
            }

            foreach (string color in fruit)
            {
                if (color == "apple")
                {
                    apple++;
                }
            }

            Console.WriteLine($"\nNumbers of 'apple' entered: {apple}");
        }
    }
}
