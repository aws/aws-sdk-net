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

using Amazon.RestXmlProtocol.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Util;
#pragma warning disable CS0612,CS0618

namespace Amazon.RestXmlProtocol.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Exception Unmarshaller for ComplexErrorException
    /// </summary>
    public partial class ComplexErrorExceptionUnmarshaller : IXmlErrorResponseUnmarshaller<ComplexErrorException, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>
        public ComplexErrorException Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>
        public ComplexErrorException Unmarshall(XmlUnmarshallerContext context, Amazon.Runtime.Internal.ErrorResponse errorResponse)
        {
            ComplexErrorException unmarshalledObject = new ComplexErrorException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("Nested"))
                    {
                        var unmarshaller = ComplexNestedErrorDataUnmarshaller.Instance;
                        unmarshalledObject.Nested = unmarshaller.Unmarshall(context);
                    }

                    if (context.TestExpression("TopLevel"))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.TopLevel = unmarshaller.Unmarshall(context);
                    }
                }
            }
            if (context.ResponseData.IsHeaderPresent("X-Header"))
            {
                unmarshalledObject.Header = context.ResponseData.GetHeaderValue("X-Header");
            }
            return unmarshalledObject;
        }

        private static ComplexErrorExceptionUnmarshaller _instance = new ComplexErrorExceptionUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ComplexErrorExceptionUnmarshaller Instance => _instance;
    }
}
