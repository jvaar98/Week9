﻿using System;
using System.IO;

namespace DirectoriesAndFiles
{
    class Program
    {
        static void Main(string[] args)
        {

            string rootDirectory = @"/Users/jaagupvaar/Desktop/Samples";
            Console.WriteLine("Sisestage loodava kausta nimi: ");
            string newDirectory = Console.ReadLine();
            Console.WriteLine("Sistage looava faili nimi: ");
            string fileName = Console.ReadLine();


            // File.Create($"{rootDirectory}\\{ newDirectory}\\{ fileName}");

            if (Directory.Exists($"{rootDirectory}\\{newDirectory}") && File.Exists($"{rootDirectory}\\{ newDirectory}\\{ fileName}"))
            {
                Console.WriteLine($"Directory and  file exists.");
            }
            else
            {
                Directory.CreateDirectory($"{rootDirectory}\\{newDirectory}");
                File.Create($"{rootDirectory}\\{ newDirectory}\\{ fileName}");

            }

        }
    }
}