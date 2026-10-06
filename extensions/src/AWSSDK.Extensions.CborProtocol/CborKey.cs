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

namespace Amazon.Extensions.CborProtocol
{
    /// <summary>
    /// Helpers for working with CBOR map keys that are known at code-generation time.
    /// </summary>
    /// <remarks>
    /// Map keys in generated marshallers are compile-time constants (the member's wire name).
    /// Writing them with <see cref="CborWriter.WriteTextString(string)"/> on every request re-runs
    /// the UTF-16 to UTF-8 transcoding and CBOR header framing each time. <see cref="Encode"/>
    /// performs that work once so the generated marshaller can cache the fully-encoded key bytes in a
    /// <c>static readonly</c> field and emit them with <see cref="CborWriter.WriteEncodedValue"/>,
    /// which copies the pre-built bytes directly. The output is byte-for-byte identical to calling
    /// <see cref="CborWriter.WriteTextString(string)"/>.
    /// </remarks>
    public static class CborKey
    {
        /// <summary>
        /// Produces the complete CBOR encoding of <paramref name="key"/> as a definite-length text
        /// string (major type 3): the length header followed by the UTF-8 bytes. The result is
        /// intended to be stored once and written via <see cref="CborWriter.WriteEncodedValue"/>.
        /// </summary>
        /// <param name="key">The constant map key to encode. Must not be null.</param>
        /// <returns>The CBOR-encoded text string bytes for <paramref name="key"/>.</returns>
        public static byte[] Encode(string key)
        {
            if (key == null)
                throw new ArgumentNullException(nameof(key));

            // Lax matches the writer configuration used by CborWriterPool. For a single definite-length
            // text string the conformance mode does not change the output, but we keep it consistent.
            var writer = new CborWriter(CborConformanceMode.Lax);
            writer.WriteTextString(key);
            return writer.Encode();
        }
    }
}
