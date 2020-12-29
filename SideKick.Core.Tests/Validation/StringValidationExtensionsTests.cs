using SideKick.Core.Validation;
using Xunit;

namespace SideKick.Core.Tests.Validation
{
    public class StringValidationExtensionsTests
    {
        [Fact()]
        public void IsNumberTest()
        {
            Assert.True("1234567890".IsNumber(),"Valid Number");
            Assert.False("~!@#$%^&*()_+".IsNumber());
            Assert.False("qwertyuiop[]asdfghjkl;'zxcvbnm,./".IsNumber());
        }

        [Fact()]
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