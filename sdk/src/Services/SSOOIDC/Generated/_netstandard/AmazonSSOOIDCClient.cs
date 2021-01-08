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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
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
    /// AWS Single Sign-On (SSO) OpenID Connect (OIDC) is a web service that enables a client
    /// (such as AWS CLI or a native application) to register with AWS SSO. The service also
    /// enables the client to fetch the user’s access token upon successful authentication
    /// and authorization with AWS SSO. This service conforms with the OAuth 2.0 based implementation
    /// of the device authorization grant standard (<a href="https://tools.ietf.org/html/rfc8628">https://tools.ietf.org/html/rfc8628</a>).
    /// 
    ///  
    /// <para>
    /// For general information about AWS SSO, see <a href="https://docs.aws.amazon.com/singlesignon/latest/userguide/what-is.html">What
    /// is AWS Single Sign-On?</a> in the <i>AWS SSO User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// This API reference guide describes the AWS SSO OIDC operations that you can call programatically
    /// and includes detailed information on data types and errors.
    /// </para>
    ///  <note> 
    /// <para>
    /// AWS provides SDKs that consist of libraries and sample code for various programming
    /// languages and platforms such as Java, Ruby, .Net, iOS, and Android. The SDKs provide
    /// a convenient way to create programmatic access to AWS SSO and other AWS services.
    /// For more information about the AWS SDKs, including how to download and install them,
    /// see <a href="http://aws.amazon.com/tools/">Tools for Amazon Web Services</a>.
    /// </para>
    ///  </note>
    /// </summary>
#if NETSTANDARD13
    [Obsolete("Support for .NET Standard 1.3 is in maintenance mode and will only receive critical bug fixes and security patches. Visit https://docs.aws.amazon.com/sdk-for-net/v3/developer-guide/migration-from-net-standard-1-3.html for further details.")]
#endif
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

        internal virtual CreateTokenResponse CreateToken(CreateTokenRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTokenResponseUnmarshaller.Instance;

            return Invoke<CreateTokenResponse>(request, options);
        }



        /// <summary>
        /// Creates and returns an access token for the authorized client. The access token issued
        /// will be used to fetch short-term credentials for the assigned roles in the AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateToken service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateTokenResponse> CreateTokenAsync(CreateTokenRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTokenResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTokenResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RegisterClient

        internal virtual RegisterClientResponse RegisterClient(RegisterClientRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterClientRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterClientResponseUnmarshaller.Instance;

            return Invoke<RegisterClientResponse>(request, options);
        }



        /// <summary>
        /// Registers a client with AWS SSO. This allows clients to initiate device authorization.
        /// The output should be persisted for reuse through many authentication requests.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterClient service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<RegisterClientResponse> RegisterClientAsync(RegisterClientRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterClientRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterClientResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterClientResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartDeviceAuthorization

        internal virtual StartDeviceAuthorizationResponse StartDeviceAuthorization(StartDeviceAuthorizationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartDeviceAuthorizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDeviceAuthorizationResponseUnmarshaller.Instance;

            return Invoke<StartDeviceAuthorizationResponse>(request, options);
        }



        /// <summary>
        /// Initiates device authorization by requesting a pair of verification codes from the
        /// authorization service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDeviceAuthorization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<StartDeviceAuthorizationResponse> StartDeviceAuthorizationAsync(StartDeviceAuthorizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartDeviceAuthorizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDeviceAuthorizationResponseUnmarshaller.Instance;

            return InvokeAsync<StartDeviceAuthorizationResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}