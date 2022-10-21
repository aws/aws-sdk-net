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
    /// Using the Amazon Cognito user pools API, you can create a user pool to manage directories
    /// and users. You can authenticate a user to obtain tokens related to user identity and
    /// access policies.
    /// 
    ///  
    /// <para>
    /// This API reference provides information about user pools in Amazon Cognito user pools.
    /// </para>
    ///  
    /// <para>
    /// For more information, see the <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/what-is-amazon-cognito.html">Amazon
    /// Cognito Documentation</a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonCognitoIdentityProvider : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        ICognitoIdentityProviderPaginatorFactory Paginators { get; }

        
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
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserImportInProgressException">
        /// This exception is thrown when you're trying to modify a user pool while a user import
        /// job is in progress for that pool.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AddCustomAttributes">REST API Reference for AddCustomAttributes Operation</seealso>
        AddCustomAttributesResponse AddCustomAttributes(AddCustomAttributesRequest request);



        /// <summary>
        /// Adds additional user attributes to the user pool schema.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddCustomAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddCustomAttributes service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserImportInProgressException">
        /// This exception is thrown when you're trying to modify a user pool while a user import
        /// job is in progress for that pool.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AddCustomAttributes">REST API Reference for AddCustomAttributes Operation</seealso>
        Task<AddCustomAttributesResponse> AddCustomAttributesAsync(AddCustomAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AdminAddUserToGroup


        /// <summary>
        /// Adds the specified user to the specified group.
        /// 
        ///  
        /// <para>
        /// Calling this action requires developer credentials.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AdminAddUserToGroup service method.</param>
        /// 
        /// <returns>The response from the AdminAddUserToGroup service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminAddUserToGroup">REST API Reference for AdminAddUserToGroup Operation</seealso>
        AdminAddUserToGroupResponse AdminAddUserToGroup(AdminAddUserToGroupRequest request);



        /// <summary>
        /// Adds the specified user to the specified group.
        /// 
        ///  
        /// <para>
        /// Calling this action requires developer credentials.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AdminAddUserToGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AdminAddUserToGroup service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminAddUserToGroup">REST API Reference for AdminAddUserToGroup Operation</seealso>
        Task<AdminAddUserToGroupResponse> AdminAddUserToGroupAsync(AdminAddUserToGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AdminConfirmSignUp


        /// <summary>
        /// Confirms user registration as an admin without using a confirmation code. Works on
        /// any user.
        /// 
        ///  
        /// <para>
        /// Calling this action requires developer credentials.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AdminConfirmSignUp service method.</param>
        /// 
        /// <returns>The response from the AdminConfirmSignUp service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidLambdaResponseException">
        /// This exception is thrown when Amazon Cognito encounters an invalid Lambda response.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.LimitExceededException">
        /// This exception is thrown when a user exceeds the limit for a requested Amazon Web
        /// Services resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyFailedAttemptsException">
        /// This exception is thrown when the user has made too many failed attempts for a given
        /// action, such as sign-in.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UnexpectedLambdaException">
        /// This exception is thrown when Amazon Cognito encounters an unexpected exception with
        /// Lambda.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserLambdaValidationException">
        /// This exception is thrown when the Amazon Cognito service encounters a user validation
        /// exception with the Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminConfirmSignUp">REST API Reference for AdminConfirmSignUp Operation</seealso>
        AdminConfirmSignUpResponse AdminConfirmSignUp(AdminConfirmSignUpRequest request);



        /// <summary>
        /// Confirms user registration as an admin without using a confirmation code. Works on
        /// any user.
        /// 
        ///  
        /// <para>
        /// Calling this action requires developer credentials.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AdminConfirmSignUp service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AdminConfirmSignUp service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidLambdaResponseException">
        /// This exception is thrown when Amazon Cognito encounters an invalid Lambda response.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.LimitExceededException">
        /// This exception is thrown when a user exceeds the limit for a requested Amazon Web
        /// Services resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyFailedAttemptsException">
        /// This exception is thrown when the user has made too many failed attempts for a given
        /// action, such as sign-in.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UnexpectedLambdaException">
        /// This exception is thrown when Amazon Cognito encounters an unexpected exception with
        /// Lambda.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserLambdaValidationException">
        /// This exception is thrown when the Amazon Cognito service encounters a user validation
        /// exception with the Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminConfirmSignUp">REST API Reference for AdminConfirmSignUp Operation</seealso>
        Task<AdminConfirmSignUpResponse> AdminConfirmSignUpAsync(AdminConfirmSignUpRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AdminCreateUser


        /// <summary>
        /// Creates a new user in the specified user pool.
        /// 
        ///  
        /// <para>
        /// If <code>MessageAction</code> isn't set, the default is to send a welcome message
        /// via email or phone (SMS).
        /// </para>
        ///  <note> 
        /// <para>
        /// This action might generate an SMS text message. Starting June 1, 2021, US telecom
        /// carriers require you to register an origination phone number before you can send SMS
        /// messages to US phone numbers. If you use SMS text messages in Amazon Cognito, you
        /// must register a phone number with <a href="https://console.aws.amazon.com/pinpoint/home/">Amazon
        /// Pinpoint</a>. Amazon Cognito uses the registered number automatically. Otherwise,
        /// Amazon Cognito users who must receive SMS messages might not be able to sign up, activate
        /// their accounts, or sign in.
        /// </para>
        ///  
        /// <para>
        /// If you have never used SMS text messages with Amazon Cognito or any other Amazon Web
        /// Service, Amazon Simple Notification Service might place your account in the SMS sandbox.
        /// In <i> <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-sms-sandbox.html">sandbox
        /// mode</a> </i>, you can send messages only to verified phone numbers. After you test
        /// your app while in the sandbox environment, you can move out of the sandbox and into
        /// production. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-identity-pools-sms-userpool-settings.html">
        /// SMS message settings for Amazon Cognito user pools</a> in the <i>Amazon Cognito Developer
        /// Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// This message is based on a template that you configured in your call to create or
        /// update a user pool. This template includes your custom sign-up instructions and placeholders
        /// for user name and temporary password.
        /// </para>
        ///  
        /// <para>
        /// Alternatively, you can call <code>AdminCreateUser</code> with <code>SUPPRESS</code>
        /// for the <code>MessageAction</code> parameter, and Amazon Cognito won't send any email.
        /// 
        /// </para>
        ///  
        /// <para>
        /// In either case, the user will be in the <code>FORCE_CHANGE_PASSWORD</code> state until
        /// they sign in and change their password.
        /// </para>
        ///  
        /// <para>
        ///  <code>AdminCreateUser</code> requires developer credentials.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AdminCreateUser service method.</param>
        /// 
        /// <returns>The response from the AdminCreateUser service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.CodeDeliveryFailureException">
        /// This exception is thrown when a verification code fails to deliver successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidLambdaResponseException">
        /// This exception is thrown when Amazon Cognito encounters an invalid Lambda response.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidPasswordException">
        /// This exception is thrown when Amazon Cognito encounters an invalid password.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidSmsRoleAccessPolicyException">
        /// This exception is returned when the role provided for SMS configuration doesn't have
        /// permission to publish using Amazon SNS.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidSmsRoleTrustRelationshipException">
        /// This exception is thrown when the trust relationship is not valid for the role provided
        /// for SMS configuration. This can happen if you don't trust <code>cognito-idp.amazonaws.com</code>
        /// or the external ID provided in the role does not match what is provided in the SMS
        /// configuration for the user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PreconditionNotMetException">
        /// This exception is thrown when a precondition is not met.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UnexpectedLambdaException">
        /// This exception is thrown when Amazon Cognito encounters an unexpected exception with
        /// Lambda.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UnsupportedUserStateException">
        /// The request failed because the user is in an unsupported state.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserLambdaValidationException">
        /// This exception is thrown when the Amazon Cognito service encounters a user validation
        /// exception with the Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UsernameExistsException">
        /// This exception is thrown when Amazon Cognito encounters a user name that already exists
        /// in the user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminCreateUser">REST API Reference for AdminCreateUser Operation</seealso>
        AdminCreateUserResponse AdminCreateUser(AdminCreateUserRequest request);



        /// <summary>
        /// Creates a new user in the specified user pool.
        /// 
        ///  
        /// <para>
        /// If <code>MessageAction</code> isn't set, the default is to send a welcome message
        /// via email or phone (SMS).
        /// </para>
        ///  <note> 
        /// <para>
        /// This action might generate an SMS text message. Starting June 1, 2021, US telecom
        /// carriers require you to register an origination phone number before you can send SMS
        /// messages to US phone numbers. If you use SMS text messages in Amazon Cognito, you
        /// must register a phone number with <a href="https://console.aws.amazon.com/pinpoint/home/">Amazon
        /// Pinpoint</a>. Amazon Cognito uses the registered number automatically. Otherwise,
        /// Amazon Cognito users who must receive SMS messages might not be able to sign up, activate
        /// their accounts, or sign in.
        /// </para>
        ///  
        /// <para>
        /// If you have never used SMS text messages with Amazon Cognito or any other Amazon Web
        /// Service, Amazon Simple Notification Service might place your account in the SMS sandbox.
        /// In <i> <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-sms-sandbox.html">sandbox
        /// mode</a> </i>, you can send messages only to verified phone numbers. After you test
        /// your app while in the sandbox environment, you can move out of the sandbox and into
        /// production. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-identity-pools-sms-userpool-settings.html">
        /// SMS message settings for Amazon Cognito user pools</a> in the <i>Amazon Cognito Developer
        /// Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// This message is based on a template that you configured in your call to create or
        /// update a user pool. This template includes your custom sign-up instructions and placeholders
        /// for user name and temporary password.
        /// </para>
        ///  
        /// <para>
        /// Alternatively, you can call <code>AdminCreateUser</code> with <code>SUPPRESS</code>
        /// for the <code>MessageAction</code> parameter, and Amazon Cognito won't send any email.
        /// 
        /// </para>
        ///  
        /// <para>
        /// In either case, the user will be in the <code>FORCE_CHANGE_PASSWORD</code> state until
        /// they sign in and change their password.
        /// </para>
        ///  
        /// <para>
        ///  <code>AdminCreateUser</code> requires developer credentials.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AdminCreateUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AdminCreateUser service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.CodeDeliveryFailureException">
        /// This exception is thrown when a verification code fails to deliver successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidLambdaResponseException">
        /// This exception is thrown when Amazon Cognito encounters an invalid Lambda response.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidPasswordException">
        /// This exception is thrown when Amazon Cognito encounters an invalid password.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidSmsRoleAccessPolicyException">
        /// This exception is returned when the role provided for SMS configuration doesn't have
        /// permission to publish using Amazon SNS.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidSmsRoleTrustRelationshipException">
        /// This exception is thrown when the trust relationship is not valid for the role provided
        /// for SMS configuration. This can happen if you don't trust <code>cognito-idp.amazonaws.com</code>
        /// or the external ID provided in the role does not match what is provided in the SMS
        /// configuration for the user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PreconditionNotMetException">
        /// This exception is thrown when a precondition is not met.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UnexpectedLambdaException">
        /// This exception is thrown when Amazon Cognito encounters an unexpected exception with
        /// Lambda.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UnsupportedUserStateException">
        /// The request failed because the user is in an unsupported state.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserLambdaValidationException">
        /// This exception is thrown when the Amazon Cognito service encounters a user validation
        /// exception with the Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UsernameExistsException">
        /// This exception is thrown when Amazon Cognito encounters a user name that already exists
        /// in the user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminCreateUser">REST API Reference for AdminCreateUser Operation</seealso>
        Task<AdminCreateUserResponse> AdminCreateUserAsync(AdminCreateUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AdminDeleteUser


        /// <summary>
        /// Deletes a user as an administrator. Works on any user.
        /// 
        ///  
        /// <para>
        /// Calling this action requires developer credentials.
        /// </para>
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
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminDeleteUser">REST API Reference for AdminDeleteUser Operation</seealso>
        AdminDeleteUserResponse AdminDeleteUser(AdminDeleteUserRequest request);



        /// <summary>
        /// Deletes a user as an administrator. Works on any user.
        /// 
        ///  
        /// <para>
        /// Calling this action requires developer credentials.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AdminDeleteUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AdminDeleteUser service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminDeleteUser">REST API Reference for AdminDeleteUser Operation</seealso>
        Task<AdminDeleteUserResponse> AdminDeleteUserAsync(AdminDeleteUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AdminDeleteUserAttributes


        /// <summary>
        /// Deletes the user attributes in a user pool as an administrator. Works on any user.
        /// 
        ///  
        /// <para>
        /// Calling this action requires developer credentials.
        /// </para>
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
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminDeleteUserAttributes">REST API Reference for AdminDeleteUserAttributes Operation</seealso>
        AdminDeleteUserAttributesResponse AdminDeleteUserAttributes(AdminDeleteUserAttributesRequest request);



        /// <summary>
        /// Deletes the user attributes in a user pool as an administrator. Works on any user.
        /// 
        ///  
        /// <para>
        /// Calling this action requires developer credentials.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AdminDeleteUserAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AdminDeleteUserAttributes service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminDeleteUserAttributes">REST API Reference for AdminDeleteUserAttributes Operation</seealso>
        Task<AdminDeleteUserAttributesResponse> AdminDeleteUserAttributesAsync(AdminDeleteUserAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AdminDisableProviderForUser


        /// <summary>
        /// Prevents the user from signing in with the specified external (SAML or social) identity
        /// provider (IdP). If the user that you want to deactivate is a Amazon Cognito user pools
        /// native username + password user, they can't use their password to sign in. If the
        /// user to deactivate is a linked external IdP user, any link between that user and an
        /// existing user is removed. When the external user signs in again, and the user is no
        /// longer attached to the previously linked <code>DestinationUser</code>, the user must
        /// create a new user account. See <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_AdminLinkProviderForUser.html">AdminLinkProviderForUser</a>.
        /// 
        ///  
        /// <para>
        /// This action is enabled only for admin access and requires developer credentials.
        /// </para>
        ///  
        /// <para>
        /// The <code>ProviderName</code> must match the value specified when creating an IdP
        /// for the pool. 
        /// </para>
        ///  
        /// <para>
        /// To deactivate a native username + password user, the <code>ProviderName</code> value
        /// must be <code>Cognito</code> and the <code>ProviderAttributeName</code> must be <code>Cognito_Subject</code>.
        /// The <code>ProviderAttributeValue</code> must be the name that is used in the user
        /// pool for the user.
        /// </para>
        ///  
        /// <para>
        /// The <code>ProviderAttributeName</code> must always be <code>Cognito_Subject</code>
        /// for social IdPs. The <code>ProviderAttributeValue</code> must always be the exact
        /// subject that was used when the user was originally linked as a source user.
        /// </para>
        ///  
        /// <para>
        /// For de-linking a SAML identity, there are two scenarios. If the linked identity has
        /// not yet been used to sign in, the <code>ProviderAttributeName</code> and <code>ProviderAttributeValue</code>
        /// must be the same values that were used for the <code>SourceUser</code> when the identities
        /// were originally linked using <code> AdminLinkProviderForUser</code> call. (If the
        /// linking was done with <code>ProviderAttributeName</code> set to <code>Cognito_Subject</code>,
        /// the same applies here). However, if the user has already signed in, the <code>ProviderAttributeName</code>
        /// must be <code>Cognito_Subject</code> and <code>ProviderAttributeValue</code> must
        /// be the subject of the SAML assertion.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AdminDisableProviderForUser service method.</param>
        /// 
        /// <returns>The response from the AdminDisableProviderForUser service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.AliasExistsException">
        /// This exception is thrown when a user tries to confirm the account with an email address
        /// or phone number that has already been supplied as an alias for a different user profile.
        /// This exception indicates that an account with this email address or phone already
        /// exists in a user pool that you've configured to use email address or phone number
        /// as a sign-in alias.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminDisableProviderForUser">REST API Reference for AdminDisableProviderForUser Operation</seealso>
        AdminDisableProviderForUserResponse AdminDisableProviderForUser(AdminDisableProviderForUserRequest request);



        /// <summary>
        /// Prevents the user from signing in with the specified external (SAML or social) identity
        /// provider (IdP). If the user that you want to deactivate is a Amazon Cognito user pools
        /// native username + password user, they can't use their password to sign in. If the
        /// user to deactivate is a linked external IdP user, any link between that user and an
        /// existing user is removed. When the external user signs in again, and the user is no
        /// longer attached to the previously linked <code>DestinationUser</code>, the user must
        /// create a new user account. See <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_AdminLinkProviderForUser.html">AdminLinkProviderForUser</a>.
        /// 
        ///  
        /// <para>
        /// This action is enabled only for admin access and requires developer credentials.
        /// </para>
        ///  
        /// <para>
        /// The <code>ProviderName</code> must match the value specified when creating an IdP
        /// for the pool. 
        /// </para>
        ///  
        /// <para>
        /// To deactivate a native username + password user, the <code>ProviderName</code> value
        /// must be <code>Cognito</code> and the <code>ProviderAttributeName</code> must be <code>Cognito_Subject</code>.
        /// The <code>ProviderAttributeValue</code> must be the name that is used in the user
        /// pool for the user.
        /// </para>
        ///  
        /// <para>
        /// The <code>ProviderAttributeName</code> must always be <code>Cognito_Subject</code>
        /// for social IdPs. The <code>ProviderAttributeValue</code> must always be the exact
        /// subject that was used when the user was originally linked as a source user.
        /// </para>
        ///  
        /// <para>
        /// For de-linking a SAML identity, there are two scenarios. If the linked identity has
        /// not yet been used to sign in, the <code>ProviderAttributeName</code> and <code>ProviderAttributeValue</code>
        /// must be the same values that were used for the <code>SourceUser</code> when the identities
        /// were originally linked using <code> AdminLinkProviderForUser</code> call. (If the
        /// linking was done with <code>ProviderAttributeName</code> set to <code>Cognito_Subject</code>,
        /// the same applies here). However, if the user has already signed in, the <code>ProviderAttributeName</code>
        /// must be <code>Cognito_Subject</code> and <code>ProviderAttributeValue</code> must
        /// be the subject of the SAML assertion.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AdminDisableProviderForUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AdminDisableProviderForUser service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.AliasExistsException">
        /// This exception is thrown when a user tries to confirm the account with an email address
        /// or phone number that has already been supplied as an alias for a different user profile.
        /// This exception indicates that an account with this email address or phone already
        /// exists in a user pool that you've configured to use email address or phone number
        /// as a sign-in alias.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminDisableProviderForUser">REST API Reference for AdminDisableProviderForUser Operation</seealso>
        Task<AdminDisableProviderForUserResponse> AdminDisableProviderForUserAsync(AdminDisableProviderForUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AdminDisableUser


        /// <summary>
        /// Deactivates a user and revokes all access tokens for the user. A deactivated user
        /// can't sign in, but still appears in the responses to <code>GetUser</code> and <code>ListUsers</code>
        /// API requests.
        /// 
        ///  
        /// <para>
        /// You must make this API request with Amazon Web Services credentials that have <code>cognito-idp:AdminDisableUser</code>
        /// permissions.
        /// </para>
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
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminDisableUser">REST API Reference for AdminDisableUser Operation</seealso>
        AdminDisableUserResponse AdminDisableUser(AdminDisableUserRequest request);



        /// <summary>
        /// Deactivates a user and revokes all access tokens for the user. A deactivated user
        /// can't sign in, but still appears in the responses to <code>GetUser</code> and <code>ListUsers</code>
        /// API requests.
        /// 
        ///  
        /// <para>
        /// You must make this API request with Amazon Web Services credentials that have <code>cognito-idp:AdminDisableUser</code>
        /// permissions.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AdminDisableUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AdminDisableUser service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminDisableUser">REST API Reference for AdminDisableUser Operation</seealso>
        Task<AdminDisableUserResponse> AdminDisableUserAsync(AdminDisableUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AdminEnableUser


        /// <summary>
        /// Enables the specified user as an administrator. Works on any user.
        /// 
        ///  
        /// <para>
        /// Calling this action requires developer credentials.
        /// </para>
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
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminEnableUser">REST API Reference for AdminEnableUser Operation</seealso>
        AdminEnableUserResponse AdminEnableUser(AdminEnableUserRequest request);



        /// <summary>
        /// Enables the specified user as an administrator. Works on any user.
        /// 
        ///  
        /// <para>
        /// Calling this action requires developer credentials.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AdminEnableUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AdminEnableUser service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminEnableUser">REST API Reference for AdminEnableUser Operation</seealso>
        Task<AdminEnableUserResponse> AdminEnableUserAsync(AdminEnableUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AdminForgetDevice


        /// <summary>
        /// Forgets the device, as an administrator.
        /// 
        ///  
        /// <para>
        /// Calling this action requires developer credentials.
        /// </para>
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
        /// This exception is thrown when the user pool configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminForgetDevice">REST API Reference for AdminForgetDevice Operation</seealso>
        AdminForgetDeviceResponse AdminForgetDevice(AdminForgetDeviceRequest request);



        /// <summary>
        /// Forgets the device, as an administrator.
        /// 
        ///  
        /// <para>
        /// Calling this action requires developer credentials.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AdminForgetDevice service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AdminForgetDevice service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidUserPoolConfigurationException">
        /// This exception is thrown when the user pool configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminForgetDevice">REST API Reference for AdminForgetDevice Operation</seealso>
        Task<AdminForgetDeviceResponse> AdminForgetDeviceAsync(AdminForgetDeviceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AdminGetDevice


        /// <summary>
        /// Gets the device, as an administrator.
        /// 
        ///  
        /// <para>
        /// Calling this action requires developer credentials.
        /// </para>
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
        /// This exception is thrown when the user pool configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminGetDevice">REST API Reference for AdminGetDevice Operation</seealso>
        AdminGetDeviceResponse AdminGetDevice(AdminGetDeviceRequest request);



        /// <summary>
        /// Gets the device, as an administrator.
        /// 
        ///  
        /// <para>
        /// Calling this action requires developer credentials.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AdminGetDevice service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AdminGetDevice service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidUserPoolConfigurationException">
        /// This exception is thrown when the user pool configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminGetDevice">REST API Reference for AdminGetDevice Operation</seealso>
        Task<AdminGetDeviceResponse> AdminGetDeviceAsync(AdminGetDeviceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AdminGetUser


        /// <summary>
        /// Gets the specified user by user name in a user pool as an administrator. Works on
        /// any user.
        /// 
        ///  
        /// <para>
        /// Calling this action requires developer credentials.
        /// </para>
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
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminGetUser">REST API Reference for AdminGetUser Operation</seealso>
        AdminGetUserResponse AdminGetUser(AdminGetUserRequest request);



        /// <summary>
        /// Gets the specified user by user name in a user pool as an administrator. Works on
        /// any user.
        /// 
        ///  
        /// <para>
        /// Calling this action requires developer credentials.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AdminGetUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AdminGetUser service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminGetUser">REST API Reference for AdminGetUser Operation</seealso>
        Task<AdminGetUserResponse> AdminGetUserAsync(AdminGetUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AdminInitiateAuth


        /// <summary>
        /// Initiates the authentication flow, as an administrator.
        /// 
        ///  <note> 
        /// <para>
        /// This action might generate an SMS text message. Starting June 1, 2021, US telecom
        /// carriers require you to register an origination phone number before you can send SMS
        /// messages to US phone numbers. If you use SMS text messages in Amazon Cognito, you
        /// must register a phone number with <a href="https://console.aws.amazon.com/pinpoint/home/">Amazon
        /// Pinpoint</a>. Amazon Cognito uses the registered number automatically. Otherwise,
        /// Amazon Cognito users who must receive SMS messages might not be able to sign up, activate
        /// their accounts, or sign in.
        /// </para>
        ///  
        /// <para>
        /// If you have never used SMS text messages with Amazon Cognito or any other Amazon Web
        /// Service, Amazon Simple Notification Service might place your account in the SMS sandbox.
        /// In <i> <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-sms-sandbox.html">sandbox
        /// mode</a> </i>, you can send messages only to verified phone numbers. After you test
        /// your app while in the sandbox environment, you can move out of the sandbox and into
        /// production. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-identity-pools-sms-userpool-settings.html">
        /// SMS message settings for Amazon Cognito user pools</a> in the <i>Amazon Cognito Developer
        /// Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Calling this action requires developer credentials.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AdminInitiateAuth service method.</param>
        /// 
        /// <returns>The response from the AdminInitiateAuth service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidLambdaResponseException">
        /// This exception is thrown when Amazon Cognito encounters an invalid Lambda response.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidSmsRoleAccessPolicyException">
        /// This exception is returned when the role provided for SMS configuration doesn't have
        /// permission to publish using Amazon SNS.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidSmsRoleTrustRelationshipException">
        /// This exception is thrown when the trust relationship is not valid for the role provided
        /// for SMS configuration. This can happen if you don't trust <code>cognito-idp.amazonaws.com</code>
        /// or the external ID provided in the role does not match what is provided in the SMS
        /// configuration for the user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidUserPoolConfigurationException">
        /// This exception is thrown when the user pool configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.MFAMethodNotFoundException">
        /// This exception is thrown when Amazon Cognito can't find a multi-factor authentication
        /// (MFA) method.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordResetRequiredException">
        /// This exception is thrown when a password reset is required.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UnexpectedLambdaException">
        /// This exception is thrown when Amazon Cognito encounters an unexpected exception with
        /// Lambda.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserLambdaValidationException">
        /// This exception is thrown when the Amazon Cognito service encounters a user validation
        /// exception with the Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user isn't confirmed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminInitiateAuth">REST API Reference for AdminInitiateAuth Operation</seealso>
        AdminInitiateAuthResponse AdminInitiateAuth(AdminInitiateAuthRequest request);



        /// <summary>
        /// Initiates the authentication flow, as an administrator.
        /// 
        ///  <note> 
        /// <para>
        /// This action might generate an SMS text message. Starting June 1, 2021, US telecom
        /// carriers require you to register an origination phone number before you can send SMS
        /// messages to US phone numbers. If you use SMS text messages in Amazon Cognito, you
        /// must register a phone number with <a href="https://console.aws.amazon.com/pinpoint/home/">Amazon
        /// Pinpoint</a>. Amazon Cognito uses the registered number automatically. Otherwise,
        /// Amazon Cognito users who must receive SMS messages might not be able to sign up, activate
        /// their accounts, or sign in.
        /// </para>
        ///  
        /// <para>
        /// If you have never used SMS text messages with Amazon Cognito or any other Amazon Web
        /// Service, Amazon Simple Notification Service might place your account in the SMS sandbox.
        /// In <i> <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-sms-sandbox.html">sandbox
        /// mode</a> </i>, you can send messages only to verified phone numbers. After you test
        /// your app while in the sandbox environment, you can move out of the sandbox and into
        /// production. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-identity-pools-sms-userpool-settings.html">
        /// SMS message settings for Amazon Cognito user pools</a> in the <i>Amazon Cognito Developer
        /// Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Calling this action requires developer credentials.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AdminInitiateAuth service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AdminInitiateAuth service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidLambdaResponseException">
        /// This exception is thrown when Amazon Cognito encounters an invalid Lambda response.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidSmsRoleAccessPolicyException">
        /// This exception is returned when the role provided for SMS configuration doesn't have
        /// permission to publish using Amazon SNS.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidSmsRoleTrustRelationshipException">
        /// This exception is thrown when the trust relationship is not valid for the role provided
        /// for SMS configuration. This can happen if you don't trust <code>cognito-idp.amazonaws.com</code>
        /// or the external ID provided in the role does not match what is provided in the SMS
        /// configuration for the user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidUserPoolConfigurationException">
        /// This exception is thrown when the user pool configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.MFAMethodNotFoundException">
        /// This exception is thrown when Amazon Cognito can't find a multi-factor authentication
        /// (MFA) method.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordResetRequiredException">
        /// This exception is thrown when a password reset is required.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UnexpectedLambdaException">
        /// This exception is thrown when Amazon Cognito encounters an unexpected exception with
        /// Lambda.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserLambdaValidationException">
        /// This exception is thrown when the Amazon Cognito service encounters a user validation
        /// exception with the Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user isn't confirmed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminInitiateAuth">REST API Reference for AdminInitiateAuth Operation</seealso>
        Task<AdminInitiateAuthResponse> AdminInitiateAuthAsync(AdminInitiateAuthRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AdminLinkProviderForUser


        /// <summary>
        /// Links an existing user account in a user pool (<code>DestinationUser</code>) to an
        /// identity from an external IdP (<code>SourceUser</code>) based on a specified attribute
        /// name and value from the external IdP. This allows you to create a link from the existing
        /// user account to an external federated user identity that has not yet been used to
        /// sign in. You can then use the federated user identity to sign in as the existing user
        /// account. 
        /// 
        ///  
        /// <para>
        ///  For example, if there is an existing user with a username and password, this API
        /// links that user to a federated user identity. When the user signs in with a federated
        /// user identity, they sign in as the existing user account.
        /// </para>
        ///  <note> 
        /// <para>
        /// The maximum number of federated identities linked to a user is five.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// Because this API allows a user with an external federated identity to sign in as an
        /// existing user in the user pool, it is critical that it only be used with external
        /// IdPs and provider attributes that have been trusted by the application owner.
        /// </para>
        ///  </important> 
        /// <para>
        /// This action is administrative and requires developer credentials.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AdminLinkProviderForUser service method.</param>
        /// 
        /// <returns>The response from the AdminLinkProviderForUser service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.AliasExistsException">
        /// This exception is thrown when a user tries to confirm the account with an email address
        /// or phone number that has already been supplied as an alias for a different user profile.
        /// This exception indicates that an account with this email address or phone already
        /// exists in a user pool that you've configured to use email address or phone number
        /// as a sign-in alias.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.LimitExceededException">
        /// This exception is thrown when a user exceeds the limit for a requested Amazon Web
        /// Services resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminLinkProviderForUser">REST API Reference for AdminLinkProviderForUser Operation</seealso>
        AdminLinkProviderForUserResponse AdminLinkProviderForUser(AdminLinkProviderForUserRequest request);



        /// <summary>
        /// Links an existing user account in a user pool (<code>DestinationUser</code>) to an
        /// identity from an external IdP (<code>SourceUser</code>) based on a specified attribute
        /// name and value from the external IdP. This allows you to create a link from the existing
        /// user account to an external federated user identity that has not yet been used to
        /// sign in. You can then use the federated user identity to sign in as the existing user
        /// account. 
        /// 
        ///  
        /// <para>
        ///  For example, if there is an existing user with a username and password, this API
        /// links that user to a federated user identity. When the user signs in with a federated
        /// user identity, they sign in as the existing user account.
        /// </para>
        ///  <note> 
        /// <para>
        /// The maximum number of federated identities linked to a user is five.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// Because this API allows a user with an external federated identity to sign in as an
        /// existing user in the user pool, it is critical that it only be used with external
        /// IdPs and provider attributes that have been trusted by the application owner.
        /// </para>
        ///  </important> 
        /// <para>
        /// This action is administrative and requires developer credentials.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AdminLinkProviderForUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AdminLinkProviderForUser service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.AliasExistsException">
        /// This exception is thrown when a user tries to confirm the account with an email address
        /// or phone number that has already been supplied as an alias for a different user profile.
        /// This exception indicates that an account with this email address or phone already
        /// exists in a user pool that you've configured to use email address or phone number
        /// as a sign-in alias.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.LimitExceededException">
        /// This exception is thrown when a user exceeds the limit for a requested Amazon Web
        /// Services resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminLinkProviderForUser">REST API Reference for AdminLinkProviderForUser Operation</seealso>
        Task<AdminLinkProviderForUserResponse> AdminLinkProviderForUserAsync(AdminLinkProviderForUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AdminListDevices


        /// <summary>
        /// Lists devices, as an administrator.
        /// 
        ///  
        /// <para>
        /// Calling this action requires developer credentials.
        /// </para>
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
        /// This exception is thrown when the user pool configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminListDevices">REST API Reference for AdminListDevices Operation</seealso>
        AdminListDevicesResponse AdminListDevices(AdminListDevicesRequest request);



        /// <summary>
        /// Lists devices, as an administrator.
        /// 
        ///  
        /// <para>
        /// Calling this action requires developer credentials.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AdminListDevices service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AdminListDevices service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidUserPoolConfigurationException">
        /// This exception is thrown when the user pool configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminListDevices">REST API Reference for AdminListDevices Operation</seealso>
        Task<AdminListDevicesResponse> AdminListDevicesAsync(AdminListDevicesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AdminListGroupsForUser


        /// <summary>
        /// Lists the groups that the user belongs to.
        /// 
        ///  
        /// <para>
        /// Calling this action requires developer credentials.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AdminListGroupsForUser service method.</param>
        /// 
        /// <returns>The response from the AdminListGroupsForUser service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminListGroupsForUser">REST API Reference for AdminListGroupsForUser Operation</seealso>
        AdminListGroupsForUserResponse AdminListGroupsForUser(AdminListGroupsForUserRequest request);



        /// <summary>
        /// Lists the groups that the user belongs to.
        /// 
        ///  
        /// <para>
        /// Calling this action requires developer credentials.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AdminListGroupsForUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AdminListGroupsForUser service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminListGroupsForUser">REST API Reference for AdminListGroupsForUser Operation</seealso>
        Task<AdminListGroupsForUserResponse> AdminListGroupsForUserAsync(AdminListGroupsForUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AdminListUserAuthEvents


        /// <summary>
        /// A history of user activity and any risks detected as part of Amazon Cognito advanced
        /// security.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AdminListUserAuthEvents service method.</param>
        /// 
        /// <returns>The response from the AdminListUserAuthEvents service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserPoolAddOnNotEnabledException">
        /// This exception is thrown when user pool add-ons aren't enabled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminListUserAuthEvents">REST API Reference for AdminListUserAuthEvents Operation</seealso>
        AdminListUserAuthEventsResponse AdminListUserAuthEvents(AdminListUserAuthEventsRequest request);



        /// <summary>
        /// A history of user activity and any risks detected as part of Amazon Cognito advanced
        /// security.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AdminListUserAuthEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AdminListUserAuthEvents service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserPoolAddOnNotEnabledException">
        /// This exception is thrown when user pool add-ons aren't enabled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminListUserAuthEvents">REST API Reference for AdminListUserAuthEvents Operation</seealso>
        Task<AdminListUserAuthEventsResponse> AdminListUserAuthEventsAsync(AdminListUserAuthEventsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AdminRemoveUserFromGroup


        /// <summary>
        /// Removes the specified user from the specified group.
        /// 
        ///  
        /// <para>
        /// Calling this action requires developer credentials.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AdminRemoveUserFromGroup service method.</param>
        /// 
        /// <returns>The response from the AdminRemoveUserFromGroup service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminRemoveUserFromGroup">REST API Reference for AdminRemoveUserFromGroup Operation</seealso>
        AdminRemoveUserFromGroupResponse AdminRemoveUserFromGroup(AdminRemoveUserFromGroupRequest request);



        /// <summary>
        /// Removes the specified user from the specified group.
        /// 
        ///  
        /// <para>
        /// Calling this action requires developer credentials.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AdminRemoveUserFromGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AdminRemoveUserFromGroup service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminRemoveUserFromGroup">REST API Reference for AdminRemoveUserFromGroup Operation</seealso>
        Task<AdminRemoveUserFromGroupResponse> AdminRemoveUserFromGroupAsync(AdminRemoveUserFromGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ///  <note> 
        /// <para>
        /// This action might generate an SMS text message. Starting June 1, 2021, US telecom
        /// carriers require you to register an origination phone number before you can send SMS
        /// messages to US phone numbers. If you use SMS text messages in Amazon Cognito, you
        /// must register a phone number with <a href="https://console.aws.amazon.com/pinpoint/home/">Amazon
        /// Pinpoint</a>. Amazon Cognito uses the registered number automatically. Otherwise,
        /// Amazon Cognito users who must receive SMS messages might not be able to sign up, activate
        /// their accounts, or sign in.
        /// </para>
        ///  
        /// <para>
        /// If you have never used SMS text messages with Amazon Cognito or any other Amazon Web
        /// Service, Amazon Simple Notification Service might place your account in the SMS sandbox.
        /// In <i> <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-sms-sandbox.html">sandbox
        /// mode</a> </i>, you can send messages only to verified phone numbers. After you test
        /// your app while in the sandbox environment, you can move out of the sandbox and into
        /// production. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-identity-pools-sms-userpool-settings.html">
        /// SMS message settings for Amazon Cognito user pools</a> in the <i>Amazon Cognito Developer
        /// Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Calling this action requires developer credentials.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AdminResetUserPassword service method.</param>
        /// 
        /// <returns>The response from the AdminResetUserPassword service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidEmailRoleAccessPolicyException">
        /// This exception is thrown when Amazon Cognito isn't allowed to use your email identity.
        /// HTTP status code: 400.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidLambdaResponseException">
        /// This exception is thrown when Amazon Cognito encounters an invalid Lambda response.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidSmsRoleAccessPolicyException">
        /// This exception is returned when the role provided for SMS configuration doesn't have
        /// permission to publish using Amazon SNS.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidSmsRoleTrustRelationshipException">
        /// This exception is thrown when the trust relationship is not valid for the role provided
        /// for SMS configuration. This can happen if you don't trust <code>cognito-idp.amazonaws.com</code>
        /// or the external ID provided in the role does not match what is provided in the SMS
        /// configuration for the user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.LimitExceededException">
        /// This exception is thrown when a user exceeds the limit for a requested Amazon Web
        /// Services resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UnexpectedLambdaException">
        /// This exception is thrown when Amazon Cognito encounters an unexpected exception with
        /// Lambda.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserLambdaValidationException">
        /// This exception is thrown when the Amazon Cognito service encounters a user validation
        /// exception with the Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminResetUserPassword">REST API Reference for AdminResetUserPassword Operation</seealso>
        AdminResetUserPasswordResponse AdminResetUserPassword(AdminResetUserPasswordRequest request);



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
        ///  <note> 
        /// <para>
        /// This action might generate an SMS text message. Starting June 1, 2021, US telecom
        /// carriers require you to register an origination phone number before you can send SMS
        /// messages to US phone numbers. If you use SMS text messages in Amazon Cognito, you
        /// must register a phone number with <a href="https://console.aws.amazon.com/pinpoint/home/">Amazon
        /// Pinpoint</a>. Amazon Cognito uses the registered number automatically. Otherwise,
        /// Amazon Cognito users who must receive SMS messages might not be able to sign up, activate
        /// their accounts, or sign in.
        /// </para>
        ///  
        /// <para>
        /// If you have never used SMS text messages with Amazon Cognito or any other Amazon Web
        /// Service, Amazon Simple Notification Service might place your account in the SMS sandbox.
        /// In <i> <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-sms-sandbox.html">sandbox
        /// mode</a> </i>, you can send messages only to verified phone numbers. After you test
        /// your app while in the sandbox environment, you can move out of the sandbox and into
        /// production. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-identity-pools-sms-userpool-settings.html">
        /// SMS message settings for Amazon Cognito user pools</a> in the <i>Amazon Cognito Developer
        /// Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Calling this action requires developer credentials.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AdminResetUserPassword service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AdminResetUserPassword service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidEmailRoleAccessPolicyException">
        /// This exception is thrown when Amazon Cognito isn't allowed to use your email identity.
        /// HTTP status code: 400.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidLambdaResponseException">
        /// This exception is thrown when Amazon Cognito encounters an invalid Lambda response.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidSmsRoleAccessPolicyException">
        /// This exception is returned when the role provided for SMS configuration doesn't have
        /// permission to publish using Amazon SNS.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidSmsRoleTrustRelationshipException">
        /// This exception is thrown when the trust relationship is not valid for the role provided
        /// for SMS configuration. This can happen if you don't trust <code>cognito-idp.amazonaws.com</code>
        /// or the external ID provided in the role does not match what is provided in the SMS
        /// configuration for the user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.LimitExceededException">
        /// This exception is thrown when a user exceeds the limit for a requested Amazon Web
        /// Services resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UnexpectedLambdaException">
        /// This exception is thrown when Amazon Cognito encounters an unexpected exception with
        /// Lambda.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserLambdaValidationException">
        /// This exception is thrown when the Amazon Cognito service encounters a user validation
        /// exception with the Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminResetUserPassword">REST API Reference for AdminResetUserPassword Operation</seealso>
        Task<AdminResetUserPasswordResponse> AdminResetUserPasswordAsync(AdminResetUserPasswordRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AdminRespondToAuthChallenge


        /// <summary>
        /// Responds to an authentication challenge, as an administrator.
        /// 
        ///  <note> 
        /// <para>
        /// This action might generate an SMS text message. Starting June 1, 2021, US telecom
        /// carriers require you to register an origination phone number before you can send SMS
        /// messages to US phone numbers. If you use SMS text messages in Amazon Cognito, you
        /// must register a phone number with <a href="https://console.aws.amazon.com/pinpoint/home/">Amazon
        /// Pinpoint</a>. Amazon Cognito uses the registered number automatically. Otherwise,
        /// Amazon Cognito users who must receive SMS messages might not be able to sign up, activate
        /// their accounts, or sign in.
        /// </para>
        ///  
        /// <para>
        /// If you have never used SMS text messages with Amazon Cognito or any other Amazon Web
        /// Service, Amazon Simple Notification Service might place your account in the SMS sandbox.
        /// In <i> <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-sms-sandbox.html">sandbox
        /// mode</a> </i>, you can send messages only to verified phone numbers. After you test
        /// your app while in the sandbox environment, you can move out of the sandbox and into
        /// production. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-identity-pools-sms-userpool-settings.html">
        /// SMS message settings for Amazon Cognito user pools</a> in the <i>Amazon Cognito Developer
        /// Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Calling this action requires developer credentials.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AdminRespondToAuthChallenge service method.</param>
        /// 
        /// <returns>The response from the AdminRespondToAuthChallenge service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.AliasExistsException">
        /// This exception is thrown when a user tries to confirm the account with an email address
        /// or phone number that has already been supplied as an alias for a different user profile.
        /// This exception indicates that an account with this email address or phone already
        /// exists in a user pool that you've configured to use email address or phone number
        /// as a sign-in alias.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.CodeMismatchException">
        /// This exception is thrown if the provided code doesn't match what the server was expecting.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ExpiredCodeException">
        /// This exception is thrown if a code has expired.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidLambdaResponseException">
        /// This exception is thrown when Amazon Cognito encounters an invalid Lambda response.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidPasswordException">
        /// This exception is thrown when Amazon Cognito encounters an invalid password.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidSmsRoleAccessPolicyException">
        /// This exception is returned when the role provided for SMS configuration doesn't have
        /// permission to publish using Amazon SNS.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidSmsRoleTrustRelationshipException">
        /// This exception is thrown when the trust relationship is not valid for the role provided
        /// for SMS configuration. This can happen if you don't trust <code>cognito-idp.amazonaws.com</code>
        /// or the external ID provided in the role does not match what is provided in the SMS
        /// configuration for the user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidUserPoolConfigurationException">
        /// This exception is thrown when the user pool configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.MFAMethodNotFoundException">
        /// This exception is thrown when Amazon Cognito can't find a multi-factor authentication
        /// (MFA) method.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordResetRequiredException">
        /// This exception is thrown when a password reset is required.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.SoftwareTokenMFANotFoundException">
        /// This exception is thrown when the software token time-based one-time password (TOTP)
        /// multi-factor authentication (MFA) isn't activated for the user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UnexpectedLambdaException">
        /// This exception is thrown when Amazon Cognito encounters an unexpected exception with
        /// Lambda.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserLambdaValidationException">
        /// This exception is thrown when the Amazon Cognito service encounters a user validation
        /// exception with the Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user isn't confirmed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminRespondToAuthChallenge">REST API Reference for AdminRespondToAuthChallenge Operation</seealso>
        AdminRespondToAuthChallengeResponse AdminRespondToAuthChallenge(AdminRespondToAuthChallengeRequest request);



        /// <summary>
        /// Responds to an authentication challenge, as an administrator.
        /// 
        ///  <note> 
        /// <para>
        /// This action might generate an SMS text message. Starting June 1, 2021, US telecom
        /// carriers require you to register an origination phone number before you can send SMS
        /// messages to US phone numbers. If you use SMS text messages in Amazon Cognito, you
        /// must register a phone number with <a href="https://console.aws.amazon.com/pinpoint/home/">Amazon
        /// Pinpoint</a>. Amazon Cognito uses the registered number automatically. Otherwise,
        /// Amazon Cognito users who must receive SMS messages might not be able to sign up, activate
        /// their accounts, or sign in.
        /// </para>
        ///  
        /// <para>
        /// If you have never used SMS text messages with Amazon Cognito or any other Amazon Web
        /// Service, Amazon Simple Notification Service might place your account in the SMS sandbox.
        /// In <i> <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-sms-sandbox.html">sandbox
        /// mode</a> </i>, you can send messages only to verified phone numbers. After you test
        /// your app while in the sandbox environment, you can move out of the sandbox and into
        /// production. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-identity-pools-sms-userpool-settings.html">
        /// SMS message settings for Amazon Cognito user pools</a> in the <i>Amazon Cognito Developer
        /// Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Calling this action requires developer credentials.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AdminRespondToAuthChallenge service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AdminRespondToAuthChallenge service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.AliasExistsException">
        /// This exception is thrown when a user tries to confirm the account with an email address
        /// or phone number that has already been supplied as an alias for a different user profile.
        /// This exception indicates that an account with this email address or phone already
        /// exists in a user pool that you've configured to use email address or phone number
        /// as a sign-in alias.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.CodeMismatchException">
        /// This exception is thrown if the provided code doesn't match what the server was expecting.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ExpiredCodeException">
        /// This exception is thrown if a code has expired.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidLambdaResponseException">
        /// This exception is thrown when Amazon Cognito encounters an invalid Lambda response.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidPasswordException">
        /// This exception is thrown when Amazon Cognito encounters an invalid password.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidSmsRoleAccessPolicyException">
        /// This exception is returned when the role provided for SMS configuration doesn't have
        /// permission to publish using Amazon SNS.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidSmsRoleTrustRelationshipException">
        /// This exception is thrown when the trust relationship is not valid for the role provided
        /// for SMS configuration. This can happen if you don't trust <code>cognito-idp.amazonaws.com</code>
        /// or the external ID provided in the role does not match what is provided in the SMS
        /// configuration for the user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidUserPoolConfigurationException">
        /// This exception is thrown when the user pool configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.MFAMethodNotFoundException">
        /// This exception is thrown when Amazon Cognito can't find a multi-factor authentication
        /// (MFA) method.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordResetRequiredException">
        /// This exception is thrown when a password reset is required.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.SoftwareTokenMFANotFoundException">
        /// This exception is thrown when the software token time-based one-time password (TOTP)
        /// multi-factor authentication (MFA) isn't activated for the user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UnexpectedLambdaException">
        /// This exception is thrown when Amazon Cognito encounters an unexpected exception with
        /// Lambda.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserLambdaValidationException">
        /// This exception is thrown when the Amazon Cognito service encounters a user validation
        /// exception with the Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user isn't confirmed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminRespondToAuthChallenge">REST API Reference for AdminRespondToAuthChallenge Operation</seealso>
        Task<AdminRespondToAuthChallengeResponse> AdminRespondToAuthChallengeAsync(AdminRespondToAuthChallengeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AdminSetUserMFAPreference


        /// <summary>
        /// The user's multi-factor authentication (MFA) preference, including which MFA options
        /// are activated, and if any are preferred. Only one factor can be set as preferred.
        /// The preferred MFA factor will be used to authenticate a user if multiple factors are
        /// activated. If multiple options are activated and no preference is set, a challenge
        /// to choose an MFA option will be returned during sign-in.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AdminSetUserMFAPreference service method.</param>
        /// 
        /// <returns>The response from the AdminSetUserMFAPreference service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordResetRequiredException">
        /// This exception is thrown when a password reset is required.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user isn't confirmed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminSetUserMFAPreference">REST API Reference for AdminSetUserMFAPreference Operation</seealso>
        AdminSetUserMFAPreferenceResponse AdminSetUserMFAPreference(AdminSetUserMFAPreferenceRequest request);



        /// <summary>
        /// The user's multi-factor authentication (MFA) preference, including which MFA options
        /// are activated, and if any are preferred. Only one factor can be set as preferred.
        /// The preferred MFA factor will be used to authenticate a user if multiple factors are
        /// activated. If multiple options are activated and no preference is set, a challenge
        /// to choose an MFA option will be returned during sign-in.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AdminSetUserMFAPreference service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AdminSetUserMFAPreference service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordResetRequiredException">
        /// This exception is thrown when a password reset is required.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user isn't confirmed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminSetUserMFAPreference">REST API Reference for AdminSetUserMFAPreference Operation</seealso>
        Task<AdminSetUserMFAPreferenceResponse> AdminSetUserMFAPreferenceAsync(AdminSetUserMFAPreferenceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AdminSetUserPassword


        /// <summary>
        /// Sets the specified user's password in a user pool as an administrator. Works on any
        /// user. 
        /// 
        ///  
        /// <para>
        /// The password can be temporary or permanent. If it is temporary, the user status enters
        /// the <code>FORCE_CHANGE_PASSWORD</code> state. When the user next tries to sign in,
        /// the InitiateAuth/AdminInitiateAuth response will contain the <code>NEW_PASSWORD_REQUIRED</code>
        /// challenge. If the user doesn't sign in before it expires, the user won't be able to
        /// sign in, and an administrator must reset their password. 
        /// </para>
        ///  
        /// <para>
        /// Once the user has set a new password, or the password is permanent, the user status
        /// is set to <code>Confirmed</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AdminSetUserPassword service method.</param>
        /// 
        /// <returns>The response from the AdminSetUserPassword service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidPasswordException">
        /// This exception is thrown when Amazon Cognito encounters an invalid password.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminSetUserPassword">REST API Reference for AdminSetUserPassword Operation</seealso>
        AdminSetUserPasswordResponse AdminSetUserPassword(AdminSetUserPasswordRequest request);



        /// <summary>
        /// Sets the specified user's password in a user pool as an administrator. Works on any
        /// user. 
        /// 
        ///  
        /// <para>
        /// The password can be temporary or permanent. If it is temporary, the user status enters
        /// the <code>FORCE_CHANGE_PASSWORD</code> state. When the user next tries to sign in,
        /// the InitiateAuth/AdminInitiateAuth response will contain the <code>NEW_PASSWORD_REQUIRED</code>
        /// challenge. If the user doesn't sign in before it expires, the user won't be able to
        /// sign in, and an administrator must reset their password. 
        /// </para>
        ///  
        /// <para>
        /// Once the user has set a new password, or the password is permanent, the user status
        /// is set to <code>Confirmed</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AdminSetUserPassword service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AdminSetUserPassword service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidPasswordException">
        /// This exception is thrown when Amazon Cognito encounters an invalid password.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminSetUserPassword">REST API Reference for AdminSetUserPassword Operation</seealso>
        Task<AdminSetUserPasswordResponse> AdminSetUserPasswordAsync(AdminSetUserPasswordRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AdminSetUserSettings


        /// <summary>
        /// <i>This action is no longer supported.</i> You can use it to configure only SMS MFA.
        /// You can't use it to configure time-based one-time password (TOTP) software token MFA.
        /// To configure either type of MFA, use <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_AdminSetUserMFAPreference.html">AdminSetUserMFAPreference</a>
        /// instead.
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
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminSetUserSettings">REST API Reference for AdminSetUserSettings Operation</seealso>
        AdminSetUserSettingsResponse AdminSetUserSettings(AdminSetUserSettingsRequest request);



        /// <summary>
        /// <i>This action is no longer supported.</i> You can use it to configure only SMS MFA.
        /// You can't use it to configure time-based one-time password (TOTP) software token MFA.
        /// To configure either type of MFA, use <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_AdminSetUserMFAPreference.html">AdminSetUserMFAPreference</a>
        /// instead.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AdminSetUserSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AdminSetUserSettings service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminSetUserSettings">REST API Reference for AdminSetUserSettings Operation</seealso>
        Task<AdminSetUserSettingsResponse> AdminSetUserSettingsAsync(AdminSetUserSettingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AdminUpdateAuthEventFeedback


        /// <summary>
        /// Provides feedback for an authentication event indicating if it was from a valid user.
        /// This feedback is used for improving the risk evaluation decision for the user pool
        /// as part of Amazon Cognito advanced security.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AdminUpdateAuthEventFeedback service method.</param>
        /// 
        /// <returns>The response from the AdminUpdateAuthEventFeedback service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserPoolAddOnNotEnabledException">
        /// This exception is thrown when user pool add-ons aren't enabled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminUpdateAuthEventFeedback">REST API Reference for AdminUpdateAuthEventFeedback Operation</seealso>
        AdminUpdateAuthEventFeedbackResponse AdminUpdateAuthEventFeedback(AdminUpdateAuthEventFeedbackRequest request);



        /// <summary>
        /// Provides feedback for an authentication event indicating if it was from a valid user.
        /// This feedback is used for improving the risk evaluation decision for the user pool
        /// as part of Amazon Cognito advanced security.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AdminUpdateAuthEventFeedback service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AdminUpdateAuthEventFeedback service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserPoolAddOnNotEnabledException">
        /// This exception is thrown when user pool add-ons aren't enabled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminUpdateAuthEventFeedback">REST API Reference for AdminUpdateAuthEventFeedback Operation</seealso>
        Task<AdminUpdateAuthEventFeedbackResponse> AdminUpdateAuthEventFeedbackAsync(AdminUpdateAuthEventFeedbackRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AdminUpdateDeviceStatus


        /// <summary>
        /// Updates the device status as an administrator.
        /// 
        ///  
        /// <para>
        /// Calling this action requires developer credentials.
        /// </para>
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
        /// This exception is thrown when the user pool configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminUpdateDeviceStatus">REST API Reference for AdminUpdateDeviceStatus Operation</seealso>
        AdminUpdateDeviceStatusResponse AdminUpdateDeviceStatus(AdminUpdateDeviceStatusRequest request);



        /// <summary>
        /// Updates the device status as an administrator.
        /// 
        ///  
        /// <para>
        /// Calling this action requires developer credentials.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AdminUpdateDeviceStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AdminUpdateDeviceStatus service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidUserPoolConfigurationException">
        /// This exception is thrown when the user pool configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminUpdateDeviceStatus">REST API Reference for AdminUpdateDeviceStatus Operation</seealso>
        Task<AdminUpdateDeviceStatusResponse> AdminUpdateDeviceStatusAsync(AdminUpdateDeviceStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AdminUpdateUserAttributes


        /// <summary>
        /// Updates the specified user's attributes, including developer attributes, as an administrator.
        /// Works on any user.
        /// 
        ///  
        /// <para>
        /// For custom attributes, you must prepend the <code>custom:</code> prefix to the attribute
        /// name.
        /// </para>
        ///  
        /// <para>
        /// In addition to updating user attributes, this API can also be used to mark phone and
        /// email as verified.
        /// </para>
        ///  <note> 
        /// <para>
        /// This action might generate an SMS text message. Starting June 1, 2021, US telecom
        /// carriers require you to register an origination phone number before you can send SMS
        /// messages to US phone numbers. If you use SMS text messages in Amazon Cognito, you
        /// must register a phone number with <a href="https://console.aws.amazon.com/pinpoint/home/">Amazon
        /// Pinpoint</a>. Amazon Cognito uses the registered number automatically. Otherwise,
        /// Amazon Cognito users who must receive SMS messages might not be able to sign up, activate
        /// their accounts, or sign in.
        /// </para>
        ///  
        /// <para>
        /// If you have never used SMS text messages with Amazon Cognito or any other Amazon Web
        /// Service, Amazon Simple Notification Service might place your account in the SMS sandbox.
        /// In <i> <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-sms-sandbox.html">sandbox
        /// mode</a> </i>, you can send messages only to verified phone numbers. After you test
        /// your app while in the sandbox environment, you can move out of the sandbox and into
        /// production. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-identity-pools-sms-userpool-settings.html">
        /// SMS message settings for Amazon Cognito user pools</a> in the <i>Amazon Cognito Developer
        /// Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Calling this action requires developer credentials.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AdminUpdateUserAttributes service method.</param>
        /// 
        /// <returns>The response from the AdminUpdateUserAttributes service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.AliasExistsException">
        /// This exception is thrown when a user tries to confirm the account with an email address
        /// or phone number that has already been supplied as an alias for a different user profile.
        /// This exception indicates that an account with this email address or phone already
        /// exists in a user pool that you've configured to use email address or phone number
        /// as a sign-in alias.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidEmailRoleAccessPolicyException">
        /// This exception is thrown when Amazon Cognito isn't allowed to use your email identity.
        /// HTTP status code: 400.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidLambdaResponseException">
        /// This exception is thrown when Amazon Cognito encounters an invalid Lambda response.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidSmsRoleAccessPolicyException">
        /// This exception is returned when the role provided for SMS configuration doesn't have
        /// permission to publish using Amazon SNS.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidSmsRoleTrustRelationshipException">
        /// This exception is thrown when the trust relationship is not valid for the role provided
        /// for SMS configuration. This can happen if you don't trust <code>cognito-idp.amazonaws.com</code>
        /// or the external ID provided in the role does not match what is provided in the SMS
        /// configuration for the user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UnexpectedLambdaException">
        /// This exception is thrown when Amazon Cognito encounters an unexpected exception with
        /// Lambda.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserLambdaValidationException">
        /// This exception is thrown when the Amazon Cognito service encounters a user validation
        /// exception with the Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminUpdateUserAttributes">REST API Reference for AdminUpdateUserAttributes Operation</seealso>
        AdminUpdateUserAttributesResponse AdminUpdateUserAttributes(AdminUpdateUserAttributesRequest request);



        /// <summary>
        /// Updates the specified user's attributes, including developer attributes, as an administrator.
        /// Works on any user.
        /// 
        ///  
        /// <para>
        /// For custom attributes, you must prepend the <code>custom:</code> prefix to the attribute
        /// name.
        /// </para>
        ///  
        /// <para>
        /// In addition to updating user attributes, this API can also be used to mark phone and
        /// email as verified.
        /// </para>
        ///  <note> 
        /// <para>
        /// This action might generate an SMS text message. Starting June 1, 2021, US telecom
        /// carriers require you to register an origination phone number before you can send SMS
        /// messages to US phone numbers. If you use SMS text messages in Amazon Cognito, you
        /// must register a phone number with <a href="https://console.aws.amazon.com/pinpoint/home/">Amazon
        /// Pinpoint</a>. Amazon Cognito uses the registered number automatically. Otherwise,
        /// Amazon Cognito users who must receive SMS messages might not be able to sign up, activate
        /// their accounts, or sign in.
        /// </para>
        ///  
        /// <para>
        /// If you have never used SMS text messages with Amazon Cognito or any other Amazon Web
        /// Service, Amazon Simple Notification Service might place your account in the SMS sandbox.
        /// In <i> <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-sms-sandbox.html">sandbox
        /// mode</a> </i>, you can send messages only to verified phone numbers. After you test
        /// your app while in the sandbox environment, you can move out of the sandbox and into
        /// production. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-identity-pools-sms-userpool-settings.html">
        /// SMS message settings for Amazon Cognito user pools</a> in the <i>Amazon Cognito Developer
        /// Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Calling this action requires developer credentials.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AdminUpdateUserAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AdminUpdateUserAttributes service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.AliasExistsException">
        /// This exception is thrown when a user tries to confirm the account with an email address
        /// or phone number that has already been supplied as an alias for a different user profile.
        /// This exception indicates that an account with this email address or phone already
        /// exists in a user pool that you've configured to use email address or phone number
        /// as a sign-in alias.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidEmailRoleAccessPolicyException">
        /// This exception is thrown when Amazon Cognito isn't allowed to use your email identity.
        /// HTTP status code: 400.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidLambdaResponseException">
        /// This exception is thrown when Amazon Cognito encounters an invalid Lambda response.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidSmsRoleAccessPolicyException">
        /// This exception is returned when the role provided for SMS configuration doesn't have
        /// permission to publish using Amazon SNS.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidSmsRoleTrustRelationshipException">
        /// This exception is thrown when the trust relationship is not valid for the role provided
        /// for SMS configuration. This can happen if you don't trust <code>cognito-idp.amazonaws.com</code>
        /// or the external ID provided in the role does not match what is provided in the SMS
        /// configuration for the user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UnexpectedLambdaException">
        /// This exception is thrown when Amazon Cognito encounters an unexpected exception with
        /// Lambda.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserLambdaValidationException">
        /// This exception is thrown when the Amazon Cognito service encounters a user validation
        /// exception with the Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminUpdateUserAttributes">REST API Reference for AdminUpdateUserAttributes Operation</seealso>
        Task<AdminUpdateUserAttributesResponse> AdminUpdateUserAttributesAsync(AdminUpdateUserAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AdminUserGlobalSignOut


        /// <summary>
        /// Signs out a user from all devices. You must sign <code>AdminUserGlobalSignOut</code>
        /// requests with Amazon Web Services credentials. It also invalidates all refresh tokens
        /// that Amazon Cognito has issued to a user. The user's current access and ID tokens
        /// remain valid until they expire. By default, access and ID tokens expire one hour after
        /// they're issued. A user can still use a hosted UI cookie to retrieve new tokens for
        /// the duration of the cookie validity period of 1 hour.
        /// 
        ///  
        /// <para>
        /// Calling this action requires developer credentials.
        /// </para>
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
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminUserGlobalSignOut">REST API Reference for AdminUserGlobalSignOut Operation</seealso>
        AdminUserGlobalSignOutResponse AdminUserGlobalSignOut(AdminUserGlobalSignOutRequest request);



        /// <summary>
        /// Signs out a user from all devices. You must sign <code>AdminUserGlobalSignOut</code>
        /// requests with Amazon Web Services credentials. It also invalidates all refresh tokens
        /// that Amazon Cognito has issued to a user. The user's current access and ID tokens
        /// remain valid until they expire. By default, access and ID tokens expire one hour after
        /// they're issued. A user can still use a hosted UI cookie to retrieve new tokens for
        /// the duration of the cookie validity period of 1 hour.
        /// 
        ///  
        /// <para>
        /// Calling this action requires developer credentials.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AdminUserGlobalSignOut service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AdminUserGlobalSignOut service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminUserGlobalSignOut">REST API Reference for AdminUserGlobalSignOut Operation</seealso>
        Task<AdminUserGlobalSignOutResponse> AdminUserGlobalSignOutAsync(AdminUserGlobalSignOutRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AssociateSoftwareToken


        /// <summary>
        /// Begins setup of time-based one-time password (TOTP) multi-factor authentication (MFA)
        /// for a user, with a unique private key that Amazon Cognito generates and returns in
        /// the API response. You can authorize an <code>AssociateSoftwareToken</code> request
        /// with either the user's access token, or a session string from a challenge response
        /// that you received from Amazon Cognito.
        /// 
        ///  <note> 
        /// <para>
        /// Amazon Cognito disassociates an existing software token when you verify the new token
        /// in a <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_VerifySoftwareToken.html">
        /// VerifySoftwareToken</a> API request. If you don't verify the software token and your
        /// user pool doesn't require MFA, the user can then authenticate with user name and password
        /// credentials alone. If your user pool requires TOTP MFA, Amazon Cognito generates an
        /// <code>MFA_SETUP</code> or <code>SOFTWARE_TOKEN_SETUP</code> challenge each time your
        /// user signs. Complete setup with <code>AssociateSoftwareToken</code> and <code>VerifySoftwareToken</code>.
        /// </para>
        ///  
        /// <para>
        /// After you set up software token MFA for your user, Amazon Cognito generates a <code>SOFTWARE_TOKEN_MFA</code>
        /// challenge when they authenticate. Respond to this challenge with your user's TOTP.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateSoftwareToken service method.</param>
        /// 
        /// <returns>The response from the AssociateSoftwareToken service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ConcurrentModificationException">
        /// This exception is thrown if two or more modifications are happening concurrently.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ForbiddenException">
        /// This exception is thrown when WAF doesn't allow your request based on a web ACL that's
        /// associated with your user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.SoftwareTokenMFANotFoundException">
        /// This exception is thrown when the software token time-based one-time password (TOTP)
        /// multi-factor authentication (MFA) isn't activated for the user pool.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AssociateSoftwareToken">REST API Reference for AssociateSoftwareToken Operation</seealso>
        AssociateSoftwareTokenResponse AssociateSoftwareToken(AssociateSoftwareTokenRequest request);



        /// <summary>
        /// Begins setup of time-based one-time password (TOTP) multi-factor authentication (MFA)
        /// for a user, with a unique private key that Amazon Cognito generates and returns in
        /// the API response. You can authorize an <code>AssociateSoftwareToken</code> request
        /// with either the user's access token, or a session string from a challenge response
        /// that you received from Amazon Cognito.
        /// 
        ///  <note> 
        /// <para>
        /// Amazon Cognito disassociates an existing software token when you verify the new token
        /// in a <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_VerifySoftwareToken.html">
        /// VerifySoftwareToken</a> API request. If you don't verify the software token and your
        /// user pool doesn't require MFA, the user can then authenticate with user name and password
        /// credentials alone. If your user pool requires TOTP MFA, Amazon Cognito generates an
        /// <code>MFA_SETUP</code> or <code>SOFTWARE_TOKEN_SETUP</code> challenge each time your
        /// user signs. Complete setup with <code>AssociateSoftwareToken</code> and <code>VerifySoftwareToken</code>.
        /// </para>
        ///  
        /// <para>
        /// After you set up software token MFA for your user, Amazon Cognito generates a <code>SOFTWARE_TOKEN_MFA</code>
        /// challenge when they authenticate. Respond to this challenge with your user's TOTP.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateSoftwareToken service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateSoftwareToken service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ConcurrentModificationException">
        /// This exception is thrown if two or more modifications are happening concurrently.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ForbiddenException">
        /// This exception is thrown when WAF doesn't allow your request based on a web ACL that's
        /// associated with your user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.SoftwareTokenMFANotFoundException">
        /// This exception is thrown when the software token time-based one-time password (TOTP)
        /// multi-factor authentication (MFA) isn't activated for the user pool.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AssociateSoftwareToken">REST API Reference for AssociateSoftwareToken Operation</seealso>
        Task<AssociateSoftwareTokenResponse> AssociateSoftwareTokenAsync(AssociateSoftwareTokenRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ChangePassword


        /// <summary>
        /// Changes the password for a specified user in a user pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ChangePassword service method.</param>
        /// 
        /// <returns>The response from the ChangePassword service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ForbiddenException">
        /// This exception is thrown when WAF doesn't allow your request based on a web ACL that's
        /// associated with your user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidPasswordException">
        /// This exception is thrown when Amazon Cognito encounters an invalid password.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.LimitExceededException">
        /// This exception is thrown when a user exceeds the limit for a requested Amazon Web
        /// Services resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordResetRequiredException">
        /// This exception is thrown when a password reset is required.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user isn't confirmed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ChangePassword">REST API Reference for ChangePassword Operation</seealso>
        ChangePasswordResponse ChangePassword(ChangePasswordRequest request);



        /// <summary>
        /// Changes the password for a specified user in a user pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ChangePassword service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ChangePassword service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ForbiddenException">
        /// This exception is thrown when WAF doesn't allow your request based on a web ACL that's
        /// associated with your user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidPasswordException">
        /// This exception is thrown when Amazon Cognito encounters an invalid password.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.LimitExceededException">
        /// This exception is thrown when a user exceeds the limit for a requested Amazon Web
        /// Services resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordResetRequiredException">
        /// This exception is thrown when a password reset is required.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user isn't confirmed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ChangePassword">REST API Reference for ChangePassword Operation</seealso>
        Task<ChangePasswordResponse> ChangePasswordAsync(ChangePasswordRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ConfirmDevice


        /// <summary>
        /// Confirms tracking of the device. This API call is the call that begins device tracking.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConfirmDevice service method.</param>
        /// 
        /// <returns>The response from the ConfirmDevice service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ForbiddenException">
        /// This exception is thrown when WAF doesn't allow your request based on a web ACL that's
        /// associated with your user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidLambdaResponseException">
        /// This exception is thrown when Amazon Cognito encounters an invalid Lambda response.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidPasswordException">
        /// This exception is thrown when Amazon Cognito encounters an invalid password.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidUserPoolConfigurationException">
        /// This exception is thrown when the user pool configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordResetRequiredException">
        /// This exception is thrown when a password reset is required.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UsernameExistsException">
        /// This exception is thrown when Amazon Cognito encounters a user name that already exists
        /// in the user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user isn't confirmed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ConfirmDevice">REST API Reference for ConfirmDevice Operation</seealso>
        ConfirmDeviceResponse ConfirmDevice(ConfirmDeviceRequest request);



        /// <summary>
        /// Confirms tracking of the device. This API call is the call that begins device tracking.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConfirmDevice service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ConfirmDevice service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ForbiddenException">
        /// This exception is thrown when WAF doesn't allow your request based on a web ACL that's
        /// associated with your user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidLambdaResponseException">
        /// This exception is thrown when Amazon Cognito encounters an invalid Lambda response.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidPasswordException">
        /// This exception is thrown when Amazon Cognito encounters an invalid password.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidUserPoolConfigurationException">
        /// This exception is thrown when the user pool configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordResetRequiredException">
        /// This exception is thrown when a password reset is required.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UsernameExistsException">
        /// This exception is thrown when Amazon Cognito encounters a user name that already exists
        /// in the user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user isn't confirmed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ConfirmDevice">REST API Reference for ConfirmDevice Operation</seealso>
        Task<ConfirmDeviceResponse> ConfirmDeviceAsync(ConfirmDeviceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ConfirmForgotPassword


        /// <summary>
        /// Allows a user to enter a confirmation code to reset a forgotten password.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConfirmForgotPassword service method.</param>
        /// 
        /// <returns>The response from the ConfirmForgotPassword service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.CodeMismatchException">
        /// This exception is thrown if the provided code doesn't match what the server was expecting.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ExpiredCodeException">
        /// This exception is thrown if a code has expired.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ForbiddenException">
        /// This exception is thrown when WAF doesn't allow your request based on a web ACL that's
        /// associated with your user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidLambdaResponseException">
        /// This exception is thrown when Amazon Cognito encounters an invalid Lambda response.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidPasswordException">
        /// This exception is thrown when Amazon Cognito encounters an invalid password.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.LimitExceededException">
        /// This exception is thrown when a user exceeds the limit for a requested Amazon Web
        /// Services resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyFailedAttemptsException">
        /// This exception is thrown when the user has made too many failed attempts for a given
        /// action, such as sign-in.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UnexpectedLambdaException">
        /// This exception is thrown when Amazon Cognito encounters an unexpected exception with
        /// Lambda.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserLambdaValidationException">
        /// This exception is thrown when the Amazon Cognito service encounters a user validation
        /// exception with the Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user isn't confirmed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ConfirmForgotPassword">REST API Reference for ConfirmForgotPassword Operation</seealso>
        ConfirmForgotPasswordResponse ConfirmForgotPassword(ConfirmForgotPasswordRequest request);



        /// <summary>
        /// Allows a user to enter a confirmation code to reset a forgotten password.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConfirmForgotPassword service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ConfirmForgotPassword service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.CodeMismatchException">
        /// This exception is thrown if the provided code doesn't match what the server was expecting.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ExpiredCodeException">
        /// This exception is thrown if a code has expired.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ForbiddenException">
        /// This exception is thrown when WAF doesn't allow your request based on a web ACL that's
        /// associated with your user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidLambdaResponseException">
        /// This exception is thrown when Amazon Cognito encounters an invalid Lambda response.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidPasswordException">
        /// This exception is thrown when Amazon Cognito encounters an invalid password.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.LimitExceededException">
        /// This exception is thrown when a user exceeds the limit for a requested Amazon Web
        /// Services resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyFailedAttemptsException">
        /// This exception is thrown when the user has made too many failed attempts for a given
        /// action, such as sign-in.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UnexpectedLambdaException">
        /// This exception is thrown when Amazon Cognito encounters an unexpected exception with
        /// Lambda.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserLambdaValidationException">
        /// This exception is thrown when the Amazon Cognito service encounters a user validation
        /// exception with the Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user isn't confirmed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ConfirmForgotPassword">REST API Reference for ConfirmForgotPassword Operation</seealso>
        Task<ConfirmForgotPasswordResponse> ConfirmForgotPasswordAsync(ConfirmForgotPasswordRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ConfirmSignUp


        /// <summary>
        /// Confirms registration of a new user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConfirmSignUp service method.</param>
        /// 
        /// <returns>The response from the ConfirmSignUp service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.AliasExistsException">
        /// This exception is thrown when a user tries to confirm the account with an email address
        /// or phone number that has already been supplied as an alias for a different user profile.
        /// This exception indicates that an account with this email address or phone already
        /// exists in a user pool that you've configured to use email address or phone number
        /// as a sign-in alias.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.CodeMismatchException">
        /// This exception is thrown if the provided code doesn't match what the server was expecting.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ExpiredCodeException">
        /// This exception is thrown if a code has expired.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ForbiddenException">
        /// This exception is thrown when WAF doesn't allow your request based on a web ACL that's
        /// associated with your user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidLambdaResponseException">
        /// This exception is thrown when Amazon Cognito encounters an invalid Lambda response.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.LimitExceededException">
        /// This exception is thrown when a user exceeds the limit for a requested Amazon Web
        /// Services resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyFailedAttemptsException">
        /// This exception is thrown when the user has made too many failed attempts for a given
        /// action, such as sign-in.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UnexpectedLambdaException">
        /// This exception is thrown when Amazon Cognito encounters an unexpected exception with
        /// Lambda.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserLambdaValidationException">
        /// This exception is thrown when the Amazon Cognito service encounters a user validation
        /// exception with the Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ConfirmSignUp">REST API Reference for ConfirmSignUp Operation</seealso>
        ConfirmSignUpResponse ConfirmSignUp(ConfirmSignUpRequest request);



        /// <summary>
        /// Confirms registration of a new user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConfirmSignUp service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ConfirmSignUp service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.AliasExistsException">
        /// This exception is thrown when a user tries to confirm the account with an email address
        /// or phone number that has already been supplied as an alias for a different user profile.
        /// This exception indicates that an account with this email address or phone already
        /// exists in a user pool that you've configured to use email address or phone number
        /// as a sign-in alias.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.CodeMismatchException">
        /// This exception is thrown if the provided code doesn't match what the server was expecting.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ExpiredCodeException">
        /// This exception is thrown if a code has expired.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ForbiddenException">
        /// This exception is thrown when WAF doesn't allow your request based on a web ACL that's
        /// associated with your user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidLambdaResponseException">
        /// This exception is thrown when Amazon Cognito encounters an invalid Lambda response.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.LimitExceededException">
        /// This exception is thrown when a user exceeds the limit for a requested Amazon Web
        /// Services resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyFailedAttemptsException">
        /// This exception is thrown when the user has made too many failed attempts for a given
        /// action, such as sign-in.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UnexpectedLambdaException">
        /// This exception is thrown when Amazon Cognito encounters an unexpected exception with
        /// Lambda.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserLambdaValidationException">
        /// This exception is thrown when the Amazon Cognito service encounters a user validation
        /// exception with the Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ConfirmSignUp">REST API Reference for ConfirmSignUp Operation</seealso>
        Task<ConfirmSignUpResponse> ConfirmSignUpAsync(ConfirmSignUpRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateGroup


        /// <summary>
        /// Creates a new group in the specified user pool.
        /// 
        ///  
        /// <para>
        /// Calling this action requires developer credentials.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGroup service method.</param>
        /// 
        /// <returns>The response from the CreateGroup service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.GroupExistsException">
        /// This exception is thrown when Amazon Cognito encounters a group that already exists
        /// in the user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.LimitExceededException">
        /// This exception is thrown when a user exceeds the limit for a requested Amazon Web
        /// Services resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        CreateGroupResponse CreateGroup(CreateGroupRequest request);



        /// <summary>
        /// Creates a new group in the specified user pool.
        /// 
        ///  
        /// <para>
        /// Calling this action requires developer credentials.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateGroup service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.GroupExistsException">
        /// This exception is thrown when Amazon Cognito encounters a group that already exists
        /// in the user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.LimitExceededException">
        /// This exception is thrown when a user exceeds the limit for a requested Amazon Web
        /// Services resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        Task<CreateGroupResponse> CreateGroupAsync(CreateGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateIdentityProvider


        /// <summary>
        /// Creates an IdP for a user pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIdentityProvider service method.</param>
        /// 
        /// <returns>The response from the CreateIdentityProvider service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.DuplicateProviderException">
        /// This exception is thrown when the provider is already supported by the user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.LimitExceededException">
        /// This exception is thrown when a user exceeds the limit for a requested Amazon Web
        /// Services resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CreateIdentityProvider">REST API Reference for CreateIdentityProvider Operation</seealso>
        CreateIdentityProviderResponse CreateIdentityProvider(CreateIdentityProviderRequest request);



        /// <summary>
        /// Creates an IdP for a user pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIdentityProvider service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateIdentityProvider service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.DuplicateProviderException">
        /// This exception is thrown when the provider is already supported by the user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.LimitExceededException">
        /// This exception is thrown when a user exceeds the limit for a requested Amazon Web
        /// Services resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CreateIdentityProvider">REST API Reference for CreateIdentityProvider Operation</seealso>
        Task<CreateIdentityProviderResponse> CreateIdentityProviderAsync(CreateIdentityProviderRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateResourceServer


        /// <summary>
        /// Creates a new OAuth2.0 resource server and defines custom scopes within it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateResourceServer service method.</param>
        /// 
        /// <returns>The response from the CreateResourceServer service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.LimitExceededException">
        /// This exception is thrown when a user exceeds the limit for a requested Amazon Web
        /// Services resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CreateResourceServer">REST API Reference for CreateResourceServer Operation</seealso>
        CreateResourceServerResponse CreateResourceServer(CreateResourceServerRequest request);



        /// <summary>
        /// Creates a new OAuth2.0 resource server and defines custom scopes within it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateResourceServer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateResourceServer service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.LimitExceededException">
        /// This exception is thrown when a user exceeds the limit for a requested Amazon Web
        /// Services resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CreateResourceServer">REST API Reference for CreateResourceServer Operation</seealso>
        Task<CreateResourceServerResponse> CreateResourceServerAsync(CreateResourceServerRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// This exception is thrown when a user exceeds the limit for a requested Amazon Web
        /// Services resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PreconditionNotMetException">
        /// This exception is thrown when a precondition is not met.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CreateUserImportJob">REST API Reference for CreateUserImportJob Operation</seealso>
        CreateUserImportJobResponse CreateUserImportJob(CreateUserImportJobRequest request);



        /// <summary>
        /// Creates the user import job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUserImportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateUserImportJob service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.LimitExceededException">
        /// This exception is thrown when a user exceeds the limit for a requested Amazon Web
        /// Services resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PreconditionNotMetException">
        /// This exception is thrown when a precondition is not met.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CreateUserImportJob">REST API Reference for CreateUserImportJob Operation</seealso>
        Task<CreateUserImportJobResponse> CreateUserImportJobAsync(CreateUserImportJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateUserPool


        /// <summary>
        /// Creates a new Amazon Cognito user pool and sets the password policy for the pool.
        /// 
        ///  <note> 
        /// <para>
        /// This action might generate an SMS text message. Starting June 1, 2021, US telecom
        /// carriers require you to register an origination phone number before you can send SMS
        /// messages to US phone numbers. If you use SMS text messages in Amazon Cognito, you
        /// must register a phone number with <a href="https://console.aws.amazon.com/pinpoint/home/">Amazon
        /// Pinpoint</a>. Amazon Cognito uses the registered number automatically. Otherwise,
        /// Amazon Cognito users who must receive SMS messages might not be able to sign up, activate
        /// their accounts, or sign in.
        /// </para>
        ///  
        /// <para>
        /// If you have never used SMS text messages with Amazon Cognito or any other Amazon Web
        /// Service, Amazon Simple Notification Service might place your account in the SMS sandbox.
        /// In <i> <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-sms-sandbox.html">sandbox
        /// mode</a> </i>, you can send messages only to verified phone numbers. After you test
        /// your app while in the sandbox environment, you can move out of the sandbox and into
        /// production. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-identity-pools-sms-userpool-settings.html">
        /// SMS message settings for Amazon Cognito user pools</a> in the <i>Amazon Cognito Developer
        /// Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUserPool service method.</param>
        /// 
        /// <returns>The response from the CreateUserPool service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidEmailRoleAccessPolicyException">
        /// This exception is thrown when Amazon Cognito isn't allowed to use your email identity.
        /// HTTP status code: 400.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidSmsRoleAccessPolicyException">
        /// This exception is returned when the role provided for SMS configuration doesn't have
        /// permission to publish using Amazon SNS.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidSmsRoleTrustRelationshipException">
        /// This exception is thrown when the trust relationship is not valid for the role provided
        /// for SMS configuration. This can happen if you don't trust <code>cognito-idp.amazonaws.com</code>
        /// or the external ID provided in the role does not match what is provided in the SMS
        /// configuration for the user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.LimitExceededException">
        /// This exception is thrown when a user exceeds the limit for a requested Amazon Web
        /// Services resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserPoolTaggingException">
        /// This exception is thrown when a user pool tag can't be set or updated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CreateUserPool">REST API Reference for CreateUserPool Operation</seealso>
        CreateUserPoolResponse CreateUserPool(CreateUserPoolRequest request);



        /// <summary>
        /// Creates a new Amazon Cognito user pool and sets the password policy for the pool.
        /// 
        ///  <note> 
        /// <para>
        /// This action might generate an SMS text message. Starting June 1, 2021, US telecom
        /// carriers require you to register an origination phone number before you can send SMS
        /// messages to US phone numbers. If you use SMS text messages in Amazon Cognito, you
        /// must register a phone number with <a href="https://console.aws.amazon.com/pinpoint/home/">Amazon
        /// Pinpoint</a>. Amazon Cognito uses the registered number automatically. Otherwise,
        /// Amazon Cognito users who must receive SMS messages might not be able to sign up, activate
        /// their accounts, or sign in.
        /// </para>
        ///  
        /// <para>
        /// If you have never used SMS text messages with Amazon Cognito or any other Amazon Web
        /// Service, Amazon Simple Notification Service might place your account in the SMS sandbox.
        /// In <i> <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-sms-sandbox.html">sandbox
        /// mode</a> </i>, you can send messages only to verified phone numbers. After you test
        /// your app while in the sandbox environment, you can move out of the sandbox and into
        /// production. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-identity-pools-sms-userpool-settings.html">
        /// SMS message settings for Amazon Cognito user pools</a> in the <i>Amazon Cognito Developer
        /// Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUserPool service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateUserPool service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidEmailRoleAccessPolicyException">
        /// This exception is thrown when Amazon Cognito isn't allowed to use your email identity.
        /// HTTP status code: 400.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidSmsRoleAccessPolicyException">
        /// This exception is returned when the role provided for SMS configuration doesn't have
        /// permission to publish using Amazon SNS.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidSmsRoleTrustRelationshipException">
        /// This exception is thrown when the trust relationship is not valid for the role provided
        /// for SMS configuration. This can happen if you don't trust <code>cognito-idp.amazonaws.com</code>
        /// or the external ID provided in the role does not match what is provided in the SMS
        /// configuration for the user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.LimitExceededException">
        /// This exception is thrown when a user exceeds the limit for a requested Amazon Web
        /// Services resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserPoolTaggingException">
        /// This exception is thrown when a user pool tag can't be set or updated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CreateUserPool">REST API Reference for CreateUserPool Operation</seealso>
        Task<CreateUserPoolResponse> CreateUserPoolAsync(CreateUserPoolRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateUserPoolClient


        /// <summary>
        /// Creates the user pool client.
        /// 
        ///  
        /// <para>
        /// When you create a new user pool client, token revocation is automatically activated.
        /// For more information about revoking tokens, see <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_RevokeToken.html">RevokeToken</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUserPoolClient service method.</param>
        /// 
        /// <returns>The response from the CreateUserPoolClient service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidOAuthFlowException">
        /// This exception is thrown when the specified OAuth flow is not valid.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.LimitExceededException">
        /// This exception is thrown when a user exceeds the limit for a requested Amazon Web
        /// Services resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ScopeDoesNotExistException">
        /// This exception is thrown when the specified scope doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CreateUserPoolClient">REST API Reference for CreateUserPoolClient Operation</seealso>
        CreateUserPoolClientResponse CreateUserPoolClient(CreateUserPoolClientRequest request);



        /// <summary>
        /// Creates the user pool client.
        /// 
        ///  
        /// <para>
        /// When you create a new user pool client, token revocation is automatically activated.
        /// For more information about revoking tokens, see <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_RevokeToken.html">RevokeToken</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUserPoolClient service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateUserPoolClient service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidOAuthFlowException">
        /// This exception is thrown when the specified OAuth flow is not valid.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.LimitExceededException">
        /// This exception is thrown when a user exceeds the limit for a requested Amazon Web
        /// Services resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ScopeDoesNotExistException">
        /// This exception is thrown when the specified scope doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CreateUserPoolClient">REST API Reference for CreateUserPoolClient Operation</seealso>
        Task<CreateUserPoolClientResponse> CreateUserPoolClientAsync(CreateUserPoolClientRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateUserPoolDomain


        /// <summary>
        /// Creates a new domain for a user pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUserPoolDomain service method.</param>
        /// 
        /// <returns>The response from the CreateUserPoolDomain service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.LimitExceededException">
        /// This exception is thrown when a user exceeds the limit for a requested Amazon Web
        /// Services resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CreateUserPoolDomain">REST API Reference for CreateUserPoolDomain Operation</seealso>
        CreateUserPoolDomainResponse CreateUserPoolDomain(CreateUserPoolDomainRequest request);



        /// <summary>
        /// Creates a new domain for a user pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUserPoolDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateUserPoolDomain service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.LimitExceededException">
        /// This exception is thrown when a user exceeds the limit for a requested Amazon Web
        /// Services resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CreateUserPoolDomain">REST API Reference for CreateUserPoolDomain Operation</seealso>
        Task<CreateUserPoolDomainResponse> CreateUserPoolDomainAsync(CreateUserPoolDomainRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteGroup


        /// <summary>
        /// Deletes a group.
        /// 
        ///  
        /// <para>
        /// Calling this action requires developer credentials.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteGroup service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        DeleteGroupResponse DeleteGroup(DeleteGroupRequest request);



        /// <summary>
        /// Deletes a group.
        /// 
        ///  
        /// <para>
        /// Calling this action requires developer credentials.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteGroup service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        Task<DeleteGroupResponse> DeleteGroupAsync(DeleteGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteIdentityProvider


        /// <summary>
        /// Deletes an IdP for a user pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIdentityProvider service method.</param>
        /// 
        /// <returns>The response from the DeleteIdentityProvider service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ConcurrentModificationException">
        /// This exception is thrown if two or more modifications are happening concurrently.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UnsupportedIdentityProviderException">
        /// This exception is thrown when the specified identifier isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteIdentityProvider">REST API Reference for DeleteIdentityProvider Operation</seealso>
        DeleteIdentityProviderResponse DeleteIdentityProvider(DeleteIdentityProviderRequest request);



        /// <summary>
        /// Deletes an IdP for a user pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIdentityProvider service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteIdentityProvider service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ConcurrentModificationException">
        /// This exception is thrown if two or more modifications are happening concurrently.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UnsupportedIdentityProviderException">
        /// This exception is thrown when the specified identifier isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteIdentityProvider">REST API Reference for DeleteIdentityProvider Operation</seealso>
        Task<DeleteIdentityProviderResponse> DeleteIdentityProviderAsync(DeleteIdentityProviderRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteResourceServer


        /// <summary>
        /// Deletes a resource server.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourceServer service method.</param>
        /// 
        /// <returns>The response from the DeleteResourceServer service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteResourceServer">REST API Reference for DeleteResourceServer Operation</seealso>
        DeleteResourceServerResponse DeleteResourceServer(DeleteResourceServerRequest request);



        /// <summary>
        /// Deletes a resource server.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourceServer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteResourceServer service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteResourceServer">REST API Reference for DeleteResourceServer Operation</seealso>
        Task<DeleteResourceServerResponse> DeleteResourceServerAsync(DeleteResourceServerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteUser


        /// <summary>
        /// Allows a user to delete himself or herself.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser service method.</param>
        /// 
        /// <returns>The response from the DeleteUser service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ForbiddenException">
        /// This exception is thrown when WAF doesn't allow your request based on a web ACL that's
        /// associated with your user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordResetRequiredException">
        /// This exception is thrown when a password reset is required.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user isn't confirmed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        DeleteUserResponse DeleteUser(DeleteUserRequest request);



        /// <summary>
        /// Allows a user to delete himself or herself.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteUser service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ForbiddenException">
        /// This exception is thrown when WAF doesn't allow your request based on a web ACL that's
        /// associated with your user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordResetRequiredException">
        /// This exception is thrown when a password reset is required.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user isn't confirmed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        Task<DeleteUserResponse> DeleteUserAsync(DeleteUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteUserAttributes


        /// <summary>
        /// Deletes the attributes for a user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserAttributes service method.</param>
        /// 
        /// <returns>The response from the DeleteUserAttributes service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ForbiddenException">
        /// This exception is thrown when WAF doesn't allow your request based on a web ACL that's
        /// associated with your user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordResetRequiredException">
        /// This exception is thrown when a password reset is required.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user isn't confirmed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteUserAttributes">REST API Reference for DeleteUserAttributes Operation</seealso>
        DeleteUserAttributesResponse DeleteUserAttributes(DeleteUserAttributesRequest request);



        /// <summary>
        /// Deletes the attributes for a user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteUserAttributes service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ForbiddenException">
        /// This exception is thrown when WAF doesn't allow your request based on a web ACL that's
        /// associated with your user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordResetRequiredException">
        /// This exception is thrown when a password reset is required.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user isn't confirmed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteUserAttributes">REST API Reference for DeleteUserAttributes Operation</seealso>
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
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserImportInProgressException">
        /// This exception is thrown when you're trying to modify a user pool while a user import
        /// job is in progress for that pool.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteUserPool">REST API Reference for DeleteUserPool Operation</seealso>
        DeleteUserPoolResponse DeleteUserPool(DeleteUserPoolRequest request);



        /// <summary>
        /// Deletes the specified Amazon Cognito user pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserPool service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteUserPool service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserImportInProgressException">
        /// This exception is thrown when you're trying to modify a user pool while a user import
        /// job is in progress for that pool.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteUserPool">REST API Reference for DeleteUserPool Operation</seealso>
        Task<DeleteUserPoolResponse> DeleteUserPoolAsync(DeleteUserPoolRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteUserPoolClient


        /// <summary>
        /// Allows the developer to delete the user pool client.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserPoolClient service method.</param>
        /// 
        /// <returns>The response from the DeleteUserPoolClient service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ConcurrentModificationException">
        /// This exception is thrown if two or more modifications are happening concurrently.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteUserPoolClient">REST API Reference for DeleteUserPoolClient Operation</seealso>
        DeleteUserPoolClientResponse DeleteUserPoolClient(DeleteUserPoolClientRequest request);



        /// <summary>
        /// Allows the developer to delete the user pool client.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserPoolClient service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteUserPoolClient service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ConcurrentModificationException">
        /// This exception is thrown if two or more modifications are happening concurrently.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteUserPoolClient">REST API Reference for DeleteUserPoolClient Operation</seealso>
        Task<DeleteUserPoolClientResponse> DeleteUserPoolClientAsync(DeleteUserPoolClientRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteUserPoolDomain


        /// <summary>
        /// Deletes a domain for a user pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserPoolDomain service method.</param>
        /// 
        /// <returns>The response from the DeleteUserPoolDomain service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteUserPoolDomain">REST API Reference for DeleteUserPoolDomain Operation</seealso>
        DeleteUserPoolDomainResponse DeleteUserPoolDomain(DeleteUserPoolDomainRequest request);



        /// <summary>
        /// Deletes a domain for a user pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserPoolDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteUserPoolDomain service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteUserPoolDomain">REST API Reference for DeleteUserPoolDomain Operation</seealso>
        Task<DeleteUserPoolDomainResponse> DeleteUserPoolDomainAsync(DeleteUserPoolDomainRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeIdentityProvider


        /// <summary>
        /// Gets information about a specific IdP.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeIdentityProvider service method.</param>
        /// 
        /// <returns>The response from the DescribeIdentityProvider service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeIdentityProvider">REST API Reference for DescribeIdentityProvider Operation</seealso>
        DescribeIdentityProviderResponse DescribeIdentityProvider(DescribeIdentityProviderRequest request);



        /// <summary>
        /// Gets information about a specific IdP.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeIdentityProvider service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeIdentityProvider service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeIdentityProvider">REST API Reference for DescribeIdentityProvider Operation</seealso>
        Task<DescribeIdentityProviderResponse> DescribeIdentityProviderAsync(DescribeIdentityProviderRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeResourceServer


        /// <summary>
        /// Describes a resource server.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeResourceServer service method.</param>
        /// 
        /// <returns>The response from the DescribeResourceServer service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeResourceServer">REST API Reference for DescribeResourceServer Operation</seealso>
        DescribeResourceServerResponse DescribeResourceServer(DescribeResourceServerRequest request);



        /// <summary>
        /// Describes a resource server.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeResourceServer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeResourceServer service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeResourceServer">REST API Reference for DescribeResourceServer Operation</seealso>
        Task<DescribeResourceServerResponse> DescribeResourceServerAsync(DescribeResourceServerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeRiskConfiguration


        /// <summary>
        /// Describes the risk configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRiskConfiguration service method.</param>
        /// 
        /// <returns>The response from the DescribeRiskConfiguration service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserPoolAddOnNotEnabledException">
        /// This exception is thrown when user pool add-ons aren't enabled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeRiskConfiguration">REST API Reference for DescribeRiskConfiguration Operation</seealso>
        DescribeRiskConfigurationResponse DescribeRiskConfiguration(DescribeRiskConfigurationRequest request);



        /// <summary>
        /// Describes the risk configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRiskConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRiskConfiguration service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserPoolAddOnNotEnabledException">
        /// This exception is thrown when user pool add-ons aren't enabled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeRiskConfiguration">REST API Reference for DescribeRiskConfiguration Operation</seealso>
        Task<DescribeRiskConfigurationResponse> DescribeRiskConfigurationAsync(DescribeRiskConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeUserImportJob">REST API Reference for DescribeUserImportJob Operation</seealso>
        DescribeUserImportJobResponse DescribeUserImportJob(DescribeUserImportJobRequest request);



        /// <summary>
        /// Describes the user import job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUserImportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeUserImportJob service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeUserImportJob">REST API Reference for DescribeUserImportJob Operation</seealso>
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
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserPoolTaggingException">
        /// This exception is thrown when a user pool tag can't be set or updated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeUserPool">REST API Reference for DescribeUserPool Operation</seealso>
        DescribeUserPoolResponse DescribeUserPool(DescribeUserPoolRequest request);



        /// <summary>
        /// Returns the configuration information and metadata of the specified user pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUserPool service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeUserPool service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserPoolTaggingException">
        /// This exception is thrown when a user pool tag can't be set or updated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeUserPool">REST API Reference for DescribeUserPool Operation</seealso>
        Task<DescribeUserPoolResponse> DescribeUserPoolAsync(DescribeUserPoolRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeUserPoolClient


        /// <summary>
        /// Client method for returning the configuration information and metadata of the specified
        /// user pool app client.
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
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeUserPoolClient">REST API Reference for DescribeUserPoolClient Operation</seealso>
        DescribeUserPoolClientResponse DescribeUserPoolClient(DescribeUserPoolClientRequest request);



        /// <summary>
        /// Client method for returning the configuration information and metadata of the specified
        /// user pool app client.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUserPoolClient service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeUserPoolClient service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeUserPoolClient">REST API Reference for DescribeUserPoolClient Operation</seealso>
        Task<DescribeUserPoolClientResponse> DescribeUserPoolClientAsync(DescribeUserPoolClientRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeUserPoolDomain


        /// <summary>
        /// Gets information about a domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUserPoolDomain service method.</param>
        /// 
        /// <returns>The response from the DescribeUserPoolDomain service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeUserPoolDomain">REST API Reference for DescribeUserPoolDomain Operation</seealso>
        DescribeUserPoolDomainResponse DescribeUserPoolDomain(DescribeUserPoolDomainRequest request);



        /// <summary>
        /// Gets information about a domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUserPoolDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeUserPoolDomain service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeUserPoolDomain">REST API Reference for DescribeUserPoolDomain Operation</seealso>
        Task<DescribeUserPoolDomainResponse> DescribeUserPoolDomainAsync(DescribeUserPoolDomainRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ForgetDevice


        /// <summary>
        /// Forgets the specified device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ForgetDevice service method.</param>
        /// 
        /// <returns>The response from the ForgetDevice service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ForbiddenException">
        /// This exception is thrown when WAF doesn't allow your request based on a web ACL that's
        /// associated with your user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidUserPoolConfigurationException">
        /// This exception is thrown when the user pool configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordResetRequiredException">
        /// This exception is thrown when a password reset is required.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user isn't confirmed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ForgetDevice">REST API Reference for ForgetDevice Operation</seealso>
        ForgetDeviceResponse ForgetDevice(ForgetDeviceRequest request);



        /// <summary>
        /// Forgets the specified device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ForgetDevice service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ForgetDevice service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ForbiddenException">
        /// This exception is thrown when WAF doesn't allow your request based on a web ACL that's
        /// associated with your user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidUserPoolConfigurationException">
        /// This exception is thrown when the user pool configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordResetRequiredException">
        /// This exception is thrown when a password reset is required.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user isn't confirmed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ForgetDevice">REST API Reference for ForgetDevice Operation</seealso>
        Task<ForgetDeviceResponse> ForgetDeviceAsync(ForgetDeviceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ForgotPassword


        /// <summary>
        /// Calling this API causes a message to be sent to the end user with a confirmation code
        /// that is required to change the user's password. For the <code>Username</code> parameter,
        /// you can use the username or user alias. The method used to send the confirmation code
        /// is sent according to the specified AccountRecoverySetting. For more information, see
        /// <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/how-to-recover-a-user-account.html">Recovering
        /// User Accounts</a> in the <i>Amazon Cognito Developer Guide</i>. If neither a verified
        /// phone number nor a verified email exists, an <code>InvalidParameterException</code>
        /// is thrown. To use the confirmation code for resetting the password, call <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_ConfirmForgotPassword.html">ConfirmForgotPassword</a>.
        /// 
        /// 
        ///  <note> 
        /// <para>
        /// This action might generate an SMS text message. Starting June 1, 2021, US telecom
        /// carriers require you to register an origination phone number before you can send SMS
        /// messages to US phone numbers. If you use SMS text messages in Amazon Cognito, you
        /// must register a phone number with <a href="https://console.aws.amazon.com/pinpoint/home/">Amazon
        /// Pinpoint</a>. Amazon Cognito uses the registered number automatically. Otherwise,
        /// Amazon Cognito users who must receive SMS messages might not be able to sign up, activate
        /// their accounts, or sign in.
        /// </para>
        ///  
        /// <para>
        /// If you have never used SMS text messages with Amazon Cognito or any other Amazon Web
        /// Service, Amazon Simple Notification Service might place your account in the SMS sandbox.
        /// In <i> <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-sms-sandbox.html">sandbox
        /// mode</a> </i>, you can send messages only to verified phone numbers. After you test
        /// your app while in the sandbox environment, you can move out of the sandbox and into
        /// production. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-identity-pools-sms-userpool-settings.html">
        /// SMS message settings for Amazon Cognito user pools</a> in the <i>Amazon Cognito Developer
        /// Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ForgotPassword service method.</param>
        /// 
        /// <returns>The response from the ForgotPassword service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.CodeDeliveryFailureException">
        /// This exception is thrown when a verification code fails to deliver successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ForbiddenException">
        /// This exception is thrown when WAF doesn't allow your request based on a web ACL that's
        /// associated with your user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidEmailRoleAccessPolicyException">
        /// This exception is thrown when Amazon Cognito isn't allowed to use your email identity.
        /// HTTP status code: 400.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidLambdaResponseException">
        /// This exception is thrown when Amazon Cognito encounters an invalid Lambda response.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidSmsRoleAccessPolicyException">
        /// This exception is returned when the role provided for SMS configuration doesn't have
        /// permission to publish using Amazon SNS.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidSmsRoleTrustRelationshipException">
        /// This exception is thrown when the trust relationship is not valid for the role provided
        /// for SMS configuration. This can happen if you don't trust <code>cognito-idp.amazonaws.com</code>
        /// or the external ID provided in the role does not match what is provided in the SMS
        /// configuration for the user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.LimitExceededException">
        /// This exception is thrown when a user exceeds the limit for a requested Amazon Web
        /// Services resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UnexpectedLambdaException">
        /// This exception is thrown when Amazon Cognito encounters an unexpected exception with
        /// Lambda.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserLambdaValidationException">
        /// This exception is thrown when the Amazon Cognito service encounters a user validation
        /// exception with the Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ForgotPassword">REST API Reference for ForgotPassword Operation</seealso>
        ForgotPasswordResponse ForgotPassword(ForgotPasswordRequest request);



        /// <summary>
        /// Calling this API causes a message to be sent to the end user with a confirmation code
        /// that is required to change the user's password. For the <code>Username</code> parameter,
        /// you can use the username or user alias. The method used to send the confirmation code
        /// is sent according to the specified AccountRecoverySetting. For more information, see
        /// <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/how-to-recover-a-user-account.html">Recovering
        /// User Accounts</a> in the <i>Amazon Cognito Developer Guide</i>. If neither a verified
        /// phone number nor a verified email exists, an <code>InvalidParameterException</code>
        /// is thrown. To use the confirmation code for resetting the password, call <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_ConfirmForgotPassword.html">ConfirmForgotPassword</a>.
        /// 
        /// 
        ///  <note> 
        /// <para>
        /// This action might generate an SMS text message. Starting June 1, 2021, US telecom
        /// carriers require you to register an origination phone number before you can send SMS
        /// messages to US phone numbers. If you use SMS text messages in Amazon Cognito, you
        /// must register a phone number with <a href="https://console.aws.amazon.com/pinpoint/home/">Amazon
        /// Pinpoint</a>. Amazon Cognito uses the registered number automatically. Otherwise,
        /// Amazon Cognito users who must receive SMS messages might not be able to sign up, activate
        /// their accounts, or sign in.
        /// </para>
        ///  
        /// <para>
        /// If you have never used SMS text messages with Amazon Cognito or any other Amazon Web
        /// Service, Amazon Simple Notification Service might place your account in the SMS sandbox.
        /// In <i> <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-sms-sandbox.html">sandbox
        /// mode</a> </i>, you can send messages only to verified phone numbers. After you test
        /// your app while in the sandbox environment, you can move out of the sandbox and into
        /// production. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-identity-pools-sms-userpool-settings.html">
        /// SMS message settings for Amazon Cognito user pools</a> in the <i>Amazon Cognito Developer
        /// Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ForgotPassword service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ForgotPassword service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.CodeDeliveryFailureException">
        /// This exception is thrown when a verification code fails to deliver successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ForbiddenException">
        /// This exception is thrown when WAF doesn't allow your request based on a web ACL that's
        /// associated with your user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidEmailRoleAccessPolicyException">
        /// This exception is thrown when Amazon Cognito isn't allowed to use your email identity.
        /// HTTP status code: 400.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidLambdaResponseException">
        /// This exception is thrown when Amazon Cognito encounters an invalid Lambda response.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidSmsRoleAccessPolicyException">
        /// This exception is returned when the role provided for SMS configuration doesn't have
        /// permission to publish using Amazon SNS.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidSmsRoleTrustRelationshipException">
        /// This exception is thrown when the trust relationship is not valid for the role provided
        /// for SMS configuration. This can happen if you don't trust <code>cognito-idp.amazonaws.com</code>
        /// or the external ID provided in the role does not match what is provided in the SMS
        /// configuration for the user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.LimitExceededException">
        /// This exception is thrown when a user exceeds the limit for a requested Amazon Web
        /// Services resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UnexpectedLambdaException">
        /// This exception is thrown when Amazon Cognito encounters an unexpected exception with
        /// Lambda.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserLambdaValidationException">
        /// This exception is thrown when the Amazon Cognito service encounters a user validation
        /// exception with the Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ForgotPassword">REST API Reference for ForgotPassword Operation</seealso>
        Task<ForgotPasswordResponse> ForgotPasswordAsync(ForgotPasswordRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetCSVHeader


        /// <summary>
        /// Gets the header information for the comma-separated value (CSV) file to be used as
        /// input for the user import job.
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
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetCSVHeader">REST API Reference for GetCSVHeader Operation</seealso>
        GetCSVHeaderResponse GetCSVHeader(GetCSVHeaderRequest request);



        /// <summary>
        /// Gets the header information for the comma-separated value (CSV) file to be used as
        /// input for the user import job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCSVHeader service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCSVHeader service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetCSVHeader">REST API Reference for GetCSVHeader Operation</seealso>
        Task<GetCSVHeaderResponse> GetCSVHeaderAsync(GetCSVHeaderRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDevice


        /// <summary>
        /// Gets the device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDevice service method.</param>
        /// 
        /// <returns>The response from the GetDevice service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ForbiddenException">
        /// This exception is thrown when WAF doesn't allow your request based on a web ACL that's
        /// associated with your user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidUserPoolConfigurationException">
        /// This exception is thrown when the user pool configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordResetRequiredException">
        /// This exception is thrown when a password reset is required.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user isn't confirmed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetDevice">REST API Reference for GetDevice Operation</seealso>
        GetDeviceResponse GetDevice(GetDeviceRequest request);



        /// <summary>
        /// Gets the device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDevice service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDevice service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ForbiddenException">
        /// This exception is thrown when WAF doesn't allow your request based on a web ACL that's
        /// associated with your user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidUserPoolConfigurationException">
        /// This exception is thrown when the user pool configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordResetRequiredException">
        /// This exception is thrown when a password reset is required.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user isn't confirmed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetDevice">REST API Reference for GetDevice Operation</seealso>
        Task<GetDeviceResponse> GetDeviceAsync(GetDeviceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetGroup


        /// <summary>
        /// Gets a group.
        /// 
        ///  
        /// <para>
        /// Calling this action requires developer credentials.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGroup service method.</param>
        /// 
        /// <returns>The response from the GetGroup service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetGroup">REST API Reference for GetGroup Operation</seealso>
        GetGroupResponse GetGroup(GetGroupRequest request);



        /// <summary>
        /// Gets a group.
        /// 
        ///  
        /// <para>
        /// Calling this action requires developer credentials.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetGroup service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetGroup">REST API Reference for GetGroup Operation</seealso>
        Task<GetGroupResponse> GetGroupAsync(GetGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetIdentityProviderByIdentifier


        /// <summary>
        /// Gets the specified IdP.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIdentityProviderByIdentifier service method.</param>
        /// 
        /// <returns>The response from the GetIdentityProviderByIdentifier service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetIdentityProviderByIdentifier">REST API Reference for GetIdentityProviderByIdentifier Operation</seealso>
        GetIdentityProviderByIdentifierResponse GetIdentityProviderByIdentifier(GetIdentityProviderByIdentifierRequest request);



        /// <summary>
        /// Gets the specified IdP.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIdentityProviderByIdentifier service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetIdentityProviderByIdentifier service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetIdentityProviderByIdentifier">REST API Reference for GetIdentityProviderByIdentifier Operation</seealso>
        Task<GetIdentityProviderByIdentifierResponse> GetIdentityProviderByIdentifierAsync(GetIdentityProviderByIdentifierRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetSigningCertificate


        /// <summary>
        /// This method takes a user pool ID, and returns the signing certificate. The issued
        /// certificate is valid for 10 years from the date of issue.
        /// 
        ///  
        /// <para>
        /// Amazon Cognito issues and assigns a new signing certificate annually. This process
        /// returns a new value in the response to <code>GetSigningCertificate</code>, but doesn't
        /// invalidate the original certificate.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSigningCertificate service method.</param>
        /// 
        /// <returns>The response from the GetSigningCertificate service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetSigningCertificate">REST API Reference for GetSigningCertificate Operation</seealso>
        GetSigningCertificateResponse GetSigningCertificate(GetSigningCertificateRequest request);



        /// <summary>
        /// This method takes a user pool ID, and returns the signing certificate. The issued
        /// certificate is valid for 10 years from the date of issue.
        /// 
        ///  
        /// <para>
        /// Amazon Cognito issues and assigns a new signing certificate annually. This process
        /// returns a new value in the response to <code>GetSigningCertificate</code>, but doesn't
        /// invalidate the original certificate.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSigningCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSigningCertificate service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetSigningCertificate">REST API Reference for GetSigningCertificate Operation</seealso>
        Task<GetSigningCertificateResponse> GetSigningCertificateAsync(GetSigningCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetUICustomization


        /// <summary>
        /// Gets the user interface (UI) Customization information for a particular app client's
        /// app UI, if any such information exists for the client. If nothing is set for the particular
        /// client, but there is an existing pool level customization (the app <code>clientId</code>
        /// is <code>ALL</code>), then that information is returned. If nothing is present, then
        /// an empty shape is returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUICustomization service method.</param>
        /// 
        /// <returns>The response from the GetUICustomization service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetUICustomization">REST API Reference for GetUICustomization Operation</seealso>
        GetUICustomizationResponse GetUICustomization(GetUICustomizationRequest request);



        /// <summary>
        /// Gets the user interface (UI) Customization information for a particular app client's
        /// app UI, if any such information exists for the client. If nothing is set for the particular
        /// client, but there is an existing pool level customization (the app <code>clientId</code>
        /// is <code>ALL</code>), then that information is returned. If nothing is present, then
        /// an empty shape is returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUICustomization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetUICustomization service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetUICustomization">REST API Reference for GetUICustomization Operation</seealso>
        Task<GetUICustomizationResponse> GetUICustomizationAsync(GetUICustomizationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetUser


        /// <summary>
        /// Gets the user attributes and metadata for a user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUser service method.</param>
        /// 
        /// <returns>The response from the GetUser service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ForbiddenException">
        /// This exception is thrown when WAF doesn't allow your request based on a web ACL that's
        /// associated with your user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordResetRequiredException">
        /// This exception is thrown when a password reset is required.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user isn't confirmed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetUser">REST API Reference for GetUser Operation</seealso>
        GetUserResponse GetUser(GetUserRequest request);



        /// <summary>
        /// Gets the user attributes and metadata for a user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetUser service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ForbiddenException">
        /// This exception is thrown when WAF doesn't allow your request based on a web ACL that's
        /// associated with your user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordResetRequiredException">
        /// This exception is thrown when a password reset is required.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user isn't confirmed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetUser">REST API Reference for GetUser Operation</seealso>
        Task<GetUserResponse> GetUserAsync(GetUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetUserAttributeVerificationCode


        /// <summary>
        /// Generates a user attribute verification code for the specified attribute name. Sends
        /// a message to a user with a code that they must return in a VerifyUserAttribute request.
        /// 
        ///  <note> 
        /// <para>
        /// This action might generate an SMS text message. Starting June 1, 2021, US telecom
        /// carriers require you to register an origination phone number before you can send SMS
        /// messages to US phone numbers. If you use SMS text messages in Amazon Cognito, you
        /// must register a phone number with <a href="https://console.aws.amazon.com/pinpoint/home/">Amazon
        /// Pinpoint</a>. Amazon Cognito uses the registered number automatically. Otherwise,
        /// Amazon Cognito users who must receive SMS messages might not be able to sign up, activate
        /// their accounts, or sign in.
        /// </para>
        ///  
        /// <para>
        /// If you have never used SMS text messages with Amazon Cognito or any other Amazon Web
        /// Service, Amazon Simple Notification Service might place your account in the SMS sandbox.
        /// In <i> <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-sms-sandbox.html">sandbox
        /// mode</a> </i>, you can send messages only to verified phone numbers. After you test
        /// your app while in the sandbox environment, you can move out of the sandbox and into
        /// production. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-identity-pools-sms-userpool-settings.html">
        /// SMS message settings for Amazon Cognito user pools</a> in the <i>Amazon Cognito Developer
        /// Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUserAttributeVerificationCode service method.</param>
        /// 
        /// <returns>The response from the GetUserAttributeVerificationCode service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.CodeDeliveryFailureException">
        /// This exception is thrown when a verification code fails to deliver successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ForbiddenException">
        /// This exception is thrown when WAF doesn't allow your request based on a web ACL that's
        /// associated with your user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidEmailRoleAccessPolicyException">
        /// This exception is thrown when Amazon Cognito isn't allowed to use your email identity.
        /// HTTP status code: 400.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidLambdaResponseException">
        /// This exception is thrown when Amazon Cognito encounters an invalid Lambda response.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidSmsRoleAccessPolicyException">
        /// This exception is returned when the role provided for SMS configuration doesn't have
        /// permission to publish using Amazon SNS.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidSmsRoleTrustRelationshipException">
        /// This exception is thrown when the trust relationship is not valid for the role provided
        /// for SMS configuration. This can happen if you don't trust <code>cognito-idp.amazonaws.com</code>
        /// or the external ID provided in the role does not match what is provided in the SMS
        /// configuration for the user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.LimitExceededException">
        /// This exception is thrown when a user exceeds the limit for a requested Amazon Web
        /// Services resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordResetRequiredException">
        /// This exception is thrown when a password reset is required.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UnexpectedLambdaException">
        /// This exception is thrown when Amazon Cognito encounters an unexpected exception with
        /// Lambda.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserLambdaValidationException">
        /// This exception is thrown when the Amazon Cognito service encounters a user validation
        /// exception with the Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user isn't confirmed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetUserAttributeVerificationCode">REST API Reference for GetUserAttributeVerificationCode Operation</seealso>
        GetUserAttributeVerificationCodeResponse GetUserAttributeVerificationCode(GetUserAttributeVerificationCodeRequest request);



        /// <summary>
        /// Generates a user attribute verification code for the specified attribute name. Sends
        /// a message to a user with a code that they must return in a VerifyUserAttribute request.
        /// 
        ///  <note> 
        /// <para>
        /// This action might generate an SMS text message. Starting June 1, 2021, US telecom
        /// carriers require you to register an origination phone number before you can send SMS
        /// messages to US phone numbers. If you use SMS text messages in Amazon Cognito, you
        /// must register a phone number with <a href="https://console.aws.amazon.com/pinpoint/home/">Amazon
        /// Pinpoint</a>. Amazon Cognito uses the registered number automatically. Otherwise,
        /// Amazon Cognito users who must receive SMS messages might not be able to sign up, activate
        /// their accounts, or sign in.
        /// </para>
        ///  
        /// <para>
        /// If you have never used SMS text messages with Amazon Cognito or any other Amazon Web
        /// Service, Amazon Simple Notification Service might place your account in the SMS sandbox.
        /// In <i> <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-sms-sandbox.html">sandbox
        /// mode</a> </i>, you can send messages only to verified phone numbers. After you test
        /// your app while in the sandbox environment, you can move out of the sandbox and into
        /// production. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-identity-pools-sms-userpool-settings.html">
        /// SMS message settings for Amazon Cognito user pools</a> in the <i>Amazon Cognito Developer
        /// Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUserAttributeVerificationCode service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetUserAttributeVerificationCode service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.CodeDeliveryFailureException">
        /// This exception is thrown when a verification code fails to deliver successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ForbiddenException">
        /// This exception is thrown when WAF doesn't allow your request based on a web ACL that's
        /// associated with your user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidEmailRoleAccessPolicyException">
        /// This exception is thrown when Amazon Cognito isn't allowed to use your email identity.
        /// HTTP status code: 400.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidLambdaResponseException">
        /// This exception is thrown when Amazon Cognito encounters an invalid Lambda response.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidSmsRoleAccessPolicyException">
        /// This exception is returned when the role provided for SMS configuration doesn't have
        /// permission to publish using Amazon SNS.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidSmsRoleTrustRelationshipException">
        /// This exception is thrown when the trust relationship is not valid for the role provided
        /// for SMS configuration. This can happen if you don't trust <code>cognito-idp.amazonaws.com</code>
        /// or the external ID provided in the role does not match what is provided in the SMS
        /// configuration for the user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.LimitExceededException">
        /// This exception is thrown when a user exceeds the limit for a requested Amazon Web
        /// Services resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordResetRequiredException">
        /// This exception is thrown when a password reset is required.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UnexpectedLambdaException">
        /// This exception is thrown when Amazon Cognito encounters an unexpected exception with
        /// Lambda.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserLambdaValidationException">
        /// This exception is thrown when the Amazon Cognito service encounters a user validation
        /// exception with the Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user isn't confirmed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetUserAttributeVerificationCode">REST API Reference for GetUserAttributeVerificationCode Operation</seealso>
        Task<GetUserAttributeVerificationCodeResponse> GetUserAttributeVerificationCodeAsync(GetUserAttributeVerificationCodeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetUserPoolMfaConfig


        /// <summary>
        /// Gets the user pool multi-factor authentication (MFA) configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUserPoolMfaConfig service method.</param>
        /// 
        /// <returns>The response from the GetUserPoolMfaConfig service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetUserPoolMfaConfig">REST API Reference for GetUserPoolMfaConfig Operation</seealso>
        GetUserPoolMfaConfigResponse GetUserPoolMfaConfig(GetUserPoolMfaConfigRequest request);



        /// <summary>
        /// Gets the user pool multi-factor authentication (MFA) configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUserPoolMfaConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetUserPoolMfaConfig service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetUserPoolMfaConfig">REST API Reference for GetUserPoolMfaConfig Operation</seealso>
        Task<GetUserPoolMfaConfigResponse> GetUserPoolMfaConfigAsync(GetUserPoolMfaConfigRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GlobalSignOut


        /// <summary>
        /// Signs out users from all devices. It also invalidates all refresh tokens that Amazon
        /// Cognito has issued to a user. A user can still use a hosted UI cookie to retrieve
        /// new tokens for the duration of the 1-hour cookie validity period.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GlobalSignOut service method.</param>
        /// 
        /// <returns>The response from the GlobalSignOut service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ForbiddenException">
        /// This exception is thrown when WAF doesn't allow your request based on a web ACL that's
        /// associated with your user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordResetRequiredException">
        /// This exception is thrown when a password reset is required.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user isn't confirmed successfully.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GlobalSignOut">REST API Reference for GlobalSignOut Operation</seealso>
        GlobalSignOutResponse GlobalSignOut(GlobalSignOutRequest request);



        /// <summary>
        /// Signs out users from all devices. It also invalidates all refresh tokens that Amazon
        /// Cognito has issued to a user. A user can still use a hosted UI cookie to retrieve
        /// new tokens for the duration of the 1-hour cookie validity period.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GlobalSignOut service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GlobalSignOut service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ForbiddenException">
        /// This exception is thrown when WAF doesn't allow your request based on a web ACL that's
        /// associated with your user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordResetRequiredException">
        /// This exception is thrown when a password reset is required.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user isn't confirmed successfully.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GlobalSignOut">REST API Reference for GlobalSignOut Operation</seealso>
        Task<GlobalSignOutResponse> GlobalSignOutAsync(GlobalSignOutRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  InitiateAuth


        /// <summary>
        /// Initiates sign-in for a user in the Amazon Cognito user directory. You can't sign
        /// in a user with a federated IdP with <code>InitiateAuth</code>. For more information,
        /// see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pools-identity-federation.html">
        /// Adding user pool sign-in through a third party</a>.
        /// 
        ///  <note> 
        /// <para>
        /// This action might generate an SMS text message. Starting June 1, 2021, US telecom
        /// carriers require you to register an origination phone number before you can send SMS
        /// messages to US phone numbers. If you use SMS text messages in Amazon Cognito, you
        /// must register a phone number with <a href="https://console.aws.amazon.com/pinpoint/home/">Amazon
        /// Pinpoint</a>. Amazon Cognito uses the registered number automatically. Otherwise,
        /// Amazon Cognito users who must receive SMS messages might not be able to sign up, activate
        /// their accounts, or sign in.
        /// </para>
        ///  
        /// <para>
        /// If you have never used SMS text messages with Amazon Cognito or any other Amazon Web
        /// Service, Amazon Simple Notification Service might place your account in the SMS sandbox.
        /// In <i> <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-sms-sandbox.html">sandbox
        /// mode</a> </i>, you can send messages only to verified phone numbers. After you test
        /// your app while in the sandbox environment, you can move out of the sandbox and into
        /// production. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-identity-pools-sms-userpool-settings.html">
        /// SMS message settings for Amazon Cognito user pools</a> in the <i>Amazon Cognito Developer
        /// Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InitiateAuth service method.</param>
        /// 
        /// <returns>The response from the InitiateAuth service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ForbiddenException">
        /// This exception is thrown when WAF doesn't allow your request based on a web ACL that's
        /// associated with your user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidLambdaResponseException">
        /// This exception is thrown when Amazon Cognito encounters an invalid Lambda response.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidSmsRoleAccessPolicyException">
        /// This exception is returned when the role provided for SMS configuration doesn't have
        /// permission to publish using Amazon SNS.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidSmsRoleTrustRelationshipException">
        /// This exception is thrown when the trust relationship is not valid for the role provided
        /// for SMS configuration. This can happen if you don't trust <code>cognito-idp.amazonaws.com</code>
        /// or the external ID provided in the role does not match what is provided in the SMS
        /// configuration for the user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidUserPoolConfigurationException">
        /// This exception is thrown when the user pool configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordResetRequiredException">
        /// This exception is thrown when a password reset is required.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UnexpectedLambdaException">
        /// This exception is thrown when Amazon Cognito encounters an unexpected exception with
        /// Lambda.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserLambdaValidationException">
        /// This exception is thrown when the Amazon Cognito service encounters a user validation
        /// exception with the Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user isn't confirmed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/InitiateAuth">REST API Reference for InitiateAuth Operation</seealso>
        InitiateAuthResponse InitiateAuth(InitiateAuthRequest request);



        /// <summary>
        /// Initiates sign-in for a user in the Amazon Cognito user directory. You can't sign
        /// in a user with a federated IdP with <code>InitiateAuth</code>. For more information,
        /// see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pools-identity-federation.html">
        /// Adding user pool sign-in through a third party</a>.
        /// 
        ///  <note> 
        /// <para>
        /// This action might generate an SMS text message. Starting June 1, 2021, US telecom
        /// carriers require you to register an origination phone number before you can send SMS
        /// messages to US phone numbers. If you use SMS text messages in Amazon Cognito, you
        /// must register a phone number with <a href="https://console.aws.amazon.com/pinpoint/home/">Amazon
        /// Pinpoint</a>. Amazon Cognito uses the registered number automatically. Otherwise,
        /// Amazon Cognito users who must receive SMS messages might not be able to sign up, activate
        /// their accounts, or sign in.
        /// </para>
        ///  
        /// <para>
        /// If you have never used SMS text messages with Amazon Cognito or any other Amazon Web
        /// Service, Amazon Simple Notification Service might place your account in the SMS sandbox.
        /// In <i> <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-sms-sandbox.html">sandbox
        /// mode</a> </i>, you can send messages only to verified phone numbers. After you test
        /// your app while in the sandbox environment, you can move out of the sandbox and into
        /// production. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-identity-pools-sms-userpool-settings.html">
        /// SMS message settings for Amazon Cognito user pools</a> in the <i>Amazon Cognito Developer
        /// Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InitiateAuth service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the InitiateAuth service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ForbiddenException">
        /// This exception is thrown when WAF doesn't allow your request based on a web ACL that's
        /// associated with your user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidLambdaResponseException">
        /// This exception is thrown when Amazon Cognito encounters an invalid Lambda response.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidSmsRoleAccessPolicyException">
        /// This exception is returned when the role provided for SMS configuration doesn't have
        /// permission to publish using Amazon SNS.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidSmsRoleTrustRelationshipException">
        /// This exception is thrown when the trust relationship is not valid for the role provided
        /// for SMS configuration. This can happen if you don't trust <code>cognito-idp.amazonaws.com</code>
        /// or the external ID provided in the role does not match what is provided in the SMS
        /// configuration for the user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidUserPoolConfigurationException">
        /// This exception is thrown when the user pool configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordResetRequiredException">
        /// This exception is thrown when a password reset is required.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UnexpectedLambdaException">
        /// This exception is thrown when Amazon Cognito encounters an unexpected exception with
        /// Lambda.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserLambdaValidationException">
        /// This exception is thrown when the Amazon Cognito service encounters a user validation
        /// exception with the Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user isn't confirmed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/InitiateAuth">REST API Reference for InitiateAuth Operation</seealso>
        Task<InitiateAuthResponse> InitiateAuthAsync(InitiateAuthRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListDevices


        /// <summary>
        /// Lists the sign-in devices that Amazon Cognito has registered to the current user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDevices service method.</param>
        /// 
        /// <returns>The response from the ListDevices service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ForbiddenException">
        /// This exception is thrown when WAF doesn't allow your request based on a web ACL that's
        /// associated with your user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidUserPoolConfigurationException">
        /// This exception is thrown when the user pool configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordResetRequiredException">
        /// This exception is thrown when a password reset is required.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user isn't confirmed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListDevices">REST API Reference for ListDevices Operation</seealso>
        ListDevicesResponse ListDevices(ListDevicesRequest request);



        /// <summary>
        /// Lists the sign-in devices that Amazon Cognito has registered to the current user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDevices service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDevices service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ForbiddenException">
        /// This exception is thrown when WAF doesn't allow your request based on a web ACL that's
        /// associated with your user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidUserPoolConfigurationException">
        /// This exception is thrown when the user pool configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordResetRequiredException">
        /// This exception is thrown when a password reset is required.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user isn't confirmed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListDevices">REST API Reference for ListDevices Operation</seealso>
        Task<ListDevicesResponse> ListDevicesAsync(ListDevicesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListGroups


        /// <summary>
        /// Lists the groups associated with a user pool.
        /// 
        ///  
        /// <para>
        /// Calling this action requires developer credentials.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroups service method.</param>
        /// 
        /// <returns>The response from the ListGroups service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListGroups">REST API Reference for ListGroups Operation</seealso>
        ListGroupsResponse ListGroups(ListGroupsRequest request);



        /// <summary>
        /// Lists the groups associated with a user pool.
        /// 
        ///  
        /// <para>
        /// Calling this action requires developer credentials.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGroups service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListGroups">REST API Reference for ListGroups Operation</seealso>
        Task<ListGroupsResponse> ListGroupsAsync(ListGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListIdentityProviders


        /// <summary>
        /// Lists information about all IdPs for a user pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIdentityProviders service method.</param>
        /// 
        /// <returns>The response from the ListIdentityProviders service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListIdentityProviders">REST API Reference for ListIdentityProviders Operation</seealso>
        ListIdentityProvidersResponse ListIdentityProviders(ListIdentityProvidersRequest request);



        /// <summary>
        /// Lists information about all IdPs for a user pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIdentityProviders service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListIdentityProviders service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListIdentityProviders">REST API Reference for ListIdentityProviders Operation</seealso>
        Task<ListIdentityProvidersResponse> ListIdentityProvidersAsync(ListIdentityProvidersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListResourceServers


        /// <summary>
        /// Lists the resource servers for a user pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceServers service method.</param>
        /// 
        /// <returns>The response from the ListResourceServers service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListResourceServers">REST API Reference for ListResourceServers Operation</seealso>
        ListResourceServersResponse ListResourceServers(ListResourceServersRequest request);



        /// <summary>
        /// Lists the resource servers for a user pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceServers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListResourceServers service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListResourceServers">REST API Reference for ListResourceServers Operation</seealso>
        Task<ListResourceServersResponse> ListResourceServersAsync(ListResourceServersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags that are assigned to an Amazon Cognito user pool.
        /// 
        ///  
        /// <para>
        /// A tag is a label that you can apply to user pools to categorize and manage them in
        /// different ways, such as by purpose, owner, environment, or other criteria.
        /// </para>
        ///  
        /// <para>
        /// You can use this action up to 10 times per second, per account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// Lists the tags that are assigned to an Amazon Cognito user pool.
        /// 
        ///  
        /// <para>
        /// A tag is a label that you can apply to user pools to categorize and manage them in
        /// different ways, such as by purpose, owner, environment, or other criteria.
        /// </para>
        ///  
        /// <para>
        /// You can use this action up to 10 times per second, per account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListUserImportJobs">REST API Reference for ListUserImportJobs Operation</seealso>
        ListUserImportJobsResponse ListUserImportJobs(ListUserImportJobsRequest request);



        /// <summary>
        /// Lists the user import jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUserImportJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListUserImportJobs service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListUserImportJobs">REST API Reference for ListUserImportJobs Operation</seealso>
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
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListUserPoolClients">REST API Reference for ListUserPoolClients Operation</seealso>
        ListUserPoolClientsResponse ListUserPoolClients(ListUserPoolClientsRequest request);



        /// <summary>
        /// Lists the clients that have been created for the specified user pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUserPoolClients service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListUserPoolClients service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListUserPoolClients">REST API Reference for ListUserPoolClients Operation</seealso>
        Task<ListUserPoolClientsResponse> ListUserPoolClientsAsync(ListUserPoolClientsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListUserPools


        /// <summary>
        /// Lists the user pools associated with an Amazon Web Services account.
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
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListUserPools">REST API Reference for ListUserPools Operation</seealso>
        ListUserPoolsResponse ListUserPools(ListUserPoolsRequest request);



        /// <summary>
        /// Lists the user pools associated with an Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUserPools service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListUserPools service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListUserPools">REST API Reference for ListUserPools Operation</seealso>
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
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListUsers">REST API Reference for ListUsers Operation</seealso>
        ListUsersResponse ListUsers(ListUsersRequest request);



        /// <summary>
        /// Lists the users in the Amazon Cognito user pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUsers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListUsers service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListUsers">REST API Reference for ListUsers Operation</seealso>
        Task<ListUsersResponse> ListUsersAsync(ListUsersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListUsersInGroup


        /// <summary>
        /// Lists the users in the specified group.
        /// 
        ///  
        /// <para>
        /// Calling this action requires developer credentials.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUsersInGroup service method.</param>
        /// 
        /// <returns>The response from the ListUsersInGroup service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListUsersInGroup">REST API Reference for ListUsersInGroup Operation</seealso>
        ListUsersInGroupResponse ListUsersInGroup(ListUsersInGroupRequest request);



        /// <summary>
        /// Lists the users in the specified group.
        /// 
        ///  
        /// <para>
        /// Calling this action requires developer credentials.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUsersInGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListUsersInGroup service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListUsersInGroup">REST API Reference for ListUsersInGroup Operation</seealso>
        Task<ListUsersInGroupResponse> ListUsersInGroupAsync(ListUsersInGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ResendConfirmationCode


        /// <summary>
        /// Resends the confirmation (for confirmation of registration) to a specific user in
        /// the user pool.
        /// 
        ///  <note> 
        /// <para>
        /// This action might generate an SMS text message. Starting June 1, 2021, US telecom
        /// carriers require you to register an origination phone number before you can send SMS
        /// messages to US phone numbers. If you use SMS text messages in Amazon Cognito, you
        /// must register a phone number with <a href="https://console.aws.amazon.com/pinpoint/home/">Amazon
        /// Pinpoint</a>. Amazon Cognito uses the registered number automatically. Otherwise,
        /// Amazon Cognito users who must receive SMS messages might not be able to sign up, activate
        /// their accounts, or sign in.
        /// </para>
        ///  
        /// <para>
        /// If you have never used SMS text messages with Amazon Cognito or any other Amazon Web
        /// Service, Amazon Simple Notification Service might place your account in the SMS sandbox.
        /// In <i> <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-sms-sandbox.html">sandbox
        /// mode</a> </i>, you can send messages only to verified phone numbers. After you test
        /// your app while in the sandbox environment, you can move out of the sandbox and into
        /// production. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-identity-pools-sms-userpool-settings.html">
        /// SMS message settings for Amazon Cognito user pools</a> in the <i>Amazon Cognito Developer
        /// Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResendConfirmationCode service method.</param>
        /// 
        /// <returns>The response from the ResendConfirmationCode service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.CodeDeliveryFailureException">
        /// This exception is thrown when a verification code fails to deliver successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ForbiddenException">
        /// This exception is thrown when WAF doesn't allow your request based on a web ACL that's
        /// associated with your user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidEmailRoleAccessPolicyException">
        /// This exception is thrown when Amazon Cognito isn't allowed to use your email identity.
        /// HTTP status code: 400.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidLambdaResponseException">
        /// This exception is thrown when Amazon Cognito encounters an invalid Lambda response.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidSmsRoleAccessPolicyException">
        /// This exception is returned when the role provided for SMS configuration doesn't have
        /// permission to publish using Amazon SNS.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidSmsRoleTrustRelationshipException">
        /// This exception is thrown when the trust relationship is not valid for the role provided
        /// for SMS configuration. This can happen if you don't trust <code>cognito-idp.amazonaws.com</code>
        /// or the external ID provided in the role does not match what is provided in the SMS
        /// configuration for the user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.LimitExceededException">
        /// This exception is thrown when a user exceeds the limit for a requested Amazon Web
        /// Services resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UnexpectedLambdaException">
        /// This exception is thrown when Amazon Cognito encounters an unexpected exception with
        /// Lambda.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserLambdaValidationException">
        /// This exception is thrown when the Amazon Cognito service encounters a user validation
        /// exception with the Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ResendConfirmationCode">REST API Reference for ResendConfirmationCode Operation</seealso>
        ResendConfirmationCodeResponse ResendConfirmationCode(ResendConfirmationCodeRequest request);



        /// <summary>
        /// Resends the confirmation (for confirmation of registration) to a specific user in
        /// the user pool.
        /// 
        ///  <note> 
        /// <para>
        /// This action might generate an SMS text message. Starting June 1, 2021, US telecom
        /// carriers require you to register an origination phone number before you can send SMS
        /// messages to US phone numbers. If you use SMS text messages in Amazon Cognito, you
        /// must register a phone number with <a href="https://console.aws.amazon.com/pinpoint/home/">Amazon
        /// Pinpoint</a>. Amazon Cognito uses the registered number automatically. Otherwise,
        /// Amazon Cognito users who must receive SMS messages might not be able to sign up, activate
        /// their accounts, or sign in.
        /// </para>
        ///  
        /// <para>
        /// If you have never used SMS text messages with Amazon Cognito or any other Amazon Web
        /// Service, Amazon Simple Notification Service might place your account in the SMS sandbox.
        /// In <i> <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-sms-sandbox.html">sandbox
        /// mode</a> </i>, you can send messages only to verified phone numbers. After you test
        /// your app while in the sandbox environment, you can move out of the sandbox and into
        /// production. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-identity-pools-sms-userpool-settings.html">
        /// SMS message settings for Amazon Cognito user pools</a> in the <i>Amazon Cognito Developer
        /// Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResendConfirmationCode service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResendConfirmationCode service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.CodeDeliveryFailureException">
        /// This exception is thrown when a verification code fails to deliver successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ForbiddenException">
        /// This exception is thrown when WAF doesn't allow your request based on a web ACL that's
        /// associated with your user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidEmailRoleAccessPolicyException">
        /// This exception is thrown when Amazon Cognito isn't allowed to use your email identity.
        /// HTTP status code: 400.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidLambdaResponseException">
        /// This exception is thrown when Amazon Cognito encounters an invalid Lambda response.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidSmsRoleAccessPolicyException">
        /// This exception is returned when the role provided for SMS configuration doesn't have
        /// permission to publish using Amazon SNS.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidSmsRoleTrustRelationshipException">
        /// This exception is thrown when the trust relationship is not valid for the role provided
        /// for SMS configuration. This can happen if you don't trust <code>cognito-idp.amazonaws.com</code>
        /// or the external ID provided in the role does not match what is provided in the SMS
        /// configuration for the user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.LimitExceededException">
        /// This exception is thrown when a user exceeds the limit for a requested Amazon Web
        /// Services resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UnexpectedLambdaException">
        /// This exception is thrown when Amazon Cognito encounters an unexpected exception with
        /// Lambda.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserLambdaValidationException">
        /// This exception is thrown when the Amazon Cognito service encounters a user validation
        /// exception with the Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ResendConfirmationCode">REST API Reference for ResendConfirmationCode Operation</seealso>
        Task<ResendConfirmationCodeResponse> ResendConfirmationCodeAsync(ResendConfirmationCodeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RespondToAuthChallenge


        /// <summary>
        /// Responds to the authentication challenge.
        /// 
        ///  <note> 
        /// <para>
        /// This action might generate an SMS text message. Starting June 1, 2021, US telecom
        /// carriers require you to register an origination phone number before you can send SMS
        /// messages to US phone numbers. If you use SMS text messages in Amazon Cognito, you
        /// must register a phone number with <a href="https://console.aws.amazon.com/pinpoint/home/">Amazon
        /// Pinpoint</a>. Amazon Cognito uses the registered number automatically. Otherwise,
        /// Amazon Cognito users who must receive SMS messages might not be able to sign up, activate
        /// their accounts, or sign in.
        /// </para>
        ///  
        /// <para>
        /// If you have never used SMS text messages with Amazon Cognito or any other Amazon Web
        /// Service, Amazon Simple Notification Service might place your account in the SMS sandbox.
        /// In <i> <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-sms-sandbox.html">sandbox
        /// mode</a> </i>, you can send messages only to verified phone numbers. After you test
        /// your app while in the sandbox environment, you can move out of the sandbox and into
        /// production. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-identity-pools-sms-userpool-settings.html">
        /// SMS message settings for Amazon Cognito user pools</a> in the <i>Amazon Cognito Developer
        /// Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RespondToAuthChallenge service method.</param>
        /// 
        /// <returns>The response from the RespondToAuthChallenge service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.AliasExistsException">
        /// This exception is thrown when a user tries to confirm the account with an email address
        /// or phone number that has already been supplied as an alias for a different user profile.
        /// This exception indicates that an account with this email address or phone already
        /// exists in a user pool that you've configured to use email address or phone number
        /// as a sign-in alias.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.CodeMismatchException">
        /// This exception is thrown if the provided code doesn't match what the server was expecting.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ExpiredCodeException">
        /// This exception is thrown if a code has expired.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ForbiddenException">
        /// This exception is thrown when WAF doesn't allow your request based on a web ACL that's
        /// associated with your user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidLambdaResponseException">
        /// This exception is thrown when Amazon Cognito encounters an invalid Lambda response.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidPasswordException">
        /// This exception is thrown when Amazon Cognito encounters an invalid password.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidSmsRoleAccessPolicyException">
        /// This exception is returned when the role provided for SMS configuration doesn't have
        /// permission to publish using Amazon SNS.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidSmsRoleTrustRelationshipException">
        /// This exception is thrown when the trust relationship is not valid for the role provided
        /// for SMS configuration. This can happen if you don't trust <code>cognito-idp.amazonaws.com</code>
        /// or the external ID provided in the role does not match what is provided in the SMS
        /// configuration for the user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidUserPoolConfigurationException">
        /// This exception is thrown when the user pool configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.MFAMethodNotFoundException">
        /// This exception is thrown when Amazon Cognito can't find a multi-factor authentication
        /// (MFA) method.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordResetRequiredException">
        /// This exception is thrown when a password reset is required.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.SoftwareTokenMFANotFoundException">
        /// This exception is thrown when the software token time-based one-time password (TOTP)
        /// multi-factor authentication (MFA) isn't activated for the user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UnexpectedLambdaException">
        /// This exception is thrown when Amazon Cognito encounters an unexpected exception with
        /// Lambda.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserLambdaValidationException">
        /// This exception is thrown when the Amazon Cognito service encounters a user validation
        /// exception with the Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user isn't confirmed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/RespondToAuthChallenge">REST API Reference for RespondToAuthChallenge Operation</seealso>
        RespondToAuthChallengeResponse RespondToAuthChallenge(RespondToAuthChallengeRequest request);



        /// <summary>
        /// Responds to the authentication challenge.
        /// 
        ///  <note> 
        /// <para>
        /// This action might generate an SMS text message. Starting June 1, 2021, US telecom
        /// carriers require you to register an origination phone number before you can send SMS
        /// messages to US phone numbers. If you use SMS text messages in Amazon Cognito, you
        /// must register a phone number with <a href="https://console.aws.amazon.com/pinpoint/home/">Amazon
        /// Pinpoint</a>. Amazon Cognito uses the registered number automatically. Otherwise,
        /// Amazon Cognito users who must receive SMS messages might not be able to sign up, activate
        /// their accounts, or sign in.
        /// </para>
        ///  
        /// <para>
        /// If you have never used SMS text messages with Amazon Cognito or any other Amazon Web
        /// Service, Amazon Simple Notification Service might place your account in the SMS sandbox.
        /// In <i> <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-sms-sandbox.html">sandbox
        /// mode</a> </i>, you can send messages only to verified phone numbers. After you test
        /// your app while in the sandbox environment, you can move out of the sandbox and into
        /// production. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-identity-pools-sms-userpool-settings.html">
        /// SMS message settings for Amazon Cognito user pools</a> in the <i>Amazon Cognito Developer
        /// Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RespondToAuthChallenge service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RespondToAuthChallenge service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.AliasExistsException">
        /// This exception is thrown when a user tries to confirm the account with an email address
        /// or phone number that has already been supplied as an alias for a different user profile.
        /// This exception indicates that an account with this email address or phone already
        /// exists in a user pool that you've configured to use email address or phone number
        /// as a sign-in alias.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.CodeMismatchException">
        /// This exception is thrown if the provided code doesn't match what the server was expecting.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ExpiredCodeException">
        /// This exception is thrown if a code has expired.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ForbiddenException">
        /// This exception is thrown when WAF doesn't allow your request based on a web ACL that's
        /// associated with your user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidLambdaResponseException">
        /// This exception is thrown when Amazon Cognito encounters an invalid Lambda response.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidPasswordException">
        /// This exception is thrown when Amazon Cognito encounters an invalid password.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidSmsRoleAccessPolicyException">
        /// This exception is returned when the role provided for SMS configuration doesn't have
        /// permission to publish using Amazon SNS.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidSmsRoleTrustRelationshipException">
        /// This exception is thrown when the trust relationship is not valid for the role provided
        /// for SMS configuration. This can happen if you don't trust <code>cognito-idp.amazonaws.com</code>
        /// or the external ID provided in the role does not match what is provided in the SMS
        /// configuration for the user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidUserPoolConfigurationException">
        /// This exception is thrown when the user pool configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.MFAMethodNotFoundException">
        /// This exception is thrown when Amazon Cognito can't find a multi-factor authentication
        /// (MFA) method.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordResetRequiredException">
        /// This exception is thrown when a password reset is required.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.SoftwareTokenMFANotFoundException">
        /// This exception is thrown when the software token time-based one-time password (TOTP)
        /// multi-factor authentication (MFA) isn't activated for the user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UnexpectedLambdaException">
        /// This exception is thrown when Amazon Cognito encounters an unexpected exception with
        /// Lambda.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserLambdaValidationException">
        /// This exception is thrown when the Amazon Cognito service encounters a user validation
        /// exception with the Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user isn't confirmed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/RespondToAuthChallenge">REST API Reference for RespondToAuthChallenge Operation</seealso>
        Task<RespondToAuthChallengeResponse> RespondToAuthChallengeAsync(RespondToAuthChallengeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RevokeToken


        /// <summary>
        /// Revokes all of the access tokens generated by, and at the same time as, the specified
        /// refresh token. After a token is revoked, you can't use the revoked token to access
        /// Amazon Cognito user APIs, or to authorize access to your resource server.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeToken service method.</param>
        /// 
        /// <returns>The response from the RevokeToken service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ForbiddenException">
        /// This exception is thrown when WAF doesn't allow your request based on a web ACL that's
        /// associated with your user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UnauthorizedException">
        /// Exception that is thrown when the request isn't authorized. This can happen due to
        /// an invalid access token in the request.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UnsupportedOperationException">
        /// Exception that is thrown when you attempt to perform an operation that isn't enabled
        /// for the user pool client.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UnsupportedTokenTypeException">
        /// Exception that is thrown when an unsupported token is passed to an operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/RevokeToken">REST API Reference for RevokeToken Operation</seealso>
        RevokeTokenResponse RevokeToken(RevokeTokenRequest request);



        /// <summary>
        /// Revokes all of the access tokens generated by, and at the same time as, the specified
        /// refresh token. After a token is revoked, you can't use the revoked token to access
        /// Amazon Cognito user APIs, or to authorize access to your resource server.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeToken service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RevokeToken service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ForbiddenException">
        /// This exception is thrown when WAF doesn't allow your request based on a web ACL that's
        /// associated with your user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UnauthorizedException">
        /// Exception that is thrown when the request isn't authorized. This can happen due to
        /// an invalid access token in the request.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UnsupportedOperationException">
        /// Exception that is thrown when you attempt to perform an operation that isn't enabled
        /// for the user pool client.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UnsupportedTokenTypeException">
        /// Exception that is thrown when an unsupported token is passed to an operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/RevokeToken">REST API Reference for RevokeToken Operation</seealso>
        Task<RevokeTokenResponse> RevokeTokenAsync(RevokeTokenRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SetRiskConfiguration


        /// <summary>
        /// Configures actions on detected risks. To delete the risk configuration for <code>UserPoolId</code>
        /// or <code>ClientId</code>, pass null values for all four configuration types.
        /// 
        ///  
        /// <para>
        /// To activate Amazon Cognito advanced security features, update the user pool to include
        /// the <code>UserPoolAddOns</code> key<code>AdvancedSecurityMode</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetRiskConfiguration service method.</param>
        /// 
        /// <returns>The response from the SetRiskConfiguration service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.CodeDeliveryFailureException">
        /// This exception is thrown when a verification code fails to deliver successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidEmailRoleAccessPolicyException">
        /// This exception is thrown when Amazon Cognito isn't allowed to use your email identity.
        /// HTTP status code: 400.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserPoolAddOnNotEnabledException">
        /// This exception is thrown when user pool add-ons aren't enabled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/SetRiskConfiguration">REST API Reference for SetRiskConfiguration Operation</seealso>
        SetRiskConfigurationResponse SetRiskConfiguration(SetRiskConfigurationRequest request);



        /// <summary>
        /// Configures actions on detected risks. To delete the risk configuration for <code>UserPoolId</code>
        /// or <code>ClientId</code>, pass null values for all four configuration types.
        /// 
        ///  
        /// <para>
        /// To activate Amazon Cognito advanced security features, update the user pool to include
        /// the <code>UserPoolAddOns</code> key<code>AdvancedSecurityMode</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetRiskConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetRiskConfiguration service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.CodeDeliveryFailureException">
        /// This exception is thrown when a verification code fails to deliver successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidEmailRoleAccessPolicyException">
        /// This exception is thrown when Amazon Cognito isn't allowed to use your email identity.
        /// HTTP status code: 400.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserPoolAddOnNotEnabledException">
        /// This exception is thrown when user pool add-ons aren't enabled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/SetRiskConfiguration">REST API Reference for SetRiskConfiguration Operation</seealso>
        Task<SetRiskConfigurationResponse> SetRiskConfigurationAsync(SetRiskConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SetUICustomization


        /// <summary>
        /// Sets the user interface (UI) customization information for a user pool's built-in
        /// app UI.
        /// 
        ///  
        /// <para>
        /// You can specify app UI customization settings for a single client (with a specific
        /// <code>clientId</code>) or for all clients (by setting the <code>clientId</code> to
        /// <code>ALL</code>). If you specify <code>ALL</code>, the default configuration is used
        /// for every client that has no previously set UI customization. If you specify UI customization
        /// settings for a particular client, it will no longer return to the <code>ALL</code>
        /// configuration.
        /// </para>
        ///  <note> 
        /// <para>
        /// To use this API, your user pool must have a domain associated with it. Otherwise,
        /// there is no place to host the app's pages, and the service will throw an error.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetUICustomization service method.</param>
        /// 
        /// <returns>The response from the SetUICustomization service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/SetUICustomization">REST API Reference for SetUICustomization Operation</seealso>
        SetUICustomizationResponse SetUICustomization(SetUICustomizationRequest request);



        /// <summary>
        /// Sets the user interface (UI) customization information for a user pool's built-in
        /// app UI.
        /// 
        ///  
        /// <para>
        /// You can specify app UI customization settings for a single client (with a specific
        /// <code>clientId</code>) or for all clients (by setting the <code>clientId</code> to
        /// <code>ALL</code>). If you specify <code>ALL</code>, the default configuration is used
        /// for every client that has no previously set UI customization. If you specify UI customization
        /// settings for a particular client, it will no longer return to the <code>ALL</code>
        /// configuration.
        /// </para>
        ///  <note> 
        /// <para>
        /// To use this API, your user pool must have a domain associated with it. Otherwise,
        /// there is no place to host the app's pages, and the service will throw an error.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetUICustomization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetUICustomization service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/SetUICustomization">REST API Reference for SetUICustomization Operation</seealso>
        Task<SetUICustomizationResponse> SetUICustomizationAsync(SetUICustomizationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SetUserMFAPreference


        /// <summary>
        /// Set the user's multi-factor authentication (MFA) method preference, including which
        /// MFA factors are activated and if any are preferred. Only one factor can be set as
        /// preferred. The preferred MFA factor will be used to authenticate a user if multiple
        /// factors are activated. If multiple options are activated and no preference is set,
        /// a challenge to choose an MFA option will be returned during sign-in. If an MFA type
        /// is activated for a user, the user will be prompted for MFA during all sign-in attempts
        /// unless device tracking is turned on and the device has been trusted. If you want MFA
        /// to be applied selectively based on the assessed risk level of sign-in attempts, deactivate
        /// MFA for users and turn on Adaptive Authentication for the user pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetUserMFAPreference service method.</param>
        /// 
        /// <returns>The response from the SetUserMFAPreference service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ForbiddenException">
        /// This exception is thrown when WAF doesn't allow your request based on a web ACL that's
        /// associated with your user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordResetRequiredException">
        /// This exception is thrown when a password reset is required.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user isn't confirmed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/SetUserMFAPreference">REST API Reference for SetUserMFAPreference Operation</seealso>
        SetUserMFAPreferenceResponse SetUserMFAPreference(SetUserMFAPreferenceRequest request);



        /// <summary>
        /// Set the user's multi-factor authentication (MFA) method preference, including which
        /// MFA factors are activated and if any are preferred. Only one factor can be set as
        /// preferred. The preferred MFA factor will be used to authenticate a user if multiple
        /// factors are activated. If multiple options are activated and no preference is set,
        /// a challenge to choose an MFA option will be returned during sign-in. If an MFA type
        /// is activated for a user, the user will be prompted for MFA during all sign-in attempts
        /// unless device tracking is turned on and the device has been trusted. If you want MFA
        /// to be applied selectively based on the assessed risk level of sign-in attempts, deactivate
        /// MFA for users and turn on Adaptive Authentication for the user pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetUserMFAPreference service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetUserMFAPreference service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ForbiddenException">
        /// This exception is thrown when WAF doesn't allow your request based on a web ACL that's
        /// associated with your user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordResetRequiredException">
        /// This exception is thrown when a password reset is required.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user isn't confirmed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/SetUserMFAPreference">REST API Reference for SetUserMFAPreference Operation</seealso>
        Task<SetUserMFAPreferenceResponse> SetUserMFAPreferenceAsync(SetUserMFAPreferenceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SetUserPoolMfaConfig


        /// <summary>
        /// Sets the user pool multi-factor authentication (MFA) configuration.
        /// 
        ///  <note> 
        /// <para>
        /// This action might generate an SMS text message. Starting June 1, 2021, US telecom
        /// carriers require you to register an origination phone number before you can send SMS
        /// messages to US phone numbers. If you use SMS text messages in Amazon Cognito, you
        /// must register a phone number with <a href="https://console.aws.amazon.com/pinpoint/home/">Amazon
        /// Pinpoint</a>. Amazon Cognito uses the registered number automatically. Otherwise,
        /// Amazon Cognito users who must receive SMS messages might not be able to sign up, activate
        /// their accounts, or sign in.
        /// </para>
        ///  
        /// <para>
        /// If you have never used SMS text messages with Amazon Cognito or any other Amazon Web
        /// Service, Amazon Simple Notification Service might place your account in the SMS sandbox.
        /// In <i> <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-sms-sandbox.html">sandbox
        /// mode</a> </i>, you can send messages only to verified phone numbers. After you test
        /// your app while in the sandbox environment, you can move out of the sandbox and into
        /// production. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-identity-pools-sms-userpool-settings.html">
        /// SMS message settings for Amazon Cognito user pools</a> in the <i>Amazon Cognito Developer
        /// Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetUserPoolMfaConfig service method.</param>
        /// 
        /// <returns>The response from the SetUserPoolMfaConfig service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidSmsRoleAccessPolicyException">
        /// This exception is returned when the role provided for SMS configuration doesn't have
        /// permission to publish using Amazon SNS.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidSmsRoleTrustRelationshipException">
        /// This exception is thrown when the trust relationship is not valid for the role provided
        /// for SMS configuration. This can happen if you don't trust <code>cognito-idp.amazonaws.com</code>
        /// or the external ID provided in the role does not match what is provided in the SMS
        /// configuration for the user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/SetUserPoolMfaConfig">REST API Reference for SetUserPoolMfaConfig Operation</seealso>
        SetUserPoolMfaConfigResponse SetUserPoolMfaConfig(SetUserPoolMfaConfigRequest request);



        /// <summary>
        /// Sets the user pool multi-factor authentication (MFA) configuration.
        /// 
        ///  <note> 
        /// <para>
        /// This action might generate an SMS text message. Starting June 1, 2021, US telecom
        /// carriers require you to register an origination phone number before you can send SMS
        /// messages to US phone numbers. If you use SMS text messages in Amazon Cognito, you
        /// must register a phone number with <a href="https://console.aws.amazon.com/pinpoint/home/">Amazon
        /// Pinpoint</a>. Amazon Cognito uses the registered number automatically. Otherwise,
        /// Amazon Cognito users who must receive SMS messages might not be able to sign up, activate
        /// their accounts, or sign in.
        /// </para>
        ///  
        /// <para>
        /// If you have never used SMS text messages with Amazon Cognito or any other Amazon Web
        /// Service, Amazon Simple Notification Service might place your account in the SMS sandbox.
        /// In <i> <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-sms-sandbox.html">sandbox
        /// mode</a> </i>, you can send messages only to verified phone numbers. After you test
        /// your app while in the sandbox environment, you can move out of the sandbox and into
        /// production. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-identity-pools-sms-userpool-settings.html">
        /// SMS message settings for Amazon Cognito user pools</a> in the <i>Amazon Cognito Developer
        /// Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetUserPoolMfaConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetUserPoolMfaConfig service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidSmsRoleAccessPolicyException">
        /// This exception is returned when the role provided for SMS configuration doesn't have
        /// permission to publish using Amazon SNS.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidSmsRoleTrustRelationshipException">
        /// This exception is thrown when the trust relationship is not valid for the role provided
        /// for SMS configuration. This can happen if you don't trust <code>cognito-idp.amazonaws.com</code>
        /// or the external ID provided in the role does not match what is provided in the SMS
        /// configuration for the user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/SetUserPoolMfaConfig">REST API Reference for SetUserPoolMfaConfig Operation</seealso>
        Task<SetUserPoolMfaConfigResponse> SetUserPoolMfaConfigAsync(SetUserPoolMfaConfigRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SetUserSettings


        /// <summary>
        /// <i>This action is no longer supported.</i> You can use it to configure only SMS MFA.
        /// You can't use it to configure time-based one-time password (TOTP) software token MFA.
        /// To configure either type of MFA, use <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_SetUserMFAPreference.html">SetUserMFAPreference</a>
        /// instead.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetUserSettings service method.</param>
        /// 
        /// <returns>The response from the SetUserSettings service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ForbiddenException">
        /// This exception is thrown when WAF doesn't allow your request based on a web ACL that's
        /// associated with your user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordResetRequiredException">
        /// This exception is thrown when a password reset is required.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user isn't confirmed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/SetUserSettings">REST API Reference for SetUserSettings Operation</seealso>
        SetUserSettingsResponse SetUserSettings(SetUserSettingsRequest request);



        /// <summary>
        /// <i>This action is no longer supported.</i> You can use it to configure only SMS MFA.
        /// You can't use it to configure time-based one-time password (TOTP) software token MFA.
        /// To configure either type of MFA, use <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_SetUserMFAPreference.html">SetUserMFAPreference</a>
        /// instead.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetUserSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetUserSettings service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ForbiddenException">
        /// This exception is thrown when WAF doesn't allow your request based on a web ACL that's
        /// associated with your user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordResetRequiredException">
        /// This exception is thrown when a password reset is required.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user isn't confirmed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/SetUserSettings">REST API Reference for SetUserSettings Operation</seealso>
        Task<SetUserSettingsResponse> SetUserSettingsAsync(SetUserSettingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SignUp


        /// <summary>
        /// Registers the user in the specified user pool and creates a user name, password, and
        /// user attributes.
        /// 
        ///  <note> 
        /// <para>
        /// This action might generate an SMS text message. Starting June 1, 2021, US telecom
        /// carriers require you to register an origination phone number before you can send SMS
        /// messages to US phone numbers. If you use SMS text messages in Amazon Cognito, you
        /// must register a phone number with <a href="https://console.aws.amazon.com/pinpoint/home/">Amazon
        /// Pinpoint</a>. Amazon Cognito uses the registered number automatically. Otherwise,
        /// Amazon Cognito users who must receive SMS messages might not be able to sign up, activate
        /// their accounts, or sign in.
        /// </para>
        ///  
        /// <para>
        /// If you have never used SMS text messages with Amazon Cognito or any other Amazon Web
        /// Service, Amazon Simple Notification Service might place your account in the SMS sandbox.
        /// In <i> <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-sms-sandbox.html">sandbox
        /// mode</a> </i>, you can send messages only to verified phone numbers. After you test
        /// your app while in the sandbox environment, you can move out of the sandbox and into
        /// production. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-identity-pools-sms-userpool-settings.html">
        /// SMS message settings for Amazon Cognito user pools</a> in the <i>Amazon Cognito Developer
        /// Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SignUp service method.</param>
        /// 
        /// <returns>The response from the SignUp service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.CodeDeliveryFailureException">
        /// This exception is thrown when a verification code fails to deliver successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ForbiddenException">
        /// This exception is thrown when WAF doesn't allow your request based on a web ACL that's
        /// associated with your user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidEmailRoleAccessPolicyException">
        /// This exception is thrown when Amazon Cognito isn't allowed to use your email identity.
        /// HTTP status code: 400.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidLambdaResponseException">
        /// This exception is thrown when Amazon Cognito encounters an invalid Lambda response.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidPasswordException">
        /// This exception is thrown when Amazon Cognito encounters an invalid password.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidSmsRoleAccessPolicyException">
        /// This exception is returned when the role provided for SMS configuration doesn't have
        /// permission to publish using Amazon SNS.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidSmsRoleTrustRelationshipException">
        /// This exception is thrown when the trust relationship is not valid for the role provided
        /// for SMS configuration. This can happen if you don't trust <code>cognito-idp.amazonaws.com</code>
        /// or the external ID provided in the role does not match what is provided in the SMS
        /// configuration for the user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UnexpectedLambdaException">
        /// This exception is thrown when Amazon Cognito encounters an unexpected exception with
        /// Lambda.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserLambdaValidationException">
        /// This exception is thrown when the Amazon Cognito service encounters a user validation
        /// exception with the Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UsernameExistsException">
        /// This exception is thrown when Amazon Cognito encounters a user name that already exists
        /// in the user pool.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/SignUp">REST API Reference for SignUp Operation</seealso>
        SignUpResponse SignUp(SignUpRequest request);



        /// <summary>
        /// Registers the user in the specified user pool and creates a user name, password, and
        /// user attributes.
        /// 
        ///  <note> 
        /// <para>
        /// This action might generate an SMS text message. Starting June 1, 2021, US telecom
        /// carriers require you to register an origination phone number before you can send SMS
        /// messages to US phone numbers. If you use SMS text messages in Amazon Cognito, you
        /// must register a phone number with <a href="https://console.aws.amazon.com/pinpoint/home/">Amazon
        /// Pinpoint</a>. Amazon Cognito uses the registered number automatically. Otherwise,
        /// Amazon Cognito users who must receive SMS messages might not be able to sign up, activate
        /// their accounts, or sign in.
        /// </para>
        ///  
        /// <para>
        /// If you have never used SMS text messages with Amazon Cognito or any other Amazon Web
        /// Service, Amazon Simple Notification Service might place your account in the SMS sandbox.
        /// In <i> <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-sms-sandbox.html">sandbox
        /// mode</a> </i>, you can send messages only to verified phone numbers. After you test
        /// your app while in the sandbox environment, you can move out of the sandbox and into
        /// production. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-identity-pools-sms-userpool-settings.html">
        /// SMS message settings for Amazon Cognito user pools</a> in the <i>Amazon Cognito Developer
        /// Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SignUp service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SignUp service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.CodeDeliveryFailureException">
        /// This exception is thrown when a verification code fails to deliver successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ForbiddenException">
        /// This exception is thrown when WAF doesn't allow your request based on a web ACL that's
        /// associated with your user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidEmailRoleAccessPolicyException">
        /// This exception is thrown when Amazon Cognito isn't allowed to use your email identity.
        /// HTTP status code: 400.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidLambdaResponseException">
        /// This exception is thrown when Amazon Cognito encounters an invalid Lambda response.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidPasswordException">
        /// This exception is thrown when Amazon Cognito encounters an invalid password.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidSmsRoleAccessPolicyException">
        /// This exception is returned when the role provided for SMS configuration doesn't have
        /// permission to publish using Amazon SNS.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidSmsRoleTrustRelationshipException">
        /// This exception is thrown when the trust relationship is not valid for the role provided
        /// for SMS configuration. This can happen if you don't trust <code>cognito-idp.amazonaws.com</code>
        /// or the external ID provided in the role does not match what is provided in the SMS
        /// configuration for the user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UnexpectedLambdaException">
        /// This exception is thrown when Amazon Cognito encounters an unexpected exception with
        /// Lambda.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserLambdaValidationException">
        /// This exception is thrown when the Amazon Cognito service encounters a user validation
        /// exception with the Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UsernameExistsException">
        /// This exception is thrown when Amazon Cognito encounters a user name that already exists
        /// in the user pool.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/SignUp">REST API Reference for SignUp Operation</seealso>
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
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PreconditionNotMetException">
        /// This exception is thrown when a precondition is not met.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/StartUserImportJob">REST API Reference for StartUserImportJob Operation</seealso>
        StartUserImportJobResponse StartUserImportJob(StartUserImportJobRequest request);



        /// <summary>
        /// Starts the user import.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartUserImportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartUserImportJob service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PreconditionNotMetException">
        /// This exception is thrown when a precondition is not met.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/StartUserImportJob">REST API Reference for StartUserImportJob Operation</seealso>
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
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PreconditionNotMetException">
        /// This exception is thrown when a precondition is not met.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/StopUserImportJob">REST API Reference for StopUserImportJob Operation</seealso>
        StopUserImportJobResponse StopUserImportJob(StopUserImportJobRequest request);



        /// <summary>
        /// Stops the user import job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopUserImportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopUserImportJob service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PreconditionNotMetException">
        /// This exception is thrown when a precondition is not met.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/StopUserImportJob">REST API Reference for StopUserImportJob Operation</seealso>
        Task<StopUserImportJobResponse> StopUserImportJobAsync(StopUserImportJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Assigns a set of tags to an Amazon Cognito user pool. A tag is a label that you can
        /// use to categorize and manage user pools in different ways, such as by purpose, owner,
        /// environment, or other criteria.
        /// 
        ///  
        /// <para>
        /// Each tag consists of a key and value, both of which you define. A key is a general
        /// category for more specific values. For example, if you have two versions of a user
        /// pool, one for testing and another for production, you might assign an <code>Environment</code>
        /// tag key to both user pools. The value of this key might be <code>Test</code> for one
        /// user pool, and <code>Production</code> for the other.
        /// </para>
        ///  
        /// <para>
        /// Tags are useful for cost tracking and access control. You can activate your tags so
        /// that they appear on the Billing and Cost Management console, where you can track the
        /// costs associated with your user pools. In an Identity and Access Management policy,
        /// you can constrain permissions for user pools based on specific tags or tag values.
        /// </para>
        ///  
        /// <para>
        /// You can use this action up to 5 times per second, per account. A user pool can have
        /// as many as 50 tags.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// Assigns a set of tags to an Amazon Cognito user pool. A tag is a label that you can
        /// use to categorize and manage user pools in different ways, such as by purpose, owner,
        /// environment, or other criteria.
        /// 
        ///  
        /// <para>
        /// Each tag consists of a key and value, both of which you define. A key is a general
        /// category for more specific values. For example, if you have two versions of a user
        /// pool, one for testing and another for production, you might assign an <code>Environment</code>
        /// tag key to both user pools. The value of this key might be <code>Test</code> for one
        /// user pool, and <code>Production</code> for the other.
        /// </para>
        ///  
        /// <para>
        /// Tags are useful for cost tracking and access control. You can activate your tags so
        /// that they appear on the Billing and Cost Management console, where you can track the
        /// costs associated with your user pools. In an Identity and Access Management policy,
        /// you can constrain permissions for user pools based on specific tags or tag values.
        /// </para>
        ///  
        /// <para>
        /// You can use this action up to 5 times per second, per account. A user pool can have
        /// as many as 50 tags.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes the specified tags from an Amazon Cognito user pool. You can use this action
        /// up to 5 times per second, per account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// Removes the specified tags from an Amazon Cognito user pool. You can use this action
        /// up to 5 times per second, per account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateAuthEventFeedback


        /// <summary>
        /// Provides the feedback for an authentication event, whether it was from a valid user
        /// or not. This feedback is used for improving the risk evaluation decision for the user
        /// pool as part of Amazon Cognito advanced security.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAuthEventFeedback service method.</param>
        /// 
        /// <returns>The response from the UpdateAuthEventFeedback service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserPoolAddOnNotEnabledException">
        /// This exception is thrown when user pool add-ons aren't enabled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateAuthEventFeedback">REST API Reference for UpdateAuthEventFeedback Operation</seealso>
        UpdateAuthEventFeedbackResponse UpdateAuthEventFeedback(UpdateAuthEventFeedbackRequest request);



        /// <summary>
        /// Provides the feedback for an authentication event, whether it was from a valid user
        /// or not. This feedback is used for improving the risk evaluation decision for the user
        /// pool as part of Amazon Cognito advanced security.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAuthEventFeedback service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAuthEventFeedback service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserPoolAddOnNotEnabledException">
        /// This exception is thrown when user pool add-ons aren't enabled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateAuthEventFeedback">REST API Reference for UpdateAuthEventFeedback Operation</seealso>
        Task<UpdateAuthEventFeedbackResponse> UpdateAuthEventFeedbackAsync(UpdateAuthEventFeedbackRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateDeviceStatus


        /// <summary>
        /// Updates the device status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDeviceStatus service method.</param>
        /// 
        /// <returns>The response from the UpdateDeviceStatus service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ForbiddenException">
        /// This exception is thrown when WAF doesn't allow your request based on a web ACL that's
        /// associated with your user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidUserPoolConfigurationException">
        /// This exception is thrown when the user pool configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordResetRequiredException">
        /// This exception is thrown when a password reset is required.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user isn't confirmed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateDeviceStatus">REST API Reference for UpdateDeviceStatus Operation</seealso>
        UpdateDeviceStatusResponse UpdateDeviceStatus(UpdateDeviceStatusRequest request);



        /// <summary>
        /// Updates the device status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDeviceStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDeviceStatus service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ForbiddenException">
        /// This exception is thrown when WAF doesn't allow your request based on a web ACL that's
        /// associated with your user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidUserPoolConfigurationException">
        /// This exception is thrown when the user pool configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordResetRequiredException">
        /// This exception is thrown when a password reset is required.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user isn't confirmed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateDeviceStatus">REST API Reference for UpdateDeviceStatus Operation</seealso>
        Task<UpdateDeviceStatusResponse> UpdateDeviceStatusAsync(UpdateDeviceStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateGroup


        /// <summary>
        /// Updates the specified group with the specified attributes.
        /// 
        ///  
        /// <para>
        /// Calling this action requires developer credentials.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateGroup service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateGroup">REST API Reference for UpdateGroup Operation</seealso>
        UpdateGroupResponse UpdateGroup(UpdateGroupRequest request);



        /// <summary>
        /// Updates the specified group with the specified attributes.
        /// 
        ///  
        /// <para>
        /// Calling this action requires developer credentials.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateGroup service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateGroup">REST API Reference for UpdateGroup Operation</seealso>
        Task<UpdateGroupResponse> UpdateGroupAsync(UpdateGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateIdentityProvider


        /// <summary>
        /// Updates IdP information for a user pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIdentityProvider service method.</param>
        /// 
        /// <returns>The response from the UpdateIdentityProvider service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ConcurrentModificationException">
        /// This exception is thrown if two or more modifications are happening concurrently.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UnsupportedIdentityProviderException">
        /// This exception is thrown when the specified identifier isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateIdentityProvider">REST API Reference for UpdateIdentityProvider Operation</seealso>
        UpdateIdentityProviderResponse UpdateIdentityProvider(UpdateIdentityProviderRequest request);



        /// <summary>
        /// Updates IdP information for a user pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIdentityProvider service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateIdentityProvider service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ConcurrentModificationException">
        /// This exception is thrown if two or more modifications are happening concurrently.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UnsupportedIdentityProviderException">
        /// This exception is thrown when the specified identifier isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateIdentityProvider">REST API Reference for UpdateIdentityProvider Operation</seealso>
        Task<UpdateIdentityProviderResponse> UpdateIdentityProviderAsync(UpdateIdentityProviderRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateResourceServer


        /// <summary>
        /// Updates the name and scopes of resource server. All other fields are read-only.
        /// 
        ///  <important> 
        /// <para>
        /// If you don't provide a value for an attribute, it is set to the default value.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResourceServer service method.</param>
        /// 
        /// <returns>The response from the UpdateResourceServer service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateResourceServer">REST API Reference for UpdateResourceServer Operation</seealso>
        UpdateResourceServerResponse UpdateResourceServer(UpdateResourceServerRequest request);



        /// <summary>
        /// Updates the name and scopes of resource server. All other fields are read-only.
        /// 
        ///  <important> 
        /// <para>
        /// If you don't provide a value for an attribute, it is set to the default value.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResourceServer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateResourceServer service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateResourceServer">REST API Reference for UpdateResourceServer Operation</seealso>
        Task<UpdateResourceServerResponse> UpdateResourceServerAsync(UpdateResourceServerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateUserAttributes


        /// <summary>
        /// Allows a user to update a specific attribute (one at a time).
        /// 
        ///  <note> 
        /// <para>
        /// This action might generate an SMS text message. Starting June 1, 2021, US telecom
        /// carriers require you to register an origination phone number before you can send SMS
        /// messages to US phone numbers. If you use SMS text messages in Amazon Cognito, you
        /// must register a phone number with <a href="https://console.aws.amazon.com/pinpoint/home/">Amazon
        /// Pinpoint</a>. Amazon Cognito uses the registered number automatically. Otherwise,
        /// Amazon Cognito users who must receive SMS messages might not be able to sign up, activate
        /// their accounts, or sign in.
        /// </para>
        ///  
        /// <para>
        /// If you have never used SMS text messages with Amazon Cognito or any other Amazon Web
        /// Service, Amazon Simple Notification Service might place your account in the SMS sandbox.
        /// In <i> <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-sms-sandbox.html">sandbox
        /// mode</a> </i>, you can send messages only to verified phone numbers. After you test
        /// your app while in the sandbox environment, you can move out of the sandbox and into
        /// production. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-identity-pools-sms-userpool-settings.html">
        /// SMS message settings for Amazon Cognito user pools</a> in the <i>Amazon Cognito Developer
        /// Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserAttributes service method.</param>
        /// 
        /// <returns>The response from the UpdateUserAttributes service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.AliasExistsException">
        /// This exception is thrown when a user tries to confirm the account with an email address
        /// or phone number that has already been supplied as an alias for a different user profile.
        /// This exception indicates that an account with this email address or phone already
        /// exists in a user pool that you've configured to use email address or phone number
        /// as a sign-in alias.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.CodeDeliveryFailureException">
        /// This exception is thrown when a verification code fails to deliver successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.CodeMismatchException">
        /// This exception is thrown if the provided code doesn't match what the server was expecting.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ExpiredCodeException">
        /// This exception is thrown if a code has expired.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ForbiddenException">
        /// This exception is thrown when WAF doesn't allow your request based on a web ACL that's
        /// associated with your user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidEmailRoleAccessPolicyException">
        /// This exception is thrown when Amazon Cognito isn't allowed to use your email identity.
        /// HTTP status code: 400.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidLambdaResponseException">
        /// This exception is thrown when Amazon Cognito encounters an invalid Lambda response.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidSmsRoleAccessPolicyException">
        /// This exception is returned when the role provided for SMS configuration doesn't have
        /// permission to publish using Amazon SNS.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidSmsRoleTrustRelationshipException">
        /// This exception is thrown when the trust relationship is not valid for the role provided
        /// for SMS configuration. This can happen if you don't trust <code>cognito-idp.amazonaws.com</code>
        /// or the external ID provided in the role does not match what is provided in the SMS
        /// configuration for the user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordResetRequiredException">
        /// This exception is thrown when a password reset is required.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UnexpectedLambdaException">
        /// This exception is thrown when Amazon Cognito encounters an unexpected exception with
        /// Lambda.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserLambdaValidationException">
        /// This exception is thrown when the Amazon Cognito service encounters a user validation
        /// exception with the Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user isn't confirmed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateUserAttributes">REST API Reference for UpdateUserAttributes Operation</seealso>
        UpdateUserAttributesResponse UpdateUserAttributes(UpdateUserAttributesRequest request);



        /// <summary>
        /// Allows a user to update a specific attribute (one at a time).
        /// 
        ///  <note> 
        /// <para>
        /// This action might generate an SMS text message. Starting June 1, 2021, US telecom
        /// carriers require you to register an origination phone number before you can send SMS
        /// messages to US phone numbers. If you use SMS text messages in Amazon Cognito, you
        /// must register a phone number with <a href="https://console.aws.amazon.com/pinpoint/home/">Amazon
        /// Pinpoint</a>. Amazon Cognito uses the registered number automatically. Otherwise,
        /// Amazon Cognito users who must receive SMS messages might not be able to sign up, activate
        /// their accounts, or sign in.
        /// </para>
        ///  
        /// <para>
        /// If you have never used SMS text messages with Amazon Cognito or any other Amazon Web
        /// Service, Amazon Simple Notification Service might place your account in the SMS sandbox.
        /// In <i> <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-sms-sandbox.html">sandbox
        /// mode</a> </i>, you can send messages only to verified phone numbers. After you test
        /// your app while in the sandbox environment, you can move out of the sandbox and into
        /// production. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-identity-pools-sms-userpool-settings.html">
        /// SMS message settings for Amazon Cognito user pools</a> in the <i>Amazon Cognito Developer
        /// Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateUserAttributes service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.AliasExistsException">
        /// This exception is thrown when a user tries to confirm the account with an email address
        /// or phone number that has already been supplied as an alias for a different user profile.
        /// This exception indicates that an account with this email address or phone already
        /// exists in a user pool that you've configured to use email address or phone number
        /// as a sign-in alias.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.CodeDeliveryFailureException">
        /// This exception is thrown when a verification code fails to deliver successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.CodeMismatchException">
        /// This exception is thrown if the provided code doesn't match what the server was expecting.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ExpiredCodeException">
        /// This exception is thrown if a code has expired.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ForbiddenException">
        /// This exception is thrown when WAF doesn't allow your request based on a web ACL that's
        /// associated with your user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidEmailRoleAccessPolicyException">
        /// This exception is thrown when Amazon Cognito isn't allowed to use your email identity.
        /// HTTP status code: 400.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidLambdaResponseException">
        /// This exception is thrown when Amazon Cognito encounters an invalid Lambda response.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidSmsRoleAccessPolicyException">
        /// This exception is returned when the role provided for SMS configuration doesn't have
        /// permission to publish using Amazon SNS.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidSmsRoleTrustRelationshipException">
        /// This exception is thrown when the trust relationship is not valid for the role provided
        /// for SMS configuration. This can happen if you don't trust <code>cognito-idp.amazonaws.com</code>
        /// or the external ID provided in the role does not match what is provided in the SMS
        /// configuration for the user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordResetRequiredException">
        /// This exception is thrown when a password reset is required.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UnexpectedLambdaException">
        /// This exception is thrown when Amazon Cognito encounters an unexpected exception with
        /// Lambda.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserLambdaValidationException">
        /// This exception is thrown when the Amazon Cognito service encounters a user validation
        /// exception with the Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user isn't confirmed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateUserAttributes">REST API Reference for UpdateUserAttributes Operation</seealso>
        Task<UpdateUserAttributesResponse> UpdateUserAttributesAsync(UpdateUserAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateUserPool


        /// <summary>
        /// Updates the specified user pool with the specified attributes. You can get a list
        /// of the current user pool settings using <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_DescribeUserPool.html">DescribeUserPool</a>.
        /// If you don't provide a value for an attribute, it will be set to the default value.
        /// 
        /// 
        ///  <note> 
        /// <para>
        /// This action might generate an SMS text message. Starting June 1, 2021, US telecom
        /// carriers require you to register an origination phone number before you can send SMS
        /// messages to US phone numbers. If you use SMS text messages in Amazon Cognito, you
        /// must register a phone number with <a href="https://console.aws.amazon.com/pinpoint/home/">Amazon
        /// Pinpoint</a>. Amazon Cognito uses the registered number automatically. Otherwise,
        /// Amazon Cognito users who must receive SMS messages might not be able to sign up, activate
        /// their accounts, or sign in.
        /// </para>
        ///  
        /// <para>
        /// If you have never used SMS text messages with Amazon Cognito or any other Amazon Web
        /// Service, Amazon Simple Notification Service might place your account in the SMS sandbox.
        /// In <i> <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-sms-sandbox.html">sandbox
        /// mode</a> </i>, you can send messages only to verified phone numbers. After you test
        /// your app while in the sandbox environment, you can move out of the sandbox and into
        /// production. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-identity-pools-sms-userpool-settings.html">
        /// SMS message settings for Amazon Cognito user pools</a> in the <i>Amazon Cognito Developer
        /// Guide</i>.
        /// </para>
        ///  </note>
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
        /// This exception is thrown when Amazon Cognito isn't allowed to use your email identity.
        /// HTTP status code: 400.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidSmsRoleAccessPolicyException">
        /// This exception is returned when the role provided for SMS configuration doesn't have
        /// permission to publish using Amazon SNS.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidSmsRoleTrustRelationshipException">
        /// This exception is thrown when the trust relationship is not valid for the role provided
        /// for SMS configuration. This can happen if you don't trust <code>cognito-idp.amazonaws.com</code>
        /// or the external ID provided in the role does not match what is provided in the SMS
        /// configuration for the user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserImportInProgressException">
        /// This exception is thrown when you're trying to modify a user pool while a user import
        /// job is in progress for that pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserPoolTaggingException">
        /// This exception is thrown when a user pool tag can't be set or updated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateUserPool">REST API Reference for UpdateUserPool Operation</seealso>
        UpdateUserPoolResponse UpdateUserPool(UpdateUserPoolRequest request);



        /// <summary>
        /// Updates the specified user pool with the specified attributes. You can get a list
        /// of the current user pool settings using <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_DescribeUserPool.html">DescribeUserPool</a>.
        /// If you don't provide a value for an attribute, it will be set to the default value.
        /// 
        /// 
        ///  <note> 
        /// <para>
        /// This action might generate an SMS text message. Starting June 1, 2021, US telecom
        /// carriers require you to register an origination phone number before you can send SMS
        /// messages to US phone numbers. If you use SMS text messages in Amazon Cognito, you
        /// must register a phone number with <a href="https://console.aws.amazon.com/pinpoint/home/">Amazon
        /// Pinpoint</a>. Amazon Cognito uses the registered number automatically. Otherwise,
        /// Amazon Cognito users who must receive SMS messages might not be able to sign up, activate
        /// their accounts, or sign in.
        /// </para>
        ///  
        /// <para>
        /// If you have never used SMS text messages with Amazon Cognito or any other Amazon Web
        /// Service, Amazon Simple Notification Service might place your account in the SMS sandbox.
        /// In <i> <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-sms-sandbox.html">sandbox
        /// mode</a> </i>, you can send messages only to verified phone numbers. After you test
        /// your app while in the sandbox environment, you can move out of the sandbox and into
        /// production. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-identity-pools-sms-userpool-settings.html">
        /// SMS message settings for Amazon Cognito user pools</a> in the <i>Amazon Cognito Developer
        /// Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserPool service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateUserPool service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ConcurrentModificationException">
        /// This exception is thrown if two or more modifications are happening concurrently.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidEmailRoleAccessPolicyException">
        /// This exception is thrown when Amazon Cognito isn't allowed to use your email identity.
        /// HTTP status code: 400.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidSmsRoleAccessPolicyException">
        /// This exception is returned when the role provided for SMS configuration doesn't have
        /// permission to publish using Amazon SNS.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidSmsRoleTrustRelationshipException">
        /// This exception is thrown when the trust relationship is not valid for the role provided
        /// for SMS configuration. This can happen if you don't trust <code>cognito-idp.amazonaws.com</code>
        /// or the external ID provided in the role does not match what is provided in the SMS
        /// configuration for the user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserImportInProgressException">
        /// This exception is thrown when you're trying to modify a user pool while a user import
        /// job is in progress for that pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserPoolTaggingException">
        /// This exception is thrown when a user pool tag can't be set or updated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateUserPool">REST API Reference for UpdateUserPool Operation</seealso>
        Task<UpdateUserPoolResponse> UpdateUserPoolAsync(UpdateUserPoolRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateUserPoolClient


        /// <summary>
        /// Updates the specified user pool app client with the specified attributes. You can
        /// get a list of the current user pool app client settings using <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_DescribeUserPoolClient.html">DescribeUserPoolClient</a>.
        /// 
        ///  <important> 
        /// <para>
        /// If you don't provide a value for an attribute, it will be set to the default value.
        /// </para>
        ///  </important> 
        /// <para>
        /// You can also use this operation to enable token revocation for user pool clients.
        /// For more information about revoking tokens, see <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_RevokeToken.html">RevokeToken</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserPoolClient service method.</param>
        /// 
        /// <returns>The response from the UpdateUserPoolClient service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ConcurrentModificationException">
        /// This exception is thrown if two or more modifications are happening concurrently.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidOAuthFlowException">
        /// This exception is thrown when the specified OAuth flow is not valid.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ScopeDoesNotExistException">
        /// This exception is thrown when the specified scope doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateUserPoolClient">REST API Reference for UpdateUserPoolClient Operation</seealso>
        UpdateUserPoolClientResponse UpdateUserPoolClient(UpdateUserPoolClientRequest request);



        /// <summary>
        /// Updates the specified user pool app client with the specified attributes. You can
        /// get a list of the current user pool app client settings using <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_DescribeUserPoolClient.html">DescribeUserPoolClient</a>.
        /// 
        ///  <important> 
        /// <para>
        /// If you don't provide a value for an attribute, it will be set to the default value.
        /// </para>
        ///  </important> 
        /// <para>
        /// You can also use this operation to enable token revocation for user pool clients.
        /// For more information about revoking tokens, see <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_RevokeToken.html">RevokeToken</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserPoolClient service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateUserPoolClient service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ConcurrentModificationException">
        /// This exception is thrown if two or more modifications are happening concurrently.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidOAuthFlowException">
        /// This exception is thrown when the specified OAuth flow is not valid.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ScopeDoesNotExistException">
        /// This exception is thrown when the specified scope doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateUserPoolClient">REST API Reference for UpdateUserPoolClient Operation</seealso>
        Task<UpdateUserPoolClientResponse> UpdateUserPoolClientAsync(UpdateUserPoolClientRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateUserPoolDomain


        /// <summary>
        /// Updates the Secure Sockets Layer (SSL) certificate for the custom domain for your
        /// user pool.
        /// 
        ///  
        /// <para>
        /// You can use this operation to provide the Amazon Resource Name (ARN) of a new certificate
        /// to Amazon Cognito. You can't use it to change the domain for a user pool.
        /// </para>
        ///  
        /// <para>
        /// A custom domain is used to host the Amazon Cognito hosted UI, which provides sign-up
        /// and sign-in pages for your application. When you set up a custom domain, you provide
        /// a certificate that you manage with Certificate Manager (ACM). When necessary, you
        /// can use this operation to change the certificate that you applied to your custom domain.
        /// </para>
        ///  
        /// <para>
        /// Usually, this is unnecessary following routine certificate renewal with ACM. When
        /// you renew your existing certificate in ACM, the ARN for your certificate remains the
        /// same, and your custom domain uses the new certificate automatically.
        /// </para>
        ///  
        /// <para>
        /// However, if you replace your existing certificate with a new one, ACM gives the new
        /// certificate a new ARN. To apply the new certificate to your custom domain, you must
        /// provide this ARN to Amazon Cognito.
        /// </para>
        ///  
        /// <para>
        /// When you add your new certificate in ACM, you must choose US East (N. Virginia) as
        /// the Amazon Web Services Region.
        /// </para>
        ///  
        /// <para>
        /// After you submit your request, Amazon Cognito requires up to 1 hour to distribute
        /// your new certificate to your custom domain.
        /// </para>
        ///  
        /// <para>
        /// For more information about adding a custom domain to your user pool, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pools-add-custom-domain.html">Using
        /// Your Own Domain for the Hosted UI</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserPoolDomain service method.</param>
        /// 
        /// <returns>The response from the UpdateUserPoolDomain service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateUserPoolDomain">REST API Reference for UpdateUserPoolDomain Operation</seealso>
        UpdateUserPoolDomainResponse UpdateUserPoolDomain(UpdateUserPoolDomainRequest request);



        /// <summary>
        /// Updates the Secure Sockets Layer (SSL) certificate for the custom domain for your
        /// user pool.
        /// 
        ///  
        /// <para>
        /// You can use this operation to provide the Amazon Resource Name (ARN) of a new certificate
        /// to Amazon Cognito. You can't use it to change the domain for a user pool.
        /// </para>
        ///  
        /// <para>
        /// A custom domain is used to host the Amazon Cognito hosted UI, which provides sign-up
        /// and sign-in pages for your application. When you set up a custom domain, you provide
        /// a certificate that you manage with Certificate Manager (ACM). When necessary, you
        /// can use this operation to change the certificate that you applied to your custom domain.
        /// </para>
        ///  
        /// <para>
        /// Usually, this is unnecessary following routine certificate renewal with ACM. When
        /// you renew your existing certificate in ACM, the ARN for your certificate remains the
        /// same, and your custom domain uses the new certificate automatically.
        /// </para>
        ///  
        /// <para>
        /// However, if you replace your existing certificate with a new one, ACM gives the new
        /// certificate a new ARN. To apply the new certificate to your custom domain, you must
        /// provide this ARN to Amazon Cognito.
        /// </para>
        ///  
        /// <para>
        /// When you add your new certificate in ACM, you must choose US East (N. Virginia) as
        /// the Amazon Web Services Region.
        /// </para>
        ///  
        /// <para>
        /// After you submit your request, Amazon Cognito requires up to 1 hour to distribute
        /// your new certificate to your custom domain.
        /// </para>
        ///  
        /// <para>
        /// For more information about adding a custom domain to your user pool, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pools-add-custom-domain.html">Using
        /// Your Own Domain for the Hosted UI</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserPoolDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateUserPoolDomain service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateUserPoolDomain">REST API Reference for UpdateUserPoolDomain Operation</seealso>
        Task<UpdateUserPoolDomainResponse> UpdateUserPoolDomainAsync(UpdateUserPoolDomainRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  VerifySoftwareToken


        /// <summary>
        /// Use this API to register a user's entered time-based one-time password (TOTP) code
        /// and mark the user's software token MFA status as "verified" if successful. The request
        /// takes an access token or a session string, but not both.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the VerifySoftwareToken service method.</param>
        /// 
        /// <returns>The response from the VerifySoftwareToken service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.CodeMismatchException">
        /// This exception is thrown if the provided code doesn't match what the server was expecting.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.EnableSoftwareTokenMFAException">
        /// This exception is thrown when there is a code mismatch and the service fails to configure
        /// the software token TOTP multi-factor authentication (MFA).
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ForbiddenException">
        /// This exception is thrown when WAF doesn't allow your request based on a web ACL that's
        /// associated with your user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidUserPoolConfigurationException">
        /// This exception is thrown when the user pool configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordResetRequiredException">
        /// This exception is thrown when a password reset is required.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.SoftwareTokenMFANotFoundException">
        /// This exception is thrown when the software token time-based one-time password (TOTP)
        /// multi-factor authentication (MFA) isn't activated for the user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user isn't confirmed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/VerifySoftwareToken">REST API Reference for VerifySoftwareToken Operation</seealso>
        VerifySoftwareTokenResponse VerifySoftwareToken(VerifySoftwareTokenRequest request);



        /// <summary>
        /// Use this API to register a user's entered time-based one-time password (TOTP) code
        /// and mark the user's software token MFA status as "verified" if successful. The request
        /// takes an access token or a session string, but not both.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the VerifySoftwareToken service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the VerifySoftwareToken service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.CodeMismatchException">
        /// This exception is thrown if the provided code doesn't match what the server was expecting.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.EnableSoftwareTokenMFAException">
        /// This exception is thrown when there is a code mismatch and the service fails to configure
        /// the software token TOTP multi-factor authentication (MFA).
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ForbiddenException">
        /// This exception is thrown when WAF doesn't allow your request based on a web ACL that's
        /// associated with your user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidUserPoolConfigurationException">
        /// This exception is thrown when the user pool configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordResetRequiredException">
        /// This exception is thrown when a password reset is required.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.SoftwareTokenMFANotFoundException">
        /// This exception is thrown when the software token time-based one-time password (TOTP)
        /// multi-factor authentication (MFA) isn't activated for the user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user isn't confirmed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/VerifySoftwareToken">REST API Reference for VerifySoftwareToken Operation</seealso>
        Task<VerifySoftwareTokenResponse> VerifySoftwareTokenAsync(VerifySoftwareTokenRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  VerifyUserAttribute


        /// <summary>
        /// Verifies the specified user attributes in the user pool.
        /// 
        ///  
        /// <para>
        ///  If your user pool requires verification before Amazon Cognito updates the attribute
        /// value, VerifyUserAttribute updates the affected attribute to its pending value. For
        /// more information, see <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_UserAttributeUpdateSettingsType.html">
        /// UserAttributeUpdateSettingsType</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the VerifyUserAttribute service method.</param>
        /// 
        /// <returns>The response from the VerifyUserAttribute service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.AliasExistsException">
        /// This exception is thrown when a user tries to confirm the account with an email address
        /// or phone number that has already been supplied as an alias for a different user profile.
        /// This exception indicates that an account with this email address or phone already
        /// exists in a user pool that you've configured to use email address or phone number
        /// as a sign-in alias.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.CodeMismatchException">
        /// This exception is thrown if the provided code doesn't match what the server was expecting.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ExpiredCodeException">
        /// This exception is thrown if a code has expired.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ForbiddenException">
        /// This exception is thrown when WAF doesn't allow your request based on a web ACL that's
        /// associated with your user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.LimitExceededException">
        /// This exception is thrown when a user exceeds the limit for a requested Amazon Web
        /// Services resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordResetRequiredException">
        /// This exception is thrown when a password reset is required.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user isn't confirmed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/VerifyUserAttribute">REST API Reference for VerifyUserAttribute Operation</seealso>
        VerifyUserAttributeResponse VerifyUserAttribute(VerifyUserAttributeRequest request);



        /// <summary>
        /// Verifies the specified user attributes in the user pool.
        /// 
        ///  
        /// <para>
        ///  If your user pool requires verification before Amazon Cognito updates the attribute
        /// value, VerifyUserAttribute updates the affected attribute to its pending value. For
        /// more information, see <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_UserAttributeUpdateSettingsType.html">
        /// UserAttributeUpdateSettingsType</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the VerifyUserAttribute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the VerifyUserAttribute service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.AliasExistsException">
        /// This exception is thrown when a user tries to confirm the account with an email address
        /// or phone number that has already been supplied as an alias for a different user profile.
        /// This exception indicates that an account with this email address or phone already
        /// exists in a user pool that you've configured to use email address or phone number
        /// as a sign-in alias.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.CodeMismatchException">
        /// This exception is thrown if the provided code doesn't match what the server was expecting.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ExpiredCodeException">
        /// This exception is thrown if a code has expired.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ForbiddenException">
        /// This exception is thrown when WAF doesn't allow your request based on a web ACL that's
        /// associated with your user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.LimitExceededException">
        /// This exception is thrown when a user exceeds the limit for a requested Amazon Web
        /// Services resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordResetRequiredException">
        /// This exception is thrown when a password reset is required.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user isn't confirmed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user isn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/VerifyUserAttribute">REST API Reference for VerifyUserAttribute Operation</seealso>
        Task<VerifyUserAttributeResponse> VerifyUserAttributeAsync(VerifyUserAttributeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}