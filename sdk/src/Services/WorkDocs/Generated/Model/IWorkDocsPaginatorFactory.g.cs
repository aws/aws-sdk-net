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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618

namespace Amazon.WorkDocs.Model
{
    /// <summary>
    /// Paginators for the WorkDocs service
    /// </summary>
    public interface IWorkDocsPaginatorFactory
    {
        /// <summary>
        /// Paginator for DescribeActivities operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "Limit", OutputToken = ["Marker"])]
        IDescribeActivitiesPaginator DescribeActivities(DescribeActivitiesRequest request);

        /// <summary>
        /// Paginator for DescribeComments operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "Limit", OutputToken = ["Marker"])]
        IDescribeCommentsPaginator DescribeComments(DescribeCommentsRequest request);

        /// <summary>
        /// Paginator for DescribeDocumentVersions operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "Limit", OutputToken = ["Marker"])]
        IDescribeDocumentVersionsPaginator DescribeDocumentVersions(DescribeDocumentVersionsRequest request);

        /// <summary>
        /// Paginator for DescribeFolderContents operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "Limit", OutputToken = ["Marker"])]
        IDescribeFolderContentsPaginator DescribeFolderContents(DescribeFolderContentsRequest request);

        /// <summary>
        /// Paginator for DescribeGroups operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "Limit", OutputToken = ["Marker"])]
        IDescribeGroupsPaginator DescribeGroups(DescribeGroupsRequest request);

        /// <summary>
        /// Paginator for DescribeNotificationSubscriptions operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "Limit", OutputToken = ["Marker"])]
        IDescribeNotificationSubscriptionsPaginator DescribeNotificationSubscriptions(DescribeNotificationSubscriptionsRequest request);

        /// <summary>
        /// Paginator for DescribeResourcePermissions operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "Limit", OutputToken = ["Marker"])]
        IDescribeResourcePermissionsPaginator DescribeResourcePermissions(DescribeResourcePermissionsRequest request);

        /// <summary>
        /// Paginator for DescribeRootFolders operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "Limit", OutputToken = ["Marker"])]
        IDescribeRootFoldersPaginator DescribeRootFolders(DescribeRootFoldersRequest request);

        /// <summary>
        /// Paginator for DescribeUsers operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "Limit", OutputToken = ["Marker"])]
        IDescribeUsersPaginator DescribeUsers(DescribeUsersRequest request);

        /// <summary>
        /// Paginator for SearchResources operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "Limit", OutputToken = ["Marker"])]
        ISearchResourcesPaginator SearchResources(SearchResourcesRequest request);
    }
}
