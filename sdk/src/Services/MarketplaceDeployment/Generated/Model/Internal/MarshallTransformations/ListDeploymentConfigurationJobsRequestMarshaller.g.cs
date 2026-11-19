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

using Amazon.MarketplaceDeployment.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.MarketplaceDeployment.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListDeploymentConfigurationJobs Request Marshaller
    /// </summary>
    public partial class ListDeploymentConfigurationJobsRequestMarshaller : IMarshaller<IRequest, ListDeploymentConfigurationJobsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListDeploymentConfigurationJobsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ListDeploymentConfigurationJobsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MarketplaceDeployment");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-01-25";
            request.HttpMethod = "GET";

            if (publicRequest.IsSetMaxResults())
            {
                request.Parameters.Add("maxResults", StringUtils.FromInt(publicRequest.MaxResults.Value));
            }

            if (publicRequest.IsSetNextToken())
            {
                request.Parameters.Add("nextToken", StringUtils.FromString(publicRequest.NextToken));
            }

            if (!publicRequest.IsSetCatalog())
            {
                throw new AmazonMarketplaceDeploymentException("Request object does not have required field Catalog set");
            }
            request.AddPathResource("{catalog}", StringUtils.FromString(publicRequest.Catalog));

            if (!publicRequest.IsSetDeliveryOptionType())
            {
                throw new AmazonMarketplaceDeploymentException("Request object does not have required field DeliveryOptionType set");
            }
            request.AddPathResource("{deliveryOptionType}", StringUtils.FromString(publicRequest.DeliveryOptionType));

            if (!publicRequest.IsSetProductId())
            {
                throw new AmazonMarketplaceDeploymentException("Request object does not have required field ProductId set");
            }
            request.AddPathResource("{productId}", StringUtils.FromString(publicRequest.ProductId));

            request.ResourcePath = "/catalogs/{catalog}/products/{productId}/delivery-options/{deliveryOptionType}/deployment-configuration/jobs";

            request.UseQueryString = true;

            return request;
        }

        private static readonly ListDeploymentConfigurationJobsRequestMarshaller _instance = new();

        internal static ListDeploymentConfigurationJobsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ListDeploymentConfigurationJobsRequestMarshaller Instance => _instance;
    }
}
