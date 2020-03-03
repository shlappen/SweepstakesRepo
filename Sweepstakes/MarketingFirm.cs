using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class MarketingFirm
    {
        ISweepstakesManager manager;
        string name;
        public string Name
        {
            get
            {
                return Name;
            }
        }


        public MarketingFirm(ISweepstakesManager manager, string name)
        {
            this.manager = manager;
            this.name = name;
        }

        public void NameFirm(string marketingFirmName)
        {
            name = marketingFirmName;
        }

        public void CreateSweepstake()
        {
            Sweepstakes sweepstake = new Sweepstakes(UserInterface.NameSweepstake());
            int numberOfContestants = UserInterface.NumberOf("contestants");
            for (int i = 0; i < numberOfContestants; i++)
            {
                sweepstake.RegisterContestant(new Contestant());
            }
            manager.InsertSweepstakes(sweepstake);
            sweepstake.PrintContestantInfo(sweepstake.PickWinner());
            sweepstake.Notify();
        }
    }
}
