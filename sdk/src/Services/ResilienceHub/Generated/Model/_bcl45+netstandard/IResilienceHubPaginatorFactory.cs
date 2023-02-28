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
        IListAlarmRecommendationsPaginator ListAlarmRecommendations(ListAlarmRecommendationsRequest request);

        /// <summary>
        /// Paginator for ListAppAssessments operation
        ///</summary>
        IListAppAssessmentsPaginator ListAppAssessments(ListAppAssessmentsRequest request);

        /// <summary>
        /// Paginator for ListAppComponentCompliances operation
        ///</summary>
        IListAppComponentCompliancesPaginator ListAppComponentCompliances(ListAppComponentCompliancesRequest request);

        /// <summary>
        /// Paginator for ListAppComponentRecommendations operation
        ///</summary>
        IListAppComponentRecommendationsPaginator ListAppComponentRecommendations(ListAppComponentRecommendationsRequest request);

        /// <summary>
        /// Paginator for ListAppInputSources operation
        ///</summary>
        IListAppInputSourcesPaginator ListAppInputSources(ListAppInputSourcesRequest request);

        /// <summary>
        /// Paginator for ListApps operation
        ///</summary>
        IListAppsPaginator ListApps(ListAppsRequest request);

        /// <summary>
        /// Paginator for ListAppVersionAppComponents operation
        ///</summary>
        IListAppVersionAppComponentsPaginator ListAppVersionAppComponents(ListAppVersionAppComponentsRequest request);

        /// <summary>
        /// Paginator for ListAppVersionResourceMappings operation
        ///</summary>
        IListAppVersionResourceMappingsPaginator ListAppVersionResourceMappings(ListAppVersionResourceMappingsRequest request);

        /// <summary>
        /// Paginator for ListAppVersionResources operation
        ///</summary>
        IListAppVersionResourcesPaginator ListAppVersionResources(ListAppVersionResourcesRequest request);

        /// <summary>
        /// Paginator for ListAppVersions operation
        ///</summary>
        IListAppVersionsPaginator ListAppVersions(ListAppVersionsRequest request);

        /// <summary>
        /// Paginator for ListRecommendationTemplates operation
        ///</summary>
        IListRecommendationTemplatesPaginator ListRecommendationTemplates(ListRecommendationTemplatesRequest request);

        /// <summary>
        /// Paginator for ListResiliencyPolicies operation
        ///</summary>
        IListResiliencyPoliciesPaginator ListResiliencyPolicies(ListResiliencyPoliciesRequest request);

        /// <summary>
        /// Paginator for ListSopRecommendations operation
        ///</summary>
        IListSopRecommendationsPaginator ListSopRecommendations(ListSopRecommendationsRequest request);

        /// <summary>
        /// Paginator for ListSuggestedResiliencyPolicies operation
        ///</summary>
        IListSuggestedResiliencyPoliciesPaginator ListSuggestedResiliencyPolicies(ListSuggestedResiliencyPoliciesRequest request);

        /// <summary>
        /// Paginator for ListTestRecommendations operation
        ///</summary>
        IListTestRecommendationsPaginator ListTestRecommendations(ListTestRecommendationsRequest request);

        /// <summary>
        /// Paginator for ListUnsupportedAppVersionResources operation
        ///</summary>
        IListUnsupportedAppVersionResourcesPaginator ListUnsupportedAppVersionResources(ListUnsupportedAppVersionResourcesRequest request);
    }
}