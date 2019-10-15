using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class MarketingFirm
    {
        //member variables(Has A)
        public ISweepStakesManager managerDecision;
        public string sweepstakesName;
        //constuctor(Spawner)

        //member method(Can do)
        public ISweepStakesManager ChooseManager()
        {
            managerDecision = UserInterface.ChooseBetweenStackOrQueue();            
            return managerDecision;
        }
        public string ChooseSweepstakesName()
        {
            sweepstakesName = UserInterface.ChooseSweepStakesName();
            Console.WriteLine("The name of your sweepstake is " + sweepstakesName);   
            return sweepstakesName;
        }
        public void CreateSweepstakes()
        {
            Sweepstakes sweepstake = new Sweepstakes(sweepstakesName);
            managerDecision.InsertSweepStakes(sweepstake);
        }
        public void CreateContestants()
        {

        }
    }
}
