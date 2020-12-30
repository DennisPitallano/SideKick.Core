using SideKick.Core.Converter;
using System;
using System.Globalization;
using System.Linq;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace SideKick.Core.Validation
{
    public static class StringValidationExtensions
    {
        /// <summary>
        /// Validate Number in string format using Regex pattern [@"^\d+$"]
        /// </summary>
        /// <param name="value"></param>
        /// <returns>True if string value is valid number/numeric else False.</returns>
        public static bool IsNumber(this string value)
            => value.All(char.IsNumber);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsWholeNumber(this string value)
            => long.TryParse(value, out _);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsDecimalNumber(this string value)
            // => value.All(char.IsDigit);
            => decimal.TryParse(value, out _);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsFloatNumber(this string value)
            => float.TryParse(value, out _);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsBoolean(this string value)
        {
            if (value.IsNumber())
            {
                return value.ToInt16()==1 || value.ToInt16()==0;
            }
            return bool.TryParse(value, out var _);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsValidCreditCardNumber(this string value)
        {
            if (string.IsNullOrEmpty(value)) { return false; }

            value = value.Replace("-", "").Replace(" ", "");

            var checksum = 0;
            var evenDigit = false;
            // http://www.beachnet.com/~hstiles/cardtype.html
            foreach (char digit in value.ToCharArray().Reverse())
            {
                if (!char.IsDigit(digit))
                {
                    return false;
                }

                var digitValue = (digit - '0') * (evenDigit ? 2 : 1);
                evenDigit = !evenDigit;

                while (digitValue > 0)
                {
                    checksum += digitValue % 10;
                    digitValue /= 10;
                }
            }

            return (checksum % 10) == 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        public static bool IsValidJson(this string json)
        {
            json = json.Trim();
            if ((json.StartsWith("{") && json.EndsWith("}")) || //For object
                (json.StartsWith("[") && json.EndsWith("]"))) //For array
            {
                try
                {
                    using var obj = JsonDocument.Parse(json);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static bool IsValidDateTimeString(this string date)
            => date.ToDateTime() != default;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static bool IsFutureDate(this string date)
            => date.ToDateTime() >= DateTime.Today;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsValidStandardDateString(this string value)
            => DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out _);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsHtml(this string value)
             => Regex.IsMatch(value, @"<\s*([^ >]+)[^>]*>.*?<\s*/\s*\1\s*>");

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsAlphaNumeric(this string value)
            => value.All(char.IsLetterOrDigit);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsAlphaNumericStrict(this string value)
            => value.All(c => (c >= 48 && c <= 57 || c >= 65 && c <= 90 || c >= 97 && c <= 122));

    }
}
