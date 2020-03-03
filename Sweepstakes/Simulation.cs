﻿using System;
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
            MarketingFirm marketingFirm = new MarketingFirm(ManagerFactory.GetManager(UserInterface.ChooseManagerPrompt()));
            marketingFirm.CreateSweepstake();
        }
    }
}
