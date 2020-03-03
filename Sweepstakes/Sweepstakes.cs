using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;

namespace Sweepstakes
{
    public class Sweepstakes
    {
        Dictionary<int, Contestant> contestants;
        string name;

        public string Name
        {
            get
            {
                return Name;
            }
        }

        public Sweepstakes(string name)
        {
            this.name = name;
            contestants = new Dictionary<int, Contestant>();

        }

        public void RegisterContestant(Contestant contestant)
        {
            contestant.registrationNumber++;
            contestant.firstName = UserInterface.GetUserInputFor("first name.");
            contestant.lastName = UserInterface.GetUserInputFor("last name.");
            contestant.emailAddress = UserInterface.GetUserInputFor("email address.");
            UserInterface.DisplayRegistrationNumber(contestant.registrationNumber);
            contestants.Add(contestant.registrationNumber, contestant);
        }

        public Contestant PickWinner()
        {
            List<int> keyList = new List<int>(contestants.Keys);
            Random rand = new Random();
            int randomKey = keyList[rand.Next(keyList.Count)]; ;
            contestants[randomKey].isWinner = true;
            return contestants[randomKey];
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine($"WE HAVE A WINNER!");
            Console.WriteLine($"Congratulations {contestant.firstName} {contestant.lastName}, number {contestant.registrationNumber}");
            Console.WriteLine($"{contestant.emailAddress}");
        }

        public void Notify()
        {
            foreach (KeyValuePair<int, Contestant> contestant in contestants)
            {
                if (contestant.Value.isWinner == false)
                {
                    var message = new MimeMessage();
                    message.From.Add(new MailboxAddress("Shae Lappen", "shaelappen@gmail.com"));
                    message.To.Add(new MailboxAddress($"{contestant.Value.firstName} {contestant.Value.lastName}", $"{contestant.Value.emailAddress}"));
                    message.Subject = "Sweepstakes";
                    message.Body = new TextPart("plain")
                    {
                        Text = $@"Dear {contestant.Value.firstName}, we have selected a winner for the sweepstakes.  Thank you for playing!"
                    };
                }
            }

        }


    }
}
