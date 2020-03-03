using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wumpus
{
    class GameLocations
    {
        private int WumpusRoom;

        //public GameLocations()
        //{
        //    constructor not necessary???
        //}

        // a lot of these are going to call Cave

        public void getCaveMap()
        {
            // which cave map are we using
        }

        public void updateWumpus(Random ness)
        {
            this.WumpusRoom = ness.nextInt(52);
        }
        
        public int getWumpusRoom()
        {
            return this.WumpusRoom;
        }

      

    }
}
