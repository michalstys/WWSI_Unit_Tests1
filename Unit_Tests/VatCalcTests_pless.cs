using WWSI_App1.Lib;

namespace Unit_Tests
{
    public class VatCalcTests_pless
    {
        // [Fact] - adnotacja oznacza test bez parametrów
        [Fact]
        public void TestVatCalc_Gross()
        {
            //Arrange
            var vatCalc = TestObjectFactory.GetVatCalc(23);

            //Act
            decimal grossValue = vatCalc.CalculateGross(100);

            //Assert
            Assert.Equal(123, grossValue);
        }

        [Fact]
        public void TestVatCalc_Net()
        {
            //Arrange
            var vatCalc = TestObjectFactory.GetVatCalc(23);

            //Act
            decimal netValue = vatCalc.CalculateNet(123);

            //Assert
            Assert.Equal(100, netValue);
        }
    }
}