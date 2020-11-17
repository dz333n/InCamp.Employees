using SheetLib;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

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

            var employees = new List<Employee>();
            // Converting work time stuff into a local model
            // Gonna skip the 1st row, it's a title
            for (int i = 1; i < inputSheet.Rows.Count; i++)
            {
                var row = inputSheet.Rows[i];

                // Row example: 
                // Randal Melendez,Jul 04 2020,8
                var name = row.Columns[0].Value;
                var date = row.Columns[1].Value;
                var hours = row.Columns[2].Value;

                // Check if we already know that employee
                var employee = employees.FirstOrDefault(
                    x => string.Equals(
                        x.Name,
                        name,
                        StringComparison.CurrentCultureIgnoreCase));

                if (employee == default(Employee)) // we don't know: create a new one
                {
                    employee = new Employee();
                    employee.Name = name;
                    employees.Add(employee);
                }

                // Simply add time stuff now
                employee.WorkTimes.Add(new WorkTime() { Date = date, Hours = hours });
            }

            // TODO: generate a new CSV
            csv.Export(outputFile, SheetType.CSV);

            sw.Stop();
            Console.WriteLine("Done in " + sw.Elapsed); 
        }
    }
}
