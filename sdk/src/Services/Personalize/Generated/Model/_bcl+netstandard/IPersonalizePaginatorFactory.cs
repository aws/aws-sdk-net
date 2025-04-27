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
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
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
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListBatchInferenceJobsPaginator ListBatchInferenceJobs(ListBatchInferenceJobsRequest request);

        /// <summary>
        /// Paginator for ListBatchSegmentJobs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListBatchSegmentJobsPaginator ListBatchSegmentJobs(ListBatchSegmentJobsRequest request);

        /// <summary>
        /// Paginator for ListCampaigns operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListCampaignsPaginator ListCampaigns(ListCampaignsRequest request);

        /// <summary>
        /// Paginator for ListDatasetExportJobs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListDatasetExportJobsPaginator ListDatasetExportJobs(ListDatasetExportJobsRequest request);

        /// <summary>
        /// Paginator for ListDatasetGroups operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListDatasetGroupsPaginator ListDatasetGroups(ListDatasetGroupsRequest request);

        /// <summary>
        /// Paginator for ListDatasetImportJobs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListDatasetImportJobsPaginator ListDatasetImportJobs(ListDatasetImportJobsRequest request);

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
        /// Paginator for ListEventTrackers operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListEventTrackersPaginator ListEventTrackers(ListEventTrackersRequest request);

        /// <summary>
        /// Paginator for ListFilters operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListFiltersPaginator ListFilters(ListFiltersRequest request);

        /// <summary>
        /// Paginator for ListMetricAttributionMetrics operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListMetricAttributionMetricsPaginator ListMetricAttributionMetrics(ListMetricAttributionMetricsRequest request);

        /// <summary>
        /// Paginator for ListMetricAttributions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListMetricAttributionsPaginator ListMetricAttributions(ListMetricAttributionsRequest request);

        /// <summary>
        /// Paginator for ListRecipes operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListRecipesPaginator ListRecipes(ListRecipesRequest request);

        /// <summary>
        /// Paginator for ListRecommenders operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListRecommendersPaginator ListRecommenders(ListRecommendersRequest request);

        /// <summary>
        /// Paginator for ListSchemas operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListSchemasPaginator ListSchemas(ListSchemasRequest request);

        /// <summary>
        /// Paginator for ListSolutions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListSolutionsPaginator ListSolutions(ListSolutionsRequest request);

        /// <summary>
        /// Paginator for ListSolutionVersions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListSolutionVersionsPaginator ListSolutionVersions(ListSolutionVersionsRequest request);
    }
}