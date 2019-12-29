using System;

namespace NumberGuess {
    class Program {
        static void Main (string[] args) {
            //get header
            Header ();
            //get greeting info
            Greeting ();

            //will run nonstop
            while (true) {
                //set correct num
                //int correctNumber = 7;
                //make new random object
                Random rand = new Random ();
                int correctNumber = rand.Next (1, 10);

                //guess
                int guess = 0;

                //ask to get
                Console.WriteLine ("Guess a number between 1 and 10");

                //guesses
                while (guess != correctNumber) {
                    //get guess input
                    string input = Console.ReadLine ();

                    //make sure its a number
                    if (!int.TryParse (input, out guess)) {
                        //add warning if NaN with color and message
                        ColorMessage(ConsoleColor.Red, "Enter a number!");
                        continue;
                    }

                    //put in guess and cast to int
                    guess = Int32.Parse (input);

                    //match guess to correct number
                    if (guess != correctNumber) {
                        ColorMessage(ConsoleColor.Red, "Wrong try again!");
                    }
                }
                //output success message
                ColorMessage(ConsoleColor.Green, "Correct!");

                //ask to play again
                Console.WriteLine ("Play again? [y or n]");

                //get answer and chane to uppercase
                string answer = Console.ReadLine ().ToUpper ();

                if (answer == "Y") {
                    continue;
                } else if (answer == "N") {
                    return;
                } else {
                    return;
                }
            }

        }
        static void Header () {

            //HEADER
            //set app vars
            string appName = "Number Guessser";
            string appVersion = "1.0.0";
            string appAuthor = "Bryan B.";

            //change text color
            Console.ForegroundColor = ConsoleColor.Green;
            //write app info
            Console.WriteLine ("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            //set color back to normal
            Console.ResetColor ();
        }
        static void Greeting () {
            //ask user for name
            Console.WriteLine ("What is your name?");

            //get input
            string inputName = Console.ReadLine();

            Console.WriteLine ("Hello {0} lets play a game MUHAHAHA", inputName);

        }
        static void ColorMessage(ConsoleColor color, string message){
            Console.ForegroundColor = color;
            Console.WriteLine (message);
            Console.ResetColor ();
        }
    }
}