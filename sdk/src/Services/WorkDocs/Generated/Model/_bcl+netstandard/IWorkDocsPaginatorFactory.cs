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
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.WorkDocs.Model
{
    /// <summary>
    /// Paginators for the WorkDocs service
    ///</summary>
    public interface IWorkDocsPaginatorFactory
    {

        /// <summary>
        /// Paginator for DescribeActivities operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "Limit",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeActivitiesPaginator DescribeActivities(DescribeActivitiesRequest request);

        /// <summary>
        /// Paginator for DescribeComments operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "Limit",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeCommentsPaginator DescribeComments(DescribeCommentsRequest request);

        /// <summary>
        /// Paginator for DescribeDocumentVersions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "Limit",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeDocumentVersionsPaginator DescribeDocumentVersions(DescribeDocumentVersionsRequest request);

        /// <summary>
        /// Paginator for DescribeFolderContents operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "Limit",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeFolderContentsPaginator DescribeFolderContents(DescribeFolderContentsRequest request);

        /// <summary>
        /// Paginator for DescribeGroups operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "Limit",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeGroupsPaginator DescribeGroups(DescribeGroupsRequest request);

        /// <summary>
        /// Paginator for DescribeNotificationSubscriptions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "Limit",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeNotificationSubscriptionsPaginator DescribeNotificationSubscriptions(DescribeNotificationSubscriptionsRequest request);

        /// <summary>
        /// Paginator for DescribeResourcePermissions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "Limit",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeResourcePermissionsPaginator DescribeResourcePermissions(DescribeResourcePermissionsRequest request);

        /// <summary>
        /// Paginator for DescribeRootFolders operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "Limit",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeRootFoldersPaginator DescribeRootFolders(DescribeRootFoldersRequest request);

        /// <summary>
        /// Paginator for DescribeUsers operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "Limit",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeUsersPaginator DescribeUsers(DescribeUsersRequest request);

        /// <summary>
        /// Paginator for SearchResources operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "Limit",
            OutputToken = new[] { "Marker" }
        )]
        ISearchResourcesPaginator SearchResources(SearchResourcesRequest request);
    }
}