using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Contestant
    {
        //member variables(Has A)
        private string firstName;
        private string lastName;
        private string emailAddress;
        Guid registrationNumber;

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
        public string EmailAddress
        {
            get
            {
                return emailAddress;
            }
            set
            {
                emailAddress = value;
            }
        }
        public Guid RegistrationNumber
        {
            get
            {
                return registrationNumber;
            }
            set
            {
                registrationNumber = value;
            }
        }
        //constuctor(Spawner)
        public Contestant()
        {

            this.firstName = UserInterface.GetFirstName();
            this.lastName = UserInterface.GetLasttName();
            this.emailAddress = UserInterface.GetEmailAddress();
            this.registrationNumber = UserInterface.GetRegistrationNumber();

        }
        

        //member method(Can do)
        
    }
}
