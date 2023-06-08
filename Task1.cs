using CsharpBasics;

namespace CsharpBasic
{
    class Task1
    {
        static void Main(string[] args)
        {
            int x;
            while (true)
            {
                Console.Write("Enter your choice: \n 1->Random Number" +
              "\n 2->Arithmetic Operation \n 3-> Sum of Multiples" +
              "\n 4-> Reverse A string \n 5-> Reverse a Number \n 6-> Sum of Digits \n 7->Swap two Numbers:"
              + "\n 8-> Exit:");
                x = Convert.ToInt32(Console.ReadLine());
                if (x == 1)
                {
                    Console.WriteLine("-------------- Random Number Generator -----------------");
                    RandomNumber obj = new RandomNumber();
                    obj.createRandom();
                }
                else if (x == 2)
                {
                    Console.WriteLine("-------------- Arithmetic Operations --------------------");
                    Arithmetic obj = new Arithmetic();
                    obj.ArithOperation();
                }
                else if (x == 3)
                {
                    Console.WriteLine("-------------- Sum of Multiples of 3 and 5 --------------");
                    Console.Write("Enter the range:");
                    int num = Convert.ToInt32(Console.ReadLine());
                    Multiples obj = new Multiples(num);
                    Console.WriteLine("The sum:" + obj.findSumOfMultiples());
                }
                else if (x == 4)
                {
                    Console.WriteLine("-------------- Reverse a String ------------------------");
                    Console.Write("Enter your string to Reverse:");
                    string str = Console.ReadLine();
                    Reverse obj = new Reverse(str);
                    Console.WriteLine("Reversed String:" + obj.reversedString());
                }
                else if (x == 5)
                {
                    Console.WriteLine("------------- Reverse a Number --------------------------");
                    Console.Write("Enter a Number  to Reverse:");
                    int num = Convert.ToInt32(Console.ReadLine());
                    ReverseNumber obj = new ReverseNumber(num);
                    Console.WriteLine("Entered Number:" + num + "\t Reversed Number:" + obj.findReverse());

                }
                else if (x == 6)
                {
                    Console.WriteLine("-------------- Sum of Digits ----------------------------");
                    Console.Write("Enter a Number to find Sum:");
                    int num = Convert.ToInt32(Console.ReadLine());
                    SumOfDigits obj = new SumOfDigits(num);
                    Console.WriteLine("The Sum of Digits of Entered Number:" + obj.findSumOfDigits());
                }
                else if (x == 7)
                {
                    Console.WriteLine("-------------- Swap two Number -------------------------");
                    Swap obj = new Swap();
                    obj.swapNumber();
                }
                else
                {
                    break;
                }
            }
        }
    }
}
