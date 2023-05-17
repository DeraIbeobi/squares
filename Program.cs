using System;

namespace Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            int sqr;
            while(true)
            {
                System.Console.WriteLine("Enter a number: ");
                if (int.TryParse(Console.ReadLine(), out sqr))
                {
                    int square = sqr*sqr;
                    if (square % 2 == 0)
                    {
                        System.Console.WriteLine(square + ", The square is divisible by 2 without a remainder");
                        break;
                    }
                    System.Console.WriteLine("Square is not divisible by 2 without remainder");
                }
                else
                {
                    System.Console.WriteLine("Invalid input, Enter a number");
                }
            }
            System.Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}