using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Nodes
{
    public interface INode
    {
        INode LeftChild { set; get; }
        INode RightChild { set; get; }

        double GetDoubleValue();
    }
}
