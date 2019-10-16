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
            Console.WriteLine("You have {0} sweepstacks in the Queue", myQ.Count);
            foreach (Sweepstakes item in myQ)
            {
                Console.WriteLine(item.contestants);
            }
        }
         public void GetSweepstakes(ISweepStakesManager sweepStakesManager)
        {

        }



    }
}
