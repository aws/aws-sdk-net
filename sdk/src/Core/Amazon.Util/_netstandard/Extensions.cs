using System;
using System.Globalization;
using System.Text;

namespace Amazon.Util
{
    internal static class Extensions
    {
        internal static string ToUpper(this String str, CultureInfo culture)
        {
            if (culture != CultureInfo.InvariantCulture)
                throw new ArgumentException("The extension method ToUpper only works for invariant culture");
            return str.ToUpperInvariant();
        }

#if !NETCOREAPP3_1_OR_GREATER
        internal static int GetBytes(this Encoding encoding, string chars, byte[] bytes)
            => encoding.GetBytes(chars, 0, chars.Length, bytes, 0);
#endif
    }
}
