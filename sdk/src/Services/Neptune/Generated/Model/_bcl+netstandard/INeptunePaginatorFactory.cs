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
 * Do not modify this file. This file is generated from the neptune-2014-10-31.normal.json service model.
 */

namespace Amazon.Neptune.Model
{
    /// <summary>
    /// Paginators for the Neptune service
    ///</summary>
    public interface INeptunePaginatorFactory
    {

        /// <summary>
        /// Paginator for DescribeDBClusterEndpoints operation
        ///</summary>
        IDescribeDBClusterEndpointsPaginator DescribeDBClusterEndpoints(DescribeDBClusterEndpointsRequest request);

        /// <summary>
        /// Paginator for DescribeDBClusterParameterGroups operation
        ///</summary>
        IDescribeDBClusterParameterGroupsPaginator DescribeDBClusterParameterGroups(DescribeDBClusterParameterGroupsRequest request);

        /// <summary>
        /// Paginator for DescribeDBClusterParameters operation
        ///</summary>
        IDescribeDBClusterParametersPaginator DescribeDBClusterParameters(DescribeDBClusterParametersRequest request);

        /// <summary>
        /// Paginator for DescribeDBClusters operation
        ///</summary>
        IDescribeDBClustersPaginator DescribeDBClusters(DescribeDBClustersRequest request);

        /// <summary>
        /// Paginator for DescribeDBClusterSnapshots operation
        ///</summary>
        IDescribeDBClusterSnapshotsPaginator DescribeDBClusterSnapshots(DescribeDBClusterSnapshotsRequest request);

        /// <summary>
        /// Paginator for DescribeDBEngineVersions operation
        ///</summary>
        IDescribeDBEngineVersionsPaginator DescribeDBEngineVersions(DescribeDBEngineVersionsRequest request);

        /// <summary>
        /// Paginator for DescribeDBInstances operation
        ///</summary>
        IDescribeDBInstancesPaginator DescribeDBInstances(DescribeDBInstancesRequest request);

        /// <summary>
        /// Paginator for DescribeDBParameterGroups operation
        ///</summary>
        IDescribeDBParameterGroupsPaginator DescribeDBParameterGroups(DescribeDBParameterGroupsRequest request);

        /// <summary>
        /// Paginator for DescribeDBParameters operation
        ///</summary>
        IDescribeDBParametersPaginator DescribeDBParameters(DescribeDBParametersRequest request);

        /// <summary>
        /// Paginator for DescribeDBSubnetGroups operation
        ///</summary>
        IDescribeDBSubnetGroupsPaginator DescribeDBSubnetGroups(DescribeDBSubnetGroupsRequest request);

        /// <summary>
        /// Paginator for DescribeEngineDefaultParameters operation
        ///</summary>
        IDescribeEngineDefaultParametersPaginator DescribeEngineDefaultParameters(DescribeEngineDefaultParametersRequest request);

        /// <summary>
        /// Paginator for DescribeEvents operation
        ///</summary>
        IDescribeEventsPaginator DescribeEvents(DescribeEventsRequest request);

        /// <summary>
        /// Paginator for DescribeEventSubscriptions operation
        ///</summary>
        IDescribeEventSubscriptionsPaginator DescribeEventSubscriptions(DescribeEventSubscriptionsRequest request);

        /// <summary>
        /// Paginator for DescribeGlobalClusters operation
        ///</summary>
        IDescribeGlobalClustersPaginator DescribeGlobalClusters(DescribeGlobalClustersRequest request);

        /// <summary>
        /// Paginator for DescribeOrderableDBInstanceOptions operation
        ///</summary>
        IDescribeOrderableDBInstanceOptionsPaginator DescribeOrderableDBInstanceOptions(DescribeOrderableDBInstanceOptionsRequest request);

        /// <summary>
        /// Paginator for DescribePendingMaintenanceActions operation
        ///</summary>
        IDescribePendingMaintenanceActionsPaginator DescribePendingMaintenanceActions(DescribePendingMaintenanceActionsRequest request);
    }
}