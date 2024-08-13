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
 * Do not modify this file. This file is generated from the databrew-2017-07-25.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.GlueDataBrew.Model
{
    /// <summary>
    /// Paginators for the GlueDataBrew service
    ///</summary>
    public class GlueDataBrewPaginatorFactory : IGlueDataBrewPaginatorFactory
    {
        private readonly IAmazonGlueDataBrew client;

        internal GlueDataBrewPaginatorFactory(IAmazonGlueDataBrew client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListDatasets operation
        ///</summary>
        public IListDatasetsPaginator ListDatasets(ListDatasetsRequest request) 
        {
            return new ListDatasetsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListJobRuns operation
        ///</summary>
        public IListJobRunsPaginator ListJobRuns(ListJobRunsRequest request) 
        {
            return new ListJobRunsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListJobs operation
        ///</summary>
        public IListJobsPaginator ListJobs(ListJobsRequest request) 
        {
            return new ListJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListProjects operation
        ///</summary>
        public IListProjectsPaginator ListProjects(ListProjectsRequest request) 
        {
            return new ListProjectsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRecipes operation
        ///</summary>
        public IListRecipesPaginator ListRecipes(ListRecipesRequest request) 
        {
            return new ListRecipesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRecipeVersions operation
        ///</summary>
        public IListRecipeVersionsPaginator ListRecipeVersions(ListRecipeVersionsRequest request) 
        {
            return new ListRecipeVersionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRulesets operation
        ///</summary>
        public IListRulesetsPaginator ListRulesets(ListRulesetsRequest request) 
        {
            return new ListRulesetsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSchedules operation
        ///</summary>
        public IListSchedulesPaginator ListSchedules(ListSchedulesRequest request) 
        {
            return new ListSchedulesPaginator(this.client, request);
        }
    }
}