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
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
 */
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// Paginators for the WorkSpaces service
    ///</summary>
    public interface IWorkSpacesPaginatorFactory
    {

        /// <summary>
        /// Paginator for DescribeApplicationAssociations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeApplicationAssociationsPaginator DescribeApplicationAssociations(DescribeApplicationAssociationsRequest request);

        /// <summary>
        /// Paginator for DescribeApplications operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeApplicationsPaginator DescribeApplications(DescribeApplicationsRequest request);

        /// <summary>
        /// Paginator for DescribeWorkspaceBundles operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeWorkspaceBundlesPaginator DescribeWorkspaceBundles(DescribeWorkspaceBundlesRequest request);

        /// <summary>
        /// Paginator for DescribeWorkspaceDirectories operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeWorkspaceDirectoriesPaginator DescribeWorkspaceDirectories(DescribeWorkspaceDirectoriesRequest request);

        /// <summary>
        /// Paginator for DescribeWorkspaces operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "Limit",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeWorkspacesPaginator DescribeWorkspaces(DescribeWorkspacesRequest request);

        /// <summary>
        /// Paginator for ListAccountLinks operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAccountLinksPaginator ListAccountLinks(ListAccountLinksRequest request);
    }
}