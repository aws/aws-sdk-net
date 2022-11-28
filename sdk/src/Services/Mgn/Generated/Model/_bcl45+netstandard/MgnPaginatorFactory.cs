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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.Mgn.Model
{
    /// <summary>
    /// Paginators for the Mgn service
    ///</summary>
    public class MgnPaginatorFactory : IMgnPaginatorFactory
    {
        private readonly IAmazonMgn client;

        internal MgnPaginatorFactory(IAmazonMgn client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for DescribeJobLogItems operation
        ///</summary>
        public IDescribeJobLogItemsPaginator DescribeJobLogItems(DescribeJobLogItemsRequest request) 
        {
            return new DescribeJobLogItemsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeJobs operation
        ///</summary>
        public IDescribeJobsPaginator DescribeJobs(DescribeJobsRequest request) 
        {
            return new DescribeJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeLaunchConfigurationTemplates operation
        ///</summary>
        public IDescribeLaunchConfigurationTemplatesPaginator DescribeLaunchConfigurationTemplates(DescribeLaunchConfigurationTemplatesRequest request) 
        {
            return new DescribeLaunchConfigurationTemplatesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeReplicationConfigurationTemplates operation
        ///</summary>
        public IDescribeReplicationConfigurationTemplatesPaginator DescribeReplicationConfigurationTemplates(DescribeReplicationConfigurationTemplatesRequest request) 
        {
            return new DescribeReplicationConfigurationTemplatesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeSourceServers operation
        ///</summary>
        public IDescribeSourceServersPaginator DescribeSourceServers(DescribeSourceServersRequest request) 
        {
            return new DescribeSourceServersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeVcenterClients operation
        ///</summary>
        public IDescribeVcenterClientsPaginator DescribeVcenterClients(DescribeVcenterClientsRequest request) 
        {
            return new DescribeVcenterClientsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListApplications operation
        ///</summary>
        public IListApplicationsPaginator ListApplications(ListApplicationsRequest request) 
        {
            return new ListApplicationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSourceServerActions operation
        ///</summary>
        public IListSourceServerActionsPaginator ListSourceServerActions(ListSourceServerActionsRequest request) 
        {
            return new ListSourceServerActionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTemplateActions operation
        ///</summary>
        public IListTemplateActionsPaginator ListTemplateActions(ListTemplateActionsRequest request) 
        {
            return new ListTemplateActionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListWaves operation
        ///</summary>
        public IListWavesPaginator ListWaves(ListWavesRequest request) 
        {
            return new ListWavesPaginator(this.client, request);
        }
    }
}