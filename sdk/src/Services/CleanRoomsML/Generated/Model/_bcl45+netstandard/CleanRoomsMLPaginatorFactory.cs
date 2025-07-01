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

#pragma warning disable CS0612,CS0618
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
        /// Paginator for ListCollaborationConfiguredModelAlgorithmAssociations operation
        ///</summary>
        public IListCollaborationConfiguredModelAlgorithmAssociationsPaginator ListCollaborationConfiguredModelAlgorithmAssociations(ListCollaborationConfiguredModelAlgorithmAssociationsRequest request) 
        {
            return new ListCollaborationConfiguredModelAlgorithmAssociationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCollaborationMLInputChannels operation
        ///</summary>
        public IListCollaborationMLInputChannelsPaginator ListCollaborationMLInputChannels(ListCollaborationMLInputChannelsRequest request) 
        {
            return new ListCollaborationMLInputChannelsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCollaborationTrainedModelExportJobs operation
        ///</summary>
        public IListCollaborationTrainedModelExportJobsPaginator ListCollaborationTrainedModelExportJobs(ListCollaborationTrainedModelExportJobsRequest request) 
        {
            return new ListCollaborationTrainedModelExportJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCollaborationTrainedModelInferenceJobs operation
        ///</summary>
        public IListCollaborationTrainedModelInferenceJobsPaginator ListCollaborationTrainedModelInferenceJobs(ListCollaborationTrainedModelInferenceJobsRequest request) 
        {
            return new ListCollaborationTrainedModelInferenceJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCollaborationTrainedModels operation
        ///</summary>
        public IListCollaborationTrainedModelsPaginator ListCollaborationTrainedModels(ListCollaborationTrainedModelsRequest request) 
        {
            return new ListCollaborationTrainedModelsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListConfiguredAudienceModels operation
        ///</summary>
        public IListConfiguredAudienceModelsPaginator ListConfiguredAudienceModels(ListConfiguredAudienceModelsRequest request) 
        {
            return new ListConfiguredAudienceModelsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListConfiguredModelAlgorithmAssociations operation
        ///</summary>
        public IListConfiguredModelAlgorithmAssociationsPaginator ListConfiguredModelAlgorithmAssociations(ListConfiguredModelAlgorithmAssociationsRequest request) 
        {
            return new ListConfiguredModelAlgorithmAssociationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListConfiguredModelAlgorithms operation
        ///</summary>
        public IListConfiguredModelAlgorithmsPaginator ListConfiguredModelAlgorithms(ListConfiguredModelAlgorithmsRequest request) 
        {
            return new ListConfiguredModelAlgorithmsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListMLInputChannels operation
        ///</summary>
        public IListMLInputChannelsPaginator ListMLInputChannels(ListMLInputChannelsRequest request) 
        {
            return new ListMLInputChannelsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTrainedModelInferenceJobs operation
        ///</summary>
        public IListTrainedModelInferenceJobsPaginator ListTrainedModelInferenceJobs(ListTrainedModelInferenceJobsRequest request) 
        {
            return new ListTrainedModelInferenceJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTrainedModels operation
        ///</summary>
        public IListTrainedModelsPaginator ListTrainedModels(ListTrainedModelsRequest request) 
        {
            return new ListTrainedModelsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTrainedModelVersions operation
        ///</summary>
        public IListTrainedModelVersionsPaginator ListTrainedModelVersions(ListTrainedModelVersionsRequest request) 
        {
            return new ListTrainedModelVersionsPaginator(this.client, request);
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