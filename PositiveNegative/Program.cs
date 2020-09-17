using System;

namespace PositiveNegative
{
    class Program
    {
        static void Main(string[] args)
        {
            /*The program checks if the number is positive or negative*/
            Console.WriteLine("Enter your number: ");

            int userNumber;
            string UserInput;

            UserInput = Console.ReadLine();
            userNumber = Int32.Parse(UserInput);

            if (userNumber > 0)
            {
                Console.WriteLine("The number is positive.");
            } else if (userNumber < 0)
            {
                Console.WriteLine("The number is negative.");
            }

        }
    }
}
