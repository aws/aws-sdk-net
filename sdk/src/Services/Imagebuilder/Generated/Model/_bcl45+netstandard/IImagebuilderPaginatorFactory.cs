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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
 */

#pragma warning disable CS0612,CS0618
namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// Paginators for the Imagebuilder service
    ///</summary>
    public interface IImagebuilderPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListComponentBuildVersions operation
        ///</summary>
        IListComponentBuildVersionsPaginator ListComponentBuildVersions(ListComponentBuildVersionsRequest request);

        /// <summary>
        /// Paginator for ListComponents operation
        ///</summary>
        IListComponentsPaginator ListComponents(ListComponentsRequest request);

        /// <summary>
        /// Paginator for ListContainerRecipes operation
        ///</summary>
        IListContainerRecipesPaginator ListContainerRecipes(ListContainerRecipesRequest request);

        /// <summary>
        /// Paginator for ListDistributionConfigurations operation
        ///</summary>
        IListDistributionConfigurationsPaginator ListDistributionConfigurations(ListDistributionConfigurationsRequest request);

        /// <summary>
        /// Paginator for ListImageBuildVersions operation
        ///</summary>
        IListImageBuildVersionsPaginator ListImageBuildVersions(ListImageBuildVersionsRequest request);

        /// <summary>
        /// Paginator for ListImagePackages operation
        ///</summary>
        IListImagePackagesPaginator ListImagePackages(ListImagePackagesRequest request);

        /// <summary>
        /// Paginator for ListImagePipelineImages operation
        ///</summary>
        IListImagePipelineImagesPaginator ListImagePipelineImages(ListImagePipelineImagesRequest request);

        /// <summary>
        /// Paginator for ListImagePipelines operation
        ///</summary>
        IListImagePipelinesPaginator ListImagePipelines(ListImagePipelinesRequest request);

        /// <summary>
        /// Paginator for ListImageRecipes operation
        ///</summary>
        IListImageRecipesPaginator ListImageRecipes(ListImageRecipesRequest request);

        /// <summary>
        /// Paginator for ListImages operation
        ///</summary>
        IListImagesPaginator ListImages(ListImagesRequest request);

        /// <summary>
        /// Paginator for ListImageScanFindingAggregations operation
        ///</summary>
        IListImageScanFindingAggregationsPaginator ListImageScanFindingAggregations(ListImageScanFindingAggregationsRequest request);

        /// <summary>
        /// Paginator for ListImageScanFindings operation
        ///</summary>
        IListImageScanFindingsPaginator ListImageScanFindings(ListImageScanFindingsRequest request);

        /// <summary>
        /// Paginator for ListInfrastructureConfigurations operation
        ///</summary>
        IListInfrastructureConfigurationsPaginator ListInfrastructureConfigurations(ListInfrastructureConfigurationsRequest request);

        /// <summary>
        /// Paginator for ListLifecycleExecutionResources operation
        ///</summary>
        IListLifecycleExecutionResourcesPaginator ListLifecycleExecutionResources(ListLifecycleExecutionResourcesRequest request);

        /// <summary>
        /// Paginator for ListLifecycleExecutions operation
        ///</summary>
        IListLifecycleExecutionsPaginator ListLifecycleExecutions(ListLifecycleExecutionsRequest request);

        /// <summary>
        /// Paginator for ListLifecyclePolicies operation
        ///</summary>
        IListLifecyclePoliciesPaginator ListLifecyclePolicies(ListLifecyclePoliciesRequest request);

        /// <summary>
        /// Paginator for ListWaitingWorkflowSteps operation
        ///</summary>
        IListWaitingWorkflowStepsPaginator ListWaitingWorkflowSteps(ListWaitingWorkflowStepsRequest request);

        /// <summary>
        /// Paginator for ListWorkflowBuildVersions operation
        ///</summary>
        IListWorkflowBuildVersionsPaginator ListWorkflowBuildVersions(ListWorkflowBuildVersionsRequest request);

        /// <summary>
        /// Paginator for ListWorkflowExecutions operation
        ///</summary>
        IListWorkflowExecutionsPaginator ListWorkflowExecutions(ListWorkflowExecutionsRequest request);

        /// <summary>
        /// Paginator for ListWorkflows operation
        ///</summary>
        IListWorkflowsPaginator ListWorkflows(ListWorkflowsRequest request);

        /// <summary>
        /// Paginator for ListWorkflowStepExecutions operation
        ///</summary>
        IListWorkflowStepExecutionsPaginator ListWorkflowStepExecutions(ListWorkflowStepExecutionsRequest request);
    }
}