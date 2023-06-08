using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace CsharpBasics
{
    class Arithmetic
    {
        public void ArithOperation()
        {
            int a, b;
            string oper;
            Console.Write("Enter the value of a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Provide the operator:");
            oper = Console.ReadLine();
            if(oper =="+")
            {
                Console.WriteLine("The Sum of " + a + " and " + b + " is " + (a + b));
            }
            else if (oper == "-")
            {
                Console.WriteLine("The Subtraction of " + a + " and " + b + " is " + (a - b));
            }
           else if (oper == "*")
            {
                Console.WriteLine("The Product of " + a + " times " + b + " is " + (a * b));
            }
            else if (oper == "/")
            {
                Console.WriteLine("The Dividend of " + a + " by " + b + " is " + (a / b));
            }
            else if (oper == "%")
            {
                Console.WriteLine("The Remainder of " + a + " % " + b + " is " + (a + b));
            }
            else
            {
                Console.WriteLine("Invalid Operator");
            }
        }
    }
}
