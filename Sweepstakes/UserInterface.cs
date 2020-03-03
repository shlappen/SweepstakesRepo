using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    static class UserInterface
    {

        public static string GetUserInputFor(string prompt)
        {
            Console.WriteLine($"Please enter your {prompt}");
            return Console.ReadLine();
        }

        public static int DisplayRegistrationNumber(int registrationNumber)
        {
            Console.WriteLine("Your registration number is: {0}", registrationNumber);
            return registrationNumber;
        }

        public static string ChooseManagerPrompt()
        {
            Console.WriteLine("Please choose from stack or queue.");
            return Console.ReadLine();
        }

        public static string NameSweepstake()
        {
            Console.WriteLine("Please enter a name for your sweepstake.");
            return Console.ReadLine();
        }

        public static int NumberOf(string items)
        {
            Console.WriteLine($"How many {items} would you like to add?");
            return Convert.ToInt32(Console.ReadLine());
        }

    }
}
