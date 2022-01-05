using System;

namespace FRAAFF
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayRandomFood();
            DisplayRandomDrink();
            DisplayRandomMovie();
        }
        private static void DisplayRandomFood()
        {
            string[] foods = { "chicken wings", "pizza", "sushi", "popcorn", "salad" };
            Random rnd = new Random();
            int rI = rnd.Next(0, foods.Length);
            string rF = foods[rI];
            Console.WriteLine($"Computer picked {rF}");
        }
        private static void DisplayRandomDrink()
        {
            string[] drinks = { "cola", "fanta", "sprite", "orange juice", "kvas" };
            Random rnd = new Random();
            int rI = rnd.Next(0, drinks.Length);
            string rd = drinks[rI];
            Console.WriteLine($"Computer picked {rd}");
        }
        private static void DisplayRandomMovie()
        {
            string[] movies = { "Undisputed", "Drive", "Death Race", "21 Jump Street", "Lock, Stock and Two Smoking Barrels" };
            Random rnd = new Random();
            int rI = rnd.Next(0, movies.Length);
            string rm = movies[rI];
            Console.WriteLine($"Computer picked {rm}");
        }
    }
}
