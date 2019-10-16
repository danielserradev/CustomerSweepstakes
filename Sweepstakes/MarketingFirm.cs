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
        public ISweepStakesManager manager;
        public string sweepstakesName;        
        public int winner;
        //constuctor(Spawner)

        //member method(Can do)
        public ISweepStakesManager ChooseManager()
        {
            manager = UserInterface.ChooseBetweenStackOrQueue();            
            return manager;            
        }
        public void CreateSweepstakes()
        { 
            Sweepstakes sweepstake = new Sweepstakes(sweepstakesName);            
            PickAmountOfContestants(sweepstake);
            sweepstake.PrintContestentInfo();
            manager.InsertSweepStakes(sweepstake);
            if(UserInterface.DecisionToCreateMoreSweepstakes() == "yes")
            {
                //ChooseSweepstakesName();
                CreateSweepstakes();
            }
            else
            {
                GrabSweepstakes();
            }           
        }
        public void PickAmountOfContestants(Sweepstakes sweepstakes)
        {
            int amount = UserInterface.PickAmountOfContestents();
            for (int i = 0; i < amount; i++)
            {                
                sweepstakes.RegisterContestant(new Contestant());
            }
        }
        public void GrabSweepstakes()
        {            
            Sweepstakes sweepstake = manager.GetSweepstakes();           
            sweepstake.PickWinner();
            if (UserInterface.DecisionToCreateMoreSweepstakes() == "yes")
            {
                //ChooseSweepstakesName();
                CreateSweepstakes();
            }
            else if(UserInterface.DecisionToCreateMoreSweepstakes() == "no")
            {
                GrabSweepstakes();
            }
            else
            {
                
            }
        }        
    }
}
