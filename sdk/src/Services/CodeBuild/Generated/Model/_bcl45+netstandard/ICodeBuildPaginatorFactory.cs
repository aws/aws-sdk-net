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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
 */

namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// Paginators for the CodeBuild service
    ///</summary>
    public interface ICodeBuildPaginatorFactory
    {

        /// <summary>
        /// Paginator for DescribeCodeCoverages operation
        ///</summary>
        IDescribeCodeCoveragesPaginator DescribeCodeCoverages(DescribeCodeCoveragesRequest request);

        /// <summary>
        /// Paginator for DescribeTestCases operation
        ///</summary>
        IDescribeTestCasesPaginator DescribeTestCases(DescribeTestCasesRequest request);

        /// <summary>
        /// Paginator for ListBuildBatches operation
        ///</summary>
        IListBuildBatchesPaginator ListBuildBatches(ListBuildBatchesRequest request);

        /// <summary>
        /// Paginator for ListBuildBatchesForProject operation
        ///</summary>
        IListBuildBatchesForProjectPaginator ListBuildBatchesForProject(ListBuildBatchesForProjectRequest request);

        /// <summary>
        /// Paginator for ListBuilds operation
        ///</summary>
        IListBuildsPaginator ListBuilds(ListBuildsRequest request);

        /// <summary>
        /// Paginator for ListBuildsForProject operation
        ///</summary>
        IListBuildsForProjectPaginator ListBuildsForProject(ListBuildsForProjectRequest request);

        /// <summary>
        /// Paginator for ListProjects operation
        ///</summary>
        IListProjectsPaginator ListProjects(ListProjectsRequest request);

        /// <summary>
        /// Paginator for ListReportGroups operation
        ///</summary>
        IListReportGroupsPaginator ListReportGroups(ListReportGroupsRequest request);

        /// <summary>
        /// Paginator for ListReports operation
        ///</summary>
        IListReportsPaginator ListReports(ListReportsRequest request);

        /// <summary>
        /// Paginator for ListReportsForReportGroup operation
        ///</summary>
        IListReportsForReportGroupPaginator ListReportsForReportGroup(ListReportsForReportGroupRequest request);

        /// <summary>
        /// Paginator for ListSharedProjects operation
        ///</summary>
        IListSharedProjectsPaginator ListSharedProjects(ListSharedProjectsRequest request);

        /// <summary>
        /// Paginator for ListSharedReportGroups operation
        ///</summary>
        IListSharedReportGroupsPaginator ListSharedReportGroups(ListSharedReportGroupsRequest request);
    }
}