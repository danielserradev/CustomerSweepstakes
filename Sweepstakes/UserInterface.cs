using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public static class UserInterface
    {
        //member variables(Has A)

        //constuctor(Spawner)

        //member method(Can do)
        public static string GetFirstName()
        {
            Console.WriteLine("What is your first name?");
            return Console.ReadLine();            
        }
        public static string GetLasttName()
        {
            Console.WriteLine("What is your last name?");
            return Console.ReadLine();
        }
        public static string GetEmailAddress()
        {
            Console.WriteLine("What is your email address?");
            return Console.ReadLine();
        }
        public static Guid GetRegistrationNumber()
        {
            return Guid.NewGuid();
        }
        public static ISweepStakesManager ChooseBetweenStackOrQueue()
        {
            Console.WriteLine("Would you like to use a Stack Manager or Queue Manaager?");
            string choice = Console.ReadLine();
            switch (choice.ToLower())
            {
                case "stack":
                    Console.WriteLine("You have choosen a {0} manager", choice);
                    return new SweepstakesStackManager();
                case " queue":
                    Console.WriteLine("You have choosen a {0} manager", choice);
                    return new SweepstakesQueueManager();
                default:
                    //Console.WriteLine("Please enter 'stack' or 'queue'.");
                    //ChooseBetweenStackOrQueue();
                    throw new ApplicationException(string.Format("Not a valid manager choice"));
            }
            
            
            
        }
        public static string ChooseSweepStakesName()
        {
            Console.WriteLine("What would you like the name of your SweepStakes to be?");
            string sweepstakesName = Console.ReadLine();
            return sweepstakesName;
        }

    }
}
