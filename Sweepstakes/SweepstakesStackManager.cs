using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class SweepstakesStackManager : ISweepStakesManager 
    {
        //member variables(Has A)
        Stack<Sweepstakes> myStack = new Stack<Sweepstakes>();
        //constuctor(Spawner)
        public SweepstakesStackManager()
        {
            
        }
        //member method(Can do)
        public void InsertSweepStakes(Sweepstakes sweepstake)
        {            
            myStack.Push(sweepstake);
            Console.WriteLine("You have {0} sweepstacks in the Stack", myStack.Count);
            foreach (Sweepstakes item in myStack)
            {
                Console.WriteLine(item.contestants);
            }
            
        }        
        public void GetSweepstakes(ISweepStakesManager sweepStakesManager)
        {
            
            
        }

    }
}
