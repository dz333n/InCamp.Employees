namespace SheetLib
{
    public class RowColumn
    {
        public RowColumn() { }

        public RowColumn(string value) : this()
        {
            Value = value;
        }

        public string Value { get; set; } = "";
    }
}
