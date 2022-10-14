using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockBusterZ
{
    internal class DVD : Movies
    {
        
        public List<Movies> movies { get; set; }
        public DVD(string name, Category genere, int runtime, string[] scenes)
            : base(name, genere, runtime, scenes)
        {
            this.Name = name;
            this.Genere = genere;
            this.RunTime = runtime;
            this.Scenes = scenes;
        }
        public  void Play()
        {
           

            //If movie is in the list within Blockbuster, Print Title and Print SceneList
            Console.WriteLine($"Scene Selection: {Name}:");
            bool playDVD = true;
            while (playDVD)
            {
                try
                {
                    int userSelect = int.Parse(Console.ReadLine());
                    //Prints a list of scenes from selected index point, forward.

                    if (userSelect > 0 && userSelect < Scenes.Length)
                    {
                        int currentTime = (RunTime / Scenes.Length) * (userSelect - 1);
                        Console.WriteLine($"Playing {Name} Start Scene: {userSelect}: {Scenes[userSelect]}.  \nPlaying from {currentTime} mins.\n");

                        for (int i = userSelect; i < Scenes.Length; i++)
                        {
                            Console.WriteLine($"{currentTime} mins: {Scenes[i]}");
                            currentTime += RunTime / Scenes.Length;
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Invalid Scene Selection in: {Name}.  Select Scenes 1 - {Scenes.Length}.");
                        continue;
                    }
                }
                //Exception inserted to catch invalid input
                catch (Exception)
                {
                    Console.WriteLine($"Input 1 - {Scenes.Length} to continue");
                    continue;
                }
            }
        }
    }
}
