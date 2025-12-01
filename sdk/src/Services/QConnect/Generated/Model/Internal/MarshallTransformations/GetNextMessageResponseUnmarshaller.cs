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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.QConnect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.QConnect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetNextMessage operation
    /// </summary>  
    public class GetNextMessageResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            GetNextMessageResponse response = new GetNextMessageResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("chunkedResponseTerminated", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    response.ChunkedResponseTerminated = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("conversationSessionData", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<RuntimeSessionData, RuntimeSessionDataUnmarshaller>(RuntimeSessionDataUnmarshaller.Instance);
                    response.ConversationSessionData = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("conversationState", targetDepth))
                {
                    var unmarshaller = ConversationStateUnmarshaller.Instance;
                    response.ConversationState = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("nextMessageToken", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.NextMessageToken = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("requestMessageId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.RequestMessageId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("response", targetDepth))
                {
                    var unmarshaller = MessageOutputUnmarshaller.Instance;
                    response.Response = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("type", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Type = unmarshaller.Unmarshall(context);
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
                if (errorResponse.Code != null && errorResponse.Code.Equals("AccessDeniedException"))
                {
                    return AccessDeniedExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFoundException"))
                {
                    return ResourceNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("UnprocessableContentException"))
                {
                    return UnprocessableContentExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ValidationException"))
                {
                    return ValidationExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonQConnectException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static GetNextMessageResponseUnmarshaller _instance = new GetNextMessageResponseUnmarshaller();        

        internal static GetNextMessageResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetNextMessageResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}