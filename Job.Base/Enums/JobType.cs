using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace Job.Base
{
    public enum JobType
    {
        [Description("Create a DNA Design")]
        DnaDesign,
        [Description("Import a DNA Design")]
        DnaImport
    }
}
