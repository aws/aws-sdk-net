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
 * Do not modify this file. This file is generated from the accessanalyzer-2019-11-01.normal.json service model.
 */
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.AccessAnalyzer.Model
{
    /// <summary>
    /// Paginators for the AccessAnalyzer service
    ///</summary>
    public interface IAccessAnalyzerPaginatorFactory
    {

        /// <summary>
        /// Paginator for GetFindingRecommendation operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetFindingRecommendationPaginator GetFindingRecommendation(GetFindingRecommendationRequest request);

        /// <summary>
        /// Paginator for GetFindingV2 operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetFindingV2Paginator GetFindingV2(GetFindingV2Request request);

        /// <summary>
        /// Paginator for ListAccessPreviewFindings operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAccessPreviewFindingsPaginator ListAccessPreviewFindings(ListAccessPreviewFindingsRequest request);

        /// <summary>
        /// Paginator for ListAccessPreviews operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAccessPreviewsPaginator ListAccessPreviews(ListAccessPreviewsRequest request);

        /// <summary>
        /// Paginator for ListAnalyzedResources operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAnalyzedResourcesPaginator ListAnalyzedResources(ListAnalyzedResourcesRequest request);

        /// <summary>
        /// Paginator for ListAnalyzers operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAnalyzersPaginator ListAnalyzers(ListAnalyzersRequest request);

        /// <summary>
        /// Paginator for ListArchiveRules operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListArchiveRulesPaginator ListArchiveRules(ListArchiveRulesRequest request);

        /// <summary>
        /// Paginator for ListFindings operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListFindingsPaginator ListFindings(ListFindingsRequest request);

        /// <summary>
        /// Paginator for ListFindingsV2 operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListFindingsV2Paginator ListFindingsV2(ListFindingsV2Request request);

        /// <summary>
        /// Paginator for ListPolicyGenerations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListPolicyGenerationsPaginator ListPolicyGenerations(ListPolicyGenerationsRequest request);

        /// <summary>
        /// Paginator for ValidatePolicy operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IValidatePolicyPaginator ValidatePolicy(ValidatePolicyRequest request);
    }
}