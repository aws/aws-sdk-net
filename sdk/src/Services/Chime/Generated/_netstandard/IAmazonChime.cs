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
 * Do not modify this file. This file is generated from the chime-2018-05-01.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Chime.Model;

namespace Amazon.Chime
{
    /// <summary>
    /// Interface for accessing Chime
    ///
    /// The Amazon Chime API (application programming interface) is designed for developers
    /// to perform key tasks, such as creating and managing Amazon Chime accounts, users,
    /// and Voice Connectors. This guide provides detailed information about the Amazon Chime
    /// API, including operations, types, inputs and outputs, and error codes. It also includes
    /// some server-side API actions to use with the Amazon Chime SDK. For more information
    /// about the Amazon Chime SDK, see <a href="https://docs.aws.amazon.com/chime/latest/dg/meetings-sdk.html">Using
    /// the Amazon Chime SDK</a> in the <i>Amazon Chime Developer Guide</i>.
    /// 
    ///  
    /// <para>
    /// You can use an AWS SDK, the AWS Command Line Interface (AWS CLI), or the REST API
    /// to make API calls. We recommend using an AWS SDK or the AWS CLI. Each API operation
    /// includes links to information about using it with a language-specific AWS SDK or the
    /// AWS CLI.
    /// </para>
    ///  <dl> <dt>Using an AWS SDK</dt> <dd> 
    /// <para>
    /// You don't need to write code to calculate a signature for request authentication.
    /// The SDK clients authenticate your requests by using access keys that you provide.
    /// For more information about AWS SDKs, see the <a href="http://aws.amazon.com/developer/">AWS
    /// Developer Center</a>.
    /// </para>
    ///  </dd> <dt>Using the AWS CLI</dt> <dd> 
    /// <para>
    /// Use your access keys with the AWS CLI to make API calls. For information about setting
    /// up the AWS CLI, see <a href="https://docs.aws.amazon.com/cli/latest/userguide/installing.html">Installing
    /// the AWS Command Line Interface</a> in the <i>AWS Command Line Interface User Guide</i>.
    /// For a list of available Amazon Chime commands, see the <a href="https://docs.aws.amazon.com/cli/latest/reference/chime/index.html">Amazon
    /// Chime commands</a> in the <i>AWS CLI Command Reference</i>.
    /// </para>
    ///  </dd> <dt>Using REST API</dt> <dd> 
    /// <para>
    /// If you use REST to make API calls, you must authenticate your request by providing
    /// a signature. Amazon Chime supports signature version 4. For more information, see
    /// <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
    /// Version 4 Signing Process</a> in the <i>Amazon Web Services General Reference</i>.
    /// </para>
    ///  
    /// <para>
    /// When making REST API calls, use the service name <code>chime</code> and REST endpoint
    /// <code>https://service.chime.aws.amazon.com</code>.
    /// </para>
    ///  </dd> </dl> 
    /// <para>
    /// Administrative permissions are controlled using AWS Identity and Access Management
    /// (IAM). For more information, see <a href="https://docs.aws.amazon.com/chime/latest/ag/security-iam.html">Identity
    /// and Access Management for Amazon Chime</a> in the <i>Amazon Chime Administration Guide</i>.
    /// </para>
    /// </summary>
    public partial interface IAmazonChime : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IChimePaginatorFactory Paginators { get; }
#endif
                
        #region  AssociatePhoneNumbersWithVoiceConnector



