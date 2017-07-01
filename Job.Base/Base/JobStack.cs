using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;

namespace Job.Base
{
    public class JobStack<TJobType>
    {
        int Capacity;

        public ConcurrentQueue<Job> Jobs { get; private set; }

        private object _lockToken = new object();

        public void AddJob(Job job)
        {
            lock (_lockToken)
            {
                Jobs.Enqueue(job);
            }
        }

        public void RemoveJob(Job job)
        {
            Job removedJob;
            lock (_lockToken)
            {
                Jobs.TryDequeue(out removedJob);
            }

            if (removedJob == null)
                throw new Exception($"failed to remove job. JobType: {job.JobType}. JobParams: {job.JobParams.ToString()}.");
        }

        public IEnumerable<Job> GetActiveJobs()
        {
            return Jobs.Where(j => j.JobState != JobState.Queued);
        }

        public IEnumerable<Job> GetQueuedJobs()
        {
            return Jobs.Where(j => j.JobState == JobState.Queued);
        }

    }
}
