using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesStackManager: ISweepstakesManager
    {
         
        Stack<Sweepstakes> StackOfSweepStakes = new Stack<Sweepstakes>();
        public Sweepstakes GetSweepstakes()
        {
            return StackOfSweepStakes.Pop();
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            StackOfSweepStakes.Push(sweepstakes);
        }
    }
}

