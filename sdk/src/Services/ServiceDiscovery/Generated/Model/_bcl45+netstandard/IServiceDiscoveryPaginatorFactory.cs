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
 * Do not modify this file. This file is generated from the servicediscovery-2017-03-14.normal.json service model.
 */

namespace Amazon.ServiceDiscovery.Model
{
    /// <summary>
    /// Paginators for the ServiceDiscovery service
    ///</summary>
    public interface IServiceDiscoveryPaginatorFactory
    {

        /// <summary>
        /// Paginator for GetInstancesHealthStatus operation
        ///</summary>
        IGetInstancesHealthStatusPaginator GetInstancesHealthStatus(GetInstancesHealthStatusRequest request);

        /// <summary>
        /// Paginator for ListInstances operation
        ///</summary>
        IListInstancesPaginator ListInstances(ListInstancesRequest request);

        /// <summary>
        /// Paginator for ListNamespaces operation
        ///</summary>
        IListNamespacesPaginator ListNamespaces(ListNamespacesRequest request);

        /// <summary>
        /// Paginator for ListOperations operation
        ///</summary>
        IListOperationsPaginator ListOperations(ListOperationsRequest request);

        /// <summary>
        /// Paginator for ListServices operation
        ///</summary>
        IListServicesPaginator ListServices(ListServicesRequest request);
    }
}