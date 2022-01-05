using System;
using System.IO;

namespace Chuck_Norris
{
    class Program
    {
        static void Main(string[] args)
        {
            string randomPhrase;
            randomPhrase = GetRandomFromFile("chuck.txt");
           

            Console.WriteLine($"Today Chuck's joke is "{randomPhrase}"");

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

