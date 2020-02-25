using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormApp1
{
    class GameControl
    {
        private int gameState;
        private Boolean displayMainMenu;
        private Boolean displayHighScorePage;
        private Boolean displayInstructions;
        private Boolean launchGame;


        public GameControl()
        {

        }

        public int getGameState()
        {
            //accessor for the game state: planning on 0: entry screen, 1: in game,
            //2: viewing high scores, or something like that
            return gameState;
        }

        public void setGameState(int gameState)
        {
            //mutator for game state variable
            this.gameState = gameState;
        }

        public void mainMenuActivated()
        {
            displayMainMenu = true;
            //passes onto UI, passes onto highscore, etc. if triggered
        }

        public void highScorePageActivated()
        {
            if (displayMainMenu)
            {
                displayHighScorePage = true;
            }
            //passes onto highscore
        }

        public void launchGameActivated()
        {
            if (displayMainMenu)
            {
                launchGame = true;
                gameState = 1;
            }
            //passes onto game creation: player, location, UI, etc.
        }
        public void instructionsActivated()
        {
            if (displayMainMenu)
            {
                displayInstructions = true;
            }
            //passes onto instructions page (UI)
        }



    }
}