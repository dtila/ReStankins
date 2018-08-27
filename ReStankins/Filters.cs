using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ReStankins
{
    public class NotEvenRowsTableFilter : IFilter
    {
        public IOutputer Outputer { get; }

        public NotEvenRowsTableFilter(IOutputer outputer)
        {
            Outputer = outputer;
        }

        public void ApplyTo(Table table)
        {
            var resultTable = new Table(table.Columns % 2 , table.Rows % 2);
            Outputer.ApplyTo(resultTable);
        }

        public void ApplyTo(Tree tree)
        {
            throw new NotSupportedException();
        }

        public void Dispose()
        {
        }
    }

    public class MergeTwoTablesTransformation : ITransformation
    {
        private List<Table> _tables;
        private string _mergeColumnName;
        private ITransformation _chained;

        public MergeTwoTablesTransformation(ITransformation outputer, string mergeColumnName)
        {
            _tables = new List<Table>();
            _mergeColumnName = mergeColumnName;
            _chained = outputer;
        }

        public void ApplyTo(Table table)
        {
            _tables.Add(table);
        }

        public void ApplyTo(Tree tree)
        {
            throw new NotSupportedException("Unable to merge a tree with");
        }

        public void Dispose()
        {
            //foreach (var table in _tables)
            //{
            //    var columnIndex = table.Columns.FindIndex(li => li.Name == _mergeColumnName);
            //    if (columnIndex  < 0)
            //        throw new ArgumentException($"Table does not have column {_mergeColumnName}");

            //    var column = table.Columns[columnIndex];
            //    if (column.DataType != typeof(int))
            //        throw new ArgumentException($"Unable to merge column type {column.DataType}");

            //    foreach (var row in table.Rows)
            //    {
            //        var cell = row[columnIndex];
                    
            //    }
            //}

            // Validate tables

            _chained.ApplyTo(new Table(
                _tables.Sum(li => li.Rows),
                _tables.Sum(li => li.Columns)
            ));
        }
    }
}
