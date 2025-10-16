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

namespace Amazon.Runtime.Internal.Util
{
    /// <summary>
    /// Class to keep track of the first request cached checksum and callback for caching the checksum.
    /// </summary>
    public class CachedChecksum
    {
        /// <summary>
        /// Callback delegate to define the method called when the checksum is finalized for the request 
        /// passing the final calculated checksum to the callback for caching.
        /// </summary>
        /// <param name="completeBase64Checksum">The base64 checksum to cache.</param>
        public delegate void Callback(string completeBase64Checksum);

        /// <summary>
        /// The value of the finalized checksum for the request. This will be the cached checksum value
        /// on subsequent requests and filled in on the first request.
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// OnComplete called when the checksum is finalized for the request passing the final calculated
        /// checksum to the callback for caching.
        /// </summary>
        public Callback OnComplete { get; set; }        
    }
}
