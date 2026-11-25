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
using Amazon.ELBProxy.Model;
using Amazon.ELBProxy.Model.Internal.MarshallTransformations;
using Amazon.ELBProxy.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570

namespace Amazon.ELBProxy
{
    /// <summary>
    /// <para>Implementation for accessing ELBProxy</para>
    /// <para>
    /// Service client instances are thread-safe and can be shared across multiple threads.
    /// For a given service configuration, it is recommended to reuse a client instance
    /// for the lifetime of your application.
    /// </para>
    ///
    /// Elastic Load Balancing for Envoy is a fully managed service that runs the open-source
    /// Envoy proxy on your behalf. You bring your Envoy configuration, and AWS provisions
    /// the proxy, scales it, upgrades the Envoy version, patches the operating system, and
    /// monitors its health. The proxy runs on Amazon EC2 instances inside your own virtual
    /// private cloud (VPC), so you keep full control of your network, security groups, and
    /// IAM.
    /// </summary>
    public partial class AmazonELBProxyClient : AmazonServiceClient, IAmazonELBProxy
    {
        private static IServiceMetadata serviceMetadata = new AmazonELBProxyMetadata();
        private IELBProxyPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IELBProxyPaginatorFactory Paginators
        {
            get
            {
                if (this._paginators == null)
                {
                    this._paginators = new ELBProxyPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        /// <summary>
        /// Constructs AmazonELBProxyClient with the credentials loaded from the application's
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
        public AmazonELBProxyClient() : base(new AmazonELBProxyConfig()) { }

        /// <summary>
        /// Constructs AmazonELBProxyClient with the credentials loaded from the application's
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
        public AmazonELBProxyClient(RegionEndpoint region) : base(new AmazonELBProxyConfig { RegionEndpoint = region }) { }

        /// <summary>
        /// Constructs AmazonELBProxyClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonELBProxyClient Configuration Object</param>
        public AmazonELBProxyClient(AmazonELBProxyConfig config) : base(config) { }

        /// <summary>
        /// Constructs AmazonELBProxyClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonELBProxyClient(AWSCredentials credentials)
            : this(credentials, new AmazonELBProxyConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonELBProxyClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonELBProxyClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonELBProxyConfig { RegionEndpoint = region })
        {
        }

        /// <summary>
        /// Constructs AmazonELBProxyClient with AWS Credentials and an
        /// AmazonELBProxyClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonELBProxyClient Configuration Object</param>
        public AmazonELBProxyClient(AWSCredentials credentials, AmazonELBProxyConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonELBProxyClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonELBProxyClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonELBProxyConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonELBProxyClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonELBProxyClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonELBProxyConfig { RegionEndpoint = region })
        {
        }

        /// <summary>
        /// Constructs AmazonELBProxyClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonELBProxyClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonELBProxyClient Configuration Object</param>
        public AmazonELBProxyClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonELBProxyConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonELBProxyClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonELBProxyClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonELBProxyConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonELBProxyClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonELBProxyClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonELBProxyConfig { RegionEndpoint = region })
        {
        }

        /// <summary>
        /// Constructs AmazonELBProxyClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonELBProxyClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonELBProxyClient Configuration Object</param>
        public AmazonELBProxyClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonELBProxyConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonELBProxyEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonELBProxyAuthSchemeHandler());
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
        /// Associates an ACM certificate with the specified Proxy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateCertificate service method.</param>
        /// <returns>The response from the AssociateCertificate service method, as returned by ELBProxy.</returns>
        /// <exception cref="Amazon.ELBProxy.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elb-proxy-2026-11-20/AssociateCertificate">REST API Reference for AssociateCertificate Operation</seealso>
        public virtual AssociateCertificateResponse AssociateCertificate(AssociateCertificateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateCertificateResponseUnmarshaller.Instance;

            return Invoke<AssociateCertificateResponse>(request, options);
        }
#else
        internal virtual AssociateCertificateResponse AssociateCertificate(AssociateCertificateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateCertificateResponseUnmarshaller.Instance;

            return Invoke<AssociateCertificateResponse>(request, options);
        }
#endif

        /// <summary>
        /// Associates an ACM certificate with the specified Proxy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the AssociateCertificate service method, as returned by ELBProxy.</returns>
        /// <exception cref="Amazon.ELBProxy.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elb-proxy-2026-11-20/AssociateCertificate">REST API Reference for AssociateCertificate Operation</seealso>
        public virtual Task<AssociateCertificateResponse> AssociateCertificateAsync(AssociateCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateCertificateResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Creates a proxy. A proxy is a fully managed, Envoy-based proxy that runs your Envoy
        /// configuration on Amazon EC2 instances inside your own virtual private cloud (VPC).
        /// AWS provisions and scales the proxy, upgrades the Envoy version, patches the operating
        /// system, and monitors its health.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProxy service method.</param>
        /// <returns>The response from the CreateProxy service method, as returned by ELBProxy.</returns>
        /// <exception cref="Amazon.ELBProxy.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.OperationNotPermittedException">
        /// The requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elb-proxy-2026-11-20/CreateProxy">REST API Reference for CreateProxy Operation</seealso>
        public virtual CreateProxyResponse CreateProxy(CreateProxyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateProxyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProxyResponseUnmarshaller.Instance;

            return Invoke<CreateProxyResponse>(request, options);
        }
#else
        internal virtual CreateProxyResponse CreateProxy(CreateProxyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateProxyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProxyResponseUnmarshaller.Instance;

            return Invoke<CreateProxyResponse>(request, options);
        }
#endif

        /// <summary>
        /// Creates a proxy. A proxy is a fully managed, Envoy-based proxy that runs your Envoy
        /// configuration on Amazon EC2 instances inside your own virtual private cloud (VPC).
        /// AWS provisions and scales the proxy, upgrades the Envoy version, patches the operating
        /// system, and monitors its health.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProxy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateProxy service method, as returned by ELBProxy.</returns>
        /// <exception cref="Amazon.ELBProxy.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.OperationNotPermittedException">
        /// The requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elb-proxy-2026-11-20/CreateProxy">REST API Reference for CreateProxy Operation</seealso>
        public virtual Task<CreateProxyResponse> CreateProxyAsync(CreateProxyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateProxyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProxyResponseUnmarshaller.Instance;

            return InvokeAsync<CreateProxyResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Deletes a proxy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProxy service method.</param>
        /// <returns>The response from the DeleteProxy service method, as returned by ELBProxy.</returns>
        /// <exception cref="Amazon.ELBProxy.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.OperationNotPermittedException">
        /// The requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elb-proxy-2026-11-20/DeleteProxy">REST API Reference for DeleteProxy Operation</seealso>
        public virtual DeleteProxyResponse DeleteProxy(DeleteProxyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteProxyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProxyResponseUnmarshaller.Instance;

            return Invoke<DeleteProxyResponse>(request, options);
        }
#else
        internal virtual DeleteProxyResponse DeleteProxy(DeleteProxyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteProxyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProxyResponseUnmarshaller.Instance;

            return Invoke<DeleteProxyResponse>(request, options);
        }
#endif

        /// <summary>
        /// Deletes a proxy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProxy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteProxy service method, as returned by ELBProxy.</returns>
        /// <exception cref="Amazon.ELBProxy.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.OperationNotPermittedException">
        /// The requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elb-proxy-2026-11-20/DeleteProxy">REST API Reference for DeleteProxy Operation</seealso>
        public virtual Task<DeleteProxyResponse> DeleteProxyAsync(DeleteProxyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteProxyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProxyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteProxyResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Disassociates an ACM certificate from the specified proxy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateCertificate service method.</param>
        /// <returns>The response from the DisassociateCertificate service method, as returned by ELBProxy.</returns>
        /// <exception cref="Amazon.ELBProxy.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elb-proxy-2026-11-20/DisassociateCertificate">REST API Reference for DisassociateCertificate Operation</seealso>
        public virtual DisassociateCertificateResponse DisassociateCertificate(DisassociateCertificateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateCertificateResponseUnmarshaller.Instance;

            return Invoke<DisassociateCertificateResponse>(request, options);
        }
#else
        internal virtual DisassociateCertificateResponse DisassociateCertificate(DisassociateCertificateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateCertificateResponseUnmarshaller.Instance;

            return Invoke<DisassociateCertificateResponse>(request, options);
        }
#endif

        /// <summary>
        /// Disassociates an ACM certificate from the specified proxy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DisassociateCertificate service method, as returned by ELBProxy.</returns>
        /// <exception cref="Amazon.ELBProxy.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elb-proxy-2026-11-20/DisassociateCertificate">REST API Reference for DisassociateCertificate Operation</seealso>
        public virtual Task<DisassociateCertificateResponse> DisassociateCertificateAsync(DisassociateCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateCertificateResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves information about the specified proxy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProxy service method.</param>
        /// <returns>The response from the GetProxy service method, as returned by ELBProxy.</returns>
        /// <exception cref="Amazon.ELBProxy.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elb-proxy-2026-11-20/GetProxy">REST API Reference for GetProxy Operation</seealso>
        public virtual GetProxyResponse GetProxy(GetProxyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProxyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProxyResponseUnmarshaller.Instance;

            return Invoke<GetProxyResponse>(request, options);
        }
#else
        internal virtual GetProxyResponse GetProxy(GetProxyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProxyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProxyResponseUnmarshaller.Instance;

            return Invoke<GetProxyResponse>(request, options);
        }
#endif

        /// <summary>
        /// Retrieves information about the specified proxy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProxy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetProxy service method, as returned by ELBProxy.</returns>
        /// <exception cref="Amazon.ELBProxy.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elb-proxy-2026-11-20/GetProxy">REST API Reference for GetProxy Operation</seealso>
        public virtual Task<GetProxyResponse> GetProxyAsync(GetProxyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProxyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProxyResponseUnmarshaller.Instance;

            return InvokeAsync<GetProxyResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves the attributes for the specified proxy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProxyAttributes service method.</param>
        /// <returns>The response from the GetProxyAttributes service method, as returned by ELBProxy.</returns>
        /// <exception cref="Amazon.ELBProxy.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elb-proxy-2026-11-20/GetProxyAttributes">REST API Reference for GetProxyAttributes Operation</seealso>
        public virtual GetProxyAttributesResponse GetProxyAttributes(GetProxyAttributesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProxyAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProxyAttributesResponseUnmarshaller.Instance;

            return Invoke<GetProxyAttributesResponse>(request, options);
        }
#else
        internal virtual GetProxyAttributesResponse GetProxyAttributes(GetProxyAttributesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProxyAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProxyAttributesResponseUnmarshaller.Instance;

            return Invoke<GetProxyAttributesResponse>(request, options);
        }
#endif

        /// <summary>
        /// Retrieves the attributes for the specified proxy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProxyAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetProxyAttributes service method, as returned by ELBProxy.</returns>
        /// <exception cref="Amazon.ELBProxy.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elb-proxy-2026-11-20/GetProxyAttributes">REST API Reference for GetProxyAttributes Operation</seealso>
        public virtual Task<GetProxyAttributesResponse> GetProxyAttributesAsync(GetProxyAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProxyAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProxyAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<GetProxyAttributesResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves the configuration file, the configuration archive, or both for the specified
        /// proxy. This operation is separate from GetProxy so that you can grant access to proxy
        /// metadata without granting access to the configuration content.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProxyConfigurationContents service method.</param>
        /// <returns>The response from the GetProxyConfigurationContents service method, as returned by ELBProxy.</returns>
        /// <exception cref="Amazon.ELBProxy.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elb-proxy-2026-11-20/GetProxyConfigurationContents">REST API Reference for GetProxyConfigurationContents Operation</seealso>
        public virtual GetProxyConfigurationContentsResponse GetProxyConfigurationContents(GetProxyConfigurationContentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProxyConfigurationContentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProxyConfigurationContentsResponseUnmarshaller.Instance;

            return Invoke<GetProxyConfigurationContentsResponse>(request, options);
        }
#else
        internal virtual GetProxyConfigurationContentsResponse GetProxyConfigurationContents(GetProxyConfigurationContentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProxyConfigurationContentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProxyConfigurationContentsResponseUnmarshaller.Instance;

            return Invoke<GetProxyConfigurationContentsResponse>(request, options);
        }
#endif

        /// <summary>
        /// Retrieves the configuration file, the configuration archive, or both for the specified
        /// proxy. This operation is separate from GetProxy so that you can grant access to proxy
        /// metadata without granting access to the configuration content.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProxyConfigurationContents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetProxyConfigurationContents service method, as returned by ELBProxy.</returns>
        /// <exception cref="Amazon.ELBProxy.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elb-proxy-2026-11-20/GetProxyConfigurationContents">REST API Reference for GetProxyConfigurationContents Operation</seealso>
        public virtual Task<GetProxyConfigurationContentsResponse> GetProxyConfigurationContentsAsync(GetProxyConfigurationContentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProxyConfigurationContentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProxyConfigurationContentsResponseUnmarshaller.Instance;

            return InvokeAsync<GetProxyConfigurationContentsResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves information about the specified proxy update.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProxyUpdate service method.</param>
        /// <returns>The response from the GetProxyUpdate service method, as returned by ELBProxy.</returns>
        /// <exception cref="Amazon.ELBProxy.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elb-proxy-2026-11-20/GetProxyUpdate">REST API Reference for GetProxyUpdate Operation</seealso>
        public virtual GetProxyUpdateResponse GetProxyUpdate(GetProxyUpdateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProxyUpdateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProxyUpdateResponseUnmarshaller.Instance;

            return Invoke<GetProxyUpdateResponse>(request, options);
        }
#else
        internal virtual GetProxyUpdateResponse GetProxyUpdate(GetProxyUpdateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProxyUpdateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProxyUpdateResponseUnmarshaller.Instance;

            return Invoke<GetProxyUpdateResponse>(request, options);
        }
#endif

        /// <summary>
        /// Retrieves information about the specified proxy update.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProxyUpdate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetProxyUpdate service method, as returned by ELBProxy.</returns>
        /// <exception cref="Amazon.ELBProxy.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elb-proxy-2026-11-20/GetProxyUpdate">REST API Reference for GetProxyUpdate Operation</seealso>
        public virtual Task<GetProxyUpdateResponse> GetProxyUpdateAsync(GetProxyUpdateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProxyUpdateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProxyUpdateResponseUnmarshaller.Instance;

            return InvokeAsync<GetProxyUpdateResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Lists the ACM certificate associations for the specified proxy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCertificateAssociations service method.</param>
        /// <returns>The response from the ListCertificateAssociations service method, as returned by ELBProxy.</returns>
        /// <exception cref="Amazon.ELBProxy.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elb-proxy-2026-11-20/ListCertificateAssociations">REST API Reference for ListCertificateAssociations Operation</seealso>
        public virtual ListCertificateAssociationsResponse ListCertificateAssociations(ListCertificateAssociationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCertificateAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCertificateAssociationsResponseUnmarshaller.Instance;

            return Invoke<ListCertificateAssociationsResponse>(request, options);
        }
#else
        internal virtual ListCertificateAssociationsResponse ListCertificateAssociations(ListCertificateAssociationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCertificateAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCertificateAssociationsResponseUnmarshaller.Instance;

            return Invoke<ListCertificateAssociationsResponse>(request, options);
        }
#endif

        /// <summary>
        /// Lists the ACM certificate associations for the specified proxy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCertificateAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListCertificateAssociations service method, as returned by ELBProxy.</returns>
        /// <exception cref="Amazon.ELBProxy.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elb-proxy-2026-11-20/ListCertificateAssociations">REST API Reference for ListCertificateAssociations Operation</seealso>
        public virtual Task<ListCertificateAssociationsResponse> ListCertificateAssociationsAsync(ListCertificateAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCertificateAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCertificateAssociationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListCertificateAssociationsResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Lists the proxies owned by the caller account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProxies service method.</param>
        /// <returns>The response from the ListProxies service method, as returned by ELBProxy.</returns>
        /// <exception cref="Amazon.ELBProxy.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elb-proxy-2026-11-20/ListProxies">REST API Reference for ListProxies Operation</seealso>
        public virtual ListProxiesResponse ListProxies(ListProxiesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProxiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProxiesResponseUnmarshaller.Instance;

            return Invoke<ListProxiesResponse>(request, options);
        }
#else
        internal virtual ListProxiesResponse ListProxies(ListProxiesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProxiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProxiesResponseUnmarshaller.Instance;

            return Invoke<ListProxiesResponse>(request, options);
        }
#endif

        /// <summary>
        /// Lists the proxies owned by the caller account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProxies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListProxies service method, as returned by ELBProxy.</returns>
        /// <exception cref="Amazon.ELBProxy.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elb-proxy-2026-11-20/ListProxies">REST API Reference for ListProxies Operation</seealso>
        public virtual Task<ListProxiesResponse> ListProxiesAsync(ListProxiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProxiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProxiesResponseUnmarshaller.Instance;

            return InvokeAsync<ListProxiesResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Lists the updates for the specified proxy, most recently submitted first.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProxyUpdates service method.</param>
        /// <returns>The response from the ListProxyUpdates service method, as returned by ELBProxy.</returns>
        /// <exception cref="Amazon.ELBProxy.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elb-proxy-2026-11-20/ListProxyUpdates">REST API Reference for ListProxyUpdates Operation</seealso>
        public virtual ListProxyUpdatesResponse ListProxyUpdates(ListProxyUpdatesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProxyUpdatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProxyUpdatesResponseUnmarshaller.Instance;

            return Invoke<ListProxyUpdatesResponse>(request, options);
        }
#else
        internal virtual ListProxyUpdatesResponse ListProxyUpdates(ListProxyUpdatesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProxyUpdatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProxyUpdatesResponseUnmarshaller.Instance;

            return Invoke<ListProxyUpdatesResponse>(request, options);
        }
#endif

        /// <summary>
        /// Lists the updates for the specified proxy, most recently submitted first.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProxyUpdates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListProxyUpdates service method, as returned by ELBProxy.</returns>
        /// <exception cref="Amazon.ELBProxy.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elb-proxy-2026-11-20/ListProxyUpdates">REST API Reference for ListProxyUpdates Operation</seealso>
        public virtual Task<ListProxyUpdatesResponse> ListProxyUpdatesAsync(ListProxyUpdatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProxyUpdatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProxyUpdatesResponseUnmarshaller.Instance;

            return InvokeAsync<ListProxyUpdatesResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Lists the available proxy versions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProxyVersions service method.</param>
        /// <returns>The response from the ListProxyVersions service method, as returned by ELBProxy.</returns>
        /// <exception cref="Amazon.ELBProxy.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elb-proxy-2026-11-20/ListProxyVersions">REST API Reference for ListProxyVersions Operation</seealso>
        public virtual ListProxyVersionsResponse ListProxyVersions(ListProxyVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProxyVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProxyVersionsResponseUnmarshaller.Instance;

            return Invoke<ListProxyVersionsResponse>(request, options);
        }
#else
        internal virtual ListProxyVersionsResponse ListProxyVersions(ListProxyVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProxyVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProxyVersionsResponseUnmarshaller.Instance;

            return Invoke<ListProxyVersionsResponse>(request, options);
        }
#endif

        /// <summary>
        /// Lists the available proxy versions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProxyVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListProxyVersions service method, as returned by ELBProxy.</returns>
        /// <exception cref="Amazon.ELBProxy.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elb-proxy-2026-11-20/ListProxyVersions">REST API Reference for ListProxyVersions Operation</seealso>
        public virtual Task<ListProxyVersionsResponse> ListProxyVersionsAsync(ListProxyVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProxyVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProxyVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListProxyVersionsResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Lists the tags for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <returns>The response from the ListTagsForResource service method, as returned by ELBProxy.</returns>
        /// <exception cref="Amazon.ELBProxy.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elb-proxy-2026-11-20/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }
#else
        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }
#endif

        /// <summary>
        /// Lists the tags for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListTagsForResource service method, as returned by ELBProxy.</returns>
        /// <exception cref="Amazon.ELBProxy.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elb-proxy-2026-11-20/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Adds the specified tags to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <returns>The response from the TagResource service method, as returned by ELBProxy.</returns>
        /// <exception cref="Amazon.ELBProxy.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elb-proxy-2026-11-20/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }
#else
        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }
#endif

        /// <summary>
        /// Adds the specified tags to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the TagResource service method, as returned by ELBProxy.</returns>
        /// <exception cref="Amazon.ELBProxy.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elb-proxy-2026-11-20/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Removes the specified tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <returns>The response from the UntagResource service method, as returned by ELBProxy.</returns>
        /// <exception cref="Amazon.ELBProxy.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elb-proxy-2026-11-20/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }
#else
        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }
#endif

        /// <summary>
        /// Removes the specified tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UntagResource service method, as returned by ELBProxy.</returns>
        /// <exception cref="Amazon.ELBProxy.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elb-proxy-2026-11-20/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Updates the attributes for the specified proxy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProxyAttributes service method.</param>
        /// <returns>The response from the UpdateProxyAttributes service method, as returned by ELBProxy.</returns>
        /// <exception cref="Amazon.ELBProxy.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elb-proxy-2026-11-20/UpdateProxyAttributes">REST API Reference for UpdateProxyAttributes Operation</seealso>
        public virtual UpdateProxyAttributesResponse UpdateProxyAttributes(UpdateProxyAttributesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateProxyAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProxyAttributesResponseUnmarshaller.Instance;

            return Invoke<UpdateProxyAttributesResponse>(request, options);
        }
#else
        internal virtual UpdateProxyAttributesResponse UpdateProxyAttributes(UpdateProxyAttributesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateProxyAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProxyAttributesResponseUnmarshaller.Instance;

            return Invoke<UpdateProxyAttributesResponse>(request, options);
        }
#endif

        /// <summary>
        /// Updates the attributes for the specified proxy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProxyAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateProxyAttributes service method, as returned by ELBProxy.</returns>
        /// <exception cref="Amazon.ELBProxy.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elb-proxy-2026-11-20/UpdateProxyAttributes">REST API Reference for UpdateProxyAttributes Operation</seealso>
        public virtual Task<UpdateProxyAttributesResponse> UpdateProxyAttributesAsync(UpdateProxyAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateProxyAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProxyAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateProxyAttributesResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Updates the configuration for the specified proxy. You can update the configuration
        /// file, the configuration archive, or both.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProxyConfiguration service method.</param>
        /// <returns>The response from the UpdateProxyConfiguration service method, as returned by ELBProxy.</returns>
        /// <exception cref="Amazon.ELBProxy.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.PriorRequestNotCompletedException">
        /// The request could not be completed because a prior request has not yet completed.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elb-proxy-2026-11-20/UpdateProxyConfiguration">REST API Reference for UpdateProxyConfiguration Operation</seealso>
        public virtual UpdateProxyConfigurationResponse UpdateProxyConfiguration(UpdateProxyConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateProxyConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProxyConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateProxyConfigurationResponse>(request, options);
        }
#else
        internal virtual UpdateProxyConfigurationResponse UpdateProxyConfiguration(UpdateProxyConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateProxyConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProxyConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateProxyConfigurationResponse>(request, options);
        }
#endif

        /// <summary>
        /// Updates the configuration for the specified proxy. You can update the configuration
        /// file, the configuration archive, or both.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProxyConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateProxyConfiguration service method, as returned by ELBProxy.</returns>
        /// <exception cref="Amazon.ELBProxy.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.PriorRequestNotCompletedException">
        /// The request could not be completed because a prior request has not yet completed.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elb-proxy-2026-11-20/UpdateProxyConfiguration">REST API Reference for UpdateProxyConfiguration Operation</seealso>
        public virtual Task<UpdateProxyConfigurationResponse> UpdateProxyConfigurationAsync(UpdateProxyConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateProxyConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProxyConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateProxyConfigurationResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Updates the network configuration for the specified proxy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProxyNetworkConfiguration service method.</param>
        /// <returns>The response from the UpdateProxyNetworkConfiguration service method, as returned by ELBProxy.</returns>
        /// <exception cref="Amazon.ELBProxy.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elb-proxy-2026-11-20/UpdateProxyNetworkConfiguration">REST API Reference for UpdateProxyNetworkConfiguration Operation</seealso>
        public virtual UpdateProxyNetworkConfigurationResponse UpdateProxyNetworkConfiguration(UpdateProxyNetworkConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateProxyNetworkConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProxyNetworkConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateProxyNetworkConfigurationResponse>(request, options);
        }
#else
        internal virtual UpdateProxyNetworkConfigurationResponse UpdateProxyNetworkConfiguration(UpdateProxyNetworkConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateProxyNetworkConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProxyNetworkConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateProxyNetworkConfigurationResponse>(request, options);
        }
#endif

        /// <summary>
        /// Updates the network configuration for the specified proxy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProxyNetworkConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateProxyNetworkConfiguration service method, as returned by ELBProxy.</returns>
        /// <exception cref="Amazon.ELBProxy.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elb-proxy-2026-11-20/UpdateProxyNetworkConfiguration">REST API Reference for UpdateProxyNetworkConfiguration Operation</seealso>
        public virtual Task<UpdateProxyNetworkConfigurationResponse> UpdateProxyNetworkConfigurationAsync(UpdateProxyNetworkConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateProxyNetworkConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProxyNetworkConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateProxyNetworkConfigurationResponse>(request, options, cancellationToken);
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
