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

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.ServiceDiscovery.Model
{
    /// <summary>
    /// Paginators for the ServiceDiscovery service
    ///</summary>
    public class ServiceDiscoveryPaginatorFactory : IServiceDiscoveryPaginatorFactory
    {
        private readonly IAmazonServiceDiscovery client;

        internal ServiceDiscoveryPaginatorFactory(IAmazonServiceDiscovery client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for GetInstancesHealthStatus operation
        ///</summary>
        public IGetInstancesHealthStatusPaginator GetInstancesHealthStatus(GetInstancesHealthStatusRequest request) 
        {
            return new GetInstancesHealthStatusPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListInstances operation
        ///</summary>
        public IListInstancesPaginator ListInstances(ListInstancesRequest request) 
        {
            return new ListInstancesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListNamespaces operation
        ///</summary>
        public IListNamespacesPaginator ListNamespaces(ListNamespacesRequest request) 
        {
            return new ListNamespacesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListOperations operation
        ///</summary>
        public IListOperationsPaginator ListOperations(ListOperationsRequest request) 
        {
            return new ListOperationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListServices operation
        ///</summary>
        public IListServicesPaginator ListServices(ListServicesRequest request) 
        {
            return new ListServicesPaginator(this.client, request);
        }
    }
}