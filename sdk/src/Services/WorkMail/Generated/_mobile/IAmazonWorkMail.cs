/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the workmail-2017-10-01.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.WorkMail.Model;

namespace Amazon.WorkMail
{
    /// <summary>
    /// Interface for accessing WorkMail
    ///
    /// Amazon WorkMail is a secure, managed business email and calendaring service with support
    /// for existing desktop and mobile email clients. You can access your email, contacts,
    /// and calendars using Microsoft Outlook, your browser, or their native iOS and Android
    /// email applications. You can integrate Amazon WorkMail with your existing corporate
    /// directory and control both the keys that encrypt your data and the location in which
    /// your data is stored.
    /// 
    ///  
    /// <para>
    /// The Amazon WorkMail API is designed for the following scenarios:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Listing and describing organizations
    /// </para>
    ///  </li> </ul> <ul> <li> 
    /// <para>
    /// Managing users
    /// </para>
    ///  </li> </ul> <ul> <li> 
    /// <para>
    /// Managing groups
    /// </para>
    ///  </li> </ul> <ul> <li> 
    /// <para>
    /// Managing resources
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// All Amazon WorkMail API actions are Amazon-authenticated and certificate-signed. They
    /// not only require the use of the AWS SDK, but also allow for the exclusive use of IAM
    /// users and roles to help facilitate access, trust, and permission policies. By creating
    /// a role and allowing an IAM user to access the Amazon WorkMail site, the IAM user gains
    /// full administrative visibility into the entire Amazon WorkMail organization (or as
    /// set in the IAM policy). This includes, but is not limited to, the ability to create,
    /// update, and delete users, groups, and resources. This allows developers to perform
    /// the scenarios listed above, as well as give users the ability to grant access on a
    /// selective basis using the IAM model.
    /// </para>
    /// </summary>
    public partial interface IAmazonWorkMail : IAmazonService, IDisposable
    {
                
        #region  AssociateDelegateToResource


