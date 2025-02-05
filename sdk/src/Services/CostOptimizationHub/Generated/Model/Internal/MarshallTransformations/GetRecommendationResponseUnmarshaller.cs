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
 * Do not modify this file. This file is generated from the cost-optimization-hub-2022-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CostOptimizationHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using Amazon.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.CostOptimizationHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetRecommendation operation
    /// </summary>  
    public class GetRecommendationResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            GetRecommendationResponse response = new GetRecommendationResponse();
            StreamingUtf8JsonReader reader = new StreamingUtf8JsonReader(context.Stream);
            context.Read(ref reader);
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("accountId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.AccountId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("actionType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ActionType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("costCalculationLookbackPeriodInDays", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    response.CostCalculationLookbackPeriodInDays = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("currencyCode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.CurrencyCode = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("currentResourceDetails", targetDepth))
                {
                    var unmarshaller = ResourceDetailsUnmarshaller.Instance;
                    response.CurrentResourceDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("currentResourceType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.CurrentResourceType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("estimatedMonthlyCost", targetDepth))
                {
                    var unmarshaller = NullableDoubleUnmarshaller.Instance;
                    response.EstimatedMonthlyCost = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("estimatedMonthlySavings", targetDepth))
                {
                    var unmarshaller = NullableDoubleUnmarshaller.Instance;
                    response.EstimatedMonthlySavings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("estimatedSavingsOverCostCalculationLookbackPeriod", targetDepth))
                {
                    var unmarshaller = NullableDoubleUnmarshaller.Instance;
                    response.EstimatedSavingsOverCostCalculationLookbackPeriod = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("estimatedSavingsPercentage", targetDepth))
                {
                    var unmarshaller = NullableDoubleUnmarshaller.Instance;
                    response.EstimatedSavingsPercentage = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("implementationEffort", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ImplementationEffort = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("lastRefreshTimestamp", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    response.LastRefreshTimestamp = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("recommendationId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.RecommendationId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("recommendationLookbackPeriodInDays", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    response.RecommendationLookbackPeriodInDays = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("recommendedResourceDetails", targetDepth))
                {
                    var unmarshaller = ResourceDetailsUnmarshaller.Instance;
                    response.RecommendedResourceDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("recommendedResourceType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.RecommendedResourceType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("region", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Region = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("resourceArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ResourceArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("resourceId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ResourceId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("restartNeeded", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    response.RestartNeeded = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("rollbackPossible", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    response.RollbackPossible = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("source", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Source = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("tags", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<Tag, TagUnmarshaller>(TagUnmarshaller.Instance);
                    response.Tags = unmarshaller.Unmarshall(context, ref reader);
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
                if (errorResponse.Code != null && errorResponse.Code.Equals("AccessDeniedException"))
                {
                    return AccessDeniedExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InternalServerException"))
                {
                    return InternalServerExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFoundException"))
                {
                    return ResourceNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ThrottlingException"))
                {
                    return ThrottlingExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ValidationException"))
                {
                    return ValidationExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
            }
            return new AmazonCostOptimizationHubException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static GetRecommendationResponseUnmarshaller _instance = new GetRecommendationResponseUnmarshaller();        

        internal static GetRecommendationResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetRecommendationResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}