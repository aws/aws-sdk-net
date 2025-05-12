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
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Paginators for the DatabaseMigrationService service
    ///</summary>
    public interface IDatabaseMigrationServicePaginatorFactory
    {

        /// <summary>
        /// Paginator for DescribeApplicableIndividualAssessments operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeApplicableIndividualAssessmentsPaginator DescribeApplicableIndividualAssessments(DescribeApplicableIndividualAssessmentsRequest request);

        /// <summary>
        /// Paginator for DescribeCertificates operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeCertificatesPaginator DescribeCertificates(DescribeCertificatesRequest request);

        /// <summary>
        /// Paginator for DescribeConnections operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeConnectionsPaginator DescribeConnections(DescribeConnectionsRequest request);

        /// <summary>
        /// Paginator for DescribeDataMigrations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeDataMigrationsPaginator DescribeDataMigrations(DescribeDataMigrationsRequest request);

        /// <summary>
        /// Paginator for DescribeDataProviders operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeDataProvidersPaginator DescribeDataProviders(DescribeDataProvidersRequest request);

        /// <summary>
        /// Paginator for DescribeEndpoints operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeEndpointsPaginator DescribeEndpoints(DescribeEndpointsRequest request);

        /// <summary>
        /// Paginator for DescribeEndpointSettings operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeEndpointSettingsPaginator DescribeEndpointSettings(DescribeEndpointSettingsRequest request);

        /// <summary>
        /// Paginator for DescribeEndpointTypes operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeEndpointTypesPaginator DescribeEndpointTypes(DescribeEndpointTypesRequest request);

        /// <summary>
        /// Paginator for DescribeEngineVersions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeEngineVersionsPaginator DescribeEngineVersions(DescribeEngineVersionsRequest request);

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
        /// Paginator for DescribeExtensionPackAssociations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeExtensionPackAssociationsPaginator DescribeExtensionPackAssociations(DescribeExtensionPackAssociationsRequest request);

        /// <summary>
        /// Paginator for DescribeFleetAdvisorCollectors operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeFleetAdvisorCollectorsPaginator DescribeFleetAdvisorCollectors(DescribeFleetAdvisorCollectorsRequest request);

        /// <summary>
        /// Paginator for DescribeFleetAdvisorDatabases operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeFleetAdvisorDatabasesPaginator DescribeFleetAdvisorDatabases(DescribeFleetAdvisorDatabasesRequest request);

        /// <summary>
        /// Paginator for DescribeFleetAdvisorLsaAnalysis operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeFleetAdvisorLsaAnalysisPaginator DescribeFleetAdvisorLsaAnalysis(DescribeFleetAdvisorLsaAnalysisRequest request);

        /// <summary>
        /// Paginator for DescribeFleetAdvisorSchemaObjectSummary operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeFleetAdvisorSchemaObjectSummaryPaginator DescribeFleetAdvisorSchemaObjectSummary(DescribeFleetAdvisorSchemaObjectSummaryRequest request);

        /// <summary>
        /// Paginator for DescribeFleetAdvisorSchemas operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeFleetAdvisorSchemasPaginator DescribeFleetAdvisorSchemas(DescribeFleetAdvisorSchemasRequest request);

        /// <summary>
        /// Paginator for DescribeInstanceProfiles operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeInstanceProfilesPaginator DescribeInstanceProfiles(DescribeInstanceProfilesRequest request);

        /// <summary>
        /// Paginator for DescribeMetadataModelAssessments operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeMetadataModelAssessmentsPaginator DescribeMetadataModelAssessments(DescribeMetadataModelAssessmentsRequest request);

        /// <summary>
        /// Paginator for DescribeMetadataModelConversions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeMetadataModelConversionsPaginator DescribeMetadataModelConversions(DescribeMetadataModelConversionsRequest request);

        /// <summary>
        /// Paginator for DescribeMetadataModelExportsAsScript operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeMetadataModelExportsAsScriptPaginator DescribeMetadataModelExportsAsScript(DescribeMetadataModelExportsAsScriptRequest request);

        /// <summary>
        /// Paginator for DescribeMetadataModelExportsToTarget operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeMetadataModelExportsToTargetPaginator DescribeMetadataModelExportsToTarget(DescribeMetadataModelExportsToTargetRequest request);

        /// <summary>
        /// Paginator for DescribeMetadataModelImports operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeMetadataModelImportsPaginator DescribeMetadataModelImports(DescribeMetadataModelImportsRequest request);

        /// <summary>
        /// Paginator for DescribeMigrationProjects operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeMigrationProjectsPaginator DescribeMigrationProjects(DescribeMigrationProjectsRequest request);

        /// <summary>
        /// Paginator for DescribeOrderableReplicationInstances operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeOrderableReplicationInstancesPaginator DescribeOrderableReplicationInstances(DescribeOrderableReplicationInstancesRequest request);

        /// <summary>
        /// Paginator for DescribePendingMaintenanceActions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribePendingMaintenanceActionsPaginator DescribePendingMaintenanceActions(DescribePendingMaintenanceActionsRequest request);

        /// <summary>
        /// Paginator for DescribeRecommendationLimitations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeRecommendationLimitationsPaginator DescribeRecommendationLimitations(DescribeRecommendationLimitationsRequest request);

        /// <summary>
        /// Paginator for DescribeRecommendations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeRecommendationsPaginator DescribeRecommendations(DescribeRecommendationsRequest request);

        /// <summary>
        /// Paginator for DescribeReplicationConfigs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeReplicationConfigsPaginator DescribeReplicationConfigs(DescribeReplicationConfigsRequest request);

        /// <summary>
        /// Paginator for DescribeReplicationInstances operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeReplicationInstancesPaginator DescribeReplicationInstances(DescribeReplicationInstancesRequest request);

        /// <summary>
        /// Paginator for DescribeReplicationInstanceTaskLogs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeReplicationInstanceTaskLogsPaginator DescribeReplicationInstanceTaskLogs(DescribeReplicationInstanceTaskLogsRequest request);

        /// <summary>
        /// Paginator for DescribeReplications operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeReplicationsPaginator DescribeReplications(DescribeReplicationsRequest request);

        /// <summary>
        /// Paginator for DescribeReplicationSubnetGroups operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeReplicationSubnetGroupsPaginator DescribeReplicationSubnetGroups(DescribeReplicationSubnetGroupsRequest request);

        /// <summary>
        /// Paginator for DescribeReplicationTableStatistics operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeReplicationTableStatisticsPaginator DescribeReplicationTableStatistics(DescribeReplicationTableStatisticsRequest request);

        /// <summary>
        /// Paginator for DescribeReplicationTaskAssessmentResults operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeReplicationTaskAssessmentResultsPaginator DescribeReplicationTaskAssessmentResults(DescribeReplicationTaskAssessmentResultsRequest request);

        /// <summary>
        /// Paginator for DescribeReplicationTaskAssessmentRuns operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeReplicationTaskAssessmentRunsPaginator DescribeReplicationTaskAssessmentRuns(DescribeReplicationTaskAssessmentRunsRequest request);

        /// <summary>
        /// Paginator for DescribeReplicationTaskIndividualAssessments operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeReplicationTaskIndividualAssessmentsPaginator DescribeReplicationTaskIndividualAssessments(DescribeReplicationTaskIndividualAssessmentsRequest request);

        /// <summary>
        /// Paginator for DescribeReplicationTasks operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeReplicationTasksPaginator DescribeReplicationTasks(DescribeReplicationTasksRequest request);

        /// <summary>
        /// Paginator for DescribeSchemas operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeSchemasPaginator DescribeSchemas(DescribeSchemasRequest request);

        /// <summary>
        /// Paginator for DescribeTableStatistics operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeTableStatisticsPaginator DescribeTableStatistics(DescribeTableStatisticsRequest request);
    }
}