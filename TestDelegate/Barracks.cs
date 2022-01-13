using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDelegate
{
    class Barracks
    {
        List<Marine> marine;
        Barracks barracks;
        public delegate Marine DelCreateMarine();
        public Barracks() { marine = new List<Marine>(); }
        ~Barracks() { }

        public Marine CreateMarine(DelCreateMarine callback)
        {
            return callback();
        }

    }
}
