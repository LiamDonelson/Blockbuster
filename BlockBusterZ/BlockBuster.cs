using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BlockBusterZ
{
    public class BlockBuster
    {
        public List<Movies> movies { get; set; }

        


        public BlockBuster(List<Movies> Movies)
        {
            this.movies = Movies;
        }

        List<Movies> listOfMovies = new List<Movies>();



        //public static void PrintMovies()
        //{
        //    for (int i = 0; i < listOfMovies.Count; i++)
        //    {

        //        Console.WriteLine($"{i + 1}) {listOfMovies[i].Name}");
        //    }

        //}

        //public static void CheckOut() 
        //{ 
        //     Console.WriteLine();
        //    Console.WriteLine("Please the number of the movie you would like to check out!");
        //    int userinput = 0;
        //    try
        //    {
        //        userinput = int.Parse(Console.ReadLine());
        //        Console.WriteLine($"You have picked movie number {userinput}");
        //        Console.WriteLine($"That is movie {BlockBuster[userinput - 1].Name}");

        //    }
        //    catch
        //    {
        //        Console.WriteLine("Please enter a valid number!");
        //    }

        //}


    }
}
