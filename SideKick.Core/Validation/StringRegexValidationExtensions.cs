using System.Text.RegularExpressions;

namespace SideKick.Core.Validation
{
    public static class StringRegexValidationExtensions
    {
        public static bool ContainsSpecialCharacter(this string value)
            =>  !Regex.IsMatch(value, @"^[a-zA-Z0-9 ]*$");
        

        public static bool IsValidEmailAddress(this string value)
            => Regex.IsMatch(value,
                @"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");


        public static bool IsValidPersonName(this string value)
            => Regex.IsMatch(value, @"^[a-zA-Z]+(([\'\,\.\- ][a-zA-Z ])?[a-zA-Z]*)*$");
    }
}
