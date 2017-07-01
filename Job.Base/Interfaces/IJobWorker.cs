using System;
using System.Collections.Generic;
using System.Text;

namespace Job.Base
{
    public interface IJobWorker<Job>
    {
        void Setup();

        void DoWork();

        void TearDown();
    }
}
