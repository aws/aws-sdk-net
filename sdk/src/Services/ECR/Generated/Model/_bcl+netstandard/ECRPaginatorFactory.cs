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
 * Do not modify this file. This file is generated from the ecr-2015-09-21.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.ECR.Model
{
    /// <summary>
    /// Paginators for the ECR service
    ///</summary>
    public class ECRPaginatorFactory : IECRPaginatorFactory
    {
        private readonly IAmazonECR client;

        internal ECRPaginatorFactory(IAmazonECR client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for DescribeImages operation
        ///</summary>
        public IDescribeImagesPaginator DescribeImages(DescribeImagesRequest request) 
        {
            return new DescribeImagesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeImageScanFindings operation
        ///</summary>
        public IDescribeImageScanFindingsPaginator DescribeImageScanFindings(DescribeImageScanFindingsRequest request) 
        {
            return new DescribeImageScanFindingsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribePullThroughCacheRules operation
        ///</summary>
        public IDescribePullThroughCacheRulesPaginator DescribePullThroughCacheRules(DescribePullThroughCacheRulesRequest request) 
        {
            return new DescribePullThroughCacheRulesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeRepositories operation
        ///</summary>
        public IDescribeRepositoriesPaginator DescribeRepositories(DescribeRepositoriesRequest request) 
        {
            return new DescribeRepositoriesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeRepositoryCreationTemplates operation
        ///</summary>
        public IDescribeRepositoryCreationTemplatesPaginator DescribeRepositoryCreationTemplates(DescribeRepositoryCreationTemplatesRequest request) 
        {
            return new DescribeRepositoryCreationTemplatesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetLifecyclePolicyPreview operation
        ///</summary>
        public IGetLifecyclePolicyPreviewPaginator GetLifecyclePolicyPreview(GetLifecyclePolicyPreviewRequest request) 
        {
            return new GetLifecyclePolicyPreviewPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListImages operation
        ///</summary>
        public IListImagesPaginator ListImages(ListImagesRequest request) 
        {
            return new ListImagesPaginator(this.client, request);
        }
    }
}