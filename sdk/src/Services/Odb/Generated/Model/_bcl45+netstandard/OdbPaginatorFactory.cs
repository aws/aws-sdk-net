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
 * Do not modify this file. This file is generated from the odb-2024-08-20.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.Odb.Model
{
    /// <summary>
    /// Paginators for the Odb service
    ///</summary>
    public class OdbPaginatorFactory : IOdbPaginatorFactory
    {
        private readonly IAmazonOdb client;

        internal OdbPaginatorFactory(IAmazonOdb client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListAutonomousVirtualMachines operation
        ///</summary>
        public IListAutonomousVirtualMachinesPaginator ListAutonomousVirtualMachines(ListAutonomousVirtualMachinesRequest request) 
        {
            return new ListAutonomousVirtualMachinesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCloudAutonomousVmClusters operation
        ///</summary>
        public IListCloudAutonomousVmClustersPaginator ListCloudAutonomousVmClusters(ListCloudAutonomousVmClustersRequest request) 
        {
            return new ListCloudAutonomousVmClustersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCloudExadataInfrastructures operation
        ///</summary>
        public IListCloudExadataInfrastructuresPaginator ListCloudExadataInfrastructures(ListCloudExadataInfrastructuresRequest request) 
        {
            return new ListCloudExadataInfrastructuresPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCloudVmClusters operation
        ///</summary>
        public IListCloudVmClustersPaginator ListCloudVmClusters(ListCloudVmClustersRequest request) 
        {
            return new ListCloudVmClustersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDbNodes operation
        ///</summary>
        public IListDbNodesPaginator ListDbNodes(ListDbNodesRequest request) 
        {
            return new ListDbNodesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDbServers operation
        ///</summary>
        public IListDbServersPaginator ListDbServers(ListDbServersRequest request) 
        {
            return new ListDbServersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDbSystemShapes operation
        ///</summary>
        public IListDbSystemShapesPaginator ListDbSystemShapes(ListDbSystemShapesRequest request) 
        {
            return new ListDbSystemShapesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListGiVersions operation
        ///</summary>
        public IListGiVersionsPaginator ListGiVersions(ListGiVersionsRequest request) 
        {
            return new ListGiVersionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListOdbNetworks operation
        ///</summary>
        public IListOdbNetworksPaginator ListOdbNetworks(ListOdbNetworksRequest request) 
        {
            return new ListOdbNetworksPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListOdbPeeringConnections operation
        ///</summary>
        public IListOdbPeeringConnectionsPaginator ListOdbPeeringConnections(ListOdbPeeringConnectionsRequest request) 
        {
            return new ListOdbPeeringConnectionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSystemVersions operation
        ///</summary>
        public IListSystemVersionsPaginator ListSystemVersions(ListSystemVersionsRequest request) 
        {
            return new ListSystemVersionsPaginator(this.client, request);
        }
    }
}