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
 * Do not modify this file. This file is generated from the eventbridge-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.EventBridge.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.EventBridge.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DescribeConnection operation
    /// </summary>  
    public class DescribeConnectionResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            DescribeConnectionResponse response = new DescribeConnectionResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AuthorizationType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.AuthorizationType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AuthParameters", targetDepth))
                {
                    var unmarshaller = ConnectionAuthResponseParametersUnmarshaller.Instance;
                    response.AuthParameters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ConnectionArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ConnectionArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ConnectionState", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ConnectionState = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreationTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.CreationTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Description = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InvocationConnectivityParameters", targetDepth))
                {
                    var unmarshaller = DescribeConnectionConnectivityParametersUnmarshaller.Instance;
                    response.InvocationConnectivityParameters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("KmsKeyIdentifier", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.KmsKeyIdentifier = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastAuthorizedTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.LastAuthorizedTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastModifiedTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.LastModifiedTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SecretArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.SecretArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StateReason", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.StateReason = unmarshaller.Unmarshall(context);
                    continue;
                }
            }

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
                if (errorResponse.Code != null && errorResponse.Code.Equals("InternalException"))
                {
                    return InternalExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFoundException"))
                {
                    return ResourceNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonEventBridgeException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static DescribeConnectionResponseUnmarshaller _instance = new DescribeConnectionResponseUnmarshaller();        

        internal static DescribeConnectionResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeConnectionResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}