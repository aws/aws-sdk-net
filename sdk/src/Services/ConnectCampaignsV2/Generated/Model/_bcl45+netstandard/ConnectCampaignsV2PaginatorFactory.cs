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
 * Do not modify this file. This file is generated from the connectcampaignsv2-2024-04-23.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.ConnectCampaignsV2.Model
{
    /// <summary>
    /// Paginators for the ConnectCampaignsV2 service
    ///</summary>
    public class ConnectCampaignsV2PaginatorFactory : IConnectCampaignsV2PaginatorFactory
    {
        private readonly IAmazonConnectCampaignsV2 client;

        internal ConnectCampaignsV2PaginatorFactory(IAmazonConnectCampaignsV2 client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListCampaigns operation
        ///</summary>
        public IListCampaignsPaginator ListCampaigns(ListCampaignsRequest request) 
        {
            return new ListCampaignsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListConnectInstanceIntegrations operation
        ///</summary>
        public IListConnectInstanceIntegrationsPaginator ListConnectInstanceIntegrations(ListConnectInstanceIntegrationsRequest request) 
        {
            return new ListConnectInstanceIntegrationsPaginator(this.client, request);
        }
    }
}