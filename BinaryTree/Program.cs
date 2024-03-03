using BinaryTree.MaxRootToLeafPathSum;
using BinaryTree.Tree;
using BinaryTree.TreeIncludes;
using BinaryTree.TreeMinValue;
using BinaryTree.TreeSum;

/*
   What is a Tree?
 
   In computer science, a tree is a widely used abstract data structure that simulates a hierarchical tree structure with a root value and subtrees of children,
   represented as a set of linked nodes. Each node in a tree has a value and a list of references to its children nodes. Here are some key concepts related to trees:
   
   Root: The topmost node in a tree, it is the starting point of the tree.
   Node: Each element in a tree data structure that contains a value and references to its child nodes (if any).
   Parent: A node that has one or more child nodes.
   Child: Nodes that have a parent node; they are connected to their parent via edges.
   Leaf: Nodes that have no children.
   Subtree: A tree structure that originates from a node and includes all of its descendants.
   Depth: The depth of a node in a tree is the length of the path from the root to that node.
   Height: The height of a tree is the maximum depth of any node in the tree.
   Binary Tree: A tree in which each node has at most two children, typically referred to as the left child and the right child.
   Binary Search Tree (BST): A binary tree in which the left child of a node contains only values less than the node's value, and the right child contains only values greater than the node's value.
   
   Trees are used to represent hierarchical data structures like file systems, organization charts, and expression trees. They provide efficient insertion, deletion, 
   and searching operations when appropriately balanced and structured. Understanding trees is fundamental for various algorithms and data structures used in computer science and software engineering.
   
   Types of trees:
   
    1. Trees vs Binary Trees:
        A tree is a data structure that simulates a hierarchical tree structure with a root value and subtrees of children, represented as a set of linked nodes.
        A binary tree is a tree in which each node has at most two children, typically referred to as the left child and the right child.
        
    2. Binary Trees vs Binary Search Trees:
        A binary search tree (BST) is a binary tree in which the left child of a node contains only values less than the node's value,
        and the right child contains only values greater than the node's value.
        
    3. Balanced vs Unbalanced Trees:
        A balanced tree is a tree in which the height of the left and right subtrees of every node differs by at most one.
        An unbalanced tree is a tree in which the height of the left and right subtrees of a node can differ significantly.
        
    4. Complete vs Full vs Perfect Binary Trees:
        A complete binary tree is a binary tree in which every level, except possibly the last, is completely filled, and all nodes are as far left as possible.
        A full binary tree is a binary tree in which every node has either zero or two children.
        A perfect binary tree is a binary tree in which all interior nodes have two children and all leaves have the same depth or same level.
*/

var one = new Node(1);
var two = new Node(2);
var three = new Node(3);
var four = new Node(4);
var five = new Node(5);
var six = new Node(6);

one.Left = two;
one.Right = three;
two.Left = four;
two.Right = five;
three.Right = six;

/*
    Tree:
    
        1
       / \
      2   3
     / \   \
    4   5   6
*/

Console.WriteLine(TreeIncludes.IncludesWithRecursion(one, 5)); // True
Console.WriteLine(TreeIncludes.IncludesWithIterationAndQueue(one, 5)); // True
Console.WriteLine(TreeIncludes.IncludesWithIterationAndStack(one, 5)); // True

Console.WriteLine(TreeSum.SumWithRecursion(one)); // 21
Console.WriteLine(TreeSum.SumWithIterationAndQueue(one)); // 21
Console.WriteLine(TreeSum.SumWithIterationAndStack(one)); // 21

Console.WriteLine(TreeMinValue.MinValueWithRecursion(one)); // 1
Console.WriteLine(TreeMinValue.MinValueWithIterationAndQueue(one)); // 1
Console.WriteLine(TreeMinValue.MinValueWithIterationAndStack(one)); // 1

Console.WriteLine(MaxRootToLeafPathSum.MaxRootToLeafPathSumWithRecursion(one));
Console.WriteLine(MaxRootToLeafPathSum.MaxRootToLeafPathSumWithIterationAndStack(one));