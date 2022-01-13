using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDelegate
{
    class App
    {
        /*
        public App()
        {
            SCV scv = new SCV();
            scv.Gather(this.GaterMinerals);
        }
        */
        /*
        public App()
        {
            Barracks barracks = new Barracks();
            Marine marine = barracks.CreateMarine(CreateMarineHandler);
            Console.WriteLine(marine);
        }
        */

       public App()
        {
            Hack hack = new Hack();
            hack.OnDisplayMessageBeforeExplode = OnDisplayMessageBeforExplodeHandler;
            hack.Explode();
        }
        private void GaterMinerals(int amount)
        {
            Console.WriteLine("scv가 {0} 미네날을 채취 합니다.",amount);
        }

        private Marine CreateMarineHandler()
        {
            return new Marine();
        }

        private void OnDisplayMessageBeforExplodeHandler() 
        {
            Console.WriteLine("핵이 감지 되었습니다.");
        }
    }
}
