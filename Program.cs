using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] scores = new int[5];

            for (int i = 0; i < scores.Length; i++)
            {
                Console.Write($"Enter 5 percentage scores {i + 1}: ");
                scores[i] = int.Parse(Console.ReadLine());

                char letter_grade;

                if (scores[i] >= 90 && scores[i] <= 100)
                {
                    letter_grade = 'A';
                }
                else if (scores[i] >= 80 && scores[i] <= 89)
                {
                    letter_grade = 'B';
                }
                else if (scores[i] >= 70 && scores[i] <= 79)
                {
                    letter_grade = 'C';
                }
                else if (scores[i] >= 60 && scores[i] <= 69)
                {
                    letter_grade = 'D';
                }
                else
                {
                    letter_grade = 'F';
                }

                switch (letter_grade)
                {
                    case 'A':
                        Console.WriteLine("Your grade is: A");
                        break;
                    case 'B':
                        Console.WriteLine("Your grade is: B");
                        break;
                    case 'C':
                        Console.WriteLine("Your grade is: C");
                        break;
                    case 'D':
                        Console.WriteLine("Your grade is: D");
                        break;
                    case 'F':
                        Console.WriteLine("Your grade is: F");
                        break;
                    default:
                        Console.WriteLine("Invalid. Please enter score.");
                        break;
                }
                Console.WriteLine();
            }  
        }
    }
}
