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

namespace Amazon.CloudWatchOmni.Model
{
    /// <summary>
    /// Paginators for the CloudWatchOmni service
    /// </summary>
    public interface ICloudWatchOmniPaginatorFactory
    {
        /// <summary>
        /// Paginator for GetContextGraph operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IGetContextGraphPaginator GetContextGraph(GetContextGraphRequest request);

        /// <summary>
        /// Paginator for GetTelemetryQueryResults operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IGetTelemetryQueryResultsPaginator GetTelemetryQueryResults(GetTelemetryQueryResultsRequest request);

        /// <summary>
        /// Paginator for ListAccessGrants operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAccessGrantsPaginator ListAccessGrants(ListAccessGrantsRequest request);

        /// <summary>
        /// Paginator for ListAccessProfiles operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAccessProfilesPaginator ListAccessProfiles(ListAccessProfilesRequest request);

        /// <summary>
        /// Paginator for ListAlerts operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAlertsPaginator ListAlerts(ListAlertsRequest request);

        /// <summary>
        /// Paginator for ListDomainAccessGrantsForOrganization operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListDomainAccessGrantsForOrganizationPaginator ListDomainAccessGrantsForOrganization(ListDomainAccessGrantsForOrganizationRequest request);

        /// <summary>
        /// Paginator for ListDomains operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListDomainsPaginator ListDomains(ListDomainsRequest request);

        /// <summary>
        /// Paginator for ListIntegrations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListIntegrationsPaginator ListIntegrations(ListIntegrationsRequest request);

        /// <summary>
        /// Paginator for ListOmniDashboards operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListOmniDashboardsPaginator ListOmniDashboards(ListOmniDashboardsRequest request);

        /// <summary>
        /// Paginator for ListSpaces operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListSpacesPaginator ListSpaces(ListSpacesRequest request);

        /// <summary>
        /// Paginator for ListSpacesForOrganization operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListSpacesForOrganizationPaginator ListSpacesForOrganization(ListSpacesForOrganizationRequest request);

        /// <summary>
        /// Paginator for ListTelemetryFields operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], OutputToken = ["NextToken"])]
        IListTelemetryFieldsPaginator ListTelemetryFields(ListTelemetryFieldsRequest request);

        /// <summary>
        /// Paginator for ListTelemetryQuerySessions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListTelemetryQuerySessionsPaginator ListTelemetryQuerySessions(ListTelemetryQuerySessionsRequest request);

        /// <summary>
        /// Paginator for ListViews operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListViewsPaginator ListViews(ListViewsRequest request);

        /// <summary>
        /// Paginator for SearchPrincipals operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        ISearchPrincipalsPaginator SearchPrincipals(SearchPrincipalsRequest request);
    }
}
