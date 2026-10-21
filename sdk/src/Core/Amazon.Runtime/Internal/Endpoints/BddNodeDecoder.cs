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
using System.Buffers.Binary;

namespace Amazon.Runtime.Internal.Endpoints
{
    /// <summary>
    /// Base64-decodes representation of Endpoints BDD nodes.
    /// </summary>
    public static class BddNodeDecoder
    {
        /// <summary>
        /// Decodes the base64-encoded BDD node blob into a flat array of signed 32-bit
        /// integers, three per node: [conditionIndex, highRef, lowRef].
        /// </summary>
        public static int[] Decode(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            var count = bytes.Length / 4;
            var result = new int[count];
            for (int i = 0; i < count; i++)
            {
                result[i] = BinaryPrimitives.ReadInt32BigEndian(bytes.AsSpan(i * 4));
            }
            return result;
        }
    }
}
