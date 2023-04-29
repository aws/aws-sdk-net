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
        IListClientVpcConnectionsPaginator ListClientVpcConnections(ListClientVpcConnectionsRequest request);

        /// <summary>
        /// Paginator for ListClusterOperations operation
        ///</summary>
        IListClusterOperationsPaginator ListClusterOperations(ListClusterOperationsRequest request);

        /// <summary>
        /// Paginator for ListClusters operation
        ///</summary>
        IListClustersPaginator ListClusters(ListClustersRequest request);

        /// <summary>
        /// Paginator for ListClustersV2 operation
        ///</summary>
        IListClustersV2Paginator ListClustersV2(ListClustersV2Request request);

        /// <summary>
        /// Paginator for ListConfigurationRevisions operation
        ///</summary>
        IListConfigurationRevisionsPaginator ListConfigurationRevisions(ListConfigurationRevisionsRequest request);

        /// <summary>
        /// Paginator for ListConfigurations operation
        ///</summary>
        IListConfigurationsPaginator ListConfigurations(ListConfigurationsRequest request);

        /// <summary>
        /// Paginator for ListKafkaVersions operation
        ///</summary>
        IListKafkaVersionsPaginator ListKafkaVersions(ListKafkaVersionsRequest request);

        /// <summary>
        /// Paginator for ListNodes operation
        ///</summary>
        IListNodesPaginator ListNodes(ListNodesRequest request);

        /// <summary>
        /// Paginator for ListScramSecrets operation
        ///</summary>
        IListScramSecretsPaginator ListScramSecrets(ListScramSecretsRequest request);

        /// <summary>
        /// Paginator for ListVpcConnections operation
        ///</summary>
        IListVpcConnectionsPaginator ListVpcConnections(ListVpcConnectionsRequest request);
    }
}