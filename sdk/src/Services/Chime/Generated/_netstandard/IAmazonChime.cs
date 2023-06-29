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
    /// <important> 
    /// <para>
    ///  <b>Most of these APIs are no longer supported and will not be updated.</b> We recommend
    /// using the latest versions in the <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/welcome.html">Amazon
    /// Chime SDK API reference</a>, in the Amazon Chime SDK.
    /// </para>
    ///  
    /// <para>
    /// Using the latest versions requires migrating to dedicated namespaces. For more information,
    /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
    /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
    /// </para>
    ///  </important> 
    /// <para>
    /// The Amazon Chime application programming interface (API) is designed so administrators
    /// can perform key tasks, such as creating and managing Amazon Chime accounts, users,
    /// and Voice Connectors. This guide provides detailed information about the Amazon Chime
    /// API, including operations, types, inputs and outputs, and error codes.
    /// </para>
    ///  
    /// <para>
    /// You can use an AWS SDK, the AWS Command Line Interface (AWS CLI), or the REST API
    /// to make API calls for Amazon Chime. We recommend using an AWS SDK or the AWS CLI.
    /// The page for each API action contains a <i>See Also</i> section that includes links
    /// to information about using the action with a language-specific AWS SDK or the AWS
    /// CLI.
    /// </para>
    ///  <dl> <dt>Using an AWS SDK</dt> <dd> 
    /// <para>
    ///  You don't need to write code to calculate a signature for request authentication.
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
    ///  </dd> <dt>Using REST APIs</dt> <dd> 
    /// <para>
    /// If you use REST to make API calls, you must authenticate your request by providing
    /// a signature. Amazon Chime supports Signature Version 4. For more information, see
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
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_voice-chime_AssociatePhoneNumbersWithVoiceConnector.html">AssociatePhoneNumbersWithVoiceConnector</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
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
        /// The client is permanently forbidden from making the request.
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
        [Obsolete("Replaced by AssociatePhoneNumbersWithVoiceConnector in the Amazon Chime SDK Voice Namespace")]
        Task<AssociatePhoneNumbersWithVoiceConnectorResponse> AssociatePhoneNumbersWithVoiceConnectorAsync(AssociatePhoneNumbersWithVoiceConnectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AssociatePhoneNumbersWithVoiceConnectorGroup



        /// <summary>
        /// Associates phone numbers with the specified Amazon Chime Voice Connector group.
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_voice-chime_AssociatePhoneNumbersWithVoiceConnectorGroup.html">AssociatePhoneNumbersWithVoiceConnectorGroup</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
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
        /// The client is permanently forbidden from making the request.
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
        [Obsolete("Replaced by AssociatePhoneNumbersWithVoiceConnectorGroup in the Amazon Chime SDK Voice Namespace")]
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
        /// The client is permanently forbidden from making the request.
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
        /// The client is permanently forbidden from making the request.
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
        /// Creates up to 100 new attendees for an active Amazon Chime SDK meeting.
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_meeting-chime_BatchCreateAttendee.html">BatchCreateAttendee</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information about the Amazon Chime SDK, see <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/meetings-sdk.html">Using
        /// the Amazon Chime SDK</a> in the <i>Amazon Chime SDK Developer Guide</i>. 
        /// </para>
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
        /// The client is permanently forbidden from making the request.
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
        [Obsolete("Replaced by BatchCreateAttendee in the Amazon Chime SDK Meetings Namespace")]
        Task<BatchCreateAttendeeResponse> BatchCreateAttendeeAsync(BatchCreateAttendeeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchCreateChannelMembership



        /// <summary>
        /// Adds a specified number of users to a channel.
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_messaging-chime_BatchCreateChannelMembership.html">BatchCreateChannelMembership</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateChannelMembership service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchCreateChannelMembership service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/BatchCreateChannelMembership">REST API Reference for BatchCreateChannelMembership Operation</seealso>
        [Obsolete("Replaced by BatchCreateChannelMembership in the Amazon Chime SDK Messaging Namespace")]
        Task<BatchCreateChannelMembershipResponse> BatchCreateChannelMembershipAsync(BatchCreateChannelMembershipRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchCreateRoomMembership



        /// <summary>
        /// Adds up to 50 members to a chat room in an Amazon Chime Enterprise account. Members
        /// can be users or bots. The member role designates whether the member is a chat room
        /// administrator or a general chat room member.
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
        /// The client is permanently forbidden from making the request.
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
        ///  Phone numbers remain in the <b>Deletion queue</b> for 7 days before they are deleted
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
        /// The client is permanently forbidden from making the request.
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
        /// Users suspended from a <code>Team</code> account are disassociated from the account,but
        /// they can continue to use Amazon Chime as free users. To remove the suspension from
        /// suspended <code>Team</code> account users, invite them to the <code>Team</code> account
        /// again. You can use the <a>InviteUsers</a> action to do so.
        /// </para>
        ///  
        /// <para>
        /// Users suspended from an <code>EnterpriseLWA</code> account are immediately signed
        /// out of Amazon Chime and can no longer sign in. To remove the suspension from suspended
        /// <code>EnterpriseLWA</code> account users, use the <a>BatchUnsuspendUser</a> action.
        /// </para>
        ///  
        /// <para>
        ///  To sign out users without suspending them, use the <a>LogoutUser</a> action.
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
        /// The client is permanently forbidden from making the request.
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
        /// account types, see <a href="https://docs.aws.amazon.com/chime/latest/ag/manage-chime-account.html">
        /// Managing Your Amazon Chime Accounts </a> in the account types, in the <i>Amazon Chime
        /// Administration Guide</i>. 
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
        /// The client is permanently forbidden from making the request.
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
        /// update the product type or the calling name.
        /// 
        ///  
        /// <para>
        /// For toll-free numbers, you cannot use the Amazon Chime Business Calling product type.
        /// For numbers outside the U.S., you must use the Amazon Chime SIP Media Application
        /// Dial-In product type.
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
        /// The client is permanently forbidden from making the request.
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
        /// The client is permanently forbidden from making the request.
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
        /// The client is permanently forbidden from making the request.
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
                
        #region  CreateAppInstance



        /// <summary>
        /// Creates an Amazon Chime SDK messaging <code>AppInstance</code> under an AWS account.
        /// Only SDK messaging customers use this API. <code>CreateAppInstance</code> supports
        /// idempotency behavior as described in the AWS API Standard.
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_identity-chime_CreateAppInstance.html">CreateAppInstance</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAppInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAppInstance service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateAppInstance">REST API Reference for CreateAppInstance Operation</seealso>
        [Obsolete("Replaced by CreateAppInstance in the Amazon Chime SDK Identity Namespace")]
        Task<CreateAppInstanceResponse> CreateAppInstanceAsync(CreateAppInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateAppInstanceAdmin



        /// <summary>
        /// Promotes an <code>AppInstanceUser</code> to an <code>AppInstanceAdmin</code>. The
        /// promoted user can perform the following actions. 
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_identity-chime_CreateAppInstanceAdmin.html">CreateAppInstanceAdmin</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important> <ul> <li> 
        /// <para>
        ///  <code>ChannelModerator</code> actions across all channels in the <code>AppInstance</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DeleteChannelMessage</code> actions.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Only an <code>AppInstanceUser</code> can be promoted to an <code>AppInstanceAdmin</code>
        /// role.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAppInstanceAdmin service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAppInstanceAdmin service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateAppInstanceAdmin">REST API Reference for CreateAppInstanceAdmin Operation</seealso>
        [Obsolete("Replaced by CreateAppInstanceAdmin in the Amazon Chime SDK Identity Namespace")]
        Task<CreateAppInstanceAdminResponse> CreateAppInstanceAdminAsync(CreateAppInstanceAdminRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateAppInstanceUser



        /// <summary>
        /// Creates a user under an Amazon Chime <code>AppInstance</code>. The request consists
        /// of a unique <code>appInstanceUserId</code> and <code>Name</code> for that user.
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_identity-chime_CreateAppInstanceUser.html">CreateAppInstanceUser</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAppInstanceUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAppInstanceUser service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateAppInstanceUser">REST API Reference for CreateAppInstanceUser Operation</seealso>
        [Obsolete("Replaced by CreateAppInstanceUser in the Amazon Chime SDK Identity Namespace")]
        Task<CreateAppInstanceUserResponse> CreateAppInstanceUserAsync(CreateAppInstanceUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateAttendee



        /// <summary>
        /// Creates a new attendee for an active Amazon Chime SDK meeting. For more information
        /// about the Amazon Chime SDK, see <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/meetings-sdk.html">Using
        /// the Amazon Chime SDK</a> in the <i>Amazon Chime SDK Developer Guide</i>. 
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_meeting-chime_CreateAttendee.html">CreateAttendee</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
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
        /// The client is permanently forbidden from making the request.
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
        [Obsolete("Replaced by CreateAttendee in the Amazon Chime SDK Meetings Namespace")]
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
        /// The client is permanently forbidden from making the request.
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
                
        #region  CreateChannel



        /// <summary>
        /// Creates a channel to which you can add users and send messages.
        /// 
        ///  
        /// <para>
        ///  <b>Restriction</b>: You can't change a channel's privacy.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  </note> <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_messaging-chime_CreateChannel.html">CreateChannel</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateChannel service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateChannel">REST API Reference for CreateChannel Operation</seealso>
        [Obsolete("Replaced by CreateChannel in the Amazon Chime SDK Messaging Namespace")]
        Task<CreateChannelResponse> CreateChannelAsync(CreateChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateChannelBan



        /// <summary>
        /// Permanently bans a member from a channel. Moderators can't add banned members to a
        /// channel. To undo a ban, you first have to <code>DeleteChannelBan</code>, and then
        /// <code>CreateChannelMembership</code>. Bans are cleaned up when you delete users or
        /// channels.
        /// 
        ///  
        /// <para>
        /// If you ban a user who is already part of a channel, that user is automatically kicked
        /// from the channel.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  </note> <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_messaging-chime_CreateChannelBan.html">CreateChannelBan</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateChannelBan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateChannelBan service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateChannelBan">REST API Reference for CreateChannelBan Operation</seealso>
        [Obsolete("Replaced by CreateChannelBan in the Amazon Chime SDK Messaging Namespace")]
        Task<CreateChannelBanResponse> CreateChannelBanAsync(CreateChannelBanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateChannelMembership



        /// <summary>
        /// Adds a user to a channel. The <code>InvitedBy</code> response field is derived from
        /// the request header. A channel member can:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// List messages
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Send messages
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Receive messages
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Edit their own messages
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Leave the channel
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Privacy settings impact this action as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Public Channels: You do not need to be a member to list messages, but you must be
        /// a member to send messages.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Private Channels: You must be a member to list or send messages.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  </note> <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_messaging-chime_CreateChannelMembership.html">CreateChannelMembership</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateChannelMembership service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateChannelMembership service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateChannelMembership">REST API Reference for CreateChannelMembership Operation</seealso>
        [Obsolete("Replaced by CreateChannelMembership in the Amazon Chime SDK Messaging Namespace")]
        Task<CreateChannelMembershipResponse> CreateChannelMembershipAsync(CreateChannelMembershipRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateChannelModerator



        /// <summary>
        /// Creates a new <code>ChannelModerator</code>. A channel moderator can:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Add and remove other members of the channel.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Add and remove other moderators of the channel.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Add and remove user bans for the channel.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Redact messages in the channel.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// List messages in the channel.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  </note> <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_messaging-chime_CreateChannelModerator.html">CreateChannelModerator</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateChannelModerator service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateChannelModerator service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateChannelModerator">REST API Reference for CreateChannelModerator Operation</seealso>
        [Obsolete("Replaced by CreateChannelModerator in the Amazon Chime SDK Messaging Namespace")]
        Task<CreateChannelModeratorResponse> CreateChannelModeratorAsync(CreateChannelModeratorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateMediaCapturePipeline



        /// <summary>
        /// Creates a media capture pipeline.
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_media-pipelines-chime_CreateMediaCapturePipeline">CreateMediaCapturePipeline</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMediaCapturePipeline service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMediaCapturePipeline service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateMediaCapturePipeline">REST API Reference for CreateMediaCapturePipeline Operation</seealso>
        [Obsolete("Replaced by CreateMediaCapturePipeline in the Amazon Chime SDK Media Pipelines Namespace")]
        Task<CreateMediaCapturePipelineResponse> CreateMediaCapturePipelineAsync(CreateMediaCapturePipelineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateMeeting



        /// <summary>
        /// Creates a new Amazon Chime SDK meeting in the specified media Region with no initial
        /// attendees. For more information about specifying media Regions, see <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/chime-sdk-meetings-regions.html">Amazon
        /// Chime SDK Media Regions</a> in the <i>Amazon Chime SDK Developer Guide</i> . For more
        /// information about the Amazon Chime SDK, see <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/meetings-sdk.html">Using
        /// the Amazon Chime SDK</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_meeting-chime_CreateMeeting.html">CreateMeeting</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
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
        /// The client is permanently forbidden from making the request.
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
        [Obsolete("Replaced by CreateMeeting in the Amazon Chime SDK Meetings Namespace")]
        Task<CreateMeetingResponse> CreateMeetingAsync(CreateMeetingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateMeetingDialOut



        /// <summary>
        /// Uses the join token and call metadata in a meeting request (From number, To number,
        /// and so forth) to initiate an outbound call to a public switched telephone network
        /// (PSTN) and join them into a Chime meeting. Also ensures that the From number belongs
        /// to the customer.
        /// 
        ///  
        /// <para>
        /// To play welcome audio or implement an interactive voice response (IVR), use the <code>CreateSipMediaApplicationCall</code>
        /// action with the corresponding SIP media application ID.
        /// </para>
        ///  <important> 
        /// <para>
        ///  <b>This API is is not available in a dedicated namespace.</b> 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMeetingDialOut service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMeetingDialOut service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateMeetingDialOut">REST API Reference for CreateMeetingDialOut Operation</seealso>
        Task<CreateMeetingDialOutResponse> CreateMeetingDialOutAsync(CreateMeetingDialOutRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateMeetingWithAttendees



        /// <summary>
        /// Creates a new Amazon Chime SDK meeting in the specified media Region, with attendees.
        /// For more information about specifying media Regions, see <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/chime-sdk-meetings-regions.html">Amazon
        /// Chime SDK Media Regions</a> in the <i>Amazon Chime SDK Developer Guide</i> . For more
        /// information about the Amazon Chime SDK, see <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/meetings-sdk.html">Using
        /// the Amazon Chime SDK</a> in the <i>Amazon Chime SDK Developer Guide</i> . 
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_meeting-chime_CreateMeetingWithAttendees.html">CreateMeetingWithAttendees</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
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
        /// The client is permanently forbidden from making the request.
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
        [Obsolete("Replaced by CreateMeetingWithAttendees in the Amazon Chime SDK Meetings Namespace")]
        Task<CreateMeetingWithAttendeesResponse> CreateMeetingWithAttendeesAsync(CreateMeetingWithAttendeesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreatePhoneNumberOrder



        /// <summary>
        /// Creates an order for phone numbers to be provisioned. For toll-free numbers, you cannot
        /// use the Amazon Chime Business Calling product type. For numbers outside the U.S.,
        /// you must use the Amazon Chime SIP Media Application Dial-In product type.
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
        /// The client is permanently forbidden from making the request.
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
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_voice-chime_CreateProxySession.html">CreateProxySession</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
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
        /// The client is permanently forbidden from making the request.
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
        [Obsolete("Replaced by CreateProxySession in the Amazon Chime SDK Voice Namespace")]
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
        /// The client is permanently forbidden from making the request.
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
        /// The client is permanently forbidden from making the request.
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
                
        #region  CreateSipMediaApplication



        /// <summary>
        /// Creates a SIP media application.
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_voice-chime_CreateSipMediaApplication.html">CreateSipMediaApplication</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSipMediaApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSipMediaApplication service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateSipMediaApplication">REST API Reference for CreateSipMediaApplication Operation</seealso>
        [Obsolete("Replaced by CreateSipMediaApplication in the Amazon Chime SDK Voice Namespace")]
        Task<CreateSipMediaApplicationResponse> CreateSipMediaApplicationAsync(CreateSipMediaApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateSipMediaApplicationCall



        /// <summary>
        /// Creates an outbound call to a phone number from the phone number specified in the
        /// request, and it invokes the endpoint of the specified <code>sipMediaApplicationId</code>.
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_voice-chime_CreateSipMediaApplicationCall.html">CreateSipMediaApplicationCall</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSipMediaApplicationCall service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSipMediaApplicationCall service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateSipMediaApplicationCall">REST API Reference for CreateSipMediaApplicationCall Operation</seealso>
        [Obsolete("Replaced by CreateSipMediaApplicationCall in the Amazon Chime SDK Voice Namespace")]
        Task<CreateSipMediaApplicationCallResponse> CreateSipMediaApplicationCallAsync(CreateSipMediaApplicationCallRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateSipRule



        /// <summary>
        /// Creates a SIP rule which can be used to run a SIP media application as a target for
        /// a specific trigger type.
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_voice-chime_CreateSipRule.html">CreateSipRule</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSipRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSipRule service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateSipRule">REST API Reference for CreateSipRule Operation</seealso>
        [Obsolete("Replaced by CreateSipRule in the Amazon Chime SDK Voice Namespace")]
        Task<CreateSipRuleResponse> CreateSipRuleAsync(CreateSipRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// The client is permanently forbidden from making the request.
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
        /// 
        /// </para>
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_voice-chime_CreateVoiceConnector.html">CreateVoiceConnector</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
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
        /// The client is permanently forbidden from making the request.
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
        [Obsolete("Replaced by CreateVoiceConnector in the Amazon Chime SDK Voice Namespace")]
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
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_voice-chime_CreateVoiceConnectorGroup.html">CreateVoiceConnectorGroup</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
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
        /// The client is permanently forbidden from making the request.
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
        [Obsolete("Replaced by CreateVoiceConnectorGroup in the Amazon Chime SDK Voice Namespace")]
        Task<CreateVoiceConnectorGroupResponse> CreateVoiceConnectorGroupAsync(CreateVoiceConnectorGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteAccount



        /// <summary>
        /// Deletes the specified Amazon Chime account. You must suspend all users before deleting
        /// <code>Team</code> account. You can use the <a>BatchSuspendUser</a> action to dodo.
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
        /// restore deleted account from your <code>Disabled</code> accounts list, you must contact
        /// AWS Support.
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
        /// The client is permanently forbidden from making the request.
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
                
        #region  DeleteAppInstance



        /// <summary>
        /// Deletes an <code>AppInstance</code> and all associated data asynchronously.
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_identity-chime_DeleteAppInstance.html">DeleteAppInstance</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAppInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAppInstance service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteAppInstance">REST API Reference for DeleteAppInstance Operation</seealso>
        [Obsolete("Replaced by DeleteAppInstance in the Amazon Chime SDK Identity Namespace")]
        Task<DeleteAppInstanceResponse> DeleteAppInstanceAsync(DeleteAppInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteAppInstanceAdmin



        /// <summary>
        /// Demotes an <code>AppInstanceAdmin</code> to an <code>AppInstanceUser</code>. This
        /// action does not delete the user.
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_identity-chime_DeleteAppInstanceAdmin.html">DeleteAppInstanceAdmin</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAppInstanceAdmin service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAppInstanceAdmin service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteAppInstanceAdmin">REST API Reference for DeleteAppInstanceAdmin Operation</seealso>
        [Obsolete("Replaced by DeleteAppInstanceAdmin in the Amazon Chime SDK Identity Namespace")]
        Task<DeleteAppInstanceAdminResponse> DeleteAppInstanceAdminAsync(DeleteAppInstanceAdminRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteAppInstanceStreamingConfigurations



        /// <summary>
        /// Deletes the streaming configurations of an <code>AppInstance</code>.
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_identity-chime_DeleteAppInstanceStreamingConfigurations.html">DeleteAppInstanceStreamingConfigurations</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAppInstanceStreamingConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAppInstanceStreamingConfigurations service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteAppInstanceStreamingConfigurations">REST API Reference for DeleteAppInstanceStreamingConfigurations Operation</seealso>
        [Obsolete("Replaced by DeleteAppInstanceStreamingConfigurations in the Amazon Chime SDK Messaging Namespace")]
        Task<DeleteAppInstanceStreamingConfigurationsResponse> DeleteAppInstanceStreamingConfigurationsAsync(DeleteAppInstanceStreamingConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteAppInstanceUser



        /// <summary>
        /// Deletes an <code>AppInstanceUser</code>.
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_identity-chime_DeleteAppInstanceUser.html">DeleteAppInstanceUser</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAppInstanceUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAppInstanceUser service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteAppInstanceUser">REST API Reference for DeleteAppInstanceUser Operation</seealso>
        [Obsolete("Replaced by DeleteAppInstanceUser in the Amazon Chime SDK Identity Namespace")]
        Task<DeleteAppInstanceUserResponse> DeleteAppInstanceUserAsync(DeleteAppInstanceUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteAttendee



        /// <summary>
        /// Deletes an attendee from the specified Amazon Chime SDK meeting and deletes their
        /// <code>JoinToken</code>. Attendees are automatically deleted when a Amazon Chime SDK
        /// meeting is deleted. For more information about the Amazon Chime SDK, see <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/meetings-sdk.html">Using
        /// the Amazon Chime SDK</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_meeting-chime_DeleteAttendee.html">DeleteAttendee</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
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
        /// The client is permanently forbidden from making the request.
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
        [Obsolete("Replaced by DeleteAttendee in the Amazon Chime SDK Meetings Namespace")]
        Task<DeleteAttendeeResponse> DeleteAttendeeAsync(DeleteAttendeeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteChannel



        /// <summary>
        /// Immediately makes a channel and its memberships inaccessible and marks them for deletion.
        /// This is an irreversible process.
        /// 
        ///  <note> 
        /// <para>
        /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  </note> <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_messaging-chime_DeleteChannel.html">DeleteChannel</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteChannel service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteChannel">REST API Reference for DeleteChannel Operation</seealso>
        [Obsolete("Replaced by DeleteChannel in the Amazon Chime SDK Messaging Namespace")]
        Task<DeleteChannelResponse> DeleteChannelAsync(DeleteChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteChannelBan



        /// <summary>
        /// Removes a user from a channel's ban list.
        /// 
        ///  <note> 
        /// <para>
        /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  </note> <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_messaging-chime_DeleteChannelBan.html">DeleteChannelBan</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannelBan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteChannelBan service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteChannelBan">REST API Reference for DeleteChannelBan Operation</seealso>
        [Obsolete("Replaced by DeleteChannelBan in the Amazon Chime SDK Messaging Namespace")]
        Task<DeleteChannelBanResponse> DeleteChannelBanAsync(DeleteChannelBanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteChannelMembership



        /// <summary>
        /// Removes a member from a channel.
        /// 
        ///  <note> 
        /// <para>
        /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  </note> <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_messaging-chime_DeleteChannelMembership.html">DeleteChannelMembership</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannelMembership service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteChannelMembership service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteChannelMembership">REST API Reference for DeleteChannelMembership Operation</seealso>
        [Obsolete("Replaced by DeleteChannelMembership in the Amazon Chime SDK Messaging Namespace")]
        Task<DeleteChannelMembershipResponse> DeleteChannelMembershipAsync(DeleteChannelMembershipRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteChannelMessage



        /// <summary>
        /// Deletes a channel message. Only admins can perform this action. Deletion makes messages
        /// inaccessible immediately. A background process deletes any revisions created by <code>UpdateChannelMessage</code>.
        /// 
        ///  <note> 
        /// <para>
        /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  </note> <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_messaging-chime_DeleteChannelMessage.html">DeleteChannelMessage</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannelMessage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteChannelMessage service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteChannelMessage">REST API Reference for DeleteChannelMessage Operation</seealso>
        [Obsolete("Replaced by DeleteChannelMessage in the Amazon Chime SDK Messaging Namespace")]
        Task<DeleteChannelMessageResponse> DeleteChannelMessageAsync(DeleteChannelMessageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteChannelModerator



        /// <summary>
        /// Deletes a channel moderator.
        /// 
        ///  <note> 
        /// <para>
        /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  </note> <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_messaging-chime_DeleteChannelModerator.html">DeleteChannelModerator</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannelModerator service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteChannelModerator service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteChannelModerator">REST API Reference for DeleteChannelModerator Operation</seealso>
        [Obsolete("Replaced by DeleteChannelModerator in the Amazon Chime SDK Messaging Namespace")]
        Task<DeleteChannelModeratorResponse> DeleteChannelModeratorAsync(DeleteChannelModeratorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// The client is permanently forbidden from making the request.
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
                
        #region  DeleteMediaCapturePipeline



        /// <summary>
        /// Deletes the media capture pipeline.
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_media-pipelines-chime_DeleteMediaCapturePipeline.html">DeleteMediaCapturePipeline</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMediaCapturePipeline service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMediaCapturePipeline service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteMediaCapturePipeline">REST API Reference for DeleteMediaCapturePipeline Operation</seealso>
        [Obsolete("Replaced by DeleteMediaCapturePipeline in the Amazon Chime SDK Media Pipelines Namespace")]
        Task<DeleteMediaCapturePipelineResponse> DeleteMediaCapturePipelineAsync(DeleteMediaCapturePipelineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteMeeting



        /// <summary>
        /// Deletes the specified Amazon Chime SDK meeting. The operation deletes all attendees,
        /// disconnects all clients, and prevents new clients from joining the meeting. For more
        /// information about the Amazon Chime SDK, see <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/meetings-sdk.html">Using
        /// the Amazon Chime SDK</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_meeting-chime_DeleteMeeting.html">DeleteMeeting</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
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
        /// The client is permanently forbidden from making the request.
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
        [Obsolete("Replaced by DeleteMeeting in the Amazon Chime SDK Meetings Namespace")]
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
        /// The client is permanently forbidden from making the request.
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
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_voice-chime_DeleteProxySession.html">DeleteProxySession</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
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
        /// The client is permanently forbidden from making the request.
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
        [Obsolete("Replaced by DeleteProxySession in the Amazon Chime SDK Voice Namespace")]
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
        /// The client is permanently forbidden from making the request.
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
        /// The client is permanently forbidden from making the request.
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
                
        #region  DeleteSipMediaApplication



        /// <summary>
        /// Deletes a SIP media application.
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_voice-chime_DeleteSipMediaApplication.html">DeleteSipMediaApplication</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSipMediaApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSipMediaApplication service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteSipMediaApplication">REST API Reference for DeleteSipMediaApplication Operation</seealso>
        [Obsolete("Replaced by DeleteSipMediaApplication in the Amazon Chime SDK Voice Namespace")]
        Task<DeleteSipMediaApplicationResponse> DeleteSipMediaApplicationAsync(DeleteSipMediaApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteSipRule



        /// <summary>
        /// Deletes a SIP rule. You must disable a SIP rule before you can delete it.
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_voice-chime_DeleteSipRule.html">DeleteSipRule</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSipRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSipRule service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteSipRule">REST API Reference for DeleteSipRule Operation</seealso>
        [Obsolete("Replaced by DeleteSipRule in the Amazon Chime SDK Voice Namespace")]
        Task<DeleteSipRuleResponse> DeleteSipRuleAsync(DeleteSipRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteVoiceConnector



        /// <summary>
        /// Deletes the specified Amazon Chime Voice Connector. Any phone numbers associated with
        /// the Amazon Chime Voice Connector must be disassociated from it before it can be deleted.
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_voice-chime_DeleteVoiceConnector.html">DeleteVoiceConnector</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
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
        /// The client is permanently forbidden from making the request.
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
        [Obsolete("Replaced by DeleteVoiceConnector in the Amazon Chime SDK Voice Namespace")]
        Task<DeleteVoiceConnectorResponse> DeleteVoiceConnectorAsync(DeleteVoiceConnectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteVoiceConnectorEmergencyCallingConfiguration



        /// <summary>
        /// Deletes the emergency calling configuration details from the specified Amazon Chime
        /// Voice Connector.
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_voice-chime_DeleteVoiceConnectorEmergencyCallingConfiguration.html">DeleteVoiceConnectorEmergencyCallingConfiguration</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
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
        /// The client is permanently forbidden from making the request.
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
        [Obsolete("Replaced by DeleteVoiceConnectorEmergencyCallingConfiguration in the Amazon Chime SDK Voice Namespace")]
        Task<DeleteVoiceConnectorEmergencyCallingConfigurationResponse> DeleteVoiceConnectorEmergencyCallingConfigurationAsync(DeleteVoiceConnectorEmergencyCallingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteVoiceConnectorGroup



        /// <summary>
        /// Deletes the specified Amazon Chime Voice Connector group. Any <code>VoiceConnectorItems</code>
        /// and phone numbers associated with the group must be removed before it can be deleted.
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_voice-chime_DeleteVoiceConnectorGroup.html">DeleteVoiceConnectorGroup</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
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
        /// The client is permanently forbidden from making the request.
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
        [Obsolete("Replaced by DeleteVoiceConnectorGroup in the Amazon Chime SDK Voice Namespace")]
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
        ///  </note> <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_voice-chime_DeleteVoiceConnectorOrigination.html">DeleteVoiceConnectorOrigination</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
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
        /// The client is permanently forbidden from making the request.
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
        [Obsolete("Replaced by DeleteVoiceConnectorOrigination in the Amazon Chime SDK Voice Namespace")]
        Task<DeleteVoiceConnectorOriginationResponse> DeleteVoiceConnectorOriginationAsync(DeleteVoiceConnectorOriginationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteVoiceConnectorProxy



        /// <summary>
        /// Deletes the proxy configuration from the specified Amazon Chime Voice Connector.
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_voice-chime_DeleteVoiceConnectorProxy.html">DeleteVoiceProxy</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
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
        /// The client is permanently forbidden from making the request.
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
        [Obsolete("Replaced by DeleteVoiceConnectorProxy in the Amazon Chime SDK Voice Namespace")]
        Task<DeleteVoiceConnectorProxyResponse> DeleteVoiceConnectorProxyAsync(DeleteVoiceConnectorProxyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteVoiceConnectorStreamingConfiguration



        /// <summary>
        /// Deletes the streaming configuration for the specified Amazon Chime Voice Connector.
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_voice-chime_DeleteVoiceConnectorStreamingConfiguration.html">DeleteVoiceConnectorStreamingConfiguration</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
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
        /// The client is permanently forbidden from making the request.
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
        [Obsolete("Replaced by DeleteVoiceConnectorStreamingConfiguration in the Amazon Chime SDK Voice Namespace")]
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
        ///  </note> <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_voice-chime_DeleteVoiceConnectorTermination.html">DeleteVoiceConnectorTermination</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
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
        /// The client is permanently forbidden from making the request.
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
        [Obsolete("Replaced by DeleteVoiceConnectorTermination in the Amazon Chime SDK Voice Namespace")]
        Task<DeleteVoiceConnectorTerminationResponse> DeleteVoiceConnectorTerminationAsync(DeleteVoiceConnectorTerminationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteVoiceConnectorTerminationCredentials



        /// <summary>
        /// Deletes the specified SIP credentials used by your equipment to authenticate during
        /// call termination.
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_voice-chime_DeleteVoiceConnectorTerminationCredentials.html">DeleteVoiceConnectorTerminationCredentials</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
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
        /// The client is permanently forbidden from making the request.
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
        [Obsolete("Replaced by DeleteVoiceConnectorTerminationCredentials in the Amazon Chime SDK Voice Namespace")]
        Task<DeleteVoiceConnectorTerminationCredentialsResponse> DeleteVoiceConnectorTerminationCredentialsAsync(DeleteVoiceConnectorTerminationCredentialsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeAppInstance



        /// <summary>
        /// Returns the full details of an <code>AppInstance</code>.
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_identity-chime_DescribeAppInstance.html">DescribeAppInstance</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAppInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAppInstance service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DescribeAppInstance">REST API Reference for DescribeAppInstance Operation</seealso>
        [Obsolete("Replaced by DescribeAppInstance in the Amazon Chime SDK Identity Namespace")]
        Task<DescribeAppInstanceResponse> DescribeAppInstanceAsync(DescribeAppInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeAppInstanceAdmin



        /// <summary>
        /// Returns the full details of an <code>AppInstanceAdmin</code>.
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_identity-chime_DescribeAppInstanceAdmin.html">DescribeAppInstanceAdmin</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAppInstanceAdmin service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAppInstanceAdmin service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DescribeAppInstanceAdmin">REST API Reference for DescribeAppInstanceAdmin Operation</seealso>
        [Obsolete("Replaced by DescribeAppInstanceAdmin in the Amazon Chime SDK Identity Namespace")]
        Task<DescribeAppInstanceAdminResponse> DescribeAppInstanceAdminAsync(DescribeAppInstanceAdminRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeAppInstanceUser



        /// <summary>
        /// Returns the full details of an <code>AppInstanceUser</code>.
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_identity-chime_DescribeAppInstanceUser.html">DescribeAppInstanceUser</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAppInstanceUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAppInstanceUser service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DescribeAppInstanceUser">REST API Reference for DescribeAppInstanceUser Operation</seealso>
        [Obsolete("Replaced by DescribeAppInstanceUser in the Amazon Chime SDK Identity Namespace")]
        Task<DescribeAppInstanceUserResponse> DescribeAppInstanceUserAsync(DescribeAppInstanceUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeChannel



        /// <summary>
        /// Returns the full details of a channel in an Amazon Chime <code>AppInstance</code>.
        /// 
        ///  <note> 
        /// <para>
        /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  </note> <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_messaging-chime_DescribeChannel.html">DescribeChannel</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeChannel service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DescribeChannel">REST API Reference for DescribeChannel Operation</seealso>
        [Obsolete("Replaced by DescribeChannel in the Amazon Chime SDK Messaging Namespace")]
        Task<DescribeChannelResponse> DescribeChannelAsync(DescribeChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeChannelBan



        /// <summary>
        /// Returns the full details of a channel ban.
        /// 
        ///  <note> 
        /// <para>
        /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  </note> <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_messaging-chime_DescribeChannelBan.html">DescribeChannelBan</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeChannelBan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeChannelBan service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DescribeChannelBan">REST API Reference for DescribeChannelBan Operation</seealso>
        [Obsolete("Replaced by DescribeChannelBan in the Amazon Chime SDK Messaging Namespace")]
        Task<DescribeChannelBanResponse> DescribeChannelBanAsync(DescribeChannelBanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeChannelMembership



        /// <summary>
        /// Returns the full details of a user's channel membership.
        /// 
        ///  <note> 
        /// <para>
        /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  </note> <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_messaging-chime_DescribeChannelMembership.html">DescribeChannelMembership</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeChannelMembership service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeChannelMembership service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DescribeChannelMembership">REST API Reference for DescribeChannelMembership Operation</seealso>
        [Obsolete("Replaced by DescribeChannelMembership in the Amazon Chime SDK Messaging Namespace")]
        Task<DescribeChannelMembershipResponse> DescribeChannelMembershipAsync(DescribeChannelMembershipRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeChannelMembershipForAppInstanceUser



        /// <summary>
        /// Returns the details of a channel based on the membership of the specified <code>AppInstanceUser</code>.
        /// 
        ///  <note> 
        /// <para>
        /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  </note> <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_messaging-chime_DescribeChannelMembershipForAppInstanceUser.html">DescribeChannelMembershipForAppInstanceUser</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeChannelMembershipForAppInstanceUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeChannelMembershipForAppInstanceUser service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DescribeChannelMembershipForAppInstanceUser">REST API Reference for DescribeChannelMembershipForAppInstanceUser Operation</seealso>
        [Obsolete("Replaced by DescribeChannelMembershipForAppInstanceUser in the Amazon Chime SDK Messaging Namespace")]
        Task<DescribeChannelMembershipForAppInstanceUserResponse> DescribeChannelMembershipForAppInstanceUserAsync(DescribeChannelMembershipForAppInstanceUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeChannelModeratedByAppInstanceUser



        /// <summary>
        /// Returns the full details of a channel moderated by the specified <code>AppInstanceUser</code>.
        /// 
        ///  <note> 
        /// <para>
        /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  </note> <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_messaging-chime_DescribeChannelModeratedByAppInstanceUser.html">DescribeChannelModeratedByAppInstanceUser</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeChannelModeratedByAppInstanceUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeChannelModeratedByAppInstanceUser service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DescribeChannelModeratedByAppInstanceUser">REST API Reference for DescribeChannelModeratedByAppInstanceUser Operation</seealso>
        [Obsolete("Replaced by DescribeChannelModeratedByAppInstanceUser in the Amazon Chime SDK Messaging Namespace")]
        Task<DescribeChannelModeratedByAppInstanceUserResponse> DescribeChannelModeratedByAppInstanceUserAsync(DescribeChannelModeratedByAppInstanceUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeChannelModerator



        /// <summary>
        /// Returns the full details of a single ChannelModerator.
        /// 
        ///  <note> 
        /// <para>
        /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  </note> <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_messaging-chime_DescribeChannelModerator.html">DescribeChannelModerator</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeChannelModerator service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeChannelModerator service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DescribeChannelModerator">REST API Reference for DescribeChannelModerator Operation</seealso>
        [Obsolete("Replaced by DescribeChannelModerator in the Amazon Chime SDK Messaging Namespace")]
        Task<DescribeChannelModeratorResponse> DescribeChannelModeratorAsync(DescribeChannelModeratorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// The client is permanently forbidden from making the request.
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
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_voice-chime_DisassociatePhoneNumbersFromVoiceConnector.html">DisassociatePhoneNumbersFromVoiceConnector</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
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
        /// The client is permanently forbidden from making the request.
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
        [Obsolete("Replaced by DisassociatePhoneNumbersFromVoiceConnector in the Amazon Chime SDK Voice Namespace")]
        Task<DisassociatePhoneNumbersFromVoiceConnectorResponse> DisassociatePhoneNumbersFromVoiceConnectorAsync(DisassociatePhoneNumbersFromVoiceConnectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisassociatePhoneNumbersFromVoiceConnectorGroup



        /// <summary>
        /// Disassociates the specified phone numbers from the specified Amazon Chime Voice Connector
        /// group.
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_voice-chime_DisassociatePhoneNumbersFromVoiceConnectorGroup.html">DisassociatePhoneNumbersFromVoiceConnectorGroup</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
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
        /// The client is permanently forbidden from making the request.
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
        [Obsolete("Replaced by DisassociatePhoneNumbersFromVoiceConnectorGroup in the Amazon Chime SDK Voice Namespace")]
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
        /// The client is permanently forbidden from making the request.
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
        /// The client is permanently forbidden from making the request.
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
        /// control and dialout settings. For more information about these settings, see <a href="https://docs.aws.amazon.com/chime/latest/ag/policies.html">Use
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
        /// The client is permanently forbidden from making the request.
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
                
        #region  GetAppInstanceRetentionSettings



        /// <summary>
        /// Gets the retention settings for an <code>AppInstance</code>.
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_identity-chime_GetAppInstanceRetentionSettings.html">GetMessagingRetentionSettings</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAppInstanceRetentionSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAppInstanceRetentionSettings service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetAppInstanceRetentionSettings">REST API Reference for GetAppInstanceRetentionSettings Operation</seealso>
        [Obsolete("Replaced by GetAppInstanceRetentionSettings in the Amazon Chime SDK Identity Namespace")]
        Task<GetAppInstanceRetentionSettingsResponse> GetAppInstanceRetentionSettingsAsync(GetAppInstanceRetentionSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetAppInstanceStreamingConfigurations



        /// <summary>
        /// Gets the streaming settings for an <code>AppInstance</code>.
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_messaging-chime_GetMessagingStreamingConfigurations.html">GetMessagingStreamingConfigurations</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAppInstanceStreamingConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAppInstanceStreamingConfigurations service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetAppInstanceStreamingConfigurations">REST API Reference for GetAppInstanceStreamingConfigurations Operation</seealso>
        [Obsolete("Replaced by GetAppInstanceStreamingConfigurations in the Amazon Chime SDK Messaging Namespace")]
        Task<GetAppInstanceStreamingConfigurationsResponse> GetAppInstanceStreamingConfigurationsAsync(GetAppInstanceStreamingConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetAttendee



        /// <summary>
        /// Gets the Amazon Chime SDK attendee details for a specified meeting ID and attendee
        /// ID. For more information about the Amazon Chime SDK, see <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/meetings-sdk.html">Using
        /// the Amazon Chime SDK</a> in the <i>Amazon Chime SDK Developer Guide</i>. 
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_meeting-chime_GetAttendee.html">GetAttendee</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
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
        /// The client is permanently forbidden from making the request.
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
        [Obsolete("Replaced by GetAttendee in the Amazon Chime SDK Meetings Namespace")]
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
        /// The client is permanently forbidden from making the request.
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
                
        #region  GetChannelMessage



        /// <summary>
        /// Gets the full details of a channel message.
        /// 
        ///  <note> 
        /// <para>
        /// The x-amz-chime-bearer request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  </note> <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_messaging-chime_GetChannelMessage.html">GetChannelMessage</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChannelMessage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetChannelMessage service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetChannelMessage">REST API Reference for GetChannelMessage Operation</seealso>
        [Obsolete("Replaced by GetChannelMessage in the Amazon Chime SDK Messaging Namespace")]
        Task<GetChannelMessageResponse> GetChannelMessageAsync(GetChannelMessageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// The client is permanently forbidden from making the request.
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
        /// The client is permanently forbidden from making the request.
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
                
        #region  GetMediaCapturePipeline



        /// <summary>
        /// Gets an existing media capture pipeline.
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_media-pipelines-chime_GetMediaCapturePipeline.html">GetMediaCapturePipeline</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMediaCapturePipeline service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMediaCapturePipeline service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetMediaCapturePipeline">REST API Reference for GetMediaCapturePipeline Operation</seealso>
        [Obsolete("Replaced by GetMediaCapturePipeline in the Amazon Chime SDK Media Pipelines Namespace")]
        Task<GetMediaCapturePipelineResponse> GetMediaCapturePipelineAsync(GetMediaCapturePipelineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetMeeting



        /// <summary>
        /// <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_meeting-chime_GetMeeting.html">GetMeeting</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important> 
        /// <para>
        ///  Gets the Amazon Chime SDK meeting details for the specified meeting ID. For more
        /// information about the Amazon Chime SDK, see <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/meetings-sdk.html">Using
        /// the Amazon Chime SDK</a> in the <i>Amazon Chime SDK Developer Guide</i> . 
        /// </para>
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
        /// The client is permanently forbidden from making the request.
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
        [Obsolete("Replaced by GetMeeting in the Amazon Chime SDK Meetings Namespace")]
        Task<GetMeetingResponse> GetMeetingAsync(GetMeetingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetMessagingSessionEndpoint



        /// <summary>
        /// The details of the endpoint for the messaging session.
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_messaging-chime_GetMessagingSessionEndpoint.html">GetMessagingSessionEndpoint</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMessagingSessionEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMessagingSessionEndpoint service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetMessagingSessionEndpoint">REST API Reference for GetMessagingSessionEndpoint Operation</seealso>
        [Obsolete("Replaced by GetMessagingSessionEndpoint in the Amazon Chime SDK Messaging Namespace")]
        Task<GetMessagingSessionEndpointResponse> GetMessagingSessionEndpointAsync(GetMessagingSessionEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// The client is permanently forbidden from making the request.
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
        /// Retrieves details for the specified phone number order, such as the order creation
        /// timestamp, phone numbers in E.164 format, product type, and order status.
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
        /// The client is permanently forbidden from making the request.
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
        /// The client is permanently forbidden from making the request.
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
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_voice-chime_GetProxySession.html">GetProxySession</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
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
        /// The client is permanently forbidden from making the request.
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
        [Obsolete("Replaced by GetProxySession in the Amazon Chime SDK Voice Namespace")]
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
        /// The client is permanently forbidden from making the request.
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
        /// The client is permanently forbidden from making the request.
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
                
        #region  GetSipMediaApplication



        /// <summary>
        /// Retrieves the information for a SIP media application, including name, AWS Region,
        /// and endpoints.
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_voice-chime_GetSipMediaApplication.html">GetSipMediaApplication</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSipMediaApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSipMediaApplication service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetSipMediaApplication">REST API Reference for GetSipMediaApplication Operation</seealso>
        [Obsolete("Replaced by GetSipMediaApplication in the Amazon Chime SDK Voice Namespace")]
        Task<GetSipMediaApplicationResponse> GetSipMediaApplicationAsync(GetSipMediaApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSipMediaApplicationLoggingConfiguration



        /// <summary>
        /// Returns the logging configuration for the specified SIP media application.
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_voice-chime_GetSipMediaApplicationLoggingConfiguration.html">GetSipMediaApplicationLoggingConfiguration</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSipMediaApplicationLoggingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSipMediaApplicationLoggingConfiguration service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetSipMediaApplicationLoggingConfiguration">REST API Reference for GetSipMediaApplicationLoggingConfiguration Operation</seealso>
        [Obsolete("Replaced by GetSipMediaApplicationLoggingConfiguration in the Amazon Chime SDK Voice Namespace")]
        Task<GetSipMediaApplicationLoggingConfigurationResponse> GetSipMediaApplicationLoggingConfigurationAsync(GetSipMediaApplicationLoggingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSipRule



        /// <summary>
        /// Retrieves the details of a SIP rule, such as the rule ID, name, triggers, and target
        /// endpoints.
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_voice-chime_GetSipRule.html">GetSipRule</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSipRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSipRule service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetSipRule">REST API Reference for GetSipRule Operation</seealso>
        [Obsolete("Replaced by GetSipRule in the Amazon Chime SDK Voice Namespace")]
        Task<GetSipRuleResponse> GetSipRuleAsync(GetSipRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetUser



        /// <summary>
        /// Retrieves details for the specified user ID, such as primary email address, license
        /// type,and personal meeting PIN.
        /// 
        ///  
        /// <para>
        ///  To retrieve user details with an email address instead of a user ID, use the <a>ListUsers</a>
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
        /// The client is permanently forbidden from making the request.
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
        /// The client is permanently forbidden from making the request.
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
        /// Retrieves details for the specified Amazon Chime Voice Connector, such as timestamps,name,
        /// outbound host, and encryption requirements.
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_voice-chime_GetVoiceConnector.html">GetVoiceConnector</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
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
        /// The client is permanently forbidden from making the request.
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
        [Obsolete("Replaced by GetVoiceConnector in the Amazon Chime SDK Voice Namespace")]
        Task<GetVoiceConnectorResponse> GetVoiceConnectorAsync(GetVoiceConnectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetVoiceConnectorEmergencyCallingConfiguration



        /// <summary>
        /// Gets the emergency calling configuration details for the specified Amazon Chime Voice
        /// Connector.
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_voice-chime_GetVoiceConnectorEmergencyCallingConfiguration.html">GetVoiceConnectorEmergencyCallingConfiguration</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
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
        /// The client is permanently forbidden from making the request.
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
        [Obsolete("Replaced by GetVoiceConnectorEmergencyCallingConfiguration in the Amazon Chime SDK Voice Namespace")]
        Task<GetVoiceConnectorEmergencyCallingConfigurationResponse> GetVoiceConnectorEmergencyCallingConfigurationAsync(GetVoiceConnectorEmergencyCallingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetVoiceConnectorGroup



        /// <summary>
        /// Retrieves details for the specified Amazon Chime Voice Connector group, such as timestamps,name,
        /// and associated <code>VoiceConnectorItems</code>.
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_voice-chime_GetVoiceConnectorGroup.html">GetVoiceConnectorGroup</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
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
        /// The client is permanently forbidden from making the request.
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
        [Obsolete("Replaced by GetVoiceConnectorGroup in the Amazon Chime SDK Voice Namespace")]
        Task<GetVoiceConnectorGroupResponse> GetVoiceConnectorGroupAsync(GetVoiceConnectorGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetVoiceConnectorLoggingConfiguration



        /// <summary>
        /// Retrieves the logging configuration details for the specified Amazon Chime Voice Connector.
        /// Shows whether SIP message logs are enabled for sending to Amazon CloudWatch Logs.
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_voice-chime_GetVoiceConnectorLoggingConfiguration.html">GetVoiceConnectorLoggingConfiguration</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
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
        /// The client is permanently forbidden from making the request.
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
        [Obsolete("Replaced by GetVoiceConnectorLoggingConfiguration in the Amazon Chime SDK Voice Namespace")]
        Task<GetVoiceConnectorLoggingConfigurationResponse> GetVoiceConnectorLoggingConfigurationAsync(GetVoiceConnectorLoggingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetVoiceConnectorOrigination



        /// <summary>
        /// Retrieves origination setting details for the specified Amazon Chime Voice Connector.
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_voice-chime_GetVoiceConnectorOrigination.html">GetVoiceConnectorOrigination</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
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
        /// The client is permanently forbidden from making the request.
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
        [Obsolete("Replaced by GetVoiceConnectorOrigination in the Amazon Chime SDK Voice Namespace")]
        Task<GetVoiceConnectorOriginationResponse> GetVoiceConnectorOriginationAsync(GetVoiceConnectorOriginationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetVoiceConnectorProxy



        /// <summary>
        /// Gets the proxy configuration details for the specified Amazon Chime Voice Connector.
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_voice-chime_GetVoiceConnectorProxy.html">GetVoiceConnectorProxy</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
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
        /// The client is permanently forbidden from making the request.
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
        [Obsolete("Replaced by GetVoiceConnectorProxy in the Amazon Chime SDK Voice Namespace")]
        Task<GetVoiceConnectorProxyResponse> GetVoiceConnectorProxyAsync(GetVoiceConnectorProxyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetVoiceConnectorStreamingConfiguration



        /// <summary>
        /// Retrieves the streaming configuration details for the specified Amazon Chime Voice
        /// Connector. Shows whether media streaming is enabled for sending to Amazon Kinesis.
        /// It also shows the retention period, in hours, for the Amazon Kinesis data.
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_voice-chime_GetVoiceConnectorStreamingConfiguration.html">GetVoiceConnectorStreamingConfiguration</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
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
        /// The client is permanently forbidden from making the request.
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
        [Obsolete("Replaced by GetVoiceConnectorStreamingConfiguration in the Amazon Chime SDK Voice Namespace")]
        Task<GetVoiceConnectorStreamingConfigurationResponse> GetVoiceConnectorStreamingConfigurationAsync(GetVoiceConnectorStreamingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetVoiceConnectorTermination



        /// <summary>
        /// Retrieves termination setting details for the specified Amazon Chime Voice Connector.
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_voice-chime_GetVoiceConnectorTermination.html">GetVoiceConnectorTermination</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
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
        /// The client is permanently forbidden from making the request.
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
        [Obsolete("Replaced by GetVoiceConnectorTermination in the Amazon Chime SDK Voice Namespace")]
        Task<GetVoiceConnectorTerminationResponse> GetVoiceConnectorTerminationAsync(GetVoiceConnectorTerminationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetVoiceConnectorTerminationHealth



        /// <summary>
        /// <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_voice-chime_GetVoiceConnectorTerminationHealth.html">GetVoiceConnectorTerminationHealth</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important> 
        /// <para>
        /// Retrieves information about the last time a SIP <code>OPTIONS</code> ping was received
        /// from your SIP infrastructure for the specified Amazon Chime Voice Connector.
        /// </para>
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
        /// The client is permanently forbidden from making the request.
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
        [Obsolete("Replaced by GetVoiceConnectorTerminationHealth in the Amazon Chime SDK Voice Namespace")]
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
        /// The client is permanently forbidden from making the request.
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
        /// The client is permanently forbidden from making the request.
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
                
        #region  ListAppInstanceAdmins



        /// <summary>
        /// Returns a list of the administrators in the <code>AppInstance</code>.
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_identity-chime_ListAppInstanceAdmins.html">ListAppInstanceAdmins</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAppInstanceAdmins service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAppInstanceAdmins service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListAppInstanceAdmins">REST API Reference for ListAppInstanceAdmins Operation</seealso>
        [Obsolete("Replaced by ListAppInstanceAdmins in the Amazon Chime SDK Identity Namespace")]
        Task<ListAppInstanceAdminsResponse> ListAppInstanceAdminsAsync(ListAppInstanceAdminsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAppInstances



        /// <summary>
        /// Lists all Amazon Chime <code>AppInstance</code>s created under a single AWS account.
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_identity-chime_ListAppInstances.html">ListAppInstances</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAppInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAppInstances service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListAppInstances">REST API Reference for ListAppInstances Operation</seealso>
        [Obsolete("Replaced by ListAppInstances in the Amazon Chime SDK Identity Namespace")]
        Task<ListAppInstancesResponse> ListAppInstancesAsync(ListAppInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAppInstanceUsers



        /// <summary>
        /// List all <code>AppInstanceUsers</code> created under a single <code>AppInstance</code>.
        /// 
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_identity-chime_ListAppInstanceUsers.html">ListAppInstanceUsers</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAppInstanceUsers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAppInstanceUsers service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListAppInstanceUsers">REST API Reference for ListAppInstanceUsers Operation</seealso>
        [Obsolete("Replaced by ListAppInstanceUsers in the Amazon Chime SDK Identity Namespace")]
        Task<ListAppInstanceUsersResponse> ListAppInstanceUsersAsync(ListAppInstanceUsersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAttendees



        /// <summary>
        /// Lists the attendees for the specified Amazon Chime SDK meeting. For more information
        /// about the Amazon Chime SDK, see <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/meetings-sdk.html">Using
        /// the Amazon Chime SDK</a> in the <i>Amazon Chime SDK Developer Guide</i>. 
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_meeting-chime_ListAttendees.html">ListAttendees</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
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
        /// The client is permanently forbidden from making the request.
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
        [Obsolete("Replaced by ListAttendees in the Amazon Chime SDK Meetings Namespace")]
        Task<ListAttendeesResponse> ListAttendeesAsync(ListAttendeesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAttendeeTags



        /// <summary>
        /// Lists the tags applied to an Amazon Chime SDK attendee resource.
        /// 
        ///  <important> 
        /// <para>
        /// ListAttendeeTags is not supported in the Amazon Chime SDK Meetings Namespace. Update
        /// your application to remove calls to this API.
        /// </para>
        ///  </important>
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
        /// The client is permanently forbidden from making the request.
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
        [Obsolete("Attendee Tags are not supported in the Amazon Chime SDK Meetings Namespace. Update your application to remove calls to this API.")]
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
        /// The client is permanently forbidden from making the request.
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
                
        #region  ListChannelBans



        /// <summary>
        /// Lists all the users banned from a particular channel.
        /// 
        ///  <note> 
        /// <para>
        /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  </note> <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_messaging-chime_ListChannelBans.html">ListChannelBans</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChannelBans service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListChannelBans service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListChannelBans">REST API Reference for ListChannelBans Operation</seealso>
        [Obsolete("Replaced by ListChannelBans in the Amazon Chime SDK Messaging Namespace")]
        Task<ListChannelBansResponse> ListChannelBansAsync(ListChannelBansRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListChannelMemberships



        /// <summary>
        /// Lists all channel memberships in a channel.
        /// 
        ///  <note> 
        /// <para>
        /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  </note> <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_messaging-chime_ListChannelMemberships.html">ListChannelMemberships</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChannelMemberships service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListChannelMemberships service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListChannelMemberships">REST API Reference for ListChannelMemberships Operation</seealso>
        [Obsolete("Replaced by ListChannelMemberships in the Amazon Chime SDK Messaging Namespace")]
        Task<ListChannelMembershipsResponse> ListChannelMembershipsAsync(ListChannelMembershipsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListChannelMembershipsForAppInstanceUser



        /// <summary>
        /// Lists all channels that a particular <code>AppInstanceUser</code> is a part of. Only
        /// an <code>AppInstanceAdmin</code> can call the API with a user ARN that is not their
        /// own. 
        /// 
        ///  <note> 
        /// <para>
        /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  </note> <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_messaging-chime_ListChannelMembershipsForAppInstanceUser.html">ListChannelMembershipsForAppInstanceUser</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChannelMembershipsForAppInstanceUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListChannelMembershipsForAppInstanceUser service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListChannelMembershipsForAppInstanceUser">REST API Reference for ListChannelMembershipsForAppInstanceUser Operation</seealso>
        [Obsolete("Replaced by ListChannelMembershipsForAppInstanceUser in the Amazon Chime SDK Messaging Namespace")]
        Task<ListChannelMembershipsForAppInstanceUserResponse> ListChannelMembershipsForAppInstanceUserAsync(ListChannelMembershipsForAppInstanceUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListChannelMessages



        /// <summary>
        /// List all the messages in a channel. Returns a paginated list of <code>ChannelMessages</code>.
        /// By default, sorted by creation timestamp in descending order.
        /// 
        ///  <note> 
        /// <para>
        /// Redacted messages appear in the results as empty, since they are only redacted, not
        /// deleted. Deleted messages do not appear in the results. This action always returns
        /// the latest version of an edited message.
        /// </para>
        ///  
        /// <para>
        /// Also, the x-amz-chime-bearer request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  </note> <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_messaging-chime_ListChannelMessages.html">ListChannelMessages</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChannelMessages service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListChannelMessages service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListChannelMessages">REST API Reference for ListChannelMessages Operation</seealso>
        [Obsolete("Replaced by ListChannelMessages in the Amazon Chime SDK Messaging Namespace")]
        Task<ListChannelMessagesResponse> ListChannelMessagesAsync(ListChannelMessagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListChannelModerators



        /// <summary>
        /// Lists all the moderators for a channel.
        /// 
        ///  <note> 
        /// <para>
        /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  </note> <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_messaging-chime_ListChannelModerators.html">ListChannelModerators</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChannelModerators service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListChannelModerators service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListChannelModerators">REST API Reference for ListChannelModerators Operation</seealso>
        [Obsolete("Replaced by ListChannelModerators in the Amazon Chime SDK Messaging Namespace")]
        Task<ListChannelModeratorsResponse> ListChannelModeratorsAsync(ListChannelModeratorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListChannels



        /// <summary>
        /// Lists all Channels created under a single Chime App as a paginated list. You can specify
        /// filters to narrow results.
        /// 
        ///  <p class="title"> <b>Functionality &amp; restrictions</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use privacy = <code>PUBLIC</code> to retrieve all public channels in the account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Only an <code>AppInstanceAdmin</code> can set privacy = <code>PRIVATE</code> to list
        /// the private channels in an account.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  </note> <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_messaging-chime_ListChannels.html">ListChannels</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChannels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListChannels service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListChannels">REST API Reference for ListChannels Operation</seealso>
        [Obsolete("Replaced by ListChannels in the Amazon Chime SDK Messaging Namespace")]
        Task<ListChannelsResponse> ListChannelsAsync(ListChannelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListChannelsModeratedByAppInstanceUser



        /// <summary>
        /// A list of the channels moderated by an <code>AppInstanceUser</code>.
        /// 
        ///  <note> 
        /// <para>
        /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  </note> <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_messaging-chime_ListChannelsModeratedByAppInstanceUser.html">ListChannelsModeratedByAppInstanceUser</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChannelsModeratedByAppInstanceUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListChannelsModeratedByAppInstanceUser service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListChannelsModeratedByAppInstanceUser">REST API Reference for ListChannelsModeratedByAppInstanceUser Operation</seealso>
        [Obsolete("Replaced by ListChannelsModeratedByAppInstanceUser in the Amazon Chime SDK Messaging Namespace")]
        Task<ListChannelsModeratedByAppInstanceUserResponse> ListChannelsModeratedByAppInstanceUserAsync(ListChannelsModeratedByAppInstanceUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListMediaCapturePipelines



        /// <summary>
        /// Returns a list of media capture pipelines.
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_media-pipelines-chime_ListMediaCapturePipelines.html">ListMediaCapturePipelines</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMediaCapturePipelines service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMediaCapturePipelines service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListMediaCapturePipelines">REST API Reference for ListMediaCapturePipelines Operation</seealso>
        [Obsolete("Replaced by ListMediaCapturePipelines in the Amazon Chime SDK Media Pipelines Namespace")]
        Task<ListMediaCapturePipelinesResponse> ListMediaCapturePipelinesAsync(ListMediaCapturePipelinesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListMeetings



        /// <summary>
        /// Lists up to 100 active Amazon Chime SDK meetings.
        /// 
        ///  <important> 
        /// <para>
        /// ListMeetings is not supported in the Amazon Chime SDK Meetings Namespace. Update your
        /// application to remove calls to this API.
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information about the Amazon Chime SDK, see <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/meetings-sdk.html">Using
        /// the Amazon Chime SDK</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
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
        /// The client is permanently forbidden from making the request.
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
        [Obsolete("ListMeetings is not supported in the Amazon Chime SDK Meetings Namespace. Update your application to remove calls to this API.")]
        Task<ListMeetingsResponse> ListMeetingsAsync(ListMeetingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListMeetingTags



        /// <summary>
        /// Lists the tags applied to an Amazon Chime SDK meeting resource.
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_meeting-chime_ListTagsForResource.html">ListTagsForResource</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
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
        /// The client is permanently forbidden from making the request.
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
        [Obsolete("Use ListTagsForResource in the Amazon Chime SDK Meetings Namespace.")]
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
        /// The client is permanently forbidden from making the request.
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
        /// The client is permanently forbidden from making the request.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListPhoneNumbers">REST API Reference for ListPhoneNumbers Operation</seealso>
        Task<ListPhoneNumbersResponse> ListPhoneNumbersAsync(ListPhoneNumbersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListProxySessions



        /// <summary>
        /// Lists the proxy sessions for the specified Amazon Chime Voice Connector.
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_voice-chime_ListProxySessions.html">ListProxySessions</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
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
        /// The client is permanently forbidden from making the request.
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
        [Obsolete("Replaced by ListProxySessions in the Amazon Chime SDK Voice Namespace")]
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
        /// The client is permanently forbidden from making the request.
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
        /// The client is permanently forbidden from making the request.
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
                
        #region  ListSipMediaApplications



        /// <summary>
        /// Lists the SIP media applications under the administrator's AWS account.
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_voice-chime_ListSipMediaApplications.html">ListSipMediaApplications</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSipMediaApplications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSipMediaApplications service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListSipMediaApplications">REST API Reference for ListSipMediaApplications Operation</seealso>
        [Obsolete("Replaced by ListSipMediaApplications in the Amazon Chime SDK Voice Namespace")]
        Task<ListSipMediaApplicationsResponse> ListSipMediaApplicationsAsync(ListSipMediaApplicationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListSipRules



        /// <summary>
        /// Lists the SIP rules under the administrator's AWS account.
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_voice-chime_ListSipRules.html">ListSipRules</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSipRules service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSipRules service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListSipRules">REST API Reference for ListSipRules Operation</seealso>
        [Obsolete("Replaced by ListSipRules in the Amazon Chime SDK Voice Namespace")]
        Task<ListSipRulesResponse> ListSipRulesAsync(ListSipRulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListSupportedPhoneNumberCountries



        /// <summary>
        /// Lists supported phone number countries.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSupportedPhoneNumberCountries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSupportedPhoneNumberCountries service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListSupportedPhoneNumberCountries">REST API Reference for ListSupportedPhoneNumberCountries Operation</seealso>
        Task<ListSupportedPhoneNumberCountriesResponse> ListSupportedPhoneNumberCountriesAsync(ListSupportedPhoneNumberCountriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Lists the tags applied to an Amazon Chime SDK meeting and messaging resources.
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the applicable latest version in the Amazon Chime SDK.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For meetings: <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_meeting-chime_ListTagsForResource.html">ListTagsForResource</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For messaging: <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_messaging-chime_ListTagsForResource.html">ListTagsForResource</a>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
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
        /// The client is permanently forbidden from making the request.
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
        [Obsolete("Replaced by ListTagsForResource in the Amazon Chime SDK Voice, Amazon Chime SDK Meetings, Amazon Chime SDK Identity, Amazon Chime SDK Messaging, and Amazon Chime SDK Media Pipelines Namespaces")]
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
        /// The client is permanently forbidden from making the request.
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
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_voice-chime_ListVoiceConnectorGroups.html">ListVoiceConnectorGroups</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
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
        /// The client is permanently forbidden from making the request.
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
        [Obsolete("Replaced by ListVoiceConnectorGroups in the Amazon Chime SDK Voice Namespace")]
        Task<ListVoiceConnectorGroupsResponse> ListVoiceConnectorGroupsAsync(ListVoiceConnectorGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListVoiceConnectors



        /// <summary>
        /// Lists the Amazon Chime Voice Connectors for the administrator's AWS account.
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_voice-chime_ListVoiceConnectors.html">ListVoiceConnectors</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
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
        /// The client is permanently forbidden from making the request.
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
        [Obsolete("Replaced by ListVoiceConnectors in the Amazon Chime SDK Voice Namespace")]
        Task<ListVoiceConnectorsResponse> ListVoiceConnectorsAsync(ListVoiceConnectorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListVoiceConnectorTerminationCredentials



        /// <summary>
        /// Lists the SIP credentials for the specified Amazon Chime Voice Connector.
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_voice-chime_ListVoiceConnectorTerminationCredentials.html">ListVoiceConnectorTerminationCredentials</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
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
        /// The client is permanently forbidden from making the request.
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
        [Obsolete("Replaced by ListVoiceConnectorTerminationCredentials in the Amazon Chime SDK Voice Namespace")]
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
        /// The client is permanently forbidden from making the request.
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
                
        #region  PutAppInstanceRetentionSettings



        /// <summary>
        /// Sets the amount of time in days that a given <code>AppInstance</code> retains data.
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_identity-chime_PutAppInstanceRetentionSettings.html">PutAppInstanceRetentionSettings</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAppInstanceRetentionSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutAppInstanceRetentionSettings service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/PutAppInstanceRetentionSettings">REST API Reference for PutAppInstanceRetentionSettings Operation</seealso>
        [Obsolete("Replaced by PutAppInstanceRetentionSettings in the Amazon Chime SDK Identity Namespace")]
        Task<PutAppInstanceRetentionSettingsResponse> PutAppInstanceRetentionSettingsAsync(PutAppInstanceRetentionSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutAppInstanceStreamingConfigurations



        /// <summary>
        /// The data streaming configurations of an <code>AppInstance</code>.
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_messaging-chime_PutMessagingStreamingConfigurations.html">PutMessagingStreamingConfigurations</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAppInstanceStreamingConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutAppInstanceStreamingConfigurations service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/PutAppInstanceStreamingConfigurations">REST API Reference for PutAppInstanceStreamingConfigurations Operation</seealso>
        [Obsolete("Replaced by PutAppInstanceStreamingConfigurations in the Amazon Chime SDK Messaging Namespace")]
        Task<PutAppInstanceStreamingConfigurationsResponse> PutAppInstanceStreamingConfigurationsAsync(PutAppInstanceStreamingConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// The client is permanently forbidden from making the request.
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
        ///  To turn off existing retention settings, remove the number of days from the corresponding
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
        /// The client is permanently forbidden from making the request.
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
                
        #region  PutSipMediaApplicationLoggingConfiguration



        /// <summary>
        /// Updates the logging configuration for the specified SIP media application.
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_voice-chime_PutSipMediaApplicationLoggingConfiguration.html">PutSipMediaApplicationLoggingConfiguration</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutSipMediaApplicationLoggingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutSipMediaApplicationLoggingConfiguration service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/PutSipMediaApplicationLoggingConfiguration">REST API Reference for PutSipMediaApplicationLoggingConfiguration Operation</seealso>
        [Obsolete("Replaced by PutSipMediaApplicationLoggingConfiguration in the Amazon Chime SDK Voice Namespace")]
        Task<PutSipMediaApplicationLoggingConfigurationResponse> PutSipMediaApplicationLoggingConfigurationAsync(PutSipMediaApplicationLoggingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutVoiceConnectorEmergencyCallingConfiguration



        /// <summary>
        /// Puts emergency calling configuration details to the specified Amazon Chime Voice Connector,
        /// such as emergency phone numbers and calling countries. Origination and termination
        /// settings must be enabled for the Amazon Chime Voice Connector before emergency calling
        /// can be configured.
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_voice-chime_PutVoiceConnectorEmergencyCallingConfiguration.html">PutVoiceConnectorEmergencyCallingConfiguration</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
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
        /// The client is permanently forbidden from making the request.
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
        [Obsolete("Replaced by PutVoiceConnectorEmergencyCallingConfiguration in the Amazon Chime SDK Voice Namespace")]
        Task<PutVoiceConnectorEmergencyCallingConfigurationResponse> PutVoiceConnectorEmergencyCallingConfigurationAsync(PutVoiceConnectorEmergencyCallingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutVoiceConnectorLoggingConfiguration



        /// <summary>
        /// Adds a logging configuration for the specified Amazon Chime Voice Connector. The logging
        /// configuration specifies whether SIP message logs are enabled for sending to Amazon
        /// CloudWatch Logs.
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_voice-chime_PutVoiceConnectorLoggingConfiguration.html">PutVoiceConnectorLoggingConfiguration</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
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
        /// The client is permanently forbidden from making the request.
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
        [Obsolete("Replaced by PutVoiceConnectorLoggingConfiguration in the Amazon Chime SDK Voice Namespace")]
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
        ///  </note> <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_voice-chime_PutVoiceConnectorOrigination.html">PutVoiceConnectorOrigination</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
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
        /// The client is permanently forbidden from making the request.
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
        [Obsolete("Replaced by PutVoiceConnectorOrigination in the Amazon Chime SDK Voice Namespace")]
        Task<PutVoiceConnectorOriginationResponse> PutVoiceConnectorOriginationAsync(PutVoiceConnectorOriginationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutVoiceConnectorProxy



        /// <summary>
        /// Puts the specified proxy configuration to the specified Amazon Chime Voice Connector.
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_voice-chime_PutVoiceConnectorProxy.html">PutVoiceConnectorProxy</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
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
        /// The client is permanently forbidden from making the request.
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
        [Obsolete("Replaced by PutVoiceConnectorProxy in the Amazon Chime SDK Voice Namespace")]
        Task<PutVoiceConnectorProxyResponse> PutVoiceConnectorProxyAsync(PutVoiceConnectorProxyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutVoiceConnectorStreamingConfiguration



        /// <summary>
        /// Adds a streaming configuration for the specified Amazon Chime Voice Connector. The
        /// streaming configuration specifies whether media streaming is enabled for sending to
        /// Kinesis. It also sets the retention period, in hours, for the Amazon Kinesis data.
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_voice-chime_PutVoiceConnectorStreamingConfiguration.html">PutVoiceConnectorStreamingConfiguration</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
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
        /// The client is permanently forbidden from making the request.
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
        [Obsolete("Replaced by PutVoiceConnectorStreamingConfiguration in the Amazon Chime SDK Voice Namespace")]
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
        ///  </note> <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_voice-chime_PutVoiceConnectorTermination.html">PutVoiceConnectorTermination</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
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
        /// The client is permanently forbidden from making the request.
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
        [Obsolete("Replaced by PutVoiceConnectorTermination in the Amazon Chime SDK Voice Namespace")]
        Task<PutVoiceConnectorTerminationResponse> PutVoiceConnectorTerminationAsync(PutVoiceConnectorTerminationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutVoiceConnectorTerminationCredentials



        /// <summary>
        /// Adds termination SIP credentials for the specified Amazon Chime Voice Connector.
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_voice-chime_PutVoiceConnectorTerminationCredentials.html">PutVoiceConnectorTerminationCredentials</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
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
        /// The client is permanently forbidden from making the request.
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
        [Obsolete("Replaced by PutVoiceConnectorTerminationCredentials in the Amazon Chime SDK Voice Namespace")]
        Task<PutVoiceConnectorTerminationCredentialsResponse> PutVoiceConnectorTerminationCredentialsAsync(PutVoiceConnectorTerminationCredentialsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RedactChannelMessage



        /// <summary>
        /// Redacts message content, but not metadata. The message exists in the back end, but
        /// the action returns null content, and the state shows as redacted.
        /// 
        ///  <note> 
        /// <para>
        /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  </note> <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_messaging-chime_RedactChannelMessage.html">RedactChannelMessage</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RedactChannelMessage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RedactChannelMessage service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/RedactChannelMessage">REST API Reference for RedactChannelMessage Operation</seealso>
        [Obsolete("Replaced by RedactChannelMessage in the Amazon Chime SDK Messaging Namespace")]
        Task<RedactChannelMessageResponse> RedactChannelMessageAsync(RedactChannelMessageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// The client is permanently forbidden from making the request.
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
        /// Redacts the specified message from the specified Amazon Chime channel.
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
        /// The client is permanently forbidden from making the request.
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
        /// The client is permanently forbidden from making the request.
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
        /// The client is permanently forbidden from making the request.
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
        /// The client is permanently forbidden from making the request.
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
        /// Searches for phone numbers that can be ordered. For US numbers, provide at least one
        /// of the following search filters: <code>AreaCode</code>, <code>City</code>, <code>State</code>,
        /// or <code>TollFreePrefix</code>. If you provide <code>City</code>, you must also provide
        /// <code>State</code>. Numbers outside the US only support the <code>PhoneNumberType</code>
        /// filter, which you must use.
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
        /// The client is permanently forbidden from making the request.
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
                
        #region  SendChannelMessage



        /// <summary>
        /// Sends a message to a particular channel that the member is a part of.
        /// 
        ///  <note> 
        /// <para>
        /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  
        /// <para>
        /// Also, <code>STANDARD</code> messages can contain 4KB of data and the 1KB of metadata.
        /// <code>CONTROL</code> messages can contain 30 bytes of data and no metadata.
        /// </para>
        ///  </note> <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_messaging-chime_SendChannelMessage.html">SendChannelMessage</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendChannelMessage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendChannelMessage service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/SendChannelMessage">REST API Reference for SendChannelMessage Operation</seealso>
        [Obsolete("Replaced by SendChannelMessage in the Amazon Chime SDK Messaging Namespace")]
        Task<SendChannelMessageResponse> SendChannelMessageAsync(SendChannelMessageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartMeetingTranscription



        /// <summary>
        /// Starts transcription for the specified <code>meetingId</code>. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/meeting-transcription.html">
        /// Using Amazon Chime SDK live transcription </a> in the <i>Amazon Chime SDK Developer
        /// Guide</i>.
        /// 
        ///  
        /// <para>
        /// If you specify an invalid configuration, a <code>TranscriptFailed</code> event will
        /// be sent with the contents of the <code>BadRequestException</code> generated by Amazon
        /// Transcribe. For more information on each parameter and which combinations are valid,
        /// refer to the <a href="https://docs.aws.amazon.com/transcribe/latest/APIReference/API_streaming_StartStreamTranscription.html">StartStreamTranscription</a>
        /// API in the <i>Amazon Transcribe Developer Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon Chime SDK live transcription is powered by Amazon Transcribe. Use of Amazon
        /// Transcribe is subject to the <a href="https://aws.amazon.com/service-terms/">AWS Service
        /// Terms</a>, including the terms specific to the AWS Machine Learning and Artificial
        /// Intelligence Services.
        /// </para>
        ///  </note> <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_meeting-chime_StartMeetingTranscription.html">StartMeetingTranscription</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMeetingTranscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartMeetingTranscription service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
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
        /// <exception cref="Amazon.Chime.Model.UnprocessableEntityException">
        /// The request was well-formed but was unable to be followed due to semantic errors.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/StartMeetingTranscription">REST API Reference for StartMeetingTranscription Operation</seealso>
        [Obsolete("Replaced by StartMeetingTranscription in the Amazon Chime SDK Meetings Namespace")]
        Task<StartMeetingTranscriptionResponse> StartMeetingTranscriptionAsync(StartMeetingTranscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopMeetingTranscription



        /// <summary>
        /// Stops transcription for the specified <code>meetingId</code>.
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_meeting-chime_StopMeetingTranscription.html">StopMeetingTranscription</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopMeetingTranscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopMeetingTranscription service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/StopMeetingTranscription">REST API Reference for StopMeetingTranscription Operation</seealso>
        [Obsolete("Replaced by StopMeetingTranscription in the Amazon Chime SDK Meetings Namespace")]
        Task<StopMeetingTranscriptionResponse> StopMeetingTranscriptionAsync(StopMeetingTranscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagAttendee



        /// <summary>
        /// Applies the specified tags to the specified Amazon Chime attendee.
        /// 
        ///  <important> 
        /// <para>
        /// TagAttendee is not supported in the Amazon Chime SDK Meetings Namespace. Update your
        /// application to remove calls to this API.
        /// </para>
        ///  </important>
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
        /// The client is permanently forbidden from making the request.
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
        [Obsolete("Attendee Tags are not supported in the Amazon Chime SDK Meetings Namespace. Update your application to remove calls to this API.")]
        Task<TagAttendeeResponse> TagAttendeeAsync(TagAttendeeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagMeeting



        /// <summary>
        /// Applies the specified tags to the specified Amazon Chime SDK meeting.
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_meeting-chime_TagResource.html">TagResource</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
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
        /// The client is permanently forbidden from making the request.
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
        [Obsolete("Use TagResource in the Amazon Chime SDK Meetings Namespace.")]
        Task<TagMeetingResponse> TagMeetingAsync(TagMeetingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Applies the specified tags to the specified Amazon Chime SDK meeting resource.
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_meeting-chime_TagResource.html">TagResource</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
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
        /// The client is permanently forbidden from making the request.
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
        [Obsolete("Replaced by TagResource in the Amazon Chime SDK Voice, Amazon Chime SDK Meetings, Amazon Chime SDK Identity, Amazon Chime SDK Messaging, and Amazon Chime SDK Media Pipelines Namespaces")]
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagAttendee



        /// <summary>
        /// Untags the specified tags from the specified Amazon Chime SDK attendee.
        /// 
        ///  <important> 
        /// <para>
        /// UntagAttendee is not supported in the Amazon Chime SDK Meetings Namespace. Update
        /// your application to remove calls to this API.
        /// </para>
        ///  </important>
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
        /// The client is permanently forbidden from making the request.
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
        [Obsolete("Attendee Tags are not supported in the Amazon Chime SDK Meetings Namespace. Update your application to remove calls to this API.")]
        Task<UntagAttendeeResponse> UntagAttendeeAsync(UntagAttendeeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagMeeting



        /// <summary>
        /// Untags the specified tags from the specified Amazon Chime SDK meeting.
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_meeting-chime_UntagResource.html">UntagResource</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
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
        /// The client is permanently forbidden from making the request.
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
        [Obsolete("Use UntagResource in the Amazon Chime SDK Meetings Namespace.")]
        Task<UntagMeetingResponse> UntagMeetingAsync(UntagMeetingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Untags the specified tags from the specified Amazon Chime SDK meeting resource.
        /// 
        ///  
        /// <para>
        /// Applies the specified tags to the specified Amazon Chime SDK meeting resource.
        /// </para>
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_meeting-chime_UntagResource.html">UntagResource</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
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
        /// The client is permanently forbidden from making the request.
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
        [Obsolete("Replaced by UntagResource in the Amazon Chime SDK Voice, Amazon Chime SDK Meetings, Amazon Chime SDK Identity, Amazon Chime SDK Messaging, and Amazon Chime SDK Media Pipelines Namespaces")]
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateAccount



        /// <summary>
        /// Updates account details for the specified Amazon Chime account. Currently, only account
        /// name and default license updates are supported for this action.
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
        /// The client is permanently forbidden from making the request.
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
        /// The client is permanently forbidden from making the request.
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
                
        #region  UpdateAppInstance



        /// <summary>
        /// Updates <code>AppInstance</code> metadata.
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_identity-chime_UpdateAppInstance.html">UpdateAppInstance</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAppInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAppInstance service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateAppInstance">REST API Reference for UpdateAppInstance Operation</seealso>
        [Obsolete("Replaced by UpdateAppInstance in the Amazon Chime SDK Identity Namespace")]
        Task<UpdateAppInstanceResponse> UpdateAppInstanceAsync(UpdateAppInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateAppInstanceUser



        /// <summary>
        /// Updates the details of an <code>AppInstanceUser</code>. You can update names and metadata.
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_identity-chime_UpdateAppInstanceUser.html">UpdateAppInstanceUser</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAppInstanceUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAppInstanceUser service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateAppInstanceUser">REST API Reference for UpdateAppInstanceUser Operation</seealso>
        [Obsolete("Replaced by UpdateAppInstanceUser in the Amazon Chime SDK Identity Namespace")]
        Task<UpdateAppInstanceUserResponse> UpdateAppInstanceUserAsync(UpdateAppInstanceUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// The client is permanently forbidden from making the request.
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
                
        #region  UpdateChannel



        /// <summary>
        /// Update a channel's attributes.
        /// 
        ///  
        /// <para>
        ///  <b>Restriction</b>: You can't change a channel's privacy. 
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  </note> <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_messaging-chime_UpdateChannel.html">UpdateChannel</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateChannel service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateChannel">REST API Reference for UpdateChannel Operation</seealso>
        [Obsolete("Replaced by UpdateChannel in the Amazon Chime SDK Messaging Namespace")]
        Task<UpdateChannelResponse> UpdateChannelAsync(UpdateChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateChannelMessage



        /// <summary>
        /// Updates the content of a message.
        /// 
        ///  <note> 
        /// <para>
        /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  </note> <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_messaging-chime_UpdateChannelMessage.html">UpdateChannelMessage</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateChannelMessage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateChannelMessage service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateChannelMessage">REST API Reference for UpdateChannelMessage Operation</seealso>
        [Obsolete("Replaced by UpdateChannelMessage in the Amazon Chime SDK Messaging Namespace")]
        Task<UpdateChannelMessageResponse> UpdateChannelMessageAsync(UpdateChannelMessageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateChannelReadMarker



        /// <summary>
        /// The details of the time when a user last read messages in a channel.
        /// 
        ///  <note> 
        /// <para>
        /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  </note> <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_messaging-chime_UpdateChannelReadMarker.html">UpdateChannelReadMarker</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateChannelReadMarker service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateChannelReadMarker service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateChannelReadMarker">REST API Reference for UpdateChannelReadMarker Operation</seealso>
        [Obsolete("Replaced by UpdateChannelReadMarker in the Amazon Chime SDK Messaging Namespace")]
        Task<UpdateChannelReadMarkerResponse> UpdateChannelReadMarkerAsync(UpdateChannelReadMarkerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// The client is permanently forbidden from making the request.
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
        /// For toll-free numbers, you cannot use the Amazon Chime Business Calling product type.
        /// For numbers outside the U.S., you must use the Amazon Chime SIP Media Application
        /// Dial-In product type.
        /// </para>
        ///  
        /// <para>
        /// Updates to outbound calling names can take 72 hours to complete. Pending updates to
        /// outbound calling names must be complete before you can request another update.
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
        /// <exception cref="Amazon.Chime.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
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
        /// The client is permanently forbidden from making the request.
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
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_voice-chime_UpdateProxySession.html">UpdateProxySession</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
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
        /// The client is permanently forbidden from making the request.
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
        [Obsolete("Replaced by UpdateProxySession in the Amazon Chime SDK Voice Namespace")]
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
        /// The client is permanently forbidden from making the request.
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
        /// The client is permanently forbidden from making the request.
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
                
        #region  UpdateSipMediaApplication



        /// <summary>
        /// Updates the details of the specified SIP media application.
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_voice-chime_UpdateSipMediaApplication.html">UpdateSipMediaApplication</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSipMediaApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSipMediaApplication service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateSipMediaApplication">REST API Reference for UpdateSipMediaApplication Operation</seealso>
        [Obsolete("Replaced by UpdateSipMediaApplication in the Amazon Chime SDK Voice Namespace")]
        Task<UpdateSipMediaApplicationResponse> UpdateSipMediaApplicationAsync(UpdateSipMediaApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateSipMediaApplicationCall



        /// <summary>
        /// Invokes the AWS Lambda function associated with the SIP media application and transaction
        /// ID in an update request. The Lambda function can then return a new set of actions.
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_voice-chime_UpdateSipMediaApplicationCall.html">UpdateSipMediaApplicationCall</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSipMediaApplicationCall service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSipMediaApplicationCall service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateSipMediaApplicationCall">REST API Reference for UpdateSipMediaApplicationCall Operation</seealso>
        [Obsolete("Replaced by UpdateSipMediaApplicationCall in the Amazon Chime SDK Voice Namespace")]
        Task<UpdateSipMediaApplicationCallResponse> UpdateSipMediaApplicationCallAsync(UpdateSipMediaApplicationCallRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateSipRule



        /// <summary>
        /// Updates the details of the specified SIP rule.
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_voice-chime_UpdateSipRule.html">UpdateSipRule</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSipRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSipRule service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateSipRule">REST API Reference for UpdateSipRule Operation</seealso>
        [Obsolete("Replaced by UpdateSipRule in the Amazon Chime SDK Voice Namespace")]
        Task<UpdateSipRuleResponse> UpdateSipRuleAsync(UpdateSipRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// The client is permanently forbidden from making the request.
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
        /// The client is permanently forbidden from making the request.
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
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_voice-chime_UpdateVoiceConnector.html">UpdateVoiceConnector</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
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
        /// The client is permanently forbidden from making the request.
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
        [Obsolete("Replaced by UpdateVoiceConnector in the Amazon Chime SDK Voice Namespace")]
        Task<UpdateVoiceConnectorResponse> UpdateVoiceConnectorAsync(UpdateVoiceConnectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateVoiceConnectorGroup



        /// <summary>
        /// Updates details of the specified Amazon Chime Voice Connector group, such as the name
        /// and Amazon Chime Voice Connector priority ranking.
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_voice-chime_UpdateVoiceConnectorGroup.html">UpdateVoiceConnectorGroup</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
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
        /// The client is permanently forbidden from making the request.
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
        [Obsolete("Replaced by UpdateVoiceConnectorGroup in the Amazon Chime SDK Voice Namespace")]
        Task<UpdateVoiceConnectorGroupResponse> UpdateVoiceConnectorGroupAsync(UpdateVoiceConnectorGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ValidateE911Address



        /// <summary>
        /// Validates an address to be used for 911 calls made with Amazon Chime Voice Connectors.
        /// You can use validated addresses in a Presence Information Data Format Location Object
        /// file that you include in SIP requests. That helps ensure that addresses are routed
        /// to the appropriate Public Safety Answering Point.
        /// 
        ///  <important> 
        /// <para>
        ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
        /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_voice-chime_ValidateE911Address.html">ValidateE911Address</a>,
        /// in the Amazon Chime SDK.
        /// </para>
        ///  
        /// <para>
        /// Using the latest version requires migrating to a dedicated namespace. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
        /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ValidateE911Address service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ValidateE911Address service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ValidateE911Address">REST API Reference for ValidateE911Address Operation</seealso>
        [Obsolete("Replaced by ValidateE911Address in the Amazon Chime SDK Voice Namespace")]
        Task<ValidateE911AddressResponse> ValidateE911AddressAsync(ValidateE911AddressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}