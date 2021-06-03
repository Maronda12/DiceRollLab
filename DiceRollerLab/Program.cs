using System;

namespace DiceRollerLab
{
    class Program
    {
        static void Main(string[] args)
        {
          

            string Continue = "true";
            while (Continue == "true")
            {
            Start:
                //asks user to enter number of sides
                string input = GetUserInput("How many sides would you like your pair of dice to have?");

                // try & catch to fix exceptions


                try
                {
                    int sides = int.Parse(input);
                    Console.WriteLine($"Dice will have {input} sides");
                    GetRandom(sides);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a valid side for the dice");

                }

                Console.WriteLine("Would you like to roll again?");
                string input2 = Console.ReadLine().ToLower().Trim();

                if (input2 == "yes" || input2 == "y")
                {

                    goto Start;
                }
                else
                {
                    Console.WriteLine("Goodbye");






                }
            }
        }

       

        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            return input;

        }

        public static void GetRandom(int sides)
        {

            Random r = new Random(); //createa a random number
            int dice1 = r.Next(1, sides + 1);
            int dice2 = r.Next(1, sides + 1);
            int total = dice1 + dice2;
            Console.WriteLine($"Your Dice1 roll is : {dice1}");
            Console.WriteLine($"Your Dice2 roll is : {dice2}");
            Console.WriteLine($"The total is: {total}");
        }
        //outputs

        public static string RollOutput(int dice1, int dice2)
        {
            int total = dice1 + dice2;

            if (dice1 == 1 && dice2 == 1)
            {
                return "Snake Eyes!!";
            }
            else if (dice1 == 1 && dice2 == 2 || dice2 == 1 && dice1 == 2)
            {
                return "Ace Deuce!!";
            }
            else if (dice1 == 6 && dice2 == 6)
            {
                return "Box Cars";
            }
            else if (total == 7 || total == 11)
            {
                return "Win!!";
            }
            else _ = (total == 2 || total == 3 || total == 12);
            {
                return "Craps";
            }
        }


       


            
        


    }
}

/* The application asks the user to enter the number of sides for a pair of dice.
● The application prompts the user to roll the dice.
● The application “rolls” two n-sided dice, displaying the results of each along with a total
● For 6-sided dice, the application recognizes the following dice combinations and
displays a message for each. It should not output this for any other size of dice.
○ Snake Eyes: Two 1s
○ Ace Deuce: A 1 and 2
○ Box Cars: Two 6s
○ Win: A total of 7 or 11
○ Craps: A total of 2, 3, or 12 (will also generate another message!)
● The application asks the user if he/she wants to roll the dice again */