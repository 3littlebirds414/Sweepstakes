using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Sweepstakes
    {
        public int size;
        public string Name;
        public string email;
        public int random;

        Dictionary<int, Contestant> SweepstakesList = new Dictionary<int, Contestant>();

        public Sweepstakes(string name)
        {
            Name = name;
        }


        public int EntryNumber
        {
            get
            {
                return (SweepstakesList.Count - 1);
            }
        }

        public int Size
        {
            get
            {
                return  SweepstakesList.Count;
            }
            //set
            //{
            //    size = value;
            //}
        }

        public void RegisterContestant(Contestant contestant)
        {
            SweepstakesList.Add(EntryNumber, contestant);
        }

        public string PickAWinner()
        {
            Random randomNumber = new Random();
            Contestant winner = SweepstakesList[randomNumber.Next(0, Size)];
            return winner.name;
        }

        private int GetRandomNumer(int upperBound)
        {
            Random random = new Random();
            return random.Next(1, upperBound);
            
        }

        public void ReturnWinner(Contestant contestant)
        {
            Console.WriteLine("Winner {0} is going to have a GREAT DAY!!!\n", contestant.name);
            Console.WriteLine("Let them know by emailing them at:  {0}\n", contestant.Email);

        }
    }
}
