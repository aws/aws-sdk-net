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

namespace AWSSDK.Extensions.CborProtocol.Internal.Transform
{
    /// <summary>
    /// Class for unmarshalling CBOR service responses.
    /// </summary>
    public class CborErrorResponseUnmarshaller : ICborUnmarshaller<ErrorResponse, CborUnmarshallerContext>
    {
        /// <summary>
        /// Build an ErrorResponse from Cbor 
        /// </summary>
        /// <param name="context">The Cbor parsing context. 
        /// Usually an <c>Amazon.Runtime.Internal.CborUnmarshallerContext</c>.</param>
        /// <returns>An <c>ErrorResponse</c> object.</returns>
        public ErrorResponse Unmarshall(CborUnmarshallerContext context)
        {
            // Placeholder until CBOR exception implementation.
            return null;
        }

        private static CborErrorResponseUnmarshaller instance;

        /// <summary>
        /// Return an instance of CborErrorResponseUnmarshaller.
        /// </summary>
        /// <returns></returns>
        public static CborErrorResponseUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new CborErrorResponseUnmarshaller();

            return instance;
        }
    }
}
