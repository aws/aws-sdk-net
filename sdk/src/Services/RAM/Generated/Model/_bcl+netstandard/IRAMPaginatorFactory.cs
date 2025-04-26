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
 * Do not modify this file. This file is generated from the ram-2018-01-04.normal.json service model.
 */
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.RAM.Model
{
    /// <summary>
    /// Paginators for the RAM service
    ///</summary>
    public interface IRAMPaginatorFactory
    {

        /// <summary>
        /// Paginator for GetResourcePolicies operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetResourcePoliciesPaginator GetResourcePolicies(GetResourcePoliciesRequest request);

        /// <summary>
        /// Paginator for GetResourceShareAssociations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetResourceShareAssociationsPaginator GetResourceShareAssociations(GetResourceShareAssociationsRequest request);

        /// <summary>
        /// Paginator for GetResourceShareInvitations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetResourceShareInvitationsPaginator GetResourceShareInvitations(GetResourceShareInvitationsRequest request);

        /// <summary>
        /// Paginator for GetResourceShares operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetResourceSharesPaginator GetResourceShares(GetResourceSharesRequest request);

        /// <summary>
        /// Paginator for ListPendingInvitationResources operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListPendingInvitationResourcesPaginator ListPendingInvitationResources(ListPendingInvitationResourcesRequest request);

        /// <summary>
        /// Paginator for ListPermissionAssociations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListPermissionAssociationsPaginator ListPermissionAssociations(ListPermissionAssociationsRequest request);

        /// <summary>
        /// Paginator for ListPermissions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListPermissionsPaginator ListPermissions(ListPermissionsRequest request);

        /// <summary>
        /// Paginator for ListPermissionVersions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListPermissionVersionsPaginator ListPermissionVersions(ListPermissionVersionsRequest request);

        /// <summary>
        /// Paginator for ListPrincipals operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListPrincipalsPaginator ListPrincipals(ListPrincipalsRequest request);

        /// <summary>
        /// Paginator for ListReplacePermissionAssociationsWork operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListReplacePermissionAssociationsWorkPaginator ListReplacePermissionAssociationsWork(ListReplacePermissionAssociationsWorkRequest request);

        /// <summary>
        /// Paginator for ListResources operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListResourcesPaginator ListResources(ListResourcesRequest request);

        /// <summary>
        /// Paginator for ListResourceSharePermissions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListResourceSharePermissionsPaginator ListResourceSharePermissions(ListResourceSharePermissionsRequest request);

        /// <summary>
        /// Paginator for ListResourceTypes operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListResourceTypesPaginator ListResourceTypes(ListResourceTypesRequest request);
    }
}