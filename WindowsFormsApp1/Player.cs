using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wumpus
{
    class Player
    {

        private String player;

        public Player(String name)
        {
            player = name ;
        }

        public void currentCave()
        {
            // call cave
        }

        public int currentScore()
        {
            int score = 0;

            //more stuff
            //calling methods to retrieve score

            return score;
        }

        public Boolean safeFromWumpus()
        {
            Boolean isSafe = true;

            //more methods
            //calling game loc

            return isSafe;
        }

        public Boolean safeFromBottomlessPit()
        {
            Boolean isSafe = true;

            //more methods
            //calling game loc

            return isSafe;
        }

        public Boolean safeFromHazards()
        {
            Boolean isSafe = true;

            //more methods
            //calling game loc

            return isSafe;
        }

    }
}
