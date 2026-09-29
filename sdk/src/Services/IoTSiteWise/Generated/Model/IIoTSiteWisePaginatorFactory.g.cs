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

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Paginators for the IoTSiteWise service
    /// </summary>
    public interface IIoTSiteWisePaginatorFactory
    {
        /// <summary>
        /// Paginator for BatchGetAssetPropertyAggregates operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IBatchGetAssetPropertyAggregatesPaginator BatchGetAssetPropertyAggregates(BatchGetAssetPropertyAggregatesRequest request);

        /// <summary>
        /// Paginator for BatchGetAssetPropertyValue operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], OutputToken = ["NextToken"])]
        IBatchGetAssetPropertyValuePaginator BatchGetAssetPropertyValue(BatchGetAssetPropertyValueRequest request);

        /// <summary>
        /// Paginator for BatchGetAssetPropertyValueHistory operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IBatchGetAssetPropertyValueHistoryPaginator BatchGetAssetPropertyValueHistory(BatchGetAssetPropertyValueHistoryRequest request);

        /// <summary>
        /// Paginator for DescribePipelineExecution operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IDescribePipelineExecutionPaginator DescribePipelineExecution(DescribePipelineExecutionRequest request);

        /// <summary>
        /// Paginator for ExecuteQuery operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IExecuteQueryPaginator ExecuteQuery(ExecuteQueryRequest request);

        /// <summary>
        /// Paginator for GetAssetPropertyAggregates operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IGetAssetPropertyAggregatesPaginator GetAssetPropertyAggregates(GetAssetPropertyAggregatesRequest request);

        /// <summary>
        /// Paginator for GetAssetPropertyValueHistory operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IGetAssetPropertyValueHistoryPaginator GetAssetPropertyValueHistory(GetAssetPropertyValueHistoryRequest request);

        /// <summary>
        /// Paginator for GetInterpolatedAssetPropertyValues operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IGetInterpolatedAssetPropertyValuesPaginator GetInterpolatedAssetPropertyValues(GetInterpolatedAssetPropertyValuesRequest request);

        /// <summary>
        /// Paginator for GetQueryResults operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IGetQueryResultsPaginator GetQueryResults(GetQueryResultsRequest request);

        /// <summary>
        /// Paginator for GetSearchResults operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IGetSearchResultsPaginator GetSearchResults(GetSearchResultsRequest request);

        /// <summary>
        /// Paginator for ListAccessPolicies operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAccessPoliciesPaginator ListAccessPolicies(ListAccessPoliciesRequest request);

        /// <summary>
        /// Paginator for ListActions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListActionsPaginator ListActions(ListActionsRequest request);

        /// <summary>
        /// Paginator for ListApplications operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListApplicationsPaginator ListApplications(ListApplicationsRequest request);

        /// <summary>
        /// Paginator for ListAssetModelCompositeModels operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAssetModelCompositeModelsPaginator ListAssetModelCompositeModels(ListAssetModelCompositeModelsRequest request);

        /// <summary>
        /// Paginator for ListAssetModelProperties operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAssetModelPropertiesPaginator ListAssetModelProperties(ListAssetModelPropertiesRequest request);

        /// <summary>
        /// Paginator for ListAssetModels operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAssetModelsPaginator ListAssetModels(ListAssetModelsRequest request);

        /// <summary>
        /// Paginator for ListAssetProperties operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAssetPropertiesPaginator ListAssetProperties(ListAssetPropertiesRequest request);

        /// <summary>
        /// Paginator for ListAssetRelationships operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAssetRelationshipsPaginator ListAssetRelationships(ListAssetRelationshipsRequest request);

        /// <summary>
        /// Paginator for ListAssets operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAssetsPaginator ListAssets(ListAssetsRequest request);

        /// <summary>
        /// Paginator for ListAssociatedAssets operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAssociatedAssetsPaginator ListAssociatedAssets(ListAssociatedAssetsRequest request);

        /// <summary>
        /// Paginator for ListBulkImportJobs operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListBulkImportJobsPaginator ListBulkImportJobs(ListBulkImportJobsRequest request);

        /// <summary>
        /// Paginator for ListCompositionRelationships operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListCompositionRelationshipsPaginator ListCompositionRelationships(ListCompositionRelationshipsRequest request);

        /// <summary>
        /// Paginator for ListComputationModelDataBindingUsages operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListComputationModelDataBindingUsagesPaginator ListComputationModelDataBindingUsages(ListComputationModelDataBindingUsagesRequest request);

        /// <summary>
        /// Paginator for ListComputationModelResolveToResources operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListComputationModelResolveToResourcesPaginator ListComputationModelResolveToResources(ListComputationModelResolveToResourcesRequest request);

        /// <summary>
        /// Paginator for ListComputationModels operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListComputationModelsPaginator ListComputationModels(ListComputationModelsRequest request);

        /// <summary>
        /// Paginator for ListDashboards operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListDashboardsPaginator ListDashboards(ListDashboardsRequest request);

        /// <summary>
        /// Paginator for ListDatasetDataSegmentRelationships operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListDatasetDataSegmentRelationshipsPaginator ListDatasetDataSegmentRelationships(ListDatasetDataSegmentRelationshipsRequest request);

        /// <summary>
        /// Paginator for ListDatasetDataSegments operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListDatasetDataSegmentsPaginator ListDatasetDataSegments(ListDatasetDataSegmentsRequest request);

        /// <summary>
        /// Paginator for ListDatasetExportJobs operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListDatasetExportJobsPaginator ListDatasetExportJobs(ListDatasetExportJobsRequest request);

        /// <summary>
        /// Paginator for ListDatasets operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListDatasetsPaginator ListDatasets(ListDatasetsRequest request);

        /// <summary>
        /// Paginator for ListEnrichmentJobs operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListEnrichmentJobsPaginator ListEnrichmentJobs(ListEnrichmentJobsRequest request);

        /// <summary>
        /// Paginator for ListExecutions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListExecutionsPaginator ListExecutions(ListExecutionsRequest request);

        /// <summary>
        /// Paginator for ListGateways operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListGatewaysPaginator ListGateways(ListGatewaysRequest request);

        /// <summary>
        /// Paginator for ListInterfaceRelationships operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListInterfaceRelationshipsPaginator ListInterfaceRelationships(ListInterfaceRelationshipsRequest request);

        /// <summary>
        /// Paginator for ListPipelineExecutions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListPipelineExecutionsPaginator ListPipelineExecutions(ListPipelineExecutionsRequest request);

        /// <summary>
        /// Paginator for ListPipelines operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListPipelinesPaginator ListPipelines(ListPipelinesRequest request);

        /// <summary>
        /// Paginator for ListPortals operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListPortalsPaginator ListPortals(ListPortalsRequest request);

        /// <summary>
        /// Paginator for ListProjectAssets operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListProjectAssetsPaginator ListProjectAssets(ListProjectAssetsRequest request);

        /// <summary>
        /// Paginator for ListProjects operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListProjectsPaginator ListProjects(ListProjectsRequest request);

        /// <summary>
        /// Paginator for ListQueries operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListQueriesPaginator ListQueries(ListQueriesRequest request);

        /// <summary>
        /// Paginator for ListSearches operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListSearchesPaginator ListSearches(ListSearchesRequest request);

        /// <summary>
        /// Paginator for ListTasks operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListTasksPaginator ListTasks(ListTasksRequest request);

        /// <summary>
        /// Paginator for ListTimeSeries operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListTimeSeriesPaginator ListTimeSeries(ListTimeSeriesRequest request);

        /// <summary>
        /// Paginator for ListWorkspaces operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListWorkspacesPaginator ListWorkspaces(ListWorkspacesRequest request);
    }
}
