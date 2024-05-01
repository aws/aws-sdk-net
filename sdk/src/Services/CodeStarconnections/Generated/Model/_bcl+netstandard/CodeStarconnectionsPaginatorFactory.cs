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
 * Do not modify this file. This file is generated from the codestar-connections-2019-12-01.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.CodeStarconnections.Model
{
    /// <summary>
    /// Paginators for the CodeStarconnections service
    ///</summary>
    public class CodeStarconnectionsPaginatorFactory : ICodeStarconnectionsPaginatorFactory
    {
        private readonly IAmazonCodeStarconnections client;

        internal CodeStarconnectionsPaginatorFactory(IAmazonCodeStarconnections client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListConnections operation
        ///</summary>
        public IListConnectionsPaginator ListConnections(ListConnectionsRequest request) 
        {
            return new ListConnectionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListHosts operation
        ///</summary>
        public IListHostsPaginator ListHosts(ListHostsRequest request) 
        {
            return new ListHostsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRepositoryLinks operation
        ///</summary>
        public IListRepositoryLinksPaginator ListRepositoryLinks(ListRepositoryLinksRequest request) 
        {
            return new ListRepositoryLinksPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSyncConfigurations operation
        ///</summary>
        public IListSyncConfigurationsPaginator ListSyncConfigurations(ListSyncConfigurationsRequest request) 
        {
            return new ListSyncConfigurationsPaginator(this.client, request);
        }
    }
}