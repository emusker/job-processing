using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace Job.Base
{
    public enum JobState
    {
        [Description("accepted by the job stack for processing")]
        Queued,
        [Description("job has begun processing")]
        Processing,
        [Description("job encountered an error while processing")]
        Error,
        [Description("job has completed successfully")]
        Complete
    }
}
