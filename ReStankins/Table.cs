using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ReStankins
{
    // TODO: Implement proper the table
    public class Table : ISource
    {
        //public ColumnCollection Columns { get; }
        //public RowCollection Rows { get; }

        //public Table(Column[] columns)
        //{
        //    Columns = new ColumnCollection(columns);
        //}

        public int Columns { get; }
        public int Rows { get; }
        public Table(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
        }

        public void AppendTo(ITransformation transformer)
        {
            transformer.ApplyTo(this);
        }


        public class Column
        {
            public string Name { get; }
            public Type DataType { get; }

            public Column(string name, Type type)
            {
                Name = name;
                DataType = type;
            }
        }
    }

    public class ColumnCollection : IList<Table.Column>
    {
        private List<Table.Column> list;

        public int Count => list.Count;

        public bool IsReadOnly => false;

        public Table.Column this[int index]
        {
            get => list[index];
            set => list[index] = value;
        }

        public ColumnCollection(IEnumerable<Table.Column> columns)
        {
            list = new List<Table.Column>(columns);
        }

        public void Add(Table.Column item)
        {
            list.Add(item);
        }

        public int FindIndex(Predicate<Table.Column> predicate)
        {
            return list.FindIndex(predicate);
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(Table.Column item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(Table.Column[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Table.Column> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(Table.Column item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(Table.Column item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, Table.Column item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }
    }

    public class RowCollection : IList<object[]>
    {
        public object[] this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(object[] item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(object[] item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(object[][] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<object[]> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(object[] item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, object[] item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(object[] item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
