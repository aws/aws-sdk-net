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
 * Do not modify this file. This file is generated from the backup-gateway-2021-01-01.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.BackupGateway.Model
{
    /// <summary>
    /// Paginators for the BackupGateway service
    ///</summary>
    public partial class BackupGatewayPaginatorFactory : IBackupGatewayPaginatorFactory
    {
        private readonly IAmazonBackupGateway client;

        internal BackupGatewayPaginatorFactory(IAmazonBackupGateway client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListGateways operation
        ///</summary>
        public IListGatewaysPaginator ListGateways(ListGatewaysRequest request) 
        {
            return new ListGatewaysPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListHypervisors operation
        ///</summary>
        public IListHypervisorsPaginator ListHypervisors(ListHypervisorsRequest request) 
        {
            return new ListHypervisorsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListVirtualMachines operation
        ///</summary>
        public IListVirtualMachinesPaginator ListVirtualMachines(ListVirtualMachinesRequest request) 
        {
            return new ListVirtualMachinesPaginator(this.client, request);
        }
    }
}