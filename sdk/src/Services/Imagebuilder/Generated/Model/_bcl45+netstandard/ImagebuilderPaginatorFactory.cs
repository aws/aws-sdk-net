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

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// Paginators for the Imagebuilder service
    ///</summary>
    public class ImagebuilderPaginatorFactory : IImagebuilderPaginatorFactory
    {
        private readonly IAmazonImagebuilder client;

        internal ImagebuilderPaginatorFactory(IAmazonImagebuilder client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListComponentBuildVersions operation
        ///</summary>
        public IListComponentBuildVersionsPaginator ListComponentBuildVersions(ListComponentBuildVersionsRequest request) 
        {
            return new ListComponentBuildVersionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListComponents operation
        ///</summary>
        public IListComponentsPaginator ListComponents(ListComponentsRequest request) 
        {
            return new ListComponentsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListContainerRecipes operation
        ///</summary>
        public IListContainerRecipesPaginator ListContainerRecipes(ListContainerRecipesRequest request) 
        {
            return new ListContainerRecipesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDistributionConfigurations operation
        ///</summary>
        public IListDistributionConfigurationsPaginator ListDistributionConfigurations(ListDistributionConfigurationsRequest request) 
        {
            return new ListDistributionConfigurationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListImageBuildVersions operation
        ///</summary>
        public IListImageBuildVersionsPaginator ListImageBuildVersions(ListImageBuildVersionsRequest request) 
        {
            return new ListImageBuildVersionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListImagePackages operation
        ///</summary>
        public IListImagePackagesPaginator ListImagePackages(ListImagePackagesRequest request) 
        {
            return new ListImagePackagesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListImagePipelineImages operation
        ///</summary>
        public IListImagePipelineImagesPaginator ListImagePipelineImages(ListImagePipelineImagesRequest request) 
        {
            return new ListImagePipelineImagesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListImagePipelines operation
        ///</summary>
        public IListImagePipelinesPaginator ListImagePipelines(ListImagePipelinesRequest request) 
        {
            return new ListImagePipelinesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListImageRecipes operation
        ///</summary>
        public IListImageRecipesPaginator ListImageRecipes(ListImageRecipesRequest request) 
        {
            return new ListImageRecipesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListImages operation
        ///</summary>
        public IListImagesPaginator ListImages(ListImagesRequest request) 
        {
            return new ListImagesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListImageScanFindingAggregations operation
        ///</summary>
        public IListImageScanFindingAggregationsPaginator ListImageScanFindingAggregations(ListImageScanFindingAggregationsRequest request) 
        {
            return new ListImageScanFindingAggregationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListImageScanFindings operation
        ///</summary>
        public IListImageScanFindingsPaginator ListImageScanFindings(ListImageScanFindingsRequest request) 
        {
            return new ListImageScanFindingsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListInfrastructureConfigurations operation
        ///</summary>
        public IListInfrastructureConfigurationsPaginator ListInfrastructureConfigurations(ListInfrastructureConfigurationsRequest request) 
        {
            return new ListInfrastructureConfigurationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListWorkflowExecutions operation
        ///</summary>
        public IListWorkflowExecutionsPaginator ListWorkflowExecutions(ListWorkflowExecutionsRequest request) 
        {
            return new ListWorkflowExecutionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListWorkflowStepExecutions operation
        ///</summary>
        public IListWorkflowStepExecutionsPaginator ListWorkflowStepExecutions(ListWorkflowStepExecutionsRequest request) 
        {
            return new ListWorkflowStepExecutionsPaginator(this.client, request);
        }
    }
}