

using System;

namespace StringExtensionsLib
{
    public static class StringExtensions
    {
        public static bool StartsWithUpperCase(this string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return false;
            }

            // Check if the first character is an uppercase letter
            return char.IsUpper(str[0]);
        }
    }
}