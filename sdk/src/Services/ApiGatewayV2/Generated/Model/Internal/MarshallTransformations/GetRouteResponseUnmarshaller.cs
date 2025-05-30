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
 * Do not modify this file. This file is generated from the apigatewayv2-2018-11-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ApiGatewayV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using Amazon.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ApiGatewayV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetRoute operation
    /// </summary>  
    public class GetRouteResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            GetRouteResponse response = new GetRouteResponse();
            StreamingUtf8JsonReader reader = new StreamingUtf8JsonReader(context.Stream);
            context.Read(ref reader);
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("apiGatewayManaged", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    response.ApiGatewayManaged = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("apiKeyRequired", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    response.ApiKeyRequired = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("authorizationScopes", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    response.AuthorizationScopes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("authorizationType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.AuthorizationType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("authorizerId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.AuthorizerId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("modelSelectionExpression", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ModelSelectionExpression = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("operationName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.OperationName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("requestModels", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    response.RequestModels = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("requestParameters", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, ParameterConstraints, StringUnmarshaller, ParameterConstraintsUnmarshaller>(StringUnmarshaller.Instance, ParameterConstraintsUnmarshaller.Instance);
                    response.RequestParameters = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("routeId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.RouteId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("routeKey", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.RouteKey = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("routeResponseSelectionExpression", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.RouteResponseSelectionExpression = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("target", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Target = unmarshaller.Unmarshall(context, ref reader);
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
            StreamingUtf8JsonReader reader = new StreamingUtf8JsonReader(context.Stream);
            var errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context, ref reader);
            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            using (var contextCopy = new JsonUnmarshallerContext(streamCopy, false, context.ResponseData))
            {
                StreamingUtf8JsonReader readerCopy = new StreamingUtf8JsonReader(streamCopy);
                if (errorResponse.Code != null && errorResponse.Code.Equals("NotFoundException"))
                {
                    return NotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("TooManyRequestsException"))
                {
                    return TooManyRequestsExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
            }
            return new AmazonApiGatewayV2Exception(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static GetRouteResponseUnmarshaller _instance = new GetRouteResponseUnmarshaller();        

        internal static GetRouteResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetRouteResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}