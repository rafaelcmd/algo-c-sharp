using BinaryTree.Tree;
using BinaryTree.TreeIncludes;
using BinaryTree.TreeSum;

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

Console.WriteLine(TreeSum.Sum(one)); // 21