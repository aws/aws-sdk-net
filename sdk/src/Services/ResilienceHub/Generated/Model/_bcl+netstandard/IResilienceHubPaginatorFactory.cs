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
 * Do not modify this file. This file is generated from the resiliencehub-2020-04-30.normal.json service model.
 */
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.ResilienceHub.Model
{
    /// <summary>
    /// Paginators for the ResilienceHub service
    ///</summary>
    public interface IResilienceHubPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListAlarmRecommendations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAlarmRecommendationsPaginator ListAlarmRecommendations(ListAlarmRecommendationsRequest request);

        /// <summary>
        /// Paginator for ListAppAssessmentComplianceDrifts operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAppAssessmentComplianceDriftsPaginator ListAppAssessmentComplianceDrifts(ListAppAssessmentComplianceDriftsRequest request);

        /// <summary>
        /// Paginator for ListAppAssessmentResourceDrifts operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAppAssessmentResourceDriftsPaginator ListAppAssessmentResourceDrifts(ListAppAssessmentResourceDriftsRequest request);

        /// <summary>
        /// Paginator for ListAppAssessments operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAppAssessmentsPaginator ListAppAssessments(ListAppAssessmentsRequest request);

        /// <summary>
        /// Paginator for ListAppComponentCompliances operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAppComponentCompliancesPaginator ListAppComponentCompliances(ListAppComponentCompliancesRequest request);

        /// <summary>
        /// Paginator for ListAppComponentRecommendations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAppComponentRecommendationsPaginator ListAppComponentRecommendations(ListAppComponentRecommendationsRequest request);

        /// <summary>
        /// Paginator for ListAppInputSources operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAppInputSourcesPaginator ListAppInputSources(ListAppInputSourcesRequest request);

        /// <summary>
        /// Paginator for ListApps operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAppsPaginator ListApps(ListAppsRequest request);

        /// <summary>
        /// Paginator for ListAppVersionAppComponents operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAppVersionAppComponentsPaginator ListAppVersionAppComponents(ListAppVersionAppComponentsRequest request);

        /// <summary>
        /// Paginator for ListAppVersionResourceMappings operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAppVersionResourceMappingsPaginator ListAppVersionResourceMappings(ListAppVersionResourceMappingsRequest request);

        /// <summary>
        /// Paginator for ListAppVersionResources operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAppVersionResourcesPaginator ListAppVersionResources(ListAppVersionResourcesRequest request);

        /// <summary>
        /// Paginator for ListAppVersions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAppVersionsPaginator ListAppVersions(ListAppVersionsRequest request);

        /// <summary>
        /// Paginator for ListMetrics operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListMetricsPaginator ListMetrics(ListMetricsRequest request);

        /// <summary>
        /// Paginator for ListRecommendationTemplates operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListRecommendationTemplatesPaginator ListRecommendationTemplates(ListRecommendationTemplatesRequest request);

        /// <summary>
        /// Paginator for ListResiliencyPolicies operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListResiliencyPoliciesPaginator ListResiliencyPolicies(ListResiliencyPoliciesRequest request);

        /// <summary>
        /// Paginator for ListResourceGroupingRecommendations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListResourceGroupingRecommendationsPaginator ListResourceGroupingRecommendations(ListResourceGroupingRecommendationsRequest request);

        /// <summary>
        /// Paginator for ListSopRecommendations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListSopRecommendationsPaginator ListSopRecommendations(ListSopRecommendationsRequest request);

        /// <summary>
        /// Paginator for ListSuggestedResiliencyPolicies operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListSuggestedResiliencyPoliciesPaginator ListSuggestedResiliencyPolicies(ListSuggestedResiliencyPoliciesRequest request);

        /// <summary>
        /// Paginator for ListTestRecommendations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListTestRecommendationsPaginator ListTestRecommendations(ListTestRecommendationsRequest request);

        /// <summary>
        /// Paginator for ListUnsupportedAppVersionResources operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListUnsupportedAppVersionResourcesPaginator ListUnsupportedAppVersionResources(ListUnsupportedAppVersionResourcesRequest request);
    }
}