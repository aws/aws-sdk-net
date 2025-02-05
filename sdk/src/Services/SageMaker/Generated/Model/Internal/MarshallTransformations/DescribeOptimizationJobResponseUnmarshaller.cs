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
using System.Text.Json;
using Amazon.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DescribeOptimizationJob operation
    /// </summary>  
    public class DescribeOptimizationJobResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            DescribeOptimizationJobResponse response = new DescribeOptimizationJobResponse();
            StreamingUtf8JsonReader reader = new StreamingUtf8JsonReader(context.Stream);
            context.Read(ref reader);
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("CreationTime", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    response.CreationTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DeploymentInstanceType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.DeploymentInstanceType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("FailureReason", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.FailureReason = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("LastModifiedTime", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    response.LastModifiedTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ModelSource", targetDepth))
                {
                    var unmarshaller = OptimizationJobModelSourceUnmarshaller.Instance;
                    response.ModelSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("OptimizationConfigs", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<OptimizationConfig, OptimizationConfigUnmarshaller>(OptimizationConfigUnmarshaller.Instance);
                    response.OptimizationConfigs = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("OptimizationEndTime", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    response.OptimizationEndTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("OptimizationEnvironment", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    response.OptimizationEnvironment = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("OptimizationJobArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.OptimizationJobArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("OptimizationJobName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.OptimizationJobName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("OptimizationJobStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.OptimizationJobStatus = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("OptimizationOutput", targetDepth))
                {
                    var unmarshaller = OptimizationOutputUnmarshaller.Instance;
                    response.OptimizationOutput = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("OptimizationStartTime", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    response.OptimizationStartTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("OutputConfig", targetDepth))
                {
                    var unmarshaller = OptimizationJobOutputConfigUnmarshaller.Instance;
                    response.OutputConfig = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RoleArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.RoleArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("StoppingCondition", targetDepth))
                {
                    var unmarshaller = StoppingConditionUnmarshaller.Instance;
                    response.StoppingCondition = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("VpcConfig", targetDepth))
                {
                    var unmarshaller = OptimizationVpcConfigUnmarshaller.Instance;
                    response.VpcConfig = unmarshaller.Unmarshall(context, ref reader);
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
            StreamingUtf8JsonReader reader = new StreamingUtf8JsonReader(context.Stream);
            var errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context, ref reader);
            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            using (var contextCopy = new JsonUnmarshallerContext(streamCopy, false, context.ResponseData))
            {
                StreamingUtf8JsonReader readerCopy = new StreamingUtf8JsonReader(streamCopy);
                if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFound"))
                {
                    return ResourceNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
            }
            return new AmazonSageMakerException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static DescribeOptimizationJobResponseUnmarshaller _instance = new DescribeOptimizationJobResponseUnmarshaller();        

        internal static DescribeOptimizationJobResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeOptimizationJobResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}