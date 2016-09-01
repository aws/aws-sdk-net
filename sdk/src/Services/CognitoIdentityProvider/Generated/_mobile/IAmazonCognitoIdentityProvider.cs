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

using Amazon.CognitoIdentityProvider.Model;

namespace Amazon.CognitoIdentityProvider
{
    /// <summary>
    /// Interface for accessing CognitoIdentityProvider
    ///
    /// You can create a user pool in Amazon Cognito Identity to manage directories and users.
    /// You can authenticate a user to obtain tokens related to user identity and access policies.
    /// 
    ///  
    /// <para>
    /// This API reference provides information about user pools in Amazon Cognito Identity.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://aws.amazon.com/cognito/">Amazon Cognito</a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonCognitoIdentityProvider : IDisposable
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
        Task<AddCustomAttributesResponse> AddCustomAttributesAsync(AddCustomAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        Task<AdminConfirmSignUpResponse> AdminConfirmSignUpAsync(AdminConfirmSignUpRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        Task<AdminDeleteUserAttributesResponse> AdminDeleteUserAttributesAsync(AdminDeleteUserAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        Task<AdminInitiateAuthResponse> AdminInitiateAuthAsync(AdminInitiateAuthRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        Task<AdminListDevicesResponse> AdminListDevicesAsync(AdminListDevicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        Task<AdminRespondToAuthChallengeResponse> AdminRespondToAuthChallengeAsync(AdminRespondToAuthChallengeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        Task<AdminSetUserSettingsResponse> AdminSetUserSettingsAsync(AdminSetUserSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        Task<AdminUserGlobalSignOutResponse> AdminUserGlobalSignOutAsync(AdminUserGlobalSignOutRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        Task<ConfirmSignUpResponse> ConfirmSignUpAsync(ConfirmSignUpRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        Task<CreateUserPoolClientResponse> CreateUserPoolClientAsync(CreateUserPoolClientRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        Task<DeleteUserPoolClientResponse> DeleteUserPoolClientAsync(DeleteUserPoolClientRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        Task<DescribeUserPoolClientResponse> DescribeUserPoolClientAsync(DescribeUserPoolClientRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        Task<GetDeviceResponse> GetDeviceAsync(GetDeviceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        Task<GetUserAttributeVerificationCodeResponse> GetUserAttributeVerificationCodeAsync(GetUserAttributeVerificationCodeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        Task<ListDevicesResponse> ListDevicesAsync(ListDevicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        Task<ListUsersResponse> ListUsersAsync(ListUsersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        Task<RespondToAuthChallengeResponse> RespondToAuthChallengeAsync(RespondToAuthChallengeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        Task<StopUserImportJobResponse> StopUserImportJobAsync(StopUserImportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        Task<UpdateDeviceStatusResponse> UpdateDeviceStatusAsync(UpdateDeviceStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        Task<UpdateUserPoolClientResponse> UpdateUserPoolClientAsync(UpdateUserPoolClientRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        Task<VerifyUserAttributeResponse> VerifyUserAttributeAsync(VerifyUserAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}