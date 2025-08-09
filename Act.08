using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act._08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] pass = new string[4];

            for (int i = 0; i < pass.Length; i++)
            {
                Console.Write($"Enter password {i + 1}: ");
                pass[i] = Console.ReadLine();

                int upCount = 0;

                foreach (char c in pass[i])
                {
                    if (char.IsUpper(c))
                    {
                        upCount++;
                        break;
                    }
                }

                if (pass[i].Length >= 6 && upCount > 0)
                {
                    Console.WriteLine("Valid");
                }
                else
                {
                    Console.WriteLine("Invalid password.");
                    if (pass[i].Length < 6)
                        Console.WriteLine("Password must be at least 6 characters long.");
                    if (upCount == 0)
                        Console.WriteLine("Password must contain at least one uppercase letter.");
                    Console.WriteLine();
                }
            }
        }
    }
}
