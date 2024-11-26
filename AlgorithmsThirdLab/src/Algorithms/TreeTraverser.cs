using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsThirdLab.src.Algorithms
{
    public class Node
    {
        public char Value;
        public Node Left;
        public Node Right;

        public Node(char value, Node left = null, Node right = null)
        {
            Value = value;
            Left = left;
            Right = right;
        }
    }
    internal class TreeTraverser
    {
        public Node Root;

        public TreeTraverser(Node root)
        {
            Root = root;
        }

        public string Traverse(Node node)
        {
            if (node == null)
            {
                return "*"; // Указывает, что узел пустой (NULL)
            }

            string result = node.Value.ToString();

            result += Traverse(node.Left);
            result += Traverse(node.Right);

            return result;
        }
    }
}
