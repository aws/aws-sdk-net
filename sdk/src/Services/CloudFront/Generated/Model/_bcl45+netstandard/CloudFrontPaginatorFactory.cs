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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// Paginators for the CloudFront service
    ///</summary>
    public class CloudFrontPaginatorFactory : ICloudFrontPaginatorFactory
    {
        private readonly IAmazonCloudFront client;

        internal CloudFrontPaginatorFactory(IAmazonCloudFront client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListCloudFrontOriginAccessIdentities operation
        ///</summary>
        public IListCloudFrontOriginAccessIdentitiesPaginator ListCloudFrontOriginAccessIdentities(ListCloudFrontOriginAccessIdentitiesRequest request) 
        {
            return new ListCloudFrontOriginAccessIdentitiesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDistributions operation
        ///</summary>
        public IListDistributionsPaginator ListDistributions(ListDistributionsRequest request) 
        {
            return new ListDistributionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListInvalidations operation
        ///</summary>
        public IListInvalidationsPaginator ListInvalidations(ListInvalidationsRequest request) 
        {
            return new ListInvalidationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListStreamingDistributions operation
        ///</summary>
        public IListStreamingDistributionsPaginator ListStreamingDistributions(ListStreamingDistributionsRequest request) 
        {
            return new ListStreamingDistributionsPaginator(this.client, request);
        }
    }
}