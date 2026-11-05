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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Paginators for the RDS service
    /// </summary>
    public interface IRDSPaginatorFactory
    {
        /// <summary>
        /// Paginator for DescribeBlueGreenDeployments operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxRecords", OutputToken = ["Marker"])]
        IDescribeBlueGreenDeploymentsPaginator DescribeBlueGreenDeployments(DescribeBlueGreenDeploymentsRequest request);

        /// <summary>
        /// Paginator for DescribeCertificates operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxRecords", OutputToken = ["Marker"])]
        IDescribeCertificatesPaginator DescribeCertificates(DescribeCertificatesRequest request);

        /// <summary>
        /// Paginator for DescribeDBCapacityReservations operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxRecords", OutputToken = ["Marker"])]
        IDescribeDBCapacityReservationsPaginator DescribeDBCapacityReservations(DescribeDBCapacityReservationsRequest request);

        /// <summary>
        /// Paginator for DescribeDBClusterAutomatedBackups operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxRecords", OutputToken = ["Marker"])]
        IDescribeDBClusterAutomatedBackupsPaginator DescribeDBClusterAutomatedBackups(DescribeDBClusterAutomatedBackupsRequest request);

        /// <summary>
        /// Paginator for DescribeDBClusterBacktracks operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxRecords", OutputToken = ["Marker"])]
        IDescribeDBClusterBacktracksPaginator DescribeDBClusterBacktracks(DescribeDBClusterBacktracksRequest request);

        /// <summary>
        /// Paginator for DescribeDBClusterEndpoints operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxRecords", OutputToken = ["Marker"])]
        IDescribeDBClusterEndpointsPaginator DescribeDBClusterEndpoints(DescribeDBClusterEndpointsRequest request);

        /// <summary>
        /// Paginator for DescribeDBClusterParameterGroups operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxRecords", OutputToken = ["Marker"])]
        IDescribeDBClusterParameterGroupsPaginator DescribeDBClusterParameterGroups(DescribeDBClusterParameterGroupsRequest request);

        /// <summary>
        /// Paginator for DescribeDBClusterParameters operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxRecords", OutputToken = ["Marker"])]
        IDescribeDBClusterParametersPaginator DescribeDBClusterParameters(DescribeDBClusterParametersRequest request);

        /// <summary>
        /// Paginator for DescribeDBClusterSnapshots operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxRecords", OutputToken = ["Marker"])]
        IDescribeDBClusterSnapshotsPaginator DescribeDBClusterSnapshots(DescribeDBClusterSnapshotsRequest request);

        /// <summary>
        /// Paginator for DescribeDBClusters operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxRecords", OutputToken = ["Marker"])]
        IDescribeDBClustersPaginator DescribeDBClusters(DescribeDBClustersRequest request);

        /// <summary>
        /// Paginator for DescribeDBEngineVersions operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxRecords", OutputToken = ["Marker"])]
        IDescribeDBEngineVersionsPaginator DescribeDBEngineVersions(DescribeDBEngineVersionsRequest request);

        /// <summary>
        /// Paginator for DescribeDBInstanceAutomatedBackups operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxRecords", OutputToken = ["Marker"])]
        IDescribeDBInstanceAutomatedBackupsPaginator DescribeDBInstanceAutomatedBackups(DescribeDBInstanceAutomatedBackupsRequest request);

        /// <summary>
        /// Paginator for DescribeDBInstances operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxRecords", OutputToken = ["Marker"])]
        IDescribeDBInstancesPaginator DescribeDBInstances(DescribeDBInstancesRequest request);

        /// <summary>
        /// Paginator for DescribeDBLogFiles operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxRecords", OutputToken = ["Marker"])]
        IDescribeDBLogFilesPaginator DescribeDBLogFiles(DescribeDBLogFilesRequest request);

        /// <summary>
        /// Paginator for DescribeDBMajorEngineVersions operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxRecords", OutputToken = ["Marker"])]
        IDescribeDBMajorEngineVersionsPaginator DescribeDBMajorEngineVersions(DescribeDBMajorEngineVersionsRequest request);

        /// <summary>
        /// Paginator for DescribeDBParameterGroups operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxRecords", OutputToken = ["Marker"])]
        IDescribeDBParameterGroupsPaginator DescribeDBParameterGroups(DescribeDBParameterGroupsRequest request);

        /// <summary>
        /// Paginator for DescribeDBParameters operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxRecords", OutputToken = ["Marker"])]
        IDescribeDBParametersPaginator DescribeDBParameters(DescribeDBParametersRequest request);

        /// <summary>
        /// Paginator for DescribeDBProxies operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxRecords", OutputToken = ["Marker"])]
        IDescribeDBProxiesPaginator DescribeDBProxies(DescribeDBProxiesRequest request);

        /// <summary>
        /// Paginator for DescribeDBProxyEndpoints operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxRecords", OutputToken = ["Marker"])]
        IDescribeDBProxyEndpointsPaginator DescribeDBProxyEndpoints(DescribeDBProxyEndpointsRequest request);

        /// <summary>
        /// Paginator for DescribeDBProxyTargetGroups operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxRecords", OutputToken = ["Marker"])]
        IDescribeDBProxyTargetGroupsPaginator DescribeDBProxyTargetGroups(DescribeDBProxyTargetGroupsRequest request);

        /// <summary>
        /// Paginator for DescribeDBProxyTargets operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxRecords", OutputToken = ["Marker"])]
        IDescribeDBProxyTargetsPaginator DescribeDBProxyTargets(DescribeDBProxyTargetsRequest request);

        /// <summary>
        /// Paginator for DescribeDBRecommendations operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxRecords", OutputToken = ["Marker"])]
        IDescribeDBRecommendationsPaginator DescribeDBRecommendations(DescribeDBRecommendationsRequest request);

        /// <summary>
        /// Paginator for DescribeDBSecurityGroups operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxRecords", OutputToken = ["Marker"])]
        IDescribeDBSecurityGroupsPaginator DescribeDBSecurityGroups(DescribeDBSecurityGroupsRequest request);

        /// <summary>
        /// Paginator for DescribeDBSnapshotTenantDatabases operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxRecords", OutputToken = ["Marker"])]
        IDescribeDBSnapshotTenantDatabasesPaginator DescribeDBSnapshotTenantDatabases(DescribeDBSnapshotTenantDatabasesRequest request);

        /// <summary>
        /// Paginator for DescribeDBSnapshots operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxRecords", OutputToken = ["Marker"])]
        IDescribeDBSnapshotsPaginator DescribeDBSnapshots(DescribeDBSnapshotsRequest request);

        /// <summary>
        /// Paginator for DescribeDBSubnetGroups operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxRecords", OutputToken = ["Marker"])]
        IDescribeDBSubnetGroupsPaginator DescribeDBSubnetGroups(DescribeDBSubnetGroupsRequest request);

        /// <summary>
        /// Paginator for DescribeEngineDefaultClusterParameters operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxRecords", OutputToken = ["EngineDefaults.Marker"])]
        IDescribeEngineDefaultClusterParametersPaginator DescribeEngineDefaultClusterParameters(DescribeEngineDefaultClusterParametersRequest request);

        /// <summary>
        /// Paginator for DescribeEngineDefaultParameters operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxRecords", OutputToken = ["EngineDefaults.Marker"])]
        IDescribeEngineDefaultParametersPaginator DescribeEngineDefaultParameters(DescribeEngineDefaultParametersRequest request);

        /// <summary>
        /// Paginator for DescribeEventSubscriptions operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxRecords", OutputToken = ["Marker"])]
        IDescribeEventSubscriptionsPaginator DescribeEventSubscriptions(DescribeEventSubscriptionsRequest request);

        /// <summary>
        /// Paginator for DescribeEvents operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxRecords", OutputToken = ["Marker"])]
        IDescribeEventsPaginator DescribeEvents(DescribeEventsRequest request);

        /// <summary>
        /// Paginator for DescribeExportTasks operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxRecords", OutputToken = ["Marker"])]
        IDescribeExportTasksPaginator DescribeExportTasks(DescribeExportTasksRequest request);

        /// <summary>
        /// Paginator for DescribeGlobalClusters operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxRecords", OutputToken = ["Marker"])]
        IDescribeGlobalClustersPaginator DescribeGlobalClusters(DescribeGlobalClustersRequest request);

        /// <summary>
        /// Paginator for DescribeIntegrations operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxRecords", OutputToken = ["Marker"])]
        IDescribeIntegrationsPaginator DescribeIntegrations(DescribeIntegrationsRequest request);

        /// <summary>
        /// Paginator for DescribeOptionGroupOptions operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxRecords", OutputToken = ["Marker"])]
        IDescribeOptionGroupOptionsPaginator DescribeOptionGroupOptions(DescribeOptionGroupOptionsRequest request);

        /// <summary>
        /// Paginator for DescribeOptionGroups operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxRecords", OutputToken = ["Marker"])]
        IDescribeOptionGroupsPaginator DescribeOptionGroups(DescribeOptionGroupsRequest request);

        /// <summary>
        /// Paginator for DescribeOrderableDBInstanceOptions operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxRecords", OutputToken = ["Marker"])]
        IDescribeOrderableDBInstanceOptionsPaginator DescribeOrderableDBInstanceOptions(DescribeOrderableDBInstanceOptionsRequest request);

        /// <summary>
        /// Paginator for DescribePendingMaintenanceActions operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxRecords", OutputToken = ["Marker"])]
        IDescribePendingMaintenanceActionsPaginator DescribePendingMaintenanceActions(DescribePendingMaintenanceActionsRequest request);

        /// <summary>
        /// Paginator for DescribeReservedDBInstances operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxRecords", OutputToken = ["Marker"])]
        IDescribeReservedDBInstancesPaginator DescribeReservedDBInstances(DescribeReservedDBInstancesRequest request);

        /// <summary>
        /// Paginator for DescribeReservedDBInstancesOfferings operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxRecords", OutputToken = ["Marker"])]
        IDescribeReservedDBInstancesOfferingsPaginator DescribeReservedDBInstancesOfferings(DescribeReservedDBInstancesOfferingsRequest request);

        /// <summary>
        /// Paginator for DescribeServerlessV2PlatformVersions operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxRecords", OutputToken = ["Marker"])]
        IDescribeServerlessV2PlatformVersionsPaginator DescribeServerlessV2PlatformVersions(DescribeServerlessV2PlatformVersionsRequest request);

        /// <summary>
        /// Paginator for DescribeSourceRegions operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxRecords", OutputToken = ["Marker"])]
        IDescribeSourceRegionsPaginator DescribeSourceRegions(DescribeSourceRegionsRequest request);

        /// <summary>
        /// Paginator for DescribeTenantDatabases operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxRecords", OutputToken = ["Marker"])]
        IDescribeTenantDatabasesPaginator DescribeTenantDatabases(DescribeTenantDatabasesRequest request);

        /// <summary>
        /// Paginator for DownloadDBLogFilePortion operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "NumberOfLines", OutputToken = ["Marker"])]
        IDownloadDBLogFilePortionPaginator DownloadDBLogFilePortion(DownloadDBLogFilePortionRequest request);
    }
}
