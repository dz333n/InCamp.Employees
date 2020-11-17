using System;
using System.IO;

namespace SheetLib
{
    public class Sheet
    {
        public SheetRows Rows { get; } = new SheetRows();

        public void Clear()
        {
            Rows.Clear();
        }

        public void Export(string fileName, SheetType type)
        {
            throw new NotImplementedException();
        }

        public void Import(string fileName, SheetType type)
        {
            this.Clear();

            if (type == SheetType.CSV)
            {
                using (var reader = new StreamReader(fileName))
                {
                    var fileContent = reader.ReadToEnd();
                    var rows = fileContent.Split(
                        new string[] { "\r\n", "\n" },
                        StringSplitOptions.RemoveEmptyEntries);

                    for (int i = 0; i < rows.Length; i++)
                    {
                        var rowRaw = rows[i];
                        var columns = rowRaw.Split(
                            new string[] { "," },
                            StringSplitOptions.RemoveEmptyEntries);

                        var row = new SheetRow();
                        Rows.Add(row);

                        for (int j = 0; j < columns.Length; j++)
                        {
                            var columnRaw = columns[j]; // cell value
                            var column = new RowColumn(columnRaw);

                            // Console.WriteLine($"Cell: {columnRaw}");
                            row.Columns.Add(column);
                        }
                    }
                }
            }
            else throw new NotImplementedException();
        }

        /// <summary>
        /// Create an empty sheet
        /// </summary>
        public Sheet() { }

        /// <summary>
        /// Import a sheet
        /// </summary>
        /// <param name="fileName">CSV file</param>
        public Sheet(string fileName, SheetType type) : this()
        {
            Import(fileName, type);
        }
    }
}
