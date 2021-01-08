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
using ThirdParty.Json.LitJson;

namespace Amazon.ApiGatewayV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for UpdateAuthorizer operation
    /// </summary>  
    public class UpdateAuthorizerResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            UpdateAuthorizerResponse response = new UpdateAuthorizerResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("authorizerCredentialsArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.AuthorizerCredentialsArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("authorizerId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.AuthorizerId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("authorizerPayloadFormatVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.AuthorizerPayloadFormatVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("authorizerResultTtlInSeconds", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    response.AuthorizerResultTtlInSeconds = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("authorizerType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.AuthorizerType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("authorizerUri", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.AuthorizerUri = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("enableSimpleResponses", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    response.EnableSimpleResponses = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("identitySource", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    response.IdentitySource = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("identityValidationExpression", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.IdentityValidationExpression = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("jwtConfiguration", targetDepth))
                {
                    var unmarshaller = JWTConfigurationUnmarshaller.Instance;
                    response.JwtConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Name = unmarshaller.Unmarshall(context);
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
                if (errorResponse.Code != null && errorResponse.Code.Equals("BadRequestException"))
                {
                    return BadRequestExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ConflictException"))
                {
                    return ConflictExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("NotFoundException"))
                {
                    return NotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("TooManyRequestsException"))
                {
                    return TooManyRequestsExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonApiGatewayV2Exception(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static UpdateAuthorizerResponseUnmarshaller _instance = new UpdateAuthorizerResponseUnmarshaller();        

        internal static UpdateAuthorizerResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateAuthorizerResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}