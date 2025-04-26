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
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.ECR.Model
{
    /// <summary>
    /// Paginators for the ECR service
    ///</summary>
    public interface IECRPaginatorFactory
    {

        /// <summary>
        /// Paginator for DescribeImages operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeImagesPaginator DescribeImages(DescribeImagesRequest request);

        /// <summary>
        /// Paginator for DescribeImageScanFindings operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeImageScanFindingsPaginator DescribeImageScanFindings(DescribeImageScanFindingsRequest request);

        /// <summary>
        /// Paginator for DescribePullThroughCacheRules operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribePullThroughCacheRulesPaginator DescribePullThroughCacheRules(DescribePullThroughCacheRulesRequest request);

        /// <summary>
        /// Paginator for DescribeRepositories operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeRepositoriesPaginator DescribeRepositories(DescribeRepositoriesRequest request);

        /// <summary>
        /// Paginator for DescribeRepositoryCreationTemplates operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeRepositoryCreationTemplatesPaginator DescribeRepositoryCreationTemplates(DescribeRepositoryCreationTemplatesRequest request);

        /// <summary>
        /// Paginator for GetLifecyclePolicyPreview operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetLifecyclePolicyPreviewPaginator GetLifecyclePolicyPreview(GetLifecyclePolicyPreviewRequest request);

        /// <summary>
        /// Paginator for ListImages operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListImagesPaginator ListImages(ListImagesRequest request);
    }
}