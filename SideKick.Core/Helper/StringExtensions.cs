using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace SideKick.Core.Helper
{
    public static  class StringExtensions
    {
        public static string ExtractIPAddress(this string value)
        {
            var result = Regex.Match(value, @"\b(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\b");
            return result.Value;
        }
    }
}
