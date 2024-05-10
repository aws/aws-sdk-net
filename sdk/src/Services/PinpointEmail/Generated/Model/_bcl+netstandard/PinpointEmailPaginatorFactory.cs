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
 * Do not modify this file. This file is generated from the pinpoint-email-2018-07-26.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.PinpointEmail.Model
{
    /// <summary>
    /// Paginators for the PinpointEmail service
    ///</summary>
    public class PinpointEmailPaginatorFactory : IPinpointEmailPaginatorFactory
    {
        private readonly IAmazonPinpointEmail client;

        internal PinpointEmailPaginatorFactory(IAmazonPinpointEmail client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for GetDedicatedIps operation
        ///</summary>
        public IGetDedicatedIpsPaginator GetDedicatedIps(GetDedicatedIpsRequest request) 
        {
            return new GetDedicatedIpsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListConfigurationSets operation
        ///</summary>
        public IListConfigurationSetsPaginator ListConfigurationSets(ListConfigurationSetsRequest request) 
        {
            return new ListConfigurationSetsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDedicatedIpPools operation
        ///</summary>
        public IListDedicatedIpPoolsPaginator ListDedicatedIpPools(ListDedicatedIpPoolsRequest request) 
        {
            return new ListDedicatedIpPoolsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDeliverabilityTestReports operation
        ///</summary>
        public IListDeliverabilityTestReportsPaginator ListDeliverabilityTestReports(ListDeliverabilityTestReportsRequest request) 
        {
            return new ListDeliverabilityTestReportsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDomainDeliverabilityCampaigns operation
        ///</summary>
        public IListDomainDeliverabilityCampaignsPaginator ListDomainDeliverabilityCampaigns(ListDomainDeliverabilityCampaignsRequest request) 
        {
            return new ListDomainDeliverabilityCampaignsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListEmailIdentities operation
        ///</summary>
        public IListEmailIdentitiesPaginator ListEmailIdentities(ListEmailIdentitiesRequest request) 
        {
            return new ListEmailIdentitiesPaginator(this.client, request);
        }
    }
}