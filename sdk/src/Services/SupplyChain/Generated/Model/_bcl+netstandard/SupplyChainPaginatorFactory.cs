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
 * Do not modify this file. This file is generated from the supplychain-2024-01-01.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.SupplyChain.Model
{
    /// <summary>
    /// Paginators for the SupplyChain service
    ///</summary>
    public class SupplyChainPaginatorFactory : ISupplyChainPaginatorFactory
    {
        private readonly IAmazonSupplyChain client;

        internal SupplyChainPaginatorFactory(IAmazonSupplyChain client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListDataIntegrationEvents operation
        ///</summary>
        public IListDataIntegrationEventsPaginator ListDataIntegrationEvents(ListDataIntegrationEventsRequest request) 
        {
            return new ListDataIntegrationEventsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDataIntegrationFlowExecutions operation
        ///</summary>
        public IListDataIntegrationFlowExecutionsPaginator ListDataIntegrationFlowExecutions(ListDataIntegrationFlowExecutionsRequest request) 
        {
            return new ListDataIntegrationFlowExecutionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDataIntegrationFlows operation
        ///</summary>
        public IListDataIntegrationFlowsPaginator ListDataIntegrationFlows(ListDataIntegrationFlowsRequest request) 
        {
            return new ListDataIntegrationFlowsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDataLakeDatasets operation
        ///</summary>
        public IListDataLakeDatasetsPaginator ListDataLakeDatasets(ListDataLakeDatasetsRequest request) 
        {
            return new ListDataLakeDatasetsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDataLakeNamespaces operation
        ///</summary>
        public IListDataLakeNamespacesPaginator ListDataLakeNamespaces(ListDataLakeNamespacesRequest request) 
        {
            return new ListDataLakeNamespacesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListInstances operation
        ///</summary>
        public IListInstancesPaginator ListInstances(ListInstancesRequest request) 
        {
            return new ListInstancesPaginator(this.client, request);
        }
    }
}