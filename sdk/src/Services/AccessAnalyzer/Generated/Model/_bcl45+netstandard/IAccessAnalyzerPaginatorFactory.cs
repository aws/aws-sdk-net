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

namespace Amazon.AccessAnalyzer.Model
{
    /// <summary>
    /// Paginators for the AccessAnalyzer service
    ///</summary>
    public interface IAccessAnalyzerPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListAccessPreviewFindings operation
        ///</summary>
        IListAccessPreviewFindingsPaginator ListAccessPreviewFindings(ListAccessPreviewFindingsRequest request);

        /// <summary>
        /// Paginator for ListAccessPreviews operation
        ///</summary>
        IListAccessPreviewsPaginator ListAccessPreviews(ListAccessPreviewsRequest request);

        /// <summary>
        /// Paginator for ListAnalyzedResources operation
        ///</summary>
        IListAnalyzedResourcesPaginator ListAnalyzedResources(ListAnalyzedResourcesRequest request);

        /// <summary>
        /// Paginator for ListAnalyzers operation
        ///</summary>
        IListAnalyzersPaginator ListAnalyzers(ListAnalyzersRequest request);

        /// <summary>
        /// Paginator for ListArchiveRules operation
        ///</summary>
        IListArchiveRulesPaginator ListArchiveRules(ListArchiveRulesRequest request);

        /// <summary>
        /// Paginator for ListFindings operation
        ///</summary>
        IListFindingsPaginator ListFindings(ListFindingsRequest request);

        /// <summary>
        /// Paginator for ListPolicyGenerations operation
        ///</summary>
        IListPolicyGenerationsPaginator ListPolicyGenerations(ListPolicyGenerationsRequest request);

        /// <summary>
        /// Paginator for ValidatePolicy operation
        ///</summary>
        IValidatePolicyPaginator ValidatePolicy(ValidatePolicyRequest request);
    }
}