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

using Amazon.ComputeOptimizerAutomation.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.ComputeOptimizerAutomation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetAutomationEvent operation.
    /// </summary>
    public partial class GetAutomationEventResponseUnmarshaller : CborResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        public override AmazonWebServiceResponse Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new GetAutomationEventResponse();
            var reader = context.Reader;

            context.AddPathSegment("GetAutomationEvent");
            reader.ReadStartMap();
            while (reader.PeekState() != CborReaderState.EndMap)
            {
                var propertyName = reader.ReadTextString();
                switch (propertyName)
                {
                    case "accountId":
                        context.AddPathSegment("AccountId");
                        unmarshalledObject.AccountId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "completedTimestamp":
                        context.AddPathSegment("CompletedTimestamp");
                        unmarshalledObject.CompletedTimestamp = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "createdTimestamp":
                        context.AddPathSegment("CreatedTimestamp");
                        unmarshalledObject.CreatedTimestamp = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "estimatedMonthlySavings":
                        context.AddPathSegment("EstimatedMonthlySavings");
                        unmarshalledObject.EstimatedMonthlySavings = EstimatedMonthlySavingsUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "eventDescription":
                        context.AddPathSegment("EventDescription");
                        unmarshalledObject.EventDescription = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "eventId":
                        context.AddPathSegment("EventId");
                        unmarshalledObject.EventId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "eventStatus":
                        context.AddPathSegment("EventStatus");
                        unmarshalledObject.EventStatus = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "eventStatusReason":
                        context.AddPathSegment("EventStatusReason");
                        unmarshalledObject.EventStatusReason = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "eventType":
                        context.AddPathSegment("EventType");
                        unmarshalledObject.EventType = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "recommendedActionId":
                        context.AddPathSegment("RecommendedActionId");
                        unmarshalledObject.RecommendedActionId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "region":
                        context.AddPathSegment("Region");
                        unmarshalledObject.Region = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "resourceArn":
                        context.AddPathSegment("ResourceArn");
                        unmarshalledObject.ResourceArn = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "resourceId":
                        context.AddPathSegment("ResourceId");
                        unmarshalledObject.ResourceId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "resourceType":
                        context.AddPathSegment("ResourceType");
                        unmarshalledObject.ResourceType = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ruleId":
                        context.AddPathSegment("RuleId");
                        unmarshalledObject.RuleId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    default:
                        reader.SkipValue();
                        break;
                }
            }
            reader.ReadEndMap();
            context.PopPathSegment();

            return unmarshalledObject;
        }

        /// <summary>
        /// Unmarshall error response to exception.
        /// </summary>
        public override AmazonServiceException UnmarshallException(CborUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            var errorResponse = CborErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            {
                using (var contextCopy = new CborUnmarshallerContext(streamCopy, false, context.ResponseData))
                {
                    if (errorResponse.Code != null && errorResponse.Code.Equals("AccessDeniedException"))
                    {
                        return AccessDeniedExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("ForbiddenException"))
                    {
                        return ForbiddenExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("InternalServerException"))
                    {
                        return InternalServerExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidParameterValueException"))
                    {
                        return InvalidParameterValueExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("OptInRequiredException"))
                    {
                        return OptInRequiredExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFoundException"))
                    {
                        return ResourceNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("ServiceUnavailableException"))
                    {
                        return ServiceUnavailableExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("ThrottlingException"))
                    {
                        return ThrottlingExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                    }
                }
            }
            return new AmazonComputeOptimizerAutomationException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static GetAutomationEventResponseUnmarshaller _instance = new GetAutomationEventResponseUnmarshaller();

        internal static GetAutomationEventResponseUnmarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetAutomationEventResponseUnmarshaller Instance => _instance;
    }
}
