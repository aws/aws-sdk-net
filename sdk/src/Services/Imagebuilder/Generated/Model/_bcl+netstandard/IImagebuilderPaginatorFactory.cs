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
using Amazon.Runtime.Internal;

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
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListComponentBuildVersionsPaginator ListComponentBuildVersions(ListComponentBuildVersionsRequest request);

        /// <summary>
        /// Paginator for ListComponents operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListComponentsPaginator ListComponents(ListComponentsRequest request);

        /// <summary>
        /// Paginator for ListContainerRecipes operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListContainerRecipesPaginator ListContainerRecipes(ListContainerRecipesRequest request);

        /// <summary>
        /// Paginator for ListDistributionConfigurations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListDistributionConfigurationsPaginator ListDistributionConfigurations(ListDistributionConfigurationsRequest request);

        /// <summary>
        /// Paginator for ListImageBuildVersions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListImageBuildVersionsPaginator ListImageBuildVersions(ListImageBuildVersionsRequest request);

        /// <summary>
        /// Paginator for ListImagePackages operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListImagePackagesPaginator ListImagePackages(ListImagePackagesRequest request);

        /// <summary>
        /// Paginator for ListImagePipelineImages operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListImagePipelineImagesPaginator ListImagePipelineImages(ListImagePipelineImagesRequest request);

        /// <summary>
        /// Paginator for ListImagePipelines operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListImagePipelinesPaginator ListImagePipelines(ListImagePipelinesRequest request);

        /// <summary>
        /// Paginator for ListImageRecipes operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListImageRecipesPaginator ListImageRecipes(ListImageRecipesRequest request);

        /// <summary>
        /// Paginator for ListImages operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListImagesPaginator ListImages(ListImagesRequest request);

        /// <summary>
        /// Paginator for ListImageScanFindingAggregations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            
            OutputToken = new[] { "NextToken" }
        )]
        IListImageScanFindingAggregationsPaginator ListImageScanFindingAggregations(ListImageScanFindingAggregationsRequest request);

        /// <summary>
        /// Paginator for ListImageScanFindings operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListImageScanFindingsPaginator ListImageScanFindings(ListImageScanFindingsRequest request);

        /// <summary>
        /// Paginator for ListInfrastructureConfigurations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListInfrastructureConfigurationsPaginator ListInfrastructureConfigurations(ListInfrastructureConfigurationsRequest request);

        /// <summary>
        /// Paginator for ListLifecycleExecutionResources operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListLifecycleExecutionResourcesPaginator ListLifecycleExecutionResources(ListLifecycleExecutionResourcesRequest request);

        /// <summary>
        /// Paginator for ListLifecycleExecutions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListLifecycleExecutionsPaginator ListLifecycleExecutions(ListLifecycleExecutionsRequest request);

        /// <summary>
        /// Paginator for ListLifecyclePolicies operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListLifecyclePoliciesPaginator ListLifecyclePolicies(ListLifecyclePoliciesRequest request);

        /// <summary>
        /// Paginator for ListWaitingWorkflowSteps operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListWaitingWorkflowStepsPaginator ListWaitingWorkflowSteps(ListWaitingWorkflowStepsRequest request);

        /// <summary>
        /// Paginator for ListWorkflowBuildVersions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListWorkflowBuildVersionsPaginator ListWorkflowBuildVersions(ListWorkflowBuildVersionsRequest request);

        /// <summary>
        /// Paginator for ListWorkflowExecutions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListWorkflowExecutionsPaginator ListWorkflowExecutions(ListWorkflowExecutionsRequest request);

        /// <summary>
        /// Paginator for ListWorkflows operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListWorkflowsPaginator ListWorkflows(ListWorkflowsRequest request);

        /// <summary>
        /// Paginator for ListWorkflowStepExecutions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListWorkflowStepExecutionsPaginator ListWorkflowStepExecutions(ListWorkflowStepExecutionsRequest request);
    }
}