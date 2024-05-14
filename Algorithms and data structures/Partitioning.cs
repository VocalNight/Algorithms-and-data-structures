using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_and_data_structures
{
    public static class Partitioning
    {
        public static List<int> PartitionArray(List<int> list)
        {
            int pivot = list[list.Count - 1];

            int left = 0;
            int right = list.Count - 2;

            while (true)
            {

                while (list[left] < pivot)
                {
                    left += 1;
                }

                while (list[right] > pivot)
                {
                    right -= 1;
                }

                if (left >= right)
                {
                    break;
                }

                if (left < right)
                {
                    var extra = list[left];

                    list[left] = list[right];
                    list[right] = extra;
                }
            }

            var cache = list[left];
            list[left] = pivot;
            list[list.Count - 1] = cache;

            return list;
        }
    }
}
