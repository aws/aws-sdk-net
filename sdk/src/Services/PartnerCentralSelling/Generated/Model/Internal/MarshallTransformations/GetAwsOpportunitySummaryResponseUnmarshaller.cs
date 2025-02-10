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
 * Do not modify this file. This file is generated from the partnercentral-selling-2022-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.PartnerCentralSelling.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using Amazon.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.PartnerCentralSelling.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetAwsOpportunitySummary operation
    /// </summary>  
    public class GetAwsOpportunitySummaryResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            GetAwsOpportunitySummaryResponse response = new GetAwsOpportunitySummaryResponse();
            StreamingUtf8JsonReader reader = new StreamingUtf8JsonReader(context.Stream);
            context.Read(ref reader);
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("Catalog", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Catalog = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Customer", targetDepth))
                {
                    var unmarshaller = AwsOpportunityCustomerUnmarshaller.Instance;
                    response.Customer = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Insights", targetDepth))
                {
                    var unmarshaller = AwsOpportunityInsightsUnmarshaller.Instance;
                    response.Insights = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("InvolvementType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.InvolvementType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("InvolvementTypeChangeReason", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.InvolvementTypeChangeReason = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("LifeCycle", targetDepth))
                {
                    var unmarshaller = AwsOpportunityLifeCycleUnmarshaller.Instance;
                    response.LifeCycle = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("OpportunityTeam", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AwsTeamMember, AwsTeamMemberUnmarshaller>(AwsTeamMemberUnmarshaller.Instance);
                    response.OpportunityTeam = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Origin", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Origin = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Project", targetDepth))
                {
                    var unmarshaller = AwsOpportunityProjectUnmarshaller.Instance;
                    response.Project = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RelatedEntityIds", targetDepth))
                {
                    var unmarshaller = AwsOpportunityRelatedEntitiesUnmarshaller.Instance;
                    response.RelatedEntityIds = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RelatedOpportunityId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.RelatedOpportunityId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Visibility", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Visibility = unmarshaller.Unmarshall(context, ref reader);
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
            return new AmazonPartnerCentralSellingException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static GetAwsOpportunitySummaryResponseUnmarshaller _instance = new GetAwsOpportunitySummaryResponseUnmarshaller();        

        internal static GetAwsOpportunitySummaryResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetAwsOpportunitySummaryResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}