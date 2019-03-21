using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Program
    {
        static void Main(string[] args)
        {


            Contestant jimmy = new Contestant("Jimmy","Neutron", "123@fakedotcom", "1");
            Contestant anna = new Contestant("Anna", "Nicole", "anna@aol.com", "2");
            Contestant john = new Contestant("John", "Neeappleseed","john@fakedotcom", "3");
            Contestant tom = new Contestant("Tom", "Tomdrum", "tom@aol.com", "4");
            Contestant tim = new Contestant("Tim", "Thetoolmantaylor", "tim@fakedotcom", "5");
            Contestant marypat = new Contestant("Mary Pat", "Down", "mp@aol.com", "6");

            List<Contestant> contestantList = new List<Contestant>() { jimmy, anna, john, tom, tim, marypat };

            foreach (Contestant person in contestantList)
            {
                
                    RegisterContestant(person);
                
            }

            SweepstakesQueueManager queueManager = new SweepstakesQueueManager();
            SweepstakesStackManager stackManager = new SweepstakesStackManager();

            //foreach (Sweepstakes sweepstakes in listOfSweepstakes)
            //{
            //    queueManager.InsertSweepstakes(sweepstakes);
            //}

            //foreach (Sweepstakes sweepstakes in listOfSweepstakes)
            //{
            //    stackManager.InsertSweepstakes(sweepstakes);
            //}


        }
    }
}
