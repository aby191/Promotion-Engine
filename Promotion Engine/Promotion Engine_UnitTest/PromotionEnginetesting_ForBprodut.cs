using Promotion_Engine;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Promotion_Engine_UnitTest
{
    public class PromotionEnginetesting_ForBprodut
    {
        [Fact]
        public void checkAProductValueWithQty()
        {
            BProductPack BPack = new BProductPack();
            int Sum = BPack.GetPrice(3, 50);
            Assert.Equal(75, Sum);

        }
        [Fact]
        public void checkAProductValueWithWithoutQty()
        {
            BProductPack BPack = new BProductPack();
            int Sum = BPack.GetPrice(0, 0);
            Assert.NotEqual(75, Sum);

        }
        [Fact]
        public void checkAProductValueWihoutQtyWithoutCost()
        {
            BProductPack BPack = new BProductPack();
            int Sum = BPack.GetPrice(3, 0);
            Assert.NotEqual(75, Sum);

        }
    }
}
