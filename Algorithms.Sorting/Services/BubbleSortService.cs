using System;
using System.Collections.Generic;

namespace  Algorithms.Sorting.Services
{
    public class BubbleSortService
    {
        public IList<int> Sort(IList<int> items)
        {
            int temp;
            for(int i=1; i<items.Count-1; i++)
            {
                for(int j=0; j<items.Count-i; j++)
                {
                    if (items[j] > items[j + 1])
                    {
                        temp = items[j];
                        items[j] = items[j + 1];
                        items[j + 1] = temp;
                    }
                }
            }
            return items;
        }
    }
}
