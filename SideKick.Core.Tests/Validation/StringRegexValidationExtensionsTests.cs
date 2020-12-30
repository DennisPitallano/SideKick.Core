using SideKick.Core.Validation;
using Xunit;


namespace SideKick.Core.Tests.Validation
{
    public class StringRegexValidationExtensionsTests
    {
        [Fact()]
        public void ContainsSpecialCharacterTest()
        {
            //Act
            const string withSpecialCharacters = "123@+";
            const string withNoSpecialCharacters = "1235345345 qwertyuiopasdfghjklzxcvbnm";
            //Assert
            Assert.True(withSpecialCharacters.ContainsSpecialCharacter(), "Contains special characters");
            Assert.False(withNoSpecialCharacters.ContainsSpecialCharacter(), "Contains No special characters");
        }

        [Fact()]
        public void IsValidEmailAddressTest()
        {
            //Act
            const string myEmail = "dennip@bss-ph.com";
            const string myWrongEmail = "@dennip@bss-ph";
            //Assert
            Assert.True(myEmail.IsValidEmailAddress(), "Test Valid email address");
            Assert.False(myWrongEmail.IsValidEmailAddress(), "Test Valid email address");
        }

        [Fact]
        public void IsValidPersonNameTest()
        {
            //Act
            const string myName = "Dennis Pitallano";
            //Assert
            Assert.True(myName.IsValidPersonName(),"My Name");
            Assert.False("Dennis @ Pitallano".IsValidPersonName(),"My Name");
        }

        [Fact()]
        public void IsIPv6AddressTest()
        {
            //Act
            var ipv6 = "61762:0:0:0:0:B03:1:AF18";
            Assert.True(ipv6.IsIPv6Address(), "Valid IPV6");
            Assert.False("192.168.0.1".IsIPv6Address(), "Valid IPV6");
        }

        [Fact()]
        public void IsIPAddressTest()
        {
            Assert.True("192.168.0.1".IsIPAddress(), "Valid IP");
            Assert.True("127.0.0.1".IsIPAddress(), "Valid IP");
            Assert.False("1127.0.0.1".IsIPAddress(), "Not Valid IP");
        }

        [Fact()]
        public void IsValidUrlTest()
        {
            Assert.True("http://www.google.com".IsValidUrl());
            Assert.True("https://www.google.com?v=D".IsValidUrl());
            Assert.False("htt://www.google.com?v=D$#3434".IsValidUrl());
        }

        [Fact()]
        public void IsValidDomainTest()
        {
            Assert.True("test.agoogle.com".IsValidDomain(), "This test needs an implementation");
        }
    }
}