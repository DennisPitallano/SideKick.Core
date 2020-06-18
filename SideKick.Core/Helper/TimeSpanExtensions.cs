using System;

namespace SideKick.Core.Helper
{
    public static class TimeSpanExtensions
    {
        /// <summary>
        /// Subtracts given <see cref="TimeSpan"/> from current date (<see cref="DateTime.Now"/>) and returns resulting <see cref="DateTime"/> in the past.
        /// </summary>
        public static DateTime Ago(this TimeSpan from)
        {
            return from.Before(DateTime.Now);
        }


        /// <summary>
        /// Subtracts given <see cref="TimeSpan"/> from <paramref name="originalValue"/> <see cref="DateTime"/> and returns resulting <see cref="DateTime"/> in the past.
        /// </summary>
        public static DateTime Ago(this TimeSpan from, DateTime originalValue)
        {
            return from.Before(originalValue);
        }

        /// <summary>
        /// Subtracts given <see cref="TimeSpan"/> from <paramref name="originalValue"/> <see cref="DateTime"/> and returns resulting <see cref="DateTime"/> in the past.
        /// </summary>
        public static DateTime Before(this TimeSpan from, DateTime originalValue)
        {
            return originalValue - from;
        }

        /// <summary>
        /// Adds given <see cref="TimeSpan"/> to current <see cref="DateTime.Now"/> and returns resulting <see cref="DateTime"/> in the future.
        /// </summary>
        public static DateTime FromNow(this TimeSpan from)
        {
            return from.From(DateTime.Now);
        }

        /// <summary>
        /// Adds given <see cref="TimeSpan"/> to supplied <paramref name="originalValue"/> <see cref="DateTime"/> and returns resulting <see cref="DateTime"/> in the future.
        /// </summary>
        public static DateTime From(this TimeSpan from, DateTime originalValue)
        {
            return originalValue + from;
        }

        /// <summary>
        /// Adds given <see cref="TimeSpan"/> to supplied <paramref name="originalValue"/> <see cref="DateTime"/> and returns resulting <see cref="DateTime"/> in the future.
        /// </summary>
        /// <seealso cref="From(TimeSpan, DateTime)"/>
        /// <remarks>
        /// Synonym of <see cref="From(TimeSpan, DateTime)"/> method.
        /// </remarks>
        public static DateTime Since(this TimeSpan from, DateTime originalValue)
        {
            return From(from, originalValue);
        }

    }
}
