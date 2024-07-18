using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class GoodANDBad
    {
        public GoodANDBad()
        {
            Console.WriteLine("please enter the string of s:");
            string s = Console.ReadLine();
            if( s.Contains("010") || s.Contains("101"))
            {
                Console.WriteLine("good");
            }
            else
            {
                Console.WriteLine("bad");
            }
        }
    }
}
