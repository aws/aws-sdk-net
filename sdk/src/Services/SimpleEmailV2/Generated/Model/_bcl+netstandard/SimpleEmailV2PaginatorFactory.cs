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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// Paginators for the SimpleEmailV2 service
    ///</summary>
    public class SimpleEmailV2PaginatorFactory : ISimpleEmailV2PaginatorFactory
    {
        private readonly IAmazonSimpleEmailServiceV2 client;

        internal SimpleEmailV2PaginatorFactory(IAmazonSimpleEmailServiceV2 client) 
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
        /// Paginator for ListContactLists operation
        ///</summary>
        public IListContactListsPaginator ListContactLists(ListContactListsRequest request) 
        {
            return new ListContactListsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListContacts operation
        ///</summary>
        public IListContactsPaginator ListContacts(ListContactsRequest request) 
        {
            return new ListContactsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCustomVerificationEmailTemplates operation
        ///</summary>
        public IListCustomVerificationEmailTemplatesPaginator ListCustomVerificationEmailTemplates(ListCustomVerificationEmailTemplatesRequest request) 
        {
            return new ListCustomVerificationEmailTemplatesPaginator(this.client, request);
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

        /// <summary>
        /// Paginator for ListEmailTemplates operation
        ///</summary>
        public IListEmailTemplatesPaginator ListEmailTemplates(ListEmailTemplatesRequest request) 
        {
            return new ListEmailTemplatesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListExportJobs operation
        ///</summary>
        public IListExportJobsPaginator ListExportJobs(ListExportJobsRequest request) 
        {
            return new ListExportJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListImportJobs operation
        ///</summary>
        public IListImportJobsPaginator ListImportJobs(ListImportJobsRequest request) 
        {
            return new ListImportJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListMultiRegionEndpoints operation
        ///</summary>
        public IListMultiRegionEndpointsPaginator ListMultiRegionEndpoints(ListMultiRegionEndpointsRequest request) 
        {
            return new ListMultiRegionEndpointsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRecommendations operation
        ///</summary>
        public IListRecommendationsPaginator ListRecommendations(ListRecommendationsRequest request) 
        {
            return new ListRecommendationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListReputationEntities operation
        ///</summary>
        public IListReputationEntitiesPaginator ListReputationEntities(ListReputationEntitiesRequest request) 
        {
            return new ListReputationEntitiesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListResourceTenants operation
        ///</summary>
        public IListResourceTenantsPaginator ListResourceTenants(ListResourceTenantsRequest request) 
        {
            return new ListResourceTenantsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSuppressedDestinations operation
        ///</summary>
        public IListSuppressedDestinationsPaginator ListSuppressedDestinations(ListSuppressedDestinationsRequest request) 
        {
            return new ListSuppressedDestinationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTenantResources operation
        ///</summary>
        public IListTenantResourcesPaginator ListTenantResources(ListTenantResourcesRequest request) 
        {
            return new ListTenantResourcesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTenants operation
        ///</summary>
        public IListTenantsPaginator ListTenants(ListTenantsRequest request) 
        {
            return new ListTenantsPaginator(this.client, request);
        }
    }
}