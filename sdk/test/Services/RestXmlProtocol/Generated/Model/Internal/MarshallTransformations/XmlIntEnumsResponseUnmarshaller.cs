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
    /// Response Unmarshaller for XmlIntEnums operation
    /// </summary>  
    public class XmlIntEnumsResponseUnmarshaller : XmlResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            XmlIntEnumsResponse response = new XmlIntEnumsResponse();
            UnmarshallResult(context,response);
            
            return response;
        }        

        private static void UnmarshallResult(XmlUnmarshallerContext context, XmlIntEnumsResponse response)
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
                    if (context.TestExpression("intEnum1", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        response.IntEnum1 = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("intEnum2", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        response.IntEnum2 = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("intEnum3", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        response.IntEnum3 = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("intEnumList/member", targetDepth))
                    {
                        if (response.IntEnumList == null)
                        {
                            response.IntEnumList = new List<int>();
                        }
                        var unmarshaller = IntUnmarshaller.Instance;
                        response.IntEnumList.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }
                    if (context.TestExpression("intEnumMap", targetDepth))
                    {
                        var unmarshaller = new DictionaryUnmarshaller<string, int, StringUnmarshaller, IntUnmarshaller>(StringUnmarshaller.Instance, IntUnmarshaller.Instance);
                        response.IntEnumMap = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("intEnumSet/member", targetDepth))
                    {
                        if (response.IntEnumSet == null)
                        {
                            response.IntEnumSet = new List<int>();
                        }
                        var unmarshaller = IntUnmarshaller.Instance;
                        response.IntEnumSet.Add(unmarshaller.Unmarshall(context));
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

        private static XmlIntEnumsResponseUnmarshaller _instance = new XmlIntEnumsResponseUnmarshaller();        

        internal static XmlIntEnumsResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static XmlIntEnumsResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
#pragma warning restore CS0612,CS0618