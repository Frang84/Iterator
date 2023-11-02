using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Tree
    {
        public Node root { get; }
        public Iterator Iterator;
        public Tree(Node root) 
        {  
            this.root = root;
            Iterator = new ConcretIterator();
        } 
        
        
        
    }
}
