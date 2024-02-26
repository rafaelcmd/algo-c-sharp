using BinaryTree.Tree;

namespace BinaryTree.TreeIncludes;

public static class TreeIncludes
{
    /// <summary>
    /// Recursively searches for a value in the tree starting from the specified root node.
    /// </summary>
    /// <param name="root">The root node of the tree to search.</param>
    /// <param name="value">The value to search for.</param>
    /// <returns>True if the value is found in the tree; otherwise, false.</returns>
    /// <remarks>
    /// Advantages of using recursion:
    /// 1. **Simplicity**: Recursive algorithms for tree traversal are often simpler and more concise compared to iterative approaches.
    /// 2. **Natural Fit**: Recursion mirrors the hierarchical structure of trees, making it intuitive for tree traversal and search operations.
    /// 3. **Ease of Implementation**: Recursive algorithms closely follow the natural definition of the problem, making them easier to implement and understand.
    /// 4. **Readability**: Recursive algorithms can be more readable and expressive, resembling pseudocode or natural language descriptions of the problem-solving process.
    /// 
    /// Time Complexity: O(n)
    /// The time complexity of this method is O(n), where n is the number of nodes in the tree. This is because the algorithm traverses each node of the tree once in the worst-case scenario,
    /// visiting all nodes to search for the target value.
    /// 
    /// Space Complexity: O(h)
    /// The space complexity of this method is O(h), where h is the height of the tree. This is because the recursive calls consume space on the call stack, proportional to the height of the tree.
    /// In a balanced tree, where the height is logarithmic in the number of nodes (h = log n), the space complexity becomes O(log n).
    /// However, in the worst case of an unbalanced tree (h = n), the space complexity becomes O(n).
    /// </remarks>
    public static bool IncludesWithRecursion(Node? root, int value)
    {
        if (root == null)
            return false;
        
        if (root.Value == value)
            return true;
        
        return IncludesWithRecursion(root.Left, value) || IncludesWithRecursion(root.Right, value);
    }
    
    /// <summary>
    /// Iteratively searches for a value in the tree starting from the specified root node, and using a Queue.
    /// </summary>
    /// <param name="root"></param>
    /// <param name="value"></param>
    /// <returns>True if the value is found in the tree; otherwise, false.</returns>
    /// <remarks>
    /// Advantages of using iteration and a queue:
    /// 1. **Space Efficiency**: Iterative algorithms often consume less space than their recursive counterparts, especially for large trees.
    /// This is because iterative algorithms do not rely on the call stack to manage recursive calls, which can lead to stack overflow errors for very deep trees.
    /// 2. **Tail Recursion Optimization**: Some programming languages and compilers do not optimize tail-recursive calls,
    /// which can lead to stack overflow errors for very deep trees. Iterative algorithms avoid this issue by using an explicit stack or queue to manage traversal.
    ///
    /// Time Complexity: O(n)
    /// The time complexity of this method is O(n), where n is the number of nodes in the tree. This is because the algorithm traverses each node of the tree once in the worst-case scenario,
    /// visiting all nodes to search for the target value.
    ///
    /// Space Complexity: O(h)
    /// The space complexity of this method is O(h), where h is the height of the tree. This is because the algorithm uses a queue to store nodes during traversal,
    /// and the queue can potentially contain all nodes of the tree in the worst case.
    /// In a balanced tree, where the height is logarithmic in the number of nodes (h = log n), the space complexity becomes O(log n).
    /// However, in the worst case of an unbalanced tree (h = n), the space complexity becomes O(n).
    /// </remarks>
    public static bool IncludesWithIterationAndQueue(Node? root, int value)
    {
        if (root == null)
            return false;
        
        var queue = new Queue<Node>();
        queue.Enqueue(root);
        
        while (queue.Count > 0)
        {
            var current = queue.Dequeue();
            
            if (current.Value == value)
                return true;
            
            if (current.Left != null)
                queue.Enqueue(current.Left);
            
            if (current.Right != null)
                queue.Enqueue(current.Right);
        }
        
        return false;
    }
    
    /// <summary>
    /// Iteratively searches for a value in the tree starting from the specified root node, and using a Stack.
    /// </summary>
    /// <param name="root"></param>
    /// <param name="value"></param>
    /// <returns>True if the value is found in the tree; otherwise, false.</returns>
    /// <remarks>
    /// Advantages of using iteration and a stack:
    /// 1. **Space Efficiency**: Iterative algorithms often consume less space than their recursive counterparts, especially for large trees.
    /// This is because iterative algorithms do not rely on the call stack to manage recursive calls, which can lead to stack overflow errors for very deep trees.
    /// 2. **Tail Recursion Optimization**: Some programming languages and compilers do not optimize tail-recursive calls, which can lead to stack overflow errors for very deep trees.
    /// Iterative algorithms avoid this issue by using an explicit stack or queue to manage traversal.
    ///
    /// Time Complexity: O(n)
    /// The time complexity of this method is O(n), where n is the number of nodes in the tree. This is because the algorithm traverses each node of the tree once in the worst-case scenario,
    /// visiting all nodes to search for the target value.
    ///
    /// Space Complexity: O(h)
    /// The space complexity of this method is O(h), where h is the height of the tree. This is because the algorithm uses a stack to store nodes during traversal,
    /// and the stack can potentially contain all nodes along the path from the root to the target node in the worst case.
    /// In a balanced tree, where the height is logarithmic in the number of nodes (h = log n), the space complexity becomes O(log n).
    /// However, in the worst case of an unbalanced tree (h = n), the space complexity becomes O(n).
    /// </remarks>
    public static bool IncludesWithIterationAndStack(Node? root, int value)
    {
        if (root == null)
            return false;
        
        var stack = new Stack<Node>();
        stack.Push(root);
        
        while (stack.Count > 0)
        {
            var current = stack.Pop();
            
            if (current.Value == value)
                return true;
            
            if (current.Right != null)
                stack.Push(current.Right);
            
            if (current.Left != null)
                stack.Push(current.Left);
        }
        
        return false;
    }
}