using System;
using System.IO;

namespace RandomFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string randomFood, randomDrink, randomMovie;
            randomFood = GetRandomFromFile("foods.txt");
            randomDrink = GetRandomFromFile("drinks.txt");
            randomMovie = GetRandomFromFile("movies.txt");


            Console.WriteLine($"Tonight you are going to have some {randomFood} with {randomDrink} and watch {randomMovie}.");

        }
        private static int GenerateRandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int rI = rnd.Next(0, someArray.Length);
            return rI;
        }
        private static string GetRandomFromFile(string fileName)
        {
            string filePath = $@"C:\Users\Artjom\Documents\RKE132\Nadal8\Files\{fileName}";
            string[] dataFromFile = File.ReadAllLines(filePath);
            string randomElement = dataFromFile[GenerateRandomIndex(dataFromFile)];
            return randomElement;
        }
    }
}
