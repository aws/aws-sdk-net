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

using Amazon.Runtime.Internal;

namespace Amazon.Extensions.CborProtocol.Internal.Transform
{
    /// <summary>
    /// The interface for unmarshalling a cbor error response.
    /// </summary>
    /// <typeparam name="T">The type to unmarshall.</typeparam>
    /// <typeparam name="TCborUnmarshallerContext">The cbor unmarshaller context</typeparam>
    public interface ICborErrorResponseUnmarshaller<T, TCborUnmarshallerContext>
    {
        /// <summary>
        /// The unmarshall method accepts a context, the error response and returns the modeled exception.
        /// </summary>
        /// <param name="context">The CBOR Unmarshaller context</param>
        /// <param name="errorResponse">The error response</param>
        /// <returns>T, the error shape that is unmarshalled from the CBOR context</returns>
        T Unmarshall(TCborUnmarshallerContext context, ErrorResponse errorResponse);
    }
}
