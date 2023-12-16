using WWSI_App1.Lib;

namespace Unit_Tests
{
    public class VatCalcTests_params
    {
        // [Theory] - adnotacja oznacza test sparametryzowany
        [Theory]
        [InlineData(23, 100, 123)]
        [InlineData(23, 200, 246)]
        [InlineData(23, 500, 615)]
        [InlineData(8, 500, 540)]
        public void TestVatCalc_Gross(int vatValuePercent, decimal netValue, decimal grossValue)
        {
            //Arrange
            var vatCalc = TestObjectFactory.GetVatCalc(vatValuePercent);

            //Act
            decimal calculatedGrossValue = vatCalc.CalculateGross(netValue);

            //Assert
            Assert.Equal(calculatedGrossValue, grossValue);
        }

        [Theory]
        [InlineData(23, 123, 100)]
        [InlineData(23, 246, 200)]
        [InlineData(23, 500, 406.50)]
        [InlineData(23, 201, 163.41)]
        [InlineData(23, 202.50, 164.63)]
        [InlineData(23, 66.42, 54)]
        [InlineData(8, 66.42, 61.5)]
        public void TestVatCalc_Net(int vatValuePercent, decimal grossValue, decimal netValue)
        {
            //Arrange
            var vatCalc = TestObjectFactory.GetVatCalc(vatValuePercent);

            //Act
            decimal calculatedNetValue = vatCalc.CalculateNet(grossValue);

            //Assert
            Assert.Equal(calculatedNetValue, netValue);
        }
    }
}