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

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.LookoutEquipment.Model
{
    /// <summary>
    /// Paginators for the LookoutEquipment service
    ///</summary>
    public class LookoutEquipmentPaginatorFactory : ILookoutEquipmentPaginatorFactory
    {
        private readonly IAmazonLookoutEquipment client;

        internal LookoutEquipmentPaginatorFactory(IAmazonLookoutEquipment client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListDataIngestionJobs operation
        ///</summary>
        public IListDataIngestionJobsPaginator ListDataIngestionJobs(ListDataIngestionJobsRequest request) 
        {
            return new ListDataIngestionJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDatasets operation
        ///</summary>
        public IListDatasetsPaginator ListDatasets(ListDatasetsRequest request) 
        {
            return new ListDatasetsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListInferenceEvents operation
        ///</summary>
        public IListInferenceEventsPaginator ListInferenceEvents(ListInferenceEventsRequest request) 
        {
            return new ListInferenceEventsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListInferenceExecutions operation
        ///</summary>
        public IListInferenceExecutionsPaginator ListInferenceExecutions(ListInferenceExecutionsRequest request) 
        {
            return new ListInferenceExecutionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListInferenceSchedulers operation
        ///</summary>
        public IListInferenceSchedulersPaginator ListInferenceSchedulers(ListInferenceSchedulersRequest request) 
        {
            return new ListInferenceSchedulersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListLabelGroups operation
        ///</summary>
        public IListLabelGroupsPaginator ListLabelGroups(ListLabelGroupsRequest request) 
        {
            return new ListLabelGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListLabels operation
        ///</summary>
        public IListLabelsPaginator ListLabels(ListLabelsRequest request) 
        {
            return new ListLabelsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListModels operation
        ///</summary>
        public IListModelsPaginator ListModels(ListModelsRequest request) 
        {
            return new ListModelsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListModelVersions operation
        ///</summary>
        public IListModelVersionsPaginator ListModelVersions(ListModelVersionsRequest request) 
        {
            return new ListModelVersionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRetrainingSchedulers operation
        ///</summary>
        public IListRetrainingSchedulersPaginator ListRetrainingSchedulers(ListRetrainingSchedulersRequest request) 
        {
            return new ListRetrainingSchedulersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSensorStatistics operation
        ///</summary>
        public IListSensorStatisticsPaginator ListSensorStatistics(ListSensorStatisticsRequest request) 
        {
            return new ListSensorStatisticsPaginator(this.client, request);
        }
    }
}