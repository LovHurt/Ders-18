using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = 20;

            switch (number)
            {
                case 10:
                    Console.WriteLine("Number is 10");
                    break;
                case 20:
                    Console.WriteLine("Number is 20");
                    break;
                default:
                    Console.WriteLine("Number is not 10, nor 20");
                    break;
            }
            Console.ReadLine();
        }
    }
}
