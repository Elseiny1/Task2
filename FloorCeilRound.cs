using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class FloorCeilRound
    {
        public FloorCeilRound()
        {
            Console.WriteLine("please enter the first number :");
            double number1 = float.Parse(Console.ReadLine());
            Console.WriteLine("please enter the second number :");
            double number2 = float.Parse(Console.ReadLine());
            double num = number1 % number2;
            double number = number1 / number2;
            if (num == 0)
            {
             
                Console.WriteLine($"floor is {number}");
                Console.WriteLine($"ceil is {number}");
                Console.WriteLine($"round is {number}");
            }
            else
            {
                double round = Math.Round(number);
                if(round > number)
                {
                    double ceil1 = round;
                    double floor1 = round - 1;
                    Console.WriteLine($"round is {round}");
                    Console.WriteLine($"ceil is :{ceil1}");
                    Console.WriteLine($"floor is :{floor1}");
                }
                else if(round < number)
                {
                    double ceil2 = round + 1;
                    double floor2 = round;
                    Console.WriteLine($"round is {round}");
                    Console.WriteLine($"ceil is :{ceil2}");
                    Console.WriteLine($"floor is :{floor2}");
                }
            }   
        }
    }
}
