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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
#pragma warning disable CS0612,CS0618

namespace Amazon.PartnerCentralMarketing.Model
{
    /// <summary>
    /// Paginators for the PartnerCentralMarketing service
    /// </summary>
    public class PartnerCentralMarketingPaginatorFactory : IPartnerCentralMarketingPaginatorFactory
    {
        private readonly IAmazonPartnerCentralMarketing client;

        internal PartnerCentralMarketingPaginatorFactory(IAmazonPartnerCentralMarketing client)
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListCampaignAssets operation
        /// </summary>
        public IListCampaignAssetsPaginator ListCampaignAssets(ListCampaignAssetsRequest request)
        {
            return new ListCampaignAssetsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCampaigns operation
        /// </summary>
        public IListCampaignsPaginator ListCampaigns(ListCampaignsRequest request)
        {
            return new ListCampaignsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSocialConnections operation
        /// </summary>
        public IListSocialConnectionsPaginator ListSocialConnections(ListSocialConnectionsRequest request)
        {
            return new ListSocialConnectionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SearchCampaignTemplates operation
        /// </summary>
        public ISearchCampaignTemplatesPaginator SearchCampaignTemplates(SearchCampaignTemplatesRequest request)
        {
            return new SearchCampaignTemplatesPaginator(this.client, request);
        }
    }
}
