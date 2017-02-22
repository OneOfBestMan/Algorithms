using System;
using Algorithms.Graphs.Model;
using Algorithms.Graphs.Services;

class Program
{
    static void Main(string[] args)
    {
        var root = new BinaryNode<int>(1);
        root.AddLeft(new BinaryNode<int>(2));
        root.AddRight(new BinaryNode<int>(3));
        root.Left.AddLeft(new BinaryNode<int>(4));
        root.Left.AddRight(new BinaryNode<int>(5));
        root.Right.AddLeft(new BinaryNode<int>(6));
        root.Right.AddRight(new BinaryNode<int>(7));
        root.Right.Right.AddLeft(new BinaryNode<int>(8));
        root.Right.Right.AddRight(new BinaryNode<int>(9));

        Console.WriteLine($"root.Data={root.Data}");

        var graphService = new GraphService();
        Console.WriteLine($"root.Depth={graphService.Depth(root)}");

        Console.WriteLine("searching using BreadthSearchFirst...");
        var searchedNode = graphService.BreadthFirstSearch(root,8);
        if(searchedNode != null)
        {
            Console.WriteLine($"found node with Id={searchedNode.Id}");
        }
        else
        {
            Console.WriteLine("node not found :(");
        }

        Console.WriteLine("searching using DepthSearchFirst...");
        searchedNode = graphService.DepthFirstSearch(root,8);
        if(searchedNode != null)
        {
            Console.WriteLine($"found node with Id={searchedNode.Id}");
        }
        else
        {
            Console.WriteLine("node not found :(");
        }
    }
}
