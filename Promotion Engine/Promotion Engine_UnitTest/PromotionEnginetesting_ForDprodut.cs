using Promotion_Engine;
using System;
using Xunit;

namespace Promotion_Engine_UnitTest
{
    public class PromotionEnginetesting_ForDprodut
    {
        [Fact]
        public void checkAProductValueWithQty()
        {
            DProductPack DPack = new DProductPack();
            int Sum = DPack.GetPrice(3, 45);
            Assert.Equal(130, Sum);

        }
        [Fact]
        public void checkAProductValueWithWithoutQty()
        {
            DProductPack DPack = new DProductPack();
            int Sum = DPack.GetPrice(0,0);
            Assert.NotEqual(45, Sum);

        }
        [Fact]
        public void checkAProductValueWihoutQtyWithoutCost()
        {
            AProductPack DPack = new AProductPack();
            int Sum = DPack.GetPrice(3, 0);
            Assert.NotEqual(45, Sum);

        }
    }
}
