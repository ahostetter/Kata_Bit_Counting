using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bit_Counting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(countBits(1234));
            Console.ReadLine();
        }

        static int countBits(int number)
        {
            int bitCount = 0;

            string binary = Convert.ToString(number, 2);

            foreach (char bit in binary)
            {
                if (bit == '1')
                {
                    bitCount++;
                }
            }
            return bitCount;
        }
    }
}
