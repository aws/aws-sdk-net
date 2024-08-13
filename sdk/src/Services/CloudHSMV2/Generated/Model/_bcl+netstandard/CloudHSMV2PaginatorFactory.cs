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
 * Do not modify this file. This file is generated from the cloudhsmv2-2017-04-28.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.CloudHSMV2.Model
{
    /// <summary>
    /// Paginators for the CloudHSMV2 service
    ///</summary>
    public class CloudHSMV2PaginatorFactory : ICloudHSMV2PaginatorFactory
    {
        private readonly IAmazonCloudHSMV2 client;

        internal CloudHSMV2PaginatorFactory(IAmazonCloudHSMV2 client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for DescribeBackups operation
        ///</summary>
        public IDescribeBackupsPaginator DescribeBackups(DescribeBackupsRequest request) 
        {
            return new DescribeBackupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeClusters operation
        ///</summary>
        public IDescribeClustersPaginator DescribeClusters(DescribeClustersRequest request) 
        {
            return new DescribeClustersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTags operation
        ///</summary>
        public IListTagsPaginator ListTags(ListTagsRequest request) 
        {
            return new ListTagsPaginator(this.client, request);
        }
    }
}