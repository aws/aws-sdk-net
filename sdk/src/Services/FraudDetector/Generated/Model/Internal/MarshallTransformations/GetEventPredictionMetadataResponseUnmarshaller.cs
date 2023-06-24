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
 * Do not modify this file. This file is generated from the frauddetector-2019-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.FraudDetector.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.FraudDetector.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetEventPredictionMetadata operation
    /// </summary>  
    public class GetEventPredictionMetadataResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            GetEventPredictionMetadataResponse response = new GetEventPredictionMetadataResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("detectorId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.DetectorId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("detectorVersionId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.DetectorVersionId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("detectorVersionStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.DetectorVersionStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("entityId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.EntityId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("entityType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.EntityType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("evaluatedExternalModels", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<EvaluatedExternalModel, EvaluatedExternalModelUnmarshaller>(EvaluatedExternalModelUnmarshaller.Instance);
                    response.EvaluatedExternalModels = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("evaluatedModelVersions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<EvaluatedModelVersion, EvaluatedModelVersionUnmarshaller>(EvaluatedModelVersionUnmarshaller.Instance);
                    response.EvaluatedModelVersions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("eventId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.EventId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("eventTimestamp", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.EventTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("eventTypeName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.EventTypeName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("eventVariables", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<EventVariableSummary, EventVariableSummaryUnmarshaller>(EventVariableSummaryUnmarshaller.Instance);
                    response.EventVariables = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("outcomes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    response.Outcomes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("predictionTimestamp", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.PredictionTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ruleExecutionMode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.RuleExecutionMode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("rules", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<EvaluatedRule, EvaluatedRuleUnmarshaller>(EvaluatedRuleUnmarshaller.Instance);
                    response.Rules = unmarshaller.Unmarshall(context);
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
                if (errorResponse.Code != null && errorResponse.Code.Equals("AccessDeniedException"))
                {
                    return AccessDeniedExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InternalServerException"))
                {
                    return InternalServerExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFoundException"))
                {
                    return ResourceNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ThrottlingException"))
                {
                    return ThrottlingExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ValidationException"))
                {
                    return ValidationExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonFraudDetectorException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static GetEventPredictionMetadataResponseUnmarshaller _instance = new GetEventPredictionMetadataResponseUnmarshaller();        

        internal static GetEventPredictionMetadataResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetEventPredictionMetadataResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}