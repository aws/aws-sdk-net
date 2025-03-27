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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */

#pragma warning disable CS0612,CS0618
namespace Amazon.RDS.Model
{
    /// <summary>
    /// Paginators for the RDS service
    ///</summary>
    public interface IRDSPaginatorFactory
    {

        /// <summary>
        /// Paginator for DescribeBlueGreenDeployments operation
        ///</summary>
        IDescribeBlueGreenDeploymentsPaginator DescribeBlueGreenDeployments(DescribeBlueGreenDeploymentsRequest request);

        /// <summary>
        /// Paginator for DescribeCertificates operation
        ///</summary>
        IDescribeCertificatesPaginator DescribeCertificates(DescribeCertificatesRequest request);

        /// <summary>
        /// Paginator for DescribeDBClusterAutomatedBackups operation
        ///</summary>
        IDescribeDBClusterAutomatedBackupsPaginator DescribeDBClusterAutomatedBackups(DescribeDBClusterAutomatedBackupsRequest request);

        /// <summary>
        /// Paginator for DescribeDBClusterBacktracks operation
        ///</summary>
        IDescribeDBClusterBacktracksPaginator DescribeDBClusterBacktracks(DescribeDBClusterBacktracksRequest request);

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
        /// Paginator for DescribeDBInstanceAutomatedBackups operation
        ///</summary>
        IDescribeDBInstanceAutomatedBackupsPaginator DescribeDBInstanceAutomatedBackups(DescribeDBInstanceAutomatedBackupsRequest request);

        /// <summary>
        /// Paginator for DescribeDBInstances operation
        ///</summary>
        IDescribeDBInstancesPaginator DescribeDBInstances(DescribeDBInstancesRequest request);

        /// <summary>
        /// Paginator for DescribeDBLogFiles operation
        ///</summary>
        IDescribeDBLogFilesPaginator DescribeDBLogFiles(DescribeDBLogFilesRequest request);

        /// <summary>
        /// Paginator for DescribeDBParameterGroups operation
        ///</summary>
        IDescribeDBParameterGroupsPaginator DescribeDBParameterGroups(DescribeDBParameterGroupsRequest request);

        /// <summary>
        /// Paginator for DescribeDBParameters operation
        ///</summary>
        IDescribeDBParametersPaginator DescribeDBParameters(DescribeDBParametersRequest request);

        /// <summary>
        /// Paginator for DescribeDBProxies operation
        ///</summary>
        IDescribeDBProxiesPaginator DescribeDBProxies(DescribeDBProxiesRequest request);

        /// <summary>
        /// Paginator for DescribeDBProxyEndpoints operation
        ///</summary>
        IDescribeDBProxyEndpointsPaginator DescribeDBProxyEndpoints(DescribeDBProxyEndpointsRequest request);

        /// <summary>
        /// Paginator for DescribeDBProxyTargetGroups operation
        ///</summary>
        IDescribeDBProxyTargetGroupsPaginator DescribeDBProxyTargetGroups(DescribeDBProxyTargetGroupsRequest request);

        /// <summary>
        /// Paginator for DescribeDBProxyTargets operation
        ///</summary>
        IDescribeDBProxyTargetsPaginator DescribeDBProxyTargets(DescribeDBProxyTargetsRequest request);

        /// <summary>
        /// Paginator for DescribeDBRecommendations operation
        ///</summary>
        IDescribeDBRecommendationsPaginator DescribeDBRecommendations(DescribeDBRecommendationsRequest request);

        /// <summary>
        /// Paginator for DescribeDBSecurityGroups operation
        ///</summary>
        IDescribeDBSecurityGroupsPaginator DescribeDBSecurityGroups(DescribeDBSecurityGroupsRequest request);

        /// <summary>
        /// Paginator for DescribeDBSnapshots operation
        ///</summary>
        IDescribeDBSnapshotsPaginator DescribeDBSnapshots(DescribeDBSnapshotsRequest request);

        /// <summary>
        /// Paginator for DescribeDBSnapshotTenantDatabases operation
        ///</summary>
        IDescribeDBSnapshotTenantDatabasesPaginator DescribeDBSnapshotTenantDatabases(DescribeDBSnapshotTenantDatabasesRequest request);

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
        /// Paginator for DescribeExportTasks operation
        ///</summary>
        IDescribeExportTasksPaginator DescribeExportTasks(DescribeExportTasksRequest request);

        /// <summary>
        /// Paginator for DescribeGlobalClusters operation
        ///</summary>
        IDescribeGlobalClustersPaginator DescribeGlobalClusters(DescribeGlobalClustersRequest request);

        /// <summary>
        /// Paginator for DescribeIntegrations operation
        ///</summary>
        IDescribeIntegrationsPaginator DescribeIntegrations(DescribeIntegrationsRequest request);

        /// <summary>
        /// Paginator for DescribeOptionGroupOptions operation
        ///</summary>
        IDescribeOptionGroupOptionsPaginator DescribeOptionGroupOptions(DescribeOptionGroupOptionsRequest request);

        /// <summary>
        /// Paginator for DescribeOptionGroups operation
        ///</summary>
        IDescribeOptionGroupsPaginator DescribeOptionGroups(DescribeOptionGroupsRequest request);

        /// <summary>
        /// Paginator for DescribeOrderableDBInstanceOptions operation
        ///</summary>
        IDescribeOrderableDBInstanceOptionsPaginator DescribeOrderableDBInstanceOptions(DescribeOrderableDBInstanceOptionsRequest request);

        /// <summary>
        /// Paginator for DescribePendingMaintenanceActions operation
        ///</summary>
        IDescribePendingMaintenanceActionsPaginator DescribePendingMaintenanceActions(DescribePendingMaintenanceActionsRequest request);

        /// <summary>
        /// Paginator for DescribeReservedDBInstances operation
        ///</summary>
        IDescribeReservedDBInstancesPaginator DescribeReservedDBInstances(DescribeReservedDBInstancesRequest request);

        /// <summary>
        /// Paginator for DescribeReservedDBInstancesOfferings operation
        ///</summary>
        IDescribeReservedDBInstancesOfferingsPaginator DescribeReservedDBInstancesOfferings(DescribeReservedDBInstancesOfferingsRequest request);

        /// <summary>
        /// Paginator for DescribeSourceRegions operation
        ///</summary>
        IDescribeSourceRegionsPaginator DescribeSourceRegions(DescribeSourceRegionsRequest request);

        /// <summary>
        /// Paginator for DescribeTenantDatabases operation
        ///</summary>
        IDescribeTenantDatabasesPaginator DescribeTenantDatabases(DescribeTenantDatabasesRequest request);

        /// <summary>
        /// Paginator for DownloadDBLogFilePortion operation
        ///</summary>
        IDownloadDBLogFilePortionPaginator DownloadDBLogFilePortion(DownloadDBLogFilePortionRequest request);
    }
}