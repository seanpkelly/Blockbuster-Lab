using System;
using System.Collections.Generic;
using System.Text;

namespace BlockbusterLab
{
    partial class VHS : Movie
    {
        public int CurrentTime { get; set; }
        

        public VHS() { }

        public VHS(string title, Genres category, int runTime, List<string> scenes)
        {
            Title = title;
            Category = category;
            RunTime = runTime;
            Scenes = scenes;
            CurrentTime = 0;

        }
        public override void Play()
        {
            for (int i = 0; i <= Scenes.Count; i++)
            {
                Console.WriteLine(Scenes[i]);
            }
        }
        public void Rewind()
        {
            CurrentTime = 0;
        }
    }
}
