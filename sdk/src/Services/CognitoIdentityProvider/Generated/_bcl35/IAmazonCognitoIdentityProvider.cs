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


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        ICognitoIdentityProviderPaginatorFactory Paginators { get; }
#endif


        
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
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserImportInProgressException">
        /// This exception is thrown when you are trying to modify a user pool while a user import
        /// job is in progress for that pool.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AddCustomAttributes">REST API Reference for AddCustomAttributes Operation</seealso>
        AddCustomAttributesResponse AddCustomAttributes(AddCustomAttributesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AddCustomAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddCustomAttributes operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddCustomAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AddCustomAttributes">REST API Reference for AddCustomAttributes Operation</seealso>
        IAsyncResult BeginAddCustomAttributes(AddCustomAttributesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AddCustomAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddCustomAttributes.</param>
        /// 
        /// <returns>Returns a  AddCustomAttributesResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AddCustomAttributes">REST API Reference for AddCustomAttributes Operation</seealso>
        AddCustomAttributesResponse EndAddCustomAttributes(IAsyncResult asyncResult);

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
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminAddUserToGroup">REST API Reference for AdminAddUserToGroup Operation</seealso>
        AdminAddUserToGroupResponse AdminAddUserToGroup(AdminAddUserToGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AdminAddUserToGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminAddUserToGroup operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAdminAddUserToGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminAddUserToGroup">REST API Reference for AdminAddUserToGroup Operation</seealso>
        IAsyncResult BeginAdminAddUserToGroup(AdminAddUserToGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AdminAddUserToGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAdminAddUserToGroup.</param>
        /// 
        /// <returns>Returns a  AdminAddUserToGroupResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminAddUserToGroup">REST API Reference for AdminAddUserToGroup Operation</seealso>
        AdminAddUserToGroupResponse EndAdminAddUserToGroup(IAsyncResult asyncResult);

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
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyFailedAttemptsException">
        /// This exception is thrown when the user has made too many failed attempts for a given
        /// action (e.g., sign in).
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UnexpectedLambdaException">
        /// This exception is thrown when the Amazon Cognito service encounters an unexpected
        /// exception with the AWS Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserLambdaValidationException">
        /// This exception is thrown when the Amazon Cognito service encounters a user validation
        /// exception with the AWS Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminConfirmSignUp">REST API Reference for AdminConfirmSignUp Operation</seealso>
        AdminConfirmSignUpResponse AdminConfirmSignUp(AdminConfirmSignUpRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AdminConfirmSignUp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminConfirmSignUp operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAdminConfirmSignUp
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminConfirmSignUp">REST API Reference for AdminConfirmSignUp Operation</seealso>
        IAsyncResult BeginAdminConfirmSignUp(AdminConfirmSignUpRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AdminConfirmSignUp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAdminConfirmSignUp.</param>
        /// 
        /// <returns>Returns a  AdminConfirmSignUpResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminConfirmSignUp">REST API Reference for AdminConfirmSignUp Operation</seealso>
        AdminConfirmSignUpResponse EndAdminConfirmSignUp(IAsyncResult asyncResult);

        #endregion
        
        #region  AdminCreateUser


        /// <summary>
        /// Creates a new user in the specified user pool.
        /// 
        ///  
        /// <para>
        /// If <code>MessageAction</code> is not set, the default is to send a welcome message
        /// via email or phone (SMS).
        /// </para>
        ///  
        /// <para>
        /// This message is based on a template that you configured in your call to create or
        /// update a user pool. This template includes your custom sign-up instructions and placeholders
        /// for user name and temporary password.
        /// </para>
        ///  
        /// <para>
        /// Alternatively, you can call <code>AdminCreateUser</code> with “SUPPRESS” for the <code>MessageAction</code>
        /// parameter, and Amazon Cognito will not send any email. 
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
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PreconditionNotMetException">
        /// This exception is thrown when a precondition is not met.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UnexpectedLambdaException">
        /// This exception is thrown when the Amazon Cognito service encounters an unexpected
        /// exception with the AWS Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UnsupportedUserStateException">
        /// The request failed because the user is in an unsupported state.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserLambdaValidationException">
        /// This exception is thrown when the Amazon Cognito service encounters a user validation
        /// exception with the AWS Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UsernameExistsException">
        /// This exception is thrown when Amazon Cognito encounters a user name that already exists
        /// in the user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminCreateUser">REST API Reference for AdminCreateUser Operation</seealso>
        AdminCreateUserResponse AdminCreateUser(AdminCreateUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AdminCreateUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminCreateUser operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAdminCreateUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminCreateUser">REST API Reference for AdminCreateUser Operation</seealso>
        IAsyncResult BeginAdminCreateUser(AdminCreateUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AdminCreateUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAdminCreateUser.</param>
        /// 
        /// <returns>Returns a  AdminCreateUserResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminCreateUser">REST API Reference for AdminCreateUser Operation</seealso>
        AdminCreateUserResponse EndAdminCreateUser(IAsyncResult asyncResult);

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
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminDeleteUser">REST API Reference for AdminDeleteUser Operation</seealso>
        AdminDeleteUserResponse AdminDeleteUser(AdminDeleteUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AdminDeleteUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminDeleteUser operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAdminDeleteUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminDeleteUser">REST API Reference for AdminDeleteUser Operation</seealso>
        IAsyncResult BeginAdminDeleteUser(AdminDeleteUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AdminDeleteUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAdminDeleteUser.</param>
        /// 
        /// <returns>Returns a  AdminDeleteUserResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminDeleteUser">REST API Reference for AdminDeleteUser Operation</seealso>
        AdminDeleteUserResponse EndAdminDeleteUser(IAsyncResult asyncResult);

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
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminDeleteUserAttributes">REST API Reference for AdminDeleteUserAttributes Operation</seealso>
        AdminDeleteUserAttributesResponse AdminDeleteUserAttributes(AdminDeleteUserAttributesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AdminDeleteUserAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminDeleteUserAttributes operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAdminDeleteUserAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminDeleteUserAttributes">REST API Reference for AdminDeleteUserAttributes Operation</seealso>
        IAsyncResult BeginAdminDeleteUserAttributes(AdminDeleteUserAttributesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AdminDeleteUserAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAdminDeleteUserAttributes.</param>
        /// 
        /// <returns>Returns a  AdminDeleteUserAttributesResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminDeleteUserAttributes">REST API Reference for AdminDeleteUserAttributes Operation</seealso>
        AdminDeleteUserAttributesResponse EndAdminDeleteUserAttributes(IAsyncResult asyncResult);

        #endregion
        
        #region  AdminDisableProviderForUser


        /// <summary>
        /// Disables the user from signing in with the specified external (SAML or social) identity
        /// provider. If the user to disable is a Cognito User Pools native username + password
        /// user, they are not permitted to use their password to sign-in. If the user to disable
        /// is a linked external IdP user, any link between that user and an existing user is
        /// removed. The next time the external user (no longer attached to the previously linked
        /// <code>DestinationUser</code>) signs in, they must create a new user account. See <a
        /// href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_AdminLinkProviderForUser.html">AdminLinkProviderForUser</a>.
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
        /// To disable a native username + password user, the <code>ProviderName</code> value
        /// must be <code>Cognito</code> and the <code>ProviderAttributeName</code> must be <code>Cognito_Subject</code>,
        /// with the <code>ProviderAttributeValue</code> being the name that is used in the user
        /// pool for the user.
        /// </para>
        ///  
        /// <para>
        /// The <code>ProviderAttributeName</code> must always be <code>Cognito_Subject</code>
        /// for social identity providers. The <code>ProviderAttributeValue</code> must always
        /// be the exact subject that was used when the user was originally linked as a source
        /// user.
        /// </para>
        ///  
        /// <para>
        /// For de-linking a SAML identity, there are two scenarios. If the linked identity has
        /// not yet been used to sign-in, the <code>ProviderAttributeName</code> and <code>ProviderAttributeValue</code>
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
        /// This exception is thrown when a user tries to confirm the account with an email or
        /// phone number that has already been supplied as an alias from a different account.
        /// This exception tells user that an account with this email or phone already exists.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminDisableProviderForUser">REST API Reference for AdminDisableProviderForUser Operation</seealso>
        AdminDisableProviderForUserResponse AdminDisableProviderForUser(AdminDisableProviderForUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AdminDisableProviderForUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminDisableProviderForUser operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAdminDisableProviderForUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminDisableProviderForUser">REST API Reference for AdminDisableProviderForUser Operation</seealso>
        IAsyncResult BeginAdminDisableProviderForUser(AdminDisableProviderForUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AdminDisableProviderForUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAdminDisableProviderForUser.</param>
        /// 
        /// <returns>Returns a  AdminDisableProviderForUserResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminDisableProviderForUser">REST API Reference for AdminDisableProviderForUser Operation</seealso>
        AdminDisableProviderForUserResponse EndAdminDisableProviderForUser(IAsyncResult asyncResult);

        #endregion
        
        #region  AdminDisableUser


        /// <summary>
        /// Disables the specified user.
        /// 
        ///  
        /// <para>
        /// Calling this action requires developer credentials.
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
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminDisableUser">REST API Reference for AdminDisableUser Operation</seealso>
        AdminDisableUserResponse AdminDisableUser(AdminDisableUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AdminDisableUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminDisableUser operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAdminDisableUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminDisableUser">REST API Reference for AdminDisableUser Operation</seealso>
        IAsyncResult BeginAdminDisableUser(AdminDisableUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AdminDisableUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAdminDisableUser.</param>
        /// 
        /// <returns>Returns a  AdminDisableUserResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminDisableUser">REST API Reference for AdminDisableUser Operation</seealso>
        AdminDisableUserResponse EndAdminDisableUser(IAsyncResult asyncResult);

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
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminEnableUser">REST API Reference for AdminEnableUser Operation</seealso>
        AdminEnableUserResponse AdminEnableUser(AdminEnableUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AdminEnableUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminEnableUser operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAdminEnableUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminEnableUser">REST API Reference for AdminEnableUser Operation</seealso>
        IAsyncResult BeginAdminEnableUser(AdminEnableUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AdminEnableUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAdminEnableUser.</param>
        /// 
        /// <returns>Returns a  AdminEnableUserResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminEnableUser">REST API Reference for AdminEnableUser Operation</seealso>
        AdminEnableUserResponse EndAdminEnableUser(IAsyncResult asyncResult);

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
        /// This exception is thrown when the user pool configuration is invalid.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminForgetDevice">REST API Reference for AdminForgetDevice Operation</seealso>
        AdminForgetDeviceResponse AdminForgetDevice(AdminForgetDeviceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AdminForgetDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminForgetDevice operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAdminForgetDevice
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminForgetDevice">REST API Reference for AdminForgetDevice Operation</seealso>
        IAsyncResult BeginAdminForgetDevice(AdminForgetDeviceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AdminForgetDevice operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAdminForgetDevice.</param>
        /// 
        /// <returns>Returns a  AdminForgetDeviceResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminForgetDevice">REST API Reference for AdminForgetDevice Operation</seealso>
        AdminForgetDeviceResponse EndAdminForgetDevice(IAsyncResult asyncResult);

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
        /// This exception is thrown when the user pool configuration is invalid.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminGetDevice">REST API Reference for AdminGetDevice Operation</seealso>
        AdminGetDeviceResponse AdminGetDevice(AdminGetDeviceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AdminGetDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminGetDevice operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAdminGetDevice
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminGetDevice">REST API Reference for AdminGetDevice Operation</seealso>
        IAsyncResult BeginAdminGetDevice(AdminGetDeviceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AdminGetDevice operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAdminGetDevice.</param>
        /// 
        /// <returns>Returns a  AdminGetDeviceResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminGetDevice">REST API Reference for AdminGetDevice Operation</seealso>
        AdminGetDeviceResponse EndAdminGetDevice(IAsyncResult asyncResult);

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
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminGetUser">REST API Reference for AdminGetUser Operation</seealso>
        AdminGetUserResponse AdminGetUser(AdminGetUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AdminGetUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminGetUser operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAdminGetUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminGetUser">REST API Reference for AdminGetUser Operation</seealso>
        IAsyncResult BeginAdminGetUser(AdminGetUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AdminGetUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAdminGetUser.</param>
        /// 
        /// <returns>Returns a  AdminGetUserResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminGetUser">REST API Reference for AdminGetUser Operation</seealso>
        AdminGetUserResponse EndAdminGetUser(IAsyncResult asyncResult);

        #endregion
        
        #region  AdminInitiateAuth


        /// <summary>
        /// Initiates the authentication flow, as an administrator.
        /// 
        ///  
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
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordResetRequiredException">
        /// This exception is thrown when a password reset is required.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UnexpectedLambdaException">
        /// This exception is thrown when the Amazon Cognito service encounters an unexpected
        /// exception with the AWS Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserLambdaValidationException">
        /// This exception is thrown when the Amazon Cognito service encounters a user validation
        /// exception with the AWS Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user is not confirmed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminInitiateAuth">REST API Reference for AdminInitiateAuth Operation</seealso>
        AdminInitiateAuthResponse AdminInitiateAuth(AdminInitiateAuthRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AdminInitiateAuth operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminInitiateAuth operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAdminInitiateAuth
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminInitiateAuth">REST API Reference for AdminInitiateAuth Operation</seealso>
        IAsyncResult BeginAdminInitiateAuth(AdminInitiateAuthRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AdminInitiateAuth operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAdminInitiateAuth.</param>
        /// 
        /// <returns>Returns a  AdminInitiateAuthResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminInitiateAuth">REST API Reference for AdminInitiateAuth Operation</seealso>
        AdminInitiateAuthResponse EndAdminInitiateAuth(IAsyncResult asyncResult);

        #endregion
        
        #region  AdminLinkProviderForUser


        /// <summary>
        /// Links an existing user account in a user pool (<code>DestinationUser</code>) to an
        /// identity from an external identity provider (<code>SourceUser</code>) based on a specified
        /// attribute name and value from the external identity provider. This allows you to create
        /// a link from the existing user account to an external federated user identity that
        /// has not yet been used to sign in, so that the federated user identity can be used
        /// to sign in as the existing user account. 
        /// 
        ///  
        /// <para>
        ///  For example, if there is an existing user with a username and password, this API
        /// links that user to a federated user identity, so that when the federated user identity
        /// is used, the user signs in as the existing user account. 
        /// </para>
        ///  <note> 
        /// <para>
        /// The maximum number of federated identities linked to a user is 5.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// Because this API allows a user with an external federated identity to sign in as an
        /// existing user in the user pool, it is critical that it only be used with external
        /// identity providers and provider attributes that have been trusted by the application
        /// owner.
        /// </para>
        ///  </important> 
        /// <para>
        /// This action is enabled only for admin access and requires developer credentials.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AdminLinkProviderForUser service method.</param>
        /// 
        /// <returns>The response from the AdminLinkProviderForUser service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.AliasExistsException">
        /// This exception is thrown when a user tries to confirm the account with an email or
        /// phone number that has already been supplied as an alias from a different account.
        /// This exception tells user that an account with this email or phone already exists.
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
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminLinkProviderForUser">REST API Reference for AdminLinkProviderForUser Operation</seealso>
        AdminLinkProviderForUserResponse AdminLinkProviderForUser(AdminLinkProviderForUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AdminLinkProviderForUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminLinkProviderForUser operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAdminLinkProviderForUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminLinkProviderForUser">REST API Reference for AdminLinkProviderForUser Operation</seealso>
        IAsyncResult BeginAdminLinkProviderForUser(AdminLinkProviderForUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AdminLinkProviderForUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAdminLinkProviderForUser.</param>
        /// 
        /// <returns>Returns a  AdminLinkProviderForUserResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminLinkProviderForUser">REST API Reference for AdminLinkProviderForUser Operation</seealso>
        AdminLinkProviderForUserResponse EndAdminLinkProviderForUser(IAsyncResult asyncResult);

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
        /// This exception is thrown when the user pool configuration is invalid.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminListDevices">REST API Reference for AdminListDevices Operation</seealso>
        AdminListDevicesResponse AdminListDevices(AdminListDevicesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AdminListDevices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminListDevices operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAdminListDevices
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminListDevices">REST API Reference for AdminListDevices Operation</seealso>
        IAsyncResult BeginAdminListDevices(AdminListDevicesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AdminListDevices operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAdminListDevices.</param>
        /// 
        /// <returns>Returns a  AdminListDevicesResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminListDevices">REST API Reference for AdminListDevices Operation</seealso>
        AdminListDevicesResponse EndAdminListDevices(IAsyncResult asyncResult);

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
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminListGroupsForUser">REST API Reference for AdminListGroupsForUser Operation</seealso>
        AdminListGroupsForUserResponse AdminListGroupsForUser(AdminListGroupsForUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AdminListGroupsForUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminListGroupsForUser operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAdminListGroupsForUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminListGroupsForUser">REST API Reference for AdminListGroupsForUser Operation</seealso>
        IAsyncResult BeginAdminListGroupsForUser(AdminListGroupsForUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AdminListGroupsForUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAdminListGroupsForUser.</param>
        /// 
        /// <returns>Returns a  AdminListGroupsForUserResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminListGroupsForUser">REST API Reference for AdminListGroupsForUser Operation</seealso>
        AdminListGroupsForUserResponse EndAdminListGroupsForUser(IAsyncResult asyncResult);

        #endregion
        
        #region  AdminListUserAuthEvents


        /// <summary>
        /// Lists a history of user activity and any risks detected as part of Amazon Cognito
        /// advanced security.
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
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user is not found.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserPoolAddOnNotEnabledException">
        /// This exception is thrown when user pool add-ons are not enabled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminListUserAuthEvents">REST API Reference for AdminListUserAuthEvents Operation</seealso>
        AdminListUserAuthEventsResponse AdminListUserAuthEvents(AdminListUserAuthEventsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AdminListUserAuthEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminListUserAuthEvents operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAdminListUserAuthEvents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminListUserAuthEvents">REST API Reference for AdminListUserAuthEvents Operation</seealso>
        IAsyncResult BeginAdminListUserAuthEvents(AdminListUserAuthEventsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AdminListUserAuthEvents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAdminListUserAuthEvents.</param>
        /// 
        /// <returns>Returns a  AdminListUserAuthEventsResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminListUserAuthEvents">REST API Reference for AdminListUserAuthEvents Operation</seealso>
        AdminListUserAuthEventsResponse EndAdminListUserAuthEvents(IAsyncResult asyncResult);

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
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminRemoveUserFromGroup">REST API Reference for AdminRemoveUserFromGroup Operation</seealso>
        AdminRemoveUserFromGroupResponse AdminRemoveUserFromGroup(AdminRemoveUserFromGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AdminRemoveUserFromGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminRemoveUserFromGroup operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAdminRemoveUserFromGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminRemoveUserFromGroup">REST API Reference for AdminRemoveUserFromGroup Operation</seealso>
        IAsyncResult BeginAdminRemoveUserFromGroup(AdminRemoveUserFromGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AdminRemoveUserFromGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAdminRemoveUserFromGroup.</param>
        /// 
        /// <returns>Returns a  AdminRemoveUserFromGroupResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminRemoveUserFromGroup">REST API Reference for AdminRemoveUserFromGroup Operation</seealso>
        AdminRemoveUserFromGroupResponse EndAdminRemoveUserFromGroup(IAsyncResult asyncResult);

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
        ///  
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
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UnexpectedLambdaException">
        /// This exception is thrown when the Amazon Cognito service encounters an unexpected
        /// exception with the AWS Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserLambdaValidationException">
        /// This exception is thrown when the Amazon Cognito service encounters a user validation
        /// exception with the AWS Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminResetUserPassword">REST API Reference for AdminResetUserPassword Operation</seealso>
        AdminResetUserPasswordResponse AdminResetUserPassword(AdminResetUserPasswordRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AdminResetUserPassword operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminResetUserPassword operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAdminResetUserPassword
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminResetUserPassword">REST API Reference for AdminResetUserPassword Operation</seealso>
        IAsyncResult BeginAdminResetUserPassword(AdminResetUserPasswordRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AdminResetUserPassword operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAdminResetUserPassword.</param>
        /// 
        /// <returns>Returns a  AdminResetUserPasswordResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminResetUserPassword">REST API Reference for AdminResetUserPassword Operation</seealso>
        AdminResetUserPasswordResponse EndAdminResetUserPassword(IAsyncResult asyncResult);

        #endregion
        
        #region  AdminRespondToAuthChallenge


        /// <summary>
        /// Responds to an authentication challenge, as an administrator.
        /// 
        ///  
        /// <para>
        /// Calling this action requires developer credentials.
        /// </para>
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
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidUserPoolConfigurationException">
        /// This exception is thrown when the user pool configuration is invalid.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.MFAMethodNotFoundException">
        /// This exception is thrown when Amazon Cognito cannot find a multi-factor authentication
        /// (MFA) method.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordResetRequiredException">
        /// This exception is thrown when a password reset is required.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.SoftwareTokenMFANotFoundException">
        /// This exception is thrown when the software token TOTP multi-factor authentication
        /// (MFA) is not enabled for the user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UnexpectedLambdaException">
        /// This exception is thrown when the Amazon Cognito service encounters an unexpected
        /// exception with the AWS Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserLambdaValidationException">
        /// This exception is thrown when the Amazon Cognito service encounters a user validation
        /// exception with the AWS Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user is not confirmed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminRespondToAuthChallenge">REST API Reference for AdminRespondToAuthChallenge Operation</seealso>
        AdminRespondToAuthChallengeResponse AdminRespondToAuthChallenge(AdminRespondToAuthChallengeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AdminRespondToAuthChallenge operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminRespondToAuthChallenge operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAdminRespondToAuthChallenge
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminRespondToAuthChallenge">REST API Reference for AdminRespondToAuthChallenge Operation</seealso>
        IAsyncResult BeginAdminRespondToAuthChallenge(AdminRespondToAuthChallengeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AdminRespondToAuthChallenge operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAdminRespondToAuthChallenge.</param>
        /// 
        /// <returns>Returns a  AdminRespondToAuthChallengeResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminRespondToAuthChallenge">REST API Reference for AdminRespondToAuthChallenge Operation</seealso>
        AdminRespondToAuthChallengeResponse EndAdminRespondToAuthChallenge(IAsyncResult asyncResult);

        #endregion
        
        #region  AdminSetUserMFAPreference


        /// <summary>
        /// Sets the user's multi-factor authentication (MFA) preference, including which MFA
        /// options are enabled and if any are preferred. Only one factor can be set as preferred.
        /// The preferred MFA factor will be used to authenticate a user if multiple factors are
        /// enabled. If multiple options are enabled and no preference is set, a challenge to
        /// choose an MFA option will be returned during sign in.
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
        /// This exception is thrown when a user is not authorized.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminSetUserMFAPreference">REST API Reference for AdminSetUserMFAPreference Operation</seealso>
        AdminSetUserMFAPreferenceResponse AdminSetUserMFAPreference(AdminSetUserMFAPreferenceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AdminSetUserMFAPreference operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminSetUserMFAPreference operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAdminSetUserMFAPreference
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminSetUserMFAPreference">REST API Reference for AdminSetUserMFAPreference Operation</seealso>
        IAsyncResult BeginAdminSetUserMFAPreference(AdminSetUserMFAPreferenceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AdminSetUserMFAPreference operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAdminSetUserMFAPreference.</param>
        /// 
        /// <returns>Returns a  AdminSetUserMFAPreferenceResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminSetUserMFAPreference">REST API Reference for AdminSetUserMFAPreference Operation</seealso>
        AdminSetUserMFAPreferenceResponse EndAdminSetUserMFAPreference(IAsyncResult asyncResult);

        #endregion
        
        #region  AdminSetUserPassword


        /// <summary>
        /// Sets the specified user's password in a user pool as an administrator. Works on any
        /// user. 
        /// 
        ///  
        /// <para>
        /// The password can be temporary or permanent. If it is temporary, the user status will
        /// be placed into the <code>FORCE_CHANGE_PASSWORD</code> state. When the user next tries
        /// to sign in, the InitiateAuth/AdminInitiateAuth response will contain the <code>NEW_PASSWORD_REQUIRED</code>
        /// challenge. If the user does not sign in before it expires, the user will not be able
        /// to sign in and their password will need to be reset by an administrator. 
        /// </para>
        ///  
        /// <para>
        /// Once the user has set a new password, or the password is permanent, the user status
        /// will be set to <code>Confirmed</code>.
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
        /// This exception is thrown when the Amazon Cognito service encounters an invalid password.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminSetUserPassword">REST API Reference for AdminSetUserPassword Operation</seealso>
        AdminSetUserPasswordResponse AdminSetUserPassword(AdminSetUserPasswordRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AdminSetUserPassword operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminSetUserPassword operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAdminSetUserPassword
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminSetUserPassword">REST API Reference for AdminSetUserPassword Operation</seealso>
        IAsyncResult BeginAdminSetUserPassword(AdminSetUserPasswordRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AdminSetUserPassword operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAdminSetUserPassword.</param>
        /// 
        /// <returns>Returns a  AdminSetUserPasswordResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminSetUserPassword">REST API Reference for AdminSetUserPassword Operation</seealso>
        AdminSetUserPasswordResponse EndAdminSetUserPassword(IAsyncResult asyncResult);

        #endregion
        
        #region  AdminSetUserSettings


        /// <summary>
        /// <i>This action is no longer supported.</i> You can use it to configure only SMS MFA.
        /// You can't use it to configure TOTP software token MFA. To configure either type of
        /// MFA, use <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_AdminSetUserMFAPreference.html">AdminSetUserMFAPreference</a>
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
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminSetUserSettings">REST API Reference for AdminSetUserSettings Operation</seealso>
        AdminSetUserSettingsResponse AdminSetUserSettings(AdminSetUserSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AdminSetUserSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminSetUserSettings operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAdminSetUserSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminSetUserSettings">REST API Reference for AdminSetUserSettings Operation</seealso>
        IAsyncResult BeginAdminSetUserSettings(AdminSetUserSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AdminSetUserSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAdminSetUserSettings.</param>
        /// 
        /// <returns>Returns a  AdminSetUserSettingsResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminSetUserSettings">REST API Reference for AdminSetUserSettings Operation</seealso>
        AdminSetUserSettingsResponse EndAdminSetUserSettings(IAsyncResult asyncResult);

        #endregion
        
        #region  AdminUpdateAuthEventFeedback


        /// <summary>
        /// Provides feedback for an authentication event as to whether it was from a valid user.
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
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user is not found.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserPoolAddOnNotEnabledException">
        /// This exception is thrown when user pool add-ons are not enabled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminUpdateAuthEventFeedback">REST API Reference for AdminUpdateAuthEventFeedback Operation</seealso>
        AdminUpdateAuthEventFeedbackResponse AdminUpdateAuthEventFeedback(AdminUpdateAuthEventFeedbackRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AdminUpdateAuthEventFeedback operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminUpdateAuthEventFeedback operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAdminUpdateAuthEventFeedback
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminUpdateAuthEventFeedback">REST API Reference for AdminUpdateAuthEventFeedback Operation</seealso>
        IAsyncResult BeginAdminUpdateAuthEventFeedback(AdminUpdateAuthEventFeedbackRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AdminUpdateAuthEventFeedback operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAdminUpdateAuthEventFeedback.</param>
        /// 
        /// <returns>Returns a  AdminUpdateAuthEventFeedbackResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminUpdateAuthEventFeedback">REST API Reference for AdminUpdateAuthEventFeedback Operation</seealso>
        AdminUpdateAuthEventFeedbackResponse EndAdminUpdateAuthEventFeedback(IAsyncResult asyncResult);

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
        /// This exception is thrown when the user pool configuration is invalid.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminUpdateDeviceStatus">REST API Reference for AdminUpdateDeviceStatus Operation</seealso>
        AdminUpdateDeviceStatusResponse AdminUpdateDeviceStatus(AdminUpdateDeviceStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AdminUpdateDeviceStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminUpdateDeviceStatus operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAdminUpdateDeviceStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminUpdateDeviceStatus">REST API Reference for AdminUpdateDeviceStatus Operation</seealso>
        IAsyncResult BeginAdminUpdateDeviceStatus(AdminUpdateDeviceStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AdminUpdateDeviceStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAdminUpdateDeviceStatus.</param>
        /// 
        /// <returns>Returns a  AdminUpdateDeviceStatusResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminUpdateDeviceStatus">REST API Reference for AdminUpdateDeviceStatus Operation</seealso>
        AdminUpdateDeviceStatusResponse EndAdminUpdateDeviceStatus(IAsyncResult asyncResult);

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
        ///  
        /// <para>
        /// Calling this action requires developer credentials.
        /// </para>
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
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UnexpectedLambdaException">
        /// This exception is thrown when the Amazon Cognito service encounters an unexpected
        /// exception with the AWS Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserLambdaValidationException">
        /// This exception is thrown when the Amazon Cognito service encounters a user validation
        /// exception with the AWS Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminUpdateUserAttributes">REST API Reference for AdminUpdateUserAttributes Operation</seealso>
        AdminUpdateUserAttributesResponse AdminUpdateUserAttributes(AdminUpdateUserAttributesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AdminUpdateUserAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminUpdateUserAttributes operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAdminUpdateUserAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminUpdateUserAttributes">REST API Reference for AdminUpdateUserAttributes Operation</seealso>
        IAsyncResult BeginAdminUpdateUserAttributes(AdminUpdateUserAttributesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AdminUpdateUserAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAdminUpdateUserAttributes.</param>
        /// 
        /// <returns>Returns a  AdminUpdateUserAttributesResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminUpdateUserAttributes">REST API Reference for AdminUpdateUserAttributes Operation</seealso>
        AdminUpdateUserAttributesResponse EndAdminUpdateUserAttributes(IAsyncResult asyncResult);

        #endregion
        
        #region  AdminUserGlobalSignOut


        /// <summary>
        /// Signs out users from all devices, as an administrator. It also invalidates all refresh
        /// tokens issued to a user. The user's current access and Id tokens remain valid until
        /// their expiry. Access and Id tokens expire one hour after they are issued.
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
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminUserGlobalSignOut">REST API Reference for AdminUserGlobalSignOut Operation</seealso>
        AdminUserGlobalSignOutResponse AdminUserGlobalSignOut(AdminUserGlobalSignOutRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AdminUserGlobalSignOut operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminUserGlobalSignOut operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAdminUserGlobalSignOut
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminUserGlobalSignOut">REST API Reference for AdminUserGlobalSignOut Operation</seealso>
        IAsyncResult BeginAdminUserGlobalSignOut(AdminUserGlobalSignOutRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AdminUserGlobalSignOut operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAdminUserGlobalSignOut.</param>
        /// 
        /// <returns>Returns a  AdminUserGlobalSignOutResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminUserGlobalSignOut">REST API Reference for AdminUserGlobalSignOut Operation</seealso>
        AdminUserGlobalSignOutResponse EndAdminUserGlobalSignOut(IAsyncResult asyncResult);

        #endregion
        
        #region  AssociateSoftwareToken


        /// <summary>
        /// Returns a unique generated shared secret key code for the user account. The request
        /// takes an access token or a session string, but not both.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateSoftwareToken service method.</param>
        /// 
        /// <returns>The response from the AssociateSoftwareToken service method, as returned by CognitoIdentityProvider.</returns>
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
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.SoftwareTokenMFANotFoundException">
        /// This exception is thrown when the software token TOTP multi-factor authentication
        /// (MFA) is not enabled for the user pool.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AssociateSoftwareToken">REST API Reference for AssociateSoftwareToken Operation</seealso>
        AssociateSoftwareTokenResponse AssociateSoftwareToken(AssociateSoftwareTokenRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateSoftwareToken operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateSoftwareToken operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateSoftwareToken
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AssociateSoftwareToken">REST API Reference for AssociateSoftwareToken Operation</seealso>
        IAsyncResult BeginAssociateSoftwareToken(AssociateSoftwareTokenRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateSoftwareToken operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateSoftwareToken.</param>
        /// 
        /// <returns>Returns a  AssociateSoftwareTokenResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AssociateSoftwareToken">REST API Reference for AssociateSoftwareToken Operation</seealso>
        AssociateSoftwareTokenResponse EndAssociateSoftwareToken(IAsyncResult asyncResult);

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
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordResetRequiredException">
        /// This exception is thrown when a password reset is required.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user is not confirmed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ChangePassword">REST API Reference for ChangePassword Operation</seealso>
        ChangePasswordResponse ChangePassword(ChangePasswordRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ChangePassword operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ChangePassword operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndChangePassword
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ChangePassword">REST API Reference for ChangePassword Operation</seealso>
        IAsyncResult BeginChangePassword(ChangePasswordRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ChangePassword operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginChangePassword.</param>
        /// 
        /// <returns>Returns a  ChangePasswordResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ChangePassword">REST API Reference for ChangePassword Operation</seealso>
        ChangePasswordResponse EndChangePassword(IAsyncResult asyncResult);

        #endregion
        
        #region  ConfirmDevice


        /// <summary>
        /// Confirms tracking of the device. This API call is the call that begins device tracking.
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
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordResetRequiredException">
        /// This exception is thrown when a password reset is required.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
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
        /// This exception is thrown when a user is not confirmed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ConfirmDevice">REST API Reference for ConfirmDevice Operation</seealso>
        ConfirmDeviceResponse ConfirmDevice(ConfirmDeviceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ConfirmDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConfirmDevice operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndConfirmDevice
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ConfirmDevice">REST API Reference for ConfirmDevice Operation</seealso>
        IAsyncResult BeginConfirmDevice(ConfirmDeviceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ConfirmDevice operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginConfirmDevice.</param>
        /// 
        /// <returns>Returns a  ConfirmDeviceResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ConfirmDevice">REST API Reference for ConfirmDevice Operation</seealso>
        ConfirmDeviceResponse EndConfirmDevice(IAsyncResult asyncResult);

        #endregion
        
        #region  ConfirmForgotPassword


        /// <summary>
        /// Allows a user to enter a confirmation code to reset a forgotten password.
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
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyFailedAttemptsException">
        /// This exception is thrown when the user has made too many failed attempts for a given
        /// action (e.g., sign in).
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UnexpectedLambdaException">
        /// This exception is thrown when the Amazon Cognito service encounters an unexpected
        /// exception with the AWS Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserLambdaValidationException">
        /// This exception is thrown when the Amazon Cognito service encounters a user validation
        /// exception with the AWS Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user is not confirmed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ConfirmForgotPassword">REST API Reference for ConfirmForgotPassword Operation</seealso>
        ConfirmForgotPasswordResponse ConfirmForgotPassword(ConfirmForgotPasswordRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ConfirmForgotPassword operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConfirmForgotPassword operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndConfirmForgotPassword
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ConfirmForgotPassword">REST API Reference for ConfirmForgotPassword Operation</seealso>
        IAsyncResult BeginConfirmForgotPassword(ConfirmForgotPasswordRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ConfirmForgotPassword operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginConfirmForgotPassword.</param>
        /// 
        /// <returns>Returns a  ConfirmForgotPasswordResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ConfirmForgotPassword">REST API Reference for ConfirmForgotPassword Operation</seealso>
        ConfirmForgotPasswordResponse EndConfirmForgotPassword(IAsyncResult asyncResult);

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
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyFailedAttemptsException">
        /// This exception is thrown when the user has made too many failed attempts for a given
        /// action (e.g., sign in).
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UnexpectedLambdaException">
        /// This exception is thrown when the Amazon Cognito service encounters an unexpected
        /// exception with the AWS Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserLambdaValidationException">
        /// This exception is thrown when the Amazon Cognito service encounters a user validation
        /// exception with the AWS Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ConfirmSignUp">REST API Reference for ConfirmSignUp Operation</seealso>
        ConfirmSignUpResponse ConfirmSignUp(ConfirmSignUpRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ConfirmSignUp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConfirmSignUp operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndConfirmSignUp
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ConfirmSignUp">REST API Reference for ConfirmSignUp Operation</seealso>
        IAsyncResult BeginConfirmSignUp(ConfirmSignUpRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ConfirmSignUp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginConfirmSignUp.</param>
        /// 
        /// <returns>Returns a  ConfirmSignUpResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ConfirmSignUp">REST API Reference for ConfirmSignUp Operation</seealso>
        ConfirmSignUpResponse EndConfirmSignUp(IAsyncResult asyncResult);

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
        /// This exception is thrown when a user exceeds the limit for a requested AWS resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        CreateGroupResponse CreateGroup(CreateGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGroup operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        IAsyncResult BeginCreateGroup(CreateGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateGroup.</param>
        /// 
        /// <returns>Returns a  CreateGroupResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        CreateGroupResponse EndCreateGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateIdentityProvider


        /// <summary>
        /// Creates an identity provider for a user pool.
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
        /// This exception is thrown when a user exceeds the limit for a requested AWS resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CreateIdentityProvider">REST API Reference for CreateIdentityProvider Operation</seealso>
        CreateIdentityProviderResponse CreateIdentityProvider(CreateIdentityProviderRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateIdentityProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateIdentityProvider operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateIdentityProvider
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CreateIdentityProvider">REST API Reference for CreateIdentityProvider Operation</seealso>
        IAsyncResult BeginCreateIdentityProvider(CreateIdentityProviderRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateIdentityProvider operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateIdentityProvider.</param>
        /// 
        /// <returns>Returns a  CreateIdentityProviderResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CreateIdentityProvider">REST API Reference for CreateIdentityProvider Operation</seealso>
        CreateIdentityProviderResponse EndCreateIdentityProvider(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateResourceServer


        /// <summary>
        /// Creates a new OAuth2.0 resource server and defines custom scopes in it.
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
        /// This exception is thrown when a user exceeds the limit for a requested AWS resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CreateResourceServer">REST API Reference for CreateResourceServer Operation</seealso>
        CreateResourceServerResponse CreateResourceServer(CreateResourceServerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateResourceServer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateResourceServer operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateResourceServer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CreateResourceServer">REST API Reference for CreateResourceServer Operation</seealso>
        IAsyncResult BeginCreateResourceServer(CreateResourceServerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateResourceServer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateResourceServer.</param>
        /// 
        /// <returns>Returns a  CreateResourceServerResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CreateResourceServer">REST API Reference for CreateResourceServer Operation</seealso>
        CreateResourceServerResponse EndCreateResourceServer(IAsyncResult asyncResult);

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
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PreconditionNotMetException">
        /// This exception is thrown when a precondition is not met.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CreateUserImportJob">REST API Reference for CreateUserImportJob Operation</seealso>
        CreateUserImportJobResponse CreateUserImportJob(CreateUserImportJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateUserImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUserImportJob operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateUserImportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CreateUserImportJob">REST API Reference for CreateUserImportJob Operation</seealso>
        IAsyncResult BeginCreateUserImportJob(CreateUserImportJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateUserImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateUserImportJob.</param>
        /// 
        /// <returns>Returns a  CreateUserImportJobResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CreateUserImportJob">REST API Reference for CreateUserImportJob Operation</seealso>
        CreateUserImportJobResponse EndCreateUserImportJob(IAsyncResult asyncResult);

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
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserPoolTaggingException">
        /// This exception is thrown when a user pool tag cannot be set or updated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CreateUserPool">REST API Reference for CreateUserPool Operation</seealso>
        CreateUserPoolResponse CreateUserPool(CreateUserPoolRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateUserPool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUserPool operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateUserPool
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CreateUserPool">REST API Reference for CreateUserPool Operation</seealso>
        IAsyncResult BeginCreateUserPool(CreateUserPoolRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateUserPool operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateUserPool.</param>
        /// 
        /// <returns>Returns a  CreateUserPoolResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CreateUserPool">REST API Reference for CreateUserPool Operation</seealso>
        CreateUserPoolResponse EndCreateUserPool(IAsyncResult asyncResult);

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
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidOAuthFlowException">
        /// This exception is thrown when the specified OAuth flow is invalid.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.LimitExceededException">
        /// This exception is thrown when a user exceeds the limit for a requested AWS resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ScopeDoesNotExistException">
        /// This exception is thrown when the specified scope does not exist.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CreateUserPoolClient">REST API Reference for CreateUserPoolClient Operation</seealso>
        CreateUserPoolClientResponse CreateUserPoolClient(CreateUserPoolClientRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateUserPoolClient operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUserPoolClient operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateUserPoolClient
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CreateUserPoolClient">REST API Reference for CreateUserPoolClient Operation</seealso>
        IAsyncResult BeginCreateUserPoolClient(CreateUserPoolClientRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateUserPoolClient operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateUserPoolClient.</param>
        /// 
        /// <returns>Returns a  CreateUserPoolClientResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CreateUserPoolClient">REST API Reference for CreateUserPoolClient Operation</seealso>
        CreateUserPoolClientResponse EndCreateUserPoolClient(IAsyncResult asyncResult);

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
        /// This exception is thrown when a user exceeds the limit for a requested AWS resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CreateUserPoolDomain">REST API Reference for CreateUserPoolDomain Operation</seealso>
        CreateUserPoolDomainResponse CreateUserPoolDomain(CreateUserPoolDomainRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateUserPoolDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUserPoolDomain operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateUserPoolDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CreateUserPoolDomain">REST API Reference for CreateUserPoolDomain Operation</seealso>
        IAsyncResult BeginCreateUserPoolDomain(CreateUserPoolDomainRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateUserPoolDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateUserPoolDomain.</param>
        /// 
        /// <returns>Returns a  CreateUserPoolDomainResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CreateUserPoolDomain">REST API Reference for CreateUserPoolDomain Operation</seealso>
        CreateUserPoolDomainResponse EndCreateUserPoolDomain(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteGroup


        /// <summary>
        /// Deletes a group. Currently only groups with no members can be deleted.
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
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        DeleteGroupResponse DeleteGroup(DeleteGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        IAsyncResult BeginDeleteGroup(DeleteGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteGroup.</param>
        /// 
        /// <returns>Returns a  DeleteGroupResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        DeleteGroupResponse EndDeleteGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteIdentityProvider


        /// <summary>
        /// Deletes an identity provider for a user pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIdentityProvider service method.</param>
        /// 
        /// <returns>The response from the DeleteIdentityProvider service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UnsupportedIdentityProviderException">
        /// This exception is thrown when the specified identifier is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteIdentityProvider">REST API Reference for DeleteIdentityProvider Operation</seealso>
        DeleteIdentityProviderResponse DeleteIdentityProvider(DeleteIdentityProviderRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIdentityProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIdentityProvider operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteIdentityProvider
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteIdentityProvider">REST API Reference for DeleteIdentityProvider Operation</seealso>
        IAsyncResult BeginDeleteIdentityProvider(DeleteIdentityProviderRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteIdentityProvider operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteIdentityProvider.</param>
        /// 
        /// <returns>Returns a  DeleteIdentityProviderResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteIdentityProvider">REST API Reference for DeleteIdentityProvider Operation</seealso>
        DeleteIdentityProviderResponse EndDeleteIdentityProvider(IAsyncResult asyncResult);

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
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteResourceServer">REST API Reference for DeleteResourceServer Operation</seealso>
        DeleteResourceServerResponse DeleteResourceServer(DeleteResourceServerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteResourceServer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourceServer operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteResourceServer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteResourceServer">REST API Reference for DeleteResourceServer Operation</seealso>
        IAsyncResult BeginDeleteResourceServer(DeleteResourceServerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteResourceServer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteResourceServer.</param>
        /// 
        /// <returns>Returns a  DeleteResourceServerResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteResourceServer">REST API Reference for DeleteResourceServer Operation</seealso>
        DeleteResourceServerResponse EndDeleteResourceServer(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteUser


        /// <summary>
        /// Allows a user to delete himself or herself.
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
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordResetRequiredException">
        /// This exception is thrown when a password reset is required.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user is not confirmed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        DeleteUserResponse DeleteUser(DeleteUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        IAsyncResult BeginDeleteUser(DeleteUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUser.</param>
        /// 
        /// <returns>Returns a  DeleteUserResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        DeleteUserResponse EndDeleteUser(IAsyncResult asyncResult);

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
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordResetRequiredException">
        /// This exception is thrown when a password reset is required.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user is not confirmed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteUserAttributes">REST API Reference for DeleteUserAttributes Operation</seealso>
        DeleteUserAttributesResponse DeleteUserAttributes(DeleteUserAttributesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUserAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserAttributes operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteUserAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteUserAttributes">REST API Reference for DeleteUserAttributes Operation</seealso>
        IAsyncResult BeginDeleteUserAttributes(DeleteUserAttributesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteUserAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUserAttributes.</param>
        /// 
        /// <returns>Returns a  DeleteUserAttributesResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteUserAttributes">REST API Reference for DeleteUserAttributes Operation</seealso>
        DeleteUserAttributesResponse EndDeleteUserAttributes(IAsyncResult asyncResult);

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
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserImportInProgressException">
        /// This exception is thrown when you are trying to modify a user pool while a user import
        /// job is in progress for that pool.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteUserPool">REST API Reference for DeleteUserPool Operation</seealso>
        DeleteUserPoolResponse DeleteUserPool(DeleteUserPoolRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUserPool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserPool operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteUserPool
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteUserPool">REST API Reference for DeleteUserPool Operation</seealso>
        IAsyncResult BeginDeleteUserPool(DeleteUserPoolRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteUserPool operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUserPool.</param>
        /// 
        /// <returns>Returns a  DeleteUserPoolResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteUserPool">REST API Reference for DeleteUserPool Operation</seealso>
        DeleteUserPoolResponse EndDeleteUserPool(IAsyncResult asyncResult);

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
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteUserPoolClient">REST API Reference for DeleteUserPoolClient Operation</seealso>
        DeleteUserPoolClientResponse DeleteUserPoolClient(DeleteUserPoolClientRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUserPoolClient operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserPoolClient operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteUserPoolClient
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteUserPoolClient">REST API Reference for DeleteUserPoolClient Operation</seealso>
        IAsyncResult BeginDeleteUserPoolClient(DeleteUserPoolClientRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteUserPoolClient operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUserPoolClient.</param>
        /// 
        /// <returns>Returns a  DeleteUserPoolClientResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteUserPoolClient">REST API Reference for DeleteUserPoolClient Operation</seealso>
        DeleteUserPoolClientResponse EndDeleteUserPoolClient(IAsyncResult asyncResult);

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
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteUserPoolDomain">REST API Reference for DeleteUserPoolDomain Operation</seealso>
        DeleteUserPoolDomainResponse DeleteUserPoolDomain(DeleteUserPoolDomainRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUserPoolDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserPoolDomain operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteUserPoolDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteUserPoolDomain">REST API Reference for DeleteUserPoolDomain Operation</seealso>
        IAsyncResult BeginDeleteUserPoolDomain(DeleteUserPoolDomainRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteUserPoolDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUserPoolDomain.</param>
        /// 
        /// <returns>Returns a  DeleteUserPoolDomainResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteUserPoolDomain">REST API Reference for DeleteUserPoolDomain Operation</seealso>
        DeleteUserPoolDomainResponse EndDeleteUserPoolDomain(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeIdentityProvider


        /// <summary>
        /// Gets information about a specific identity provider.
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
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeIdentityProvider">REST API Reference for DescribeIdentityProvider Operation</seealso>
        DescribeIdentityProviderResponse DescribeIdentityProvider(DescribeIdentityProviderRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeIdentityProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeIdentityProvider operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeIdentityProvider
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeIdentityProvider">REST API Reference for DescribeIdentityProvider Operation</seealso>
        IAsyncResult BeginDescribeIdentityProvider(DescribeIdentityProviderRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeIdentityProvider operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeIdentityProvider.</param>
        /// 
        /// <returns>Returns a  DescribeIdentityProviderResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeIdentityProvider">REST API Reference for DescribeIdentityProvider Operation</seealso>
        DescribeIdentityProviderResponse EndDescribeIdentityProvider(IAsyncResult asyncResult);

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
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeResourceServer">REST API Reference for DescribeResourceServer Operation</seealso>
        DescribeResourceServerResponse DescribeResourceServer(DescribeResourceServerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeResourceServer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeResourceServer operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeResourceServer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeResourceServer">REST API Reference for DescribeResourceServer Operation</seealso>
        IAsyncResult BeginDescribeResourceServer(DescribeResourceServerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeResourceServer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeResourceServer.</param>
        /// 
        /// <returns>Returns a  DescribeResourceServerResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeResourceServer">REST API Reference for DescribeResourceServer Operation</seealso>
        DescribeResourceServerResponse EndDescribeResourceServer(IAsyncResult asyncResult);

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
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserPoolAddOnNotEnabledException">
        /// This exception is thrown when user pool add-ons are not enabled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeRiskConfiguration">REST API Reference for DescribeRiskConfiguration Operation</seealso>
        DescribeRiskConfigurationResponse DescribeRiskConfiguration(DescribeRiskConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRiskConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRiskConfiguration operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeRiskConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeRiskConfiguration">REST API Reference for DescribeRiskConfiguration Operation</seealso>
        IAsyncResult BeginDescribeRiskConfiguration(DescribeRiskConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRiskConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRiskConfiguration.</param>
        /// 
        /// <returns>Returns a  DescribeRiskConfigurationResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeRiskConfiguration">REST API Reference for DescribeRiskConfiguration Operation</seealso>
        DescribeRiskConfigurationResponse EndDescribeRiskConfiguration(IAsyncResult asyncResult);

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
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeUserImportJob">REST API Reference for DescribeUserImportJob Operation</seealso>
        DescribeUserImportJobResponse DescribeUserImportJob(DescribeUserImportJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeUserImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeUserImportJob operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeUserImportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeUserImportJob">REST API Reference for DescribeUserImportJob Operation</seealso>
        IAsyncResult BeginDescribeUserImportJob(DescribeUserImportJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeUserImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeUserImportJob.</param>
        /// 
        /// <returns>Returns a  DescribeUserImportJobResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeUserImportJob">REST API Reference for DescribeUserImportJob Operation</seealso>
        DescribeUserImportJobResponse EndDescribeUserImportJob(IAsyncResult asyncResult);

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
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserPoolTaggingException">
        /// This exception is thrown when a user pool tag cannot be set or updated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeUserPool">REST API Reference for DescribeUserPool Operation</seealso>
        DescribeUserPoolResponse DescribeUserPool(DescribeUserPoolRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeUserPool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeUserPool operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeUserPool
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeUserPool">REST API Reference for DescribeUserPool Operation</seealso>
        IAsyncResult BeginDescribeUserPool(DescribeUserPoolRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeUserPool operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeUserPool.</param>
        /// 
        /// <returns>Returns a  DescribeUserPoolResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeUserPool">REST API Reference for DescribeUserPool Operation</seealso>
        DescribeUserPoolResponse EndDescribeUserPool(IAsyncResult asyncResult);

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
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeUserPoolClient">REST API Reference for DescribeUserPoolClient Operation</seealso>
        DescribeUserPoolClientResponse DescribeUserPoolClient(DescribeUserPoolClientRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeUserPoolClient operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeUserPoolClient operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeUserPoolClient
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeUserPoolClient">REST API Reference for DescribeUserPoolClient Operation</seealso>
        IAsyncResult BeginDescribeUserPoolClient(DescribeUserPoolClientRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeUserPoolClient operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeUserPoolClient.</param>
        /// 
        /// <returns>Returns a  DescribeUserPoolClientResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeUserPoolClient">REST API Reference for DescribeUserPoolClient Operation</seealso>
        DescribeUserPoolClientResponse EndDescribeUserPoolClient(IAsyncResult asyncResult);

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
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeUserPoolDomain">REST API Reference for DescribeUserPoolDomain Operation</seealso>
        DescribeUserPoolDomainResponse DescribeUserPoolDomain(DescribeUserPoolDomainRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeUserPoolDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeUserPoolDomain operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeUserPoolDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeUserPoolDomain">REST API Reference for DescribeUserPoolDomain Operation</seealso>
        IAsyncResult BeginDescribeUserPoolDomain(DescribeUserPoolDomainRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeUserPoolDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeUserPoolDomain.</param>
        /// 
        /// <returns>Returns a  DescribeUserPoolDomainResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeUserPoolDomain">REST API Reference for DescribeUserPoolDomain Operation</seealso>
        DescribeUserPoolDomainResponse EndDescribeUserPoolDomain(IAsyncResult asyncResult);

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
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordResetRequiredException">
        /// This exception is thrown when a password reset is required.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user is not confirmed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ForgetDevice">REST API Reference for ForgetDevice Operation</seealso>
        ForgetDeviceResponse ForgetDevice(ForgetDeviceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ForgetDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ForgetDevice operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndForgetDevice
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ForgetDevice">REST API Reference for ForgetDevice Operation</seealso>
        IAsyncResult BeginForgetDevice(ForgetDeviceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ForgetDevice operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginForgetDevice.</param>
        /// 
        /// <returns>Returns a  ForgetDeviceResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ForgetDevice">REST API Reference for ForgetDevice Operation</seealso>
        ForgetDeviceResponse EndForgetDevice(IAsyncResult asyncResult);

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
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UnexpectedLambdaException">
        /// This exception is thrown when the Amazon Cognito service encounters an unexpected
        /// exception with the AWS Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserLambdaValidationException">
        /// This exception is thrown when the Amazon Cognito service encounters a user validation
        /// exception with the AWS Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user is not confirmed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ForgotPassword">REST API Reference for ForgotPassword Operation</seealso>
        ForgotPasswordResponse ForgotPassword(ForgotPasswordRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ForgotPassword operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ForgotPassword operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndForgotPassword
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ForgotPassword">REST API Reference for ForgotPassword Operation</seealso>
        IAsyncResult BeginForgotPassword(ForgotPasswordRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ForgotPassword operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginForgotPassword.</param>
        /// 
        /// <returns>Returns a  ForgotPasswordResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ForgotPassword">REST API Reference for ForgotPassword Operation</seealso>
        ForgotPasswordResponse EndForgotPassword(IAsyncResult asyncResult);

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
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetCSVHeader">REST API Reference for GetCSVHeader Operation</seealso>
        GetCSVHeaderResponse GetCSVHeader(GetCSVHeaderRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetCSVHeader operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCSVHeader operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCSVHeader
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetCSVHeader">REST API Reference for GetCSVHeader Operation</seealso>
        IAsyncResult BeginGetCSVHeader(GetCSVHeaderRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCSVHeader operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCSVHeader.</param>
        /// 
        /// <returns>Returns a  GetCSVHeaderResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetCSVHeader">REST API Reference for GetCSVHeader Operation</seealso>
        GetCSVHeaderResponse EndGetCSVHeader(IAsyncResult asyncResult);

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
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordResetRequiredException">
        /// This exception is thrown when a password reset is required.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user is not confirmed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetDevice">REST API Reference for GetDevice Operation</seealso>
        GetDeviceResponse GetDevice(GetDeviceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDevice operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDevice
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetDevice">REST API Reference for GetDevice Operation</seealso>
        IAsyncResult BeginGetDevice(GetDeviceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDevice operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDevice.</param>
        /// 
        /// <returns>Returns a  GetDeviceResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetDevice">REST API Reference for GetDevice Operation</seealso>
        GetDeviceResponse EndGetDevice(IAsyncResult asyncResult);

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
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetGroup">REST API Reference for GetGroup Operation</seealso>
        GetGroupResponse GetGroup(GetGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGroup operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetGroup">REST API Reference for GetGroup Operation</seealso>
        IAsyncResult BeginGetGroup(GetGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGroup.</param>
        /// 
        /// <returns>Returns a  GetGroupResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetGroup">REST API Reference for GetGroup Operation</seealso>
        GetGroupResponse EndGetGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  GetIdentityProviderByIdentifier


        /// <summary>
        /// Gets the specified identity provider.
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
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetIdentityProviderByIdentifier">REST API Reference for GetIdentityProviderByIdentifier Operation</seealso>
        GetIdentityProviderByIdentifierResponse GetIdentityProviderByIdentifier(GetIdentityProviderByIdentifierRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetIdentityProviderByIdentifier operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIdentityProviderByIdentifier operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetIdentityProviderByIdentifier
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetIdentityProviderByIdentifier">REST API Reference for GetIdentityProviderByIdentifier Operation</seealso>
        IAsyncResult BeginGetIdentityProviderByIdentifier(GetIdentityProviderByIdentifierRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetIdentityProviderByIdentifier operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetIdentityProviderByIdentifier.</param>
        /// 
        /// <returns>Returns a  GetIdentityProviderByIdentifierResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetIdentityProviderByIdentifier">REST API Reference for GetIdentityProviderByIdentifier Operation</seealso>
        GetIdentityProviderByIdentifierResponse EndGetIdentityProviderByIdentifier(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSigningCertificate


        /// <summary>
        /// This method takes a user pool ID, and returns the signing certificate.
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
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetSigningCertificate">REST API Reference for GetSigningCertificate Operation</seealso>
        GetSigningCertificateResponse GetSigningCertificate(GetSigningCertificateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSigningCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSigningCertificate operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSigningCertificate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetSigningCertificate">REST API Reference for GetSigningCertificate Operation</seealso>
        IAsyncResult BeginGetSigningCertificate(GetSigningCertificateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSigningCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSigningCertificate.</param>
        /// 
        /// <returns>Returns a  GetSigningCertificateResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetSigningCertificate">REST API Reference for GetSigningCertificate Operation</seealso>
        GetSigningCertificateResponse EndGetSigningCertificate(IAsyncResult asyncResult);

        #endregion
        
        #region  GetUICustomization


        /// <summary>
        /// Gets the UI Customization information for a particular app client's app UI, if there
        /// is something set. If nothing is set for the particular client, but there is an existing
        /// pool level customization (app <code>clientId</code> will be <code>ALL</code>), then
        /// that is returned. If nothing is present, then an empty shape is returned.
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
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetUICustomization">REST API Reference for GetUICustomization Operation</seealso>
        GetUICustomizationResponse GetUICustomization(GetUICustomizationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetUICustomization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUICustomization operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetUICustomization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetUICustomization">REST API Reference for GetUICustomization Operation</seealso>
        IAsyncResult BeginGetUICustomization(GetUICustomizationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetUICustomization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUICustomization.</param>
        /// 
        /// <returns>Returns a  GetUICustomizationResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetUICustomization">REST API Reference for GetUICustomization Operation</seealso>
        GetUICustomizationResponse EndGetUICustomization(IAsyncResult asyncResult);

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
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordResetRequiredException">
        /// This exception is thrown when a password reset is required.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user is not confirmed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetUser">REST API Reference for GetUser Operation</seealso>
        GetUserResponse GetUser(GetUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUser operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetUser">REST API Reference for GetUser Operation</seealso>
        IAsyncResult BeginGetUser(GetUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUser.</param>
        /// 
        /// <returns>Returns a  GetUserResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetUser">REST API Reference for GetUser Operation</seealso>
        GetUserResponse EndGetUser(IAsyncResult asyncResult);

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
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordResetRequiredException">
        /// This exception is thrown when a password reset is required.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UnexpectedLambdaException">
        /// This exception is thrown when the Amazon Cognito service encounters an unexpected
        /// exception with the AWS Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserLambdaValidationException">
        /// This exception is thrown when the Amazon Cognito service encounters a user validation
        /// exception with the AWS Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user is not confirmed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetUserAttributeVerificationCode">REST API Reference for GetUserAttributeVerificationCode Operation</seealso>
        GetUserAttributeVerificationCodeResponse GetUserAttributeVerificationCode(GetUserAttributeVerificationCodeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetUserAttributeVerificationCode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUserAttributeVerificationCode operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetUserAttributeVerificationCode
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetUserAttributeVerificationCode">REST API Reference for GetUserAttributeVerificationCode Operation</seealso>
        IAsyncResult BeginGetUserAttributeVerificationCode(GetUserAttributeVerificationCodeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetUserAttributeVerificationCode operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUserAttributeVerificationCode.</param>
        /// 
        /// <returns>Returns a  GetUserAttributeVerificationCodeResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetUserAttributeVerificationCode">REST API Reference for GetUserAttributeVerificationCode Operation</seealso>
        GetUserAttributeVerificationCodeResponse EndGetUserAttributeVerificationCode(IAsyncResult asyncResult);

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
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetUserPoolMfaConfig">REST API Reference for GetUserPoolMfaConfig Operation</seealso>
        GetUserPoolMfaConfigResponse GetUserPoolMfaConfig(GetUserPoolMfaConfigRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetUserPoolMfaConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUserPoolMfaConfig operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetUserPoolMfaConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetUserPoolMfaConfig">REST API Reference for GetUserPoolMfaConfig Operation</seealso>
        IAsyncResult BeginGetUserPoolMfaConfig(GetUserPoolMfaConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetUserPoolMfaConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUserPoolMfaConfig.</param>
        /// 
        /// <returns>Returns a  GetUserPoolMfaConfigResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetUserPoolMfaConfig">REST API Reference for GetUserPoolMfaConfig Operation</seealso>
        GetUserPoolMfaConfigResponse EndGetUserPoolMfaConfig(IAsyncResult asyncResult);

        #endregion
        
        #region  GlobalSignOut


        /// <summary>
        /// Signs out users from all devices. It also invalidates all refresh tokens issued to
        /// a user. The user's current access and Id tokens remain valid until their expiry. Access
        /// and Id tokens expire one hour after they are issued.
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
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordResetRequiredException">
        /// This exception is thrown when a password reset is required.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user is not confirmed successfully.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GlobalSignOut">REST API Reference for GlobalSignOut Operation</seealso>
        GlobalSignOutResponse GlobalSignOut(GlobalSignOutRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GlobalSignOut operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GlobalSignOut operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGlobalSignOut
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GlobalSignOut">REST API Reference for GlobalSignOut Operation</seealso>
        IAsyncResult BeginGlobalSignOut(GlobalSignOutRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GlobalSignOut operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGlobalSignOut.</param>
        /// 
        /// <returns>Returns a  GlobalSignOutResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GlobalSignOut">REST API Reference for GlobalSignOut Operation</seealso>
        GlobalSignOutResponse EndGlobalSignOut(IAsyncResult asyncResult);

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
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordResetRequiredException">
        /// This exception is thrown when a password reset is required.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UnexpectedLambdaException">
        /// This exception is thrown when the Amazon Cognito service encounters an unexpected
        /// exception with the AWS Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserLambdaValidationException">
        /// This exception is thrown when the Amazon Cognito service encounters a user validation
        /// exception with the AWS Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user is not confirmed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/InitiateAuth">REST API Reference for InitiateAuth Operation</seealso>
        InitiateAuthResponse InitiateAuth(InitiateAuthRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the InitiateAuth operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InitiateAuth operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndInitiateAuth
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/InitiateAuth">REST API Reference for InitiateAuth Operation</seealso>
        IAsyncResult BeginInitiateAuth(InitiateAuthRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  InitiateAuth operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginInitiateAuth.</param>
        /// 
        /// <returns>Returns a  InitiateAuthResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/InitiateAuth">REST API Reference for InitiateAuth Operation</seealso>
        InitiateAuthResponse EndInitiateAuth(IAsyncResult asyncResult);

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
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordResetRequiredException">
        /// This exception is thrown when a password reset is required.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user is not confirmed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListDevices">REST API Reference for ListDevices Operation</seealso>
        ListDevicesResponse ListDevices(ListDevicesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDevices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDevices operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDevices
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListDevices">REST API Reference for ListDevices Operation</seealso>
        IAsyncResult BeginListDevices(ListDevicesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDevices operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDevices.</param>
        /// 
        /// <returns>Returns a  ListDevicesResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListDevices">REST API Reference for ListDevices Operation</seealso>
        ListDevicesResponse EndListDevices(IAsyncResult asyncResult);

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
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListGroups">REST API Reference for ListGroups Operation</seealso>
        ListGroupsResponse ListGroups(ListGroupsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGroups operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListGroups">REST API Reference for ListGroups Operation</seealso>
        IAsyncResult BeginListGroups(ListGroupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGroups.</param>
        /// 
        /// <returns>Returns a  ListGroupsResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListGroups">REST API Reference for ListGroups Operation</seealso>
        ListGroupsResponse EndListGroups(IAsyncResult asyncResult);

        #endregion
        
        #region  ListIdentityProviders


        /// <summary>
        /// Lists information about all identity providers for a user pool.
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
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListIdentityProviders">REST API Reference for ListIdentityProviders Operation</seealso>
        ListIdentityProvidersResponse ListIdentityProviders(ListIdentityProvidersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListIdentityProviders operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIdentityProviders operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListIdentityProviders
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListIdentityProviders">REST API Reference for ListIdentityProviders Operation</seealso>
        IAsyncResult BeginListIdentityProviders(ListIdentityProvidersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListIdentityProviders operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListIdentityProviders.</param>
        /// 
        /// <returns>Returns a  ListIdentityProvidersResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListIdentityProviders">REST API Reference for ListIdentityProviders Operation</seealso>
        ListIdentityProvidersResponse EndListIdentityProviders(IAsyncResult asyncResult);

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
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListResourceServers">REST API Reference for ListResourceServers Operation</seealso>
        ListResourceServersResponse ListResourceServers(ListResourceServersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListResourceServers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResourceServers operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListResourceServers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListResourceServers">REST API Reference for ListResourceServers Operation</seealso>
        IAsyncResult BeginListResourceServers(ListResourceServersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListResourceServers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListResourceServers.</param>
        /// 
        /// <returns>Returns a  ListResourceServersResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListResourceServers">REST API Reference for ListResourceServers Operation</seealso>
        ListResourceServersResponse EndListResourceServers(IAsyncResult asyncResult);

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
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

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
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListUserImportJobs">REST API Reference for ListUserImportJobs Operation</seealso>
        ListUserImportJobsResponse ListUserImportJobs(ListUserImportJobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListUserImportJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUserImportJobs operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListUserImportJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListUserImportJobs">REST API Reference for ListUserImportJobs Operation</seealso>
        IAsyncResult BeginListUserImportJobs(ListUserImportJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListUserImportJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListUserImportJobs.</param>
        /// 
        /// <returns>Returns a  ListUserImportJobsResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListUserImportJobs">REST API Reference for ListUserImportJobs Operation</seealso>
        ListUserImportJobsResponse EndListUserImportJobs(IAsyncResult asyncResult);

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
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListUserPoolClients">REST API Reference for ListUserPoolClients Operation</seealso>
        ListUserPoolClientsResponse ListUserPoolClients(ListUserPoolClientsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListUserPoolClients operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUserPoolClients operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListUserPoolClients
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListUserPoolClients">REST API Reference for ListUserPoolClients Operation</seealso>
        IAsyncResult BeginListUserPoolClients(ListUserPoolClientsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListUserPoolClients operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListUserPoolClients.</param>
        /// 
        /// <returns>Returns a  ListUserPoolClientsResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListUserPoolClients">REST API Reference for ListUserPoolClients Operation</seealso>
        ListUserPoolClientsResponse EndListUserPoolClients(IAsyncResult asyncResult);

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
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListUserPools">REST API Reference for ListUserPools Operation</seealso>
        ListUserPoolsResponse ListUserPools(ListUserPoolsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListUserPools operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUserPools operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListUserPools
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListUserPools">REST API Reference for ListUserPools Operation</seealso>
        IAsyncResult BeginListUserPools(ListUserPoolsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListUserPools operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListUserPools.</param>
        /// 
        /// <returns>Returns a  ListUserPoolsResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListUserPools">REST API Reference for ListUserPools Operation</seealso>
        ListUserPoolsResponse EndListUserPools(IAsyncResult asyncResult);

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
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListUsers">REST API Reference for ListUsers Operation</seealso>
        ListUsersResponse ListUsers(ListUsersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListUsers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUsers operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListUsers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListUsers">REST API Reference for ListUsers Operation</seealso>
        IAsyncResult BeginListUsers(ListUsersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListUsers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListUsers.</param>
        /// 
        /// <returns>Returns a  ListUsersResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListUsers">REST API Reference for ListUsers Operation</seealso>
        ListUsersResponse EndListUsers(IAsyncResult asyncResult);

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
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListUsersInGroup">REST API Reference for ListUsersInGroup Operation</seealso>
        ListUsersInGroupResponse ListUsersInGroup(ListUsersInGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListUsersInGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUsersInGroup operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListUsersInGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListUsersInGroup">REST API Reference for ListUsersInGroup Operation</seealso>
        IAsyncResult BeginListUsersInGroup(ListUsersInGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListUsersInGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListUsersInGroup.</param>
        /// 
        /// <returns>Returns a  ListUsersInGroupResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListUsersInGroup">REST API Reference for ListUsersInGroup Operation</seealso>
        ListUsersInGroupResponse EndListUsersInGroup(IAsyncResult asyncResult);

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
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UnexpectedLambdaException">
        /// This exception is thrown when the Amazon Cognito service encounters an unexpected
        /// exception with the AWS Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserLambdaValidationException">
        /// This exception is thrown when the Amazon Cognito service encounters a user validation
        /// exception with the AWS Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ResendConfirmationCode">REST API Reference for ResendConfirmationCode Operation</seealso>
        ResendConfirmationCodeResponse ResendConfirmationCode(ResendConfirmationCodeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ResendConfirmationCode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResendConfirmationCode operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResendConfirmationCode
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ResendConfirmationCode">REST API Reference for ResendConfirmationCode Operation</seealso>
        IAsyncResult BeginResendConfirmationCode(ResendConfirmationCodeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ResendConfirmationCode operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResendConfirmationCode.</param>
        /// 
        /// <returns>Returns a  ResendConfirmationCodeResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ResendConfirmationCode">REST API Reference for ResendConfirmationCode Operation</seealso>
        ResendConfirmationCodeResponse EndResendConfirmationCode(IAsyncResult asyncResult);

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
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidUserPoolConfigurationException">
        /// This exception is thrown when the user pool configuration is invalid.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.MFAMethodNotFoundException">
        /// This exception is thrown when Amazon Cognito cannot find a multi-factor authentication
        /// (MFA) method.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordResetRequiredException">
        /// This exception is thrown when a password reset is required.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.SoftwareTokenMFANotFoundException">
        /// This exception is thrown when the software token TOTP multi-factor authentication
        /// (MFA) is not enabled for the user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UnexpectedLambdaException">
        /// This exception is thrown when the Amazon Cognito service encounters an unexpected
        /// exception with the AWS Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserLambdaValidationException">
        /// This exception is thrown when the Amazon Cognito service encounters a user validation
        /// exception with the AWS Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user is not confirmed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/RespondToAuthChallenge">REST API Reference for RespondToAuthChallenge Operation</seealso>
        RespondToAuthChallengeResponse RespondToAuthChallenge(RespondToAuthChallengeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RespondToAuthChallenge operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RespondToAuthChallenge operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRespondToAuthChallenge
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/RespondToAuthChallenge">REST API Reference for RespondToAuthChallenge Operation</seealso>
        IAsyncResult BeginRespondToAuthChallenge(RespondToAuthChallengeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RespondToAuthChallenge operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRespondToAuthChallenge.</param>
        /// 
        /// <returns>Returns a  RespondToAuthChallengeResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/RespondToAuthChallenge">REST API Reference for RespondToAuthChallenge Operation</seealso>
        RespondToAuthChallengeResponse EndRespondToAuthChallenge(IAsyncResult asyncResult);

        #endregion
        
        #region  SetRiskConfiguration


        /// <summary>
        /// Configures actions on detected risks. To delete the risk configuration for <code>UserPoolId</code>
        /// or <code>ClientId</code>, pass null values for all four configuration types.
        /// 
        ///  
        /// <para>
        /// To enable Amazon Cognito advanced security features, update the user pool to include
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
        /// This exception is thrown when Amazon Cognito is not allowed to use your email identity.
        /// HTTP status code: 400.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserPoolAddOnNotEnabledException">
        /// This exception is thrown when user pool add-ons are not enabled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/SetRiskConfiguration">REST API Reference for SetRiskConfiguration Operation</seealso>
        SetRiskConfigurationResponse SetRiskConfiguration(SetRiskConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SetRiskConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetRiskConfiguration operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetRiskConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/SetRiskConfiguration">REST API Reference for SetRiskConfiguration Operation</seealso>
        IAsyncResult BeginSetRiskConfiguration(SetRiskConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SetRiskConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetRiskConfiguration.</param>
        /// 
        /// <returns>Returns a  SetRiskConfigurationResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/SetRiskConfiguration">REST API Reference for SetRiskConfiguration Operation</seealso>
        SetRiskConfigurationResponse EndSetRiskConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  SetUICustomization


        /// <summary>
        /// Sets the UI customization information for a user pool's built-in app UI.
        /// 
        ///  
        /// <para>
        /// You can specify app UI customization settings for a single client (with a specific
        /// <code>clientId</code>) or for all clients (by setting the <code>clientId</code> to
        /// <code>ALL</code>). If you specify <code>ALL</code>, the default configuration will
        /// be used for every client that has no UI customization set previously. If you specify
        /// UI customization settings for a particular client, it will no longer fall back to
        /// the <code>ALL</code> configuration. 
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
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/SetUICustomization">REST API Reference for SetUICustomization Operation</seealso>
        SetUICustomizationResponse SetUICustomization(SetUICustomizationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SetUICustomization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetUICustomization operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetUICustomization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/SetUICustomization">REST API Reference for SetUICustomization Operation</seealso>
        IAsyncResult BeginSetUICustomization(SetUICustomizationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SetUICustomization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetUICustomization.</param>
        /// 
        /// <returns>Returns a  SetUICustomizationResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/SetUICustomization">REST API Reference for SetUICustomization Operation</seealso>
        SetUICustomizationResponse EndSetUICustomization(IAsyncResult asyncResult);

        #endregion
        
        #region  SetUserMFAPreference


        /// <summary>
        /// Set the user's multi-factor authentication (MFA) method preference, including which
        /// MFA factors are enabled and if any are preferred. Only one factor can be set as preferred.
        /// The preferred MFA factor will be used to authenticate a user if multiple factors are
        /// enabled. If multiple options are enabled and no preference is set, a challenge to
        /// choose an MFA option will be returned during sign in. If an MFA type is enabled for
        /// a user, the user will be prompted for MFA during all sign in attempts, unless device
        /// tracking is turned on and the device has been trusted. If you would like MFA to be
        /// applied selectively based on the assessed risk level of sign in attempts, disable
        /// MFA for users and turn on Adaptive Authentication for the user pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetUserMFAPreference service method.</param>
        /// 
        /// <returns>The response from the SetUserMFAPreference service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user is not authorized.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/SetUserMFAPreference">REST API Reference for SetUserMFAPreference Operation</seealso>
        SetUserMFAPreferenceResponse SetUserMFAPreference(SetUserMFAPreferenceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SetUserMFAPreference operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetUserMFAPreference operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetUserMFAPreference
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/SetUserMFAPreference">REST API Reference for SetUserMFAPreference Operation</seealso>
        IAsyncResult BeginSetUserMFAPreference(SetUserMFAPreferenceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SetUserMFAPreference operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetUserMFAPreference.</param>
        /// 
        /// <returns>Returns a  SetUserMFAPreferenceResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/SetUserMFAPreference">REST API Reference for SetUserMFAPreference Operation</seealso>
        SetUserMFAPreferenceResponse EndSetUserMFAPreference(IAsyncResult asyncResult);

        #endregion
        
        #region  SetUserPoolMfaConfig


        /// <summary>
        /// Set the user pool multi-factor authentication (MFA) configuration.
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
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/SetUserPoolMfaConfig">REST API Reference for SetUserPoolMfaConfig Operation</seealso>
        SetUserPoolMfaConfigResponse SetUserPoolMfaConfig(SetUserPoolMfaConfigRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SetUserPoolMfaConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetUserPoolMfaConfig operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetUserPoolMfaConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/SetUserPoolMfaConfig">REST API Reference for SetUserPoolMfaConfig Operation</seealso>
        IAsyncResult BeginSetUserPoolMfaConfig(SetUserPoolMfaConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SetUserPoolMfaConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetUserPoolMfaConfig.</param>
        /// 
        /// <returns>Returns a  SetUserPoolMfaConfigResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/SetUserPoolMfaConfig">REST API Reference for SetUserPoolMfaConfig Operation</seealso>
        SetUserPoolMfaConfigResponse EndSetUserPoolMfaConfig(IAsyncResult asyncResult);

        #endregion
        
        #region  SetUserSettings


        /// <summary>
        /// <i>This action is no longer supported.</i> You can use it to configure only SMS MFA.
        /// You can't use it to configure TOTP software token MFA. To configure either type of
        /// MFA, use <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_SetUserMFAPreference.html">SetUserMFAPreference</a>
        /// instead.
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
        /// This exception is thrown when a user is not authorized.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/SetUserSettings">REST API Reference for SetUserSettings Operation</seealso>
        SetUserSettingsResponse SetUserSettings(SetUserSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SetUserSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetUserSettings operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetUserSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/SetUserSettings">REST API Reference for SetUserSettings Operation</seealso>
        IAsyncResult BeginSetUserSettings(SetUserSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SetUserSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetUserSettings.</param>
        /// 
        /// <returns>Returns a  SetUserSettingsResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/SetUserSettings">REST API Reference for SetUserSettings Operation</seealso>
        SetUserSettingsResponse EndSetUserSettings(IAsyncResult asyncResult);

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
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UnexpectedLambdaException">
        /// This exception is thrown when the Amazon Cognito service encounters an unexpected
        /// exception with the AWS Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserLambdaValidationException">
        /// This exception is thrown when the Amazon Cognito service encounters a user validation
        /// exception with the AWS Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UsernameExistsException">
        /// This exception is thrown when Amazon Cognito encounters a user name that already exists
        /// in the user pool.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/SignUp">REST API Reference for SignUp Operation</seealso>
        SignUpResponse SignUp(SignUpRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SignUp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SignUp operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSignUp
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/SignUp">REST API Reference for SignUp Operation</seealso>
        IAsyncResult BeginSignUp(SignUpRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SignUp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSignUp.</param>
        /// 
        /// <returns>Returns a  SignUpResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/SignUp">REST API Reference for SignUp Operation</seealso>
        SignUpResponse EndSignUp(IAsyncResult asyncResult);

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
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PreconditionNotMetException">
        /// This exception is thrown when a precondition is not met.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/StartUserImportJob">REST API Reference for StartUserImportJob Operation</seealso>
        StartUserImportJobResponse StartUserImportJob(StartUserImportJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartUserImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartUserImportJob operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartUserImportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/StartUserImportJob">REST API Reference for StartUserImportJob Operation</seealso>
        IAsyncResult BeginStartUserImportJob(StartUserImportJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartUserImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartUserImportJob.</param>
        /// 
        /// <returns>Returns a  StartUserImportJobResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/StartUserImportJob">REST API Reference for StartUserImportJob Operation</seealso>
        StartUserImportJobResponse EndStartUserImportJob(IAsyncResult asyncResult);

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
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PreconditionNotMetException">
        /// This exception is thrown when a precondition is not met.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/StopUserImportJob">REST API Reference for StopUserImportJob Operation</seealso>
        StopUserImportJobResponse StopUserImportJob(StopUserImportJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopUserImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopUserImportJob operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopUserImportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/StopUserImportJob">REST API Reference for StopUserImportJob Operation</seealso>
        IAsyncResult BeginStopUserImportJob(StopUserImportJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopUserImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopUserImportJob.</param>
        /// 
        /// <returns>Returns a  StopUserImportJobResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/StopUserImportJob">REST API Reference for StopUserImportJob Operation</seealso>
        StopUserImportJobResponse EndStopUserImportJob(IAsyncResult asyncResult);

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
        /// user pool and <code>Production</code> for the other.
        /// </para>
        ///  
        /// <para>
        /// Tags are useful for cost tracking and access control. You can activate your tags so
        /// that they appear on the Billing and Cost Management console, where you can track the
        /// costs associated with your user pools. In an IAM policy, you can constrain permissions
        /// for user pools based on specific tags or tag values.
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
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes the specified tags from an Amazon Cognito user pool. You can use this action
        /// up to 5 times per second, per account
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
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateAuthEventFeedback


        /// <summary>
        /// Provides the feedback for an authentication event whether it was from a valid user
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
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user is not found.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserPoolAddOnNotEnabledException">
        /// This exception is thrown when user pool add-ons are not enabled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateAuthEventFeedback">REST API Reference for UpdateAuthEventFeedback Operation</seealso>
        UpdateAuthEventFeedbackResponse UpdateAuthEventFeedback(UpdateAuthEventFeedbackRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAuthEventFeedback operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAuthEventFeedback operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAuthEventFeedback
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateAuthEventFeedback">REST API Reference for UpdateAuthEventFeedback Operation</seealso>
        IAsyncResult BeginUpdateAuthEventFeedback(UpdateAuthEventFeedbackRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAuthEventFeedback operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAuthEventFeedback.</param>
        /// 
        /// <returns>Returns a  UpdateAuthEventFeedbackResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateAuthEventFeedback">REST API Reference for UpdateAuthEventFeedback Operation</seealso>
        UpdateAuthEventFeedbackResponse EndUpdateAuthEventFeedback(IAsyncResult asyncResult);

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
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordResetRequiredException">
        /// This exception is thrown when a password reset is required.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user is not confirmed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateDeviceStatus">REST API Reference for UpdateDeviceStatus Operation</seealso>
        UpdateDeviceStatusResponse UpdateDeviceStatus(UpdateDeviceStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDeviceStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDeviceStatus operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDeviceStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateDeviceStatus">REST API Reference for UpdateDeviceStatus Operation</seealso>
        IAsyncResult BeginUpdateDeviceStatus(UpdateDeviceStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDeviceStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDeviceStatus.</param>
        /// 
        /// <returns>Returns a  UpdateDeviceStatusResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateDeviceStatus">REST API Reference for UpdateDeviceStatus Operation</seealso>
        UpdateDeviceStatusResponse EndUpdateDeviceStatus(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateGroup


        /// <summary>
        /// Updates the specified group with the specified attributes.
        /// 
        ///  
        /// <para>
        /// Calling this action requires developer credentials.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you don't provide a value for an attribute, it will be set to the default value.
        /// </para>
        ///  </important>
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
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateGroup">REST API Reference for UpdateGroup Operation</seealso>
        UpdateGroupResponse UpdateGroup(UpdateGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroup operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateGroup">REST API Reference for UpdateGroup Operation</seealso>
        IAsyncResult BeginUpdateGroup(UpdateGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateGroup.</param>
        /// 
        /// <returns>Returns a  UpdateGroupResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateGroup">REST API Reference for UpdateGroup Operation</seealso>
        UpdateGroupResponse EndUpdateGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateIdentityProvider


        /// <summary>
        /// Updates identity provider information for a user pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIdentityProvider service method.</param>
        /// 
        /// <returns>The response from the UpdateIdentityProvider service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InternalErrorException">
        /// This exception is thrown when Amazon Cognito encounters an internal error.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UnsupportedIdentityProviderException">
        /// This exception is thrown when the specified identifier is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateIdentityProvider">REST API Reference for UpdateIdentityProvider Operation</seealso>
        UpdateIdentityProviderResponse UpdateIdentityProvider(UpdateIdentityProviderRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateIdentityProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateIdentityProvider operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateIdentityProvider
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateIdentityProvider">REST API Reference for UpdateIdentityProvider Operation</seealso>
        IAsyncResult BeginUpdateIdentityProvider(UpdateIdentityProviderRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateIdentityProvider operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateIdentityProvider.</param>
        /// 
        /// <returns>Returns a  UpdateIdentityProviderResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateIdentityProvider">REST API Reference for UpdateIdentityProvider Operation</seealso>
        UpdateIdentityProviderResponse EndUpdateIdentityProvider(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateResourceServer


        /// <summary>
        /// Updates the name and scopes of resource server. All other fields are read-only.
        /// 
        ///  <important> 
        /// <para>
        /// If you don't provide a value for an attribute, it will be set to the default value.
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
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateResourceServer">REST API Reference for UpdateResourceServer Operation</seealso>
        UpdateResourceServerResponse UpdateResourceServer(UpdateResourceServerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateResourceServer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateResourceServer operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateResourceServer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateResourceServer">REST API Reference for UpdateResourceServer Operation</seealso>
        IAsyncResult BeginUpdateResourceServer(UpdateResourceServerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateResourceServer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateResourceServer.</param>
        /// 
        /// <returns>Returns a  UpdateResourceServerResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateResourceServer">REST API Reference for UpdateResourceServer Operation</seealso>
        UpdateResourceServerResponse EndUpdateResourceServer(IAsyncResult asyncResult);

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
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordResetRequiredException">
        /// This exception is thrown when a password reset is required.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UnexpectedLambdaException">
        /// This exception is thrown when the Amazon Cognito service encounters an unexpected
        /// exception with the AWS Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserLambdaValidationException">
        /// This exception is thrown when the Amazon Cognito service encounters a user validation
        /// exception with the AWS Lambda service.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user is not confirmed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateUserAttributes">REST API Reference for UpdateUserAttributes Operation</seealso>
        UpdateUserAttributesResponse UpdateUserAttributes(UpdateUserAttributesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUserAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserAttributes operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateUserAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateUserAttributes">REST API Reference for UpdateUserAttributes Operation</seealso>
        IAsyncResult BeginUpdateUserAttributes(UpdateUserAttributesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateUserAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateUserAttributes.</param>
        /// 
        /// <returns>Returns a  UpdateUserAttributesResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateUserAttributes">REST API Reference for UpdateUserAttributes Operation</seealso>
        UpdateUserAttributesResponse EndUpdateUserAttributes(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateUserPool


        /// <summary>
        /// Updates the specified user pool with the specified attributes. You can get a list
        /// of the current user pool settings using <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_DescribeUserPool.html">DescribeUserPool</a>.
        /// 
        ///  <important> 
        /// <para>
        /// If you don't provide a value for an attribute, it will be set to the default value.
        /// </para>
        ///  </important>
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
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserImportInProgressException">
        /// This exception is thrown when you are trying to modify a user pool while a user import
        /// job is in progress for that pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserPoolTaggingException">
        /// This exception is thrown when a user pool tag cannot be set or updated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateUserPool">REST API Reference for UpdateUserPool Operation</seealso>
        UpdateUserPoolResponse UpdateUserPool(UpdateUserPoolRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUserPool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserPool operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateUserPool
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateUserPool">REST API Reference for UpdateUserPool Operation</seealso>
        IAsyncResult BeginUpdateUserPool(UpdateUserPoolRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateUserPool operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateUserPool.</param>
        /// 
        /// <returns>Returns a  UpdateUserPoolResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateUserPool">REST API Reference for UpdateUserPool Operation</seealso>
        UpdateUserPoolResponse EndUpdateUserPool(IAsyncResult asyncResult);

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
        /// This exception is thrown when the specified OAuth flow is invalid.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ScopeDoesNotExistException">
        /// This exception is thrown when the specified scope does not exist.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateUserPoolClient">REST API Reference for UpdateUserPoolClient Operation</seealso>
        UpdateUserPoolClientResponse UpdateUserPoolClient(UpdateUserPoolClientRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUserPoolClient operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserPoolClient operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateUserPoolClient
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateUserPoolClient">REST API Reference for UpdateUserPoolClient Operation</seealso>
        IAsyncResult BeginUpdateUserPoolClient(UpdateUserPoolClientRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateUserPoolClient operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateUserPoolClient.</param>
        /// 
        /// <returns>Returns a  UpdateUserPoolClientResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateUserPoolClient">REST API Reference for UpdateUserPoolClient Operation</seealso>
        UpdateUserPoolClientResponse EndUpdateUserPoolClient(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateUserPoolDomain


        /// <summary>
        /// Updates the Secure Sockets Layer (SSL) certificate for the custom domain for your
        /// user pool.
        /// 
        ///  
        /// <para>
        /// You can use this operation to provide the Amazon Resource Name (ARN) of a new certificate
        /// to Amazon Cognito. You cannot use it to change the domain for a user pool.
        /// </para>
        ///  
        /// <para>
        /// A custom domain is used to host the Amazon Cognito hosted UI, which provides sign-up
        /// and sign-in pages for your application. When you set up a custom domain, you provide
        /// a certificate that you manage with AWS Certificate Manager (ACM). When necessary,
        /// you can use this operation to change the certificate that you applied to your custom
        /// domain.
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
        /// the AWS Region.
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
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateUserPoolDomain">REST API Reference for UpdateUserPoolDomain Operation</seealso>
        UpdateUserPoolDomainResponse UpdateUserPoolDomain(UpdateUserPoolDomainRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUserPoolDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserPoolDomain operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateUserPoolDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateUserPoolDomain">REST API Reference for UpdateUserPoolDomain Operation</seealso>
        IAsyncResult BeginUpdateUserPoolDomain(UpdateUserPoolDomainRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateUserPoolDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateUserPoolDomain.</param>
        /// 
        /// <returns>Returns a  UpdateUserPoolDomainResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateUserPoolDomain">REST API Reference for UpdateUserPoolDomain Operation</seealso>
        UpdateUserPoolDomainResponse EndUpdateUserPoolDomain(IAsyncResult asyncResult);

        #endregion
        
        #region  VerifySoftwareToken


        /// <summary>
        /// Use this API to register a user's entered TOTP code and mark the user's software token
        /// MFA status as "verified" if successful. The request takes an access token or a session
        /// string, but not both.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the VerifySoftwareToken service method.</param>
        /// 
        /// <returns>The response from the VerifySoftwareToken service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.CodeMismatchException">
        /// This exception is thrown if the provided code does not match what the server was expecting.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.EnableSoftwareTokenMFAException">
        /// This exception is thrown when there is a code mismatch and the service fails to configure
        /// the software token TOTP multi-factor authentication (MFA).
        /// </exception>
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
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordResetRequiredException">
        /// This exception is thrown when a password reset is required.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.SoftwareTokenMFANotFoundException">
        /// This exception is thrown when the software token TOTP multi-factor authentication
        /// (MFA) is not enabled for the user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user is not confirmed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/VerifySoftwareToken">REST API Reference for VerifySoftwareToken Operation</seealso>
        VerifySoftwareTokenResponse VerifySoftwareToken(VerifySoftwareTokenRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the VerifySoftwareToken operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the VerifySoftwareToken operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndVerifySoftwareToken
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/VerifySoftwareToken">REST API Reference for VerifySoftwareToken Operation</seealso>
        IAsyncResult BeginVerifySoftwareToken(VerifySoftwareTokenRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  VerifySoftwareToken operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginVerifySoftwareToken.</param>
        /// 
        /// <returns>Returns a  VerifySoftwareTokenResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/VerifySoftwareToken">REST API Reference for VerifySoftwareToken Operation</seealso>
        VerifySoftwareTokenResponse EndVerifySoftwareToken(IAsyncResult asyncResult);

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
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordResetRequiredException">
        /// This exception is thrown when a password reset is required.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotConfirmedException">
        /// This exception is thrown when a user is not confirmed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserNotFoundException">
        /// This exception is thrown when a user is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/VerifyUserAttribute">REST API Reference for VerifyUserAttribute Operation</seealso>
        VerifyUserAttributeResponse VerifyUserAttribute(VerifyUserAttributeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the VerifyUserAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the VerifyUserAttribute operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndVerifyUserAttribute
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/VerifyUserAttribute">REST API Reference for VerifyUserAttribute Operation</seealso>
        IAsyncResult BeginVerifyUserAttribute(VerifyUserAttributeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  VerifyUserAttribute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginVerifyUserAttribute.</param>
        /// 
        /// <returns>Returns a  VerifyUserAttributeResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/VerifyUserAttribute">REST API Reference for VerifyUserAttribute Operation</seealso>
        VerifyUserAttributeResponse EndVerifyUserAttribute(IAsyncResult asyncResult);

        #endregion
        
    }
}