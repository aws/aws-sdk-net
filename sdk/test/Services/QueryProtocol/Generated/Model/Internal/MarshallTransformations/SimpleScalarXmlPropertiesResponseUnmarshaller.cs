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
 * Do not modify this file. This file is generated from the query-protocol-2020-01-08.normal.json service model.
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
#pragma warning disable CS0612,CS0618
namespace Amazon.QueryProtocol.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SimpleScalarXmlProperties operation
    /// </summary>  
    public class SimpleScalarXmlPropertiesResponseUnmarshaller : XmlResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            SimpleScalarXmlPropertiesResponse response = new SimpleScalarXmlPropertiesResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.IsStartElement)
                {                    
                    if(context.TestExpression("SimpleScalarXmlPropertiesResult", 2))
                    {
                        UnmarshallResult(context, response);                        
                        continue;
                    }
                    
                    if (context.TestExpression("ResponseMetadata", 2))
                    {
                        response.ResponseMetadata = ResponseMetadataUnmarshaller.Instance.Unmarshall(context);
                    }
                }
            }

            return response;
        }

        private static void UnmarshallResult(XmlUnmarshallerContext context, SimpleScalarXmlPropertiesResponse response)
        {
            
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {

                    if (context.TestExpression("byteValue", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        response.ByteValue = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DoubleDribble", targetDepth))
                    {
                        var unmarshaller = NullableDoubleUnmarshaller.Instance;
                        response.DoubleValue = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("emptyStringValue", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.EmptyStringValue = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("falseBooleanValue", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        response.FalseBooleanValue = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("floatValue", targetDepth))
                    {
                        var unmarshaller = NullableFloatUnmarshaller.Instance;
                        response.FloatValue = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("integerValue", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        response.IntegerValue = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("longValue", targetDepth))
                    {
                        var unmarshaller = NullableLongUnmarshaller.Instance;
                        response.LongValue = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("shortValue", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        response.ShortValue = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("stringValue", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.StringValue = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("trueBooleanValue", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        response.TrueBooleanValue = unmarshaller.Unmarshall(context);
                        continue;
                    }
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
            ErrorResponse errorResponse = XmlErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            using (var contextCopy = new XmlUnmarshallerContext(streamCopy, false, null))
            {
            }
            return new AmazonQueryProtocolException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }
        private static SimpleScalarXmlPropertiesResponseUnmarshaller _instance = new SimpleScalarXmlPropertiesResponseUnmarshaller();        

        internal static SimpleScalarXmlPropertiesResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SimpleScalarXmlPropertiesResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}