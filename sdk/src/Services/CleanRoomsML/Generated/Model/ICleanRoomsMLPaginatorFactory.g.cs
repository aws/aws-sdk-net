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

namespace Amazon.CleanRoomsML.Model
{
    /// <summary>
    /// Paginators for the CleanRoomsML service
    /// </summary>
    public interface ICleanRoomsMLPaginatorFactory
    {
        /// <summary>
        /// Paginator for ListAudienceExportJobs operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAudienceExportJobsPaginator ListAudienceExportJobs(ListAudienceExportJobsRequest request);

        /// <summary>
        /// Paginator for ListAudienceGenerationJobs operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAudienceGenerationJobsPaginator ListAudienceGenerationJobs(ListAudienceGenerationJobsRequest request);

        /// <summary>
        /// Paginator for ListAudienceModels operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAudienceModelsPaginator ListAudienceModels(ListAudienceModelsRequest request);

        /// <summary>
        /// Paginator for ListCollaborationConfiguredModelAlgorithmAssociations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListCollaborationConfiguredModelAlgorithmAssociationsPaginator ListCollaborationConfiguredModelAlgorithmAssociations(ListCollaborationConfiguredModelAlgorithmAssociationsRequest request);

        /// <summary>
        /// Paginator for ListCollaborationMLInputChannels operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListCollaborationMLInputChannelsPaginator ListCollaborationMLInputChannels(ListCollaborationMLInputChannelsRequest request);

        /// <summary>
        /// Paginator for ListCollaborationTrainedModelExportJobs operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListCollaborationTrainedModelExportJobsPaginator ListCollaborationTrainedModelExportJobs(ListCollaborationTrainedModelExportJobsRequest request);

        /// <summary>
        /// Paginator for ListCollaborationTrainedModelInferenceJobs operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListCollaborationTrainedModelInferenceJobsPaginator ListCollaborationTrainedModelInferenceJobs(ListCollaborationTrainedModelInferenceJobsRequest request);

        /// <summary>
        /// Paginator for ListCollaborationTrainedModels operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListCollaborationTrainedModelsPaginator ListCollaborationTrainedModels(ListCollaborationTrainedModelsRequest request);

        /// <summary>
        /// Paginator for ListConfiguredAudienceModels operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListConfiguredAudienceModelsPaginator ListConfiguredAudienceModels(ListConfiguredAudienceModelsRequest request);

        /// <summary>
        /// Paginator for ListConfiguredModelAlgorithmAssociations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListConfiguredModelAlgorithmAssociationsPaginator ListConfiguredModelAlgorithmAssociations(ListConfiguredModelAlgorithmAssociationsRequest request);

        /// <summary>
        /// Paginator for ListConfiguredModelAlgorithms operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListConfiguredModelAlgorithmsPaginator ListConfiguredModelAlgorithms(ListConfiguredModelAlgorithmsRequest request);

        /// <summary>
        /// Paginator for ListMLInputChannels operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListMLInputChannelsPaginator ListMLInputChannels(ListMLInputChannelsRequest request);

        /// <summary>
        /// Paginator for ListTrainedModelInferenceJobs operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListTrainedModelInferenceJobsPaginator ListTrainedModelInferenceJobs(ListTrainedModelInferenceJobsRequest request);

        /// <summary>
        /// Paginator for ListTrainedModelVersions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListTrainedModelVersionsPaginator ListTrainedModelVersions(ListTrainedModelVersionsRequest request);

        /// <summary>
        /// Paginator for ListTrainedModels operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListTrainedModelsPaginator ListTrainedModels(ListTrainedModelsRequest request);

        /// <summary>
        /// Paginator for ListTrainingDatasets operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListTrainingDatasetsPaginator ListTrainingDatasets(ListTrainingDatasetsRequest request);
    }
}
