using System;
using System.Collections;
using Test.Nodes;

namespace Test
{
    public class PolishInvertedEntryParser
    {
        public static INode Parse(string polishInvertedEntry)
        {
            INode result = null;
            Stack stack = new Stack();

            //Splitting a string into elements
            string[] elements = polishInvertedEntry.Split(' ');
            //pass each elements
            for (int i = 0; i < elements.Length; i++)
            {
                //Create real object in depending by element
                //Converts element to int. If this throws FormatException then trys to create OperationNode. If not supported operation or wrong string it throws exception and displays message on the console. 
                INode node = getNodeByString(elements[i]);
                if (node != null)
                {
                    //if element is number then put it in the stack
                    if (node.GetType() == typeof(NumberNode))
                    {
                        stack.Push(node);
                    }
                    //if element is operation get two last elements from stack and first becomes right child for node and second - left child
                    else
                    {
                        node.RightChild = (INode)stack.Pop();
                        node.LeftChild = (INode)stack.Pop();
                        stack.Push(node);
                    }
                }
                result = node;
            }
            return result;
        }

        private static INode getNodeByString(string stringValue)
        {
            INode node;
            try
            {
                int value = Convert.ToInt32(stringValue);
                node = new NumberNode(value);
            }
            catch (FormatException ex)
            {
                try
                {
                    node = new OperationNode(stringValue);
                }
                catch (NotImplementedException exeption)
                {
                    Console.WriteLine("Wrong entry or used unsupported operation. Note, you can use '/', '*', '+', '-'.");
                    return null;
                }
            }
            return node;
        }
    }
}