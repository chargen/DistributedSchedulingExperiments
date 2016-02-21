using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistributedSchedulingExperiments.Model
{
    public interface ICluster
    {
        IPeer Peer(string name, float cpu, ulong disk, ulong memory);
    }
}
