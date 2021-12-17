using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackBlocks
{
    public class MinimumWidthCalculator
    {
        public int PackBlock(int[] blocks, int height)
        {
            int start = blocks.Max();
            int end = 100000;

            while (start <= end)
            {
                int mid = (start + end) / 2;
                int subSum = 0;
                int numberOfSubArray = 1;
                for (int i = 0; i < blocks.Length; i++)
                {
                    if (subSum + blocks[i] > mid)
                    {
                        subSum = blocks[i];
                        numberOfSubArray++;
                    }
                    else
                    {
                        subSum += blocks[i];
                    }
                }

                if (numberOfSubArray <= height)
                    end = mid - 1;
                else
                    start = mid + 1;
            }

            return start;
        }
    }
}
