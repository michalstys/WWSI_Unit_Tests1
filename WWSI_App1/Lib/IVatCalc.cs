namespace WWSI_App1.Lib
{
    public interface IVatCalc
    {
        decimal CalculateGross(decimal netPrice);
        decimal CalculateNet(decimal grossPrice);
    }
}
