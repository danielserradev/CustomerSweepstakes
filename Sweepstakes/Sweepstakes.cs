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
        //public List<Contestant> contestants;
        private string name;
        public Dictionary<Guid, Contestant> contestants = new Dictionary<Guid, Contestant>();
        Random rng = new Random();
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
            this.name = UserInterface.ChooseSweepStakesName();
        }
        public void RegisterContestant(Contestant contestant)
        {            
            contestants.Add(contestant.RegistrationNumber, contestant);
        }
        public void PrintContestentInfo()
        {
            Console.WriteLine("The registered contestants for the {0} Sweepstake are listed below.", Name);
            foreach (KeyValuePair<Guid, Contestant> pair in contestants)
            {
                Console.WriteLine(pair.Key + " - " + pair.Value.FirstName + " " + pair.Value.LastName);
            }
        }
        public void PickWinner()
        {
            List<Guid> KeyList = new List<Guid>(contestants.Keys);
            Guid randomnKey = KeyList[rng.Next(KeyList.Count)];
            Contestant winner = contestants[randomnKey];
            Console.WriteLine("Congratulations to " + winner.FirstName + " " + winner.LastName + " for winning the Sweepstake! ");
        }
    }
}
