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
 * Do not modify this file. This file is generated from the kafkaconnect-2021-09-14.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.KafkaConnect.Model
{
    /// <summary>
    /// Paginators for the KafkaConnect service
    ///</summary>
    public class KafkaConnectPaginatorFactory : IKafkaConnectPaginatorFactory
    {
        private readonly IAmazonKafkaConnect client;

        internal KafkaConnectPaginatorFactory(IAmazonKafkaConnect client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListConnectorOperations operation
        ///</summary>
        public IListConnectorOperationsPaginator ListConnectorOperations(ListConnectorOperationsRequest request) 
        {
            return new ListConnectorOperationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListConnectors operation
        ///</summary>
        public IListConnectorsPaginator ListConnectors(ListConnectorsRequest request) 
        {
            return new ListConnectorsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCustomPlugins operation
        ///</summary>
        public IListCustomPluginsPaginator ListCustomPlugins(ListCustomPluginsRequest request) 
        {
            return new ListCustomPluginsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListWorkerConfigurations operation
        ///</summary>
        public IListWorkerConfigurationsPaginator ListWorkerConfigurations(ListWorkerConfigurationsRequest request) 
        {
            return new ListWorkerConfigurationsPaginator(this.client, request);
        }
    }
}