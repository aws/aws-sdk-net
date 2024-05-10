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
 * Do not modify this file. This file is generated from the connectcampaigns-2021-01-30.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.ConnectCampaignService.Model
{
    /// <summary>
    /// Paginators for the ConnectCampaignService service
    ///</summary>
    public class ConnectCampaignServicePaginatorFactory : IConnectCampaignServicePaginatorFactory
    {
        private readonly IAmazonConnectCampaignService client;

        internal ConnectCampaignServicePaginatorFactory(IAmazonConnectCampaignService client) 
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
    }
}