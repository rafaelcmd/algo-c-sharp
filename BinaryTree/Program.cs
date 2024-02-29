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
   
    1. Binary Tree: A tree in which each node has at most two children, typically referred to as the left child and the right child.
    2. Binary Search Tree (BST): A binary tree in which the left child of a node contains only values less than the node's value, and the right child contains only values greater than the node's value.
    3. AVL Tree: A self-balancing binary search tree in which the heights of the two child subtrees of any node differ by at most one.
    4. Red-Black Tree: A self-balancing binary search tree with a property that the height of the tree is O(log n), where n is the number of nodes in the tree.
    5. B-Tree: A self-balancing tree data structure that maintains sorted data and allows searches, sequential access, insertions, and deletions in logarithmic time.
    6. Trie: A tree data structure used to store a dynamic set of strings, where the keys are usually strings.
    7. Segment Tree: A tree data structure used to store information about intervals or segments, allowing for efficient queries and updates on the intervals.
    8. Fenwick Tree (Binary Indexed Tree): A tree data structure used to efficiently perform range queries and updates on an array of numbers.
    9. Suffix Tree: A tree data structure used to store all the suffixes of a given text, allowing for efficient substring searches and other string-related operations.
    10. Expression Tree: A tree data structure used to represent mathematical expressions, allowing for efficient evaluation and manipulation of the expressions.
    11. Heap: A specialized tree-based data structure that satisfies the heap property, which is used to implement priority queues and heapsort.
    12. Balanced Tree: A tree data structure in which the heights of the two child subtrees of any node differ by at most one, ensuring that the tree remains balanced and efficient.
    13. Unbalanced Tree: A tree data structure in which the heights of the two child subtrees of a node can differ significantly, leading to inefficient operations and performance.
    14. Multiway Tree: A tree data structure in which a node can have more than two children, allowing for more flexible and complex hierarchical structures.
    15. General Tree: A tree data structure in which each node can have an arbitrary number of children, allowing for flexible and complex hierarchical structures.
    16. M-ary Tree: A tree data structure in which each node can have at most m children, where m is a fixed natural number greater than 1.
    17. Ternary Tree: A tree data structure in which each node has at most three children, typically referred to as the left child, middle child, and right child.
    20. Perfect Binary Tree: A binary tree in which all interior nodes have two children and all leaves have the same depth or same level.
    21. Complete Binary Tree: A binary tree in which every level, except possibly the last, is completely filled, and all nodes are as far left as possible.
    22. Full Binary Tree: A binary tree in which every node other than the leaves has two children.
    23. Degenerate Tree: A tree in which each parent node has only one associated child node, leading to a linear data structure similar to a linked list.
    24. Threaded Binary Tree: A binary tree in which every node has a thread (or pointer) to its in-order successor and predecessor, allowing for efficient in-order traversal.
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

Console.WriteLine(TreeIncludes.IncludesWithRecursion(one, 5)); // True
Console.WriteLine(TreeIncludes.IncludesWithIterationAndQueue(one, 5)); // True
Console.WriteLine(TreeIncludes.IncludesWithIterationAndStack(one, 5)); // True

Console.WriteLine(TreeSum.SumWithRecursion(one)); // 21
Console.WriteLine(TreeSum.SumWithIterationAndQueue(one)); // 21
Console.WriteLine(TreeSum.SumWithIterationAndStack(one)); // 21

Console.WriteLine(TreeMinValue.MinValueWithRecursion(one)); // 1
Console.WriteLine(TreeMinValue.MinValueWithIterationAndQueue(one)); // 1
Console.WriteLine(TreeMinValue.MinValueWithIterationAndStack(one)); // 1