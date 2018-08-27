using System;
using System.Collections.Generic;
using System.Text;

namespace ReStankins.Test
{
    class AccesibleTestTransformer : ITransformation
    {
        public List<Table> Tables { get; }
        public List<Tree> Trees { get; }

        public AccesibleTestTransformer()
        {
            Tables = new List<Table>();
            Trees = new List<Tree>();
        }

        public void ApplyTo(Table table)
        {
            Tables.Add(table);
        }

        public void ApplyTo(Tree tree)
        {
            Trees.Add(tree);
        }

        public void Dispose()
        {
        }
    }
}
