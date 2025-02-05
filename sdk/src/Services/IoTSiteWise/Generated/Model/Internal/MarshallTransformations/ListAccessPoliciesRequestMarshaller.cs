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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTSiteWise.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.IoTSiteWise.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListAccessPolicies Request Marshaller
    /// </summary>       
    public class ListAccessPoliciesRequestMarshaller : IMarshaller<IRequest, ListAccessPoliciesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListAccessPoliciesRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListAccessPoliciesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoTSiteWise");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-12-02";
            request.HttpMethod = "GET";

            
            if (publicRequest.IsSetIamArn())
                request.Parameters.Add("iamArn", StringUtils.FromString(publicRequest.IamArn));
            
            if (publicRequest.IsSetIdentityId())
                request.Parameters.Add("identityId", StringUtils.FromString(publicRequest.IdentityId));
            
            if (publicRequest.IsSetIdentityType())
                request.Parameters.Add("identityType", StringUtils.FromString(publicRequest.IdentityType));
            
            if (publicRequest.IsSetMaxResults())
                request.Parameters.Add("maxResults", StringUtils.FromInt(publicRequest.MaxResults));
            
            if (publicRequest.IsSetNextToken())
                request.Parameters.Add("nextToken", StringUtils.FromString(publicRequest.NextToken));
            
            if (publicRequest.IsSetResourceId())
                request.Parameters.Add("resourceId", StringUtils.FromString(publicRequest.ResourceId));
            
            if (publicRequest.IsSetResourceType())
                request.Parameters.Add("resourceType", StringUtils.FromString(publicRequest.ResourceType));
            request.ResourcePath = "/access-policies";
            request.UseQueryString = true;
            
            request.HostPrefix = $"monitor.";

            return request;
        }
        private static ListAccessPoliciesRequestMarshaller _instance = new ListAccessPoliciesRequestMarshaller();        

        internal static ListAccessPoliciesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListAccessPoliciesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}