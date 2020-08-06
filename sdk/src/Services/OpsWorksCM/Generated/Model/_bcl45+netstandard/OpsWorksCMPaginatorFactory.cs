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
 * Do not modify this file. This file is generated from the opsworkscm-2016-11-01.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.OpsWorksCM.Model
{
    /// <summary>
    /// Paginators for the OpsWorksCM service
    ///</summary>
    public class OpsWorksCMPaginatorFactory : IOpsWorksCMPaginatorFactory
    {
        private readonly IAmazonOpsWorksCM client;

        internal OpsWorksCMPaginatorFactory(IAmazonOpsWorksCM client) 
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
        /// Paginator for DescribeEvents operation
        ///</summary>
        public IDescribeEventsPaginator DescribeEvents(DescribeEventsRequest request) 
        {
            return new DescribeEventsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeServers operation
        ///</summary>
        public IDescribeServersPaginator DescribeServers(DescribeServersRequest request) 
        {
            return new DescribeServersPaginator(this.client, request);
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
#endif