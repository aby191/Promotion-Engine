using System;
using System.Collections.Generic;
using System.Text;

namespace Promotion_Engine
{
    public class AProductPack: IPack
    {
        public int ProductsCount { get; set; }
        public int GetPrice(int counterofA, int costOfA)
        {
            return (counterofA / 3) * 130 + (counterofA % 3 * costOfA);
        }
    }
}
