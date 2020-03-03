using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Simulation
    {
        public void RunSimulation()
        {
            CreateMarketingFirmWithManager();
        }
        public void CreateMarketingFirmWithManager()
        {
            string marketingFirmName = UserInterface.GetUserInputFor("marketing firm's name.");
            ISweepstakesManager sweepstakesManager = ManagerFactory.GetManager(UserInterface.ChooseManagerPrompt());
            MarketingFirm marketingFirm = new MarketingFirm(sweepstakesManager, marketingFirmName);
            marketingFirm.CreateSweepstake();
            //sweepstakesManager.GetSweepstakes();
        }
    }
}
