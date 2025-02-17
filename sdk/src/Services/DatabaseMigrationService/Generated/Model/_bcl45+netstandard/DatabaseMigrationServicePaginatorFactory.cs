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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Paginators for the DatabaseMigrationService service
    ///</summary>
    public class DatabaseMigrationServicePaginatorFactory : IDatabaseMigrationServicePaginatorFactory
    {
        private readonly IAmazonDatabaseMigrationService client;

        internal DatabaseMigrationServicePaginatorFactory(IAmazonDatabaseMigrationService client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for DescribeApplicableIndividualAssessments operation
        ///</summary>
        public IDescribeApplicableIndividualAssessmentsPaginator DescribeApplicableIndividualAssessments(DescribeApplicableIndividualAssessmentsRequest request) 
        {
            return new DescribeApplicableIndividualAssessmentsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeCertificates operation
        ///</summary>
        public IDescribeCertificatesPaginator DescribeCertificates(DescribeCertificatesRequest request) 
        {
            return new DescribeCertificatesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeConnections operation
        ///</summary>
        public IDescribeConnectionsPaginator DescribeConnections(DescribeConnectionsRequest request) 
        {
            return new DescribeConnectionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeDataMigrations operation
        ///</summary>
        public IDescribeDataMigrationsPaginator DescribeDataMigrations(DescribeDataMigrationsRequest request) 
        {
            return new DescribeDataMigrationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeDataProviders operation
        ///</summary>
        public IDescribeDataProvidersPaginator DescribeDataProviders(DescribeDataProvidersRequest request) 
        {
            return new DescribeDataProvidersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeEndpoints operation
        ///</summary>
        public IDescribeEndpointsPaginator DescribeEndpoints(DescribeEndpointsRequest request) 
        {
            return new DescribeEndpointsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeEndpointSettings operation
        ///</summary>
        public IDescribeEndpointSettingsPaginator DescribeEndpointSettings(DescribeEndpointSettingsRequest request) 
        {
            return new DescribeEndpointSettingsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeEndpointTypes operation
        ///</summary>
        public IDescribeEndpointTypesPaginator DescribeEndpointTypes(DescribeEndpointTypesRequest request) 
        {
            return new DescribeEndpointTypesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeEngineVersions operation
        ///</summary>
        public IDescribeEngineVersionsPaginator DescribeEngineVersions(DescribeEngineVersionsRequest request) 
        {
            return new DescribeEngineVersionsPaginator(this.client, request);
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
        /// Paginator for DescribeExtensionPackAssociations operation
        ///</summary>
        public IDescribeExtensionPackAssociationsPaginator DescribeExtensionPackAssociations(DescribeExtensionPackAssociationsRequest request) 
        {
            return new DescribeExtensionPackAssociationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeFleetAdvisorCollectors operation
        ///</summary>
        public IDescribeFleetAdvisorCollectorsPaginator DescribeFleetAdvisorCollectors(DescribeFleetAdvisorCollectorsRequest request) 
        {
            return new DescribeFleetAdvisorCollectorsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeFleetAdvisorDatabases operation
        ///</summary>
        public IDescribeFleetAdvisorDatabasesPaginator DescribeFleetAdvisorDatabases(DescribeFleetAdvisorDatabasesRequest request) 
        {
            return new DescribeFleetAdvisorDatabasesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeFleetAdvisorLsaAnalysis operation
        ///</summary>
        public IDescribeFleetAdvisorLsaAnalysisPaginator DescribeFleetAdvisorLsaAnalysis(DescribeFleetAdvisorLsaAnalysisRequest request) 
        {
            return new DescribeFleetAdvisorLsaAnalysisPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeFleetAdvisorSchemaObjectSummary operation
        ///</summary>
        public IDescribeFleetAdvisorSchemaObjectSummaryPaginator DescribeFleetAdvisorSchemaObjectSummary(DescribeFleetAdvisorSchemaObjectSummaryRequest request) 
        {
            return new DescribeFleetAdvisorSchemaObjectSummaryPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeFleetAdvisorSchemas operation
        ///</summary>
        public IDescribeFleetAdvisorSchemasPaginator DescribeFleetAdvisorSchemas(DescribeFleetAdvisorSchemasRequest request) 
        {
            return new DescribeFleetAdvisorSchemasPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeInstanceProfiles operation
        ///</summary>
        public IDescribeInstanceProfilesPaginator DescribeInstanceProfiles(DescribeInstanceProfilesRequest request) 
        {
            return new DescribeInstanceProfilesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeMetadataModelAssessments operation
        ///</summary>
        public IDescribeMetadataModelAssessmentsPaginator DescribeMetadataModelAssessments(DescribeMetadataModelAssessmentsRequest request) 
        {
            return new DescribeMetadataModelAssessmentsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeMetadataModelConversions operation
        ///</summary>
        public IDescribeMetadataModelConversionsPaginator DescribeMetadataModelConversions(DescribeMetadataModelConversionsRequest request) 
        {
            return new DescribeMetadataModelConversionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeMetadataModelExportsAsScript operation
        ///</summary>
        public IDescribeMetadataModelExportsAsScriptPaginator DescribeMetadataModelExportsAsScript(DescribeMetadataModelExportsAsScriptRequest request) 
        {
            return new DescribeMetadataModelExportsAsScriptPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeMetadataModelExportsToTarget operation
        ///</summary>
        public IDescribeMetadataModelExportsToTargetPaginator DescribeMetadataModelExportsToTarget(DescribeMetadataModelExportsToTargetRequest request) 
        {
            return new DescribeMetadataModelExportsToTargetPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeMetadataModelImports operation
        ///</summary>
        public IDescribeMetadataModelImportsPaginator DescribeMetadataModelImports(DescribeMetadataModelImportsRequest request) 
        {
            return new DescribeMetadataModelImportsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeMigrationProjects operation
        ///</summary>
        public IDescribeMigrationProjectsPaginator DescribeMigrationProjects(DescribeMigrationProjectsRequest request) 
        {
            return new DescribeMigrationProjectsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeOrderableReplicationInstances operation
        ///</summary>
        public IDescribeOrderableReplicationInstancesPaginator DescribeOrderableReplicationInstances(DescribeOrderableReplicationInstancesRequest request) 
        {
            return new DescribeOrderableReplicationInstancesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribePendingMaintenanceActions operation
        ///</summary>
        public IDescribePendingMaintenanceActionsPaginator DescribePendingMaintenanceActions(DescribePendingMaintenanceActionsRequest request) 
        {
            return new DescribePendingMaintenanceActionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeRecommendationLimitations operation
        ///</summary>
        public IDescribeRecommendationLimitationsPaginator DescribeRecommendationLimitations(DescribeRecommendationLimitationsRequest request) 
        {
            return new DescribeRecommendationLimitationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeRecommendations operation
        ///</summary>
        public IDescribeRecommendationsPaginator DescribeRecommendations(DescribeRecommendationsRequest request) 
        {
            return new DescribeRecommendationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeReplicationConfigs operation
        ///</summary>
        public IDescribeReplicationConfigsPaginator DescribeReplicationConfigs(DescribeReplicationConfigsRequest request) 
        {
            return new DescribeReplicationConfigsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeReplicationInstances operation
        ///</summary>
        public IDescribeReplicationInstancesPaginator DescribeReplicationInstances(DescribeReplicationInstancesRequest request) 
        {
            return new DescribeReplicationInstancesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeReplicationInstanceTaskLogs operation
        ///</summary>
        public IDescribeReplicationInstanceTaskLogsPaginator DescribeReplicationInstanceTaskLogs(DescribeReplicationInstanceTaskLogsRequest request) 
        {
            return new DescribeReplicationInstanceTaskLogsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeReplications operation
        ///</summary>
        public IDescribeReplicationsPaginator DescribeReplications(DescribeReplicationsRequest request) 
        {
            return new DescribeReplicationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeReplicationSubnetGroups operation
        ///</summary>
        public IDescribeReplicationSubnetGroupsPaginator DescribeReplicationSubnetGroups(DescribeReplicationSubnetGroupsRequest request) 
        {
            return new DescribeReplicationSubnetGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeReplicationTableStatistics operation
        ///</summary>
        public IDescribeReplicationTableStatisticsPaginator DescribeReplicationTableStatistics(DescribeReplicationTableStatisticsRequest request) 
        {
            return new DescribeReplicationTableStatisticsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeReplicationTaskAssessmentResults operation
        ///</summary>
        public IDescribeReplicationTaskAssessmentResultsPaginator DescribeReplicationTaskAssessmentResults(DescribeReplicationTaskAssessmentResultsRequest request) 
        {
            return new DescribeReplicationTaskAssessmentResultsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeReplicationTaskAssessmentRuns operation
        ///</summary>
        public IDescribeReplicationTaskAssessmentRunsPaginator DescribeReplicationTaskAssessmentRuns(DescribeReplicationTaskAssessmentRunsRequest request) 
        {
            return new DescribeReplicationTaskAssessmentRunsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeReplicationTaskIndividualAssessments operation
        ///</summary>
        public IDescribeReplicationTaskIndividualAssessmentsPaginator DescribeReplicationTaskIndividualAssessments(DescribeReplicationTaskIndividualAssessmentsRequest request) 
        {
            return new DescribeReplicationTaskIndividualAssessmentsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeReplicationTasks operation
        ///</summary>
        public IDescribeReplicationTasksPaginator DescribeReplicationTasks(DescribeReplicationTasksRequest request) 
        {
            return new DescribeReplicationTasksPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeSchemas operation
        ///</summary>
        public IDescribeSchemasPaginator DescribeSchemas(DescribeSchemasRequest request) 
        {
            return new DescribeSchemasPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeTableStatistics operation
        ///</summary>
        public IDescribeTableStatisticsPaginator DescribeTableStatistics(DescribeTableStatisticsRequest request) 
        {
            return new DescribeTableStatisticsPaginator(this.client, request);
        }
    }
}