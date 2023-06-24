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
 * Do not modify this file. This file is generated from the appconfig-2019-10-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.AppConfig.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.AppConfig.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for StopDeployment operation
    /// </summary>  
    public class StopDeploymentResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            StopDeploymentResponse response = new StopDeploymentResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ApplicationId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ApplicationId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AppliedExtensions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AppliedExtension, AppliedExtensionUnmarshaller>(AppliedExtensionUnmarshaller.Instance);
                    response.AppliedExtensions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CompletedAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.CompletedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ConfigurationLocationUri", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ConfigurationLocationUri = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ConfigurationName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ConfigurationName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ConfigurationProfileId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ConfigurationProfileId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ConfigurationVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ConfigurationVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DeploymentDurationInMinutes", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    response.DeploymentDurationInMinutes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DeploymentNumber", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    response.DeploymentNumber = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DeploymentStrategyId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.DeploymentStrategyId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Description = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EnvironmentId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.EnvironmentId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EventLog", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<DeploymentEvent, DeploymentEventUnmarshaller>(DeploymentEventUnmarshaller.Instance);
                    response.EventLog = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FinalBakeTimeInMinutes", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    response.FinalBakeTimeInMinutes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("GrowthFactor", targetDepth))
                {
                    var unmarshaller = FloatUnmarshaller.Instance;
                    response.GrowthFactor = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("GrowthType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.GrowthType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("KmsKeyArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.KmsKeyArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("KmsKeyIdentifier", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.KmsKeyIdentifier = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PercentageComplete", targetDepth))
                {
                    var unmarshaller = FloatUnmarshaller.Instance;
                    response.PercentageComplete = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StartedAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.StartedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("State", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.State = unmarshaller.Unmarshall(context);
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
                if (errorResponse.Code != null && errorResponse.Code.Equals("InternalServerException"))
                {
                    return InternalServerExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFoundException"))
                {
                    return ResourceNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonAppConfigException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static StopDeploymentResponseUnmarshaller _instance = new StopDeploymentResponseUnmarshaller();        

        internal static StopDeploymentResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StopDeploymentResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}