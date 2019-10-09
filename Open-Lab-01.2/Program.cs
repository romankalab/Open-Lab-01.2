using System;
using System.IO;

namespace Open_Lab_01._1
{
    class GFG
    {
        public static void Main()
        {
            int number;

            Console.WriteLine("Enter your number: ");

            number = Convert.ToInt32(Console.ReadLine());

            int number2;

            Console.WriteLine("Enter your ssecond number: ");

            number2 = Convert.ToInt32(Console.ReadLine());

            int sum = number + number2;

            Console.WriteLine($"This is the result: {sum}");
        }
    }
}
