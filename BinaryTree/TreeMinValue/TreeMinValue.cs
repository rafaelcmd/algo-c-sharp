using BinaryTree.Tree;

namespace BinaryTree.TreeMinValue;

public static class TreeMinValue
{
    /// <summary>
    /// Recursively finds the minimum value in the tree starting from the specified root node.
    /// </summary>
    /// <param name="root">The root node of the tree to find the minimum value for.</param>
    /// <returns>The minimum value in the tree.</returns>
    /// <remarks>
    /// Advantages of using recursion:
    /// 1. **Simplicity**: Recursive algorithms are often simpler to implement and understand than their iterative counterparts.
    /// 2. **Natural Fit**: Recursion mirrors the hierarchical structure of trees, making it intuitive for tree traversal and aggregation operations.
    /// 3. **Readability**: Recursive algorithms can be more readable and expressive, resembling pseudocode or natural language descriptions of the problem-solving process.
    /// 4. **Ease of Implementation**: Recursive algorithms closely follow the natural definition of the problem, making them easier to implement and understand.
    ///
    /// Time Complexity: O(n)
    /// The time complexity of this method is O(n), where n is the number of nodes in the tree. This is because the algorithm visits each node of the tree once to find the minimum value.
    ///
    /// Space Complexity: O(h)
    /// The space complexity of this method is O(h), where h is the height of the tree. This is because the recursive calls consume space on the call stack, proportional to the height of the tree.
    /// In a balanced tree, where the height is logarithmic in the number of nodes (h = log n), the space complexity becomes O(log n).
    /// However, in the worst case of an unbalanced tree (h = n), the space complexity becomes O(n).
    /// </remarks>
    public static int MinValueWithRecursion(Node? root)
    {
        if (root == null)
            return int.MaxValue;
        
        var leftMin = MinValueWithRecursion(root.Left);
        var rightMin = MinValueWithRecursion(root.Right);
        
        return Math.Min(root.Value, Math.Min(leftMin, rightMin));
    }
    
    /// <summary>
    /// Iteratively finds the minimum value in the tree starting from the specified root node, and using a Queue.
    /// </summary>
    /// <param name="root">The root node of the tree to find the minimum value for.</param>
    /// <returns>The minimum value in the tree.</returns>
    /// <remarks>
    /// Advantages of using iteration and a queue:
    /// 1. **Space Efficiency**: Iterative algorithms often consume less space than their recursive counterparts, especially for large trees.
    /// This is because iterative algorithms do not rely on the call stack to manage recursive calls, which can lead to stack overflow errors for very deep trees.
    /// 2. **Tail Recursion Optimization**: Some programming languages and compilers do not optimize tail-recursive calls,
    /// which can lead to stack overflow errors for very deep trees. Iterative algorithms avoid this issue by using an explicit stack or queue to manage traversal.
    ///
    /// Time Complexity: O(n)
    /// The time complexity of this method is O(n), where n is the number of nodes in the tree. This is because the algorithm visits each node of the tree once to find the minimum value.
    ///
    /// Space Complexity: O(h)
    /// The space complexity of this method is O(h), where h is the height of the tree. This is because the algorithm uses a queue to store nodes during traversal,
    /// and the queue can potentially contain all nodes of the tree in the worst case.
    /// In a balanced tree, where the height is logarithmic in the number of nodes (h = log n), the space complexity becomes O(log n).
    /// However, in the worst case of an unbalanced tree (h = n), the space complexity becomes O(n).
    /// </remarks>
    public static int MinValueWithIterationAndQueue(Node? root)
    {
        if (root == null)
            throw new ArgumentNullException(nameof(root), "The root node cannot be null.");
        
        var queue = new Queue<Node>();
        queue.Enqueue(root);
        
        var minValue = int.MaxValue;
        
        while (queue.Count > 0)
        {
            var current = queue.Dequeue();
            
            minValue = Math.Min(minValue, current.Value);
            
            if (current.Left != null)
                queue.Enqueue(current.Left);
            
            if (current.Right != null)
                queue.Enqueue(current.Right);
        }
        
        return minValue;
    }
    
    /// <summary>
    /// Iteratively finds the minimum value in the tree starting from the specified root node, and using a Stack.
    /// </summary>
    /// <param name="root">The root node of the tree to find the minimum value for.</param>
    /// <returns>The minimum value in the tree.</returns>
    /// <remarks>
    /// Advantages of using iteration and a stack:
    /// 1. **Space Efficiency**: Iterative algorithms often consume less space than their recursive counterparts, especially for large trees.
    /// This is because iterative algorithms do not rely on the call stack to manage recursive calls, which can lead to stack overflow errors for very deep trees.
    /// 2. **Tail Recursion Optimization**: Some programming languages and compilers do not optimize tail-recursive calls,
    /// which can lead to stack overflow errors for very deep trees. Iterative algorithms avoid this issue by using an explicit stack or queue to manage traversal.
    ///
    /// Time Complexity: O(n)
    /// The time complexity of this method is O(n), where n is the number of nodes in the tree. This is because the algorithm visits each node of the tree once to find the minimum value.
    ///
    /// Space Complexity: O(h)
    /// The space complexity of this method is O(h), where h is the height of the tree. This is because the algorithm uses a stack to store nodes during traversal,
    /// and the stack can potentially contain all nodes of the tree in the worst case.
    /// In a balanced tree, where the height is logarithmic in the number of nodes (h = log n), the space complexity becomes O(log n).
    /// However, in the worst case of an unbalanced tree (h = n), the space complexity becomes O(n).
    /// </remarks>
    public static int MinValueWithIterationAndStack(Node? root)
    {
        if (root == null)
            throw new ArgumentNullException(nameof(root), "The root node cannot be null.");
        
        var stack = new Stack<Node>();
        stack.Push(root);
        
        var minValue = int.MaxValue;
        
        while (stack.Count > 0)
        {
            var current = stack.Pop();
            
            minValue = Math.Min(minValue, current.Value);
            
            if (current.Right != null)
                stack.Push(current.Right);
            
            if (current.Left != null)
                stack.Push(current.Left);
        }
        
        return minValue;
    }
}