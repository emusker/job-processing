using System;
using System.Collections.Generic;
using System.Text;

namespace Job.Base
{
    public class Job
    {
        public JobType JobType { get; private set; }
        public IJobParams JobParams { get; private set; }

        // this will likely be updated by the worker... how to protect properly
        public JobState JobState { get; private set; }

        public Job(JobType jobType, IJobParams jobParams)
        {
            JobType = jobType;
            JobParams = jobParams;
            JobState = JobState.Queued;
        }
    }
}
