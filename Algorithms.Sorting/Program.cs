using System;
using System.Collections.Generic;
using Algorithms.Sorting.Services;

class Program
{
    static void Main(string[] args)
    {
        var unsorted = new List<int>{9,3,54,6,54,63,213,536,75,1,9};

        var heapSortService = new HeapSortService();
        var bubbleSortService = new BubbleSortService();
        //var sorted = heapSortService.Sort(unsorted);
        var sorted = bubbleSortService.Sort(unsorted);
        foreach(var item in sorted)
        {
            Console.WriteLine(item);
        }
    }
}
