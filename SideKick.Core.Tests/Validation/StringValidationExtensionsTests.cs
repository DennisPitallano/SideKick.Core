using SideKick.Core.Validation;
using Xunit;

namespace SideKick.Core.Tests.Validation
{
    public class StringValidationExtensionsTests
    {
        [Fact]
        public void IsNumberTest()
        {
            //Act
            var validNumberInString = "1234567890".IsNumber();
            var notValidNumber = "~!@#$%^&*()_+".IsNumber();
            var keyBoards = "qwertyuiop[]asdfghjkl;'zxcvbnm,./".IsNumber();

            //Assert
            Assert.True(validNumberInString,"Valid Number");
            Assert.False(notValidNumber,"Special characters");
            Assert.False(keyBoards,"Keyboards");
        }

        [Fact]
        public void IsWholeNumberTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact()]
        public void IsDecimalNumberTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact()]
        public void IsBooleanTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact()]
        public void IsValidEmailFormatTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact()]
        public void IsValidCreditCardNumberTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact()]
        public void IsValidJsonTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact()]
        public void IsValidDateTimeStringTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact()]
        public void IsFutureDateTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact()]
        public void IsValidStandardDateStringTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact()]
        public void IsHtmlTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact()]
        public void IsAlphaNumericTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact()]
        public void IsAlphaNumericStrictTest()
        {
            Assert.True(false, "This test needs an implementation");
        }
    }
}