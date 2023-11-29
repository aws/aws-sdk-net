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
 * Do not modify this file. This file is generated from the cleanroomsml-2023-09-06.normal.json service model.
 */

namespace Amazon.CleanRoomsML.Model
{
    /// <summary>
    /// Paginators for the CleanRoomsML service
    ///</summary>
    public interface ICleanRoomsMLPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListAudienceExportJobs operation
        ///</summary>
        IListAudienceExportJobsPaginator ListAudienceExportJobs(ListAudienceExportJobsRequest request);

        /// <summary>
        /// Paginator for ListAudienceGenerationJobs operation
        ///</summary>
        IListAudienceGenerationJobsPaginator ListAudienceGenerationJobs(ListAudienceGenerationJobsRequest request);

        /// <summary>
        /// Paginator for ListAudienceModels operation
        ///</summary>
        IListAudienceModelsPaginator ListAudienceModels(ListAudienceModelsRequest request);

        /// <summary>
        /// Paginator for ListConfiguredAudienceModels operation
        ///</summary>
        IListConfiguredAudienceModelsPaginator ListConfiguredAudienceModels(ListConfiguredAudienceModelsRequest request);

        /// <summary>
        /// Paginator for ListTrainingDatasets operation
        ///</summary>
        IListTrainingDatasetsPaginator ListTrainingDatasets(ListTrainingDatasetsRequest request);
    }
}