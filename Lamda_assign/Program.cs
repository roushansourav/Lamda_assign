using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamda_assign
{
    class Program
    {
        public delegate int Delegate1(int a, int b);
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            
            Delegate1 d1 = (a, b) => a + b;
            Delegate1 d2 = (a, b) => a -b;
            Delegate1 d3 = (a, b) => a * b;
            Delegate1 d4 = (a, b) => a / b;
            Console.WriteLine("Addition: " + d1(x, y));
            Console.WriteLine("Subtraction: " + d2(x, y));
            Console.WriteLine("Multiplication: " + d3(x, y));
            Console.WriteLine("Division: " + d4(x, y));

        }
    }
}
