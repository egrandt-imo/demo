﻿using System;
using System.IO;

namespace Project
{
    class Program
    {
        private static void Main(string[] args)
        {
            var input = File.ReadAllText("Data\\data.json");

            // TODO: Convert input to requested output
            
            Console.WriteLine(input);
        }
    }
}