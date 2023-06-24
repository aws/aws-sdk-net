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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Paginators for the Glue service
    ///</summary>
    public interface IGluePaginatorFactory
    {

        /// <summary>
        /// Paginator for GetBlueprintRuns operation
        ///</summary>
        IGetBlueprintRunsPaginator GetBlueprintRuns(GetBlueprintRunsRequest request);

        /// <summary>
        /// Paginator for GetClassifiers operation
        ///</summary>
        IGetClassifiersPaginator GetClassifiers(GetClassifiersRequest request);

        /// <summary>
        /// Paginator for GetConnections operation
        ///</summary>
        IGetConnectionsPaginator GetConnections(GetConnectionsRequest request);

        /// <summary>
        /// Paginator for GetCrawlerMetrics operation
        ///</summary>
        IGetCrawlerMetricsPaginator GetCrawlerMetrics(GetCrawlerMetricsRequest request);

        /// <summary>
        /// Paginator for GetCrawlers operation
        ///</summary>
        IGetCrawlersPaginator GetCrawlers(GetCrawlersRequest request);

        /// <summary>
        /// Paginator for GetDatabases operation
        ///</summary>
        IGetDatabasesPaginator GetDatabases(GetDatabasesRequest request);

        /// <summary>
        /// Paginator for GetDevEndpoints operation
        ///</summary>
        IGetDevEndpointsPaginator GetDevEndpoints(GetDevEndpointsRequest request);

        /// <summary>
        /// Paginator for GetJobRuns operation
        ///</summary>
        IGetJobRunsPaginator GetJobRuns(GetJobRunsRequest request);

        /// <summary>
        /// Paginator for GetJobs operation
        ///</summary>
        IGetJobsPaginator GetJobs(GetJobsRequest request);

        /// <summary>
        /// Paginator for GetMLTaskRuns operation
        ///</summary>
        IGetMLTaskRunsPaginator GetMLTaskRuns(GetMLTaskRunsRequest request);

        /// <summary>
        /// Paginator for GetMLTransforms operation
        ///</summary>
        IGetMLTransformsPaginator GetMLTransforms(GetMLTransformsRequest request);

        /// <summary>
        /// Paginator for GetPartitionIndexes operation
        ///</summary>
        IGetPartitionIndexesPaginator GetPartitionIndexes(GetPartitionIndexesRequest request);

        /// <summary>
        /// Paginator for GetPartitions operation
        ///</summary>
        IGetPartitionsPaginator GetPartitions(GetPartitionsRequest request);

        /// <summary>
        /// Paginator for GetResourcePolicies operation
        ///</summary>
        IGetResourcePoliciesPaginator GetResourcePolicies(GetResourcePoliciesRequest request);

        /// <summary>
        /// Paginator for GetSecurityConfigurations operation
        ///</summary>
        IGetSecurityConfigurationsPaginator GetSecurityConfigurations(GetSecurityConfigurationsRequest request);

        /// <summary>
        /// Paginator for GetTables operation
        ///</summary>
        IGetTablesPaginator GetTables(GetTablesRequest request);

        /// <summary>
        /// Paginator for GetTableVersions operation
        ///</summary>
        IGetTableVersionsPaginator GetTableVersions(GetTableVersionsRequest request);

        /// <summary>
        /// Paginator for GetTriggers operation
        ///</summary>
        IGetTriggersPaginator GetTriggers(GetTriggersRequest request);

        /// <summary>
        /// Paginator for GetUnfilteredPartitionsMetadata operation
        ///</summary>
        IGetUnfilteredPartitionsMetadataPaginator GetUnfilteredPartitionsMetadata(GetUnfilteredPartitionsMetadataRequest request);

        /// <summary>
        /// Paginator for GetUserDefinedFunctions operation
        ///</summary>
        IGetUserDefinedFunctionsPaginator GetUserDefinedFunctions(GetUserDefinedFunctionsRequest request);

        /// <summary>
        /// Paginator for GetWorkflowRuns operation
        ///</summary>
        IGetWorkflowRunsPaginator GetWorkflowRuns(GetWorkflowRunsRequest request);

        /// <summary>
        /// Paginator for ListBlueprints operation
        ///</summary>
        IListBlueprintsPaginator ListBlueprints(ListBlueprintsRequest request);

        /// <summary>
        /// Paginator for ListCrawlers operation
        ///</summary>
        IListCrawlersPaginator ListCrawlers(ListCrawlersRequest request);

        /// <summary>
        /// Paginator for ListCustomEntityTypes operation
        ///</summary>
        IListCustomEntityTypesPaginator ListCustomEntityTypes(ListCustomEntityTypesRequest request);

        /// <summary>
        /// Paginator for ListDataQualityResults operation
        ///</summary>
        IListDataQualityResultsPaginator ListDataQualityResults(ListDataQualityResultsRequest request);

        /// <summary>
        /// Paginator for ListDataQualityRuleRecommendationRuns operation
        ///</summary>
        IListDataQualityRuleRecommendationRunsPaginator ListDataQualityRuleRecommendationRuns(ListDataQualityRuleRecommendationRunsRequest request);

        /// <summary>
        /// Paginator for ListDataQualityRulesetEvaluationRuns operation
        ///</summary>
        IListDataQualityRulesetEvaluationRunsPaginator ListDataQualityRulesetEvaluationRuns(ListDataQualityRulesetEvaluationRunsRequest request);

        /// <summary>
        /// Paginator for ListDataQualityRulesets operation
        ///</summary>
        IListDataQualityRulesetsPaginator ListDataQualityRulesets(ListDataQualityRulesetsRequest request);

        /// <summary>
        /// Paginator for ListDevEndpoints operation
        ///</summary>
        IListDevEndpointsPaginator ListDevEndpoints(ListDevEndpointsRequest request);

        /// <summary>
        /// Paginator for ListJobs operation
        ///</summary>
        IListJobsPaginator ListJobs(ListJobsRequest request);

        /// <summary>
        /// Paginator for ListMLTransforms operation
        ///</summary>
        IListMLTransformsPaginator ListMLTransforms(ListMLTransformsRequest request);

        /// <summary>
        /// Paginator for ListRegistries operation
        ///</summary>
        IListRegistriesPaginator ListRegistries(ListRegistriesRequest request);

        /// <summary>
        /// Paginator for ListSchemas operation
        ///</summary>
        IListSchemasPaginator ListSchemas(ListSchemasRequest request);

        /// <summary>
        /// Paginator for ListSchemaVersions operation
        ///</summary>
        IListSchemaVersionsPaginator ListSchemaVersions(ListSchemaVersionsRequest request);

        /// <summary>
        /// Paginator for ListSessions operation
        ///</summary>
        IListSessionsPaginator ListSessions(ListSessionsRequest request);

        /// <summary>
        /// Paginator for ListTriggers operation
        ///</summary>
        IListTriggersPaginator ListTriggers(ListTriggersRequest request);

        /// <summary>
        /// Paginator for ListWorkflows operation
        ///</summary>
        IListWorkflowsPaginator ListWorkflows(ListWorkflowsRequest request);

        /// <summary>
        /// Paginator for SearchTables operation
        ///</summary>
        ISearchTablesPaginator SearchTables(SearchTablesRequest request);
    }
}