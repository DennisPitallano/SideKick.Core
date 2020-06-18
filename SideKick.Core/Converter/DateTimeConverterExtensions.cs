using System;

namespace SideKick.Core.Converter
{
    public static class DateTimeConverterExtensions
    {
        public static int GetYearsFromDate(this DateTime date)
        {
            var now = DateTime.UtcNow;
            int years = now.Year - date.Year;

            if ((date.Month > now.Month) || (date.Month == now.Month && date.Day > now.Day))
                years--;

            return years;
        }

        public static int GetYearsDifference(this DateTime date, DateTime dateToCompare)
        {
            int years = dateToCompare.Year - date.Year;

            if ((date.Month > dateToCompare.Month) || (date.Month == dateToCompare.Month && date.Day > dateToCompare.Day))
                years--;

            return years;
        }
    }
}
