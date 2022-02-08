using System;

namespace NullableTypesTask
{
    /// <summary>
    /// Nullable type extension class.
    /// </summary>
    public static class NullableTypeExtensions
    {
        /// <summary>
        /// Implement for nullable types the additional possibility of determining whether
        /// the nullable variable is null or not.
        /// </summary>
        /// <param name="variable">Source parameter.</param>
        /// <returns>true if variable is null, false otherwise.</returns>
        public static bool IsNull(this object? variable)
        {
            throw new NotImplementedException("You need to implement this method.");
        }
    }
}
