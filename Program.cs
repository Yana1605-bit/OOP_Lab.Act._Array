using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act._07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] votes = new string[10];
            int Mae = 0;
            int Angela = 0;
            int Ashly = 0;

            Console.WriteLine("Choose your candidate (Mae / Angela / Ashly)");

            for (int i = 0; i < votes.Length; i++)
            {
                Console.Write($"Enter vote {i + 1}: ");
                votes[i] = Console.ReadLine().ToLower();
            }

            for (int i = 0; i < votes.Length; i++)
            {
                if (votes[i] == "mae")
                {
                    Mae++;
                }
                else if (votes[i] == "angela")
                {
                    Angela++;
                }
                else if (votes[i] == "ashly")
                {
                    Ashly++;
                }
                else
                {
                    Console.WriteLine("Invalid vote.");
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Total votes for Mae: {Mae} votes");
            Console.WriteLine($"Total votes for Angela: {Angela} votes");
            Console.WriteLine($"Total votes for Ashly: {Ashly} votes");

            int[] voteC = { Mae, Angela, Ashly };
            string[] candidates = { "Mae", "Angela", "Ashly" };

            int maxV = voteC[0];
            int winner = 0;

            for (int i = 1; i < voteC.Length; i++)
            {
                if (voteC[i] > maxV)
                {
                    maxV = voteC[i];
                    winner = i;
                }
            }

            Console.WriteLine($"\nWinner: {candidates[winner]}!!!");
        }
    }
}
