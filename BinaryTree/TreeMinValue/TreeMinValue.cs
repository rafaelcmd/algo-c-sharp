using BinaryTree.Tree;

namespace BinaryTree.TreeMinValue;

public static class TreeMinValue
{
    public static int MinValueWithRecursion(Node? root)
    {
        if (root == null)
            return int.MaxValue;
        
        var leftMin = MinValueWithRecursion(root.Left);
        var rightMin = MinValueWithRecursion(root.Right);
        
        return Math.Min(root.Value, Math.Min(leftMin, rightMin));
    }
    
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