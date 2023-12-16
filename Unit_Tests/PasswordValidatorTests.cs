using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WWSI_App1.Lib;

namespace Unit_Tests
{
    public class PasswordValidatorTests
    {
        [Theory]
        [InlineData("Th1sIsapassword!", true)]
        [InlineData("thisIsapassword123!", true)]
        [InlineData("Abc$123456", true)]
        [InlineData("Th1s!", false)]
        [InlineData("thisIsAPassword", false)]
        [InlineData("thisisapassword#", false)]
        [InlineData("THISISAPASSWORD123!", false)]
        [InlineData("", false)]
        public void ValidatePassword(string password, bool expectedResult)
        {
            //Arrange
            var passwordValidator = TestObjectFactory.GetPasswordValidator();

            //Act
            bool isValid = passwordValidator.IsValid(password);

            //Assert
            Assert.Equal(expectedResult, isValid);
        }
    }
}
