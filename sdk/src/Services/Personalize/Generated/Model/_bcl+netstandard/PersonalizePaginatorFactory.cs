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

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.Personalize.Model
{
    /// <summary>
    /// Paginators for the Personalize service
    ///</summary>
    public class PersonalizePaginatorFactory : IPersonalizePaginatorFactory
    {
        private readonly IAmazonPersonalize client;

        internal PersonalizePaginatorFactory(IAmazonPersonalize client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListBatchInferenceJobs operation
        ///</summary>
        public IListBatchInferenceJobsPaginator ListBatchInferenceJobs(ListBatchInferenceJobsRequest request) 
        {
            return new ListBatchInferenceJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListBatchSegmentJobs operation
        ///</summary>
        public IListBatchSegmentJobsPaginator ListBatchSegmentJobs(ListBatchSegmentJobsRequest request) 
        {
            return new ListBatchSegmentJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCampaigns operation
        ///</summary>
        public IListCampaignsPaginator ListCampaigns(ListCampaignsRequest request) 
        {
            return new ListCampaignsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDatasetExportJobs operation
        ///</summary>
        public IListDatasetExportJobsPaginator ListDatasetExportJobs(ListDatasetExportJobsRequest request) 
        {
            return new ListDatasetExportJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDatasetGroups operation
        ///</summary>
        public IListDatasetGroupsPaginator ListDatasetGroups(ListDatasetGroupsRequest request) 
        {
            return new ListDatasetGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDatasetImportJobs operation
        ///</summary>
        public IListDatasetImportJobsPaginator ListDatasetImportJobs(ListDatasetImportJobsRequest request) 
        {
            return new ListDatasetImportJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDatasets operation
        ///</summary>
        public IListDatasetsPaginator ListDatasets(ListDatasetsRequest request) 
        {
            return new ListDatasetsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListEventTrackers operation
        ///</summary>
        public IListEventTrackersPaginator ListEventTrackers(ListEventTrackersRequest request) 
        {
            return new ListEventTrackersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListFilters operation
        ///</summary>
        public IListFiltersPaginator ListFilters(ListFiltersRequest request) 
        {
            return new ListFiltersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListMetricAttributionMetrics operation
        ///</summary>
        public IListMetricAttributionMetricsPaginator ListMetricAttributionMetrics(ListMetricAttributionMetricsRequest request) 
        {
            return new ListMetricAttributionMetricsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListMetricAttributions operation
        ///</summary>
        public IListMetricAttributionsPaginator ListMetricAttributions(ListMetricAttributionsRequest request) 
        {
            return new ListMetricAttributionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRecipes operation
        ///</summary>
        public IListRecipesPaginator ListRecipes(ListRecipesRequest request) 
        {
            return new ListRecipesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRecommenders operation
        ///</summary>
        public IListRecommendersPaginator ListRecommenders(ListRecommendersRequest request) 
        {
            return new ListRecommendersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSchemas operation
        ///</summary>
        public IListSchemasPaginator ListSchemas(ListSchemasRequest request) 
        {
            return new ListSchemasPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSolutions operation
        ///</summary>
        public IListSolutionsPaginator ListSolutions(ListSolutionsRequest request) 
        {
            return new ListSolutionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSolutionVersions operation
        ///</summary>
        public IListSolutionVersionsPaginator ListSolutionVersions(ListSolutionVersionsRequest request) 
        {
            return new ListSolutionVersionsPaginator(this.client, request);
        }
    }
}