using SheetLib;
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
            var inputSheet = new Sheet(inputFile, SheetType.CSV);

            Console.WriteLine("Generating a new one...");
            var csv = new Sheet();

            // TODO: actually generate stuff
            // Copying previous sheet to a new one for testing purposes
            
            foreach (var row in inputSheet.Rows)
            {
                var newRow = csv.Rows.Create();

                foreach (var column in row.Columns)
                {
                    var newColumn = newRow.Columns.Create(column.Value);
                }
            }

            csv.Export(outputFile, SheetType.CSV);

            sw.Stop();
            Console.WriteLine("Done in " + sw.Elapsed); 
        }
    }
}
