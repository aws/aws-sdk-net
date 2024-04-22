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
 * Do not modify this file. This file is generated from the rest-json-protocol-2019-12-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.RestJsonProtocol.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.RestJsonProtocol.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SimpleScalarProperties operation
    /// </summary>  
    public class SimpleScalarPropertiesResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            SimpleScalarPropertiesResponse response = new SimpleScalarPropertiesResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("byteValue", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    response.ByteValue = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DoubleDribble", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    response.DoubleValue = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("falseBooleanValue", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    response.FalseBooleanValue = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("floatValue", targetDepth))
                {
                    var unmarshaller = FloatUnmarshaller.Instance;
                    response.FloatValue = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("integerValue", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    response.IntegerValue = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("longValue", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    response.LongValue = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("shortValue", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
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
                    var unmarshaller = BoolUnmarshaller.Instance;
                    response.TrueBooleanValue = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            if (context.ResponseData.IsHeaderPresent("X-Foo"))
                response.Foo = context.ResponseData.GetHeaderValue("X-Foo");

            return response;
        }

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="innerException"></param>
        /// <param name="statusCode"></param>
        /// <returns></returns>
        public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            var errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            using (var contextCopy = new JsonUnmarshallerContext(streamCopy, false, null))
            {
            }
            return new AmazonRestJsonProtocolException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static SimpleScalarPropertiesResponseUnmarshaller _instance = new SimpleScalarPropertiesResponseUnmarshaller();        

        internal static SimpleScalarPropertiesResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SimpleScalarPropertiesResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
#pragma warning restore CS0612,CS0618