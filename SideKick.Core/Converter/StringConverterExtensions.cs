using System;
using System.Globalization;
using System.Text;
using SideKick.Core.Validation;

namespace SideKick.Core.Converter
{
    public static class StringConverterExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static DateTime ToDateTime(this string value)
          => DateTime.TryParse(value, out var result) ? result : default;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static DateTime? ToNullableDateTime(this string value)
              => !string.IsNullOrEmpty((value ?? "").Trim()) ? value.ToDateTime() : (DateTime?)null;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static short ToInt16(this string value)
            => short.TryParse(value, out var result) ? result : default;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int ToInt32(this string value)
            => int.TryParse(value, out var result) ? result : default;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int? ToNullableInt32(this string value)
            => !string.IsNullOrEmpty(value) ? value.ToInt32() : (int?)null;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static long ToInt64(this string value)
            => long.TryParse(value, out var result) ? result : default;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static long? ToNullableInt64(this string value)
        => !string.IsNullOrEmpty(value) ? value.ToInt64() : (long?)null;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool ToBoolean(this string value)
        {
            if (value.IsNumber())
            {
               return value.ToInt16()==1;
            }
           return bool.TryParse(value, out var result) ? result : default;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static float ToFloat(this string value)
            => float.TryParse(value, out var result) ? result : default;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal ToDecimal(this string value)
            => decimal.TryParse(value, out var result) ? result : default;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static double ToDouble(this string value)
           => double.TryParse(value, out var result) ? result : default;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ToBase64Encode(this string value)
            => Convert.ToBase64String(Encoding.UTF8.GetBytes(value));

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ToBase64Decode(this string value)
            => Encoding.UTF8.GetString(Convert.FromBase64String(value));

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static byte[] ToByteFromBase64CharArray(this string value)
            => Convert.FromBase64CharArray(value.ToCharArray(), 0, value.Length);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static byte[] ToByteArray(this string value)
            => Convert.FromBase64String(value);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="date"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        public static string ToDateTimeFormat(this string date, string format)
            => date.ToDateTime().ToString(format, CultureInfo.InvariantCulture);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ToCamelCase(this string value)
        {
            if (!string.IsNullOrEmpty(value) && value.Length > 1)
            {
                return char.ToLowerInvariant(value[0]) + value.Substring(1);
            }
            return value;
        }
    }
}
