using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Game
    {
        Player playerOne;
        Player playerTwo;

        public Game()
        {
            playerOne = new Human();
        }

        private void Welcome()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock!"
                + " \n Instructions:" 
                + " \n 1) Select player1 vs. Ralph the computer or player1 vs. player2"
                + " \n 2) Outcomes"
                + " \n Scissors cuts Paper"
                + " \n Paper covers Rock"
                + " \n Rock crushes Lizard"
                + " \n Lizard poisons Spock"
                + " \n Spock smashes Scissors"
                + " \n Scissors decapitate Lizard"
                + " \n Lizard eats Paper"
                + " \n Paper disproves Spock"
                + " \n Spock vaporizes Rock"
                + " \n Rock destroys Scissors"
                + " \n 4) Best of three rounds wins!"
                + " \n 5) Player One always goes first"
                + " \n 6) Ready to play?"
                + " \n type: 'yes' to get started");
            string readInstructions = Console.ReadLine().ToLower().Trim();

            switch (readInstructions)
            {
                case "yes":
                    playerOne.SetName();
                    break;
                default:
                    Console.WriteLine("Please read through the instructions and type yes to get started");
                    Welcome();
                    break;
            }
        }
        private void GetPlayers()
        {
            Console.WriteLine($"Hi {playerOne.name}, who are you playing against?"
                + " \n type: 'player' for a second player or 'AI' to play against the computer");
            string playerSelect = Console.ReadLine().Trim();

            switch (playerSelect)
            {
                case "player":
                    playerTwo = new Human();
                    playerTwo.SetName();
                    break;
                case "AI":
                    playerTwo = new AI();
                    break;
                default:
                    Console.WriteLine("Please select who you will be playing against");
                    GetPlayers();
                    break;
            }
        }
        private void playRound()
        {
            while (playerOne.score < 2 && playerTwo.score < 2)
            {
                playerOne.GetShoot();
                playerTwo.GetShoot();
                Outcome();
            }
            displayWinner();
        }

        private void Outcome()
        {
            if (playerOne.shoot == playerTwo.shoot)
            {
                Console.WriteLine("It was a tie, please pick again!");
                Console.ReadLine();
                playRound();
            }
            else if (playerOne.shoot == 0)
            {
                if (playerTwo.shoot == 1)
                {
                    Console.WriteLine($"{playerOne.name} chose rock, \n {playerTwo.name} chose paper, \n paper covers rock; \n {playerOne.name} wins this round!");
                    playerOne.score++;
                    playRound();
                }
                else if (playerTwo.shoot == 2)
                {
                    Console.WriteLine($" {playerOne.name} chose rock, \n {playerTwo.name} chose scissors, \n rock destroys scissors; \n {playerOne.name} wins this round!");
                    playerOne.score++;
                    playRound();
                }
                else if (playerTwo.shoot == 3)
                {
                    Console.WriteLine($" {playerOne.name} chose rock, \n {playerTwo.name} chose lizard, \n rock crushes lizard; \n {playerOne.name} wins this round!");
                    playerOne.score++;
                    playRound();
                }
                else if (playerTwo.shoot == 4)
                {
                    Console.WriteLine($" {playerOne.name} chose rock, \n {playerTwo.name} chose spock, \n spock vaporizes rock; \n {playerTwo.name} wins this round!");
                    playerTwo.score++;
                    playRound();
                }
            }
            else if (playerOne.shoot == 1)
            {
                if (playerTwo.shoot == 0)
                {
                    Console.WriteLine($" {playerOne.name} chose paper, \n {playerTwo.name} chose rock, \n paper covers rock; \n {playerOne.name} wins this round!");
                    playerOne.score++;
                    playRound();
                }
                else if (playerTwo.shoot == 2)
                {
                    Console.WriteLine($" {playerOne.name} chose paper, \n {playerTwo.name} chose scissors, \n scissors cut paper; \n {playerTwo.name} wins this round!");
                    playerTwo.score++;
                    playRound();
                }
                else if (playerTwo.shoot == 3)
                {
                    Console.WriteLine($" {playerOne.name} chose paper, \n {playerTwo.name} chose lizard, \n lizard eats paper; \n {playerOne.name} wins this round!");
                    playerOne.score++;
                    playRound();
                }
                else if (playerTwo.shoot == 4)
                {
                    Console.WriteLine($" {playerOne.name} chose paper, \n {playerTwo.name} chose spock, \n paper disproves spock; \n {playerOne.name} wins this round!");
                    playerOne.score++;
                    playRound();
                }
            }
            else if (playerOne.shoot == 2)
            {
                if (playerTwo.shoot == 0)
                {
                    Console.WriteLine($" {playerOne.name} chose scissors, \n {playerTwo.name} chose rock, \n rock destroys scissors; \n {playerOne.name} wins this round!");
                    playerOne.score++;
                    playRound();
                }
                else if (playerTwo.shoot == 1)
                {
                    Console.WriteLine($" {playerOne.name} chose scissors, \n {playerTwo.name} chose paper, \n scissors cuts paper; \n {playerOne.name} wins this round!");
                    playerOne.score++;
                    playRound();
                }
                else if (playerTwo.shoot == 3)
                {
                    Console.WriteLine($" {playerOne.name} chose scissors, \n {playerTwo.name} chose lizard, \n scissors decapitate lizard; \n {playerOne.name} wins this round!");
                    playerOne.score++;
                    playRound();
                }
                else if (playerTwo.shoot == 4)
                {
                    Console.WriteLine($" {playerOne.name} chose scissors, \n {playerTwo.name} chose spock, \n spock smashes scissors; \n {playerTwo.name} wins this round!");
                    playerTwo.score++;
                    playRound();
                }
            }
            else if (playerOne.shoot == 3)
            {
                if (playerTwo.shoot == 0)
                {
                    Console.WriteLine($" {playerOne.name} chose lizard, \n {playerTwo.name} chose rock, \n rock crushes lizard; \n {playerTwo.name} wins this round!");
                    playerTwo.score++;
                    playRound();
                }
                else if (playerTwo.shoot == 1)
                {
                    Console.WriteLine($" {playerOne.name} chose lizard, \n {playerTwo.name} chose paper, \n lizard eats paper; \n {playerOne.name} wins this round!");
                    playerOne.score++;
                    playRound();
                }
                else if (playerTwo.shoot == 2)
                {
                    Console.WriteLine($" {playerOne.name} chose lizard, \n {playerTwo.name} chose scissors, \n scissors decapitate lizard; \n {playerTwo.name} wins this round!");
                    playerTwo.score++;
                    playRound();
                }
                else if (playerTwo.shoot == 4)
                {
                    Console.WriteLine($" {playerOne.name} chose lizard, \n {playerTwo.name} chose spock, \n lizard poisons spock; \n {playerOne.name} wins this round!");
                    playerOne.score++;
                    playRound();
                }
            }
            else if(playerOne.shoot == 4)
            {
                if (playerTwo.shoot == 0)
                {
                    Console.WriteLine($" {playerOne.name} chose spock, \n {playerTwo.name} chose rock, \n spock vaporizes rock; \n {playerOne.name} wins this round!");
                    playerOne.score++;
                    playRound();
                }
                else if(playerTwo.shoot == 1)
                {
                    Console.WriteLine($" {playerOne.name} chose spock, \n {playerTwo.name} chose paper, \n paper disproves spock; \n {playerTwo.name} wins this round!");
                    playerTwo.score++;
                    playRound();
                }
                else if(playerTwo.shoot == 2)
                {
                    Console.WriteLine($" {playerOne.name} chose spock, \n {playerTwo.name} chose scissors, \n spock smashes scissors; \n {playerOne.name} wins this round!");
                    playerOne.score++;
                    playRound();
                }
                else if(playerTwo.shoot == 3)
                {
                    Console.WriteLine($" {playerOne.name} chose spock, \n {playerTwo.name} chose lizard, \n lizard poisons spock; \n {playerTwo.name} wins this round!");
                    playerTwo.score++;
                    playRound();
                }
            }
            else
            {
                Console.WriteLine("Please pick one of the following options");
                playRound();
            }
        }
    
        private void displayWinner()
        {
            if (playerOne.score > playerTwo.score)
            {
                Console.WriteLine($"{playerOne.name} Wins! Please press enter");
                Console.ReadLine();
            } else {
                Console.WriteLine($"{playerTwo.name} Wins! Please press enter");
                Console.ReadLine();
            }
            GameWinner();
        }

        private void GameWinner()
        {
            Console.WriteLine($"Please type: \n 'play again' to play the game again \n or 'exit' to exit the game.");
            string rematch = Console.ReadLine().ToLower().Trim();

            switch (rematch)
            {
                case "play again":
                    playerOne = new Human();
                    playGame();
                    break;
                case "exit":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Game Over, please pick something");
                    GameWinner();
                    break;
            }
        }

        public void playGame()
        {
            Welcome();
            GetPlayers();
            playRound();
            Outcome();
            displayWinner();
            GameWinner();
        }
    }
}
