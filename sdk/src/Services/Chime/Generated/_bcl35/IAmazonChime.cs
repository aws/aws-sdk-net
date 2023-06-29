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


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
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
        AssociatePhoneNumbersWithVoiceConnectorResponse AssociatePhoneNumbersWithVoiceConnector(AssociatePhoneNumbersWithVoiceConnectorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociatePhoneNumbersWithVoiceConnector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociatePhoneNumbersWithVoiceConnector operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociatePhoneNumbersWithVoiceConnector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/AssociatePhoneNumbersWithVoiceConnector">REST API Reference for AssociatePhoneNumbersWithVoiceConnector Operation</seealso>
        [Obsolete("Replaced by AssociatePhoneNumbersWithVoiceConnector in the Amazon Chime SDK Voice Namespace")]
        IAsyncResult BeginAssociatePhoneNumbersWithVoiceConnector(AssociatePhoneNumbersWithVoiceConnectorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociatePhoneNumbersWithVoiceConnector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociatePhoneNumbersWithVoiceConnector.</param>
        /// 
        /// <returns>Returns a  AssociatePhoneNumbersWithVoiceConnectorResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/AssociatePhoneNumbersWithVoiceConnector">REST API Reference for AssociatePhoneNumbersWithVoiceConnector Operation</seealso>
        [Obsolete("Replaced by AssociatePhoneNumbersWithVoiceConnector in the Amazon Chime SDK Voice Namespace")]
        AssociatePhoneNumbersWithVoiceConnectorResponse EndAssociatePhoneNumbersWithVoiceConnector(IAsyncResult asyncResult);

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
        AssociatePhoneNumbersWithVoiceConnectorGroupResponse AssociatePhoneNumbersWithVoiceConnectorGroup(AssociatePhoneNumbersWithVoiceConnectorGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociatePhoneNumbersWithVoiceConnectorGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociatePhoneNumbersWithVoiceConnectorGroup operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociatePhoneNumbersWithVoiceConnectorGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/AssociatePhoneNumbersWithVoiceConnectorGroup">REST API Reference for AssociatePhoneNumbersWithVoiceConnectorGroup Operation</seealso>
        [Obsolete("Replaced by AssociatePhoneNumbersWithVoiceConnectorGroup in the Amazon Chime SDK Voice Namespace")]
        IAsyncResult BeginAssociatePhoneNumbersWithVoiceConnectorGroup(AssociatePhoneNumbersWithVoiceConnectorGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociatePhoneNumbersWithVoiceConnectorGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociatePhoneNumbersWithVoiceConnectorGroup.</param>
        /// 
        /// <returns>Returns a  AssociatePhoneNumbersWithVoiceConnectorGroupResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/AssociatePhoneNumbersWithVoiceConnectorGroup">REST API Reference for AssociatePhoneNumbersWithVoiceConnectorGroup Operation</seealso>
        [Obsolete("Replaced by AssociatePhoneNumbersWithVoiceConnectorGroup in the Amazon Chime SDK Voice Namespace")]
        AssociatePhoneNumbersWithVoiceConnectorGroupResponse EndAssociatePhoneNumbersWithVoiceConnectorGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  AssociatePhoneNumberWithUser


        /// <summary>
        /// Associates a phone number with the specified Amazon Chime user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociatePhoneNumberWithUser service method.</param>
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
        AssociatePhoneNumberWithUserResponse AssociatePhoneNumberWithUser(AssociatePhoneNumberWithUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociatePhoneNumberWithUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociatePhoneNumberWithUser operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociatePhoneNumberWithUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/AssociatePhoneNumberWithUser">REST API Reference for AssociatePhoneNumberWithUser Operation</seealso>
        IAsyncResult BeginAssociatePhoneNumberWithUser(AssociatePhoneNumberWithUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociatePhoneNumberWithUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociatePhoneNumberWithUser.</param>
        /// 
        /// <returns>Returns a  AssociatePhoneNumberWithUserResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/AssociatePhoneNumberWithUser">REST API Reference for AssociatePhoneNumberWithUser Operation</seealso>
        AssociatePhoneNumberWithUserResponse EndAssociatePhoneNumberWithUser(IAsyncResult asyncResult);

        #endregion
        
        #region  AssociateSigninDelegateGroupsWithAccount


        /// <summary>
        /// Associates the specified sign-in delegate groups with the specified Amazon Chime account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateSigninDelegateGroupsWithAccount service method.</param>
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
        AssociateSigninDelegateGroupsWithAccountResponse AssociateSigninDelegateGroupsWithAccount(AssociateSigninDelegateGroupsWithAccountRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateSigninDelegateGroupsWithAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateSigninDelegateGroupsWithAccount operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateSigninDelegateGroupsWithAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/AssociateSigninDelegateGroupsWithAccount">REST API Reference for AssociateSigninDelegateGroupsWithAccount Operation</seealso>
        IAsyncResult BeginAssociateSigninDelegateGroupsWithAccount(AssociateSigninDelegateGroupsWithAccountRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateSigninDelegateGroupsWithAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateSigninDelegateGroupsWithAccount.</param>
        /// 
        /// <returns>Returns a  AssociateSigninDelegateGroupsWithAccountResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/AssociateSigninDelegateGroupsWithAccount">REST API Reference for AssociateSigninDelegateGroupsWithAccount Operation</seealso>
        AssociateSigninDelegateGroupsWithAccountResponse EndAssociateSigninDelegateGroupsWithAccount(IAsyncResult asyncResult);

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
        BatchCreateAttendeeResponse BatchCreateAttendee(BatchCreateAttendeeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchCreateAttendee operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateAttendee operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchCreateAttendee
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/BatchCreateAttendee">REST API Reference for BatchCreateAttendee Operation</seealso>
        [Obsolete("Replaced by BatchCreateAttendee in the Amazon Chime SDK Meetings Namespace")]
        IAsyncResult BeginBatchCreateAttendee(BatchCreateAttendeeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchCreateAttendee operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchCreateAttendee.</param>
        /// 
        /// <returns>Returns a  BatchCreateAttendeeResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/BatchCreateAttendee">REST API Reference for BatchCreateAttendee Operation</seealso>
        [Obsolete("Replaced by BatchCreateAttendee in the Amazon Chime SDK Meetings Namespace")]
        BatchCreateAttendeeResponse EndBatchCreateAttendee(IAsyncResult asyncResult);

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
        BatchCreateChannelMembershipResponse BatchCreateChannelMembership(BatchCreateChannelMembershipRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchCreateChannelMembership operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateChannelMembership operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchCreateChannelMembership
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/BatchCreateChannelMembership">REST API Reference for BatchCreateChannelMembership Operation</seealso>
        [Obsolete("Replaced by BatchCreateChannelMembership in the Amazon Chime SDK Messaging Namespace")]
        IAsyncResult BeginBatchCreateChannelMembership(BatchCreateChannelMembershipRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchCreateChannelMembership operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchCreateChannelMembership.</param>
        /// 
        /// <returns>Returns a  BatchCreateChannelMembershipResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/BatchCreateChannelMembership">REST API Reference for BatchCreateChannelMembership Operation</seealso>
        [Obsolete("Replaced by BatchCreateChannelMembership in the Amazon Chime SDK Messaging Namespace")]
        BatchCreateChannelMembershipResponse EndBatchCreateChannelMembership(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchCreateRoomMembership


        /// <summary>
        /// Adds up to 50 members to a chat room in an Amazon Chime Enterprise account. Members
        /// can be users or bots. The member role designates whether the member is a chat room
        /// administrator or a general chat room member.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateRoomMembership service method.</param>
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
        BatchCreateRoomMembershipResponse BatchCreateRoomMembership(BatchCreateRoomMembershipRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchCreateRoomMembership operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateRoomMembership operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchCreateRoomMembership
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/BatchCreateRoomMembership">REST API Reference for BatchCreateRoomMembership Operation</seealso>
        IAsyncResult BeginBatchCreateRoomMembership(BatchCreateRoomMembershipRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchCreateRoomMembership operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchCreateRoomMembership.</param>
        /// 
        /// <returns>Returns a  BatchCreateRoomMembershipResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/BatchCreateRoomMembership">REST API Reference for BatchCreateRoomMembership Operation</seealso>
        BatchCreateRoomMembershipResponse EndBatchCreateRoomMembership(IAsyncResult asyncResult);

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
        BatchDeletePhoneNumberResponse BatchDeletePhoneNumber(BatchDeletePhoneNumberRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchDeletePhoneNumber operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDeletePhoneNumber operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchDeletePhoneNumber
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/BatchDeletePhoneNumber">REST API Reference for BatchDeletePhoneNumber Operation</seealso>
        IAsyncResult BeginBatchDeletePhoneNumber(BatchDeletePhoneNumberRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDeletePhoneNumber operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDeletePhoneNumber.</param>
        /// 
        /// <returns>Returns a  BatchDeletePhoneNumberResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/BatchDeletePhoneNumber">REST API Reference for BatchDeletePhoneNumber Operation</seealso>
        BatchDeletePhoneNumberResponse EndBatchDeletePhoneNumber(IAsyncResult asyncResult);

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
        BatchSuspendUserResponse BatchSuspendUser(BatchSuspendUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchSuspendUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchSuspendUser operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchSuspendUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/BatchSuspendUser">REST API Reference for BatchSuspendUser Operation</seealso>
        IAsyncResult BeginBatchSuspendUser(BatchSuspendUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchSuspendUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchSuspendUser.</param>
        /// 
        /// <returns>Returns a  BatchSuspendUserResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/BatchSuspendUser">REST API Reference for BatchSuspendUser Operation</seealso>
        BatchSuspendUserResponse EndBatchSuspendUser(IAsyncResult asyncResult);

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
        BatchUnsuspendUserResponse BatchUnsuspendUser(BatchUnsuspendUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchUnsuspendUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchUnsuspendUser operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchUnsuspendUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/BatchUnsuspendUser">REST API Reference for BatchUnsuspendUser Operation</seealso>
        IAsyncResult BeginBatchUnsuspendUser(BatchUnsuspendUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchUnsuspendUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchUnsuspendUser.</param>
        /// 
        /// <returns>Returns a  BatchUnsuspendUserResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/BatchUnsuspendUser">REST API Reference for BatchUnsuspendUser Operation</seealso>
        BatchUnsuspendUserResponse EndBatchUnsuspendUser(IAsyncResult asyncResult);

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
        BatchUpdatePhoneNumberResponse BatchUpdatePhoneNumber(BatchUpdatePhoneNumberRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchUpdatePhoneNumber operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdatePhoneNumber operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchUpdatePhoneNumber
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/BatchUpdatePhoneNumber">REST API Reference for BatchUpdatePhoneNumber Operation</seealso>
        IAsyncResult BeginBatchUpdatePhoneNumber(BatchUpdatePhoneNumberRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchUpdatePhoneNumber operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchUpdatePhoneNumber.</param>
        /// 
        /// <returns>Returns a  BatchUpdatePhoneNumberResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/BatchUpdatePhoneNumber">REST API Reference for BatchUpdatePhoneNumber Operation</seealso>
        BatchUpdatePhoneNumberResponse EndBatchUpdatePhoneNumber(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchUpdateUser


        /// <summary>
        /// Updates user details within the <a>UpdateUserRequestItem</a> object for up to 20 users
        /// for the specified Amazon Chime account. Currently, only <code>LicenseType</code> updates
        /// are supported for this action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateUser service method.</param>
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
        BatchUpdateUserResponse BatchUpdateUser(BatchUpdateUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchUpdateUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateUser operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchUpdateUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/BatchUpdateUser">REST API Reference for BatchUpdateUser Operation</seealso>
        IAsyncResult BeginBatchUpdateUser(BatchUpdateUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchUpdateUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchUpdateUser.</param>
        /// 
        /// <returns>Returns a  BatchUpdateUserResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/BatchUpdateUser">REST API Reference for BatchUpdateUser Operation</seealso>
        BatchUpdateUserResponse EndBatchUpdateUser(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateAccount


        /// <summary>
        /// Creates an Amazon Chime account under the administrator's AWS account. Only <code>Team</code>
        /// account types are currently supported for this action. For more information about
        /// different account types, see <a href="https://docs.aws.amazon.com/chime/latest/ag/manage-chime-account.html">Managing
        /// Your Amazon Chime Accounts</a> in the <i>Amazon Chime Administration Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccount service method.</param>
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
        CreateAccountResponse CreateAccount(CreateAccountRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAccount operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateAccount">REST API Reference for CreateAccount Operation</seealso>
        IAsyncResult BeginCreateAccount(CreateAccountRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAccount.</param>
        /// 
        /// <returns>Returns a  CreateAccountResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateAccount">REST API Reference for CreateAccount Operation</seealso>
        CreateAccountResponse EndCreateAccount(IAsyncResult asyncResult);

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
        CreateAppInstanceResponse CreateAppInstance(CreateAppInstanceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAppInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAppInstance operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAppInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateAppInstance">REST API Reference for CreateAppInstance Operation</seealso>
        [Obsolete("Replaced by CreateAppInstance in the Amazon Chime SDK Identity Namespace")]
        IAsyncResult BeginCreateAppInstance(CreateAppInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAppInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAppInstance.</param>
        /// 
        /// <returns>Returns a  CreateAppInstanceResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateAppInstance">REST API Reference for CreateAppInstance Operation</seealso>
        [Obsolete("Replaced by CreateAppInstance in the Amazon Chime SDK Identity Namespace")]
        CreateAppInstanceResponse EndCreateAppInstance(IAsyncResult asyncResult);

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
        CreateAppInstanceAdminResponse CreateAppInstanceAdmin(CreateAppInstanceAdminRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAppInstanceAdmin operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAppInstanceAdmin operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAppInstanceAdmin
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateAppInstanceAdmin">REST API Reference for CreateAppInstanceAdmin Operation</seealso>
        [Obsolete("Replaced by CreateAppInstanceAdmin in the Amazon Chime SDK Identity Namespace")]
        IAsyncResult BeginCreateAppInstanceAdmin(CreateAppInstanceAdminRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAppInstanceAdmin operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAppInstanceAdmin.</param>
        /// 
        /// <returns>Returns a  CreateAppInstanceAdminResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateAppInstanceAdmin">REST API Reference for CreateAppInstanceAdmin Operation</seealso>
        [Obsolete("Replaced by CreateAppInstanceAdmin in the Amazon Chime SDK Identity Namespace")]
        CreateAppInstanceAdminResponse EndCreateAppInstanceAdmin(IAsyncResult asyncResult);

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
        CreateAppInstanceUserResponse CreateAppInstanceUser(CreateAppInstanceUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAppInstanceUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAppInstanceUser operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAppInstanceUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateAppInstanceUser">REST API Reference for CreateAppInstanceUser Operation</seealso>
        [Obsolete("Replaced by CreateAppInstanceUser in the Amazon Chime SDK Identity Namespace")]
        IAsyncResult BeginCreateAppInstanceUser(CreateAppInstanceUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAppInstanceUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAppInstanceUser.</param>
        /// 
        /// <returns>Returns a  CreateAppInstanceUserResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateAppInstanceUser">REST API Reference for CreateAppInstanceUser Operation</seealso>
        [Obsolete("Replaced by CreateAppInstanceUser in the Amazon Chime SDK Identity Namespace")]
        CreateAppInstanceUserResponse EndCreateAppInstanceUser(IAsyncResult asyncResult);

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
        CreateAttendeeResponse CreateAttendee(CreateAttendeeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAttendee operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAttendee operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAttendee
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateAttendee">REST API Reference for CreateAttendee Operation</seealso>
        [Obsolete("Replaced by CreateAttendee in the Amazon Chime SDK Meetings Namespace")]
        IAsyncResult BeginCreateAttendee(CreateAttendeeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAttendee operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAttendee.</param>
        /// 
        /// <returns>Returns a  CreateAttendeeResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateAttendee">REST API Reference for CreateAttendee Operation</seealso>
        [Obsolete("Replaced by CreateAttendee in the Amazon Chime SDK Meetings Namespace")]
        CreateAttendeeResponse EndCreateAttendee(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateBot


        /// <summary>
        /// Creates a bot for an Amazon Chime Enterprise account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBot service method.</param>
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
        CreateBotResponse CreateBot(CreateBotRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateBot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBot operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateBot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateBot">REST API Reference for CreateBot Operation</seealso>
        IAsyncResult BeginCreateBot(CreateBotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBot.</param>
        /// 
        /// <returns>Returns a  CreateBotResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateBot">REST API Reference for CreateBot Operation</seealso>
        CreateBotResponse EndCreateBot(IAsyncResult asyncResult);

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
        CreateChannelResponse CreateChannel(CreateChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateChannel operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateChannel">REST API Reference for CreateChannel Operation</seealso>
        [Obsolete("Replaced by CreateChannel in the Amazon Chime SDK Messaging Namespace")]
        IAsyncResult BeginCreateChannel(CreateChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateChannel.</param>
        /// 
        /// <returns>Returns a  CreateChannelResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateChannel">REST API Reference for CreateChannel Operation</seealso>
        [Obsolete("Replaced by CreateChannel in the Amazon Chime SDK Messaging Namespace")]
        CreateChannelResponse EndCreateChannel(IAsyncResult asyncResult);

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
        CreateChannelBanResponse CreateChannelBan(CreateChannelBanRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateChannelBan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateChannelBan operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateChannelBan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateChannelBan">REST API Reference for CreateChannelBan Operation</seealso>
        [Obsolete("Replaced by CreateChannelBan in the Amazon Chime SDK Messaging Namespace")]
        IAsyncResult BeginCreateChannelBan(CreateChannelBanRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateChannelBan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateChannelBan.</param>
        /// 
        /// <returns>Returns a  CreateChannelBanResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateChannelBan">REST API Reference for CreateChannelBan Operation</seealso>
        [Obsolete("Replaced by CreateChannelBan in the Amazon Chime SDK Messaging Namespace")]
        CreateChannelBanResponse EndCreateChannelBan(IAsyncResult asyncResult);

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
        CreateChannelMembershipResponse CreateChannelMembership(CreateChannelMembershipRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateChannelMembership operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateChannelMembership operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateChannelMembership
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateChannelMembership">REST API Reference for CreateChannelMembership Operation</seealso>
        [Obsolete("Replaced by CreateChannelMembership in the Amazon Chime SDK Messaging Namespace")]
        IAsyncResult BeginCreateChannelMembership(CreateChannelMembershipRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateChannelMembership operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateChannelMembership.</param>
        /// 
        /// <returns>Returns a  CreateChannelMembershipResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateChannelMembership">REST API Reference for CreateChannelMembership Operation</seealso>
        [Obsolete("Replaced by CreateChannelMembership in the Amazon Chime SDK Messaging Namespace")]
        CreateChannelMembershipResponse EndCreateChannelMembership(IAsyncResult asyncResult);

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
        CreateChannelModeratorResponse CreateChannelModerator(CreateChannelModeratorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateChannelModerator operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateChannelModerator operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateChannelModerator
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateChannelModerator">REST API Reference for CreateChannelModerator Operation</seealso>
        [Obsolete("Replaced by CreateChannelModerator in the Amazon Chime SDK Messaging Namespace")]
        IAsyncResult BeginCreateChannelModerator(CreateChannelModeratorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateChannelModerator operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateChannelModerator.</param>
        /// 
        /// <returns>Returns a  CreateChannelModeratorResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateChannelModerator">REST API Reference for CreateChannelModerator Operation</seealso>
        [Obsolete("Replaced by CreateChannelModerator in the Amazon Chime SDK Messaging Namespace")]
        CreateChannelModeratorResponse EndCreateChannelModerator(IAsyncResult asyncResult);

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
        CreateMediaCapturePipelineResponse CreateMediaCapturePipeline(CreateMediaCapturePipelineRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateMediaCapturePipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMediaCapturePipeline operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMediaCapturePipeline
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateMediaCapturePipeline">REST API Reference for CreateMediaCapturePipeline Operation</seealso>
        [Obsolete("Replaced by CreateMediaCapturePipeline in the Amazon Chime SDK Media Pipelines Namespace")]
        IAsyncResult BeginCreateMediaCapturePipeline(CreateMediaCapturePipelineRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMediaCapturePipeline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMediaCapturePipeline.</param>
        /// 
        /// <returns>Returns a  CreateMediaCapturePipelineResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateMediaCapturePipeline">REST API Reference for CreateMediaCapturePipeline Operation</seealso>
        [Obsolete("Replaced by CreateMediaCapturePipeline in the Amazon Chime SDK Media Pipelines Namespace")]
        CreateMediaCapturePipelineResponse EndCreateMediaCapturePipeline(IAsyncResult asyncResult);

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
        CreateMeetingResponse CreateMeeting(CreateMeetingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateMeeting operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMeeting operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMeeting
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateMeeting">REST API Reference for CreateMeeting Operation</seealso>
        [Obsolete("Replaced by CreateMeeting in the Amazon Chime SDK Meetings Namespace")]
        IAsyncResult BeginCreateMeeting(CreateMeetingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMeeting operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMeeting.</param>
        /// 
        /// <returns>Returns a  CreateMeetingResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateMeeting">REST API Reference for CreateMeeting Operation</seealso>
        [Obsolete("Replaced by CreateMeeting in the Amazon Chime SDK Meetings Namespace")]
        CreateMeetingResponse EndCreateMeeting(IAsyncResult asyncResult);

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
        CreateMeetingDialOutResponse CreateMeetingDialOut(CreateMeetingDialOutRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateMeetingDialOut operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMeetingDialOut operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMeetingDialOut
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateMeetingDialOut">REST API Reference for CreateMeetingDialOut Operation</seealso>
        IAsyncResult BeginCreateMeetingDialOut(CreateMeetingDialOutRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMeetingDialOut operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMeetingDialOut.</param>
        /// 
        /// <returns>Returns a  CreateMeetingDialOutResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateMeetingDialOut">REST API Reference for CreateMeetingDialOut Operation</seealso>
        CreateMeetingDialOutResponse EndCreateMeetingDialOut(IAsyncResult asyncResult);

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
        CreateMeetingWithAttendeesResponse CreateMeetingWithAttendees(CreateMeetingWithAttendeesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateMeetingWithAttendees operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMeetingWithAttendees operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMeetingWithAttendees
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateMeetingWithAttendees">REST API Reference for CreateMeetingWithAttendees Operation</seealso>
        [Obsolete("Replaced by CreateMeetingWithAttendees in the Amazon Chime SDK Meetings Namespace")]
        IAsyncResult BeginCreateMeetingWithAttendees(CreateMeetingWithAttendeesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMeetingWithAttendees operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMeetingWithAttendees.</param>
        /// 
        /// <returns>Returns a  CreateMeetingWithAttendeesResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateMeetingWithAttendees">REST API Reference for CreateMeetingWithAttendees Operation</seealso>
        [Obsolete("Replaced by CreateMeetingWithAttendees in the Amazon Chime SDK Meetings Namespace")]
        CreateMeetingWithAttendeesResponse EndCreateMeetingWithAttendees(IAsyncResult asyncResult);

        #endregion
        
        #region  CreatePhoneNumberOrder


        /// <summary>
        /// Creates an order for phone numbers to be provisioned. For toll-free numbers, you cannot
        /// use the Amazon Chime Business Calling product type. For numbers outside the U.S.,
        /// you must use the Amazon Chime SIP Media Application Dial-In product type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePhoneNumberOrder service method.</param>
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
        CreatePhoneNumberOrderResponse CreatePhoneNumberOrder(CreatePhoneNumberOrderRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePhoneNumberOrder operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePhoneNumberOrder operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePhoneNumberOrder
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreatePhoneNumberOrder">REST API Reference for CreatePhoneNumberOrder Operation</seealso>
        IAsyncResult BeginCreatePhoneNumberOrder(CreatePhoneNumberOrderRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePhoneNumberOrder operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePhoneNumberOrder.</param>
        /// 
        /// <returns>Returns a  CreatePhoneNumberOrderResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreatePhoneNumberOrder">REST API Reference for CreatePhoneNumberOrder Operation</seealso>
        CreatePhoneNumberOrderResponse EndCreatePhoneNumberOrder(IAsyncResult asyncResult);

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
        CreateProxySessionResponse CreateProxySession(CreateProxySessionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateProxySession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateProxySession operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateProxySession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateProxySession">REST API Reference for CreateProxySession Operation</seealso>
        [Obsolete("Replaced by CreateProxySession in the Amazon Chime SDK Voice Namespace")]
        IAsyncResult BeginCreateProxySession(CreateProxySessionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateProxySession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateProxySession.</param>
        /// 
        /// <returns>Returns a  CreateProxySessionResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateProxySession">REST API Reference for CreateProxySession Operation</seealso>
        [Obsolete("Replaced by CreateProxySession in the Amazon Chime SDK Voice Namespace")]
        CreateProxySessionResponse EndCreateProxySession(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateRoom


        /// <summary>
        /// Creates a chat room for the specified Amazon Chime Enterprise account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRoom service method.</param>
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
        CreateRoomResponse CreateRoom(CreateRoomRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRoom operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRoom operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRoom
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateRoom">REST API Reference for CreateRoom Operation</seealso>
        IAsyncResult BeginCreateRoom(CreateRoomRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRoom operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRoom.</param>
        /// 
        /// <returns>Returns a  CreateRoomResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateRoom">REST API Reference for CreateRoom Operation</seealso>
        CreateRoomResponse EndCreateRoom(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateRoomMembership


        /// <summary>
        /// Adds a member to a chat room in an Amazon Chime Enterprise account. A member can be
        /// either a user or a bot. The member role designates whether the member is a chat room
        /// administrator or a general chat room member.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRoomMembership service method.</param>
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
        CreateRoomMembershipResponse CreateRoomMembership(CreateRoomMembershipRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRoomMembership operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRoomMembership operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRoomMembership
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateRoomMembership">REST API Reference for CreateRoomMembership Operation</seealso>
        IAsyncResult BeginCreateRoomMembership(CreateRoomMembershipRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRoomMembership operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRoomMembership.</param>
        /// 
        /// <returns>Returns a  CreateRoomMembershipResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateRoomMembership">REST API Reference for CreateRoomMembership Operation</seealso>
        CreateRoomMembershipResponse EndCreateRoomMembership(IAsyncResult asyncResult);

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
        CreateSipMediaApplicationResponse CreateSipMediaApplication(CreateSipMediaApplicationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSipMediaApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSipMediaApplication operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSipMediaApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateSipMediaApplication">REST API Reference for CreateSipMediaApplication Operation</seealso>
        [Obsolete("Replaced by CreateSipMediaApplication in the Amazon Chime SDK Voice Namespace")]
        IAsyncResult BeginCreateSipMediaApplication(CreateSipMediaApplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSipMediaApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSipMediaApplication.</param>
        /// 
        /// <returns>Returns a  CreateSipMediaApplicationResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateSipMediaApplication">REST API Reference for CreateSipMediaApplication Operation</seealso>
        [Obsolete("Replaced by CreateSipMediaApplication in the Amazon Chime SDK Voice Namespace")]
        CreateSipMediaApplicationResponse EndCreateSipMediaApplication(IAsyncResult asyncResult);

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
        CreateSipMediaApplicationCallResponse CreateSipMediaApplicationCall(CreateSipMediaApplicationCallRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSipMediaApplicationCall operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSipMediaApplicationCall operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSipMediaApplicationCall
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateSipMediaApplicationCall">REST API Reference for CreateSipMediaApplicationCall Operation</seealso>
        [Obsolete("Replaced by CreateSipMediaApplicationCall in the Amazon Chime SDK Voice Namespace")]
        IAsyncResult BeginCreateSipMediaApplicationCall(CreateSipMediaApplicationCallRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSipMediaApplicationCall operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSipMediaApplicationCall.</param>
        /// 
        /// <returns>Returns a  CreateSipMediaApplicationCallResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateSipMediaApplicationCall">REST API Reference for CreateSipMediaApplicationCall Operation</seealso>
        [Obsolete("Replaced by CreateSipMediaApplicationCall in the Amazon Chime SDK Voice Namespace")]
        CreateSipMediaApplicationCallResponse EndCreateSipMediaApplicationCall(IAsyncResult asyncResult);

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
        CreateSipRuleResponse CreateSipRule(CreateSipRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSipRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSipRule operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSipRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateSipRule">REST API Reference for CreateSipRule Operation</seealso>
        [Obsolete("Replaced by CreateSipRule in the Amazon Chime SDK Voice Namespace")]
        IAsyncResult BeginCreateSipRule(CreateSipRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSipRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSipRule.</param>
        /// 
        /// <returns>Returns a  CreateSipRuleResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateSipRule">REST API Reference for CreateSipRule Operation</seealso>
        [Obsolete("Replaced by CreateSipRule in the Amazon Chime SDK Voice Namespace")]
        CreateSipRuleResponse EndCreateSipRule(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateUser


        /// <summary>
        /// Creates a user under the specified Amazon Chime account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUser service method.</param>
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
        CreateUserResponse CreateUser(CreateUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUser operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateUser">REST API Reference for CreateUser Operation</seealso>
        IAsyncResult BeginCreateUser(CreateUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateUser.</param>
        /// 
        /// <returns>Returns a  CreateUserResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateUser">REST API Reference for CreateUser Operation</seealso>
        CreateUserResponse EndCreateUser(IAsyncResult asyncResult);

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
        CreateVoiceConnectorResponse CreateVoiceConnector(CreateVoiceConnectorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVoiceConnector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVoiceConnector operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVoiceConnector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateVoiceConnector">REST API Reference for CreateVoiceConnector Operation</seealso>
        [Obsolete("Replaced by CreateVoiceConnector in the Amazon Chime SDK Voice Namespace")]
        IAsyncResult BeginCreateVoiceConnector(CreateVoiceConnectorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVoiceConnector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVoiceConnector.</param>
        /// 
        /// <returns>Returns a  CreateVoiceConnectorResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateVoiceConnector">REST API Reference for CreateVoiceConnector Operation</seealso>
        [Obsolete("Replaced by CreateVoiceConnector in the Amazon Chime SDK Voice Namespace")]
        CreateVoiceConnectorResponse EndCreateVoiceConnector(IAsyncResult asyncResult);

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
        CreateVoiceConnectorGroupResponse CreateVoiceConnectorGroup(CreateVoiceConnectorGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVoiceConnectorGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVoiceConnectorGroup operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVoiceConnectorGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateVoiceConnectorGroup">REST API Reference for CreateVoiceConnectorGroup Operation</seealso>
        [Obsolete("Replaced by CreateVoiceConnectorGroup in the Amazon Chime SDK Voice Namespace")]
        IAsyncResult BeginCreateVoiceConnectorGroup(CreateVoiceConnectorGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVoiceConnectorGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVoiceConnectorGroup.</param>
        /// 
        /// <returns>Returns a  CreateVoiceConnectorGroupResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateVoiceConnectorGroup">REST API Reference for CreateVoiceConnectorGroup Operation</seealso>
        [Obsolete("Replaced by CreateVoiceConnectorGroup in the Amazon Chime SDK Voice Namespace")]
        CreateVoiceConnectorGroupResponse EndCreateVoiceConnectorGroup(IAsyncResult asyncResult);

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
        DeleteAccountResponse DeleteAccount(DeleteAccountRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccount operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteAccount">REST API Reference for DeleteAccount Operation</seealso>
        IAsyncResult BeginDeleteAccount(DeleteAccountRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAccount.</param>
        /// 
        /// <returns>Returns a  DeleteAccountResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteAccount">REST API Reference for DeleteAccount Operation</seealso>
        DeleteAccountResponse EndDeleteAccount(IAsyncResult asyncResult);

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
        DeleteAppInstanceResponse DeleteAppInstance(DeleteAppInstanceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAppInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAppInstance operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAppInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteAppInstance">REST API Reference for DeleteAppInstance Operation</seealso>
        [Obsolete("Replaced by DeleteAppInstance in the Amazon Chime SDK Identity Namespace")]
        IAsyncResult BeginDeleteAppInstance(DeleteAppInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAppInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAppInstance.</param>
        /// 
        /// <returns>Returns a  DeleteAppInstanceResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteAppInstance">REST API Reference for DeleteAppInstance Operation</seealso>
        [Obsolete("Replaced by DeleteAppInstance in the Amazon Chime SDK Identity Namespace")]
        DeleteAppInstanceResponse EndDeleteAppInstance(IAsyncResult asyncResult);

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
        DeleteAppInstanceAdminResponse DeleteAppInstanceAdmin(DeleteAppInstanceAdminRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAppInstanceAdmin operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAppInstanceAdmin operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAppInstanceAdmin
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteAppInstanceAdmin">REST API Reference for DeleteAppInstanceAdmin Operation</seealso>
        [Obsolete("Replaced by DeleteAppInstanceAdmin in the Amazon Chime SDK Identity Namespace")]
        IAsyncResult BeginDeleteAppInstanceAdmin(DeleteAppInstanceAdminRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAppInstanceAdmin operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAppInstanceAdmin.</param>
        /// 
        /// <returns>Returns a  DeleteAppInstanceAdminResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteAppInstanceAdmin">REST API Reference for DeleteAppInstanceAdmin Operation</seealso>
        [Obsolete("Replaced by DeleteAppInstanceAdmin in the Amazon Chime SDK Identity Namespace")]
        DeleteAppInstanceAdminResponse EndDeleteAppInstanceAdmin(IAsyncResult asyncResult);

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
        DeleteAppInstanceStreamingConfigurationsResponse DeleteAppInstanceStreamingConfigurations(DeleteAppInstanceStreamingConfigurationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAppInstanceStreamingConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAppInstanceStreamingConfigurations operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAppInstanceStreamingConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteAppInstanceStreamingConfigurations">REST API Reference for DeleteAppInstanceStreamingConfigurations Operation</seealso>
        [Obsolete("Replaced by DeleteAppInstanceStreamingConfigurations in the Amazon Chime SDK Messaging Namespace")]
        IAsyncResult BeginDeleteAppInstanceStreamingConfigurations(DeleteAppInstanceStreamingConfigurationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAppInstanceStreamingConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAppInstanceStreamingConfigurations.</param>
        /// 
        /// <returns>Returns a  DeleteAppInstanceStreamingConfigurationsResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteAppInstanceStreamingConfigurations">REST API Reference for DeleteAppInstanceStreamingConfigurations Operation</seealso>
        [Obsolete("Replaced by DeleteAppInstanceStreamingConfigurations in the Amazon Chime SDK Messaging Namespace")]
        DeleteAppInstanceStreamingConfigurationsResponse EndDeleteAppInstanceStreamingConfigurations(IAsyncResult asyncResult);

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
        DeleteAppInstanceUserResponse DeleteAppInstanceUser(DeleteAppInstanceUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAppInstanceUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAppInstanceUser operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAppInstanceUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteAppInstanceUser">REST API Reference for DeleteAppInstanceUser Operation</seealso>
        [Obsolete("Replaced by DeleteAppInstanceUser in the Amazon Chime SDK Identity Namespace")]
        IAsyncResult BeginDeleteAppInstanceUser(DeleteAppInstanceUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAppInstanceUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAppInstanceUser.</param>
        /// 
        /// <returns>Returns a  DeleteAppInstanceUserResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteAppInstanceUser">REST API Reference for DeleteAppInstanceUser Operation</seealso>
        [Obsolete("Replaced by DeleteAppInstanceUser in the Amazon Chime SDK Identity Namespace")]
        DeleteAppInstanceUserResponse EndDeleteAppInstanceUser(IAsyncResult asyncResult);

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
        DeleteAttendeeResponse DeleteAttendee(DeleteAttendeeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAttendee operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAttendee operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAttendee
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteAttendee">REST API Reference for DeleteAttendee Operation</seealso>
        [Obsolete("Replaced by DeleteAttendee in the Amazon Chime SDK Meetings Namespace")]
        IAsyncResult BeginDeleteAttendee(DeleteAttendeeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAttendee operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAttendee.</param>
        /// 
        /// <returns>Returns a  DeleteAttendeeResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteAttendee">REST API Reference for DeleteAttendee Operation</seealso>
        [Obsolete("Replaced by DeleteAttendee in the Amazon Chime SDK Meetings Namespace")]
        DeleteAttendeeResponse EndDeleteAttendee(IAsyncResult asyncResult);

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
        DeleteChannelResponse DeleteChannel(DeleteChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannel operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteChannel">REST API Reference for DeleteChannel Operation</seealso>
        [Obsolete("Replaced by DeleteChannel in the Amazon Chime SDK Messaging Namespace")]
        IAsyncResult BeginDeleteChannel(DeleteChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteChannel.</param>
        /// 
        /// <returns>Returns a  DeleteChannelResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteChannel">REST API Reference for DeleteChannel Operation</seealso>
        [Obsolete("Replaced by DeleteChannel in the Amazon Chime SDK Messaging Namespace")]
        DeleteChannelResponse EndDeleteChannel(IAsyncResult asyncResult);

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
        DeleteChannelBanResponse DeleteChannelBan(DeleteChannelBanRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteChannelBan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannelBan operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteChannelBan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteChannelBan">REST API Reference for DeleteChannelBan Operation</seealso>
        [Obsolete("Replaced by DeleteChannelBan in the Amazon Chime SDK Messaging Namespace")]
        IAsyncResult BeginDeleteChannelBan(DeleteChannelBanRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteChannelBan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteChannelBan.</param>
        /// 
        /// <returns>Returns a  DeleteChannelBanResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteChannelBan">REST API Reference for DeleteChannelBan Operation</seealso>
        [Obsolete("Replaced by DeleteChannelBan in the Amazon Chime SDK Messaging Namespace")]
        DeleteChannelBanResponse EndDeleteChannelBan(IAsyncResult asyncResult);

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
        DeleteChannelMembershipResponse DeleteChannelMembership(DeleteChannelMembershipRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteChannelMembership operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannelMembership operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteChannelMembership
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteChannelMembership">REST API Reference for DeleteChannelMembership Operation</seealso>
        [Obsolete("Replaced by DeleteChannelMembership in the Amazon Chime SDK Messaging Namespace")]
        IAsyncResult BeginDeleteChannelMembership(DeleteChannelMembershipRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteChannelMembership operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteChannelMembership.</param>
        /// 
        /// <returns>Returns a  DeleteChannelMembershipResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteChannelMembership">REST API Reference for DeleteChannelMembership Operation</seealso>
        [Obsolete("Replaced by DeleteChannelMembership in the Amazon Chime SDK Messaging Namespace")]
        DeleteChannelMembershipResponse EndDeleteChannelMembership(IAsyncResult asyncResult);

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
        DeleteChannelMessageResponse DeleteChannelMessage(DeleteChannelMessageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteChannelMessage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannelMessage operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteChannelMessage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteChannelMessage">REST API Reference for DeleteChannelMessage Operation</seealso>
        [Obsolete("Replaced by DeleteChannelMessage in the Amazon Chime SDK Messaging Namespace")]
        IAsyncResult BeginDeleteChannelMessage(DeleteChannelMessageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteChannelMessage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteChannelMessage.</param>
        /// 
        /// <returns>Returns a  DeleteChannelMessageResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteChannelMessage">REST API Reference for DeleteChannelMessage Operation</seealso>
        [Obsolete("Replaced by DeleteChannelMessage in the Amazon Chime SDK Messaging Namespace")]
        DeleteChannelMessageResponse EndDeleteChannelMessage(IAsyncResult asyncResult);

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
        DeleteChannelModeratorResponse DeleteChannelModerator(DeleteChannelModeratorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteChannelModerator operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannelModerator operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteChannelModerator
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteChannelModerator">REST API Reference for DeleteChannelModerator Operation</seealso>
        [Obsolete("Replaced by DeleteChannelModerator in the Amazon Chime SDK Messaging Namespace")]
        IAsyncResult BeginDeleteChannelModerator(DeleteChannelModeratorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteChannelModerator operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteChannelModerator.</param>
        /// 
        /// <returns>Returns a  DeleteChannelModeratorResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteChannelModerator">REST API Reference for DeleteChannelModerator Operation</seealso>
        [Obsolete("Replaced by DeleteChannelModerator in the Amazon Chime SDK Messaging Namespace")]
        DeleteChannelModeratorResponse EndDeleteChannelModerator(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteEventsConfiguration


        /// <summary>
        /// Deletes the events configuration that allows a bot to receive outgoing events.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventsConfiguration service method.</param>
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
        DeleteEventsConfigurationResponse DeleteEventsConfiguration(DeleteEventsConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEventsConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventsConfiguration operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEventsConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteEventsConfiguration">REST API Reference for DeleteEventsConfiguration Operation</seealso>
        IAsyncResult BeginDeleteEventsConfiguration(DeleteEventsConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEventsConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEventsConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteEventsConfigurationResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteEventsConfiguration">REST API Reference for DeleteEventsConfiguration Operation</seealso>
        DeleteEventsConfigurationResponse EndDeleteEventsConfiguration(IAsyncResult asyncResult);

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
        DeleteMediaCapturePipelineResponse DeleteMediaCapturePipeline(DeleteMediaCapturePipelineRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMediaCapturePipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMediaCapturePipeline operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMediaCapturePipeline
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteMediaCapturePipeline">REST API Reference for DeleteMediaCapturePipeline Operation</seealso>
        [Obsolete("Replaced by DeleteMediaCapturePipeline in the Amazon Chime SDK Media Pipelines Namespace")]
        IAsyncResult BeginDeleteMediaCapturePipeline(DeleteMediaCapturePipelineRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMediaCapturePipeline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMediaCapturePipeline.</param>
        /// 
        /// <returns>Returns a  DeleteMediaCapturePipelineResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteMediaCapturePipeline">REST API Reference for DeleteMediaCapturePipeline Operation</seealso>
        [Obsolete("Replaced by DeleteMediaCapturePipeline in the Amazon Chime SDK Media Pipelines Namespace")]
        DeleteMediaCapturePipelineResponse EndDeleteMediaCapturePipeline(IAsyncResult asyncResult);

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
        DeleteMeetingResponse DeleteMeeting(DeleteMeetingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMeeting operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMeeting operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMeeting
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteMeeting">REST API Reference for DeleteMeeting Operation</seealso>
        [Obsolete("Replaced by DeleteMeeting in the Amazon Chime SDK Meetings Namespace")]
        IAsyncResult BeginDeleteMeeting(DeleteMeetingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMeeting operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMeeting.</param>
        /// 
        /// <returns>Returns a  DeleteMeetingResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteMeeting">REST API Reference for DeleteMeeting Operation</seealso>
        [Obsolete("Replaced by DeleteMeeting in the Amazon Chime SDK Meetings Namespace")]
        DeleteMeetingResponse EndDeleteMeeting(IAsyncResult asyncResult);

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
        DeletePhoneNumberResponse DeletePhoneNumber(DeletePhoneNumberRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePhoneNumber operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePhoneNumber operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePhoneNumber
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeletePhoneNumber">REST API Reference for DeletePhoneNumber Operation</seealso>
        IAsyncResult BeginDeletePhoneNumber(DeletePhoneNumberRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePhoneNumber operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePhoneNumber.</param>
        /// 
        /// <returns>Returns a  DeletePhoneNumberResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeletePhoneNumber">REST API Reference for DeletePhoneNumber Operation</seealso>
        DeletePhoneNumberResponse EndDeletePhoneNumber(IAsyncResult asyncResult);

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
        DeleteProxySessionResponse DeleteProxySession(DeleteProxySessionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteProxySession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteProxySession operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteProxySession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteProxySession">REST API Reference for DeleteProxySession Operation</seealso>
        [Obsolete("Replaced by DeleteProxySession in the Amazon Chime SDK Voice Namespace")]
        IAsyncResult BeginDeleteProxySession(DeleteProxySessionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteProxySession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteProxySession.</param>
        /// 
        /// <returns>Returns a  DeleteProxySessionResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteProxySession">REST API Reference for DeleteProxySession Operation</seealso>
        [Obsolete("Replaced by DeleteProxySession in the Amazon Chime SDK Voice Namespace")]
        DeleteProxySessionResponse EndDeleteProxySession(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteRoom


        /// <summary>
        /// Deletes a chat room in an Amazon Chime Enterprise account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoom service method.</param>
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
        DeleteRoomResponse DeleteRoom(DeleteRoomRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRoom operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoom operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRoom
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteRoom">REST API Reference for DeleteRoom Operation</seealso>
        IAsyncResult BeginDeleteRoom(DeleteRoomRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRoom operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRoom.</param>
        /// 
        /// <returns>Returns a  DeleteRoomResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteRoom">REST API Reference for DeleteRoom Operation</seealso>
        DeleteRoomResponse EndDeleteRoom(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteRoomMembership


        /// <summary>
        /// Removes a member from a chat room in an Amazon Chime Enterprise account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoomMembership service method.</param>
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
        DeleteRoomMembershipResponse DeleteRoomMembership(DeleteRoomMembershipRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRoomMembership operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoomMembership operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRoomMembership
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteRoomMembership">REST API Reference for DeleteRoomMembership Operation</seealso>
        IAsyncResult BeginDeleteRoomMembership(DeleteRoomMembershipRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRoomMembership operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRoomMembership.</param>
        /// 
        /// <returns>Returns a  DeleteRoomMembershipResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteRoomMembership">REST API Reference for DeleteRoomMembership Operation</seealso>
        DeleteRoomMembershipResponse EndDeleteRoomMembership(IAsyncResult asyncResult);

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
        DeleteSipMediaApplicationResponse DeleteSipMediaApplication(DeleteSipMediaApplicationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSipMediaApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSipMediaApplication operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSipMediaApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteSipMediaApplication">REST API Reference for DeleteSipMediaApplication Operation</seealso>
        [Obsolete("Replaced by DeleteSipMediaApplication in the Amazon Chime SDK Voice Namespace")]
        IAsyncResult BeginDeleteSipMediaApplication(DeleteSipMediaApplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSipMediaApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSipMediaApplication.</param>
        /// 
        /// <returns>Returns a  DeleteSipMediaApplicationResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteSipMediaApplication">REST API Reference for DeleteSipMediaApplication Operation</seealso>
        [Obsolete("Replaced by DeleteSipMediaApplication in the Amazon Chime SDK Voice Namespace")]
        DeleteSipMediaApplicationResponse EndDeleteSipMediaApplication(IAsyncResult asyncResult);

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
        DeleteSipRuleResponse DeleteSipRule(DeleteSipRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSipRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSipRule operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSipRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteSipRule">REST API Reference for DeleteSipRule Operation</seealso>
        [Obsolete("Replaced by DeleteSipRule in the Amazon Chime SDK Voice Namespace")]
        IAsyncResult BeginDeleteSipRule(DeleteSipRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSipRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSipRule.</param>
        /// 
        /// <returns>Returns a  DeleteSipRuleResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteSipRule">REST API Reference for DeleteSipRule Operation</seealso>
        [Obsolete("Replaced by DeleteSipRule in the Amazon Chime SDK Voice Namespace")]
        DeleteSipRuleResponse EndDeleteSipRule(IAsyncResult asyncResult);

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
        DeleteVoiceConnectorResponse DeleteVoiceConnector(DeleteVoiceConnectorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVoiceConnector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceConnector operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVoiceConnector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteVoiceConnector">REST API Reference for DeleteVoiceConnector Operation</seealso>
        [Obsolete("Replaced by DeleteVoiceConnector in the Amazon Chime SDK Voice Namespace")]
        IAsyncResult BeginDeleteVoiceConnector(DeleteVoiceConnectorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVoiceConnector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVoiceConnector.</param>
        /// 
        /// <returns>Returns a  DeleteVoiceConnectorResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteVoiceConnector">REST API Reference for DeleteVoiceConnector Operation</seealso>
        [Obsolete("Replaced by DeleteVoiceConnector in the Amazon Chime SDK Voice Namespace")]
        DeleteVoiceConnectorResponse EndDeleteVoiceConnector(IAsyncResult asyncResult);

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
        DeleteVoiceConnectorEmergencyCallingConfigurationResponse DeleteVoiceConnectorEmergencyCallingConfiguration(DeleteVoiceConnectorEmergencyCallingConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVoiceConnectorEmergencyCallingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceConnectorEmergencyCallingConfiguration operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVoiceConnectorEmergencyCallingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteVoiceConnectorEmergencyCallingConfiguration">REST API Reference for DeleteVoiceConnectorEmergencyCallingConfiguration Operation</seealso>
        [Obsolete("Replaced by DeleteVoiceConnectorEmergencyCallingConfiguration in the Amazon Chime SDK Voice Namespace")]
        IAsyncResult BeginDeleteVoiceConnectorEmergencyCallingConfiguration(DeleteVoiceConnectorEmergencyCallingConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVoiceConnectorEmergencyCallingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVoiceConnectorEmergencyCallingConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteVoiceConnectorEmergencyCallingConfigurationResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteVoiceConnectorEmergencyCallingConfiguration">REST API Reference for DeleteVoiceConnectorEmergencyCallingConfiguration Operation</seealso>
        [Obsolete("Replaced by DeleteVoiceConnectorEmergencyCallingConfiguration in the Amazon Chime SDK Voice Namespace")]
        DeleteVoiceConnectorEmergencyCallingConfigurationResponse EndDeleteVoiceConnectorEmergencyCallingConfiguration(IAsyncResult asyncResult);

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
        DeleteVoiceConnectorGroupResponse DeleteVoiceConnectorGroup(DeleteVoiceConnectorGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVoiceConnectorGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceConnectorGroup operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVoiceConnectorGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteVoiceConnectorGroup">REST API Reference for DeleteVoiceConnectorGroup Operation</seealso>
        [Obsolete("Replaced by DeleteVoiceConnectorGroup in the Amazon Chime SDK Voice Namespace")]
        IAsyncResult BeginDeleteVoiceConnectorGroup(DeleteVoiceConnectorGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVoiceConnectorGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVoiceConnectorGroup.</param>
        /// 
        /// <returns>Returns a  DeleteVoiceConnectorGroupResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteVoiceConnectorGroup">REST API Reference for DeleteVoiceConnectorGroup Operation</seealso>
        [Obsolete("Replaced by DeleteVoiceConnectorGroup in the Amazon Chime SDK Voice Namespace")]
        DeleteVoiceConnectorGroupResponse EndDeleteVoiceConnectorGroup(IAsyncResult asyncResult);

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
        DeleteVoiceConnectorOriginationResponse DeleteVoiceConnectorOrigination(DeleteVoiceConnectorOriginationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVoiceConnectorOrigination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceConnectorOrigination operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVoiceConnectorOrigination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteVoiceConnectorOrigination">REST API Reference for DeleteVoiceConnectorOrigination Operation</seealso>
        [Obsolete("Replaced by DeleteVoiceConnectorOrigination in the Amazon Chime SDK Voice Namespace")]
        IAsyncResult BeginDeleteVoiceConnectorOrigination(DeleteVoiceConnectorOriginationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVoiceConnectorOrigination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVoiceConnectorOrigination.</param>
        /// 
        /// <returns>Returns a  DeleteVoiceConnectorOriginationResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteVoiceConnectorOrigination">REST API Reference for DeleteVoiceConnectorOrigination Operation</seealso>
        [Obsolete("Replaced by DeleteVoiceConnectorOrigination in the Amazon Chime SDK Voice Namespace")]
        DeleteVoiceConnectorOriginationResponse EndDeleteVoiceConnectorOrigination(IAsyncResult asyncResult);

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
        DeleteVoiceConnectorProxyResponse DeleteVoiceConnectorProxy(DeleteVoiceConnectorProxyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVoiceConnectorProxy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceConnectorProxy operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVoiceConnectorProxy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteVoiceConnectorProxy">REST API Reference for DeleteVoiceConnectorProxy Operation</seealso>
        [Obsolete("Replaced by DeleteVoiceConnectorProxy in the Amazon Chime SDK Voice Namespace")]
        IAsyncResult BeginDeleteVoiceConnectorProxy(DeleteVoiceConnectorProxyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVoiceConnectorProxy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVoiceConnectorProxy.</param>
        /// 
        /// <returns>Returns a  DeleteVoiceConnectorProxyResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteVoiceConnectorProxy">REST API Reference for DeleteVoiceConnectorProxy Operation</seealso>
        [Obsolete("Replaced by DeleteVoiceConnectorProxy in the Amazon Chime SDK Voice Namespace")]
        DeleteVoiceConnectorProxyResponse EndDeleteVoiceConnectorProxy(IAsyncResult asyncResult);

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
        DeleteVoiceConnectorStreamingConfigurationResponse DeleteVoiceConnectorStreamingConfiguration(DeleteVoiceConnectorStreamingConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVoiceConnectorStreamingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceConnectorStreamingConfiguration operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVoiceConnectorStreamingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteVoiceConnectorStreamingConfiguration">REST API Reference for DeleteVoiceConnectorStreamingConfiguration Operation</seealso>
        [Obsolete("Replaced by DeleteVoiceConnectorStreamingConfiguration in the Amazon Chime SDK Voice Namespace")]
        IAsyncResult BeginDeleteVoiceConnectorStreamingConfiguration(DeleteVoiceConnectorStreamingConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVoiceConnectorStreamingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVoiceConnectorStreamingConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteVoiceConnectorStreamingConfigurationResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteVoiceConnectorStreamingConfiguration">REST API Reference for DeleteVoiceConnectorStreamingConfiguration Operation</seealso>
        [Obsolete("Replaced by DeleteVoiceConnectorStreamingConfiguration in the Amazon Chime SDK Voice Namespace")]
        DeleteVoiceConnectorStreamingConfigurationResponse EndDeleteVoiceConnectorStreamingConfiguration(IAsyncResult asyncResult);

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
        DeleteVoiceConnectorTerminationResponse DeleteVoiceConnectorTermination(DeleteVoiceConnectorTerminationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVoiceConnectorTermination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceConnectorTermination operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVoiceConnectorTermination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteVoiceConnectorTermination">REST API Reference for DeleteVoiceConnectorTermination Operation</seealso>
        [Obsolete("Replaced by DeleteVoiceConnectorTermination in the Amazon Chime SDK Voice Namespace")]
        IAsyncResult BeginDeleteVoiceConnectorTermination(DeleteVoiceConnectorTerminationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVoiceConnectorTermination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVoiceConnectorTermination.</param>
        /// 
        /// <returns>Returns a  DeleteVoiceConnectorTerminationResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteVoiceConnectorTermination">REST API Reference for DeleteVoiceConnectorTermination Operation</seealso>
        [Obsolete("Replaced by DeleteVoiceConnectorTermination in the Amazon Chime SDK Voice Namespace")]
        DeleteVoiceConnectorTerminationResponse EndDeleteVoiceConnectorTermination(IAsyncResult asyncResult);

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
        DeleteVoiceConnectorTerminationCredentialsResponse DeleteVoiceConnectorTerminationCredentials(DeleteVoiceConnectorTerminationCredentialsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVoiceConnectorTerminationCredentials operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceConnectorTerminationCredentials operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVoiceConnectorTerminationCredentials
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteVoiceConnectorTerminationCredentials">REST API Reference for DeleteVoiceConnectorTerminationCredentials Operation</seealso>
        [Obsolete("Replaced by DeleteVoiceConnectorTerminationCredentials in the Amazon Chime SDK Voice Namespace")]
        IAsyncResult BeginDeleteVoiceConnectorTerminationCredentials(DeleteVoiceConnectorTerminationCredentialsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVoiceConnectorTerminationCredentials operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVoiceConnectorTerminationCredentials.</param>
        /// 
        /// <returns>Returns a  DeleteVoiceConnectorTerminationCredentialsResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteVoiceConnectorTerminationCredentials">REST API Reference for DeleteVoiceConnectorTerminationCredentials Operation</seealso>
        [Obsolete("Replaced by DeleteVoiceConnectorTerminationCredentials in the Amazon Chime SDK Voice Namespace")]
        DeleteVoiceConnectorTerminationCredentialsResponse EndDeleteVoiceConnectorTerminationCredentials(IAsyncResult asyncResult);

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
        DescribeAppInstanceResponse DescribeAppInstance(DescribeAppInstanceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAppInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAppInstance operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAppInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DescribeAppInstance">REST API Reference for DescribeAppInstance Operation</seealso>
        [Obsolete("Replaced by DescribeAppInstance in the Amazon Chime SDK Identity Namespace")]
        IAsyncResult BeginDescribeAppInstance(DescribeAppInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAppInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAppInstance.</param>
        /// 
        /// <returns>Returns a  DescribeAppInstanceResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DescribeAppInstance">REST API Reference for DescribeAppInstance Operation</seealso>
        [Obsolete("Replaced by DescribeAppInstance in the Amazon Chime SDK Identity Namespace")]
        DescribeAppInstanceResponse EndDescribeAppInstance(IAsyncResult asyncResult);

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
        DescribeAppInstanceAdminResponse DescribeAppInstanceAdmin(DescribeAppInstanceAdminRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAppInstanceAdmin operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAppInstanceAdmin operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAppInstanceAdmin
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DescribeAppInstanceAdmin">REST API Reference for DescribeAppInstanceAdmin Operation</seealso>
        [Obsolete("Replaced by DescribeAppInstanceAdmin in the Amazon Chime SDK Identity Namespace")]
        IAsyncResult BeginDescribeAppInstanceAdmin(DescribeAppInstanceAdminRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAppInstanceAdmin operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAppInstanceAdmin.</param>
        /// 
        /// <returns>Returns a  DescribeAppInstanceAdminResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DescribeAppInstanceAdmin">REST API Reference for DescribeAppInstanceAdmin Operation</seealso>
        [Obsolete("Replaced by DescribeAppInstanceAdmin in the Amazon Chime SDK Identity Namespace")]
        DescribeAppInstanceAdminResponse EndDescribeAppInstanceAdmin(IAsyncResult asyncResult);

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
        DescribeAppInstanceUserResponse DescribeAppInstanceUser(DescribeAppInstanceUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAppInstanceUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAppInstanceUser operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAppInstanceUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DescribeAppInstanceUser">REST API Reference for DescribeAppInstanceUser Operation</seealso>
        [Obsolete("Replaced by DescribeAppInstanceUser in the Amazon Chime SDK Identity Namespace")]
        IAsyncResult BeginDescribeAppInstanceUser(DescribeAppInstanceUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAppInstanceUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAppInstanceUser.</param>
        /// 
        /// <returns>Returns a  DescribeAppInstanceUserResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DescribeAppInstanceUser">REST API Reference for DescribeAppInstanceUser Operation</seealso>
        [Obsolete("Replaced by DescribeAppInstanceUser in the Amazon Chime SDK Identity Namespace")]
        DescribeAppInstanceUserResponse EndDescribeAppInstanceUser(IAsyncResult asyncResult);

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
        DescribeChannelResponse DescribeChannel(DescribeChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeChannel operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DescribeChannel">REST API Reference for DescribeChannel Operation</seealso>
        [Obsolete("Replaced by DescribeChannel in the Amazon Chime SDK Messaging Namespace")]
        IAsyncResult BeginDescribeChannel(DescribeChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeChannel.</param>
        /// 
        /// <returns>Returns a  DescribeChannelResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DescribeChannel">REST API Reference for DescribeChannel Operation</seealso>
        [Obsolete("Replaced by DescribeChannel in the Amazon Chime SDK Messaging Namespace")]
        DescribeChannelResponse EndDescribeChannel(IAsyncResult asyncResult);

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
        DescribeChannelBanResponse DescribeChannelBan(DescribeChannelBanRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeChannelBan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeChannelBan operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeChannelBan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DescribeChannelBan">REST API Reference for DescribeChannelBan Operation</seealso>
        [Obsolete("Replaced by DescribeChannelBan in the Amazon Chime SDK Messaging Namespace")]
        IAsyncResult BeginDescribeChannelBan(DescribeChannelBanRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeChannelBan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeChannelBan.</param>
        /// 
        /// <returns>Returns a  DescribeChannelBanResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DescribeChannelBan">REST API Reference for DescribeChannelBan Operation</seealso>
        [Obsolete("Replaced by DescribeChannelBan in the Amazon Chime SDK Messaging Namespace")]
        DescribeChannelBanResponse EndDescribeChannelBan(IAsyncResult asyncResult);

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
        DescribeChannelMembershipResponse DescribeChannelMembership(DescribeChannelMembershipRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeChannelMembership operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeChannelMembership operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeChannelMembership
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DescribeChannelMembership">REST API Reference for DescribeChannelMembership Operation</seealso>
        [Obsolete("Replaced by DescribeChannelMembership in the Amazon Chime SDK Messaging Namespace")]
        IAsyncResult BeginDescribeChannelMembership(DescribeChannelMembershipRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeChannelMembership operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeChannelMembership.</param>
        /// 
        /// <returns>Returns a  DescribeChannelMembershipResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DescribeChannelMembership">REST API Reference for DescribeChannelMembership Operation</seealso>
        [Obsolete("Replaced by DescribeChannelMembership in the Amazon Chime SDK Messaging Namespace")]
        DescribeChannelMembershipResponse EndDescribeChannelMembership(IAsyncResult asyncResult);

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
        DescribeChannelMembershipForAppInstanceUserResponse DescribeChannelMembershipForAppInstanceUser(DescribeChannelMembershipForAppInstanceUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeChannelMembershipForAppInstanceUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeChannelMembershipForAppInstanceUser operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeChannelMembershipForAppInstanceUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DescribeChannelMembershipForAppInstanceUser">REST API Reference for DescribeChannelMembershipForAppInstanceUser Operation</seealso>
        [Obsolete("Replaced by DescribeChannelMembershipForAppInstanceUser in the Amazon Chime SDK Messaging Namespace")]
        IAsyncResult BeginDescribeChannelMembershipForAppInstanceUser(DescribeChannelMembershipForAppInstanceUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeChannelMembershipForAppInstanceUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeChannelMembershipForAppInstanceUser.</param>
        /// 
        /// <returns>Returns a  DescribeChannelMembershipForAppInstanceUserResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DescribeChannelMembershipForAppInstanceUser">REST API Reference for DescribeChannelMembershipForAppInstanceUser Operation</seealso>
        [Obsolete("Replaced by DescribeChannelMembershipForAppInstanceUser in the Amazon Chime SDK Messaging Namespace")]
        DescribeChannelMembershipForAppInstanceUserResponse EndDescribeChannelMembershipForAppInstanceUser(IAsyncResult asyncResult);

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
        DescribeChannelModeratedByAppInstanceUserResponse DescribeChannelModeratedByAppInstanceUser(DescribeChannelModeratedByAppInstanceUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeChannelModeratedByAppInstanceUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeChannelModeratedByAppInstanceUser operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeChannelModeratedByAppInstanceUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DescribeChannelModeratedByAppInstanceUser">REST API Reference for DescribeChannelModeratedByAppInstanceUser Operation</seealso>
        [Obsolete("Replaced by DescribeChannelModeratedByAppInstanceUser in the Amazon Chime SDK Messaging Namespace")]
        IAsyncResult BeginDescribeChannelModeratedByAppInstanceUser(DescribeChannelModeratedByAppInstanceUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeChannelModeratedByAppInstanceUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeChannelModeratedByAppInstanceUser.</param>
        /// 
        /// <returns>Returns a  DescribeChannelModeratedByAppInstanceUserResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DescribeChannelModeratedByAppInstanceUser">REST API Reference for DescribeChannelModeratedByAppInstanceUser Operation</seealso>
        [Obsolete("Replaced by DescribeChannelModeratedByAppInstanceUser in the Amazon Chime SDK Messaging Namespace")]
        DescribeChannelModeratedByAppInstanceUserResponse EndDescribeChannelModeratedByAppInstanceUser(IAsyncResult asyncResult);

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
        DescribeChannelModeratorResponse DescribeChannelModerator(DescribeChannelModeratorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeChannelModerator operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeChannelModerator operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeChannelModerator
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DescribeChannelModerator">REST API Reference for DescribeChannelModerator Operation</seealso>
        [Obsolete("Replaced by DescribeChannelModerator in the Amazon Chime SDK Messaging Namespace")]
        IAsyncResult BeginDescribeChannelModerator(DescribeChannelModeratorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeChannelModerator operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeChannelModerator.</param>
        /// 
        /// <returns>Returns a  DescribeChannelModeratorResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DescribeChannelModerator">REST API Reference for DescribeChannelModerator Operation</seealso>
        [Obsolete("Replaced by DescribeChannelModerator in the Amazon Chime SDK Messaging Namespace")]
        DescribeChannelModeratorResponse EndDescribeChannelModerator(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociatePhoneNumberFromUser


        /// <summary>
        /// Disassociates the primary provisioned phone number from the specified Amazon Chime
        /// user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociatePhoneNumberFromUser service method.</param>
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
        DisassociatePhoneNumberFromUserResponse DisassociatePhoneNumberFromUser(DisassociatePhoneNumberFromUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociatePhoneNumberFromUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociatePhoneNumberFromUser operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociatePhoneNumberFromUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DisassociatePhoneNumberFromUser">REST API Reference for DisassociatePhoneNumberFromUser Operation</seealso>
        IAsyncResult BeginDisassociatePhoneNumberFromUser(DisassociatePhoneNumberFromUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociatePhoneNumberFromUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociatePhoneNumberFromUser.</param>
        /// 
        /// <returns>Returns a  DisassociatePhoneNumberFromUserResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DisassociatePhoneNumberFromUser">REST API Reference for DisassociatePhoneNumberFromUser Operation</seealso>
        DisassociatePhoneNumberFromUserResponse EndDisassociatePhoneNumberFromUser(IAsyncResult asyncResult);

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
        DisassociatePhoneNumbersFromVoiceConnectorResponse DisassociatePhoneNumbersFromVoiceConnector(DisassociatePhoneNumbersFromVoiceConnectorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociatePhoneNumbersFromVoiceConnector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociatePhoneNumbersFromVoiceConnector operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociatePhoneNumbersFromVoiceConnector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DisassociatePhoneNumbersFromVoiceConnector">REST API Reference for DisassociatePhoneNumbersFromVoiceConnector Operation</seealso>
        [Obsolete("Replaced by DisassociatePhoneNumbersFromVoiceConnector in the Amazon Chime SDK Voice Namespace")]
        IAsyncResult BeginDisassociatePhoneNumbersFromVoiceConnector(DisassociatePhoneNumbersFromVoiceConnectorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociatePhoneNumbersFromVoiceConnector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociatePhoneNumbersFromVoiceConnector.</param>
        /// 
        /// <returns>Returns a  DisassociatePhoneNumbersFromVoiceConnectorResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DisassociatePhoneNumbersFromVoiceConnector">REST API Reference for DisassociatePhoneNumbersFromVoiceConnector Operation</seealso>
        [Obsolete("Replaced by DisassociatePhoneNumbersFromVoiceConnector in the Amazon Chime SDK Voice Namespace")]
        DisassociatePhoneNumbersFromVoiceConnectorResponse EndDisassociatePhoneNumbersFromVoiceConnector(IAsyncResult asyncResult);

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
        DisassociatePhoneNumbersFromVoiceConnectorGroupResponse DisassociatePhoneNumbersFromVoiceConnectorGroup(DisassociatePhoneNumbersFromVoiceConnectorGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociatePhoneNumbersFromVoiceConnectorGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociatePhoneNumbersFromVoiceConnectorGroup operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociatePhoneNumbersFromVoiceConnectorGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DisassociatePhoneNumbersFromVoiceConnectorGroup">REST API Reference for DisassociatePhoneNumbersFromVoiceConnectorGroup Operation</seealso>
        [Obsolete("Replaced by DisassociatePhoneNumbersFromVoiceConnectorGroup in the Amazon Chime SDK Voice Namespace")]
        IAsyncResult BeginDisassociatePhoneNumbersFromVoiceConnectorGroup(DisassociatePhoneNumbersFromVoiceConnectorGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociatePhoneNumbersFromVoiceConnectorGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociatePhoneNumbersFromVoiceConnectorGroup.</param>
        /// 
        /// <returns>Returns a  DisassociatePhoneNumbersFromVoiceConnectorGroupResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DisassociatePhoneNumbersFromVoiceConnectorGroup">REST API Reference for DisassociatePhoneNumbersFromVoiceConnectorGroup Operation</seealso>
        [Obsolete("Replaced by DisassociatePhoneNumbersFromVoiceConnectorGroup in the Amazon Chime SDK Voice Namespace")]
        DisassociatePhoneNumbersFromVoiceConnectorGroupResponse EndDisassociatePhoneNumbersFromVoiceConnectorGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateSigninDelegateGroupsFromAccount


        /// <summary>
        /// Disassociates the specified sign-in delegate groups from the specified Amazon Chime
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateSigninDelegateGroupsFromAccount service method.</param>
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
        DisassociateSigninDelegateGroupsFromAccountResponse DisassociateSigninDelegateGroupsFromAccount(DisassociateSigninDelegateGroupsFromAccountRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateSigninDelegateGroupsFromAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateSigninDelegateGroupsFromAccount operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateSigninDelegateGroupsFromAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DisassociateSigninDelegateGroupsFromAccount">REST API Reference for DisassociateSigninDelegateGroupsFromAccount Operation</seealso>
        IAsyncResult BeginDisassociateSigninDelegateGroupsFromAccount(DisassociateSigninDelegateGroupsFromAccountRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateSigninDelegateGroupsFromAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateSigninDelegateGroupsFromAccount.</param>
        /// 
        /// <returns>Returns a  DisassociateSigninDelegateGroupsFromAccountResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DisassociateSigninDelegateGroupsFromAccount">REST API Reference for DisassociateSigninDelegateGroupsFromAccount Operation</seealso>
        DisassociateSigninDelegateGroupsFromAccountResponse EndDisassociateSigninDelegateGroupsFromAccount(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAccount


        /// <summary>
        /// Retrieves details for the specified Amazon Chime account, such as account type and
        /// supported licenses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccount service method.</param>
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
        GetAccountResponse GetAccount(GetAccountRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccount operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetAccount">REST API Reference for GetAccount Operation</seealso>
        IAsyncResult BeginGetAccount(GetAccountRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAccount.</param>
        /// 
        /// <returns>Returns a  GetAccountResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetAccount">REST API Reference for GetAccount Operation</seealso>
        GetAccountResponse EndGetAccount(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAccountSettings


        /// <summary>
        /// Retrieves account settings for the specified Amazon Chime account ID, such as remote
        /// control and dialout settings. For more information about these settings, see <a href="https://docs.aws.amazon.com/chime/latest/ag/policies.html">Use
        /// the Policies Page</a> in the <i>Amazon Chime Administration Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccountSettings service method.</param>
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
        GetAccountSettingsResponse GetAccountSettings(GetAccountSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAccountSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccountSettings operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAccountSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetAccountSettings">REST API Reference for GetAccountSettings Operation</seealso>
        IAsyncResult BeginGetAccountSettings(GetAccountSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAccountSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAccountSettings.</param>
        /// 
        /// <returns>Returns a  GetAccountSettingsResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetAccountSettings">REST API Reference for GetAccountSettings Operation</seealso>
        GetAccountSettingsResponse EndGetAccountSettings(IAsyncResult asyncResult);

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
        GetAppInstanceRetentionSettingsResponse GetAppInstanceRetentionSettings(GetAppInstanceRetentionSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAppInstanceRetentionSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAppInstanceRetentionSettings operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAppInstanceRetentionSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetAppInstanceRetentionSettings">REST API Reference for GetAppInstanceRetentionSettings Operation</seealso>
        [Obsolete("Replaced by GetAppInstanceRetentionSettings in the Amazon Chime SDK Identity Namespace")]
        IAsyncResult BeginGetAppInstanceRetentionSettings(GetAppInstanceRetentionSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAppInstanceRetentionSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAppInstanceRetentionSettings.</param>
        /// 
        /// <returns>Returns a  GetAppInstanceRetentionSettingsResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetAppInstanceRetentionSettings">REST API Reference for GetAppInstanceRetentionSettings Operation</seealso>
        [Obsolete("Replaced by GetAppInstanceRetentionSettings in the Amazon Chime SDK Identity Namespace")]
        GetAppInstanceRetentionSettingsResponse EndGetAppInstanceRetentionSettings(IAsyncResult asyncResult);

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
        GetAppInstanceStreamingConfigurationsResponse GetAppInstanceStreamingConfigurations(GetAppInstanceStreamingConfigurationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAppInstanceStreamingConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAppInstanceStreamingConfigurations operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAppInstanceStreamingConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetAppInstanceStreamingConfigurations">REST API Reference for GetAppInstanceStreamingConfigurations Operation</seealso>
        [Obsolete("Replaced by GetAppInstanceStreamingConfigurations in the Amazon Chime SDK Messaging Namespace")]
        IAsyncResult BeginGetAppInstanceStreamingConfigurations(GetAppInstanceStreamingConfigurationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAppInstanceStreamingConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAppInstanceStreamingConfigurations.</param>
        /// 
        /// <returns>Returns a  GetAppInstanceStreamingConfigurationsResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetAppInstanceStreamingConfigurations">REST API Reference for GetAppInstanceStreamingConfigurations Operation</seealso>
        [Obsolete("Replaced by GetAppInstanceStreamingConfigurations in the Amazon Chime SDK Messaging Namespace")]
        GetAppInstanceStreamingConfigurationsResponse EndGetAppInstanceStreamingConfigurations(IAsyncResult asyncResult);

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
        GetAttendeeResponse GetAttendee(GetAttendeeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAttendee operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAttendee operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAttendee
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetAttendee">REST API Reference for GetAttendee Operation</seealso>
        [Obsolete("Replaced by GetAttendee in the Amazon Chime SDK Meetings Namespace")]
        IAsyncResult BeginGetAttendee(GetAttendeeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAttendee operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAttendee.</param>
        /// 
        /// <returns>Returns a  GetAttendeeResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetAttendee">REST API Reference for GetAttendee Operation</seealso>
        [Obsolete("Replaced by GetAttendee in the Amazon Chime SDK Meetings Namespace")]
        GetAttendeeResponse EndGetAttendee(IAsyncResult asyncResult);

        #endregion
        
        #region  GetBot


        /// <summary>
        /// Retrieves details for the specified bot, such as bot email address, bot type, status,
        /// and display name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBot service method.</param>
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
        GetBotResponse GetBot(GetBotRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetBot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBot operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetBot">REST API Reference for GetBot Operation</seealso>
        IAsyncResult BeginGetBot(GetBotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetBot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBot.</param>
        /// 
        /// <returns>Returns a  GetBotResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetBot">REST API Reference for GetBot Operation</seealso>
        GetBotResponse EndGetBot(IAsyncResult asyncResult);

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
        GetChannelMessageResponse GetChannelMessage(GetChannelMessageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetChannelMessage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetChannelMessage operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetChannelMessage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetChannelMessage">REST API Reference for GetChannelMessage Operation</seealso>
        [Obsolete("Replaced by GetChannelMessage in the Amazon Chime SDK Messaging Namespace")]
        IAsyncResult BeginGetChannelMessage(GetChannelMessageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetChannelMessage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetChannelMessage.</param>
        /// 
        /// <returns>Returns a  GetChannelMessageResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetChannelMessage">REST API Reference for GetChannelMessage Operation</seealso>
        [Obsolete("Replaced by GetChannelMessage in the Amazon Chime SDK Messaging Namespace")]
        GetChannelMessageResponse EndGetChannelMessage(IAsyncResult asyncResult);

        #endregion
        
        #region  GetEventsConfiguration


        /// <summary>
        /// Gets details for an events configuration that allows a bot to receive outgoing events,
        /// such as an HTTPS endpoint or Lambda function ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEventsConfiguration service method.</param>
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
        GetEventsConfigurationResponse GetEventsConfiguration(GetEventsConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetEventsConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEventsConfiguration operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEventsConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetEventsConfiguration">REST API Reference for GetEventsConfiguration Operation</seealso>
        IAsyncResult BeginGetEventsConfiguration(GetEventsConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetEventsConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEventsConfiguration.</param>
        /// 
        /// <returns>Returns a  GetEventsConfigurationResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetEventsConfiguration">REST API Reference for GetEventsConfiguration Operation</seealso>
        GetEventsConfigurationResponse EndGetEventsConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  GetGlobalSettings


        /// <summary>
        /// Retrieves global settings for the administrator's AWS account, such as Amazon Chime
        /// Business Calling and Amazon Chime Voice Connector settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGlobalSettings service method.</param>
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
        GetGlobalSettingsResponse GetGlobalSettings(GetGlobalSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetGlobalSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGlobalSettings operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetGlobalSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetGlobalSettings">REST API Reference for GetGlobalSettings Operation</seealso>
        IAsyncResult BeginGetGlobalSettings(GetGlobalSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetGlobalSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGlobalSettings.</param>
        /// 
        /// <returns>Returns a  GetGlobalSettingsResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetGlobalSettings">REST API Reference for GetGlobalSettings Operation</seealso>
        GetGlobalSettingsResponse EndGetGlobalSettings(IAsyncResult asyncResult);

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
        GetMediaCapturePipelineResponse GetMediaCapturePipeline(GetMediaCapturePipelineRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetMediaCapturePipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMediaCapturePipeline operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMediaCapturePipeline
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetMediaCapturePipeline">REST API Reference for GetMediaCapturePipeline Operation</seealso>
        [Obsolete("Replaced by GetMediaCapturePipeline in the Amazon Chime SDK Media Pipelines Namespace")]
        IAsyncResult BeginGetMediaCapturePipeline(GetMediaCapturePipelineRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetMediaCapturePipeline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMediaCapturePipeline.</param>
        /// 
        /// <returns>Returns a  GetMediaCapturePipelineResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetMediaCapturePipeline">REST API Reference for GetMediaCapturePipeline Operation</seealso>
        [Obsolete("Replaced by GetMediaCapturePipeline in the Amazon Chime SDK Media Pipelines Namespace")]
        GetMediaCapturePipelineResponse EndGetMediaCapturePipeline(IAsyncResult asyncResult);

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
        GetMeetingResponse GetMeeting(GetMeetingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetMeeting operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMeeting operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMeeting
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetMeeting">REST API Reference for GetMeeting Operation</seealso>
        [Obsolete("Replaced by GetMeeting in the Amazon Chime SDK Meetings Namespace")]
        IAsyncResult BeginGetMeeting(GetMeetingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetMeeting operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMeeting.</param>
        /// 
        /// <returns>Returns a  GetMeetingResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetMeeting">REST API Reference for GetMeeting Operation</seealso>
        [Obsolete("Replaced by GetMeeting in the Amazon Chime SDK Meetings Namespace")]
        GetMeetingResponse EndGetMeeting(IAsyncResult asyncResult);

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
        GetMessagingSessionEndpointResponse GetMessagingSessionEndpoint(GetMessagingSessionEndpointRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetMessagingSessionEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMessagingSessionEndpoint operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMessagingSessionEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetMessagingSessionEndpoint">REST API Reference for GetMessagingSessionEndpoint Operation</seealso>
        [Obsolete("Replaced by GetMessagingSessionEndpoint in the Amazon Chime SDK Messaging Namespace")]
        IAsyncResult BeginGetMessagingSessionEndpoint(GetMessagingSessionEndpointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetMessagingSessionEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMessagingSessionEndpoint.</param>
        /// 
        /// <returns>Returns a  GetMessagingSessionEndpointResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetMessagingSessionEndpoint">REST API Reference for GetMessagingSessionEndpoint Operation</seealso>
        [Obsolete("Replaced by GetMessagingSessionEndpoint in the Amazon Chime SDK Messaging Namespace")]
        GetMessagingSessionEndpointResponse EndGetMessagingSessionEndpoint(IAsyncResult asyncResult);

        #endregion
        
        #region  GetPhoneNumber


        /// <summary>
        /// Retrieves details for the specified phone number ID, such as associations, capabilities,
        /// and product type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPhoneNumber service method.</param>
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
        GetPhoneNumberResponse GetPhoneNumber(GetPhoneNumberRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetPhoneNumber operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPhoneNumber operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPhoneNumber
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetPhoneNumber">REST API Reference for GetPhoneNumber Operation</seealso>
        IAsyncResult BeginGetPhoneNumber(GetPhoneNumberRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetPhoneNumber operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPhoneNumber.</param>
        /// 
        /// <returns>Returns a  GetPhoneNumberResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetPhoneNumber">REST API Reference for GetPhoneNumber Operation</seealso>
        GetPhoneNumberResponse EndGetPhoneNumber(IAsyncResult asyncResult);

        #endregion
        
        #region  GetPhoneNumberOrder


        /// <summary>
        /// Retrieves details for the specified phone number order, such as the order creation
        /// timestamp, phone numbers in E.164 format, product type, and order status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPhoneNumberOrder service method.</param>
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
        GetPhoneNumberOrderResponse GetPhoneNumberOrder(GetPhoneNumberOrderRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetPhoneNumberOrder operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPhoneNumberOrder operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPhoneNumberOrder
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetPhoneNumberOrder">REST API Reference for GetPhoneNumberOrder Operation</seealso>
        IAsyncResult BeginGetPhoneNumberOrder(GetPhoneNumberOrderRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetPhoneNumberOrder operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPhoneNumberOrder.</param>
        /// 
        /// <returns>Returns a  GetPhoneNumberOrderResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetPhoneNumberOrder">REST API Reference for GetPhoneNumberOrder Operation</seealso>
        GetPhoneNumberOrderResponse EndGetPhoneNumberOrder(IAsyncResult asyncResult);

        #endregion
        
        #region  GetPhoneNumberSettings


        /// <summary>
        /// Retrieves the phone number settings for the administrator's AWS account, such as the
        /// default outbound calling name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPhoneNumberSettings service method.</param>
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
        GetPhoneNumberSettingsResponse GetPhoneNumberSettings(GetPhoneNumberSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetPhoneNumberSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPhoneNumberSettings operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPhoneNumberSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetPhoneNumberSettings">REST API Reference for GetPhoneNumberSettings Operation</seealso>
        IAsyncResult BeginGetPhoneNumberSettings(GetPhoneNumberSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetPhoneNumberSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPhoneNumberSettings.</param>
        /// 
        /// <returns>Returns a  GetPhoneNumberSettingsResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetPhoneNumberSettings">REST API Reference for GetPhoneNumberSettings Operation</seealso>
        GetPhoneNumberSettingsResponse EndGetPhoneNumberSettings(IAsyncResult asyncResult);

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
        GetProxySessionResponse GetProxySession(GetProxySessionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetProxySession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetProxySession operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetProxySession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetProxySession">REST API Reference for GetProxySession Operation</seealso>
        [Obsolete("Replaced by GetProxySession in the Amazon Chime SDK Voice Namespace")]
        IAsyncResult BeginGetProxySession(GetProxySessionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetProxySession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetProxySession.</param>
        /// 
        /// <returns>Returns a  GetProxySessionResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetProxySession">REST API Reference for GetProxySession Operation</seealso>
        [Obsolete("Replaced by GetProxySession in the Amazon Chime SDK Voice Namespace")]
        GetProxySessionResponse EndGetProxySession(IAsyncResult asyncResult);

        #endregion
        
        #region  GetRetentionSettings


        /// <summary>
        /// Gets the retention settings for the specified Amazon Chime Enterprise account. For
        /// more information about retention settings, see <a href="https://docs.aws.amazon.com/chime/latest/ag/chat-retention.html">Managing
        /// Chat Retention Policies</a> in the <i>Amazon Chime Administration Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRetentionSettings service method.</param>
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
        GetRetentionSettingsResponse GetRetentionSettings(GetRetentionSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetRetentionSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRetentionSettings operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRetentionSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetRetentionSettings">REST API Reference for GetRetentionSettings Operation</seealso>
        IAsyncResult BeginGetRetentionSettings(GetRetentionSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRetentionSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRetentionSettings.</param>
        /// 
        /// <returns>Returns a  GetRetentionSettingsResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetRetentionSettings">REST API Reference for GetRetentionSettings Operation</seealso>
        GetRetentionSettingsResponse EndGetRetentionSettings(IAsyncResult asyncResult);

        #endregion
        
        #region  GetRoom


        /// <summary>
        /// Retrieves room details, such as the room name, for a room in an Amazon Chime Enterprise
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRoom service method.</param>
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
        GetRoomResponse GetRoom(GetRoomRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetRoom operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRoom operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRoom
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetRoom">REST API Reference for GetRoom Operation</seealso>
        IAsyncResult BeginGetRoom(GetRoomRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRoom operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRoom.</param>
        /// 
        /// <returns>Returns a  GetRoomResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetRoom">REST API Reference for GetRoom Operation</seealso>
        GetRoomResponse EndGetRoom(IAsyncResult asyncResult);

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
        GetSipMediaApplicationResponse GetSipMediaApplication(GetSipMediaApplicationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSipMediaApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSipMediaApplication operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSipMediaApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetSipMediaApplication">REST API Reference for GetSipMediaApplication Operation</seealso>
        [Obsolete("Replaced by GetSipMediaApplication in the Amazon Chime SDK Voice Namespace")]
        IAsyncResult BeginGetSipMediaApplication(GetSipMediaApplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSipMediaApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSipMediaApplication.</param>
        /// 
        /// <returns>Returns a  GetSipMediaApplicationResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetSipMediaApplication">REST API Reference for GetSipMediaApplication Operation</seealso>
        [Obsolete("Replaced by GetSipMediaApplication in the Amazon Chime SDK Voice Namespace")]
        GetSipMediaApplicationResponse EndGetSipMediaApplication(IAsyncResult asyncResult);

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
        GetSipMediaApplicationLoggingConfigurationResponse GetSipMediaApplicationLoggingConfiguration(GetSipMediaApplicationLoggingConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSipMediaApplicationLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSipMediaApplicationLoggingConfiguration operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSipMediaApplicationLoggingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetSipMediaApplicationLoggingConfiguration">REST API Reference for GetSipMediaApplicationLoggingConfiguration Operation</seealso>
        [Obsolete("Replaced by GetSipMediaApplicationLoggingConfiguration in the Amazon Chime SDK Voice Namespace")]
        IAsyncResult BeginGetSipMediaApplicationLoggingConfiguration(GetSipMediaApplicationLoggingConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSipMediaApplicationLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSipMediaApplicationLoggingConfiguration.</param>
        /// 
        /// <returns>Returns a  GetSipMediaApplicationLoggingConfigurationResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetSipMediaApplicationLoggingConfiguration">REST API Reference for GetSipMediaApplicationLoggingConfiguration Operation</seealso>
        [Obsolete("Replaced by GetSipMediaApplicationLoggingConfiguration in the Amazon Chime SDK Voice Namespace")]
        GetSipMediaApplicationLoggingConfigurationResponse EndGetSipMediaApplicationLoggingConfiguration(IAsyncResult asyncResult);

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
        GetSipRuleResponse GetSipRule(GetSipRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSipRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSipRule operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSipRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetSipRule">REST API Reference for GetSipRule Operation</seealso>
        [Obsolete("Replaced by GetSipRule in the Amazon Chime SDK Voice Namespace")]
        IAsyncResult BeginGetSipRule(GetSipRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSipRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSipRule.</param>
        /// 
        /// <returns>Returns a  GetSipRuleResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetSipRule">REST API Reference for GetSipRule Operation</seealso>
        [Obsolete("Replaced by GetSipRule in the Amazon Chime SDK Voice Namespace")]
        GetSipRuleResponse EndGetSipRule(IAsyncResult asyncResult);

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
        GetUserResponse GetUser(GetUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUser operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetUser">REST API Reference for GetUser Operation</seealso>
        IAsyncResult BeginGetUser(GetUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUser.</param>
        /// 
        /// <returns>Returns a  GetUserResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetUser">REST API Reference for GetUser Operation</seealso>
        GetUserResponse EndGetUser(IAsyncResult asyncResult);

        #endregion
        
        #region  GetUserSettings


        /// <summary>
        /// Retrieves settings for the specified user ID, such as any associated phone number
        /// settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUserSettings service method.</param>
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
        GetUserSettingsResponse GetUserSettings(GetUserSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetUserSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUserSettings operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetUserSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetUserSettings">REST API Reference for GetUserSettings Operation</seealso>
        IAsyncResult BeginGetUserSettings(GetUserSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetUserSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUserSettings.</param>
        /// 
        /// <returns>Returns a  GetUserSettingsResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetUserSettings">REST API Reference for GetUserSettings Operation</seealso>
        GetUserSettingsResponse EndGetUserSettings(IAsyncResult asyncResult);

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
        GetVoiceConnectorResponse GetVoiceConnector(GetVoiceConnectorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetVoiceConnector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnector operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVoiceConnector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetVoiceConnector">REST API Reference for GetVoiceConnector Operation</seealso>
        [Obsolete("Replaced by GetVoiceConnector in the Amazon Chime SDK Voice Namespace")]
        IAsyncResult BeginGetVoiceConnector(GetVoiceConnectorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetVoiceConnector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVoiceConnector.</param>
        /// 
        /// <returns>Returns a  GetVoiceConnectorResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetVoiceConnector">REST API Reference for GetVoiceConnector Operation</seealso>
        [Obsolete("Replaced by GetVoiceConnector in the Amazon Chime SDK Voice Namespace")]
        GetVoiceConnectorResponse EndGetVoiceConnector(IAsyncResult asyncResult);

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
        GetVoiceConnectorEmergencyCallingConfigurationResponse GetVoiceConnectorEmergencyCallingConfiguration(GetVoiceConnectorEmergencyCallingConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetVoiceConnectorEmergencyCallingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnectorEmergencyCallingConfiguration operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVoiceConnectorEmergencyCallingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetVoiceConnectorEmergencyCallingConfiguration">REST API Reference for GetVoiceConnectorEmergencyCallingConfiguration Operation</seealso>
        [Obsolete("Replaced by GetVoiceConnectorEmergencyCallingConfiguration in the Amazon Chime SDK Voice Namespace")]
        IAsyncResult BeginGetVoiceConnectorEmergencyCallingConfiguration(GetVoiceConnectorEmergencyCallingConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetVoiceConnectorEmergencyCallingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVoiceConnectorEmergencyCallingConfiguration.</param>
        /// 
        /// <returns>Returns a  GetVoiceConnectorEmergencyCallingConfigurationResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetVoiceConnectorEmergencyCallingConfiguration">REST API Reference for GetVoiceConnectorEmergencyCallingConfiguration Operation</seealso>
        [Obsolete("Replaced by GetVoiceConnectorEmergencyCallingConfiguration in the Amazon Chime SDK Voice Namespace")]
        GetVoiceConnectorEmergencyCallingConfigurationResponse EndGetVoiceConnectorEmergencyCallingConfiguration(IAsyncResult asyncResult);

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
        GetVoiceConnectorGroupResponse GetVoiceConnectorGroup(GetVoiceConnectorGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetVoiceConnectorGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnectorGroup operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVoiceConnectorGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetVoiceConnectorGroup">REST API Reference for GetVoiceConnectorGroup Operation</seealso>
        [Obsolete("Replaced by GetVoiceConnectorGroup in the Amazon Chime SDK Voice Namespace")]
        IAsyncResult BeginGetVoiceConnectorGroup(GetVoiceConnectorGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetVoiceConnectorGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVoiceConnectorGroup.</param>
        /// 
        /// <returns>Returns a  GetVoiceConnectorGroupResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetVoiceConnectorGroup">REST API Reference for GetVoiceConnectorGroup Operation</seealso>
        [Obsolete("Replaced by GetVoiceConnectorGroup in the Amazon Chime SDK Voice Namespace")]
        GetVoiceConnectorGroupResponse EndGetVoiceConnectorGroup(IAsyncResult asyncResult);

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
        GetVoiceConnectorLoggingConfigurationResponse GetVoiceConnectorLoggingConfiguration(GetVoiceConnectorLoggingConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetVoiceConnectorLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnectorLoggingConfiguration operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVoiceConnectorLoggingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetVoiceConnectorLoggingConfiguration">REST API Reference for GetVoiceConnectorLoggingConfiguration Operation</seealso>
        [Obsolete("Replaced by GetVoiceConnectorLoggingConfiguration in the Amazon Chime SDK Voice Namespace")]
        IAsyncResult BeginGetVoiceConnectorLoggingConfiguration(GetVoiceConnectorLoggingConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetVoiceConnectorLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVoiceConnectorLoggingConfiguration.</param>
        /// 
        /// <returns>Returns a  GetVoiceConnectorLoggingConfigurationResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetVoiceConnectorLoggingConfiguration">REST API Reference for GetVoiceConnectorLoggingConfiguration Operation</seealso>
        [Obsolete("Replaced by GetVoiceConnectorLoggingConfiguration in the Amazon Chime SDK Voice Namespace")]
        GetVoiceConnectorLoggingConfigurationResponse EndGetVoiceConnectorLoggingConfiguration(IAsyncResult asyncResult);

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
        GetVoiceConnectorOriginationResponse GetVoiceConnectorOrigination(GetVoiceConnectorOriginationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetVoiceConnectorOrigination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnectorOrigination operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVoiceConnectorOrigination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetVoiceConnectorOrigination">REST API Reference for GetVoiceConnectorOrigination Operation</seealso>
        [Obsolete("Replaced by GetVoiceConnectorOrigination in the Amazon Chime SDK Voice Namespace")]
        IAsyncResult BeginGetVoiceConnectorOrigination(GetVoiceConnectorOriginationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetVoiceConnectorOrigination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVoiceConnectorOrigination.</param>
        /// 
        /// <returns>Returns a  GetVoiceConnectorOriginationResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetVoiceConnectorOrigination">REST API Reference for GetVoiceConnectorOrigination Operation</seealso>
        [Obsolete("Replaced by GetVoiceConnectorOrigination in the Amazon Chime SDK Voice Namespace")]
        GetVoiceConnectorOriginationResponse EndGetVoiceConnectorOrigination(IAsyncResult asyncResult);

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
        GetVoiceConnectorProxyResponse GetVoiceConnectorProxy(GetVoiceConnectorProxyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetVoiceConnectorProxy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnectorProxy operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVoiceConnectorProxy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetVoiceConnectorProxy">REST API Reference for GetVoiceConnectorProxy Operation</seealso>
        [Obsolete("Replaced by GetVoiceConnectorProxy in the Amazon Chime SDK Voice Namespace")]
        IAsyncResult BeginGetVoiceConnectorProxy(GetVoiceConnectorProxyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetVoiceConnectorProxy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVoiceConnectorProxy.</param>
        /// 
        /// <returns>Returns a  GetVoiceConnectorProxyResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetVoiceConnectorProxy">REST API Reference for GetVoiceConnectorProxy Operation</seealso>
        [Obsolete("Replaced by GetVoiceConnectorProxy in the Amazon Chime SDK Voice Namespace")]
        GetVoiceConnectorProxyResponse EndGetVoiceConnectorProxy(IAsyncResult asyncResult);

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
        GetVoiceConnectorStreamingConfigurationResponse GetVoiceConnectorStreamingConfiguration(GetVoiceConnectorStreamingConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetVoiceConnectorStreamingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnectorStreamingConfiguration operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVoiceConnectorStreamingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetVoiceConnectorStreamingConfiguration">REST API Reference for GetVoiceConnectorStreamingConfiguration Operation</seealso>
        [Obsolete("Replaced by GetVoiceConnectorStreamingConfiguration in the Amazon Chime SDK Voice Namespace")]
        IAsyncResult BeginGetVoiceConnectorStreamingConfiguration(GetVoiceConnectorStreamingConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetVoiceConnectorStreamingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVoiceConnectorStreamingConfiguration.</param>
        /// 
        /// <returns>Returns a  GetVoiceConnectorStreamingConfigurationResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetVoiceConnectorStreamingConfiguration">REST API Reference for GetVoiceConnectorStreamingConfiguration Operation</seealso>
        [Obsolete("Replaced by GetVoiceConnectorStreamingConfiguration in the Amazon Chime SDK Voice Namespace")]
        GetVoiceConnectorStreamingConfigurationResponse EndGetVoiceConnectorStreamingConfiguration(IAsyncResult asyncResult);

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
        GetVoiceConnectorTerminationResponse GetVoiceConnectorTermination(GetVoiceConnectorTerminationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetVoiceConnectorTermination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnectorTermination operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVoiceConnectorTermination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetVoiceConnectorTermination">REST API Reference for GetVoiceConnectorTermination Operation</seealso>
        [Obsolete("Replaced by GetVoiceConnectorTermination in the Amazon Chime SDK Voice Namespace")]
        IAsyncResult BeginGetVoiceConnectorTermination(GetVoiceConnectorTerminationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetVoiceConnectorTermination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVoiceConnectorTermination.</param>
        /// 
        /// <returns>Returns a  GetVoiceConnectorTerminationResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetVoiceConnectorTermination">REST API Reference for GetVoiceConnectorTermination Operation</seealso>
        [Obsolete("Replaced by GetVoiceConnectorTermination in the Amazon Chime SDK Voice Namespace")]
        GetVoiceConnectorTerminationResponse EndGetVoiceConnectorTermination(IAsyncResult asyncResult);

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
        GetVoiceConnectorTerminationHealthResponse GetVoiceConnectorTerminationHealth(GetVoiceConnectorTerminationHealthRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetVoiceConnectorTerminationHealth operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnectorTerminationHealth operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVoiceConnectorTerminationHealth
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetVoiceConnectorTerminationHealth">REST API Reference for GetVoiceConnectorTerminationHealth Operation</seealso>
        [Obsolete("Replaced by GetVoiceConnectorTerminationHealth in the Amazon Chime SDK Voice Namespace")]
        IAsyncResult BeginGetVoiceConnectorTerminationHealth(GetVoiceConnectorTerminationHealthRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetVoiceConnectorTerminationHealth operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVoiceConnectorTerminationHealth.</param>
        /// 
        /// <returns>Returns a  GetVoiceConnectorTerminationHealthResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetVoiceConnectorTerminationHealth">REST API Reference for GetVoiceConnectorTerminationHealth Operation</seealso>
        [Obsolete("Replaced by GetVoiceConnectorTerminationHealth in the Amazon Chime SDK Voice Namespace")]
        GetVoiceConnectorTerminationHealthResponse EndGetVoiceConnectorTerminationHealth(IAsyncResult asyncResult);

        #endregion
        
        #region  InviteUsers


        /// <summary>
        /// Sends email to a maximum of 50 users, inviting them to the specified Amazon Chime
        /// <code>Team</code> account. Only <code>Team</code> account types are currently supported
        /// for this action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InviteUsers service method.</param>
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
        InviteUsersResponse InviteUsers(InviteUsersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the InviteUsers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InviteUsers operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndInviteUsers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/InviteUsers">REST API Reference for InviteUsers Operation</seealso>
        IAsyncResult BeginInviteUsers(InviteUsersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  InviteUsers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginInviteUsers.</param>
        /// 
        /// <returns>Returns a  InviteUsersResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/InviteUsers">REST API Reference for InviteUsers Operation</seealso>
        InviteUsersResponse EndInviteUsers(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAccounts


        /// <summary>
        /// Lists the Amazon Chime accounts under the administrator's AWS account. You can filter
        /// accounts by account name prefix. To find out which Amazon Chime account a user belongs
        /// to, you can filter by the user's email address, which returns one account result.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccounts service method.</param>
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
        ListAccountsResponse ListAccounts(ListAccountsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAccounts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAccounts operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAccounts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListAccounts">REST API Reference for ListAccounts Operation</seealso>
        IAsyncResult BeginListAccounts(ListAccountsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAccounts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAccounts.</param>
        /// 
        /// <returns>Returns a  ListAccountsResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListAccounts">REST API Reference for ListAccounts Operation</seealso>
        ListAccountsResponse EndListAccounts(IAsyncResult asyncResult);

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
        ListAppInstanceAdminsResponse ListAppInstanceAdmins(ListAppInstanceAdminsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAppInstanceAdmins operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAppInstanceAdmins operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAppInstanceAdmins
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListAppInstanceAdmins">REST API Reference for ListAppInstanceAdmins Operation</seealso>
        [Obsolete("Replaced by ListAppInstanceAdmins in the Amazon Chime SDK Identity Namespace")]
        IAsyncResult BeginListAppInstanceAdmins(ListAppInstanceAdminsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAppInstanceAdmins operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAppInstanceAdmins.</param>
        /// 
        /// <returns>Returns a  ListAppInstanceAdminsResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListAppInstanceAdmins">REST API Reference for ListAppInstanceAdmins Operation</seealso>
        [Obsolete("Replaced by ListAppInstanceAdmins in the Amazon Chime SDK Identity Namespace")]
        ListAppInstanceAdminsResponse EndListAppInstanceAdmins(IAsyncResult asyncResult);

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
        ListAppInstancesResponse ListAppInstances(ListAppInstancesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAppInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAppInstances operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAppInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListAppInstances">REST API Reference for ListAppInstances Operation</seealso>
        [Obsolete("Replaced by ListAppInstances in the Amazon Chime SDK Identity Namespace")]
        IAsyncResult BeginListAppInstances(ListAppInstancesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAppInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAppInstances.</param>
        /// 
        /// <returns>Returns a  ListAppInstancesResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListAppInstances">REST API Reference for ListAppInstances Operation</seealso>
        [Obsolete("Replaced by ListAppInstances in the Amazon Chime SDK Identity Namespace")]
        ListAppInstancesResponse EndListAppInstances(IAsyncResult asyncResult);

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
        ListAppInstanceUsersResponse ListAppInstanceUsers(ListAppInstanceUsersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAppInstanceUsers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAppInstanceUsers operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAppInstanceUsers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListAppInstanceUsers">REST API Reference for ListAppInstanceUsers Operation</seealso>
        [Obsolete("Replaced by ListAppInstanceUsers in the Amazon Chime SDK Identity Namespace")]
        IAsyncResult BeginListAppInstanceUsers(ListAppInstanceUsersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAppInstanceUsers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAppInstanceUsers.</param>
        /// 
        /// <returns>Returns a  ListAppInstanceUsersResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListAppInstanceUsers">REST API Reference for ListAppInstanceUsers Operation</seealso>
        [Obsolete("Replaced by ListAppInstanceUsers in the Amazon Chime SDK Identity Namespace")]
        ListAppInstanceUsersResponse EndListAppInstanceUsers(IAsyncResult asyncResult);

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
        ListAttendeesResponse ListAttendees(ListAttendeesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAttendees operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAttendees operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAttendees
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListAttendees">REST API Reference for ListAttendees Operation</seealso>
        [Obsolete("Replaced by ListAttendees in the Amazon Chime SDK Meetings Namespace")]
        IAsyncResult BeginListAttendees(ListAttendeesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAttendees operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAttendees.</param>
        /// 
        /// <returns>Returns a  ListAttendeesResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListAttendees">REST API Reference for ListAttendees Operation</seealso>
        [Obsolete("Replaced by ListAttendees in the Amazon Chime SDK Meetings Namespace")]
        ListAttendeesResponse EndListAttendees(IAsyncResult asyncResult);

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
        ListAttendeeTagsResponse ListAttendeeTags(ListAttendeeTagsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAttendeeTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAttendeeTags operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAttendeeTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListAttendeeTags">REST API Reference for ListAttendeeTags Operation</seealso>
        [Obsolete("Attendee Tags are not supported in the Amazon Chime SDK Meetings Namespace. Update your application to remove calls to this API.")]
        IAsyncResult BeginListAttendeeTags(ListAttendeeTagsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAttendeeTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAttendeeTags.</param>
        /// 
        /// <returns>Returns a  ListAttendeeTagsResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListAttendeeTags">REST API Reference for ListAttendeeTags Operation</seealso>
        [Obsolete("Attendee Tags are not supported in the Amazon Chime SDK Meetings Namespace. Update your application to remove calls to this API.")]
        ListAttendeeTagsResponse EndListAttendeeTags(IAsyncResult asyncResult);

        #endregion
        
        #region  ListBots


        /// <summary>
        /// Lists the bots associated with the administrator's Amazon Chime Enterprise account
        /// ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBots service method.</param>
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
        ListBotsResponse ListBots(ListBotsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListBots operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBots operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBots
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListBots">REST API Reference for ListBots Operation</seealso>
        IAsyncResult BeginListBots(ListBotsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListBots operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBots.</param>
        /// 
        /// <returns>Returns a  ListBotsResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListBots">REST API Reference for ListBots Operation</seealso>
        ListBotsResponse EndListBots(IAsyncResult asyncResult);

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
        ListChannelBansResponse ListChannelBans(ListChannelBansRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListChannelBans operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListChannelBans operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListChannelBans
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListChannelBans">REST API Reference for ListChannelBans Operation</seealso>
        [Obsolete("Replaced by ListChannelBans in the Amazon Chime SDK Messaging Namespace")]
        IAsyncResult BeginListChannelBans(ListChannelBansRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListChannelBans operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListChannelBans.</param>
        /// 
        /// <returns>Returns a  ListChannelBansResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListChannelBans">REST API Reference for ListChannelBans Operation</seealso>
        [Obsolete("Replaced by ListChannelBans in the Amazon Chime SDK Messaging Namespace")]
        ListChannelBansResponse EndListChannelBans(IAsyncResult asyncResult);

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
        ListChannelMembershipsResponse ListChannelMemberships(ListChannelMembershipsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListChannelMemberships operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListChannelMemberships operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListChannelMemberships
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListChannelMemberships">REST API Reference for ListChannelMemberships Operation</seealso>
        [Obsolete("Replaced by ListChannelMemberships in the Amazon Chime SDK Messaging Namespace")]
        IAsyncResult BeginListChannelMemberships(ListChannelMembershipsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListChannelMemberships operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListChannelMemberships.</param>
        /// 
        /// <returns>Returns a  ListChannelMembershipsResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListChannelMemberships">REST API Reference for ListChannelMemberships Operation</seealso>
        [Obsolete("Replaced by ListChannelMemberships in the Amazon Chime SDK Messaging Namespace")]
        ListChannelMembershipsResponse EndListChannelMemberships(IAsyncResult asyncResult);

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
        ListChannelMembershipsForAppInstanceUserResponse ListChannelMembershipsForAppInstanceUser(ListChannelMembershipsForAppInstanceUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListChannelMembershipsForAppInstanceUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListChannelMembershipsForAppInstanceUser operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListChannelMembershipsForAppInstanceUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListChannelMembershipsForAppInstanceUser">REST API Reference for ListChannelMembershipsForAppInstanceUser Operation</seealso>
        [Obsolete("Replaced by ListChannelMembershipsForAppInstanceUser in the Amazon Chime SDK Messaging Namespace")]
        IAsyncResult BeginListChannelMembershipsForAppInstanceUser(ListChannelMembershipsForAppInstanceUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListChannelMembershipsForAppInstanceUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListChannelMembershipsForAppInstanceUser.</param>
        /// 
        /// <returns>Returns a  ListChannelMembershipsForAppInstanceUserResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListChannelMembershipsForAppInstanceUser">REST API Reference for ListChannelMembershipsForAppInstanceUser Operation</seealso>
        [Obsolete("Replaced by ListChannelMembershipsForAppInstanceUser in the Amazon Chime SDK Messaging Namespace")]
        ListChannelMembershipsForAppInstanceUserResponse EndListChannelMembershipsForAppInstanceUser(IAsyncResult asyncResult);

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
        ListChannelMessagesResponse ListChannelMessages(ListChannelMessagesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListChannelMessages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListChannelMessages operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListChannelMessages
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListChannelMessages">REST API Reference for ListChannelMessages Operation</seealso>
        [Obsolete("Replaced by ListChannelMessages in the Amazon Chime SDK Messaging Namespace")]
        IAsyncResult BeginListChannelMessages(ListChannelMessagesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListChannelMessages operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListChannelMessages.</param>
        /// 
        /// <returns>Returns a  ListChannelMessagesResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListChannelMessages">REST API Reference for ListChannelMessages Operation</seealso>
        [Obsolete("Replaced by ListChannelMessages in the Amazon Chime SDK Messaging Namespace")]
        ListChannelMessagesResponse EndListChannelMessages(IAsyncResult asyncResult);

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
        ListChannelModeratorsResponse ListChannelModerators(ListChannelModeratorsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListChannelModerators operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListChannelModerators operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListChannelModerators
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListChannelModerators">REST API Reference for ListChannelModerators Operation</seealso>
        [Obsolete("Replaced by ListChannelModerators in the Amazon Chime SDK Messaging Namespace")]
        IAsyncResult BeginListChannelModerators(ListChannelModeratorsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListChannelModerators operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListChannelModerators.</param>
        /// 
        /// <returns>Returns a  ListChannelModeratorsResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListChannelModerators">REST API Reference for ListChannelModerators Operation</seealso>
        [Obsolete("Replaced by ListChannelModerators in the Amazon Chime SDK Messaging Namespace")]
        ListChannelModeratorsResponse EndListChannelModerators(IAsyncResult asyncResult);

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
        ListChannelsResponse ListChannels(ListChannelsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListChannels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListChannels operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListChannels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListChannels">REST API Reference for ListChannels Operation</seealso>
        [Obsolete("Replaced by ListChannels in the Amazon Chime SDK Messaging Namespace")]
        IAsyncResult BeginListChannels(ListChannelsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListChannels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListChannels.</param>
        /// 
        /// <returns>Returns a  ListChannelsResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListChannels">REST API Reference for ListChannels Operation</seealso>
        [Obsolete("Replaced by ListChannels in the Amazon Chime SDK Messaging Namespace")]
        ListChannelsResponse EndListChannels(IAsyncResult asyncResult);

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
        ListChannelsModeratedByAppInstanceUserResponse ListChannelsModeratedByAppInstanceUser(ListChannelsModeratedByAppInstanceUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListChannelsModeratedByAppInstanceUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListChannelsModeratedByAppInstanceUser operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListChannelsModeratedByAppInstanceUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListChannelsModeratedByAppInstanceUser">REST API Reference for ListChannelsModeratedByAppInstanceUser Operation</seealso>
        [Obsolete("Replaced by ListChannelsModeratedByAppInstanceUser in the Amazon Chime SDK Messaging Namespace")]
        IAsyncResult BeginListChannelsModeratedByAppInstanceUser(ListChannelsModeratedByAppInstanceUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListChannelsModeratedByAppInstanceUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListChannelsModeratedByAppInstanceUser.</param>
        /// 
        /// <returns>Returns a  ListChannelsModeratedByAppInstanceUserResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListChannelsModeratedByAppInstanceUser">REST API Reference for ListChannelsModeratedByAppInstanceUser Operation</seealso>
        [Obsolete("Replaced by ListChannelsModeratedByAppInstanceUser in the Amazon Chime SDK Messaging Namespace")]
        ListChannelsModeratedByAppInstanceUserResponse EndListChannelsModeratedByAppInstanceUser(IAsyncResult asyncResult);

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
        ListMediaCapturePipelinesResponse ListMediaCapturePipelines(ListMediaCapturePipelinesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListMediaCapturePipelines operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMediaCapturePipelines operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMediaCapturePipelines
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListMediaCapturePipelines">REST API Reference for ListMediaCapturePipelines Operation</seealso>
        [Obsolete("Replaced by ListMediaCapturePipelines in the Amazon Chime SDK Media Pipelines Namespace")]
        IAsyncResult BeginListMediaCapturePipelines(ListMediaCapturePipelinesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListMediaCapturePipelines operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMediaCapturePipelines.</param>
        /// 
        /// <returns>Returns a  ListMediaCapturePipelinesResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListMediaCapturePipelines">REST API Reference for ListMediaCapturePipelines Operation</seealso>
        [Obsolete("Replaced by ListMediaCapturePipelines in the Amazon Chime SDK Media Pipelines Namespace")]
        ListMediaCapturePipelinesResponse EndListMediaCapturePipelines(IAsyncResult asyncResult);

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
        ListMeetingsResponse ListMeetings(ListMeetingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListMeetings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMeetings operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMeetings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListMeetings">REST API Reference for ListMeetings Operation</seealso>
        [Obsolete("ListMeetings is not supported in the Amazon Chime SDK Meetings Namespace. Update your application to remove calls to this API.")]
        IAsyncResult BeginListMeetings(ListMeetingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListMeetings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMeetings.</param>
        /// 
        /// <returns>Returns a  ListMeetingsResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListMeetings">REST API Reference for ListMeetings Operation</seealso>
        [Obsolete("ListMeetings is not supported in the Amazon Chime SDK Meetings Namespace. Update your application to remove calls to this API.")]
        ListMeetingsResponse EndListMeetings(IAsyncResult asyncResult);

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
        ListMeetingTagsResponse ListMeetingTags(ListMeetingTagsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListMeetingTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMeetingTags operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMeetingTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListMeetingTags">REST API Reference for ListMeetingTags Operation</seealso>
        [Obsolete("Use ListTagsForResource in the Amazon Chime SDK Meetings Namespace.")]
        IAsyncResult BeginListMeetingTags(ListMeetingTagsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListMeetingTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMeetingTags.</param>
        /// 
        /// <returns>Returns a  ListMeetingTagsResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListMeetingTags">REST API Reference for ListMeetingTags Operation</seealso>
        [Obsolete("Use ListTagsForResource in the Amazon Chime SDK Meetings Namespace.")]
        ListMeetingTagsResponse EndListMeetingTags(IAsyncResult asyncResult);

        #endregion
        
        #region  ListPhoneNumberOrders


        /// <summary>
        /// Lists the phone number orders for the administrator's Amazon Chime account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPhoneNumberOrders service method.</param>
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
        ListPhoneNumberOrdersResponse ListPhoneNumberOrders(ListPhoneNumberOrdersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPhoneNumberOrders operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPhoneNumberOrders operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPhoneNumberOrders
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListPhoneNumberOrders">REST API Reference for ListPhoneNumberOrders Operation</seealso>
        IAsyncResult BeginListPhoneNumberOrders(ListPhoneNumberOrdersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPhoneNumberOrders operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPhoneNumberOrders.</param>
        /// 
        /// <returns>Returns a  ListPhoneNumberOrdersResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListPhoneNumberOrders">REST API Reference for ListPhoneNumberOrders Operation</seealso>
        ListPhoneNumberOrdersResponse EndListPhoneNumberOrders(IAsyncResult asyncResult);

        #endregion
        
        #region  ListPhoneNumbers


        /// <summary>
        /// Lists the phone numbers for the specified Amazon Chime account, Amazon Chime user,
        /// Amazon Chime Voice Connector, or Amazon Chime Voice Connector group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPhoneNumbers service method.</param>
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
        ListPhoneNumbersResponse ListPhoneNumbers(ListPhoneNumbersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPhoneNumbers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPhoneNumbers operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPhoneNumbers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListPhoneNumbers">REST API Reference for ListPhoneNumbers Operation</seealso>
        IAsyncResult BeginListPhoneNumbers(ListPhoneNumbersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPhoneNumbers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPhoneNumbers.</param>
        /// 
        /// <returns>Returns a  ListPhoneNumbersResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListPhoneNumbers">REST API Reference for ListPhoneNumbers Operation</seealso>
        ListPhoneNumbersResponse EndListPhoneNumbers(IAsyncResult asyncResult);

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
        ListProxySessionsResponse ListProxySessions(ListProxySessionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListProxySessions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProxySessions operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListProxySessions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListProxySessions">REST API Reference for ListProxySessions Operation</seealso>
        [Obsolete("Replaced by ListProxySessions in the Amazon Chime SDK Voice Namespace")]
        IAsyncResult BeginListProxySessions(ListProxySessionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListProxySessions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListProxySessions.</param>
        /// 
        /// <returns>Returns a  ListProxySessionsResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListProxySessions">REST API Reference for ListProxySessions Operation</seealso>
        [Obsolete("Replaced by ListProxySessions in the Amazon Chime SDK Voice Namespace")]
        ListProxySessionsResponse EndListProxySessions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListRoomMemberships


        /// <summary>
        /// Lists the membership details for the specified room in an Amazon Chime Enterprise
        /// account, such as the members' IDs, email addresses, and names.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRoomMemberships service method.</param>
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
        ListRoomMembershipsResponse ListRoomMemberships(ListRoomMembershipsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListRoomMemberships operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRoomMemberships operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRoomMemberships
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListRoomMemberships">REST API Reference for ListRoomMemberships Operation</seealso>
        IAsyncResult BeginListRoomMemberships(ListRoomMembershipsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListRoomMemberships operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRoomMemberships.</param>
        /// 
        /// <returns>Returns a  ListRoomMembershipsResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListRoomMemberships">REST API Reference for ListRoomMemberships Operation</seealso>
        ListRoomMembershipsResponse EndListRoomMemberships(IAsyncResult asyncResult);

        #endregion
        
        #region  ListRooms


        /// <summary>
        /// Lists the room details for the specified Amazon Chime Enterprise account. Optionally,
        /// filter the results by a member ID (user ID or bot ID) to see a list of rooms that
        /// the member belongs to.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRooms service method.</param>
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
        ListRoomsResponse ListRooms(ListRoomsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListRooms operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRooms operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRooms
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListRooms">REST API Reference for ListRooms Operation</seealso>
        IAsyncResult BeginListRooms(ListRoomsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListRooms operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRooms.</param>
        /// 
        /// <returns>Returns a  ListRoomsResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListRooms">REST API Reference for ListRooms Operation</seealso>
        ListRoomsResponse EndListRooms(IAsyncResult asyncResult);

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
        ListSipMediaApplicationsResponse ListSipMediaApplications(ListSipMediaApplicationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSipMediaApplications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSipMediaApplications operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSipMediaApplications
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListSipMediaApplications">REST API Reference for ListSipMediaApplications Operation</seealso>
        [Obsolete("Replaced by ListSipMediaApplications in the Amazon Chime SDK Voice Namespace")]
        IAsyncResult BeginListSipMediaApplications(ListSipMediaApplicationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSipMediaApplications operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSipMediaApplications.</param>
        /// 
        /// <returns>Returns a  ListSipMediaApplicationsResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListSipMediaApplications">REST API Reference for ListSipMediaApplications Operation</seealso>
        [Obsolete("Replaced by ListSipMediaApplications in the Amazon Chime SDK Voice Namespace")]
        ListSipMediaApplicationsResponse EndListSipMediaApplications(IAsyncResult asyncResult);

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
        ListSipRulesResponse ListSipRules(ListSipRulesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSipRules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSipRules operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSipRules
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListSipRules">REST API Reference for ListSipRules Operation</seealso>
        [Obsolete("Replaced by ListSipRules in the Amazon Chime SDK Voice Namespace")]
        IAsyncResult BeginListSipRules(ListSipRulesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSipRules operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSipRules.</param>
        /// 
        /// <returns>Returns a  ListSipRulesResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListSipRules">REST API Reference for ListSipRules Operation</seealso>
        [Obsolete("Replaced by ListSipRules in the Amazon Chime SDK Voice Namespace")]
        ListSipRulesResponse EndListSipRules(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSupportedPhoneNumberCountries


        /// <summary>
        /// Lists supported phone number countries.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSupportedPhoneNumberCountries service method.</param>
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
        ListSupportedPhoneNumberCountriesResponse ListSupportedPhoneNumberCountries(ListSupportedPhoneNumberCountriesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSupportedPhoneNumberCountries operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSupportedPhoneNumberCountries operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSupportedPhoneNumberCountries
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListSupportedPhoneNumberCountries">REST API Reference for ListSupportedPhoneNumberCountries Operation</seealso>
        IAsyncResult BeginListSupportedPhoneNumberCountries(ListSupportedPhoneNumberCountriesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSupportedPhoneNumberCountries operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSupportedPhoneNumberCountries.</param>
        /// 
        /// <returns>Returns a  ListSupportedPhoneNumberCountriesResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListSupportedPhoneNumberCountries">REST API Reference for ListSupportedPhoneNumberCountries Operation</seealso>
        ListSupportedPhoneNumberCountriesResponse EndListSupportedPhoneNumberCountries(IAsyncResult asyncResult);

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
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        [Obsolete("Replaced by ListTagsForResource in the Amazon Chime SDK Voice, Amazon Chime SDK Meetings, Amazon Chime SDK Identity, Amazon Chime SDK Messaging, and Amazon Chime SDK Media Pipelines Namespaces")]
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        [Obsolete("Replaced by ListTagsForResource in the Amazon Chime SDK Voice, Amazon Chime SDK Meetings, Amazon Chime SDK Identity, Amazon Chime SDK Messaging, and Amazon Chime SDK Media Pipelines Namespaces")]
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  ListUsers


        /// <summary>
        /// Lists the users that belong to the specified Amazon Chime account. You can specify
        /// an email address to list only the user that the email address belongs to.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUsers service method.</param>
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
        ListUsersResponse ListUsers(ListUsersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListUsers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUsers operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListUsers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListUsers">REST API Reference for ListUsers Operation</seealso>
        IAsyncResult BeginListUsers(ListUsersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListUsers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListUsers.</param>
        /// 
        /// <returns>Returns a  ListUsersResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListUsers">REST API Reference for ListUsers Operation</seealso>
        ListUsersResponse EndListUsers(IAsyncResult asyncResult);

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
        ListVoiceConnectorGroupsResponse ListVoiceConnectorGroups(ListVoiceConnectorGroupsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListVoiceConnectorGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVoiceConnectorGroups operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListVoiceConnectorGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListVoiceConnectorGroups">REST API Reference for ListVoiceConnectorGroups Operation</seealso>
        [Obsolete("Replaced by ListVoiceConnectorGroups in the Amazon Chime SDK Voice Namespace")]
        IAsyncResult BeginListVoiceConnectorGroups(ListVoiceConnectorGroupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListVoiceConnectorGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVoiceConnectorGroups.</param>
        /// 
        /// <returns>Returns a  ListVoiceConnectorGroupsResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListVoiceConnectorGroups">REST API Reference for ListVoiceConnectorGroups Operation</seealso>
        [Obsolete("Replaced by ListVoiceConnectorGroups in the Amazon Chime SDK Voice Namespace")]
        ListVoiceConnectorGroupsResponse EndListVoiceConnectorGroups(IAsyncResult asyncResult);

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
        ListVoiceConnectorsResponse ListVoiceConnectors(ListVoiceConnectorsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListVoiceConnectors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVoiceConnectors operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListVoiceConnectors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListVoiceConnectors">REST API Reference for ListVoiceConnectors Operation</seealso>
        [Obsolete("Replaced by ListVoiceConnectors in the Amazon Chime SDK Voice Namespace")]
        IAsyncResult BeginListVoiceConnectors(ListVoiceConnectorsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListVoiceConnectors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVoiceConnectors.</param>
        /// 
        /// <returns>Returns a  ListVoiceConnectorsResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListVoiceConnectors">REST API Reference for ListVoiceConnectors Operation</seealso>
        [Obsolete("Replaced by ListVoiceConnectors in the Amazon Chime SDK Voice Namespace")]
        ListVoiceConnectorsResponse EndListVoiceConnectors(IAsyncResult asyncResult);

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
        ListVoiceConnectorTerminationCredentialsResponse ListVoiceConnectorTerminationCredentials(ListVoiceConnectorTerminationCredentialsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListVoiceConnectorTerminationCredentials operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVoiceConnectorTerminationCredentials operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListVoiceConnectorTerminationCredentials
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListVoiceConnectorTerminationCredentials">REST API Reference for ListVoiceConnectorTerminationCredentials Operation</seealso>
        [Obsolete("Replaced by ListVoiceConnectorTerminationCredentials in the Amazon Chime SDK Voice Namespace")]
        IAsyncResult BeginListVoiceConnectorTerminationCredentials(ListVoiceConnectorTerminationCredentialsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListVoiceConnectorTerminationCredentials operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVoiceConnectorTerminationCredentials.</param>
        /// 
        /// <returns>Returns a  ListVoiceConnectorTerminationCredentialsResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListVoiceConnectorTerminationCredentials">REST API Reference for ListVoiceConnectorTerminationCredentials Operation</seealso>
        [Obsolete("Replaced by ListVoiceConnectorTerminationCredentials in the Amazon Chime SDK Voice Namespace")]
        ListVoiceConnectorTerminationCredentialsResponse EndListVoiceConnectorTerminationCredentials(IAsyncResult asyncResult);

        #endregion
        
        #region  LogoutUser


        /// <summary>
        /// Logs out the specified user from all of the devices they are currently logged into.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the LogoutUser service method.</param>
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
        LogoutUserResponse LogoutUser(LogoutUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the LogoutUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the LogoutUser operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndLogoutUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/LogoutUser">REST API Reference for LogoutUser Operation</seealso>
        IAsyncResult BeginLogoutUser(LogoutUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  LogoutUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginLogoutUser.</param>
        /// 
        /// <returns>Returns a  LogoutUserResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/LogoutUser">REST API Reference for LogoutUser Operation</seealso>
        LogoutUserResponse EndLogoutUser(IAsyncResult asyncResult);

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
        PutAppInstanceRetentionSettingsResponse PutAppInstanceRetentionSettings(PutAppInstanceRetentionSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutAppInstanceRetentionSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutAppInstanceRetentionSettings operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutAppInstanceRetentionSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/PutAppInstanceRetentionSettings">REST API Reference for PutAppInstanceRetentionSettings Operation</seealso>
        [Obsolete("Replaced by PutAppInstanceRetentionSettings in the Amazon Chime SDK Identity Namespace")]
        IAsyncResult BeginPutAppInstanceRetentionSettings(PutAppInstanceRetentionSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutAppInstanceRetentionSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutAppInstanceRetentionSettings.</param>
        /// 
        /// <returns>Returns a  PutAppInstanceRetentionSettingsResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/PutAppInstanceRetentionSettings">REST API Reference for PutAppInstanceRetentionSettings Operation</seealso>
        [Obsolete("Replaced by PutAppInstanceRetentionSettings in the Amazon Chime SDK Identity Namespace")]
        PutAppInstanceRetentionSettingsResponse EndPutAppInstanceRetentionSettings(IAsyncResult asyncResult);

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
        PutAppInstanceStreamingConfigurationsResponse PutAppInstanceStreamingConfigurations(PutAppInstanceStreamingConfigurationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutAppInstanceStreamingConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutAppInstanceStreamingConfigurations operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutAppInstanceStreamingConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/PutAppInstanceStreamingConfigurations">REST API Reference for PutAppInstanceStreamingConfigurations Operation</seealso>
        [Obsolete("Replaced by PutAppInstanceStreamingConfigurations in the Amazon Chime SDK Messaging Namespace")]
        IAsyncResult BeginPutAppInstanceStreamingConfigurations(PutAppInstanceStreamingConfigurationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutAppInstanceStreamingConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutAppInstanceStreamingConfigurations.</param>
        /// 
        /// <returns>Returns a  PutAppInstanceStreamingConfigurationsResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/PutAppInstanceStreamingConfigurations">REST API Reference for PutAppInstanceStreamingConfigurations Operation</seealso>
        [Obsolete("Replaced by PutAppInstanceStreamingConfigurations in the Amazon Chime SDK Messaging Namespace")]
        PutAppInstanceStreamingConfigurationsResponse EndPutAppInstanceStreamingConfigurations(IAsyncResult asyncResult);

        #endregion
        
        #region  PutEventsConfiguration


        /// <summary>
        /// Creates an events configuration that allows a bot to receive outgoing events sent
        /// by Amazon Chime. Choose either an HTTPS endpoint or a Lambda function ARN. For more
        /// information, see <a>Bot</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEventsConfiguration service method.</param>
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
        PutEventsConfigurationResponse PutEventsConfiguration(PutEventsConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutEventsConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutEventsConfiguration operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutEventsConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/PutEventsConfiguration">REST API Reference for PutEventsConfiguration Operation</seealso>
        IAsyncResult BeginPutEventsConfiguration(PutEventsConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutEventsConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutEventsConfiguration.</param>
        /// 
        /// <returns>Returns a  PutEventsConfigurationResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/PutEventsConfiguration">REST API Reference for PutEventsConfiguration Operation</seealso>
        PutEventsConfigurationResponse EndPutEventsConfiguration(IAsyncResult asyncResult);

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
        PutRetentionSettingsResponse PutRetentionSettings(PutRetentionSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutRetentionSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutRetentionSettings operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutRetentionSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/PutRetentionSettings">REST API Reference for PutRetentionSettings Operation</seealso>
        IAsyncResult BeginPutRetentionSettings(PutRetentionSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutRetentionSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutRetentionSettings.</param>
        /// 
        /// <returns>Returns a  PutRetentionSettingsResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/PutRetentionSettings">REST API Reference for PutRetentionSettings Operation</seealso>
        PutRetentionSettingsResponse EndPutRetentionSettings(IAsyncResult asyncResult);

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
        PutSipMediaApplicationLoggingConfigurationResponse PutSipMediaApplicationLoggingConfiguration(PutSipMediaApplicationLoggingConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutSipMediaApplicationLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutSipMediaApplicationLoggingConfiguration operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutSipMediaApplicationLoggingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/PutSipMediaApplicationLoggingConfiguration">REST API Reference for PutSipMediaApplicationLoggingConfiguration Operation</seealso>
        [Obsolete("Replaced by PutSipMediaApplicationLoggingConfiguration in the Amazon Chime SDK Voice Namespace")]
        IAsyncResult BeginPutSipMediaApplicationLoggingConfiguration(PutSipMediaApplicationLoggingConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutSipMediaApplicationLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutSipMediaApplicationLoggingConfiguration.</param>
        /// 
        /// <returns>Returns a  PutSipMediaApplicationLoggingConfigurationResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/PutSipMediaApplicationLoggingConfiguration">REST API Reference for PutSipMediaApplicationLoggingConfiguration Operation</seealso>
        [Obsolete("Replaced by PutSipMediaApplicationLoggingConfiguration in the Amazon Chime SDK Voice Namespace")]
        PutSipMediaApplicationLoggingConfigurationResponse EndPutSipMediaApplicationLoggingConfiguration(IAsyncResult asyncResult);

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
        PutVoiceConnectorEmergencyCallingConfigurationResponse PutVoiceConnectorEmergencyCallingConfiguration(PutVoiceConnectorEmergencyCallingConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutVoiceConnectorEmergencyCallingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutVoiceConnectorEmergencyCallingConfiguration operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutVoiceConnectorEmergencyCallingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/PutVoiceConnectorEmergencyCallingConfiguration">REST API Reference for PutVoiceConnectorEmergencyCallingConfiguration Operation</seealso>
        [Obsolete("Replaced by PutVoiceConnectorEmergencyCallingConfiguration in the Amazon Chime SDK Voice Namespace")]
        IAsyncResult BeginPutVoiceConnectorEmergencyCallingConfiguration(PutVoiceConnectorEmergencyCallingConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutVoiceConnectorEmergencyCallingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutVoiceConnectorEmergencyCallingConfiguration.</param>
        /// 
        /// <returns>Returns a  PutVoiceConnectorEmergencyCallingConfigurationResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/PutVoiceConnectorEmergencyCallingConfiguration">REST API Reference for PutVoiceConnectorEmergencyCallingConfiguration Operation</seealso>
        [Obsolete("Replaced by PutVoiceConnectorEmergencyCallingConfiguration in the Amazon Chime SDK Voice Namespace")]
        PutVoiceConnectorEmergencyCallingConfigurationResponse EndPutVoiceConnectorEmergencyCallingConfiguration(IAsyncResult asyncResult);

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
        PutVoiceConnectorLoggingConfigurationResponse PutVoiceConnectorLoggingConfiguration(PutVoiceConnectorLoggingConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutVoiceConnectorLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutVoiceConnectorLoggingConfiguration operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutVoiceConnectorLoggingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/PutVoiceConnectorLoggingConfiguration">REST API Reference for PutVoiceConnectorLoggingConfiguration Operation</seealso>
        [Obsolete("Replaced by PutVoiceConnectorLoggingConfiguration in the Amazon Chime SDK Voice Namespace")]
        IAsyncResult BeginPutVoiceConnectorLoggingConfiguration(PutVoiceConnectorLoggingConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutVoiceConnectorLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutVoiceConnectorLoggingConfiguration.</param>
        /// 
        /// <returns>Returns a  PutVoiceConnectorLoggingConfigurationResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/PutVoiceConnectorLoggingConfiguration">REST API Reference for PutVoiceConnectorLoggingConfiguration Operation</seealso>
        [Obsolete("Replaced by PutVoiceConnectorLoggingConfiguration in the Amazon Chime SDK Voice Namespace")]
        PutVoiceConnectorLoggingConfigurationResponse EndPutVoiceConnectorLoggingConfiguration(IAsyncResult asyncResult);

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
        PutVoiceConnectorOriginationResponse PutVoiceConnectorOrigination(PutVoiceConnectorOriginationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutVoiceConnectorOrigination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutVoiceConnectorOrigination operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutVoiceConnectorOrigination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/PutVoiceConnectorOrigination">REST API Reference for PutVoiceConnectorOrigination Operation</seealso>
        [Obsolete("Replaced by PutVoiceConnectorOrigination in the Amazon Chime SDK Voice Namespace")]
        IAsyncResult BeginPutVoiceConnectorOrigination(PutVoiceConnectorOriginationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutVoiceConnectorOrigination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutVoiceConnectorOrigination.</param>
        /// 
        /// <returns>Returns a  PutVoiceConnectorOriginationResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/PutVoiceConnectorOrigination">REST API Reference for PutVoiceConnectorOrigination Operation</seealso>
        [Obsolete("Replaced by PutVoiceConnectorOrigination in the Amazon Chime SDK Voice Namespace")]
        PutVoiceConnectorOriginationResponse EndPutVoiceConnectorOrigination(IAsyncResult asyncResult);

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
        PutVoiceConnectorProxyResponse PutVoiceConnectorProxy(PutVoiceConnectorProxyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutVoiceConnectorProxy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutVoiceConnectorProxy operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutVoiceConnectorProxy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/PutVoiceConnectorProxy">REST API Reference for PutVoiceConnectorProxy Operation</seealso>
        [Obsolete("Replaced by PutVoiceConnectorProxy in the Amazon Chime SDK Voice Namespace")]
        IAsyncResult BeginPutVoiceConnectorProxy(PutVoiceConnectorProxyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutVoiceConnectorProxy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutVoiceConnectorProxy.</param>
        /// 
        /// <returns>Returns a  PutVoiceConnectorProxyResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/PutVoiceConnectorProxy">REST API Reference for PutVoiceConnectorProxy Operation</seealso>
        [Obsolete("Replaced by PutVoiceConnectorProxy in the Amazon Chime SDK Voice Namespace")]
        PutVoiceConnectorProxyResponse EndPutVoiceConnectorProxy(IAsyncResult asyncResult);

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
        PutVoiceConnectorStreamingConfigurationResponse PutVoiceConnectorStreamingConfiguration(PutVoiceConnectorStreamingConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutVoiceConnectorStreamingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutVoiceConnectorStreamingConfiguration operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutVoiceConnectorStreamingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/PutVoiceConnectorStreamingConfiguration">REST API Reference for PutVoiceConnectorStreamingConfiguration Operation</seealso>
        [Obsolete("Replaced by PutVoiceConnectorStreamingConfiguration in the Amazon Chime SDK Voice Namespace")]
        IAsyncResult BeginPutVoiceConnectorStreamingConfiguration(PutVoiceConnectorStreamingConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutVoiceConnectorStreamingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutVoiceConnectorStreamingConfiguration.</param>
        /// 
        /// <returns>Returns a  PutVoiceConnectorStreamingConfigurationResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/PutVoiceConnectorStreamingConfiguration">REST API Reference for PutVoiceConnectorStreamingConfiguration Operation</seealso>
        [Obsolete("Replaced by PutVoiceConnectorStreamingConfiguration in the Amazon Chime SDK Voice Namespace")]
        PutVoiceConnectorStreamingConfigurationResponse EndPutVoiceConnectorStreamingConfiguration(IAsyncResult asyncResult);

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
        PutVoiceConnectorTerminationResponse PutVoiceConnectorTermination(PutVoiceConnectorTerminationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutVoiceConnectorTermination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutVoiceConnectorTermination operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutVoiceConnectorTermination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/PutVoiceConnectorTermination">REST API Reference for PutVoiceConnectorTermination Operation</seealso>
        [Obsolete("Replaced by PutVoiceConnectorTermination in the Amazon Chime SDK Voice Namespace")]
        IAsyncResult BeginPutVoiceConnectorTermination(PutVoiceConnectorTerminationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutVoiceConnectorTermination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutVoiceConnectorTermination.</param>
        /// 
        /// <returns>Returns a  PutVoiceConnectorTerminationResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/PutVoiceConnectorTermination">REST API Reference for PutVoiceConnectorTermination Operation</seealso>
        [Obsolete("Replaced by PutVoiceConnectorTermination in the Amazon Chime SDK Voice Namespace")]
        PutVoiceConnectorTerminationResponse EndPutVoiceConnectorTermination(IAsyncResult asyncResult);

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
        PutVoiceConnectorTerminationCredentialsResponse PutVoiceConnectorTerminationCredentials(PutVoiceConnectorTerminationCredentialsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutVoiceConnectorTerminationCredentials operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutVoiceConnectorTerminationCredentials operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutVoiceConnectorTerminationCredentials
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/PutVoiceConnectorTerminationCredentials">REST API Reference for PutVoiceConnectorTerminationCredentials Operation</seealso>
        [Obsolete("Replaced by PutVoiceConnectorTerminationCredentials in the Amazon Chime SDK Voice Namespace")]
        IAsyncResult BeginPutVoiceConnectorTerminationCredentials(PutVoiceConnectorTerminationCredentialsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutVoiceConnectorTerminationCredentials operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutVoiceConnectorTerminationCredentials.</param>
        /// 
        /// <returns>Returns a  PutVoiceConnectorTerminationCredentialsResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/PutVoiceConnectorTerminationCredentials">REST API Reference for PutVoiceConnectorTerminationCredentials Operation</seealso>
        [Obsolete("Replaced by PutVoiceConnectorTerminationCredentials in the Amazon Chime SDK Voice Namespace")]
        PutVoiceConnectorTerminationCredentialsResponse EndPutVoiceConnectorTerminationCredentials(IAsyncResult asyncResult);

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
        RedactChannelMessageResponse RedactChannelMessage(RedactChannelMessageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RedactChannelMessage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RedactChannelMessage operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRedactChannelMessage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/RedactChannelMessage">REST API Reference for RedactChannelMessage Operation</seealso>
        [Obsolete("Replaced by RedactChannelMessage in the Amazon Chime SDK Messaging Namespace")]
        IAsyncResult BeginRedactChannelMessage(RedactChannelMessageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RedactChannelMessage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRedactChannelMessage.</param>
        /// 
        /// <returns>Returns a  RedactChannelMessageResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/RedactChannelMessage">REST API Reference for RedactChannelMessage Operation</seealso>
        [Obsolete("Replaced by RedactChannelMessage in the Amazon Chime SDK Messaging Namespace")]
        RedactChannelMessageResponse EndRedactChannelMessage(IAsyncResult asyncResult);

        #endregion
        
        #region  RedactConversationMessage


        /// <summary>
        /// Redacts the specified message from the specified Amazon Chime conversation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RedactConversationMessage service method.</param>
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
        RedactConversationMessageResponse RedactConversationMessage(RedactConversationMessageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RedactConversationMessage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RedactConversationMessage operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRedactConversationMessage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/RedactConversationMessage">REST API Reference for RedactConversationMessage Operation</seealso>
        IAsyncResult BeginRedactConversationMessage(RedactConversationMessageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RedactConversationMessage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRedactConversationMessage.</param>
        /// 
        /// <returns>Returns a  RedactConversationMessageResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/RedactConversationMessage">REST API Reference for RedactConversationMessage Operation</seealso>
        RedactConversationMessageResponse EndRedactConversationMessage(IAsyncResult asyncResult);

        #endregion
        
        #region  RedactRoomMessage


        /// <summary>
        /// Redacts the specified message from the specified Amazon Chime channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RedactRoomMessage service method.</param>
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
        RedactRoomMessageResponse RedactRoomMessage(RedactRoomMessageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RedactRoomMessage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RedactRoomMessage operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRedactRoomMessage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/RedactRoomMessage">REST API Reference for RedactRoomMessage Operation</seealso>
        IAsyncResult BeginRedactRoomMessage(RedactRoomMessageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RedactRoomMessage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRedactRoomMessage.</param>
        /// 
        /// <returns>Returns a  RedactRoomMessageResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/RedactRoomMessage">REST API Reference for RedactRoomMessage Operation</seealso>
        RedactRoomMessageResponse EndRedactRoomMessage(IAsyncResult asyncResult);

        #endregion
        
        #region  RegenerateSecurityToken


        /// <summary>
        /// Regenerates the security token for a bot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegenerateSecurityToken service method.</param>
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
        RegenerateSecurityTokenResponse RegenerateSecurityToken(RegenerateSecurityTokenRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RegenerateSecurityToken operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegenerateSecurityToken operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegenerateSecurityToken
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/RegenerateSecurityToken">REST API Reference for RegenerateSecurityToken Operation</seealso>
        IAsyncResult BeginRegenerateSecurityToken(RegenerateSecurityTokenRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RegenerateSecurityToken operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegenerateSecurityToken.</param>
        /// 
        /// <returns>Returns a  RegenerateSecurityTokenResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/RegenerateSecurityToken">REST API Reference for RegenerateSecurityToken Operation</seealso>
        RegenerateSecurityTokenResponse EndRegenerateSecurityToken(IAsyncResult asyncResult);

        #endregion
        
        #region  ResetPersonalPIN


        /// <summary>
        /// Resets the personal meeting PIN for the specified user on an Amazon Chime account.
        /// Returns the <a>User</a> object with the updated personal meeting PIN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetPersonalPIN service method.</param>
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
        ResetPersonalPINResponse ResetPersonalPIN(ResetPersonalPINRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ResetPersonalPIN operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetPersonalPIN operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResetPersonalPIN
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ResetPersonalPIN">REST API Reference for ResetPersonalPIN Operation</seealso>
        IAsyncResult BeginResetPersonalPIN(ResetPersonalPINRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ResetPersonalPIN operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResetPersonalPIN.</param>
        /// 
        /// <returns>Returns a  ResetPersonalPINResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ResetPersonalPIN">REST API Reference for ResetPersonalPIN Operation</seealso>
        ResetPersonalPINResponse EndResetPersonalPIN(IAsyncResult asyncResult);

        #endregion
        
        #region  RestorePhoneNumber


        /// <summary>
        /// Moves a phone number from the <b>Deletion queue</b> back into the phone number <b>Inventory</b>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestorePhoneNumber service method.</param>
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
        RestorePhoneNumberResponse RestorePhoneNumber(RestorePhoneNumberRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RestorePhoneNumber operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestorePhoneNumber operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRestorePhoneNumber
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/RestorePhoneNumber">REST API Reference for RestorePhoneNumber Operation</seealso>
        IAsyncResult BeginRestorePhoneNumber(RestorePhoneNumberRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RestorePhoneNumber operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRestorePhoneNumber.</param>
        /// 
        /// <returns>Returns a  RestorePhoneNumberResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/RestorePhoneNumber">REST API Reference for RestorePhoneNumber Operation</seealso>
        RestorePhoneNumberResponse EndRestorePhoneNumber(IAsyncResult asyncResult);

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
        SearchAvailablePhoneNumbersResponse SearchAvailablePhoneNumbers(SearchAvailablePhoneNumbersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SearchAvailablePhoneNumbers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchAvailablePhoneNumbers operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchAvailablePhoneNumbers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/SearchAvailablePhoneNumbers">REST API Reference for SearchAvailablePhoneNumbers Operation</seealso>
        IAsyncResult BeginSearchAvailablePhoneNumbers(SearchAvailablePhoneNumbersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SearchAvailablePhoneNumbers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchAvailablePhoneNumbers.</param>
        /// 
        /// <returns>Returns a  SearchAvailablePhoneNumbersResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/SearchAvailablePhoneNumbers">REST API Reference for SearchAvailablePhoneNumbers Operation</seealso>
        SearchAvailablePhoneNumbersResponse EndSearchAvailablePhoneNumbers(IAsyncResult asyncResult);

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
        SendChannelMessageResponse SendChannelMessage(SendChannelMessageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SendChannelMessage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendChannelMessage operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSendChannelMessage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/SendChannelMessage">REST API Reference for SendChannelMessage Operation</seealso>
        [Obsolete("Replaced by SendChannelMessage in the Amazon Chime SDK Messaging Namespace")]
        IAsyncResult BeginSendChannelMessage(SendChannelMessageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SendChannelMessage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendChannelMessage.</param>
        /// 
        /// <returns>Returns a  SendChannelMessageResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/SendChannelMessage">REST API Reference for SendChannelMessage Operation</seealso>
        [Obsolete("Replaced by SendChannelMessage in the Amazon Chime SDK Messaging Namespace")]
        SendChannelMessageResponse EndSendChannelMessage(IAsyncResult asyncResult);

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
        StartMeetingTranscriptionResponse StartMeetingTranscription(StartMeetingTranscriptionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartMeetingTranscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartMeetingTranscription operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartMeetingTranscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/StartMeetingTranscription">REST API Reference for StartMeetingTranscription Operation</seealso>
        [Obsolete("Replaced by StartMeetingTranscription in the Amazon Chime SDK Meetings Namespace")]
        IAsyncResult BeginStartMeetingTranscription(StartMeetingTranscriptionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartMeetingTranscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartMeetingTranscription.</param>
        /// 
        /// <returns>Returns a  StartMeetingTranscriptionResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/StartMeetingTranscription">REST API Reference for StartMeetingTranscription Operation</seealso>
        [Obsolete("Replaced by StartMeetingTranscription in the Amazon Chime SDK Meetings Namespace")]
        StartMeetingTranscriptionResponse EndStartMeetingTranscription(IAsyncResult asyncResult);

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
        StopMeetingTranscriptionResponse StopMeetingTranscription(StopMeetingTranscriptionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopMeetingTranscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopMeetingTranscription operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopMeetingTranscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/StopMeetingTranscription">REST API Reference for StopMeetingTranscription Operation</seealso>
        [Obsolete("Replaced by StopMeetingTranscription in the Amazon Chime SDK Meetings Namespace")]
        IAsyncResult BeginStopMeetingTranscription(StopMeetingTranscriptionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopMeetingTranscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopMeetingTranscription.</param>
        /// 
        /// <returns>Returns a  StopMeetingTranscriptionResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/StopMeetingTranscription">REST API Reference for StopMeetingTranscription Operation</seealso>
        [Obsolete("Replaced by StopMeetingTranscription in the Amazon Chime SDK Meetings Namespace")]
        StopMeetingTranscriptionResponse EndStopMeetingTranscription(IAsyncResult asyncResult);

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
        TagAttendeeResponse TagAttendee(TagAttendeeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagAttendee operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagAttendee operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagAttendee
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/TagAttendee">REST API Reference for TagAttendee Operation</seealso>
        [Obsolete("Attendee Tags are not supported in the Amazon Chime SDK Meetings Namespace. Update your application to remove calls to this API.")]
        IAsyncResult BeginTagAttendee(TagAttendeeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagAttendee operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagAttendee.</param>
        /// 
        /// <returns>Returns a  TagAttendeeResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/TagAttendee">REST API Reference for TagAttendee Operation</seealso>
        [Obsolete("Attendee Tags are not supported in the Amazon Chime SDK Meetings Namespace. Update your application to remove calls to this API.")]
        TagAttendeeResponse EndTagAttendee(IAsyncResult asyncResult);

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
        TagMeetingResponse TagMeeting(TagMeetingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagMeeting operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagMeeting operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagMeeting
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/TagMeeting">REST API Reference for TagMeeting Operation</seealso>
        [Obsolete("Use TagResource in the Amazon Chime SDK Meetings Namespace.")]
        IAsyncResult BeginTagMeeting(TagMeetingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagMeeting operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagMeeting.</param>
        /// 
        /// <returns>Returns a  TagMeetingResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/TagMeeting">REST API Reference for TagMeeting Operation</seealso>
        [Obsolete("Use TagResource in the Amazon Chime SDK Meetings Namespace.")]
        TagMeetingResponse EndTagMeeting(IAsyncResult asyncResult);

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
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/TagResource">REST API Reference for TagResource Operation</seealso>
        [Obsolete("Replaced by TagResource in the Amazon Chime SDK Voice, Amazon Chime SDK Meetings, Amazon Chime SDK Identity, Amazon Chime SDK Messaging, and Amazon Chime SDK Media Pipelines Namespaces")]
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/TagResource">REST API Reference for TagResource Operation</seealso>
        [Obsolete("Replaced by TagResource in the Amazon Chime SDK Voice, Amazon Chime SDK Meetings, Amazon Chime SDK Identity, Amazon Chime SDK Messaging, and Amazon Chime SDK Media Pipelines Namespaces")]
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

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
        UntagAttendeeResponse UntagAttendee(UntagAttendeeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagAttendee operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagAttendee operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagAttendee
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UntagAttendee">REST API Reference for UntagAttendee Operation</seealso>
        [Obsolete("Attendee Tags are not supported in the Amazon Chime SDK Meetings Namespace. Update your application to remove calls to this API.")]
        IAsyncResult BeginUntagAttendee(UntagAttendeeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagAttendee operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagAttendee.</param>
        /// 
        /// <returns>Returns a  UntagAttendeeResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UntagAttendee">REST API Reference for UntagAttendee Operation</seealso>
        [Obsolete("Attendee Tags are not supported in the Amazon Chime SDK Meetings Namespace. Update your application to remove calls to this API.")]
        UntagAttendeeResponse EndUntagAttendee(IAsyncResult asyncResult);

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
        UntagMeetingResponse UntagMeeting(UntagMeetingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagMeeting operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagMeeting operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagMeeting
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UntagMeeting">REST API Reference for UntagMeeting Operation</seealso>
        [Obsolete("Use UntagResource in the Amazon Chime SDK Meetings Namespace.")]
        IAsyncResult BeginUntagMeeting(UntagMeetingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagMeeting operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagMeeting.</param>
        /// 
        /// <returns>Returns a  UntagMeetingResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UntagMeeting">REST API Reference for UntagMeeting Operation</seealso>
        [Obsolete("Use UntagResource in the Amazon Chime SDK Meetings Namespace.")]
        UntagMeetingResponse EndUntagMeeting(IAsyncResult asyncResult);

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
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        [Obsolete("Replaced by UntagResource in the Amazon Chime SDK Voice, Amazon Chime SDK Meetings, Amazon Chime SDK Identity, Amazon Chime SDK Messaging, and Amazon Chime SDK Media Pipelines Namespaces")]
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        [Obsolete("Replaced by UntagResource in the Amazon Chime SDK Voice, Amazon Chime SDK Meetings, Amazon Chime SDK Identity, Amazon Chime SDK Messaging, and Amazon Chime SDK Media Pipelines Namespaces")]
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateAccount


        /// <summary>
        /// Updates account details for the specified Amazon Chime account. Currently, only account
        /// name and default license updates are supported for this action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccount service method.</param>
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
        UpdateAccountResponse UpdateAccount(UpdateAccountRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccount operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateAccount">REST API Reference for UpdateAccount Operation</seealso>
        IAsyncResult BeginUpdateAccount(UpdateAccountRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAccount.</param>
        /// 
        /// <returns>Returns a  UpdateAccountResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateAccount">REST API Reference for UpdateAccount Operation</seealso>
        UpdateAccountResponse EndUpdateAccount(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateAccountSettings


        /// <summary>
        /// Updates the settings for the specified Amazon Chime account. You can update settings
        /// for remote control of shared screens, or for the dial-out option. For more information
        /// about these settings, see <a href="https://docs.aws.amazon.com/chime/latest/ag/policies.html">Use
        /// the Policies Page</a> in the <i>Amazon Chime Administration Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccountSettings service method.</param>
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
        UpdateAccountSettingsResponse UpdateAccountSettings(UpdateAccountSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAccountSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccountSettings operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAccountSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateAccountSettings">REST API Reference for UpdateAccountSettings Operation</seealso>
        IAsyncResult BeginUpdateAccountSettings(UpdateAccountSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAccountSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAccountSettings.</param>
        /// 
        /// <returns>Returns a  UpdateAccountSettingsResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateAccountSettings">REST API Reference for UpdateAccountSettings Operation</seealso>
        UpdateAccountSettingsResponse EndUpdateAccountSettings(IAsyncResult asyncResult);

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
        UpdateAppInstanceResponse UpdateAppInstance(UpdateAppInstanceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAppInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAppInstance operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAppInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateAppInstance">REST API Reference for UpdateAppInstance Operation</seealso>
        [Obsolete("Replaced by UpdateAppInstance in the Amazon Chime SDK Identity Namespace")]
        IAsyncResult BeginUpdateAppInstance(UpdateAppInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAppInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAppInstance.</param>
        /// 
        /// <returns>Returns a  UpdateAppInstanceResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateAppInstance">REST API Reference for UpdateAppInstance Operation</seealso>
        [Obsolete("Replaced by UpdateAppInstance in the Amazon Chime SDK Identity Namespace")]
        UpdateAppInstanceResponse EndUpdateAppInstance(IAsyncResult asyncResult);

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
        UpdateAppInstanceUserResponse UpdateAppInstanceUser(UpdateAppInstanceUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAppInstanceUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAppInstanceUser operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAppInstanceUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateAppInstanceUser">REST API Reference for UpdateAppInstanceUser Operation</seealso>
        [Obsolete("Replaced by UpdateAppInstanceUser in the Amazon Chime SDK Identity Namespace")]
        IAsyncResult BeginUpdateAppInstanceUser(UpdateAppInstanceUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAppInstanceUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAppInstanceUser.</param>
        /// 
        /// <returns>Returns a  UpdateAppInstanceUserResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateAppInstanceUser">REST API Reference for UpdateAppInstanceUser Operation</seealso>
        [Obsolete("Replaced by UpdateAppInstanceUser in the Amazon Chime SDK Identity Namespace")]
        UpdateAppInstanceUserResponse EndUpdateAppInstanceUser(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateBot


        /// <summary>
        /// Updates the status of the specified bot, such as starting or stopping the bot from
        /// running in your Amazon Chime Enterprise account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBot service method.</param>
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
        UpdateBotResponse UpdateBot(UpdateBotRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBot operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateBot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateBot">REST API Reference for UpdateBot Operation</seealso>
        IAsyncResult BeginUpdateBot(UpdateBotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateBot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateBot.</param>
        /// 
        /// <returns>Returns a  UpdateBotResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateBot">REST API Reference for UpdateBot Operation</seealso>
        UpdateBotResponse EndUpdateBot(IAsyncResult asyncResult);

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
        UpdateChannelResponse UpdateChannel(UpdateChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateChannel operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateChannel">REST API Reference for UpdateChannel Operation</seealso>
        [Obsolete("Replaced by UpdateChannel in the Amazon Chime SDK Messaging Namespace")]
        IAsyncResult BeginUpdateChannel(UpdateChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateChannel.</param>
        /// 
        /// <returns>Returns a  UpdateChannelResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateChannel">REST API Reference for UpdateChannel Operation</seealso>
        [Obsolete("Replaced by UpdateChannel in the Amazon Chime SDK Messaging Namespace")]
        UpdateChannelResponse EndUpdateChannel(IAsyncResult asyncResult);

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
        UpdateChannelMessageResponse UpdateChannelMessage(UpdateChannelMessageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateChannelMessage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateChannelMessage operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateChannelMessage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateChannelMessage">REST API Reference for UpdateChannelMessage Operation</seealso>
        [Obsolete("Replaced by UpdateChannelMessage in the Amazon Chime SDK Messaging Namespace")]
        IAsyncResult BeginUpdateChannelMessage(UpdateChannelMessageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateChannelMessage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateChannelMessage.</param>
        /// 
        /// <returns>Returns a  UpdateChannelMessageResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateChannelMessage">REST API Reference for UpdateChannelMessage Operation</seealso>
        [Obsolete("Replaced by UpdateChannelMessage in the Amazon Chime SDK Messaging Namespace")]
        UpdateChannelMessageResponse EndUpdateChannelMessage(IAsyncResult asyncResult);

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
        UpdateChannelReadMarkerResponse UpdateChannelReadMarker(UpdateChannelReadMarkerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateChannelReadMarker operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateChannelReadMarker operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateChannelReadMarker
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateChannelReadMarker">REST API Reference for UpdateChannelReadMarker Operation</seealso>
        [Obsolete("Replaced by UpdateChannelReadMarker in the Amazon Chime SDK Messaging Namespace")]
        IAsyncResult BeginUpdateChannelReadMarker(UpdateChannelReadMarkerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateChannelReadMarker operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateChannelReadMarker.</param>
        /// 
        /// <returns>Returns a  UpdateChannelReadMarkerResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateChannelReadMarker">REST API Reference for UpdateChannelReadMarker Operation</seealso>
        [Obsolete("Replaced by UpdateChannelReadMarker in the Amazon Chime SDK Messaging Namespace")]
        UpdateChannelReadMarkerResponse EndUpdateChannelReadMarker(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateGlobalSettings


        /// <summary>
        /// Updates global settings for the administrator's AWS account, such as Amazon Chime
        /// Business Calling and Amazon Chime Voice Connector settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGlobalSettings service method.</param>
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
        UpdateGlobalSettingsResponse UpdateGlobalSettings(UpdateGlobalSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGlobalSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGlobalSettings operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateGlobalSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateGlobalSettings">REST API Reference for UpdateGlobalSettings Operation</seealso>
        IAsyncResult BeginUpdateGlobalSettings(UpdateGlobalSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateGlobalSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateGlobalSettings.</param>
        /// 
        /// <returns>Returns a  UpdateGlobalSettingsResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateGlobalSettings">REST API Reference for UpdateGlobalSettings Operation</seealso>
        UpdateGlobalSettingsResponse EndUpdateGlobalSettings(IAsyncResult asyncResult);

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
        UpdatePhoneNumberResponse UpdatePhoneNumber(UpdatePhoneNumberRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePhoneNumber operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePhoneNumber operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePhoneNumber
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdatePhoneNumber">REST API Reference for UpdatePhoneNumber Operation</seealso>
        IAsyncResult BeginUpdatePhoneNumber(UpdatePhoneNumberRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePhoneNumber operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePhoneNumber.</param>
        /// 
        /// <returns>Returns a  UpdatePhoneNumberResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdatePhoneNumber">REST API Reference for UpdatePhoneNumber Operation</seealso>
        UpdatePhoneNumberResponse EndUpdatePhoneNumber(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdatePhoneNumberSettings


        /// <summary>
        /// Updates the phone number settings for the administrator's AWS account, such as the
        /// default outbound calling name. You can update the default outbound calling name once
        /// every seven days. Outbound calling names can take up to 72 hours to update.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePhoneNumberSettings service method.</param>
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
        UpdatePhoneNumberSettingsResponse UpdatePhoneNumberSettings(UpdatePhoneNumberSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePhoneNumberSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePhoneNumberSettings operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePhoneNumberSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdatePhoneNumberSettings">REST API Reference for UpdatePhoneNumberSettings Operation</seealso>
        IAsyncResult BeginUpdatePhoneNumberSettings(UpdatePhoneNumberSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePhoneNumberSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePhoneNumberSettings.</param>
        /// 
        /// <returns>Returns a  UpdatePhoneNumberSettingsResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdatePhoneNumberSettings">REST API Reference for UpdatePhoneNumberSettings Operation</seealso>
        UpdatePhoneNumberSettingsResponse EndUpdatePhoneNumberSettings(IAsyncResult asyncResult);

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
        UpdateProxySessionResponse UpdateProxySession(UpdateProxySessionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateProxySession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateProxySession operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateProxySession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateProxySession">REST API Reference for UpdateProxySession Operation</seealso>
        [Obsolete("Replaced by UpdateProxySession in the Amazon Chime SDK Voice Namespace")]
        IAsyncResult BeginUpdateProxySession(UpdateProxySessionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateProxySession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateProxySession.</param>
        /// 
        /// <returns>Returns a  UpdateProxySessionResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateProxySession">REST API Reference for UpdateProxySession Operation</seealso>
        [Obsolete("Replaced by UpdateProxySession in the Amazon Chime SDK Voice Namespace")]
        UpdateProxySessionResponse EndUpdateProxySession(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateRoom


        /// <summary>
        /// Updates room details, such as the room name, for a room in an Amazon Chime Enterprise
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoom service method.</param>
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
        UpdateRoomResponse UpdateRoom(UpdateRoomRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRoom operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoom operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRoom
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateRoom">REST API Reference for UpdateRoom Operation</seealso>
        IAsyncResult BeginUpdateRoom(UpdateRoomRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRoom operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRoom.</param>
        /// 
        /// <returns>Returns a  UpdateRoomResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateRoom">REST API Reference for UpdateRoom Operation</seealso>
        UpdateRoomResponse EndUpdateRoom(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateRoomMembership


        /// <summary>
        /// Updates room membership details, such as the member role, for a room in an Amazon
        /// Chime Enterprise account. The member role designates whether the member is a chat
        /// room administrator or a general chat room member. The member role can be updated only
        /// for user IDs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoomMembership service method.</param>
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
        UpdateRoomMembershipResponse UpdateRoomMembership(UpdateRoomMembershipRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRoomMembership operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoomMembership operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRoomMembership
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateRoomMembership">REST API Reference for UpdateRoomMembership Operation</seealso>
        IAsyncResult BeginUpdateRoomMembership(UpdateRoomMembershipRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRoomMembership operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRoomMembership.</param>
        /// 
        /// <returns>Returns a  UpdateRoomMembershipResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateRoomMembership">REST API Reference for UpdateRoomMembership Operation</seealso>
        UpdateRoomMembershipResponse EndUpdateRoomMembership(IAsyncResult asyncResult);

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
        UpdateSipMediaApplicationResponse UpdateSipMediaApplication(UpdateSipMediaApplicationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSipMediaApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSipMediaApplication operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSipMediaApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateSipMediaApplication">REST API Reference for UpdateSipMediaApplication Operation</seealso>
        [Obsolete("Replaced by UpdateSipMediaApplication in the Amazon Chime SDK Voice Namespace")]
        IAsyncResult BeginUpdateSipMediaApplication(UpdateSipMediaApplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSipMediaApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSipMediaApplication.</param>
        /// 
        /// <returns>Returns a  UpdateSipMediaApplicationResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateSipMediaApplication">REST API Reference for UpdateSipMediaApplication Operation</seealso>
        [Obsolete("Replaced by UpdateSipMediaApplication in the Amazon Chime SDK Voice Namespace")]
        UpdateSipMediaApplicationResponse EndUpdateSipMediaApplication(IAsyncResult asyncResult);

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
        UpdateSipMediaApplicationCallResponse UpdateSipMediaApplicationCall(UpdateSipMediaApplicationCallRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSipMediaApplicationCall operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSipMediaApplicationCall operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSipMediaApplicationCall
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateSipMediaApplicationCall">REST API Reference for UpdateSipMediaApplicationCall Operation</seealso>
        [Obsolete("Replaced by UpdateSipMediaApplicationCall in the Amazon Chime SDK Voice Namespace")]
        IAsyncResult BeginUpdateSipMediaApplicationCall(UpdateSipMediaApplicationCallRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSipMediaApplicationCall operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSipMediaApplicationCall.</param>
        /// 
        /// <returns>Returns a  UpdateSipMediaApplicationCallResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateSipMediaApplicationCall">REST API Reference for UpdateSipMediaApplicationCall Operation</seealso>
        [Obsolete("Replaced by UpdateSipMediaApplicationCall in the Amazon Chime SDK Voice Namespace")]
        UpdateSipMediaApplicationCallResponse EndUpdateSipMediaApplicationCall(IAsyncResult asyncResult);

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
        UpdateSipRuleResponse UpdateSipRule(UpdateSipRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSipRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSipRule operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSipRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateSipRule">REST API Reference for UpdateSipRule Operation</seealso>
        [Obsolete("Replaced by UpdateSipRule in the Amazon Chime SDK Voice Namespace")]
        IAsyncResult BeginUpdateSipRule(UpdateSipRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSipRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSipRule.</param>
        /// 
        /// <returns>Returns a  UpdateSipRuleResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateSipRule">REST API Reference for UpdateSipRule Operation</seealso>
        [Obsolete("Replaced by UpdateSipRule in the Amazon Chime SDK Voice Namespace")]
        UpdateSipRuleResponse EndUpdateSipRule(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateUser


        /// <summary>
        /// Updates user details for a specified user ID. Currently, only <code>LicenseType</code>
        /// updates are supported for this action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUser service method.</param>
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
        UpdateUserResponse UpdateUser(UpdateUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUser operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateUser">REST API Reference for UpdateUser Operation</seealso>
        IAsyncResult BeginUpdateUser(UpdateUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateUser.</param>
        /// 
        /// <returns>Returns a  UpdateUserResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateUser">REST API Reference for UpdateUser Operation</seealso>
        UpdateUserResponse EndUpdateUser(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateUserSettings


        /// <summary>
        /// Updates the settings for the specified user, such as phone number settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserSettings service method.</param>
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
        UpdateUserSettingsResponse UpdateUserSettings(UpdateUserSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUserSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserSettings operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateUserSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateUserSettings">REST API Reference for UpdateUserSettings Operation</seealso>
        IAsyncResult BeginUpdateUserSettings(UpdateUserSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateUserSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateUserSettings.</param>
        /// 
        /// <returns>Returns a  UpdateUserSettingsResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateUserSettings">REST API Reference for UpdateUserSettings Operation</seealso>
        UpdateUserSettingsResponse EndUpdateUserSettings(IAsyncResult asyncResult);

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
        UpdateVoiceConnectorResponse UpdateVoiceConnector(UpdateVoiceConnectorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateVoiceConnector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateVoiceConnector operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateVoiceConnector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateVoiceConnector">REST API Reference for UpdateVoiceConnector Operation</seealso>
        [Obsolete("Replaced by UpdateVoiceConnector in the Amazon Chime SDK Voice Namespace")]
        IAsyncResult BeginUpdateVoiceConnector(UpdateVoiceConnectorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateVoiceConnector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateVoiceConnector.</param>
        /// 
        /// <returns>Returns a  UpdateVoiceConnectorResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateVoiceConnector">REST API Reference for UpdateVoiceConnector Operation</seealso>
        [Obsolete("Replaced by UpdateVoiceConnector in the Amazon Chime SDK Voice Namespace")]
        UpdateVoiceConnectorResponse EndUpdateVoiceConnector(IAsyncResult asyncResult);

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
        UpdateVoiceConnectorGroupResponse UpdateVoiceConnectorGroup(UpdateVoiceConnectorGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateVoiceConnectorGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateVoiceConnectorGroup operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateVoiceConnectorGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateVoiceConnectorGroup">REST API Reference for UpdateVoiceConnectorGroup Operation</seealso>
        [Obsolete("Replaced by UpdateVoiceConnectorGroup in the Amazon Chime SDK Voice Namespace")]
        IAsyncResult BeginUpdateVoiceConnectorGroup(UpdateVoiceConnectorGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateVoiceConnectorGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateVoiceConnectorGroup.</param>
        /// 
        /// <returns>Returns a  UpdateVoiceConnectorGroupResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateVoiceConnectorGroup">REST API Reference for UpdateVoiceConnectorGroup Operation</seealso>
        [Obsolete("Replaced by UpdateVoiceConnectorGroup in the Amazon Chime SDK Voice Namespace")]
        UpdateVoiceConnectorGroupResponse EndUpdateVoiceConnectorGroup(IAsyncResult asyncResult);

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
        ValidateE911AddressResponse ValidateE911Address(ValidateE911AddressRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ValidateE911Address operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ValidateE911Address operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndValidateE911Address
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ValidateE911Address">REST API Reference for ValidateE911Address Operation</seealso>
        [Obsolete("Replaced by ValidateE911Address in the Amazon Chime SDK Voice Namespace")]
        IAsyncResult BeginValidateE911Address(ValidateE911AddressRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ValidateE911Address operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginValidateE911Address.</param>
        /// 
        /// <returns>Returns a  ValidateE911AddressResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ValidateE911Address">REST API Reference for ValidateE911Address Operation</seealso>
        [Obsolete("Replaced by ValidateE911Address in the Amazon Chime SDK Voice Namespace")]
        ValidateE911AddressResponse EndValidateE911Address(IAsyncResult asyncResult);

        #endregion
        
    }
}