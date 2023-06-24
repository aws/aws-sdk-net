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
        IDescribeApplicableIndividualAssessmentsPaginator DescribeApplicableIndividualAssessments(DescribeApplicableIndividualAssessmentsRequest request);

        /// <summary>
        /// Paginator for DescribeCertificates operation
        ///</summary>
        IDescribeCertificatesPaginator DescribeCertificates(DescribeCertificatesRequest request);

        /// <summary>
        /// Paginator for DescribeConnections operation
        ///</summary>
        IDescribeConnectionsPaginator DescribeConnections(DescribeConnectionsRequest request);

        /// <summary>
        /// Paginator for DescribeEndpoints operation
        ///</summary>
        IDescribeEndpointsPaginator DescribeEndpoints(DescribeEndpointsRequest request);

        /// <summary>
        /// Paginator for DescribeEndpointSettings operation
        ///</summary>
        IDescribeEndpointSettingsPaginator DescribeEndpointSettings(DescribeEndpointSettingsRequest request);

        /// <summary>
        /// Paginator for DescribeEndpointTypes operation
        ///</summary>
        IDescribeEndpointTypesPaginator DescribeEndpointTypes(DescribeEndpointTypesRequest request);

        /// <summary>
        /// Paginator for DescribeEvents operation
        ///</summary>
        IDescribeEventsPaginator DescribeEvents(DescribeEventsRequest request);

        /// <summary>
        /// Paginator for DescribeEventSubscriptions operation
        ///</summary>
        IDescribeEventSubscriptionsPaginator DescribeEventSubscriptions(DescribeEventSubscriptionsRequest request);

        /// <summary>
        /// Paginator for DescribeFleetAdvisorCollectors operation
        ///</summary>
        IDescribeFleetAdvisorCollectorsPaginator DescribeFleetAdvisorCollectors(DescribeFleetAdvisorCollectorsRequest request);

        /// <summary>
        /// Paginator for DescribeFleetAdvisorDatabases operation
        ///</summary>
        IDescribeFleetAdvisorDatabasesPaginator DescribeFleetAdvisorDatabases(DescribeFleetAdvisorDatabasesRequest request);

        /// <summary>
        /// Paginator for DescribeFleetAdvisorLsaAnalysis operation
        ///</summary>
        IDescribeFleetAdvisorLsaAnalysisPaginator DescribeFleetAdvisorLsaAnalysis(DescribeFleetAdvisorLsaAnalysisRequest request);

        /// <summary>
        /// Paginator for DescribeFleetAdvisorSchemaObjectSummary operation
        ///</summary>
        IDescribeFleetAdvisorSchemaObjectSummaryPaginator DescribeFleetAdvisorSchemaObjectSummary(DescribeFleetAdvisorSchemaObjectSummaryRequest request);

        /// <summary>
        /// Paginator for DescribeFleetAdvisorSchemas operation
        ///</summary>
        IDescribeFleetAdvisorSchemasPaginator DescribeFleetAdvisorSchemas(DescribeFleetAdvisorSchemasRequest request);

        /// <summary>
        /// Paginator for DescribeOrderableReplicationInstances operation
        ///</summary>
        IDescribeOrderableReplicationInstancesPaginator DescribeOrderableReplicationInstances(DescribeOrderableReplicationInstancesRequest request);

        /// <summary>
        /// Paginator for DescribePendingMaintenanceActions operation
        ///</summary>
        IDescribePendingMaintenanceActionsPaginator DescribePendingMaintenanceActions(DescribePendingMaintenanceActionsRequest request);

        /// <summary>
        /// Paginator for DescribeRecommendationLimitations operation
        ///</summary>
        IDescribeRecommendationLimitationsPaginator DescribeRecommendationLimitations(DescribeRecommendationLimitationsRequest request);

        /// <summary>
        /// Paginator for DescribeRecommendations operation
        ///</summary>
        IDescribeRecommendationsPaginator DescribeRecommendations(DescribeRecommendationsRequest request);

        /// <summary>
        /// Paginator for DescribeReplicationInstances operation
        ///</summary>
        IDescribeReplicationInstancesPaginator DescribeReplicationInstances(DescribeReplicationInstancesRequest request);

        /// <summary>
        /// Paginator for DescribeReplicationInstanceTaskLogs operation
        ///</summary>
        IDescribeReplicationInstanceTaskLogsPaginator DescribeReplicationInstanceTaskLogs(DescribeReplicationInstanceTaskLogsRequest request);

        /// <summary>
        /// Paginator for DescribeReplicationSubnetGroups operation
        ///</summary>
        IDescribeReplicationSubnetGroupsPaginator DescribeReplicationSubnetGroups(DescribeReplicationSubnetGroupsRequest request);

        /// <summary>
        /// Paginator for DescribeReplicationTaskAssessmentResults operation
        ///</summary>
        IDescribeReplicationTaskAssessmentResultsPaginator DescribeReplicationTaskAssessmentResults(DescribeReplicationTaskAssessmentResultsRequest request);

        /// <summary>
        /// Paginator for DescribeReplicationTaskAssessmentRuns operation
        ///</summary>
        IDescribeReplicationTaskAssessmentRunsPaginator DescribeReplicationTaskAssessmentRuns(DescribeReplicationTaskAssessmentRunsRequest request);

        /// <summary>
        /// Paginator for DescribeReplicationTaskIndividualAssessments operation
        ///</summary>
        IDescribeReplicationTaskIndividualAssessmentsPaginator DescribeReplicationTaskIndividualAssessments(DescribeReplicationTaskIndividualAssessmentsRequest request);

        /// <summary>
        /// Paginator for DescribeReplicationTasks operation
        ///</summary>
        IDescribeReplicationTasksPaginator DescribeReplicationTasks(DescribeReplicationTasksRequest request);

        /// <summary>
        /// Paginator for DescribeSchemas operation
        ///</summary>
        IDescribeSchemasPaginator DescribeSchemas(DescribeSchemasRequest request);

        /// <summary>
        /// Paginator for DescribeTableStatistics operation
        ///</summary>
        IDescribeTableStatisticsPaginator DescribeTableStatistics(DescribeTableStatisticsRequest request);
    }
}