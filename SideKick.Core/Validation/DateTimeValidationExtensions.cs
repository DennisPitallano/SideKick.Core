using System;

namespace SideKick.Core.Validation
{
    public static class DateTimeValidationExtensions
    {
        public static bool IsValidDateTime(this DateTime? date)
            => date != default;

        public static bool IsValidDateTime(this DateTime date)
            => date != default;
    }
}
