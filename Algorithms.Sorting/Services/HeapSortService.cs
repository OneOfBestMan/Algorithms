using System.Collections.Generic;

namespace  Algorithms.Sorting.Services
{
    public class HeapSortService
    {
        public IList<int> Sort(IList<int> items)
        {
            int i, temp;
            for (i = (items.Count / 2)-1; i >= 0; i--)
            {
                siftDown(items, i, items.Count);
            }
            for (i = items.Count-1; i >= 1; i--)
            {
                temp = items[0];
                items[0] = items[i];
                items[i] = temp;
                siftDown(items, 0, i-1);
            }
            return items;
        }
        
        private void siftDown(IList<int> items, int root, int bottom)
        {
            int done, maxChild, temp;
            done = 0;
            while ((root*2 <= bottom) && (done==0 ))
            {
                if (root*2 == bottom)
                {
                    maxChild = root * 2;
                }
                else if (items[root * 2] > items[root * 2 + 1])
                {
                    maxChild = root * 2;
                }
                else
                {
                    maxChild = root * 2 + 1;
                }

                if (items[root] < items[maxChild])
                {
                    temp = items[root];
                    items[root] = items[maxChild];
                    items[maxChild] = temp;
                    root = maxChild;
                }
                else
                {
                    done = 1;
                }
            }
        }
    }
}
