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
    /// Response Unmarshaller for UpdateStage operation
    /// </summary>  
    public class UpdateStageResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            UpdateStageResponse response = new UpdateStageResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("accessLogSettings", targetDepth))
                {
                    var unmarshaller = AccessLogSettingsUnmarshaller.Instance;
                    response.AccessLogSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("clientCertificateId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ClientCertificateId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("createdDate", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.CreatedDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("defaultRouteSettings", targetDepth))
                {
                    var unmarshaller = RouteSettingsUnmarshaller.Instance;
                    response.DefaultRouteSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("deploymentId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.DeploymentId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Description = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lastUpdatedDate", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.LastUpdatedDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("routeSettings", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, RouteSettings, StringUnmarshaller, RouteSettingsUnmarshaller>(StringUnmarshaller.Instance, RouteSettingsUnmarshaller.Instance);
                    response.RouteSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("stageName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.StageName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("stageVariables", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    response.StageVariables = unmarshaller.Unmarshall(context);
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
            if (errorResponse.Code != null && errorResponse.Code.Equals("BadRequestException"))
            {
                return new BadRequestException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("ConflictException"))
            {
                return new ConflictException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
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

        private static UpdateStageResponseUnmarshaller _instance = new UpdateStageResponseUnmarshaller();        

        internal static UpdateStageResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateStageResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}