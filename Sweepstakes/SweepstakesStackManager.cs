using System;
using System.Collections.Generic;

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
            Console.WriteLine("Your Stack has an amount of {0}.", myStack.Count);
            foreach (Sweepstakes item in myStack)
            {
                Console.WriteLine(item.contestants);
            }
            
        }        
        public Sweepstakes GetSweepstakes()
        {
            return myStack.Pop();
             
        }

    }
}
