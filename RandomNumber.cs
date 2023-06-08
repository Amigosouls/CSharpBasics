using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasics
{
  class RandomNumber
    {
        public void createRandom()
        {
            Random rand = new Random();
            int x;

            while (true)
            {
                Console.Write("Enter your choice: \n 1-> A random number" +
               "\n 2->Random Number upto a Range \n 3-> Random number between a range" +
               "\n 4-> Decimal Random Number \n 5-> Fill array with Bytes \n 6->Exit:");
                x = Convert.ToInt32(Console.ReadLine());
                if (x == 1)
                {
                    Console.WriteLine(rand.Next());
                }
                else if (x == 2)
                {
                    Console.Write("Enter a number");
                    int n = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(rand.Next(n));
                }
                else if (x == 3)
                {
                    Console.Write("Enter The start value:");
                    int start = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter The end value:");
                    int end = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(rand.Next(start, end));

                }
                else if (x == 4)
                {
                    Console.WriteLine(rand.NextDouble());
                }
                else if (x == 5)
                {
                    byte[] byteArray = new byte[4];
                    rand.NextBytes(byteArray);
                    Console.WriteLine("Values of array..");
                    foreach (byte val in byteArray)
                    {
                        Console.Write(val + "\t");
                    }
                }
                else
                {
                    break;
                }
            }
        }
    }
}
