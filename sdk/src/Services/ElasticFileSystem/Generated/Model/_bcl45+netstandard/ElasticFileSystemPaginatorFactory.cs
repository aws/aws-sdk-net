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

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.ElasticFileSystem.Model
{
    /// <summary>
    /// Paginators for the ElasticFileSystem service
    ///</summary>
    public class ElasticFileSystemPaginatorFactory : IElasticFileSystemPaginatorFactory
    {
        private readonly IAmazonElasticFileSystem client;

        internal ElasticFileSystemPaginatorFactory(IAmazonElasticFileSystem client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for DescribeAccessPoints operation
        ///</summary>
        public IDescribeAccessPointsPaginator DescribeAccessPoints(DescribeAccessPointsRequest request) 
        {
            return new DescribeAccessPointsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeFileSystems operation
        ///</summary>
        public IDescribeFileSystemsPaginator DescribeFileSystems(DescribeFileSystemsRequest request) 
        {
            return new DescribeFileSystemsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeMountTargets operation
        ///</summary>
        public IDescribeMountTargetsPaginator DescribeMountTargets(DescribeMountTargetsRequest request) 
        {
            return new DescribeMountTargetsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeReplicationConfigurations operation
        ///</summary>
        public IDescribeReplicationConfigurationsPaginator DescribeReplicationConfigurations(DescribeReplicationConfigurationsRequest request) 
        {
            return new DescribeReplicationConfigurationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeTags operation
        ///</summary>
        public IDescribeTagsPaginator DescribeTags(DescribeTagsRequest request) 
        {
            return new DescribeTagsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTagsForResource operation
        ///</summary>
        public IListTagsForResourcePaginator ListTagsForResource(ListTagsForResourceRequest request) 
        {
            return new ListTagsForResourcePaginator(this.client, request);
        }
    }
}