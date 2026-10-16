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
using System.Buffers;
using System.Formats.Cbor;
using System.IO;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Util;

namespace Amazon.Extensions.CborProtocol
{
    /// <summary>
    /// SDK-specific write helpers for <see cref="CborContentWriter"/>, mirroring <see cref="CborWriterExtensions"/>
    /// so the generated marshaller call sites resolve identically regardless of which writer the context carries.
    /// </summary>
    public static class CborContentWriterExtensions
    {
        /// <summary>
        /// Writes the contents of a <see cref="MemoryStream"/> as a CBOR byte string without a <c>ToArray</c>
        /// allocation: the stream's buffer is used directly when visible, otherwise a pooled buffer is used.
        /// </summary>
        public static void WriteByteString(this CborContentWriter writer, MemoryStream value)
        {
            if (value.TryGetBuffer(out var segment))
            {
                writer.WriteByteString(segment.AsSpan());
            }
            else
            {
                var length = (int)value.Length;
                var array = ArrayPool<byte>.Shared.Rent(length);
                try
                {
                    value.Position = 0;
                    int totalRead = 0;
                    int bytesRead;
                    while (totalRead < length && (bytesRead = value.Read(array, totalRead, length - totalRead)) > 0)
                    {
                        totalRead += bytesRead;
                    }
                    writer.WriteByteString(new ReadOnlySpan<byte>(array, 0, totalRead));
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(array);
                }
            }
        }

        /// <summary>Writes the DateTime as a tag-1 Unix epoch seconds value, the only timestamp form CBOR uses here.</summary>
        public static void WriteDateTime(this CborContentWriter writer, DateTime value)
        {
            writer.WriteTag(CborTag.UnixTimeSeconds);
            writer.WriteOptimizedNumber(AWSSDKUtils.ConvertToUnixEpochSecondsDouble(value));
        }

        /// <summary>Writes a double using the smallest CBOR representation that preserves value and precision.</summary>
        public static void WriteOptimizedNumber(this CborContentWriter writer, double value)
        {
            if (double.IsNaN(value) || double.IsInfinity(value))
            {
                writer.WriteDouble(value);
                return;
            }

            if (value % 1 == 0)
            {
                if (value >= long.MinValue && value <= long.MaxValue)
                {
                    writer.WriteInt64((long)value);
                    return;
                }

                if (value >= 0 && value <= ulong.MaxValue)
                {
                    writer.WriteUInt64((ulong)value);
                    return;
                }
            }

            float floatCandidate = (float)value;
            if ((double)floatCandidate == value)
            {
                WriteOptimizedNumber(writer, floatCandidate);
                return;
            }

            writer.WriteDouble(value);
        }

        /// <summary>Writes a float using the smallest CBOR representation that preserves value and precision.</summary>
        public static void WriteOptimizedNumber(this CborContentWriter writer, float value)
        {
            if (value % 1 == 0)
            {
                if (value >= long.MinValue && value <= long.MaxValue)
                {
                    writer.WriteInt64((long)value);
                    return;
                }

                if (value >= 0 && value <= ulong.MaxValue)
                {
                    writer.WriteUInt64((ulong)value);
                    return;
                }
            }

            // float32 marker (0xFA) + big-endian single, matching CborWriterExtensions' manual encoding.
            writer.WriteSingle(value);
        }
    }
}
