using System.Collections;
using System.Collections.Generic;

namespace SheetLib
{
    public class RowColumns : IList<RowColumn>
    {
        private IList<RowColumn> list = new List<RowColumn>();

        public RowColumn this[int index]
        {
            get => list[index];
            set => list[index] = value;
        }

        public int Count => list.Count;

        public bool IsReadOnly => list.IsReadOnly;

        public void Add(RowColumn item) => list.Add(item);

        public void Clear() => list.Clear();

        public bool Contains(RowColumn item) => list.Contains(item);

        public void CopyTo(RowColumn[] array, int arrayIndex) => list.CopyTo(array, arrayIndex);

        public IEnumerator<RowColumn> GetEnumerator() => list.GetEnumerator();

        public int IndexOf(RowColumn item) => list.IndexOf(item);

        public void Insert(int index, RowColumn item) => list.Insert(index, item);

        public bool Remove(RowColumn item) => list.Remove(item);

        public void RemoveAt(int index) => list.RemoveAt(index);

        IEnumerator IEnumerable.GetEnumerator() => list.GetEnumerator();
    }
}
