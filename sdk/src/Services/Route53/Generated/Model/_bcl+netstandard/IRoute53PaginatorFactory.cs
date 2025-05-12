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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
 */
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.Route53.Model
{
    /// <summary>
    /// Paginators for the Route53 service
    ///</summary>
    public interface IRoute53PaginatorFactory
    {

        /// <summary>
        /// Paginator for ListCidrBlocks operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListCidrBlocksPaginator ListCidrBlocks(ListCidrBlocksRequest request);

        /// <summary>
        /// Paginator for ListCidrCollections operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListCidrCollectionsPaginator ListCidrCollections(ListCidrCollectionsRequest request);

        /// <summary>
        /// Paginator for ListCidrLocations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListCidrLocationsPaginator ListCidrLocations(ListCidrLocationsRequest request);

        /// <summary>
        /// Paginator for ListHealthChecks operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxItems",
            OutputToken = new[] { "NextMarker" }
        )]
        IListHealthChecksPaginator ListHealthChecks(ListHealthChecksRequest request);

        /// <summary>
        /// Paginator for ListHostedZones operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxItems",
            OutputToken = new[] { "NextMarker" }
        )]
        IListHostedZonesPaginator ListHostedZones(ListHostedZonesRequest request);

        /// <summary>
        /// Paginator for ListQueryLoggingConfigs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListQueryLoggingConfigsPaginator ListQueryLoggingConfigs(ListQueryLoggingConfigsRequest request);

        /// <summary>
        /// Paginator for ListResourceRecordSets operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "StartRecordName","StartRecordType","StartRecordIdentifier" },
            LimitKey = "MaxItems",
            OutputToken = new[] { "NextRecordName","NextRecordType","NextRecordIdentifier" }
        )]
        IListResourceRecordSetsPaginator ListResourceRecordSets(ListResourceRecordSetsRequest request);
    }
}