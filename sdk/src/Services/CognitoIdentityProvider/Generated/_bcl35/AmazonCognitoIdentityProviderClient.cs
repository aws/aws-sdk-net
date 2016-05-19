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
using System.Collections.Generic;

using Amazon.CognitoIdentityProvider.Model;
using Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CognitoIdentityProvider
{
    /// <summary>
    /// Implementation for accessing CognitoIdentityProvider
    ///
    /// You can create a user pool in Amazon Cognito Identity to manage directories and users.
    /// You can authenticate a user to obtain tokens related to user identity and access policies.
    /// 
    ///  
    /// <para>
    /// This API reference provides information about user pools in Amazon Cognito Identity,
    /// which is a new capability that is available as a beta.
    /// </para>
    /// </summary>
    public partial class AmazonCognitoIdentityProviderClient : AmazonServiceClient, IAmazonCognitoIdentityProvider
    {
        #region Constructors

        /// <summary>
        /// Constructs AmazonCognitoIdentityProviderClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonCognitoIdentityProviderClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCognitoIdentityProviderConfig()) { }

        /// <summary>
        /// Constructs AmazonCognitoIdentityProviderClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonCognitoIdentityProviderClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCognitoIdentityProviderConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonCognitoIdentityProviderClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonCognitoIdentityProviderClient Configuration Object</param>
        public AmazonCognitoIdentityProviderClient(AmazonCognitoIdentityProviderConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonCognitoIdentityProviderClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonCognitoIdentityProviderClient(AWSCredentials credentials)
            : this(credentials, new AmazonCognitoIdentityProviderConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCognitoIdentityProviderClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCognitoIdentityProviderClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonCognitoIdentityProviderConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCognitoIdentityProviderClient with AWS Credentials and an
        /// AmazonCognitoIdentityProviderClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonCognitoIdentityProviderClient Configuration Object</param>
        public AmazonCognitoIdentityProviderClient(AWSCredentials credentials, AmazonCognitoIdentityProviderConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCognitoIdentityProviderClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonCognitoIdentityProviderClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCognitoIdentityProviderConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCognitoIdentityProviderClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCognitoIdentityProviderClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCognitoIdentityProviderConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonCognitoIdentityProviderClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCognitoIdentityProviderClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonCognitoIdentityProviderClient Configuration Object</param>
        public AmazonCognitoIdentityProviderClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCognitoIdentityProviderConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCognitoIdentityProviderClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonCognitoIdentityProviderClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCognitoIdentityProviderConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCognitoIdentityProviderClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCognitoIdentityProviderClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCognitoIdentityProviderConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCognitoIdentityProviderClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCognitoIdentityProviderClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonCognitoIdentityProviderClient Configuration Object</param>
        public AmazonCognitoIdentityProviderClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCognitoIdentityProviderConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        
        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }


        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

        
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
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception gets thrown when the user has made too many requests for a given operation.
        /// </exception>
        public AddCustomAttributesResponse AddCustomAttributes(AddCustomAttributesRequest request)
        {
            var marshaller = new AddCustomAttributesRequestMarshaller();
            var unmarshaller = AddCustomAttributesResponseUnmarshaller.Instance;

            return Invoke<AddCustomAttributesRequest,AddCustomAttributesResponse>(request, marshaller, unmarshaller);
        }

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
        public IAsyncResult BeginAddCustomAttributes(AddCustomAttributesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new AddCustomAttributesRequestMarshaller();
            var unmarshaller = AddCustomAttributesResponseUnmarshaller.Instance;

            return BeginInvoke<AddCustomAttributesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AddCustomAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddCustomAttributes.</param>
        /// 
        /// <returns>Returns a  AddCustomAttributesResult from CognitoIdentityProvider.</returns>
        public  AddCustomAttributesResponse EndAddCustomAttributes(IAsyncResult asyncResult)
        {
            return EndInvoke<AddCustomAttributesResponse>(asyncResult);
        }

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
        public AdminConfirmSignUpResponse AdminConfirmSignUp(AdminConfirmSignUpRequest request)
        {
            var marshaller = new AdminConfirmSignUpRequestMarshaller();
            var unmarshaller = AdminConfirmSignUpResponseUnmarshaller.Instance;

            return Invoke<AdminConfirmSignUpRequest,AdminConfirmSignUpResponse>(request, marshaller, unmarshaller);
        }

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
        public IAsyncResult BeginAdminConfirmSignUp(AdminConfirmSignUpRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new AdminConfirmSignUpRequestMarshaller();
            var unmarshaller = AdminConfirmSignUpResponseUnmarshaller.Instance;

            return BeginInvoke<AdminConfirmSignUpRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AdminConfirmSignUp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAdminConfirmSignUp.</param>
        /// 
        /// <returns>Returns a  AdminConfirmSignUpResult from CognitoIdentityProvider.</returns>
        public  AdminConfirmSignUpResponse EndAdminConfirmSignUp(IAsyncResult asyncResult)
        {
            return EndInvoke<AdminConfirmSignUpResponse>(asyncResult);
        }

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
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception gets thrown when the user has made too many requests for a given operation.
        /// </exception>
        public AdminDeleteUserResponse AdminDeleteUser(AdminDeleteUserRequest request)
        {
            var marshaller = new AdminDeleteUserRequestMarshaller();
            var unmarshaller = AdminDeleteUserResponseUnmarshaller.Instance;

            return Invoke<AdminDeleteUserRequest,AdminDeleteUserResponse>(request, marshaller, unmarshaller);
        }

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
        public IAsyncResult BeginAdminDeleteUser(AdminDeleteUserRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new AdminDeleteUserRequestMarshaller();
            var unmarshaller = AdminDeleteUserResponseUnmarshaller.Instance;

            return BeginInvoke<AdminDeleteUserRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AdminDeleteUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAdminDeleteUser.</param>
        /// 
        /// <returns>Returns a  AdminDeleteUserResult from CognitoIdentityProvider.</returns>
        public  AdminDeleteUserResponse EndAdminDeleteUser(IAsyncResult asyncResult)
        {
            return EndInvoke<AdminDeleteUserResponse>(asyncResult);
        }

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
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception gets thrown when the user has made too many requests for a given operation.
        /// </exception>
        public AdminDeleteUserAttributesResponse AdminDeleteUserAttributes(AdminDeleteUserAttributesRequest request)
        {
            var marshaller = new AdminDeleteUserAttributesRequestMarshaller();
            var unmarshaller = AdminDeleteUserAttributesResponseUnmarshaller.Instance;

            return Invoke<AdminDeleteUserAttributesRequest,AdminDeleteUserAttributesResponse>(request, marshaller, unmarshaller);
        }

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
        public IAsyncResult BeginAdminDeleteUserAttributes(AdminDeleteUserAttributesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new AdminDeleteUserAttributesRequestMarshaller();
            var unmarshaller = AdminDeleteUserAttributesResponseUnmarshaller.Instance;

            return BeginInvoke<AdminDeleteUserAttributesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AdminDeleteUserAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAdminDeleteUserAttributes.</param>
        /// 
        /// <returns>Returns a  AdminDeleteUserAttributesResult from CognitoIdentityProvider.</returns>
        public  AdminDeleteUserAttributesResponse EndAdminDeleteUserAttributes(IAsyncResult asyncResult)
        {
            return EndInvoke<AdminDeleteUserAttributesResponse>(asyncResult);
        }

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
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception gets thrown when the user has made too many requests for a given operation.
        /// </exception>
        public AdminDisableUserResponse AdminDisableUser(AdminDisableUserRequest request)
        {
            var marshaller = new AdminDisableUserRequestMarshaller();
            var unmarshaller = AdminDisableUserResponseUnmarshaller.Instance;

            return Invoke<AdminDisableUserRequest,AdminDisableUserResponse>(request, marshaller, unmarshaller);
        }

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
        public IAsyncResult BeginAdminDisableUser(AdminDisableUserRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new AdminDisableUserRequestMarshaller();
            var unmarshaller = AdminDisableUserResponseUnmarshaller.Instance;

            return BeginInvoke<AdminDisableUserRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AdminDisableUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAdminDisableUser.</param>
        /// 
        /// <returns>Returns a  AdminDisableUserResult from CognitoIdentityProvider.</returns>
        public  AdminDisableUserResponse EndAdminDisableUser(IAsyncResult asyncResult)
        {
            return EndInvoke<AdminDisableUserResponse>(asyncResult);
        }

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
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception gets thrown when the user has made too many requests for a given operation.
        /// </exception>
        public AdminEnableUserResponse AdminEnableUser(AdminEnableUserRequest request)
        {
            var marshaller = new AdminEnableUserRequestMarshaller();
            var unmarshaller = AdminEnableUserResponseUnmarshaller.Instance;

            return Invoke<AdminEnableUserRequest,AdminEnableUserResponse>(request, marshaller, unmarshaller);
        }

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
        public IAsyncResult BeginAdminEnableUser(AdminEnableUserRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new AdminEnableUserRequestMarshaller();
            var unmarshaller = AdminEnableUserResponseUnmarshaller.Instance;

            return BeginInvoke<AdminEnableUserRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AdminEnableUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAdminEnableUser.</param>
        /// 
        /// <returns>Returns a  AdminEnableUserResult from CognitoIdentityProvider.</returns>
        public  AdminEnableUserResponse EndAdminEnableUser(IAsyncResult asyncResult)
        {
            return EndInvoke<AdminEnableUserResponse>(asyncResult);
        }

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
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception gets thrown when the user has made too many requests for a given operation.
        /// </exception>
        public AdminGetUserResponse AdminGetUser(AdminGetUserRequest request)
        {
            var marshaller = new AdminGetUserRequestMarshaller();
            var unmarshaller = AdminGetUserResponseUnmarshaller.Instance;

            return Invoke<AdminGetUserRequest,AdminGetUserResponse>(request, marshaller, unmarshaller);
        }

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
        public IAsyncResult BeginAdminGetUser(AdminGetUserRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new AdminGetUserRequestMarshaller();
            var unmarshaller = AdminGetUserResponseUnmarshaller.Instance;

            return BeginInvoke<AdminGetUserRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AdminGetUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAdminGetUser.</param>
        /// 
        /// <returns>Returns a  AdminGetUserResult from CognitoIdentityProvider.</returns>
        public  AdminGetUserResponse EndAdminGetUser(IAsyncResult asyncResult)
        {
            return EndInvoke<AdminGetUserResponse>(asyncResult);
        }

        #endregion
        
        #region  AdminResetUserPassword

        /// <summary>
        /// Resets the specified user's password in a user pool as an administrator. Works on
        /// any user.
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
        public AdminResetUserPasswordResponse AdminResetUserPassword(AdminResetUserPasswordRequest request)
        {
            var marshaller = new AdminResetUserPasswordRequestMarshaller();
            var unmarshaller = AdminResetUserPasswordResponseUnmarshaller.Instance;

            return Invoke<AdminResetUserPasswordRequest,AdminResetUserPasswordResponse>(request, marshaller, unmarshaller);
        }

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
        public IAsyncResult BeginAdminResetUserPassword(AdminResetUserPasswordRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new AdminResetUserPasswordRequestMarshaller();
            var unmarshaller = AdminResetUserPasswordResponseUnmarshaller.Instance;

            return BeginInvoke<AdminResetUserPasswordRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AdminResetUserPassword operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAdminResetUserPassword.</param>
        /// 
        /// <returns>Returns a  AdminResetUserPasswordResult from CognitoIdentityProvider.</returns>
        public  AdminResetUserPasswordResponse EndAdminResetUserPassword(IAsyncResult asyncResult)
        {
            return EndInvoke<AdminResetUserPasswordResponse>(asyncResult);
        }

        #endregion
        
        #region  AdminSetUserSettings

        /// <summary>
        /// Sets all the user settings for a specified user name. Works on any user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AdminSetUserSettings service method.</param>
        /// 
        /// <returns>The response from the AdminSetUserSettings service method, as returned by CognitoIdentityProvider.</returns>
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
        public AdminSetUserSettingsResponse AdminSetUserSettings(AdminSetUserSettingsRequest request)
        {
            var marshaller = new AdminSetUserSettingsRequestMarshaller();
            var unmarshaller = AdminSetUserSettingsResponseUnmarshaller.Instance;

            return Invoke<AdminSetUserSettingsRequest,AdminSetUserSettingsResponse>(request, marshaller, unmarshaller);
        }

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
        public IAsyncResult BeginAdminSetUserSettings(AdminSetUserSettingsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new AdminSetUserSettingsRequestMarshaller();
            var unmarshaller = AdminSetUserSettingsResponseUnmarshaller.Instance;

            return BeginInvoke<AdminSetUserSettingsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AdminSetUserSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAdminSetUserSettings.</param>
        /// 
        /// <returns>Returns a  AdminSetUserSettingsResult from CognitoIdentityProvider.</returns>
        public  AdminSetUserSettingsResponse EndAdminSetUserSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<AdminSetUserSettingsResponse>(asyncResult);
        }

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
        public AdminUpdateUserAttributesResponse AdminUpdateUserAttributes(AdminUpdateUserAttributesRequest request)
        {
            var marshaller = new AdminUpdateUserAttributesRequestMarshaller();
            var unmarshaller = AdminUpdateUserAttributesResponseUnmarshaller.Instance;

            return Invoke<AdminUpdateUserAttributesRequest,AdminUpdateUserAttributesResponse>(request, marshaller, unmarshaller);
        }

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
        public IAsyncResult BeginAdminUpdateUserAttributes(AdminUpdateUserAttributesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new AdminUpdateUserAttributesRequestMarshaller();
            var unmarshaller = AdminUpdateUserAttributesResponseUnmarshaller.Instance;

            return BeginInvoke<AdminUpdateUserAttributesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AdminUpdateUserAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAdminUpdateUserAttributes.</param>
        /// 
        /// <returns>Returns a  AdminUpdateUserAttributesResult from CognitoIdentityProvider.</returns>
        public  AdminUpdateUserAttributesResponse EndAdminUpdateUserAttributes(IAsyncResult asyncResult)
        {
            return EndInvoke<AdminUpdateUserAttributesResponse>(asyncResult);
        }

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
        public ChangePasswordResponse ChangePassword(ChangePasswordRequest request)
        {
            var marshaller = new ChangePasswordRequestMarshaller();
            var unmarshaller = ChangePasswordResponseUnmarshaller.Instance;

            return Invoke<ChangePasswordRequest,ChangePasswordResponse>(request, marshaller, unmarshaller);
        }

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
        public IAsyncResult BeginChangePassword(ChangePasswordRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ChangePasswordRequestMarshaller();
            var unmarshaller = ChangePasswordResponseUnmarshaller.Instance;

            return BeginInvoke<ChangePasswordRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ChangePassword operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginChangePassword.</param>
        /// 
        /// <returns>Returns a  ChangePasswordResult from CognitoIdentityProvider.</returns>
        public  ChangePasswordResponse EndChangePassword(IAsyncResult asyncResult)
        {
            return EndInvoke<ChangePasswordResponse>(asyncResult);
        }

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
        public ConfirmForgotPasswordResponse ConfirmForgotPassword(ConfirmForgotPasswordRequest request)
        {
            var marshaller = new ConfirmForgotPasswordRequestMarshaller();
            var unmarshaller = ConfirmForgotPasswordResponseUnmarshaller.Instance;

            return Invoke<ConfirmForgotPasswordRequest,ConfirmForgotPasswordResponse>(request, marshaller, unmarshaller);
        }

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
        public IAsyncResult BeginConfirmForgotPassword(ConfirmForgotPasswordRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ConfirmForgotPasswordRequestMarshaller();
            var unmarshaller = ConfirmForgotPasswordResponseUnmarshaller.Instance;

            return BeginInvoke<ConfirmForgotPasswordRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ConfirmForgotPassword operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginConfirmForgotPassword.</param>
        /// 
        /// <returns>Returns a  ConfirmForgotPasswordResult from CognitoIdentityProvider.</returns>
        public  ConfirmForgotPasswordResponse EndConfirmForgotPassword(IAsyncResult asyncResult)
        {
            return EndInvoke<ConfirmForgotPasswordResponse>(asyncResult);
        }

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
        public ConfirmSignUpResponse ConfirmSignUp(ConfirmSignUpRequest request)
        {
            var marshaller = new ConfirmSignUpRequestMarshaller();
            var unmarshaller = ConfirmSignUpResponseUnmarshaller.Instance;

            return Invoke<ConfirmSignUpRequest,ConfirmSignUpResponse>(request, marshaller, unmarshaller);
        }

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
        public IAsyncResult BeginConfirmSignUp(ConfirmSignUpRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ConfirmSignUpRequestMarshaller();
            var unmarshaller = ConfirmSignUpResponseUnmarshaller.Instance;

            return BeginInvoke<ConfirmSignUpRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ConfirmSignUp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginConfirmSignUp.</param>
        /// 
        /// <returns>Returns a  ConfirmSignUpResult from CognitoIdentityProvider.</returns>
        public  ConfirmSignUpResponse EndConfirmSignUp(IAsyncResult asyncResult)
        {
            return EndInvoke<ConfirmSignUpResponse>(asyncResult);
        }

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
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.LimitExceededException">
        /// This exception is thrown when a user exceeds the limit for a requested AWS resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception gets thrown when the user has made too many requests for a given operation.
        /// </exception>
        public CreateUserPoolResponse CreateUserPool(CreateUserPoolRequest request)
        {
            var marshaller = new CreateUserPoolRequestMarshaller();
            var unmarshaller = CreateUserPoolResponseUnmarshaller.Instance;

            return Invoke<CreateUserPoolRequest,CreateUserPoolResponse>(request, marshaller, unmarshaller);
        }

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
        public IAsyncResult BeginCreateUserPool(CreateUserPoolRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateUserPoolRequestMarshaller();
            var unmarshaller = CreateUserPoolResponseUnmarshaller.Instance;

            return BeginInvoke<CreateUserPoolRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateUserPool operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateUserPool.</param>
        /// 
        /// <returns>Returns a  CreateUserPoolResult from CognitoIdentityProvider.</returns>
        public  CreateUserPoolResponse EndCreateUserPool(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateUserPoolResponse>(asyncResult);
        }

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
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception gets thrown when the user has made too many requests for a given operation.
        /// </exception>
        public CreateUserPoolClientResponse CreateUserPoolClient(CreateUserPoolClientRequest request)
        {
            var marshaller = new CreateUserPoolClientRequestMarshaller();
            var unmarshaller = CreateUserPoolClientResponseUnmarshaller.Instance;

            return Invoke<CreateUserPoolClientRequest,CreateUserPoolClientResponse>(request, marshaller, unmarshaller);
        }

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
        public IAsyncResult BeginCreateUserPoolClient(CreateUserPoolClientRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateUserPoolClientRequestMarshaller();
            var unmarshaller = CreateUserPoolClientResponseUnmarshaller.Instance;

            return BeginInvoke<CreateUserPoolClientRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateUserPoolClient operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateUserPoolClient.</param>
        /// 
        /// <returns>Returns a  CreateUserPoolClientResult from CognitoIdentityProvider.</returns>
        public  CreateUserPoolClientResponse EndCreateUserPoolClient(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateUserPoolClientResponse>(asyncResult);
        }

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
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception gets thrown when the user has made too many requests for a given operation.
        /// </exception>
        public DeleteUserResponse DeleteUser(DeleteUserRequest request)
        {
            var marshaller = new DeleteUserRequestMarshaller();
            var unmarshaller = DeleteUserResponseUnmarshaller.Instance;

            return Invoke<DeleteUserRequest,DeleteUserResponse>(request, marshaller, unmarshaller);
        }

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
        public IAsyncResult BeginDeleteUser(DeleteUserRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteUserRequestMarshaller();
            var unmarshaller = DeleteUserResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteUserRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUser.</param>
        /// 
        /// <returns>Returns a  DeleteUserResult from CognitoIdentityProvider.</returns>
        public  DeleteUserResponse EndDeleteUser(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteUserResponse>(asyncResult);
        }

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
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception gets thrown when the user has made too many requests for a given operation.
        /// </exception>
        public DeleteUserAttributesResponse DeleteUserAttributes(DeleteUserAttributesRequest request)
        {
            var marshaller = new DeleteUserAttributesRequestMarshaller();
            var unmarshaller = DeleteUserAttributesResponseUnmarshaller.Instance;

            return Invoke<DeleteUserAttributesRequest,DeleteUserAttributesResponse>(request, marshaller, unmarshaller);
        }

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
        public IAsyncResult BeginDeleteUserAttributes(DeleteUserAttributesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteUserAttributesRequestMarshaller();
            var unmarshaller = DeleteUserAttributesResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteUserAttributesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteUserAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUserAttributes.</param>
        /// 
        /// <returns>Returns a  DeleteUserAttributesResult from CognitoIdentityProvider.</returns>
        public  DeleteUserAttributesResponse EndDeleteUserAttributes(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteUserAttributesResponse>(asyncResult);
        }

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
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception gets thrown when the user has made too many requests for a given operation.
        /// </exception>
        public DeleteUserPoolResponse DeleteUserPool(DeleteUserPoolRequest request)
        {
            var marshaller = new DeleteUserPoolRequestMarshaller();
            var unmarshaller = DeleteUserPoolResponseUnmarshaller.Instance;

            return Invoke<DeleteUserPoolRequest,DeleteUserPoolResponse>(request, marshaller, unmarshaller);
        }

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
        public IAsyncResult BeginDeleteUserPool(DeleteUserPoolRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteUserPoolRequestMarshaller();
            var unmarshaller = DeleteUserPoolResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteUserPoolRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteUserPool operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUserPool.</param>
        /// 
        /// <returns>Returns a  DeleteUserPoolResult from CognitoIdentityProvider.</returns>
        public  DeleteUserPoolResponse EndDeleteUserPool(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteUserPoolResponse>(asyncResult);
        }

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
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception gets thrown when the user has made too many requests for a given operation.
        /// </exception>
        public DeleteUserPoolClientResponse DeleteUserPoolClient(DeleteUserPoolClientRequest request)
        {
            var marshaller = new DeleteUserPoolClientRequestMarshaller();
            var unmarshaller = DeleteUserPoolClientResponseUnmarshaller.Instance;

            return Invoke<DeleteUserPoolClientRequest,DeleteUserPoolClientResponse>(request, marshaller, unmarshaller);
        }

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
        public IAsyncResult BeginDeleteUserPoolClient(DeleteUserPoolClientRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteUserPoolClientRequestMarshaller();
            var unmarshaller = DeleteUserPoolClientResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteUserPoolClientRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteUserPoolClient operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUserPoolClient.</param>
        /// 
        /// <returns>Returns a  DeleteUserPoolClientResult from CognitoIdentityProvider.</returns>
        public  DeleteUserPoolClientResponse EndDeleteUserPoolClient(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteUserPoolClientResponse>(asyncResult);
        }

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
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception gets thrown when the user has made too many requests for a given operation.
        /// </exception>
        public DescribeUserPoolResponse DescribeUserPool(DescribeUserPoolRequest request)
        {
            var marshaller = new DescribeUserPoolRequestMarshaller();
            var unmarshaller = DescribeUserPoolResponseUnmarshaller.Instance;

            return Invoke<DescribeUserPoolRequest,DescribeUserPoolResponse>(request, marshaller, unmarshaller);
        }

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
        public IAsyncResult BeginDescribeUserPool(DescribeUserPoolRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeUserPoolRequestMarshaller();
            var unmarshaller = DescribeUserPoolResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeUserPoolRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeUserPool operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeUserPool.</param>
        /// 
        /// <returns>Returns a  DescribeUserPoolResult from CognitoIdentityProvider.</returns>
        public  DescribeUserPoolResponse EndDescribeUserPool(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeUserPoolResponse>(asyncResult);
        }

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
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception gets thrown when the user has made too many requests for a given operation.
        /// </exception>
        public DescribeUserPoolClientResponse DescribeUserPoolClient(DescribeUserPoolClientRequest request)
        {
            var marshaller = new DescribeUserPoolClientRequestMarshaller();
            var unmarshaller = DescribeUserPoolClientResponseUnmarshaller.Instance;

            return Invoke<DescribeUserPoolClientRequest,DescribeUserPoolClientResponse>(request, marshaller, unmarshaller);
        }

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
        public IAsyncResult BeginDescribeUserPoolClient(DescribeUserPoolClientRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeUserPoolClientRequestMarshaller();
            var unmarshaller = DescribeUserPoolClientResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeUserPoolClientRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeUserPoolClient operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeUserPoolClient.</param>
        /// 
        /// <returns>Returns a  DescribeUserPoolClientResult from CognitoIdentityProvider.</returns>
        public  DescribeUserPoolClientResponse EndDescribeUserPoolClient(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeUserPoolClientResponse>(asyncResult);
        }

        #endregion
        
        #region  ForgotPassword

        /// <summary>
        /// Retrieves the password for the specified client ID or username.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ForgotPassword service method.</param>
        /// 
        /// <returns>The response from the ForgotPassword service method, as returned by CognitoIdentityProvider.</returns>
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
        public ForgotPasswordResponse ForgotPassword(ForgotPasswordRequest request)
        {
            var marshaller = new ForgotPasswordRequestMarshaller();
            var unmarshaller = ForgotPasswordResponseUnmarshaller.Instance;

            return Invoke<ForgotPasswordRequest,ForgotPasswordResponse>(request, marshaller, unmarshaller);
        }

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
        public IAsyncResult BeginForgotPassword(ForgotPasswordRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ForgotPasswordRequestMarshaller();
            var unmarshaller = ForgotPasswordResponseUnmarshaller.Instance;

            return BeginInvoke<ForgotPasswordRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ForgotPassword operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginForgotPassword.</param>
        /// 
        /// <returns>Returns a  ForgotPasswordResult from CognitoIdentityProvider.</returns>
        public  ForgotPasswordResponse EndForgotPassword(IAsyncResult asyncResult)
        {
            return EndInvoke<ForgotPasswordResponse>(asyncResult);
        }

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
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception gets thrown when the user has made too many requests for a given operation.
        /// </exception>
        public GetUserResponse GetUser(GetUserRequest request)
        {
            var marshaller = new GetUserRequestMarshaller();
            var unmarshaller = GetUserResponseUnmarshaller.Instance;

            return Invoke<GetUserRequest,GetUserResponse>(request, marshaller, unmarshaller);
        }

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
        public IAsyncResult BeginGetUser(GetUserRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetUserRequestMarshaller();
            var unmarshaller = GetUserResponseUnmarshaller.Instance;

            return BeginInvoke<GetUserRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUser.</param>
        /// 
        /// <returns>Returns a  GetUserResult from CognitoIdentityProvider.</returns>
        public  GetUserResponse EndGetUser(IAsyncResult asyncResult)
        {
            return EndInvoke<GetUserResponse>(asyncResult);
        }

        #endregion
        
        #region  GetUserAttributeVerificationCode

        /// <summary>
        /// Gets the user attribute verification code for the specified attribute name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUserAttributeVerificationCode service method.</param>
        /// 
        /// <returns>The response from the GetUserAttributeVerificationCode service method, as returned by CognitoIdentityProvider.</returns>
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
        public GetUserAttributeVerificationCodeResponse GetUserAttributeVerificationCode(GetUserAttributeVerificationCodeRequest request)
        {
            var marshaller = new GetUserAttributeVerificationCodeRequestMarshaller();
            var unmarshaller = GetUserAttributeVerificationCodeResponseUnmarshaller.Instance;

            return Invoke<GetUserAttributeVerificationCodeRequest,GetUserAttributeVerificationCodeResponse>(request, marshaller, unmarshaller);
        }

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
        public IAsyncResult BeginGetUserAttributeVerificationCode(GetUserAttributeVerificationCodeRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetUserAttributeVerificationCodeRequestMarshaller();
            var unmarshaller = GetUserAttributeVerificationCodeResponseUnmarshaller.Instance;

            return BeginInvoke<GetUserAttributeVerificationCodeRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetUserAttributeVerificationCode operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUserAttributeVerificationCode.</param>
        /// 
        /// <returns>Returns a  GetUserAttributeVerificationCodeResult from CognitoIdentityProvider.</returns>
        public  GetUserAttributeVerificationCodeResponse EndGetUserAttributeVerificationCode(IAsyncResult asyncResult)
        {
            return EndInvoke<GetUserAttributeVerificationCodeResponse>(asyncResult);
        }

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
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception gets thrown when the user has made too many requests for a given operation.
        /// </exception>
        public ListUserPoolClientsResponse ListUserPoolClients(ListUserPoolClientsRequest request)
        {
            var marshaller = new ListUserPoolClientsRequestMarshaller();
            var unmarshaller = ListUserPoolClientsResponseUnmarshaller.Instance;

            return Invoke<ListUserPoolClientsRequest,ListUserPoolClientsResponse>(request, marshaller, unmarshaller);
        }

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
        public IAsyncResult BeginListUserPoolClients(ListUserPoolClientsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListUserPoolClientsRequestMarshaller();
            var unmarshaller = ListUserPoolClientsResponseUnmarshaller.Instance;

            return BeginInvoke<ListUserPoolClientsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListUserPoolClients operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListUserPoolClients.</param>
        /// 
        /// <returns>Returns a  ListUserPoolClientsResult from CognitoIdentityProvider.</returns>
        public  ListUserPoolClientsResponse EndListUserPoolClients(IAsyncResult asyncResult)
        {
            return EndInvoke<ListUserPoolClientsResponse>(asyncResult);
        }

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
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception gets thrown when the user has made too many requests for a given operation.
        /// </exception>
        public ListUserPoolsResponse ListUserPools(ListUserPoolsRequest request)
        {
            var marshaller = new ListUserPoolsRequestMarshaller();
            var unmarshaller = ListUserPoolsResponseUnmarshaller.Instance;

            return Invoke<ListUserPoolsRequest,ListUserPoolsResponse>(request, marshaller, unmarshaller);
        }

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
        public IAsyncResult BeginListUserPools(ListUserPoolsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListUserPoolsRequestMarshaller();
            var unmarshaller = ListUserPoolsResponseUnmarshaller.Instance;

            return BeginInvoke<ListUserPoolsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListUserPools operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListUserPools.</param>
        /// 
        /// <returns>Returns a  ListUserPoolsResult from CognitoIdentityProvider.</returns>
        public  ListUserPoolsResponse EndListUserPools(IAsyncResult asyncResult)
        {
            return EndInvoke<ListUserPoolsResponse>(asyncResult);
        }

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
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception gets thrown when the user has made too many requests for a given operation.
        /// </exception>
        public ListUsersResponse ListUsers(ListUsersRequest request)
        {
            var marshaller = new ListUsersRequestMarshaller();
            var unmarshaller = ListUsersResponseUnmarshaller.Instance;

            return Invoke<ListUsersRequest,ListUsersResponse>(request, marshaller, unmarshaller);
        }

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
        public IAsyncResult BeginListUsers(ListUsersRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListUsersRequestMarshaller();
            var unmarshaller = ListUsersResponseUnmarshaller.Instance;

            return BeginInvoke<ListUsersRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListUsers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListUsers.</param>
        /// 
        /// <returns>Returns a  ListUsersResult from CognitoIdentityProvider.</returns>
        public  ListUsersResponse EndListUsers(IAsyncResult asyncResult)
        {
            return EndInvoke<ListUsersResponse>(asyncResult);
        }

        #endregion
        
        #region  ResendConfirmationCode

        /// <summary>
        /// Resends the confirmation (for confirmation of registration) to a specific user in
        /// the user pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResendConfirmationCode service method.</param>
        /// 
        /// <returns>The response from the ResendConfirmationCode service method, as returned by CognitoIdentityProvider.</returns>
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
        public ResendConfirmationCodeResponse ResendConfirmationCode(ResendConfirmationCodeRequest request)
        {
            var marshaller = new ResendConfirmationCodeRequestMarshaller();
            var unmarshaller = ResendConfirmationCodeResponseUnmarshaller.Instance;

            return Invoke<ResendConfirmationCodeRequest,ResendConfirmationCodeResponse>(request, marshaller, unmarshaller);
        }

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
        public IAsyncResult BeginResendConfirmationCode(ResendConfirmationCodeRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ResendConfirmationCodeRequestMarshaller();
            var unmarshaller = ResendConfirmationCodeResponseUnmarshaller.Instance;

            return BeginInvoke<ResendConfirmationCodeRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ResendConfirmationCode operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResendConfirmationCode.</param>
        /// 
        /// <returns>Returns a  ResendConfirmationCodeResult from CognitoIdentityProvider.</returns>
        public  ResendConfirmationCodeResponse EndResendConfirmationCode(IAsyncResult asyncResult)
        {
            return EndInvoke<ResendConfirmationCodeResponse>(asyncResult);
        }

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
        public SetUserSettingsResponse SetUserSettings(SetUserSettingsRequest request)
        {
            var marshaller = new SetUserSettingsRequestMarshaller();
            var unmarshaller = SetUserSettingsResponseUnmarshaller.Instance;

            return Invoke<SetUserSettingsRequest,SetUserSettingsResponse>(request, marshaller, unmarshaller);
        }

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
        public IAsyncResult BeginSetUserSettings(SetUserSettingsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new SetUserSettingsRequestMarshaller();
            var unmarshaller = SetUserSettingsResponseUnmarshaller.Instance;

            return BeginInvoke<SetUserSettingsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SetUserSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetUserSettings.</param>
        /// 
        /// <returns>Returns a  SetUserSettingsResult from CognitoIdentityProvider.</returns>
        public  SetUserSettingsResponse EndSetUserSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<SetUserSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  SignUp

        /// <summary>
        /// Registers the user in the specified user pool and creates a user name, password, and
        /// user attributes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SignUp service method.</param>
        /// 
        /// <returns>The response from the SignUp service method, as returned by CognitoIdentityProvider.</returns>
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
        public SignUpResponse SignUp(SignUpRequest request)
        {
            var marshaller = new SignUpRequestMarshaller();
            var unmarshaller = SignUpResponseUnmarshaller.Instance;

            return Invoke<SignUpRequest,SignUpResponse>(request, marshaller, unmarshaller);
        }

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
        public IAsyncResult BeginSignUp(SignUpRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new SignUpRequestMarshaller();
            var unmarshaller = SignUpResponseUnmarshaller.Instance;

            return BeginInvoke<SignUpRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SignUp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSignUp.</param>
        /// 
        /// <returns>Returns a  SignUpResult from CognitoIdentityProvider.</returns>
        public  SignUpResponse EndSignUp(IAsyncResult asyncResult)
        {
            return EndInvoke<SignUpResponse>(asyncResult);
        }

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
        public UpdateUserAttributesResponse UpdateUserAttributes(UpdateUserAttributesRequest request)
        {
            var marshaller = new UpdateUserAttributesRequestMarshaller();
            var unmarshaller = UpdateUserAttributesResponseUnmarshaller.Instance;

            return Invoke<UpdateUserAttributesRequest,UpdateUserAttributesResponse>(request, marshaller, unmarshaller);
        }

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
        public IAsyncResult BeginUpdateUserAttributes(UpdateUserAttributesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateUserAttributesRequestMarshaller();
            var unmarshaller = UpdateUserAttributesResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateUserAttributesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateUserAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateUserAttributes.</param>
        /// 
        /// <returns>Returns a  UpdateUserAttributesResult from CognitoIdentityProvider.</returns>
        public  UpdateUserAttributesResponse EndUpdateUserAttributes(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateUserAttributesResponse>(asyncResult);
        }

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
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.InvalidParameterException">
        /// This exception is thrown when the Amazon Cognito service encounters an invalid parameter.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception gets thrown when the user has made too many requests for a given operation.
        /// </exception>
        public UpdateUserPoolResponse UpdateUserPool(UpdateUserPoolRequest request)
        {
            var marshaller = new UpdateUserPoolRequestMarshaller();
            var unmarshaller = UpdateUserPoolResponseUnmarshaller.Instance;

            return Invoke<UpdateUserPoolRequest,UpdateUserPoolResponse>(request, marshaller, unmarshaller);
        }

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
        public IAsyncResult BeginUpdateUserPool(UpdateUserPoolRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateUserPoolRequestMarshaller();
            var unmarshaller = UpdateUserPoolResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateUserPoolRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateUserPool operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateUserPool.</param>
        /// 
        /// <returns>Returns a  UpdateUserPoolResult from CognitoIdentityProvider.</returns>
        public  UpdateUserPoolResponse EndUpdateUserPool(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateUserPoolResponse>(asyncResult);
        }

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
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception gets thrown when the user has made too many requests for a given operation.
        /// </exception>
        public UpdateUserPoolClientResponse UpdateUserPoolClient(UpdateUserPoolClientRequest request)
        {
            var marshaller = new UpdateUserPoolClientRequestMarshaller();
            var unmarshaller = UpdateUserPoolClientResponseUnmarshaller.Instance;

            return Invoke<UpdateUserPoolClientRequest,UpdateUserPoolClientResponse>(request, marshaller, unmarshaller);
        }

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
        public IAsyncResult BeginUpdateUserPoolClient(UpdateUserPoolClientRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateUserPoolClientRequestMarshaller();
            var unmarshaller = UpdateUserPoolClientResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateUserPoolClientRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateUserPoolClient operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateUserPoolClient.</param>
        /// 
        /// <returns>Returns a  UpdateUserPoolClientResult from CognitoIdentityProvider.</returns>
        public  UpdateUserPoolClientResponse EndUpdateUserPoolClient(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateUserPoolClientResponse>(asyncResult);
        }

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
        public VerifyUserAttributeResponse VerifyUserAttribute(VerifyUserAttributeRequest request)
        {
            var marshaller = new VerifyUserAttributeRequestMarshaller();
            var unmarshaller = VerifyUserAttributeResponseUnmarshaller.Instance;

            return Invoke<VerifyUserAttributeRequest,VerifyUserAttributeResponse>(request, marshaller, unmarshaller);
        }

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
        public IAsyncResult BeginVerifyUserAttribute(VerifyUserAttributeRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new VerifyUserAttributeRequestMarshaller();
            var unmarshaller = VerifyUserAttributeResponseUnmarshaller.Instance;

            return BeginInvoke<VerifyUserAttributeRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  VerifyUserAttribute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginVerifyUserAttribute.</param>
        /// 
        /// <returns>Returns a  VerifyUserAttributeResult from CognitoIdentityProvider.</returns>
        public  VerifyUserAttributeResponse EndVerifyUserAttribute(IAsyncResult asyncResult)
        {
            return EndInvoke<VerifyUserAttributeResponse>(asyncResult);
        }

        #endregion
        
    }
}