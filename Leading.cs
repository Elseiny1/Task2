using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Leading
    {
        public Leading()
        {
            Console.WriteLine("please enter the number :");
           string number = Console.ReadLine();
            Console.WriteLine(number);
            Console.WriteLine(number.Length);
            number.Remove(0);
            for (int i = number.Length - 1; i >= 0; i--)
            {
                Console.Write(number[i]);

            }
        }
    }
}
