using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Program
    {
        //member variables(Has A)

        //constuctor(Spawner)

        //member method(Can do)
        static void Main(string[] args)
        {
            MarketingFirm marketingFirm = new MarketingFirm();
            marketingFirm.ChooseManager();
            marketingFirm.ChooseSweepstakesName();
            marketingFirm.CreateSweepstakes("Vacation");


            Sweepstakes sweepstakes = new Sweepstakes("vacation");
            Contestant contestant1 = new Contestant();
            Contestant contestant2 = new Contestant();
            
            sweepstakes.RegisterContestant(contestant1);
            sweepstakes.RegisterContestant(contestant2);

            Console.ReadLine();
        }
    }
}
