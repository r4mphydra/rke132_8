using System;

namespace FridayRandomReturn
{
    class Program
    {
        static void Main(string[] args)
        {
            string randomFood, randomDrink, randomMovie;
            string[] foods = { "chicken wings", "pizza", "sushi", "popcorn", "salad" };
            string[] drinks = { "cola", "fanta", "sprite", "orange juice", "kvas" };
            string[] movies = { "Undisputed", "Drive", "Death Race", "21 Jump Street", "Lock, Stock and Two Smoking Barrels" };
            randomFood = PickRandomeElementFromArray(foods);
            randomDrink = PickRandomeElementFromArray(drinks);
            randomMovie = PickRandomeElementFromArray(movies);

            Console.WriteLine($"Tonight you are going to have some {randomFood} with {randomDrink} and watch {randomMovie}.");
        }
        private static int GenerateRandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int rI = rnd.Next(0, someArray.Length);
            return rI;
        }

        private static string PickRandomeElementFromArray(string[] someArray)
        {
            string randomElement = someArray[GenerateRandomIndex(someArray)];
            return randomElement;

        }

    } 
}

