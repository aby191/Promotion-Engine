using System;
using System.Collections.Generic;
using System.Text;

namespace Promotion_Engine
{
    public class CProductPack : IPack
    {
        public int ProductsCount { get; set; }
        public int GetPrice(int counterofC, int costOfC) => (counterofC * costOfC);
    }
}
