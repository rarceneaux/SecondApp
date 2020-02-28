using System;

namespace SecondApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Enter your name...");
            var userEntry = Console.ReadLine();

            Console.WriteLine(userEntry);

            Console.ReadLine();

            if (userEntry == "Ray")
            {
                Console.WriteLine("Your are awesome");
            }
            else
            {
                Console.WriteLine("U are not cool");
            }
            Console.ReadLine();

            //    var i = 0;
            //    while (i < 10)
            //    {
            //        Console.WriteLine($"Current Value of i is {i++}...");
            //    }

            //for (int j = 0; j < 10; j++)
            //{
            //    Console.WriteLine($"Current Value of j is {j}...");
            //}
            //Console.ReadLine();
            foreach (var letter in userEntry)
            {
                Console.WriteLine($"the current letter is { letter}");
            }
        }
    }
}
