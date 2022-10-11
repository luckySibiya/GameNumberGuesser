using System;

namespace GameNumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {

            //change text color 
            Console.ForegroundColor = ConsoleColor.Green;

            string AppName = "Guessing Numbers";
            string AppVersion = "1.0.0";
            string AppAuthor = "Lucky Sibiya";

            //change text color 
            Console.ForegroundColor = ConsoleColor.Green;

            //App Info
            Console.WriteLine("{0}: Version {1} By {2}", AppName, AppVersion, AppAuthor);

            //resets color 
            Console.ResetColor();

            Console.WriteLine("Hi, What Is Your Name?");
            string InputName = Console.ReadLine();

            Console.WriteLine("Hi {0}, You're About To Play {1}", InputName, AppName);

            while (true)
            {

                //int CorrectNumber = 7; 

                Random random = new Random();

                int CorrectNumber = random.Next(1, 10);

                int guess = 0;

                Console.WriteLine("Guess A Number Between 1 To 10");

                while (guess != CorrectNumber)
                {
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out guess))
                    {
                        PrintColorMessage(ConsoleColor.Red, "Invalid, Please Try Again.");

                        continue;
                    }

                    guess = Int32.Parse(input);

                    if (guess != CorrectNumber)
                    {

                        PrintColorMessage(ConsoleColor.Red, "Wrong Guess, Please Try Again");
                    }

                }

                PrintColorMessage(ConsoleColor.DarkGreen, "Great Guess!");

                Console.WriteLine("{0} Do You Want To Play Again? [Y or N]", InputName);

                string Answer = Console.ReadLine().ToUpper();

                if (Answer == "Y")
                {
                    continue;
                }
                else if(Answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }

        } 

       static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;

            Console.WriteLine(message);

            Console.ResetColor();
        }
    }
}
