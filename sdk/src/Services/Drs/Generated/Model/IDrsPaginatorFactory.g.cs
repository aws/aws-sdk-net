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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618

namespace Amazon.Drs.Model
{
    /// <summary>
    /// Paginators for the Drs service
    /// </summary>
    public interface IDrsPaginatorFactory
    {
        /// <summary>
        /// Paginator for DescribeJobLogItems operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IDescribeJobLogItemsPaginator DescribeJobLogItems(DescribeJobLogItemsRequest request);

        /// <summary>
        /// Paginator for DescribeJobs operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IDescribeJobsPaginator DescribeJobs(DescribeJobsRequest request);

        /// <summary>
        /// Paginator for DescribeLaunchConfigurationTemplates operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IDescribeLaunchConfigurationTemplatesPaginator DescribeLaunchConfigurationTemplates(DescribeLaunchConfigurationTemplatesRequest request);

        /// <summary>
        /// Paginator for DescribeRecoveryInstances operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IDescribeRecoveryInstancesPaginator DescribeRecoveryInstances(DescribeRecoveryInstancesRequest request);

        /// <summary>
        /// Paginator for DescribeRecoverySnapshots operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IDescribeRecoverySnapshotsPaginator DescribeRecoverySnapshots(DescribeRecoverySnapshotsRequest request);

        /// <summary>
        /// Paginator for DescribeReplicationConfigurationTemplates operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IDescribeReplicationConfigurationTemplatesPaginator DescribeReplicationConfigurationTemplates(DescribeReplicationConfigurationTemplatesRequest request);

        /// <summary>
        /// Paginator for DescribeSourceNetworks operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IDescribeSourceNetworksPaginator DescribeSourceNetworks(DescribeSourceNetworksRequest request);

        /// <summary>
        /// Paginator for DescribeSourceServers operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IDescribeSourceServersPaginator DescribeSourceServers(DescribeSourceServersRequest request);

        /// <summary>
        /// Paginator for ListExtensibleSourceServers operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListExtensibleSourceServersPaginator ListExtensibleSourceServers(ListExtensibleSourceServersRequest request);

        /// <summary>
        /// Paginator for ListLaunchActions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListLaunchActionsPaginator ListLaunchActions(ListLaunchActionsRequest request);

        /// <summary>
        /// Paginator for ListRecoveryPlanExecutionSteps operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListRecoveryPlanExecutionStepsPaginator ListRecoveryPlanExecutionSteps(ListRecoveryPlanExecutionStepsRequest request);

        /// <summary>
        /// Paginator for ListRecoveryPlanExecutions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListRecoveryPlanExecutionsPaginator ListRecoveryPlanExecutions(ListRecoveryPlanExecutionsRequest request);

        /// <summary>
        /// Paginator for ListRecoveryPlanSteps operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListRecoveryPlanStepsPaginator ListRecoveryPlanSteps(ListRecoveryPlanStepsRequest request);

        /// <summary>
        /// Paginator for ListRecoveryPlans operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListRecoveryPlansPaginator ListRecoveryPlans(ListRecoveryPlansRequest request);

        /// <summary>
        /// Paginator for ListStagingAccounts operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListStagingAccountsPaginator ListStagingAccounts(ListStagingAccountsRequest request);
    }
}
