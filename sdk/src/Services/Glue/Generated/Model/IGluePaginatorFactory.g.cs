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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Paginators for the Glue service
    /// </summary>
    public interface IGluePaginatorFactory
    {
        /// <summary>
        /// Paginator for DescribeEntity operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], OutputToken = ["NextToken"])]
        IDescribeEntityPaginator DescribeEntity(DescribeEntityRequest request);

        /// <summary>
        /// Paginator for GetBlueprintRuns operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IGetBlueprintRunsPaginator GetBlueprintRuns(GetBlueprintRunsRequest request);

        /// <summary>
        /// Paginator for GetClassifiers operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IGetClassifiersPaginator GetClassifiers(GetClassifiersRequest request);

        /// <summary>
        /// Paginator for GetColumnStatisticsTaskRuns operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IGetColumnStatisticsTaskRunsPaginator GetColumnStatisticsTaskRuns(GetColumnStatisticsTaskRunsRequest request);

        /// <summary>
        /// Paginator for GetConnections operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IGetConnectionsPaginator GetConnections(GetConnectionsRequest request);

        /// <summary>
        /// Paginator for GetCrawlerMetrics operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IGetCrawlerMetricsPaginator GetCrawlerMetrics(GetCrawlerMetricsRequest request);

        /// <summary>
        /// Paginator for GetCrawlers operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IGetCrawlersPaginator GetCrawlers(GetCrawlersRequest request);

        /// <summary>
        /// Paginator for GetDatabases operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IGetDatabasesPaginator GetDatabases(GetDatabasesRequest request);

        /// <summary>
        /// Paginator for GetDevEndpoints operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IGetDevEndpointsPaginator GetDevEndpoints(GetDevEndpointsRequest request);

        /// <summary>
        /// Paginator for GetJobRuns operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IGetJobRunsPaginator GetJobRuns(GetJobRunsRequest request);

        /// <summary>
        /// Paginator for GetJobs operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IGetJobsPaginator GetJobs(GetJobsRequest request);

        /// <summary>
        /// Paginator for GetMLTaskRuns operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IGetMLTaskRunsPaginator GetMLTaskRuns(GetMLTaskRunsRequest request);

        /// <summary>
        /// Paginator for GetMLTransforms operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IGetMLTransformsPaginator GetMLTransforms(GetMLTransformsRequest request);

        /// <summary>
        /// Paginator for GetPartitionIndexes operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], OutputToken = ["NextToken"])]
        IGetPartitionIndexesPaginator GetPartitionIndexes(GetPartitionIndexesRequest request);

        /// <summary>
        /// Paginator for GetPartitions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IGetPartitionsPaginator GetPartitions(GetPartitionsRequest request);

        /// <summary>
        /// Paginator for GetResourcePolicies operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IGetResourcePoliciesPaginator GetResourcePolicies(GetResourcePoliciesRequest request);

        /// <summary>
        /// Paginator for GetSecurityConfigurations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IGetSecurityConfigurationsPaginator GetSecurityConfigurations(GetSecurityConfigurationsRequest request);

        /// <summary>
        /// Paginator for GetTableVersions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IGetTableVersionsPaginator GetTableVersions(GetTableVersionsRequest request);

        /// <summary>
        /// Paginator for GetTables operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IGetTablesPaginator GetTables(GetTablesRequest request);

        /// <summary>
        /// Paginator for GetTriggers operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IGetTriggersPaginator GetTriggers(GetTriggersRequest request);

        /// <summary>
        /// Paginator for GetUnfilteredPartitionsMetadata operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IGetUnfilteredPartitionsMetadataPaginator GetUnfilteredPartitionsMetadata(GetUnfilteredPartitionsMetadataRequest request);

        /// <summary>
        /// Paginator for GetUserDefinedFunctions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IGetUserDefinedFunctionsPaginator GetUserDefinedFunctions(GetUserDefinedFunctionsRequest request);

        /// <summary>
        /// Paginator for GetWorkflowRuns operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IGetWorkflowRunsPaginator GetWorkflowRuns(GetWorkflowRunsRequest request);

        /// <summary>
        /// Paginator for ListAssetTypes operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAssetTypesPaginator ListAssetTypes(ListAssetTypesRequest request);

        /// <summary>
        /// Paginator for ListBlueprints operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListBlueprintsPaginator ListBlueprints(ListBlueprintsRequest request);

        /// <summary>
        /// Paginator for ListColumnStatisticsTaskRuns operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListColumnStatisticsTaskRunsPaginator ListColumnStatisticsTaskRuns(ListColumnStatisticsTaskRunsRequest request);

        /// <summary>
        /// Paginator for ListConnectionTypes operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListConnectionTypesPaginator ListConnectionTypes(ListConnectionTypesRequest request);

        /// <summary>
        /// Paginator for ListCrawlers operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListCrawlersPaginator ListCrawlers(ListCrawlersRequest request);

        /// <summary>
        /// Paginator for ListCustomEntityTypes operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListCustomEntityTypesPaginator ListCustomEntityTypes(ListCustomEntityTypesRequest request);

        /// <summary>
        /// Paginator for ListDataQualityResults operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListDataQualityResultsPaginator ListDataQualityResults(ListDataQualityResultsRequest request);

        /// <summary>
        /// Paginator for ListDataQualityResultsV2 operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListDataQualityResultsV2Paginator ListDataQualityResultsV2(ListDataQualityResultsV2Request request);

        /// <summary>
        /// Paginator for ListDataQualityRuleRecommendationRuns operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListDataQualityRuleRecommendationRunsPaginator ListDataQualityRuleRecommendationRuns(ListDataQualityRuleRecommendationRunsRequest request);

        /// <summary>
        /// Paginator for ListDataQualityRulesetEvaluationRuns operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListDataQualityRulesetEvaluationRunsPaginator ListDataQualityRulesetEvaluationRuns(ListDataQualityRulesetEvaluationRunsRequest request);

        /// <summary>
        /// Paginator for ListDataQualityRulesets operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListDataQualityRulesetsPaginator ListDataQualityRulesets(ListDataQualityRulesetsRequest request);

        /// <summary>
        /// Paginator for ListDevEndpoints operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListDevEndpointsPaginator ListDevEndpoints(ListDevEndpointsRequest request);

        /// <summary>
        /// Paginator for ListEntities operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], OutputToken = ["NextToken"])]
        IListEntitiesPaginator ListEntities(ListEntitiesRequest request);

        /// <summary>
        /// Paginator for ListFormTypes operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListFormTypesPaginator ListFormTypes(ListFormTypesRequest request);

        /// <summary>
        /// Paginator for ListGlossaries operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListGlossariesPaginator ListGlossaries(ListGlossariesRequest request);

        /// <summary>
        /// Paginator for ListGlossaryTerms operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListGlossaryTermsPaginator ListGlossaryTerms(ListGlossaryTermsRequest request);

        /// <summary>
        /// Paginator for ListIterableForms operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListIterableFormsPaginator ListIterableForms(ListIterableFormsRequest request);

        /// <summary>
        /// Paginator for ListJobs operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListJobsPaginator ListJobs(ListJobsRequest request);

        /// <summary>
        /// Paginator for ListMLTransforms operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListMLTransformsPaginator ListMLTransforms(ListMLTransformsRequest request);

        /// <summary>
        /// Paginator for ListMaterializedViewRefreshTaskRuns operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListMaterializedViewRefreshTaskRunsPaginator ListMaterializedViewRefreshTaskRuns(ListMaterializedViewRefreshTaskRunsRequest request);

        /// <summary>
        /// Paginator for ListRegistries operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListRegistriesPaginator ListRegistries(ListRegistriesRequest request);

        /// <summary>
        /// Paginator for ListSchemaVersions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListSchemaVersionsPaginator ListSchemaVersions(ListSchemaVersionsRequest request);

        /// <summary>
        /// Paginator for ListSchemas operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListSchemasPaginator ListSchemas(ListSchemasRequest request);

        /// <summary>
        /// Paginator for ListSessions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListSessionsPaginator ListSessions(ListSessionsRequest request);

        /// <summary>
        /// Paginator for ListTableOptimizerRuns operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListTableOptimizerRunsPaginator ListTableOptimizerRuns(ListTableOptimizerRunsRequest request);

        /// <summary>
        /// Paginator for ListTriggers operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListTriggersPaginator ListTriggers(ListTriggersRequest request);

        /// <summary>
        /// Paginator for ListUsageProfiles operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListUsageProfilesPaginator ListUsageProfiles(ListUsageProfilesRequest request);

        /// <summary>
        /// Paginator for ListWorkflows operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListWorkflowsPaginator ListWorkflows(ListWorkflowsRequest request);

        /// <summary>
        /// Paginator for SearchAssets operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        ISearchAssetsPaginator SearchAssets(SearchAssetsRequest request);

        /// <summary>
        /// Paginator for SearchTables operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        ISearchTablesPaginator SearchTables(SearchTablesRequest request);
    }
}
