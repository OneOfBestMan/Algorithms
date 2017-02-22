using System;
using System.Collections.Generic;

namespace Algorithms.Graphs.Model
{
	public abstract class AbstractNode<T>
	{
		public Guid Id { get; set; }
		public T Data {get;set;}
		public IList<AbstractNode<T>> Children;

		public AbstractNode(T data)
		{
			Data = data;
			Id = Guid.NewGuid();
			Children = new List<AbstractNode<T>>();
		}
	}
}
