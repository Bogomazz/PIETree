using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Nodes
{
    public class NumberNode : INode
    {
        public double Value { set; get; }
        public INode LeftChild { set; get; }

        public INode RightChild { set; get; }

        public NumberNode(double value)
        {
            Value = value;
            LeftChild = null;
            RightChild = null;
        }

        public double GetDoubleValue()
        {
            return Value;
        }
    }
}
