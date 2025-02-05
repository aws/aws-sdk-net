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
 * Do not modify this file. This file is generated from the security-ir-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityIR.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using Amazon.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityIR.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetCase operation
    /// </summary>  
    public class GetCaseResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            GetCaseResponse response = new GetCaseResponse();
            StreamingUtf8JsonReader reader = new StreamingUtf8JsonReader(context.Stream);
            context.Read(ref reader);
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("actualIncidentStartDate", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    response.ActualIncidentStartDate = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("caseArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.CaseArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("caseAttachments", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<CaseAttachmentAttributes, CaseAttachmentAttributesUnmarshaller>(CaseAttachmentAttributesUnmarshaller.Instance);
                    response.CaseAttachments = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("caseStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.CaseStatus = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("closedDate", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    response.ClosedDate = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("closureCode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ClosureCode = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("createdDate", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    response.CreatedDate = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Description = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("engagementType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.EngagementType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("impactedAccounts", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    response.ImpactedAccounts = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("impactedAwsRegions", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<ImpactedAwsRegion, ImpactedAwsRegionUnmarshaller>(ImpactedAwsRegionUnmarshaller.Instance);
                    response.ImpactedAwsRegions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("impactedServices", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    response.ImpactedServices = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("lastUpdatedDate", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    response.LastUpdatedDate = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("pendingAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.PendingAction = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("reportedIncidentStartDate", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    response.ReportedIncidentStartDate = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("resolverType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ResolverType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("threatActorIpAddresses", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<ThreatActorIp, ThreatActorIpUnmarshaller>(ThreatActorIpUnmarshaller.Instance);
                    response.ThreatActorIpAddresses = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("title", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Title = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("watchers", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<Watcher, WatcherUnmarshaller>(WatcherUnmarshaller.Instance);
                    response.Watchers = unmarshaller.Unmarshall(context, ref reader);
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
                if (errorResponse.Code != null && errorResponse.Code.Equals("ConflictException"))
                {
                    return ConflictExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InternalServerException"))
                {
                    return InternalServerExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidTokenException"))
                {
                    return InvalidTokenExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFoundException"))
                {
                    return ResourceNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("SecurityIncidentResponseNotActiveException"))
                {
                    return SecurityIncidentResponseNotActiveExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ServiceQuotaExceededException"))
                {
                    return ServiceQuotaExceededExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
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
            return new AmazonSecurityIRException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static GetCaseResponseUnmarshaller _instance = new GetCaseResponseUnmarshaller();        

        internal static GetCaseResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetCaseResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}