using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Awalé
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a Person
            Person person = new Person("John Doe");
            Console.WriteLine($"Person Name: {person.Name}");
            Console.ReadKey();

            // Create a Player and set properties
            Player player = new Player("Jane Doe", 1);
            Console.WriteLine($"Player Name: {player.Name}, Player Number: {player.PlayerNumber}");
            Console.ReadKey();

            // Update and get Player's score
            player.UpdateScore(10);
            Console.WriteLine($"Player Score: {player.GetScore()}");
            Console.ReadKey();

            // Create a Score 
            Score score = new Score();
            score.AddPoints(5);
            Console.WriteLine($"Score Total: {score.Total}");
            Console.ReadKey();

            // Initialize the Board
            Board board = new Board();
            board.SetupBoard(); // properly initializes the board
            board.DisplayBoard(); // prints out the board state
            Console.ReadKey();

            // Create Seeds and manipulate count
            Seeds seeds = new Seeds(4);
            seeds.AddSeeds(2);
            Console.WriteLine($"Seeds Count: {seeds.Count}");
            Console.ReadKey();

            // Create a Pit and manipulate seeds
            Pits pit = new Pits(4);
            pit.IncrementSeeds();
            Console.WriteLine($"Pit Seeds Count: {pit.Seeds.Count}");
            Console.ReadKey();

            // Initialize a Row and reset it
            Row row = new Row();
            row.ResetRow(); // resets to initial state
            row.DisplayRow(); // this method prints out the row's state
            Console.ReadKey();

        }
    }
}
