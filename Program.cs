using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        
        {
            Console.WriteLine("vuvedi chisla i gi razdeli s interval:");
            int[] inputNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray(); 

            Console.WriteLine("broqt na nulite e:"+CountOfZeros(inputNumbers));

            Console.WriteLine("broqt na chislata razlichni ot nula e:" + CountOfNonZeros(inputNumbers));
        }

        static int CountOfZeros(int[] numbers)
        {
            int zeroCounts = 0;

           // numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i <= numbers.Length; i++)
            {
                if (i == 0)
                {
                    zeroCounts++;
                }
            }
            return zeroCounts;
        }

        static int CountOfNonZeros(int[] numbers)
        {
            int nonZeroCounts = 0;

            for (int i = 0; i <= numbers.Length; i++)
            {
                if (i != 0)
                {
                    nonZeroCounts++;
                }
            }
            return nonZeroCounts;
        }
    }
}
