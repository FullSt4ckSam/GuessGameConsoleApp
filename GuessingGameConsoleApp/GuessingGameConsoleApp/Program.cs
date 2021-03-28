using System;

namespace GuessingGameConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random(); //initial random object for random number generator

            bool correctNum = false;

            display1(); //welcome user
            display2(); //prompt for input

            while (true)
            {
                int randNum = rand.Next(0, 100); //generate random integer between 0 and 99
                while (correctNum == false)
                {
                    string input = Console.ReadLine();  //get input data for integer

                    bool success = Int32.TryParse(input, out int inputNum); //convert input to boolean

                    if (!success)
                    {
                        display3(); //prompt for correct input
                    }
                    else
                    {
                        if (inputNum > randNum)
                        {
                            display4(); //too high
                        }
                        else if (inputNum < randNum)
                        {
                            display6(); //too low
                        }
                        else if (inputNum == randNum)
                        {
                            Console.WriteLine("You guessed right! The guess is  {0}!", randNum);
                            display5(); //prompt to continue game
                            

                            string getStr = Console.ReadLine().ToUpper(); //get input to continue game and convert to upper case

                            if (getStr == "Y")
                            {
                                display2(); //promptfor input
                                break;
                            }
                            else if (getStr == "N")
                            {
                                Console.WriteLine("Goodbye!"); //prompt user before exiting game
                                return;
                            }
                            else
                            {
                                return;
                            }
                        }
                    }

                }
            }

            void display1()
            {
                Console.WriteLine("Welcome to the numbers guessing game");
                Console.WriteLine("");
            }

            void display2()
            {
                Console.WriteLine("Please enter a number between 0 and 100");
                Console.WriteLine("");
            }

            void display3()
            {
                Console.WriteLine("Wrong input, enter a number");
                Console.WriteLine("");
            }

            void display4()
            {
                Console.WriteLine("Too high! guess lower...");
                Console.WriteLine("");
            }

            void display5()
            {
                Console.WriteLine("");

                Console.WriteLine("Play again? Y: yes. N: no");
                Console.WriteLine("");
            }

            void display6()
            {
                Console.WriteLine("Too low! guess higher...");
                Console.WriteLine("");
            }

        }
    }
}
