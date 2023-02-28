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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Lambda.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Lambda.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetEventSourceMapping operation
    /// </summary>  
    public class GetEventSourceMappingResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            GetEventSourceMappingResponse response = new GetEventSourceMappingResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AmazonManagedKafkaEventSourceConfig", targetDepth))
                {
                    var unmarshaller = AmazonManagedKafkaEventSourceConfigUnmarshaller.Instance;
                    response.AmazonManagedKafkaEventSourceConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("BatchSize", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    response.BatchSize = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("BisectBatchOnFunctionError", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    response.BisectBatchOnFunctionError = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DestinationConfig", targetDepth))
                {
                    var unmarshaller = DestinationConfigUnmarshaller.Instance;
                    response.DestinationConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DocumentDBEventSourceConfig", targetDepth))
                {
                    var unmarshaller = DocumentDBEventSourceConfigUnmarshaller.Instance;
                    response.DocumentDBEventSourceConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EventSourceArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.EventSourceArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FilterCriteria", targetDepth))
                {
                    var unmarshaller = FilterCriteriaUnmarshaller.Instance;
                    response.FilterCriteria = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FunctionArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.FunctionArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FunctionResponseTypes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    response.FunctionResponseTypes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastModified", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.LastModified = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastProcessingResult", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.LastProcessingResult = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MaximumBatchingWindowInSeconds", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    response.MaximumBatchingWindowInSeconds = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MaximumRecordAgeInSeconds", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    response.MaximumRecordAgeInSeconds = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MaximumRetryAttempts", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    response.MaximumRetryAttempts = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ParallelizationFactor", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    response.ParallelizationFactor = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Queues", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    response.Queues = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ScalingConfig", targetDepth))
                {
                    var unmarshaller = ScalingConfigUnmarshaller.Instance;
                    response.ScalingConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SelfManagedEventSource", targetDepth))
                {
                    var unmarshaller = SelfManagedEventSourceUnmarshaller.Instance;
                    response.SelfManagedEventSource = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SelfManagedKafkaEventSourceConfig", targetDepth))
                {
                    var unmarshaller = SelfManagedKafkaEventSourceConfigUnmarshaller.Instance;
                    response.SelfManagedKafkaEventSourceConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SourceAccessConfigurations", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<SourceAccessConfiguration, SourceAccessConfigurationUnmarshaller>(SourceAccessConfigurationUnmarshaller.Instance);
                    response.SourceAccessConfigurations = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StartingPosition", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.StartingPosition = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StartingPositionTimestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.StartingPositionTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("State", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.State = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StateTransitionReason", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.StateTransitionReason = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Topics", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    response.Topics = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TumblingWindowInSeconds", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    response.TumblingWindowInSeconds = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UUID", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.UUID = unmarshaller.Unmarshall(context);
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
                if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidParameterValueException"))
                {
                    return InvalidParameterValueExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFoundException"))
                {
                    return ResourceNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ServiceException"))
                {
                    return ServiceExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("TooManyRequestsException"))
                {
                    return TooManyRequestsExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonLambdaException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static GetEventSourceMappingResponseUnmarshaller _instance = new GetEventSourceMappingResponseUnmarshaller();        

        internal static GetEventSourceMappingResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetEventSourceMappingResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}