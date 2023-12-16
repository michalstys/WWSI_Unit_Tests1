namespace WWSI_App1.Lib
{
    public class VatCalc : IVatCalc
    {
        public int VatValuePercent { get; private set; }

        private readonly decimal VatValueFactor;

        public VatCalc(int vatValuePercent) 
        {
            VatValuePercent = vatValuePercent;

            VatValueFactor = 1 + (decimal)VatValuePercent / 100;
        }

        public decimal CalculateGross(decimal netPrice)
        {
            decimal result = netPrice * VatValueFactor;

            return RoundResult(result);
        }

        public decimal CalculateNet(decimal grossPrice)
        {
            decimal result = grossPrice / VatValueFactor;

            return RoundResult(result);
        }

        private static decimal RoundResult(decimal result)
        {
            return decimal.Round(result, 2, MidpointRounding.AwayFromZero);
        }
    }
}
