using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WWSI_App1.Lib;

namespace Unit_Tests
{
    public class EmailValidatorTests
    {
        [Theory]
        [InlineData("john.smith@company.com", true)]
        [InlineData("johnsmith@company.com", true)]
        [InlineData("john.smith@company.comma", true)]
        [InlineData("john.smith@company.it", true)]
        [InlineData("john.smith.company.com", false)]
        [InlineData("john@smith@company.com", false)]
        [InlineData("john", false)]
        [InlineData("", false)]
        public void ValidateEmail(string email, bool expectedResult)
        {
            //Arrange
            var emailValidator = TestObjectFactory.GetEmailValidator();

            //Act
            bool isValid = emailValidator.IsValid(email);

            //Assert
            Assert.Equal(expectedResult, isValid);
        }
    }
}
