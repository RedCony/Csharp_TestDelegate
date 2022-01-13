using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDelegate
{
    class Hack
    {
        public delegate void DelDiplayMessage();
        public Hack() { }
        ~Hack() { }
        public DelDiplayMessage OnDisplayMessageBeforeExplode;
        public void Explode()
        {
            OnDisplayMessageBeforeExplode();
            Console.WriteLine("쿠쾅쾅쾅~~~콰~~앙~~");
        }
    }
}
