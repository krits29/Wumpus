using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WumpusTest
{
    class GameLocations
    {
        private String gameLoc;

        public GameLocations(String name)
        {
            gameLoc = name;
        }

        // a lot of these are going to call Cave

        public void getCaveMap()
        {
            // which cave map are we using
        }

        public int wumpusRoom()
        {
            int room = 0;
            //calling cave
            return room;
        }

      

    }
}
