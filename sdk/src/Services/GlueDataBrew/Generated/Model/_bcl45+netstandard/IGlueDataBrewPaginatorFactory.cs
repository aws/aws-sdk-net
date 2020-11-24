#if !NETSTANDARD13
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

namespace Amazon.GlueDataBrew.Model
{
    /// <summary>
    /// Paginators for the GlueDataBrew service
    ///</summary>
    public interface IGlueDataBrewPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListDatasets operation
        ///</summary>
        IListDatasetsPaginator ListDatasets(ListDatasetsRequest request);

        /// <summary>
        /// Paginator for ListJobRuns operation
        ///</summary>
        IListJobRunsPaginator ListJobRuns(ListJobRunsRequest request);

        /// <summary>
        /// Paginator for ListJobs operation
        ///</summary>
        IListJobsPaginator ListJobs(ListJobsRequest request);

        /// <summary>
        /// Paginator for ListProjects operation
        ///</summary>
        IListProjectsPaginator ListProjects(ListProjectsRequest request);

        /// <summary>
        /// Paginator for ListRecipes operation
        ///</summary>
        IListRecipesPaginator ListRecipes(ListRecipesRequest request);

        /// <summary>
        /// Paginator for ListRecipeVersions operation
        ///</summary>
        IListRecipeVersionsPaginator ListRecipeVersions(ListRecipeVersionsRequest request);

        /// <summary>
        /// Paginator for ListSchedules operation
        ///</summary>
        IListSchedulesPaginator ListSchedules(ListSchedulesRequest request);
    }
}
#endif