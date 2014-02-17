using System;
using System.Collections.Generic;
namespace adrianpadilla.deployforeman
{
    public class CheckController
    {
        public ICheckListParser CheckListParser { get; set; }
        public IEnumerable<ConfigCheck> ConfigrationChecks { get; set; }

        public void RunChecks()
        {
            foreach (var item in ConfigrationChecks)
            {
                item.PerformCheck();
                
            }
        }
    }
}
