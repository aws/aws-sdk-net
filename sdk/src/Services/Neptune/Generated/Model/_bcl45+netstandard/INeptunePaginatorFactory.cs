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
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
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
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeDBClusterEndpointsPaginator DescribeDBClusterEndpoints(DescribeDBClusterEndpointsRequest request);

        /// <summary>
        /// Paginator for DescribeDBClusterParameterGroups operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeDBClusterParameterGroupsPaginator DescribeDBClusterParameterGroups(DescribeDBClusterParameterGroupsRequest request);

        /// <summary>
        /// Paginator for DescribeDBClusterParameters operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeDBClusterParametersPaginator DescribeDBClusterParameters(DescribeDBClusterParametersRequest request);

        /// <summary>
        /// Paginator for DescribeDBClusters operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeDBClustersPaginator DescribeDBClusters(DescribeDBClustersRequest request);

        /// <summary>
        /// Paginator for DescribeDBClusterSnapshots operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeDBClusterSnapshotsPaginator DescribeDBClusterSnapshots(DescribeDBClusterSnapshotsRequest request);

        /// <summary>
        /// Paginator for DescribeDBEngineVersions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeDBEngineVersionsPaginator DescribeDBEngineVersions(DescribeDBEngineVersionsRequest request);

        /// <summary>
        /// Paginator for DescribeDBInstances operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeDBInstancesPaginator DescribeDBInstances(DescribeDBInstancesRequest request);

        /// <summary>
        /// Paginator for DescribeDBParameterGroups operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeDBParameterGroupsPaginator DescribeDBParameterGroups(DescribeDBParameterGroupsRequest request);

        /// <summary>
        /// Paginator for DescribeDBParameters operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeDBParametersPaginator DescribeDBParameters(DescribeDBParametersRequest request);

        /// <summary>
        /// Paginator for DescribeDBSubnetGroups operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeDBSubnetGroupsPaginator DescribeDBSubnetGroups(DescribeDBSubnetGroupsRequest request);

        /// <summary>
        /// Paginator for DescribeEngineDefaultParameters operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "EngineDefaults.Marker" }
        )]
        IDescribeEngineDefaultParametersPaginator DescribeEngineDefaultParameters(DescribeEngineDefaultParametersRequest request);

        /// <summary>
        /// Paginator for DescribeEvents operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeEventsPaginator DescribeEvents(DescribeEventsRequest request);

        /// <summary>
        /// Paginator for DescribeEventSubscriptions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeEventSubscriptionsPaginator DescribeEventSubscriptions(DescribeEventSubscriptionsRequest request);

        /// <summary>
        /// Paginator for DescribeGlobalClusters operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeGlobalClustersPaginator DescribeGlobalClusters(DescribeGlobalClustersRequest request);

        /// <summary>
        /// Paginator for DescribeOrderableDBInstanceOptions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeOrderableDBInstanceOptionsPaginator DescribeOrderableDBInstanceOptions(DescribeOrderableDBInstanceOptionsRequest request);

        /// <summary>
        /// Paginator for DescribePendingMaintenanceActions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribePendingMaintenanceActionsPaginator DescribePendingMaintenanceActions(DescribePendingMaintenanceActionsRequest request);
    }
}