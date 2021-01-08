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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.FSx.Model
{
    /// <summary>
    /// Paginators for the FSx service
    ///</summary>
    public class FSxPaginatorFactory : IFSxPaginatorFactory
    {
        private readonly IAmazonFSx client;

        internal FSxPaginatorFactory(IAmazonFSx client) 
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
        /// Paginator for DescribeDataRepositoryTasks operation
        ///</summary>
        public IDescribeDataRepositoryTasksPaginator DescribeDataRepositoryTasks(DescribeDataRepositoryTasksRequest request) 
        {
            return new DescribeDataRepositoryTasksPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeFileSystemAliases operation
        ///</summary>
        public IDescribeFileSystemAliasesPaginator DescribeFileSystemAliases(DescribeFileSystemAliasesRequest request) 
        {
            return new DescribeFileSystemAliasesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeFileSystems operation
        ///</summary>
        public IDescribeFileSystemsPaginator DescribeFileSystems(DescribeFileSystemsRequest request) 
        {
            return new DescribeFileSystemsPaginator(this.client, request);
        }
    }
}
#endif