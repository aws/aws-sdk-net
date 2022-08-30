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
        IListDataIngestionJobsPaginator ListDataIngestionJobs(ListDataIngestionJobsRequest request);

        /// <summary>
        /// Paginator for ListDatasets operation
        ///</summary>
        IListDatasetsPaginator ListDatasets(ListDatasetsRequest request);

        /// <summary>
        /// Paginator for ListInferenceEvents operation
        ///</summary>
        IListInferenceEventsPaginator ListInferenceEvents(ListInferenceEventsRequest request);

        /// <summary>
        /// Paginator for ListInferenceExecutions operation
        ///</summary>
        IListInferenceExecutionsPaginator ListInferenceExecutions(ListInferenceExecutionsRequest request);

        /// <summary>
        /// Paginator for ListInferenceSchedulers operation
        ///</summary>
        IListInferenceSchedulersPaginator ListInferenceSchedulers(ListInferenceSchedulersRequest request);

        /// <summary>
        /// Paginator for ListLabelGroups operation
        ///</summary>
        IListLabelGroupsPaginator ListLabelGroups(ListLabelGroupsRequest request);

        /// <summary>
        /// Paginator for ListLabels operation
        ///</summary>
        IListLabelsPaginator ListLabels(ListLabelsRequest request);

        /// <summary>
        /// Paginator for ListModels operation
        ///</summary>
        IListModelsPaginator ListModels(ListModelsRequest request);

        /// <summary>
        /// Paginator for ListSensorStatistics operation
        ///</summary>
        IListSensorStatisticsPaginator ListSensorStatistics(ListSensorStatisticsRequest request);
    }
}