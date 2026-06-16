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
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.Resiliencehubv2.Model
{
    /// <summary>
    /// Paginators for the Resiliencehubv2 service
    ///</summary>
    public interface IResiliencehubv2PaginatorFactory
    {

        /// <summary>
        /// Paginator for ListAssertions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAssertionsPaginator ListAssertions(ListAssertionsRequest request);

        /// <summary>
        /// Paginator for ListDependencies operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListDependenciesPaginator ListDependencies(ListDependenciesRequest request);

        /// <summary>
        /// Paginator for ListFailureModeAssessments operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListFailureModeAssessmentsPaginator ListFailureModeAssessments(ListFailureModeAssessmentsRequest request);

        /// <summary>
        /// Paginator for ListFailureModeFindings operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListFailureModeFindingsPaginator ListFailureModeFindings(ListFailureModeFindingsRequest request);

        /// <summary>
        /// Paginator for ListInputSources operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListInputSourcesPaginator ListInputSources(ListInputSourcesRequest request);

        /// <summary>
        /// Paginator for ListPolicies operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListPoliciesPaginator ListPolicies(ListPoliciesRequest request);

        /// <summary>
        /// Paginator for ListReports operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListReportsPaginator ListReports(ListReportsRequest request);

        /// <summary>
        /// Paginator for ListResources operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListResourcesPaginator ListResources(ListResourcesRequest request);

        /// <summary>
        /// Paginator for ListServiceEvents operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListServiceEventsPaginator ListServiceEvents(ListServiceEventsRequest request);

        /// <summary>
        /// Paginator for ListServiceFunctions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListServiceFunctionsPaginator ListServiceFunctions(ListServiceFunctionsRequest request);

        /// <summary>
        /// Paginator for ListServices operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListServicesPaginator ListServices(ListServicesRequest request);

        /// <summary>
        /// Paginator for ListServiceTopologyEdges operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListServiceTopologyEdgesPaginator ListServiceTopologyEdges(ListServiceTopologyEdgesRequest request);

        /// <summary>
        /// Paginator for ListSystemEvents operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListSystemEventsPaginator ListSystemEvents(ListSystemEventsRequest request);

        /// <summary>
        /// Paginator for ListSystems operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListSystemsPaginator ListSystems(ListSystemsRequest request);

        /// <summary>
        /// Paginator for ListUserJourneys operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListUserJourneysPaginator ListUserJourneys(ListUserJourneysRequest request);
    }
}