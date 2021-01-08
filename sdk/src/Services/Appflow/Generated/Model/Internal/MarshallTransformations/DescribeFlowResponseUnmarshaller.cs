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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Appflow.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Appflow.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DescribeFlow operation
    /// </summary>  
    public class DescribeFlowResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            DescribeFlowResponse response = new DescribeFlowResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
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
                if (context.TestExpression("destinationFlowConfigList", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<DestinationFlowConfig, DestinationFlowConfigUnmarshaller>(DestinationFlowConfigUnmarshaller.Instance);
                    response.DestinationFlowConfigList = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("flowArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.FlowArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("flowName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.FlowName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("flowStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.FlowStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("flowStatusMessage", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.FlowStatusMessage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("kmsArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.KmsArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lastRunExecutionDetails", targetDepth))
                {
                    var unmarshaller = ExecutionDetailsUnmarshaller.Instance;
                    response.LastRunExecutionDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lastUpdatedAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.LastUpdatedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lastUpdatedBy", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.LastUpdatedBy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sourceFlowConfig", targetDepth))
                {
                    var unmarshaller = SourceFlowConfigUnmarshaller.Instance;
                    response.SourceFlowConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("tags", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    response.Tags = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("tasks", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Task, TaskUnmarshaller>(TaskUnmarshaller.Instance);
                    response.Tasks = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("triggerConfig", targetDepth))
                {
                    var unmarshaller = TriggerConfigUnmarshaller.Instance;
                    response.TriggerConfig = unmarshaller.Unmarshall(context);
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
                if (errorResponse.Code != null && errorResponse.Code.Equals("InternalServerException"))
                {
                    return InternalServerExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFoundException"))
                {
                    return ResourceNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonAppflowException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static DescribeFlowResponseUnmarshaller _instance = new DescribeFlowResponseUnmarshaller();        

        internal static DescribeFlowResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeFlowResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}