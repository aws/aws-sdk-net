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

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// Paginators for the CodeBuild service
    ///</summary>
    public class CodeBuildPaginatorFactory : ICodeBuildPaginatorFactory
    {
        private readonly IAmazonCodeBuild client;

        internal CodeBuildPaginatorFactory(IAmazonCodeBuild client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for DescribeCodeCoverages operation
        ///</summary>
        public IDescribeCodeCoveragesPaginator DescribeCodeCoverages(DescribeCodeCoveragesRequest request) 
        {
            return new DescribeCodeCoveragesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeTestCases operation
        ///</summary>
        public IDescribeTestCasesPaginator DescribeTestCases(DescribeTestCasesRequest request) 
        {
            return new DescribeTestCasesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListBuildBatches operation
        ///</summary>
        public IListBuildBatchesPaginator ListBuildBatches(ListBuildBatchesRequest request) 
        {
            return new ListBuildBatchesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListBuildBatchesForProject operation
        ///</summary>
        public IListBuildBatchesForProjectPaginator ListBuildBatchesForProject(ListBuildBatchesForProjectRequest request) 
        {
            return new ListBuildBatchesForProjectPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListBuilds operation
        ///</summary>
        public IListBuildsPaginator ListBuilds(ListBuildsRequest request) 
        {
            return new ListBuildsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListBuildsForProject operation
        ///</summary>
        public IListBuildsForProjectPaginator ListBuildsForProject(ListBuildsForProjectRequest request) 
        {
            return new ListBuildsForProjectPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCommandExecutionsForSandbox operation
        ///</summary>
        public IListCommandExecutionsForSandboxPaginator ListCommandExecutionsForSandbox(ListCommandExecutionsForSandboxRequest request) 
        {
            return new ListCommandExecutionsForSandboxPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListFleets operation
        ///</summary>
        public IListFleetsPaginator ListFleets(ListFleetsRequest request) 
        {
            return new ListFleetsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListProjects operation
        ///</summary>
        public IListProjectsPaginator ListProjects(ListProjectsRequest request) 
        {
            return new ListProjectsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListReportGroups operation
        ///</summary>
        public IListReportGroupsPaginator ListReportGroups(ListReportGroupsRequest request) 
        {
            return new ListReportGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListReports operation
        ///</summary>
        public IListReportsPaginator ListReports(ListReportsRequest request) 
        {
            return new ListReportsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListReportsForReportGroup operation
        ///</summary>
        public IListReportsForReportGroupPaginator ListReportsForReportGroup(ListReportsForReportGroupRequest request) 
        {
            return new ListReportsForReportGroupPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSandboxes operation
        ///</summary>
        public IListSandboxesPaginator ListSandboxes(ListSandboxesRequest request) 
        {
            return new ListSandboxesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSandboxesForProject operation
        ///</summary>
        public IListSandboxesForProjectPaginator ListSandboxesForProject(ListSandboxesForProjectRequest request) 
        {
            return new ListSandboxesForProjectPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSharedProjects operation
        ///</summary>
        public IListSharedProjectsPaginator ListSharedProjects(ListSharedProjectsRequest request) 
        {
            return new ListSharedProjectsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSharedReportGroups operation
        ///</summary>
        public IListSharedReportGroupsPaginator ListSharedReportGroups(ListSharedReportGroupsRequest request) 
        {
            return new ListSharedReportGroupsPaginator(this.client, request);
        }
    }
}