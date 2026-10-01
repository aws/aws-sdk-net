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
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618

namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// Paginators for the SimpleEmailV2 service
    /// </summary>
    public interface ISimpleEmailV2PaginatorFactory
    {
        /// <summary>
        /// Paginator for GetDedicatedIps operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "PageSize", OutputToken = ["NextToken"])]
        IGetDedicatedIpsPaginator GetDedicatedIps(GetDedicatedIpsRequest request);

        /// <summary>
        /// Paginator for ListConfigurationSets operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "PageSize", OutputToken = ["NextToken"])]
        IListConfigurationSetsPaginator ListConfigurationSets(ListConfigurationSetsRequest request);

        /// <summary>
        /// Paginator for ListContactLists operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "PageSize", OutputToken = ["NextToken"])]
        IListContactListsPaginator ListContactLists(ListContactListsRequest request);

        /// <summary>
        /// Paginator for ListContacts operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "PageSize", OutputToken = ["NextToken"])]
        IListContactsPaginator ListContacts(ListContactsRequest request);

        /// <summary>
        /// Paginator for ListCustomVerificationEmailTemplates operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "PageSize", OutputToken = ["NextToken"])]
        IListCustomVerificationEmailTemplatesPaginator ListCustomVerificationEmailTemplates(ListCustomVerificationEmailTemplatesRequest request);

        /// <summary>
        /// Paginator for ListDedicatedIpPools operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "PageSize", OutputToken = ["NextToken"])]
        IListDedicatedIpPoolsPaginator ListDedicatedIpPools(ListDedicatedIpPoolsRequest request);

        /// <summary>
        /// Paginator for ListDeliverabilityTestReports operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "PageSize", OutputToken = ["NextToken"])]
        IListDeliverabilityTestReportsPaginator ListDeliverabilityTestReports(ListDeliverabilityTestReportsRequest request);

        /// <summary>
        /// Paginator for ListDomainDeliverabilityCampaigns operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "PageSize", OutputToken = ["NextToken"])]
        IListDomainDeliverabilityCampaignsPaginator ListDomainDeliverabilityCampaigns(ListDomainDeliverabilityCampaignsRequest request);

        /// <summary>
        /// Paginator for ListEmailIdentities operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "PageSize", OutputToken = ["NextToken"])]
        IListEmailIdentitiesPaginator ListEmailIdentities(ListEmailIdentitiesRequest request);

        /// <summary>
        /// Paginator for ListEmailIdentityCertificates operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "PageSize", OutputToken = ["NextToken"])]
        IListEmailIdentityCertificatesPaginator ListEmailIdentityCertificates(ListEmailIdentityCertificatesRequest request);

        /// <summary>
        /// Paginator for ListEmailTemplates operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "PageSize", OutputToken = ["NextToken"])]
        IListEmailTemplatesPaginator ListEmailTemplates(ListEmailTemplatesRequest request);

        /// <summary>
        /// Paginator for ListExportJobs operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "PageSize", OutputToken = ["NextToken"])]
        IListExportJobsPaginator ListExportJobs(ListExportJobsRequest request);

        /// <summary>
        /// Paginator for ListImportJobs operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "PageSize", OutputToken = ["NextToken"])]
        IListImportJobsPaginator ListImportJobs(ListImportJobsRequest request);

        /// <summary>
        /// Paginator for ListMultiRegionEndpoints operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "PageSize", OutputToken = ["NextToken"])]
        IListMultiRegionEndpointsPaginator ListMultiRegionEndpoints(ListMultiRegionEndpointsRequest request);

        /// <summary>
        /// Paginator for ListRecommendations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "PageSize", OutputToken = ["NextToken"])]
        IListRecommendationsPaginator ListRecommendations(ListRecommendationsRequest request);

        /// <summary>
        /// Paginator for ListReputationEntities operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "PageSize", OutputToken = ["NextToken"])]
        IListReputationEntitiesPaginator ListReputationEntities(ListReputationEntitiesRequest request);

        /// <summary>
        /// Paginator for ListResourceTenants operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "PageSize", OutputToken = ["NextToken"])]
        IListResourceTenantsPaginator ListResourceTenants(ListResourceTenantsRequest request);

        /// <summary>
        /// Paginator for ListSuppressedDestinations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "PageSize", OutputToken = ["NextToken"])]
        IListSuppressedDestinationsPaginator ListSuppressedDestinations(ListSuppressedDestinationsRequest request);

        /// <summary>
        /// Paginator for ListTenantResources operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "PageSize", OutputToken = ["NextToken"])]
        IListTenantResourcesPaginator ListTenantResources(ListTenantResourcesRequest request);

        /// <summary>
        /// Paginator for ListTenants operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "PageSize", OutputToken = ["NextToken"])]
        IListTenantsPaginator ListTenants(ListTenantsRequest request);
    }
}
