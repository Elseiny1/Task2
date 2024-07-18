using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Maltiplication
    {
        public Maltiplication()
        {
            Console.WriteLine("please enter the number :");
            int number = int.Parse(Console.ReadLine());
            for(int i = 0; i <= 12; i++)
            {
                Console.WriteLine($"{i} * {number} = {i * number}");
            }
        }
    }
}
