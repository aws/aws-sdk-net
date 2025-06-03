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

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.RDS.Model
{
    /// <summary>
    /// Paginators for the RDS service
    ///</summary>
    public class RDSPaginatorFactory : IRDSPaginatorFactory
    {
        private readonly IAmazonRDS client;

        internal RDSPaginatorFactory(IAmazonRDS client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for DescribeBlueGreenDeployments operation
        ///</summary>
        public IDescribeBlueGreenDeploymentsPaginator DescribeBlueGreenDeployments(DescribeBlueGreenDeploymentsRequest request) 
        {
            return new DescribeBlueGreenDeploymentsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeCertificates operation
        ///</summary>
        public IDescribeCertificatesPaginator DescribeCertificates(DescribeCertificatesRequest request) 
        {
            return new DescribeCertificatesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeDBClusterAutomatedBackups operation
        ///</summary>
        public IDescribeDBClusterAutomatedBackupsPaginator DescribeDBClusterAutomatedBackups(DescribeDBClusterAutomatedBackupsRequest request) 
        {
            return new DescribeDBClusterAutomatedBackupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeDBClusterBacktracks operation
        ///</summary>
        public IDescribeDBClusterBacktracksPaginator DescribeDBClusterBacktracks(DescribeDBClusterBacktracksRequest request) 
        {
            return new DescribeDBClusterBacktracksPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeDBClusterEndpoints operation
        ///</summary>
        public IDescribeDBClusterEndpointsPaginator DescribeDBClusterEndpoints(DescribeDBClusterEndpointsRequest request) 
        {
            return new DescribeDBClusterEndpointsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeDBClusterParameterGroups operation
        ///</summary>
        public IDescribeDBClusterParameterGroupsPaginator DescribeDBClusterParameterGroups(DescribeDBClusterParameterGroupsRequest request) 
        {
            return new DescribeDBClusterParameterGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeDBClusterParameters operation
        ///</summary>
        public IDescribeDBClusterParametersPaginator DescribeDBClusterParameters(DescribeDBClusterParametersRequest request) 
        {
            return new DescribeDBClusterParametersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeDBClusters operation
        ///</summary>
        public IDescribeDBClustersPaginator DescribeDBClusters(DescribeDBClustersRequest request) 
        {
            return new DescribeDBClustersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeDBClusterSnapshots operation
        ///</summary>
        public IDescribeDBClusterSnapshotsPaginator DescribeDBClusterSnapshots(DescribeDBClusterSnapshotsRequest request) 
        {
            return new DescribeDBClusterSnapshotsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeDBEngineVersions operation
        ///</summary>
        public IDescribeDBEngineVersionsPaginator DescribeDBEngineVersions(DescribeDBEngineVersionsRequest request) 
        {
            return new DescribeDBEngineVersionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeDBInstanceAutomatedBackups operation
        ///</summary>
        public IDescribeDBInstanceAutomatedBackupsPaginator DescribeDBInstanceAutomatedBackups(DescribeDBInstanceAutomatedBackupsRequest request) 
        {
            return new DescribeDBInstanceAutomatedBackupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeDBInstances operation
        ///</summary>
        public IDescribeDBInstancesPaginator DescribeDBInstances(DescribeDBInstancesRequest request) 
        {
            return new DescribeDBInstancesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeDBLogFiles operation
        ///</summary>
        public IDescribeDBLogFilesPaginator DescribeDBLogFiles(DescribeDBLogFilesRequest request) 
        {
            return new DescribeDBLogFilesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeDBMajorEngineVersions operation
        ///</summary>
        public IDescribeDBMajorEngineVersionsPaginator DescribeDBMajorEngineVersions(DescribeDBMajorEngineVersionsRequest request) 
        {
            return new DescribeDBMajorEngineVersionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeDBParameterGroups operation
        ///</summary>
        public IDescribeDBParameterGroupsPaginator DescribeDBParameterGroups(DescribeDBParameterGroupsRequest request) 
        {
            return new DescribeDBParameterGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeDBParameters operation
        ///</summary>
        public IDescribeDBParametersPaginator DescribeDBParameters(DescribeDBParametersRequest request) 
        {
            return new DescribeDBParametersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeDBProxies operation
        ///</summary>
        public IDescribeDBProxiesPaginator DescribeDBProxies(DescribeDBProxiesRequest request) 
        {
            return new DescribeDBProxiesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeDBProxyEndpoints operation
        ///</summary>
        public IDescribeDBProxyEndpointsPaginator DescribeDBProxyEndpoints(DescribeDBProxyEndpointsRequest request) 
        {
            return new DescribeDBProxyEndpointsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeDBProxyTargetGroups operation
        ///</summary>
        public IDescribeDBProxyTargetGroupsPaginator DescribeDBProxyTargetGroups(DescribeDBProxyTargetGroupsRequest request) 
        {
            return new DescribeDBProxyTargetGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeDBProxyTargets operation
        ///</summary>
        public IDescribeDBProxyTargetsPaginator DescribeDBProxyTargets(DescribeDBProxyTargetsRequest request) 
        {
            return new DescribeDBProxyTargetsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeDBRecommendations operation
        ///</summary>
        public IDescribeDBRecommendationsPaginator DescribeDBRecommendations(DescribeDBRecommendationsRequest request) 
        {
            return new DescribeDBRecommendationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeDBSecurityGroups operation
        ///</summary>
        public IDescribeDBSecurityGroupsPaginator DescribeDBSecurityGroups(DescribeDBSecurityGroupsRequest request) 
        {
            return new DescribeDBSecurityGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeDBSnapshots operation
        ///</summary>
        public IDescribeDBSnapshotsPaginator DescribeDBSnapshots(DescribeDBSnapshotsRequest request) 
        {
            return new DescribeDBSnapshotsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeDBSnapshotTenantDatabases operation
        ///</summary>
        public IDescribeDBSnapshotTenantDatabasesPaginator DescribeDBSnapshotTenantDatabases(DescribeDBSnapshotTenantDatabasesRequest request) 
        {
            return new DescribeDBSnapshotTenantDatabasesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeDBSubnetGroups operation
        ///</summary>
        public IDescribeDBSubnetGroupsPaginator DescribeDBSubnetGroups(DescribeDBSubnetGroupsRequest request) 
        {
            return new DescribeDBSubnetGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeEngineDefaultParameters operation
        ///</summary>
        public IDescribeEngineDefaultParametersPaginator DescribeEngineDefaultParameters(DescribeEngineDefaultParametersRequest request) 
        {
            return new DescribeEngineDefaultParametersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeEvents operation
        ///</summary>
        public IDescribeEventsPaginator DescribeEvents(DescribeEventsRequest request) 
        {
            return new DescribeEventsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeEventSubscriptions operation
        ///</summary>
        public IDescribeEventSubscriptionsPaginator DescribeEventSubscriptions(DescribeEventSubscriptionsRequest request) 
        {
            return new DescribeEventSubscriptionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeExportTasks operation
        ///</summary>
        public IDescribeExportTasksPaginator DescribeExportTasks(DescribeExportTasksRequest request) 
        {
            return new DescribeExportTasksPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeGlobalClusters operation
        ///</summary>
        public IDescribeGlobalClustersPaginator DescribeGlobalClusters(DescribeGlobalClustersRequest request) 
        {
            return new DescribeGlobalClustersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeIntegrations operation
        ///</summary>
        public IDescribeIntegrationsPaginator DescribeIntegrations(DescribeIntegrationsRequest request) 
        {
            return new DescribeIntegrationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeOptionGroupOptions operation
        ///</summary>
        public IDescribeOptionGroupOptionsPaginator DescribeOptionGroupOptions(DescribeOptionGroupOptionsRequest request) 
        {
            return new DescribeOptionGroupOptionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeOptionGroups operation
        ///</summary>
        public IDescribeOptionGroupsPaginator DescribeOptionGroups(DescribeOptionGroupsRequest request) 
        {
            return new DescribeOptionGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeOrderableDBInstanceOptions operation
        ///</summary>
        public IDescribeOrderableDBInstanceOptionsPaginator DescribeOrderableDBInstanceOptions(DescribeOrderableDBInstanceOptionsRequest request) 
        {
            return new DescribeOrderableDBInstanceOptionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribePendingMaintenanceActions operation
        ///</summary>
        public IDescribePendingMaintenanceActionsPaginator DescribePendingMaintenanceActions(DescribePendingMaintenanceActionsRequest request) 
        {
            return new DescribePendingMaintenanceActionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeReservedDBInstances operation
        ///</summary>
        public IDescribeReservedDBInstancesPaginator DescribeReservedDBInstances(DescribeReservedDBInstancesRequest request) 
        {
            return new DescribeReservedDBInstancesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeReservedDBInstancesOfferings operation
        ///</summary>
        public IDescribeReservedDBInstancesOfferingsPaginator DescribeReservedDBInstancesOfferings(DescribeReservedDBInstancesOfferingsRequest request) 
        {
            return new DescribeReservedDBInstancesOfferingsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeSourceRegions operation
        ///</summary>
        public IDescribeSourceRegionsPaginator DescribeSourceRegions(DescribeSourceRegionsRequest request) 
        {
            return new DescribeSourceRegionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeTenantDatabases operation
        ///</summary>
        public IDescribeTenantDatabasesPaginator DescribeTenantDatabases(DescribeTenantDatabasesRequest request) 
        {
            return new DescribeTenantDatabasesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DownloadDBLogFilePortion operation
        ///</summary>
        public IDownloadDBLogFilePortionPaginator DownloadDBLogFilePortion(DownloadDBLogFilePortionRequest request) 
        {
            return new DownloadDBLogFilePortionPaginator(this.client, request);
        }
    }
}