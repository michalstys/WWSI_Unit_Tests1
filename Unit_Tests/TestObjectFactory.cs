using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WWSI_App1.Lib;

namespace Unit_Tests
{
    public static class TestObjectFactory
    {
        public static IVatCalc GetVatCalc(int vatValuePercent)
        {
            return new VatCalc(vatValuePercent);
        }

        public static IValidator GetPasswordValidator()
        {
            return new PasswordValidator();
        }

        public static IValidator GetEmailValidator()
        {
            return new EmailValidator();
        }
    }
}
