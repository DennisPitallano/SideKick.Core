using System.Collections.Generic;
using JetBrains.Annotations;

namespace SideKick.Core.Validation
{
    public static class CollectionValidationExtensions
    {
        /// <summary>
        /// Checks whatever given collection object is null or has no item.
        /// </summary>
        public static bool IsNullOrEmpty<T>([CanBeNull] this ICollection<T> source)
        {
            return source == null || source.Count <= 0;
        }
    }
}
