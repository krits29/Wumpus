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
        private int currentScore;

        public Player(String name)
        {
            player = name ;
            currentScore = 0;
        }
        
        public int getCurrentScore()
        {
            return this.currentScore;
        }
        
        public String getPlayer()
        {
            return this.player;
        }

        public void currentCave()
        {
            // call cave
        }

        public void updateScore(int update)
        {
            this.currentScore += update;
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
