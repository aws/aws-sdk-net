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
using System.IO.Compression;

namespace Amazon.Runtime.Internal.Compression
{
    /// <summary>
    /// Gzip algorithm implementation of <see cref="ICompressionAlgorithm"/> interface.
    /// Used to compress request payloads using GZip algorithm.
    /// </summary>
    public class GZipCompression : ICompressionAlgorithm
    {

        /// <inheritdoc/>
        public CompressionEncodingAlgorithm AlgorithmId => CompressionEncodingAlgorithm.gzip;

        /// <inheritdoc/>
        public byte[] Compress(byte[] content)
        {
            using (var outputStream = new MemoryStream())
            {
                using (var gzip = new GZipStream(outputStream, CompressionMode.Compress))
                {
                    gzip.Write(content, 0, content.Length);
                    gzip.Close();
                }
                return outputStream.ToArray();
            }
        }

        /// <inheritdoc/>
        public Stream GetCompressionStream(Stream inputStream)
        {
            return new GZipStream(inputStream, CompressionMode.Compress, leaveOpen:true);
        }
    }
}
