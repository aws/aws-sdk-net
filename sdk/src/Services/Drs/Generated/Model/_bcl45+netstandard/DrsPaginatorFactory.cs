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
 * Do not modify this file. This file is generated from the drs-2020-02-26.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.Drs.Model
{
    /// <summary>
    /// Paginators for the Drs service
    ///</summary>
    public class DrsPaginatorFactory : IDrsPaginatorFactory
    {
        private readonly IAmazonDrs client;

        internal DrsPaginatorFactory(IAmazonDrs client) 
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
        /// Paginator for DescribeRecoveryInstances operation
        ///</summary>
        public IDescribeRecoveryInstancesPaginator DescribeRecoveryInstances(DescribeRecoveryInstancesRequest request) 
        {
            return new DescribeRecoveryInstancesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeRecoverySnapshots operation
        ///</summary>
        public IDescribeRecoverySnapshotsPaginator DescribeRecoverySnapshots(DescribeRecoverySnapshotsRequest request) 
        {
            return new DescribeRecoverySnapshotsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeReplicationConfigurationTemplates operation
        ///</summary>
        public IDescribeReplicationConfigurationTemplatesPaginator DescribeReplicationConfigurationTemplates(DescribeReplicationConfigurationTemplatesRequest request) 
        {
            return new DescribeReplicationConfigurationTemplatesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeSourceNetworks operation
        ///</summary>
        public IDescribeSourceNetworksPaginator DescribeSourceNetworks(DescribeSourceNetworksRequest request) 
        {
            return new DescribeSourceNetworksPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeSourceServers operation
        ///</summary>
        public IDescribeSourceServersPaginator DescribeSourceServers(DescribeSourceServersRequest request) 
        {
            return new DescribeSourceServersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListExtensibleSourceServers operation
        ///</summary>
        public IListExtensibleSourceServersPaginator ListExtensibleSourceServers(ListExtensibleSourceServersRequest request) 
        {
            return new ListExtensibleSourceServersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListLaunchActions operation
        ///</summary>
        public IListLaunchActionsPaginator ListLaunchActions(ListLaunchActionsRequest request) 
        {
            return new ListLaunchActionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListStagingAccounts operation
        ///</summary>
        public IListStagingAccountsPaginator ListStagingAccounts(ListStagingAccountsRequest request) 
        {
            return new ListStagingAccountsPaginator(this.client, request);
        }
    }
}