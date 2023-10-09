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

namespace Amazon.Runtime.Internal.Compression
{
    /// <summary>
    /// Compression Factory class
    /// </summary>
    public static class CompressionFactory
    {
        /// <summary>
        /// Gets compression algorithm object based on <paramref name="type"/>
        /// </summary>
        /// <param name="type"> Selected type of compression </param>
        /// <returns> An instance object of the selected compression type </returns>
        /// <exception cref="ArgumentException"> We should throw this error when the value of <paramref name="type"/>
        /// is NONE which means that the selected compression algorithm is not supported by the SDK </exception>
        public static ICompressionAlgorithm GetCompressionAlgorithm(CompressionEncodingAlgorithm type)
        {
            switch (type)
            {
                case CompressionEncodingAlgorithm.gzip:
                    return new GZipCompression();
                // Add cases for other compression types here if needed
                default:
                    throw new ArgumentException($"Invalid compression type: {type}");
            }
        }
    }
}
