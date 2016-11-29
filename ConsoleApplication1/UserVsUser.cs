using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication1
{
    public class UserVsUser
    {
        string name, otherPlayer, user1Input, user2Input;

        public string GetName()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            return name;
            Console.WriteLine("Ok, what is the other players name?");
            string otherPlayer = Console.ReadLine();
            return otherPlayer;
            Console.WriteLine("Hi {0} and {1}, let's play!", name, otherPlayer);
            playUsers();
        }
    

        public void playUsers()
        {
            Console.WriteLine();

    }
}

//Scissors cuts Paper
//Scissors decapitates Lizard

//Rock crushes Lizard
//Rock crushes Scissors

//Lizard poisons Spock
//Lizard eats Paper

//Spock smashes Scissors
//Spock vaporizes Rock

//Paper covers Rock
//Paper disproves Spock

