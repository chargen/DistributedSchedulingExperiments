namespace DistributedSchedulingExperiments.Model
{
    /// <summary>
    /// A resource which is input or output of a unit of work
    /// </summary>
    public class Resource
    {
        /// <summary>
        /// Name of this resource
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// SIze of this resource (in bytes)
        /// </summary>
        private int Size { get; }

        public Resource(string name, int size)
        {
            Name = name;
            Size = size;
        }
    }
}
