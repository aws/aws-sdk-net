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
 * Do not modify this file. This file is generated from the cloudhsmv2-2017-04-28.normal.json service model.
 */

namespace Amazon.CloudHSMV2.Model
{
    /// <summary>
    /// Paginators for the CloudHSMV2 service
    ///</summary>
    public interface ICloudHSMV2PaginatorFactory
    {

        /// <summary>
        /// Paginator for DescribeBackups operation
        ///</summary>
        IDescribeBackupsPaginator DescribeBackups(DescribeBackupsRequest request);

        /// <summary>
        /// Paginator for DescribeClusters operation
        ///</summary>
        IDescribeClustersPaginator DescribeClusters(DescribeClustersRequest request);

        /// <summary>
        /// Paginator for ListTags operation
        ///</summary>
        IListTagsPaginator ListTags(ListTagsRequest request);
    }
}
#endif