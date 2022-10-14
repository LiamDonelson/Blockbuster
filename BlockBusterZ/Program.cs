using System.ComponentModel;
using System.Net.Security;

namespace BlockBusterZ
{
    internal class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Welcome to blockbuster!!!!!");
            Console.WriteLine();

            List<Movies> listOfMovies = new List<Movies>();
            listOfMovies.Add(new DVD("The Shawshank Redemption",Category.Action,152, new string[] {"He jumps!","He falls!","He cries","He picks himself up","He smiles"}));
            listOfMovies.Add(new DVD("The Ring", Category.Horror, 192, new string[] { "She climbs out of the tv!", "She stabs him!", "He begins to crawl away", "She picks him up", "She throws him down a well" }));
            listOfMovies.Add(new VHS("Adventure Timz", Category.Romance, 91, new string[] { "He swings", "Shrek appears", "Shrek starts to bathe in the swamp", "Shrek runs away", "Shrek climbs through your window" }));
            listOfMovies.Add(new VHS("tony the pizza chainsaw", Category.Horror, 251, new string[] { "The pizza gets put in the oven", "They start singing", "Chainsaw man comes out", "Chainsaw man eats them", "Credits" }));
            listOfMovies.Add(new DVD("Cheesezits for cheese?", Category.Action, 52, new string[] { "They all get together to sing", "The grand adventure begins!", "They all start running from the big tree", "They burn it down", "The all go home" }));
            listOfMovies.Add(new VHS("The Formidable Mountain", Category.Drama, 132, new string[] { "They choose their faction", "Jacob chooses wrong", "Jacob cries himself to sleep", "Jacob is forever ruined now", "Jacob dies" }));

            BlockBuster shop = new BlockBuster(listOfMovies);


            for ( int i = 0; i < listOfMovies.Count; i++)
            {

                Console.WriteLine($"{i+1}) {listOfMovies[i].Name}");
            }

           

        }
    }
}