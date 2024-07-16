using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POConEnum
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            Console.Write("Enter the Number of Month : ");

            int monthNumber=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The Month is : {(Month)monthNumber}");
        }
    }
}
