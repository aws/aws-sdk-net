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
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.Elasticsearch.Model
{
    /// <summary>
    /// Paginators for the Elasticsearch service
    ///</summary>
    public interface IElasticsearchPaginatorFactory
    {

        /// <summary>
        /// Paginator for DescribeDomainAutoTunes operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeDomainAutoTunesPaginator DescribeDomainAutoTunes(DescribeDomainAutoTunesRequest request);

        /// <summary>
        /// Paginator for DescribeInboundCrossClusterSearchConnections operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeInboundCrossClusterSearchConnectionsPaginator DescribeInboundCrossClusterSearchConnections(DescribeInboundCrossClusterSearchConnectionsRequest request);

        /// <summary>
        /// Paginator for DescribeOutboundCrossClusterSearchConnections operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeOutboundCrossClusterSearchConnectionsPaginator DescribeOutboundCrossClusterSearchConnections(DescribeOutboundCrossClusterSearchConnectionsRequest request);

        /// <summary>
        /// Paginator for DescribePackages operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribePackagesPaginator DescribePackages(DescribePackagesRequest request);

        /// <summary>
        /// Paginator for DescribeReservedElasticsearchInstanceOfferings operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeReservedElasticsearchInstanceOfferingsPaginator DescribeReservedElasticsearchInstanceOfferings(DescribeReservedElasticsearchInstanceOfferingsRequest request);

        /// <summary>
        /// Paginator for DescribeReservedElasticsearchInstances operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeReservedElasticsearchInstancesPaginator DescribeReservedElasticsearchInstances(DescribeReservedElasticsearchInstancesRequest request);

        /// <summary>
        /// Paginator for GetPackageVersionHistory operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetPackageVersionHistoryPaginator GetPackageVersionHistory(GetPackageVersionHistoryRequest request);

        /// <summary>
        /// Paginator for GetUpgradeHistory operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetUpgradeHistoryPaginator GetUpgradeHistory(GetUpgradeHistoryRequest request);

        /// <summary>
        /// Paginator for ListDomainsForPackage operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListDomainsForPackagePaginator ListDomainsForPackage(ListDomainsForPackageRequest request);

        /// <summary>
        /// Paginator for ListElasticsearchInstanceTypes operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListElasticsearchInstanceTypesPaginator ListElasticsearchInstanceTypes(ListElasticsearchInstanceTypesRequest request);

        /// <summary>
        /// Paginator for ListElasticsearchVersions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListElasticsearchVersionsPaginator ListElasticsearchVersions(ListElasticsearchVersionsRequest request);

        /// <summary>
        /// Paginator for ListPackagesForDomain operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListPackagesForDomainPaginator ListPackagesForDomain(ListPackagesForDomainRequest request);
    }
}