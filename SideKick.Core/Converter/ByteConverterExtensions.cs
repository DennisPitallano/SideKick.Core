using System;

namespace SideKick.Core.Converter
{
    public static class ByteConverterExtensions
    {
        public static string ToBase64Encode(this byte[] value)
            => Convert.ToBase64String(value);
    }
}
