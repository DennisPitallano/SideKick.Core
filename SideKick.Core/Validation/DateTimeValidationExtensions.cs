using System;

namespace SideKick.Core.Validation
{
    public static class DateTimeValidationExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static bool IsValidDateTime(this DateTime? date)
            => date != default;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static bool IsValidDateTime(this DateTime date)
            => date != default;
    }
}
