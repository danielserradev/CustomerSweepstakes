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
        public static int GetRegistrationNumber()
        {
            Console.WriteLine("What is your registration number?");
            return int.Parse(Console.ReadLine());

        }
    }
}
