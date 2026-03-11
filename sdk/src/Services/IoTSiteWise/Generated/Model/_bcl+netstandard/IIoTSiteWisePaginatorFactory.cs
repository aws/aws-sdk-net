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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
 */
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Paginators for the IoTSiteWise service
    ///</summary>
    public interface IIoTSiteWisePaginatorFactory
    {

        /// <summary>
        /// Paginator for BatchGetAssetPropertyAggregates operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IBatchGetAssetPropertyAggregatesPaginator BatchGetAssetPropertyAggregates(BatchGetAssetPropertyAggregatesRequest request);

        /// <summary>
        /// Paginator for BatchGetAssetPropertyValue operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            
            OutputToken = new[] { "NextToken" }
        )]
        IBatchGetAssetPropertyValuePaginator BatchGetAssetPropertyValue(BatchGetAssetPropertyValueRequest request);

        /// <summary>
        /// Paginator for BatchGetAssetPropertyValueHistory operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IBatchGetAssetPropertyValueHistoryPaginator BatchGetAssetPropertyValueHistory(BatchGetAssetPropertyValueHistoryRequest request);

        /// <summary>
        /// Paginator for ExecuteQuery operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IExecuteQueryPaginator ExecuteQuery(ExecuteQueryRequest request);

        /// <summary>
        /// Paginator for GetAssetPropertyAggregates operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetAssetPropertyAggregatesPaginator GetAssetPropertyAggregates(GetAssetPropertyAggregatesRequest request);

        /// <summary>
        /// Paginator for GetAssetPropertyValueHistory operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetAssetPropertyValueHistoryPaginator GetAssetPropertyValueHistory(GetAssetPropertyValueHistoryRequest request);

        /// <summary>
        /// Paginator for GetInterpolatedAssetPropertyValues operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetInterpolatedAssetPropertyValuesPaginator GetInterpolatedAssetPropertyValues(GetInterpolatedAssetPropertyValuesRequest request);

        /// <summary>
        /// Paginator for ListAccessPolicies operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAccessPoliciesPaginator ListAccessPolicies(ListAccessPoliciesRequest request);

        /// <summary>
        /// Paginator for ListActions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListActionsPaginator ListActions(ListActionsRequest request);

        /// <summary>
        /// Paginator for ListAssetModelCompositeModels operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAssetModelCompositeModelsPaginator ListAssetModelCompositeModels(ListAssetModelCompositeModelsRequest request);

        /// <summary>
        /// Paginator for ListAssetModelProperties operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAssetModelPropertiesPaginator ListAssetModelProperties(ListAssetModelPropertiesRequest request);

        /// <summary>
        /// Paginator for ListAssetModels operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAssetModelsPaginator ListAssetModels(ListAssetModelsRequest request);

        /// <summary>
        /// Paginator for ListAssetProperties operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAssetPropertiesPaginator ListAssetProperties(ListAssetPropertiesRequest request);

        /// <summary>
        /// Paginator for ListAssetRelationships operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAssetRelationshipsPaginator ListAssetRelationships(ListAssetRelationshipsRequest request);

        /// <summary>
        /// Paginator for ListAssets operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAssetsPaginator ListAssets(ListAssetsRequest request);

        /// <summary>
        /// Paginator for ListAssociatedAssets operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAssociatedAssetsPaginator ListAssociatedAssets(ListAssociatedAssetsRequest request);

        /// <summary>
        /// Paginator for ListBulkImportJobs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListBulkImportJobsPaginator ListBulkImportJobs(ListBulkImportJobsRequest request);

        /// <summary>
        /// Paginator for ListCompositionRelationships operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListCompositionRelationshipsPaginator ListCompositionRelationships(ListCompositionRelationshipsRequest request);

        /// <summary>
        /// Paginator for ListComputationModelDataBindingUsages operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListComputationModelDataBindingUsagesPaginator ListComputationModelDataBindingUsages(ListComputationModelDataBindingUsagesRequest request);

        /// <summary>
        /// Paginator for ListComputationModelResolveToResources operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListComputationModelResolveToResourcesPaginator ListComputationModelResolveToResources(ListComputationModelResolveToResourcesRequest request);

        /// <summary>
        /// Paginator for ListComputationModels operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListComputationModelsPaginator ListComputationModels(ListComputationModelsRequest request);

        /// <summary>
        /// Paginator for ListDashboards operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListDashboardsPaginator ListDashboards(ListDashboardsRequest request);

        /// <summary>
        /// Paginator for ListDatasets operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListDatasetsPaginator ListDatasets(ListDatasetsRequest request);

        /// <summary>
        /// Paginator for ListExecutions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListExecutionsPaginator ListExecutions(ListExecutionsRequest request);

        /// <summary>
        /// Paginator for ListGateways operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListGatewaysPaginator ListGateways(ListGatewaysRequest request);

        /// <summary>
        /// Paginator for ListInterfaceRelationships operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListInterfaceRelationshipsPaginator ListInterfaceRelationships(ListInterfaceRelationshipsRequest request);

        /// <summary>
        /// Paginator for ListPortals operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListPortalsPaginator ListPortals(ListPortalsRequest request);

        /// <summary>
        /// Paginator for ListProjectAssets operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListProjectAssetsPaginator ListProjectAssets(ListProjectAssetsRequest request);

        /// <summary>
        /// Paginator for ListProjects operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListProjectsPaginator ListProjects(ListProjectsRequest request);

        /// <summary>
        /// Paginator for ListTimeSeries operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListTimeSeriesPaginator ListTimeSeries(ListTimeSeriesRequest request);
    }
}