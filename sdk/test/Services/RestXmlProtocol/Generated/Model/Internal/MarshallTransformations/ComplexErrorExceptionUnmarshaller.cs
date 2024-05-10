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
 * Do not modify this file. This file is generated from the rest-xml-protocol-2019-12-16.normal.json service model.
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

#pragma warning disable CS0612,CS0618
namespace Amazon.RestXmlProtocol.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ComplexErrorException operation
    /// </summary>  
    public class ComplexErrorExceptionUnmarshaller : IErrorResponseUnmarshaller<ComplexErrorException, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ComplexErrorException Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="errorResponse"></param>
        /// <returns></returns>
        public ComplexErrorException Unmarshall(XmlUnmarshallerContext context, Amazon.Runtime.Internal.ErrorResponse errorResponse)
        {
            ComplexErrorException response = new ComplexErrorException(errorResponse.Message, errorResponse.InnerException, 
                errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);

            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("X-Header"))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.Header = unmarshaller.Unmarshall(context);
                    }
                    if (context.TestExpression("Nested"))
                    {
                        var unmarshaller = ComplexNestedErrorDataUnmarshaller.Instance;
                        response.Nested = unmarshaller.Unmarshall(context);
                    }
                    if (context.TestExpression("TopLevel"))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.TopLevel = unmarshaller.Unmarshall(context);
                    }
                }
            }
            return response;
        }

        private static ComplexErrorExceptionUnmarshaller _instance = new ComplexErrorExceptionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ComplexErrorExceptionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}