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
 * Do not modify this file. This file is generated from the signin-2023-01-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.Signin.Model;
using Amazon.Signin.Model.Internal.MarshallTransformations;
using Amazon.Signin.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.Signin
{
    /// <summary>
    /// <para>Implementation for accessing Signin</para>
    /// <para>
    /// Service client instances are thread-safe and can be shared across multiple threads.
    /// For a given service configuration, it is recommended to reuse a client instance
    /// for the lifetime of your application.
    /// </para>
    ///
    /// AWS Sign-In manages authentication for AWS services. This service provides secure
    /// authentication flows for accessing AWS resources from the console and developer tools.
    /// </summary>
    public partial class AmazonSigninClient : AmazonServiceClient, IAmazonSignin
    {
        private static IServiceMetadata serviceMetadata = new AmazonSigninMetadata();
        private ISigninPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ISigninPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new SigninPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonSigninClient with the credentials loaded from the application's
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
        public AmazonSigninClient()
            : base(new AmazonSigninConfig()) { }

        /// <summary>
        /// Constructs AmazonSigninClient with the credentials loaded from the application's
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
        public AmazonSigninClient(RegionEndpoint region)
            : base(new AmazonSigninConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonSigninClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonSigninClient Configuration Object</param>
        public AmazonSigninClient(AmazonSigninConfig config)
            : base(config) { }

        /// <summary>
        /// Constructs AmazonSigninClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonSigninClient(AWSCredentials credentials)
            : this(credentials, new AmazonSigninConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSigninClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSigninClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonSigninConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSigninClient with AWS Credentials and an
        /// AmazonSigninClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSigninClient Configuration Object</param>
        public AmazonSigninClient(AWSCredentials credentials, AmazonSigninConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSigninClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonSigninClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSigninConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSigninClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSigninClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSigninConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonSigninClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSigninClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSigninClient Configuration Object</param>
        public AmazonSigninClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSigninConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSigninClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonSigninClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSigninConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSigninClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSigninClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSigninConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSigninClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSigninClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonSigninClient Configuration Object</param>
        public AmazonSigninClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonSigninConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides  

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.EndpointResolver>(new Amazon.Signin.Internal.AmazonSigninPostMarshallerHandler());
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonSigninEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonSigninAuthSchemeHandler());
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


        #region  CreateOAuth2Token


        /// <summary>
        /// CreateOAuth2Token API
        /// 
        ///  
        /// <para>
        /// Path: /v1/token Request Method: POST Content-Type: application/json or application/x-www-form-urlencoded
        /// </para>
        ///  
        /// <para>
        /// This API implements OAuth 2.0 flows for AWS Sign-In CLI clients, supporting both:
        /// </para>
        ///  <ol> <li>Authorization code redemption (grant_type=authorization_code) - NOT idempotent</li>
        /// <li>Token refresh (grant_type=refresh_token) - Idempotent within token validity window</li>
        /// </ol> 
        /// <para>
        /// The operation behavior is determined by the grant_type parameter in the request body:
        /// </para>
        ///  
        /// <para>
        /// <strong>Authorization Code Flow (NOT Idempotent):</strong>
        /// </para>
        ///  <ul> <li>JSON or form-encoded body with client_id, grant_type=authorization_code,
        /// code, redirect_uri, code_verifier</li> <li>Returns access_token, token_type, expires_in,
        /// refresh_token, and id_token</li> <li>Each authorization code can only be used ONCE
        /// for security (prevents replay attacks)</li> </ul> 
        /// <para>
        /// <strong>Token Refresh Flow (Idempotent):</strong>
        /// </para>
        ///  <ul> <li>JSON or form-encoded body with client_id, grant_type=refresh_token, refresh_token</li>
        /// <li>Returns access_token, token_type, expires_in, and refresh_token (no id_token)</li>
        /// <li>Multiple calls with same refresh_token return consistent results within validity
        /// window</li> </ul> 
        /// <para>
        /// Authentication and authorization:
        /// </para>
        ///  <ul> <li>Confidential clients: sigv4 signing required with signin:ExchangeToken permissions</li>
        /// <li>CLI clients (public): authn/authz skipped based on client_id &amp; grant_type</li>
        /// </ul> 
        /// <para>
        /// Note: This operation cannot be marked as @idempotent because it handles both idempotent
        /// (token refresh) and non-idempotent (auth code redemption) flows in a single endpoint.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOAuth2Token service method.</param>
        /// 
        /// <returns>The response from the CreateOAuth2Token service method, as returned by Signin.</returns>
        /// <exception cref="Amazon.Signin.Model.AccessDeniedException">
        /// Error thrown for access denied scenarios with flexible HTTP status mapping
        /// 
        ///  
        /// <para>
        /// Runtime HTTP Status Code Mapping:
        /// </para>
        ///  <ul> <li>HTTP 401 (Unauthorized): TOKEN_EXPIRED, AUTHCODE_EXPIRED</li> <li>HTTP 403
        /// (Forbidden): USER_CREDENTIALS_CHANGED, INSUFFICIENT_PERMISSIONS</li> </ul> 
        /// <para>
        /// The specific HTTP status code is determined at runtime based on the error enum value.
        /// Consumers should use the error field to determine the specific access denial reason.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.InternalServerException">
        /// Error thrown when an internal server error occurs
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 500 Internal Server Error
        /// </para>
        ///  
        /// <para>
        /// Used for unexpected server-side errors that prevent request processing.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.TooManyRequestsErrorException">
        /// Error thrown when rate limit is exceeded
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 429 Too Many Requests
        /// </para>
        ///  
        /// <para>
        /// Possible OAuth2ErrorCode values:
        /// </para>
        ///  <ul> <li>INVALID_REQUEST: Rate limiting, too many requests, abuse prevention</li>
        /// </ul> 
        /// <para>
        /// Possible causes:
        /// </para>
        ///  <ul> <li>Too many token requests from the same client</li> <li>Rate limiting based
        /// on client_id or IP address</li> <li>Abuse prevention mechanisms triggered</li> <li>Service
        /// protection against excessive token generation</li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ValidationException">
        /// Error thrown when request validation fails
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 400 Bad Request
        /// </para>
        ///  
        /// <para>
        /// Used for request validation errors such as malformed parameters, missing required
        /// fields, or invalid parameter values.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signin-2023-01-01/CreateOAuth2Token">REST API Reference for CreateOAuth2Token Operation</seealso>
        public virtual CreateOAuth2TokenResponse CreateOAuth2Token(CreateOAuth2TokenRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateOAuth2TokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOAuth2TokenResponseUnmarshaller.Instance;

            return Invoke<CreateOAuth2TokenResponse>(request, options);
        }


        /// <summary>
        /// CreateOAuth2Token API
        /// 
        ///  
        /// <para>
        /// Path: /v1/token Request Method: POST Content-Type: application/json or application/x-www-form-urlencoded
        /// </para>
        ///  
        /// <para>
        /// This API implements OAuth 2.0 flows for AWS Sign-In CLI clients, supporting both:
        /// </para>
        ///  <ol> <li>Authorization code redemption (grant_type=authorization_code) - NOT idempotent</li>
        /// <li>Token refresh (grant_type=refresh_token) - Idempotent within token validity window</li>
        /// </ol> 
        /// <para>
        /// The operation behavior is determined by the grant_type parameter in the request body:
        /// </para>
        ///  
        /// <para>
        /// <strong>Authorization Code Flow (NOT Idempotent):</strong>
        /// </para>
        ///  <ul> <li>JSON or form-encoded body with client_id, grant_type=authorization_code,
        /// code, redirect_uri, code_verifier</li> <li>Returns access_token, token_type, expires_in,
        /// refresh_token, and id_token</li> <li>Each authorization code can only be used ONCE
        /// for security (prevents replay attacks)</li> </ul> 
        /// <para>
        /// <strong>Token Refresh Flow (Idempotent):</strong>
        /// </para>
        ///  <ul> <li>JSON or form-encoded body with client_id, grant_type=refresh_token, refresh_token</li>
        /// <li>Returns access_token, token_type, expires_in, and refresh_token (no id_token)</li>
        /// <li>Multiple calls with same refresh_token return consistent results within validity
        /// window</li> </ul> 
        /// <para>
        /// Authentication and authorization:
        /// </para>
        ///  <ul> <li>Confidential clients: sigv4 signing required with signin:ExchangeToken permissions</li>
        /// <li>CLI clients (public): authn/authz skipped based on client_id &amp; grant_type</li>
        /// </ul> 
        /// <para>
        /// Note: This operation cannot be marked as @idempotent because it handles both idempotent
        /// (token refresh) and non-idempotent (auth code redemption) flows in a single endpoint.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOAuth2Token service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateOAuth2Token service method, as returned by Signin.</returns>
        /// <exception cref="Amazon.Signin.Model.AccessDeniedException">
        /// Error thrown for access denied scenarios with flexible HTTP status mapping
        /// 
        ///  
        /// <para>
        /// Runtime HTTP Status Code Mapping:
        /// </para>
        ///  <ul> <li>HTTP 401 (Unauthorized): TOKEN_EXPIRED, AUTHCODE_EXPIRED</li> <li>HTTP 403
        /// (Forbidden): USER_CREDENTIALS_CHANGED, INSUFFICIENT_PERMISSIONS</li> </ul> 
        /// <para>
        /// The specific HTTP status code is determined at runtime based on the error enum value.
        /// Consumers should use the error field to determine the specific access denial reason.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.InternalServerException">
        /// Error thrown when an internal server error occurs
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 500 Internal Server Error
        /// </para>
        ///  
        /// <para>
        /// Used for unexpected server-side errors that prevent request processing.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.TooManyRequestsErrorException">
        /// Error thrown when rate limit is exceeded
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 429 Too Many Requests
        /// </para>
        ///  
        /// <para>
        /// Possible OAuth2ErrorCode values:
        /// </para>
        ///  <ul> <li>INVALID_REQUEST: Rate limiting, too many requests, abuse prevention</li>
        /// </ul> 
        /// <para>
        /// Possible causes:
        /// </para>
        ///  <ul> <li>Too many token requests from the same client</li> <li>Rate limiting based
        /// on client_id or IP address</li> <li>Abuse prevention mechanisms triggered</li> <li>Service
        /// protection against excessive token generation</li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ValidationException">
        /// Error thrown when request validation fails
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 400 Bad Request
        /// </para>
        ///  
        /// <para>
        /// Used for request validation errors such as malformed parameters, missing required
        /// fields, or invalid parameter values.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signin-2023-01-01/CreateOAuth2Token">REST API Reference for CreateOAuth2Token Operation</seealso>
        public virtual Task<CreateOAuth2TokenResponse> CreateOAuth2TokenAsync(CreateOAuth2TokenRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateOAuth2TokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOAuth2TokenResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateOAuth2TokenResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateOAuth2TokenWithIAM


        /// <summary>
        /// Grants permission to exchange client credentials for an OAuth 2.0 access token scoped
        /// to a resource that can be used to access AWS services from applications
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOAuth2TokenWithIAM service method.</param>
        /// 
        /// <returns>The response from the CreateOAuth2TokenWithIAM service method, as returned by Signin.</returns>
        /// <exception cref="Amazon.Signin.Model.AccessDeniedException">
        /// Error thrown for access denied scenarios with flexible HTTP status mapping
        /// 
        ///  
        /// <para>
        /// Runtime HTTP Status Code Mapping:
        /// </para>
        ///  <ul> <li>HTTP 401 (Unauthorized): TOKEN_EXPIRED, AUTHCODE_EXPIRED</li> <li>HTTP 403
        /// (Forbidden): USER_CREDENTIALS_CHANGED, INSUFFICIENT_PERMISSIONS</li> </ul> 
        /// <para>
        /// The specific HTTP status code is determined at runtime based on the error enum value.
        /// Consumers should use the error field to determine the specific access denial reason.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.InternalServerException">
        /// Error thrown when an internal server error occurs
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 500 Internal Server Error
        /// </para>
        ///  
        /// <para>
        /// Used for unexpected server-side errors that prevent request processing.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.TooManyRequestsErrorException">
        /// Error thrown when rate limit is exceeded
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 429 Too Many Requests
        /// </para>
        ///  
        /// <para>
        /// Possible OAuth2ErrorCode values:
        /// </para>
        ///  <ul> <li>INVALID_REQUEST: Rate limiting, too many requests, abuse prevention</li>
        /// </ul> 
        /// <para>
        /// Possible causes:
        /// </para>
        ///  <ul> <li>Too many token requests from the same client</li> <li>Rate limiting based
        /// on client_id or IP address</li> <li>Abuse prevention mechanisms triggered</li> <li>Service
        /// protection against excessive token generation</li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ValidationException">
        /// Error thrown when request validation fails
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 400 Bad Request
        /// </para>
        ///  
        /// <para>
        /// Used for request validation errors such as malformed parameters, missing required
        /// fields, or invalid parameter values.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signin-2023-01-01/CreateOAuth2TokenWithIAM">REST API Reference for CreateOAuth2TokenWithIAM Operation</seealso>
        public virtual CreateOAuth2TokenWithIAMResponse CreateOAuth2TokenWithIAM(CreateOAuth2TokenWithIAMRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateOAuth2TokenWithIAMRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOAuth2TokenWithIAMResponseUnmarshaller.Instance;

            return Invoke<CreateOAuth2TokenWithIAMResponse>(request, options);
        }


        /// <summary>
        /// Grants permission to exchange client credentials for an OAuth 2.0 access token scoped
        /// to a resource that can be used to access AWS services from applications
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOAuth2TokenWithIAM service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateOAuth2TokenWithIAM service method, as returned by Signin.</returns>
        /// <exception cref="Amazon.Signin.Model.AccessDeniedException">
        /// Error thrown for access denied scenarios with flexible HTTP status mapping
        /// 
        ///  
        /// <para>
        /// Runtime HTTP Status Code Mapping:
        /// </para>
        ///  <ul> <li>HTTP 401 (Unauthorized): TOKEN_EXPIRED, AUTHCODE_EXPIRED</li> <li>HTTP 403
        /// (Forbidden): USER_CREDENTIALS_CHANGED, INSUFFICIENT_PERMISSIONS</li> </ul> 
        /// <para>
        /// The specific HTTP status code is determined at runtime based on the error enum value.
        /// Consumers should use the error field to determine the specific access denial reason.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.InternalServerException">
        /// Error thrown when an internal server error occurs
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 500 Internal Server Error
        /// </para>
        ///  
        /// <para>
        /// Used for unexpected server-side errors that prevent request processing.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.TooManyRequestsErrorException">
        /// Error thrown when rate limit is exceeded
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 429 Too Many Requests
        /// </para>
        ///  
        /// <para>
        /// Possible OAuth2ErrorCode values:
        /// </para>
        ///  <ul> <li>INVALID_REQUEST: Rate limiting, too many requests, abuse prevention</li>
        /// </ul> 
        /// <para>
        /// Possible causes:
        /// </para>
        ///  <ul> <li>Too many token requests from the same client</li> <li>Rate limiting based
        /// on client_id or IP address</li> <li>Abuse prevention mechanisms triggered</li> <li>Service
        /// protection against excessive token generation</li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ValidationException">
        /// Error thrown when request validation fails
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 400 Bad Request
        /// </para>
        ///  
        /// <para>
        /// Used for request validation errors such as malformed parameters, missing required
        /// fields, or invalid parameter values.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signin-2023-01-01/CreateOAuth2TokenWithIAM">REST API Reference for CreateOAuth2TokenWithIAM Operation</seealso>
        public virtual Task<CreateOAuth2TokenWithIAMResponse> CreateOAuth2TokenWithIAMAsync(CreateOAuth2TokenWithIAMRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateOAuth2TokenWithIAMRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOAuth2TokenWithIAMResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateOAuth2TokenWithIAMResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteConsoleAuthorizationConfiguration


        /// <summary>
        /// Delete console authorization configuration with automatic scope detection
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConsoleAuthorizationConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteConsoleAuthorizationConfiguration service method, as returned by Signin.</returns>
        /// <exception cref="Amazon.Signin.Model.AccessDeniedException">
        /// Error thrown for access denied scenarios with flexible HTTP status mapping
        /// 
        ///  
        /// <para>
        /// Runtime HTTP Status Code Mapping:
        /// </para>
        ///  <ul> <li>HTTP 401 (Unauthorized): TOKEN_EXPIRED, AUTHCODE_EXPIRED</li> <li>HTTP 403
        /// (Forbidden): USER_CREDENTIALS_CHANGED, INSUFFICIENT_PERMISSIONS</li> </ul> 
        /// <para>
        /// The specific HTTP status code is determined at runtime based on the error enum value.
        /// Consumers should use the error field to determine the specific access denial reason.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.InternalServerException">
        /// Error thrown when an internal server error occurs
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 500 Internal Server Error
        /// </para>
        ///  
        /// <para>
        /// Used for unexpected server-side errors that prevent request processing.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ResourceNotFoundException">
        /// Error thrown when requested resource is not found
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 404 Not Found
        /// </para>
        ///  
        /// <para>
        /// Used when the specified resource does not exist
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.TooManyRequestsErrorException">
        /// Error thrown when rate limit is exceeded
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 429 Too Many Requests
        /// </para>
        ///  
        /// <para>
        /// Possible OAuth2ErrorCode values:
        /// </para>
        ///  <ul> <li>INVALID_REQUEST: Rate limiting, too many requests, abuse prevention</li>
        /// </ul> 
        /// <para>
        /// Possible causes:
        /// </para>
        ///  <ul> <li>Too many token requests from the same client</li> <li>Rate limiting based
        /// on client_id or IP address</li> <li>Abuse prevention mechanisms triggered</li> <li>Service
        /// protection against excessive token generation</li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ValidationException">
        /// Error thrown when request validation fails
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 400 Bad Request
        /// </para>
        ///  
        /// <para>
        /// Used for request validation errors such as malformed parameters, missing required
        /// fields, or invalid parameter values.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signin-2023-01-01/DeleteConsoleAuthorizationConfiguration">REST API Reference for DeleteConsoleAuthorizationConfiguration Operation</seealso>
        public virtual DeleteConsoleAuthorizationConfigurationResponse DeleteConsoleAuthorizationConfiguration(DeleteConsoleAuthorizationConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConsoleAuthorizationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConsoleAuthorizationConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteConsoleAuthorizationConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Delete console authorization configuration with automatic scope detection
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConsoleAuthorizationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteConsoleAuthorizationConfiguration service method, as returned by Signin.</returns>
        /// <exception cref="Amazon.Signin.Model.AccessDeniedException">
        /// Error thrown for access denied scenarios with flexible HTTP status mapping
        /// 
        ///  
        /// <para>
        /// Runtime HTTP Status Code Mapping:
        /// </para>
        ///  <ul> <li>HTTP 401 (Unauthorized): TOKEN_EXPIRED, AUTHCODE_EXPIRED</li> <li>HTTP 403
        /// (Forbidden): USER_CREDENTIALS_CHANGED, INSUFFICIENT_PERMISSIONS</li> </ul> 
        /// <para>
        /// The specific HTTP status code is determined at runtime based on the error enum value.
        /// Consumers should use the error field to determine the specific access denial reason.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.InternalServerException">
        /// Error thrown when an internal server error occurs
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 500 Internal Server Error
        /// </para>
        ///  
        /// <para>
        /// Used for unexpected server-side errors that prevent request processing.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ResourceNotFoundException">
        /// Error thrown when requested resource is not found
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 404 Not Found
        /// </para>
        ///  
        /// <para>
        /// Used when the specified resource does not exist
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.TooManyRequestsErrorException">
        /// Error thrown when rate limit is exceeded
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 429 Too Many Requests
        /// </para>
        ///  
        /// <para>
        /// Possible OAuth2ErrorCode values:
        /// </para>
        ///  <ul> <li>INVALID_REQUEST: Rate limiting, too many requests, abuse prevention</li>
        /// </ul> 
        /// <para>
        /// Possible causes:
        /// </para>
        ///  <ul> <li>Too many token requests from the same client</li> <li>Rate limiting based
        /// on client_id or IP address</li> <li>Abuse prevention mechanisms triggered</li> <li>Service
        /// protection against excessive token generation</li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ValidationException">
        /// Error thrown when request validation fails
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 400 Bad Request
        /// </para>
        ///  
        /// <para>
        /// Used for request validation errors such as malformed parameters, missing required
        /// fields, or invalid parameter values.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signin-2023-01-01/DeleteConsoleAuthorizationConfiguration">REST API Reference for DeleteConsoleAuthorizationConfiguration Operation</seealso>
        public virtual Task<DeleteConsoleAuthorizationConfigurationResponse> DeleteConsoleAuthorizationConfigurationAsync(DeleteConsoleAuthorizationConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConsoleAuthorizationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConsoleAuthorizationConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteConsoleAuthorizationConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteResourcePermissionStatement


        /// <summary>
        /// Remove a permission statement from the account's SignIn resource-based policy
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePermissionStatement service method.</param>
        /// 
        /// <returns>The response from the DeleteResourcePermissionStatement service method, as returned by Signin.</returns>
        /// <exception cref="Amazon.Signin.Model.AccessDeniedException">
        /// Error thrown for access denied scenarios with flexible HTTP status mapping
        /// 
        ///  
        /// <para>
        /// Runtime HTTP Status Code Mapping:
        /// </para>
        ///  <ul> <li>HTTP 401 (Unauthorized): TOKEN_EXPIRED, AUTHCODE_EXPIRED</li> <li>HTTP 403
        /// (Forbidden): USER_CREDENTIALS_CHANGED, INSUFFICIENT_PERMISSIONS</li> </ul> 
        /// <para>
        /// The specific HTTP status code is determined at runtime based on the error enum value.
        /// Consumers should use the error field to determine the specific access denial reason.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.InternalServerException">
        /// Error thrown when an internal server error occurs
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 500 Internal Server Error
        /// </para>
        ///  
        /// <para>
        /// Used for unexpected server-side errors that prevent request processing.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ResourceNotFoundException">
        /// Error thrown when requested resource is not found
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 404 Not Found
        /// </para>
        ///  
        /// <para>
        /// Used when the specified resource does not exist
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.TooManyRequestsErrorException">
        /// Error thrown when rate limit is exceeded
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 429 Too Many Requests
        /// </para>
        ///  
        /// <para>
        /// Possible OAuth2ErrorCode values:
        /// </para>
        ///  <ul> <li>INVALID_REQUEST: Rate limiting, too many requests, abuse prevention</li>
        /// </ul> 
        /// <para>
        /// Possible causes:
        /// </para>
        ///  <ul> <li>Too many token requests from the same client</li> <li>Rate limiting based
        /// on client_id or IP address</li> <li>Abuse prevention mechanisms triggered</li> <li>Service
        /// protection against excessive token generation</li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ValidationException">
        /// Error thrown when request validation fails
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 400 Bad Request
        /// </para>
        ///  
        /// <para>
        /// Used for request validation errors such as malformed parameters, missing required
        /// fields, or invalid parameter values.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signin-2023-01-01/DeleteResourcePermissionStatement">REST API Reference for DeleteResourcePermissionStatement Operation</seealso>
        public virtual DeleteResourcePermissionStatementResponse DeleteResourcePermissionStatement(DeleteResourcePermissionStatementRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteResourcePermissionStatementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourcePermissionStatementResponseUnmarshaller.Instance;

            return Invoke<DeleteResourcePermissionStatementResponse>(request, options);
        }


        /// <summary>
        /// Remove a permission statement from the account's SignIn resource-based policy
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePermissionStatement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteResourcePermissionStatement service method, as returned by Signin.</returns>
        /// <exception cref="Amazon.Signin.Model.AccessDeniedException">
        /// Error thrown for access denied scenarios with flexible HTTP status mapping
        /// 
        ///  
        /// <para>
        /// Runtime HTTP Status Code Mapping:
        /// </para>
        ///  <ul> <li>HTTP 401 (Unauthorized): TOKEN_EXPIRED, AUTHCODE_EXPIRED</li> <li>HTTP 403
        /// (Forbidden): USER_CREDENTIALS_CHANGED, INSUFFICIENT_PERMISSIONS</li> </ul> 
        /// <para>
        /// The specific HTTP status code is determined at runtime based on the error enum value.
        /// Consumers should use the error field to determine the specific access denial reason.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.InternalServerException">
        /// Error thrown when an internal server error occurs
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 500 Internal Server Error
        /// </para>
        ///  
        /// <para>
        /// Used for unexpected server-side errors that prevent request processing.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ResourceNotFoundException">
        /// Error thrown when requested resource is not found
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 404 Not Found
        /// </para>
        ///  
        /// <para>
        /// Used when the specified resource does not exist
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.TooManyRequestsErrorException">
        /// Error thrown when rate limit is exceeded
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 429 Too Many Requests
        /// </para>
        ///  
        /// <para>
        /// Possible OAuth2ErrorCode values:
        /// </para>
        ///  <ul> <li>INVALID_REQUEST: Rate limiting, too many requests, abuse prevention</li>
        /// </ul> 
        /// <para>
        /// Possible causes:
        /// </para>
        ///  <ul> <li>Too many token requests from the same client</li> <li>Rate limiting based
        /// on client_id or IP address</li> <li>Abuse prevention mechanisms triggered</li> <li>Service
        /// protection against excessive token generation</li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ValidationException">
        /// Error thrown when request validation fails
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 400 Bad Request
        /// </para>
        ///  
        /// <para>
        /// Used for request validation errors such as malformed parameters, missing required
        /// fields, or invalid parameter values.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signin-2023-01-01/DeleteResourcePermissionStatement">REST API Reference for DeleteResourcePermissionStatement Operation</seealso>
        public virtual Task<DeleteResourcePermissionStatementResponse> DeleteResourcePermissionStatementAsync(DeleteResourcePermissionStatementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteResourcePermissionStatementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourcePermissionStatementResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteResourcePermissionStatementResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetConsoleAuthorizationConfiguration


        /// <summary>
        /// Get console authorization configuration with automatic scope detection
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConsoleAuthorizationConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetConsoleAuthorizationConfiguration service method, as returned by Signin.</returns>
        /// <exception cref="Amazon.Signin.Model.AccessDeniedException">
        /// Error thrown for access denied scenarios with flexible HTTP status mapping
        /// 
        ///  
        /// <para>
        /// Runtime HTTP Status Code Mapping:
        /// </para>
        ///  <ul> <li>HTTP 401 (Unauthorized): TOKEN_EXPIRED, AUTHCODE_EXPIRED</li> <li>HTTP 403
        /// (Forbidden): USER_CREDENTIALS_CHANGED, INSUFFICIENT_PERMISSIONS</li> </ul> 
        /// <para>
        /// The specific HTTP status code is determined at runtime based on the error enum value.
        /// Consumers should use the error field to determine the specific access denial reason.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.InternalServerException">
        /// Error thrown when an internal server error occurs
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 500 Internal Server Error
        /// </para>
        ///  
        /// <para>
        /// Used for unexpected server-side errors that prevent request processing.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ResourceNotFoundException">
        /// Error thrown when requested resource is not found
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 404 Not Found
        /// </para>
        ///  
        /// <para>
        /// Used when the specified resource does not exist
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.TooManyRequestsErrorException">
        /// Error thrown when rate limit is exceeded
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 429 Too Many Requests
        /// </para>
        ///  
        /// <para>
        /// Possible OAuth2ErrorCode values:
        /// </para>
        ///  <ul> <li>INVALID_REQUEST: Rate limiting, too many requests, abuse prevention</li>
        /// </ul> 
        /// <para>
        /// Possible causes:
        /// </para>
        ///  <ul> <li>Too many token requests from the same client</li> <li>Rate limiting based
        /// on client_id or IP address</li> <li>Abuse prevention mechanisms triggered</li> <li>Service
        /// protection against excessive token generation</li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ValidationException">
        /// Error thrown when request validation fails
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 400 Bad Request
        /// </para>
        ///  
        /// <para>
        /// Used for request validation errors such as malformed parameters, missing required
        /// fields, or invalid parameter values.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signin-2023-01-01/GetConsoleAuthorizationConfiguration">REST API Reference for GetConsoleAuthorizationConfiguration Operation</seealso>
        public virtual GetConsoleAuthorizationConfigurationResponse GetConsoleAuthorizationConfiguration(GetConsoleAuthorizationConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConsoleAuthorizationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConsoleAuthorizationConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetConsoleAuthorizationConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Get console authorization configuration with automatic scope detection
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConsoleAuthorizationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetConsoleAuthorizationConfiguration service method, as returned by Signin.</returns>
        /// <exception cref="Amazon.Signin.Model.AccessDeniedException">
        /// Error thrown for access denied scenarios with flexible HTTP status mapping
        /// 
        ///  
        /// <para>
        /// Runtime HTTP Status Code Mapping:
        /// </para>
        ///  <ul> <li>HTTP 401 (Unauthorized): TOKEN_EXPIRED, AUTHCODE_EXPIRED</li> <li>HTTP 403
        /// (Forbidden): USER_CREDENTIALS_CHANGED, INSUFFICIENT_PERMISSIONS</li> </ul> 
        /// <para>
        /// The specific HTTP status code is determined at runtime based on the error enum value.
        /// Consumers should use the error field to determine the specific access denial reason.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.InternalServerException">
        /// Error thrown when an internal server error occurs
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 500 Internal Server Error
        /// </para>
        ///  
        /// <para>
        /// Used for unexpected server-side errors that prevent request processing.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ResourceNotFoundException">
        /// Error thrown when requested resource is not found
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 404 Not Found
        /// </para>
        ///  
        /// <para>
        /// Used when the specified resource does not exist
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.TooManyRequestsErrorException">
        /// Error thrown when rate limit is exceeded
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 429 Too Many Requests
        /// </para>
        ///  
        /// <para>
        /// Possible OAuth2ErrorCode values:
        /// </para>
        ///  <ul> <li>INVALID_REQUEST: Rate limiting, too many requests, abuse prevention</li>
        /// </ul> 
        /// <para>
        /// Possible causes:
        /// </para>
        ///  <ul> <li>Too many token requests from the same client</li> <li>Rate limiting based
        /// on client_id or IP address</li> <li>Abuse prevention mechanisms triggered</li> <li>Service
        /// protection against excessive token generation</li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ValidationException">
        /// Error thrown when request validation fails
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 400 Bad Request
        /// </para>
        ///  
        /// <para>
        /// Used for request validation errors such as malformed parameters, missing required
        /// fields, or invalid parameter values.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signin-2023-01-01/GetConsoleAuthorizationConfiguration">REST API Reference for GetConsoleAuthorizationConfiguration Operation</seealso>
        public virtual Task<GetConsoleAuthorizationConfigurationResponse> GetConsoleAuthorizationConfigurationAsync(GetConsoleAuthorizationConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConsoleAuthorizationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConsoleAuthorizationConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetConsoleAuthorizationConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetResourcePolicy


        /// <summary>
        /// Retrieve the account's consolidated SignIn resource-based policy
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the GetResourcePolicy service method, as returned by Signin.</returns>
        /// <exception cref="Amazon.Signin.Model.AccessDeniedException">
        /// Error thrown for access denied scenarios with flexible HTTP status mapping
        /// 
        ///  
        /// <para>
        /// Runtime HTTP Status Code Mapping:
        /// </para>
        ///  <ul> <li>HTTP 401 (Unauthorized): TOKEN_EXPIRED, AUTHCODE_EXPIRED</li> <li>HTTP 403
        /// (Forbidden): USER_CREDENTIALS_CHANGED, INSUFFICIENT_PERMISSIONS</li> </ul> 
        /// <para>
        /// The specific HTTP status code is determined at runtime based on the error enum value.
        /// Consumers should use the error field to determine the specific access denial reason.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.InternalServerException">
        /// Error thrown when an internal server error occurs
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 500 Internal Server Error
        /// </para>
        ///  
        /// <para>
        /// Used for unexpected server-side errors that prevent request processing.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ResourceNotFoundException">
        /// Error thrown when requested resource is not found
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 404 Not Found
        /// </para>
        ///  
        /// <para>
        /// Used when the specified resource does not exist
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.TooManyRequestsErrorException">
        /// Error thrown when rate limit is exceeded
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 429 Too Many Requests
        /// </para>
        ///  
        /// <para>
        /// Possible OAuth2ErrorCode values:
        /// </para>
        ///  <ul> <li>INVALID_REQUEST: Rate limiting, too many requests, abuse prevention</li>
        /// </ul> 
        /// <para>
        /// Possible causes:
        /// </para>
        ///  <ul> <li>Too many token requests from the same client</li> <li>Rate limiting based
        /// on client_id or IP address</li> <li>Abuse prevention mechanisms triggered</li> <li>Service
        /// protection against excessive token generation</li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signin-2023-01-01/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        public virtual GetResourcePolicyResponse GetResourcePolicy(GetResourcePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<GetResourcePolicyResponse>(request, options);
        }


        /// <summary>
        /// Retrieve the account's consolidated SignIn resource-based policy
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetResourcePolicy service method, as returned by Signin.</returns>
        /// <exception cref="Amazon.Signin.Model.AccessDeniedException">
        /// Error thrown for access denied scenarios with flexible HTTP status mapping
        /// 
        ///  
        /// <para>
        /// Runtime HTTP Status Code Mapping:
        /// </para>
        ///  <ul> <li>HTTP 401 (Unauthorized): TOKEN_EXPIRED, AUTHCODE_EXPIRED</li> <li>HTTP 403
        /// (Forbidden): USER_CREDENTIALS_CHANGED, INSUFFICIENT_PERMISSIONS</li> </ul> 
        /// <para>
        /// The specific HTTP status code is determined at runtime based on the error enum value.
        /// Consumers should use the error field to determine the specific access denial reason.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.InternalServerException">
        /// Error thrown when an internal server error occurs
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 500 Internal Server Error
        /// </para>
        ///  
        /// <para>
        /// Used for unexpected server-side errors that prevent request processing.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ResourceNotFoundException">
        /// Error thrown when requested resource is not found
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 404 Not Found
        /// </para>
        ///  
        /// <para>
        /// Used when the specified resource does not exist
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.TooManyRequestsErrorException">
        /// Error thrown when rate limit is exceeded
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 429 Too Many Requests
        /// </para>
        ///  
        /// <para>
        /// Possible OAuth2ErrorCode values:
        /// </para>
        ///  <ul> <li>INVALID_REQUEST: Rate limiting, too many requests, abuse prevention</li>
        /// </ul> 
        /// <para>
        /// Possible causes:
        /// </para>
        ///  <ul> <li>Too many token requests from the same client</li> <li>Rate limiting based
        /// on client_id or IP address</li> <li>Abuse prevention mechanisms triggered</li> <li>Service
        /// protection against excessive token generation</li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signin-2023-01-01/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        public virtual Task<GetResourcePolicyResponse> GetResourcePolicyAsync(GetResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcePolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetResourcePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  IntrospectOAuth2TokenWithIAM


        /// <summary>
        /// Grants permission to inspect the metadata and state of an OAuth 2.0 access token or
        /// refresh token
        /// 
        ///  
        /// <para>
        /// Implements RFC 7662 OAuth 2.0 Token Introspection over a SigV4-authenticated endpoint.
        /// Inspects the metadata of an access_token or refresh_token issued by AWS Sign-In and
        /// returns the claims associated with it.
        /// </para>
        ///  
        /// <para>
        /// Inactive token semantics (RFC 7662 §2.2): when the supplied token is unknown, expired,
        /// revoked, malformed, or owned by a different account, the response body is exactly
        /// { &quot;active&quot;: false } with all other claims omitted.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the IntrospectOAuth2TokenWithIAM service method.</param>
        /// 
        /// <returns>The response from the IntrospectOAuth2TokenWithIAM service method, as returned by Signin.</returns>
        /// <exception cref="Amazon.Signin.Model.AccessDeniedException">
        /// Error thrown for access denied scenarios with flexible HTTP status mapping
        /// 
        ///  
        /// <para>
        /// Runtime HTTP Status Code Mapping:
        /// </para>
        ///  <ul> <li>HTTP 401 (Unauthorized): TOKEN_EXPIRED, AUTHCODE_EXPIRED</li> <li>HTTP 403
        /// (Forbidden): USER_CREDENTIALS_CHANGED, INSUFFICIENT_PERMISSIONS</li> </ul> 
        /// <para>
        /// The specific HTTP status code is determined at runtime based on the error enum value.
        /// Consumers should use the error field to determine the specific access denial reason.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.InternalServerException">
        /// Error thrown when an internal server error occurs
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 500 Internal Server Error
        /// </para>
        ///  
        /// <para>
        /// Used for unexpected server-side errors that prevent request processing.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.TooManyRequestsErrorException">
        /// Error thrown when rate limit is exceeded
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 429 Too Many Requests
        /// </para>
        ///  
        /// <para>
        /// Possible OAuth2ErrorCode values:
        /// </para>
        ///  <ul> <li>INVALID_REQUEST: Rate limiting, too many requests, abuse prevention</li>
        /// </ul> 
        /// <para>
        /// Possible causes:
        /// </para>
        ///  <ul> <li>Too many token requests from the same client</li> <li>Rate limiting based
        /// on client_id or IP address</li> <li>Abuse prevention mechanisms triggered</li> <li>Service
        /// protection against excessive token generation</li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ValidationException">
        /// Error thrown when request validation fails
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 400 Bad Request
        /// </para>
        ///  
        /// <para>
        /// Used for request validation errors such as malformed parameters, missing required
        /// fields, or invalid parameter values.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signin-2023-01-01/IntrospectOAuth2TokenWithIAM">REST API Reference for IntrospectOAuth2TokenWithIAM Operation</seealso>
        public virtual IntrospectOAuth2TokenWithIAMResponse IntrospectOAuth2TokenWithIAM(IntrospectOAuth2TokenWithIAMRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = IntrospectOAuth2TokenWithIAMRequestMarshaller.Instance;
            options.ResponseUnmarshaller = IntrospectOAuth2TokenWithIAMResponseUnmarshaller.Instance;

            return Invoke<IntrospectOAuth2TokenWithIAMResponse>(request, options);
        }


        /// <summary>
        /// Grants permission to inspect the metadata and state of an OAuth 2.0 access token or
        /// refresh token
        /// 
        ///  
        /// <para>
        /// Implements RFC 7662 OAuth 2.0 Token Introspection over a SigV4-authenticated endpoint.
        /// Inspects the metadata of an access_token or refresh_token issued by AWS Sign-In and
        /// returns the claims associated with it.
        /// </para>
        ///  
        /// <para>
        /// Inactive token semantics (RFC 7662 §2.2): when the supplied token is unknown, expired,
        /// revoked, malformed, or owned by a different account, the response body is exactly
        /// { &quot;active&quot;: false } with all other claims omitted.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the IntrospectOAuth2TokenWithIAM service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the IntrospectOAuth2TokenWithIAM service method, as returned by Signin.</returns>
        /// <exception cref="Amazon.Signin.Model.AccessDeniedException">
        /// Error thrown for access denied scenarios with flexible HTTP status mapping
        /// 
        ///  
        /// <para>
        /// Runtime HTTP Status Code Mapping:
        /// </para>
        ///  <ul> <li>HTTP 401 (Unauthorized): TOKEN_EXPIRED, AUTHCODE_EXPIRED</li> <li>HTTP 403
        /// (Forbidden): USER_CREDENTIALS_CHANGED, INSUFFICIENT_PERMISSIONS</li> </ul> 
        /// <para>
        /// The specific HTTP status code is determined at runtime based on the error enum value.
        /// Consumers should use the error field to determine the specific access denial reason.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.InternalServerException">
        /// Error thrown when an internal server error occurs
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 500 Internal Server Error
        /// </para>
        ///  
        /// <para>
        /// Used for unexpected server-side errors that prevent request processing.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.TooManyRequestsErrorException">
        /// Error thrown when rate limit is exceeded
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 429 Too Many Requests
        /// </para>
        ///  
        /// <para>
        /// Possible OAuth2ErrorCode values:
        /// </para>
        ///  <ul> <li>INVALID_REQUEST: Rate limiting, too many requests, abuse prevention</li>
        /// </ul> 
        /// <para>
        /// Possible causes:
        /// </para>
        ///  <ul> <li>Too many token requests from the same client</li> <li>Rate limiting based
        /// on client_id or IP address</li> <li>Abuse prevention mechanisms triggered</li> <li>Service
        /// protection against excessive token generation</li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ValidationException">
        /// Error thrown when request validation fails
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 400 Bad Request
        /// </para>
        ///  
        /// <para>
        /// Used for request validation errors such as malformed parameters, missing required
        /// fields, or invalid parameter values.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signin-2023-01-01/IntrospectOAuth2TokenWithIAM">REST API Reference for IntrospectOAuth2TokenWithIAM Operation</seealso>
        public virtual Task<IntrospectOAuth2TokenWithIAMResponse> IntrospectOAuth2TokenWithIAMAsync(IntrospectOAuth2TokenWithIAMRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = IntrospectOAuth2TokenWithIAMRequestMarshaller.Instance;
            options.ResponseUnmarshaller = IntrospectOAuth2TokenWithIAMResponseUnmarshaller.Instance;
            
            return InvokeAsync<IntrospectOAuth2TokenWithIAMResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListResourcePermissionStatements


        /// <summary>
        /// Retrieve all permission statements in the account's SignIn resource-based policy
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourcePermissionStatements service method.</param>
        /// 
        /// <returns>The response from the ListResourcePermissionStatements service method, as returned by Signin.</returns>
        /// <exception cref="Amazon.Signin.Model.AccessDeniedException">
        /// Error thrown for access denied scenarios with flexible HTTP status mapping
        /// 
        ///  
        /// <para>
        /// Runtime HTTP Status Code Mapping:
        /// </para>
        ///  <ul> <li>HTTP 401 (Unauthorized): TOKEN_EXPIRED, AUTHCODE_EXPIRED</li> <li>HTTP 403
        /// (Forbidden): USER_CREDENTIALS_CHANGED, INSUFFICIENT_PERMISSIONS</li> </ul> 
        /// <para>
        /// The specific HTTP status code is determined at runtime based on the error enum value.
        /// Consumers should use the error field to determine the specific access denial reason.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.InternalServerException">
        /// Error thrown when an internal server error occurs
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 500 Internal Server Error
        /// </para>
        ///  
        /// <para>
        /// Used for unexpected server-side errors that prevent request processing.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ResourceNotFoundException">
        /// Error thrown when requested resource is not found
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 404 Not Found
        /// </para>
        ///  
        /// <para>
        /// Used when the specified resource does not exist
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.TooManyRequestsErrorException">
        /// Error thrown when rate limit is exceeded
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 429 Too Many Requests
        /// </para>
        ///  
        /// <para>
        /// Possible OAuth2ErrorCode values:
        /// </para>
        ///  <ul> <li>INVALID_REQUEST: Rate limiting, too many requests, abuse prevention</li>
        /// </ul> 
        /// <para>
        /// Possible causes:
        /// </para>
        ///  <ul> <li>Too many token requests from the same client</li> <li>Rate limiting based
        /// on client_id or IP address</li> <li>Abuse prevention mechanisms triggered</li> <li>Service
        /// protection against excessive token generation</li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ValidationException">
        /// Error thrown when request validation fails
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 400 Bad Request
        /// </para>
        ///  
        /// <para>
        /// Used for request validation errors such as malformed parameters, missing required
        /// fields, or invalid parameter values.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signin-2023-01-01/ListResourcePermissionStatements">REST API Reference for ListResourcePermissionStatements Operation</seealso>
        public virtual ListResourcePermissionStatementsResponse ListResourcePermissionStatements(ListResourcePermissionStatementsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListResourcePermissionStatementsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourcePermissionStatementsResponseUnmarshaller.Instance;

            return Invoke<ListResourcePermissionStatementsResponse>(request, options);
        }


        /// <summary>
        /// Retrieve all permission statements in the account's SignIn resource-based policy
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourcePermissionStatements service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListResourcePermissionStatements service method, as returned by Signin.</returns>
        /// <exception cref="Amazon.Signin.Model.AccessDeniedException">
        /// Error thrown for access denied scenarios with flexible HTTP status mapping
        /// 
        ///  
        /// <para>
        /// Runtime HTTP Status Code Mapping:
        /// </para>
        ///  <ul> <li>HTTP 401 (Unauthorized): TOKEN_EXPIRED, AUTHCODE_EXPIRED</li> <li>HTTP 403
        /// (Forbidden): USER_CREDENTIALS_CHANGED, INSUFFICIENT_PERMISSIONS</li> </ul> 
        /// <para>
        /// The specific HTTP status code is determined at runtime based on the error enum value.
        /// Consumers should use the error field to determine the specific access denial reason.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.InternalServerException">
        /// Error thrown when an internal server error occurs
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 500 Internal Server Error
        /// </para>
        ///  
        /// <para>
        /// Used for unexpected server-side errors that prevent request processing.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ResourceNotFoundException">
        /// Error thrown when requested resource is not found
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 404 Not Found
        /// </para>
        ///  
        /// <para>
        /// Used when the specified resource does not exist
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.TooManyRequestsErrorException">
        /// Error thrown when rate limit is exceeded
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 429 Too Many Requests
        /// </para>
        ///  
        /// <para>
        /// Possible OAuth2ErrorCode values:
        /// </para>
        ///  <ul> <li>INVALID_REQUEST: Rate limiting, too many requests, abuse prevention</li>
        /// </ul> 
        /// <para>
        /// Possible causes:
        /// </para>
        ///  <ul> <li>Too many token requests from the same client</li> <li>Rate limiting based
        /// on client_id or IP address</li> <li>Abuse prevention mechanisms triggered</li> <li>Service
        /// protection against excessive token generation</li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ValidationException">
        /// Error thrown when request validation fails
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 400 Bad Request
        /// </para>
        ///  
        /// <para>
        /// Used for request validation errors such as malformed parameters, missing required
        /// fields, or invalid parameter values.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signin-2023-01-01/ListResourcePermissionStatements">REST API Reference for ListResourcePermissionStatements Operation</seealso>
        public virtual Task<ListResourcePermissionStatementsResponse> ListResourcePermissionStatementsAsync(ListResourcePermissionStatementsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListResourcePermissionStatementsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourcePermissionStatementsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListResourcePermissionStatementsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutConsoleAuthorizationConfiguration


        /// <summary>
        /// Enable console authorization configuration with automatic scope detection
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutConsoleAuthorizationConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutConsoleAuthorizationConfiguration service method, as returned by Signin.</returns>
        /// <exception cref="Amazon.Signin.Model.AccessDeniedException">
        /// Error thrown for access denied scenarios with flexible HTTP status mapping
        /// 
        ///  
        /// <para>
        /// Runtime HTTP Status Code Mapping:
        /// </para>
        ///  <ul> <li>HTTP 401 (Unauthorized): TOKEN_EXPIRED, AUTHCODE_EXPIRED</li> <li>HTTP 403
        /// (Forbidden): USER_CREDENTIALS_CHANGED, INSUFFICIENT_PERMISSIONS</li> </ul> 
        /// <para>
        /// The specific HTTP status code is determined at runtime based on the error enum value.
        /// Consumers should use the error field to determine the specific access denial reason.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ConflictException">
        /// Error thrown when request conflicts with current state
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 409 Conflict
        /// </para>
        ///  
        /// <para>
        /// Used when the request conflicts with the current state of the resource
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.InternalServerException">
        /// Error thrown when an internal server error occurs
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 500 Internal Server Error
        /// </para>
        ///  
        /// <para>
        /// Used for unexpected server-side errors that prevent request processing.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ResourceNotFoundException">
        /// Error thrown when requested resource is not found
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 404 Not Found
        /// </para>
        ///  
        /// <para>
        /// Used when the specified resource does not exist
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.TooManyRequestsErrorException">
        /// Error thrown when rate limit is exceeded
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 429 Too Many Requests
        /// </para>
        ///  
        /// <para>
        /// Possible OAuth2ErrorCode values:
        /// </para>
        ///  <ul> <li>INVALID_REQUEST: Rate limiting, too many requests, abuse prevention</li>
        /// </ul> 
        /// <para>
        /// Possible causes:
        /// </para>
        ///  <ul> <li>Too many token requests from the same client</li> <li>Rate limiting based
        /// on client_id or IP address</li> <li>Abuse prevention mechanisms triggered</li> <li>Service
        /// protection against excessive token generation</li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ValidationException">
        /// Error thrown when request validation fails
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 400 Bad Request
        /// </para>
        ///  
        /// <para>
        /// Used for request validation errors such as malformed parameters, missing required
        /// fields, or invalid parameter values.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signin-2023-01-01/PutConsoleAuthorizationConfiguration">REST API Reference for PutConsoleAuthorizationConfiguration Operation</seealso>
        public virtual PutConsoleAuthorizationConfigurationResponse PutConsoleAuthorizationConfiguration(PutConsoleAuthorizationConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutConsoleAuthorizationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutConsoleAuthorizationConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutConsoleAuthorizationConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Enable console authorization configuration with automatic scope detection
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutConsoleAuthorizationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutConsoleAuthorizationConfiguration service method, as returned by Signin.</returns>
        /// <exception cref="Amazon.Signin.Model.AccessDeniedException">
        /// Error thrown for access denied scenarios with flexible HTTP status mapping
        /// 
        ///  
        /// <para>
        /// Runtime HTTP Status Code Mapping:
        /// </para>
        ///  <ul> <li>HTTP 401 (Unauthorized): TOKEN_EXPIRED, AUTHCODE_EXPIRED</li> <li>HTTP 403
        /// (Forbidden): USER_CREDENTIALS_CHANGED, INSUFFICIENT_PERMISSIONS</li> </ul> 
        /// <para>
        /// The specific HTTP status code is determined at runtime based on the error enum value.
        /// Consumers should use the error field to determine the specific access denial reason.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ConflictException">
        /// Error thrown when request conflicts with current state
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 409 Conflict
        /// </para>
        ///  
        /// <para>
        /// Used when the request conflicts with the current state of the resource
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.InternalServerException">
        /// Error thrown when an internal server error occurs
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 500 Internal Server Error
        /// </para>
        ///  
        /// <para>
        /// Used for unexpected server-side errors that prevent request processing.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ResourceNotFoundException">
        /// Error thrown when requested resource is not found
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 404 Not Found
        /// </para>
        ///  
        /// <para>
        /// Used when the specified resource does not exist
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.TooManyRequestsErrorException">
        /// Error thrown when rate limit is exceeded
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 429 Too Many Requests
        /// </para>
        ///  
        /// <para>
        /// Possible OAuth2ErrorCode values:
        /// </para>
        ///  <ul> <li>INVALID_REQUEST: Rate limiting, too many requests, abuse prevention</li>
        /// </ul> 
        /// <para>
        /// Possible causes:
        /// </para>
        ///  <ul> <li>Too many token requests from the same client</li> <li>Rate limiting based
        /// on client_id or IP address</li> <li>Abuse prevention mechanisms triggered</li> <li>Service
        /// protection against excessive token generation</li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ValidationException">
        /// Error thrown when request validation fails
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 400 Bad Request
        /// </para>
        ///  
        /// <para>
        /// Used for request validation errors such as malformed parameters, missing required
        /// fields, or invalid parameter values.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signin-2023-01-01/PutConsoleAuthorizationConfiguration">REST API Reference for PutConsoleAuthorizationConfiguration Operation</seealso>
        public virtual Task<PutConsoleAuthorizationConfigurationResponse> PutConsoleAuthorizationConfigurationAsync(PutConsoleAuthorizationConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutConsoleAuthorizationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutConsoleAuthorizationConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutConsoleAuthorizationConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutResourcePermissionStatement


        /// <summary>
        /// Create a permission statement in the account's SignIn resource-based policy
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePermissionStatement service method.</param>
        /// 
        /// <returns>The response from the PutResourcePermissionStatement service method, as returned by Signin.</returns>
        /// <exception cref="Amazon.Signin.Model.AccessDeniedException">
        /// Error thrown for access denied scenarios with flexible HTTP status mapping
        /// 
        ///  
        /// <para>
        /// Runtime HTTP Status Code Mapping:
        /// </para>
        ///  <ul> <li>HTTP 401 (Unauthorized): TOKEN_EXPIRED, AUTHCODE_EXPIRED</li> <li>HTTP 403
        /// (Forbidden): USER_CREDENTIALS_CHANGED, INSUFFICIENT_PERMISSIONS</li> </ul> 
        /// <para>
        /// The specific HTTP status code is determined at runtime based on the error enum value.
        /// Consumers should use the error field to determine the specific access denial reason.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ConflictException">
        /// Error thrown when request conflicts with current state
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 409 Conflict
        /// </para>
        ///  
        /// <para>
        /// Used when the request conflicts with the current state of the resource
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.InternalServerException">
        /// Error thrown when an internal server error occurs
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 500 Internal Server Error
        /// </para>
        ///  
        /// <para>
        /// Used for unexpected server-side errors that prevent request processing.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ServiceQuotaExceededException">
        /// Error thrown when service quota is exceeded
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 402 Payment Required (used as quota exceeded indicator)
        /// </para>
        ///  
        /// <para>
        /// Used when the request would cause a service quota to be exceeded
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.TooManyRequestsErrorException">
        /// Error thrown when rate limit is exceeded
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 429 Too Many Requests
        /// </para>
        ///  
        /// <para>
        /// Possible OAuth2ErrorCode values:
        /// </para>
        ///  <ul> <li>INVALID_REQUEST: Rate limiting, too many requests, abuse prevention</li>
        /// </ul> 
        /// <para>
        /// Possible causes:
        /// </para>
        ///  <ul> <li>Too many token requests from the same client</li> <li>Rate limiting based
        /// on client_id or IP address</li> <li>Abuse prevention mechanisms triggered</li> <li>Service
        /// protection against excessive token generation</li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ValidationException">
        /// Error thrown when request validation fails
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 400 Bad Request
        /// </para>
        ///  
        /// <para>
        /// Used for request validation errors such as malformed parameters, missing required
        /// fields, or invalid parameter values.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signin-2023-01-01/PutResourcePermissionStatement">REST API Reference for PutResourcePermissionStatement Operation</seealso>
        public virtual PutResourcePermissionStatementResponse PutResourcePermissionStatement(PutResourcePermissionStatementRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutResourcePermissionStatementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourcePermissionStatementResponseUnmarshaller.Instance;

            return Invoke<PutResourcePermissionStatementResponse>(request, options);
        }


        /// <summary>
        /// Create a permission statement in the account's SignIn resource-based policy
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePermissionStatement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutResourcePermissionStatement service method, as returned by Signin.</returns>
        /// <exception cref="Amazon.Signin.Model.AccessDeniedException">
        /// Error thrown for access denied scenarios with flexible HTTP status mapping
        /// 
        ///  
        /// <para>
        /// Runtime HTTP Status Code Mapping:
        /// </para>
        ///  <ul> <li>HTTP 401 (Unauthorized): TOKEN_EXPIRED, AUTHCODE_EXPIRED</li> <li>HTTP 403
        /// (Forbidden): USER_CREDENTIALS_CHANGED, INSUFFICIENT_PERMISSIONS</li> </ul> 
        /// <para>
        /// The specific HTTP status code is determined at runtime based on the error enum value.
        /// Consumers should use the error field to determine the specific access denial reason.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ConflictException">
        /// Error thrown when request conflicts with current state
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 409 Conflict
        /// </para>
        ///  
        /// <para>
        /// Used when the request conflicts with the current state of the resource
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.InternalServerException">
        /// Error thrown when an internal server error occurs
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 500 Internal Server Error
        /// </para>
        ///  
        /// <para>
        /// Used for unexpected server-side errors that prevent request processing.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ServiceQuotaExceededException">
        /// Error thrown when service quota is exceeded
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 402 Payment Required (used as quota exceeded indicator)
        /// </para>
        ///  
        /// <para>
        /// Used when the request would cause a service quota to be exceeded
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.TooManyRequestsErrorException">
        /// Error thrown when rate limit is exceeded
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 429 Too Many Requests
        /// </para>
        ///  
        /// <para>
        /// Possible OAuth2ErrorCode values:
        /// </para>
        ///  <ul> <li>INVALID_REQUEST: Rate limiting, too many requests, abuse prevention</li>
        /// </ul> 
        /// <para>
        /// Possible causes:
        /// </para>
        ///  <ul> <li>Too many token requests from the same client</li> <li>Rate limiting based
        /// on client_id or IP address</li> <li>Abuse prevention mechanisms triggered</li> <li>Service
        /// protection against excessive token generation</li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ValidationException">
        /// Error thrown when request validation fails
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 400 Bad Request
        /// </para>
        ///  
        /// <para>
        /// Used for request validation errors such as malformed parameters, missing required
        /// fields, or invalid parameter values.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signin-2023-01-01/PutResourcePermissionStatement">REST API Reference for PutResourcePermissionStatement Operation</seealso>
        public virtual Task<PutResourcePermissionStatementResponse> PutResourcePermissionStatementAsync(PutResourcePermissionStatementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutResourcePermissionStatementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourcePermissionStatementResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutResourcePermissionStatementResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RevokeOAuth2TokenWithIAM


        /// <summary>
        /// Grants permission to revoke an OAuth 2.0 refresh token and its associated refresh
        /// tokens
        /// 
        ///  
        /// <para>
        /// Revokes a refresh_token issued by AWS Sign-In, invalidating the entire token chain
        /// so that the refresh_token can no longer be used to mint new access_tokens.
        /// </para>
        ///  
        /// <para>
        /// Idempotency: revoking an already-revoked, expired, or otherwise invalid token still
        /// returns 200 OK with an empty body. Only the refresh_token type is accepted.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeOAuth2TokenWithIAM service method.</param>
        /// 
        /// <returns>The response from the RevokeOAuth2TokenWithIAM service method, as returned by Signin.</returns>
        /// <exception cref="Amazon.Signin.Model.AccessDeniedException">
        /// Error thrown for access denied scenarios with flexible HTTP status mapping
        /// 
        ///  
        /// <para>
        /// Runtime HTTP Status Code Mapping:
        /// </para>
        ///  <ul> <li>HTTP 401 (Unauthorized): TOKEN_EXPIRED, AUTHCODE_EXPIRED</li> <li>HTTP 403
        /// (Forbidden): USER_CREDENTIALS_CHANGED, INSUFFICIENT_PERMISSIONS</li> </ul> 
        /// <para>
        /// The specific HTTP status code is determined at runtime based on the error enum value.
        /// Consumers should use the error field to determine the specific access denial reason.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.InternalServerException">
        /// Error thrown when an internal server error occurs
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 500 Internal Server Error
        /// </para>
        ///  
        /// <para>
        /// Used for unexpected server-side errors that prevent request processing.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.TooManyRequestsErrorException">
        /// Error thrown when rate limit is exceeded
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 429 Too Many Requests
        /// </para>
        ///  
        /// <para>
        /// Possible OAuth2ErrorCode values:
        /// </para>
        ///  <ul> <li>INVALID_REQUEST: Rate limiting, too many requests, abuse prevention</li>
        /// </ul> 
        /// <para>
        /// Possible causes:
        /// </para>
        ///  <ul> <li>Too many token requests from the same client</li> <li>Rate limiting based
        /// on client_id or IP address</li> <li>Abuse prevention mechanisms triggered</li> <li>Service
        /// protection against excessive token generation</li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ValidationException">
        /// Error thrown when request validation fails
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 400 Bad Request
        /// </para>
        ///  
        /// <para>
        /// Used for request validation errors such as malformed parameters, missing required
        /// fields, or invalid parameter values.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signin-2023-01-01/RevokeOAuth2TokenWithIAM">REST API Reference for RevokeOAuth2TokenWithIAM Operation</seealso>
        public virtual RevokeOAuth2TokenWithIAMResponse RevokeOAuth2TokenWithIAM(RevokeOAuth2TokenWithIAMRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RevokeOAuth2TokenWithIAMRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeOAuth2TokenWithIAMResponseUnmarshaller.Instance;

            return Invoke<RevokeOAuth2TokenWithIAMResponse>(request, options);
        }


        /// <summary>
        /// Grants permission to revoke an OAuth 2.0 refresh token and its associated refresh
        /// tokens
        /// 
        ///  
        /// <para>
        /// Revokes a refresh_token issued by AWS Sign-In, invalidating the entire token chain
        /// so that the refresh_token can no longer be used to mint new access_tokens.
        /// </para>
        ///  
        /// <para>
        /// Idempotency: revoking an already-revoked, expired, or otherwise invalid token still
        /// returns 200 OK with an empty body. Only the refresh_token type is accepted.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeOAuth2TokenWithIAM service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RevokeOAuth2TokenWithIAM service method, as returned by Signin.</returns>
        /// <exception cref="Amazon.Signin.Model.AccessDeniedException">
        /// Error thrown for access denied scenarios with flexible HTTP status mapping
        /// 
        ///  
        /// <para>
        /// Runtime HTTP Status Code Mapping:
        /// </para>
        ///  <ul> <li>HTTP 401 (Unauthorized): TOKEN_EXPIRED, AUTHCODE_EXPIRED</li> <li>HTTP 403
        /// (Forbidden): USER_CREDENTIALS_CHANGED, INSUFFICIENT_PERMISSIONS</li> </ul> 
        /// <para>
        /// The specific HTTP status code is determined at runtime based on the error enum value.
        /// Consumers should use the error field to determine the specific access denial reason.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.InternalServerException">
        /// Error thrown when an internal server error occurs
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 500 Internal Server Error
        /// </para>
        ///  
        /// <para>
        /// Used for unexpected server-side errors that prevent request processing.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.TooManyRequestsErrorException">
        /// Error thrown when rate limit is exceeded
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 429 Too Many Requests
        /// </para>
        ///  
        /// <para>
        /// Possible OAuth2ErrorCode values:
        /// </para>
        ///  <ul> <li>INVALID_REQUEST: Rate limiting, too many requests, abuse prevention</li>
        /// </ul> 
        /// <para>
        /// Possible causes:
        /// </para>
        ///  <ul> <li>Too many token requests from the same client</li> <li>Rate limiting based
        /// on client_id or IP address</li> <li>Abuse prevention mechanisms triggered</li> <li>Service
        /// protection against excessive token generation</li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ValidationException">
        /// Error thrown when request validation fails
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 400 Bad Request
        /// </para>
        ///  
        /// <para>
        /// Used for request validation errors such as malformed parameters, missing required
        /// fields, or invalid parameter values.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signin-2023-01-01/RevokeOAuth2TokenWithIAM">REST API Reference for RevokeOAuth2TokenWithIAM Operation</seealso>
        public virtual Task<RevokeOAuth2TokenWithIAMResponse> RevokeOAuth2TokenWithIAMAsync(RevokeOAuth2TokenWithIAMRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RevokeOAuth2TokenWithIAMRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeOAuth2TokenWithIAMResponseUnmarshaller.Instance;
            
            return InvokeAsync<RevokeOAuth2TokenWithIAMResponse>(request, options, cancellationToken);
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
            var parameters = new ServiceOperationEndpointParameters(request);
            return Config.DetermineServiceOperationEndpoint(parameters);
        }

        #endregion

    }
}