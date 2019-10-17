using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class ManagerFactory
    {
        ISweepStakesManager manager;
        public ManagerFactory()
        {
            
        }
        public  ISweepStakesManager ChooseManager()
        {
            manager = UserInterface.ChooseBetweenStackOrQueue();
            return manager;
        }
    }
}
