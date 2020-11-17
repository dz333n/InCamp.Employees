using System;

namespace CSVLib
{
    public class CSV
    {
        public void Export(string fileName)
        {
            throw new NotImplementedException();
        }

        public void Import(string fileName)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Create an empty sheet
        /// </summary>
        public CSV() { }

        /// <summary>
        /// Import a sheet
        /// </summary>
        /// <param name="fileName">CSV file</param>
        public CSV(string fileName) : this()
        {
            Import(fileName);
        }
    }
}
