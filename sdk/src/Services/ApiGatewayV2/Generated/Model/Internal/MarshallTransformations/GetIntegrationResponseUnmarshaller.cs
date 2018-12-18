/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
                if (context.TestExpression("contentHandlingStrategy", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ContentHandlingStrategy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("credentialsArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.CredentialsArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Description = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("integrationId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.IntegrationId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("integrationMethod", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.IntegrationMethod = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("integrationResponseSelectionExpression", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.IntegrationResponseSelectionExpression = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("integrationType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.IntegrationType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("integrationUri", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.IntegrationUri = unmarshaller.Unmarshall(context);
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
                if (context.TestExpression("templateSelectionExpression", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.TemplateSelectionExpression = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("timeoutInMillis", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    response.TimeoutInMillis = unmarshaller.Unmarshall(context);
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
            ErrorResponse errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            if (errorResponse.Code != null && errorResponse.Code.Equals("NotFoundException"))
            {
                return new NotFoundException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("TooManyRequestsException"))
            {
                return new TooManyRequestsException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            return new AmazonApiGatewayV2Exception(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
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