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

            Contestant contestant1 = new Contestant();            
            //Contestant contestant2 = new Contestant();
            //Contestant contestant3 = new Contestant();
            Sweepstakes sweepstakes = new Sweepstakes("vacation");
            sweepstakes.RegisterContestant(contestant1);


            //Console.WriteLine(contestant1.FirstName);
            //Console.WriteLine(contestant1.LastName);
            //Console.WriteLine(contestant1.EmailAddress);
            //Console.WriteLine(contestant1.RegistrationNumber);
            //Console.WriteLine(contestant2.FirstName);
            //Console.WriteLine(contestant2.LastName);
            //Console.WriteLine(contestant2.EmailAddress);
            //Console.WriteLine(contestant2.RegistrationNumber);

            Console.ReadLine();
        }
    }
}
