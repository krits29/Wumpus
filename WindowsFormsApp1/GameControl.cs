using System;
using System.Collections.Generic;
using System.Text;

namespace Wumpus
{
    class GameControl
    {
        private int gameState;
        private Boolean displayingMainMenu;
        private Boolean displayingHighScorePage;
        private Boolean displayingInstructions;
        private Boolean launchedGame;


        public GameControl()
        {

        }

        public int getGameState()
        {
            //accessor for the game state: planning on 0: entry screen, 1: in game,
            //2: viewing high scores, or instructions
            return gameState;
        }

        public void setGameState(int gameState)
        {
            //mutator for game state variable
            this.gameState = gameState;
        }

        public void mainMenuActivated()
        {
            displayingMainMenu = true;
            //passes onto UI, passes onto highscore, etc. if triggered
        }

        public void highScorePageActivated()
        {
            if (displayingMainMenu)
            {
                displayingMainMenu = false;
                displayingHighScorePage = true;
                gameState = 2;
            }
            //passes onto highscore
        }

        public void launchGameActivated()
        {
            if (displayingMainMenu)
            {
                displayingMainMenu = false;
                launchedGame = true;
                gameState = 1;
            }
            //passes onto game creation: player, location, UI, etc.
        }

        public void instructionsActivated()
        {
            if (displayingMainMenu)
            {
                displayingInstructions = true;
                displayingMainMenu = false;
                gameState = 2;
            }
            //passes onto instructions page (UI)
        }

        public void goBack(){
            displayingMainMenu = true;
            displayingInstructions = false;
            launchedGame = false;
            displayingHighScorePage = false;
            gameState = 0;
        }

        public String instructions(){
            String str = "";
            str += "Use the arrow keys or WASD to move";
            str += "\nThe object of the game is to shoot the Wumpus.";
            str += "\nGood luck!";
        
            return str;

        }



    }
}