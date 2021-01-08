#if !NETSTANDARD13
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

namespace Amazon.Elasticsearch.Model
{
    /// <summary>
    /// Paginators for the Elasticsearch service
    ///</summary>
    public interface IElasticsearchPaginatorFactory
    {

        /// <summary>
        /// Paginator for DescribeInboundCrossClusterSearchConnections operation
        ///</summary>
        IDescribeInboundCrossClusterSearchConnectionsPaginator DescribeInboundCrossClusterSearchConnections(DescribeInboundCrossClusterSearchConnectionsRequest request);

        /// <summary>
        /// Paginator for DescribeOutboundCrossClusterSearchConnections operation
        ///</summary>
        IDescribeOutboundCrossClusterSearchConnectionsPaginator DescribeOutboundCrossClusterSearchConnections(DescribeOutboundCrossClusterSearchConnectionsRequest request);

        /// <summary>
        /// Paginator for DescribePackages operation
        ///</summary>
        IDescribePackagesPaginator DescribePackages(DescribePackagesRequest request);

        /// <summary>
        /// Paginator for DescribeReservedElasticsearchInstanceOfferings operation
        ///</summary>
        IDescribeReservedElasticsearchInstanceOfferingsPaginator DescribeReservedElasticsearchInstanceOfferings(DescribeReservedElasticsearchInstanceOfferingsRequest request);

        /// <summary>
        /// Paginator for DescribeReservedElasticsearchInstances operation
        ///</summary>
        IDescribeReservedElasticsearchInstancesPaginator DescribeReservedElasticsearchInstances(DescribeReservedElasticsearchInstancesRequest request);

        /// <summary>
        /// Paginator for GetPackageVersionHistory operation
        ///</summary>
        IGetPackageVersionHistoryPaginator GetPackageVersionHistory(GetPackageVersionHistoryRequest request);

        /// <summary>
        /// Paginator for GetUpgradeHistory operation
        ///</summary>
        IGetUpgradeHistoryPaginator GetUpgradeHistory(GetUpgradeHistoryRequest request);

        /// <summary>
        /// Paginator for ListDomainsForPackage operation
        ///</summary>
        IListDomainsForPackagePaginator ListDomainsForPackage(ListDomainsForPackageRequest request);

        /// <summary>
        /// Paginator for ListElasticsearchInstanceTypes operation
        ///</summary>
        IListElasticsearchInstanceTypesPaginator ListElasticsearchInstanceTypes(ListElasticsearchInstanceTypesRequest request);

        /// <summary>
        /// Paginator for ListElasticsearchVersions operation
        ///</summary>
        IListElasticsearchVersionsPaginator ListElasticsearchVersions(ListElasticsearchVersionsRequest request);

        /// <summary>
        /// Paginator for ListPackagesForDomain operation
        ///</summary>
        IListPackagesForDomainPaginator ListPackagesForDomain(ListPackagesForDomainRequest request);
    }
}
#endif