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

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.AccessAnalyzer.Model
{
    /// <summary>
    /// Paginators for the AccessAnalyzer service
    ///</summary>
    public class AccessAnalyzerPaginatorFactory : IAccessAnalyzerPaginatorFactory
    {
        private readonly IAmazonAccessAnalyzer client;

        internal AccessAnalyzerPaginatorFactory(IAmazonAccessAnalyzer client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for GetFindingRecommendation operation
        ///</summary>
        public IGetFindingRecommendationPaginator GetFindingRecommendation(GetFindingRecommendationRequest request) 
        {
            return new GetFindingRecommendationPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetFindingV2 operation
        ///</summary>
        public IGetFindingV2Paginator GetFindingV2(GetFindingV2Request request) 
        {
            return new GetFindingV2Paginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAccessPreviewFindings operation
        ///</summary>
        public IListAccessPreviewFindingsPaginator ListAccessPreviewFindings(ListAccessPreviewFindingsRequest request) 
        {
            return new ListAccessPreviewFindingsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAccessPreviews operation
        ///</summary>
        public IListAccessPreviewsPaginator ListAccessPreviews(ListAccessPreviewsRequest request) 
        {
            return new ListAccessPreviewsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAnalyzedResources operation
        ///</summary>
        public IListAnalyzedResourcesPaginator ListAnalyzedResources(ListAnalyzedResourcesRequest request) 
        {
            return new ListAnalyzedResourcesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAnalyzers operation
        ///</summary>
        public IListAnalyzersPaginator ListAnalyzers(ListAnalyzersRequest request) 
        {
            return new ListAnalyzersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListArchiveRules operation
        ///</summary>
        public IListArchiveRulesPaginator ListArchiveRules(ListArchiveRulesRequest request) 
        {
            return new ListArchiveRulesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListFindings operation
        ///</summary>
        public IListFindingsPaginator ListFindings(ListFindingsRequest request) 
        {
            return new ListFindingsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListFindingsV2 operation
        ///</summary>
        public IListFindingsV2Paginator ListFindingsV2(ListFindingsV2Request request) 
        {
            return new ListFindingsV2Paginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPolicyGenerations operation
        ///</summary>
        public IListPolicyGenerationsPaginator ListPolicyGenerations(ListPolicyGenerationsRequest request) 
        {
            return new ListPolicyGenerationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ValidatePolicy operation
        ///</summary>
        public IValidatePolicyPaginator ValidatePolicy(ValidatePolicyRequest request) 
        {
            return new ValidatePolicyPaginator(this.client, request);
        }
    }
}