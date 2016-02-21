using System;
using DistributedSchedulingExperiments.Model;
using DistributedSchedulingExperiments.Schedulers.Identity;;

namespace DistributedSchedulingExperiments
{
    class Program
    {
        static void Main(string[] args)
        {
            //create some resources which will be in the pipeline
            var normalInput = new Resource("normal texture", 1024 * 1024 * 4);
            var normalIntermediate = new Resource("intermediate texture", 1024 * 1024 * 4);
            var normalDxt = new Resource("normal output", 1024 * 1024);

            //setup some work to do
            var normalProcess = new Work("process normals", TimeSpan.FromSeconds(1), new [] { normalInput }, new [] { normalIntermediate });
            var normalEncode = new Work("encode normals", TimeSpan.FromSeconds(1), new[] { normalIntermediate }, new[] { normalDxt });

            //Create a scheduler
            var scheduler = new Scheduler();

            //Create a cluster to run this work
            var cluster = scheduler.Cluster();

            //Create peers, assign initial resources to peers
            cluster.Peer("storage", cpu: 1, disk: ulong.MaxValue, memory: 1000000000)
                .Store(normalInput);
            cluster.Peer("cpu", cpu: 128, disk: 0, memory: 1000000000);

            //Run the jobs through the scheduler
            var schedule = scheduler.Schedule(normalProcess, normalEncode);

            //Print statstics of schedule
            //todo: ^
        }
    }
}
