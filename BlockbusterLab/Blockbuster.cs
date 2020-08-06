using System;
using System.Collections.Generic;
using System.Text;

namespace BlockbusterLab
{
    class Blockbuster 
    {
        public List<Movie> Movies = new List<Movie>
        {
            new VHS("The Note-Pad", Genres.Romance, 120, new List<string>(){"They meet", "Making out in the rain", "They die"}),
            new VHS("There's Something about Mary Magdalene", Genres.Comedy, 120, new List<string>(){"God puts a baby in Mary", "Ben Stiller?", "Crucifixion"}),
            new VHS("Whatever Marvel Nonsense", Genres.Action, 120, new List<string>(){"Loud explosions", "Comic book guys and gals I don't know", "They win"}),
            new DVD("No Country For Young Men Either", Genres.Drama, 250, new List<string>(){"Drug money found", "Young sherriff is joyful", "Javier Bardem wins" }),
            new DVD("Quarantine2020", Genres.Horror, 120, new List<string>(){"Airborn virus spreads from a market in China", "USA underestimates it", "???"}),
            new DVD("Mr. Bean: Nothing 2 Laugh About", Genres.Drama, 120, new List<string>(){"Mr. Bean gets mugged", "Mr. Bean wants revenge", "Mr. Bean rides off into the sunset"})
        };
        public void PrintMovies()
        {
            
            for (int i = 0; i < Movies.Count; i++)
            {
                Console.WriteLine($"{i+1}) {Movies[i].Title}" );
            }
        }
        public void CheckOut()
        {
            PrintMovies();
            Console.WriteLine();
            Console.WriteLine("Which Movie would you like to check out?\nPlease input the number corresponding to the movie (1-6)");
            Console.WriteLine();

        }
    }
}
