using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    public class ConcretIterator : Iterator
    {
        public Node First(Tree tree)
        {
            return tree.root;
        }
        public bool HasLeft(Node node)
        {
            if (node.left != null)
            {
                return true;
            }
            else 
            { 
                return false;
            }
        }

        public Node right(Node node)
        {
            if (node.right != null)
            {
                return node.right;
            }
            else
            {
                return null;
            }
        }

        public bool HasRight(Node node)
        {
            if (node.right != null) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }
      

        public void printInorder(Node node) 
        {
            if (node == null)
                return;

            // First recur on left child
            printInorder(node.left);

            // Then print the data of node
            Console.Write(node.id + " ");

            // Now recur on right child
            printInorder(node.right);
        }


    }
}
