using System;
using System.Collections.Generic;

namespace AddingNumbers
{
    class Program
    {

        static readonly Dictionary<string, int> numbersInWords = new Dictionary<string, int>()
        {
            { "zero", 0 },
            { "one", 1 },
            { "two", 2 },
            { "three", 3 },
            { "four", 4 },
            { "five", 5 },
            { "six", 6 },
            { "seven", 7 },
            { "eight", 8 },
            { "nine", 9 }
        };
      
        static void Main(string[] args)
        {
            Console.Write("Give me numbers separated by space: ");
            string numbersInLine = Console.ReadLine().ToLower(); ;
            string[] separatedNumbers = SeparateNumbers(numbersInLine);
            int sum = AddingNumbers(separatedNumbers);         
            Console.WriteLine("\nSum of given numbers is: " + sum);
        }

        static int AddingNumbers(params string[] numbers)
        {
           int sum = 0;
           foreach (string number in numbers)
            {                
                if (int.TryParse(number, out int num))
                {
                    sum += num;
                }
                else if (numbersInWords.TryGetValue(number, out int num2))
                {
                    sum += num2;
                }
                else
                {
                    Console.WriteLine("Can't add numbers. Wrong parameters.");
                } 
            }
            return sum;
        }

        static string[] SeparateNumbers(string line)
        {
            return line.Split(' ');
        }
    }
}
