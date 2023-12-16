using WWSI_App1.Lib;

VatCalc vatCalc = new VatCalc(23);

Console.WriteLine("100 brutto = " + vatCalc.CalculateGross(100));
Console.WriteLine("223 netto = "+ vatCalc.CalculateNet(223));
Console.WriteLine("511 brutto = " + vatCalc.CalculateGross(511));
Console.WriteLine("628 netto = " + vatCalc.CalculateNet(628));
