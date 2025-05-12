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
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
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
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeJobLogItemsPaginator DescribeJobLogItems(DescribeJobLogItemsRequest request);

        /// <summary>
        /// Paginator for DescribeJobs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeJobsPaginator DescribeJobs(DescribeJobsRequest request);

        /// <summary>
        /// Paginator for DescribeLaunchConfigurationTemplates operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeLaunchConfigurationTemplatesPaginator DescribeLaunchConfigurationTemplates(DescribeLaunchConfigurationTemplatesRequest request);

        /// <summary>
        /// Paginator for DescribeRecoveryInstances operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeRecoveryInstancesPaginator DescribeRecoveryInstances(DescribeRecoveryInstancesRequest request);

        /// <summary>
        /// Paginator for DescribeRecoverySnapshots operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeRecoverySnapshotsPaginator DescribeRecoverySnapshots(DescribeRecoverySnapshotsRequest request);

        /// <summary>
        /// Paginator for DescribeReplicationConfigurationTemplates operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeReplicationConfigurationTemplatesPaginator DescribeReplicationConfigurationTemplates(DescribeReplicationConfigurationTemplatesRequest request);

        /// <summary>
        /// Paginator for DescribeSourceNetworks operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeSourceNetworksPaginator DescribeSourceNetworks(DescribeSourceNetworksRequest request);

        /// <summary>
        /// Paginator for DescribeSourceServers operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeSourceServersPaginator DescribeSourceServers(DescribeSourceServersRequest request);

        /// <summary>
        /// Paginator for ListExtensibleSourceServers operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListExtensibleSourceServersPaginator ListExtensibleSourceServers(ListExtensibleSourceServersRequest request);

        /// <summary>
        /// Paginator for ListLaunchActions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListLaunchActionsPaginator ListLaunchActions(ListLaunchActionsRequest request);

        /// <summary>
        /// Paginator for ListStagingAccounts operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListStagingAccountsPaginator ListStagingAccounts(ListStagingAccountsRequest request);
    }
}