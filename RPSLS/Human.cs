using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Human : Player
    {
        //member variables
        string[] roundOptions = { "Rock", "Paper", "Scissors", "Lizard", "Spock" };

        //constructor
        public Human()
        {
        }
        public override void SetName()
        {
            Console.WriteLine($"Please enter your name");
            try
            {
                name = Console.ReadLine();
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Please enter a valid name");
            }
        }
        public override void GetShoot()
        {
            Console.WriteLine("Pick One, type: \n '0' for Rock, \n '1' for Paper, \n '2' for Scissors, \n '3' for Lizard, or \n '4' for Spock.");
            shoot = int.Parse(Console.ReadLine().Trim());

            switch (shoot)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine("Opps, please pick a valid option, try again");
                    Console.ReadLine();
                    break;
            }
        }
    }
}