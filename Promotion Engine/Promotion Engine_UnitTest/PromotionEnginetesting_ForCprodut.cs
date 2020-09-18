using Promotion_Engine;
using System;
using Xunit;

namespace Promotion_Engine_UnitTest
{
    public class PromotionEnginetesting_ForCprodut
    {
        [Fact]
        public void checkAProductValueWithQty()
        {
            CProductPack CPack = new CProductPack();
            int Sum = CPack.GetPrice(3, 60);
            Assert.Equal(130, Sum);

        }
        [Fact]
        public void checkAProductValueWithWithoutQty()
        {
            AProductPack CPack = new AProductPack();
            int Sum = CPack.GetPrice(0,0);
            Assert.NotEqual(60, Sum);

        }
        [Fact]
        public void checkAProductValueWihoutQtyWithoutCost()
        {
            AProductPack CPack = new AProductPack();
            int Sum = CPack.GetPrice(3, 0);
            Assert.NotEqual(60, Sum);

        }
    }
}
