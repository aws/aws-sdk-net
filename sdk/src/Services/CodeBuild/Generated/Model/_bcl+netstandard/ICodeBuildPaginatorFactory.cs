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
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
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
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeCodeCoveragesPaginator DescribeCodeCoverages(DescribeCodeCoveragesRequest request);

        /// <summary>
        /// Paginator for DescribeTestCases operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeTestCasesPaginator DescribeTestCases(DescribeTestCasesRequest request);

        /// <summary>
        /// Paginator for ListBuildBatches operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListBuildBatchesPaginator ListBuildBatches(ListBuildBatchesRequest request);

        /// <summary>
        /// Paginator for ListBuildBatchesForProject operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListBuildBatchesForProjectPaginator ListBuildBatchesForProject(ListBuildBatchesForProjectRequest request);

        /// <summary>
        /// Paginator for ListBuilds operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            
            OutputToken = new[] { "NextToken" }
        )]
        IListBuildsPaginator ListBuilds(ListBuildsRequest request);

        /// <summary>
        /// Paginator for ListBuildsForProject operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            
            OutputToken = new[] { "NextToken" }
        )]
        IListBuildsForProjectPaginator ListBuildsForProject(ListBuildsForProjectRequest request);

        /// <summary>
        /// Paginator for ListCommandExecutionsForSandbox operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListCommandExecutionsForSandboxPaginator ListCommandExecutionsForSandbox(ListCommandExecutionsForSandboxRequest request);

        /// <summary>
        /// Paginator for ListFleets operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListFleetsPaginator ListFleets(ListFleetsRequest request);

        /// <summary>
        /// Paginator for ListProjects operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            
            OutputToken = new[] { "NextToken" }
        )]
        IListProjectsPaginator ListProjects(ListProjectsRequest request);

        /// <summary>
        /// Paginator for ListReportGroups operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListReportGroupsPaginator ListReportGroups(ListReportGroupsRequest request);

        /// <summary>
        /// Paginator for ListReports operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListReportsPaginator ListReports(ListReportsRequest request);

        /// <summary>
        /// Paginator for ListReportsForReportGroup operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListReportsForReportGroupPaginator ListReportsForReportGroup(ListReportsForReportGroupRequest request);

        /// <summary>
        /// Paginator for ListSandboxes operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListSandboxesPaginator ListSandboxes(ListSandboxesRequest request);

        /// <summary>
        /// Paginator for ListSandboxesForProject operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListSandboxesForProjectPaginator ListSandboxesForProject(ListSandboxesForProjectRequest request);

        /// <summary>
        /// Paginator for ListSharedProjects operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListSharedProjectsPaginator ListSharedProjects(ListSharedProjectsRequest request);

        /// <summary>
        /// Paginator for ListSharedReportGroups operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListSharedReportGroupsPaginator ListSharedReportGroups(ListSharedReportGroupsRequest request);
    }
}