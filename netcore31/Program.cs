using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace InterviewProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            var output = File.ReadAllText("Samples\\data.json");
            // todo: convert input to requested output
            Console.WriteLine(output);
            Console.ReadLine();
        }

    }
}