using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGPOEPart1
{
    internal class Module
    {
        public Module()
        {
        }

        public string ModuleCode { get; set; }
        public string ModuleName { get; set; }
        public int Credits { get; set; }
        public int ClassesPerWeek { get; set; }
        public int NumWeeks { get; set; }
        public DateTime StartDate  { get; set; }

    }
}
