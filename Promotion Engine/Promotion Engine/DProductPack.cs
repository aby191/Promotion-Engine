using System;
using System.Collections.Generic;
using System.Text;

namespace Promotion_Engine
{

   public class DProductPack : IPack
    {
        public int ProductsCount { get; set; }
        public int GetPrice(int counterofD, int costOfD)
        {
            return (counterofD * costOfD);
        }
    }
}
