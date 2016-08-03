using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Nodes
{
    public class OperationNode: INode
    {
        public string Value;
        public INode LeftChild { set; get; }
        public INode RightChild { set; get; }

        private string[] supportedOperation = { "+", "-", "/", "*" };
        public OperationNode(string value)
        {
            if (!supportedOperation.Contains(value))
            {
                throw new NotImplementedException();
            }
            Value = value;
        }

        public double GetDoubleValue()
        {
            switch (Value)
            {
                case "-":
                    return LeftChild.GetDoubleValue() - RightChild.GetDoubleValue();
                case "+":
                    return LeftChild.GetDoubleValue() + RightChild.GetDoubleValue();
                case "/":
                    return LeftChild.GetDoubleValue() / RightChild.GetDoubleValue();
                case "*": 
                    return LeftChild.GetDoubleValue() * RightChild.GetDoubleValue();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
