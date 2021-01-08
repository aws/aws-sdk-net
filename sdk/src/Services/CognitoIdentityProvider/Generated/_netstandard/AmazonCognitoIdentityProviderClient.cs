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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.CognitoIdentityProvider.Model;
using Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations;
using Amazon.CognitoIdentityProvider.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CognitoIdentityProvider
{
    /// <summary>
    /// Implementation for accessing CognitoIdentityProvider
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
#if NETSTANDARD13
    [Obsolete("Support for .NET Standard 1.3 is in maintenance mode and will only receive critical bug fixes and security patches. Visit https://docs.aws.amazon.com/sdk-for-net/v3/developer-guide/migration-from-net-standard-1-3.html for further details.")]
#endif
    public partial class AmazonCognitoIdentityProviderClient : AmazonServiceClient, IAmazonCognitoIdentityProvider
    {
        private static IServiceMetadata serviceMetadata = new AmazonCognitoIdentityProviderMetadata();
        
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
#if AWS_ASYNC_ENUMERABLES_API
        private ICognitoIdentityProviderPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ICognitoIdentityProviderPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new CognitoIdentityProviderPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        } 

        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
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

        internal virtual AddCustomAttributesResponse AddCustomAttributes(AddCustomAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddCustomAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddCustomAttributesResponseUnmarshaller.Instance;

            return Invoke<AddCustomAttributesResponse>(request, options);
        }



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
        public virtual Task<AddCustomAttributesResponse> AddCustomAttributesAsync(AddCustomAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddCustomAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddCustomAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<AddCustomAttributesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AdminAddUserToGroup

        internal virtual AdminAddUserToGroupResponse AdminAddUserToGroup(AdminAddUserToGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminAddUserToGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminAddUserToGroupResponseUnmarshaller.Instance;

            return Invoke<AdminAddUserToGroupResponse>(request, options);
        }



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
        public virtual Task<AdminAddUserToGroupResponse> AdminAddUserToGroupAsync(AdminAddUserToGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminAddUserToGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminAddUserToGroupResponseUnmarshaller.Instance;

            return InvokeAsync<AdminAddUserToGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AdminConfirmSignUp

        internal virtual AdminConfirmSignUpResponse AdminConfirmSignUp(AdminConfirmSignUpRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminConfirmSignUpRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminConfirmSignUpResponseUnmarshaller.Instance;

            return Invoke<AdminConfirmSignUpResponse>(request, options);
        }



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
        public virtual Task<AdminConfirmSignUpResponse> AdminConfirmSignUpAsync(AdminConfirmSignUpRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminConfirmSignUpRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminConfirmSignUpResponseUnmarshaller.Instance;

            return InvokeAsync<AdminConfirmSignUpResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AdminCreateUser

        internal virtual AdminCreateUserResponse AdminCreateUser(AdminCreateUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminCreateUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminCreateUserResponseUnmarshaller.Instance;

            return Invoke<AdminCreateUserResponse>(request, options);
        }



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
        public virtual Task<AdminCreateUserResponse> AdminCreateUserAsync(AdminCreateUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminCreateUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminCreateUserResponseUnmarshaller.Instance;

            return InvokeAsync<AdminCreateUserResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AdminDeleteUser

        internal virtual AdminDeleteUserResponse AdminDeleteUser(AdminDeleteUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminDeleteUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminDeleteUserResponseUnmarshaller.Instance;

            return Invoke<AdminDeleteUserResponse>(request, options);
        }



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
        public virtual Task<AdminDeleteUserResponse> AdminDeleteUserAsync(AdminDeleteUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminDeleteUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminDeleteUserResponseUnmarshaller.Instance;

            return InvokeAsync<AdminDeleteUserResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AdminDeleteUserAttributes

        internal virtual AdminDeleteUserAttributesResponse AdminDeleteUserAttributes(AdminDeleteUserAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminDeleteUserAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminDeleteUserAttributesResponseUnmarshaller.Instance;

            return Invoke<AdminDeleteUserAttributesResponse>(request, options);
        }



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
        public virtual Task<AdminDeleteUserAttributesResponse> AdminDeleteUserAttributesAsync(AdminDeleteUserAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminDeleteUserAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminDeleteUserAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<AdminDeleteUserAttributesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AdminDisableProviderForUser

        internal virtual AdminDisableProviderForUserResponse AdminDisableProviderForUser(AdminDisableProviderForUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminDisableProviderForUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminDisableProviderForUserResponseUnmarshaller.Instance;

            return Invoke<AdminDisableProviderForUserResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<AdminDisableProviderForUserResponse> AdminDisableProviderForUserAsync(AdminDisableProviderForUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminDisableProviderForUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminDisableProviderForUserResponseUnmarshaller.Instance;

            return InvokeAsync<AdminDisableProviderForUserResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AdminDisableUser

        internal virtual AdminDisableUserResponse AdminDisableUser(AdminDisableUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminDisableUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminDisableUserResponseUnmarshaller.Instance;

            return Invoke<AdminDisableUserResponse>(request, options);
        }



        /// <summary>
        /// Disables the specified user.
        /// 
        ///  
        /// <para>
        /// Calling this action requires developer credentials.
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
        public virtual Task<AdminDisableUserResponse> AdminDisableUserAsync(AdminDisableUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminDisableUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminDisableUserResponseUnmarshaller.Instance;

            return InvokeAsync<AdminDisableUserResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AdminEnableUser

        internal virtual AdminEnableUserResponse AdminEnableUser(AdminEnableUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminEnableUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminEnableUserResponseUnmarshaller.Instance;

            return Invoke<AdminEnableUserResponse>(request, options);
        }



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
        public virtual Task<AdminEnableUserResponse> AdminEnableUserAsync(AdminEnableUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminEnableUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminEnableUserResponseUnmarshaller.Instance;

            return InvokeAsync<AdminEnableUserResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AdminForgetDevice

        internal virtual AdminForgetDeviceResponse AdminForgetDevice(AdminForgetDeviceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminForgetDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminForgetDeviceResponseUnmarshaller.Instance;

            return Invoke<AdminForgetDeviceResponse>(request, options);
        }



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
        public virtual Task<AdminForgetDeviceResponse> AdminForgetDeviceAsync(AdminForgetDeviceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminForgetDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminForgetDeviceResponseUnmarshaller.Instance;

            return InvokeAsync<AdminForgetDeviceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AdminGetDevice

        internal virtual AdminGetDeviceResponse AdminGetDevice(AdminGetDeviceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminGetDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminGetDeviceResponseUnmarshaller.Instance;

            return Invoke<AdminGetDeviceResponse>(request, options);
        }



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
        public virtual Task<AdminGetDeviceResponse> AdminGetDeviceAsync(AdminGetDeviceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminGetDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminGetDeviceResponseUnmarshaller.Instance;

            return InvokeAsync<AdminGetDeviceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AdminGetUser

        internal virtual AdminGetUserResponse AdminGetUser(AdminGetUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminGetUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminGetUserResponseUnmarshaller.Instance;

            return Invoke<AdminGetUserResponse>(request, options);
        }



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
        public virtual Task<AdminGetUserResponse> AdminGetUserAsync(AdminGetUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminGetUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminGetUserResponseUnmarshaller.Instance;

            return InvokeAsync<AdminGetUserResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AdminInitiateAuth

        internal virtual AdminInitiateAuthResponse AdminInitiateAuth(AdminInitiateAuthRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminInitiateAuthRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminInitiateAuthResponseUnmarshaller.Instance;

            return Invoke<AdminInitiateAuthResponse>(request, options);
        }



        /// <summary>
        /// Initiates the authentication flow, as an administrator.
        /// 
        ///  
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
        public virtual Task<AdminInitiateAuthResponse> AdminInitiateAuthAsync(AdminInitiateAuthRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminInitiateAuthRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminInitiateAuthResponseUnmarshaller.Instance;

            return InvokeAsync<AdminInitiateAuthResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AdminLinkProviderForUser

        internal virtual AdminLinkProviderForUserResponse AdminLinkProviderForUser(AdminLinkProviderForUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminLinkProviderForUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminLinkProviderForUserResponseUnmarshaller.Instance;

            return Invoke<AdminLinkProviderForUserResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<AdminLinkProviderForUserResponse> AdminLinkProviderForUserAsync(AdminLinkProviderForUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminLinkProviderForUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminLinkProviderForUserResponseUnmarshaller.Instance;

            return InvokeAsync<AdminLinkProviderForUserResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AdminListDevices

        internal virtual AdminListDevicesResponse AdminListDevices(AdminListDevicesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminListDevicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminListDevicesResponseUnmarshaller.Instance;

            return Invoke<AdminListDevicesResponse>(request, options);
        }



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
        public virtual Task<AdminListDevicesResponse> AdminListDevicesAsync(AdminListDevicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminListDevicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminListDevicesResponseUnmarshaller.Instance;

            return InvokeAsync<AdminListDevicesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AdminListGroupsForUser

        internal virtual AdminListGroupsForUserResponse AdminListGroupsForUser(AdminListGroupsForUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminListGroupsForUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminListGroupsForUserResponseUnmarshaller.Instance;

            return Invoke<AdminListGroupsForUserResponse>(request, options);
        }



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
        public virtual Task<AdminListGroupsForUserResponse> AdminListGroupsForUserAsync(AdminListGroupsForUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminListGroupsForUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminListGroupsForUserResponseUnmarshaller.Instance;

            return InvokeAsync<AdminListGroupsForUserResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AdminListUserAuthEvents

        internal virtual AdminListUserAuthEventsResponse AdminListUserAuthEvents(AdminListUserAuthEventsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminListUserAuthEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminListUserAuthEventsResponseUnmarshaller.Instance;

            return Invoke<AdminListUserAuthEventsResponse>(request, options);
        }



        /// <summary>
        /// Lists a history of user activity and any risks detected as part of Amazon Cognito
        /// advanced security.
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
        public virtual Task<AdminListUserAuthEventsResponse> AdminListUserAuthEventsAsync(AdminListUserAuthEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminListUserAuthEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminListUserAuthEventsResponseUnmarshaller.Instance;

            return InvokeAsync<AdminListUserAuthEventsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AdminRemoveUserFromGroup

        internal virtual AdminRemoveUserFromGroupResponse AdminRemoveUserFromGroup(AdminRemoveUserFromGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminRemoveUserFromGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminRemoveUserFromGroupResponseUnmarshaller.Instance;

            return Invoke<AdminRemoveUserFromGroupResponse>(request, options);
        }



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
        public virtual Task<AdminRemoveUserFromGroupResponse> AdminRemoveUserFromGroupAsync(AdminRemoveUserFromGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminRemoveUserFromGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminRemoveUserFromGroupResponseUnmarshaller.Instance;

            return InvokeAsync<AdminRemoveUserFromGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AdminResetUserPassword

        internal virtual AdminResetUserPasswordResponse AdminResetUserPassword(AdminResetUserPasswordRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminResetUserPasswordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminResetUserPasswordResponseUnmarshaller.Instance;

            return Invoke<AdminResetUserPasswordResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<AdminResetUserPasswordResponse> AdminResetUserPasswordAsync(AdminResetUserPasswordRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminResetUserPasswordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminResetUserPasswordResponseUnmarshaller.Instance;

            return InvokeAsync<AdminResetUserPasswordResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AdminRespondToAuthChallenge

        internal virtual AdminRespondToAuthChallengeResponse AdminRespondToAuthChallenge(AdminRespondToAuthChallengeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminRespondToAuthChallengeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminRespondToAuthChallengeResponseUnmarshaller.Instance;

            return Invoke<AdminRespondToAuthChallengeResponse>(request, options);
        }



        /// <summary>
        /// Responds to an authentication challenge, as an administrator.
        /// 
        ///  
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
        public virtual Task<AdminRespondToAuthChallengeResponse> AdminRespondToAuthChallengeAsync(AdminRespondToAuthChallengeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminRespondToAuthChallengeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminRespondToAuthChallengeResponseUnmarshaller.Instance;

            return InvokeAsync<AdminRespondToAuthChallengeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AdminSetUserMFAPreference

        internal virtual AdminSetUserMFAPreferenceResponse AdminSetUserMFAPreference(AdminSetUserMFAPreferenceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminSetUserMFAPreferenceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminSetUserMFAPreferenceResponseUnmarshaller.Instance;

            return Invoke<AdminSetUserMFAPreferenceResponse>(request, options);
        }



        /// <summary>
        /// Sets the user's multi-factor authentication (MFA) preference, including which MFA
        /// options are enabled and if any are preferred. Only one factor can be set as preferred.
        /// The preferred MFA factor will be used to authenticate a user if multiple factors are
        /// enabled. If multiple options are enabled and no preference is set, a challenge to
        /// choose an MFA option will be returned during sign in.
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
        public virtual Task<AdminSetUserMFAPreferenceResponse> AdminSetUserMFAPreferenceAsync(AdminSetUserMFAPreferenceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminSetUserMFAPreferenceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminSetUserMFAPreferenceResponseUnmarshaller.Instance;

            return InvokeAsync<AdminSetUserMFAPreferenceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AdminSetUserPassword

        internal virtual AdminSetUserPasswordResponse AdminSetUserPassword(AdminSetUserPasswordRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminSetUserPasswordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminSetUserPasswordResponseUnmarshaller.Instance;

            return Invoke<AdminSetUserPasswordResponse>(request, options);
        }



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
        public virtual Task<AdminSetUserPasswordResponse> AdminSetUserPasswordAsync(AdminSetUserPasswordRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminSetUserPasswordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminSetUserPasswordResponseUnmarshaller.Instance;

            return InvokeAsync<AdminSetUserPasswordResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AdminSetUserSettings

        internal virtual AdminSetUserSettingsResponse AdminSetUserSettings(AdminSetUserSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminSetUserSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminSetUserSettingsResponseUnmarshaller.Instance;

            return Invoke<AdminSetUserSettingsResponse>(request, options);
        }



        /// <summary>
        /// <i>This action is no longer supported.</i> You can use it to configure only SMS MFA.
        /// You can't use it to configure TOTP software token MFA. To configure either type of
        /// MFA, use <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_AdminSetUserMFAPreference.html">AdminSetUserMFAPreference</a>
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
        public virtual Task<AdminSetUserSettingsResponse> AdminSetUserSettingsAsync(AdminSetUserSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminSetUserSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminSetUserSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<AdminSetUserSettingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AdminUpdateAuthEventFeedback

        internal virtual AdminUpdateAuthEventFeedbackResponse AdminUpdateAuthEventFeedback(AdminUpdateAuthEventFeedbackRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminUpdateAuthEventFeedbackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminUpdateAuthEventFeedbackResponseUnmarshaller.Instance;

            return Invoke<AdminUpdateAuthEventFeedbackResponse>(request, options);
        }



        /// <summary>
        /// Provides feedback for an authentication event as to whether it was from a valid user.
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
        public virtual Task<AdminUpdateAuthEventFeedbackResponse> AdminUpdateAuthEventFeedbackAsync(AdminUpdateAuthEventFeedbackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminUpdateAuthEventFeedbackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminUpdateAuthEventFeedbackResponseUnmarshaller.Instance;

            return InvokeAsync<AdminUpdateAuthEventFeedbackResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AdminUpdateDeviceStatus

        internal virtual AdminUpdateDeviceStatusResponse AdminUpdateDeviceStatus(AdminUpdateDeviceStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminUpdateDeviceStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminUpdateDeviceStatusResponseUnmarshaller.Instance;

            return Invoke<AdminUpdateDeviceStatusResponse>(request, options);
        }



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
        public virtual Task<AdminUpdateDeviceStatusResponse> AdminUpdateDeviceStatusAsync(AdminUpdateDeviceStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminUpdateDeviceStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminUpdateDeviceStatusResponseUnmarshaller.Instance;

            return InvokeAsync<AdminUpdateDeviceStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AdminUpdateUserAttributes

        internal virtual AdminUpdateUserAttributesResponse AdminUpdateUserAttributes(AdminUpdateUserAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminUpdateUserAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminUpdateUserAttributesResponseUnmarshaller.Instance;

            return Invoke<AdminUpdateUserAttributesResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<AdminUpdateUserAttributesResponse> AdminUpdateUserAttributesAsync(AdminUpdateUserAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminUpdateUserAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminUpdateUserAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<AdminUpdateUserAttributesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AdminUserGlobalSignOut

        internal virtual AdminUserGlobalSignOutResponse AdminUserGlobalSignOut(AdminUserGlobalSignOutRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminUserGlobalSignOutRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminUserGlobalSignOutResponseUnmarshaller.Instance;

            return Invoke<AdminUserGlobalSignOutResponse>(request, options);
        }



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
        public virtual Task<AdminUserGlobalSignOutResponse> AdminUserGlobalSignOutAsync(AdminUserGlobalSignOutRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminUserGlobalSignOutRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminUserGlobalSignOutResponseUnmarshaller.Instance;

            return InvokeAsync<AdminUserGlobalSignOutResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateSoftwareToken

        internal virtual AssociateSoftwareTokenResponse AssociateSoftwareToken(AssociateSoftwareTokenRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateSoftwareTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateSoftwareTokenResponseUnmarshaller.Instance;

            return Invoke<AssociateSoftwareTokenResponse>(request, options);
        }



        /// <summary>
        /// Returns a unique generated shared secret key code for the user account. The request
        /// takes an access token or a session string, but not both.
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
        public virtual Task<AssociateSoftwareTokenResponse> AssociateSoftwareTokenAsync(AssociateSoftwareTokenRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateSoftwareTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateSoftwareTokenResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateSoftwareTokenResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ChangePassword

        internal virtual ChangePasswordResponse ChangePassword(ChangePasswordRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ChangePasswordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ChangePasswordResponseUnmarshaller.Instance;

            return Invoke<ChangePasswordResponse>(request, options);
        }



        /// <summary>
        /// Changes the password for a specified user in a user pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ChangePassword service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ChangePasswordResponse> ChangePasswordAsync(ChangePasswordRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ChangePasswordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ChangePasswordResponseUnmarshaller.Instance;

            return InvokeAsync<ChangePasswordResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ConfirmDevice

        internal virtual ConfirmDeviceResponse ConfirmDevice(ConfirmDeviceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ConfirmDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConfirmDeviceResponseUnmarshaller.Instance;

            return Invoke<ConfirmDeviceResponse>(request, options);
        }



        /// <summary>
        /// Confirms tracking of the device. This API call is the call that begins device tracking.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConfirmDevice service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ConfirmDeviceResponse> ConfirmDeviceAsync(ConfirmDeviceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ConfirmDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConfirmDeviceResponseUnmarshaller.Instance;

            return InvokeAsync<ConfirmDeviceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ConfirmForgotPassword

        internal virtual ConfirmForgotPasswordResponse ConfirmForgotPassword(ConfirmForgotPasswordRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ConfirmForgotPasswordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConfirmForgotPasswordResponseUnmarshaller.Instance;

            return Invoke<ConfirmForgotPasswordResponse>(request, options);
        }



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
        public virtual Task<ConfirmForgotPasswordResponse> ConfirmForgotPasswordAsync(ConfirmForgotPasswordRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ConfirmForgotPasswordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConfirmForgotPasswordResponseUnmarshaller.Instance;

            return InvokeAsync<ConfirmForgotPasswordResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ConfirmSignUp

        internal virtual ConfirmSignUpResponse ConfirmSignUp(ConfirmSignUpRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ConfirmSignUpRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConfirmSignUpResponseUnmarshaller.Instance;

            return Invoke<ConfirmSignUpResponse>(request, options);
        }



        /// <summary>
        /// Confirms registration of a user and handles the existing alias from a previous user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConfirmSignUp service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ConfirmSignUpResponse> ConfirmSignUpAsync(ConfirmSignUpRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ConfirmSignUpRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConfirmSignUpResponseUnmarshaller.Instance;

            return InvokeAsync<ConfirmSignUpResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateGroup

        internal virtual CreateGroupResponse CreateGroup(CreateGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGroupResponseUnmarshaller.Instance;

            return Invoke<CreateGroupResponse>(request, options);
        }



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
        public virtual Task<CreateGroupResponse> CreateGroupAsync(CreateGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateIdentityProvider

        internal virtual CreateIdentityProviderResponse CreateIdentityProvider(CreateIdentityProviderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateIdentityProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIdentityProviderResponseUnmarshaller.Instance;

            return Invoke<CreateIdentityProviderResponse>(request, options);
        }



        /// <summary>
        /// Creates an identity provider for a user pool.
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
        public virtual Task<CreateIdentityProviderResponse> CreateIdentityProviderAsync(CreateIdentityProviderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateIdentityProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIdentityProviderResponseUnmarshaller.Instance;

            return InvokeAsync<CreateIdentityProviderResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateResourceServer

        internal virtual CreateResourceServerResponse CreateResourceServer(CreateResourceServerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateResourceServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateResourceServerResponseUnmarshaller.Instance;

            return Invoke<CreateResourceServerResponse>(request, options);
        }



        /// <summary>
        /// Creates a new OAuth2.0 resource server and defines custom scopes in it.
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
        public virtual Task<CreateResourceServerResponse> CreateResourceServerAsync(CreateResourceServerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateResourceServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateResourceServerResponseUnmarshaller.Instance;

            return InvokeAsync<CreateResourceServerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateUserImportJob

        internal virtual CreateUserImportJobResponse CreateUserImportJob(CreateUserImportJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateUserImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserImportJobResponseUnmarshaller.Instance;

            return Invoke<CreateUserImportJobResponse>(request, options);
        }



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
        public virtual Task<CreateUserImportJobResponse> CreateUserImportJobAsync(CreateUserImportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateUserImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserImportJobResponseUnmarshaller.Instance;

            return InvokeAsync<CreateUserImportJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateUserPool

        internal virtual CreateUserPoolResponse CreateUserPool(CreateUserPoolRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateUserPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserPoolResponseUnmarshaller.Instance;

            return Invoke<CreateUserPoolResponse>(request, options);
        }



        /// <summary>
        /// Creates a new Amazon Cognito user pool and sets the password policy for the pool.
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
        public virtual Task<CreateUserPoolResponse> CreateUserPoolAsync(CreateUserPoolRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateUserPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserPoolResponseUnmarshaller.Instance;

            return InvokeAsync<CreateUserPoolResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateUserPoolClient

        internal virtual CreateUserPoolClientResponse CreateUserPoolClient(CreateUserPoolClientRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateUserPoolClientRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserPoolClientResponseUnmarshaller.Instance;

            return Invoke<CreateUserPoolClientResponse>(request, options);
        }



        /// <summary>
        /// Creates the user pool client.
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
        public virtual Task<CreateUserPoolClientResponse> CreateUserPoolClientAsync(CreateUserPoolClientRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateUserPoolClientRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserPoolClientResponseUnmarshaller.Instance;

            return InvokeAsync<CreateUserPoolClientResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateUserPoolDomain

        internal virtual CreateUserPoolDomainResponse CreateUserPoolDomain(CreateUserPoolDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateUserPoolDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserPoolDomainResponseUnmarshaller.Instance;

            return Invoke<CreateUserPoolDomainResponse>(request, options);
        }



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
        public virtual Task<CreateUserPoolDomainResponse> CreateUserPoolDomainAsync(CreateUserPoolDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateUserPoolDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserPoolDomainResponseUnmarshaller.Instance;

            return InvokeAsync<CreateUserPoolDomainResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteGroup

        internal virtual DeleteGroupResponse DeleteGroup(DeleteGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteGroupResponse>(request, options);
        }



        /// <summary>
        /// Deletes a group. Currently only groups with no members can be deleted.
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
        public virtual Task<DeleteGroupResponse> DeleteGroupAsync(DeleteGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteIdentityProvider

        internal virtual DeleteIdentityProviderResponse DeleteIdentityProvider(DeleteIdentityProviderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteIdentityProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIdentityProviderResponseUnmarshaller.Instance;

            return Invoke<DeleteIdentityProviderResponse>(request, options);
        }



        /// <summary>
        /// Deletes an identity provider for a user pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIdentityProvider service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteIdentityProviderResponse> DeleteIdentityProviderAsync(DeleteIdentityProviderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteIdentityProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIdentityProviderResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteIdentityProviderResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteResourceServer

        internal virtual DeleteResourceServerResponse DeleteResourceServer(DeleteResourceServerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResourceServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourceServerResponseUnmarshaller.Instance;

            return Invoke<DeleteResourceServerResponse>(request, options);
        }



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
        public virtual Task<DeleteResourceServerResponse> DeleteResourceServerAsync(DeleteResourceServerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResourceServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourceServerResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteResourceServerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteUser

        internal virtual DeleteUserResponse DeleteUser(DeleteUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserResponseUnmarshaller.Instance;

            return Invoke<DeleteUserResponse>(request, options);
        }



        /// <summary>
        /// Allows a user to delete himself or herself.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteUserResponse> DeleteUserAsync(DeleteUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteUserResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteUserAttributes

        internal virtual DeleteUserAttributesResponse DeleteUserAttributes(DeleteUserAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserAttributesResponseUnmarshaller.Instance;

            return Invoke<DeleteUserAttributesResponse>(request, options);
        }



        /// <summary>
        /// Deletes the attributes for a user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteUserAttributesResponse> DeleteUserAttributesAsync(DeleteUserAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteUserAttributesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteUserPool

        internal virtual DeleteUserPoolResponse DeleteUserPool(DeleteUserPoolRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserPoolResponseUnmarshaller.Instance;

            return Invoke<DeleteUserPoolResponse>(request, options);
        }



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
        public virtual Task<DeleteUserPoolResponse> DeleteUserPoolAsync(DeleteUserPoolRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserPoolResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteUserPoolResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteUserPoolClient

        internal virtual DeleteUserPoolClientResponse DeleteUserPoolClient(DeleteUserPoolClientRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserPoolClientRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserPoolClientResponseUnmarshaller.Instance;

            return Invoke<DeleteUserPoolClientResponse>(request, options);
        }



        /// <summary>
        /// Allows the developer to delete the user pool client.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserPoolClient service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteUserPoolClientResponse> DeleteUserPoolClientAsync(DeleteUserPoolClientRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserPoolClientRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserPoolClientResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteUserPoolClientResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteUserPoolDomain

        internal virtual DeleteUserPoolDomainResponse DeleteUserPoolDomain(DeleteUserPoolDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserPoolDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserPoolDomainResponseUnmarshaller.Instance;

            return Invoke<DeleteUserPoolDomainResponse>(request, options);
        }



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
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteUserPoolDomain">REST API Reference for DeleteUserPoolDomain Operation</seealso>
        public virtual Task<DeleteUserPoolDomainResponse> DeleteUserPoolDomainAsync(DeleteUserPoolDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserPoolDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserPoolDomainResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteUserPoolDomainResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeIdentityProvider

        internal virtual DescribeIdentityProviderResponse DescribeIdentityProvider(DescribeIdentityProviderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeIdentityProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeIdentityProviderResponseUnmarshaller.Instance;

            return Invoke<DescribeIdentityProviderResponse>(request, options);
        }



        /// <summary>
        /// Gets information about a specific identity provider.
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
        public virtual Task<DescribeIdentityProviderResponse> DescribeIdentityProviderAsync(DescribeIdentityProviderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeIdentityProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeIdentityProviderResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeIdentityProviderResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeResourceServer

        internal virtual DescribeResourceServerResponse DescribeResourceServer(DescribeResourceServerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeResourceServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeResourceServerResponseUnmarshaller.Instance;

            return Invoke<DescribeResourceServerResponse>(request, options);
        }



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
        public virtual Task<DescribeResourceServerResponse> DescribeResourceServerAsync(DescribeResourceServerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeResourceServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeResourceServerResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeResourceServerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeRiskConfiguration

        internal virtual DescribeRiskConfigurationResponse DescribeRiskConfiguration(DescribeRiskConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRiskConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRiskConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeRiskConfigurationResponse>(request, options);
        }



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
        public virtual Task<DescribeRiskConfigurationResponse> DescribeRiskConfigurationAsync(DescribeRiskConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRiskConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRiskConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeRiskConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeUserImportJob

        internal virtual DescribeUserImportJobResponse DescribeUserImportJob(DescribeUserImportJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeUserImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUserImportJobResponseUnmarshaller.Instance;

            return Invoke<DescribeUserImportJobResponse>(request, options);
        }



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
        public virtual Task<DescribeUserImportJobResponse> DescribeUserImportJobAsync(DescribeUserImportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeUserImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUserImportJobResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeUserImportJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeUserPool

        internal virtual DescribeUserPoolResponse DescribeUserPool(DescribeUserPoolRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeUserPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUserPoolResponseUnmarshaller.Instance;

            return Invoke<DescribeUserPoolResponse>(request, options);
        }



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
        public virtual Task<DescribeUserPoolResponse> DescribeUserPoolAsync(DescribeUserPoolRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeUserPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUserPoolResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeUserPoolResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeUserPoolClient

        internal virtual DescribeUserPoolClientResponse DescribeUserPoolClient(DescribeUserPoolClientRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeUserPoolClientRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUserPoolClientResponseUnmarshaller.Instance;

            return Invoke<DescribeUserPoolClientResponse>(request, options);
        }



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
        public virtual Task<DescribeUserPoolClientResponse> DescribeUserPoolClientAsync(DescribeUserPoolClientRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeUserPoolClientRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUserPoolClientResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeUserPoolClientResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeUserPoolDomain

        internal virtual DescribeUserPoolDomainResponse DescribeUserPoolDomain(DescribeUserPoolDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeUserPoolDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUserPoolDomainResponseUnmarshaller.Instance;

            return Invoke<DescribeUserPoolDomainResponse>(request, options);
        }



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
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeUserPoolDomain">REST API Reference for DescribeUserPoolDomain Operation</seealso>
        public virtual Task<DescribeUserPoolDomainResponse> DescribeUserPoolDomainAsync(DescribeUserPoolDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeUserPoolDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUserPoolDomainResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeUserPoolDomainResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ForgetDevice

        internal virtual ForgetDeviceResponse ForgetDevice(ForgetDeviceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ForgetDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ForgetDeviceResponseUnmarshaller.Instance;

            return Invoke<ForgetDeviceResponse>(request, options);
        }



        /// <summary>
        /// Forgets the specified device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ForgetDevice service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ForgetDeviceResponse> ForgetDeviceAsync(ForgetDeviceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ForgetDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ForgetDeviceResponseUnmarshaller.Instance;

            return InvokeAsync<ForgetDeviceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ForgotPassword

        internal virtual ForgotPasswordResponse ForgotPassword(ForgotPasswordRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ForgotPasswordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ForgotPasswordResponseUnmarshaller.Instance;

            return Invoke<ForgotPasswordResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ForgotPasswordResponse> ForgotPasswordAsync(ForgotPasswordRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ForgotPasswordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ForgotPasswordResponseUnmarshaller.Instance;

            return InvokeAsync<ForgotPasswordResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetCSVHeader

        internal virtual GetCSVHeaderResponse GetCSVHeader(GetCSVHeaderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCSVHeaderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCSVHeaderResponseUnmarshaller.Instance;

            return Invoke<GetCSVHeaderResponse>(request, options);
        }



        /// <summary>
        /// Gets the header information for the .csv file to be used as input for the user import
        /// job.
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
        public virtual Task<GetCSVHeaderResponse> GetCSVHeaderAsync(GetCSVHeaderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCSVHeaderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCSVHeaderResponseUnmarshaller.Instance;

            return InvokeAsync<GetCSVHeaderResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDevice

        internal virtual GetDeviceResponse GetDevice(GetDeviceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeviceResponseUnmarshaller.Instance;

            return Invoke<GetDeviceResponse>(request, options);
        }



        /// <summary>
        /// Gets the device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDevice service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetDeviceResponse> GetDeviceAsync(GetDeviceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeviceResponseUnmarshaller.Instance;

            return InvokeAsync<GetDeviceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetGroup

        internal virtual GetGroupResponse GetGroup(GetGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGroupResponseUnmarshaller.Instance;

            return Invoke<GetGroupResponse>(request, options);
        }



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
        public virtual Task<GetGroupResponse> GetGroupAsync(GetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGroupResponseUnmarshaller.Instance;

            return InvokeAsync<GetGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetIdentityProviderByIdentifier

        internal virtual GetIdentityProviderByIdentifierResponse GetIdentityProviderByIdentifier(GetIdentityProviderByIdentifierRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIdentityProviderByIdentifierRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIdentityProviderByIdentifierResponseUnmarshaller.Instance;

            return Invoke<GetIdentityProviderByIdentifierResponse>(request, options);
        }



        /// <summary>
        /// Gets the specified identity provider.
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
        public virtual Task<GetIdentityProviderByIdentifierResponse> GetIdentityProviderByIdentifierAsync(GetIdentityProviderByIdentifierRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIdentityProviderByIdentifierRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIdentityProviderByIdentifierResponseUnmarshaller.Instance;

            return InvokeAsync<GetIdentityProviderByIdentifierResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSigningCertificate

        internal virtual GetSigningCertificateResponse GetSigningCertificate(GetSigningCertificateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSigningCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSigningCertificateResponseUnmarshaller.Instance;

            return Invoke<GetSigningCertificateResponse>(request, options);
        }



        /// <summary>
        /// This method takes a user pool ID, and returns the signing certificate.
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
        /// This exception is thrown when the Amazon Cognito service cannot find the requested
        /// resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetSigningCertificate">REST API Reference for GetSigningCertificate Operation</seealso>
        public virtual Task<GetSigningCertificateResponse> GetSigningCertificateAsync(GetSigningCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSigningCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSigningCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<GetSigningCertificateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetUICustomization

        internal virtual GetUICustomizationResponse GetUICustomization(GetUICustomizationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUICustomizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUICustomizationResponseUnmarshaller.Instance;

            return Invoke<GetUICustomizationResponse>(request, options);
        }



        /// <summary>
        /// Gets the UI Customization information for a particular app client's app UI, if there
        /// is something set. If nothing is set for the particular client, but there is an existing
        /// pool level customization (app <code>clientId</code> will be <code>ALL</code>), then
        /// that is returned. If nothing is present, then an empty shape is returned.
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
        public virtual Task<GetUICustomizationResponse> GetUICustomizationAsync(GetUICustomizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUICustomizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUICustomizationResponseUnmarshaller.Instance;

            return InvokeAsync<GetUICustomizationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetUser

        internal virtual GetUserResponse GetUser(GetUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUserResponseUnmarshaller.Instance;

            return Invoke<GetUserResponse>(request, options);
        }



        /// <summary>
        /// Gets the user attributes and metadata for a user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetUserResponse> GetUserAsync(GetUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUserResponseUnmarshaller.Instance;

            return InvokeAsync<GetUserResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetUserAttributeVerificationCode

        internal virtual GetUserAttributeVerificationCodeResponse GetUserAttributeVerificationCode(GetUserAttributeVerificationCodeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUserAttributeVerificationCodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUserAttributeVerificationCodeResponseUnmarshaller.Instance;

            return Invoke<GetUserAttributeVerificationCodeResponse>(request, options);
        }



        /// <summary>
        /// Gets the user attribute verification code for the specified attribute name.
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
        public virtual Task<GetUserAttributeVerificationCodeResponse> GetUserAttributeVerificationCodeAsync(GetUserAttributeVerificationCodeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUserAttributeVerificationCodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUserAttributeVerificationCodeResponseUnmarshaller.Instance;

            return InvokeAsync<GetUserAttributeVerificationCodeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetUserPoolMfaConfig

        internal virtual GetUserPoolMfaConfigResponse GetUserPoolMfaConfig(GetUserPoolMfaConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUserPoolMfaConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUserPoolMfaConfigResponseUnmarshaller.Instance;

            return Invoke<GetUserPoolMfaConfigResponse>(request, options);
        }



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
        public virtual Task<GetUserPoolMfaConfigResponse> GetUserPoolMfaConfigAsync(GetUserPoolMfaConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUserPoolMfaConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUserPoolMfaConfigResponseUnmarshaller.Instance;

            return InvokeAsync<GetUserPoolMfaConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GlobalSignOut

        internal virtual GlobalSignOutResponse GlobalSignOut(GlobalSignOutRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GlobalSignOutRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GlobalSignOutResponseUnmarshaller.Instance;

            return Invoke<GlobalSignOutResponse>(request, options);
        }



        /// <summary>
        /// Signs out users from all devices. It also invalidates all refresh tokens issued to
        /// a user. The user's current access and Id tokens remain valid until their expiry. Access
        /// and Id tokens expire one hour after they are issued.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GlobalSignOut service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GlobalSignOutResponse> GlobalSignOutAsync(GlobalSignOutRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GlobalSignOutRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GlobalSignOutResponseUnmarshaller.Instance;

            return InvokeAsync<GlobalSignOutResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  InitiateAuth

        internal virtual InitiateAuthResponse InitiateAuth(InitiateAuthRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = InitiateAuthRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InitiateAuthResponseUnmarshaller.Instance;

            return Invoke<InitiateAuthResponse>(request, options);
        }



        /// <summary>
        /// Initiates the authentication flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InitiateAuth service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<InitiateAuthResponse> InitiateAuthAsync(InitiateAuthRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = InitiateAuthRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InitiateAuthResponseUnmarshaller.Instance;

            return InvokeAsync<InitiateAuthResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDevices

        internal virtual ListDevicesResponse ListDevices(ListDevicesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDevicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDevicesResponseUnmarshaller.Instance;

            return Invoke<ListDevicesResponse>(request, options);
        }



        /// <summary>
        /// Lists the devices.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDevices service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListDevicesResponse> ListDevicesAsync(ListDevicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDevicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDevicesResponseUnmarshaller.Instance;

            return InvokeAsync<ListDevicesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListGroups

        internal virtual ListGroupsResponse ListGroups(ListGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGroupsResponseUnmarshaller.Instance;

            return Invoke<ListGroupsResponse>(request, options);
        }



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
        public virtual Task<ListGroupsResponse> ListGroupsAsync(ListGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<ListGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListIdentityProviders

        internal virtual ListIdentityProvidersResponse ListIdentityProviders(ListIdentityProvidersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIdentityProvidersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIdentityProvidersResponseUnmarshaller.Instance;

            return Invoke<ListIdentityProvidersResponse>(request, options);
        }



        /// <summary>
        /// Lists information about all identity providers for a user pool.
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
        public virtual Task<ListIdentityProvidersResponse> ListIdentityProvidersAsync(ListIdentityProvidersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIdentityProvidersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIdentityProvidersResponseUnmarshaller.Instance;

            return InvokeAsync<ListIdentityProvidersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListResourceServers

        internal virtual ListResourceServersResponse ListResourceServers(ListResourceServersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResourceServersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourceServersResponseUnmarshaller.Instance;

            return Invoke<ListResourceServersResponse>(request, options);
        }



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
        public virtual Task<ListResourceServersResponse> ListResourceServersAsync(ListResourceServersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResourceServersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourceServersResponseUnmarshaller.Instance;

            return InvokeAsync<ListResourceServersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }



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
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListUserImportJobs

        internal virtual ListUserImportJobsResponse ListUserImportJobs(ListUserImportJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUserImportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUserImportJobsResponseUnmarshaller.Instance;

            return Invoke<ListUserImportJobsResponse>(request, options);
        }



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
        public virtual Task<ListUserImportJobsResponse> ListUserImportJobsAsync(ListUserImportJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUserImportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUserImportJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListUserImportJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListUserPoolClients

        internal virtual ListUserPoolClientsResponse ListUserPoolClients(ListUserPoolClientsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUserPoolClientsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUserPoolClientsResponseUnmarshaller.Instance;

            return Invoke<ListUserPoolClientsResponse>(request, options);
        }



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
        public virtual Task<ListUserPoolClientsResponse> ListUserPoolClientsAsync(ListUserPoolClientsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUserPoolClientsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUserPoolClientsResponseUnmarshaller.Instance;

            return InvokeAsync<ListUserPoolClientsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListUserPools

        internal virtual ListUserPoolsResponse ListUserPools(ListUserPoolsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUserPoolsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUserPoolsResponseUnmarshaller.Instance;

            return Invoke<ListUserPoolsResponse>(request, options);
        }



        /// <summary>
        /// Lists the user pools associated with an AWS account.
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
        /// This exception is thrown when a user is not authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListUserPools">REST API Reference for ListUserPools Operation</seealso>
        public virtual Task<ListUserPoolsResponse> ListUserPoolsAsync(ListUserPoolsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUserPoolsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUserPoolsResponseUnmarshaller.Instance;

            return InvokeAsync<ListUserPoolsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListUsers

        internal virtual ListUsersResponse ListUsers(ListUsersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUsersResponseUnmarshaller.Instance;

            return Invoke<ListUsersResponse>(request, options);
        }



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
        public virtual Task<ListUsersResponse> ListUsersAsync(ListUsersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUsersResponseUnmarshaller.Instance;

            return InvokeAsync<ListUsersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListUsersInGroup

        internal virtual ListUsersInGroupResponse ListUsersInGroup(ListUsersInGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUsersInGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUsersInGroupResponseUnmarshaller.Instance;

            return Invoke<ListUsersInGroupResponse>(request, options);
        }



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
        public virtual Task<ListUsersInGroupResponse> ListUsersInGroupAsync(ListUsersInGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUsersInGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUsersInGroupResponseUnmarshaller.Instance;

            return InvokeAsync<ListUsersInGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ResendConfirmationCode

        internal virtual ResendConfirmationCodeResponse ResendConfirmationCode(ResendConfirmationCodeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResendConfirmationCodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResendConfirmationCodeResponseUnmarshaller.Instance;

            return Invoke<ResendConfirmationCodeResponse>(request, options);
        }



        /// <summary>
        /// Resends the confirmation (for confirmation of registration) to a specific user in
        /// the user pool.
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
        public virtual Task<ResendConfirmationCodeResponse> ResendConfirmationCodeAsync(ResendConfirmationCodeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResendConfirmationCodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResendConfirmationCodeResponseUnmarshaller.Instance;

            return InvokeAsync<ResendConfirmationCodeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RespondToAuthChallenge

        internal virtual RespondToAuthChallengeResponse RespondToAuthChallenge(RespondToAuthChallengeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RespondToAuthChallengeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RespondToAuthChallengeResponseUnmarshaller.Instance;

            return Invoke<RespondToAuthChallengeResponse>(request, options);
        }



        /// <summary>
        /// Responds to the authentication challenge.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RespondToAuthChallenge service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<RespondToAuthChallengeResponse> RespondToAuthChallengeAsync(RespondToAuthChallengeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RespondToAuthChallengeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RespondToAuthChallengeResponseUnmarshaller.Instance;

            return InvokeAsync<RespondToAuthChallengeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SetRiskConfiguration

        internal virtual SetRiskConfigurationResponse SetRiskConfiguration(SetRiskConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetRiskConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetRiskConfigurationResponseUnmarshaller.Instance;

            return Invoke<SetRiskConfigurationResponse>(request, options);
        }



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
        public virtual Task<SetRiskConfigurationResponse> SetRiskConfigurationAsync(SetRiskConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetRiskConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetRiskConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<SetRiskConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SetUICustomization

        internal virtual SetUICustomizationResponse SetUICustomization(SetUICustomizationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetUICustomizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetUICustomizationResponseUnmarshaller.Instance;

            return Invoke<SetUICustomizationResponse>(request, options);
        }



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
        public virtual Task<SetUICustomizationResponse> SetUICustomizationAsync(SetUICustomizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetUICustomizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetUICustomizationResponseUnmarshaller.Instance;

            return InvokeAsync<SetUICustomizationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SetUserMFAPreference

        internal virtual SetUserMFAPreferenceResponse SetUserMFAPreference(SetUserMFAPreferenceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetUserMFAPreferenceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetUserMFAPreferenceResponseUnmarshaller.Instance;

            return Invoke<SetUserMFAPreferenceResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<SetUserMFAPreferenceResponse> SetUserMFAPreferenceAsync(SetUserMFAPreferenceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetUserMFAPreferenceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetUserMFAPreferenceResponseUnmarshaller.Instance;

            return InvokeAsync<SetUserMFAPreferenceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SetUserPoolMfaConfig

        internal virtual SetUserPoolMfaConfigResponse SetUserPoolMfaConfig(SetUserPoolMfaConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetUserPoolMfaConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetUserPoolMfaConfigResponseUnmarshaller.Instance;

            return Invoke<SetUserPoolMfaConfigResponse>(request, options);
        }



        /// <summary>
        /// Set the user pool multi-factor authentication (MFA) configuration.
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
        public virtual Task<SetUserPoolMfaConfigResponse> SetUserPoolMfaConfigAsync(SetUserPoolMfaConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetUserPoolMfaConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetUserPoolMfaConfigResponseUnmarshaller.Instance;

            return InvokeAsync<SetUserPoolMfaConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SetUserSettings

        internal virtual SetUserSettingsResponse SetUserSettings(SetUserSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetUserSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetUserSettingsResponseUnmarshaller.Instance;

            return Invoke<SetUserSettingsResponse>(request, options);
        }



        /// <summary>
        /// <i>This action is no longer supported.</i> You can use it to configure only SMS MFA.
        /// You can't use it to configure TOTP software token MFA. To configure either type of
        /// MFA, use <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_SetUserMFAPreference.html">SetUserMFAPreference</a>
        /// instead.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetUserSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<SetUserSettingsResponse> SetUserSettingsAsync(SetUserSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetUserSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetUserSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<SetUserSettingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SignUp

        internal virtual SignUpResponse SignUp(SignUpRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SignUpRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SignUpResponseUnmarshaller.Instance;

            return Invoke<SignUpResponse>(request, options);
        }



        /// <summary>
        /// Registers the user in the specified user pool and creates a user name, password, and
        /// user attributes.
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
        public virtual Task<SignUpResponse> SignUpAsync(SignUpRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SignUpRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SignUpResponseUnmarshaller.Instance;

            return InvokeAsync<SignUpResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartUserImportJob

        internal virtual StartUserImportJobResponse StartUserImportJob(StartUserImportJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartUserImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartUserImportJobResponseUnmarshaller.Instance;

            return Invoke<StartUserImportJobResponse>(request, options);
        }



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
        public virtual Task<StartUserImportJobResponse> StartUserImportJobAsync(StartUserImportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartUserImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartUserImportJobResponseUnmarshaller.Instance;

            return InvokeAsync<StartUserImportJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopUserImportJob

        internal virtual StopUserImportJobResponse StopUserImportJob(StopUserImportJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopUserImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopUserImportJobResponseUnmarshaller.Instance;

            return Invoke<StopUserImportJobResponse>(request, options);
        }



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
        public virtual Task<StopUserImportJobResponse> StopUserImportJobAsync(StopUserImportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopUserImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopUserImportJobResponseUnmarshaller.Instance;

            return InvokeAsync<StopUserImportJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



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
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }



        /// <summary>
        /// Removes the specified tags from an Amazon Cognito user pool. You can use this action
        /// up to 5 times per second, per account
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
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateAuthEventFeedback

        internal virtual UpdateAuthEventFeedbackResponse UpdateAuthEventFeedback(UpdateAuthEventFeedbackRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAuthEventFeedbackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAuthEventFeedbackResponseUnmarshaller.Instance;

            return Invoke<UpdateAuthEventFeedbackResponse>(request, options);
        }



        /// <summary>
        /// Provides the feedback for an authentication event whether it was from a valid user
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
        public virtual Task<UpdateAuthEventFeedbackResponse> UpdateAuthEventFeedbackAsync(UpdateAuthEventFeedbackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAuthEventFeedbackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAuthEventFeedbackResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAuthEventFeedbackResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDeviceStatus

        internal virtual UpdateDeviceStatusResponse UpdateDeviceStatus(UpdateDeviceStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDeviceStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDeviceStatusResponseUnmarshaller.Instance;

            return Invoke<UpdateDeviceStatusResponse>(request, options);
        }



        /// <summary>
        /// Updates the device status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDeviceStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateDeviceStatusResponse> UpdateDeviceStatusAsync(UpdateDeviceStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDeviceStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDeviceStatusResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDeviceStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateGroup

        internal virtual UpdateGroupResponse UpdateGroup(UpdateGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateGroupResponse>(request, options);
        }



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
        public virtual Task<UpdateGroupResponse> UpdateGroupAsync(UpdateGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGroupResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateIdentityProvider

        internal virtual UpdateIdentityProviderResponse UpdateIdentityProvider(UpdateIdentityProviderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateIdentityProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIdentityProviderResponseUnmarshaller.Instance;

            return Invoke<UpdateIdentityProviderResponse>(request, options);
        }



        /// <summary>
        /// Updates identity provider information for a user pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIdentityProvider service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateIdentityProviderResponse> UpdateIdentityProviderAsync(UpdateIdentityProviderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateIdentityProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIdentityProviderResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateIdentityProviderResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateResourceServer

        internal virtual UpdateResourceServerResponse UpdateResourceServer(UpdateResourceServerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateResourceServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateResourceServerResponseUnmarshaller.Instance;

            return Invoke<UpdateResourceServerResponse>(request, options);
        }



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
        public virtual Task<UpdateResourceServerResponse> UpdateResourceServerAsync(UpdateResourceServerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateResourceServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateResourceServerResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateResourceServerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateUserAttributes

        internal virtual UpdateUserAttributesResponse UpdateUserAttributes(UpdateUserAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUserAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserAttributesResponseUnmarshaller.Instance;

            return Invoke<UpdateUserAttributesResponse>(request, options);
        }



        /// <summary>
        /// Allows a user to update a specific attribute (one at a time).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateUserAttributesResponse> UpdateUserAttributesAsync(UpdateUserAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUserAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateUserAttributesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateUserPool

        internal virtual UpdateUserPoolResponse UpdateUserPool(UpdateUserPoolRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUserPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserPoolResponseUnmarshaller.Instance;

            return Invoke<UpdateUserPoolResponse>(request, options);
        }



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
        public virtual Task<UpdateUserPoolResponse> UpdateUserPoolAsync(UpdateUserPoolRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUserPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserPoolResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateUserPoolResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateUserPoolClient

        internal virtual UpdateUserPoolClientResponse UpdateUserPoolClient(UpdateUserPoolClientRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUserPoolClientRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserPoolClientResponseUnmarshaller.Instance;

            return Invoke<UpdateUserPoolClientResponse>(request, options);
        }



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
        public virtual Task<UpdateUserPoolClientResponse> UpdateUserPoolClientAsync(UpdateUserPoolClientRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUserPoolClientRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserPoolClientResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateUserPoolClientResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateUserPoolDomain

        internal virtual UpdateUserPoolDomainResponse UpdateUserPoolDomain(UpdateUserPoolDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUserPoolDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserPoolDomainResponseUnmarshaller.Instance;

            return Invoke<UpdateUserPoolDomainResponse>(request, options);
        }



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
        public virtual Task<UpdateUserPoolDomainResponse> UpdateUserPoolDomainAsync(UpdateUserPoolDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUserPoolDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserPoolDomainResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateUserPoolDomainResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  VerifySoftwareToken

        internal virtual VerifySoftwareTokenResponse VerifySoftwareToken(VerifySoftwareTokenRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = VerifySoftwareTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = VerifySoftwareTokenResponseUnmarshaller.Instance;

            return Invoke<VerifySoftwareTokenResponse>(request, options);
        }



        /// <summary>
        /// Use this API to register a user's entered TOTP code and mark the user's software token
        /// MFA status as "verified" if successful. The request takes an access token or a session
        /// string, but not both.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the VerifySoftwareToken service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<VerifySoftwareTokenResponse> VerifySoftwareTokenAsync(VerifySoftwareTokenRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = VerifySoftwareTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = VerifySoftwareTokenResponseUnmarshaller.Instance;

            return InvokeAsync<VerifySoftwareTokenResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  VerifyUserAttribute

        internal virtual VerifyUserAttributeResponse VerifyUserAttribute(VerifyUserAttributeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = VerifyUserAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = VerifyUserAttributeResponseUnmarshaller.Instance;

            return Invoke<VerifyUserAttributeResponse>(request, options);
        }



        /// <summary>
        /// Verifies the specified user attributes in the user pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the VerifyUserAttribute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<VerifyUserAttributeResponse> VerifyUserAttributeAsync(VerifyUserAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = VerifyUserAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = VerifyUserAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<VerifyUserAttributeResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}