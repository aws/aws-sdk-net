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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.CognitoIdentityProvider.Model;

namespace Amazon.CognitoIdentityProvider
{
    /// <summary>
    /// Interface for accessing CognitoIdentityProvider
    ///
    /// Using the Amazon Cognito User Pools API, you can create a user pool to manage directories
    /// and users. You can authenticate a user to obtain tokens related to user identity and
    /// access policies.
    /// 
    ///  
    /// <para>
    /// This API reference provides information about user pools in Amazon Cognito User Pools.
    /// </para>
    ///  
    /// <para>
    /// For more information, see the Amazon Cognito Documentation.
    /// </para>
    /// </summary>
    public partial interface IAmazonCognitoIdentityProvider : IAmazonService, IDisposable
    {
                
        #region  AddCustomAttributes


        /// <summary>
        /// Initiates the asynchronous execution of the AddCustomAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddCustomAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AddCustomAttributes">REST API Reference for AddCustomAttributes Operation</seealso>
        Task<AddCustomAttributesResponse> AddCustomAttributesAsync(AddCustomAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AdminAddUserToGroup


        /// <summary>
        /// Initiates the asynchronous execution of the AdminAddUserToGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminAddUserToGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminAddUserToGroup">REST API Reference for AdminAddUserToGroup Operation</seealso>
        Task<AdminAddUserToGroupResponse> AdminAddUserToGroupAsync(AdminAddUserToGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AdminConfirmSignUp


        /// <summary>
        /// Initiates the asynchronous execution of the AdminConfirmSignUp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminConfirmSignUp operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminConfirmSignUp">REST API Reference for AdminConfirmSignUp Operation</seealso>
        Task<AdminConfirmSignUpResponse> AdminConfirmSignUpAsync(AdminConfirmSignUpRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AdminCreateUser


        /// <summary>
        /// Initiates the asynchronous execution of the AdminCreateUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminCreateUser operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminCreateUser">REST API Reference for AdminCreateUser Operation</seealso>
        Task<AdminCreateUserResponse> AdminCreateUserAsync(AdminCreateUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AdminDeleteUser


        /// <summary>
        /// Initiates the asynchronous execution of the AdminDeleteUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminDeleteUser operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminDeleteUser">REST API Reference for AdminDeleteUser Operation</seealso>
        Task<AdminDeleteUserResponse> AdminDeleteUserAsync(AdminDeleteUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AdminDeleteUserAttributes


        /// <summary>
        /// Initiates the asynchronous execution of the AdminDeleteUserAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminDeleteUserAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminDeleteUserAttributes">REST API Reference for AdminDeleteUserAttributes Operation</seealso>
        Task<AdminDeleteUserAttributesResponse> AdminDeleteUserAttributesAsync(AdminDeleteUserAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AdminDisableProviderForUser


        /// <summary>
        /// Initiates the asynchronous execution of the AdminDisableProviderForUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminDisableProviderForUser operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminDisableProviderForUser">REST API Reference for AdminDisableProviderForUser Operation</seealso>
        Task<AdminDisableProviderForUserResponse> AdminDisableProviderForUserAsync(AdminDisableProviderForUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AdminDisableUser


        /// <summary>
        /// Initiates the asynchronous execution of the AdminDisableUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminDisableUser operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminDisableUser">REST API Reference for AdminDisableUser Operation</seealso>
        Task<AdminDisableUserResponse> AdminDisableUserAsync(AdminDisableUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AdminEnableUser


        /// <summary>
        /// Initiates the asynchronous execution of the AdminEnableUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminEnableUser operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminEnableUser">REST API Reference for AdminEnableUser Operation</seealso>
        Task<AdminEnableUserResponse> AdminEnableUserAsync(AdminEnableUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AdminForgetDevice


        /// <summary>
        /// Initiates the asynchronous execution of the AdminForgetDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminForgetDevice operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminForgetDevice">REST API Reference for AdminForgetDevice Operation</seealso>
        Task<AdminForgetDeviceResponse> AdminForgetDeviceAsync(AdminForgetDeviceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AdminGetDevice


        /// <summary>
        /// Initiates the asynchronous execution of the AdminGetDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminGetDevice operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminGetDevice">REST API Reference for AdminGetDevice Operation</seealso>
        Task<AdminGetDeviceResponse> AdminGetDeviceAsync(AdminGetDeviceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AdminGetUser


        /// <summary>
        /// Initiates the asynchronous execution of the AdminGetUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminGetUser operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminGetUser">REST API Reference for AdminGetUser Operation</seealso>
        Task<AdminGetUserResponse> AdminGetUserAsync(AdminGetUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AdminInitiateAuth


        /// <summary>
        /// Initiates the asynchronous execution of the AdminInitiateAuth operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminInitiateAuth operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminInitiateAuth">REST API Reference for AdminInitiateAuth Operation</seealso>
        Task<AdminInitiateAuthResponse> AdminInitiateAuthAsync(AdminInitiateAuthRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AdminLinkProviderForUser


        /// <summary>
        /// Initiates the asynchronous execution of the AdminLinkProviderForUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminLinkProviderForUser operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminLinkProviderForUser">REST API Reference for AdminLinkProviderForUser Operation</seealso>
        Task<AdminLinkProviderForUserResponse> AdminLinkProviderForUserAsync(AdminLinkProviderForUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AdminListDevices


        /// <summary>
        /// Initiates the asynchronous execution of the AdminListDevices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminListDevices operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminListDevices">REST API Reference for AdminListDevices Operation</seealso>
        Task<AdminListDevicesResponse> AdminListDevicesAsync(AdminListDevicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AdminListGroupsForUser


        /// <summary>
        /// Initiates the asynchronous execution of the AdminListGroupsForUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminListGroupsForUser operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminListGroupsForUser">REST API Reference for AdminListGroupsForUser Operation</seealso>
        Task<AdminListGroupsForUserResponse> AdminListGroupsForUserAsync(AdminListGroupsForUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AdminListUserAuthEvents


        /// <summary>
        /// Initiates the asynchronous execution of the AdminListUserAuthEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminListUserAuthEvents operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminListUserAuthEvents">REST API Reference for AdminListUserAuthEvents Operation</seealso>
        Task<AdminListUserAuthEventsResponse> AdminListUserAuthEventsAsync(AdminListUserAuthEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AdminRemoveUserFromGroup


        /// <summary>
        /// Initiates the asynchronous execution of the AdminRemoveUserFromGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminRemoveUserFromGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminRemoveUserFromGroup">REST API Reference for AdminRemoveUserFromGroup Operation</seealso>
        Task<AdminRemoveUserFromGroupResponse> AdminRemoveUserFromGroupAsync(AdminRemoveUserFromGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AdminResetUserPassword


        /// <summary>
        /// Initiates the asynchronous execution of the AdminResetUserPassword operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminResetUserPassword operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminResetUserPassword">REST API Reference for AdminResetUserPassword Operation</seealso>
        Task<AdminResetUserPasswordResponse> AdminResetUserPasswordAsync(AdminResetUserPasswordRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AdminRespondToAuthChallenge


        /// <summary>
        /// Initiates the asynchronous execution of the AdminRespondToAuthChallenge operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminRespondToAuthChallenge operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminRespondToAuthChallenge">REST API Reference for AdminRespondToAuthChallenge Operation</seealso>
        Task<AdminRespondToAuthChallengeResponse> AdminRespondToAuthChallengeAsync(AdminRespondToAuthChallengeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AdminSetUserMFAPreference


        /// <summary>
        /// Initiates the asynchronous execution of the AdminSetUserMFAPreference operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminSetUserMFAPreference operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminSetUserMFAPreference">REST API Reference for AdminSetUserMFAPreference Operation</seealso>
        Task<AdminSetUserMFAPreferenceResponse> AdminSetUserMFAPreferenceAsync(AdminSetUserMFAPreferenceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AdminSetUserSettings


        /// <summary>
        /// Initiates the asynchronous execution of the AdminSetUserSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminSetUserSettings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminSetUserSettings">REST API Reference for AdminSetUserSettings Operation</seealso>
        Task<AdminSetUserSettingsResponse> AdminSetUserSettingsAsync(AdminSetUserSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AdminUpdateAuthEventFeedback


        /// <summary>
        /// Initiates the asynchronous execution of the AdminUpdateAuthEventFeedback operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminUpdateAuthEventFeedback operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminUpdateAuthEventFeedback">REST API Reference for AdminUpdateAuthEventFeedback Operation</seealso>
        Task<AdminUpdateAuthEventFeedbackResponse> AdminUpdateAuthEventFeedbackAsync(AdminUpdateAuthEventFeedbackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AdminUpdateDeviceStatus


        /// <summary>
        /// Initiates the asynchronous execution of the AdminUpdateDeviceStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminUpdateDeviceStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminUpdateDeviceStatus">REST API Reference for AdminUpdateDeviceStatus Operation</seealso>
        Task<AdminUpdateDeviceStatusResponse> AdminUpdateDeviceStatusAsync(AdminUpdateDeviceStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AdminUpdateUserAttributes


        /// <summary>
        /// Initiates the asynchronous execution of the AdminUpdateUserAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminUpdateUserAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminUpdateUserAttributes">REST API Reference for AdminUpdateUserAttributes Operation</seealso>
        Task<AdminUpdateUserAttributesResponse> AdminUpdateUserAttributesAsync(AdminUpdateUserAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AdminUserGlobalSignOut


        /// <summary>
        /// Initiates the asynchronous execution of the AdminUserGlobalSignOut operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminUserGlobalSignOut operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminUserGlobalSignOut">REST API Reference for AdminUserGlobalSignOut Operation</seealso>
        Task<AdminUserGlobalSignOutResponse> AdminUserGlobalSignOutAsync(AdminUserGlobalSignOutRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AssociateSoftwareToken


        /// <summary>
        /// Initiates the asynchronous execution of the AssociateSoftwareToken operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateSoftwareToken operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AssociateSoftwareToken">REST API Reference for AssociateSoftwareToken Operation</seealso>
        Task<AssociateSoftwareTokenResponse> AssociateSoftwareTokenAsync(AssociateSoftwareTokenRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ChangePassword


        /// <summary>
        /// Initiates the asynchronous execution of the ChangePassword operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ChangePassword operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ChangePassword">REST API Reference for ChangePassword Operation</seealso>
        Task<ChangePasswordResponse> ChangePasswordAsync(ChangePasswordRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ConfirmDevice


        /// <summary>
        /// Initiates the asynchronous execution of the ConfirmDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConfirmDevice operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ConfirmDevice">REST API Reference for ConfirmDevice Operation</seealso>
        Task<ConfirmDeviceResponse> ConfirmDeviceAsync(ConfirmDeviceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ConfirmForgotPassword


        /// <summary>
        /// Initiates the asynchronous execution of the ConfirmForgotPassword operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConfirmForgotPassword operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ConfirmForgotPassword">REST API Reference for ConfirmForgotPassword Operation</seealso>
        Task<ConfirmForgotPasswordResponse> ConfirmForgotPasswordAsync(ConfirmForgotPasswordRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ConfirmSignUp


        /// <summary>
        /// Initiates the asynchronous execution of the ConfirmSignUp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConfirmSignUp operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ConfirmSignUp">REST API Reference for ConfirmSignUp Operation</seealso>
        Task<ConfirmSignUpResponse> ConfirmSignUpAsync(ConfirmSignUpRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        Task<CreateGroupResponse> CreateGroupAsync(CreateGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateIdentityProvider


        /// <summary>
        /// Initiates the asynchronous execution of the CreateIdentityProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateIdentityProvider operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CreateIdentityProvider">REST API Reference for CreateIdentityProvider Operation</seealso>
        Task<CreateIdentityProviderResponse> CreateIdentityProviderAsync(CreateIdentityProviderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateResourceServer


        /// <summary>
        /// Initiates the asynchronous execution of the CreateResourceServer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateResourceServer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CreateResourceServer">REST API Reference for CreateResourceServer Operation</seealso>
        Task<CreateResourceServerResponse> CreateResourceServerAsync(CreateResourceServerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateUserImportJob


        /// <summary>
        /// Initiates the asynchronous execution of the CreateUserImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUserImportJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CreateUserImportJob">REST API Reference for CreateUserImportJob Operation</seealso>
        Task<CreateUserImportJobResponse> CreateUserImportJobAsync(CreateUserImportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateUserPool


        /// <summary>
        /// Initiates the asynchronous execution of the CreateUserPool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUserPool operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CreateUserPool">REST API Reference for CreateUserPool Operation</seealso>
        Task<CreateUserPoolResponse> CreateUserPoolAsync(CreateUserPoolRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateUserPoolClient


        /// <summary>
        /// Initiates the asynchronous execution of the CreateUserPoolClient operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUserPoolClient operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CreateUserPoolClient">REST API Reference for CreateUserPoolClient Operation</seealso>
        Task<CreateUserPoolClientResponse> CreateUserPoolClientAsync(CreateUserPoolClientRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateUserPoolDomain


        /// <summary>
        /// Initiates the asynchronous execution of the CreateUserPoolDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUserPoolDomain operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CreateUserPoolDomain">REST API Reference for CreateUserPoolDomain Operation</seealso>
        Task<CreateUserPoolDomainResponse> CreateUserPoolDomainAsync(CreateUserPoolDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        Task<DeleteGroupResponse> DeleteGroupAsync(DeleteGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteIdentityProvider


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIdentityProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIdentityProvider operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteIdentityProvider">REST API Reference for DeleteIdentityProvider Operation</seealso>
        Task<DeleteIdentityProviderResponse> DeleteIdentityProviderAsync(DeleteIdentityProviderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteResourceServer


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteResourceServer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourceServer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteResourceServer">REST API Reference for DeleteResourceServer Operation</seealso>
        Task<DeleteResourceServerResponse> DeleteResourceServerAsync(DeleteResourceServerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        Task<DeleteUserResponse> DeleteUserAsync(DeleteUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteUserAttributes


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUserAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteUserAttributes">REST API Reference for DeleteUserAttributes Operation</seealso>
        Task<DeleteUserAttributesResponse> DeleteUserAttributesAsync(DeleteUserAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteUserPool


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUserPool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserPool operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteUserPool">REST API Reference for DeleteUserPool Operation</seealso>
        Task<DeleteUserPoolResponse> DeleteUserPoolAsync(DeleteUserPoolRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteUserPoolClient


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUserPoolClient operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserPoolClient operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteUserPoolClient">REST API Reference for DeleteUserPoolClient Operation</seealso>
        Task<DeleteUserPoolClientResponse> DeleteUserPoolClientAsync(DeleteUserPoolClientRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteUserPoolDomain


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUserPoolDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserPoolDomain operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteUserPoolDomain">REST API Reference for DeleteUserPoolDomain Operation</seealso>
        Task<DeleteUserPoolDomainResponse> DeleteUserPoolDomainAsync(DeleteUserPoolDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeIdentityProvider


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeIdentityProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeIdentityProvider operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeIdentityProvider">REST API Reference for DescribeIdentityProvider Operation</seealso>
        Task<DescribeIdentityProviderResponse> DescribeIdentityProviderAsync(DescribeIdentityProviderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeResourceServer


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeResourceServer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeResourceServer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeResourceServer">REST API Reference for DescribeResourceServer Operation</seealso>
        Task<DescribeResourceServerResponse> DescribeResourceServerAsync(DescribeResourceServerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeRiskConfiguration


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRiskConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRiskConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeRiskConfiguration">REST API Reference for DescribeRiskConfiguration Operation</seealso>
        Task<DescribeRiskConfigurationResponse> DescribeRiskConfigurationAsync(DescribeRiskConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeUserImportJob


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeUserImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeUserImportJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeUserImportJob">REST API Reference for DescribeUserImportJob Operation</seealso>
        Task<DescribeUserImportJobResponse> DescribeUserImportJobAsync(DescribeUserImportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeUserPool


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeUserPool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeUserPool operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeUserPool">REST API Reference for DescribeUserPool Operation</seealso>
        Task<DescribeUserPoolResponse> DescribeUserPoolAsync(DescribeUserPoolRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeUserPoolClient


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeUserPoolClient operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeUserPoolClient operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeUserPoolClient">REST API Reference for DescribeUserPoolClient Operation</seealso>
        Task<DescribeUserPoolClientResponse> DescribeUserPoolClientAsync(DescribeUserPoolClientRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeUserPoolDomain


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeUserPoolDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeUserPoolDomain operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeUserPoolDomain">REST API Reference for DescribeUserPoolDomain Operation</seealso>
        Task<DescribeUserPoolDomainResponse> DescribeUserPoolDomainAsync(DescribeUserPoolDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ForgetDevice


        /// <summary>
        /// Initiates the asynchronous execution of the ForgetDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ForgetDevice operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ForgetDevice">REST API Reference for ForgetDevice Operation</seealso>
        Task<ForgetDeviceResponse> ForgetDeviceAsync(ForgetDeviceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ForgotPassword


        /// <summary>
        /// Initiates the asynchronous execution of the ForgotPassword operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ForgotPassword operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ForgotPassword">REST API Reference for ForgotPassword Operation</seealso>
        Task<ForgotPasswordResponse> ForgotPasswordAsync(ForgotPasswordRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetCSVHeader


        /// <summary>
        /// Initiates the asynchronous execution of the GetCSVHeader operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCSVHeader operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetCSVHeader">REST API Reference for GetCSVHeader Operation</seealso>
        Task<GetCSVHeaderResponse> GetCSVHeaderAsync(GetCSVHeaderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetDevice


        /// <summary>
        /// Initiates the asynchronous execution of the GetDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDevice operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetDevice">REST API Reference for GetDevice Operation</seealso>
        Task<GetDeviceResponse> GetDeviceAsync(GetDeviceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetGroup


        /// <summary>
        /// Initiates the asynchronous execution of the GetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetGroup">REST API Reference for GetGroup Operation</seealso>
        Task<GetGroupResponse> GetGroupAsync(GetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetIdentityProviderByIdentifier


        /// <summary>
        /// Initiates the asynchronous execution of the GetIdentityProviderByIdentifier operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIdentityProviderByIdentifier operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetIdentityProviderByIdentifier">REST API Reference for GetIdentityProviderByIdentifier Operation</seealso>
        Task<GetIdentityProviderByIdentifierResponse> GetIdentityProviderByIdentifierAsync(GetIdentityProviderByIdentifierRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSigningCertificate


        /// <summary>
        /// Initiates the asynchronous execution of the GetSigningCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSigningCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetSigningCertificate">REST API Reference for GetSigningCertificate Operation</seealso>
        Task<GetSigningCertificateResponse> GetSigningCertificateAsync(GetSigningCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetUICustomization


        /// <summary>
        /// Initiates the asynchronous execution of the GetUICustomization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUICustomization operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetUICustomization">REST API Reference for GetUICustomization Operation</seealso>
        Task<GetUICustomizationResponse> GetUICustomizationAsync(GetUICustomizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetUser


        /// <summary>
        /// Initiates the asynchronous execution of the GetUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUser operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetUser">REST API Reference for GetUser Operation</seealso>
        Task<GetUserResponse> GetUserAsync(GetUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetUserAttributeVerificationCode


        /// <summary>
        /// Initiates the asynchronous execution of the GetUserAttributeVerificationCode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUserAttributeVerificationCode operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetUserAttributeVerificationCode">REST API Reference for GetUserAttributeVerificationCode Operation</seealso>
        Task<GetUserAttributeVerificationCodeResponse> GetUserAttributeVerificationCodeAsync(GetUserAttributeVerificationCodeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetUserPoolMfaConfig


        /// <summary>
        /// Initiates the asynchronous execution of the GetUserPoolMfaConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUserPoolMfaConfig operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetUserPoolMfaConfig">REST API Reference for GetUserPoolMfaConfig Operation</seealso>
        Task<GetUserPoolMfaConfigResponse> GetUserPoolMfaConfigAsync(GetUserPoolMfaConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GlobalSignOut


        /// <summary>
        /// Initiates the asynchronous execution of the GlobalSignOut operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GlobalSignOut operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GlobalSignOut">REST API Reference for GlobalSignOut Operation</seealso>
        Task<GlobalSignOutResponse> GlobalSignOutAsync(GlobalSignOutRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  InitiateAuth


        /// <summary>
        /// Initiates the asynchronous execution of the InitiateAuth operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InitiateAuth operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/InitiateAuth">REST API Reference for InitiateAuth Operation</seealso>
        Task<InitiateAuthResponse> InitiateAuthAsync(InitiateAuthRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListDevices


        /// <summary>
        /// Initiates the asynchronous execution of the ListDevices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDevices operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListDevices">REST API Reference for ListDevices Operation</seealso>
        Task<ListDevicesResponse> ListDevicesAsync(ListDevicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListGroups">REST API Reference for ListGroups Operation</seealso>
        Task<ListGroupsResponse> ListGroupsAsync(ListGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListIdentityProviders


        /// <summary>
        /// Initiates the asynchronous execution of the ListIdentityProviders operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIdentityProviders operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListIdentityProviders">REST API Reference for ListIdentityProviders Operation</seealso>
        Task<ListIdentityProvidersResponse> ListIdentityProvidersAsync(ListIdentityProvidersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListResourceServers


        /// <summary>
        /// Initiates the asynchronous execution of the ListResourceServers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResourceServers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListResourceServers">REST API Reference for ListResourceServers Operation</seealso>
        Task<ListResourceServersResponse> ListResourceServersAsync(ListResourceServersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListUserImportJobs


        /// <summary>
        /// Initiates the asynchronous execution of the ListUserImportJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUserImportJobs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListUserImportJobs">REST API Reference for ListUserImportJobs Operation</seealso>
        Task<ListUserImportJobsResponse> ListUserImportJobsAsync(ListUserImportJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListUserPoolClients


        /// <summary>
        /// Initiates the asynchronous execution of the ListUserPoolClients operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUserPoolClients operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListUserPoolClients">REST API Reference for ListUserPoolClients Operation</seealso>
        Task<ListUserPoolClientsResponse> ListUserPoolClientsAsync(ListUserPoolClientsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListUserPools


        /// <summary>
        /// Initiates the asynchronous execution of the ListUserPools operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUserPools operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListUserPools">REST API Reference for ListUserPools Operation</seealso>
        Task<ListUserPoolsResponse> ListUserPoolsAsync(ListUserPoolsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListUsers">REST API Reference for ListUsers Operation</seealso>
        Task<ListUsersResponse> ListUsersAsync(ListUsersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListUsersInGroup


        /// <summary>
        /// Initiates the asynchronous execution of the ListUsersInGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUsersInGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListUsersInGroup">REST API Reference for ListUsersInGroup Operation</seealso>
        Task<ListUsersInGroupResponse> ListUsersInGroupAsync(ListUsersInGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ResendConfirmationCode


        /// <summary>
        /// Initiates the asynchronous execution of the ResendConfirmationCode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResendConfirmationCode operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ResendConfirmationCode">REST API Reference for ResendConfirmationCode Operation</seealso>
        Task<ResendConfirmationCodeResponse> ResendConfirmationCodeAsync(ResendConfirmationCodeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RespondToAuthChallenge


        /// <summary>
        /// Initiates the asynchronous execution of the RespondToAuthChallenge operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RespondToAuthChallenge operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/RespondToAuthChallenge">REST API Reference for RespondToAuthChallenge Operation</seealso>
        Task<RespondToAuthChallengeResponse> RespondToAuthChallengeAsync(RespondToAuthChallengeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SetRiskConfiguration


        /// <summary>
        /// Initiates the asynchronous execution of the SetRiskConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetRiskConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/SetRiskConfiguration">REST API Reference for SetRiskConfiguration Operation</seealso>
        Task<SetRiskConfigurationResponse> SetRiskConfigurationAsync(SetRiskConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SetUICustomization


        /// <summary>
        /// Initiates the asynchronous execution of the SetUICustomization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetUICustomization operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/SetUICustomization">REST API Reference for SetUICustomization Operation</seealso>
        Task<SetUICustomizationResponse> SetUICustomizationAsync(SetUICustomizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SetUserMFAPreference


        /// <summary>
        /// Initiates the asynchronous execution of the SetUserMFAPreference operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetUserMFAPreference operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/SetUserMFAPreference">REST API Reference for SetUserMFAPreference Operation</seealso>
        Task<SetUserMFAPreferenceResponse> SetUserMFAPreferenceAsync(SetUserMFAPreferenceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SetUserPoolMfaConfig


        /// <summary>
        /// Initiates the asynchronous execution of the SetUserPoolMfaConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetUserPoolMfaConfig operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/SetUserPoolMfaConfig">REST API Reference for SetUserPoolMfaConfig Operation</seealso>
        Task<SetUserPoolMfaConfigResponse> SetUserPoolMfaConfigAsync(SetUserPoolMfaConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SetUserSettings


        /// <summary>
        /// Initiates the asynchronous execution of the SetUserSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetUserSettings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/SetUserSettings">REST API Reference for SetUserSettings Operation</seealso>
        Task<SetUserSettingsResponse> SetUserSettingsAsync(SetUserSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SignUp


        /// <summary>
        /// Initiates the asynchronous execution of the SignUp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SignUp operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/SignUp">REST API Reference for SignUp Operation</seealso>
        Task<SignUpResponse> SignUpAsync(SignUpRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartUserImportJob


        /// <summary>
        /// Initiates the asynchronous execution of the StartUserImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartUserImportJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/StartUserImportJob">REST API Reference for StartUserImportJob Operation</seealso>
        Task<StartUserImportJobResponse> StartUserImportJobAsync(StartUserImportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopUserImportJob


        /// <summary>
        /// Initiates the asynchronous execution of the StopUserImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopUserImportJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/StopUserImportJob">REST API Reference for StopUserImportJob Operation</seealso>
        Task<StopUserImportJobResponse> StopUserImportJobAsync(StopUserImportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateAuthEventFeedback


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAuthEventFeedback operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAuthEventFeedback operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateAuthEventFeedback">REST API Reference for UpdateAuthEventFeedback Operation</seealso>
        Task<UpdateAuthEventFeedbackResponse> UpdateAuthEventFeedbackAsync(UpdateAuthEventFeedbackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateDeviceStatus


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDeviceStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDeviceStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateDeviceStatus">REST API Reference for UpdateDeviceStatus Operation</seealso>
        Task<UpdateDeviceStatusResponse> UpdateDeviceStatusAsync(UpdateDeviceStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateGroup


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateGroup">REST API Reference for UpdateGroup Operation</seealso>
        Task<UpdateGroupResponse> UpdateGroupAsync(UpdateGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateIdentityProvider


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateIdentityProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateIdentityProvider operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateIdentityProvider">REST API Reference for UpdateIdentityProvider Operation</seealso>
        Task<UpdateIdentityProviderResponse> UpdateIdentityProviderAsync(UpdateIdentityProviderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateResourceServer


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateResourceServer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateResourceServer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateResourceServer">REST API Reference for UpdateResourceServer Operation</seealso>
        Task<UpdateResourceServerResponse> UpdateResourceServerAsync(UpdateResourceServerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateUserAttributes


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUserAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateUserAttributes">REST API Reference for UpdateUserAttributes Operation</seealso>
        Task<UpdateUserAttributesResponse> UpdateUserAttributesAsync(UpdateUserAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateUserPool


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUserPool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserPool operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateUserPool">REST API Reference for UpdateUserPool Operation</seealso>
        Task<UpdateUserPoolResponse> UpdateUserPoolAsync(UpdateUserPoolRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateUserPoolClient


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUserPoolClient operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserPoolClient operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateUserPoolClient">REST API Reference for UpdateUserPoolClient Operation</seealso>
        Task<UpdateUserPoolClientResponse> UpdateUserPoolClientAsync(UpdateUserPoolClientRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  VerifySoftwareToken


        /// <summary>
        /// Initiates the asynchronous execution of the VerifySoftwareToken operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the VerifySoftwareToken operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/VerifySoftwareToken">REST API Reference for VerifySoftwareToken Operation</seealso>
        Task<VerifySoftwareTokenResponse> VerifySoftwareTokenAsync(VerifySoftwareTokenRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  VerifyUserAttribute


        /// <summary>
        /// Initiates the asynchronous execution of the VerifyUserAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the VerifyUserAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/VerifyUserAttribute">REST API Reference for VerifyUserAttribute Operation</seealso>
        Task<VerifyUserAttributeResponse> VerifyUserAttributeAsync(VerifyUserAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}