        /// <summary>
        /// Initiates the asynchronous execution of the AssociateDelegateToResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateDelegateToResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/AssociateDelegateToResource">REST API Reference for AssociateDelegateToResource Operation</seealso>
        Task<AssociateDelegateToResourceResponse> AssociateDelegateToResourceAsync(AssociateDelegateToResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AssociateMemberToGroup


        /// <summary>
        /// Initiates the asynchronous execution of the AssociateMemberToGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateMemberToGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/AssociateMemberToGroup">REST API Reference for AssociateMemberToGroup Operation</seealso>
        Task<AssociateMemberToGroupResponse> AssociateMemberToGroupAsync(AssociateMemberToGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateAlias


        /// <summary>
        /// Initiates the asynchronous execution of the CreateAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAlias operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/CreateAlias">REST API Reference for CreateAlias Operation</seealso>
        Task<CreateAliasResponse> CreateAliasAsync(CreateAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateGroup


        /// <summary>
        /// Initiates the asynchronous execution of the CreateGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        Task<CreateGroupResponse> CreateGroupAsync(CreateGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateResource


        /// <summary>
        /// Initiates the asynchronous execution of the CreateResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/CreateResource">REST API Reference for CreateResource Operation</seealso>
        Task<CreateResourceResponse> CreateResourceAsync(CreateResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateUser


        /// <summary>
        /// Initiates the asynchronous execution of the CreateUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUser operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/CreateUser">REST API Reference for CreateUser Operation</seealso>
        Task<CreateUserResponse> CreateUserAsync(CreateUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteAlias


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlias operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteAlias">REST API Reference for DeleteAlias Operation</seealso>
        Task<DeleteAliasResponse> DeleteAliasAsync(DeleteAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteGroup


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        Task<DeleteGroupResponse> DeleteGroupAsync(DeleteGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteMailboxPermissions


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMailboxPermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMailboxPermissions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteMailboxPermissions">REST API Reference for DeleteMailboxPermissions Operation</seealso>
        Task<DeleteMailboxPermissionsResponse> DeleteMailboxPermissionsAsync(DeleteMailboxPermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteResource


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteResource">REST API Reference for DeleteResource Operation</seealso>
        Task<DeleteResourceResponse> DeleteResourceAsync(DeleteResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteUser


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        Task<DeleteUserResponse> DeleteUserAsync(DeleteUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeregisterFromWorkMail


        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterFromWorkMail operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterFromWorkMail operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeregisterFromWorkMail">REST API Reference for DeregisterFromWorkMail Operation</seealso>
        Task<DeregisterFromWorkMailResponse> DeregisterFromWorkMailAsync(DeregisterFromWorkMailRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeGroup


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DescribeGroup">REST API Reference for DescribeGroup Operation</seealso>
        Task<DescribeGroupResponse> DescribeGroupAsync(DescribeGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeOrganization


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeOrganization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrganization operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DescribeOrganization">REST API Reference for DescribeOrganization Operation</seealso>
        Task<DescribeOrganizationResponse> DescribeOrganizationAsync(DescribeOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeResource


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DescribeResource">REST API Reference for DescribeResource Operation</seealso>
        Task<DescribeResourceResponse> DescribeResourceAsync(DescribeResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeUser


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeUser operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DescribeUser">REST API Reference for DescribeUser Operation</seealso>
        Task<DescribeUserResponse> DescribeUserAsync(DescribeUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisassociateDelegateFromResource


        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateDelegateFromResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateDelegateFromResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DisassociateDelegateFromResource">REST API Reference for DisassociateDelegateFromResource Operation</seealso>
        Task<DisassociateDelegateFromResourceResponse> DisassociateDelegateFromResourceAsync(DisassociateDelegateFromResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisassociateMemberFromGroup


        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateMemberFromGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMemberFromGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DisassociateMemberFromGroup">REST API Reference for DisassociateMemberFromGroup Operation</seealso>
        Task<DisassociateMemberFromGroupResponse> DisassociateMemberFromGroupAsync(DisassociateMemberFromGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAliases


        /// <summary>
        /// Initiates the asynchronous execution of the ListAliases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAliases operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListAliases">REST API Reference for ListAliases Operation</seealso>
        Task<ListAliasesResponse> ListAliasesAsync(ListAliasesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListGroupMembers


        /// <summary>
        /// Initiates the asynchronous execution of the ListGroupMembers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGroupMembers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListGroupMembers">REST API Reference for ListGroupMembers Operation</seealso>
        Task<ListGroupMembersResponse> ListGroupMembersAsync(ListGroupMembersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListGroups


        /// <summary>
        /// Initiates the asynchronous execution of the ListGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListGroups">REST API Reference for ListGroups Operation</seealso>
        Task<ListGroupsResponse> ListGroupsAsync(ListGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListMailboxPermissions


        /// <summary>
        /// Initiates the asynchronous execution of the ListMailboxPermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMailboxPermissions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListMailboxPermissions">REST API Reference for ListMailboxPermissions Operation</seealso>
        Task<ListMailboxPermissionsResponse> ListMailboxPermissionsAsync(ListMailboxPermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListOrganizations


        /// <summary>
        /// Initiates the asynchronous execution of the ListOrganizations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOrganizations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListOrganizations">REST API Reference for ListOrganizations Operation</seealso>
        Task<ListOrganizationsResponse> ListOrganizationsAsync(ListOrganizationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListResourceDelegates


        /// <summary>
        /// Initiates the asynchronous execution of the ListResourceDelegates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResourceDelegates operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListResourceDelegates">REST API Reference for ListResourceDelegates Operation</seealso>
        Task<ListResourceDelegatesResponse> ListResourceDelegatesAsync(ListResourceDelegatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListResources


        /// <summary>
        /// Initiates the asynchronous execution of the ListResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResources operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListResources">REST API Reference for ListResources Operation</seealso>
        Task<ListResourcesResponse> ListResourcesAsync(ListResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListUsers


        /// <summary>
        /// Initiates the asynchronous execution of the ListUsers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUsers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListUsers">REST API Reference for ListUsers Operation</seealso>
        Task<ListUsersResponse> ListUsersAsync(ListUsersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutMailboxPermissions


        /// <summary>
        /// Initiates the asynchronous execution of the PutMailboxPermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutMailboxPermissions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/PutMailboxPermissions">REST API Reference for PutMailboxPermissions Operation</seealso>
        Task<PutMailboxPermissionsResponse> PutMailboxPermissionsAsync(PutMailboxPermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RegisterToWorkMail


        /// <summary>
        /// Initiates the asynchronous execution of the RegisterToWorkMail operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterToWorkMail operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/RegisterToWorkMail">REST API Reference for RegisterToWorkMail Operation</seealso>
        Task<RegisterToWorkMailResponse> RegisterToWorkMailAsync(RegisterToWorkMailRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ResetPassword


        /// <summary>
        /// Initiates the asynchronous execution of the ResetPassword operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetPassword operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ResetPassword">REST API Reference for ResetPassword Operation</seealso>
        Task<ResetPasswordResponse> ResetPasswordAsync(ResetPasswordRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdatePrimaryEmailAddress


        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePrimaryEmailAddress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePrimaryEmailAddress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/UpdatePrimaryEmailAddress">REST API Reference for UpdatePrimaryEmailAddress Operation</seealso>
        Task<UpdatePrimaryEmailAddressResponse> UpdatePrimaryEmailAddressAsync(UpdatePrimaryEmailAddressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateResource


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/UpdateResource">REST API Reference for UpdateResource Operation</seealso>
        Task<UpdateResourceResponse> UpdateResourceAsync(UpdateResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}