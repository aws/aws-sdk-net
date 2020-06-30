#if !NETSTANDARD13
/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.PinpointEmail.Model
{
    /// <summary>
    /// Paginators for the PinpointEmail service
    ///</summary>
    public interface IPinpointEmailPaginatorFactory
    {

        /// <summary>
        /// Paginator for GetDedicatedIps operation
        ///</summary>
        IGetDedicatedIpsPaginator GetDedicatedIps(GetDedicatedIpsRequest request);

        /// <summary>
        /// Paginator for ListConfigurationSets operation
        ///</summary>
        IListConfigurationSetsPaginator ListConfigurationSets(ListConfigurationSetsRequest request);

        /// <summary>
        /// Paginator for ListDedicatedIpPools operation
        ///</summary>
        IListDedicatedIpPoolsPaginator ListDedicatedIpPools(ListDedicatedIpPoolsRequest request);

        /// <summary>
        /// Paginator for ListDeliverabilityTestReports operation
        ///</summary>
        IListDeliverabilityTestReportsPaginator ListDeliverabilityTestReports(ListDeliverabilityTestReportsRequest request);

        /// <summary>
        /// Paginator for ListDomainDeliverabilityCampaigns operation
        ///</summary>
        IListDomainDeliverabilityCampaignsPaginator ListDomainDeliverabilityCampaigns(ListDomainDeliverabilityCampaignsRequest request);

        /// <summary>
        /// Paginator for ListEmailIdentities operation
        ///</summary>
        IListEmailIdentitiesPaginator ListEmailIdentities(ListEmailIdentitiesRequest request);
    }
}
#endif