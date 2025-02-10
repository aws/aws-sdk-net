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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DataZone.Model;
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
namespace Amazon.DataZone.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListSubscriptionGrants Request Marshaller
    /// </summary>       
    public class ListSubscriptionGrantsRequestMarshaller : IMarshaller<IRequest, ListSubscriptionGrantsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListSubscriptionGrantsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListSubscriptionGrantsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DataZone");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetDomainIdentifier())
                throw new AmazonDataZoneException("Request object does not have required field DomainIdentifier set");
            request.AddPathResource("{domainIdentifier}", StringUtils.FromString(publicRequest.DomainIdentifier));
            
            if (publicRequest.IsSetEnvironmentId())
                request.Parameters.Add("environmentId", StringUtils.FromString(publicRequest.EnvironmentId));
            
            if (publicRequest.IsSetMaxResults())
                request.Parameters.Add("maxResults", StringUtils.FromInt(publicRequest.MaxResults));
            
            if (publicRequest.IsSetNextToken())
                request.Parameters.Add("nextToken", StringUtils.FromString(publicRequest.NextToken));
            
            if (publicRequest.IsSetOwningProjectId())
                request.Parameters.Add("owningProjectId", StringUtils.FromString(publicRequest.OwningProjectId));
            
            if (publicRequest.IsSetSortBy())
                request.Parameters.Add("sortBy", StringUtils.FromString(publicRequest.SortBy));
            
            if (publicRequest.IsSetSortOrder())
                request.Parameters.Add("sortOrder", StringUtils.FromString(publicRequest.SortOrder));
            
            if (publicRequest.IsSetSubscribedListingId())
                request.Parameters.Add("subscribedListingId", StringUtils.FromString(publicRequest.SubscribedListingId));
            
            if (publicRequest.IsSetSubscriptionId())
                request.Parameters.Add("subscriptionId", StringUtils.FromString(publicRequest.SubscriptionId));
            
            if (publicRequest.IsSetSubscriptionTargetId())
                request.Parameters.Add("subscriptionTargetId", StringUtils.FromString(publicRequest.SubscriptionTargetId));
            request.ResourcePath = "/v2/domains/{domainIdentifier}/subscription-grants";
            request.UseQueryString = true;

            return request;
        }
        private static ListSubscriptionGrantsRequestMarshaller _instance = new ListSubscriptionGrantsRequestMarshaller();        

        internal static ListSubscriptionGrantsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListSubscriptionGrantsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}