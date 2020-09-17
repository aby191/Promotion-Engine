using Promotion_Engine;
using System;
using Xunit;

namespace Promotion_Engine_UnitTest
{
    public class PromotionEngine
    {
        [Fact]
        public void checkAProductValueWithQty()
        {
            AProductPack APack = new AProductPack();
            int Sum =APack.GetPrice(3, 50);
            Assert.Equal(130, Sum);

        }
        [Fact]
        public void checkAProductValueWithWithoutQty()
        {
            AProductPack APack = new AProductPack();
            int Sum = APack.GetPrice(3,0);
            Assert.Equal(130, Sum);

        }
        [Fact]
        public void checkAProductValueWihoutQtyWithoutCost()
        {
            AProductPack APack = new AProductPack();
            int Sum = APack.GetPrice(3, 50);
            Assert.Equal(130, Sum);

        }
    }
}
