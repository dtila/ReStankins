using System;
using System.Collections.Generic;
using System.Text;

namespace ReStankins
{
    public class Tree : List<Tree.Node>, ISource
    {
        public Tree()
        {
        }

        public void AppendTo(ITransformation transformer)
        {
            transformer.ApplyTo(this);
        }

        public class Node
        {
            public int ID { get; }

            public Node(int id)
            {
                ID = id;
            }
        }
    }
}
