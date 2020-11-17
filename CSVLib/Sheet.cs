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
            throw new NotImplementedException();
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
