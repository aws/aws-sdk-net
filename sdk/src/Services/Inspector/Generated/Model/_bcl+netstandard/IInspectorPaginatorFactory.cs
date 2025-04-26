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
 * Do not modify this file. This file is generated from the inspector-2016-02-16.normal.json service model.
 */
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.Inspector.Model
{
    /// <summary>
    /// Paginators for the Inspector service
    ///</summary>
    public interface IInspectorPaginatorFactory
    {

        /// <summary>
        /// Paginator for GetExclusionsPreview operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetExclusionsPreviewPaginator GetExclusionsPreview(GetExclusionsPreviewRequest request);

        /// <summary>
        /// Paginator for ListAssessmentRunAgents operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAssessmentRunAgentsPaginator ListAssessmentRunAgents(ListAssessmentRunAgentsRequest request);

        /// <summary>
        /// Paginator for ListAssessmentRuns operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAssessmentRunsPaginator ListAssessmentRuns(ListAssessmentRunsRequest request);

        /// <summary>
        /// Paginator for ListAssessmentTargets operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAssessmentTargetsPaginator ListAssessmentTargets(ListAssessmentTargetsRequest request);

        /// <summary>
        /// Paginator for ListAssessmentTemplates operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAssessmentTemplatesPaginator ListAssessmentTemplates(ListAssessmentTemplatesRequest request);

        /// <summary>
        /// Paginator for ListEventSubscriptions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListEventSubscriptionsPaginator ListEventSubscriptions(ListEventSubscriptionsRequest request);

        /// <summary>
        /// Paginator for ListExclusions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListExclusionsPaginator ListExclusions(ListExclusionsRequest request);

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
        /// Paginator for ListRulesPackages operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListRulesPackagesPaginator ListRulesPackages(ListRulesPackagesRequest request);

        /// <summary>
        /// Paginator for PreviewAgents operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IPreviewAgentsPaginator PreviewAgents(PreviewAgentsRequest request);
    }
}