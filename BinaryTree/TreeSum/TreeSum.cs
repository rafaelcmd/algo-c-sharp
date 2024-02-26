using BinaryTree.Tree;

namespace BinaryTree.TreeSum;

public static class TreeSum
{
    private static int _totalSum = 0;
    
    public static int Sum(Node? root)
    {
        if (root == null)
            return 0;

        _totalSum += root.Value;
        
        Sum(root.Left);
        Sum(root.Right);

        return _totalSum;
    }
}