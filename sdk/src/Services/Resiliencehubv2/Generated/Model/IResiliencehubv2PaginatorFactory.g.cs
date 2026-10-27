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

namespace Amazon.Resiliencehubv2.Model
{
    /// <summary>
    /// Paginators for the Resiliencehubv2 service
    /// </summary>
    public interface IResiliencehubv2PaginatorFactory
    {
        /// <summary>
        /// Paginator for ListAssertions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAssertionsPaginator ListAssertions(ListAssertionsRequest request);

        /// <summary>
        /// Paginator for ListDependencies operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListDependenciesPaginator ListDependencies(ListDependenciesRequest request);

        /// <summary>
        /// Paginator for ListFailureModeAssessments operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListFailureModeAssessmentsPaginator ListFailureModeAssessments(ListFailureModeAssessmentsRequest request);

        /// <summary>
        /// Paginator for ListFailureModeFindings operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListFailureModeFindingsPaginator ListFailureModeFindings(ListFailureModeFindingsRequest request);

        /// <summary>
        /// Paginator for ListInputSources operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListInputSourcesPaginator ListInputSources(ListInputSourcesRequest request);

        /// <summary>
        /// Paginator for ListPolicies operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListPoliciesPaginator ListPolicies(ListPoliciesRequest request);

        /// <summary>
        /// Paginator for ListPolicyEvents operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListPolicyEventsPaginator ListPolicyEvents(ListPolicyEventsRequest request);

        /// <summary>
        /// Paginator for ListReports operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListReportsPaginator ListReports(ListReportsRequest request);

        /// <summary>
        /// Paginator for ListResolvedTestRunTargetResources operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListResolvedTestRunTargetResourcesPaginator ListResolvedTestRunTargetResources(ListResolvedTestRunTargetResourcesRequest request);

        /// <summary>
        /// Paginator for ListResources operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListResourcesPaginator ListResources(ListResourcesRequest request);

        /// <summary>
        /// Paginator for ListServiceEvents operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListServiceEventsPaginator ListServiceEvents(ListServiceEventsRequest request);

        /// <summary>
        /// Paginator for ListServiceFunctions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListServiceFunctionsPaginator ListServiceFunctions(ListServiceFunctionsRequest request);

        /// <summary>
        /// Paginator for ListServiceTopologyEdges operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListServiceTopologyEdgesPaginator ListServiceTopologyEdges(ListServiceTopologyEdgesRequest request);

        /// <summary>
        /// Paginator for ListServices operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListServicesPaginator ListServices(ListServicesRequest request);

        /// <summary>
        /// Paginator for ListSystemEvents operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListSystemEventsPaginator ListSystemEvents(ListSystemEventsRequest request);

        /// <summary>
        /// Paginator for ListSystems operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListSystemsPaginator ListSystems(ListSystemsRequest request);

        /// <summary>
        /// Paginator for ListTestRunDependencies operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListTestRunDependenciesPaginator ListTestRunDependencies(ListTestRunDependenciesRequest request);

        /// <summary>
        /// Paginator for ListTestRunEvents operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListTestRunEventsPaginator ListTestRunEvents(ListTestRunEventsRequest request);

        /// <summary>
        /// Paginator for ListTestRunSourceEvents operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListTestRunSourceEventsPaginator ListTestRunSourceEvents(ListTestRunSourceEventsRequest request);

        /// <summary>
        /// Paginator for ListTestRunSources operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListTestRunSourcesPaginator ListTestRunSources(ListTestRunSourcesRequest request);

        /// <summary>
        /// Paginator for ListTestRuns operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListTestRunsPaginator ListTestRuns(ListTestRunsRequest request);

        /// <summary>
        /// Paginator for ListTestSources operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListTestSourcesPaginator ListTestSources(ListTestSourcesRequest request);

        /// <summary>
        /// Paginator for ListTests operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListTestsPaginator ListTests(ListTestsRequest request);

        /// <summary>
        /// Paginator for ListUserJourneys operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListUserJourneysPaginator ListUserJourneys(ListUserJourneysRequest request);
    }
}
