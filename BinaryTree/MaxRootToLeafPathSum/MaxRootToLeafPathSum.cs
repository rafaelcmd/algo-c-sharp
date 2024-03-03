using BinaryTree.Tree;

namespace BinaryTree.MaxRootToLeafPathSum;

public static class MaxRootToLeafPathSum
{
    private static int _currentPathSum;
    private static int _maxPathSum;

    /// <summary>
    /// Recursively calculates the maximum root-to-leaf path sum in the tree starting from the specified root node.
    /// </summary>
    /// <param name="node">The root node of the tree to calculate the maximum path sum for.</param>
    /// <returns>The maximum root-to-leaf path sum in the tree.</returns>
    /// <remarks>
    /// Advantages of using recursion:
    /// 1. **Simplicity**: Recursive algorithms are often simpler to implement and understand than their iterative counterparts.
    /// 2. **Natural Fit**: Recursion mirrors the hierarchical structure of trees, making it intuitive for tree traversal and aggregation operations.
    /// 3. **Readability**: Recursive algorithms can be more readable and expressive, resembling pseudocode or natural language descriptions of the problem-solving process.
    /// 4. **Ease of Implementation**: Recursive algorithms closely follow the natural definition of the problem, making them easier to implement and understand.
    ///
    /// Time Complexity: O(n)
    /// The time complexity of this method is O(n), where n is the number of nodes in the tree. This is because the algorithm visits each node of the tree once to calculate the maximum path sum.
    ///
    /// Space Complexity: O(h)
    /// The space complexity of this method is O(h), where h is the height of the tree. This is because the recursive calls consume space on the call stack, proportional to the height of the tree.
    /// In a balanced tree, where the height is logarithmic in the number of nodes (h = log n), the space complexity becomes O(log n).
    /// However, in the worst case of an unbalanced tree (h = n), the space complexity becomes O(n).
    /// </remarks>
    public static int MaxRootToLeafPathSumWithRecursion(Node? node)
    {
        if (node == null)
            return 0;

        _currentPathSum += node.Value;

        if (node.Left == null && node.Right == null)
            _maxPathSum = Math.Max(_maxPathSum, _currentPathSum);
        
        MaxRootToLeafPathSumWithRecursion(node.Left);
        MaxRootToLeafPathSumWithRecursion(node.Right);
        
        _currentPathSum -= node.Value;
        
        return _maxPathSum;
    }

    /// <summary>
    /// Iteratively calculates the maximum root-to-leaf path sum in the tree starting from the specified root node, and using a Stack.
    /// </summary>
    /// <param name="root">The root node of the tree to calculate the maximum path sum for.</param>
    /// <returns>The maximum root-to-leaf path sum in the tree.</returns>
    /// <remarks>
    /// Advantages of using iteration and a stack:
    /// 1. **Space Efficiency**: Iterative algorithms often consume less space than their recursive counterparts, especially for large trees.
    /// This is because iterative algorithms do not rely on the call stack to manage recursive calls, which can lead to stack overflow errors for very deep trees.
    /// 2. **Tail Recursion Optimization**: Some programming languages and compilers do not optimize tail-recursive calls,
    /// which can lead to stack overflow errors for very deep trees. Iterative algorithms avoid this issue by using an explicit stack or queue to manage traversal.
    ///
    /// Time Complexity: O(n)
    /// The time complexity of this method is O(n), where n is the number of nodes in the tree. This is because the algorithm visits each node of the tree once to calculate the maximum path sum.
    ///
    /// Space Complexity: O(h)
    /// The space complexity of this method is O(h), where h is the height of the tree. This is because the algorithm uses a stack to store nodes during traversal,
    /// and the stack can potentially contain all nodes of the tree in the worst case.
    /// In a balanced tree, where the height is logarithmic in the number of nodes (h = log n), the space complexity becomes O(log n).
    /// However, in the worst case of an unbalanced tree (h = n), the space complexity becomes O(n).
    /// </remarks>
    public static int MaxRootToLeafPathSumWithIterationAndStack(Node? root)
    {
        if (root == null)
            return 0;

        var maxPathSum = 0;
        var stack = new Stack<(Node, int)>();
        stack.Push((root, 0));

        while (stack.Count > 0)
        {
            var (node, pathSum) = stack.Pop();
            var currentPathSum = pathSum + node.Value;

            if (node.Left == null && node.Right == null)
                maxPathSum = Math.Max(maxPathSum, currentPathSum);

            if (node.Left != null)
                stack.Push((node.Left, currentPathSum));

            if (node.Right != null)
                stack.Push((node.Right, currentPathSum));
        }

        return maxPathSum;
    }
}