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
 * Do not modify this file. This file is generated from the es-2015-01-01.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.Elasticsearch.Model
{
    /// <summary>
    /// Paginators for the Elasticsearch service
    ///</summary>
    public class ElasticsearchPaginatorFactory : IElasticsearchPaginatorFactory
    {
        private readonly IAmazonElasticsearch client;

        internal ElasticsearchPaginatorFactory(IAmazonElasticsearch client) 
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
        /// Paginator for DescribeInboundCrossClusterSearchConnections operation
        ///</summary>
        public IDescribeInboundCrossClusterSearchConnectionsPaginator DescribeInboundCrossClusterSearchConnections(DescribeInboundCrossClusterSearchConnectionsRequest request) 
        {
            return new DescribeInboundCrossClusterSearchConnectionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeOutboundCrossClusterSearchConnections operation
        ///</summary>
        public IDescribeOutboundCrossClusterSearchConnectionsPaginator DescribeOutboundCrossClusterSearchConnections(DescribeOutboundCrossClusterSearchConnectionsRequest request) 
        {
            return new DescribeOutboundCrossClusterSearchConnectionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribePackages operation
        ///</summary>
        public IDescribePackagesPaginator DescribePackages(DescribePackagesRequest request) 
        {
            return new DescribePackagesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeReservedElasticsearchInstanceOfferings operation
        ///</summary>
        public IDescribeReservedElasticsearchInstanceOfferingsPaginator DescribeReservedElasticsearchInstanceOfferings(DescribeReservedElasticsearchInstanceOfferingsRequest request) 
        {
            return new DescribeReservedElasticsearchInstanceOfferingsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeReservedElasticsearchInstances operation
        ///</summary>
        public IDescribeReservedElasticsearchInstancesPaginator DescribeReservedElasticsearchInstances(DescribeReservedElasticsearchInstancesRequest request) 
        {
            return new DescribeReservedElasticsearchInstancesPaginator(this.client, request);
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
        /// Paginator for ListElasticsearchInstanceTypes operation
        ///</summary>
        public IListElasticsearchInstanceTypesPaginator ListElasticsearchInstanceTypes(ListElasticsearchInstanceTypesRequest request) 
        {
            return new ListElasticsearchInstanceTypesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListElasticsearchVersions operation
        ///</summary>
        public IListElasticsearchVersionsPaginator ListElasticsearchVersions(ListElasticsearchVersionsRequest request) 
        {
            return new ListElasticsearchVersionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPackagesForDomain operation
        ///</summary>
        public IListPackagesForDomainPaginator ListPackagesForDomain(ListPackagesForDomainRequest request) 
        {
            return new ListPackagesForDomainPaginator(this.client, request);
        }
    }
}