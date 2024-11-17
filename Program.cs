using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string row = Console.ReadLine();

            string[] word = row.Split();

            string maxWord = word[0];

            foreach (string w in word)
            {
                if (maxWord.Length <= w.Length)
                {
                    maxWord = w;
                }
            }

            Console.WriteLine($"Наибольшее слово в строке: {maxWord}");

            Console.ReadKey();
        }
    }
}
