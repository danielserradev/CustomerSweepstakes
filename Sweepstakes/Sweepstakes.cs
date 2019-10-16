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
        private string name;
        Dictionary<Guid, string> list = new Dictionary<Guid, string>();
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        //constuctor(Spawner)
        public Sweepstakes(string name)
        {
            contestants = new List<Contestant>();
            this.name = UserInterface.ChooseSweepStakesName();
        }

        //member method(Can do)
        //public Contestant PickWinner()
        //{
            
        //}

        public void RegisterContestant(Contestant contestant)
        {
            
            list.Add(contestant.RegistrationNumber, contestant.FirstName + " " + contestant.LastName + " " + contestant.EmailAddress);

            foreach (KeyValuePair<Guid, string> pair in list)
            {
                Console.WriteLine(pair.Key + " - " + pair.Value);
            }
        }
        public void PrintContestentInfo(Contestant contestant)
        {
            
            
        }
    }
}
