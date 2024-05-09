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
    /// Response Unmarshaller for XmlEnums operation
    /// </summary>  
    public class XmlEnumsResponseUnmarshaller : XmlResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            XmlEnumsResponse response = new XmlEnumsResponse();
            UnmarshallResult(context,response);
            
            return response;
        }        

        private static void UnmarshallResult(XmlUnmarshallerContext context, XmlEnumsResponse response)
        {
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument) 
                   targetDepth += 1;
            if (context.IsEmptyResponse)
            {
                return;
            }
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("fooEnum1", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.FooEnum1 = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("fooEnum2", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.FooEnum2 = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("fooEnum3", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.FooEnum3 = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("fooEnumList/member", targetDepth))
                    {
                        if (response.FooEnumList == null)
                        {
                            response.FooEnumList = new List<string>();
                        }
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.FooEnumList.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }
                    if (context.TestExpression("fooEnumMap", targetDepth))
                    {
                        var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                        response.FooEnumMap = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("fooEnumSet/member", targetDepth))
                    {
                        if (response.FooEnumSet == null)
                        {
                            response.FooEnumSet = new List<string>();
                        }
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.FooEnumSet.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return;
                }
            }
          
            return;
        }
  

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="innerException"></param>
        /// <param name="statusCode"></param>
        /// <returns></returns>
        public override AmazonServiceException UnmarshallException(XmlUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            ErrorResponse errorResponse = ErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            using (var contextCopy = new XmlUnmarshallerContext(streamCopy, false, null))
            {
            }
            return new AmazonRestXmlProtocolException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }

        private static XmlEnumsResponseUnmarshaller _instance = new XmlEnumsResponseUnmarshaller();        

        internal static XmlEnumsResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static XmlEnumsResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}