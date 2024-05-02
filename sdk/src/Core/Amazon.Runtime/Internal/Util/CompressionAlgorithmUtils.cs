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

using Amazon.Util;
using System;

namespace Amazon.Runtime.Internal.Util
{
    /// <summary>
    /// Utilities for working with compressing request payloads using supported algortihms
    /// </summary>
    public static class CompressionAlgorithmUtils
    {

        /// <summary>
        /// Sets the <see cref="CompressionEncodingAlgorithm"/> enum member of <see cref="IRequest"/>
        /// based off its enum value.
        /// </summary>
        /// <param name="request"> The request containing the payload that we want to compress </param>
        /// <param name="compressionAlgorithm"> The enum value of <see cref="CompressionEncodingAlgorithm"/> </param>
        public static void SetCompressionAlgorithm(IRequest request, CompressionEncodingAlgorithm compressionAlgorithm)
        {
            request.CompressionAlgorithm = compressionAlgorithm;
        }

        /// <summary>
        /// Sets or appends <see cref="CompressionEncodingAlgorithm"/> to the request header <see cref="HeaderKeys.ContentEncodingHeader"/>
        /// </summary>
        /// <param name="request"> The request containing the payload that we want to compress </param>
        /// <param name="compressionEncodingAlgorithm"> Enum containing the value of the compression algortihm </param>
        public static void SetRequestHeader(IRequest request, CompressionEncodingAlgorithm compressionEncodingAlgorithm)
        {
            var compressionAlgorithmId = compressionEncodingAlgorithm.ToString();

            if (compressionEncodingAlgorithm == CompressionEncodingAlgorithm.NONE)
            {
                throw new ArgumentException($"{nameof(CompressionEncodingAlgorithm)} enum cannot have value NONE");
            }
            else if (request.Headers.ContainsKey(HeaderKeys.ContentEncodingHeader))
            {
                request.Headers[HeaderKeys.ContentEncodingHeader] = request.Headers[HeaderKeys.ContentEncodingHeader] + "," + compressionAlgorithmId;
            }
            else
            {
                request.Headers[HeaderKeys.ContentEncodingHeader] = compressionAlgorithmId;
            }
        }
    }
}
