using System;
using System.Collections.Generic;
using System.Text;

namespace BlockbusterLab
{
    class DVD : Movie
    {
        public DVD()
        {

        }

        public DVD(string title, Genres category, int runTime, List<string> scenes)
        {
            Title = title;
            Category = category;
            RunTime = runTime;
            Scenes = scenes;
        }

        public override void Play()
        {
            Console.WriteLine("What scene would you like to watch? ");
            PrintScenes();
            int input = int.Parse(Console.ReadLine());
       
            if (input < Scenes.Count)
            {
                Console.WriteLine($"Enjoy: {Scenes[input -1]}");
                
            }
            else
            {
                Console.WriteLine("I'm sorry, try again.");
            }
        }

    }
}
