using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DistributedSchedulingExperiments.Model;

namespace DistributedSchedulingExperiments.Schedulers.Identity
{
    public class Scheduler
        : IScheduler
    {
        public ICluster Cluster()
        {
            throw new NotImplementedException();
        }

        public void Schedule(params Work[] work)
        {
            throw new NotImplementedException();
        }
    }
}
