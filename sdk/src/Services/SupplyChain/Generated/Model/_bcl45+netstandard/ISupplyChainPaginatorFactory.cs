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
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.SupplyChain.Model
{
    /// <summary>
    /// Paginators for the SupplyChain service
    ///</summary>
    public interface ISupplyChainPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListDataIntegrationEvents operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListDataIntegrationEventsPaginator ListDataIntegrationEvents(ListDataIntegrationEventsRequest request);

        /// <summary>
        /// Paginator for ListDataIntegrationFlowExecutions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListDataIntegrationFlowExecutionsPaginator ListDataIntegrationFlowExecutions(ListDataIntegrationFlowExecutionsRequest request);

        /// <summary>
        /// Paginator for ListDataIntegrationFlows operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListDataIntegrationFlowsPaginator ListDataIntegrationFlows(ListDataIntegrationFlowsRequest request);

        /// <summary>
        /// Paginator for ListDataLakeDatasets operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListDataLakeDatasetsPaginator ListDataLakeDatasets(ListDataLakeDatasetsRequest request);

        /// <summary>
        /// Paginator for ListDataLakeNamespaces operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListDataLakeNamespacesPaginator ListDataLakeNamespaces(ListDataLakeNamespacesRequest request);

        /// <summary>
        /// Paginator for ListInstances operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListInstancesPaginator ListInstances(ListInstancesRequest request);
    }
}