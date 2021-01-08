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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SimpleSystemsManagement.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SimpleSystemsManagement.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetMaintenanceWindowExecutionTask operation
    /// </summary>  
    public class GetMaintenanceWindowExecutionTaskResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            GetMaintenanceWindowExecutionTaskResponse response = new GetMaintenanceWindowExecutionTaskResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("EndTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.EndTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MaxConcurrency", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.MaxConcurrency = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MaxErrors", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.MaxErrors = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Priority", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    response.Priority = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ServiceRole", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ServiceRole = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StartTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.StartTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StatusDetails", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.StatusDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TaskArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.TaskArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TaskExecutionId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.TaskExecutionId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TaskParameters", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Dictionary<string, MaintenanceWindowTaskParameterValueExpression>, DictionaryUnmarshaller<string, MaintenanceWindowTaskParameterValueExpression, StringUnmarshaller, MaintenanceWindowTaskParameterValueExpressionUnmarshaller>>(new DictionaryUnmarshaller<string, MaintenanceWindowTaskParameterValueExpression, StringUnmarshaller, MaintenanceWindowTaskParameterValueExpressionUnmarshaller>(StringUnmarshaller.Instance, MaintenanceWindowTaskParameterValueExpressionUnmarshaller.Instance));
                    response.TaskParameters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Type", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Type = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("WindowExecutionId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.WindowExecutionId = unmarshaller.Unmarshall(context);
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
                if (errorResponse.Code != null && errorResponse.Code.Equals("DoesNotExistException"))
                {
                    return DoesNotExistExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InternalServerError"))
                {
                    return InternalServerErrorExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonSimpleSystemsManagementException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static GetMaintenanceWindowExecutionTaskResponseUnmarshaller _instance = new GetMaintenanceWindowExecutionTaskResponseUnmarshaller();        

        internal static GetMaintenanceWindowExecutionTaskResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetMaintenanceWindowExecutionTaskResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}