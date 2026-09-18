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

using Amazon.Bedrock.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Globalization;
using Amazon.Util;
#pragma warning disable CS0612,CS0618

namespace Amazon.Bedrock.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetGuardrail operation.
    /// </summary>
    public partial class GetGuardrailResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            var unmarshalledObject = new GetGuardrailResponse();
            var reader = new StreamingUtf8JsonReader(context.Stream, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);

            context.Read(ref reader);
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("automatedReasoningPolicy", targetDepth, ref reader))
                {
                    var unmarshaller = GuardrailAutomatedReasoningPolicyUnmarshaller.Instance;
                    unmarshalledObject.AutomatedReasoningPolicy = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("blockedInputMessaging", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BlockedInputMessaging = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("blockedOutputsMessaging", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BlockedOutputsMessaging = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("contentPolicy", targetDepth, ref reader))
                {
                    var unmarshaller = GuardrailContentPolicyUnmarshaller.Instance;
                    unmarshalledObject.ContentPolicy = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("contextualGroundingPolicy", targetDepth, ref reader))
                {
                    var unmarshaller = GuardrailContextualGroundingPolicyUnmarshaller.Instance;
                    unmarshalledObject.ContextualGroundingPolicy = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("createdAt", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreatedAt = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("crossRegionDetails", targetDepth, ref reader))
                {
                    var unmarshaller = GuardrailCrossRegionDetailsUnmarshaller.Instance;
                    unmarshalledObject.CrossRegionDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("description", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Description = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("failureRecommendations", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.FailureRecommendations = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("guardrailArn", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.GuardrailArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("guardrailId", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.GuardrailId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("kmsKeyArn", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.KmsKeyArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("name", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("sensitiveInformationPolicy", targetDepth, ref reader))
                {
                    var unmarshaller = GuardrailSensitiveInformationPolicyUnmarshaller.Instance;
                    unmarshalledObject.SensitiveInformationPolicy = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("status", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("statusReasons", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.StatusReasons = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("topicPolicy", targetDepth, ref reader))
                {
                    var unmarshaller = GuardrailTopicPolicyUnmarshaller.Instance;
                    unmarshalledObject.TopicPolicy = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("updatedAt", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.UpdatedAt = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("version", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Version = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("wordPolicy", targetDepth, ref reader))
                {
                    var unmarshaller = GuardrailWordPolicyUnmarshaller.Instance;
                    unmarshalledObject.WordPolicy = unmarshaller.Unmarshall(context, ref reader);
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
            return new AmazonBedrockException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static GetGuardrailResponseUnmarshaller _instance = new GetGuardrailResponseUnmarshaller();

        internal static GetGuardrailResponseUnmarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetGuardrailResponseUnmarshaller Instance => _instance;
    }
}
