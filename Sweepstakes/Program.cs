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
            marketingFirm.CreateSweepstakes();



            Console.ReadLine();
        }
    }
}
