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
 * Do not modify this file. This file is generated from the kafka-2018-11-14.normal.json service model.
 */
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.Kafka.Model
{
    /// <summary>
    /// Paginators for the Kafka service
    ///</summary>
    public interface IKafkaPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListClientVpcConnections operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListClientVpcConnectionsPaginator ListClientVpcConnections(ListClientVpcConnectionsRequest request);

        /// <summary>
        /// Paginator for ListClusterOperations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListClusterOperationsPaginator ListClusterOperations(ListClusterOperationsRequest request);

        /// <summary>
        /// Paginator for ListClusterOperationsV2 operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListClusterOperationsV2Paginator ListClusterOperationsV2(ListClusterOperationsV2Request request);

        /// <summary>
        /// Paginator for ListClusters operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListClustersPaginator ListClusters(ListClustersRequest request);

        /// <summary>
        /// Paginator for ListClustersV2 operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListClustersV2Paginator ListClustersV2(ListClustersV2Request request);

        /// <summary>
        /// Paginator for ListConfigurationRevisions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListConfigurationRevisionsPaginator ListConfigurationRevisions(ListConfigurationRevisionsRequest request);

        /// <summary>
        /// Paginator for ListConfigurations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListConfigurationsPaginator ListConfigurations(ListConfigurationsRequest request);

        /// <summary>
        /// Paginator for ListKafkaVersions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListKafkaVersionsPaginator ListKafkaVersions(ListKafkaVersionsRequest request);

        /// <summary>
        /// Paginator for ListNodes operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListNodesPaginator ListNodes(ListNodesRequest request);

        /// <summary>
        /// Paginator for ListReplicators operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListReplicatorsPaginator ListReplicators(ListReplicatorsRequest request);

        /// <summary>
        /// Paginator for ListScramSecrets operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListScramSecretsPaginator ListScramSecrets(ListScramSecretsRequest request);

        /// <summary>
        /// Paginator for ListVpcConnections operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListVpcConnectionsPaginator ListVpcConnections(ListVpcConnectionsRequest request);
    }
}