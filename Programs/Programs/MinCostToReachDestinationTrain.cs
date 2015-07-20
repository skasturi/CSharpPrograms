using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    /// <summary>
    /// http://www.geeksforgeeks.org/find-the-minimum-cost-to-reach-a-destination-where-every-station-is-connected-in-one-direction/
    /// </summary>
    public class MinCostToReachDestinationTrain
    {
        private static int[,] _cost = null;

        public static int Run(int[,] cost)
        {
            _cost = cost;
            return FindCost(0, 3);
        }

        private static int FindCost(int sourceIdx, int destIdx)
        {
            if (destIdx - sourceIdx == 1)
            {
                return _cost[sourceIdx, destIdx];
            }

            if (sourceIdx == _cost.Length - 1 || sourceIdx > destIdx)
            {
                return Int32.MaxValue;
            }

            if (sourceIdx == destIdx)
            {
                return 0;
            }

            var option1 = _cost[sourceIdx, destIdx];
            var option2 =  _cost[sourceIdx, sourceIdx + 1] + FindCost(sourceIdx + 1, destIdx);
            var option3 = FindCost(sourceIdx, destIdx - 1) + _cost[destIdx - 1, destIdx];

            return Math.Min(option1, Math.Min(option2, option3));
        }
    }
}
