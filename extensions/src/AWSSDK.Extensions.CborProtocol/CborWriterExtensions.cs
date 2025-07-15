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
using System.Formats.Cbor;
using Amazon.Util;

namespace Amazon.Extensions.CborProtocol
{
    public static class CborWriterExtensions
    {
        /// <summary>
        /// Writes the DateTime as UnixEpochSeconds which is the only type we support for CBOR.
        /// </summary>
        /// <param name="writer">The CBOR writer to use.</param>
        /// <param name="value">The DateTime value to write.</param>
        public static void WriteDateTime(this CborWriter writer, DateTime value)
        {
            writer.WriteTag(CborTag.UnixTimeSeconds);
            writer.WriteOptimizedNumber(AWSSDKUtils.ConvertToUnixEpochSecondsDouble(value));
        }

        /// <summary>
        /// Writes a double using the smallest CBOR representation that preserves value and precision.
        /// </summary>
        /// <param name="writer">The CBOR writer to use.</param>
        /// <param name="value">The double value to write.</param>
        public static void WriteOptimizedNumber(this CborWriter writer, double value)
        {
            if (double.IsNaN(value) || double.IsInfinity(value))
            {
                writer.WriteDouble(value); // Write NaN or Infinity as a double.
                return;
            }

            // If the value is an integer (without fractional part), write it as Int64 or UInt64.
            if (value % 1 == 0)
            {
                if (value >= long.MinValue && value <= long.MaxValue)
                {
                    // If the value fits within the signed 64-bit integer (long) range,
                    // WriteInt64 serializes it into the smallest CBOR type representation
                    // that can contain its value without loss of precision.
                    writer.WriteInt64((long)value);
                    return;
                }

                if (value >= 0 && value <= ulong.MaxValue)
                {
                    // If the value is non-negative and fits within the unsigned 64-bit range,
                    // WriteUInt64 serializes it into the smallest possible CBOR type representation.
                    writer.WriteUInt64((ulong)value);
                    return;
                }
            }

            // Check if value can safely be represented as float32
            float floatCandidate = (float)value;
            if ((double)floatCandidate == value)
            {
                WriteOptimizedNumber(writer, floatCandidate);
                return;
            }

            // If none of the above conditions are satisfied, write the value as a double.
            writer.WriteDouble(value);
        }

        /// <summary>
        /// Writes a float using the smallest CBOR representation that preserves value and precision.
        /// This method uses manual encoding to avoid writing as a half-precision float.
        /// </summary>
        /// <param name="writer">The CBOR writer to use.</param>
        /// <param name="value">The float value to write.</param>
        public static void WriteOptimizedNumber(this CborWriter writer, float value)
        {
            // If the value is an integer (without fractional part), write it as Int64 or UInt64.
            if (value % 1 == 0)
            {
                if (value >= long.MinValue && value <= long.MaxValue)
                {
                    // If the value fits within the signed 64-bit integer (long) range,
                    // WriteInt64 serializes it into the smallest CBOR type representation
                    // that can contain its value without loss of precision.
                    writer.WriteInt64((long)value);
                    return;
                }

                if (value >= 0 && value <= ulong.MaxValue)
                {
                    // If the value is non-negative and fits within the unsigned 64-bit range,
                    // WriteUInt64 serializes it into the smallest possible CBOR type representation.
                    writer.WriteUInt64((ulong)value);
                    return;
                }
            }

            // Manual encoding to avoid half-precision floats
            var bytes = new byte[5];
            bytes[0] = 0xFA; // CBOR float32 marker
            BitConverter.GetBytes(value).CopyTo(bytes, 1);

            // Ensure the bytes are in the correct endian order for CBOR.
            if (BitConverter.IsLittleEndian)
                Array.Reverse(bytes, 1, 4);

            writer.WriteEncodedValue(bytes);
        }
    }
}
