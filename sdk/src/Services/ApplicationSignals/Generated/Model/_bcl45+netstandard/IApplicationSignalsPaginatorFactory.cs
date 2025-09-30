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
 * Do not modify this file. This file is generated from the application-signals-2024-04-15.normal.json service model.
 */
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.ApplicationSignals.Model
{
    /// <summary>
    /// Paginators for the ApplicationSignals service
    ///</summary>
    public interface IApplicationSignalsPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListServiceDependencies operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListServiceDependenciesPaginator ListServiceDependencies(ListServiceDependenciesRequest request);

        /// <summary>
        /// Paginator for ListServiceDependents operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListServiceDependentsPaginator ListServiceDependents(ListServiceDependentsRequest request);

        /// <summary>
        /// Paginator for ListServiceLevelObjectiveExclusionWindows operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListServiceLevelObjectiveExclusionWindowsPaginator ListServiceLevelObjectiveExclusionWindows(ListServiceLevelObjectiveExclusionWindowsRequest request);

        /// <summary>
        /// Paginator for ListServiceLevelObjectives operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListServiceLevelObjectivesPaginator ListServiceLevelObjectives(ListServiceLevelObjectivesRequest request);

        /// <summary>
        /// Paginator for ListServiceOperations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListServiceOperationsPaginator ListServiceOperations(ListServiceOperationsRequest request);

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
        /// Paginator for ListServiceStates operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListServiceStatesPaginator ListServiceStates(ListServiceStatesRequest request);
    }
}