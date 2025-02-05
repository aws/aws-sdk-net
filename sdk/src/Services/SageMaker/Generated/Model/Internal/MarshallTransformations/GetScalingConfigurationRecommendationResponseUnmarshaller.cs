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
    /// Response Unmarshaller for GetScalingConfigurationRecommendation operation
    /// </summary>  
    public class GetScalingConfigurationRecommendationResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            GetScalingConfigurationRecommendationResponse response = new GetScalingConfigurationRecommendationResponse();
            StreamingUtf8JsonReader reader = new StreamingUtf8JsonReader(context.Stream);
            context.Read(ref reader);
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("DynamicScalingConfiguration", targetDepth))
                {
                    var unmarshaller = DynamicScalingConfigurationUnmarshaller.Instance;
                    response.DynamicScalingConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("EndpointName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.EndpointName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("InferenceRecommendationsJobName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.InferenceRecommendationsJobName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Metric", targetDepth))
                {
                    var unmarshaller = ScalingPolicyMetricUnmarshaller.Instance;
                    response.Metric = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RecommendationId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.RecommendationId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ScalingPolicyObjective", targetDepth))
                {
                    var unmarshaller = ScalingPolicyObjectiveUnmarshaller.Instance;
                    response.ScalingPolicyObjective = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TargetCpuUtilizationPerCore", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    response.TargetCpuUtilizationPerCore = unmarshaller.Unmarshall(context, ref reader);
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

        private static GetScalingConfigurationRecommendationResponseUnmarshaller _instance = new GetScalingConfigurationRecommendationResponseUnmarshaller();        

        internal static GetScalingConfigurationRecommendationResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetScalingConfigurationRecommendationResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}