using System;

namespace PrimeNumbersLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine($"The Prime #{input} is {Prime.PrimeNum(input)}");
        }
    }
}
