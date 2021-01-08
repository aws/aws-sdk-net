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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.APIGateway.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.APIGateway.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetIntegration operation
    /// </summary>  
    public class GetIntegrationResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            GetIntegrationResponse response = new GetIntegrationResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("cacheKeyParameters", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    response.CacheKeyParameters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("cacheNamespace", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.CacheNamespace = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("connectionId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ConnectionId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("connectionType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ConnectionType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("contentHandling", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ContentHandling = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("credentials", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Credentials = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("httpMethod", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.HttpMethod = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("integrationResponses", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, IntegrationResponse, StringUnmarshaller, IntegrationResponseUnmarshaller>(StringUnmarshaller.Instance, IntegrationResponseUnmarshaller.Instance);
                    response.IntegrationResponses = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("passthroughBehavior", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.PassthroughBehavior = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("requestParameters", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    response.RequestParameters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("requestTemplates", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    response.RequestTemplates = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("timeoutInMillis", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    response.TimeoutInMillis = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("tlsConfig", targetDepth))
                {
                    var unmarshaller = TlsConfigUnmarshaller.Instance;
                    response.TlsConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("type", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Type = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("uri", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Uri = unmarshaller.Unmarshall(context);
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
                if (errorResponse.Code != null && errorResponse.Code.Equals("NotFoundException"))
                {
                    return NotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("TooManyRequestsException"))
                {
                    return TooManyRequestsExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("UnauthorizedException"))
                {
                    return UnauthorizedExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonAPIGatewayException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static GetIntegrationResponseUnmarshaller _instance = new GetIntegrationResponseUnmarshaller();        

        internal static GetIntegrationResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetIntegrationResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}