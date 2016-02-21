using System;
using System.Collections.Generic;

namespace DistributedSchedulingExperiments.Model
{
    /// <summary>
    /// A unit of work which consumes some resources, and produces some more resources
    /// </summary>
    public class Work
    {
        /// <summary>
        /// Name of this work unit (for debugging)
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Time this unit of work tkes to process (of a unit speed CPU)
        /// </summary>
        public TimeSpan ProcessingTime { get; }

        /// <summary>
        /// Input resources
        /// </summary>
        public IReadOnlyList<Resource> Input { get; }

        /// <summary>
        /// Output resources
        /// </summary>
        public IReadOnlyList<Resource> Output { get; }

        public Work(string name, TimeSpan processingTime, IReadOnlyList<Resource> input, IReadOnlyList<Resource> output)
        {
            Name = name;
            ProcessingTime = processingTime;
            Input = input;
            Output = output;
        }
    }
}
