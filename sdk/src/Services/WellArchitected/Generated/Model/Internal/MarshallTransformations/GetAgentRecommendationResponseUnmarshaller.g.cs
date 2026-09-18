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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.WellArchitected.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Globalization;
using Amazon.Util;
#pragma warning disable CS0612,CS0618

namespace Amazon.WellArchitected.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetAgentRecommendation operation.
    /// </summary>
    public partial class GetAgentRecommendationResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            var unmarshalledObject = new GetAgentRecommendationResponse();
            var reader = new StreamingUtf8JsonReader(context.Stream, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);

            context.Read(ref reader);
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("applications", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Applications = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("awsServices", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.AwsServices = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("businessUnits", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.BusinessUnits = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("createdAt", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreatedAt = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("createdBy", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CreatedBy = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("crossPillarBenefits", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<CrossPillarBenefit, CrossPillarBenefitUnmarshaller>(CrossPillarBenefitUnmarshaller.Instance);
                    unmarshalledObject.CrossPillarBenefits = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("description", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Description = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("effort", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Effort = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("goals", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<RecommendationGoal, RecommendationGoalUnmarshaller>(RecommendationGoalUnmarshaller.Instance);
                    unmarshalledObject.Goals = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("highlights", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Highlights = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("impact", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Impact = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("impactDetails", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.ImpactDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("insights", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<Insight, InsightUnmarshaller>(InsightUnmarshaller.Instance);
                    unmarshalledObject.Insights = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("lastModifiedAt", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastModifiedAt = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("lastModifiedBy", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LastModifiedBy = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("numberOfResources", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.NumberOfResources = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("pillar", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Pillar = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("priority", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Priority = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("profileArn", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ProfileArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("recommendationArn", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RecommendationArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("remediationSummary", targetDepth, ref reader))
                {
                    var unmarshaller = RemediationSummaryUnmarshaller.Instance;
                    unmarshalledObject.RemediationSummary = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("remediations", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<AgentRecommendationRemediation, AgentRecommendationRemediationUnmarshaller>(AgentRecommendationRemediationUnmarshaller.Instance);
                    unmarshalledObject.Remediations = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("roi", targetDepth, ref reader))
                {
                    var unmarshaller = RoiUnmarshaller.Instance;
                    unmarshalledObject.Roi = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("sources", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Sources = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("state", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.State = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("status", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("tags", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<Tag, TagUnmarshaller>(TagUnmarshaller.Instance);
                    unmarshalledObject.Tags = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("title", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Title = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("tradeOffs", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<TradeOff, TradeOffUnmarshaller>(TradeOffUnmarshaller.Instance);
                    unmarshalledObject.TradeOffs = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("type", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Type = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("updateReason", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UpdateReason = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }

            return unmarshalledObject;
        }

        /// <summary>
        /// Unmarshall error response to exception.
        /// </summary>
        public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            var reader = new StreamingUtf8JsonReader(context.Stream, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);
            var errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context, ref reader);

            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            {
                using (var contextCopy = new JsonUnmarshallerContext(streamCopy, false, context.ResponseData))
                {
                    var readerCopy = new StreamingUtf8JsonReader(streamCopy, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);
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
            }
            return new AmazonWellArchitectedException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static GetAgentRecommendationResponseUnmarshaller _instance = new GetAgentRecommendationResponseUnmarshaller();

        internal static GetAgentRecommendationResponseUnmarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetAgentRecommendationResponseUnmarshaller Instance => _instance;
    }
}
