using System;

namespace SheetLib
{
    public class Sheet
    {
        public void Clear()
        {
            throw new NotImplementedException();
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
