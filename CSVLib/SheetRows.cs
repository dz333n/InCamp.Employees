using System.Collections;
using System.Collections.Generic;

namespace SheetLib
{
    public class SheetRows : IList<SheetRow>
    {
        private IList<SheetRow> list = new List<SheetRow>();

        public SheetRow this[int index] 
        {
            get => list[index];
            set => list[index] = value;
        }

        /// <summary>
        /// Create a new row
        /// </summary>
        /// <returns>Created row</returns>
        public SheetRow Create()
        {
            var row = new SheetRow();
            Add(row);
            return row;
        }

        public int Count => list.Count;

        public bool IsReadOnly => list.IsReadOnly;

        public void Add(SheetRow item) => list.Add(item);

        public void Clear() => list.Clear();

        public bool Contains(SheetRow item) => list.Contains(item);

        public void CopyTo(SheetRow[] array, int arrayIndex) => list.CopyTo(array, arrayIndex);

        public IEnumerator<SheetRow> GetEnumerator() => list.GetEnumerator();

        public int IndexOf(SheetRow item) => list.IndexOf(item);

        public void Insert(int index, SheetRow item) => list.Insert(index, item);

        public bool Remove(SheetRow item) => list.Remove(item);

        public void RemoveAt(int index) => list.RemoveAt(index);

        IEnumerator IEnumerable.GetEnumerator() => list.GetEnumerator();
    }
}
