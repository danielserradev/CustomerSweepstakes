using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Sweepstakes
    {
        //member variables(Has A)
        public List<Contestant> contestants;
        string name;
        

        //constuctor(Spawner)
        public Sweepstakes(string name)
        {
            contestants = new List<Contestant>();
            this.name = name;
        }

        //member method(Can do)
        //public Contestant PickWinner()
        //{
            
        //}

        public void RegisterContestant(Contestant contestant)
        {
            //contestent.Add(contestent);
        }
        public void PrintContestentInfo(Contestant contestant)
        {
            
            
        }
    }
}
