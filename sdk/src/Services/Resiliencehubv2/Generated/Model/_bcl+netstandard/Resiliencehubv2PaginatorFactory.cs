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
 * Do not modify this file. This file is generated from the resiliencehubv2-2026-02-17.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.Resiliencehubv2.Model
{
    /// <summary>
    /// Paginators for the Resiliencehubv2 service
    ///</summary>
    public class Resiliencehubv2PaginatorFactory : IResiliencehubv2PaginatorFactory
    {
        private readonly IAmazonResiliencehubv2 client;

        internal Resiliencehubv2PaginatorFactory(IAmazonResiliencehubv2 client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListAssertions operation
        ///</summary>
        public IListAssertionsPaginator ListAssertions(ListAssertionsRequest request) 
        {
            return new ListAssertionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDependencies operation
        ///</summary>
        public IListDependenciesPaginator ListDependencies(ListDependenciesRequest request) 
        {
            return new ListDependenciesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListFailureModeAssessments operation
        ///</summary>
        public IListFailureModeAssessmentsPaginator ListFailureModeAssessments(ListFailureModeAssessmentsRequest request) 
        {
            return new ListFailureModeAssessmentsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListFailureModeFindings operation
        ///</summary>
        public IListFailureModeFindingsPaginator ListFailureModeFindings(ListFailureModeFindingsRequest request) 
        {
            return new ListFailureModeFindingsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListInputSources operation
        ///</summary>
        public IListInputSourcesPaginator ListInputSources(ListInputSourcesRequest request) 
        {
            return new ListInputSourcesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPolicies operation
        ///</summary>
        public IListPoliciesPaginator ListPolicies(ListPoliciesRequest request) 
        {
            return new ListPoliciesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListReports operation
        ///</summary>
        public IListReportsPaginator ListReports(ListReportsRequest request) 
        {
            return new ListReportsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListResources operation
        ///</summary>
        public IListResourcesPaginator ListResources(ListResourcesRequest request) 
        {
            return new ListResourcesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListServiceEvents operation
        ///</summary>
        public IListServiceEventsPaginator ListServiceEvents(ListServiceEventsRequest request) 
        {
            return new ListServiceEventsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListServiceFunctions operation
        ///</summary>
        public IListServiceFunctionsPaginator ListServiceFunctions(ListServiceFunctionsRequest request) 
        {
            return new ListServiceFunctionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListServices operation
        ///</summary>
        public IListServicesPaginator ListServices(ListServicesRequest request) 
        {
            return new ListServicesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListServiceTopologyEdges operation
        ///</summary>
        public IListServiceTopologyEdgesPaginator ListServiceTopologyEdges(ListServiceTopologyEdgesRequest request) 
        {
            return new ListServiceTopologyEdgesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSystemEvents operation
        ///</summary>
        public IListSystemEventsPaginator ListSystemEvents(ListSystemEventsRequest request) 
        {
            return new ListSystemEventsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSystems operation
        ///</summary>
        public IListSystemsPaginator ListSystems(ListSystemsRequest request) 
        {
            return new ListSystemsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListUserJourneys operation
        ///</summary>
        public IListUserJourneysPaginator ListUserJourneys(ListUserJourneysRequest request) 
        {
            return new ListUserJourneysPaginator(this.client, request);
        }
    }
}