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

#if NETSTANDARD || NETFRAMEWORK
        /// <summary>
        ///     Encodes into a span of bytes a set of characters from the specified read-only span.
        /// </summary>
        /// <param name="encoding">The encoding to be used.</param>
        /// <param name="src">The span containing the set of characters to encode.</param>
        /// <param name="dest">The byte span to hold the encoded bytes.</param>
        /// <returns>The count of encoded bytes.</returns>
        /// <remarks>
        ///     The method was introduced as a compatibility shim for .NET Standard and can be replaced for target frameworks that provide those methods out of the box.
        /// </remarks>
        /// <seealso
        ///     href="https://docs.microsoft.com/dotnet/api/system.text.encoding.getbytes?view=netstandard-2.1#system-text-encoding-getbytes(system-readonlyspan((system-char))-system-span((system-byte)))" />
        public static unsafe int GetBytes(this Encoding encoding,
            ReadOnlySpan<char> src,
            Span<byte> dest)
        {
            if (src.Length == 0) return 0;

            if (dest.Length == 0) return 0;

            fixed (char* charPointer = src)
            {
                fixed (byte* bytePointer = dest)
                {
                    return encoding.GetBytes(
                        charPointer,
                        src.Length,
                        bytePointer,
                        dest.Length);
                }
            }
        }

        /// <summary>
        ///     When overridden in a derived class, decodes all the bytes in the specified byte span into a string.
        /// </summary>
        /// <param name="encoding">The encoding to be used.</param>
        /// <param name="bytes">A read-only byte span to decode to a Unicode string.</param>
        /// <returns>A string that contains the decoded bytes from the provided read-only span.</returns>
        /// <remarks>
        ///     The method was introduced as a compatibility shim for .NET Standard and can be replaced for target frameworks that provide those methods out of the box.
        /// </remarks>
        public static unsafe string GetString(this Encoding encoding, ReadOnlySpan<byte> bytes)
        {
            if (bytes.Length == 0) return string.Empty;

            fixed (byte* bytePointer = bytes)
            {
                return encoding.GetString(bytePointer, bytes.Length);
            }
        }
#endif
    }
}
