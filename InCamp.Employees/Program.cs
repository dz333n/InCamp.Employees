using CSVLib;
using System;
using System.Diagnostics;

namespace InCamp.Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input filename: ");
            var inputFile = Console.ReadLine();

            Console.Write("Output filename: ");
            var outputFile = Console.ReadLine();

            var sw = new Stopwatch();
            sw.Start();

            Console.WriteLine("Reading file...");
            var inputSheet = new CSV(inputFile);

            Console.WriteLine("Generating a new one...");
            var csv = new CSV();

            // TODO: actually generate stuff

            csv.Export(outputFile);

            sw.Stop();
            Console.WriteLine("Done in " + sw.Elapsed); 
        }
    }
}
