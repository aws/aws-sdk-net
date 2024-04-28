#if NETSTANDARD
/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

using System;
using System.Text;

namespace Amazon.Runtime.Internal.Util
{
    /// <summary>
    ///     Encoding extensions used to provide a compatibility shim for encoding methods that are missing in .NET Standard
    ///     2.0.
    /// </summary>
    internal static class EncodingExtensions
    {
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
    }
}
#endif