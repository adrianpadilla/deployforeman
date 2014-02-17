using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adrianpadilla.deployforeman
{
    public abstract class ConfigCheck
    {
        CheckResult Result { get; set; }

        public abstract void PerformCheck();


    }
}
