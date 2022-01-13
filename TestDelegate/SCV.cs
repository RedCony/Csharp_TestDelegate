using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDelegate
{
    class SCV
    {
        public delegate void DelGaterMinerals(int amount);
        public SCV() { }
        ~SCV() { }

        public void Gather(DelGaterMinerals callback)
        {
            callback(1);
        }
    }
}
