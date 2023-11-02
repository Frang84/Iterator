using ConsoleApp1;

Node root = new Node(1);
Tree tree = new Tree(root);
Console.WriteLine( tree.Iterator.First(tree).id);
