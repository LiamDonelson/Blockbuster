using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BlockBusterZ
{
    public enum Category
    {
        Drama,
        Comedy,
        Horror,
        Romance,
        Action
    }

    public abstract class Movies
    {
        public string Name { get; set; }

        public Category Genere { get; set; }

        public int RunTime { get; set; }

        public string[] Scenes { get; set; }

        public Movies(string name, Category genere, int runtime, string[] scenes)
        {
            this.Name = name;
            this.Genere = genere;
            this.RunTime = runtime;
            this.Scenes = scenes;
        }
    
    
    }




}
