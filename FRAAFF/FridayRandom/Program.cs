using System;

namespace FridayRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayRandomFood();
            DisplayRandomDrink();
            DisplayRandomMovie();
        }
        private static int GenerateRandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int rI = rnd.Next(0, someArray.Length);
            return rI;
        }
        private static void DisplayRandomFood()
        {
            string[] foods = { "chicken wings", "pizza", "sushi", "popcorn", "salad" };
            Console.WriteLine($"Computer picked {foods[GenerateRandomIndex(foods)]}");
        }
        private static void DisplayRandomDrink()
        {
            string[] drinks = { "cola", "fanta", "sprite", "orange juice", "kvas" };
       
            Console.WriteLine($"Computer picked {drinks[GenerateRandomIndex(drinks)]}");
        }
        private static void DisplayRandomMovie()
        {
            string[] movies = { "Undisputed", "Drive", "Death Race", "21 Jump Street", "Lock, Stock and Two Smoking Barrels" };
            
            Console.WriteLine($"Computer picked {movies[GenerateRandomIndex(movies)]}");
        }
    }
}
