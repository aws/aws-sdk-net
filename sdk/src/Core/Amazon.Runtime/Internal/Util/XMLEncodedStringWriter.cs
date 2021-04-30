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
using System.IO;

namespace Amazon.Runtime.Internal.Util
{

    /// <summary>
    /// Overridden StringWriter that escapes additional characters in XML requests for consistency across AWS SDKs.
    /// There isn't an XmlWriterSettings.NewLineHandling value which matches the desired
    /// encoding, so this replaces the characters that NewLineHandling.Entitize doesn't encode
    /// </summary>
    public class XMLEncodedStringWriter : StringWriter
    {
        public XMLEncodedStringWriter(IFormatProvider formatProvider) : base(formatProvider)
        {
        }

        /// <summary>
        /// Writes a range of a character array to the underlying string buffer and 
        /// encodes additional characters for AWS XML requests
        /// </summary>
        /// <param name="buffer">Characters to write to underlying string buffer</param>
        /// <param name="index">Position in buffer to start writing from</param>
        /// <param name="count">Number of characters to write</param>
        public override void Write(char[] buffer, int index, int count)
        {
            if (buffer == null)
            {
                throw new ArgumentNullException(nameof(buffer));
            }
            if (index < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }
            if (count < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(count));
            }
            if (buffer.Length - index < count)
            {
                throw new ArgumentException();
            }

            // Write directly to the underlying StringWriter's internal StringBuilder
            var stringBuilder = GetStringBuilder();

            for (int i = index; i < index + count; i++)
            {
                switch (buffer[i])
                {
                    // We're still relying on NewLineHandling.Entitize to handle \r
                    case '\n':
                        stringBuilder.Append("&#xA;");
                        break;
                    case '\u0085':
                        stringBuilder.Append("&#x85;");
                        break;
                    case '\u2028':
                        stringBuilder.Append("&#x2028;");
                        break;
                    default:
                        stringBuilder.Append(buffer[i]);
                        break;
                }
            }
        }
    }
}