        /// <summary>
        /// Associates phone numbers with the specified Amazon Chime Voice Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociatePhoneNumbersWithVoiceConnector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociatePhoneNumbersWithVoiceConnector service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/AssociatePhoneNumbersWithVoiceConnector">REST API Reference for AssociatePhoneNumbersWithVoiceConnector Operation</seealso>
        Task<AssociatePhoneNumbersWithVoiceConnectorResponse> AssociatePhoneNumbersWithVoiceConnectorAsync(AssociatePhoneNumbersWithVoiceConnectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AssociatePhoneNumbersWithVoiceConnectorGroup



        /// <summary>
        /// Associates phone numbers with the specified Amazon Chime Voice Connector group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociatePhoneNumbersWithVoiceConnectorGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociatePhoneNumbersWithVoiceConnectorGroup service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/AssociatePhoneNumbersWithVoiceConnectorGroup">REST API Reference for AssociatePhoneNumbersWithVoiceConnectorGroup Operation</seealso>
        Task<AssociatePhoneNumbersWithVoiceConnectorGroupResponse> AssociatePhoneNumbersWithVoiceConnectorGroupAsync(AssociatePhoneNumbersWithVoiceConnectorGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AssociatePhoneNumberWithUser



        /// <summary>
        /// Associates a phone number with the specified Amazon Chime user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociatePhoneNumberWithUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociatePhoneNumberWithUser service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/AssociatePhoneNumberWithUser">REST API Reference for AssociatePhoneNumberWithUser Operation</seealso>
        Task<AssociatePhoneNumberWithUserResponse> AssociatePhoneNumberWithUserAsync(AssociatePhoneNumberWithUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AssociateSigninDelegateGroupsWithAccount



        /// <summary>
        /// Associates the specified sign-in delegate groups with the specified Amazon Chime account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateSigninDelegateGroupsWithAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateSigninDelegateGroupsWithAccount service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/AssociateSigninDelegateGroupsWithAccount">REST API Reference for AssociateSigninDelegateGroupsWithAccount Operation</seealso>
        Task<AssociateSigninDelegateGroupsWithAccountResponse> AssociateSigninDelegateGroupsWithAccountAsync(AssociateSigninDelegateGroupsWithAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchCreateAttendee



        /// <summary>
        /// Creates up to 100 new attendees for an active Amazon Chime SDK meeting. For more information
        /// about the Amazon Chime SDK, see <a href="https://docs.aws.amazon.com/chime/latest/dg/meetings-sdk.html">Using
        /// the Amazon Chime SDK</a> in the <i>Amazon Chime Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateAttendee service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchCreateAttendee service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/BatchCreateAttendee">REST API Reference for BatchCreateAttendee Operation</seealso>
        Task<BatchCreateAttendeeResponse> BatchCreateAttendeeAsync(BatchCreateAttendeeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchCreateRoomMembership



        /// <summary>
        /// Adds up to 50 members to a chat room in an Amazon Chime Enterprise account. Members
        /// can be either users or bots. The member role designates whether the member is a chat
        /// room administrator or a general chat room member.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateRoomMembership service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchCreateRoomMembership service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/BatchCreateRoomMembership">REST API Reference for BatchCreateRoomMembership Operation</seealso>
        Task<BatchCreateRoomMembershipResponse> BatchCreateRoomMembershipAsync(BatchCreateRoomMembershipRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchDeletePhoneNumber



        /// <summary>
        /// Moves phone numbers into the <b>Deletion queue</b>. Phone numbers must be disassociated
        /// from any users or Amazon Chime Voice Connectors before they can be deleted.
        /// 
        ///  
        /// <para>
        /// Phone numbers remain in the <b>Deletion queue</b> for 7 days before they are deleted
        /// permanently.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeletePhoneNumber service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDeletePhoneNumber service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/BatchDeletePhoneNumber">REST API Reference for BatchDeletePhoneNumber Operation</seealso>
        Task<BatchDeletePhoneNumberResponse> BatchDeletePhoneNumberAsync(BatchDeletePhoneNumberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchSuspendUser



        /// <summary>
        /// Suspends up to 50 users from a <code>Team</code> or <code>EnterpriseLWA</code> Amazon
        /// Chime account. For more information about different account types, see <a href="https://docs.aws.amazon.com/chime/latest/ag/manage-chime-account.html">Managing
        /// Your Amazon Chime Accounts</a> in the <i>Amazon Chime Administration Guide</i>.
        /// 
        ///  
        /// <para>
        /// Users suspended from a <code>Team</code> account are disassociated from the account,
        /// but they can continue to use Amazon Chime as free users. To remove the suspension
        /// from suspended <code>Team</code> account users, invite them to the <code>Team</code>
        /// account again. You can use the <a>InviteUsers</a> action to do so.
        /// </para>
        ///  
        /// <para>
        /// Users suspended from an <code>EnterpriseLWA</code> account are immediately signed
        /// out of Amazon Chime and can no longer sign in. To remove the suspension from suspended
        /// <code>EnterpriseLWA</code> account users, use the <a>BatchUnsuspendUser</a> action.
        /// 
        /// </para>
        ///  
        /// <para>
        /// To sign out users without suspending them, use the <a>LogoutUser</a> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchSuspendUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchSuspendUser service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/BatchSuspendUser">REST API Reference for BatchSuspendUser Operation</seealso>
        Task<BatchSuspendUserResponse> BatchSuspendUserAsync(BatchSuspendUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchUnsuspendUser



        /// <summary>
        /// Removes the suspension from up to 50 previously suspended users for the specified
        /// Amazon Chime <code>EnterpriseLWA</code> account. Only users on <code>EnterpriseLWA</code>
        /// accounts can be unsuspended using this action. For more information about different
        /// account types, see <a href="https://docs.aws.amazon.com/chime/latest/ag/manage-chime-account.html">Managing
        /// Your Amazon Chime Accounts</a> in the <i>Amazon Chime Administration Guide</i>.
        /// 
        ///  
        /// <para>
        /// Previously suspended users who are unsuspended using this action are returned to <code>Registered</code>
        /// status. Users who are not previously suspended are ignored.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUnsuspendUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchUnsuspendUser service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/BatchUnsuspendUser">REST API Reference for BatchUnsuspendUser Operation</seealso>
        Task<BatchUnsuspendUserResponse> BatchUnsuspendUserAsync(BatchUnsuspendUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchUpdatePhoneNumber



        /// <summary>
        /// Updates phone number product types or calling names. You can update one attribute
        /// at a time for each <code>UpdatePhoneNumberRequestItem</code>. For example, you can
        /// update either the product type or the calling name.
        /// 
        ///  
        /// <para>
        /// For product types, choose from Amazon Chime Business Calling and Amazon Chime Voice
        /// Connector. For toll-free numbers, you must use the Amazon Chime Voice Connector product
        /// type.
        /// </para>
        ///  
        /// <para>
        /// Updates to outbound calling names can take up to 72 hours to complete. Pending updates
        /// to outbound calling names must be complete before you can request another update.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdatePhoneNumber service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchUpdatePhoneNumber service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/BatchUpdatePhoneNumber">REST API Reference for BatchUpdatePhoneNumber Operation</seealso>
        Task<BatchUpdatePhoneNumberResponse> BatchUpdatePhoneNumberAsync(BatchUpdatePhoneNumberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchUpdateUser



        /// <summary>
        /// Updates user details within the <a>UpdateUserRequestItem</a> object for up to 20 users
        /// for the specified Amazon Chime account. Currently, only <code>LicenseType</code> updates
        /// are supported for this action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchUpdateUser service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/BatchUpdateUser">REST API Reference for BatchUpdateUser Operation</seealso>
        Task<BatchUpdateUserResponse> BatchUpdateUserAsync(BatchUpdateUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateAccount



        /// <summary>
        /// Creates an Amazon Chime account under the administrator's AWS account. Only <code>Team</code>
        /// account types are currently supported for this action. For more information about
        /// different account types, see <a href="https://docs.aws.amazon.com/chime/latest/ag/manage-chime-account.html">Managing
        /// Your Amazon Chime Accounts</a> in the <i>Amazon Chime Administration Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAccount service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateAccount">REST API Reference for CreateAccount Operation</seealso>
        Task<CreateAccountResponse> CreateAccountAsync(CreateAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateAttendee



        /// <summary>
        /// Creates a new attendee for an active Amazon Chime SDK meeting. For more information
        /// about the Amazon Chime SDK, see <a href="https://docs.aws.amazon.com/chime/latest/dg/meetings-sdk.html">Using
        /// the Amazon Chime SDK</a> in the <i>Amazon Chime Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAttendee service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAttendee service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateAttendee">REST API Reference for CreateAttendee Operation</seealso>
        Task<CreateAttendeeResponse> CreateAttendeeAsync(CreateAttendeeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateBot



        /// <summary>
        /// Creates a bot for an Amazon Chime Enterprise account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateBot service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateBot">REST API Reference for CreateBot Operation</seealso>
        Task<CreateBotResponse> CreateBotAsync(CreateBotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateMeeting



        /// <summary>
        /// Creates a new Amazon Chime SDK meeting in the specified media Region with no initial
        /// attendees. For more information about specifying media Regions, see <a href="https://docs.aws.amazon.com/chime/latest/dg/chime-sdk-meetings-regions.html">Amazon
        /// Chime SDK Media Regions</a> in the <i>Amazon Chime Developer Guide</i>. For more information
        /// about the Amazon Chime SDK, see <a href="https://docs.aws.amazon.com/chime/latest/dg/meetings-sdk.html">Using
        /// the Amazon Chime SDK</a> in the <i>Amazon Chime Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMeeting service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMeeting service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateMeeting">REST API Reference for CreateMeeting Operation</seealso>
        Task<CreateMeetingResponse> CreateMeetingAsync(CreateMeetingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateMeetingWithAttendees



        /// <summary>
        /// Creates a new Amazon Chime SDK meeting in the specified media Region, with attendees.
        /// For more information about specifying media Regions, see <a href="https://docs.aws.amazon.com/chime/latest/dg/chime-sdk-meetings-regions.html">Amazon
        /// Chime SDK Media Regions</a> in the <i>Amazon Chime Developer Guide</i>. For more information
        /// about the Amazon Chime SDK, see <a href="https://docs.aws.amazon.com/chime/latest/dg/meetings-sdk.html">Using
        /// the Amazon Chime SDK</a> in the <i>Amazon Chime Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMeetingWithAttendees service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMeetingWithAttendees service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateMeetingWithAttendees">REST API Reference for CreateMeetingWithAttendees Operation</seealso>
        Task<CreateMeetingWithAttendeesResponse> CreateMeetingWithAttendeesAsync(CreateMeetingWithAttendeesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreatePhoneNumberOrder



        /// <summary>
        /// Creates an order for phone numbers to be provisioned. Choose from Amazon Chime Business
        /// Calling and Amazon Chime Voice Connector product types. For toll-free numbers, you
        /// must use the Amazon Chime Voice Connector product type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePhoneNumberOrder service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePhoneNumberOrder service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreatePhoneNumberOrder">REST API Reference for CreatePhoneNumberOrder Operation</seealso>
        Task<CreatePhoneNumberOrderResponse> CreatePhoneNumberOrderAsync(CreatePhoneNumberOrderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateProxySession



        /// <summary>
        /// Creates a proxy session on the specified Amazon Chime Voice Connector for the specified
        /// participant phone numbers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProxySession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateProxySession service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateProxySession">REST API Reference for CreateProxySession Operation</seealso>
        Task<CreateProxySessionResponse> CreateProxySessionAsync(CreateProxySessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateRoom



        /// <summary>
        /// Creates a chat room for the specified Amazon Chime Enterprise account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRoom service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRoom service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateRoom">REST API Reference for CreateRoom Operation</seealso>
        Task<CreateRoomResponse> CreateRoomAsync(CreateRoomRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateRoomMembership



        /// <summary>
        /// Adds a member to a chat room in an Amazon Chime Enterprise account. A member can be
        /// either a user or a bot. The member role designates whether the member is a chat room
        /// administrator or a general chat room member.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRoomMembership service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRoomMembership service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateRoomMembership">REST API Reference for CreateRoomMembership Operation</seealso>
        Task<CreateRoomMembershipResponse> CreateRoomMembershipAsync(CreateRoomMembershipRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateUser



        /// <summary>
        /// Creates a user under the specified Amazon Chime account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateUser service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateUser">REST API Reference for CreateUser Operation</seealso>
        Task<CreateUserResponse> CreateUserAsync(CreateUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateVoiceConnector



        /// <summary>
        /// Creates an Amazon Chime Voice Connector under the administrator's AWS account. You
        /// can choose to create an Amazon Chime Voice Connector in a specific AWS Region.
        /// 
        ///  
        /// <para>
        /// Enabling <a>CreateVoiceConnectorRequest$RequireEncryption</a> configures your Amazon
        /// Chime Voice Connector to use TLS transport for SIP signaling and Secure RTP (SRTP)
        /// for media. Inbound calls use TLS transport, and unencrypted outbound calls are blocked.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVoiceConnector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateVoiceConnector service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateVoiceConnector">REST API Reference for CreateVoiceConnector Operation</seealso>
        Task<CreateVoiceConnectorResponse> CreateVoiceConnectorAsync(CreateVoiceConnectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateVoiceConnectorGroup



        /// <summary>
        /// Creates an Amazon Chime Voice Connector group under the administrator's AWS account.
        /// You can associate Amazon Chime Voice Connectors with the Amazon Chime Voice Connector
        /// group by including <code>VoiceConnectorItems</code> in the request.
        /// 
        ///  
        /// <para>
        /// You can include Amazon Chime Voice Connectors from different AWS Regions in your group.
        /// This creates a fault tolerant mechanism for fallback in case of availability events.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVoiceConnectorGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateVoiceConnectorGroup service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateVoiceConnectorGroup">REST API Reference for CreateVoiceConnectorGroup Operation</seealso>
        Task<CreateVoiceConnectorGroupResponse> CreateVoiceConnectorGroupAsync(CreateVoiceConnectorGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteAccount



        /// <summary>
        /// Deletes the specified Amazon Chime account. You must suspend all users before deleting
        /// a <code>Team</code> account. You can use the <a>BatchSuspendUser</a> action to do
        /// so.
        /// 
        ///  
        /// <para>
        /// For <code>EnterpriseLWA</code> and <code>EnterpriseAD</code> accounts, you must release
        /// the claimed domains for your Amazon Chime account before deletion. As soon as you
        /// release the domain, all users under that account are suspended.
        /// </para>
        ///  
        /// <para>
        /// Deleted accounts appear in your <code>Disabled</code> accounts list for 90 days. To
        /// restore a deleted account from your <code>Disabled</code> accounts list, you must
        /// contact AWS Support.
        /// </para>
        ///  
        /// <para>
        /// After 90 days, deleted accounts are permanently removed from your <code>Disabled</code>
        /// accounts list.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAccount service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnprocessableEntityException">
        /// The request was well-formed but was unable to be followed due to semantic errors.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteAccount">REST API Reference for DeleteAccount Operation</seealso>
        Task<DeleteAccountResponse> DeleteAccountAsync(DeleteAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteAttendee



        /// <summary>
        /// Deletes an attendee from the specified Amazon Chime SDK meeting and deletes their
        /// <code>JoinToken</code>. Attendees are automatically deleted when a Amazon Chime SDK
        /// meeting is deleted. For more information about the Amazon Chime SDK, see <a href="https://docs.aws.amazon.com/chime/latest/dg/meetings-sdk.html">Using
        /// the Amazon Chime SDK</a> in the <i>Amazon Chime Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAttendee service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAttendee service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteAttendee">REST API Reference for DeleteAttendee Operation</seealso>
        Task<DeleteAttendeeResponse> DeleteAttendeeAsync(DeleteAttendeeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteEventsConfiguration



        /// <summary>
        /// Deletes the events configuration that allows a bot to receive outgoing events.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventsConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEventsConfiguration service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteEventsConfiguration">REST API Reference for DeleteEventsConfiguration Operation</seealso>
        Task<DeleteEventsConfigurationResponse> DeleteEventsConfigurationAsync(DeleteEventsConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteMeeting



        /// <summary>
        /// Deletes the specified Amazon Chime SDK meeting. When a meeting is deleted, its attendees
        /// are also deleted and clients can no longer join it. For more information about the
        /// Amazon Chime SDK, see <a href="https://docs.aws.amazon.com/chime/latest/dg/meetings-sdk.html">Using
        /// the Amazon Chime SDK</a> in the <i>Amazon Chime Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMeeting service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMeeting service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteMeeting">REST API Reference for DeleteMeeting Operation</seealso>
        Task<DeleteMeetingResponse> DeleteMeetingAsync(DeleteMeetingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeletePhoneNumber



        /// <summary>
        /// Moves the specified phone number into the <b>Deletion queue</b>. A phone number must
        /// be disassociated from any users or Amazon Chime Voice Connectors before it can be
        /// deleted.
        /// 
        ///  
        /// <para>
        /// Deleted phone numbers remain in the <b>Deletion queue</b> for 7 days before they are
        /// deleted permanently.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePhoneNumber service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePhoneNumber service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeletePhoneNumber">REST API Reference for DeletePhoneNumber Operation</seealso>
        Task<DeletePhoneNumberResponse> DeletePhoneNumberAsync(DeletePhoneNumberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteProxySession



        /// <summary>
        /// Deletes the specified proxy session from the specified Amazon Chime Voice Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProxySession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteProxySession service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteProxySession">REST API Reference for DeleteProxySession Operation</seealso>
        Task<DeleteProxySessionResponse> DeleteProxySessionAsync(DeleteProxySessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteRoom



        /// <summary>
        /// Deletes a chat room in an Amazon Chime Enterprise account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoom service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRoom service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteRoom">REST API Reference for DeleteRoom Operation</seealso>
        Task<DeleteRoomResponse> DeleteRoomAsync(DeleteRoomRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteRoomMembership



        /// <summary>
        /// Removes a member from a chat room in an Amazon Chime Enterprise account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoomMembership service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRoomMembership service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteRoomMembership">REST API Reference for DeleteRoomMembership Operation</seealso>
        Task<DeleteRoomMembershipResponse> DeleteRoomMembershipAsync(DeleteRoomMembershipRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteVoiceConnector



        /// <summary>
        /// Deletes the specified Amazon Chime Voice Connector. Any phone numbers associated with
        /// the Amazon Chime Voice Connector must be disassociated from it before it can be deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceConnector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVoiceConnector service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteVoiceConnector">REST API Reference for DeleteVoiceConnector Operation</seealso>
        Task<DeleteVoiceConnectorResponse> DeleteVoiceConnectorAsync(DeleteVoiceConnectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteVoiceConnectorEmergencyCallingConfiguration



        /// <summary>
        /// Deletes the emergency calling configuration details from the specified Amazon Chime
        /// Voice Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceConnectorEmergencyCallingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVoiceConnectorEmergencyCallingConfiguration service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteVoiceConnectorEmergencyCallingConfiguration">REST API Reference for DeleteVoiceConnectorEmergencyCallingConfiguration Operation</seealso>
        Task<DeleteVoiceConnectorEmergencyCallingConfigurationResponse> DeleteVoiceConnectorEmergencyCallingConfigurationAsync(DeleteVoiceConnectorEmergencyCallingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteVoiceConnectorGroup



        /// <summary>
        /// Deletes the specified Amazon Chime Voice Connector group. Any <code>VoiceConnectorItems</code>
        /// and phone numbers associated with the group must be removed before it can be deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceConnectorGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVoiceConnectorGroup service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteVoiceConnectorGroup">REST API Reference for DeleteVoiceConnectorGroup Operation</seealso>
        Task<DeleteVoiceConnectorGroupResponse> DeleteVoiceConnectorGroupAsync(DeleteVoiceConnectorGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteVoiceConnectorOrigination



        /// <summary>
        /// Deletes the origination settings for the specified Amazon Chime Voice Connector.
        /// 
        ///  <note> 
        /// <para>
        /// If emergency calling is configured for the Amazon Chime Voice Connector, it must be
        /// deleted prior to deleting the origination settings.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceConnectorOrigination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVoiceConnectorOrigination service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteVoiceConnectorOrigination">REST API Reference for DeleteVoiceConnectorOrigination Operation</seealso>
        Task<DeleteVoiceConnectorOriginationResponse> DeleteVoiceConnectorOriginationAsync(DeleteVoiceConnectorOriginationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteVoiceConnectorProxy



        /// <summary>
        /// Deletes the proxy configuration from the specified Amazon Chime Voice Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceConnectorProxy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVoiceConnectorProxy service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteVoiceConnectorProxy">REST API Reference for DeleteVoiceConnectorProxy Operation</seealso>
        Task<DeleteVoiceConnectorProxyResponse> DeleteVoiceConnectorProxyAsync(DeleteVoiceConnectorProxyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteVoiceConnectorStreamingConfiguration



        /// <summary>
        /// Deletes the streaming configuration for the specified Amazon Chime Voice Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceConnectorStreamingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVoiceConnectorStreamingConfiguration service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteVoiceConnectorStreamingConfiguration">REST API Reference for DeleteVoiceConnectorStreamingConfiguration Operation</seealso>
        Task<DeleteVoiceConnectorStreamingConfigurationResponse> DeleteVoiceConnectorStreamingConfigurationAsync(DeleteVoiceConnectorStreamingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteVoiceConnectorTermination



        /// <summary>
        /// Deletes the termination settings for the specified Amazon Chime Voice Connector.
        /// 
        ///  <note> 
        /// <para>
        /// If emergency calling is configured for the Amazon Chime Voice Connector, it must be
        /// deleted prior to deleting the termination settings.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceConnectorTermination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVoiceConnectorTermination service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteVoiceConnectorTermination">REST API Reference for DeleteVoiceConnectorTermination Operation</seealso>
        Task<DeleteVoiceConnectorTerminationResponse> DeleteVoiceConnectorTerminationAsync(DeleteVoiceConnectorTerminationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteVoiceConnectorTerminationCredentials



        /// <summary>
        /// Deletes the specified SIP credentials used by your equipment to authenticate during
        /// call termination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceConnectorTerminationCredentials service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVoiceConnectorTerminationCredentials service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteVoiceConnectorTerminationCredentials">REST API Reference for DeleteVoiceConnectorTerminationCredentials Operation</seealso>
        Task<DeleteVoiceConnectorTerminationCredentialsResponse> DeleteVoiceConnectorTerminationCredentialsAsync(DeleteVoiceConnectorTerminationCredentialsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisassociatePhoneNumberFromUser



        /// <summary>
        /// Disassociates the primary provisioned phone number from the specified Amazon Chime
        /// user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociatePhoneNumberFromUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociatePhoneNumberFromUser service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DisassociatePhoneNumberFromUser">REST API Reference for DisassociatePhoneNumberFromUser Operation</seealso>
        Task<DisassociatePhoneNumberFromUserResponse> DisassociatePhoneNumberFromUserAsync(DisassociatePhoneNumberFromUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisassociatePhoneNumbersFromVoiceConnector



        /// <summary>
        /// Disassociates the specified phone numbers from the specified Amazon Chime Voice Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociatePhoneNumbersFromVoiceConnector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociatePhoneNumbersFromVoiceConnector service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DisassociatePhoneNumbersFromVoiceConnector">REST API Reference for DisassociatePhoneNumbersFromVoiceConnector Operation</seealso>
        Task<DisassociatePhoneNumbersFromVoiceConnectorResponse> DisassociatePhoneNumbersFromVoiceConnectorAsync(DisassociatePhoneNumbersFromVoiceConnectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisassociatePhoneNumbersFromVoiceConnectorGroup



        /// <summary>
        /// Disassociates the specified phone numbers from the specified Amazon Chime Voice Connector
        /// group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociatePhoneNumbersFromVoiceConnectorGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociatePhoneNumbersFromVoiceConnectorGroup service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DisassociatePhoneNumbersFromVoiceConnectorGroup">REST API Reference for DisassociatePhoneNumbersFromVoiceConnectorGroup Operation</seealso>
        Task<DisassociatePhoneNumbersFromVoiceConnectorGroupResponse> DisassociatePhoneNumbersFromVoiceConnectorGroupAsync(DisassociatePhoneNumbersFromVoiceConnectorGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisassociateSigninDelegateGroupsFromAccount



        /// <summary>
        /// Disassociates the specified sign-in delegate groups from the specified Amazon Chime
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateSigninDelegateGroupsFromAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateSigninDelegateGroupsFromAccount service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DisassociateSigninDelegateGroupsFromAccount">REST API Reference for DisassociateSigninDelegateGroupsFromAccount Operation</seealso>
        Task<DisassociateSigninDelegateGroupsFromAccountResponse> DisassociateSigninDelegateGroupsFromAccountAsync(DisassociateSigninDelegateGroupsFromAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetAccount



        /// <summary>
        /// Retrieves details for the specified Amazon Chime account, such as account type and
        /// supported licenses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAccount service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetAccount">REST API Reference for GetAccount Operation</seealso>
        Task<GetAccountResponse> GetAccountAsync(GetAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetAccountSettings



        /// <summary>
        /// Retrieves account settings for the specified Amazon Chime account ID, such as remote
        /// control and dial out settings. For more information about these settings, see <a href="https://docs.aws.amazon.com/chime/latest/ag/policies.html">Use
        /// the Policies Page</a> in the <i>Amazon Chime Administration Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccountSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAccountSettings service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetAccountSettings">REST API Reference for GetAccountSettings Operation</seealso>
        Task<GetAccountSettingsResponse> GetAccountSettingsAsync(GetAccountSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetAttendee



        /// <summary>
        /// Gets the Amazon Chime SDK attendee details for a specified meeting ID and attendee
        /// ID. For more information about the Amazon Chime SDK, see <a href="https://docs.aws.amazon.com/chime/latest/dg/meetings-sdk.html">Using
        /// the Amazon Chime SDK</a> in the <i>Amazon Chime Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAttendee service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAttendee service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetAttendee">REST API Reference for GetAttendee Operation</seealso>
        Task<GetAttendeeResponse> GetAttendeeAsync(GetAttendeeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetBot



        /// <summary>
        /// Retrieves details for the specified bot, such as bot email address, bot type, status,
        /// and display name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBot service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetBot">REST API Reference for GetBot Operation</seealso>
        Task<GetBotResponse> GetBotAsync(GetBotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetEventsConfiguration



        /// <summary>
        /// Gets details for an events configuration that allows a bot to receive outgoing events,
        /// such as an HTTPS endpoint or Lambda function ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEventsConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEventsConfiguration service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetEventsConfiguration">REST API Reference for GetEventsConfiguration Operation</seealso>
        Task<GetEventsConfigurationResponse> GetEventsConfigurationAsync(GetEventsConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetGlobalSettings



        /// <summary>
        /// Retrieves global settings for the administrator's AWS account, such as Amazon Chime
        /// Business Calling and Amazon Chime Voice Connector settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGlobalSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetGlobalSettings service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetGlobalSettings">REST API Reference for GetGlobalSettings Operation</seealso>
        Task<GetGlobalSettingsResponse> GetGlobalSettingsAsync(GetGlobalSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetMeeting



        /// <summary>
        /// Gets the Amazon Chime SDK meeting details for the specified meeting ID. For more information
        /// about the Amazon Chime SDK, see <a href="https://docs.aws.amazon.com/chime/latest/dg/meetings-sdk.html">Using
        /// the Amazon Chime SDK</a> in the <i>Amazon Chime Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMeeting service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMeeting service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetMeeting">REST API Reference for GetMeeting Operation</seealso>
        Task<GetMeetingResponse> GetMeetingAsync(GetMeetingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetPhoneNumber



        /// <summary>
        /// Retrieves details for the specified phone number ID, such as associations, capabilities,
        /// and product type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPhoneNumber service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPhoneNumber service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetPhoneNumber">REST API Reference for GetPhoneNumber Operation</seealso>
        Task<GetPhoneNumberResponse> GetPhoneNumberAsync(GetPhoneNumberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetPhoneNumberOrder



        /// <summary>
        /// Retrieves details for the specified phone number order, such as order creation timestamp,
        /// phone numbers in E.164 format, product type, and order status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPhoneNumberOrder service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPhoneNumberOrder service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetPhoneNumberOrder">REST API Reference for GetPhoneNumberOrder Operation</seealso>
        Task<GetPhoneNumberOrderResponse> GetPhoneNumberOrderAsync(GetPhoneNumberOrderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetPhoneNumberSettings



        /// <summary>
        /// Retrieves the phone number settings for the administrator's AWS account, such as the
        /// default outbound calling name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPhoneNumberSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPhoneNumberSettings service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetPhoneNumberSettings">REST API Reference for GetPhoneNumberSettings Operation</seealso>
        Task<GetPhoneNumberSettingsResponse> GetPhoneNumberSettingsAsync(GetPhoneNumberSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetProxySession



        /// <summary>
        /// Gets the specified proxy session details for the specified Amazon Chime Voice Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProxySession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetProxySession service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetProxySession">REST API Reference for GetProxySession Operation</seealso>
        Task<GetProxySessionResponse> GetProxySessionAsync(GetProxySessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetRetentionSettings



        /// <summary>
        /// Gets the retention settings for the specified Amazon Chime Enterprise account. For
        /// more information about retention settings, see <a href="https://docs.aws.amazon.com/chime/latest/ag/chat-retention.html">Managing
        /// Chat Retention Policies</a> in the <i>Amazon Chime Administration Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRetentionSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRetentionSettings service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetRetentionSettings">REST API Reference for GetRetentionSettings Operation</seealso>
        Task<GetRetentionSettingsResponse> GetRetentionSettingsAsync(GetRetentionSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetRoom



        /// <summary>
        /// Retrieves room details, such as the room name, for a room in an Amazon Chime Enterprise
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRoom service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRoom service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetRoom">REST API Reference for GetRoom Operation</seealso>
        Task<GetRoomResponse> GetRoomAsync(GetRoomRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetUser



        /// <summary>
        /// Retrieves details for the specified user ID, such as primary email address, license
        /// type, and personal meeting PIN.
        /// 
        ///  
        /// <para>
        /// To retrieve user details with an email address instead of a user ID, use the <a>ListUsers</a>
        /// action, and then filter by email address.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetUser service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetUser">REST API Reference for GetUser Operation</seealso>
        Task<GetUserResponse> GetUserAsync(GetUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetUserSettings



        /// <summary>
        /// Retrieves settings for the specified user ID, such as any associated phone number
        /// settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUserSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetUserSettings service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetUserSettings">REST API Reference for GetUserSettings Operation</seealso>
        Task<GetUserSettingsResponse> GetUserSettingsAsync(GetUserSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetVoiceConnector



        /// <summary>
        /// Retrieves details for the specified Amazon Chime Voice Connector, such as timestamps,
        /// name, outbound host, and encryption requirements.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetVoiceConnector service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetVoiceConnector">REST API Reference for GetVoiceConnector Operation</seealso>
        Task<GetVoiceConnectorResponse> GetVoiceConnectorAsync(GetVoiceConnectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetVoiceConnectorEmergencyCallingConfiguration



        /// <summary>
        /// Gets the emergency calling configuration details for the specified Amazon Chime Voice
        /// Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnectorEmergencyCallingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetVoiceConnectorEmergencyCallingConfiguration service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetVoiceConnectorEmergencyCallingConfiguration">REST API Reference for GetVoiceConnectorEmergencyCallingConfiguration Operation</seealso>
        Task<GetVoiceConnectorEmergencyCallingConfigurationResponse> GetVoiceConnectorEmergencyCallingConfigurationAsync(GetVoiceConnectorEmergencyCallingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetVoiceConnectorGroup



        /// <summary>
        /// Retrieves details for the specified Amazon Chime Voice Connector group, such as timestamps,
        /// name, and associated <code>VoiceConnectorItems</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnectorGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetVoiceConnectorGroup service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetVoiceConnectorGroup">REST API Reference for GetVoiceConnectorGroup Operation</seealso>
        Task<GetVoiceConnectorGroupResponse> GetVoiceConnectorGroupAsync(GetVoiceConnectorGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetVoiceConnectorLoggingConfiguration



        /// <summary>
        /// Retrieves the logging configuration details for the specified Amazon Chime Voice Connector.
        /// Shows whether SIP message logs are enabled for sending to Amazon CloudWatch Logs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnectorLoggingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetVoiceConnectorLoggingConfiguration service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetVoiceConnectorLoggingConfiguration">REST API Reference for GetVoiceConnectorLoggingConfiguration Operation</seealso>
        Task<GetVoiceConnectorLoggingConfigurationResponse> GetVoiceConnectorLoggingConfigurationAsync(GetVoiceConnectorLoggingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetVoiceConnectorOrigination



        /// <summary>
        /// Retrieves origination setting details for the specified Amazon Chime Voice Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnectorOrigination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetVoiceConnectorOrigination service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetVoiceConnectorOrigination">REST API Reference for GetVoiceConnectorOrigination Operation</seealso>
        Task<GetVoiceConnectorOriginationResponse> GetVoiceConnectorOriginationAsync(GetVoiceConnectorOriginationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetVoiceConnectorProxy



        /// <summary>
        /// Gets the proxy configuration details for the specified Amazon Chime Voice Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnectorProxy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetVoiceConnectorProxy service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetVoiceConnectorProxy">REST API Reference for GetVoiceConnectorProxy Operation</seealso>
        Task<GetVoiceConnectorProxyResponse> GetVoiceConnectorProxyAsync(GetVoiceConnectorProxyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetVoiceConnectorStreamingConfiguration



        /// <summary>
        /// Retrieves the streaming configuration details for the specified Amazon Chime Voice
        /// Connector. Shows whether media streaming is enabled for sending to Amazon Kinesis.
        /// It also shows the retention period, in hours, for the Amazon Kinesis data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnectorStreamingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetVoiceConnectorStreamingConfiguration service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetVoiceConnectorStreamingConfiguration">REST API Reference for GetVoiceConnectorStreamingConfiguration Operation</seealso>
        Task<GetVoiceConnectorStreamingConfigurationResponse> GetVoiceConnectorStreamingConfigurationAsync(GetVoiceConnectorStreamingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetVoiceConnectorTermination



        /// <summary>
        /// Retrieves termination setting details for the specified Amazon Chime Voice Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnectorTermination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetVoiceConnectorTermination service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetVoiceConnectorTermination">REST API Reference for GetVoiceConnectorTermination Operation</seealso>
        Task<GetVoiceConnectorTerminationResponse> GetVoiceConnectorTerminationAsync(GetVoiceConnectorTerminationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetVoiceConnectorTerminationHealth



        /// <summary>
        /// Retrieves information about the last time a SIP <code>OPTIONS</code> ping was received
        /// from your SIP infrastructure for the specified Amazon Chime Voice Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnectorTerminationHealth service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetVoiceConnectorTerminationHealth service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetVoiceConnectorTerminationHealth">REST API Reference for GetVoiceConnectorTerminationHealth Operation</seealso>
        Task<GetVoiceConnectorTerminationHealthResponse> GetVoiceConnectorTerminationHealthAsync(GetVoiceConnectorTerminationHealthRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  InviteUsers



        /// <summary>
        /// Sends email to a maximum of 50 users, inviting them to the specified Amazon Chime
        /// <code>Team</code> account. Only <code>Team</code> account types are currently supported
        /// for this action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InviteUsers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the InviteUsers service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/InviteUsers">REST API Reference for InviteUsers Operation</seealso>
        Task<InviteUsersResponse> InviteUsersAsync(InviteUsersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAccounts



        /// <summary>
        /// Lists the Amazon Chime accounts under the administrator's AWS account. You can filter
        /// accounts by account name prefix. To find out which Amazon Chime account a user belongs
        /// to, you can filter by the user's email address, which returns one account result.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccounts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAccounts service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListAccounts">REST API Reference for ListAccounts Operation</seealso>
        Task<ListAccountsResponse> ListAccountsAsync(ListAccountsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAttendees



        /// <summary>
        /// Lists the attendees for the specified Amazon Chime SDK meeting. For more information
        /// about the Amazon Chime SDK, see <a href="https://docs.aws.amazon.com/chime/latest/dg/meetings-sdk.html">Using
        /// the Amazon Chime SDK</a> in the <i>Amazon Chime Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAttendees service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAttendees service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListAttendees">REST API Reference for ListAttendees Operation</seealso>
        Task<ListAttendeesResponse> ListAttendeesAsync(ListAttendeesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAttendeeTags



        /// <summary>
        /// Lists the tags applied to an Amazon Chime SDK attendee resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAttendeeTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAttendeeTags service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListAttendeeTags">REST API Reference for ListAttendeeTags Operation</seealso>
        Task<ListAttendeeTagsResponse> ListAttendeeTagsAsync(ListAttendeeTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListBots



        /// <summary>
        /// Lists the bots associated with the administrator's Amazon Chime Enterprise account
        /// ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBots service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBots service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListBots">REST API Reference for ListBots Operation</seealso>
        Task<ListBotsResponse> ListBotsAsync(ListBotsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListMeetings



        /// <summary>
        /// Lists up to 100 active Amazon Chime SDK meetings. For more information about the Amazon
        /// Chime SDK, see <a href="https://docs.aws.amazon.com/chime/latest/dg/meetings-sdk.html">Using
        /// the Amazon Chime SDK</a> in the <i>Amazon Chime Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMeetings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMeetings service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListMeetings">REST API Reference for ListMeetings Operation</seealso>
        Task<ListMeetingsResponse> ListMeetingsAsync(ListMeetingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListMeetingTags



        /// <summary>
        /// Lists the tags applied to an Amazon Chime SDK meeting resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMeetingTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMeetingTags service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListMeetingTags">REST API Reference for ListMeetingTags Operation</seealso>
        Task<ListMeetingTagsResponse> ListMeetingTagsAsync(ListMeetingTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListPhoneNumberOrders



        /// <summary>
        /// Lists the phone number orders for the administrator's Amazon Chime account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPhoneNumberOrders service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPhoneNumberOrders service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListPhoneNumberOrders">REST API Reference for ListPhoneNumberOrders Operation</seealso>
        Task<ListPhoneNumberOrdersResponse> ListPhoneNumberOrdersAsync(ListPhoneNumberOrdersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListPhoneNumbers



        /// <summary>
        /// Lists the phone numbers for the specified Amazon Chime account, Amazon Chime user,
        /// Amazon Chime Voice Connector, or Amazon Chime Voice Connector group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPhoneNumbers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPhoneNumbers service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListPhoneNumbers">REST API Reference for ListPhoneNumbers Operation</seealso>
        Task<ListPhoneNumbersResponse> ListPhoneNumbersAsync(ListPhoneNumbersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListProxySessions



        /// <summary>
        /// Lists the proxy sessions for the specified Amazon Chime Voice Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProxySessions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListProxySessions service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListProxySessions">REST API Reference for ListProxySessions Operation</seealso>
        Task<ListProxySessionsResponse> ListProxySessionsAsync(ListProxySessionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListRoomMemberships



        /// <summary>
        /// Lists the membership details for the specified room in an Amazon Chime Enterprise
        /// account, such as the members' IDs, email addresses, and names.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRoomMemberships service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRoomMemberships service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListRoomMemberships">REST API Reference for ListRoomMemberships Operation</seealso>
        Task<ListRoomMembershipsResponse> ListRoomMembershipsAsync(ListRoomMembershipsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListRooms



        /// <summary>
        /// Lists the room details for the specified Amazon Chime Enterprise account. Optionally,
        /// filter the results by a member ID (user ID or bot ID) to see a list of rooms that
        /// the member belongs to.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRooms service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRooms service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListRooms">REST API Reference for ListRooms Operation</seealso>
        Task<ListRoomsResponse> ListRoomsAsync(ListRoomsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Lists the tags applied to an Amazon Chime SDK meeting resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListUsers



        /// <summary>
        /// Lists the users that belong to the specified Amazon Chime account. You can specify
        /// an email address to list only the user that the email address belongs to.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUsers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListUsers service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListUsers">REST API Reference for ListUsers Operation</seealso>
        Task<ListUsersResponse> ListUsersAsync(ListUsersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListVoiceConnectorGroups



        /// <summary>
        /// Lists the Amazon Chime Voice Connector groups for the administrator's AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVoiceConnectorGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListVoiceConnectorGroups service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListVoiceConnectorGroups">REST API Reference for ListVoiceConnectorGroups Operation</seealso>
        Task<ListVoiceConnectorGroupsResponse> ListVoiceConnectorGroupsAsync(ListVoiceConnectorGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListVoiceConnectors



        /// <summary>
        /// Lists the Amazon Chime Voice Connectors for the administrator's AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVoiceConnectors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListVoiceConnectors service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListVoiceConnectors">REST API Reference for ListVoiceConnectors Operation</seealso>
        Task<ListVoiceConnectorsResponse> ListVoiceConnectorsAsync(ListVoiceConnectorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListVoiceConnectorTerminationCredentials



        /// <summary>
        /// Lists the SIP credentials for the specified Amazon Chime Voice Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVoiceConnectorTerminationCredentials service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListVoiceConnectorTerminationCredentials service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListVoiceConnectorTerminationCredentials">REST API Reference for ListVoiceConnectorTerminationCredentials Operation</seealso>
        Task<ListVoiceConnectorTerminationCredentialsResponse> ListVoiceConnectorTerminationCredentialsAsync(ListVoiceConnectorTerminationCredentialsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  LogoutUser



        /// <summary>
        /// Logs out the specified user from all of the devices they are currently logged into.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the LogoutUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the LogoutUser service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/LogoutUser">REST API Reference for LogoutUser Operation</seealso>
        Task<LogoutUserResponse> LogoutUserAsync(LogoutUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutEventsConfiguration



        /// <summary>
        /// Creates an events configuration that allows a bot to receive outgoing events sent
        /// by Amazon Chime. Choose either an HTTPS endpoint or a Lambda function ARN. For more
        /// information, see <a>Bot</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEventsConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutEventsConfiguration service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/PutEventsConfiguration">REST API Reference for PutEventsConfiguration Operation</seealso>
        Task<PutEventsConfigurationResponse> PutEventsConfigurationAsync(PutEventsConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutRetentionSettings



        /// <summary>
        /// Puts retention settings for the specified Amazon Chime Enterprise account. We recommend
        /// using AWS CloudTrail to monitor usage of this API for your account. For more information,
        /// see <a href="https://docs.aws.amazon.com/chime/latest/ag/cloudtrail.html">Logging
        /// Amazon Chime API Calls with AWS CloudTrail</a> in the <i>Amazon Chime Administration
        /// Guide</i>.
        /// 
        ///  
        /// <para>
        /// To turn off existing retention settings, remove the number of days from the corresponding
        /// <b>RetentionDays</b> field in the <b>RetentionSettings</b> object. For more information
        /// about retention settings, see <a href="https://docs.aws.amazon.com/chime/latest/ag/chat-retention.html">Managing
        /// Chat Retention Policies</a> in the <i>Amazon Chime Administration Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRetentionSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutRetentionSettings service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/PutRetentionSettings">REST API Reference for PutRetentionSettings Operation</seealso>
        Task<PutRetentionSettingsResponse> PutRetentionSettingsAsync(PutRetentionSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutVoiceConnectorEmergencyCallingConfiguration



        /// <summary>
        /// Puts emergency calling configuration details to the specified Amazon Chime Voice Connector,
        /// such as emergency phone numbers and calling countries. Origination and termination
        /// settings must be enabled for the Amazon Chime Voice Connector before emergency calling
        /// can be configured.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutVoiceConnectorEmergencyCallingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutVoiceConnectorEmergencyCallingConfiguration service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/PutVoiceConnectorEmergencyCallingConfiguration">REST API Reference for PutVoiceConnectorEmergencyCallingConfiguration Operation</seealso>
        Task<PutVoiceConnectorEmergencyCallingConfigurationResponse> PutVoiceConnectorEmergencyCallingConfigurationAsync(PutVoiceConnectorEmergencyCallingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutVoiceConnectorLoggingConfiguration



        /// <summary>
        /// Adds a logging configuration for the specified Amazon Chime Voice Connector. The logging
        /// configuration specifies whether SIP message logs are enabled for sending to Amazon
        /// CloudWatch Logs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutVoiceConnectorLoggingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutVoiceConnectorLoggingConfiguration service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/PutVoiceConnectorLoggingConfiguration">REST API Reference for PutVoiceConnectorLoggingConfiguration Operation</seealso>
        Task<PutVoiceConnectorLoggingConfigurationResponse> PutVoiceConnectorLoggingConfigurationAsync(PutVoiceConnectorLoggingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutVoiceConnectorOrigination



        /// <summary>
        /// Adds origination settings for the specified Amazon Chime Voice Connector.
        /// 
        ///  <note> 
        /// <para>
        /// If emergency calling is configured for the Amazon Chime Voice Connector, it must be
        /// deleted prior to turning off origination settings.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutVoiceConnectorOrigination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutVoiceConnectorOrigination service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/PutVoiceConnectorOrigination">REST API Reference for PutVoiceConnectorOrigination Operation</seealso>
        Task<PutVoiceConnectorOriginationResponse> PutVoiceConnectorOriginationAsync(PutVoiceConnectorOriginationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutVoiceConnectorProxy



        /// <summary>
        /// Puts the specified proxy configuration to the specified Amazon Chime Voice Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutVoiceConnectorProxy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutVoiceConnectorProxy service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/PutVoiceConnectorProxy">REST API Reference for PutVoiceConnectorProxy Operation</seealso>
        Task<PutVoiceConnectorProxyResponse> PutVoiceConnectorProxyAsync(PutVoiceConnectorProxyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutVoiceConnectorStreamingConfiguration



        /// <summary>
        /// Adds a streaming configuration for the specified Amazon Chime Voice Connector. The
        /// streaming configuration specifies whether media streaming is enabled for sending to
        /// Amazon Kinesis. It also sets the retention period, in hours, for the Amazon Kinesis
        /// data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutVoiceConnectorStreamingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutVoiceConnectorStreamingConfiguration service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/PutVoiceConnectorStreamingConfiguration">REST API Reference for PutVoiceConnectorStreamingConfiguration Operation</seealso>
        Task<PutVoiceConnectorStreamingConfigurationResponse> PutVoiceConnectorStreamingConfigurationAsync(PutVoiceConnectorStreamingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutVoiceConnectorTermination



        /// <summary>
        /// Adds termination settings for the specified Amazon Chime Voice Connector.
        /// 
        ///  <note> 
        /// <para>
        /// If emergency calling is configured for the Amazon Chime Voice Connector, it must be
        /// deleted prior to turning off termination settings.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutVoiceConnectorTermination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutVoiceConnectorTermination service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/PutVoiceConnectorTermination">REST API Reference for PutVoiceConnectorTermination Operation</seealso>
        Task<PutVoiceConnectorTerminationResponse> PutVoiceConnectorTerminationAsync(PutVoiceConnectorTerminationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutVoiceConnectorTerminationCredentials



        /// <summary>
        /// Adds termination SIP credentials for the specified Amazon Chime Voice Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutVoiceConnectorTerminationCredentials service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutVoiceConnectorTerminationCredentials service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/PutVoiceConnectorTerminationCredentials">REST API Reference for PutVoiceConnectorTerminationCredentials Operation</seealso>
        Task<PutVoiceConnectorTerminationCredentialsResponse> PutVoiceConnectorTerminationCredentialsAsync(PutVoiceConnectorTerminationCredentialsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RedactConversationMessage



        /// <summary>
        /// Redacts the specified message from the specified Amazon Chime conversation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RedactConversationMessage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RedactConversationMessage service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/RedactConversationMessage">REST API Reference for RedactConversationMessage Operation</seealso>
        Task<RedactConversationMessageResponse> RedactConversationMessageAsync(RedactConversationMessageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RedactRoomMessage



        /// <summary>
        /// Redacts the specified message from the specified Amazon Chime chat room.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RedactRoomMessage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RedactRoomMessage service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/RedactRoomMessage">REST API Reference for RedactRoomMessage Operation</seealso>
        Task<RedactRoomMessageResponse> RedactRoomMessageAsync(RedactRoomMessageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RegenerateSecurityToken



        /// <summary>
        /// Regenerates the security token for a bot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegenerateSecurityToken service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegenerateSecurityToken service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/RegenerateSecurityToken">REST API Reference for RegenerateSecurityToken Operation</seealso>
        Task<RegenerateSecurityTokenResponse> RegenerateSecurityTokenAsync(RegenerateSecurityTokenRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ResetPersonalPIN



        /// <summary>
        /// Resets the personal meeting PIN for the specified user on an Amazon Chime account.
        /// Returns the <a>User</a> object with the updated personal meeting PIN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetPersonalPIN service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResetPersonalPIN service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ResetPersonalPIN">REST API Reference for ResetPersonalPIN Operation</seealso>
        Task<ResetPersonalPINResponse> ResetPersonalPINAsync(ResetPersonalPINRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RestorePhoneNumber



        /// <summary>
        /// Moves a phone number from the <b>Deletion queue</b> back into the phone number <b>Inventory</b>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestorePhoneNumber service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RestorePhoneNumber service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/RestorePhoneNumber">REST API Reference for RestorePhoneNumber Operation</seealso>
        Task<RestorePhoneNumberResponse> RestorePhoneNumberAsync(RestorePhoneNumberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SearchAvailablePhoneNumbers



        /// <summary>
        /// Searches phone numbers that can be ordered.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchAvailablePhoneNumbers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchAvailablePhoneNumbers service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/SearchAvailablePhoneNumbers">REST API Reference for SearchAvailablePhoneNumbers Operation</seealso>
        Task<SearchAvailablePhoneNumbersResponse> SearchAvailablePhoneNumbersAsync(SearchAvailablePhoneNumbersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagAttendee



        /// <summary>
        /// Applies the specified tags to the specified Amazon Chime SDK attendee.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagAttendee service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagAttendee service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/TagAttendee">REST API Reference for TagAttendee Operation</seealso>
        Task<TagAttendeeResponse> TagAttendeeAsync(TagAttendeeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagMeeting



        /// <summary>
        /// Applies the specified tags to the specified Amazon Chime SDK meeting.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagMeeting service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagMeeting service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/TagMeeting">REST API Reference for TagMeeting Operation</seealso>
        Task<TagMeetingResponse> TagMeetingAsync(TagMeetingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Applies the specified tags to the specified Amazon Chime SDK meeting resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagAttendee



        /// <summary>
        /// Untags the specified tags from the specified Amazon Chime SDK attendee.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagAttendee service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagAttendee service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UntagAttendee">REST API Reference for UntagAttendee Operation</seealso>
        Task<UntagAttendeeResponse> UntagAttendeeAsync(UntagAttendeeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagMeeting



        /// <summary>
        /// Untags the specified tags from the specified Amazon Chime SDK meeting.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagMeeting service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagMeeting service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UntagMeeting">REST API Reference for UntagMeeting Operation</seealso>
        Task<UntagMeetingResponse> UntagMeetingAsync(UntagMeetingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Untags the specified tags from the specified Amazon Chime SDK meeting resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateAccount



        /// <summary>
        /// Updates account details for the specified Amazon Chime account. Currently, only account
        /// name updates are supported for this action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAccount service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateAccount">REST API Reference for UpdateAccount Operation</seealso>
        Task<UpdateAccountResponse> UpdateAccountAsync(UpdateAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateAccountSettings



        /// <summary>
        /// Updates the settings for the specified Amazon Chime account. You can update settings
        /// for remote control of shared screens, or for the dial-out option. For more information
        /// about these settings, see <a href="https://docs.aws.amazon.com/chime/latest/ag/policies.html">Use
        /// the Policies Page</a> in the <i>Amazon Chime Administration Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccountSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAccountSettings service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateAccountSettings">REST API Reference for UpdateAccountSettings Operation</seealso>
        Task<UpdateAccountSettingsResponse> UpdateAccountSettingsAsync(UpdateAccountSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateBot



        /// <summary>
        /// Updates the status of the specified bot, such as starting or stopping the bot from
        /// running in your Amazon Chime Enterprise account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateBot service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateBot">REST API Reference for UpdateBot Operation</seealso>
        Task<UpdateBotResponse> UpdateBotAsync(UpdateBotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateGlobalSettings



        /// <summary>
        /// Updates global settings for the administrator's AWS account, such as Amazon Chime
        /// Business Calling and Amazon Chime Voice Connector settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGlobalSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateGlobalSettings service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateGlobalSettings">REST API Reference for UpdateGlobalSettings Operation</seealso>
        Task<UpdateGlobalSettingsResponse> UpdateGlobalSettingsAsync(UpdateGlobalSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdatePhoneNumber



        /// <summary>
        /// Updates phone number details, such as product type or calling name, for the specified
        /// phone number ID. You can update one phone number detail at a time. For example, you
        /// can update either the product type or the calling name in one action.
        /// 
        ///  
        /// <para>
        /// For toll-free numbers, you must use the Amazon Chime Voice Connector product type.
        /// </para>
        ///  
        /// <para>
        /// Updates to outbound calling names can take up to 72 hours to complete. Pending updates
        /// to outbound calling names must be complete before you can request another update.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePhoneNumber service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePhoneNumber service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdatePhoneNumber">REST API Reference for UpdatePhoneNumber Operation</seealso>
        Task<UpdatePhoneNumberResponse> UpdatePhoneNumberAsync(UpdatePhoneNumberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdatePhoneNumberSettings



        /// <summary>
        /// Updates the phone number settings for the administrator's AWS account, such as the
        /// default outbound calling name. You can update the default outbound calling name once
        /// every seven days. Outbound calling names can take up to 72 hours to update.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePhoneNumberSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePhoneNumberSettings service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdatePhoneNumberSettings">REST API Reference for UpdatePhoneNumberSettings Operation</seealso>
        Task<UpdatePhoneNumberSettingsResponse> UpdatePhoneNumberSettingsAsync(UpdatePhoneNumberSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateProxySession



        /// <summary>
        /// Updates the specified proxy session details, such as voice or SMS capabilities.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProxySession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateProxySession service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateProxySession">REST API Reference for UpdateProxySession Operation</seealso>
        Task<UpdateProxySessionResponse> UpdateProxySessionAsync(UpdateProxySessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateRoom



        /// <summary>
        /// Updates room details, such as the room name, for a room in an Amazon Chime Enterprise
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoom service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRoom service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateRoom">REST API Reference for UpdateRoom Operation</seealso>
        Task<UpdateRoomResponse> UpdateRoomAsync(UpdateRoomRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateRoomMembership



        /// <summary>
        /// Updates room membership details, such as the member role, for a room in an Amazon
        /// Chime Enterprise account. The member role designates whether the member is a chat
        /// room administrator or a general chat room member. The member role can be updated only
        /// for user IDs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoomMembership service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRoomMembership service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateRoomMembership">REST API Reference for UpdateRoomMembership Operation</seealso>
        Task<UpdateRoomMembershipResponse> UpdateRoomMembershipAsync(UpdateRoomMembershipRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateUser



        /// <summary>
        /// Updates user details for a specified user ID. Currently, only <code>LicenseType</code>
        /// updates are supported for this action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateUser service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateUser">REST API Reference for UpdateUser Operation</seealso>
        Task<UpdateUserResponse> UpdateUserAsync(UpdateUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateUserSettings



        /// <summary>
        /// Updates the settings for the specified user, such as phone number settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateUserSettings service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateUserSettings">REST API Reference for UpdateUserSettings Operation</seealso>
        Task<UpdateUserSettingsResponse> UpdateUserSettingsAsync(UpdateUserSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateVoiceConnector



        /// <summary>
        /// Updates details for the specified Amazon Chime Voice Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVoiceConnector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateVoiceConnector service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateVoiceConnector">REST API Reference for UpdateVoiceConnector Operation</seealso>
        Task<UpdateVoiceConnectorResponse> UpdateVoiceConnectorAsync(UpdateVoiceConnectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateVoiceConnectorGroup



        /// <summary>
        /// Updates details for the specified Amazon Chime Voice Connector group, such as the
        /// name and Amazon Chime Voice Connector priority ranking.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVoiceConnectorGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateVoiceConnectorGroup service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request. For example, when a user
        /// tries to create an account from an unsupported Region.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateVoiceConnectorGroup">REST API Reference for UpdateVoiceConnectorGroup Operation</seealso>
        Task<UpdateVoiceConnectorGroupResponse> UpdateVoiceConnectorGroupAsync(UpdateVoiceConnectorGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}