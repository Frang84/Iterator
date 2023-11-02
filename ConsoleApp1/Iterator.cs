using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface Iterator
    {

        public Node First(Tree tree);
      
        public bool HasLeft (Node node);
        public bool HasRight(Node node);
       
        public void printInorder(Node root);


    }
}
