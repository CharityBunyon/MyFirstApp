using System;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Enter Your Name..");
            var userEntry = Console.ReadLine();

            Console.WriteLine(userEntry);
            Console.ReadLine();

            if (userEntry == "Charity")
            {
                //do something
                Console.WriteLine("Your da BOMB!");
            }
            else
            {
                //do something else
                Console.WriteLine("Your AWESOME!");
            }

            var a = 0;
            while (a < 10)
            {
                Console.WriteLine($"Current value of i is {a++}...");
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Current value of i is {i}...");
                //don't need ++ becuase it's part of the loop
            }

            foreach (var currentCharacter in userEntry)
            {
                if (currentCharacter == 'n'|| currentCharacter == 'N')
                {
                    continue;
                }
                Console.WriteLine($"the current character is {currentCharacter}");
            }

            switch (userEntry)
            {
                case "Charity":
                    Console.WriteLine("Its Me");
                    break;
                default:
                    Console.WriteLine("its anything but me");
                    break;
            }

            var isCharity = userEntry == "Charity" ? true : false;
            try
            {
                var y = 0;
                var x = 1 / y; 
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
