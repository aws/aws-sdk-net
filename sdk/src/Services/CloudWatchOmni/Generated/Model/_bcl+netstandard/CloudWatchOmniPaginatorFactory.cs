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
 * Do not modify this file. This file is generated from the cloudwatchomni-2025-01-01.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.CloudWatchOmni.Model
{
    /// <summary>
    /// Paginators for the CloudWatchOmni service
    ///</summary>
    public class CloudWatchOmniPaginatorFactory : ICloudWatchOmniPaginatorFactory
    {
        private readonly IAmazonCloudWatchOmni client;

        internal CloudWatchOmniPaginatorFactory(IAmazonCloudWatchOmni client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for GetContextGraph operation
        ///</summary>
        public IGetContextGraphPaginator GetContextGraph(GetContextGraphRequest request) 
        {
            return new GetContextGraphPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetTelemetryQueryResults operation
        ///</summary>
        public IGetTelemetryQueryResultsPaginator GetTelemetryQueryResults(GetTelemetryQueryResultsRequest request) 
        {
            return new GetTelemetryQueryResultsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAccessGrants operation
        ///</summary>
        public IListAccessGrantsPaginator ListAccessGrants(ListAccessGrantsRequest request) 
        {
            return new ListAccessGrantsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAccessProfiles operation
        ///</summary>
        public IListAccessProfilesPaginator ListAccessProfiles(ListAccessProfilesRequest request) 
        {
            return new ListAccessProfilesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAlerts operation
        ///</summary>
        public IListAlertsPaginator ListAlerts(ListAlertsRequest request) 
        {
            return new ListAlertsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDomainAccessGrantsForOrganization operation
        ///</summary>
        public IListDomainAccessGrantsForOrganizationPaginator ListDomainAccessGrantsForOrganization(ListDomainAccessGrantsForOrganizationRequest request) 
        {
            return new ListDomainAccessGrantsForOrganizationPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDomains operation
        ///</summary>
        public IListDomainsPaginator ListDomains(ListDomainsRequest request) 
        {
            return new ListDomainsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListIntegrations operation
        ///</summary>
        public IListIntegrationsPaginator ListIntegrations(ListIntegrationsRequest request) 
        {
            return new ListIntegrationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListOmniDashboards operation
        ///</summary>
        public IListOmniDashboardsPaginator ListOmniDashboards(ListOmniDashboardsRequest request) 
        {
            return new ListOmniDashboardsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSpaces operation
        ///</summary>
        public IListSpacesPaginator ListSpaces(ListSpacesRequest request) 
        {
            return new ListSpacesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSpacesForOrganization operation
        ///</summary>
        public IListSpacesForOrganizationPaginator ListSpacesForOrganization(ListSpacesForOrganizationRequest request) 
        {
            return new ListSpacesForOrganizationPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTelemetryFields operation
        ///</summary>
        public IListTelemetryFieldsPaginator ListTelemetryFields(ListTelemetryFieldsRequest request) 
        {
            return new ListTelemetryFieldsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTelemetryQuerySessions operation
        ///</summary>
        public IListTelemetryQuerySessionsPaginator ListTelemetryQuerySessions(ListTelemetryQuerySessionsRequest request) 
        {
            return new ListTelemetryQuerySessionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListViews operation
        ///</summary>
        public IListViewsPaginator ListViews(ListViewsRequest request) 
        {
            return new ListViewsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SearchPrincipals operation
        ///</summary>
        public ISearchPrincipalsPaginator SearchPrincipals(SearchPrincipalsRequest request) 
        {
            return new SearchPrincipalsPaginator(this.client, request);
        }
    }
}