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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMaker.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DescribeProcessingJob operation
    /// </summary>  
    public class DescribeProcessingJobResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            DescribeProcessingJobResponse response = new DescribeProcessingJobResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AppSpecification", targetDepth))
                {
                    var unmarshaller = AppSpecificationUnmarshaller.Instance;
                    response.AppSpecification = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AutoMLJobArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.AutoMLJobArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreationTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.CreationTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Environment", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    response.Environment = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExitMessage", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ExitMessage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExperimentConfig", targetDepth))
                {
                    var unmarshaller = ExperimentConfigUnmarshaller.Instance;
                    response.ExperimentConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FailureReason", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.FailureReason = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastModifiedTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.LastModifiedTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MonitoringScheduleArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.MonitoringScheduleArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NetworkConfig", targetDepth))
                {
                    var unmarshaller = NetworkConfigUnmarshaller.Instance;
                    response.NetworkConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProcessingEndTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.ProcessingEndTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProcessingInputs", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ProcessingInput, ProcessingInputUnmarshaller>(ProcessingInputUnmarshaller.Instance);
                    response.ProcessingInputs = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProcessingJobArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ProcessingJobArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProcessingJobName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ProcessingJobName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProcessingJobStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ProcessingJobStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProcessingOutputConfig", targetDepth))
                {
                    var unmarshaller = ProcessingOutputConfigUnmarshaller.Instance;
                    response.ProcessingOutputConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProcessingResources", targetDepth))
                {
                    var unmarshaller = ProcessingResourcesUnmarshaller.Instance;
                    response.ProcessingResources = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProcessingStartTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.ProcessingStartTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RoleArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.RoleArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StoppingCondition", targetDepth))
                {
                    var unmarshaller = ProcessingStoppingConditionUnmarshaller.Instance;
                    response.StoppingCondition = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TrainingJobArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.TrainingJobArn = unmarshaller.Unmarshall(context);
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
                if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFound"))
                {
                    return ResourceNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonSageMakerException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static DescribeProcessingJobResponseUnmarshaller _instance = new DescribeProcessingJobResponseUnmarshaller();        

        internal static DescribeProcessingJobResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeProcessingJobResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}