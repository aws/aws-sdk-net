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
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.Odb.Model
{
    /// <summary>
    /// Paginators for the Odb service
    ///</summary>
    public interface IOdbPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListAutonomousVirtualMachines operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAutonomousVirtualMachinesPaginator ListAutonomousVirtualMachines(ListAutonomousVirtualMachinesRequest request);

        /// <summary>
        /// Paginator for ListCloudAutonomousVmClusters operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListCloudAutonomousVmClustersPaginator ListCloudAutonomousVmClusters(ListCloudAutonomousVmClustersRequest request);

        /// <summary>
        /// Paginator for ListCloudExadataInfrastructures operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListCloudExadataInfrastructuresPaginator ListCloudExadataInfrastructures(ListCloudExadataInfrastructuresRequest request);

        /// <summary>
        /// Paginator for ListCloudVmClusters operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListCloudVmClustersPaginator ListCloudVmClusters(ListCloudVmClustersRequest request);

        /// <summary>
        /// Paginator for ListDbNodes operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListDbNodesPaginator ListDbNodes(ListDbNodesRequest request);

        /// <summary>
        /// Paginator for ListDbServers operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListDbServersPaginator ListDbServers(ListDbServersRequest request);

        /// <summary>
        /// Paginator for ListDbSystemShapes operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListDbSystemShapesPaginator ListDbSystemShapes(ListDbSystemShapesRequest request);

        /// <summary>
        /// Paginator for ListGiVersions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListGiVersionsPaginator ListGiVersions(ListGiVersionsRequest request);

        /// <summary>
        /// Paginator for ListOdbNetworks operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListOdbNetworksPaginator ListOdbNetworks(ListOdbNetworksRequest request);

        /// <summary>
        /// Paginator for ListOdbPeeringConnections operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListOdbPeeringConnectionsPaginator ListOdbPeeringConnections(ListOdbPeeringConnectionsRequest request);

        /// <summary>
        /// Paginator for ListSystemVersions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListSystemVersionsPaginator ListSystemVersions(ListSystemVersionsRequest request);
    }
}