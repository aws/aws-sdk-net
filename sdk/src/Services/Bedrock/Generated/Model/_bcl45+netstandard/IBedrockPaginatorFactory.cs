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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
 */

#pragma warning disable CS0612,CS0618
namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Paginators for the Bedrock service
    ///</summary>
    public interface IBedrockPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListCustomModels operation
        ///</summary>
        IListCustomModelsPaginator ListCustomModels(ListCustomModelsRequest request);

        /// <summary>
        /// Paginator for ListEvaluationJobs operation
        ///</summary>
        IListEvaluationJobsPaginator ListEvaluationJobs(ListEvaluationJobsRequest request);

        /// <summary>
        /// Paginator for ListGuardrails operation
        ///</summary>
        IListGuardrailsPaginator ListGuardrails(ListGuardrailsRequest request);

        /// <summary>
        /// Paginator for ListImportedModels operation
        ///</summary>
        IListImportedModelsPaginator ListImportedModels(ListImportedModelsRequest request);

        /// <summary>
        /// Paginator for ListInferenceProfiles operation
        ///</summary>
        IListInferenceProfilesPaginator ListInferenceProfiles(ListInferenceProfilesRequest request);

        /// <summary>
        /// Paginator for ListMarketplaceModelEndpoints operation
        ///</summary>
        IListMarketplaceModelEndpointsPaginator ListMarketplaceModelEndpoints(ListMarketplaceModelEndpointsRequest request);

        /// <summary>
        /// Paginator for ListModelCopyJobs operation
        ///</summary>
        IListModelCopyJobsPaginator ListModelCopyJobs(ListModelCopyJobsRequest request);

        /// <summary>
        /// Paginator for ListModelCustomizationJobs operation
        ///</summary>
        IListModelCustomizationJobsPaginator ListModelCustomizationJobs(ListModelCustomizationJobsRequest request);

        /// <summary>
        /// Paginator for ListModelImportJobs operation
        ///</summary>
        IListModelImportJobsPaginator ListModelImportJobs(ListModelImportJobsRequest request);

        /// <summary>
        /// Paginator for ListModelInvocationJobs operation
        ///</summary>
        IListModelInvocationJobsPaginator ListModelInvocationJobs(ListModelInvocationJobsRequest request);

        /// <summary>
        /// Paginator for ListPromptRouters operation
        ///</summary>
        IListPromptRoutersPaginator ListPromptRouters(ListPromptRoutersRequest request);

        /// <summary>
        /// Paginator for ListProvisionedModelThroughputs operation
        ///</summary>
        IListProvisionedModelThroughputsPaginator ListProvisionedModelThroughputs(ListProvisionedModelThroughputsRequest request);
    }
}