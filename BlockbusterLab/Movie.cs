using System;
using System.Collections.Generic;
using System.Text;

namespace BlockbusterLab
{
    abstract class Movie
    {
        public string Title { get; set; }
        public Genres Category { get; set; }
        public int RunTime { get; set; }
        public List<string> Scenes { get; set; }
        public Movie(List<string> Scenes)
        {
            this.Scenes = Scenes;
        }
        public Movie() { }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine();
            Console.WriteLine($"Category: {Category}");
            Console.WriteLine();
            Console.WriteLine($"RunTime: {RunTime} mins");
            Console.WriteLine();
            PrintScenes();
        }

        public virtual void PrintScenes()
        {
            Console.WriteLine("The film goes a little something like this: ");
            Console.WriteLine();
            for (int i = 0; i < Scenes.Count; i++)
            {
                Console.WriteLine($"{i + 1}: Scene: {Scenes[i]}.");
                //Console.WriteLine(Scenes[i]);
                if (i < Scenes.Count)
                {
                    Console.WriteLine($"Enjoy: {Scenes[i]}");
                }
            }
        }

        public abstract void Play();
       
    }
   
    
}
