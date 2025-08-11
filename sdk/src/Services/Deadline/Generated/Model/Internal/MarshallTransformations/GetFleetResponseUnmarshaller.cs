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
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Deadline.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Deadline.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetFleet operation
    /// </summary>  
    public class GetFleetResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            GetFleetResponse response = new GetFleetResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("autoScalingStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.AutoScalingStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("capabilities", targetDepth))
                {
                    var unmarshaller = FleetCapabilitiesUnmarshaller.Instance;
                    response.Capabilities = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("configuration", targetDepth))
                {
                    var unmarshaller = FleetConfigurationUnmarshaller.Instance;
                    response.Configuration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("createdAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.CreatedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("createdBy", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.CreatedBy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Description = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("displayName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.DisplayName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("farmId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.FarmId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("fleetId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.FleetId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("hostConfiguration", targetDepth))
                {
                    var unmarshaller = HostConfigurationUnmarshaller.Instance;
                    response.HostConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("maxWorkerCount", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    response.MaxWorkerCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("minWorkerCount", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    response.MinWorkerCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("roleArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.RoleArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("statusMessage", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.StatusMessage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("targetWorkerCount", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    response.TargetWorkerCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("updatedAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.UpdatedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("updatedBy", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.UpdatedBy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("workerCount", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    response.WorkerCount = unmarshaller.Unmarshall(context);
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
                if (errorResponse.Code != null && errorResponse.Code.Equals("InternalServerErrorException"))
                {
                    return InternalServerErrorExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFoundException"))
                {
                    return ResourceNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ThrottlingException"))
                {
                    return ThrottlingExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ValidationException"))
                {
                    return ValidationExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonDeadlineException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static GetFleetResponseUnmarshaller _instance = new GetFleetResponseUnmarshaller();        

        internal static GetFleetResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetFleetResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}