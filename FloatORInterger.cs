using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class FloatORInterger
    {
        public FloatORInterger()
        {
            try
            {
                Console.WriteLine("please enter the number : ");
                int number1 = int.Parse(Console.ReadLine());
                Console.WriteLine($"int  {number1} ");
            }
              catch (Exception ex)
            {
                Console.WriteLine("please enter the number : ");
                float number1 = float.Parse(Console.ReadLine());
                Console.WriteLine($"float    {number1}");
            }
        }
    }
}
