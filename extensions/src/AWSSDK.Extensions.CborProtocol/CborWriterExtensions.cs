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
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Util;
using System;
using System.Collections.Generic;
using System.Formats.Cbor;
using System.IO;
using System.Text.RegularExpressions;

namespace AWSSDK.Extensions.CborProtocol
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

            writer.WriteDouble(value);
        }

        /// <summary>
        /// Writes a float using the smallest CBOR representation that preserves value and precision.
        /// </summary>
        /// <param name="writer">The CBOR writer to use.</param>
        /// <param name="value">The float value to write.</param>
        public static void WriteOptimizedNumber(this CborWriter writer, float value)
        {
            if (float.IsNaN(value) || float.IsInfinity(value))
            {
                writer.WriteSingle(value);
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

            writer.WriteSingle(value);
        }
    }
}
