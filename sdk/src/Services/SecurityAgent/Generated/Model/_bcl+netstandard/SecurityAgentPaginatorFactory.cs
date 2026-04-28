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
 * Do not modify this file. This file is generated from the securityagent-2025-09-06.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// Paginators for the SecurityAgent service
    ///</summary>
    public class SecurityAgentPaginatorFactory : ISecurityAgentPaginatorFactory
    {
        private readonly IAmazonSecurityAgent client;

        internal SecurityAgentPaginatorFactory(IAmazonSecurityAgent client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListAgentSpaces operation
        ///</summary>
        public IListAgentSpacesPaginator ListAgentSpaces(ListAgentSpacesRequest request) 
        {
            return new ListAgentSpacesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListApplications operation
        ///</summary>
        public IListApplicationsPaginator ListApplications(ListApplicationsRequest request) 
        {
            return new ListApplicationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListArtifacts operation
        ///</summary>
        public IListArtifactsPaginator ListArtifacts(ListArtifactsRequest request) 
        {
            return new ListArtifactsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDiscoveredEndpoints operation
        ///</summary>
        public IListDiscoveredEndpointsPaginator ListDiscoveredEndpoints(ListDiscoveredEndpointsRequest request) 
        {
            return new ListDiscoveredEndpointsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListFindings operation
        ///</summary>
        public IListFindingsPaginator ListFindings(ListFindingsRequest request) 
        {
            return new ListFindingsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListIntegratedResources operation
        ///</summary>
        public IListIntegratedResourcesPaginator ListIntegratedResources(ListIntegratedResourcesRequest request) 
        {
            return new ListIntegratedResourcesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListIntegrations operation
        ///</summary>
        public IListIntegrationsPaginator ListIntegrations(ListIntegrationsRequest request) 
        {
            return new ListIntegrationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListMemberships operation
        ///</summary>
        public IListMembershipsPaginator ListMemberships(ListMembershipsRequest request) 
        {
            return new ListMembershipsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPentestJobsForPentest operation
        ///</summary>
        public IListPentestJobsForPentestPaginator ListPentestJobsForPentest(ListPentestJobsForPentestRequest request) 
        {
            return new ListPentestJobsForPentestPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPentestJobTasks operation
        ///</summary>
        public IListPentestJobTasksPaginator ListPentestJobTasks(ListPentestJobTasksRequest request) 
        {
            return new ListPentestJobTasksPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPentests operation
        ///</summary>
        public IListPentestsPaginator ListPentests(ListPentestsRequest request) 
        {
            return new ListPentestsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTargetDomains operation
        ///</summary>
        public IListTargetDomainsPaginator ListTargetDomains(ListTargetDomainsRequest request) 
        {
            return new ListTargetDomainsPaginator(this.client, request);
        }
    }
}