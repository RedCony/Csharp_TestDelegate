using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDelegate
{
    class Marine
    {
        private string name;
        public Marine() { }
        ~Marine() { }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public Marine(string name)
        {
            this.name = name;
        }
    }
}
