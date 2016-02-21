using DistributedSchedulingExperiments.Model;

namespace DistributedSchedulingExperiments.Schedulers
{
    public interface IScheduler
    {
        /// <summary>
        /// Create a cluster
        /// </summary>
        /// <returns></returns>
        ICluster Cluster();

        /// <summary>
        /// Generate a schedule for the given units of work
        /// </summary>
        /// <param name="work"></param>
        void Schedule(params Work[] work);
    }
}
