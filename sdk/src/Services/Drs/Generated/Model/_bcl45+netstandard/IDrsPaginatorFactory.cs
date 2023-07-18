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

namespace Amazon.Drs.Model
{
    /// <summary>
    /// Paginators for the Drs service
    ///</summary>
    public interface IDrsPaginatorFactory
    {

        /// <summary>
        /// Paginator for DescribeJobLogItems operation
        ///</summary>
        IDescribeJobLogItemsPaginator DescribeJobLogItems(DescribeJobLogItemsRequest request);

        /// <summary>
        /// Paginator for DescribeJobs operation
        ///</summary>
        IDescribeJobsPaginator DescribeJobs(DescribeJobsRequest request);

        /// <summary>
        /// Paginator for DescribeLaunchConfigurationTemplates operation
        ///</summary>
        IDescribeLaunchConfigurationTemplatesPaginator DescribeLaunchConfigurationTemplates(DescribeLaunchConfigurationTemplatesRequest request);

        /// <summary>
        /// Paginator for DescribeRecoveryInstances operation
        ///</summary>
        IDescribeRecoveryInstancesPaginator DescribeRecoveryInstances(DescribeRecoveryInstancesRequest request);

        /// <summary>
        /// Paginator for DescribeRecoverySnapshots operation
        ///</summary>
        IDescribeRecoverySnapshotsPaginator DescribeRecoverySnapshots(DescribeRecoverySnapshotsRequest request);

        /// <summary>
        /// Paginator for DescribeReplicationConfigurationTemplates operation
        ///</summary>
        IDescribeReplicationConfigurationTemplatesPaginator DescribeReplicationConfigurationTemplates(DescribeReplicationConfigurationTemplatesRequest request);

        /// <summary>
        /// Paginator for DescribeSourceNetworks operation
        ///</summary>
        IDescribeSourceNetworksPaginator DescribeSourceNetworks(DescribeSourceNetworksRequest request);

        /// <summary>
        /// Paginator for DescribeSourceServers operation
        ///</summary>
        IDescribeSourceServersPaginator DescribeSourceServers(DescribeSourceServersRequest request);

        /// <summary>
        /// Paginator for ListExtensibleSourceServers operation
        ///</summary>
        IListExtensibleSourceServersPaginator ListExtensibleSourceServers(ListExtensibleSourceServersRequest request);

        /// <summary>
        /// Paginator for ListStagingAccounts operation
        ///</summary>
        IListStagingAccountsPaginator ListStagingAccounts(ListStagingAccountsRequest request);
    }
}