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
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityIR.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetMembership operation
    /// </summary>  
    public class GetMembershipResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            GetMembershipResponse response = new GetMembershipResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("accountId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.AccountId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("customerType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.CustomerType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("incidentResponseTeam", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<IncidentResponder, IncidentResponderUnmarshaller>(IncidentResponderUnmarshaller.Instance);
                    response.IncidentResponseTeam = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("membershipAccountsConfigurations", targetDepth))
                {
                    var unmarshaller = MembershipAccountsConfigurationsUnmarshaller.Instance;
                    response.MembershipAccountsConfigurations = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("membershipActivationTimestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.MembershipActivationTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("membershipArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.MembershipArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("membershipDeactivationTimestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.MembershipDeactivationTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("membershipId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.MembershipId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("membershipName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.MembershipName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("membershipStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.MembershipStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("numberOfAccountsCovered", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    response.NumberOfAccountsCovered = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("optInFeatures", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<OptInFeature, OptInFeatureUnmarshaller>(OptInFeatureUnmarshaller.Instance);
                    response.OptInFeatures = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("region", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Region = unmarshaller.Unmarshall(context);
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
                if (errorResponse.Code != null && errorResponse.Code.Equals("ConflictException"))
                {
                    return ConflictExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InternalServerException"))
                {
                    return InternalServerExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidTokenException"))
                {
                    return InvalidTokenExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFoundException"))
                {
                    return ResourceNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("SecurityIncidentResponseNotActiveException"))
                {
                    return SecurityIncidentResponseNotActiveExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ServiceQuotaExceededException"))
                {
                    return ServiceQuotaExceededExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
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
            return new AmazonSecurityIRException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static GetMembershipResponseUnmarshaller _instance = new GetMembershipResponseUnmarshaller();        

        internal static GetMembershipResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetMembershipResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}