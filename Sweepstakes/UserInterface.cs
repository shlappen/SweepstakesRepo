using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    static class UserInterface
    {

        public static string GetUserInputForFirstName(string firstName)
        {
            Console.WriteLine("Please enter your first name");
            
            string input = Console.ReadLine();
            firstName = input;
        }

        public static string GetUserInputForLastName(string lastName)
        {
            Console.WriteLine("Please enter your last name");
            string input = Console.ReadLine();
            lastName = input;
        }

        public static string GetUserInputForEmail(string emailAddress)
        {
            Console.WriteLine("Please enter your email address");
            string input = Console.ReadLine();
            emailAddress = input;
        }

    }
}
