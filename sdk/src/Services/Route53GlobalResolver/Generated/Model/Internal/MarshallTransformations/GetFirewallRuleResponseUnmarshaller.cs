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
 * Do not modify this file. This file is generated from the route53globalresolver-2022-09-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Route53GlobalResolver.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Route53GlobalResolver.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetFirewallRule operation
    /// </summary>  
    public class GetFirewallRuleResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            GetFirewallRuleResponse response = new GetFirewallRuleResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("action", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Action = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("blockOverrideDnsType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.BlockOverrideDnsType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("blockOverrideDomain", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.BlockOverrideDomain = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("blockOverrideTtl", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    response.BlockOverrideTtl = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("blockResponse", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.BlockResponse = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("confidenceThreshold", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ConfidenceThreshold = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("createdAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.CreatedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Description = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dnsAdvancedProtection", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.DnsAdvancedProtection = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dnsViewId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.DnsViewId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("firewallDomainListId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.FirewallDomainListId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("id", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Id = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("priority", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    response.Priority = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("queryType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.QueryType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("updatedAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.UpdatedAt = unmarshaller.Unmarshall(context);
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
            return new AmazonRoute53GlobalResolverException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static GetFirewallRuleResponseUnmarshaller _instance = new GetFirewallRuleResponseUnmarshaller();        

        internal static GetFirewallRuleResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetFirewallRuleResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}