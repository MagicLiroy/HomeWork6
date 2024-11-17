using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string row = Console.ReadLine();
            string reverseRow = "";

            row = row.Replace(" ", "").ToLower();

            foreach(char letter in row)
            {
                reverseRow =  letter + reverseRow;
            }

            if ( reverseRow == row)
            {
                Console.WriteLine("Строка - палиндром ");
            }
            else
            {
                Console.WriteLine("Строка не палиндром");
            }

            Console.ReadLine();
        }
    }
}
