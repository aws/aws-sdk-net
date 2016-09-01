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
        /// Adds additional user attributes to the user pool schema.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddCustomAttributes service method.</param>
        /// 
        /// <returns>The response from the AddCustomAttributes service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception gets thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception gets thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserImportInProgressException">
        /// This exception is thrown when you are trying to modify a user pool while a user import
        /// job is in progress for that pool.
        /// </exception>
        AddCustomAttributesResponse AddCustomAttributes(AddCustomAttributesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the AddCustomAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddCustomAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<AddCustomAttributesResponse> AddCustomAttributesAsync(AddCustomAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AdminConfirmSignUp


        /// <summary>
        /// Confirms user registration as an admin without using a confirmation code. Works on
        /// any user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AdminConfirmSignUp service method.</param>
        /// 
        /// <returns>The response from the AdminConfirmSignUp service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidLambdaResponseException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid AWS
        /// Lambda response.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.LimitExceededException">
        /// This exception is thrown when a user exceeds the limit for a requested AWS resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception gets thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyFailedAttemptsException">
        /// This exception gets thrown when the user has made too many failed attempts for a given
        /// action (e.g., sign in).
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception gets thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UnexpectedLambdaException">
        /// This exception gets thrown when the Amazon Cognito service encounters an unexpected
        /// exception with the AWS Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserLambdaValidationException">
        /// This exception gets thrown when the Amazon Cognito service encounters a user validation
        /// exception with the AWS Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user is not found.
        /// </exception>
        AdminConfirmSignUpResponse AdminConfirmSignUp(AdminConfirmSignUpRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the AdminConfirmSignUp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminConfirmSignUp operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<AdminConfirmSignUpResponse> AdminConfirmSignUpAsync(AdminConfirmSignUpRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AdminDeleteUser


        /// <summary>
        /// Deletes a user as an administrator. Works on any user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AdminDeleteUser service method.</param>
        /// 
        /// <returns>The response from the AdminDeleteUser service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception gets thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception gets thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user is not found.
        /// </exception>
        AdminDeleteUserResponse AdminDeleteUser(AdminDeleteUserRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the AdminDeleteUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminDeleteUser operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<AdminDeleteUserResponse> AdminDeleteUserAsync(AdminDeleteUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AdminDeleteUserAttributes


        /// <summary>
        /// Deletes the user attributes in a user pool as an administrator. Works on any user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AdminDeleteUserAttributes service method.</param>
        /// 
        /// <returns>The response from the AdminDeleteUserAttributes service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception gets thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception gets thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user is not found.
        /// </exception>
        AdminDeleteUserAttributesResponse AdminDeleteUserAttributes(AdminDeleteUserAttributesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the AdminDeleteUserAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminDeleteUserAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<AdminDeleteUserAttributesResponse> AdminDeleteUserAttributesAsync(AdminDeleteUserAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AdminDisableUser


        /// <summary>
        /// Disables the specified user as an administrator. Works on any user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AdminDisableUser service method.</param>
        /// 
        /// <returns>The response from the AdminDisableUser service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception gets thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception gets thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user is not found.
        /// </exception>
        AdminDisableUserResponse AdminDisableUser(AdminDisableUserRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the AdminDisableUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminDisableUser operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<AdminDisableUserResponse> AdminDisableUserAsync(AdminDisableUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AdminEnableUser


        /// <summary>
        /// Enables the specified user as an administrator. Works on any user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AdminEnableUser service method.</param>
        /// 
        /// <returns>The response from the AdminEnableUser service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception gets thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception gets thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user is not found.
        /// </exception>
        AdminEnableUserResponse AdminEnableUser(AdminEnableUserRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the AdminEnableUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminEnableUser operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<AdminEnableUserResponse> AdminEnableUserAsync(AdminEnableUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AdminForgetDevice


        /// <summary>
        /// Forgets the device, as an administrator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AdminForgetDevice service method.</param>
        /// 
        /// <returns>The response from the AdminForgetDevice service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidUserPoolConfigurationException">
        /// This exception is thrown when the user pool configuration is invalid.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception gets thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception gets thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user is not found.
        /// </exception>
        AdminForgetDeviceResponse AdminForgetDevice(AdminForgetDeviceRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the AdminForgetDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminForgetDevice operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<AdminForgetDeviceResponse> AdminForgetDeviceAsync(AdminForgetDeviceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AdminGetDevice


        /// <summary>
        /// Gets the device, as an administrator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AdminGetDevice service method.</param>
        /// 
        /// <returns>The response from the AdminGetDevice service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidUserPoolConfigurationException">
        /// This exception is thrown when the user pool configuration is invalid.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception gets thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception gets thrown when the user has made too many requests for a given operation.
        /// </exception>
        AdminGetDeviceResponse AdminGetDevice(AdminGetDeviceRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the AdminGetDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminGetDevice operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<AdminGetDeviceResponse> AdminGetDeviceAsync(AdminGetDeviceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AdminGetUser


        /// <summary>
        /// Gets the specified user by user name in a user pool as an administrator. Works on
        /// any user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AdminGetUser service method.</param>
        /// 
        /// <returns>The response from the AdminGetUser service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception gets thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception gets thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user is not found.
        /// </exception>
        AdminGetUserResponse AdminGetUser(AdminGetUserRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the AdminGetUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminGetUser operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<AdminGetUserResponse> AdminGetUserAsync(AdminGetUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AdminInitiateAuth


        /// <summary>
        /// Initiates the authentication flow, as an administrator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AdminInitiateAuth service method.</param>
        /// 
        /// <returns>The response from the AdminInitiateAuth service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidLambdaResponseException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid AWS
        /// Lambda response.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidSmsRoleAccessPolicyException">
        /// This exception is returned when the role provided for SMS configuration does not have
        /// permission to publish using Amazon SNS.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidSmsRoleTrustRelationshipException">
        /// This exception is thrown when the trust relationship is invalid for the role provided
        /// for SMS configuration. This can happen if you do not trust <b>cognito-idp.amazonaws.com</b>
        /// or the external ID provided in the role does not match what is provided in the SMS
        /// configuration for the user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidUserPoolConfigurationException">
        /// This exception is thrown when the user pool configuration is invalid.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.MFAMethodNotFoundException">
        /// This exception is thrown when Amazon Cognito cannot find a multi-factor authentication
        /// (MFA) method.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception gets thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordResetRequiredException">
        /// This exception is thrown when a password reset is required.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception gets thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UnexpectedLambdaException">
        /// This exception gets thrown when the Amazon Cognito service encounters an unexpected
        /// exception with the AWS Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserLambdaValidationException">
        /// This exception gets thrown when the Amazon Cognito service encounters a user validation
        /// exception with the AWS Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user is not confirmed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user is not found.
        /// </exception>
        AdminInitiateAuthResponse AdminInitiateAuth(AdminInitiateAuthRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the AdminInitiateAuth operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminInitiateAuth operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<AdminInitiateAuthResponse> AdminInitiateAuthAsync(AdminInitiateAuthRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AdminListDevices


        /// <summary>
        /// Lists devices, as an administrator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AdminListDevices service method.</param>
        /// 
        /// <returns>The response from the AdminListDevices service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidUserPoolConfigurationException">
        /// This exception is thrown when the user pool configuration is invalid.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception gets thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception gets thrown when the user has made too many requests for a given operation.
        /// </exception>
        AdminListDevicesResponse AdminListDevices(AdminListDevicesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the AdminListDevices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminListDevices operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<AdminListDevicesResponse> AdminListDevicesAsync(AdminListDevicesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AdminResetUserPassword


        /// <summary>
        /// Resets the specified user's password in a user pool as an administrator. Works on
        /// any user.
        /// 
        ///  
        /// <para>
        /// When a developer calls this API, the current password is invalidated, so it must be
        /// changed. If a user tries to sign in after the API is called, the app will get a PasswordResetRequiredException
        /// exception back and should direct the user down the flow to reset the password, which
        /// is the same as the forgot password flow. In addition, if the user pool has phone verification
        /// selected and a verified phone number exists for the user, or if email verification
        /// is selected and a verified email exists for the user, calling this API will also result
        /// in sending a message to the end user with the code to change their password.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AdminResetUserPassword service method.</param>
        /// 
        /// <returns>The response from the AdminResetUserPassword service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidLambdaResponseException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid AWS
        /// Lambda response.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.LimitExceededException">
        /// This exception is thrown when a user exceeds the limit for a requested AWS resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception gets thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception gets thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UnexpectedLambdaException">
        /// This exception gets thrown when the Amazon Cognito service encounters an unexpected
        /// exception with the AWS Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserLambdaValidationException">
        /// This exception gets thrown when the Amazon Cognito service encounters a user validation
        /// exception with the AWS Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user is not found.
        /// </exception>
        AdminResetUserPasswordResponse AdminResetUserPassword(AdminResetUserPasswordRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the AdminResetUserPassword operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminResetUserPassword operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<AdminResetUserPasswordResponse> AdminResetUserPasswordAsync(AdminResetUserPasswordRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AdminRespondToAuthChallenge


        /// <summary>
        /// Responds to an authentication challenge, as an administrator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AdminRespondToAuthChallenge service method.</param>
        /// 
        /// <returns>The response from the AdminRespondToAuthChallenge service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.AliasExistsException">
        /// This exception is thrown when a user tries to confirm the account with an email or
        /// phone number that has already been supplied as an alias from a different account.
        /// This exception tells user that an account with this email or phone already exists.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.CodeMismatchException">
        /// This exception is thrown if the provided code does not match what the server was expecting.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ExpiredCodeException">
        /// This exception is thrown if a code has expired.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidLambdaResponseException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid AWS
        /// Lambda response.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidSmsRoleAccessPolicyException">
        /// This exception is returned when the role provided for SMS configuration does not have
        /// permission to publish using Amazon SNS.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidSmsRoleTrustRelationshipException">
        /// This exception is thrown when the trust relationship is invalid for the role provided
        /// for SMS configuration. This can happen if you do not trust <b>cognito-idp.amazonaws.com</b>
        /// or the external ID provided in the role does not match what is provided in the SMS
        /// configuration for the user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidUserPoolConfigurationException">
        /// This exception is thrown when the user pool configuration is invalid.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.MFAMethodNotFoundException">
        /// This exception is thrown when Amazon Cognito cannot find a multi-factor authentication
        /// (MFA) method.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception gets thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordResetRequiredException">
        /// This exception is thrown when a password reset is required.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception gets thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UnexpectedLambdaException">
        /// This exception gets thrown when the Amazon Cognito service encounters an unexpected
        /// exception with the AWS Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserLambdaValidationException">
        /// This exception gets thrown when the Amazon Cognito service encounters a user validation
        /// exception with the AWS Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user is not confirmed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user is not found.
        /// </exception>
        AdminRespondToAuthChallengeResponse AdminRespondToAuthChallenge(AdminRespondToAuthChallengeRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the AdminRespondToAuthChallenge operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminRespondToAuthChallenge operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<AdminRespondToAuthChallengeResponse> AdminRespondToAuthChallengeAsync(AdminRespondToAuthChallengeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AdminSetUserSettings


        /// <summary>
        /// Sets all the user settings for a specified user name. Works on any user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AdminSetUserSettings service method.</param>
        /// 
        /// <returns>The response from the AdminSetUserSettings service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception gets thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user is not found.
        /// </exception>
        AdminSetUserSettingsResponse AdminSetUserSettings(AdminSetUserSettingsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the AdminSetUserSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminSetUserSettings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<AdminSetUserSettingsResponse> AdminSetUserSettingsAsync(AdminSetUserSettingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AdminUpdateDeviceStatus


        /// <summary>
        /// Updates the device status as an administrator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AdminUpdateDeviceStatus service method.</param>
        /// 
        /// <returns>The response from the AdminUpdateDeviceStatus service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidUserPoolConfigurationException">
        /// This exception is thrown when the user pool configuration is invalid.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception gets thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception gets thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user is not found.
        /// </exception>
        AdminUpdateDeviceStatusResponse AdminUpdateDeviceStatus(AdminUpdateDeviceStatusRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the AdminUpdateDeviceStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminUpdateDeviceStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<AdminUpdateDeviceStatusResponse> AdminUpdateDeviceStatusAsync(AdminUpdateDeviceStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AdminUpdateUserAttributes


        /// <summary>
        /// Updates the specified user's attributes, including developer attributes, as an administrator.
        /// Works on any user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AdminUpdateUserAttributes service method.</param>
        /// 
        /// <returns>The response from the AdminUpdateUserAttributes service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.AliasExistsException">
        /// This exception is thrown when a user tries to confirm the account with an email or
        /// phone number that has already been supplied as an alias from a different account.
        /// This exception tells user that an account with this email or phone already exists.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidLambdaResponseException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid AWS
        /// Lambda response.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception gets thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception gets thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UnexpectedLambdaException">
        /// This exception gets thrown when the Amazon Cognito service encounters an unexpected
        /// exception with the AWS Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserLambdaValidationException">
        /// This exception gets thrown when the Amazon Cognito service encounters a user validation
        /// exception with the AWS Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user is not found.
        /// </exception>
        AdminUpdateUserAttributesResponse AdminUpdateUserAttributes(AdminUpdateUserAttributesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the AdminUpdateUserAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminUpdateUserAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<AdminUpdateUserAttributesResponse> AdminUpdateUserAttributesAsync(AdminUpdateUserAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AdminUserGlobalSignOut


        /// <summary>
        /// Signs out users from all devices, as an administrator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AdminUserGlobalSignOut service method.</param>
        /// 
        /// <returns>The response from the AdminUserGlobalSignOut service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception gets thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception gets thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user is not found.
        /// </exception>
        AdminUserGlobalSignOutResponse AdminUserGlobalSignOut(AdminUserGlobalSignOutRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the AdminUserGlobalSignOut operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminUserGlobalSignOut operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<AdminUserGlobalSignOutResponse> AdminUserGlobalSignOutAsync(AdminUserGlobalSignOutRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ChangePassword


        /// <summary>
        /// Changes the password for a specified user in a user pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ChangePassword service method.</param>
        /// 
        /// <returns>The response from the ChangePassword service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidPasswordException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid password.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.LimitExceededException">
        /// This exception is thrown when a user exceeds the limit for a requested AWS resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception gets thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordResetRequiredException">
        /// This exception is thrown when a password reset is required.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception gets thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user is not confirmed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user is not found.
        /// </exception>
        ChangePasswordResponse ChangePassword(ChangePasswordRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ChangePassword operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ChangePassword operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ChangePasswordResponse> ChangePasswordAsync(ChangePasswordRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ConfirmDevice


        /// <summary>
        /// Confirms tracking of the device. This API call is the call that beings device tracking.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConfirmDevice service method.</param>
        /// 
        /// <returns>The response from the ConfirmDevice service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidLambdaResponseException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid AWS
        /// Lambda response.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidPasswordException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid password.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidUserPoolConfigurationException">
        /// This exception is thrown when the user pool configuration is invalid.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception gets thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordResetRequiredException">
        /// This exception is thrown when a password reset is required.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception gets thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UsernameExistsException">
        /// This exception is thrown when Amazon Cognito encounters a user name that already exists
        /// in the user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user is not confirmed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user is not found.
        /// </exception>
        ConfirmDeviceResponse ConfirmDevice(ConfirmDeviceRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ConfirmDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConfirmDevice operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ConfirmDeviceResponse> ConfirmDeviceAsync(ConfirmDeviceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ConfirmForgotPassword


        /// <summary>
        /// Allows a user to enter a code provided when they reset their password to update their
        /// password.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConfirmForgotPassword service method.</param>
        /// 
        /// <returns>The response from the ConfirmForgotPassword service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.CodeMismatchException">
        /// This exception is thrown if the provided code does not match what the server was expecting.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ExpiredCodeException">
        /// This exception is thrown if a code has expired.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidLambdaResponseException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid AWS
        /// Lambda response.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidPasswordException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid password.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.LimitExceededException">
        /// This exception is thrown when a user exceeds the limit for a requested AWS resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception gets thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyFailedAttemptsException">
        /// This exception gets thrown when the user has made too many failed attempts for a given
        /// action (e.g., sign in).
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception gets thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UnexpectedLambdaException">
        /// This exception gets thrown when the Amazon Cognito service encounters an unexpected
        /// exception with the AWS Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserLambdaValidationException">
        /// This exception gets thrown when the Amazon Cognito service encounters a user validation
        /// exception with the AWS Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user is not confirmed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user is not found.
        /// </exception>
        ConfirmForgotPasswordResponse ConfirmForgotPassword(ConfirmForgotPasswordRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ConfirmForgotPassword operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConfirmForgotPassword operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ConfirmForgotPasswordResponse> ConfirmForgotPasswordAsync(ConfirmForgotPasswordRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ConfirmSignUp


        /// <summary>
        /// Confirms registration of a user and handles the existing alias from a previous user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConfirmSignUp service method.</param>
        /// 
        /// <returns>The response from the ConfirmSignUp service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.AliasExistsException">
        /// This exception is thrown when a user tries to confirm the account with an email or
        /// phone number that has already been supplied as an alias from a different account.
        /// This exception tells user that an account with this email or phone already exists.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.CodeMismatchException">
        /// This exception is thrown if the provided code does not match what the server was expecting.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ExpiredCodeException">
        /// This exception is thrown if a code has expired.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidLambdaResponseException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid AWS
        /// Lambda response.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.LimitExceededException">
        /// This exception is thrown when a user exceeds the limit for a requested AWS resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception gets thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyFailedAttemptsException">
        /// This exception gets thrown when the user has made too many failed attempts for a given
        /// action (e.g., sign in).
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception gets thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UnexpectedLambdaException">
        /// This exception gets thrown when the Amazon Cognito service encounters an unexpected
        /// exception with the AWS Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserLambdaValidationException">
        /// This exception gets thrown when the Amazon Cognito service encounters a user validation
        /// exception with the AWS Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user is not found.
        /// </exception>
        ConfirmSignUpResponse ConfirmSignUp(ConfirmSignUpRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ConfirmSignUp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConfirmSignUp operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ConfirmSignUpResponse> ConfirmSignUpAsync(ConfirmSignUpRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateUserImportJob


        /// <summary>
        /// Creates the user import job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUserImportJob service method.</param>
        /// 
        /// <returns>The response from the CreateUserImportJob service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.LimitExceededException">
        /// This exception is thrown when a user exceeds the limit for a requested AWS resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception gets thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PreconditionNotMetException">
        /// This exception is thrown when a precondition is not met.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception gets thrown when the user has made too many requests for a given operation.
        /// </exception>
        CreateUserImportJobResponse CreateUserImportJob(CreateUserImportJobRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateUserImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUserImportJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateUserImportJobResponse> CreateUserImportJobAsync(CreateUserImportJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateUserPool


        /// <summary>
        /// Creates a new Amazon Cognito user pool and sets the password policy for the pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUserPool service method.</param>
        /// 
        /// <returns>The response from the CreateUserPool service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidEmailRoleAccessPolicyException">
        /// This exception is thrown when Amazon Cognito is not allowed to use your email identity.
        /// HTTP status code: 400.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidSmsRoleAccessPolicyException">
        /// This exception is returned when the role provided for SMS configuration does not have
        /// permission to publish using Amazon SNS.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidSmsRoleTrustRelationshipException">
        /// This exception is thrown when the trust relationship is invalid for the role provided
        /// for SMS configuration. This can happen if you do not trust <b>cognito-idp.amazonaws.com</b>
        /// or the external ID provided in the role does not match what is provided in the SMS
        /// configuration for the user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.LimitExceededException">
        /// This exception is thrown when a user exceeds the limit for a requested AWS resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception gets thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception gets thrown when the user has made too many requests for a given operation.
        /// </exception>
        CreateUserPoolResponse CreateUserPool(CreateUserPoolRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateUserPool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUserPool operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateUserPoolResponse> CreateUserPoolAsync(CreateUserPoolRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateUserPoolClient


        /// <summary>
        /// Creates the user pool client.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUserPoolClient service method.</param>
        /// 
        /// <returns>The response from the CreateUserPoolClient service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.LimitExceededException">
        /// This exception is thrown when a user exceeds the limit for a requested AWS resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception gets thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception gets thrown when the user has made too many requests for a given operation.
        /// </exception>
        CreateUserPoolClientResponse CreateUserPoolClient(CreateUserPoolClientRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateUserPoolClient operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUserPoolClient operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateUserPoolClientResponse> CreateUserPoolClientAsync(CreateUserPoolClientRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteUser


        /// <summary>
        /// Allows a user to delete one's self.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser service method.</param>
        /// 
        /// <returns>The response from the DeleteUser service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception gets thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordResetRequiredException">
        /// This exception is thrown when a password reset is required.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception gets thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user is not confirmed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user is not found.
        /// </exception>
        DeleteUserResponse DeleteUser(DeleteUserRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteUserResponse> DeleteUserAsync(DeleteUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteUserAttributes


        /// <summary>
        /// Deletes the attributes for a user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserAttributes service method.</param>
        /// 
        /// <returns>The response from the DeleteUserAttributes service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception gets thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordResetRequiredException">
        /// This exception is thrown when a password reset is required.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception gets thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user is not confirmed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user is not found.
        /// </exception>
        DeleteUserAttributesResponse DeleteUserAttributes(DeleteUserAttributesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUserAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteUserAttributesResponse> DeleteUserAttributesAsync(DeleteUserAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteUserPool


        /// <summary>
        /// Deletes the specified Amazon Cognito user pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserPool service method.</param>
        /// 
        /// <returns>The response from the DeleteUserPool service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception gets thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception gets thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserImportInProgressException">
        /// This exception is thrown when you are trying to modify a user pool while a user import
        /// job is in progress for that pool.
        /// </exception>
        DeleteUserPoolResponse DeleteUserPool(DeleteUserPoolRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUserPool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserPool operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteUserPoolResponse> DeleteUserPoolAsync(DeleteUserPoolRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteUserPoolClient


        /// <summary>
        /// Allows the developer to delete the user pool client.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserPoolClient service method.</param>
        /// 
        /// <returns>The response from the DeleteUserPoolClient service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception gets thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception gets thrown when the user has made too many requests for a given operation.
        /// </exception>
        DeleteUserPoolClientResponse DeleteUserPoolClient(DeleteUserPoolClientRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUserPoolClient operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserPoolClient operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteUserPoolClientResponse> DeleteUserPoolClientAsync(DeleteUserPoolClientRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeUserImportJob


        /// <summary>
        /// Describes the user import job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUserImportJob service method.</param>
        /// 
        /// <returns>The response from the DescribeUserImportJob service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception gets thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception gets thrown when the user has made too many requests for a given operation.
        /// </exception>
        DescribeUserImportJobResponse DescribeUserImportJob(DescribeUserImportJobRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeUserImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeUserImportJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeUserImportJobResponse> DescribeUserImportJobAsync(DescribeUserImportJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeUserPool


        /// <summary>
        /// Returns the configuration information and metadata of the specified user pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUserPool service method.</param>
        /// 
        /// <returns>The response from the DescribeUserPool service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception gets thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception gets thrown when the user has made too many requests for a given operation.
        /// </exception>
        DescribeUserPoolResponse DescribeUserPool(DescribeUserPoolRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeUserPool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeUserPool operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeUserPoolResponse> DescribeUserPoolAsync(DescribeUserPoolRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeUserPoolClient


        /// <summary>
        /// Client method for returning the configuration information and metadata of the specified
        /// user pool client.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUserPoolClient service method.</param>
        /// 
        /// <returns>The response from the DescribeUserPoolClient service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception gets thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception gets thrown when the user has made too many requests for a given operation.
        /// </exception>
        DescribeUserPoolClientResponse DescribeUserPoolClient(DescribeUserPoolClientRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeUserPoolClient operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeUserPoolClient operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeUserPoolClientResponse> DescribeUserPoolClientAsync(DescribeUserPoolClientRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ForgetDevice


        /// <summary>
        /// Forgets the specified device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ForgetDevice service method.</param>
        /// 
        /// <returns>The response from the ForgetDevice service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidUserPoolConfigurationException">
        /// This exception is thrown when the user pool configuration is invalid.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception gets thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordResetRequiredException">
        /// This exception is thrown when a password reset is required.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception gets thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user is not confirmed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user is not found.
        /// </exception>
        ForgetDeviceResponse ForgetDevice(ForgetDeviceRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ForgetDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ForgetDevice operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ForgetDeviceResponse> ForgetDeviceAsync(ForgetDeviceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ForgotPassword


        /// <summary>
        /// Retrieves the password for the specified client ID or username.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ForgotPassword service method.</param>
        /// 
        /// <returns>The response from the ForgotPassword service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.CodeDeliveryFailureException">
        /// This exception is thrown when a verification code fails to deliver successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidEmailRoleAccessPolicyException">
        /// This exception is thrown when Amazon Cognito is not allowed to use your email identity.
        /// HTTP status code: 400.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidLambdaResponseException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid AWS
        /// Lambda response.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidSmsRoleAccessPolicyException">
        /// This exception is returned when the role provided for SMS configuration does not have
        /// permission to publish using Amazon SNS.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidSmsRoleTrustRelationshipException">
        /// This exception is thrown when the trust relationship is invalid for the role provided
        /// for SMS configuration. This can happen if you do not trust <b>cognito-idp.amazonaws.com</b>
        /// or the external ID provided in the role does not match what is provided in the SMS
        /// configuration for the user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.LimitExceededException">
        /// This exception is thrown when a user exceeds the limit for a requested AWS resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception gets thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception gets thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UnexpectedLambdaException">
        /// This exception gets thrown when the Amazon Cognito service encounters an unexpected
        /// exception with the AWS Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserLambdaValidationException">
        /// This exception gets thrown when the Amazon Cognito service encounters a user validation
        /// exception with the AWS Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user is not confirmed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user is not found.
        /// </exception>
        ForgotPasswordResponse ForgotPassword(ForgotPasswordRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ForgotPassword operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ForgotPassword operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ForgotPasswordResponse> ForgotPasswordAsync(ForgotPasswordRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetCSVHeader


        /// <summary>
        /// Gets the header information for the .csv file to be used as input for the user import
        /// job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCSVHeader service method.</param>
        /// 
        /// <returns>The response from the GetCSVHeader service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception gets thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception gets thrown when the user has made too many requests for a given operation.
        /// </exception>
        GetCSVHeaderResponse GetCSVHeader(GetCSVHeaderRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetCSVHeader operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCSVHeader operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetCSVHeaderResponse> GetCSVHeaderAsync(GetCSVHeaderRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDevice


        /// <summary>
        /// Gets the device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDevice service method.</param>
        /// 
        /// <returns>The response from the GetDevice service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidUserPoolConfigurationException">
        /// This exception is thrown when the user pool configuration is invalid.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception gets thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordResetRequiredException">
        /// This exception is thrown when a password reset is required.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception gets thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user is not confirmed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user is not found.
        /// </exception>
        GetDeviceResponse GetDevice(GetDeviceRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDevice operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetDeviceResponse> GetDeviceAsync(GetDeviceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetUser


        /// <summary>
        /// Gets the user attributes and metadata for a user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUser service method.</param>
        /// 
        /// <returns>The response from the GetUser service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception gets thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordResetRequiredException">
        /// This exception is thrown when a password reset is required.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception gets thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user is not confirmed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user is not found.
        /// </exception>
        GetUserResponse GetUser(GetUserRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUser operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetUserResponse> GetUserAsync(GetUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetUserAttributeVerificationCode


        /// <summary>
        /// Gets the user attribute verification code for the specified attribute name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUserAttributeVerificationCode service method.</param>
        /// 
        /// <returns>The response from the GetUserAttributeVerificationCode service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.CodeDeliveryFailureException">
        /// This exception is thrown when a verification code fails to deliver successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidEmailRoleAccessPolicyException">
        /// This exception is thrown when Amazon Cognito is not allowed to use your email identity.
        /// HTTP status code: 400.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidLambdaResponseException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid AWS
        /// Lambda response.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidSmsRoleAccessPolicyException">
        /// This exception is returned when the role provided for SMS configuration does not have
        /// permission to publish using Amazon SNS.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidSmsRoleTrustRelationshipException">
        /// This exception is thrown when the trust relationship is invalid for the role provided
        /// for SMS configuration. This can happen if you do not trust <b>cognito-idp.amazonaws.com</b>
        /// or the external ID provided in the role does not match what is provided in the SMS
        /// configuration for the user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.LimitExceededException">
        /// This exception is thrown when a user exceeds the limit for a requested AWS resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception gets thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordResetRequiredException">
        /// This exception is thrown when a password reset is required.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception gets thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UnexpectedLambdaException">
        /// This exception gets thrown when the Amazon Cognito service encounters an unexpected
        /// exception with the AWS Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserLambdaValidationException">
        /// This exception gets thrown when the Amazon Cognito service encounters a user validation
        /// exception with the AWS Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user is not confirmed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user is not found.
        /// </exception>
        GetUserAttributeVerificationCodeResponse GetUserAttributeVerificationCode(GetUserAttributeVerificationCodeRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetUserAttributeVerificationCode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUserAttributeVerificationCode operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetUserAttributeVerificationCodeResponse> GetUserAttributeVerificationCodeAsync(GetUserAttributeVerificationCodeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GlobalSignOut


        /// <summary>
        /// Signs out users from all devices.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GlobalSignOut service method.</param>
        /// 
        /// <returns>The response from the GlobalSignOut service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception gets thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception gets thrown when the user has made too many requests for a given operation.
        /// </exception>
        GlobalSignOutResponse GlobalSignOut(GlobalSignOutRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GlobalSignOut operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GlobalSignOut operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GlobalSignOutResponse> GlobalSignOutAsync(GlobalSignOutRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  InitiateAuth


        /// <summary>
        /// Initiates the authentication flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InitiateAuth service method.</param>
        /// 
        /// <returns>The response from the InitiateAuth service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidLambdaResponseException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid AWS
        /// Lambda response.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidUserPoolConfigurationException">
        /// This exception is thrown when the user pool configuration is invalid.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception gets thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordResetRequiredException">
        /// This exception is thrown when a password reset is required.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception gets thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UnexpectedLambdaException">
        /// This exception gets thrown when the Amazon Cognito service encounters an unexpected
        /// exception with the AWS Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserLambdaValidationException">
        /// This exception gets thrown when the Amazon Cognito service encounters a user validation
        /// exception with the AWS Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user is not confirmed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user is not found.
        /// </exception>
        InitiateAuthResponse InitiateAuth(InitiateAuthRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the InitiateAuth operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InitiateAuth operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<InitiateAuthResponse> InitiateAuthAsync(InitiateAuthRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListDevices


        /// <summary>
        /// Lists the devices.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDevices service method.</param>
        /// 
        /// <returns>The response from the ListDevices service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidUserPoolConfigurationException">
        /// This exception is thrown when the user pool configuration is invalid.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception gets thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordResetRequiredException">
        /// This exception is thrown when a password reset is required.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception gets thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user is not confirmed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user is not found.
        /// </exception>
        ListDevicesResponse ListDevices(ListDevicesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListDevices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDevices operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListDevicesResponse> ListDevicesAsync(ListDevicesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListUserImportJobs


        /// <summary>
        /// Lists the user import jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUserImportJobs service method.</param>
        /// 
        /// <returns>The response from the ListUserImportJobs service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception gets thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception gets thrown when the user has made too many requests for a given operation.
        /// </exception>
        ListUserImportJobsResponse ListUserImportJobs(ListUserImportJobsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListUserImportJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUserImportJobs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListUserImportJobsResponse> ListUserImportJobsAsync(ListUserImportJobsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListUserPoolClients


        /// <summary>
        /// Lists the clients that have been created for the specified user pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUserPoolClients service method.</param>
        /// 
        /// <returns>The response from the ListUserPoolClients service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception gets thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception gets thrown when the user has made too many requests for a given operation.
        /// </exception>
        ListUserPoolClientsResponse ListUserPoolClients(ListUserPoolClientsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListUserPoolClients operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUserPoolClients operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListUserPoolClientsResponse> ListUserPoolClientsAsync(ListUserPoolClientsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListUserPools


        /// <summary>
        /// Lists the user pools associated with an AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUserPools service method.</param>
        /// 
        /// <returns>The response from the ListUserPools service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception gets thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception gets thrown when the user has made too many requests for a given operation.
        /// </exception>
        ListUserPoolsResponse ListUserPools(ListUserPoolsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListUserPools operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUserPools operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListUserPoolsResponse> ListUserPoolsAsync(ListUserPoolsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListUsers


        /// <summary>
        /// Lists the users in the Amazon Cognito user pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUsers service method.</param>
        /// 
        /// <returns>The response from the ListUsers service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception gets thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception gets thrown when the user has made too many requests for a given operation.
        /// </exception>
        ListUsersResponse ListUsers(ListUsersRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListUsers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUsers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListUsersResponse> ListUsersAsync(ListUsersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ResendConfirmationCode


        /// <summary>
        /// Resends the confirmation (for confirmation of registration) to a specific user in
        /// the user pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResendConfirmationCode service method.</param>
        /// 
        /// <returns>The response from the ResendConfirmationCode service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.CodeDeliveryFailureException">
        /// This exception is thrown when a verification code fails to deliver successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidEmailRoleAccessPolicyException">
        /// This exception is thrown when Amazon Cognito is not allowed to use your email identity.
        /// HTTP status code: 400.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidLambdaResponseException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid AWS
        /// Lambda response.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidSmsRoleAccessPolicyException">
        /// This exception is returned when the role provided for SMS configuration does not have
        /// permission to publish using Amazon SNS.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidSmsRoleTrustRelationshipException">
        /// This exception is thrown when the trust relationship is invalid for the role provided
        /// for SMS configuration. This can happen if you do not trust <b>cognito-idp.amazonaws.com</b>
        /// or the external ID provided in the role does not match what is provided in the SMS
        /// configuration for the user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.LimitExceededException">
        /// This exception is thrown when a user exceeds the limit for a requested AWS resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception gets thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception gets thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UnexpectedLambdaException">
        /// This exception gets thrown when the Amazon Cognito service encounters an unexpected
        /// exception with the AWS Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserLambdaValidationException">
        /// This exception gets thrown when the Amazon Cognito service encounters a user validation
        /// exception with the AWS Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user is not found.
        /// </exception>
        ResendConfirmationCodeResponse ResendConfirmationCode(ResendConfirmationCodeRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ResendConfirmationCode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResendConfirmationCode operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ResendConfirmationCodeResponse> ResendConfirmationCodeAsync(ResendConfirmationCodeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RespondToAuthChallenge


        /// <summary>
        /// Responds to the authentication challenge.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RespondToAuthChallenge service method.</param>
        /// 
        /// <returns>The response from the RespondToAuthChallenge service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.AliasExistsException">
        /// This exception is thrown when a user tries to confirm the account with an email or
        /// phone number that has already been supplied as an alias from a different account.
        /// This exception tells user that an account with this email or phone already exists.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.CodeMismatchException">
        /// This exception is thrown if the provided code does not match what the server was expecting.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ExpiredCodeException">
        /// This exception is thrown if a code has expired.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidLambdaResponseException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid AWS
        /// Lambda response.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidSmsRoleAccessPolicyException">
        /// This exception is returned when the role provided for SMS configuration does not have
        /// permission to publish using Amazon SNS.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidSmsRoleTrustRelationshipException">
        /// This exception is thrown when the trust relationship is invalid for the role provided
        /// for SMS configuration. This can happen if you do not trust <b>cognito-idp.amazonaws.com</b>
        /// or the external ID provided in the role does not match what is provided in the SMS
        /// configuration for the user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidUserPoolConfigurationException">
        /// This exception is thrown when the user pool configuration is invalid.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.MFAMethodNotFoundException">
        /// This exception is thrown when Amazon Cognito cannot find a multi-factor authentication
        /// (MFA) method.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception gets thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordResetRequiredException">
        /// This exception is thrown when a password reset is required.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception gets thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UnexpectedLambdaException">
        /// This exception gets thrown when the Amazon Cognito service encounters an unexpected
        /// exception with the AWS Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserLambdaValidationException">
        /// This exception gets thrown when the Amazon Cognito service encounters a user validation
        /// exception with the AWS Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user is not confirmed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user is not found.
        /// </exception>
        RespondToAuthChallengeResponse RespondToAuthChallenge(RespondToAuthChallengeRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the RespondToAuthChallenge operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RespondToAuthChallenge operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RespondToAuthChallengeResponse> RespondToAuthChallengeAsync(RespondToAuthChallengeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SetUserSettings


        /// <summary>
        /// Sets the user settings like multi-factor authentication (MFA). If MFA is to be removed
        /// for a particular attribute pass the attribute with code delivery as null. If null
        /// list is passed, all MFA options are removed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetUserSettings service method.</param>
        /// 
        /// <returns>The response from the SetUserSettings service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception gets thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordResetRequiredException">
        /// This exception is thrown when a password reset is required.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user is not confirmed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user is not found.
        /// </exception>
        SetUserSettingsResponse SetUserSettings(SetUserSettingsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the SetUserSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetUserSettings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<SetUserSettingsResponse> SetUserSettingsAsync(SetUserSettingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SignUp


        /// <summary>
        /// Registers the user in the specified user pool and creates a user name, password, and
        /// user attributes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SignUp service method.</param>
        /// 
        /// <returns>The response from the SignUp service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.CodeDeliveryFailureException">
        /// This exception is thrown when a verification code fails to deliver successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidEmailRoleAccessPolicyException">
        /// This exception is thrown when Amazon Cognito is not allowed to use your email identity.
        /// HTTP status code: 400.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidLambdaResponseException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid AWS
        /// Lambda response.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidPasswordException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid password.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidSmsRoleAccessPolicyException">
        /// This exception is returned when the role provided for SMS configuration does not have
        /// permission to publish using Amazon SNS.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidSmsRoleTrustRelationshipException">
        /// This exception is thrown when the trust relationship is invalid for the role provided
        /// for SMS configuration. This can happen if you do not trust <b>cognito-idp.amazonaws.com</b>
        /// or the external ID provided in the role does not match what is provided in the SMS
        /// configuration for the user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception gets thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception gets thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UnexpectedLambdaException">
        /// This exception gets thrown when the Amazon Cognito service encounters an unexpected
        /// exception with the AWS Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserLambdaValidationException">
        /// This exception gets thrown when the Amazon Cognito service encounters a user validation
        /// exception with the AWS Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UsernameExistsException">
        /// This exception is thrown when Amazon Cognito encounters a user name that already exists
        /// in the user pool.
        /// </exception>
        SignUpResponse SignUp(SignUpRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the SignUp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SignUp operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<SignUpResponse> SignUpAsync(SignUpRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartUserImportJob


        /// <summary>
        /// Starts the user import.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartUserImportJob service method.</param>
        /// 
        /// <returns>The response from the StartUserImportJob service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception gets thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PreconditionNotMetException">
        /// This exception is thrown when a precondition is not met.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception gets thrown when the user has made too many requests for a given operation.
        /// </exception>
        StartUserImportJobResponse StartUserImportJob(StartUserImportJobRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the StartUserImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartUserImportJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<StartUserImportJobResponse> StartUserImportJobAsync(StartUserImportJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StopUserImportJob


        /// <summary>
        /// Stops the user import job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopUserImportJob service method.</param>
        /// 
        /// <returns>The response from the StopUserImportJob service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception gets thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PreconditionNotMetException">
        /// This exception is thrown when a precondition is not met.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception gets thrown when the user has made too many requests for a given operation.
        /// </exception>
        StopUserImportJobResponse StopUserImportJob(StopUserImportJobRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the StopUserImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopUserImportJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<StopUserImportJobResponse> StopUserImportJobAsync(StopUserImportJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateDeviceStatus


        /// <summary>
        /// Updates the device status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDeviceStatus service method.</param>
        /// 
        /// <returns>The response from the UpdateDeviceStatus service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidUserPoolConfigurationException">
        /// This exception is thrown when the user pool configuration is invalid.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception gets thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordResetRequiredException">
        /// This exception is thrown when a password reset is required.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception gets thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user is not confirmed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user is not found.
        /// </exception>
        UpdateDeviceStatusResponse UpdateDeviceStatus(UpdateDeviceStatusRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDeviceStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDeviceStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateDeviceStatusResponse> UpdateDeviceStatusAsync(UpdateDeviceStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateUserAttributes


        /// <summary>
        /// Allows a user to update a specific attribute (one at a time).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserAttributes service method.</param>
        /// 
        /// <returns>The response from the UpdateUserAttributes service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.AliasExistsException">
        /// This exception is thrown when a user tries to confirm the account with an email or
        /// phone number that has already been supplied as an alias from a different account.
        /// This exception tells user that an account with this email or phone already exists.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.CodeDeliveryFailureException">
        /// This exception is thrown when a verification code fails to deliver successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.CodeMismatchException">
        /// This exception is thrown if the provided code does not match what the server was expecting.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ExpiredCodeException">
        /// This exception is thrown if a code has expired.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidEmailRoleAccessPolicyException">
        /// This exception is thrown when Amazon Cognito is not allowed to use your email identity.
        /// HTTP status code: 400.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidLambdaResponseException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid AWS
        /// Lambda response.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidSmsRoleAccessPolicyException">
        /// This exception is returned when the role provided for SMS configuration does not have
        /// permission to publish using Amazon SNS.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidSmsRoleTrustRelationshipException">
        /// This exception is thrown when the trust relationship is invalid for the role provided
        /// for SMS configuration. This can happen if you do not trust <b>cognito-idp.amazonaws.com</b>
        /// or the external ID provided in the role does not match what is provided in the SMS
        /// configuration for the user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception gets thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordResetRequiredException">
        /// This exception is thrown when a password reset is required.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception gets thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UnexpectedLambdaException">
        /// This exception gets thrown when the Amazon Cognito service encounters an unexpected
        /// exception with the AWS Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserLambdaValidationException">
        /// This exception gets thrown when the Amazon Cognito service encounters a user validation
        /// exception with the AWS Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user is not confirmed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user is not found.
        /// </exception>
        UpdateUserAttributesResponse UpdateUserAttributes(UpdateUserAttributesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUserAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateUserAttributesResponse> UpdateUserAttributesAsync(UpdateUserAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateUserPool


        /// <summary>
        /// Updates the specified user pool with the specified attributes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserPool service method.</param>
        /// 
        /// <returns>The response from the UpdateUserPool service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ConcurrentModificationException">
        /// This exception is thrown if two or more modifications are happening concurrently.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidEmailRoleAccessPolicyException">
        /// This exception is thrown when Amazon Cognito is not allowed to use your email identity.
        /// HTTP status code: 400.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidSmsRoleAccessPolicyException">
        /// This exception is returned when the role provided for SMS configuration does not have
        /// permission to publish using Amazon SNS.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidSmsRoleTrustRelationshipException">
        /// This exception is thrown when the trust relationship is invalid for the role provided
        /// for SMS configuration. This can happen if you do not trust <b>cognito-idp.amazonaws.com</b>
        /// or the external ID provided in the role does not match what is provided in the SMS
        /// configuration for the user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception gets thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception gets thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserImportInProgressException">
        /// This exception is thrown when you are trying to modify a user pool while a user import
        /// job is in progress for that pool.
        /// </exception>
        UpdateUserPoolResponse UpdateUserPool(UpdateUserPoolRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUserPool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserPool operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateUserPoolResponse> UpdateUserPoolAsync(UpdateUserPoolRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateUserPoolClient


        /// <summary>
        /// Allows the developer to update the specified user pool client and password policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserPoolClient service method.</param>
        /// 
        /// <returns>The response from the UpdateUserPoolClient service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception gets thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception gets thrown when the user has made too many requests for a given operation.
        /// </exception>
        UpdateUserPoolClientResponse UpdateUserPoolClient(UpdateUserPoolClientRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUserPoolClient operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserPoolClient operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateUserPoolClientResponse> UpdateUserPoolClientAsync(UpdateUserPoolClientRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  VerifyUserAttribute


        /// <summary>
        /// Verifies the specified user attributes in the user pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the VerifyUserAttribute service method.</param>
        /// 
        /// <returns>The response from the VerifyUserAttribute service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.CodeMismatchException">
        /// This exception is thrown if the provided code does not match what the server was expecting.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ExpiredCodeException">
        /// This exception is thrown if a code has expired.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.LimitExceededException">
        /// This exception is thrown when a user exceeds the limit for a requested AWS resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception gets thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordResetRequiredException">
        /// This exception is thrown when a password reset is required.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception gets thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user is not confirmed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user is not found.
        /// </exception>
        VerifyUserAttributeResponse VerifyUserAttribute(VerifyUserAttributeRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the VerifyUserAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the VerifyUserAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<VerifyUserAttributeResponse> VerifyUserAttributeAsync(VerifyUserAttributeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}