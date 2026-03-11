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
    ///
    /// AWS Sign-In manages authentication for AWS services. This service provides secure
    /// authentication flows for accessing AWS resources from the console and developer tools.
    /// </summary>
    public partial class AmazonSigninClient : AmazonServiceClient, IAmazonSignin
    {
        private static IServiceMetadata serviceMetadata = new AmazonSigninMetadata();
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