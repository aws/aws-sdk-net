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
 * Do not modify this file. This file is generated from the snowball-2016-06-30.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.Snowball.Model
{
    /// <summary>
    /// Paginators for the Snowball service
    ///</summary>
    public class SnowballPaginatorFactory : ISnowballPaginatorFactory
    {
        private readonly IAmazonSnowball client;

        internal SnowballPaginatorFactory(IAmazonSnowball client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for DescribeAddresses operation
        ///</summary>
        public IDescribeAddressesPaginator DescribeAddresses(DescribeAddressesRequest request) 
        {
            return new DescribeAddressesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListClusterJobs operation
        ///</summary>
        public IListClusterJobsPaginator ListClusterJobs(ListClusterJobsRequest request) 
        {
            return new ListClusterJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListClusters operation
        ///</summary>
        public IListClustersPaginator ListClusters(ListClustersRequest request) 
        {
            return new ListClustersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCompatibleImages operation
        ///</summary>
        public IListCompatibleImagesPaginator ListCompatibleImages(ListCompatibleImagesRequest request) 
        {
            return new ListCompatibleImagesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListJobs operation
        ///</summary>
        public IListJobsPaginator ListJobs(ListJobsRequest request) 
        {
            return new ListJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListLongTermPricing operation
        ///</summary>
        public IListLongTermPricingPaginator ListLongTermPricing(ListLongTermPricingRequest request) 
        {
            return new ListLongTermPricingPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPickupLocations operation
        ///</summary>
        public IListPickupLocationsPaginator ListPickupLocations(ListPickupLocationsRequest request) 
        {
            return new ListPickupLocationsPaginator(this.client, request);
        }
    }
}