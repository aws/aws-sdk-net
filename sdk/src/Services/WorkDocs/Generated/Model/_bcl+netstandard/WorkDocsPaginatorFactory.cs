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
 * Do not modify this file. This file is generated from the workdocs-2016-05-01.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.WorkDocs.Model
{
    /// <summary>
    /// Paginators for the WorkDocs service
    ///</summary>
    public class WorkDocsPaginatorFactory : IWorkDocsPaginatorFactory
    {
        private readonly IAmazonWorkDocs client;

        internal WorkDocsPaginatorFactory(IAmazonWorkDocs client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for DescribeActivities operation
        ///</summary>
        public IDescribeActivitiesPaginator DescribeActivities(DescribeActivitiesRequest request) 
        {
            return new DescribeActivitiesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeComments operation
        ///</summary>
        public IDescribeCommentsPaginator DescribeComments(DescribeCommentsRequest request) 
        {
            return new DescribeCommentsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeDocumentVersions operation
        ///</summary>
        public IDescribeDocumentVersionsPaginator DescribeDocumentVersions(DescribeDocumentVersionsRequest request) 
        {
            return new DescribeDocumentVersionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeFolderContents operation
        ///</summary>
        public IDescribeFolderContentsPaginator DescribeFolderContents(DescribeFolderContentsRequest request) 
        {
            return new DescribeFolderContentsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeGroups operation
        ///</summary>
        public IDescribeGroupsPaginator DescribeGroups(DescribeGroupsRequest request) 
        {
            return new DescribeGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeNotificationSubscriptions operation
        ///</summary>
        public IDescribeNotificationSubscriptionsPaginator DescribeNotificationSubscriptions(DescribeNotificationSubscriptionsRequest request) 
        {
            return new DescribeNotificationSubscriptionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeResourcePermissions operation
        ///</summary>
        public IDescribeResourcePermissionsPaginator DescribeResourcePermissions(DescribeResourcePermissionsRequest request) 
        {
            return new DescribeResourcePermissionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeRootFolders operation
        ///</summary>
        public IDescribeRootFoldersPaginator DescribeRootFolders(DescribeRootFoldersRequest request) 
        {
            return new DescribeRootFoldersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeUsers operation
        ///</summary>
        public IDescribeUsersPaginator DescribeUsers(DescribeUsersRequest request) 
        {
            return new DescribeUsersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SearchResources operation
        ///</summary>
        public ISearchResourcesPaginator SearchResources(SearchResourcesRequest request) 
        {
            return new SearchResourcesPaginator(this.client, request);
        }
    }
}