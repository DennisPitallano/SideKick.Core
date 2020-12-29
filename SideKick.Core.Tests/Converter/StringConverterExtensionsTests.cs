using System;
using SideKick.Core.Converter;
using SideKick.Core.Validation;
using Xunit;

namespace SideKick.Core.Tests.Converter
{
    public class StringConverterExtensionsTests
    {
        [Fact()]
        public void ToDateTimeTest()
        {
            var dateString = "12/02/2020".ToDateTime();
            Assert.Equal(new DateTime(2020,12,2),dateString );
            Assert.True(dateString.IsValidDateTime(), "Validate converted datetime");
        }

        [Fact()]
        public void ToNullableDateTimeTest()
        {
            var nullableDate = "".ToNullableDateTime();
            DateTime? nullDateTime = null;
            Assert.Equal(nullDateTime, nullableDate);
            Assert.False(nullableDate.IsValidDateTime(), "Validate converted nullable datetime");
        }

        [Fact()]
        public void ToInt16Test()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact()]
        public void ToInt32Test()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact()]
        public void ToNullableInt32Test()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact()]
        public void ToInt64Test()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact()]
        public void ToNullableInt64Test()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact()]
        public void ToBooleanTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact()]
        public void ToFloatTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact()]
        public void ToDecimalTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact()]
        public void ToDoubleTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact()]
        public void ToBase64EncodeTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact()]
        public void ToBase64DecodeTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact()]
        public void ToByteFromBase64CharArrayTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact()]
        public void ToByteArrayTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact()]
        public void ToDateTimeFormatTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact()]
        public void ToCamelCaseTest()
        {
            Assert.True(false, "This test needs an implementation");
        }
    }
}