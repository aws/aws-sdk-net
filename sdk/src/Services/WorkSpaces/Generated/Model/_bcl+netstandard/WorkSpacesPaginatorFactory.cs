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

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// Paginators for the WorkSpaces service
    ///</summary>
    public class WorkSpacesPaginatorFactory : IWorkSpacesPaginatorFactory
    {
        private readonly IAmazonWorkSpaces client;

        internal WorkSpacesPaginatorFactory(IAmazonWorkSpaces client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for DescribeApplicationAssociations operation
        ///</summary>
        public IDescribeApplicationAssociationsPaginator DescribeApplicationAssociations(DescribeApplicationAssociationsRequest request) 
        {
            return new DescribeApplicationAssociationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeApplications operation
        ///</summary>
        public IDescribeApplicationsPaginator DescribeApplications(DescribeApplicationsRequest request) 
        {
            return new DescribeApplicationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeWorkspaceBundles operation
        ///</summary>
        public IDescribeWorkspaceBundlesPaginator DescribeWorkspaceBundles(DescribeWorkspaceBundlesRequest request) 
        {
            return new DescribeWorkspaceBundlesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeWorkspaceDirectories operation
        ///</summary>
        public IDescribeWorkspaceDirectoriesPaginator DescribeWorkspaceDirectories(DescribeWorkspaceDirectoriesRequest request) 
        {
            return new DescribeWorkspaceDirectoriesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeWorkspaces operation
        ///</summary>
        public IDescribeWorkspacesPaginator DescribeWorkspaces(DescribeWorkspacesRequest request) 
        {
            return new DescribeWorkspacesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAccountLinks operation
        ///</summary>
        public IListAccountLinksPaginator ListAccountLinks(ListAccountLinksRequest request) 
        {
            return new ListAccountLinksPaginator(this.client, request);
        }
    }
}