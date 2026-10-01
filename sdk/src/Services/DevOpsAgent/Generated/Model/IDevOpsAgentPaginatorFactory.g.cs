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

namespace Amazon.DevOpsAgent.Model
{
    /// <summary>
    /// Paginators for the DevOpsAgent service
    /// </summary>
    public interface IDevOpsAgentPaginatorFactory
    {
        /// <summary>
        /// Paginator for ListAgentSpaces operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAgentSpacesPaginator ListAgentSpaces(ListAgentSpacesRequest request);

        /// <summary>
        /// Paginator for ListAssetFiles operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAssetFilesPaginator ListAssetFiles(ListAssetFilesRequest request);

        /// <summary>
        /// Paginator for ListAssetTypes operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAssetTypesPaginator ListAssetTypes(ListAssetTypesRequest request);

        /// <summary>
        /// Paginator for ListAssetVersions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAssetVersionsPaginator ListAssetVersions(ListAssetVersionsRequest request);

        /// <summary>
        /// Paginator for ListAssets operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAssetsPaginator ListAssets(ListAssetsRequest request);

        /// <summary>
        /// Paginator for ListAssociations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAssociationsPaginator ListAssociations(ListAssociationsRequest request);

        /// <summary>
        /// Paginator for ListBacklogTasks operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "Limit", OutputToken = ["NextToken"])]
        IListBacklogTasksPaginator ListBacklogTasks(ListBacklogTasksRequest request);

        /// <summary>
        /// Paginator for ListExecutions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "Limit", OutputToken = ["NextToken"])]
        IListExecutionsPaginator ListExecutions(ListExecutionsRequest request);

        /// <summary>
        /// Paginator for ListGoals operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "Limit", OutputToken = ["NextToken"])]
        IListGoalsPaginator ListGoals(ListGoalsRequest request);

        /// <summary>
        /// Paginator for ListJournalRecords operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "Limit", OutputToken = ["NextToken"])]
        IListJournalRecordsPaginator ListJournalRecords(ListJournalRecordsRequest request);

        /// <summary>
        /// Paginator for ListServices operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListServicesPaginator ListServices(ListServicesRequest request);

        /// <summary>
        /// Paginator for ListTriggers operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListTriggersPaginator ListTriggers(ListTriggersRequest request);
    }
}
