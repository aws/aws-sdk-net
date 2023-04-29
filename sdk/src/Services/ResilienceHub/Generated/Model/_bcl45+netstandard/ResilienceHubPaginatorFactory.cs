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

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.ResilienceHub.Model
{
    /// <summary>
    /// Paginators for the ResilienceHub service
    ///</summary>
    public class ResilienceHubPaginatorFactory : IResilienceHubPaginatorFactory
    {
        private readonly IAmazonResilienceHub client;

        internal ResilienceHubPaginatorFactory(IAmazonResilienceHub client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListAlarmRecommendations operation
        ///</summary>
        public IListAlarmRecommendationsPaginator ListAlarmRecommendations(ListAlarmRecommendationsRequest request) 
        {
            return new ListAlarmRecommendationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAppAssessments operation
        ///</summary>
        public IListAppAssessmentsPaginator ListAppAssessments(ListAppAssessmentsRequest request) 
        {
            return new ListAppAssessmentsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAppComponentCompliances operation
        ///</summary>
        public IListAppComponentCompliancesPaginator ListAppComponentCompliances(ListAppComponentCompliancesRequest request) 
        {
            return new ListAppComponentCompliancesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAppComponentRecommendations operation
        ///</summary>
        public IListAppComponentRecommendationsPaginator ListAppComponentRecommendations(ListAppComponentRecommendationsRequest request) 
        {
            return new ListAppComponentRecommendationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAppInputSources operation
        ///</summary>
        public IListAppInputSourcesPaginator ListAppInputSources(ListAppInputSourcesRequest request) 
        {
            return new ListAppInputSourcesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListApps operation
        ///</summary>
        public IListAppsPaginator ListApps(ListAppsRequest request) 
        {
            return new ListAppsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAppVersionAppComponents operation
        ///</summary>
        public IListAppVersionAppComponentsPaginator ListAppVersionAppComponents(ListAppVersionAppComponentsRequest request) 
        {
            return new ListAppVersionAppComponentsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAppVersionResourceMappings operation
        ///</summary>
        public IListAppVersionResourceMappingsPaginator ListAppVersionResourceMappings(ListAppVersionResourceMappingsRequest request) 
        {
            return new ListAppVersionResourceMappingsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAppVersionResources operation
        ///</summary>
        public IListAppVersionResourcesPaginator ListAppVersionResources(ListAppVersionResourcesRequest request) 
        {
            return new ListAppVersionResourcesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAppVersions operation
        ///</summary>
        public IListAppVersionsPaginator ListAppVersions(ListAppVersionsRequest request) 
        {
            return new ListAppVersionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRecommendationTemplates operation
        ///</summary>
        public IListRecommendationTemplatesPaginator ListRecommendationTemplates(ListRecommendationTemplatesRequest request) 
        {
            return new ListRecommendationTemplatesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListResiliencyPolicies operation
        ///</summary>
        public IListResiliencyPoliciesPaginator ListResiliencyPolicies(ListResiliencyPoliciesRequest request) 
        {
            return new ListResiliencyPoliciesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSopRecommendations operation
        ///</summary>
        public IListSopRecommendationsPaginator ListSopRecommendations(ListSopRecommendationsRequest request) 
        {
            return new ListSopRecommendationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSuggestedResiliencyPolicies operation
        ///</summary>
        public IListSuggestedResiliencyPoliciesPaginator ListSuggestedResiliencyPolicies(ListSuggestedResiliencyPoliciesRequest request) 
        {
            return new ListSuggestedResiliencyPoliciesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTestRecommendations operation
        ///</summary>
        public IListTestRecommendationsPaginator ListTestRecommendations(ListTestRecommendationsRequest request) 
        {
            return new ListTestRecommendationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListUnsupportedAppVersionResources operation
        ///</summary>
        public IListUnsupportedAppVersionResourcesPaginator ListUnsupportedAppVersionResources(ListUnsupportedAppVersionResourcesRequest request) 
        {
            return new ListUnsupportedAppVersionResourcesPaginator(this.client, request);
        }
    }
}