using System;
using System.IO;

namespace EpicBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] heroes = {"Harry Potter", "SuperMan", "Luke Skywalker", "Lara Croft"};
            //string[] villains = {"Voldemort", "Joker", "Venom", "Darth Vader", "Cruella"};
            string folderPath = @"C:\Users\opilane\Samples\";
            string[] heroes = GetDataFromFile(folderPath + "heroes.txt");
            string[] villains = GetDataFromFile(folderPath + "villains.txt");
            string[] heroesweapon = GetDataFromFile(folderPath + "heroesweapon.txt");
            string[] villainsweapon = GetDataFromFile(folderPath + "villainsweapon.txt");

            string randomHero = GetRandomElement(heroes);
            string randomvillain = GetRandomElement(villains);
            string Hweapon = GetRandomElement(heroesweapon);
            string Vweapon = GetRandomElement(villainsweapon);
            Console.WriteLine($"Your random  hero is: {randomHero}");
            Console.WriteLine($"Your random  villains is: {randomvillain}");
            Console.WriteLine($"{randomHero} with {Hweapon} will fight {randomvillain} with {Vweapon}");
        }

        public static string GetRandomElement(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);
            string randomCharacter = someArray[randomIndex];
            return randomCharacter;
        }

        public static string[] GetDataFromFile(string filepath)
        {
            string[] datafromfile = File.ReadAllLines(filepath);
            return datafromfile;
        }
    }
}
