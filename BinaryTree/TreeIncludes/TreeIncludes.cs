using BinaryTree.Tree;

namespace BinaryTree.TreeIncludes;

/*
    The best approach for finding a value in a tree depends on the type of tree and the specific requirements of the problem. Here's a brief overview of each approach:
   
    1. Recursion: Recursion is a natural and elegant way to traverse trees. You can use recursive algorithms like depth-first search (DFS) or breadth-first search (BFS) to find a value in a tree.
    In DFS, you would typically use either an in-order, pre-order, or post-order traversal depending on the requirements of your problem. Recursion can be especially useful for binary trees and binary search trees.
   
    2. Iteration with Queue (Breadth-First Search): Using a queue-based iterative approach is suitable for breadth-first search (BFS). BFS explores nodes level by level, starting from the root.
    You enqueue each node's children as you visit them and dequeue nodes to process them. This approach is effective for finding a value in a general tree or a binary tree.
   
    3. Iteration with Stack (Depth-First Search): Using a stack-based iterative approach is suitable for depth-first search (DFS). DFS explores as far as possible along each branch before backtracking.
    You push nodes onto the stack as you visit them and pop nodes to process them. This approach is useful for finding a value in a general tree or a binary tree.
   
    Here's a quick summary of when to use each approach:
   
    1. Use recursion when the tree is small or when the problem naturally lends itself to recursive thinking. Recursive solutions are often concise and easy to understand.
   
    2. Use iteration with a queue (BFS) when you need to find the shortest path to a node or when you're working with a tree that is wider than it is deep (i.e., a tree with many children per node).
   
    3. Use iteration with a stack (DFS) when you want to conserve memory or when you're working with a deep tree (i.e., a tree with few children per node).
   
    Ultimately, the choice between recursion, iteration with a queue, and iteration with a stack depends on factors such as the size and structure of the tree, memory constraints,
    and the specific requirements of the problem you're solving. Each approach has its advantages and disadvantages, so it's essential to consider these factors when deciding which method to use.
 */

public static class TreeIncludes
{
    /// <summary>
    /// Recursively searches for a value in a binary tree rooted at the specified node.
    /// </summary>
    /// <param name="root">The root node of the binary tree to search.</param>
    /// <param name="value">The value to search for in the binary tree.</param>
    /// <returns>
    ///     <c>true</c> if the value is found in the binary tree; otherwise, <c>false</c>.
    /// </returns>
    /// <remarks>
    ///     This method performs a depth-first search (DFS) recursively to find the specified value 
    ///     in the binary tree. It returns <c>true</c> if the value is found at the current node 
    ///     or in any of its descendant nodes, otherwise returns <c>false</c>.
    /// </remarks>
    /// <seealso cref="Node"/>
    /// <remarks>
    ///     Time Complexity: O(n), where n is the number of nodes in the binary tree.
    ///     Space Complexity: O(h), where h is the height of the binary tree.
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
    /// Iteratively searches for a value in a binary tree rooted at the specified node using a queue-based approach.
    /// </summary>
    /// <param name="root">The root node of the binary tree to search.</param>
    /// <param name="value">The value to search for in the binary tree.</param>
    /// <returns>
    ///     <c>true</c> if the value is found in the binary tree; otherwise, <c>false</c>.
    /// </returns>
    /// <remarks>
    ///     This method performs a breadth-first search (BFS) iteratively using a queue to find the specified value 
    ///     in the binary tree. It enqueues each node's children as it visits them and dequeues nodes to process them.
    ///     If the value is found at any node during traversal, the method returns <c>true</c>; otherwise, it returns <c>false</c>.
    /// </remarks>
    /// <seealso cref="Node"/>
    /// <remarks>
    ///     Time Complexity: O(n), where n is the number of nodes in the binary tree.
    ///     Space Complexity: O(n), where n is the maximum number of nodes at any level of the binary tree.
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
    /// Iteratively searches for a value in a binary tree rooted at the specified node using a stack-based approach.
    /// </summary>
    /// <param name="root">The root node of the binary tree to search.</param>
    /// <param name="value">The value to search for in the binary tree.</param>
    /// <returns>
    ///     <c>true</c> if the value is found in the binary tree; otherwise, <c>false</c>.
    /// </returns>
    /// <remarks>
    ///     This method performs a depth-first search (DFS) iteratively using a stack to find the specified value 
    ///     in the binary tree. It pushes nodes onto the stack as it visits them and pops nodes to process them.
    ///     If the value is found at any node during traversal, the method returns <c>true</c>; otherwise, it returns <c>false</c>.
    /// </remarks>
    /// <seealso cref="Node"/>
    /// <remarks>
    ///     Time Complexity: O(n), where n is the number of nodes in the binary tree.
    ///     Space Complexity: O(h), where h is the height of the binary tree.
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