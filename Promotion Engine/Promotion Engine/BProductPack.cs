using System;
using System.Collections.Generic;
using System.Text;

namespace Promotion_Engine
{
    public class BProductPack : IPack
    {
        public int ProductsCount { get; set; }
        public int GetPrice(int counterofB, int costOfB)
        {
            return (counterofB / 2) * 45 + (counterofB % 2 * costOfB);
        }
    }
}
