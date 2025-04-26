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
 * Do not modify this file. This file is generated from the elasticfilesystem-2015-02-01.normal.json service model.
 */
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.ElasticFileSystem.Model
{
    /// <summary>
    /// Paginators for the ElasticFileSystem service
    ///</summary>
    public interface IElasticFileSystemPaginatorFactory
    {

        /// <summary>
        /// Paginator for DescribeAccessPoints operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeAccessPointsPaginator DescribeAccessPoints(DescribeAccessPointsRequest request);

        /// <summary>
        /// Paginator for DescribeFileSystems operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxItems",
            OutputToken = new[] { "NextMarker" }
        )]
        IDescribeFileSystemsPaginator DescribeFileSystems(DescribeFileSystemsRequest request);

        /// <summary>
        /// Paginator for DescribeMountTargets operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxItems",
            OutputToken = new[] { "NextMarker" }
        )]
        IDescribeMountTargetsPaginator DescribeMountTargets(DescribeMountTargetsRequest request);

        /// <summary>
        /// Paginator for DescribeReplicationConfigurations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeReplicationConfigurationsPaginator DescribeReplicationConfigurations(DescribeReplicationConfigurationsRequest request);

        /// <summary>
        /// Paginator for DescribeTags operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxItems",
            OutputToken = new[] { "NextMarker" }
        )]
        IDescribeTagsPaginator DescribeTags(DescribeTagsRequest request);

        /// <summary>
        /// Paginator for ListTagsForResource operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListTagsForResourcePaginator ListTagsForResource(ListTagsForResourceRequest request);
    }
}