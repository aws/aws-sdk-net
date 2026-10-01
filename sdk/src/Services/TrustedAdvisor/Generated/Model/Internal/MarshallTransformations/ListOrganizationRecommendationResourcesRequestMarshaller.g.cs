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
using System.IO;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;

using Amazon.TrustedAdvisor.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.TrustedAdvisor.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListOrganizationRecommendationResources Request Marshaller
    /// </summary>
    public partial class ListOrganizationRecommendationResourcesRequestMarshaller : IMarshaller<IRequest, ListOrganizationRecommendationResourcesRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListOrganizationRecommendationResourcesRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ListOrganizationRecommendationResourcesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.TrustedAdvisor");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-09-15";
            request.HttpMethod = "GET";

            if (publicRequest.IsSetAffectedAccountId())
            {
                request.Parameters.Add("affectedAccountId", StringUtils.FromString(publicRequest.AffectedAccountId));
            }

            if (publicRequest.IsSetExclusionStatus())
            {
                request.Parameters.Add("exclusionStatus", StringUtils.FromString(publicRequest.ExclusionStatus));
            }

            if (publicRequest.IsSetMaxResults())
            {
                request.Parameters.Add("maxResults", StringUtils.FromInt(publicRequest.MaxResults.Value));
            }

            if (publicRequest.IsSetNextToken())
            {
                request.Parameters.Add("nextToken", StringUtils.FromString(publicRequest.NextToken));
            }

            if (publicRequest.IsSetRegionCode())
            {
                request.Parameters.Add("regionCode", StringUtils.FromString(publicRequest.RegionCode));
            }

            if (publicRequest.IsSetStatus())
            {
                request.Parameters.Add("status", StringUtils.FromString(publicRequest.Status));
            }

            if (!publicRequest.IsSetOrganizationRecommendationIdentifier())
            {
                throw new AmazonTrustedAdvisorException("Request object does not have required field OrganizationRecommendationIdentifier set");
            }
            request.AddPathResource("{organizationRecommendationIdentifier}", StringUtils.FromString(publicRequest.OrganizationRecommendationIdentifier));

            request.ResourcePath = "/v1/organization-recommendations/{organizationRecommendationIdentifier}/resources";

            request.UseQueryString = true;

            return request;
        }

        private static readonly ListOrganizationRecommendationResourcesRequestMarshaller _instance = new();

        internal static ListOrganizationRecommendationResourcesRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ListOrganizationRecommendationResourcesRequestMarshaller Instance => _instance;
    }
}
