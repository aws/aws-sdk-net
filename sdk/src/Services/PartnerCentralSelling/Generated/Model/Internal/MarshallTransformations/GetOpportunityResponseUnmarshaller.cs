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
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.PartnerCentralSelling.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetOpportunity operation
    /// </summary>  
    public class GetOpportunityResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            GetOpportunityResponse response = new GetOpportunityResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Arn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Arn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Catalog", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Catalog = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreatedDate", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.CreatedDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Customer", targetDepth))
                {
                    var unmarshaller = CustomerUnmarshaller.Instance;
                    response.Customer = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Id", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Id = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastModifiedDate", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.LastModifiedDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LifeCycle", targetDepth))
                {
                    var unmarshaller = LifeCycleUnmarshaller.Instance;
                    response.LifeCycle = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Marketing", targetDepth))
                {
                    var unmarshaller = MarketingUnmarshaller.Instance;
                    response.Marketing = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NationalSecurity", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.NationalSecurity = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OpportunityTeam", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Contact, ContactUnmarshaller>(ContactUnmarshaller.Instance);
                    response.OpportunityTeam = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OpportunityType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.OpportunityType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PartnerOpportunityIdentifier", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.PartnerOpportunityIdentifier = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PrimaryNeedsFromAws", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    response.PrimaryNeedsFromAws = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Project", targetDepth))
                {
                    var unmarshaller = ProjectUnmarshaller.Instance;
                    response.Project = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RelatedEntityIdentifiers", targetDepth))
                {
                    var unmarshaller = RelatedEntityIdentifiersUnmarshaller.Instance;
                    response.RelatedEntityIdentifiers = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SoftwareRevenue", targetDepth))
                {
                    var unmarshaller = SoftwareRevenueUnmarshaller.Instance;
                    response.SoftwareRevenue = unmarshaller.Unmarshall(context);
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
            return new AmazonPartnerCentralSellingException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static GetOpportunityResponseUnmarshaller _instance = new GetOpportunityResponseUnmarshaller();        

        internal static GetOpportunityResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetOpportunityResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}