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
 * Do not modify this file. This file is generated from the sms-2016-10-24.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.ServerMigrationService.Model
{
    /// <summary>
    /// Paginators for the ServerMigrationService service
    ///</summary>
    public class ServerMigrationServicePaginatorFactory : IServerMigrationServicePaginatorFactory
    {
        private readonly IAmazonServerMigrationService client;

        internal ServerMigrationServicePaginatorFactory(IAmazonServerMigrationService client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for GetConnectors operation
        ///</summary>
        public IGetConnectorsPaginator GetConnectors(GetConnectorsRequest request) 
        {
            return new GetConnectorsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetReplicationJobs operation
        ///</summary>
        public IGetReplicationJobsPaginator GetReplicationJobs(GetReplicationJobsRequest request) 
        {
            return new GetReplicationJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetReplicationRuns operation
        ///</summary>
        public IGetReplicationRunsPaginator GetReplicationRuns(GetReplicationRunsRequest request) 
        {
            return new GetReplicationRunsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetServers operation
        ///</summary>
        public IGetServersPaginator GetServers(GetServersRequest request) 
        {
            return new GetServersPaginator(this.client, request);
        }
    }
}