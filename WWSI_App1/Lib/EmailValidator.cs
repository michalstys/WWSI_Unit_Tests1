using System.Net.Mail;
using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;

namespace WWSI_App1.Lib
{
    public class EmailValidator : IValidator
    {
        public bool IsValid(string email)
        {
            if (string.IsNullOrEmpty(email)) 
                return false;

            try
            {
                MailAddress m = new MailAddress(email);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
