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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;
using Amazon.AccountAccessRuntime.Model;
using Amazon.AccountAccessRuntime.Model.Internal.MarshallTransformations;
using Amazon.AccountAccessRuntime.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570

namespace Amazon.AccountAccessRuntime
{
    /// <summary>
    /// <para>Implementation for accessing AccountAccessRuntime</para>
    /// <para>
    /// Service client instances are thread-safe and can be shared across multiple threads.
    /// For a given service configuration, it is recommended to reuse a client instance
    /// for the lifetime of your application.
    /// </para>
    ///
    /// Use the Account Access Runtime API to list the roles that you can access and retrieve
    /// temporary Amazon Web Services credentials for those roles. You authenticate with a
    /// bearer token from IAM Identity Center. Each request is scoped to a tenant.
    /// </summary>
    public partial class AmazonAccountAccessRuntimeClient : AmazonServiceClient, IAmazonAccountAccessRuntime
    {
        private static IServiceMetadata serviceMetadata = new AmazonAccountAccessRuntimeMetadata();
        private IAccountAccessRuntimePaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IAccountAccessRuntimePaginatorFactory Paginators
        {
            get
            {
                if (this._paginators == null)
                {
                    this._paginators = new AccountAccessRuntimePaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        /// <summary>
        /// Constructs AmazonAccountAccessRuntimeClient with the credentials loaded from the application's
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
        public AmazonAccountAccessRuntimeClient() : base(new AmazonAccountAccessRuntimeConfig()) { }

        /// <summary>
        /// Constructs AmazonAccountAccessRuntimeClient with the credentials loaded from the application's
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
        public AmazonAccountAccessRuntimeClient(RegionEndpoint region) : base(new AmazonAccountAccessRuntimeConfig { RegionEndpoint = region }) { }

        /// <summary>
        /// Constructs AmazonAccountAccessRuntimeClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonAccountAccessRuntimeClient Configuration Object</param>
        public AmazonAccountAccessRuntimeClient(AmazonAccountAccessRuntimeConfig config) : base(config) { }

        /// <summary>
        /// Constructs AmazonAccountAccessRuntimeClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonAccountAccessRuntimeClient(AWSCredentials credentials)
            : this(credentials, new AmazonAccountAccessRuntimeConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAccountAccessRuntimeClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAccountAccessRuntimeClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonAccountAccessRuntimeConfig { RegionEndpoint = region })
        {
        }

        /// <summary>
        /// Constructs AmazonAccountAccessRuntimeClient with AWS Credentials and an
        /// AmazonAccountAccessRuntimeClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonAccountAccessRuntimeClient Configuration Object</param>
        public AmazonAccountAccessRuntimeClient(AWSCredentials credentials, AmazonAccountAccessRuntimeConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAccountAccessRuntimeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonAccountAccessRuntimeClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAccountAccessRuntimeConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAccountAccessRuntimeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAccountAccessRuntimeClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAccountAccessRuntimeConfig { RegionEndpoint = region })
        {
        }

        /// <summary>
        /// Constructs AmazonAccountAccessRuntimeClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAccountAccessRuntimeClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonAccountAccessRuntimeClient Configuration Object</param>
        public AmazonAccountAccessRuntimeClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonAccountAccessRuntimeConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAccountAccessRuntimeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonAccountAccessRuntimeClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAccountAccessRuntimeConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAccountAccessRuntimeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAccountAccessRuntimeClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAccountAccessRuntimeConfig { RegionEndpoint = region })
        {
        }

        /// <summary>
        /// Constructs AmazonAccountAccessRuntimeClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAccountAccessRuntimeClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonAccountAccessRuntimeClient Configuration Object</param>
        public AmazonAccountAccessRuntimeClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonAccountAccessRuntimeConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonAccountAccessRuntimeEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonAccountAccessRuntimeAuthSchemeHandler());
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

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Returns temporary Amazon Web Services credentials for a role that you are entitled
        /// to assume within a tenant. You can use these credentials for programmatic access with
        /// the CLI or an Amazon Web Services SDK. If you aren't entitled to the role, the request
        /// fails with an <c>AccessDeniedException</c> error.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRoleCredentials service method.</param>
        /// <returns>The response from the GetRoleCredentials service method, as returned by AccountAccessRuntime.</returns>
        /// <exception cref="Amazon.AccountAccessRuntime.Model.AccessDeniedException">
        /// You are authenticated but not authorized to perform the requested action, such as
        /// assuming a role that you aren't entitled to. This error returns an HTTP 403 status
        /// code.
        /// </exception>
        /// <exception cref="Amazon.AccountAccessRuntime.Model.InternalServerException">
        /// An internal server error occurred. Retry the request. If the problem persists, contact
        /// Amazon Web Services Support. This error returns an HTTP 500 status code.
        /// </exception>
        /// <exception cref="Amazon.AccountAccessRuntime.Model.ThrottlingException">
        /// The request rate exceeded the allowed limit. Reduce your request rate, and then retry
        /// the request. This error returns an HTTP 429 status code.
        /// </exception>
        /// <exception cref="Amazon.AccountAccessRuntime.Model.UnauthorizedException">
        /// The bearer token is missing, invalid, or expired. Obtain a new token, and then retry
        /// the request. This error returns an HTTP 401 status code.
        /// </exception>
        /// <exception cref="Amazon.AccountAccessRuntime.Model.ValidationException">
        /// The request is missing a required parameter, or a parameter value doesn't satisfy
        /// its constraints, such as its length or pattern. Correct the input, and then retry
        /// the request. This error returns an HTTP 400 status code.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-access-runtime-2018-05-10/GetRoleCredentials">REST API Reference for GetRoleCredentials Operation</seealso>
        public virtual GetRoleCredentialsResponse GetRoleCredentials(GetRoleCredentialsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRoleCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRoleCredentialsResponseUnmarshaller.Instance;

            return Invoke<GetRoleCredentialsResponse>(request, options);
        }
#else
        internal virtual GetRoleCredentialsResponse GetRoleCredentials(GetRoleCredentialsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRoleCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRoleCredentialsResponseUnmarshaller.Instance;

            return Invoke<GetRoleCredentialsResponse>(request, options);
        }
#endif

        /// <summary>
        /// Returns temporary Amazon Web Services credentials for a role that you are entitled
        /// to assume within a tenant. You can use these credentials for programmatic access with
        /// the CLI or an Amazon Web Services SDK. If you aren't entitled to the role, the request
        /// fails with an <c>AccessDeniedException</c> error.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRoleCredentials service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetRoleCredentials service method, as returned by AccountAccessRuntime.</returns>
        /// <exception cref="Amazon.AccountAccessRuntime.Model.AccessDeniedException">
        /// You are authenticated but not authorized to perform the requested action, such as
        /// assuming a role that you aren't entitled to. This error returns an HTTP 403 status
        /// code.
        /// </exception>
        /// <exception cref="Amazon.AccountAccessRuntime.Model.InternalServerException">
        /// An internal server error occurred. Retry the request. If the problem persists, contact
        /// Amazon Web Services Support. This error returns an HTTP 500 status code.
        /// </exception>
        /// <exception cref="Amazon.AccountAccessRuntime.Model.ThrottlingException">
        /// The request rate exceeded the allowed limit. Reduce your request rate, and then retry
        /// the request. This error returns an HTTP 429 status code.
        /// </exception>
        /// <exception cref="Amazon.AccountAccessRuntime.Model.UnauthorizedException">
        /// The bearer token is missing, invalid, or expired. Obtain a new token, and then retry
        /// the request. This error returns an HTTP 401 status code.
        /// </exception>
        /// <exception cref="Amazon.AccountAccessRuntime.Model.ValidationException">
        /// The request is missing a required parameter, or a parameter value doesn't satisfy
        /// its constraints, such as its length or pattern. Correct the input, and then retry
        /// the request. This error returns an HTTP 400 status code.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-access-runtime-2018-05-10/GetRoleCredentials">REST API Reference for GetRoleCredentials Operation</seealso>
        public virtual Task<GetRoleCredentialsResponse> GetRoleCredentialsAsync(GetRoleCredentialsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRoleCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRoleCredentialsResponseUnmarshaller.Instance;

            return InvokeAsync<GetRoleCredentialsResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Returns the roles that you are entitled to access within a tenant. The results are
        /// paginated. Use a returned role with <c>GetRoleCredentials</c> to obtain temporary
        /// credentials.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRoles service method.</param>
        /// <returns>The response from the ListRoles service method, as returned by AccountAccessRuntime.</returns>
        /// <exception cref="Amazon.AccountAccessRuntime.Model.InternalServerException">
        /// An internal server error occurred. Retry the request. If the problem persists, contact
        /// Amazon Web Services Support. This error returns an HTTP 500 status code.
        /// </exception>
        /// <exception cref="Amazon.AccountAccessRuntime.Model.ThrottlingException">
        /// The request rate exceeded the allowed limit. Reduce your request rate, and then retry
        /// the request. This error returns an HTTP 429 status code.
        /// </exception>
        /// <exception cref="Amazon.AccountAccessRuntime.Model.UnauthorizedException">
        /// The bearer token is missing, invalid, or expired. Obtain a new token, and then retry
        /// the request. This error returns an HTTP 401 status code.
        /// </exception>
        /// <exception cref="Amazon.AccountAccessRuntime.Model.ValidationException">
        /// The request is missing a required parameter, or a parameter value doesn't satisfy
        /// its constraints, such as its length or pattern. Correct the input, and then retry
        /// the request. This error returns an HTTP 400 status code.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-access-runtime-2018-05-10/ListRoles">REST API Reference for ListRoles Operation</seealso>
        public virtual ListRolesResponse ListRoles(ListRolesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRolesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRolesResponseUnmarshaller.Instance;

            return Invoke<ListRolesResponse>(request, options);
        }
#else
        internal virtual ListRolesResponse ListRoles(ListRolesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRolesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRolesResponseUnmarshaller.Instance;

            return Invoke<ListRolesResponse>(request, options);
        }
#endif

        /// <summary>
        /// Returns the roles that you are entitled to access within a tenant. The results are
        /// paginated. Use a returned role with <c>GetRoleCredentials</c> to obtain temporary
        /// credentials.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRoles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListRoles service method, as returned by AccountAccessRuntime.</returns>
        /// <exception cref="Amazon.AccountAccessRuntime.Model.InternalServerException">
        /// An internal server error occurred. Retry the request. If the problem persists, contact
        /// Amazon Web Services Support. This error returns an HTTP 500 status code.
        /// </exception>
        /// <exception cref="Amazon.AccountAccessRuntime.Model.ThrottlingException">
        /// The request rate exceeded the allowed limit. Reduce your request rate, and then retry
        /// the request. This error returns an HTTP 429 status code.
        /// </exception>
        /// <exception cref="Amazon.AccountAccessRuntime.Model.UnauthorizedException">
        /// The bearer token is missing, invalid, or expired. Obtain a new token, and then retry
        /// the request. This error returns an HTTP 401 status code.
        /// </exception>
        /// <exception cref="Amazon.AccountAccessRuntime.Model.ValidationException">
        /// The request is missing a required parameter, or a parameter value doesn't satisfy
        /// its constraints, such as its length or pattern. Correct the input, and then retry
        /// the request. This error returns an HTTP 400 status code.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-access-runtime-2018-05-10/ListRoles">REST API Reference for ListRoles Operation</seealso>
        public virtual Task<ListRolesResponse> ListRolesAsync(ListRolesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRolesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRolesResponseUnmarshaller.Instance;

            return InvokeAsync<ListRolesResponse>(request, options, cancellationToken);
        }

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
    }
}
