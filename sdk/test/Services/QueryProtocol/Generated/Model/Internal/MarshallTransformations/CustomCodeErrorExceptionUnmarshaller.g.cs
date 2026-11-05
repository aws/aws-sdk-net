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

/*
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.QueryProtocol.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Util;
#pragma warning disable CS0612,CS0618

namespace Amazon.QueryProtocol.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Exception Unmarshaller for CustomCodeErrorException
    /// </summary>
    public partial class CustomCodeErrorExceptionUnmarshaller : IXmlErrorResponseUnmarshaller<CustomCodeErrorException, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>
        public CustomCodeErrorException Unmarshall(XmlUnmarshallerContext context)
        {
            return this.Unmarshall(context, new Amazon.Runtime.Internal.ErrorResponse());
        }

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>
        public CustomCodeErrorException Unmarshall(XmlUnmarshallerContext context, Amazon.Runtime.Internal.ErrorResponse errorResponse)
        {
            CustomCodeErrorException unmarshalledObject = new CustomCodeErrorException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument)
            {
                targetDepth += 2;
            }

            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                }
            }
            return unmarshalledObject;
        }

        private static CustomCodeErrorExceptionUnmarshaller _instance = new CustomCodeErrorExceptionUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CustomCodeErrorExceptionUnmarshaller Instance => _instance;
    }
}
