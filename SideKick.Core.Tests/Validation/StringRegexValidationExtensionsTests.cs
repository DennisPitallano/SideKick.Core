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
    }
}