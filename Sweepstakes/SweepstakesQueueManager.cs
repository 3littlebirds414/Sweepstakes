using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesQueueManager: ISweepstakesManager
    {
        
        Queue<Sweepstakes> QueueOfSweepstakes = new Queue<Sweepstakes>();
        public Sweepstakes GetSweepstakes()
        {
            return QueueOfSweepstakes.Dequeue();
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            QueueOfSweepstakes.Enqueue(sweepstakes);
        }
    }
}

