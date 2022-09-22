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
 * Do not modify this file. This file is generated from the sso-oidc-2019-06-10.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.SSOOIDC.Model;
using Amazon.SSOOIDC.Model.Internal.MarshallTransformations;
using Amazon.SSOOIDC.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.SSOOIDC
{
    /// <summary>
    /// Implementation for accessing SSOOIDC
    ///
    /// AWS IAM Identity Center (successor to AWS Single Sign-On) OpenID Connect (OIDC) is
    /// a web service that enables a client (such as AWS CLI or a native application) to register
    /// with IAM Identity Center. The service also enables the client to fetch the user’s
    /// access token upon successful authentication and authorization with IAM Identity Center.
    /// 
    ///  <note> 
    /// <para>
    /// Although AWS Single Sign-On was renamed, the <code>sso</code> and <code>identitystore</code>
    /// API namespaces will continue to retain their original name for backward compatibility
    /// purposes. For more information, see <a href="https://docs.aws.amazon.com/singlesignon/latest/userguide/what-is.html#renamed">IAM
    /// Identity Center rename</a>.
    /// </para>
    ///  </note> 
    /// <para>
    ///  <b>Considerations for Using This Guide</b> 
    /// </para>
    ///  
    /// <para>
    /// Before you begin using this guide, we recommend that you first review the following
    /// important information about how the IAM Identity Center OIDC service works.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The IAM Identity Center OIDC service currently implements only the portions of the
    /// OAuth 2.0 Device Authorization Grant standard (<a href="https://tools.ietf.org/html/rfc8628">https://tools.ietf.org/html/rfc8628</a>)
    /// that are necessary to enable single sign-on authentication with the AWS CLI. Support
    /// for other OIDC flows frequently needed for native applications, such as Authorization
    /// Code Flow (+ PKCE), will be addressed in future releases.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The service emits only OIDC access tokens, such that obtaining a new token (For example,
    /// token refresh) requires explicit user re-authentication.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The access tokens provided by this service grant access to all AWS account entitlements
    /// assigned to an IAM Identity Center user, not just a particular application.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The documentation in this guide does not describe the mechanism to convert the access
    /// token into AWS Auth (“sigv4”) credentials for use with IAM-protected AWS service endpoints.
    /// For more information, see <a href="https://docs.aws.amazon.com/singlesignon/latest/PortalAPIReference/API_GetRoleCredentials.html">GetRoleCredentials</a>
    /// in the <i>IAM Identity Center Portal API Reference Guide</i>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For general information about IAM Identity Center, see <a href="https://docs.aws.amazon.com/singlesignon/latest/userguide/what-is.html">What
    /// is IAM Identity Center?</a> in the <i>IAM Identity Center User Guide</i>.
    /// </para>
    /// </summary>
    public partial class AmazonSSOOIDCClient : AmazonServiceClient, IAmazonSSOOIDC
    {
        private static IServiceMetadata serviceMetadata = new AmazonSSOOIDCMetadata();

        #region Constructors

        /// <summary>
        /// Constructs AmazonSSOOIDCClient with the credentials loaded from the application's
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
        public AmazonSSOOIDCClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSSOOIDCConfig()) { }

        /// <summary>
        /// Constructs AmazonSSOOIDCClient with the credentials loaded from the application's
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
        public AmazonSSOOIDCClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSSOOIDCConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonSSOOIDCClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonSSOOIDCClient Configuration Object</param>
        public AmazonSSOOIDCClient(AmazonSSOOIDCConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonSSOOIDCClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonSSOOIDCClient(AWSCredentials credentials)
            : this(credentials, new AmazonSSOOIDCConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSSOOIDCClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSSOOIDCClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonSSOOIDCConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSSOOIDCClient with AWS Credentials and an
        /// AmazonSSOOIDCClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSSOOIDCClient Configuration Object</param>
        public AmazonSSOOIDCClient(AWSCredentials credentials, AmazonSSOOIDCConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSSOOIDCClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonSSOOIDCClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSSOOIDCConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSSOOIDCClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSSOOIDCClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSSOOIDCConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonSSOOIDCClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSSOOIDCClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSSOOIDCClient Configuration Object</param>
        public AmazonSSOOIDCClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSSOOIDCConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSSOOIDCClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonSSOOIDCClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSSOOIDCConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSSOOIDCClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSSOOIDCClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSSOOIDCConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSSOOIDCClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSSOOIDCClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonSSOOIDCClient Configuration Object</param>
        public AmazonSSOOIDCClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonSSOOIDCConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonSSOOIDCEndpointResolver());
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


        #region  CreateToken

        /// <summary>
        /// Creates and returns an access token for the authorized client. The access token issued
        /// will be used to fetch short-term credentials for the assigned roles in the AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateToken service method.</param>
        /// 
        /// <returns>The response from the CreateToken service method, as returned by SSOOIDC.</returns>
        /// <exception cref="Amazon.SSOOIDC.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOOIDC.Model.AuthorizationPendingException">
        /// Indicates that a request to authorize a client with an access user session token is
        /// pending.
        /// </exception>
        /// <exception cref="Amazon.SSOOIDC.Model.ExpiredTokenException">
        /// Indicates that the token issued by the service is expired and is no longer valid.
        /// </exception>
        /// <exception cref="Amazon.SSOOIDC.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.SSOOIDC.Model.InvalidClientException">
        /// Indicates that the <code>clientId</code> or <code>clientSecret</code> in the request
        /// is invalid. For example, this can occur when a client sends an incorrect <code>clientId</code>
        /// or an expired <code>clientSecret</code>.
        /// </exception>
        /// <exception cref="Amazon.SSOOIDC.Model.InvalidGrantException">
        /// Indicates that a request contains an invalid grant. This can occur if a client makes
        /// a <a>CreateToken</a> request with an invalid grant type.
        /// </exception>
        /// <exception cref="Amazon.SSOOIDC.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter might be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.SSOOIDC.Model.InvalidScopeException">
        /// Indicates that the scope provided in the request is invalid.
        /// </exception>
        /// <exception cref="Amazon.SSOOIDC.Model.SlowDownException">
        /// Indicates that the client is making the request too frequently and is more than the
        /// service can handle.
        /// </exception>
        /// <exception cref="Amazon.SSOOIDC.Model.UnauthorizedClientException">
        /// Indicates that the client is not currently authorized to make the request. This can
        /// happen when a <code>clientId</code> is not issued for a public client.
        /// </exception>
        /// <exception cref="Amazon.SSOOIDC.Model.UnsupportedGrantTypeException">
        /// Indicates that the grant type in the request is not supported by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-oidc-2019-06-10/CreateToken">REST API Reference for CreateToken Operation</seealso>
        public virtual CreateTokenResponse CreateToken(CreateTokenRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTokenResponseUnmarshaller.Instance;

            return Invoke<CreateTokenResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateToken operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateToken operation on AmazonSSOOIDCClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateToken
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-oidc-2019-06-10/CreateToken">REST API Reference for CreateToken Operation</seealso>
        public virtual IAsyncResult BeginCreateToken(CreateTokenRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTokenResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateToken operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateToken.</param>
        /// 
        /// <returns>Returns a  CreateTokenResult from SSOOIDC.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-oidc-2019-06-10/CreateToken">REST API Reference for CreateToken Operation</seealso>
        public virtual CreateTokenResponse EndCreateToken(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateTokenResponse>(asyncResult);
        }

        #endregion
        
        #region  RegisterClient

        /// <summary>
        /// Registers a client with IAM Identity Center. This allows clients to initiate device
        /// authorization. The output should be persisted for reuse through many authentication
        /// requests.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterClient service method.</param>
        /// 
        /// <returns>The response from the RegisterClient service method, as returned by SSOOIDC.</returns>
        /// <exception cref="Amazon.SSOOIDC.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.SSOOIDC.Model.InvalidClientMetadataException">
        /// Indicates that the client information sent in the request during registration is invalid.
        /// </exception>
        /// <exception cref="Amazon.SSOOIDC.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter might be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.SSOOIDC.Model.InvalidScopeException">
        /// Indicates that the scope provided in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-oidc-2019-06-10/RegisterClient">REST API Reference for RegisterClient Operation</seealso>
        public virtual RegisterClientResponse RegisterClient(RegisterClientRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterClientRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterClientResponseUnmarshaller.Instance;

            return Invoke<RegisterClientResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterClient operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterClient operation on AmazonSSOOIDCClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterClient
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-oidc-2019-06-10/RegisterClient">REST API Reference for RegisterClient Operation</seealso>
        public virtual IAsyncResult BeginRegisterClient(RegisterClientRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterClientRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterClientResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterClient operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterClient.</param>
        /// 
        /// <returns>Returns a  RegisterClientResult from SSOOIDC.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-oidc-2019-06-10/RegisterClient">REST API Reference for RegisterClient Operation</seealso>
        public virtual RegisterClientResponse EndRegisterClient(IAsyncResult asyncResult)
        {
            return EndInvoke<RegisterClientResponse>(asyncResult);
        }

        #endregion
        
        #region  StartDeviceAuthorization

        /// <summary>
        /// Initiates device authorization by requesting a pair of verification codes from the
        /// authorization service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDeviceAuthorization service method.</param>
        /// 
        /// <returns>The response from the StartDeviceAuthorization service method, as returned by SSOOIDC.</returns>
        /// <exception cref="Amazon.SSOOIDC.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.SSOOIDC.Model.InvalidClientException">
        /// Indicates that the <code>clientId</code> or <code>clientSecret</code> in the request
        /// is invalid. For example, this can occur when a client sends an incorrect <code>clientId</code>
        /// or an expired <code>clientSecret</code>.
        /// </exception>
        /// <exception cref="Amazon.SSOOIDC.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter might be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.SSOOIDC.Model.SlowDownException">
        /// Indicates that the client is making the request too frequently and is more than the
        /// service can handle.
        /// </exception>
        /// <exception cref="Amazon.SSOOIDC.Model.UnauthorizedClientException">
        /// Indicates that the client is not currently authorized to make the request. This can
        /// happen when a <code>clientId</code> is not issued for a public client.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-oidc-2019-06-10/StartDeviceAuthorization">REST API Reference for StartDeviceAuthorization Operation</seealso>
        public virtual StartDeviceAuthorizationResponse StartDeviceAuthorization(StartDeviceAuthorizationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartDeviceAuthorizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDeviceAuthorizationResponseUnmarshaller.Instance;

            return Invoke<StartDeviceAuthorizationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartDeviceAuthorization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartDeviceAuthorization operation on AmazonSSOOIDCClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartDeviceAuthorization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-oidc-2019-06-10/StartDeviceAuthorization">REST API Reference for StartDeviceAuthorization Operation</seealso>
        public virtual IAsyncResult BeginStartDeviceAuthorization(StartDeviceAuthorizationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartDeviceAuthorizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDeviceAuthorizationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartDeviceAuthorization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartDeviceAuthorization.</param>
        /// 
        /// <returns>Returns a  StartDeviceAuthorizationResult from SSOOIDC.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-oidc-2019-06-10/StartDeviceAuthorization">REST API Reference for StartDeviceAuthorization Operation</seealso>
        public virtual StartDeviceAuthorizationResponse EndStartDeviceAuthorization(IAsyncResult asyncResult)
        {
            return EndInvoke<StartDeviceAuthorizationResponse>(asyncResult);
        }

        #endregion
        
    }
}