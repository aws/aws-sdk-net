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
using Amazon.LambdaCore.Model;
using Amazon.LambdaCore.Model.Internal.MarshallTransformations;
using Amazon.LambdaCore.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570

namespace Amazon.LambdaCore
{
    /// <summary>
    /// <para>Implementation for accessing LambdaCore</para>
    /// <para>
    /// Service client instances are thread-safe and can be shared across multiple threads.
    /// For a given service configuration, it is recommended to reuse a client instance
    /// for the lifetime of your application.
    /// </para>
    ///
    /// Lambda 
    /// <para>
    ///  <b>Overview</b> 
    /// </para>
    ///  
    /// <para>
    /// Lambda Core is a set of APIs for managing shared infrastructure resources used by
    /// Lambda. The Lambda Core API provides operations for:
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// Creating and managing network connectors that enable Lambda MicroVMs and Lambda Web
    /// Functions to access resources in your Amazon Virtual Private Cloud (Amazon VPC).
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Creating customer-managed runtimes which can be used with Lambda Event Functions.
    /// </para>
    ///  </li> </ol> 
    /// <para>
    /// Network connectors provision elastic network interfaces (ENIs) in your VPC subnets,
    /// providing a managed network path from Lambda compute environments to private resources
    /// such as Amazon RDS databases, Amazon ElastiCache clusters, and internal APIs. You
    /// create a network connector once and attach it to one or more Lambda MicroVMs or Lambda
    /// Web Functions at run time.
    /// </para>
    ///  
    /// <para>
    /// A customer-managed runtime is a Lambda runtime that you create and manage as a standalone
    /// resource. Lambda Event Functions can use your customer-managed runtime instead of
    /// using one of the built-in Lambda-managed runtimes. Customer-managed runtimes enable
    /// you to create customized runtimes for your workloads, and give you control over runtime
    /// updates and the deprecation lifecycle.
    /// </para>
    ///  
    /// <para>
    /// The <i>Lambda Core API Reference</i> provides information about each of the API methods,
    /// including details about the parameters in each API request and response.
    /// </para>
    ///  
    /// <para>
    /// You can use Software Development Kits (SDKs), Integrated Development Environment (IDE)
    /// Toolkits, and command line tools to access the API. For installation instructions,
    /// see <a href="http://aws.amazon.com/tools/">Tools for Amazon Web Services</a>.
    /// </para>
    ///  
    /// <para>
    /// For a list of Region-specific endpoints that Lambda supports, see <a href="https://docs.aws.amazon.com/general/latest/gr/lambda-service.html">Lambda
    /// endpoints and quotas</a> in the <i>Amazon Web Services General Reference.</i> 
    /// </para>
    ///  
    /// <para>
    /// When making the API calls, you will need to authenticate your request by providing
    /// a signature. Lambda supports signature version 4. For more information, see <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
    /// Version 4 signing process</a> in the <i>Amazon Web Services General Reference.</i>
    /// 
    /// </para>
    /// </summary>
    public partial class AmazonLambdaCoreClient : AmazonServiceClient, IAmazonLambdaCore
    {
        private static IServiceMetadata serviceMetadata = new AmazonLambdaCoreMetadata();
        private ILambdaCorePaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ILambdaCorePaginatorFactory Paginators
        {
            get
            {
                if (this._paginators == null)
                {
                    this._paginators = new LambdaCorePaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        /// <summary>
        /// Constructs AmazonLambdaCoreClient with the credentials loaded from the application's
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
        public AmazonLambdaCoreClient() : base(new AmazonLambdaCoreConfig()) { }

        /// <summary>
        /// Constructs AmazonLambdaCoreClient with the credentials loaded from the application's
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
        public AmazonLambdaCoreClient(RegionEndpoint region) : base(new AmazonLambdaCoreConfig { RegionEndpoint = region }) { }

        /// <summary>
        /// Constructs AmazonLambdaCoreClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonLambdaCoreClient Configuration Object</param>
        public AmazonLambdaCoreClient(AmazonLambdaCoreConfig config) : base(config) { }

        /// <summary>
        /// Constructs AmazonLambdaCoreClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonLambdaCoreClient(AWSCredentials credentials)
            : this(credentials, new AmazonLambdaCoreConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonLambdaCoreClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonLambdaCoreClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonLambdaCoreConfig { RegionEndpoint = region })
        {
        }

        /// <summary>
        /// Constructs AmazonLambdaCoreClient with AWS Credentials and an
        /// AmazonLambdaCoreClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonLambdaCoreClient Configuration Object</param>
        public AmazonLambdaCoreClient(AWSCredentials credentials, AmazonLambdaCoreConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonLambdaCoreClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonLambdaCoreClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonLambdaCoreConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonLambdaCoreClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonLambdaCoreClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonLambdaCoreConfig { RegionEndpoint = region })
        {
        }

        /// <summary>
        /// Constructs AmazonLambdaCoreClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonLambdaCoreClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonLambdaCoreClient Configuration Object</param>
        public AmazonLambdaCoreClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonLambdaCoreConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonLambdaCoreClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonLambdaCoreClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonLambdaCoreConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonLambdaCoreClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonLambdaCoreClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonLambdaCoreConfig { RegionEndpoint = region })
        {
        }

        /// <summary>
        /// Constructs AmazonLambdaCoreClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonLambdaCoreClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonLambdaCoreClient Configuration Object</param>
        public AmazonLambdaCoreClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonLambdaCoreConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonLambdaCoreEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonLambdaCoreAuthSchemeHandler());
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
        /// Creates a network connector that enables Lambda compute resources to route outbound
        /// traffic through your Amazon VPC. The network connector provisions elastic network
        /// interfaces (ENIs) in the subnets you specify, providing a managed network path to
        /// private resources such as databases, caches, and internal APIs.
        /// 
        ///  
        /// <para>
        /// This operation is asynchronous. The network connector starts in <c>PENDING</c> state
        /// while ENIs are provisioned in your VPC (provisioning typically takes up to 10 minutes).
        /// Use <c>GetNetworkConnector</c> to poll the connector state until it reaches <c>ACTIVE</c>.
        /// Once active, you can attach the connector to supported Lambda compute resources —
        /// such as MicroVMs and WebFunctions — at run time. For how to attach a connector, see
        /// the documentation for the specific compute type.
        /// </para>
        ///  
        /// <para>
        /// This operation is idempotent when you provide a <c>ClientToken</c> — if you retry
        /// a request that completed successfully using the same client token, the operation returns
        /// the existing connector without creating a duplicate.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkConnector service method.</param>
        /// <returns>The response from the CreateNetworkConnector service method, as returned by LambdaCore.</returns>
        /// <exception cref="Amazon.LambdaCore.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid. Check the error message for details
        /// about which parameter failed validation.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.NetworkConnectorLimitExceededException">
        /// The request would exceed a network connector limit. For <c>CreateNetworkConnector</c>,
        /// the account has reached the maximum number of network connectors allowed. For <c>UpdateNetworkConnector</c>,
        /// the connector has reached the maximum number of versions allowed.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ResourceConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. For example, attempting to modify a resource that is not in a state that
        /// permits the operation.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ServiceException">
        /// An internal service error occurred. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.TooManyRequestsException">
        /// The request was throttled due to exceeding the allowed request rate. Retry the request
        /// after a brief wait using exponential backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-core-2026-04-30/CreateNetworkConnector">REST API Reference for CreateNetworkConnector Operation</seealso>
        public virtual CreateNetworkConnectorResponse CreateNetworkConnector(CreateNetworkConnectorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateNetworkConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNetworkConnectorResponseUnmarshaller.Instance;

            return Invoke<CreateNetworkConnectorResponse>(request, options);
        }
#else
        internal virtual CreateNetworkConnectorResponse CreateNetworkConnector(CreateNetworkConnectorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateNetworkConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNetworkConnectorResponseUnmarshaller.Instance;

            return Invoke<CreateNetworkConnectorResponse>(request, options);
        }
#endif

        /// <summary>
        /// Creates a network connector that enables Lambda compute resources to route outbound
        /// traffic through your Amazon VPC. The network connector provisions elastic network
        /// interfaces (ENIs) in the subnets you specify, providing a managed network path to
        /// private resources such as databases, caches, and internal APIs.
        /// 
        ///  
        /// <para>
        /// This operation is asynchronous. The network connector starts in <c>PENDING</c> state
        /// while ENIs are provisioned in your VPC (provisioning typically takes up to 10 minutes).
        /// Use <c>GetNetworkConnector</c> to poll the connector state until it reaches <c>ACTIVE</c>.
        /// Once active, you can attach the connector to supported Lambda compute resources —
        /// such as MicroVMs and WebFunctions — at run time. For how to attach a connector, see
        /// the documentation for the specific compute type.
        /// </para>
        ///  
        /// <para>
        /// This operation is idempotent when you provide a <c>ClientToken</c> — if you retry
        /// a request that completed successfully using the same client token, the operation returns
        /// the existing connector without creating a duplicate.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkConnector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateNetworkConnector service method, as returned by LambdaCore.</returns>
        /// <exception cref="Amazon.LambdaCore.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid. Check the error message for details
        /// about which parameter failed validation.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.NetworkConnectorLimitExceededException">
        /// The request would exceed a network connector limit. For <c>CreateNetworkConnector</c>,
        /// the account has reached the maximum number of network connectors allowed. For <c>UpdateNetworkConnector</c>,
        /// the connector has reached the maximum number of versions allowed.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ResourceConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. For example, attempting to modify a resource that is not in a state that
        /// permits the operation.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ServiceException">
        /// An internal service error occurred. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.TooManyRequestsException">
        /// The request was throttled due to exceeding the allowed request rate. Retry the request
        /// after a brief wait using exponential backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-core-2026-04-30/CreateNetworkConnector">REST API Reference for CreateNetworkConnector Operation</seealso>
        public virtual Task<CreateNetworkConnectorResponse> CreateNetworkConnectorAsync(CreateNetworkConnectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateNetworkConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNetworkConnectorResponseUnmarshaller.Instance;

            return InvokeAsync<CreateNetworkConnectorResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Creates a customer-managed runtime, a resource providing a centrally managed execution
        /// environment for your Lambda functions. The runtime resource is the parent of the runtime
        /// version and runtime alias child resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRuntime service method.</param>
        /// <returns>The response from the CreateRuntime service method, as returned by LambdaCore.</returns>
        /// <exception cref="Amazon.LambdaCore.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid. Check the error message for details
        /// about which parameter failed validation.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ResourceConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. For example, attempting to modify a resource that is not in a state that
        /// permits the operation.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ServiceException">
        /// An internal service error occurred. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota for your account. Request a quota increase
        /// or reduce the number of resources in use, then retry the request.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.TooManyRequestsException">
        /// The request was throttled due to exceeding the allowed request rate. Retry the request
        /// after a brief wait using exponential backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-core-2026-04-30/CreateRuntime">REST API Reference for CreateRuntime Operation</seealso>
        public virtual CreateRuntimeResponse CreateRuntime(CreateRuntimeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRuntimeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRuntimeResponseUnmarshaller.Instance;

            return Invoke<CreateRuntimeResponse>(request, options);
        }
#else
        internal virtual CreateRuntimeResponse CreateRuntime(CreateRuntimeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRuntimeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRuntimeResponseUnmarshaller.Instance;

            return Invoke<CreateRuntimeResponse>(request, options);
        }
#endif

        /// <summary>
        /// Creates a customer-managed runtime, a resource providing a centrally managed execution
        /// environment for your Lambda functions. The runtime resource is the parent of the runtime
        /// version and runtime alias child resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRuntime service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateRuntime service method, as returned by LambdaCore.</returns>
        /// <exception cref="Amazon.LambdaCore.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid. Check the error message for details
        /// about which parameter failed validation.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ResourceConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. For example, attempting to modify a resource that is not in a state that
        /// permits the operation.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ServiceException">
        /// An internal service error occurred. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota for your account. Request a quota increase
        /// or reduce the number of resources in use, then retry the request.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.TooManyRequestsException">
        /// The request was throttled due to exceeding the allowed request rate. Retry the request
        /// after a brief wait using exponential backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-core-2026-04-30/CreateRuntime">REST API Reference for CreateRuntime Operation</seealso>
        public virtual Task<CreateRuntimeResponse> CreateRuntimeAsync(CreateRuntimeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRuntimeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRuntimeResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRuntimeResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Creates a new customer-managed runtime alias. The alias is a named pointer to a runtime
        /// version. Functions consume the customer-managed runtime through the runtime alias.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRuntimeAlias service method.</param>
        /// <returns>The response from the CreateRuntimeAlias service method, as returned by LambdaCore.</returns>
        /// <exception cref="Amazon.LambdaCore.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid. Check the error message for details
        /// about which parameter failed validation.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ResourceConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. For example, attempting to modify a resource that is not in a state that
        /// permits the operation.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ResourceNotFoundException">
        /// The specified resource does not exist. Verify the identifier and Region.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ServiceException">
        /// An internal service error occurred. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota for your account. Request a quota increase
        /// or reduce the number of resources in use, then retry the request.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.TooManyRequestsException">
        /// The request was throttled due to exceeding the allowed request rate. Retry the request
        /// after a brief wait using exponential backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-core-2026-04-30/CreateRuntimeAlias">REST API Reference for CreateRuntimeAlias Operation</seealso>
        public virtual CreateRuntimeAliasResponse CreateRuntimeAlias(CreateRuntimeAliasRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRuntimeAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRuntimeAliasResponseUnmarshaller.Instance;

            return Invoke<CreateRuntimeAliasResponse>(request, options);
        }
#else
        internal virtual CreateRuntimeAliasResponse CreateRuntimeAlias(CreateRuntimeAliasRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRuntimeAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRuntimeAliasResponseUnmarshaller.Instance;

            return Invoke<CreateRuntimeAliasResponse>(request, options);
        }
#endif

        /// <summary>
        /// Creates a new customer-managed runtime alias. The alias is a named pointer to a runtime
        /// version. Functions consume the customer-managed runtime through the runtime alias.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRuntimeAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateRuntimeAlias service method, as returned by LambdaCore.</returns>
        /// <exception cref="Amazon.LambdaCore.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid. Check the error message for details
        /// about which parameter failed validation.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ResourceConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. For example, attempting to modify a resource that is not in a state that
        /// permits the operation.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ResourceNotFoundException">
        /// The specified resource does not exist. Verify the identifier and Region.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ServiceException">
        /// An internal service error occurred. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota for your account. Request a quota increase
        /// or reduce the number of resources in use, then retry the request.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.TooManyRequestsException">
        /// The request was throttled due to exceeding the allowed request rate. Retry the request
        /// after a brief wait using exponential backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-core-2026-04-30/CreateRuntimeAlias">REST API Reference for CreateRuntimeAlias Operation</seealso>
        public virtual Task<CreateRuntimeAliasResponse> CreateRuntimeAliasAsync(CreateRuntimeAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRuntimeAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRuntimeAliasResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRuntimeAliasResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Creates a new runtime version. A runtime version defines the function execution environment
        /// by referencing a container image. Runtime versions are immutable. To update the runtime,
        /// create a new runtime version and migrate functions by updating the runtime aliases
        /// to point to the new runtime version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRuntimeVersion service method.</param>
        /// <returns>The response from the CreateRuntimeVersion service method, as returned by LambdaCore.</returns>
        /// <exception cref="Amazon.LambdaCore.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid. Check the error message for details
        /// about which parameter failed validation.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ResourceConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. For example, attempting to modify a resource that is not in a state that
        /// permits the operation.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ResourceNotFoundException">
        /// The specified resource does not exist. Verify the identifier and Region.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ServiceException">
        /// An internal service error occurred. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota for your account. Request a quota increase
        /// or reduce the number of resources in use, then retry the request.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.TooManyRequestsException">
        /// The request was throttled due to exceeding the allowed request rate. Retry the request
        /// after a brief wait using exponential backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-core-2026-04-30/CreateRuntimeVersion">REST API Reference for CreateRuntimeVersion Operation</seealso>
        public virtual CreateRuntimeVersionResponse CreateRuntimeVersion(CreateRuntimeVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRuntimeVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRuntimeVersionResponseUnmarshaller.Instance;

            return Invoke<CreateRuntimeVersionResponse>(request, options);
        }
#else
        internal virtual CreateRuntimeVersionResponse CreateRuntimeVersion(CreateRuntimeVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRuntimeVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRuntimeVersionResponseUnmarshaller.Instance;

            return Invoke<CreateRuntimeVersionResponse>(request, options);
        }
#endif

        /// <summary>
        /// Creates a new runtime version. A runtime version defines the function execution environment
        /// by referencing a container image. Runtime versions are immutable. To update the runtime,
        /// create a new runtime version and migrate functions by updating the runtime aliases
        /// to point to the new runtime version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRuntimeVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateRuntimeVersion service method, as returned by LambdaCore.</returns>
        /// <exception cref="Amazon.LambdaCore.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid. Check the error message for details
        /// about which parameter failed validation.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ResourceConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. For example, attempting to modify a resource that is not in a state that
        /// permits the operation.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ResourceNotFoundException">
        /// The specified resource does not exist. Verify the identifier and Region.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ServiceException">
        /// An internal service error occurred. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota for your account. Request a quota increase
        /// or reduce the number of resources in use, then retry the request.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.TooManyRequestsException">
        /// The request was throttled due to exceeding the allowed request rate. Retry the request
        /// after a brief wait using exponential backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-core-2026-04-30/CreateRuntimeVersion">REST API Reference for CreateRuntimeVersion Operation</seealso>
        public virtual Task<CreateRuntimeVersionResponse> CreateRuntimeVersionAsync(CreateRuntimeVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRuntimeVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRuntimeVersionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRuntimeVersionResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Initiates deletion of a network connector. The connector transitions to <c>DELETING</c>
        /// state while elastic network interfaces are cleaned up asynchronously. After deletion
        /// completes, subsequent calls to <c>GetNetworkConnector</c> return <c>ResourceNotFoundException</c>.
        /// 
        ///  
        /// <para>
        /// This operation is idempotent — calling delete on a connector that is already deleting
        /// or has been deleted succeeds without error. You can delete connectors in <c>ACTIVE</c>
        /// or <c>FAILED</c> states. Before deleting a connector, ensure that no Lambda compute
        /// resources are using it, as they will lose VPC egress connectivity immediately.
        /// </para>
        ///  
        /// <para>
        /// Deleting with an unqualified identifier removes the connector and all of its versions.
        /// To remove a single historical version, supply its version-qualified ARN; the connector
        /// and its remaining versions are unaffected. You can't delete the latest version on
        /// its own — delete the connector to remove it.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkConnector service method.</param>
        /// <returns>The response from the DeleteNetworkConnector service method, as returned by LambdaCore.</returns>
        /// <exception cref="Amazon.LambdaCore.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid. Check the error message for details
        /// about which parameter failed validation.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ResourceConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. For example, attempting to modify a resource that is not in a state that
        /// permits the operation.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ResourceNotFoundException">
        /// The specified resource does not exist. Verify the identifier and Region.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ServiceException">
        /// An internal service error occurred. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.TooManyRequestsException">
        /// The request was throttled due to exceeding the allowed request rate. Retry the request
        /// after a brief wait using exponential backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-core-2026-04-30/DeleteNetworkConnector">REST API Reference for DeleteNetworkConnector Operation</seealso>
        public virtual DeleteNetworkConnectorResponse DeleteNetworkConnector(DeleteNetworkConnectorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteNetworkConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNetworkConnectorResponseUnmarshaller.Instance;

            return Invoke<DeleteNetworkConnectorResponse>(request, options);
        }
#else
        internal virtual DeleteNetworkConnectorResponse DeleteNetworkConnector(DeleteNetworkConnectorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteNetworkConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNetworkConnectorResponseUnmarshaller.Instance;

            return Invoke<DeleteNetworkConnectorResponse>(request, options);
        }
#endif

        /// <summary>
        /// Initiates deletion of a network connector. The connector transitions to <c>DELETING</c>
        /// state while elastic network interfaces are cleaned up asynchronously. After deletion
        /// completes, subsequent calls to <c>GetNetworkConnector</c> return <c>ResourceNotFoundException</c>.
        /// 
        ///  
        /// <para>
        /// This operation is idempotent — calling delete on a connector that is already deleting
        /// or has been deleted succeeds without error. You can delete connectors in <c>ACTIVE</c>
        /// or <c>FAILED</c> states. Before deleting a connector, ensure that no Lambda compute
        /// resources are using it, as they will lose VPC egress connectivity immediately.
        /// </para>
        ///  
        /// <para>
        /// Deleting with an unqualified identifier removes the connector and all of its versions.
        /// To remove a single historical version, supply its version-qualified ARN; the connector
        /// and its remaining versions are unaffected. You can't delete the latest version on
        /// its own — delete the connector to remove it.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkConnector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteNetworkConnector service method, as returned by LambdaCore.</returns>
        /// <exception cref="Amazon.LambdaCore.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid. Check the error message for details
        /// about which parameter failed validation.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ResourceConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. For example, attempting to modify a resource that is not in a state that
        /// permits the operation.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ResourceNotFoundException">
        /// The specified resource does not exist. Verify the identifier and Region.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ServiceException">
        /// An internal service error occurred. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.TooManyRequestsException">
        /// The request was throttled due to exceeding the allowed request rate. Retry the request
        /// after a brief wait using exponential backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-core-2026-04-30/DeleteNetworkConnector">REST API Reference for DeleteNetworkConnector Operation</seealso>
        public virtual Task<DeleteNetworkConnectorResponse> DeleteNetworkConnectorAsync(DeleteNetworkConnectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteNetworkConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNetworkConnectorResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteNetworkConnectorResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Schedules a customer-managed runtime to be deleted. Runtimes scheduled for deletion
        /// enter the PENDING_DELETION state and can be restored during the scheduled deletion
        /// window. Runtime versions and aliases must be deleted or scheduled for deletion before
        /// deleting the runtime. Function invokes fail for functions using runtime versions or
        /// aliases that are deleted or pending deletion.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRuntime service method.</param>
        /// <returns>The response from the DeleteRuntime service method, as returned by LambdaCore.</returns>
        /// <exception cref="Amazon.LambdaCore.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid. Check the error message for details
        /// about which parameter failed validation.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ResourceConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. For example, attempting to modify a resource that is not in a state that
        /// permits the operation.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ResourceNotFoundException">
        /// The specified resource does not exist. Verify the identifier and Region.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ServiceException">
        /// An internal service error occurred. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.TooManyRequestsException">
        /// The request was throttled due to exceeding the allowed request rate. Retry the request
        /// after a brief wait using exponential backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-core-2026-04-30/DeleteRuntime">REST API Reference for DeleteRuntime Operation</seealso>
        public virtual DeleteRuntimeResponse DeleteRuntime(DeleteRuntimeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRuntimeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRuntimeResponseUnmarshaller.Instance;

            return Invoke<DeleteRuntimeResponse>(request, options);
        }
#else
        internal virtual DeleteRuntimeResponse DeleteRuntime(DeleteRuntimeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRuntimeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRuntimeResponseUnmarshaller.Instance;

            return Invoke<DeleteRuntimeResponse>(request, options);
        }
#endif

        /// <summary>
        /// Schedules a customer-managed runtime to be deleted. Runtimes scheduled for deletion
        /// enter the PENDING_DELETION state and can be restored during the scheduled deletion
        /// window. Runtime versions and aliases must be deleted or scheduled for deletion before
        /// deleting the runtime. Function invokes fail for functions using runtime versions or
        /// aliases that are deleted or pending deletion.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRuntime service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteRuntime service method, as returned by LambdaCore.</returns>
        /// <exception cref="Amazon.LambdaCore.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid. Check the error message for details
        /// about which parameter failed validation.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ResourceConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. For example, attempting to modify a resource that is not in a state that
        /// permits the operation.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ResourceNotFoundException">
        /// The specified resource does not exist. Verify the identifier and Region.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ServiceException">
        /// An internal service error occurred. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.TooManyRequestsException">
        /// The request was throttled due to exceeding the allowed request rate. Retry the request
        /// after a brief wait using exponential backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-core-2026-04-30/DeleteRuntime">REST API Reference for DeleteRuntime Operation</seealso>
        public virtual Task<DeleteRuntimeResponse> DeleteRuntimeAsync(DeleteRuntimeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRuntimeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRuntimeResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRuntimeResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Schedules a runtime alias to be deleted. Runtime aliases scheduled for deletion enter
        /// the PENDING_DELETION state and can be restored during the scheduled deletion window.
        /// Function invokes fail for functions using runtime aliases that are deleted or pending
        /// deletion.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRuntimeAlias service method.</param>
        /// <returns>The response from the DeleteRuntimeAlias service method, as returned by LambdaCore.</returns>
        /// <exception cref="Amazon.LambdaCore.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid. Check the error message for details
        /// about which parameter failed validation.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ResourceConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. For example, attempting to modify a resource that is not in a state that
        /// permits the operation.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ResourceNotFoundException">
        /// The specified resource does not exist. Verify the identifier and Region.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ServiceException">
        /// An internal service error occurred. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.TooManyRequestsException">
        /// The request was throttled due to exceeding the allowed request rate. Retry the request
        /// after a brief wait using exponential backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-core-2026-04-30/DeleteRuntimeAlias">REST API Reference for DeleteRuntimeAlias Operation</seealso>
        public virtual DeleteRuntimeAliasResponse DeleteRuntimeAlias(DeleteRuntimeAliasRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRuntimeAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRuntimeAliasResponseUnmarshaller.Instance;

            return Invoke<DeleteRuntimeAliasResponse>(request, options);
        }
#else
        internal virtual DeleteRuntimeAliasResponse DeleteRuntimeAlias(DeleteRuntimeAliasRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRuntimeAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRuntimeAliasResponseUnmarshaller.Instance;

            return Invoke<DeleteRuntimeAliasResponse>(request, options);
        }
#endif

        /// <summary>
        /// Schedules a runtime alias to be deleted. Runtime aliases scheduled for deletion enter
        /// the PENDING_DELETION state and can be restored during the scheduled deletion window.
        /// Function invokes fail for functions using runtime aliases that are deleted or pending
        /// deletion.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRuntimeAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteRuntimeAlias service method, as returned by LambdaCore.</returns>
        /// <exception cref="Amazon.LambdaCore.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid. Check the error message for details
        /// about which parameter failed validation.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ResourceConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. For example, attempting to modify a resource that is not in a state that
        /// permits the operation.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ResourceNotFoundException">
        /// The specified resource does not exist. Verify the identifier and Region.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ServiceException">
        /// An internal service error occurred. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.TooManyRequestsException">
        /// The request was throttled due to exceeding the allowed request rate. Retry the request
        /// after a brief wait using exponential backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-core-2026-04-30/DeleteRuntimeAlias">REST API Reference for DeleteRuntimeAlias Operation</seealso>
        public virtual Task<DeleteRuntimeAliasResponse> DeleteRuntimeAliasAsync(DeleteRuntimeAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRuntimeAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRuntimeAliasResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRuntimeAliasResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Schedules a runtime version to be deleted. Runtime versions scheduled for deletion
        /// enter the PENDING_DELETION state and can be restored during the scheduled deletion
        /// window. Function invokes fail for functions using a runtime version that is deleted
        /// or pending deletion.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRuntimeVersion service method.</param>
        /// <returns>The response from the DeleteRuntimeVersion service method, as returned by LambdaCore.</returns>
        /// <exception cref="Amazon.LambdaCore.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid. Check the error message for details
        /// about which parameter failed validation.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ResourceConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. For example, attempting to modify a resource that is not in a state that
        /// permits the operation.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ResourceNotFoundException">
        /// The specified resource does not exist. Verify the identifier and Region.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ServiceException">
        /// An internal service error occurred. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.TooManyRequestsException">
        /// The request was throttled due to exceeding the allowed request rate. Retry the request
        /// after a brief wait using exponential backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-core-2026-04-30/DeleteRuntimeVersion">REST API Reference for DeleteRuntimeVersion Operation</seealso>
        public virtual DeleteRuntimeVersionResponse DeleteRuntimeVersion(DeleteRuntimeVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRuntimeVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRuntimeVersionResponseUnmarshaller.Instance;

            return Invoke<DeleteRuntimeVersionResponse>(request, options);
        }
#else
        internal virtual DeleteRuntimeVersionResponse DeleteRuntimeVersion(DeleteRuntimeVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRuntimeVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRuntimeVersionResponseUnmarshaller.Instance;

            return Invoke<DeleteRuntimeVersionResponse>(request, options);
        }
#endif

        /// <summary>
        /// Schedules a runtime version to be deleted. Runtime versions scheduled for deletion
        /// enter the PENDING_DELETION state and can be restored during the scheduled deletion
        /// window. Function invokes fail for functions using a runtime version that is deleted
        /// or pending deletion.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRuntimeVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteRuntimeVersion service method, as returned by LambdaCore.</returns>
        /// <exception cref="Amazon.LambdaCore.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid. Check the error message for details
        /// about which parameter failed validation.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ResourceConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. For example, attempting to modify a resource that is not in a state that
        /// permits the operation.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ResourceNotFoundException">
        /// The specified resource does not exist. Verify the identifier and Region.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ServiceException">
        /// An internal service error occurred. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.TooManyRequestsException">
        /// The request was throttled due to exceeding the allowed request rate. Retry the request
        /// after a brief wait using exponential backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-core-2026-04-30/DeleteRuntimeVersion">REST API Reference for DeleteRuntimeVersion Operation</seealso>
        public virtual Task<DeleteRuntimeVersionResponse> DeleteRuntimeVersionAsync(DeleteRuntimeVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRuntimeVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRuntimeVersionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRuntimeVersionResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves the current configuration, state, and metadata of a network connector. The
        /// <c>Identifier</c> parameter accepts the connector ID, name, or full ARN. Use this
        /// operation to poll connector state after creation or update, or to inspect the current
        /// VPC configuration and any failure reasons.
        /// 
        ///  
        /// <para>
        /// The response includes the full connector configuration, current state, and — if the
        /// connector has been updated — the <c>LastUpdateStatus</c> and <c>LastUpdateStatusReasonCode</c>
        /// fields that indicate whether the most recent update succeeded or failed.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNetworkConnector service method.</param>
        /// <returns>The response from the GetNetworkConnector service method, as returned by LambdaCore.</returns>
        /// <exception cref="Amazon.LambdaCore.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid. Check the error message for details
        /// about which parameter failed validation.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ResourceNotFoundException">
        /// The specified resource does not exist. Verify the identifier and Region.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ServiceException">
        /// An internal service error occurred. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.TooManyRequestsException">
        /// The request was throttled due to exceeding the allowed request rate. Retry the request
        /// after a brief wait using exponential backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-core-2026-04-30/GetNetworkConnector">REST API Reference for GetNetworkConnector Operation</seealso>
        public virtual GetNetworkConnectorResponse GetNetworkConnector(GetNetworkConnectorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetNetworkConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNetworkConnectorResponseUnmarshaller.Instance;

            return Invoke<GetNetworkConnectorResponse>(request, options);
        }
#else
        internal virtual GetNetworkConnectorResponse GetNetworkConnector(GetNetworkConnectorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetNetworkConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNetworkConnectorResponseUnmarshaller.Instance;

            return Invoke<GetNetworkConnectorResponse>(request, options);
        }
#endif

        /// <summary>
        /// Retrieves the current configuration, state, and metadata of a network connector. The
        /// <c>Identifier</c> parameter accepts the connector ID, name, or full ARN. Use this
        /// operation to poll connector state after creation or update, or to inspect the current
        /// VPC configuration and any failure reasons.
        /// 
        ///  
        /// <para>
        /// The response includes the full connector configuration, current state, and — if the
        /// connector has been updated — the <c>LastUpdateStatus</c> and <c>LastUpdateStatusReasonCode</c>
        /// fields that indicate whether the most recent update succeeded or failed.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNetworkConnector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetNetworkConnector service method, as returned by LambdaCore.</returns>
        /// <exception cref="Amazon.LambdaCore.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid. Check the error message for details
        /// about which parameter failed validation.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ResourceNotFoundException">
        /// The specified resource does not exist. Verify the identifier and Region.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ServiceException">
        /// An internal service error occurred. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.TooManyRequestsException">
        /// The request was throttled due to exceeding the allowed request rate. Retry the request
        /// after a brief wait using exponential backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-core-2026-04-30/GetNetworkConnector">REST API Reference for GetNetworkConnector Operation</seealso>
        public virtual Task<GetNetworkConnectorResponse> GetNetworkConnectorAsync(GetNetworkConnectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetNetworkConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNetworkConnectorResponseUnmarshaller.Instance;

            return InvokeAsync<GetNetworkConnectorResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves the configuration and metadata of a runtime.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRuntime service method.</param>
        /// <returns>The response from the GetRuntime service method, as returned by LambdaCore.</returns>
        /// <exception cref="Amazon.LambdaCore.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid. Check the error message for details
        /// about which parameter failed validation.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ResourceNotFoundException">
        /// The specified resource does not exist. Verify the identifier and Region.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ServiceException">
        /// An internal service error occurred. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.TooManyRequestsException">
        /// The request was throttled due to exceeding the allowed request rate. Retry the request
        /// after a brief wait using exponential backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-core-2026-04-30/GetRuntime">REST API Reference for GetRuntime Operation</seealso>
        public virtual GetRuntimeResponse GetRuntime(GetRuntimeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRuntimeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRuntimeResponseUnmarshaller.Instance;

            return Invoke<GetRuntimeResponse>(request, options);
        }
#else
        internal virtual GetRuntimeResponse GetRuntime(GetRuntimeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRuntimeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRuntimeResponseUnmarshaller.Instance;

            return Invoke<GetRuntimeResponse>(request, options);
        }
#endif

        /// <summary>
        /// Retrieves the configuration and metadata of a runtime.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRuntime service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetRuntime service method, as returned by LambdaCore.</returns>
        /// <exception cref="Amazon.LambdaCore.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid. Check the error message for details
        /// about which parameter failed validation.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ResourceNotFoundException">
        /// The specified resource does not exist. Verify the identifier and Region.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ServiceException">
        /// An internal service error occurred. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.TooManyRequestsException">
        /// The request was throttled due to exceeding the allowed request rate. Retry the request
        /// after a brief wait using exponential backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-core-2026-04-30/GetRuntime">REST API Reference for GetRuntime Operation</seealso>
        public virtual Task<GetRuntimeResponse> GetRuntimeAsync(GetRuntimeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRuntimeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRuntimeResponseUnmarshaller.Instance;

            return InvokeAsync<GetRuntimeResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves the configuration, state, and metadata of a runtime alias.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRuntimeAlias service method.</param>
        /// <returns>The response from the GetRuntimeAlias service method, as returned by LambdaCore.</returns>
        /// <exception cref="Amazon.LambdaCore.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid. Check the error message for details
        /// about which parameter failed validation.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ResourceNotFoundException">
        /// The specified resource does not exist. Verify the identifier and Region.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ServiceException">
        /// An internal service error occurred. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.TooManyRequestsException">
        /// The request was throttled due to exceeding the allowed request rate. Retry the request
        /// after a brief wait using exponential backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-core-2026-04-30/GetRuntimeAlias">REST API Reference for GetRuntimeAlias Operation</seealso>
        public virtual GetRuntimeAliasResponse GetRuntimeAlias(GetRuntimeAliasRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRuntimeAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRuntimeAliasResponseUnmarshaller.Instance;

            return Invoke<GetRuntimeAliasResponse>(request, options);
        }
#else
        internal virtual GetRuntimeAliasResponse GetRuntimeAlias(GetRuntimeAliasRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRuntimeAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRuntimeAliasResponseUnmarshaller.Instance;

            return Invoke<GetRuntimeAliasResponse>(request, options);
        }
#endif

        /// <summary>
        /// Retrieves the configuration, state, and metadata of a runtime alias.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRuntimeAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetRuntimeAlias service method, as returned by LambdaCore.</returns>
        /// <exception cref="Amazon.LambdaCore.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid. Check the error message for details
        /// about which parameter failed validation.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ResourceNotFoundException">
        /// The specified resource does not exist. Verify the identifier and Region.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ServiceException">
        /// An internal service error occurred. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.TooManyRequestsException">
        /// The request was throttled due to exceeding the allowed request rate. Retry the request
        /// after a brief wait using exponential backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-core-2026-04-30/GetRuntimeAlias">REST API Reference for GetRuntimeAlias Operation</seealso>
        public virtual Task<GetRuntimeAliasResponse> GetRuntimeAliasAsync(GetRuntimeAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRuntimeAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRuntimeAliasResponseUnmarshaller.Instance;

            return InvokeAsync<GetRuntimeAliasResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves the configuration, state, and metadata of a runtime version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRuntimeVersion service method.</param>
        /// <returns>The response from the GetRuntimeVersion service method, as returned by LambdaCore.</returns>
        /// <exception cref="Amazon.LambdaCore.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid. Check the error message for details
        /// about which parameter failed validation.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ResourceNotFoundException">
        /// The specified resource does not exist. Verify the identifier and Region.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ServiceException">
        /// An internal service error occurred. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.TooManyRequestsException">
        /// The request was throttled due to exceeding the allowed request rate. Retry the request
        /// after a brief wait using exponential backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-core-2026-04-30/GetRuntimeVersion">REST API Reference for GetRuntimeVersion Operation</seealso>
        public virtual GetRuntimeVersionResponse GetRuntimeVersion(GetRuntimeVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRuntimeVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRuntimeVersionResponseUnmarshaller.Instance;

            return Invoke<GetRuntimeVersionResponse>(request, options);
        }
#else
        internal virtual GetRuntimeVersionResponse GetRuntimeVersion(GetRuntimeVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRuntimeVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRuntimeVersionResponseUnmarshaller.Instance;

            return Invoke<GetRuntimeVersionResponse>(request, options);
        }
#endif

        /// <summary>
        /// Retrieves the configuration, state, and metadata of a runtime version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRuntimeVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetRuntimeVersion service method, as returned by LambdaCore.</returns>
        /// <exception cref="Amazon.LambdaCore.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid. Check the error message for details
        /// about which parameter failed validation.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ResourceNotFoundException">
        /// The specified resource does not exist. Verify the identifier and Region.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ServiceException">
        /// An internal service error occurred. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.TooManyRequestsException">
        /// The request was throttled due to exceeding the allowed request rate. Retry the request
        /// after a brief wait using exponential backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-core-2026-04-30/GetRuntimeVersion">REST API Reference for GetRuntimeVersion Operation</seealso>
        public virtual Task<GetRuntimeVersionResponse> GetRuntimeVersionAsync(GetRuntimeVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRuntimeVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRuntimeVersionResponseUnmarshaller.Instance;

            return InvokeAsync<GetRuntimeVersionResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Returns a paginated list of the versions of a network connector. Each configuration
        /// update creates a new immutable version; this operation lists those versions for the
        /// connector you specify. You can optionally filter results by version state. Use the
        /// <c>Marker</c> parameter from a previous response to retrieve the next page of results.
        /// 
        ///  
        /// <para>
        /// Each item in the response includes the version-qualified ARN, version number, current
        /// state, and last modified timestamp for that version. To retrieve the current (latest)
        /// configuration of the connector, use <c>GetNetworkConnector</c>; to inspect a specific
        /// version, call <c>GetNetworkConnector</c> with a version-qualified identifier.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNetworkConnectorVersions service method.</param>
        /// <returns>The response from the ListNetworkConnectorVersions service method, as returned by LambdaCore.</returns>
        /// <exception cref="Amazon.LambdaCore.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid. Check the error message for details
        /// about which parameter failed validation.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ResourceNotFoundException">
        /// The specified resource does not exist. Verify the identifier and Region.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ServiceException">
        /// An internal service error occurred. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.TooManyRequestsException">
        /// The request was throttled due to exceeding the allowed request rate. Retry the request
        /// after a brief wait using exponential backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-core-2026-04-30/ListNetworkConnectorVersions">REST API Reference for ListNetworkConnectorVersions Operation</seealso>
        public virtual ListNetworkConnectorVersionsResponse ListNetworkConnectorVersions(ListNetworkConnectorVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListNetworkConnectorVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNetworkConnectorVersionsResponseUnmarshaller.Instance;

            return Invoke<ListNetworkConnectorVersionsResponse>(request, options);
        }
#else
        internal virtual ListNetworkConnectorVersionsResponse ListNetworkConnectorVersions(ListNetworkConnectorVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListNetworkConnectorVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNetworkConnectorVersionsResponseUnmarshaller.Instance;

            return Invoke<ListNetworkConnectorVersionsResponse>(request, options);
        }
#endif

        /// <summary>
        /// Returns a paginated list of the versions of a network connector. Each configuration
        /// update creates a new immutable version; this operation lists those versions for the
        /// connector you specify. You can optionally filter results by version state. Use the
        /// <c>Marker</c> parameter from a previous response to retrieve the next page of results.
        /// 
        ///  
        /// <para>
        /// Each item in the response includes the version-qualified ARN, version number, current
        /// state, and last modified timestamp for that version. To retrieve the current (latest)
        /// configuration of the connector, use <c>GetNetworkConnector</c>; to inspect a specific
        /// version, call <c>GetNetworkConnector</c> with a version-qualified identifier.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNetworkConnectorVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListNetworkConnectorVersions service method, as returned by LambdaCore.</returns>
        /// <exception cref="Amazon.LambdaCore.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid. Check the error message for details
        /// about which parameter failed validation.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ResourceNotFoundException">
        /// The specified resource does not exist. Verify the identifier and Region.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ServiceException">
        /// An internal service error occurred. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.TooManyRequestsException">
        /// The request was throttled due to exceeding the allowed request rate. Retry the request
        /// after a brief wait using exponential backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-core-2026-04-30/ListNetworkConnectorVersions">REST API Reference for ListNetworkConnectorVersions Operation</seealso>
        public virtual Task<ListNetworkConnectorVersionsResponse> ListNetworkConnectorVersionsAsync(ListNetworkConnectorVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListNetworkConnectorVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNetworkConnectorVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListNetworkConnectorVersionsResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Returns a paginated list of network connectors in your account for the current Region.
        /// You can optionally filter results by connector state. Use the <c>Marker</c> parameter
        /// from a previous response to retrieve the next page of results.
        /// 
        ///  
        /// <para>
        /// Each item in the response includes the connector ARN, name, ID, type, current state,
        /// and last modified timestamp. To retrieve full configuration details for a specific
        /// connector, use <c>GetNetworkConnector</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNetworkConnectors service method.</param>
        /// <returns>The response from the ListNetworkConnectors service method, as returned by LambdaCore.</returns>
        /// <exception cref="Amazon.LambdaCore.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid. Check the error message for details
        /// about which parameter failed validation.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ServiceException">
        /// An internal service error occurred. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.TooManyRequestsException">
        /// The request was throttled due to exceeding the allowed request rate. Retry the request
        /// after a brief wait using exponential backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-core-2026-04-30/ListNetworkConnectors">REST API Reference for ListNetworkConnectors Operation</seealso>
        public virtual ListNetworkConnectorsResponse ListNetworkConnectors(ListNetworkConnectorsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListNetworkConnectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNetworkConnectorsResponseUnmarshaller.Instance;

            return Invoke<ListNetworkConnectorsResponse>(request, options);
        }
#else
        internal virtual ListNetworkConnectorsResponse ListNetworkConnectors(ListNetworkConnectorsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListNetworkConnectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNetworkConnectorsResponseUnmarshaller.Instance;

            return Invoke<ListNetworkConnectorsResponse>(request, options);
        }
#endif

        /// <summary>
        /// Returns a paginated list of network connectors in your account for the current Region.
        /// You can optionally filter results by connector state. Use the <c>Marker</c> parameter
        /// from a previous response to retrieve the next page of results.
        /// 
        ///  
        /// <para>
        /// Each item in the response includes the connector ARN, name, ID, type, current state,
        /// and last modified timestamp. To retrieve full configuration details for a specific
        /// connector, use <c>GetNetworkConnector</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNetworkConnectors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListNetworkConnectors service method, as returned by LambdaCore.</returns>
        /// <exception cref="Amazon.LambdaCore.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid. Check the error message for details
        /// about which parameter failed validation.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ServiceException">
        /// An internal service error occurred. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.TooManyRequestsException">
        /// The request was throttled due to exceeding the allowed request rate. Retry the request
        /// after a brief wait using exponential backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-core-2026-04-30/ListNetworkConnectors">REST API Reference for ListNetworkConnectors Operation</seealso>
        public virtual Task<ListNetworkConnectorsResponse> ListNetworkConnectorsAsync(ListNetworkConnectorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListNetworkConnectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNetworkConnectorsResponseUnmarshaller.Instance;

            return InvokeAsync<ListNetworkConnectorsResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Returns a paginated list of aliases for the specified runtime.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRuntimeAliases service method.</param>
        /// <returns>The response from the ListRuntimeAliases service method, as returned by LambdaCore.</returns>
        /// <exception cref="Amazon.LambdaCore.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid. Check the error message for details
        /// about which parameter failed validation.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ResourceNotFoundException">
        /// The specified resource does not exist. Verify the identifier and Region.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ServiceException">
        /// An internal service error occurred. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.TooManyRequestsException">
        /// The request was throttled due to exceeding the allowed request rate. Retry the request
        /// after a brief wait using exponential backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-core-2026-04-30/ListRuntimeAliases">REST API Reference for ListRuntimeAliases Operation</seealso>
        public virtual ListRuntimeAliasesResponse ListRuntimeAliases(ListRuntimeAliasesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRuntimeAliasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRuntimeAliasesResponseUnmarshaller.Instance;

            return Invoke<ListRuntimeAliasesResponse>(request, options);
        }
#else
        internal virtual ListRuntimeAliasesResponse ListRuntimeAliases(ListRuntimeAliasesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRuntimeAliasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRuntimeAliasesResponseUnmarshaller.Instance;

            return Invoke<ListRuntimeAliasesResponse>(request, options);
        }
#endif

        /// <summary>
        /// Returns a paginated list of aliases for the specified runtime.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRuntimeAliases service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListRuntimeAliases service method, as returned by LambdaCore.</returns>
        /// <exception cref="Amazon.LambdaCore.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid. Check the error message for details
        /// about which parameter failed validation.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ResourceNotFoundException">
        /// The specified resource does not exist. Verify the identifier and Region.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ServiceException">
        /// An internal service error occurred. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.TooManyRequestsException">
        /// The request was throttled due to exceeding the allowed request rate. Retry the request
        /// after a brief wait using exponential backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-core-2026-04-30/ListRuntimeAliases">REST API Reference for ListRuntimeAliases Operation</seealso>
        public virtual Task<ListRuntimeAliasesResponse> ListRuntimeAliasesAsync(ListRuntimeAliasesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRuntimeAliasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRuntimeAliasesResponseUnmarshaller.Instance;

            return InvokeAsync<ListRuntimeAliasesResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Returns a paginated list of versions for the specified runtime.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRuntimeVersions service method.</param>
        /// <returns>The response from the ListRuntimeVersions service method, as returned by LambdaCore.</returns>
        /// <exception cref="Amazon.LambdaCore.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid. Check the error message for details
        /// about which parameter failed validation.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ResourceNotFoundException">
        /// The specified resource does not exist. Verify the identifier and Region.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ServiceException">
        /// An internal service error occurred. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.TooManyRequestsException">
        /// The request was throttled due to exceeding the allowed request rate. Retry the request
        /// after a brief wait using exponential backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-core-2026-04-30/ListRuntimeVersions">REST API Reference for ListRuntimeVersions Operation</seealso>
        public virtual ListRuntimeVersionsResponse ListRuntimeVersions(ListRuntimeVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRuntimeVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRuntimeVersionsResponseUnmarshaller.Instance;

            return Invoke<ListRuntimeVersionsResponse>(request, options);
        }
#else
        internal virtual ListRuntimeVersionsResponse ListRuntimeVersions(ListRuntimeVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRuntimeVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRuntimeVersionsResponseUnmarshaller.Instance;

            return Invoke<ListRuntimeVersionsResponse>(request, options);
        }
#endif

        /// <summary>
        /// Returns a paginated list of versions for the specified runtime.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRuntimeVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListRuntimeVersions service method, as returned by LambdaCore.</returns>
        /// <exception cref="Amazon.LambdaCore.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid. Check the error message for details
        /// about which parameter failed validation.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ResourceNotFoundException">
        /// The specified resource does not exist. Verify the identifier and Region.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ServiceException">
        /// An internal service error occurred. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.TooManyRequestsException">
        /// The request was throttled due to exceeding the allowed request rate. Retry the request
        /// after a brief wait using exponential backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-core-2026-04-30/ListRuntimeVersions">REST API Reference for ListRuntimeVersions Operation</seealso>
        public virtual Task<ListRuntimeVersionsResponse> ListRuntimeVersionsAsync(ListRuntimeVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRuntimeVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRuntimeVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListRuntimeVersionsResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Returns a paginated list of runtimes in your account for the current Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRuntimes service method.</param>
        /// <returns>The response from the ListRuntimes service method, as returned by LambdaCore.</returns>
        /// <exception cref="Amazon.LambdaCore.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid. Check the error message for details
        /// about which parameter failed validation.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ServiceException">
        /// An internal service error occurred. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.TooManyRequestsException">
        /// The request was throttled due to exceeding the allowed request rate. Retry the request
        /// after a brief wait using exponential backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-core-2026-04-30/ListRuntimes">REST API Reference for ListRuntimes Operation</seealso>
        public virtual ListRuntimesResponse ListRuntimes(ListRuntimesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRuntimesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRuntimesResponseUnmarshaller.Instance;

            return Invoke<ListRuntimesResponse>(request, options);
        }
#else
        internal virtual ListRuntimesResponse ListRuntimes(ListRuntimesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRuntimesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRuntimesResponseUnmarshaller.Instance;

            return Invoke<ListRuntimesResponse>(request, options);
        }
#endif

        /// <summary>
        /// Returns a paginated list of runtimes in your account for the current Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRuntimes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListRuntimes service method, as returned by LambdaCore.</returns>
        /// <exception cref="Amazon.LambdaCore.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid. Check the error message for details
        /// about which parameter failed validation.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ServiceException">
        /// An internal service error occurred. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.TooManyRequestsException">
        /// The request was throttled due to exceeding the allowed request rate. Retry the request
        /// after a brief wait using exponential backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-core-2026-04-30/ListRuntimes">REST API Reference for ListRuntimes Operation</seealso>
        public virtual Task<ListRuntimesResponse> ListRuntimesAsync(ListRuntimesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRuntimesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRuntimesResponseUnmarshaller.Instance;

            return InvokeAsync<ListRuntimesResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Cancels a pending scheduled deletion, returning the resource to the ACTIVE state.
        /// Scope is determined by the RuntimeName path parameter plus an optional, mutually exclusive
        /// RuntimeVersion or RuntimeAlias query parameter: with neither, the runtime itself is
        /// restored; with RuntimeVersion, the named runtime version; with RuntimeAlias, the named
        /// runtime alias. Restoring a resource that is already ACTIVE is a no-op success. Restore
        /// only works while the target is PENDING_DELETION; once the scheduled deletion has begun
        /// executing (DELETING) or has completed, the call fails.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreRuntime service method.</param>
        /// <returns>The response from the RestoreRuntime service method, as returned by LambdaCore.</returns>
        /// <exception cref="Amazon.LambdaCore.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid. Check the error message for details
        /// about which parameter failed validation.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ResourceConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. For example, attempting to modify a resource that is not in a state that
        /// permits the operation.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ResourceNotFoundException">
        /// The specified resource does not exist. Verify the identifier and Region.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ServiceException">
        /// An internal service error occurred. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.TooManyRequestsException">
        /// The request was throttled due to exceeding the allowed request rate. Retry the request
        /// after a brief wait using exponential backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-core-2026-04-30/RestoreRuntime">REST API Reference for RestoreRuntime Operation</seealso>
        public virtual RestoreRuntimeResponse RestoreRuntime(RestoreRuntimeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RestoreRuntimeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreRuntimeResponseUnmarshaller.Instance;

            return Invoke<RestoreRuntimeResponse>(request, options);
        }
#else
        internal virtual RestoreRuntimeResponse RestoreRuntime(RestoreRuntimeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RestoreRuntimeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreRuntimeResponseUnmarshaller.Instance;

            return Invoke<RestoreRuntimeResponse>(request, options);
        }
#endif

        /// <summary>
        /// Cancels a pending scheduled deletion, returning the resource to the ACTIVE state.
        /// Scope is determined by the RuntimeName path parameter plus an optional, mutually exclusive
        /// RuntimeVersion or RuntimeAlias query parameter: with neither, the runtime itself is
        /// restored; with RuntimeVersion, the named runtime version; with RuntimeAlias, the named
        /// runtime alias. Restoring a resource that is already ACTIVE is a no-op success. Restore
        /// only works while the target is PENDING_DELETION; once the scheduled deletion has begun
        /// executing (DELETING) or has completed, the call fails.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreRuntime service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the RestoreRuntime service method, as returned by LambdaCore.</returns>
        /// <exception cref="Amazon.LambdaCore.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid. Check the error message for details
        /// about which parameter failed validation.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ResourceConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. For example, attempting to modify a resource that is not in a state that
        /// permits the operation.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ResourceNotFoundException">
        /// The specified resource does not exist. Verify the identifier and Region.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ServiceException">
        /// An internal service error occurred. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.TooManyRequestsException">
        /// The request was throttled due to exceeding the allowed request rate. Retry the request
        /// after a brief wait using exponential backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-core-2026-04-30/RestoreRuntime">REST API Reference for RestoreRuntime Operation</seealso>
        public virtual Task<RestoreRuntimeResponse> RestoreRuntimeAsync(RestoreRuntimeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RestoreRuntimeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreRuntimeResponseUnmarshaller.Instance;

            return InvokeAsync<RestoreRuntimeResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Updates the VPC configuration or operator role of an existing network connector. You
        /// can modify the subnet IDs, security group IDs, network protocol, or operator role.
        /// The connector must be in <c>ACTIVE</c> state to accept updates.
        /// 
        ///  
        /// <para>
        /// This operation is asynchronous. The connector remains in <c>ACTIVE</c> state during
        /// the update — existing workloads that reference this connector are not disrupted. Use
        /// <c>GetNetworkConnector</c> to monitor the <c>LastUpdateStatus</c> field, which transitions
        /// through <c>InProgress</c> to <c>Successful</c> or <c>Failed</c>. If the update fails,
        /// the <c>LastUpdateStatusReasonCode</c> field provides a specific error code for troubleshooting.
        /// This operation is idempotent when you provide a <c>ClientToken</c>.
        /// </para>
        ///  
        /// <para>
        /// Each successful configuration change creates a new immutable version. A connector
        /// can have a limited number of versions; once that limit is reached, further updates
        /// fail with <c>NetworkConnectorLimitExceededException</c> until you delete older versions.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNetworkConnector service method.</param>
        /// <returns>The response from the UpdateNetworkConnector service method, as returned by LambdaCore.</returns>
        /// <exception cref="Amazon.LambdaCore.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid. Check the error message for details
        /// about which parameter failed validation.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.NetworkConnectorLimitExceededException">
        /// The request would exceed a network connector limit. For <c>CreateNetworkConnector</c>,
        /// the account has reached the maximum number of network connectors allowed. For <c>UpdateNetworkConnector</c>,
        /// the connector has reached the maximum number of versions allowed.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ResourceConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. For example, attempting to modify a resource that is not in a state that
        /// permits the operation.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ResourceNotFoundException">
        /// The specified resource does not exist. Verify the identifier and Region.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ServiceException">
        /// An internal service error occurred. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.TooManyRequestsException">
        /// The request was throttled due to exceeding the allowed request rate. Retry the request
        /// after a brief wait using exponential backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-core-2026-04-30/UpdateNetworkConnector">REST API Reference for UpdateNetworkConnector Operation</seealso>
        public virtual UpdateNetworkConnectorResponse UpdateNetworkConnector(UpdateNetworkConnectorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateNetworkConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNetworkConnectorResponseUnmarshaller.Instance;

            return Invoke<UpdateNetworkConnectorResponse>(request, options);
        }
#else
        internal virtual UpdateNetworkConnectorResponse UpdateNetworkConnector(UpdateNetworkConnectorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateNetworkConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNetworkConnectorResponseUnmarshaller.Instance;

            return Invoke<UpdateNetworkConnectorResponse>(request, options);
        }
#endif

        /// <summary>
        /// Updates the VPC configuration or operator role of an existing network connector. You
        /// can modify the subnet IDs, security group IDs, network protocol, or operator role.
        /// The connector must be in <c>ACTIVE</c> state to accept updates.
        /// 
        ///  
        /// <para>
        /// This operation is asynchronous. The connector remains in <c>ACTIVE</c> state during
        /// the update — existing workloads that reference this connector are not disrupted. Use
        /// <c>GetNetworkConnector</c> to monitor the <c>LastUpdateStatus</c> field, which transitions
        /// through <c>InProgress</c> to <c>Successful</c> or <c>Failed</c>. If the update fails,
        /// the <c>LastUpdateStatusReasonCode</c> field provides a specific error code for troubleshooting.
        /// This operation is idempotent when you provide a <c>ClientToken</c>.
        /// </para>
        ///  
        /// <para>
        /// Each successful configuration change creates a new immutable version. A connector
        /// can have a limited number of versions; once that limit is reached, further updates
        /// fail with <c>NetworkConnectorLimitExceededException</c> until you delete older versions.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNetworkConnector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateNetworkConnector service method, as returned by LambdaCore.</returns>
        /// <exception cref="Amazon.LambdaCore.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid. Check the error message for details
        /// about which parameter failed validation.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.NetworkConnectorLimitExceededException">
        /// The request would exceed a network connector limit. For <c>CreateNetworkConnector</c>,
        /// the account has reached the maximum number of network connectors allowed. For <c>UpdateNetworkConnector</c>,
        /// the connector has reached the maximum number of versions allowed.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ResourceConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. For example, attempting to modify a resource that is not in a state that
        /// permits the operation.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ResourceNotFoundException">
        /// The specified resource does not exist. Verify the identifier and Region.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ServiceException">
        /// An internal service error occurred. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.TooManyRequestsException">
        /// The request was throttled due to exceeding the allowed request rate. Retry the request
        /// after a brief wait using exponential backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-core-2026-04-30/UpdateNetworkConnector">REST API Reference for UpdateNetworkConnector Operation</seealso>
        public virtual Task<UpdateNetworkConnectorResponse> UpdateNetworkConnectorAsync(UpdateNetworkConnectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateNetworkConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNetworkConnectorResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateNetworkConnectorResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Updates the properties of an existing customer-managed runtime, such as its description,
        /// license information, or lifecycle information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRuntime service method.</param>
        /// <returns>The response from the UpdateRuntime service method, as returned by LambdaCore.</returns>
        /// <exception cref="Amazon.LambdaCore.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid. Check the error message for details
        /// about which parameter failed validation.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ResourceConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. For example, attempting to modify a resource that is not in a state that
        /// permits the operation.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ResourceNotFoundException">
        /// The specified resource does not exist. Verify the identifier and Region.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ServiceException">
        /// An internal service error occurred. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.TooManyRequestsException">
        /// The request was throttled due to exceeding the allowed request rate. Retry the request
        /// after a brief wait using exponential backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-core-2026-04-30/UpdateRuntime">REST API Reference for UpdateRuntime Operation</seealso>
        public virtual UpdateRuntimeResponse UpdateRuntime(UpdateRuntimeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRuntimeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRuntimeResponseUnmarshaller.Instance;

            return Invoke<UpdateRuntimeResponse>(request, options);
        }
#else
        internal virtual UpdateRuntimeResponse UpdateRuntime(UpdateRuntimeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRuntimeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRuntimeResponseUnmarshaller.Instance;

            return Invoke<UpdateRuntimeResponse>(request, options);
        }
#endif

        /// <summary>
        /// Updates the properties of an existing customer-managed runtime, such as its description,
        /// license information, or lifecycle information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRuntime service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateRuntime service method, as returned by LambdaCore.</returns>
        /// <exception cref="Amazon.LambdaCore.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid. Check the error message for details
        /// about which parameter failed validation.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ResourceConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. For example, attempting to modify a resource that is not in a state that
        /// permits the operation.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ResourceNotFoundException">
        /// The specified resource does not exist. Verify the identifier and Region.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ServiceException">
        /// An internal service error occurred. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.TooManyRequestsException">
        /// The request was throttled due to exceeding the allowed request rate. Retry the request
        /// after a brief wait using exponential backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-core-2026-04-30/UpdateRuntime">REST API Reference for UpdateRuntime Operation</seealso>
        public virtual Task<UpdateRuntimeResponse> UpdateRuntimeAsync(UpdateRuntimeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRuntimeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRuntimeResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateRuntimeResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Updates an existing runtime alias to point to a different runtime version or to change
        /// its description or lifecycle information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRuntimeAlias service method.</param>
        /// <returns>The response from the UpdateRuntimeAlias service method, as returned by LambdaCore.</returns>
        /// <exception cref="Amazon.LambdaCore.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid. Check the error message for details
        /// about which parameter failed validation.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ResourceConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. For example, attempting to modify a resource that is not in a state that
        /// permits the operation.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ResourceNotFoundException">
        /// The specified resource does not exist. Verify the identifier and Region.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ServiceException">
        /// An internal service error occurred. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.TooManyRequestsException">
        /// The request was throttled due to exceeding the allowed request rate. Retry the request
        /// after a brief wait using exponential backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-core-2026-04-30/UpdateRuntimeAlias">REST API Reference for UpdateRuntimeAlias Operation</seealso>
        public virtual UpdateRuntimeAliasResponse UpdateRuntimeAlias(UpdateRuntimeAliasRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRuntimeAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRuntimeAliasResponseUnmarshaller.Instance;

            return Invoke<UpdateRuntimeAliasResponse>(request, options);
        }
#else
        internal virtual UpdateRuntimeAliasResponse UpdateRuntimeAlias(UpdateRuntimeAliasRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRuntimeAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRuntimeAliasResponseUnmarshaller.Instance;

            return Invoke<UpdateRuntimeAliasResponse>(request, options);
        }
#endif

        /// <summary>
        /// Updates an existing runtime alias to point to a different runtime version or to change
        /// its description or lifecycle information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRuntimeAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateRuntimeAlias service method, as returned by LambdaCore.</returns>
        /// <exception cref="Amazon.LambdaCore.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid. Check the error message for details
        /// about which parameter failed validation.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ResourceConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. For example, attempting to modify a resource that is not in a state that
        /// permits the operation.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ResourceNotFoundException">
        /// The specified resource does not exist. Verify the identifier and Region.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ServiceException">
        /// An internal service error occurred. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.TooManyRequestsException">
        /// The request was throttled due to exceeding the allowed request rate. Retry the request
        /// after a brief wait using exponential backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-core-2026-04-30/UpdateRuntimeAlias">REST API Reference for UpdateRuntimeAlias Operation</seealso>
        public virtual Task<UpdateRuntimeAliasResponse> UpdateRuntimeAliasAsync(UpdateRuntimeAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRuntimeAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRuntimeAliasResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateRuntimeAliasResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Updates the runtime version release notes. The runtime version must be in the ACTIVE
        /// state. The runtime version image is immutable. To change the runtime contents, create
        /// a new runtime version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRuntimeVersion service method.</param>
        /// <returns>The response from the UpdateRuntimeVersion service method, as returned by LambdaCore.</returns>
        /// <exception cref="Amazon.LambdaCore.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid. Check the error message for details
        /// about which parameter failed validation.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ResourceConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. For example, attempting to modify a resource that is not in a state that
        /// permits the operation.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ResourceNotFoundException">
        /// The specified resource does not exist. Verify the identifier and Region.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ServiceException">
        /// An internal service error occurred. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.TooManyRequestsException">
        /// The request was throttled due to exceeding the allowed request rate. Retry the request
        /// after a brief wait using exponential backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-core-2026-04-30/UpdateRuntimeVersion">REST API Reference for UpdateRuntimeVersion Operation</seealso>
        public virtual UpdateRuntimeVersionResponse UpdateRuntimeVersion(UpdateRuntimeVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRuntimeVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRuntimeVersionResponseUnmarshaller.Instance;

            return Invoke<UpdateRuntimeVersionResponse>(request, options);
        }
#else
        internal virtual UpdateRuntimeVersionResponse UpdateRuntimeVersion(UpdateRuntimeVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRuntimeVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRuntimeVersionResponseUnmarshaller.Instance;

            return Invoke<UpdateRuntimeVersionResponse>(request, options);
        }
#endif

        /// <summary>
        /// Updates the runtime version release notes. The runtime version must be in the ACTIVE
        /// state. The runtime version image is immutable. To change the runtime contents, create
        /// a new runtime version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRuntimeVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateRuntimeVersion service method, as returned by LambdaCore.</returns>
        /// <exception cref="Amazon.LambdaCore.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid. Check the error message for details
        /// about which parameter failed validation.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ResourceConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. For example, attempting to modify a resource that is not in a state that
        /// permits the operation.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ResourceNotFoundException">
        /// The specified resource does not exist. Verify the identifier and Region.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ServiceException">
        /// An internal service error occurred. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.TooManyRequestsException">
        /// The request was throttled due to exceeding the allowed request rate. Retry the request
        /// after a brief wait using exponential backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-core-2026-04-30/UpdateRuntimeVersion">REST API Reference for UpdateRuntimeVersion Operation</seealso>
        public virtual Task<UpdateRuntimeVersionResponse> UpdateRuntimeVersionAsync(UpdateRuntimeVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRuntimeVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRuntimeVersionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateRuntimeVersionResponse>(request, options, cancellationToken);
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
