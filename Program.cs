using System;

namespace arrayEven
{
    class Program
    {
        static void Main(string[] args)
        {
            short sum = 0;
            short[,] numbers = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 }, { 13, 14, 15 } };
            foreach (short number in numbers)
            {
                if (number % 2 == 0)
                {
                    sum += number;
                }
            }
            Console.WriteLine("Sum of even numbers is " + sum);
        }
    }
}
