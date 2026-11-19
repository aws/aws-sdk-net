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

using Amazon.CloudFront.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Util;
#pragma warning disable CS0612,CS0618

namespace Amazon.CloudFront.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Exception Unmarshaller for CannotDeleteEntityWhileInUseException
    /// </summary>
    public partial class CannotDeleteEntityWhileInUseExceptionUnmarshaller : IXmlErrorResponseUnmarshaller<CannotDeleteEntityWhileInUseException, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>
        public CannotDeleteEntityWhileInUseException Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>
        public CannotDeleteEntityWhileInUseException Unmarshall(XmlUnmarshallerContext context, Amazon.Runtime.Internal.ErrorResponse errorResponse)
        {
            CannotDeleteEntityWhileInUseException unmarshalledObject = new CannotDeleteEntityWhileInUseException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                }
            }
            return unmarshalledObject;
        }

        private static CannotDeleteEntityWhileInUseExceptionUnmarshaller _instance = new CannotDeleteEntityWhileInUseExceptionUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CannotDeleteEntityWhileInUseExceptionUnmarshaller Instance => _instance;
    }
}
