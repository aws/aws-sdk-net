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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTSiteWise.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.IoTSiteWise.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DescribeExecution operation
    /// </summary>  
    public class DescribeExecutionResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            DescribeExecutionResponse response = new DescribeExecutionResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("actionType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ActionType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("executionDetails", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    response.ExecutionDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("executionEndTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.ExecutionEndTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("executionEntityVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ExecutionEntityVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("executionId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ExecutionId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("executionResult", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    response.ExecutionResult = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("executionStartTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.ExecutionStartTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("executionStatus", targetDepth))
                {
                    var unmarshaller = ExecutionStatusUnmarshaller.Instance;
                    response.ExecutionStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("resolveTo", targetDepth))
                {
                    var unmarshaller = ResolveToUnmarshaller.Instance;
                    response.ResolveTo = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("targetResource", targetDepth))
                {
                    var unmarshaller = TargetResourceUnmarshaller.Instance;
                    response.TargetResource = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("targetResourceVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.TargetResourceVersion = unmarshaller.Unmarshall(context);
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
                if (errorResponse.Code != null && errorResponse.Code.Equals("InternalFailureException"))
                {
                    return InternalFailureExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidRequestException"))
                {
                    return InvalidRequestExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFoundException"))
                {
                    return ResourceNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ThrottlingException"))
                {
                    return ThrottlingExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonIoTSiteWiseException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static DescribeExecutionResponseUnmarshaller _instance = new DescribeExecutionResponseUnmarshaller();        

        internal static DescribeExecutionResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeExecutionResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}