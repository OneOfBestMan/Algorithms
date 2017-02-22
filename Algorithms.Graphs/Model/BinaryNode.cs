using System;

namespace Algorithms.Graphs.Model
{
    public class BinaryNode<T> : AbstractNode<T>
    {
        public BinaryNode<T> Left {get;set;}
        public BinaryNode<T> Right {get;set;}
        
        public BinaryNode(T data):base(data)
        {}

        public void AddLeft(BinaryNode<T> node)
        {
            if(Left!=null)
            {
                throw new InvalidOperationException("left child already assigned");
            }
            Left = node;
            Children.Add(node);
        }
        
        public void AddRight(BinaryNode<T> node)
        {
            if(Right!=null)
            {
                throw new InvalidOperationException("left child already assigned");
            }
            Right = node;
            Children.Add(node);
        }
    }
}
