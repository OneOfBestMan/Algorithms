using Algorithms.Graphs.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Graphs.Services
{
    public class GraphService
    {
        public int Depth<T>(AbstractNode<T> node)
        {
            if(node.Children.Count==0)
            {
                return 1;
            }
            else
            {
                var maxDepth = 1;
                foreach(var child in node.Children)
                {
                    var depth = Depth(child);
                    if(depth>maxDepth)
                    {
                        maxDepth = depth;
                    }
                }
                return 1 + maxDepth;
            }
        }

        public AbstractNode<T> BreadthFirstSearch<T>(AbstractNode<T> rootNode, T searchedData)
        {
            var queue = new Queue<AbstractNode<T>>();
            queue.Enqueue(rootNode);
            
            while(queue.Any())
            {
                var currentNode = queue.Dequeue();
                Console.WriteLine($"visting node with Data={currentNode.Data}");
                if(currentNode.Data.Equals(searchedData))
                {
                    return currentNode;
                }
            
                foreach(var child in currentNode.Children)
                {
                    queue.Enqueue(child);
                }
            }
            return null;
        }
        
        public AbstractNode<T> DepthFirstSearch<T>(AbstractNode<T> node, T searchedData) 
        {
            Stack<AbstractNode<T>> stack = new Stack<AbstractNode<T>>();
            stack.Push(node);
            while (stack.Count > 0) 
            {
                var currentNode = stack.Pop();
                Console.WriteLine($"visting node with Data={currentNode.Data}");
                if (currentNode.Data.Equals(searchedData))
                {
                    return currentNode;
                }

                foreach (var child in currentNode.Children)
                {
                    stack.Push(child);
                }
            }
            return null;
        }
    }
}
