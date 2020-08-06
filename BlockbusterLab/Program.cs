using System;

namespace BlockbusterLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Blockbuster blockBuster = new Blockbuster();
            VHS vhs = new VHS();
            DVD dvd = new DVD();

            bool programStart = true;
            while (programStart)
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine(",.,.,.,.,.,.,.,.,.,.,.,.,.,.,.,.,.,., ");
            Console.WriteLine("Welcome to Grand Circus Blockbuster!, ");
            Console.WriteLine(",.,.,.,.,.,.,.,.,.,.,.,.,.,.,.,.,.,., ");

            Console.WriteLine();
       
            string wantToWatch = GetUserInput("So do you want to watch a movie? y/n?");


            if (wantToWatch == "y")
            {
                Console.WriteLine();
                Console.WriteLine("Here's our selection: ");
                Console.WriteLine();


                blockBuster.CheckOut();
                

                int number = int.Parse(Console.ReadLine()) - 1;

                Movie selectedMovie = blockBuster.Movies[number];
                    
               

                if (selectedMovie is VHS)
                {
                    vhs = (VHS)selectedMovie;
                    vhs.PrintInfo();

                    vhs.Rewind();

                }
                else if (selectedMovie is DVD)
                {
                    dvd = (DVD)selectedMovie;
                    dvd.PrintInfo();
                }
                if (wantToWatch == "y") 
                {

                }

            }

            static string GetUserInput(string str)
            {
                Console.WriteLine(str);
                string input = Console.ReadLine();
                return input;
            }
                Console.WriteLine("Would you like to watch this movie? y/n?");
                Console.WriteLine();
                string responseLast = Console.ReadLine();

                if (responseLast == "y")
                {
                    Console.WriteLine($"Which scene would you like to watch? Select 1-3: ");
                    int number = int.Parse(Console.ReadLine()) - 1;

                    Movie selectedMovie = blockBuster.Movies[number];

                    programStart = true;
                    break;
                }

                else if (responseLast == "n" || responseLast == "no")
                {
                    Console.WriteLine();
                    Console.WriteLine("Alright. Thanks for your time, bye!");
                    programStart = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Seriously? y/n?");
                }
            }

        }
    }
}
