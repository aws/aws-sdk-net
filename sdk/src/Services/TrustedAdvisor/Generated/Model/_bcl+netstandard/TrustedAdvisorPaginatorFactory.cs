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
 * Do not modify this file. This file is generated from the trustedadvisor-2022-09-15.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.TrustedAdvisor.Model
{
    /// <summary>
    /// Paginators for the TrustedAdvisor service
    ///</summary>
    public class TrustedAdvisorPaginatorFactory : ITrustedAdvisorPaginatorFactory
    {
        private readonly IAmazonTrustedAdvisor client;

        internal TrustedAdvisorPaginatorFactory(IAmazonTrustedAdvisor client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListChecks operation
        ///</summary>
        public IListChecksPaginator ListChecks(ListChecksRequest request) 
        {
            return new ListChecksPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListOrganizationRecommendationAccounts operation
        ///</summary>
        public IListOrganizationRecommendationAccountsPaginator ListOrganizationRecommendationAccounts(ListOrganizationRecommendationAccountsRequest request) 
        {
            return new ListOrganizationRecommendationAccountsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListOrganizationRecommendationResources operation
        ///</summary>
        public IListOrganizationRecommendationResourcesPaginator ListOrganizationRecommendationResources(ListOrganizationRecommendationResourcesRequest request) 
        {
            return new ListOrganizationRecommendationResourcesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListOrganizationRecommendations operation
        ///</summary>
        public IListOrganizationRecommendationsPaginator ListOrganizationRecommendations(ListOrganizationRecommendationsRequest request) 
        {
            return new ListOrganizationRecommendationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRecommendationResources operation
        ///</summary>
        public IListRecommendationResourcesPaginator ListRecommendationResources(ListRecommendationResourcesRequest request) 
        {
            return new ListRecommendationResourcesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRecommendations operation
        ///</summary>
        public IListRecommendationsPaginator ListRecommendations(ListRecommendationsRequest request) 
        {
            return new ListRecommendationsPaginator(this.client, request);
        }
    }
}