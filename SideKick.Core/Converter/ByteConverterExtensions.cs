using System;

namespace SideKick.Core.Converter
{
    public static class ByteConverterExtensions
    {
        /// <summary>
        /// Convert <see cref="byte[]"/> to Base64Encoded String
        /// </summary>
        /// <param name="inArray"></param>
        /// <returns>The string representation, in base 64, of the contents of inArray</returns>
        public static string ToBase64Encode(this byte[] inArray)
            => Convert.ToBase64String(inArray);
    }
}
