using System;
using System.Collections.Generic;
using System.Text;

namespace BlockbusterLab
{
    public enum Genres
    {
        //each of these are our type within our Genres enum
        Drama, //value = 0
        Comedy, // value = 1
        Horror, // value = 2
        Romance, // value = 3
        Action, //value = 4

    }

    public class Movies
    {
        public Genres Category { get; set; }

    }
}
