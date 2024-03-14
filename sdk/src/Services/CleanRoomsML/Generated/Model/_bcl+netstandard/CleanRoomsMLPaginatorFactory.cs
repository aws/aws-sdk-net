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

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.CleanRoomsML.Model
{
    /// <summary>
    /// Paginators for the CleanRoomsML service
    ///</summary>
    public class CleanRoomsMLPaginatorFactory : ICleanRoomsMLPaginatorFactory
    {
        private readonly IAmazonCleanRoomsML client;

        internal CleanRoomsMLPaginatorFactory(IAmazonCleanRoomsML client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListAudienceExportJobs operation
        ///</summary>
        public IListAudienceExportJobsPaginator ListAudienceExportJobs(ListAudienceExportJobsRequest request) 
        {
            return new ListAudienceExportJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAudienceGenerationJobs operation
        ///</summary>
        public IListAudienceGenerationJobsPaginator ListAudienceGenerationJobs(ListAudienceGenerationJobsRequest request) 
        {
            return new ListAudienceGenerationJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAudienceModels operation
        ///</summary>
        public IListAudienceModelsPaginator ListAudienceModels(ListAudienceModelsRequest request) 
        {
            return new ListAudienceModelsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListConfiguredAudienceModels operation
        ///</summary>
        public IListConfiguredAudienceModelsPaginator ListConfiguredAudienceModels(ListConfiguredAudienceModelsRequest request) 
        {
            return new ListConfiguredAudienceModelsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTrainingDatasets operation
        ///</summary>
        public IListTrainingDatasetsPaginator ListTrainingDatasets(ListTrainingDatasetsRequest request) 
        {
            return new ListTrainingDatasetsPaginator(this.client, request);
        }
    }
}