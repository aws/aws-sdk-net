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

using System.IO;

namespace Amazon.Runtime.Internal.Compression
{
    /// <summary>
    /// Interface for an implementation of compression algorithms
    /// </summary>
    public interface ICompressionAlgorithm
    {
        /// <summary>
        /// The ID of the compression algorithm. This is matched against the algorithm
        /// names used in the trait e.g. "gzip"
        /// </summary>
        CompressionEncodingAlgorithm AlgorithmId { get; }

        /// <summary>
        /// Compresses request payload content of fixed length
        /// </summary>
        /// <param name="content"> Request payload content represented in byte array </param>
        /// <returns> Compressed data in a byte array format </returns>
        byte[] Compress(byte[] content);

        /// <summary>
        /// Wraps <paramref name="inputStream"/> with an instance object of the compression stream algorithm
        /// </summary>
        /// <param name="inputStream"> The stream that will contain compressed data </param>
        /// <returns> Instance of compression stream algorithm </returns>
        Stream GetCompressionStream(Stream inputStream);
    }
}
