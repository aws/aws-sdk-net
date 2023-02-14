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
    /// Response Unmarshaller for DescribeHyperParameterTuningJob operation
    /// </summary>  
    public class DescribeHyperParameterTuningJobResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            DescribeHyperParameterTuningJobResponse response = new DescribeHyperParameterTuningJobResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("BestTrainingJob", targetDepth))
                {
                    var unmarshaller = HyperParameterTrainingJobSummaryUnmarshaller.Instance;
                    response.BestTrainingJob = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ConsumedResources", targetDepth))
                {
                    var unmarshaller = HyperParameterTuningJobConsumedResourcesUnmarshaller.Instance;
                    response.ConsumedResources = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreationTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.CreationTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FailureReason", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.FailureReason = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HyperParameterTuningEndTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.HyperParameterTuningEndTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HyperParameterTuningJobArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.HyperParameterTuningJobArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HyperParameterTuningJobConfig", targetDepth))
                {
                    var unmarshaller = HyperParameterTuningJobConfigUnmarshaller.Instance;
                    response.HyperParameterTuningJobConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HyperParameterTuningJobName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.HyperParameterTuningJobName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HyperParameterTuningJobStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.HyperParameterTuningJobStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastModifiedTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.LastModifiedTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ObjectiveStatusCounters", targetDepth))
                {
                    var unmarshaller = ObjectiveStatusCountersUnmarshaller.Instance;
                    response.ObjectiveStatusCounters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OverallBestTrainingJob", targetDepth))
                {
                    var unmarshaller = HyperParameterTrainingJobSummaryUnmarshaller.Instance;
                    response.OverallBestTrainingJob = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TrainingJobDefinition", targetDepth))
                {
                    var unmarshaller = HyperParameterTrainingJobDefinitionUnmarshaller.Instance;
                    response.TrainingJobDefinition = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TrainingJobDefinitions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<HyperParameterTrainingJobDefinition, HyperParameterTrainingJobDefinitionUnmarshaller>(HyperParameterTrainingJobDefinitionUnmarshaller.Instance);
                    response.TrainingJobDefinitions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TrainingJobStatusCounters", targetDepth))
                {
                    var unmarshaller = TrainingJobStatusCountersUnmarshaller.Instance;
                    response.TrainingJobStatusCounters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TuningJobCompletionDetails", targetDepth))
                {
                    var unmarshaller = HyperParameterTuningJobCompletionDetailsUnmarshaller.Instance;
                    response.TuningJobCompletionDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("WarmStartConfig", targetDepth))
                {
                    var unmarshaller = HyperParameterTuningJobWarmStartConfigUnmarshaller.Instance;
                    response.WarmStartConfig = unmarshaller.Unmarshall(context);
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

        private static DescribeHyperParameterTuningJobResponseUnmarshaller _instance = new DescribeHyperParameterTuningJobResponseUnmarshaller();        

        internal static DescribeHyperParameterTuningJobResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeHyperParameterTuningJobResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}