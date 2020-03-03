using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            new Contestant();
            contestant.firstName = UserInterface.GetUserInputFor("first name.");
            contestant.lastName = UserInterface.GetUserInputFor("last name.");
            contestant.lastName = UserInterface.GetUserInputFor("email address.");
            UserInterface.DisplayRegistrationNumber(contestant.registrationNumber++);
            contestants.Add(contestant.registrationNumber, contestant);
        }

        public Contestant PickWinner()
        {
            Random rand = new Random();
            Contestant contestant = contestants[rand.Next(contestants.Count)];
            return contestant;
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine($"WE HAVE A WINNER!");
            Console.WriteLine($"Congratulations {contestant.firstName} {contestant.lastName}, number {contestant.registrationNumber}");
            Console.WriteLine($"{contestant.emailAddress}");
        }
    }
}
