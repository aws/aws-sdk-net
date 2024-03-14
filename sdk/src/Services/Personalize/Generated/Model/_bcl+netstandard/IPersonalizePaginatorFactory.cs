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
 * Do not modify this file. This file is generated from the personalize-2018-05-22.normal.json service model.
 */

namespace Amazon.Personalize.Model
{
    /// <summary>
    /// Paginators for the Personalize service
    ///</summary>
    public interface IPersonalizePaginatorFactory
    {

        /// <summary>
        /// Paginator for ListBatchInferenceJobs operation
        ///</summary>
        IListBatchInferenceJobsPaginator ListBatchInferenceJobs(ListBatchInferenceJobsRequest request);

        /// <summary>
        /// Paginator for ListBatchSegmentJobs operation
        ///</summary>
        IListBatchSegmentJobsPaginator ListBatchSegmentJobs(ListBatchSegmentJobsRequest request);

        /// <summary>
        /// Paginator for ListCampaigns operation
        ///</summary>
        IListCampaignsPaginator ListCampaigns(ListCampaignsRequest request);

        /// <summary>
        /// Paginator for ListDatasetExportJobs operation
        ///</summary>
        IListDatasetExportJobsPaginator ListDatasetExportJobs(ListDatasetExportJobsRequest request);

        /// <summary>
        /// Paginator for ListDatasetGroups operation
        ///</summary>
        IListDatasetGroupsPaginator ListDatasetGroups(ListDatasetGroupsRequest request);

        /// <summary>
        /// Paginator for ListDatasetImportJobs operation
        ///</summary>
        IListDatasetImportJobsPaginator ListDatasetImportJobs(ListDatasetImportJobsRequest request);

        /// <summary>
        /// Paginator for ListDatasets operation
        ///</summary>
        IListDatasetsPaginator ListDatasets(ListDatasetsRequest request);

        /// <summary>
        /// Paginator for ListEventTrackers operation
        ///</summary>
        IListEventTrackersPaginator ListEventTrackers(ListEventTrackersRequest request);

        /// <summary>
        /// Paginator for ListFilters operation
        ///</summary>
        IListFiltersPaginator ListFilters(ListFiltersRequest request);

        /// <summary>
        /// Paginator for ListMetricAttributionMetrics operation
        ///</summary>
        IListMetricAttributionMetricsPaginator ListMetricAttributionMetrics(ListMetricAttributionMetricsRequest request);

        /// <summary>
        /// Paginator for ListMetricAttributions operation
        ///</summary>
        IListMetricAttributionsPaginator ListMetricAttributions(ListMetricAttributionsRequest request);

        /// <summary>
        /// Paginator for ListRecipes operation
        ///</summary>
        IListRecipesPaginator ListRecipes(ListRecipesRequest request);

        /// <summary>
        /// Paginator for ListRecommenders operation
        ///</summary>
        IListRecommendersPaginator ListRecommenders(ListRecommendersRequest request);

        /// <summary>
        /// Paginator for ListSchemas operation
        ///</summary>
        IListSchemasPaginator ListSchemas(ListSchemasRequest request);

        /// <summary>
        /// Paginator for ListSolutions operation
        ///</summary>
        IListSolutionsPaginator ListSolutions(ListSolutionsRequest request);

        /// <summary>
        /// Paginator for ListSolutionVersions operation
        ///</summary>
        IListSolutionVersionsPaginator ListSolutionVersions(ListSolutionVersionsRequest request);
    }
}