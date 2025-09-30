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

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.ApplicationSignals.Model
{
    /// <summary>
    /// Paginators for the ApplicationSignals service
    ///</summary>
    public class ApplicationSignalsPaginatorFactory : IApplicationSignalsPaginatorFactory
    {
        private readonly IAmazonApplicationSignals client;

        internal ApplicationSignalsPaginatorFactory(IAmazonApplicationSignals client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListServiceDependencies operation
        ///</summary>
        public IListServiceDependenciesPaginator ListServiceDependencies(ListServiceDependenciesRequest request) 
        {
            return new ListServiceDependenciesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListServiceDependents operation
        ///</summary>
        public IListServiceDependentsPaginator ListServiceDependents(ListServiceDependentsRequest request) 
        {
            return new ListServiceDependentsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListServiceLevelObjectiveExclusionWindows operation
        ///</summary>
        public IListServiceLevelObjectiveExclusionWindowsPaginator ListServiceLevelObjectiveExclusionWindows(ListServiceLevelObjectiveExclusionWindowsRequest request) 
        {
            return new ListServiceLevelObjectiveExclusionWindowsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListServiceLevelObjectives operation
        ///</summary>
        public IListServiceLevelObjectivesPaginator ListServiceLevelObjectives(ListServiceLevelObjectivesRequest request) 
        {
            return new ListServiceLevelObjectivesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListServiceOperations operation
        ///</summary>
        public IListServiceOperationsPaginator ListServiceOperations(ListServiceOperationsRequest request) 
        {
            return new ListServiceOperationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListServices operation
        ///</summary>
        public IListServicesPaginator ListServices(ListServicesRequest request) 
        {
            return new ListServicesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListServiceStates operation
        ///</summary>
        public IListServiceStatesPaginator ListServiceStates(ListServiceStatesRequest request) 
        {
            return new ListServiceStatesPaginator(this.client, request);
        }
    }
}