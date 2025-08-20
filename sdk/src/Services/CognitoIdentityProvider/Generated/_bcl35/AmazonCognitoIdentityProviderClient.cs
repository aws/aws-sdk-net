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
using System.Net;

using Amazon.CognitoIdentityProvider.Model;
using Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations;
using Amazon.CognitoIdentityProvider.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.CognitoIdentityProvider
{
    /// <summary>
    /// <para>Implementation for accessing CognitoIdentityProvider</para>
    ///
    /// With the Amazon Cognito user pools API, you can configure user pools and authenticate
    /// users. To authenticate users from third-party identity providers (IdPs) in this API,
    /// you can <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pools-identity-federation-consolidate-users.html">link
    /// IdP users to native user profiles</a>. Learn more about the authentication and authorization
    /// of federated users at <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pools-identity-federation.html">Adding
    /// user pool sign-in through a third party</a> and in the <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-userpools-server-contract-reference.html">User
    /// pool federation endpoints and managed login reference</a>.
    /// 
    ///  
    /// <para>
    /// This API reference provides detailed information about API operations and object types
    /// in Amazon Cognito.
    /// </para>
    ///  
    /// <para>
    /// Along with resource management operations, the Amazon Cognito user pools API includes
    /// classes of operations and authorization models for client-side and server-side authentication
    /// of users. You can interact with operations in the Amazon Cognito user pools API as
    /// any of the following subjects.
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// An administrator who wants to configure user pools, app clients, users, groups, or
    /// other user pool functions.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A server-side app, like a web application, that wants to use its Amazon Web Services
    /// privileges to manage, authenticate, or authorize a user.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A client-side app, like a mobile app, that wants to make unauthenticated requests
    /// to manage, authenticate, or authorize a user.
    /// </para>
    ///  </li> </ol> 
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/authentication-flows-public-server-side.html#user-pools-API-operations">Understanding
    /// API, OIDC, and managed login pages authentication</a> in the <i>Amazon Cognito Developer
    /// Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// With your Amazon Web Services SDK, you can build the logic to support operational
    /// flows in every use case for this API. You can also make direct REST API requests to
    /// <a href="https://docs.aws.amazon.com/general/latest/gr/cognito_identity.html#cognito_identity_your_user_pools_region">Amazon
    /// Cognito user pools service endpoints</a>. The following links can get you started
    /// with the <c>CognitoIdentityProvider</c> client in supported Amazon Web Services SDKs.
    /// </para>
    ///  
    /// <para>
    /// To get started with an Amazon Web Services SDK, see <a href="http://aws.amazon.com/developer/tools/">Tools
    /// to Build on Amazon Web Services</a>. For example actions and scenarios, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/service_code_examples_cognito-identity-provider.html">Code
    /// examples for Amazon Cognito Identity Provider using Amazon Web Services SDKs</a>.
    /// </para>
    /// </summary>
    public partial class AmazonCognitoIdentityProviderClient : AmazonServiceClient, IAmazonCognitoIdentityProvider
    {
        private static IServiceMetadata serviceMetadata = new AmazonCognitoIdentityProviderMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
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
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
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

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonCognitoIdentityProviderEndpointResolver());
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

        /// <summary>
        /// Adds additional user attributes to the user pool schema. Custom attributes can be
        /// mutable or immutable and have a <c>custom:</c> or <c>dev:</c> prefix. For more information,
        /// see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pool-settings-attributes.html#user-pool-settings-custom-attributes">Custom
        /// attributes</a>.
        /// 
        ///  <note> 
        /// <para>
        /// Amazon Cognito evaluates Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you must use IAM credentials to authorize
        /// requests, and you must grant yourself the corresponding IAM permission in a policy.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
        /// Amazon Web Services API Requests</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a> 
        /// </para>
        ///  </li> </ul> </note>
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
        public virtual AddCustomAttributesResponse AddCustomAttributes(AddCustomAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddCustomAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddCustomAttributesResponseUnmarshaller.Instance;

            return Invoke<AddCustomAttributesResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AddCustomAttributes">REST API Reference for AddCustomAttributes Operation</seealso>
        public virtual IAsyncResult BeginAddCustomAttributes(AddCustomAttributesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddCustomAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddCustomAttributesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AddCustomAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddCustomAttributes.</param>
        /// 
        /// <returns>Returns a  AddCustomAttributesResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AddCustomAttributes">REST API Reference for AddCustomAttributes Operation</seealso>
        public virtual AddCustomAttributesResponse EndAddCustomAttributes(IAsyncResult asyncResult)
        {
            return EndInvoke<AddCustomAttributesResponse>(asyncResult);
        }

        #endregion
        
        #region  AdminAddUserToGroup

        /// <summary>
        /// Adds a user to a group. A user who is in a group can present a preferred-role claim
        /// to an identity pool, and populates a <c>cognito:groups</c> claim to their access and
        /// identity tokens.
        /// 
        ///  <note> 
        /// <para>
        /// Amazon Cognito evaluates Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you must use IAM credentials to authorize
        /// requests, and you must grant yourself the corresponding IAM permission in a policy.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
        /// Amazon Web Services API Requests</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a> 
        /// </para>
        ///  </li> </ul> </note>
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
        public virtual AdminAddUserToGroupResponse AdminAddUserToGroup(AdminAddUserToGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminAddUserToGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminAddUserToGroupResponseUnmarshaller.Instance;

            return Invoke<AdminAddUserToGroupResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginAdminAddUserToGroup(AdminAddUserToGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminAddUserToGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminAddUserToGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AdminAddUserToGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAdminAddUserToGroup.</param>
        /// 
        /// <returns>Returns a  AdminAddUserToGroupResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminAddUserToGroup">REST API Reference for AdminAddUserToGroup Operation</seealso>
        public virtual AdminAddUserToGroupResponse EndAdminAddUserToGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<AdminAddUserToGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  AdminConfirmSignUp

        /// <summary>
        /// Confirms user sign-up as an administrator. 
        /// 
        ///  
        /// <para>
        /// This request sets a user account active in a user pool that <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/signing-up-users-in-your-app.html#signing-up-users-in-your-app-and-confirming-them-as-admin">requires
        /// confirmation of new user accounts</a> before they can sign in. You can configure your
        /// user pool to not send confirmation codes to new users and instead confirm them with
        /// this API operation on the back end.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon Cognito evaluates Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you must use IAM credentials to authorize
        /// requests, and you must grant yourself the corresponding IAM permission in a policy.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
        /// Amazon Web Services API Requests</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a> 
        /// </para>
        ///  </li> </ul> </note> 
        /// <para>
        /// To configure your user pool to require administrative confirmation of users, set <c>AllowAdminCreateUserOnly</c>
        /// to <c>true</c> in a <c>CreateUserPool</c> or <c>UpdateUserPool</c> request.
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
        public virtual AdminConfirmSignUpResponse AdminConfirmSignUp(AdminConfirmSignUpRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminConfirmSignUpRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminConfirmSignUpResponseUnmarshaller.Instance;

            return Invoke<AdminConfirmSignUpResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminConfirmSignUp">REST API Reference for AdminConfirmSignUp Operation</seealso>
        public virtual IAsyncResult BeginAdminConfirmSignUp(AdminConfirmSignUpRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminConfirmSignUpRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminConfirmSignUpResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AdminConfirmSignUp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAdminConfirmSignUp.</param>
        /// 
        /// <returns>Returns a  AdminConfirmSignUpResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminConfirmSignUp">REST API Reference for AdminConfirmSignUp Operation</seealso>
        public virtual AdminConfirmSignUpResponse EndAdminConfirmSignUp(IAsyncResult asyncResult)
        {
            return EndInvoke<AdminConfirmSignUpResponse>(asyncResult);
        }

        #endregion
        
        #region  AdminCreateUser

        /// <summary>
        /// Creates a new user in the specified user pool.
        /// 
        ///  
        /// <para>
        /// If <c>MessageAction</c> isn't set, the default is to send a welcome message via email
        /// or phone (SMS).
        /// </para>
        ///  
        /// <para>
        /// This message is based on a template that you configured in your call to create or
        /// update a user pool. This template includes your custom sign-up instructions and placeholders
        /// for user name and temporary password.
        /// </para>
        ///  
        /// <para>
        /// Alternatively, you can call <c>AdminCreateUser</c> with <c>SUPPRESS</c> for the <c>MessageAction</c>
        /// parameter, and Amazon Cognito won't send any email. 
        /// </para>
        ///  
        /// <para>
        /// In either case, if the user has a password, they will be in the <c>FORCE_CHANGE_PASSWORD</c>
        /// state until they sign in and set their password. Your invitation message template
        /// must have the <c>{####}</c> password placeholder if your users have passwords. If
        /// your template doesn't have this placeholder, Amazon Cognito doesn't deliver the invitation
        /// message. In this case, you must update your message template and resend the password
        /// with a new <c>AdminCreateUser</c> request with a <c>MessageAction</c> value of <c>RESEND</c>.
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
        /// Services service, Amazon Simple Notification Service might place your account in the
        /// SMS sandbox. In <i> <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-sms-sandbox.html">sandbox
        /// mode</a> </i>, you can send messages only to verified phone numbers. After you test
        /// your app while in the sandbox environment, you can move out of the sandbox and into
        /// production. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pool-sms-settings.html">
        /// SMS message settings for Amazon Cognito user pools</a> in the <i>Amazon Cognito Developer
        /// Guide</i>.
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// Amazon Cognito evaluates Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you must use IAM credentials to authorize
        /// requests, and you must grant yourself the corresponding IAM permission in a policy.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
        /// Amazon Web Services API Requests</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a> 
        /// </para>
        ///  </li> </ul> </note>
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
        /// for SMS configuration. This can happen if you don't trust <c>cognito-idp.amazonaws.com</c>
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
        public virtual AdminCreateUserResponse AdminCreateUser(AdminCreateUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminCreateUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminCreateUserResponseUnmarshaller.Instance;

            return Invoke<AdminCreateUserResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginAdminCreateUser(AdminCreateUserRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminCreateUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminCreateUserResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AdminCreateUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAdminCreateUser.</param>
        /// 
        /// <returns>Returns a  AdminCreateUserResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminCreateUser">REST API Reference for AdminCreateUser Operation</seealso>
        public virtual AdminCreateUserResponse EndAdminCreateUser(IAsyncResult asyncResult)
        {
            return EndInvoke<AdminCreateUserResponse>(asyncResult);
        }

        #endregion
        
        #region  AdminDeleteUser

        /// <summary>
        /// Deletes a user profile in your user pool.
        /// 
        ///  <note> 
        /// <para>
        /// Amazon Cognito evaluates Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you must use IAM credentials to authorize
        /// requests, and you must grant yourself the corresponding IAM permission in a policy.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
        /// Amazon Web Services API Requests</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a> 
        /// </para>
        ///  </li> </ul> </note>
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
        public virtual AdminDeleteUserResponse AdminDeleteUser(AdminDeleteUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminDeleteUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminDeleteUserResponseUnmarshaller.Instance;

            return Invoke<AdminDeleteUserResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminDeleteUser">REST API Reference for AdminDeleteUser Operation</seealso>
        public virtual IAsyncResult BeginAdminDeleteUser(AdminDeleteUserRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminDeleteUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminDeleteUserResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AdminDeleteUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAdminDeleteUser.</param>
        /// 
        /// <returns>Returns a  AdminDeleteUserResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminDeleteUser">REST API Reference for AdminDeleteUser Operation</seealso>
        public virtual AdminDeleteUserResponse EndAdminDeleteUser(IAsyncResult asyncResult)
        {
            return EndInvoke<AdminDeleteUserResponse>(asyncResult);
        }

        #endregion
        
        #region  AdminDeleteUserAttributes

        /// <summary>
        /// Deletes attribute values from a user. This operation doesn't affect tokens for existing
        /// user sessions. The next ID token that the user receives will no longer have the deleted
        /// attributes.
        /// 
        ///  <note> 
        /// <para>
        /// Amazon Cognito evaluates Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you must use IAM credentials to authorize
        /// requests, and you must grant yourself the corresponding IAM permission in a policy.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
        /// Amazon Web Services API Requests</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a> 
        /// </para>
        ///  </li> </ul> </note>
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
        public virtual AdminDeleteUserAttributesResponse AdminDeleteUserAttributes(AdminDeleteUserAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminDeleteUserAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminDeleteUserAttributesResponseUnmarshaller.Instance;

            return Invoke<AdminDeleteUserAttributesResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminDeleteUserAttributes">REST API Reference for AdminDeleteUserAttributes Operation</seealso>
        public virtual IAsyncResult BeginAdminDeleteUserAttributes(AdminDeleteUserAttributesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminDeleteUserAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminDeleteUserAttributesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AdminDeleteUserAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAdminDeleteUserAttributes.</param>
        /// 
        /// <returns>Returns a  AdminDeleteUserAttributesResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminDeleteUserAttributes">REST API Reference for AdminDeleteUserAttributes Operation</seealso>
        public virtual AdminDeleteUserAttributesResponse EndAdminDeleteUserAttributes(IAsyncResult asyncResult)
        {
            return EndInvoke<AdminDeleteUserAttributesResponse>(asyncResult);
        }

        #endregion
        
        #region  AdminDisableProviderForUser

        /// <summary>
        /// Prevents the user from signing in with the specified external (SAML or social) identity
        /// provider (IdP). If the user that you want to deactivate is a Amazon Cognito user pools
        /// native username + password user, they can't use their password to sign in. If the
        /// user to deactivate is a linked external IdP user, any link between that user and an
        /// existing user is removed. When the external user signs in again, and the user is no
        /// longer attached to the previously linked <c>DestinationUser</c>, the user must create
        /// a new user account.
        /// 
        ///  
        /// <para>
        /// The value of <c>ProviderName</c> must match the name of a user pool IdP.
        /// </para>
        ///  
        /// <para>
        /// To deactivate a local user, set <c>ProviderName</c> to <c>Cognito</c> and the <c>ProviderAttributeName</c>
        /// to <c>Cognito_Subject</c>. The <c>ProviderAttributeValue</c> must be user's local
        /// username.
        /// </para>
        ///  
        /// <para>
        /// The <c>ProviderAttributeName</c> must always be <c>Cognito_Subject</c> for social
        /// IdPs. The <c>ProviderAttributeValue</c> must always be the exact subject that was
        /// used when the user was originally linked as a source user.
        /// </para>
        ///  
        /// <para>
        /// For de-linking a SAML identity, there are two scenarios. If the linked identity has
        /// not yet been used to sign in, the <c>ProviderAttributeName</c> and <c>ProviderAttributeValue</c>
        /// must be the same values that were used for the <c>SourceUser</c> when the identities
        /// were originally linked using <c> AdminLinkProviderForUser</c> call. This is also true
        /// if the linking was done with <c>ProviderAttributeName</c> set to <c>Cognito_Subject</c>.
        /// If the user has already signed in, the <c>ProviderAttributeName</c> must be <c>Cognito_Subject</c>
        /// and <c>ProviderAttributeValue</c> must be the <c>NameID</c> from their SAML assertion.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon Cognito evaluates Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you must use IAM credentials to authorize
        /// requests, and you must grant yourself the corresponding IAM permission in a policy.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
        /// Amazon Web Services API Requests</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a> 
        /// </para>
        ///  </li> </ul> </note>
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
        public virtual AdminDisableProviderForUserResponse AdminDisableProviderForUser(AdminDisableProviderForUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminDisableProviderForUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminDisableProviderForUserResponseUnmarshaller.Instance;

            return Invoke<AdminDisableProviderForUserResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginAdminDisableProviderForUser(AdminDisableProviderForUserRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminDisableProviderForUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminDisableProviderForUserResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AdminDisableProviderForUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAdminDisableProviderForUser.</param>
        /// 
        /// <returns>Returns a  AdminDisableProviderForUserResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminDisableProviderForUser">REST API Reference for AdminDisableProviderForUser Operation</seealso>
        public virtual AdminDisableProviderForUserResponse EndAdminDisableProviderForUser(IAsyncResult asyncResult)
        {
            return EndInvoke<AdminDisableProviderForUserResponse>(asyncResult);
        }

        #endregion
        
        #region  AdminDisableUser

        /// <summary>
        /// Deactivates a user profile and revokes all access tokens for the user. A deactivated
        /// user can't sign in, but still appears in the responses to <c>ListUsers</c> API requests.
        /// 
        ///  <note> 
        /// <para>
        /// Amazon Cognito evaluates Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you must use IAM credentials to authorize
        /// requests, and you must grant yourself the corresponding IAM permission in a policy.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
        /// Amazon Web Services API Requests</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a> 
        /// </para>
        ///  </li> </ul> </note>
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
        public virtual AdminDisableUserResponse AdminDisableUser(AdminDisableUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminDisableUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminDisableUserResponseUnmarshaller.Instance;

            return Invoke<AdminDisableUserResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminDisableUser">REST API Reference for AdminDisableUser Operation</seealso>
        public virtual IAsyncResult BeginAdminDisableUser(AdminDisableUserRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminDisableUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminDisableUserResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AdminDisableUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAdminDisableUser.</param>
        /// 
        /// <returns>Returns a  AdminDisableUserResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminDisableUser">REST API Reference for AdminDisableUser Operation</seealso>
        public virtual AdminDisableUserResponse EndAdminDisableUser(IAsyncResult asyncResult)
        {
            return EndInvoke<AdminDisableUserResponse>(asyncResult);
        }

        #endregion
        
        #region  AdminEnableUser

        /// <summary>
        /// Activates sign-in for a user profile that previously had sign-in access disabled.
        /// 
        ///  <note> 
        /// <para>
        /// Amazon Cognito evaluates Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you must use IAM credentials to authorize
        /// requests, and you must grant yourself the corresponding IAM permission in a policy.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
        /// Amazon Web Services API Requests</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a> 
        /// </para>
        ///  </li> </ul> </note>
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
        public virtual AdminEnableUserResponse AdminEnableUser(AdminEnableUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminEnableUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminEnableUserResponseUnmarshaller.Instance;

            return Invoke<AdminEnableUserResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminEnableUser">REST API Reference for AdminEnableUser Operation</seealso>
        public virtual IAsyncResult BeginAdminEnableUser(AdminEnableUserRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminEnableUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminEnableUserResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AdminEnableUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAdminEnableUser.</param>
        /// 
        /// <returns>Returns a  AdminEnableUserResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminEnableUser">REST API Reference for AdminEnableUser Operation</seealso>
        public virtual AdminEnableUserResponse EndAdminEnableUser(IAsyncResult asyncResult)
        {
            return EndInvoke<AdminEnableUserResponse>(asyncResult);
        }

        #endregion
        
        #region  AdminForgetDevice

        /// <summary>
        /// Forgets, or deletes, a remembered device from a user's profile. After you forget the
        /// device, the user can no longer complete device authentication with that device and
        /// when applicable, must submit MFA codes again. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/amazon-cognito-user-pools-device-tracking.html">Working
        /// with devices</a>.
        /// 
        ///  <note> 
        /// <para>
        /// Amazon Cognito evaluates Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you must use IAM credentials to authorize
        /// requests, and you must grant yourself the corresponding IAM permission in a policy.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
        /// Amazon Web Services API Requests</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a> 
        /// </para>
        ///  </li> </ul> </note>
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
        public virtual AdminForgetDeviceResponse AdminForgetDevice(AdminForgetDeviceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminForgetDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminForgetDeviceResponseUnmarshaller.Instance;

            return Invoke<AdminForgetDeviceResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginAdminForgetDevice(AdminForgetDeviceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminForgetDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminForgetDeviceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AdminForgetDevice operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAdminForgetDevice.</param>
        /// 
        /// <returns>Returns a  AdminForgetDeviceResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminForgetDevice">REST API Reference for AdminForgetDevice Operation</seealso>
        public virtual AdminForgetDeviceResponse EndAdminForgetDevice(IAsyncResult asyncResult)
        {
            return EndInvoke<AdminForgetDeviceResponse>(asyncResult);
        }

        #endregion
        
        #region  AdminGetDevice

        /// <summary>
        /// Given the device key, returns details for a user's device. For more information, see
        /// <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/amazon-cognito-user-pools-device-tracking.html">Working
        /// with devices</a>.
        /// 
        ///  <note> 
        /// <para>
        /// Amazon Cognito evaluates Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you must use IAM credentials to authorize
        /// requests, and you must grant yourself the corresponding IAM permission in a policy.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
        /// Amazon Web Services API Requests</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a> 
        /// </para>
        ///  </li> </ul> </note>
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
        public virtual AdminGetDeviceResponse AdminGetDevice(AdminGetDeviceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminGetDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminGetDeviceResponseUnmarshaller.Instance;

            return Invoke<AdminGetDeviceResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginAdminGetDevice(AdminGetDeviceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminGetDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminGetDeviceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AdminGetDevice operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAdminGetDevice.</param>
        /// 
        /// <returns>Returns a  AdminGetDeviceResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminGetDevice">REST API Reference for AdminGetDevice Operation</seealso>
        public virtual AdminGetDeviceResponse EndAdminGetDevice(IAsyncResult asyncResult)
        {
            return EndInvoke<AdminGetDeviceResponse>(asyncResult);
        }

        #endregion
        
        #region  AdminGetUser

        /// <summary>
        /// Given a username, returns details about a user profile in a user pool. You can specify
        /// alias attributes in the <c>Username</c> request parameter.
        /// 
        ///  
        /// <para>
        /// This operation contributes to your monthly active user (MAU) count for the purpose
        /// of billing.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon Cognito evaluates Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you must use IAM credentials to authorize
        /// requests, and you must grant yourself the corresponding IAM permission in a policy.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
        /// Amazon Web Services API Requests</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a> 
        /// </para>
        ///  </li> </ul> </note>
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
        public virtual AdminGetUserResponse AdminGetUser(AdminGetUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminGetUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminGetUserResponseUnmarshaller.Instance;

            return Invoke<AdminGetUserResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminGetUser">REST API Reference for AdminGetUser Operation</seealso>
        public virtual IAsyncResult BeginAdminGetUser(AdminGetUserRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminGetUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminGetUserResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AdminGetUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAdminGetUser.</param>
        /// 
        /// <returns>Returns a  AdminGetUserResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminGetUser">REST API Reference for AdminGetUser Operation</seealso>
        public virtual AdminGetUserResponse EndAdminGetUser(IAsyncResult asyncResult)
        {
            return EndInvoke<AdminGetUserResponse>(asyncResult);
        }

        #endregion
        
        #region  AdminInitiateAuth

        /// <summary>
        /// Starts sign-in for applications with a server-side component, for example a traditional
        /// web application. This operation specifies the authentication flow that you'd like
        /// to begin. The authentication flow that you specify must be supported in your app client
        /// configuration. For more information about authentication flows, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/amazon-cognito-user-pools-authentication-flow-methods.html">Authentication
        /// flows</a>.
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
        /// Services service, Amazon Simple Notification Service might place your account in the
        /// SMS sandbox. In <i> <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-sms-sandbox.html">sandbox
        /// mode</a> </i>, you can send messages only to verified phone numbers. After you test
        /// your app while in the sandbox environment, you can move out of the sandbox and into
        /// production. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pool-sms-settings.html">
        /// SMS message settings for Amazon Cognito user pools</a> in the <i>Amazon Cognito Developer
        /// Guide</i>.
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// Amazon Cognito evaluates Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you must use IAM credentials to authorize
        /// requests, and you must grant yourself the corresponding IAM permission in a policy.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
        /// Amazon Web Services API Requests</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a> 
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AdminInitiateAuth service method.</param>
        /// 
        /// <returns>The response from the AdminInitiateAuth service method, as returned by CognitoIdentityProvider.</returns>
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
        /// for SMS configuration. This can happen if you don't trust <c>cognito-idp.amazonaws.com</c>
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
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UnsupportedOperationException">
        /// Exception that is thrown when you attempt to perform an operation that isn't enabled
        /// for the user pool client.
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
        public virtual AdminInitiateAuthResponse AdminInitiateAuth(AdminInitiateAuthRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminInitiateAuthRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminInitiateAuthResponseUnmarshaller.Instance;

            return Invoke<AdminInitiateAuthResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginAdminInitiateAuth(AdminInitiateAuthRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminInitiateAuthRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminInitiateAuthResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AdminInitiateAuth operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAdminInitiateAuth.</param>
        /// 
        /// <returns>Returns a  AdminInitiateAuthResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminInitiateAuth">REST API Reference for AdminInitiateAuth Operation</seealso>
        public virtual AdminInitiateAuthResponse EndAdminInitiateAuth(IAsyncResult asyncResult)
        {
            return EndInvoke<AdminInitiateAuthResponse>(asyncResult);
        }

        #endregion
        
        #region  AdminLinkProviderForUser

        /// <summary>
        /// Links an existing user account in a user pool, or <c>DestinationUser</c>, to an identity
        /// from an external IdP, or <c>SourceUser</c>, based on a specified attribute name and
        /// value from the external IdP.
        /// 
        ///  
        /// <para>
        /// This operation connects a local user profile with a user identity who hasn't yet signed
        /// in from their third-party IdP. When the user signs in with their IdP, they get access-control
        /// configuration from the local user profile. Linked local users can also sign in with
        /// SDK-based API operations like <c>InitiateAuth</c> after they sign in at least once
        /// through their IdP. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pools-identity-federation-consolidate-users.html">Linking
        /// federated users</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// The maximum number of federated identities linked to a user is five.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// Because this API allows a user with an external federated identity to sign in as a
        /// local user, it is critical that it only be used with external IdPs and linked attributes
        /// that you trust.
        /// </para>
        ///  </important> <note> 
        /// <para>
        /// Amazon Cognito evaluates Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you must use IAM credentials to authorize
        /// requests, and you must grant yourself the corresponding IAM permission in a policy.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
        /// Amazon Web Services API Requests</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a> 
        /// </para>
        ///  </li> </ul> </note>
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
        public virtual AdminLinkProviderForUserResponse AdminLinkProviderForUser(AdminLinkProviderForUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminLinkProviderForUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminLinkProviderForUserResponseUnmarshaller.Instance;

            return Invoke<AdminLinkProviderForUserResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginAdminLinkProviderForUser(AdminLinkProviderForUserRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminLinkProviderForUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminLinkProviderForUserResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AdminLinkProviderForUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAdminLinkProviderForUser.</param>
        /// 
        /// <returns>Returns a  AdminLinkProviderForUserResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminLinkProviderForUser">REST API Reference for AdminLinkProviderForUser Operation</seealso>
        public virtual AdminLinkProviderForUserResponse EndAdminLinkProviderForUser(IAsyncResult asyncResult)
        {
            return EndInvoke<AdminLinkProviderForUserResponse>(asyncResult);
        }

        #endregion
        
        #region  AdminListDevices

        /// <summary>
        /// Lists a user's registered devices. Remembered devices are used in authentication services
        /// where you offer a "Remember me" option for users who you want to permit to sign in
        /// without MFA from a trusted device. Users can bypass MFA while your application performs
        /// device SRP authentication on the back end. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/amazon-cognito-user-pools-device-tracking.html">Working
        /// with devices</a>.
        /// 
        ///  <note> 
        /// <para>
        /// Amazon Cognito evaluates Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you must use IAM credentials to authorize
        /// requests, and you must grant yourself the corresponding IAM permission in a policy.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
        /// Amazon Web Services API Requests</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a> 
        /// </para>
        ///  </li> </ul> </note>
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
        public virtual AdminListDevicesResponse AdminListDevices(AdminListDevicesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminListDevicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminListDevicesResponseUnmarshaller.Instance;

            return Invoke<AdminListDevicesResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginAdminListDevices(AdminListDevicesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminListDevicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminListDevicesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AdminListDevices operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAdminListDevices.</param>
        /// 
        /// <returns>Returns a  AdminListDevicesResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminListDevices">REST API Reference for AdminListDevices Operation</seealso>
        public virtual AdminListDevicesResponse EndAdminListDevices(IAsyncResult asyncResult)
        {
            return EndInvoke<AdminListDevicesResponse>(asyncResult);
        }

        #endregion
        
        #region  AdminListGroupsForUser

        /// <summary>
        /// Lists the groups that a user belongs to. User pool groups are identifiers that you
        /// can reference from the contents of ID and access tokens, and set preferred IAM roles
        /// for identity-pool authentication. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pools-user-groups.html">Adding
        /// groups to a user pool</a>.
        /// 
        ///  <note> 
        /// <para>
        /// Amazon Cognito evaluates Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you must use IAM credentials to authorize
        /// requests, and you must grant yourself the corresponding IAM permission in a policy.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
        /// Amazon Web Services API Requests</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a> 
        /// </para>
        ///  </li> </ul> </note>
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
        public virtual AdminListGroupsForUserResponse AdminListGroupsForUser(AdminListGroupsForUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminListGroupsForUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminListGroupsForUserResponseUnmarshaller.Instance;

            return Invoke<AdminListGroupsForUserResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginAdminListGroupsForUser(AdminListGroupsForUserRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminListGroupsForUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminListGroupsForUserResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AdminListGroupsForUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAdminListGroupsForUser.</param>
        /// 
        /// <returns>Returns a  AdminListGroupsForUserResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminListGroupsForUser">REST API Reference for AdminListGroupsForUser Operation</seealso>
        public virtual AdminListGroupsForUserResponse EndAdminListGroupsForUser(IAsyncResult asyncResult)
        {
            return EndInvoke<AdminListGroupsForUserResponse>(asyncResult);
        }

        #endregion
        
        #region  AdminListUserAuthEvents

        /// <summary>
        /// Requests a history of user activity and any risks detected as part of Amazon Cognito
        /// threat protection. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pool-settings-adaptive-authentication.html#user-pool-settings-adaptive-authentication-event-user-history">Viewing
        /// user event history</a>.
        /// 
        ///  <note> 
        /// <para>
        /// Amazon Cognito evaluates Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you must use IAM credentials to authorize
        /// requests, and you must grant yourself the corresponding IAM permission in a policy.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
        /// Amazon Web Services API Requests</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a> 
        /// </para>
        ///  </li> </ul> </note>
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
        public virtual AdminListUserAuthEventsResponse AdminListUserAuthEvents(AdminListUserAuthEventsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminListUserAuthEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminListUserAuthEventsResponseUnmarshaller.Instance;

            return Invoke<AdminListUserAuthEventsResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginAdminListUserAuthEvents(AdminListUserAuthEventsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminListUserAuthEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminListUserAuthEventsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AdminListUserAuthEvents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAdminListUserAuthEvents.</param>
        /// 
        /// <returns>Returns a  AdminListUserAuthEventsResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminListUserAuthEvents">REST API Reference for AdminListUserAuthEvents Operation</seealso>
        public virtual AdminListUserAuthEventsResponse EndAdminListUserAuthEvents(IAsyncResult asyncResult)
        {
            return EndInvoke<AdminListUserAuthEventsResponse>(asyncResult);
        }

        #endregion
        
        #region  AdminRemoveUserFromGroup

        /// <summary>
        /// Given a username and a group name, removes them from the group. User pool groups are
        /// identifiers that you can reference from the contents of ID and access tokens, and
        /// set preferred IAM roles for identity-pool authentication. For more information, see
        /// <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pools-user-groups.html">Adding
        /// groups to a user pool</a>.
        /// 
        ///  <note> 
        /// <para>
        /// Amazon Cognito evaluates Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you must use IAM credentials to authorize
        /// requests, and you must grant yourself the corresponding IAM permission in a policy.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
        /// Amazon Web Services API Requests</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a> 
        /// </para>
        ///  </li> </ul> </note>
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
        public virtual AdminRemoveUserFromGroupResponse AdminRemoveUserFromGroup(AdminRemoveUserFromGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminRemoveUserFromGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminRemoveUserFromGroupResponseUnmarshaller.Instance;

            return Invoke<AdminRemoveUserFromGroupResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginAdminRemoveUserFromGroup(AdminRemoveUserFromGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminRemoveUserFromGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminRemoveUserFromGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AdminRemoveUserFromGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAdminRemoveUserFromGroup.</param>
        /// 
        /// <returns>Returns a  AdminRemoveUserFromGroupResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminRemoveUserFromGroup">REST API Reference for AdminRemoveUserFromGroup Operation</seealso>
        public virtual AdminRemoveUserFromGroupResponse EndAdminRemoveUserFromGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<AdminRemoveUserFromGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  AdminResetUserPassword

        /// <summary>
        /// Begins the password reset process. Sets the requested user’s account into a <c>RESET_REQUIRED</c>
        /// status, and sends them a password-reset code. Your user pool also sends the user a
        /// notification with a reset code and the information that their password has been reset.
        /// At sign-in, your application or the managed login session receives a challenge to
        /// complete the reset by confirming the code and setting a new password.
        /// 
        ///  
        /// <para>
        /// To use this API operation, your user pool must have self-service account recovery
        /// configured.
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
        /// Services service, Amazon Simple Notification Service might place your account in the
        /// SMS sandbox. In <i> <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-sms-sandbox.html">sandbox
        /// mode</a> </i>, you can send messages only to verified phone numbers. After you test
        /// your app while in the sandbox environment, you can move out of the sandbox and into
        /// production. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pool-sms-settings.html">
        /// SMS message settings for Amazon Cognito user pools</a> in the <i>Amazon Cognito Developer
        /// Guide</i>.
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// Amazon Cognito evaluates Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you must use IAM credentials to authorize
        /// requests, and you must grant yourself the corresponding IAM permission in a policy.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
        /// Amazon Web Services API Requests</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a> 
        /// </para>
        ///  </li> </ul> </note>
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
        /// for SMS configuration. This can happen if you don't trust <c>cognito-idp.amazonaws.com</c>
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
        public virtual AdminResetUserPasswordResponse AdminResetUserPassword(AdminResetUserPasswordRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminResetUserPasswordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminResetUserPasswordResponseUnmarshaller.Instance;

            return Invoke<AdminResetUserPasswordResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminResetUserPassword">REST API Reference for AdminResetUserPassword Operation</seealso>
        public virtual IAsyncResult BeginAdminResetUserPassword(AdminResetUserPasswordRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminResetUserPasswordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminResetUserPasswordResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AdminResetUserPassword operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAdminResetUserPassword.</param>
        /// 
        /// <returns>Returns a  AdminResetUserPasswordResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminResetUserPassword">REST API Reference for AdminResetUserPassword Operation</seealso>
        public virtual AdminResetUserPasswordResponse EndAdminResetUserPassword(IAsyncResult asyncResult)
        {
            return EndInvoke<AdminResetUserPasswordResponse>(asyncResult);
        }

        #endregion
        
        #region  AdminRespondToAuthChallenge

        /// <summary>
        /// Some API operations in a user pool generate a challenge, like a prompt for an MFA
        /// code, for device authentication that bypasses MFA, or for a custom authentication
        /// challenge. An <c>AdminRespondToAuthChallenge</c> API request provides the answer to
        /// that challenge, like a code or a secure remote password (SRP). The parameters of a
        /// response to an authentication challenge vary with the type of challenge.
        /// 
        ///  
        /// <para>
        /// For more information about custom authentication challenges, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pool-lambda-challenge.html">Custom
        /// authentication challenge Lambda triggers</a>.
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
        /// Services service, Amazon Simple Notification Service might place your account in the
        /// SMS sandbox. In <i> <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-sms-sandbox.html">sandbox
        /// mode</a> </i>, you can send messages only to verified phone numbers. After you test
        /// your app while in the sandbox environment, you can move out of the sandbox and into
        /// production. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pool-sms-settings.html">
        /// SMS message settings for Amazon Cognito user pools</a> in the <i>Amazon Cognito Developer
        /// Guide</i>.
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// Amazon Cognito evaluates Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you must use IAM credentials to authorize
        /// requests, and you must grant yourself the corresponding IAM permission in a policy.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
        /// Amazon Web Services API Requests</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a> 
        /// </para>
        ///  </li> </ul> </note>
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
        /// for SMS configuration. This can happen if you don't trust <c>cognito-idp.amazonaws.com</c>
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
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordHistoryPolicyViolationException">
        /// The message returned when a user's new password matches a previous password and doesn't
        /// comply with the password-history policy.
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
        public virtual AdminRespondToAuthChallengeResponse AdminRespondToAuthChallenge(AdminRespondToAuthChallengeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminRespondToAuthChallengeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminRespondToAuthChallengeResponseUnmarshaller.Instance;

            return Invoke<AdminRespondToAuthChallengeResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginAdminRespondToAuthChallenge(AdminRespondToAuthChallengeRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminRespondToAuthChallengeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminRespondToAuthChallengeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AdminRespondToAuthChallenge operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAdminRespondToAuthChallenge.</param>
        /// 
        /// <returns>Returns a  AdminRespondToAuthChallengeResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminRespondToAuthChallenge">REST API Reference for AdminRespondToAuthChallenge Operation</seealso>
        public virtual AdminRespondToAuthChallengeResponse EndAdminRespondToAuthChallenge(IAsyncResult asyncResult)
        {
            return EndInvoke<AdminRespondToAuthChallengeResponse>(asyncResult);
        }

        #endregion
        
        #region  AdminSetUserMFAPreference

        /// <summary>
        /// Sets the user's multi-factor authentication (MFA) preference, including which MFA
        /// options are activated, and if any are preferred. Only one factor can be set as preferred.
        /// The preferred MFA factor will be used to authenticate a user if multiple factors are
        /// activated. If multiple options are activated and no preference is set, a challenge
        /// to choose an MFA option will be returned during sign-in.
        /// 
        ///  <note> 
        /// <para>
        /// Amazon Cognito evaluates Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you must use IAM credentials to authorize
        /// requests, and you must grant yourself the corresponding IAM permission in a policy.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
        /// Amazon Web Services API Requests</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a> 
        /// </para>
        ///  </li> </ul> </note>
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
        public virtual AdminSetUserMFAPreferenceResponse AdminSetUserMFAPreference(AdminSetUserMFAPreferenceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminSetUserMFAPreferenceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminSetUserMFAPreferenceResponseUnmarshaller.Instance;

            return Invoke<AdminSetUserMFAPreferenceResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginAdminSetUserMFAPreference(AdminSetUserMFAPreferenceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminSetUserMFAPreferenceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminSetUserMFAPreferenceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AdminSetUserMFAPreference operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAdminSetUserMFAPreference.</param>
        /// 
        /// <returns>Returns a  AdminSetUserMFAPreferenceResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminSetUserMFAPreference">REST API Reference for AdminSetUserMFAPreference Operation</seealso>
        public virtual AdminSetUserMFAPreferenceResponse EndAdminSetUserMFAPreference(IAsyncResult asyncResult)
        {
            return EndInvoke<AdminSetUserMFAPreferenceResponse>(asyncResult);
        }

        #endregion
        
        #region  AdminSetUserPassword

        /// <summary>
        /// Sets the specified user's password in a user pool. This operation administratively
        /// sets a temporary or permanent password for a user. With this operation, you can bypass
        /// self-service password changes and permit immediate sign-in with the password that
        /// you set. To do this, set <c>Permanent</c> to <c>true</c>.
        /// 
        ///  
        /// <para>
        /// You can also set a new temporary password in this request, send it to a user, and
        /// require them to choose a new password on their next sign-in. To do this, set <c>Permanent</c>
        /// to <c>false</c>.
        /// </para>
        ///  
        /// <para>
        /// If the password is temporary, the user's <c>Status</c> becomes <c>FORCE_CHANGE_PASSWORD</c>.
        /// When the user next tries to sign in, the <c>InitiateAuth</c> or <c>AdminInitiateAuth</c>
        /// response includes the <c>NEW_PASSWORD_REQUIRED</c> challenge. If the user doesn't
        /// sign in before the temporary password expires, they can no longer sign in and you
        /// must repeat this operation to set a temporary or permanent password for them.
        /// </para>
        ///  
        /// <para>
        /// After the user sets a new password, or if you set a permanent password, their status
        /// becomes <c>Confirmed</c>.
        /// </para>
        ///  
        /// <para>
        ///  <c>AdminSetUserPassword</c> can set a password for the user profile that Amazon Cognito
        /// creates for third-party federated users. When you set a password, the federated user's
        /// status changes from <c>EXTERNAL_PROVIDER</c> to <c>CONFIRMED</c>. A user in this state
        /// can sign in as a federated user, and initiate authentication flows in the API like
        /// a linked native user. They can also modify their password and attributes in token-authenticated
        /// API requests like <c>ChangePassword</c> and <c>UpdateUserAttributes</c>. As a best
        /// security practice and to keep users in sync with your external IdP, don't set passwords
        /// on federated user profiles. To set up a federated user for native sign-in with a linked
        /// native user, refer to <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pools-identity-federation-consolidate-users.html">Linking
        /// federated users to an existing user profile</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon Cognito evaluates Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you must use IAM credentials to authorize
        /// requests, and you must grant yourself the corresponding IAM permission in a policy.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
        /// Amazon Web Services API Requests</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a> 
        /// </para>
        ///  </li> </ul> </note>
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
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordHistoryPolicyViolationException">
        /// The message returned when a user's new password matches a previous password and doesn't
        /// comply with the password-history policy.
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
        public virtual AdminSetUserPasswordResponse AdminSetUserPassword(AdminSetUserPasswordRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminSetUserPasswordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminSetUserPasswordResponseUnmarshaller.Instance;

            return Invoke<AdminSetUserPasswordResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginAdminSetUserPassword(AdminSetUserPasswordRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminSetUserPasswordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminSetUserPasswordResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AdminSetUserPassword operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAdminSetUserPassword.</param>
        /// 
        /// <returns>Returns a  AdminSetUserPasswordResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminSetUserPassword">REST API Reference for AdminSetUserPassword Operation</seealso>
        public virtual AdminSetUserPasswordResponse EndAdminSetUserPassword(IAsyncResult asyncResult)
        {
            return EndInvoke<AdminSetUserPasswordResponse>(asyncResult);
        }

        #endregion
        
        #region  AdminSetUserSettings

        /// <summary>
        /// <i>This action is no longer supported.</i> You can use it to configure only SMS MFA.
        /// You can't use it to configure time-based one-time password (TOTP) software token MFA.
        /// 
        ///  <note> 
        /// <para>
        /// Amazon Cognito evaluates Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you must use IAM credentials to authorize
        /// requests, and you must grant yourself the corresponding IAM permission in a policy.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
        /// Amazon Web Services API Requests</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a> 
        /// </para>
        ///  </li> </ul> </note>
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
        public virtual AdminSetUserSettingsResponse AdminSetUserSettings(AdminSetUserSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminSetUserSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminSetUserSettingsResponseUnmarshaller.Instance;

            return Invoke<AdminSetUserSettingsResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminSetUserSettings">REST API Reference for AdminSetUserSettings Operation</seealso>
        public virtual IAsyncResult BeginAdminSetUserSettings(AdminSetUserSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminSetUserSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminSetUserSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AdminSetUserSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAdminSetUserSettings.</param>
        /// 
        /// <returns>Returns a  AdminSetUserSettingsResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminSetUserSettings">REST API Reference for AdminSetUserSettings Operation</seealso>
        public virtual AdminSetUserSettingsResponse EndAdminSetUserSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<AdminSetUserSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  AdminUpdateAuthEventFeedback

        /// <summary>
        /// Provides the feedback for an authentication event generated by threat protection features.
        /// Your response indicates that you think that the event either was from a valid user
        /// or was an unwanted authentication attempt. This feedback improves the risk evaluation
        /// decision for the user pool as part of Amazon Cognito threat protection. To activate
        /// this setting, your user pool must be on the <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/feature-plans-features-plus.html">
        /// Plus tier</a>.
        /// 
        ///  
        /// <para>
        /// To train the threat-protection model to recognize trusted and untrusted sign-in characteristics,
        /// configure threat protection in audit-only mode and provide a mechanism for users or
        /// administrators to submit feedback. Your feedback can tell Amazon Cognito that a risk
        /// rating was assigned at a level you don't agree with.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon Cognito evaluates Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you must use IAM credentials to authorize
        /// requests, and you must grant yourself the corresponding IAM permission in a policy.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
        /// Amazon Web Services API Requests</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a> 
        /// </para>
        ///  </li> </ul> </note>
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
        public virtual AdminUpdateAuthEventFeedbackResponse AdminUpdateAuthEventFeedback(AdminUpdateAuthEventFeedbackRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminUpdateAuthEventFeedbackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminUpdateAuthEventFeedbackResponseUnmarshaller.Instance;

            return Invoke<AdminUpdateAuthEventFeedbackResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginAdminUpdateAuthEventFeedback(AdminUpdateAuthEventFeedbackRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminUpdateAuthEventFeedbackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminUpdateAuthEventFeedbackResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AdminUpdateAuthEventFeedback operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAdminUpdateAuthEventFeedback.</param>
        /// 
        /// <returns>Returns a  AdminUpdateAuthEventFeedbackResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminUpdateAuthEventFeedback">REST API Reference for AdminUpdateAuthEventFeedback Operation</seealso>
        public virtual AdminUpdateAuthEventFeedbackResponse EndAdminUpdateAuthEventFeedback(IAsyncResult asyncResult)
        {
            return EndInvoke<AdminUpdateAuthEventFeedbackResponse>(asyncResult);
        }

        #endregion
        
        #region  AdminUpdateDeviceStatus

        /// <summary>
        /// Updates the status of a user's device so that it is marked as remembered or not remembered
        /// for the purpose of device authentication. Device authentication is a "remember me"
        /// mechanism that silently completes sign-in from trusted devices with a device key instead
        /// of a user-provided MFA code. This operation changes the status of a device without
        /// deleting it, so you can enable it again later. For more information about device authentication,
        /// see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/amazon-cognito-user-pools-device-tracking.html">Working
        /// with devices</a>.
        /// 
        ///  <note> 
        /// <para>
        /// Amazon Cognito evaluates Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you must use IAM credentials to authorize
        /// requests, and you must grant yourself the corresponding IAM permission in a policy.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
        /// Amazon Web Services API Requests</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a> 
        /// </para>
        ///  </li> </ul> </note>
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
        public virtual AdminUpdateDeviceStatusResponse AdminUpdateDeviceStatus(AdminUpdateDeviceStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminUpdateDeviceStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminUpdateDeviceStatusResponseUnmarshaller.Instance;

            return Invoke<AdminUpdateDeviceStatusResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginAdminUpdateDeviceStatus(AdminUpdateDeviceStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminUpdateDeviceStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminUpdateDeviceStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AdminUpdateDeviceStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAdminUpdateDeviceStatus.</param>
        /// 
        /// <returns>Returns a  AdminUpdateDeviceStatusResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminUpdateDeviceStatus">REST API Reference for AdminUpdateDeviceStatus Operation</seealso>
        public virtual AdminUpdateDeviceStatusResponse EndAdminUpdateDeviceStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<AdminUpdateDeviceStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  AdminUpdateUserAttributes

        /// <summary>
        /// Updates the specified user's attributes. To delete an attribute from your user, submit
        /// the attribute in your API request with a blank value.
        /// 
        ///  
        /// <para>
        /// For custom attributes, you must add a <c>custom:</c> prefix to the attribute name,
        /// for example <c>custom:department</c>.
        /// </para>
        ///  
        /// <para>
        /// This operation can set a user's email address or phone number as verified and permit
        /// immediate sign-in in user pools that require verification of these attributes. To
        /// do this, set the <c>email_verified</c> or <c>phone_number_verified</c> attribute to
        /// <c>true</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon Cognito evaluates Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you must use IAM credentials to authorize
        /// requests, and you must grant yourself the corresponding IAM permission in a policy.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
        /// Amazon Web Services API Requests</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a> 
        /// </para>
        ///  </li> </ul> </note> <note> 
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
        /// Services service, Amazon Simple Notification Service might place your account in the
        /// SMS sandbox. In <i> <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-sms-sandbox.html">sandbox
        /// mode</a> </i>, you can send messages only to verified phone numbers. After you test
        /// your app while in the sandbox environment, you can move out of the sandbox and into
        /// production. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pool-sms-settings.html">
        /// SMS message settings for Amazon Cognito user pools</a> in the <i>Amazon Cognito Developer
        /// Guide</i>.
        /// </para>
        ///  </note>
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
        /// for SMS configuration. This can happen if you don't trust <c>cognito-idp.amazonaws.com</c>
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
        public virtual AdminUpdateUserAttributesResponse AdminUpdateUserAttributes(AdminUpdateUserAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminUpdateUserAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminUpdateUserAttributesResponseUnmarshaller.Instance;

            return Invoke<AdminUpdateUserAttributesResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminUpdateUserAttributes">REST API Reference for AdminUpdateUserAttributes Operation</seealso>
        public virtual IAsyncResult BeginAdminUpdateUserAttributes(AdminUpdateUserAttributesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminUpdateUserAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminUpdateUserAttributesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AdminUpdateUserAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAdminUpdateUserAttributes.</param>
        /// 
        /// <returns>Returns a  AdminUpdateUserAttributesResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminUpdateUserAttributes">REST API Reference for AdminUpdateUserAttributes Operation</seealso>
        public virtual AdminUpdateUserAttributesResponse EndAdminUpdateUserAttributes(IAsyncResult asyncResult)
        {
            return EndInvoke<AdminUpdateUserAttributesResponse>(asyncResult);
        }

        #endregion
        
        #region  AdminUserGlobalSignOut

        /// <summary>
        /// Invalidates the identity, access, and refresh tokens that Amazon Cognito issued to
        /// a user. Call this operation with your administrative credentials when your user signs
        /// out of your app. This results in the following behavior.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Amazon Cognito no longer accepts <i>token-authorized</i> user operations that you
        /// authorize with a signed-out user's access tokens. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a>.
        /// </para>
        ///  
        /// <para>
        /// Amazon Cognito returns an <c>Access Token has been revoked</c> error when your app
        /// attempts to authorize a user pools API request with a revoked access token that contains
        /// the scope <c>aws.cognito.signin.user.admin</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Cognito no longer accepts a signed-out user's ID token in a <a href="https://docs.aws.amazon.com/cognitoidentity/latest/APIReference/API_GetId.html">GetId
        /// </a> request to an identity pool with <c>ServerSideTokenCheck</c> enabled for its
        /// user pool IdP configuration in <a href="https://docs.aws.amazon.com/cognitoidentity/latest/APIReference/API_CognitoIdentityProvider.html">CognitoIdentityProvider</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Cognito no longer accepts a signed-out user's refresh tokens in refresh requests.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Other requests might be valid until your user's token expires. This operation doesn't
        /// clear the <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pools-managed-login.html">managed
        /// login</a> session cookie. To clear the session for a user who signed in with managed
        /// login or the classic hosted UI, direct their browser session to the <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/logout-endpoint.html">logout
        /// endpoint</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon Cognito evaluates Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you must use IAM credentials to authorize
        /// requests, and you must grant yourself the corresponding IAM permission in a policy.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
        /// Amazon Web Services API Requests</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a> 
        /// </para>
        ///  </li> </ul> </note>
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
        public virtual AdminUserGlobalSignOutResponse AdminUserGlobalSignOut(AdminUserGlobalSignOutRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminUserGlobalSignOutRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminUserGlobalSignOutResponseUnmarshaller.Instance;

            return Invoke<AdminUserGlobalSignOutResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginAdminUserGlobalSignOut(AdminUserGlobalSignOutRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminUserGlobalSignOutRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminUserGlobalSignOutResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AdminUserGlobalSignOut operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAdminUserGlobalSignOut.</param>
        /// 
        /// <returns>Returns a  AdminUserGlobalSignOutResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminUserGlobalSignOut">REST API Reference for AdminUserGlobalSignOut Operation</seealso>
        public virtual AdminUserGlobalSignOutResponse EndAdminUserGlobalSignOut(IAsyncResult asyncResult)
        {
            return EndInvoke<AdminUserGlobalSignOutResponse>(asyncResult);
        }

        #endregion
        
        #region  AssociateSoftwareToken

        /// <summary>
        /// Begins setup of time-based one-time password (TOTP) multi-factor authentication (MFA)
        /// for a user, with a unique private key that Amazon Cognito generates and returns in
        /// the API response. You can authorize an <c>AssociateSoftwareToken</c> request with
        /// either the user's access token, or a session string from a challenge response that
        /// you received from Amazon Cognito.
        /// 
        ///  <note> 
        /// <para>
        /// Amazon Cognito doesn't evaluate Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you can't use IAM credentials to authorize
        /// requests, and you can't grant IAM permissions in policies. For more information about
        /// authorization models in Amazon Cognito, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Authorize this action with a signed-in user's access token. It must include the scope
        /// <c>aws.cognito.signin.user.admin</c>.
        /// </para>
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
        public virtual AssociateSoftwareTokenResponse AssociateSoftwareToken(AssociateSoftwareTokenRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateSoftwareTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateSoftwareTokenResponseUnmarshaller.Instance;

            return Invoke<AssociateSoftwareTokenResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginAssociateSoftwareToken(AssociateSoftwareTokenRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateSoftwareTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateSoftwareTokenResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateSoftwareToken operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateSoftwareToken.</param>
        /// 
        /// <returns>Returns a  AssociateSoftwareTokenResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AssociateSoftwareToken">REST API Reference for AssociateSoftwareToken Operation</seealso>
        public virtual AssociateSoftwareTokenResponse EndAssociateSoftwareToken(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateSoftwareTokenResponse>(asyncResult);
        }

        #endregion
        
        #region  ChangePassword

        /// <summary>
        /// Changes the password for the currently signed-in user.
        /// 
        ///  
        /// <para>
        /// Authorize this action with a signed-in user's access token. It must include the scope
        /// <c>aws.cognito.signin.user.admin</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon Cognito doesn't evaluate Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you can't use IAM credentials to authorize
        /// requests, and you can't grant IAM permissions in policies. For more information about
        /// authorization models in Amazon Cognito, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a>.
        /// </para>
        ///  </note>
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
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordHistoryPolicyViolationException">
        /// The message returned when a user's new password matches a previous password and doesn't
        /// comply with the password-history policy.
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
        public virtual ChangePasswordResponse ChangePassword(ChangePasswordRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ChangePasswordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ChangePasswordResponseUnmarshaller.Instance;

            return Invoke<ChangePasswordResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ChangePassword">REST API Reference for ChangePassword Operation</seealso>
        public virtual IAsyncResult BeginChangePassword(ChangePasswordRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ChangePasswordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ChangePasswordResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ChangePassword operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginChangePassword.</param>
        /// 
        /// <returns>Returns a  ChangePasswordResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ChangePassword">REST API Reference for ChangePassword Operation</seealso>
        public virtual ChangePasswordResponse EndChangePassword(IAsyncResult asyncResult)
        {
            return EndInvoke<ChangePasswordResponse>(asyncResult);
        }

        #endregion
        
        #region  CompleteWebAuthnRegistration

        /// <summary>
        /// Completes registration of a passkey authenticator for the currently signed-in user.
        /// 
        ///  
        /// <para>
        /// Authorize this action with a signed-in user's access token. It must include the scope
        /// <c>aws.cognito.signin.user.admin</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CompleteWebAuthnRegistration service method.</param>
        /// 
        /// <returns>The response from the CompleteWebAuthnRegistration service method, as returned by CognitoIdentityProvider.</returns>
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
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.WebAuthnChallengeNotFoundException">
        /// This exception is thrown when the challenge from <c>StartWebAuthn</c> registration
        /// has expired.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.WebAuthnClientMismatchException">
        /// This exception is thrown when the access token is for a different client than the
        /// one in the original <c>StartWebAuthnRegistration</c> request.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.WebAuthnCredentialNotSupportedException">
        /// This exception is thrown when a user presents passkey credentials from an unsupported
        /// device or provider.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.WebAuthnNotEnabledException">
        /// This exception is thrown when the passkey feature isn't enabled for the user pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.WebAuthnOriginNotAllowedException">
        /// This exception is thrown when the passkey credential's registration origin does not
        /// align with the user pool relying party id.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.WebAuthnRelyingPartyMismatchException">
        /// This exception is thrown when the given passkey credential is associated with a different
        /// relying party ID than the user pool relying party ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CompleteWebAuthnRegistration">REST API Reference for CompleteWebAuthnRegistration Operation</seealso>
        public virtual CompleteWebAuthnRegistrationResponse CompleteWebAuthnRegistration(CompleteWebAuthnRegistrationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CompleteWebAuthnRegistrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CompleteWebAuthnRegistrationResponseUnmarshaller.Instance;

            return Invoke<CompleteWebAuthnRegistrationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CompleteWebAuthnRegistration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CompleteWebAuthnRegistration operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCompleteWebAuthnRegistration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CompleteWebAuthnRegistration">REST API Reference for CompleteWebAuthnRegistration Operation</seealso>
        public virtual IAsyncResult BeginCompleteWebAuthnRegistration(CompleteWebAuthnRegistrationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CompleteWebAuthnRegistrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CompleteWebAuthnRegistrationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CompleteWebAuthnRegistration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCompleteWebAuthnRegistration.</param>
        /// 
        /// <returns>Returns a  CompleteWebAuthnRegistrationResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CompleteWebAuthnRegistration">REST API Reference for CompleteWebAuthnRegistration Operation</seealso>
        public virtual CompleteWebAuthnRegistrationResponse EndCompleteWebAuthnRegistration(IAsyncResult asyncResult)
        {
            return EndInvoke<CompleteWebAuthnRegistrationResponse>(asyncResult);
        }

        #endregion
        
        #region  ConfirmDevice

        /// <summary>
        /// Confirms a device that a user wants to remember. A remembered device is a "Remember
        /// me on this device" option for user pools that perform authentication with the device
        /// key of a trusted device in the back end, instead of a user-provided MFA code. For
        /// more information about device authentication, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/amazon-cognito-user-pools-device-tracking.html">Working
        /// with user devices in your user pool</a>.
        /// 
        ///  
        /// <para>
        /// Authorize this action with a signed-in user's access token. It must include the scope
        /// <c>aws.cognito.signin.user.admin</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon Cognito doesn't evaluate Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you can't use IAM credentials to authorize
        /// requests, and you can't grant IAM permissions in policies. For more information about
        /// authorization models in Amazon Cognito, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConfirmDevice service method.</param>
        /// 
        /// <returns>The response from the ConfirmDevice service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.DeviceKeyExistsException">
        /// This exception is thrown when a user attempts to confirm a device with a device key
        /// that already exists.
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
        public virtual ConfirmDeviceResponse ConfirmDevice(ConfirmDeviceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ConfirmDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConfirmDeviceResponseUnmarshaller.Instance;

            return Invoke<ConfirmDeviceResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginConfirmDevice(ConfirmDeviceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ConfirmDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConfirmDeviceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ConfirmDevice operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginConfirmDevice.</param>
        /// 
        /// <returns>Returns a  ConfirmDeviceResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ConfirmDevice">REST API Reference for ConfirmDevice Operation</seealso>
        public virtual ConfirmDeviceResponse EndConfirmDevice(IAsyncResult asyncResult)
        {
            return EndInvoke<ConfirmDeviceResponse>(asyncResult);
        }

        #endregion
        
        #region  ConfirmForgotPassword

        /// <summary>
        /// This public API operation accepts a confirmation code that Amazon Cognito sent to
        /// a user and accepts a new password for that user.
        /// 
        ///  <note> 
        /// <para>
        /// Amazon Cognito doesn't evaluate Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you can't use IAM credentials to authorize
        /// requests, and you can't grant IAM permissions in policies. For more information about
        /// authorization models in Amazon Cognito, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a>.
        /// </para>
        ///  </note>
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
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordHistoryPolicyViolationException">
        /// The message returned when a user's new password matches a previous password and doesn't
        /// comply with the password-history policy.
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
        public virtual ConfirmForgotPasswordResponse ConfirmForgotPassword(ConfirmForgotPasswordRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ConfirmForgotPasswordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConfirmForgotPasswordResponseUnmarshaller.Instance;

            return Invoke<ConfirmForgotPasswordResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ConfirmForgotPassword">REST API Reference for ConfirmForgotPassword Operation</seealso>
        public virtual IAsyncResult BeginConfirmForgotPassword(ConfirmForgotPasswordRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ConfirmForgotPasswordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConfirmForgotPasswordResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ConfirmForgotPassword operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginConfirmForgotPassword.</param>
        /// 
        /// <returns>Returns a  ConfirmForgotPasswordResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ConfirmForgotPassword">REST API Reference for ConfirmForgotPassword Operation</seealso>
        public virtual ConfirmForgotPasswordResponse EndConfirmForgotPassword(IAsyncResult asyncResult)
        {
            return EndInvoke<ConfirmForgotPasswordResponse>(asyncResult);
        }

        #endregion
        
        #region  ConfirmSignUp

        /// <summary>
        /// Confirms the account of a new user. This public API operation submits a code that
        /// Amazon Cognito sent to your user when they signed up in your user pool. After your
        /// user enters their code, they confirm ownership of the email address or phone number
        /// that they provided, and their user account becomes active. Depending on your user
        /// pool configuration, your users will receive their confirmation code in an email or
        /// SMS message.
        /// 
        ///  
        /// <para>
        /// Local users who signed up in your user pool are the only type of user who can confirm
        /// sign-up with a code. Users who federate through an external identity provider (IdP)
        /// have already been confirmed by their IdP.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon Cognito doesn't evaluate Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you can't use IAM credentials to authorize
        /// requests, and you can't grant IAM permissions in policies. For more information about
        /// authorization models in Amazon Cognito, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a>.
        /// </para>
        ///  </note>
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
        public virtual ConfirmSignUpResponse ConfirmSignUp(ConfirmSignUpRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ConfirmSignUpRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConfirmSignUpResponseUnmarshaller.Instance;

            return Invoke<ConfirmSignUpResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ConfirmSignUp">REST API Reference for ConfirmSignUp Operation</seealso>
        public virtual IAsyncResult BeginConfirmSignUp(ConfirmSignUpRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ConfirmSignUpRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConfirmSignUpResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ConfirmSignUp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginConfirmSignUp.</param>
        /// 
        /// <returns>Returns a  ConfirmSignUpResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ConfirmSignUp">REST API Reference for ConfirmSignUp Operation</seealso>
        public virtual ConfirmSignUpResponse EndConfirmSignUp(IAsyncResult asyncResult)
        {
            return EndInvoke<ConfirmSignUpResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateGroup

        /// <summary>
        /// Creates a new group in the specified user pool. For more information about user pool
        /// groups, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pools-user-groups.html">Adding
        /// groups to a user pool</a>.
        /// 
        ///  <note> 
        /// <para>
        /// Amazon Cognito evaluates Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you must use IAM credentials to authorize
        /// requests, and you must grant yourself the corresponding IAM permission in a policy.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
        /// Amazon Web Services API Requests</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a> 
        /// </para>
        ///  </li> </ul> </note>
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
        public virtual CreateGroupResponse CreateGroup(CreateGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGroupResponseUnmarshaller.Instance;

            return Invoke<CreateGroupResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginCreateGroup(CreateGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateGroup.</param>
        /// 
        /// <returns>Returns a  CreateGroupResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        public virtual CreateGroupResponse EndCreateGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateIdentityProvider

        /// <summary>
        /// Adds a configuration and trust relationship between a third-party identity provider
        /// (IdP) and a user pool. Amazon Cognito accepts sign-in with third-party identity providers
        /// through managed login and OIDC relying-party libraries. For more information, see
        /// <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pools-identity-federation.html">Third-party
        /// IdP sign-in</a>.
        /// 
        ///  <note> 
        /// <para>
        /// Amazon Cognito evaluates Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you must use IAM credentials to authorize
        /// requests, and you must grant yourself the corresponding IAM permission in a policy.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
        /// Amazon Web Services API Requests</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a> 
        /// </para>
        ///  </li> </ul> </note>
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
        public virtual CreateIdentityProviderResponse CreateIdentityProvider(CreateIdentityProviderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateIdentityProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIdentityProviderResponseUnmarshaller.Instance;

            return Invoke<CreateIdentityProviderResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginCreateIdentityProvider(CreateIdentityProviderRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateIdentityProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIdentityProviderResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateIdentityProvider operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateIdentityProvider.</param>
        /// 
        /// <returns>Returns a  CreateIdentityProviderResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CreateIdentityProvider">REST API Reference for CreateIdentityProvider Operation</seealso>
        public virtual CreateIdentityProviderResponse EndCreateIdentityProvider(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateIdentityProviderResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateManagedLoginBranding

        /// <summary>
        /// Creates a new set of branding settings for a user pool style and associates it with
        /// an app client. This operation is the programmatic option for the creation of a new
        /// style in the branding editor.
        /// 
        ///  
        /// <para>
        /// Provides values for UI customization in a <c>Settings</c> JSON object and image files
        /// in an <c>Assets</c> array. To send the JSON object <c>Document</c> type parameter
        /// in <c>Settings</c>, you might need to update to the most recent version of your Amazon
        /// Web Services SDK. To create a new style with default settings, set <c>UseCognitoProvidedValues</c>
        /// to <c>true</c> and don't provide values for any other options.
        /// </para>
        ///  
        /// <para>
        ///  This operation has a 2-megabyte request-size limit and include the CSS settings and
        /// image assets for your app client. Your branding settings might exceed 2MB in size.
        /// Amazon Cognito doesn't require that you pass all parameters in one request and preserves
        /// existing style settings that you don't specify. If your request is larger than 2MB,
        /// separate it into multiple requests, each with a size smaller than the limit. 
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon Cognito evaluates Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you must use IAM credentials to authorize
        /// requests, and you must grant yourself the corresponding IAM permission in a policy.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
        /// Amazon Web Services API Requests</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a> 
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateManagedLoginBranding service method.</param>
        /// 
        /// <returns>The response from the CreateManagedLoginBranding service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ConcurrentModificationException">
        /// This exception is thrown if two or more modifications are happening concurrently.
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
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ManagedLoginBrandingExistsException">
        /// This exception is thrown when you attempt to apply a managed login branding style
        /// to an app client that already has an assigned style.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CreateManagedLoginBranding">REST API Reference for CreateManagedLoginBranding Operation</seealso>
        public virtual CreateManagedLoginBrandingResponse CreateManagedLoginBranding(CreateManagedLoginBrandingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateManagedLoginBrandingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateManagedLoginBrandingResponseUnmarshaller.Instance;

            return Invoke<CreateManagedLoginBrandingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateManagedLoginBranding operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateManagedLoginBranding operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateManagedLoginBranding
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CreateManagedLoginBranding">REST API Reference for CreateManagedLoginBranding Operation</seealso>
        public virtual IAsyncResult BeginCreateManagedLoginBranding(CreateManagedLoginBrandingRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateManagedLoginBrandingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateManagedLoginBrandingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateManagedLoginBranding operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateManagedLoginBranding.</param>
        /// 
        /// <returns>Returns a  CreateManagedLoginBrandingResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CreateManagedLoginBranding">REST API Reference for CreateManagedLoginBranding Operation</seealso>
        public virtual CreateManagedLoginBrandingResponse EndCreateManagedLoginBranding(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateManagedLoginBrandingResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateResourceServer

        /// <summary>
        /// Creates a new OAuth2.0 resource server and defines custom scopes within it. Resource
        /// servers are associated with custom scopes and machine-to-machine (M2M) authorization.
        /// For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pools-define-resource-servers.html">Access
        /// control with resource servers</a>.
        /// 
        ///  <note> 
        /// <para>
        /// Amazon Cognito evaluates Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you must use IAM credentials to authorize
        /// requests, and you must grant yourself the corresponding IAM permission in a policy.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
        /// Amazon Web Services API Requests</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a> 
        /// </para>
        ///  </li> </ul> </note>
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
        public virtual CreateResourceServerResponse CreateResourceServer(CreateResourceServerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateResourceServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateResourceServerResponseUnmarshaller.Instance;

            return Invoke<CreateResourceServerResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginCreateResourceServer(CreateResourceServerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateResourceServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateResourceServerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateResourceServer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateResourceServer.</param>
        /// 
        /// <returns>Returns a  CreateResourceServerResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CreateResourceServer">REST API Reference for CreateResourceServer Operation</seealso>
        public virtual CreateResourceServerResponse EndCreateResourceServer(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateResourceServerResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateTerms

        /// <summary>
        /// Creates terms documents for the requested app client. When Terms and conditions and
        /// Privacy policy documents are configured, the app client displays links to them in
        /// the sign-up page of managed login for the app client.
        /// 
        ///  
        /// <para>
        /// You can provide URLs for terms documents in the languages that are supported by <a
        /// href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pools-managed-login.html#managed-login-localization">managed
        /// login localization</a>. Amazon Cognito directs users to the terms documents for their
        /// current language, with fallback to <c>default</c> if no document exists for the language.
        /// </para>
        ///  
        /// <para>
        /// Each request accepts one type of terms document and a map of language-to-link for
        /// that document type. You must provide both types of terms documents in at least one
        /// language before Amazon Cognito displays your terms documents. Supply each type in
        /// separate requests.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pools-managed-login.html#managed-login-terms-documents">Terms
        /// documents</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon Cognito evaluates Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you must use IAM credentials to authorize
        /// requests, and you must grant yourself the corresponding IAM permission in a policy.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
        /// Amazon Web Services API Requests</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a> 
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTerms service method.</param>
        /// 
        /// <returns>The response from the CreateTerms service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ConcurrentModificationException">
        /// This exception is thrown if two or more modifications are happening concurrently.
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
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TermsExistsException">
        /// Terms document names must be unique to the app client. This exception is thrown when
        /// you attempt to create terms documents with a duplicate <c>TermsName</c>.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CreateTerms">REST API Reference for CreateTerms Operation</seealso>
        public virtual CreateTermsResponse CreateTerms(CreateTermsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTermsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTermsResponseUnmarshaller.Instance;

            return Invoke<CreateTermsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTerms operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTerms operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTerms
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CreateTerms">REST API Reference for CreateTerms Operation</seealso>
        public virtual IAsyncResult BeginCreateTerms(CreateTermsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTermsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTermsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTerms operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTerms.</param>
        /// 
        /// <returns>Returns a  CreateTermsResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CreateTerms">REST API Reference for CreateTerms Operation</seealso>
        public virtual CreateTermsResponse EndCreateTerms(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateTermsResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateUserImportJob

        /// <summary>
        /// Creates a user import job. You can import users into user pools from a comma-separated
        /// values (CSV) file without adding Amazon Cognito MAU costs to your Amazon Web Services
        /// bill.
        /// 
        ///  <note> 
        /// <para>
        /// Amazon Cognito evaluates Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you must use IAM credentials to authorize
        /// requests, and you must grant yourself the corresponding IAM permission in a policy.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
        /// Amazon Web Services API Requests</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a> 
        /// </para>
        ///  </li> </ul> </note>
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
        public virtual CreateUserImportJobResponse CreateUserImportJob(CreateUserImportJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateUserImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserImportJobResponseUnmarshaller.Instance;

            return Invoke<CreateUserImportJobResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginCreateUserImportJob(CreateUserImportJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateUserImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserImportJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateUserImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateUserImportJob.</param>
        /// 
        /// <returns>Returns a  CreateUserImportJobResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CreateUserImportJob">REST API Reference for CreateUserImportJob Operation</seealso>
        public virtual CreateUserImportJobResponse EndCreateUserImportJob(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateUserImportJobResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateUserPool

        /// <summary>
        /// Creates a new Amazon Cognito user pool. This operation sets basic and advanced configuration
        /// options.
        /// 
        ///  <important> 
        /// <para>
        /// If you don't provide a value for an attribute, Amazon Cognito sets it to its default
        /// value.
        /// </para>
        ///  </important> <note> 
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
        /// Services service, Amazon Simple Notification Service might place your account in the
        /// SMS sandbox. In <i> <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-sms-sandbox.html">sandbox
        /// mode</a> </i>, you can send messages only to verified phone numbers. After you test
        /// your app while in the sandbox environment, you can move out of the sandbox and into
        /// production. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pool-sms-settings.html">
        /// SMS message settings for Amazon Cognito user pools</a> in the <i>Amazon Cognito Developer
        /// Guide</i>.
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// Amazon Cognito evaluates Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you must use IAM credentials to authorize
        /// requests, and you must grant yourself the corresponding IAM permission in a policy.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
        /// Amazon Web Services API Requests</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a> 
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUserPool service method.</param>
        /// 
        /// <returns>The response from the CreateUserPool service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.FeatureUnavailableInTierException">
        /// This exception is thrown when a feature you attempted to configure isn't available
        /// in your current feature plan.
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
        /// for SMS configuration. This can happen if you don't trust <c>cognito-idp.amazonaws.com</c>
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
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TierChangeNotAllowedException">
        /// This exception is thrown when you've attempted to change your feature plan but the
        /// operation isn't permitted.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UserPoolTaggingException">
        /// This exception is thrown when a user pool tag can't be set or updated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CreateUserPool">REST API Reference for CreateUserPool Operation</seealso>
        public virtual CreateUserPoolResponse CreateUserPool(CreateUserPoolRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateUserPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserPoolResponseUnmarshaller.Instance;

            return Invoke<CreateUserPoolResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CreateUserPool">REST API Reference for CreateUserPool Operation</seealso>
        public virtual IAsyncResult BeginCreateUserPool(CreateUserPoolRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateUserPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserPoolResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateUserPool operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateUserPool.</param>
        /// 
        /// <returns>Returns a  CreateUserPoolResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CreateUserPool">REST API Reference for CreateUserPool Operation</seealso>
        public virtual CreateUserPoolResponse EndCreateUserPool(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateUserPoolResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateUserPoolClient

        /// <summary>
        /// Creates an app client in a user pool. This operation sets basic and advanced configuration
        /// options.
        /// 
        ///  
        /// <para>
        /// Unlike app clients created in the console, Amazon Cognito doesn't automatically assign
        /// a branding style to app clients that you configure with this API operation. Managed
        /// login and classic hosted UI pages aren't available for your client until after you
        /// apply a branding style.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you don't provide a value for an attribute, Amazon Cognito sets it to its default
        /// value.
        /// </para>
        ///  </important> <note> 
        /// <para>
        /// Amazon Cognito evaluates Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you must use IAM credentials to authorize
        /// requests, and you must grant yourself the corresponding IAM permission in a policy.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
        /// Amazon Web Services API Requests</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a> 
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUserPoolClient service method.</param>
        /// 
        /// <returns>The response from the CreateUserPoolClient service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.FeatureUnavailableInTierException">
        /// This exception is thrown when a feature you attempted to configure isn't available
        /// in your current feature plan.
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
        public virtual CreateUserPoolClientResponse CreateUserPoolClient(CreateUserPoolClientRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateUserPoolClientRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserPoolClientResponseUnmarshaller.Instance;

            return Invoke<CreateUserPoolClientResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CreateUserPoolClient">REST API Reference for CreateUserPoolClient Operation</seealso>
        public virtual IAsyncResult BeginCreateUserPoolClient(CreateUserPoolClientRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateUserPoolClientRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserPoolClientResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateUserPoolClient operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateUserPoolClient.</param>
        /// 
        /// <returns>Returns a  CreateUserPoolClientResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CreateUserPoolClient">REST API Reference for CreateUserPoolClient Operation</seealso>
        public virtual CreateUserPoolClientResponse EndCreateUserPoolClient(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateUserPoolClientResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateUserPoolDomain

        /// <summary>
        /// A user pool domain hosts managed login, an authorization server and web server for
        /// authentication in your application. This operation creates a new user pool prefix
        /// domain or custom domain and sets the managed login branding version. Set the branding
        /// version to <c>1</c> for hosted UI (classic) or <c>2</c> for managed login. When you
        /// choose a custom domain, you must provide an SSL certificate in the US East (N. Virginia)
        /// Amazon Web Services Region in your request.
        /// 
        ///  
        /// <para>
        /// Your prefix domain might take up to one minute to take effect. Your custom domain
        /// is online within five minutes, but it can take up to one hour to distribute your SSL
        /// certificate.
        /// </para>
        ///  
        /// <para>
        /// For more information about adding a custom domain to your user pool, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pools-add-custom-domain.html">Configuring
        /// a user pool domain</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon Cognito evaluates Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you must use IAM credentials to authorize
        /// requests, and you must grant yourself the corresponding IAM permission in a policy.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
        /// Amazon Web Services API Requests</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a> 
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUserPoolDomain service method.</param>
        /// 
        /// <returns>The response from the CreateUserPoolDomain service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ConcurrentModificationException">
        /// This exception is thrown if two or more modifications are happening concurrently.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.FeatureUnavailableInTierException">
        /// This exception is thrown when a feature you attempted to configure isn't available
        /// in your current feature plan.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CreateUserPoolDomain">REST API Reference for CreateUserPoolDomain Operation</seealso>
        public virtual CreateUserPoolDomainResponse CreateUserPoolDomain(CreateUserPoolDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateUserPoolDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserPoolDomainResponseUnmarshaller.Instance;

            return Invoke<CreateUserPoolDomainResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginCreateUserPoolDomain(CreateUserPoolDomainRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateUserPoolDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserPoolDomainResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateUserPoolDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateUserPoolDomain.</param>
        /// 
        /// <returns>Returns a  CreateUserPoolDomainResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CreateUserPoolDomain">REST API Reference for CreateUserPoolDomain Operation</seealso>
        public virtual CreateUserPoolDomainResponse EndCreateUserPoolDomain(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateUserPoolDomainResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteGroup

        /// <summary>
        /// Deletes a group from the specified user pool. When you delete a group, that group
        /// no longer contributes to users' <c>cognito:preferred_group</c> or <c>cognito:groups</c>
        /// claims, and no longer influence access-control decision that are based on group membership.
        /// For more information about user pool groups, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pools-user-groups.html">Adding
        /// groups to a user pool</a>.
        /// 
        ///  <note> 
        /// <para>
        /// Amazon Cognito evaluates Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you must use IAM credentials to authorize
        /// requests, and you must grant yourself the corresponding IAM permission in a policy.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
        /// Amazon Web Services API Requests</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a> 
        /// </para>
        ///  </li> </ul> </note>
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
        public virtual DeleteGroupResponse DeleteGroup(DeleteGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteGroupResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginDeleteGroup(DeleteGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteGroup.</param>
        /// 
        /// <returns>Returns a  DeleteGroupResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        public virtual DeleteGroupResponse EndDeleteGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteIdentityProvider

        /// <summary>
        /// Deletes a user pool identity provider (IdP). After you delete an IdP, users can no
        /// longer sign in to your user pool through that IdP. For more information about user
        /// pool IdPs, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pools-identity-federation.html">Third-party
        /// IdP sign-in</a>.
        /// 
        ///  <note> 
        /// <para>
        /// Amazon Cognito evaluates Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you must use IAM credentials to authorize
        /// requests, and you must grant yourself the corresponding IAM permission in a policy.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
        /// Amazon Web Services API Requests</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a> 
        /// </para>
        ///  </li> </ul> </note>
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
        public virtual DeleteIdentityProviderResponse DeleteIdentityProvider(DeleteIdentityProviderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteIdentityProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIdentityProviderResponseUnmarshaller.Instance;

            return Invoke<DeleteIdentityProviderResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginDeleteIdentityProvider(DeleteIdentityProviderRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteIdentityProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIdentityProviderResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteIdentityProvider operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteIdentityProvider.</param>
        /// 
        /// <returns>Returns a  DeleteIdentityProviderResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteIdentityProvider">REST API Reference for DeleteIdentityProvider Operation</seealso>
        public virtual DeleteIdentityProviderResponse EndDeleteIdentityProvider(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteIdentityProviderResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteManagedLoginBranding

        /// <summary>
        /// Deletes a managed login branding style. When you delete a style, you delete the branding
        /// association for an app client. When an app client doesn't have a style assigned, your
        /// managed login pages for that app client are nonfunctional until you create a new style
        /// or switch the domain branding version.
        /// 
        ///  <note> 
        /// <para>
        /// Amazon Cognito evaluates Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you must use IAM credentials to authorize
        /// requests, and you must grant yourself the corresponding IAM permission in a policy.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
        /// Amazon Web Services API Requests</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a> 
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteManagedLoginBranding service method.</param>
        /// 
        /// <returns>The response from the DeleteManagedLoginBranding service method, as returned by CognitoIdentityProvider.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteManagedLoginBranding">REST API Reference for DeleteManagedLoginBranding Operation</seealso>
        public virtual DeleteManagedLoginBrandingResponse DeleteManagedLoginBranding(DeleteManagedLoginBrandingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteManagedLoginBrandingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteManagedLoginBrandingResponseUnmarshaller.Instance;

            return Invoke<DeleteManagedLoginBrandingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteManagedLoginBranding operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteManagedLoginBranding operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteManagedLoginBranding
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteManagedLoginBranding">REST API Reference for DeleteManagedLoginBranding Operation</seealso>
        public virtual IAsyncResult BeginDeleteManagedLoginBranding(DeleteManagedLoginBrandingRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteManagedLoginBrandingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteManagedLoginBrandingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteManagedLoginBranding operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteManagedLoginBranding.</param>
        /// 
        /// <returns>Returns a  DeleteManagedLoginBrandingResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteManagedLoginBranding">REST API Reference for DeleteManagedLoginBranding Operation</seealso>
        public virtual DeleteManagedLoginBrandingResponse EndDeleteManagedLoginBranding(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteManagedLoginBrandingResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteResourceServer

        /// <summary>
        /// Deletes a resource server. After you delete a resource server, users can no longer
        /// generate access tokens with scopes that are associate with that resource server.
        /// 
        ///  
        /// <para>
        /// Resource servers are associated with custom scopes and machine-to-machine (M2M) authorization.
        /// For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pools-define-resource-servers.html">Access
        /// control with resource servers</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon Cognito evaluates Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you must use IAM credentials to authorize
        /// requests, and you must grant yourself the corresponding IAM permission in a policy.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
        /// Amazon Web Services API Requests</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a> 
        /// </para>
        ///  </li> </ul> </note>
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
        public virtual DeleteResourceServerResponse DeleteResourceServer(DeleteResourceServerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResourceServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourceServerResponseUnmarshaller.Instance;

            return Invoke<DeleteResourceServerResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginDeleteResourceServer(DeleteResourceServerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResourceServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourceServerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteResourceServer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteResourceServer.</param>
        /// 
        /// <returns>Returns a  DeleteResourceServerResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteResourceServer">REST API Reference for DeleteResourceServer Operation</seealso>
        public virtual DeleteResourceServerResponse EndDeleteResourceServer(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteResourceServerResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteTerms

        /// <summary>
        /// Deletes the terms documents with the requested ID from your app client.
        /// 
        ///  <note> 
        /// <para>
        /// Amazon Cognito evaluates Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you must use IAM credentials to authorize
        /// requests, and you must grant yourself the corresponding IAM permission in a policy.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
        /// Amazon Web Services API Requests</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a> 
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTerms service method.</param>
        /// 
        /// <returns>The response from the DeleteTerms service method, as returned by CognitoIdentityProvider.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteTerms">REST API Reference for DeleteTerms Operation</seealso>
        public virtual DeleteTermsResponse DeleteTerms(DeleteTermsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTermsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTermsResponseUnmarshaller.Instance;

            return Invoke<DeleteTermsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTerms operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTerms operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTerms
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteTerms">REST API Reference for DeleteTerms Operation</seealso>
        public virtual IAsyncResult BeginDeleteTerms(DeleteTermsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTermsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTermsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTerms operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTerms.</param>
        /// 
        /// <returns>Returns a  DeleteTermsResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteTerms">REST API Reference for DeleteTerms Operation</seealso>
        public virtual DeleteTermsResponse EndDeleteTerms(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteTermsResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteUser

        /// <summary>
        /// Deletes the profile of the currently signed-in user. A deleted user profile can no
        /// longer be used to sign in and can't be restored.
        /// 
        ///  
        /// <para>
        /// Authorize this action with a signed-in user's access token. It must include the scope
        /// <c>aws.cognito.signin.user.admin</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon Cognito doesn't evaluate Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you can't use IAM credentials to authorize
        /// requests, and you can't grant IAM permissions in policies. For more information about
        /// authorization models in Amazon Cognito, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a>.
        /// </para>
        ///  </note>
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
        public virtual DeleteUserResponse DeleteUser(DeleteUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserResponseUnmarshaller.Instance;

            return Invoke<DeleteUserResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        public virtual IAsyncResult BeginDeleteUser(DeleteUserRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUser.</param>
        /// 
        /// <returns>Returns a  DeleteUserResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        public virtual DeleteUserResponse EndDeleteUser(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteUserResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteUserAttributes

        /// <summary>
        /// Deletes attributes from the currently signed-in user. For example, your application
        /// can submit a request to this operation when a user wants to remove their <c>birthdate</c>
        /// attribute value.
        /// 
        ///  
        /// <para>
        /// Authorize this action with a signed-in user's access token. It must include the scope
        /// <c>aws.cognito.signin.user.admin</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon Cognito doesn't evaluate Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you can't use IAM credentials to authorize
        /// requests, and you can't grant IAM permissions in policies. For more information about
        /// authorization models in Amazon Cognito, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a>.
        /// </para>
        ///  </note>
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
        public virtual DeleteUserAttributesResponse DeleteUserAttributes(DeleteUserAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserAttributesResponseUnmarshaller.Instance;

            return Invoke<DeleteUserAttributesResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteUserAttributes">REST API Reference for DeleteUserAttributes Operation</seealso>
        public virtual IAsyncResult BeginDeleteUserAttributes(DeleteUserAttributesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserAttributesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteUserAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUserAttributes.</param>
        /// 
        /// <returns>Returns a  DeleteUserAttributesResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteUserAttributes">REST API Reference for DeleteUserAttributes Operation</seealso>
        public virtual DeleteUserAttributesResponse EndDeleteUserAttributes(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteUserAttributesResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteUserPool

        /// <summary>
        /// Deletes a user pool. After you delete a user pool, users can no longer sign in to
        /// any associated applications. 
        /// 
        ///  
        /// <para>
        /// When you delete a user pool, it's no longer visible or operational in your Amazon
        /// Web Services account. Amazon Cognito retains deleted user pools in an inactive state
        /// for 14 days, then begins a cleanup process that fully removes them from Amazon Web
        /// Services systems. In case of accidental deletion, contact Amazon Web ServicesSupport
        /// within 14 days for restoration assistance.
        /// </para>
        ///  
        /// <para>
        /// Amazon Cognito begins full deletion of all resources from deleted user pools after
        /// 14 days. In the case of large user pools, the cleanup process might take significant
        /// additional time before all user data is permanently deleted.
        /// </para>
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
        public virtual DeleteUserPoolResponse DeleteUserPool(DeleteUserPoolRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserPoolResponseUnmarshaller.Instance;

            return Invoke<DeleteUserPoolResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteUserPool">REST API Reference for DeleteUserPool Operation</seealso>
        public virtual IAsyncResult BeginDeleteUserPool(DeleteUserPoolRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserPoolResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteUserPool operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUserPool.</param>
        /// 
        /// <returns>Returns a  DeleteUserPoolResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteUserPool">REST API Reference for DeleteUserPool Operation</seealso>
        public virtual DeleteUserPoolResponse EndDeleteUserPool(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteUserPoolResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteUserPoolClient

        /// <summary>
        /// Deletes a user pool app client. After you delete an app client, users can no longer
        /// sign in to the associated application.
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
        public virtual DeleteUserPoolClientResponse DeleteUserPoolClient(DeleteUserPoolClientRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserPoolClientRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserPoolClientResponseUnmarshaller.Instance;

            return Invoke<DeleteUserPoolClientResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteUserPoolClient">REST API Reference for DeleteUserPoolClient Operation</seealso>
        public virtual IAsyncResult BeginDeleteUserPoolClient(DeleteUserPoolClientRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserPoolClientRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserPoolClientResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteUserPoolClient operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUserPoolClient.</param>
        /// 
        /// <returns>Returns a  DeleteUserPoolClientResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteUserPoolClient">REST API Reference for DeleteUserPoolClient Operation</seealso>
        public virtual DeleteUserPoolClientResponse EndDeleteUserPoolClient(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteUserPoolClientResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteUserPoolDomain

        /// <summary>
        /// Given a user pool ID and domain identifier, deletes a user pool domain. After you
        /// delete a user pool domain, your managed login pages and authorization server are no
        /// longer available.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserPoolDomain service method.</param>
        /// 
        /// <returns>The response from the DeleteUserPoolDomain service method, as returned by CognitoIdentityProvider.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteUserPoolDomain">REST API Reference for DeleteUserPoolDomain Operation</seealso>
        public virtual DeleteUserPoolDomainResponse DeleteUserPoolDomain(DeleteUserPoolDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserPoolDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserPoolDomainResponseUnmarshaller.Instance;

            return Invoke<DeleteUserPoolDomainResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginDeleteUserPoolDomain(DeleteUserPoolDomainRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserPoolDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserPoolDomainResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteUserPoolDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUserPoolDomain.</param>
        /// 
        /// <returns>Returns a  DeleteUserPoolDomainResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteUserPoolDomain">REST API Reference for DeleteUserPoolDomain Operation</seealso>
        public virtual DeleteUserPoolDomainResponse EndDeleteUserPoolDomain(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteUserPoolDomainResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteWebAuthnCredential

        /// <summary>
        /// Deletes a registered passkey, or WebAuthn, authenticator for the currently signed-in
        /// user.
        /// 
        ///  
        /// <para>
        /// Authorize this action with a signed-in user's access token. It must include the scope
        /// <c>aws.cognito.signin.user.admin</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon Cognito doesn't evaluate Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you can't use IAM credentials to authorize
        /// requests, and you can't grant IAM permissions in policies. For more information about
        /// authorization models in Amazon Cognito, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWebAuthnCredential service method.</param>
        /// 
        /// <returns>The response from the DeleteWebAuthnCredential service method, as returned by CognitoIdentityProvider.</returns>
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
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ResourceNotFoundException">
        /// This exception is thrown when the Amazon Cognito service can't find the requested
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteWebAuthnCredential">REST API Reference for DeleteWebAuthnCredential Operation</seealso>
        public virtual DeleteWebAuthnCredentialResponse DeleteWebAuthnCredential(DeleteWebAuthnCredentialRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWebAuthnCredentialRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWebAuthnCredentialResponseUnmarshaller.Instance;

            return Invoke<DeleteWebAuthnCredentialResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteWebAuthnCredential operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWebAuthnCredential operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWebAuthnCredential
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteWebAuthnCredential">REST API Reference for DeleteWebAuthnCredential Operation</seealso>
        public virtual IAsyncResult BeginDeleteWebAuthnCredential(DeleteWebAuthnCredentialRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWebAuthnCredentialRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWebAuthnCredentialResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWebAuthnCredential operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWebAuthnCredential.</param>
        /// 
        /// <returns>Returns a  DeleteWebAuthnCredentialResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteWebAuthnCredential">REST API Reference for DeleteWebAuthnCredential Operation</seealso>
        public virtual DeleteWebAuthnCredentialResponse EndDeleteWebAuthnCredential(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteWebAuthnCredentialResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeIdentityProvider

        /// <summary>
        /// Given a user pool ID and identity provider (IdP) name, returns details about the IdP.
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
        public virtual DescribeIdentityProviderResponse DescribeIdentityProvider(DescribeIdentityProviderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeIdentityProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeIdentityProviderResponseUnmarshaller.Instance;

            return Invoke<DescribeIdentityProviderResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginDescribeIdentityProvider(DescribeIdentityProviderRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeIdentityProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeIdentityProviderResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeIdentityProvider operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeIdentityProvider.</param>
        /// 
        /// <returns>Returns a  DescribeIdentityProviderResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeIdentityProvider">REST API Reference for DescribeIdentityProvider Operation</seealso>
        public virtual DescribeIdentityProviderResponse EndDescribeIdentityProvider(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeIdentityProviderResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeManagedLoginBranding

        /// <summary>
        /// Given the ID of a managed login branding style, returns detailed information about
        /// the style.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeManagedLoginBranding service method.</param>
        /// 
        /// <returns>The response from the DescribeManagedLoginBranding service method, as returned by CognitoIdentityProvider.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeManagedLoginBranding">REST API Reference for DescribeManagedLoginBranding Operation</seealso>
        public virtual DescribeManagedLoginBrandingResponse DescribeManagedLoginBranding(DescribeManagedLoginBrandingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeManagedLoginBrandingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeManagedLoginBrandingResponseUnmarshaller.Instance;

            return Invoke<DescribeManagedLoginBrandingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeManagedLoginBranding operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeManagedLoginBranding operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeManagedLoginBranding
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeManagedLoginBranding">REST API Reference for DescribeManagedLoginBranding Operation</seealso>
        public virtual IAsyncResult BeginDescribeManagedLoginBranding(DescribeManagedLoginBrandingRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeManagedLoginBrandingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeManagedLoginBrandingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeManagedLoginBranding operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeManagedLoginBranding.</param>
        /// 
        /// <returns>Returns a  DescribeManagedLoginBrandingResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeManagedLoginBranding">REST API Reference for DescribeManagedLoginBranding Operation</seealso>
        public virtual DescribeManagedLoginBrandingResponse EndDescribeManagedLoginBranding(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeManagedLoginBrandingResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeManagedLoginBrandingByClient

        /// <summary>
        /// Given the ID of a user pool app client, returns detailed information about the style
        /// assigned to the app client.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeManagedLoginBrandingByClient service method.</param>
        /// 
        /// <returns>The response from the DescribeManagedLoginBrandingByClient service method, as returned by CognitoIdentityProvider.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeManagedLoginBrandingByClient">REST API Reference for DescribeManagedLoginBrandingByClient Operation</seealso>
        public virtual DescribeManagedLoginBrandingByClientResponse DescribeManagedLoginBrandingByClient(DescribeManagedLoginBrandingByClientRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeManagedLoginBrandingByClientRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeManagedLoginBrandingByClientResponseUnmarshaller.Instance;

            return Invoke<DescribeManagedLoginBrandingByClientResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeManagedLoginBrandingByClient operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeManagedLoginBrandingByClient operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeManagedLoginBrandingByClient
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeManagedLoginBrandingByClient">REST API Reference for DescribeManagedLoginBrandingByClient Operation</seealso>
        public virtual IAsyncResult BeginDescribeManagedLoginBrandingByClient(DescribeManagedLoginBrandingByClientRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeManagedLoginBrandingByClientRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeManagedLoginBrandingByClientResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeManagedLoginBrandingByClient operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeManagedLoginBrandingByClient.</param>
        /// 
        /// <returns>Returns a  DescribeManagedLoginBrandingByClientResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeManagedLoginBrandingByClient">REST API Reference for DescribeManagedLoginBrandingByClient Operation</seealso>
        public virtual DescribeManagedLoginBrandingByClientResponse EndDescribeManagedLoginBrandingByClient(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeManagedLoginBrandingByClientResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeResourceServer

        /// <summary>
        /// Describes a resource server. For more information about resource servers, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pools-define-resource-servers.html">Access
        /// control with resource servers</a>.
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
        public virtual DescribeResourceServerResponse DescribeResourceServer(DescribeResourceServerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeResourceServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeResourceServerResponseUnmarshaller.Instance;

            return Invoke<DescribeResourceServerResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginDescribeResourceServer(DescribeResourceServerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeResourceServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeResourceServerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeResourceServer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeResourceServer.</param>
        /// 
        /// <returns>Returns a  DescribeResourceServerResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeResourceServer">REST API Reference for DescribeResourceServer Operation</seealso>
        public virtual DescribeResourceServerResponse EndDescribeResourceServer(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeResourceServerResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeRiskConfiguration

        /// <summary>
        /// Given an app client or user pool ID where threat protection is configured, describes
        /// the risk configuration. This operation returns details about adaptive authentication,
        /// compromised credentials, and IP-address allow- and denylists. For more information
        /// about threat protection, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pool-settings-threat-protection.html">Threat
        /// protection</a>.
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
        public virtual DescribeRiskConfigurationResponse DescribeRiskConfiguration(DescribeRiskConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRiskConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRiskConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeRiskConfigurationResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginDescribeRiskConfiguration(DescribeRiskConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRiskConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRiskConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRiskConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRiskConfiguration.</param>
        /// 
        /// <returns>Returns a  DescribeRiskConfigurationResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeRiskConfiguration">REST API Reference for DescribeRiskConfiguration Operation</seealso>
        public virtual DescribeRiskConfigurationResponse EndDescribeRiskConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeRiskConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeTerms

        /// <summary>
        /// Returns details for the requested terms documents ID. For more information, see <a
        /// href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pools-managed-login.html#managed-login-terms-documents">Terms
        /// documents</a>.
        /// 
        ///  <note> 
        /// <para>
        /// Amazon Cognito evaluates Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you must use IAM credentials to authorize
        /// requests, and you must grant yourself the corresponding IAM permission in a policy.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
        /// Amazon Web Services API Requests</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a> 
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTerms service method.</param>
        /// 
        /// <returns>The response from the DescribeTerms service method, as returned by CognitoIdentityProvider.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeTerms">REST API Reference for DescribeTerms Operation</seealso>
        public virtual DescribeTermsResponse DescribeTerms(DescribeTermsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTermsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTermsResponseUnmarshaller.Instance;

            return Invoke<DescribeTermsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTerms operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTerms operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTerms
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeTerms">REST API Reference for DescribeTerms Operation</seealso>
        public virtual IAsyncResult BeginDescribeTerms(DescribeTermsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTermsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTermsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTerms operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTerms.</param>
        /// 
        /// <returns>Returns a  DescribeTermsResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeTerms">REST API Reference for DescribeTerms Operation</seealso>
        public virtual DescribeTermsResponse EndDescribeTerms(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeTermsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeUserImportJob

        /// <summary>
        /// Describes a user import job. For more information about user CSV import, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pools-using-import-tool.html">Importing
        /// users from a CSV file</a>.
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
        public virtual DescribeUserImportJobResponse DescribeUserImportJob(DescribeUserImportJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeUserImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUserImportJobResponseUnmarshaller.Instance;

            return Invoke<DescribeUserImportJobResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginDescribeUserImportJob(DescribeUserImportJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeUserImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUserImportJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeUserImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeUserImportJob.</param>
        /// 
        /// <returns>Returns a  DescribeUserImportJobResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeUserImportJob">REST API Reference for DescribeUserImportJob Operation</seealso>
        public virtual DescribeUserImportJobResponse EndDescribeUserImportJob(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeUserImportJobResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeUserPool

        /// <summary>
        /// Given a user pool ID, returns configuration information. This operation is useful
        /// when you want to inspect an existing user pool and programmatically replicate the
        /// configuration to another user pool.
        /// 
        ///  <note> 
        /// <para>
        /// Amazon Cognito evaluates Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you must use IAM credentials to authorize
        /// requests, and you must grant yourself the corresponding IAM permission in a policy.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
        /// Amazon Web Services API Requests</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a> 
        /// </para>
        ///  </li> </ul> </note>
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
        public virtual DescribeUserPoolResponse DescribeUserPool(DescribeUserPoolRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeUserPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUserPoolResponseUnmarshaller.Instance;

            return Invoke<DescribeUserPoolResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeUserPool">REST API Reference for DescribeUserPool Operation</seealso>
        public virtual IAsyncResult BeginDescribeUserPool(DescribeUserPoolRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeUserPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUserPoolResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeUserPool operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeUserPool.</param>
        /// 
        /// <returns>Returns a  DescribeUserPoolResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeUserPool">REST API Reference for DescribeUserPool Operation</seealso>
        public virtual DescribeUserPoolResponse EndDescribeUserPool(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeUserPoolResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeUserPoolClient

        /// <summary>
        /// Given an app client ID, returns configuration information. This operation is useful
        /// when you want to inspect an existing app client and programmatically replicate the
        /// configuration to another app client. For more information about app clients, see <a
        /// href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pool-settings-client-apps.html">App
        /// clients</a>.
        /// 
        ///  <note> 
        /// <para>
        /// Amazon Cognito evaluates Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you must use IAM credentials to authorize
        /// requests, and you must grant yourself the corresponding IAM permission in a policy.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
        /// Amazon Web Services API Requests</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a> 
        /// </para>
        ///  </li> </ul> </note>
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
        public virtual DescribeUserPoolClientResponse DescribeUserPoolClient(DescribeUserPoolClientRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeUserPoolClientRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUserPoolClientResponseUnmarshaller.Instance;

            return Invoke<DescribeUserPoolClientResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeUserPoolClient">REST API Reference for DescribeUserPoolClient Operation</seealso>
        public virtual IAsyncResult BeginDescribeUserPoolClient(DescribeUserPoolClientRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeUserPoolClientRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUserPoolClientResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeUserPoolClient operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeUserPoolClient.</param>
        /// 
        /// <returns>Returns a  DescribeUserPoolClientResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeUserPoolClient">REST API Reference for DescribeUserPoolClient Operation</seealso>
        public virtual DescribeUserPoolClientResponse EndDescribeUserPoolClient(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeUserPoolClientResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeUserPoolDomain

        /// <summary>
        /// Given a user pool domain name, returns information about the domain configuration.
        /// 
        ///  <note> 
        /// <para>
        /// Amazon Cognito evaluates Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you must use IAM credentials to authorize
        /// requests, and you must grant yourself the corresponding IAM permission in a policy.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
        /// Amazon Web Services API Requests</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a> 
        /// </para>
        ///  </li> </ul> </note>
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
        public virtual DescribeUserPoolDomainResponse DescribeUserPoolDomain(DescribeUserPoolDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeUserPoolDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUserPoolDomainResponseUnmarshaller.Instance;

            return Invoke<DescribeUserPoolDomainResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginDescribeUserPoolDomain(DescribeUserPoolDomainRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeUserPoolDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUserPoolDomainResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeUserPoolDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeUserPoolDomain.</param>
        /// 
        /// <returns>Returns a  DescribeUserPoolDomainResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeUserPoolDomain">REST API Reference for DescribeUserPoolDomain Operation</seealso>
        public virtual DescribeUserPoolDomainResponse EndDescribeUserPoolDomain(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeUserPoolDomainResponse>(asyncResult);
        }

        #endregion
        
        #region  ForgetDevice

        /// <summary>
        /// Given a device key, deletes a remembered device as the currently signed-in user. For
        /// more information about device authentication, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/amazon-cognito-user-pools-device-tracking.html">Working
        /// with user devices in your user pool</a>.
        /// 
        ///  
        /// <para>
        /// Authorize this action with a signed-in user's access token. It must include the scope
        /// <c>aws.cognito.signin.user.admin</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon Cognito doesn't evaluate Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you can't use IAM credentials to authorize
        /// requests, and you can't grant IAM permissions in policies. For more information about
        /// authorization models in Amazon Cognito, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a>.
        /// </para>
        ///  </note>
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
        public virtual ForgetDeviceResponse ForgetDevice(ForgetDeviceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ForgetDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ForgetDeviceResponseUnmarshaller.Instance;

            return Invoke<ForgetDeviceResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginForgetDevice(ForgetDeviceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ForgetDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ForgetDeviceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ForgetDevice operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginForgetDevice.</param>
        /// 
        /// <returns>Returns a  ForgetDeviceResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ForgetDevice">REST API Reference for ForgetDevice Operation</seealso>
        public virtual ForgetDeviceResponse EndForgetDevice(IAsyncResult asyncResult)
        {
            return EndInvoke<ForgetDeviceResponse>(asyncResult);
        }

        #endregion
        
        #region  ForgotPassword

        /// <summary>
        /// Sends a password-reset confirmation code to the email address or phone number of the
        /// requested username. The message delivery method is determined by the user's available
        /// attributes and the <c>AccountRecoverySetting</c> configuration of the user pool.
        /// 
        ///  
        /// <para>
        /// For the <c>Username</c> parameter, you can use the username or an email, phone, or
        /// preferred username alias.
        /// </para>
        ///  
        /// <para>
        /// If neither a verified phone number nor a verified email exists, Amazon Cognito responds
        /// with an <c>InvalidParameterException</c> error . If your app client has a client secret
        /// and you don't provide a <c>SECRET_HASH</c> parameter, this API returns <c>NotAuthorizedException</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon Cognito doesn't evaluate Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you can't use IAM credentials to authorize
        /// requests, and you can't grant IAM permissions in policies. For more information about
        /// authorization models in Amazon Cognito, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a>.
        /// </para>
        ///  </note> <note> 
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
        /// Services service, Amazon Simple Notification Service might place your account in the
        /// SMS sandbox. In <i> <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-sms-sandbox.html">sandbox
        /// mode</a> </i>, you can send messages only to verified phone numbers. After you test
        /// your app while in the sandbox environment, you can move out of the sandbox and into
        /// production. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pool-sms-settings.html">
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
        /// for SMS configuration. This can happen if you don't trust <c>cognito-idp.amazonaws.com</c>
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
        public virtual ForgotPasswordResponse ForgotPassword(ForgotPasswordRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ForgotPasswordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ForgotPasswordResponseUnmarshaller.Instance;

            return Invoke<ForgotPasswordResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ForgotPassword">REST API Reference for ForgotPassword Operation</seealso>
        public virtual IAsyncResult BeginForgotPassword(ForgotPasswordRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ForgotPasswordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ForgotPasswordResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ForgotPassword operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginForgotPassword.</param>
        /// 
        /// <returns>Returns a  ForgotPasswordResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ForgotPassword">REST API Reference for ForgotPassword Operation</seealso>
        public virtual ForgotPasswordResponse EndForgotPassword(IAsyncResult asyncResult)
        {
            return EndInvoke<ForgotPasswordResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCSVHeader

        /// <summary>
        /// Given a user pool ID, generates a comma-separated value (CSV) list populated with
        /// available user attributes in the user pool. This list is the header for the CSV file
        /// that determines the users in a user import job. Save the content of <c>CSVHeader</c>
        /// in the response as a <c>.csv</c> file and populate it with the usernames and attributes
        /// of users that you want to import. For more information about CSV user import, see
        /// <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pools-using-import-tool.html">Importing
        /// users from a CSV file</a>.
        /// 
        ///  <note> 
        /// <para>
        /// Amazon Cognito evaluates Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you must use IAM credentials to authorize
        /// requests, and you must grant yourself the corresponding IAM permission in a policy.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
        /// Amazon Web Services API Requests</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a> 
        /// </para>
        ///  </li> </ul> </note>
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
        public virtual GetCSVHeaderResponse GetCSVHeader(GetCSVHeaderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCSVHeaderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCSVHeaderResponseUnmarshaller.Instance;

            return Invoke<GetCSVHeaderResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginGetCSVHeader(GetCSVHeaderRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCSVHeaderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCSVHeaderResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCSVHeader operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCSVHeader.</param>
        /// 
        /// <returns>Returns a  GetCSVHeaderResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetCSVHeader">REST API Reference for GetCSVHeader Operation</seealso>
        public virtual GetCSVHeaderResponse EndGetCSVHeader(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCSVHeaderResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDevice

        /// <summary>
        /// Given a device key, returns information about a remembered device for the current
        /// user. For more information about device authentication, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/amazon-cognito-user-pools-device-tracking.html">Working
        /// with user devices in your user pool</a>.
        /// 
        ///  
        /// <para>
        /// Authorize this action with a signed-in user's access token. It must include the scope
        /// <c>aws.cognito.signin.user.admin</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon Cognito doesn't evaluate Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you can't use IAM credentials to authorize
        /// requests, and you can't grant IAM permissions in policies. For more information about
        /// authorization models in Amazon Cognito, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a>.
        /// </para>
        ///  </note>
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
        public virtual GetDeviceResponse GetDevice(GetDeviceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeviceResponseUnmarshaller.Instance;

            return Invoke<GetDeviceResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginGetDevice(GetDeviceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeviceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDevice operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDevice.</param>
        /// 
        /// <returns>Returns a  GetDeviceResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetDevice">REST API Reference for GetDevice Operation</seealso>
        public virtual GetDeviceResponse EndGetDevice(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDeviceResponse>(asyncResult);
        }

        #endregion
        
        #region  GetGroup

        /// <summary>
        /// Given a user pool ID and a group name, returns information about the user group.
        /// 
        ///  
        /// <para>
        ///  For more information about user pool groups, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pools-user-groups.html">Adding
        /// groups to a user pool</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon Cognito evaluates Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you must use IAM credentials to authorize
        /// requests, and you must grant yourself the corresponding IAM permission in a policy.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
        /// Amazon Web Services API Requests</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a> 
        /// </para>
        ///  </li> </ul> </note>
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
        public virtual GetGroupResponse GetGroup(GetGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGroupResponseUnmarshaller.Instance;

            return Invoke<GetGroupResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginGetGroup(GetGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGroup.</param>
        /// 
        /// <returns>Returns a  GetGroupResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetGroup">REST API Reference for GetGroup Operation</seealso>
        public virtual GetGroupResponse EndGetGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<GetGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  GetIdentityProviderByIdentifier

        /// <summary>
        /// Given the identifier of an identity provider (IdP), for example <c>examplecorp</c>,
        /// returns information about the user pool configuration for that IdP. For more information
        /// about IdPs, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pools-identity-federation.html">Third-party
        /// IdP sign-in</a>.
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
        public virtual GetIdentityProviderByIdentifierResponse GetIdentityProviderByIdentifier(GetIdentityProviderByIdentifierRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIdentityProviderByIdentifierRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIdentityProviderByIdentifierResponseUnmarshaller.Instance;

            return Invoke<GetIdentityProviderByIdentifierResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginGetIdentityProviderByIdentifier(GetIdentityProviderByIdentifierRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIdentityProviderByIdentifierRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIdentityProviderByIdentifierResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetIdentityProviderByIdentifier operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetIdentityProviderByIdentifier.</param>
        /// 
        /// <returns>Returns a  GetIdentityProviderByIdentifierResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetIdentityProviderByIdentifier">REST API Reference for GetIdentityProviderByIdentifier Operation</seealso>
        public virtual GetIdentityProviderByIdentifierResponse EndGetIdentityProviderByIdentifier(IAsyncResult asyncResult)
        {
            return EndInvoke<GetIdentityProviderByIdentifierResponse>(asyncResult);
        }

        #endregion
        
        #region  GetLogDeliveryConfiguration

        /// <summary>
        /// Given a user pool ID, returns the logging configuration. User pools can export message-delivery
        /// error and threat-protection activity logs to external Amazon Web Services services.
        /// For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/exporting-quotas-and-usage.html">Exporting
        /// user pool logs</a>.
        /// 
        ///  <note> 
        /// <para>
        /// Amazon Cognito evaluates Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you must use IAM credentials to authorize
        /// requests, and you must grant yourself the corresponding IAM permission in a policy.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
        /// Amazon Web Services API Requests</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a> 
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLogDeliveryConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetLogDeliveryConfiguration service method, as returned by CognitoIdentityProvider.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetLogDeliveryConfiguration">REST API Reference for GetLogDeliveryConfiguration Operation</seealso>
        public virtual GetLogDeliveryConfigurationResponse GetLogDeliveryConfiguration(GetLogDeliveryConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLogDeliveryConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLogDeliveryConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetLogDeliveryConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetLogDeliveryConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLogDeliveryConfiguration operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLogDeliveryConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetLogDeliveryConfiguration">REST API Reference for GetLogDeliveryConfiguration Operation</seealso>
        public virtual IAsyncResult BeginGetLogDeliveryConfiguration(GetLogDeliveryConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLogDeliveryConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLogDeliveryConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetLogDeliveryConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLogDeliveryConfiguration.</param>
        /// 
        /// <returns>Returns a  GetLogDeliveryConfigurationResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetLogDeliveryConfiguration">REST API Reference for GetLogDeliveryConfiguration Operation</seealso>
        public virtual GetLogDeliveryConfigurationResponse EndGetLogDeliveryConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetLogDeliveryConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSigningCertificate

        /// <summary>
        /// Given a user pool ID, returns the signing certificate for SAML 2.0 federation.
        /// 
        ///  
        /// <para>
        /// Issued certificates are valid for 10 years from the date of issue. Amazon Cognito
        /// issues and assigns a new signing certificate annually. This renewal process returns
        /// a new value in the response to <c>GetSigningCertificate</c>, but doesn't invalidate
        /// the original certificate.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pools-SAML-signing-encryption.html#cognito-user-pools-SAML-signing">Signing
        /// SAML requests</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon Cognito evaluates Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you must use IAM credentials to authorize
        /// requests, and you must grant yourself the corresponding IAM permission in a policy.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
        /// Amazon Web Services API Requests</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a> 
        /// </para>
        ///  </li> </ul> </note>
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
        public virtual GetSigningCertificateResponse GetSigningCertificate(GetSigningCertificateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSigningCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSigningCertificateResponseUnmarshaller.Instance;

            return Invoke<GetSigningCertificateResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginGetSigningCertificate(GetSigningCertificateRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSigningCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSigningCertificateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSigningCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSigningCertificate.</param>
        /// 
        /// <returns>Returns a  GetSigningCertificateResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetSigningCertificate">REST API Reference for GetSigningCertificate Operation</seealso>
        public virtual GetSigningCertificateResponse EndGetSigningCertificate(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSigningCertificateResponse>(asyncResult);
        }

        #endregion
        
        #region  GetTokensFromRefreshToken

        /// <summary>
        /// Given a refresh token, issues new ID, access, and optionally refresh tokens for the
        /// user who owns the submitted token. This operation issues a new refresh token and invalidates
        /// the original refresh token after an optional grace period when refresh token rotation
        /// is enabled. If refresh token rotation is disabled, issues new ID and access tokens
        /// only.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTokensFromRefreshToken service method.</param>
        /// 
        /// <returns>The response from the GetTokensFromRefreshToken service method, as returned by CognitoIdentityProvider.</returns>
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
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.NotAuthorizedException">
        /// This exception is thrown when a user isn't authorized.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.RefreshTokenReuseException">
        /// This exception is throw when your application requests token refresh with a refresh
        /// token that has been invalidated by refresh-token rotation.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetTokensFromRefreshToken">REST API Reference for GetTokensFromRefreshToken Operation</seealso>
        public virtual GetTokensFromRefreshTokenResponse GetTokensFromRefreshToken(GetTokensFromRefreshTokenRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTokensFromRefreshTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTokensFromRefreshTokenResponseUnmarshaller.Instance;

            return Invoke<GetTokensFromRefreshTokenResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTokensFromRefreshToken operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTokensFromRefreshToken operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTokensFromRefreshToken
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetTokensFromRefreshToken">REST API Reference for GetTokensFromRefreshToken Operation</seealso>
        public virtual IAsyncResult BeginGetTokensFromRefreshToken(GetTokensFromRefreshTokenRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTokensFromRefreshTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTokensFromRefreshTokenResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTokensFromRefreshToken operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTokensFromRefreshToken.</param>
        /// 
        /// <returns>Returns a  GetTokensFromRefreshTokenResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetTokensFromRefreshToken">REST API Reference for GetTokensFromRefreshToken Operation</seealso>
        public virtual GetTokensFromRefreshTokenResponse EndGetTokensFromRefreshToken(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTokensFromRefreshTokenResponse>(asyncResult);
        }

        #endregion
        
        #region  GetUICustomization

        /// <summary>
        /// Given a user pool ID or app client, returns information about classic hosted UI branding
        /// that you applied, if any. Returns user-pool level branding information if no app client
        /// branding is applied, or if you don't specify an app client ID. Returns an empty object
        /// if you haven't applied hosted UI branding to either the client or the user pool. For
        /// more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/hosted-ui-classic-branding.html">Hosted
        /// UI (classic) branding</a>.
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
        public virtual GetUICustomizationResponse GetUICustomization(GetUICustomizationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUICustomizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUICustomizationResponseUnmarshaller.Instance;

            return Invoke<GetUICustomizationResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginGetUICustomization(GetUICustomizationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUICustomizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUICustomizationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetUICustomization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUICustomization.</param>
        /// 
        /// <returns>Returns a  GetUICustomizationResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetUICustomization">REST API Reference for GetUICustomization Operation</seealso>
        public virtual GetUICustomizationResponse EndGetUICustomization(IAsyncResult asyncResult)
        {
            return EndInvoke<GetUICustomizationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetUser

        /// <summary>
        /// Gets user attributes and and MFA settings for the currently signed-in user.
        /// 
        ///  
        /// <para>
        /// Authorize this action with a signed-in user's access token. It must include the scope
        /// <c>aws.cognito.signin.user.admin</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon Cognito doesn't evaluate Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you can't use IAM credentials to authorize
        /// requests, and you can't grant IAM permissions in policies. For more information about
        /// authorization models in Amazon Cognito, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a>.
        /// </para>
        ///  </note>
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
        public virtual GetUserResponse GetUser(GetUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUserResponseUnmarshaller.Instance;

            return Invoke<GetUserResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetUser">REST API Reference for GetUser Operation</seealso>
        public virtual IAsyncResult BeginGetUser(GetUserRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUserResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUser.</param>
        /// 
        /// <returns>Returns a  GetUserResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetUser">REST API Reference for GetUser Operation</seealso>
        public virtual GetUserResponse EndGetUser(IAsyncResult asyncResult)
        {
            return EndInvoke<GetUserResponse>(asyncResult);
        }

        #endregion
        
        #region  GetUserAttributeVerificationCode

        /// <summary>
        /// Given an attribute name, sends a user attribute verification code for the specified
        /// attribute name to the currently signed-in user.
        /// 
        ///  
        /// <para>
        /// Authorize this action with a signed-in user's access token. It must include the scope
        /// <c>aws.cognito.signin.user.admin</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon Cognito doesn't evaluate Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you can't use IAM credentials to authorize
        /// requests, and you can't grant IAM permissions in policies. For more information about
        /// authorization models in Amazon Cognito, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a>.
        /// </para>
        ///  </note> <note> 
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
        /// Services service, Amazon Simple Notification Service might place your account in the
        /// SMS sandbox. In <i> <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-sms-sandbox.html">sandbox
        /// mode</a> </i>, you can send messages only to verified phone numbers. After you test
        /// your app while in the sandbox environment, you can move out of the sandbox and into
        /// production. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pool-sms-settings.html">
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
        /// for SMS configuration. This can happen if you don't trust <c>cognito-idp.amazonaws.com</c>
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
        public virtual GetUserAttributeVerificationCodeResponse GetUserAttributeVerificationCode(GetUserAttributeVerificationCodeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUserAttributeVerificationCodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUserAttributeVerificationCodeResponseUnmarshaller.Instance;

            return Invoke<GetUserAttributeVerificationCodeResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetUserAttributeVerificationCode">REST API Reference for GetUserAttributeVerificationCode Operation</seealso>
        public virtual IAsyncResult BeginGetUserAttributeVerificationCode(GetUserAttributeVerificationCodeRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUserAttributeVerificationCodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUserAttributeVerificationCodeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetUserAttributeVerificationCode operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUserAttributeVerificationCode.</param>
        /// 
        /// <returns>Returns a  GetUserAttributeVerificationCodeResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetUserAttributeVerificationCode">REST API Reference for GetUserAttributeVerificationCode Operation</seealso>
        public virtual GetUserAttributeVerificationCodeResponse EndGetUserAttributeVerificationCode(IAsyncResult asyncResult)
        {
            return EndInvoke<GetUserAttributeVerificationCodeResponse>(asyncResult);
        }

        #endregion
        
        #region  GetUserAuthFactors

        /// <summary>
        /// Lists the authentication options for the currently signed-in user. Returns the following:
        /// 
        ///  <ol> <li> 
        /// <para>
        /// The user's multi-factor authentication (MFA) preferences.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The user's options for choice-based authentication with the <c>USER_AUTH</c> flow.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// Authorize this action with a signed-in user's access token. It must include the scope
        /// <c>aws.cognito.signin.user.admin</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon Cognito doesn't evaluate Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you can't use IAM credentials to authorize
        /// requests, and you can't grant IAM permissions in policies. For more information about
        /// authorization models in Amazon Cognito, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUserAuthFactors service method.</param>
        /// 
        /// <returns>The response from the GetUserAuthFactors service method, as returned by CognitoIdentityProvider.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetUserAuthFactors">REST API Reference for GetUserAuthFactors Operation</seealso>
        public virtual GetUserAuthFactorsResponse GetUserAuthFactors(GetUserAuthFactorsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUserAuthFactorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUserAuthFactorsResponseUnmarshaller.Instance;

            return Invoke<GetUserAuthFactorsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetUserAuthFactors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUserAuthFactors operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetUserAuthFactors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetUserAuthFactors">REST API Reference for GetUserAuthFactors Operation</seealso>
        public virtual IAsyncResult BeginGetUserAuthFactors(GetUserAuthFactorsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUserAuthFactorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUserAuthFactorsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetUserAuthFactors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUserAuthFactors.</param>
        /// 
        /// <returns>Returns a  GetUserAuthFactorsResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetUserAuthFactors">REST API Reference for GetUserAuthFactors Operation</seealso>
        public virtual GetUserAuthFactorsResponse EndGetUserAuthFactors(IAsyncResult asyncResult)
        {
            return EndInvoke<GetUserAuthFactorsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetUserPoolMfaConfig

        /// <summary>
        /// Given a user pool ID, returns configuration for sign-in with WebAuthn authenticators
        /// and for multi-factor authentication (MFA). This operation describes the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The WebAuthn relying party (RP) ID and user-verification settings.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The required, optional, or disabled state of MFA for all user pool users.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The message templates for email and SMS MFA.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The enabled or disabled state of time-based one-time password (TOTP) MFA.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// Amazon Cognito evaluates Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you must use IAM credentials to authorize
        /// requests, and you must grant yourself the corresponding IAM permission in a policy.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
        /// Amazon Web Services API Requests</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a> 
        /// </para>
        ///  </li> </ul> </note>
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
        public virtual GetUserPoolMfaConfigResponse GetUserPoolMfaConfig(GetUserPoolMfaConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUserPoolMfaConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUserPoolMfaConfigResponseUnmarshaller.Instance;

            return Invoke<GetUserPoolMfaConfigResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginGetUserPoolMfaConfig(GetUserPoolMfaConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUserPoolMfaConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUserPoolMfaConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetUserPoolMfaConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUserPoolMfaConfig.</param>
        /// 
        /// <returns>Returns a  GetUserPoolMfaConfigResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetUserPoolMfaConfig">REST API Reference for GetUserPoolMfaConfig Operation</seealso>
        public virtual GetUserPoolMfaConfigResponse EndGetUserPoolMfaConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<GetUserPoolMfaConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  GlobalSignOut

        /// <summary>
        /// Invalidates the identity, access, and refresh tokens that Amazon Cognito issued to
        /// a user. Call this operation when your user signs out of your app. This results in
        /// the following behavior. 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Amazon Cognito no longer accepts <i>token-authorized</i> user operations that you
        /// authorize with a signed-out user's access tokens. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a>.
        /// </para>
        ///  
        /// <para>
        /// Amazon Cognito returns an <c>Access Token has been revoked</c> error when your app
        /// attempts to authorize a user pools API request with a revoked access token that contains
        /// the scope <c>aws.cognito.signin.user.admin</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Cognito no longer accepts a signed-out user's ID token in a <a href="https://docs.aws.amazon.com/cognitoidentity/latest/APIReference/API_GetId.html">GetId
        /// </a> request to an identity pool with <c>ServerSideTokenCheck</c> enabled for its
        /// user pool IdP configuration in <a href="https://docs.aws.amazon.com/cognitoidentity/latest/APIReference/API_CognitoIdentityProvider.html">CognitoIdentityProvider</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Cognito no longer accepts a signed-out user's refresh tokens in refresh requests.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Other requests might be valid until your user's token expires. This operation doesn't
        /// clear the <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pools-managed-login.html">managed
        /// login</a> session cookie. To clear the session for a user who signed in with managed
        /// login or the classic hosted UI, direct their browser session to the <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/logout-endpoint.html">logout
        /// endpoint</a>.
        /// </para>
        ///  
        /// <para>
        /// Authorize this action with a signed-in user's access token. It must include the scope
        /// <c>aws.cognito.signin.user.admin</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon Cognito doesn't evaluate Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you can't use IAM credentials to authorize
        /// requests, and you can't grant IAM permissions in policies. For more information about
        /// authorization models in Amazon Cognito, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a>.
        /// </para>
        ///  </note>
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
        public virtual GlobalSignOutResponse GlobalSignOut(GlobalSignOutRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GlobalSignOutRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GlobalSignOutResponseUnmarshaller.Instance;

            return Invoke<GlobalSignOutResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginGlobalSignOut(GlobalSignOutRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GlobalSignOutRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GlobalSignOutResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GlobalSignOut operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGlobalSignOut.</param>
        /// 
        /// <returns>Returns a  GlobalSignOutResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GlobalSignOut">REST API Reference for GlobalSignOut Operation</seealso>
        public virtual GlobalSignOutResponse EndGlobalSignOut(IAsyncResult asyncResult)
        {
            return EndInvoke<GlobalSignOutResponse>(asyncResult);
        }

        #endregion
        
        #region  InitiateAuth

        /// <summary>
        /// Declares an authentication flow and initiates sign-in for a user in the Amazon Cognito
        /// user directory. Amazon Cognito might respond with an additional challenge or an <c>AuthenticationResult</c>
        /// that contains the outcome of a successful authentication. You can't sign in a user
        /// with a federated IdP with <c>InitiateAuth</c>. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/authentication.html">Authentication</a>.
        /// 
        ///  <note> 
        /// <para>
        /// Amazon Cognito doesn't evaluate Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you can't use IAM credentials to authorize
        /// requests, and you can't grant IAM permissions in policies. For more information about
        /// authorization models in Amazon Cognito, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a>.
        /// </para>
        ///  </note> <note> 
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
        /// Services service, Amazon Simple Notification Service might place your account in the
        /// SMS sandbox. In <i> <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-sms-sandbox.html">sandbox
        /// mode</a> </i>, you can send messages only to verified phone numbers. After you test
        /// your app while in the sandbox environment, you can move out of the sandbox and into
        /// production. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pool-sms-settings.html">
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
        /// for SMS configuration. This can happen if you don't trust <c>cognito-idp.amazonaws.com</c>
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
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UnsupportedOperationException">
        /// Exception that is thrown when you attempt to perform an operation that isn't enabled
        /// for the user pool client.
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
        public virtual InitiateAuthResponse InitiateAuth(InitiateAuthRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = InitiateAuthRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InitiateAuthResponseUnmarshaller.Instance;

            return Invoke<InitiateAuthResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginInitiateAuth(InitiateAuthRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = InitiateAuthRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InitiateAuthResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  InitiateAuth operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginInitiateAuth.</param>
        /// 
        /// <returns>Returns a  InitiateAuthResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/InitiateAuth">REST API Reference for InitiateAuth Operation</seealso>
        public virtual InitiateAuthResponse EndInitiateAuth(IAsyncResult asyncResult)
        {
            return EndInvoke<InitiateAuthResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDevices

        /// <summary>
        /// Lists the devices that Amazon Cognito has registered to the currently signed-in user.
        /// For more information about device authentication, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/amazon-cognito-user-pools-device-tracking.html">Working
        /// with user devices in your user pool</a>.
        /// 
        ///  
        /// <para>
        /// Authorize this action with a signed-in user's access token. It must include the scope
        /// <c>aws.cognito.signin.user.admin</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon Cognito doesn't evaluate Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you can't use IAM credentials to authorize
        /// requests, and you can't grant IAM permissions in policies. For more information about
        /// authorization models in Amazon Cognito, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a>.
        /// </para>
        ///  </note>
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
        public virtual ListDevicesResponse ListDevices(ListDevicesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDevicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDevicesResponseUnmarshaller.Instance;

            return Invoke<ListDevicesResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginListDevices(ListDevicesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDevicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDevicesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDevices operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDevices.</param>
        /// 
        /// <returns>Returns a  ListDevicesResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListDevices">REST API Reference for ListDevices Operation</seealso>
        public virtual ListDevicesResponse EndListDevices(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDevicesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListGroups

        /// <summary>
        /// Given a user pool ID, returns user pool groups and their details.
        /// 
        ///  <note> 
        /// <para>
        /// Amazon Cognito evaluates Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you must use IAM credentials to authorize
        /// requests, and you must grant yourself the corresponding IAM permission in a policy.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
        /// Amazon Web Services API Requests</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a> 
        /// </para>
        ///  </li> </ul> </note>
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
        public virtual ListGroupsResponse ListGroups(ListGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGroupsResponseUnmarshaller.Instance;

            return Invoke<ListGroupsResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginListGroups(ListGroupsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGroupsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGroups.</param>
        /// 
        /// <returns>Returns a  ListGroupsResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListGroups">REST API Reference for ListGroups Operation</seealso>
        public virtual ListGroupsResponse EndListGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<ListGroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListIdentityProviders

        /// <summary>
        /// Given a user pool ID, returns information about configured identity providers (IdPs).
        /// For more information about IdPs, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pools-identity-federation.html">Third-party
        /// IdP sign-in</a>.
        /// 
        ///  <note> 
        /// <para>
        /// Amazon Cognito evaluates Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you must use IAM credentials to authorize
        /// requests, and you must grant yourself the corresponding IAM permission in a policy.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
        /// Amazon Web Services API Requests</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a> 
        /// </para>
        ///  </li> </ul> </note>
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
        public virtual ListIdentityProvidersResponse ListIdentityProviders(ListIdentityProvidersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIdentityProvidersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIdentityProvidersResponseUnmarshaller.Instance;

            return Invoke<ListIdentityProvidersResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginListIdentityProviders(ListIdentityProvidersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIdentityProvidersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIdentityProvidersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListIdentityProviders operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListIdentityProviders.</param>
        /// 
        /// <returns>Returns a  ListIdentityProvidersResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListIdentityProviders">REST API Reference for ListIdentityProviders Operation</seealso>
        public virtual ListIdentityProvidersResponse EndListIdentityProviders(IAsyncResult asyncResult)
        {
            return EndInvoke<ListIdentityProvidersResponse>(asyncResult);
        }

        #endregion
        
        #region  ListResourceServers

        /// <summary>
        /// Given a user pool ID, returns all resource servers and their details. For more information
        /// about resource servers, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pools-define-resource-servers.html">Access
        /// control with resource servers</a>.
        /// 
        ///  <note> 
        /// <para>
        /// Amazon Cognito evaluates Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you must use IAM credentials to authorize
        /// requests, and you must grant yourself the corresponding IAM permission in a policy.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
        /// Amazon Web Services API Requests</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a> 
        /// </para>
        ///  </li> </ul> </note>
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
        public virtual ListResourceServersResponse ListResourceServers(ListResourceServersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResourceServersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourceServersResponseUnmarshaller.Instance;

            return Invoke<ListResourceServersResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginListResourceServers(ListResourceServersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResourceServersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourceServersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListResourceServers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListResourceServers.</param>
        /// 
        /// <returns>Returns a  ListResourceServersResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListResourceServers">REST API Reference for ListResourceServers Operation</seealso>
        public virtual ListResourceServersResponse EndListResourceServers(IAsyncResult asyncResult)
        {
            return EndInvoke<ListResourceServersResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Lists the tags that are assigned to an Amazon Cognito user pool. For more information,
        /// see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/tagging.html">Tagging
        /// resources</a>.
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
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTerms

        /// <summary>
        /// Returns details about all terms documents for the requested user pool.
        /// 
        ///  <note> 
        /// <para>
        /// Amazon Cognito evaluates Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you must use IAM credentials to authorize
        /// requests, and you must grant yourself the corresponding IAM permission in a policy.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
        /// Amazon Web Services API Requests</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a> 
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTerms service method.</param>
        /// 
        /// <returns>The response from the ListTerms service method, as returned by CognitoIdentityProvider.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListTerms">REST API Reference for ListTerms Operation</seealso>
        public virtual ListTermsResponse ListTerms(ListTermsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTermsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTermsResponseUnmarshaller.Instance;

            return Invoke<ListTermsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTerms operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTerms operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTerms
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListTerms">REST API Reference for ListTerms Operation</seealso>
        public virtual IAsyncResult BeginListTerms(ListTermsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTermsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTermsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTerms operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTerms.</param>
        /// 
        /// <returns>Returns a  ListTermsResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListTerms">REST API Reference for ListTerms Operation</seealso>
        public virtual ListTermsResponse EndListTerms(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTermsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListUserImportJobs

        /// <summary>
        /// Given a user pool ID, returns user import jobs and their details. Import jobs are
        /// retained in user pool configuration so that you can stage, stop, start, review, and
        /// delete them. For more information about user import, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pools-using-import-tool.html">Importing
        /// users from a CSV file</a>.
        /// 
        ///  <note> 
        /// <para>
        /// Amazon Cognito evaluates Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you must use IAM credentials to authorize
        /// requests, and you must grant yourself the corresponding IAM permission in a policy.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
        /// Amazon Web Services API Requests</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a> 
        /// </para>
        ///  </li> </ul> </note>
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
        public virtual ListUserImportJobsResponse ListUserImportJobs(ListUserImportJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUserImportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUserImportJobsResponseUnmarshaller.Instance;

            return Invoke<ListUserImportJobsResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginListUserImportJobs(ListUserImportJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUserImportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUserImportJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListUserImportJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListUserImportJobs.</param>
        /// 
        /// <returns>Returns a  ListUserImportJobsResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListUserImportJobs">REST API Reference for ListUserImportJobs Operation</seealso>
        public virtual ListUserImportJobsResponse EndListUserImportJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListUserImportJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListUserPoolClients

        /// <summary>
        /// Given a user pool ID, lists app clients. App clients are sets of rules for the access
        /// that you want a user pool to grant to one application. For more information, see <a
        /// href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pool-settings-client-apps.html">App
        /// clients</a>.
        /// 
        ///  <note> 
        /// <para>
        /// Amazon Cognito evaluates Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you must use IAM credentials to authorize
        /// requests, and you must grant yourself the corresponding IAM permission in a policy.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
        /// Amazon Web Services API Requests</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a> 
        /// </para>
        ///  </li> </ul> </note>
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
        public virtual ListUserPoolClientsResponse ListUserPoolClients(ListUserPoolClientsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUserPoolClientsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUserPoolClientsResponseUnmarshaller.Instance;

            return Invoke<ListUserPoolClientsResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListUserPoolClients">REST API Reference for ListUserPoolClients Operation</seealso>
        public virtual IAsyncResult BeginListUserPoolClients(ListUserPoolClientsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUserPoolClientsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUserPoolClientsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListUserPoolClients operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListUserPoolClients.</param>
        /// 
        /// <returns>Returns a  ListUserPoolClientsResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListUserPoolClients">REST API Reference for ListUserPoolClients Operation</seealso>
        public virtual ListUserPoolClientsResponse EndListUserPoolClients(IAsyncResult asyncResult)
        {
            return EndInvoke<ListUserPoolClientsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListUserPools

        /// <summary>
        /// Lists user pools and their details in the current Amazon Web Services account.
        /// 
        ///  <note> 
        /// <para>
        /// Amazon Cognito evaluates Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you must use IAM credentials to authorize
        /// requests, and you must grant yourself the corresponding IAM permission in a policy.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
        /// Amazon Web Services API Requests</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a> 
        /// </para>
        ///  </li> </ul> </note>
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
        public virtual ListUserPoolsResponse ListUserPools(ListUserPoolsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUserPoolsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUserPoolsResponseUnmarshaller.Instance;

            return Invoke<ListUserPoolsResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListUserPools">REST API Reference for ListUserPools Operation</seealso>
        public virtual IAsyncResult BeginListUserPools(ListUserPoolsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUserPoolsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUserPoolsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListUserPools operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListUserPools.</param>
        /// 
        /// <returns>Returns a  ListUserPoolsResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListUserPools">REST API Reference for ListUserPools Operation</seealso>
        public virtual ListUserPoolsResponse EndListUserPools(IAsyncResult asyncResult)
        {
            return EndInvoke<ListUserPoolsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListUsers

        /// <summary>
        /// Given a user pool ID, returns a list of users and their basic details in a user pool.
        /// 
        ///  <note> 
        /// <para>
        /// Amazon Cognito evaluates Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you must use IAM credentials to authorize
        /// requests, and you must grant yourself the corresponding IAM permission in a policy.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
        /// Amazon Web Services API Requests</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a> 
        /// </para>
        ///  </li> </ul> </note>
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
        public virtual ListUsersResponse ListUsers(ListUsersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUsersResponseUnmarshaller.Instance;

            return Invoke<ListUsersResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListUsers">REST API Reference for ListUsers Operation</seealso>
        public virtual IAsyncResult BeginListUsers(ListUsersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUsersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListUsers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListUsers.</param>
        /// 
        /// <returns>Returns a  ListUsersResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListUsers">REST API Reference for ListUsers Operation</seealso>
        public virtual ListUsersResponse EndListUsers(IAsyncResult asyncResult)
        {
            return EndInvoke<ListUsersResponse>(asyncResult);
        }

        #endregion
        
        #region  ListUsersInGroup

        /// <summary>
        /// Given a user pool ID and a group name, returns a list of users in the group. For more
        /// information about user pool groups, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pools-user-groups.html">Adding
        /// groups to a user pool</a>.
        /// 
        ///  <note> 
        /// <para>
        /// Amazon Cognito evaluates Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you must use IAM credentials to authorize
        /// requests, and you must grant yourself the corresponding IAM permission in a policy.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
        /// Amazon Web Services API Requests</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a> 
        /// </para>
        ///  </li> </ul> </note>
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
        public virtual ListUsersInGroupResponse ListUsersInGroup(ListUsersInGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUsersInGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUsersInGroupResponseUnmarshaller.Instance;

            return Invoke<ListUsersInGroupResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginListUsersInGroup(ListUsersInGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUsersInGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUsersInGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListUsersInGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListUsersInGroup.</param>
        /// 
        /// <returns>Returns a  ListUsersInGroupResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListUsersInGroup">REST API Reference for ListUsersInGroup Operation</seealso>
        public virtual ListUsersInGroupResponse EndListUsersInGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<ListUsersInGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  ListWebAuthnCredentials

        /// <summary>
        /// Generates a list of the currently signed-in user's registered passkey, or WebAuthn,
        /// credentials.
        /// 
        ///  
        /// <para>
        /// Authorize this action with a signed-in user's access token. It must include the scope
        /// <c>aws.cognito.signin.user.admin</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon Cognito doesn't evaluate Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you can't use IAM credentials to authorize
        /// requests, and you can't grant IAM permissions in policies. For more information about
        /// authorization models in Amazon Cognito, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWebAuthnCredentials service method.</param>
        /// 
        /// <returns>The response from the ListWebAuthnCredentials service method, as returned by CognitoIdentityProvider.</returns>
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
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListWebAuthnCredentials">REST API Reference for ListWebAuthnCredentials Operation</seealso>
        public virtual ListWebAuthnCredentialsResponse ListWebAuthnCredentials(ListWebAuthnCredentialsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWebAuthnCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWebAuthnCredentialsResponseUnmarshaller.Instance;

            return Invoke<ListWebAuthnCredentialsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListWebAuthnCredentials operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWebAuthnCredentials operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWebAuthnCredentials
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListWebAuthnCredentials">REST API Reference for ListWebAuthnCredentials Operation</seealso>
        public virtual IAsyncResult BeginListWebAuthnCredentials(ListWebAuthnCredentialsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWebAuthnCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWebAuthnCredentialsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListWebAuthnCredentials operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWebAuthnCredentials.</param>
        /// 
        /// <returns>Returns a  ListWebAuthnCredentialsResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListWebAuthnCredentials">REST API Reference for ListWebAuthnCredentials Operation</seealso>
        public virtual ListWebAuthnCredentialsResponse EndListWebAuthnCredentials(IAsyncResult asyncResult)
        {
            return EndInvoke<ListWebAuthnCredentialsResponse>(asyncResult);
        }

        #endregion
        
        #region  ResendConfirmationCode

        /// <summary>
        /// Resends the code that confirms a new account for a user who has signed up in your
        /// user pool. Amazon Cognito sends confirmation codes to the user attribute in the <c>AutoVerifiedAttributes</c>
        /// property of your user pool. When you prompt new users for the confirmation code, include
        /// a "Resend code" option that generates a call to this API operation.
        /// 
        ///  <note> 
        /// <para>
        /// Amazon Cognito doesn't evaluate Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you can't use IAM credentials to authorize
        /// requests, and you can't grant IAM permissions in policies. For more information about
        /// authorization models in Amazon Cognito, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a>.
        /// </para>
        ///  </note> <note> 
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
        /// Services service, Amazon Simple Notification Service might place your account in the
        /// SMS sandbox. In <i> <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-sms-sandbox.html">sandbox
        /// mode</a> </i>, you can send messages only to verified phone numbers. After you test
        /// your app while in the sandbox environment, you can move out of the sandbox and into
        /// production. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pool-sms-settings.html">
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
        /// for SMS configuration. This can happen if you don't trust <c>cognito-idp.amazonaws.com</c>
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
        public virtual ResendConfirmationCodeResponse ResendConfirmationCode(ResendConfirmationCodeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResendConfirmationCodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResendConfirmationCodeResponseUnmarshaller.Instance;

            return Invoke<ResendConfirmationCodeResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ResendConfirmationCode">REST API Reference for ResendConfirmationCode Operation</seealso>
        public virtual IAsyncResult BeginResendConfirmationCode(ResendConfirmationCodeRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResendConfirmationCodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResendConfirmationCodeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ResendConfirmationCode operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResendConfirmationCode.</param>
        /// 
        /// <returns>Returns a  ResendConfirmationCodeResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ResendConfirmationCode">REST API Reference for ResendConfirmationCode Operation</seealso>
        public virtual ResendConfirmationCodeResponse EndResendConfirmationCode(IAsyncResult asyncResult)
        {
            return EndInvoke<ResendConfirmationCodeResponse>(asyncResult);
        }

        #endregion
        
        #region  RespondToAuthChallenge

        /// <summary>
        /// Some API operations in a user pool generate a challenge, like a prompt for an MFA
        /// code, for device authentication that bypasses MFA, or for a custom authentication
        /// challenge. A <c>RespondToAuthChallenge</c> API request provides the answer to that
        /// challenge, like a code or a secure remote password (SRP). The parameters of a response
        /// to an authentication challenge vary with the type of challenge.
        /// 
        ///  
        /// <para>
        /// For more information about custom authentication challenges, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pool-lambda-challenge.html">Custom
        /// authentication challenge Lambda triggers</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon Cognito doesn't evaluate Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you can't use IAM credentials to authorize
        /// requests, and you can't grant IAM permissions in policies. For more information about
        /// authorization models in Amazon Cognito, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a>.
        /// </para>
        ///  </note> <note> 
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
        /// Services service, Amazon Simple Notification Service might place your account in the
        /// SMS sandbox. In <i> <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-sms-sandbox.html">sandbox
        /// mode</a> </i>, you can send messages only to verified phone numbers. After you test
        /// your app while in the sandbox environment, you can move out of the sandbox and into
        /// production. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pool-sms-settings.html">
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
        /// for SMS configuration. This can happen if you don't trust <c>cognito-idp.amazonaws.com</c>
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
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.PasswordHistoryPolicyViolationException">
        /// The message returned when a user's new password matches a previous password and doesn't
        /// comply with the password-history policy.
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
        public virtual RespondToAuthChallengeResponse RespondToAuthChallenge(RespondToAuthChallengeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RespondToAuthChallengeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RespondToAuthChallengeResponseUnmarshaller.Instance;

            return Invoke<RespondToAuthChallengeResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginRespondToAuthChallenge(RespondToAuthChallengeRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RespondToAuthChallengeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RespondToAuthChallengeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RespondToAuthChallenge operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRespondToAuthChallenge.</param>
        /// 
        /// <returns>Returns a  RespondToAuthChallengeResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/RespondToAuthChallenge">REST API Reference for RespondToAuthChallenge Operation</seealso>
        public virtual RespondToAuthChallengeResponse EndRespondToAuthChallenge(IAsyncResult asyncResult)
        {
            return EndInvoke<RespondToAuthChallengeResponse>(asyncResult);
        }

        #endregion
        
        #region  RevokeToken

        /// <summary>
        /// Revokes all of the access tokens generated by, and at the same time as, the specified
        /// refresh token. After a token is revoked, you can't use the revoked token to access
        /// Amazon Cognito user APIs, or to authorize access to your resource server.
        /// 
        ///  <note> 
        /// <para>
        /// Amazon Cognito doesn't evaluate Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you can't use IAM credentials to authorize
        /// requests, and you can't grant IAM permissions in policies. For more information about
        /// authorization models in Amazon Cognito, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a>.
        /// </para>
        ///  </note>
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
        public virtual RevokeTokenResponse RevokeToken(RevokeTokenRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RevokeTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeTokenResponseUnmarshaller.Instance;

            return Invoke<RevokeTokenResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RevokeToken operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RevokeToken operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRevokeToken
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/RevokeToken">REST API Reference for RevokeToken Operation</seealso>
        public virtual IAsyncResult BeginRevokeToken(RevokeTokenRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RevokeTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeTokenResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RevokeToken operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRevokeToken.</param>
        /// 
        /// <returns>Returns a  RevokeTokenResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/RevokeToken">REST API Reference for RevokeToken Operation</seealso>
        public virtual RevokeTokenResponse EndRevokeToken(IAsyncResult asyncResult)
        {
            return EndInvoke<RevokeTokenResponse>(asyncResult);
        }

        #endregion
        
        #region  SetLogDeliveryConfiguration

        /// <summary>
        /// Sets up or modifies the logging configuration of a user pool. User pools can export
        /// user notification logs and, when threat protection is active, user-activity logs.
        /// For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/exporting-quotas-and-usage.html">Exporting
        /// user pool logs</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetLogDeliveryConfiguration service method.</param>
        /// 
        /// <returns>The response from the SetLogDeliveryConfiguration service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.FeatureUnavailableInTierException">
        /// This exception is thrown when a feature you attempted to configure isn't available
        /// in your current feature plan.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/SetLogDeliveryConfiguration">REST API Reference for SetLogDeliveryConfiguration Operation</seealso>
        public virtual SetLogDeliveryConfigurationResponse SetLogDeliveryConfiguration(SetLogDeliveryConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetLogDeliveryConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetLogDeliveryConfigurationResponseUnmarshaller.Instance;

            return Invoke<SetLogDeliveryConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SetLogDeliveryConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetLogDeliveryConfiguration operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetLogDeliveryConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/SetLogDeliveryConfiguration">REST API Reference for SetLogDeliveryConfiguration Operation</seealso>
        public virtual IAsyncResult BeginSetLogDeliveryConfiguration(SetLogDeliveryConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetLogDeliveryConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetLogDeliveryConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SetLogDeliveryConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetLogDeliveryConfiguration.</param>
        /// 
        /// <returns>Returns a  SetLogDeliveryConfigurationResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/SetLogDeliveryConfiguration">REST API Reference for SetLogDeliveryConfiguration Operation</seealso>
        public virtual SetLogDeliveryConfigurationResponse EndSetLogDeliveryConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<SetLogDeliveryConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  SetRiskConfiguration

        /// <summary>
        /// Configures threat protection for a user pool or app client. Sets configuration for
        /// the following.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Responses to risks with adaptive authentication
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Responses to vulnerable passwords with compromised-credentials detection
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Notifications to users who have had risky activity detected
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IP-address denylist and allowlist
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To set the risk configuration for the user pool to defaults, send this request with
        /// only the <c>UserPoolId</c> parameter. To reset the threat protection settings of an
        /// app client to be inherited from the user pool, send <c>UserPoolId</c> and <c>ClientId</c>
        /// parameters only. To change threat protection to audit-only or off, update the value
        /// of <c>UserPoolAddOns</c> in an <c>UpdateUserPool</c> request. To activate this setting,
        /// your user pool must be on the <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/feature-plans-features-plus.html">
        /// Plus tier</a>.
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
        public virtual SetRiskConfigurationResponse SetRiskConfiguration(SetRiskConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetRiskConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetRiskConfigurationResponseUnmarshaller.Instance;

            return Invoke<SetRiskConfigurationResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginSetRiskConfiguration(SetRiskConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetRiskConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetRiskConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SetRiskConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetRiskConfiguration.</param>
        /// 
        /// <returns>Returns a  SetRiskConfigurationResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/SetRiskConfiguration">REST API Reference for SetRiskConfiguration Operation</seealso>
        public virtual SetRiskConfigurationResponse EndSetRiskConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<SetRiskConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  SetUICustomization

        /// <summary>
        /// Configures UI branding settings for domains with the hosted UI (classic) branding
        /// version. Your user pool must have a domain. Configure a domain with .
        /// 
        ///  
        /// <para>
        /// Set the default configuration for all clients with a <c>ClientId</c> of <c>ALL</c>.
        /// When the <c>ClientId</c> value is an app client ID, the settings you pass in this
        /// request apply to that app client and override the default <c>ALL</c> configuration.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon Cognito evaluates Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you must use IAM credentials to authorize
        /// requests, and you must grant yourself the corresponding IAM permission in a policy.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
        /// Amazon Web Services API Requests</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a> 
        /// </para>
        ///  </li> </ul> </note>
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
        public virtual SetUICustomizationResponse SetUICustomization(SetUICustomizationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetUICustomizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetUICustomizationResponseUnmarshaller.Instance;

            return Invoke<SetUICustomizationResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginSetUICustomization(SetUICustomizationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetUICustomizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetUICustomizationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SetUICustomization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetUICustomization.</param>
        /// 
        /// <returns>Returns a  SetUICustomizationResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/SetUICustomization">REST API Reference for SetUICustomization Operation</seealso>
        public virtual SetUICustomizationResponse EndSetUICustomization(IAsyncResult asyncResult)
        {
            return EndInvoke<SetUICustomizationResponse>(asyncResult);
        }

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
        /// 
        ///  
        /// <para>
        /// Authorize this action with a signed-in user's access token. It must include the scope
        /// <c>aws.cognito.signin.user.admin</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon Cognito doesn't evaluate Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you can't use IAM credentials to authorize
        /// requests, and you can't grant IAM permissions in policies. For more information about
        /// authorization models in Amazon Cognito, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a>.
        /// </para>
        ///  </note>
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
        public virtual SetUserMFAPreferenceResponse SetUserMFAPreference(SetUserMFAPreferenceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetUserMFAPreferenceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetUserMFAPreferenceResponseUnmarshaller.Instance;

            return Invoke<SetUserMFAPreferenceResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginSetUserMFAPreference(SetUserMFAPreferenceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetUserMFAPreferenceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetUserMFAPreferenceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SetUserMFAPreference operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetUserMFAPreference.</param>
        /// 
        /// <returns>Returns a  SetUserMFAPreferenceResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/SetUserMFAPreference">REST API Reference for SetUserMFAPreference Operation</seealso>
        public virtual SetUserMFAPreferenceResponse EndSetUserMFAPreference(IAsyncResult asyncResult)
        {
            return EndInvoke<SetUserMFAPreferenceResponse>(asyncResult);
        }

        #endregion
        
        #region  SetUserPoolMfaConfig

        /// <summary>
        /// Sets user pool multi-factor authentication (MFA) and passkey configuration. For more
        /// information about user pool MFA, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pool-settings-mfa.html">Adding
        /// MFA</a>. For more information about WebAuthn passkeys see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/amazon-cognito-user-pools-authentication-flow-methods.html#amazon-cognito-user-pools-authentication-flow-methods-passkey">Authentication
        /// flows</a>.
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
        /// Services service, Amazon Simple Notification Service might place your account in the
        /// SMS sandbox. In <i> <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-sms-sandbox.html">sandbox
        /// mode</a> </i>, you can send messages only to verified phone numbers. After you test
        /// your app while in the sandbox environment, you can move out of the sandbox and into
        /// production. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pool-sms-settings.html">
        /// SMS message settings for Amazon Cognito user pools</a> in the <i>Amazon Cognito Developer
        /// Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetUserPoolMfaConfig service method.</param>
        /// 
        /// <returns>The response from the SetUserPoolMfaConfig service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ConcurrentModificationException">
        /// This exception is thrown if two or more modifications are happening concurrently.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.FeatureUnavailableInTierException">
        /// This exception is thrown when a feature you attempted to configure isn't available
        /// in your current feature plan.
        /// </exception>
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
        /// for SMS configuration. This can happen if you don't trust <c>cognito-idp.amazonaws.com</c>
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
        public virtual SetUserPoolMfaConfigResponse SetUserPoolMfaConfig(SetUserPoolMfaConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetUserPoolMfaConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetUserPoolMfaConfigResponseUnmarshaller.Instance;

            return Invoke<SetUserPoolMfaConfigResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginSetUserPoolMfaConfig(SetUserPoolMfaConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetUserPoolMfaConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetUserPoolMfaConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SetUserPoolMfaConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetUserPoolMfaConfig.</param>
        /// 
        /// <returns>Returns a  SetUserPoolMfaConfigResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/SetUserPoolMfaConfig">REST API Reference for SetUserPoolMfaConfig Operation</seealso>
        public virtual SetUserPoolMfaConfigResponse EndSetUserPoolMfaConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<SetUserPoolMfaConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  SetUserSettings

        /// <summary>
        /// <i>This action is no longer supported.</i> You can use it to configure only SMS MFA.
        /// You can't use it to configure time-based one-time password (TOTP) software token or
        /// email MFA.
        /// 
        ///  
        /// <para>
        /// Authorize this action with a signed-in user's access token. It must include the scope
        /// <c>aws.cognito.signin.user.admin</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon Cognito doesn't evaluate Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you can't use IAM credentials to authorize
        /// requests, and you can't grant IAM permissions in policies. For more information about
        /// authorization models in Amazon Cognito, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a>.
        /// </para>
        ///  </note>
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
        public virtual SetUserSettingsResponse SetUserSettings(SetUserSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetUserSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetUserSettingsResponseUnmarshaller.Instance;

            return Invoke<SetUserSettingsResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/SetUserSettings">REST API Reference for SetUserSettings Operation</seealso>
        public virtual IAsyncResult BeginSetUserSettings(SetUserSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetUserSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetUserSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SetUserSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetUserSettings.</param>
        /// 
        /// <returns>Returns a  SetUserSettingsResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/SetUserSettings">REST API Reference for SetUserSettings Operation</seealso>
        public virtual SetUserSettingsResponse EndSetUserSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<SetUserSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  SignUp

        /// <summary>
        /// Registers a user with an app client and requests a user name, password, and user attributes
        /// in the user pool.
        /// 
        ///  <note> 
        /// <para>
        /// Amazon Cognito doesn't evaluate Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you can't use IAM credentials to authorize
        /// requests, and you can't grant IAM permissions in policies. For more information about
        /// authorization models in Amazon Cognito, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a>.
        /// </para>
        ///  </note> <note> 
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
        /// Services service, Amazon Simple Notification Service might place your account in the
        /// SMS sandbox. In <i> <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-sms-sandbox.html">sandbox
        /// mode</a> </i>, you can send messages only to verified phone numbers. After you test
        /// your app while in the sandbox environment, you can move out of the sandbox and into
        /// production. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pool-sms-settings.html">
        /// SMS message settings for Amazon Cognito user pools</a> in the <i>Amazon Cognito Developer
        /// Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// You might receive a <c>LimitExceeded</c> exception in response to this request if
        /// you have exceeded a rate quota for email or SMS messages, and if your user pool automatically
        /// verifies email addresses or phone numbers. When you get this exception in the response,
        /// the user is successfully created and is in an <c>UNCONFIRMED</c> state.
        /// </para>
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
        /// for SMS configuration. This can happen if you don't trust <c>cognito-idp.amazonaws.com</c>
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
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.UsernameExistsException">
        /// This exception is thrown when Amazon Cognito encounters a user name that already exists
        /// in the user pool.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/SignUp">REST API Reference for SignUp Operation</seealso>
        public virtual SignUpResponse SignUp(SignUpRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SignUpRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SignUpResponseUnmarshaller.Instance;

            return Invoke<SignUpResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/SignUp">REST API Reference for SignUp Operation</seealso>
        public virtual IAsyncResult BeginSignUp(SignUpRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SignUpRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SignUpResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SignUp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSignUp.</param>
        /// 
        /// <returns>Returns a  SignUpResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/SignUp">REST API Reference for SignUp Operation</seealso>
        public virtual SignUpResponse EndSignUp(IAsyncResult asyncResult)
        {
            return EndInvoke<SignUpResponse>(asyncResult);
        }

        #endregion
        
        #region  StartUserImportJob

        /// <summary>
        /// Instructs your user pool to start importing users from a CSV file that contains their
        /// usernames and attributes. For more information about importing users from a CSV file,
        /// see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pools-using-import-tool.html">Importing
        /// users from a CSV file</a>.
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
        public virtual StartUserImportJobResponse StartUserImportJob(StartUserImportJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartUserImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartUserImportJobResponseUnmarshaller.Instance;

            return Invoke<StartUserImportJobResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginStartUserImportJob(StartUserImportJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartUserImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartUserImportJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartUserImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartUserImportJob.</param>
        /// 
        /// <returns>Returns a  StartUserImportJobResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/StartUserImportJob">REST API Reference for StartUserImportJob Operation</seealso>
        public virtual StartUserImportJobResponse EndStartUserImportJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StartUserImportJobResponse>(asyncResult);
        }

        #endregion
        
        #region  StartWebAuthnRegistration

        /// <summary>
        /// Requests credential creation options from your user pool for the currently signed-in
        /// user. Returns information about the user pool, the user profile, and authentication
        /// requirements. Users must provide this information in their request to enroll your
        /// application with their passkey provider.
        /// 
        ///  
        /// <para>
        /// Authorize this action with a signed-in user's access token. It must include the scope
        /// <c>aws.cognito.signin.user.admin</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartWebAuthnRegistration service method.</param>
        /// 
        /// <returns>The response from the StartWebAuthnRegistration service method, as returned by CognitoIdentityProvider.</returns>
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
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.WebAuthnConfigurationMissingException">
        /// This exception is thrown when a user pool doesn't have a configured relying party
        /// id or a user pool domain.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.WebAuthnNotEnabledException">
        /// This exception is thrown when the passkey feature isn't enabled for the user pool.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/StartWebAuthnRegistration">REST API Reference for StartWebAuthnRegistration Operation</seealso>
        public virtual StartWebAuthnRegistrationResponse StartWebAuthnRegistration(StartWebAuthnRegistrationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartWebAuthnRegistrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartWebAuthnRegistrationResponseUnmarshaller.Instance;

            return Invoke<StartWebAuthnRegistrationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartWebAuthnRegistration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartWebAuthnRegistration operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartWebAuthnRegistration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/StartWebAuthnRegistration">REST API Reference for StartWebAuthnRegistration Operation</seealso>
        public virtual IAsyncResult BeginStartWebAuthnRegistration(StartWebAuthnRegistrationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartWebAuthnRegistrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartWebAuthnRegistrationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartWebAuthnRegistration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartWebAuthnRegistration.</param>
        /// 
        /// <returns>Returns a  StartWebAuthnRegistrationResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/StartWebAuthnRegistration">REST API Reference for StartWebAuthnRegistration Operation</seealso>
        public virtual StartWebAuthnRegistrationResponse EndStartWebAuthnRegistration(IAsyncResult asyncResult)
        {
            return EndInvoke<StartWebAuthnRegistrationResponse>(asyncResult);
        }

        #endregion
        
        #region  StopUserImportJob

        /// <summary>
        /// Instructs your user pool to stop a running job that's importing users from a CSV file
        /// that contains their usernames and attributes. For more information about importing
        /// users from a CSV file, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pools-using-import-tool.html">Importing
        /// users from a CSV file</a>.
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
        public virtual StopUserImportJobResponse StopUserImportJob(StopUserImportJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopUserImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopUserImportJobResponseUnmarshaller.Instance;

            return Invoke<StopUserImportJobResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginStopUserImportJob(StopUserImportJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopUserImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopUserImportJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopUserImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopUserImportJob.</param>
        /// 
        /// <returns>Returns a  StopUserImportJobResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/StopUserImportJob">REST API Reference for StopUserImportJob Operation</seealso>
        public virtual StopUserImportJobResponse EndStopUserImportJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StopUserImportJobResponse>(asyncResult);
        }

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
        /// pool, one for testing and another for production, you might assign an <c>Environment</c>
        /// tag key to both user pools. The value of this key might be <c>Test</c> for one user
        /// pool, and <c>Production</c> for the other.
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
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Given tag IDs that you previously assigned to a user pool, removes them.
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
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAuthEventFeedback

        /// <summary>
        /// Provides the feedback for an authentication event generated by threat protection features.
        /// The user's response indicates that you think that the event either was from a valid
        /// user or was an unwanted authentication attempt. This feedback improves the risk evaluation
        /// decision for the user pool as part of Amazon Cognito threat protection. To activate
        /// this setting, your user pool must be on the <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/feature-plans-features-plus.html">
        /// Plus tier</a>.
        /// 
        ///  
        /// <para>
        /// This operation requires a <c>FeedbackToken</c> that Amazon Cognito generates and adds
        /// to notification emails when users have potentially suspicious authentication events.
        /// Users invoke this operation when they select the link that corresponds to <c>{one-click-link-valid}</c>
        /// or <c>{one-click-link-invalid}</c> in your notification template. Because <c>FeedbackToken</c>
        /// is a required parameter, you can't make requests to <c>UpdateAuthEventFeedback</c>
        /// without the contents of the notification email message.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon Cognito doesn't evaluate Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you can't use IAM credentials to authorize
        /// requests, and you can't grant IAM permissions in policies. For more information about
        /// authorization models in Amazon Cognito, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a>.
        /// </para>
        ///  </note>
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
        public virtual UpdateAuthEventFeedbackResponse UpdateAuthEventFeedback(UpdateAuthEventFeedbackRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAuthEventFeedbackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAuthEventFeedbackResponseUnmarshaller.Instance;

            return Invoke<UpdateAuthEventFeedbackResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginUpdateAuthEventFeedback(UpdateAuthEventFeedbackRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAuthEventFeedbackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAuthEventFeedbackResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAuthEventFeedback operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAuthEventFeedback.</param>
        /// 
        /// <returns>Returns a  UpdateAuthEventFeedbackResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateAuthEventFeedback">REST API Reference for UpdateAuthEventFeedback Operation</seealso>
        public virtual UpdateAuthEventFeedbackResponse EndUpdateAuthEventFeedback(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAuthEventFeedbackResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDeviceStatus

        /// <summary>
        /// Updates the status of a the currently signed-in user's device so that it is marked
        /// as remembered or not remembered for the purpose of device authentication. Device authentication
        /// is a "remember me" mechanism that silently completes sign-in from trusted devices
        /// with a device key instead of a user-provided MFA code. This operation changes the
        /// status of a device without deleting it, so you can enable it again later. For more
        /// information about device authentication, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/amazon-cognito-user-pools-device-tracking.html">Working
        /// with devices</a>.
        /// 
        ///  
        /// <para>
        /// Authorize this action with a signed-in user's access token. It must include the scope
        /// <c>aws.cognito.signin.user.admin</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon Cognito doesn't evaluate Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you can't use IAM credentials to authorize
        /// requests, and you can't grant IAM permissions in policies. For more information about
        /// authorization models in Amazon Cognito, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a>.
        /// </para>
        ///  </note>
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
        public virtual UpdateDeviceStatusResponse UpdateDeviceStatus(UpdateDeviceStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDeviceStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDeviceStatusResponseUnmarshaller.Instance;

            return Invoke<UpdateDeviceStatusResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginUpdateDeviceStatus(UpdateDeviceStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDeviceStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDeviceStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDeviceStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDeviceStatus.</param>
        /// 
        /// <returns>Returns a  UpdateDeviceStatusResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateDeviceStatus">REST API Reference for UpdateDeviceStatus Operation</seealso>
        public virtual UpdateDeviceStatusResponse EndUpdateDeviceStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDeviceStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateGroup

        /// <summary>
        /// Given the name of a user pool group, updates any of the properties for precedence,
        /// IAM role, or description. For more information about user pool groups, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pools-user-groups.html">Adding
        /// groups to a user pool</a>.
        /// 
        ///  <note> 
        /// <para>
        /// Amazon Cognito evaluates Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you must use IAM credentials to authorize
        /// requests, and you must grant yourself the corresponding IAM permission in a policy.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
        /// Amazon Web Services API Requests</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a> 
        /// </para>
        ///  </li> </ul> </note>
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
        public virtual UpdateGroupResponse UpdateGroup(UpdateGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateGroupResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginUpdateGroup(UpdateGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateGroup.</param>
        /// 
        /// <returns>Returns a  UpdateGroupResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateGroup">REST API Reference for UpdateGroup Operation</seealso>
        public virtual UpdateGroupResponse EndUpdateGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateIdentityProvider

        /// <summary>
        /// Modifies the configuration and trust relationship between a third-party identity provider
        /// (IdP) and a user pool. Amazon Cognito accepts sign-in with third-party identity providers
        /// through managed login and OIDC relying-party libraries. For more information, see
        /// <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pools-identity-federation.html">Third-party
        /// IdP sign-in</a>.
        /// 
        ///  <note> 
        /// <para>
        /// Amazon Cognito evaluates Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you must use IAM credentials to authorize
        /// requests, and you must grant yourself the corresponding IAM permission in a policy.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
        /// Amazon Web Services API Requests</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a> 
        /// </para>
        ///  </li> </ul> </note>
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
        public virtual UpdateIdentityProviderResponse UpdateIdentityProvider(UpdateIdentityProviderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateIdentityProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIdentityProviderResponseUnmarshaller.Instance;

            return Invoke<UpdateIdentityProviderResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginUpdateIdentityProvider(UpdateIdentityProviderRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateIdentityProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIdentityProviderResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateIdentityProvider operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateIdentityProvider.</param>
        /// 
        /// <returns>Returns a  UpdateIdentityProviderResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateIdentityProvider">REST API Reference for UpdateIdentityProvider Operation</seealso>
        public virtual UpdateIdentityProviderResponse EndUpdateIdentityProvider(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateIdentityProviderResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateManagedLoginBranding

        /// <summary>
        /// Configures the branding settings for a user pool style. This operation is the programmatic
        /// option for the configuration of a style in the branding editor.
        /// 
        ///  
        /// <para>
        /// Provides values for UI customization in a <c>Settings</c> JSON object and image files
        /// in an <c>Assets</c> array.
        /// </para>
        ///  
        /// <para>
        ///  This operation has a 2-megabyte request-size limit and include the CSS settings and
        /// image assets for your app client. Your branding settings might exceed 2MB in size.
        /// Amazon Cognito doesn't require that you pass all parameters in one request and preserves
        /// existing style settings that you don't specify. If your request is larger than 2MB,
        /// separate it into multiple requests, each with a size smaller than the limit.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon Cognito evaluates Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you must use IAM credentials to authorize
        /// requests, and you must grant yourself the corresponding IAM permission in a policy.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
        /// Amazon Web Services API Requests</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a> 
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateManagedLoginBranding service method.</param>
        /// 
        /// <returns>The response from the UpdateManagedLoginBranding service method, as returned by CognitoIdentityProvider.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateManagedLoginBranding">REST API Reference for UpdateManagedLoginBranding Operation</seealso>
        public virtual UpdateManagedLoginBrandingResponse UpdateManagedLoginBranding(UpdateManagedLoginBrandingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateManagedLoginBrandingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateManagedLoginBrandingResponseUnmarshaller.Instance;

            return Invoke<UpdateManagedLoginBrandingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateManagedLoginBranding operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateManagedLoginBranding operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateManagedLoginBranding
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateManagedLoginBranding">REST API Reference for UpdateManagedLoginBranding Operation</seealso>
        public virtual IAsyncResult BeginUpdateManagedLoginBranding(UpdateManagedLoginBrandingRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateManagedLoginBrandingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateManagedLoginBrandingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateManagedLoginBranding operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateManagedLoginBranding.</param>
        /// 
        /// <returns>Returns a  UpdateManagedLoginBrandingResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateManagedLoginBranding">REST API Reference for UpdateManagedLoginBranding Operation</seealso>
        public virtual UpdateManagedLoginBrandingResponse EndUpdateManagedLoginBranding(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateManagedLoginBrandingResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateResourceServer

        /// <summary>
        /// Updates the name and scopes of a resource server. All other fields are read-only.
        /// For more information about resource servers, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pools-define-resource-servers.html">Access
        /// control with resource servers</a>.
        /// 
        ///  <important> 
        /// <para>
        /// If you don't provide a value for an attribute, it is set to the default value.
        /// </para>
        ///  </important> <note> 
        /// <para>
        /// Amazon Cognito evaluates Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you must use IAM credentials to authorize
        /// requests, and you must grant yourself the corresponding IAM permission in a policy.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
        /// Amazon Web Services API Requests</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a> 
        /// </para>
        ///  </li> </ul> </note>
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
        public virtual UpdateResourceServerResponse UpdateResourceServer(UpdateResourceServerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateResourceServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateResourceServerResponseUnmarshaller.Instance;

            return Invoke<UpdateResourceServerResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginUpdateResourceServer(UpdateResourceServerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateResourceServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateResourceServerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateResourceServer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateResourceServer.</param>
        /// 
        /// <returns>Returns a  UpdateResourceServerResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateResourceServer">REST API Reference for UpdateResourceServer Operation</seealso>
        public virtual UpdateResourceServerResponse EndUpdateResourceServer(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateResourceServerResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateTerms

        /// <summary>
        /// Modifies existing terms documents for the requested app client. When Terms and conditions
        /// and Privacy policy documents are configured, the app client displays links to them
        /// in the sign-up page of managed login for the app client.
        /// 
        ///  
        /// <para>
        /// You can provide URLs for terms documents in the languages that are supported by <a
        /// href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pools-managed-login.html#managed-login-localization">managed
        /// login localization</a>. Amazon Cognito directs users to the terms documents for their
        /// current language, with fallback to <c>default</c> if no document exists for the language.
        /// </para>
        ///  
        /// <para>
        /// Each request accepts one type of terms document and a map of language-to-link for
        /// that document type. You must provide both types of terms documents in at least one
        /// language before Amazon Cognito displays your terms documents. Supply each type in
        /// separate requests.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pools-managed-login.html#managed-login-terms-documents">Terms
        /// documents</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon Cognito evaluates Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you must use IAM credentials to authorize
        /// requests, and you must grant yourself the corresponding IAM permission in a policy.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
        /// Amazon Web Services API Requests</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a> 
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTerms service method.</param>
        /// 
        /// <returns>The response from the UpdateTerms service method, as returned by CognitoIdentityProvider.</returns>
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
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TermsExistsException">
        /// Terms document names must be unique to the app client. This exception is thrown when
        /// you attempt to create terms documents with a duplicate <c>TermsName</c>.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TooManyRequestsException">
        /// This exception is thrown when the user has made too many requests for a given operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateTerms">REST API Reference for UpdateTerms Operation</seealso>
        public virtual UpdateTermsResponse UpdateTerms(UpdateTermsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTermsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTermsResponseUnmarshaller.Instance;

            return Invoke<UpdateTermsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTerms operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTerms operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTerms
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateTerms">REST API Reference for UpdateTerms Operation</seealso>
        public virtual IAsyncResult BeginUpdateTerms(UpdateTermsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTermsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTermsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTerms operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTerms.</param>
        /// 
        /// <returns>Returns a  UpdateTermsResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateTerms">REST API Reference for UpdateTerms Operation</seealso>
        public virtual UpdateTermsResponse EndUpdateTerms(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateTermsResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateUserAttributes

        /// <summary>
        /// Updates the currently signed-in user's attributes. To delete an attribute from the
        /// user, submit the attribute in your API request with a blank value.
        /// 
        ///  
        /// <para>
        /// For custom attributes, you must add a <c>custom:</c> prefix to the attribute name,
        /// for example <c>custom:department</c>.
        /// </para>
        ///  
        /// <para>
        /// Authorize this action with a signed-in user's access token. It must include the scope
        /// <c>aws.cognito.signin.user.admin</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon Cognito doesn't evaluate Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you can't use IAM credentials to authorize
        /// requests, and you can't grant IAM permissions in policies. For more information about
        /// authorization models in Amazon Cognito, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a>.
        /// </para>
        ///  </note> <note> 
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
        /// Services service, Amazon Simple Notification Service might place your account in the
        /// SMS sandbox. In <i> <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-sms-sandbox.html">sandbox
        /// mode</a> </i>, you can send messages only to verified phone numbers. After you test
        /// your app while in the sandbox environment, you can move out of the sandbox and into
        /// production. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pool-sms-settings.html">
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
        /// for SMS configuration. This can happen if you don't trust <c>cognito-idp.amazonaws.com</c>
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
        public virtual UpdateUserAttributesResponse UpdateUserAttributes(UpdateUserAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUserAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserAttributesResponseUnmarshaller.Instance;

            return Invoke<UpdateUserAttributesResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateUserAttributes">REST API Reference for UpdateUserAttributes Operation</seealso>
        public virtual IAsyncResult BeginUpdateUserAttributes(UpdateUserAttributesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUserAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserAttributesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateUserAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateUserAttributes.</param>
        /// 
        /// <returns>Returns a  UpdateUserAttributesResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateUserAttributes">REST API Reference for UpdateUserAttributes Operation</seealso>
        public virtual UpdateUserAttributesResponse EndUpdateUserAttributes(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateUserAttributesResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateUserPool

        /// <summary>
        /// Updates the configuration of a user pool. To avoid setting parameters to Amazon Cognito
        /// defaults, construct this API request to pass the existing configuration of your user
        /// pool, modified to include the changes that you want to make.
        /// 
        ///  <important> 
        /// <para>
        /// If you don't provide a value for an attribute, Amazon Cognito sets it to its default
        /// value.
        /// </para>
        ///  </important> <note> 
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
        /// Services service, Amazon Simple Notification Service might place your account in the
        /// SMS sandbox. In <i> <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-sms-sandbox.html">sandbox
        /// mode</a> </i>, you can send messages only to verified phone numbers. After you test
        /// your app while in the sandbox environment, you can move out of the sandbox and into
        /// production. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pool-sms-settings.html">
        /// SMS message settings for Amazon Cognito user pools</a> in the <i>Amazon Cognito Developer
        /// Guide</i>.
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// Amazon Cognito evaluates Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you must use IAM credentials to authorize
        /// requests, and you must grant yourself the corresponding IAM permission in a policy.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
        /// Amazon Web Services API Requests</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a> 
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserPool service method.</param>
        /// 
        /// <returns>The response from the UpdateUserPool service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ConcurrentModificationException">
        /// This exception is thrown if two or more modifications are happening concurrently.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.FeatureUnavailableInTierException">
        /// This exception is thrown when a feature you attempted to configure isn't available
        /// in your current feature plan.
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
        /// for SMS configuration. This can happen if you don't trust <c>cognito-idp.amazonaws.com</c>
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
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.TierChangeNotAllowedException">
        /// This exception is thrown when you've attempted to change your feature plan but the
        /// operation isn't permitted.
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
        public virtual UpdateUserPoolResponse UpdateUserPool(UpdateUserPoolRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUserPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserPoolResponseUnmarshaller.Instance;

            return Invoke<UpdateUserPoolResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateUserPool">REST API Reference for UpdateUserPool Operation</seealso>
        public virtual IAsyncResult BeginUpdateUserPool(UpdateUserPoolRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUserPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserPoolResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateUserPool operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateUserPool.</param>
        /// 
        /// <returns>Returns a  UpdateUserPoolResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateUserPool">REST API Reference for UpdateUserPool Operation</seealso>
        public virtual UpdateUserPoolResponse EndUpdateUserPool(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateUserPoolResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateUserPoolClient

        /// <summary>
        /// Given a user pool app client ID, updates the configuration. To avoid setting parameters
        /// to Amazon Cognito defaults, construct this API request to pass the existing configuration
        /// of your app client, modified to include the changes that you want to make.
        /// 
        ///  <important> 
        /// <para>
        /// If you don't provide a value for an attribute, Amazon Cognito sets it to its default
        /// value.
        /// </para>
        ///  </important> 
        /// <para>
        /// Unlike app clients created in the console, Amazon Cognito doesn't automatically assign
        /// a branding style to app clients that you configure with this API operation. Managed
        /// login and classic hosted UI pages aren't available for your client until after you
        /// apply a branding style.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon Cognito evaluates Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you must use IAM credentials to authorize
        /// requests, and you must grant yourself the corresponding IAM permission in a policy.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
        /// Amazon Web Services API Requests</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a> 
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserPoolClient service method.</param>
        /// 
        /// <returns>The response from the UpdateUserPoolClient service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ConcurrentModificationException">
        /// This exception is thrown if two or more modifications are happening concurrently.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.FeatureUnavailableInTierException">
        /// This exception is thrown when a feature you attempted to configure isn't available
        /// in your current feature plan.
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
        public virtual UpdateUserPoolClientResponse UpdateUserPoolClient(UpdateUserPoolClientRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUserPoolClientRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserPoolClientResponseUnmarshaller.Instance;

            return Invoke<UpdateUserPoolClientResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateUserPoolClient">REST API Reference for UpdateUserPoolClient Operation</seealso>
        public virtual IAsyncResult BeginUpdateUserPoolClient(UpdateUserPoolClientRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUserPoolClientRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserPoolClientResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateUserPoolClient operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateUserPoolClient.</param>
        /// 
        /// <returns>Returns a  UpdateUserPoolClientResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateUserPoolClient">REST API Reference for UpdateUserPoolClient Operation</seealso>
        public virtual UpdateUserPoolClientResponse EndUpdateUserPoolClient(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateUserPoolClientResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateUserPoolDomain

        /// <summary>
        /// A user pool domain hosts managed login, an authorization server and web server for
        /// authentication in your application. This operation updates the branding version for
        /// user pool domains between <c>1</c> for hosted UI (classic) and <c>2</c> for managed
        /// login. It also updates the SSL certificate for user pool custom domains.
        /// 
        ///  
        /// <para>
        /// Changes to the domain branding version take up to one minute to take effect for a
        /// prefix domain and up to five minutes for a custom domain.
        /// </para>
        ///  
        /// <para>
        /// This operation doesn't change the name of your user pool domain. To change your domain,
        /// delete it with <c>DeleteUserPoolDomain</c> and create a new domain with <c>CreateUserPoolDomain</c>.
        /// </para>
        ///  
        /// <para>
        /// You can pass the ARN of a new Certificate Manager certificate in this request. Typically,
        /// ACM certificates automatically renew and you user pool can continue to use the same
        /// ARN. But if you generate a new certificate for your custom domain name, replace the
        /// original configuration with the new ARN in this request.
        /// </para>
        ///  
        /// <para>
        /// ACM certificates for custom domains must be in the US East (N. Virginia) Amazon Web
        /// Services Region. After you submit your request, Amazon Cognito requires up to 1 hour
        /// to distribute your new certificate to your custom domain.
        /// </para>
        ///  
        /// <para>
        /// For more information about adding a custom domain to your user pool, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pools-add-custom-domain.html">Configuring
        /// a user pool domain</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon Cognito evaluates Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you must use IAM credentials to authorize
        /// requests, and you must grant yourself the corresponding IAM permission in a policy.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
        /// Amazon Web Services API Requests</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a> 
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserPoolDomain service method.</param>
        /// 
        /// <returns>The response from the UpdateUserPoolDomain service method, as returned by CognitoIdentityProvider.</returns>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.ConcurrentModificationException">
        /// This exception is thrown if two or more modifications are happening concurrently.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentityProvider.Model.FeatureUnavailableInTierException">
        /// This exception is thrown when a feature you attempted to configure isn't available
        /// in your current feature plan.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateUserPoolDomain">REST API Reference for UpdateUserPoolDomain Operation</seealso>
        public virtual UpdateUserPoolDomainResponse UpdateUserPoolDomain(UpdateUserPoolDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUserPoolDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserPoolDomainResponseUnmarshaller.Instance;

            return Invoke<UpdateUserPoolDomainResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginUpdateUserPoolDomain(UpdateUserPoolDomainRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUserPoolDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserPoolDomainResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateUserPoolDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateUserPoolDomain.</param>
        /// 
        /// <returns>Returns a  UpdateUserPoolDomainResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateUserPoolDomain">REST API Reference for UpdateUserPoolDomain Operation</seealso>
        public virtual UpdateUserPoolDomainResponse EndUpdateUserPoolDomain(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateUserPoolDomainResponse>(asyncResult);
        }

        #endregion
        
        #region  VerifySoftwareToken

        /// <summary>
        /// Registers the current user's time-based one-time password (TOTP) authenticator with
        /// a code generated in their authenticator app from a private key that's supplied by
        /// your user pool. Marks the user's software token MFA status as "verified" if successful.
        /// The request takes an access token or a session string, but not both.
        /// 
        ///  <note> 
        /// <para>
        /// Amazon Cognito doesn't evaluate Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you can't use IAM credentials to authorize
        /// requests, and you can't grant IAM permissions in policies. For more information about
        /// authorization models in Amazon Cognito, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a>.
        /// </para>
        ///  </note>
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
        public virtual VerifySoftwareTokenResponse VerifySoftwareToken(VerifySoftwareTokenRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = VerifySoftwareTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = VerifySoftwareTokenResponseUnmarshaller.Instance;

            return Invoke<VerifySoftwareTokenResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginVerifySoftwareToken(VerifySoftwareTokenRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = VerifySoftwareTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = VerifySoftwareTokenResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  VerifySoftwareToken operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginVerifySoftwareToken.</param>
        /// 
        /// <returns>Returns a  VerifySoftwareTokenResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/VerifySoftwareToken">REST API Reference for VerifySoftwareToken Operation</seealso>
        public virtual VerifySoftwareTokenResponse EndVerifySoftwareToken(IAsyncResult asyncResult)
        {
            return EndInvoke<VerifySoftwareTokenResponse>(asyncResult);
        }

        #endregion
        
        #region  VerifyUserAttribute

        /// <summary>
        /// Submits a verification code for a signed-in user who has added or changed a value
        /// of an auto-verified attribute. When successful, the user's attribute becomes verified
        /// and the attribute <c>email_verified</c> or <c>phone_number_verified</c> becomes <c>true</c>.
        /// 
        ///  
        /// <para>
        ///  If your user pool requires verification before Amazon Cognito updates the attribute
        /// value, this operation updates the affected attribute to its pending value.
        /// </para>
        ///  
        /// <para>
        /// Authorize this action with a signed-in user's access token. It must include the scope
        /// <c>aws.cognito.signin.user.admin</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon Cognito doesn't evaluate Identity and Access Management (IAM) policies in requests
        /// for this API operation. For this operation, you can't use IAM credentials to authorize
        /// requests, and you can't grant IAM permissions in policies. For more information about
        /// authorization models in Amazon Cognito, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
        /// the Amazon Cognito user pools API and user pool endpoints</a>.
        /// </para>
        ///  </note>
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
        public virtual VerifyUserAttributeResponse VerifyUserAttribute(VerifyUserAttributeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = VerifyUserAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = VerifyUserAttributeResponseUnmarshaller.Instance;

            return Invoke<VerifyUserAttributeResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/VerifyUserAttribute">REST API Reference for VerifyUserAttribute Operation</seealso>
        public virtual IAsyncResult BeginVerifyUserAttribute(VerifyUserAttributeRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = VerifyUserAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = VerifyUserAttributeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  VerifyUserAttribute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginVerifyUserAttribute.</param>
        /// 
        /// <returns>Returns a  VerifyUserAttributeResult from CognitoIdentityProvider.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/VerifyUserAttribute">REST API Reference for VerifyUserAttribute Operation</seealso>
        public virtual VerifyUserAttributeResponse EndVerifyUserAttribute(IAsyncResult asyncResult)
        {
            return EndInvoke<VerifyUserAttributeResponse>(asyncResult);
        }

        #endregion
        
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        public Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request)
        {
            var requestContext = new Amazon.Runtime.Internal.RequestContext(false, CreateSigner())
            {
                ClientConfig = Config,
                OriginalRequest = request,
                Request = new Amazon.Runtime.Internal.DefaultRequest(request, ServiceMetadata.ServiceId)
            };

            var executionContext = new Amazon.Runtime.Internal.ExecutionContext(requestContext, null);
            var resolver = new AmazonCognitoIdentityProviderEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}