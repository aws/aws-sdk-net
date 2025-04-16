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
 * Do not modify this file. This file is generated from the lookoutequipment-2020-12-15.normal.json service model.
 */
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.LookoutEquipment.Model
{
    /// <summary>
    /// Paginators for the LookoutEquipment service
    ///</summary>
    public interface ILookoutEquipmentPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListDataIngestionJobs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListDataIngestionJobsPaginator ListDataIngestionJobs(ListDataIngestionJobsRequest request);

        /// <summary>
        /// Paginator for ListDatasets operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListDatasetsPaginator ListDatasets(ListDatasetsRequest request);

        /// <summary>
        /// Paginator for ListInferenceEvents operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListInferenceEventsPaginator ListInferenceEvents(ListInferenceEventsRequest request);

        /// <summary>
        /// Paginator for ListInferenceExecutions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListInferenceExecutionsPaginator ListInferenceExecutions(ListInferenceExecutionsRequest request);

        /// <summary>
        /// Paginator for ListInferenceSchedulers operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListInferenceSchedulersPaginator ListInferenceSchedulers(ListInferenceSchedulersRequest request);

        /// <summary>
        /// Paginator for ListLabelGroups operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListLabelGroupsPaginator ListLabelGroups(ListLabelGroupsRequest request);

        /// <summary>
        /// Paginator for ListLabels operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListLabelsPaginator ListLabels(ListLabelsRequest request);

        /// <summary>
        /// Paginator for ListModels operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListModelsPaginator ListModels(ListModelsRequest request);

        /// <summary>
        /// Paginator for ListModelVersions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListModelVersionsPaginator ListModelVersions(ListModelVersionsRequest request);

        /// <summary>
        /// Paginator for ListRetrainingSchedulers operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListRetrainingSchedulersPaginator ListRetrainingSchedulers(ListRetrainingSchedulersRequest request);

        /// <summary>
        /// Paginator for ListSensorStatistics operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListSensorStatisticsPaginator ListSensorStatistics(ListSensorStatisticsRequest request);
    }
}