using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasics
{
    class Swap
    {
        public void swapNumber()
        {
            int a, b;
            Console.Write("Enter the value of a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("a:" + a + "\t b:"+b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("After Swapping......");
            Console.WriteLine("a:" + a + "\t b:" + b);
        } 
    }
}
