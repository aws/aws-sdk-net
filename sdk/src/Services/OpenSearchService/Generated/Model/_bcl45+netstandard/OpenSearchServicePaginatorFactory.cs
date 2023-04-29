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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Paginators for the OpenSearchService service
    ///</summary>
    public class OpenSearchServicePaginatorFactory : IOpenSearchServicePaginatorFactory
    {
        private readonly IAmazonOpenSearchService client;

        internal OpenSearchServicePaginatorFactory(IAmazonOpenSearchService client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for DescribeDomainAutoTunes operation
        ///</summary>
        public IDescribeDomainAutoTunesPaginator DescribeDomainAutoTunes(DescribeDomainAutoTunesRequest request) 
        {
            return new DescribeDomainAutoTunesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeInboundConnections operation
        ///</summary>
        public IDescribeInboundConnectionsPaginator DescribeInboundConnections(DescribeInboundConnectionsRequest request) 
        {
            return new DescribeInboundConnectionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeOutboundConnections operation
        ///</summary>
        public IDescribeOutboundConnectionsPaginator DescribeOutboundConnections(DescribeOutboundConnectionsRequest request) 
        {
            return new DescribeOutboundConnectionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribePackages operation
        ///</summary>
        public IDescribePackagesPaginator DescribePackages(DescribePackagesRequest request) 
        {
            return new DescribePackagesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeReservedInstanceOfferings operation
        ///</summary>
        public IDescribeReservedInstanceOfferingsPaginator DescribeReservedInstanceOfferings(DescribeReservedInstanceOfferingsRequest request) 
        {
            return new DescribeReservedInstanceOfferingsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeReservedInstances operation
        ///</summary>
        public IDescribeReservedInstancesPaginator DescribeReservedInstances(DescribeReservedInstancesRequest request) 
        {
            return new DescribeReservedInstancesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetPackageVersionHistory operation
        ///</summary>
        public IGetPackageVersionHistoryPaginator GetPackageVersionHistory(GetPackageVersionHistoryRequest request) 
        {
            return new GetPackageVersionHistoryPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetUpgradeHistory operation
        ///</summary>
        public IGetUpgradeHistoryPaginator GetUpgradeHistory(GetUpgradeHistoryRequest request) 
        {
            return new GetUpgradeHistoryPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDomainsForPackage operation
        ///</summary>
        public IListDomainsForPackagePaginator ListDomainsForPackage(ListDomainsForPackageRequest request) 
        {
            return new ListDomainsForPackagePaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListInstanceTypeDetails operation
        ///</summary>
        public IListInstanceTypeDetailsPaginator ListInstanceTypeDetails(ListInstanceTypeDetailsRequest request) 
        {
            return new ListInstanceTypeDetailsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPackagesForDomain operation
        ///</summary>
        public IListPackagesForDomainPaginator ListPackagesForDomain(ListPackagesForDomainRequest request) 
        {
            return new ListPackagesForDomainPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListScheduledActions operation
        ///</summary>
        public IListScheduledActionsPaginator ListScheduledActions(ListScheduledActionsRequest request) 
        {
            return new ListScheduledActionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListVersions operation
        ///</summary>
        public IListVersionsPaginator ListVersions(ListVersionsRequest request) 
        {
            return new ListVersionsPaginator(this.client, request);
        }
    }
}