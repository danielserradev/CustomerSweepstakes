using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class SweepstakesQueueManager : ISweepStakesManager
    {
        //member variables(Has A)
        Queue<Sweepstakes> myQ = new Queue<Sweepstakes>();
        //constuctor(Spawner)

        //member method(Can do)
        public void InsertSweepStakes(Sweepstakes sweepstake)
        {
            myQ.Enqueue(sweepstake);
            Console.WriteLine("Your Sweepstake Queue has an amount of {0}.", myQ.Count);
            foreach (Sweepstakes item in myQ)
            {
                Console.WriteLine(item);
            }
        }
         public Sweepstakes GetSweepstakes()
        {
            return myQ.Dequeue();
        }
    }
}
