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

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.Kafka.Model
{
    /// <summary>
    /// Paginators for the Kafka service
    ///</summary>
    public class KafkaPaginatorFactory : IKafkaPaginatorFactory
    {
        private readonly IAmazonKafka client;

        internal KafkaPaginatorFactory(IAmazonKafka client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListClientVpcConnections operation
        ///</summary>
        public IListClientVpcConnectionsPaginator ListClientVpcConnections(ListClientVpcConnectionsRequest request) 
        {
            return new ListClientVpcConnectionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListClusterOperations operation
        ///</summary>
        public IListClusterOperationsPaginator ListClusterOperations(ListClusterOperationsRequest request) 
        {
            return new ListClusterOperationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListClusterOperationsV2 operation
        ///</summary>
        public IListClusterOperationsV2Paginator ListClusterOperationsV2(ListClusterOperationsV2Request request) 
        {
            return new ListClusterOperationsV2Paginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListClusters operation
        ///</summary>
        public IListClustersPaginator ListClusters(ListClustersRequest request) 
        {
            return new ListClustersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListClustersV2 operation
        ///</summary>
        public IListClustersV2Paginator ListClustersV2(ListClustersV2Request request) 
        {
            return new ListClustersV2Paginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListConfigurationRevisions operation
        ///</summary>
        public IListConfigurationRevisionsPaginator ListConfigurationRevisions(ListConfigurationRevisionsRequest request) 
        {
            return new ListConfigurationRevisionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListConfigurations operation
        ///</summary>
        public IListConfigurationsPaginator ListConfigurations(ListConfigurationsRequest request) 
        {
            return new ListConfigurationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListKafkaVersions operation
        ///</summary>
        public IListKafkaVersionsPaginator ListKafkaVersions(ListKafkaVersionsRequest request) 
        {
            return new ListKafkaVersionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListNodes operation
        ///</summary>
        public IListNodesPaginator ListNodes(ListNodesRequest request) 
        {
            return new ListNodesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListReplicators operation
        ///</summary>
        public IListReplicatorsPaginator ListReplicators(ListReplicatorsRequest request) 
        {
            return new ListReplicatorsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListScramSecrets operation
        ///</summary>
        public IListScramSecretsPaginator ListScramSecrets(ListScramSecretsRequest request) 
        {
            return new ListScramSecretsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListVpcConnections operation
        ///</summary>
        public IListVpcConnectionsPaginator ListVpcConnections(ListVpcConnectionsRequest request) 
        {
            return new ListVpcConnectionsPaginator(this.client, request);
        }
    }
}