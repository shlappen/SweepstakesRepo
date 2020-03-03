using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    static class ManagerFactory
    {
        public static ISweepstakesManager GetManager(string manager)
        {
            switch (manager.ToLower())
            {
                case "queue":
                    return new SweepstakesQueueManager();
                case "stack":
                    return new SweepstakesStackManager();
                default:
                    throw new ApplicationException(string.Format("Please enter Stack or Queue."));
            }
        }

    }
}
