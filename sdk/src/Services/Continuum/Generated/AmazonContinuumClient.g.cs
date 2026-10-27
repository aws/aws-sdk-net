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
using Amazon.Continuum.Model;
using Amazon.Continuum.Model.Internal.MarshallTransformations;
using Amazon.Continuum.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570

namespace Amazon.Continuum
{
    /// <summary>
    /// <para>Implementation for accessing Continuum</para>
    /// <para>
    /// Service client instances are thread-safe and can be shared across multiple threads.
    /// For a given service configuration, it is recommended to reuse a client instance
    /// for the lifetime of your application.
    /// </para>
    ///
    /// AWS Continuum finds, validates, prioritizes, and remediates code vulnerabilities across
    /// the source repositories and AWS resources in your environments.
    /// </summary>
    public partial class AmazonContinuumClient : AmazonServiceClient, IAmazonContinuum
    {
        private static IServiceMetadata serviceMetadata = new AmazonContinuumMetadata();
        private IContinuumPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IContinuumPaginatorFactory Paginators
        {
            get
            {
                if (this._paginators == null)
                {
                    this._paginators = new ContinuumPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        /// <summary>
        /// Constructs AmazonContinuumClient with the credentials loaded from the application's
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
        public AmazonContinuumClient() : base(new AmazonContinuumConfig()) { }

        /// <summary>
        /// Constructs AmazonContinuumClient with the credentials loaded from the application's
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
        public AmazonContinuumClient(RegionEndpoint region) : base(new AmazonContinuumConfig { RegionEndpoint = region }) { }

        /// <summary>
        /// Constructs AmazonContinuumClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonContinuumClient Configuration Object</param>
        public AmazonContinuumClient(AmazonContinuumConfig config) : base(config) { }

        /// <summary>
        /// Constructs AmazonContinuumClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonContinuumClient(AWSCredentials credentials)
            : this(credentials, new AmazonContinuumConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonContinuumClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonContinuumClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonContinuumConfig { RegionEndpoint = region })
        {
        }

        /// <summary>
        /// Constructs AmazonContinuumClient with AWS Credentials and an
        /// AmazonContinuumClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonContinuumClient Configuration Object</param>
        public AmazonContinuumClient(AWSCredentials credentials, AmazonContinuumConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonContinuumClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonContinuumClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonContinuumConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonContinuumClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonContinuumClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonContinuumConfig { RegionEndpoint = region })
        {
        }

        /// <summary>
        /// Constructs AmazonContinuumClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonContinuumClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonContinuumClient Configuration Object</param>
        public AmazonContinuumClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonContinuumConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonContinuumClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonContinuumClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonContinuumConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonContinuumClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonContinuumClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonContinuumConfig { RegionEndpoint = region })
        {
        }

        /// <summary>
        /// Constructs AmazonContinuumClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonContinuumClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonContinuumClient Configuration Object</param>
        public AmazonContinuumClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonContinuumConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonContinuumEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonContinuumAuthSchemeHandler());
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
        /// Associates one Collector with this Environment and configures the customer role Continuum
        /// uses to authorize access to associated Collector data. The caller must have permission
        /// on the Environment and permission to pass the role. Continuum assumes the supplied
        /// role and calls GetCollectorDataAccessAuthorization on the requested Collector; only
        /// a successful authorization response permits the association. The caller does not need
        /// Collector data-access permission. The Environment retains its other Collector associations.
        /// Calling again with an existing association is safe and does not create a duplicate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateCollector service method.</param>
        /// <returns>The response from the AssociateCollector service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/AssociateCollector">REST API Reference for AssociateCollector Operation</seealso>
        public virtual AssociateCollectorResponse AssociateCollector(AssociateCollectorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateCollectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateCollectorResponseUnmarshaller.Instance;

            return Invoke<AssociateCollectorResponse>(request, options);
        }
#else
        internal virtual AssociateCollectorResponse AssociateCollector(AssociateCollectorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateCollectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateCollectorResponseUnmarshaller.Instance;

            return Invoke<AssociateCollectorResponse>(request, options);
        }
#endif

        /// <summary>
        /// Associates one Collector with this Environment and configures the customer role Continuum
        /// uses to authorize access to associated Collector data. The caller must have permission
        /// on the Environment and permission to pass the role. Continuum assumes the supplied
        /// role and calls GetCollectorDataAccessAuthorization on the requested Collector; only
        /// a successful authorization response permits the association. The caller does not need
        /// Collector data-access permission. The Environment retains its other Collector associations.
        /// Calling again with an existing association is safe and does not create a duplicate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateCollector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the AssociateCollector service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/AssociateCollector">REST API Reference for AssociateCollector Operation</seealso>
        public virtual Task<AssociateCollectorResponse> AssociateCollectorAsync(AssociateCollectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateCollectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateCollectorResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateCollectorResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Ingests a customer-supplied security finding into an environment. Continuum validates
        /// the document synchronously against the required overlay fields for the declared format;
        /// invalid documents are rejected with a ValidationException. The maximum accepted document
        /// size is 256 KB. The environment must have a source configured, and the finding must
        /// identify a code location so Continuum can tie it to a repository in the environment's
        /// build. Continuum assigns a findingId and stores the verbatim document. When no successful
        /// build yet contains the finding's repository, the finding stays SUBMITTED until the
        /// next successful build; if that build does not contain it either, the finding is DISCARDED
        /// with discardReason SOURCE_REPO_NOT_FOUND.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCodeFinding service method.</param>
        /// <returns>The response from the CreateCodeFinding service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/CreateCodeFinding">REST API Reference for CreateCodeFinding Operation</seealso>
        public virtual CreateCodeFindingResponse CreateCodeFinding(CreateCodeFindingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCodeFindingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCodeFindingResponseUnmarshaller.Instance;

            return Invoke<CreateCodeFindingResponse>(request, options);
        }
#else
        internal virtual CreateCodeFindingResponse CreateCodeFinding(CreateCodeFindingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCodeFindingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCodeFindingResponseUnmarshaller.Instance;

            return Invoke<CreateCodeFindingResponse>(request, options);
        }
#endif

        /// <summary>
        /// Ingests a customer-supplied security finding into an environment. Continuum validates
        /// the document synchronously against the required overlay fields for the declared format;
        /// invalid documents are rejected with a ValidationException. The maximum accepted document
        /// size is 256 KB. The environment must have a source configured, and the finding must
        /// identify a code location so Continuum can tie it to a repository in the environment's
        /// build. Continuum assigns a findingId and stores the verbatim document. When no successful
        /// build yet contains the finding's repository, the finding stays SUBMITTED until the
        /// next successful build; if that build does not contain it either, the finding is DISCARDED
        /// with discardReason SOURCE_REPO_NOT_FOUND.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCodeFinding service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateCodeFinding service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/CreateCodeFinding">REST API Reference for CreateCodeFinding Operation</seealso>
        public virtual Task<CreateCodeFindingResponse> CreateCodeFindingAsync(CreateCodeFindingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCodeFindingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCodeFindingResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCodeFindingResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Creates an explicit scan request for one environment. CP creates durable work before
        /// any queue delivery occurs. Retrying a request that succeeded, with the same clientToken
        /// on the same environment, returns the original scan instead of starting another one.
        /// Token handling is not yet atomic: requests with the same token that run at the same
        /// time, or a retry after a request that failed partway through, can leave an additional
        /// scan, which may end in the FAILED state with a message that it was superseded. Deleting
        /// the environment makes its tokens unusable; a later request with one of them returns
        /// ResourceNotFoundException. Each environment can have a limited number of scans in
        /// progress at the same time. Once that limit is enforced, a request that would exceed
        /// it returns ServiceQuotaExceededException; wait for a scan to finish (ListCodeScans
        /// shows each scan's status), then retry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCodeScan service method.</param>
        /// <returns>The response from the CreateCodeScan service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota. Review your quota and request an increase
        /// if needed.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/CreateCodeScan">REST API Reference for CreateCodeScan Operation</seealso>
        public virtual CreateCodeScanResponse CreateCodeScan(CreateCodeScanRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCodeScanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCodeScanResponseUnmarshaller.Instance;

            return Invoke<CreateCodeScanResponse>(request, options);
        }
#else
        internal virtual CreateCodeScanResponse CreateCodeScan(CreateCodeScanRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCodeScanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCodeScanResponseUnmarshaller.Instance;

            return Invoke<CreateCodeScanResponse>(request, options);
        }
#endif

        /// <summary>
        /// Creates an explicit scan request for one environment. CP creates durable work before
        /// any queue delivery occurs. Retrying a request that succeeded, with the same clientToken
        /// on the same environment, returns the original scan instead of starting another one.
        /// Token handling is not yet atomic: requests with the same token that run at the same
        /// time, or a retry after a request that failed partway through, can leave an additional
        /// scan, which may end in the FAILED state with a message that it was superseded. Deleting
        /// the environment makes its tokens unusable; a later request with one of them returns
        /// ResourceNotFoundException. Each environment can have a limited number of scans in
        /// progress at the same time. Once that limit is enforced, a request that would exceed
        /// it returns ServiceQuotaExceededException; wait for a scan to finish (ListCodeScans
        /// shows each scan's status), then retry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCodeScan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateCodeScan service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota. Review your quota and request an increase
        /// if needed.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/CreateCodeScan">REST API Reference for CreateCodeScan Operation</seealso>
        public virtual Task<CreateCodeScanResponse> CreateCodeScanAsync(CreateCodeScanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCodeScanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCodeScanResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCodeScanResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Creates the Collector for the caller's account. Provisions an AWS Config service-linked
        /// recorder using the caller's federated access session and begins recording infrastructure
        /// changes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCollector service method.</param>
        /// <returns>The response from the CreateCollector service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota. Review your quota and request an increase
        /// if needed.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/CreateCollector">REST API Reference for CreateCollector Operation</seealso>
        public virtual CreateCollectorResponse CreateCollector(CreateCollectorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCollectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCollectorResponseUnmarshaller.Instance;

            return Invoke<CreateCollectorResponse>(request, options);
        }
#else
        internal virtual CreateCollectorResponse CreateCollector(CreateCollectorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCollectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCollectorResponseUnmarshaller.Instance;

            return Invoke<CreateCollectorResponse>(request, options);
        }
#endif

        /// <summary>
        /// Creates the Collector for the caller's account. Provisions an AWS Config service-linked
        /// recorder using the caller's federated access session and begins recording infrastructure
        /// changes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCollector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateCollector service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota. Review your quota and request an increase
        /// if needed.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/CreateCollector">REST API Reference for CreateCollector Operation</seealso>
        public virtual Task<CreateCollectorResponse> CreateCollectorAsync(CreateCollectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCollectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCollectorResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCollectorResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Creates an environment and starts its validation and any requested provisioning. Storage
        /// provisioning and dependency checks may continue after the initial 201 response; use
        /// GetEnvironment to observe completion.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEnvironment service method.</param>
        /// <returns>The response from the CreateEnvironment service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota. Review your quota and request an increase
        /// if needed.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/CreateEnvironment">REST API Reference for CreateEnvironment Operation</seealso>
        public virtual CreateEnvironmentResponse CreateEnvironment(CreateEnvironmentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEnvironmentResponseUnmarshaller.Instance;

            return Invoke<CreateEnvironmentResponse>(request, options);
        }
#else
        internal virtual CreateEnvironmentResponse CreateEnvironment(CreateEnvironmentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEnvironmentResponseUnmarshaller.Instance;

            return Invoke<CreateEnvironmentResponse>(request, options);
        }
#endif

        /// <summary>
        /// Creates an environment and starts its validation and any requested provisioning. Storage
        /// provisioning and dependency checks may continue after the initial 201 response; use
        /// GetEnvironment to observe completion.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateEnvironment service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota. Review your quota and request an increase
        /// if needed.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/CreateEnvironment">REST API Reference for CreateEnvironment Operation</seealso>
        public virtual Task<CreateEnvironmentResponse> CreateEnvironmentAsync(CreateEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEnvironmentResponseUnmarshaller.Instance;

            return InvokeAsync<CreateEnvironmentResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Creates a new integration with an external source provider. Repeating an identical
        /// request with the same clientToken returns the original integrationId, integrationArn,
        /// and createdAt. Token records are retained for eight hours after success or terminal
        /// failure, including after the integration is deleted; replaying a deleted integration's
        /// token does not recreate it. An identical request with a retained terminal failure
        /// returns the recorded error. Reusing a token with different parameters returns ValidationException.
        /// A fresh token starts a new create attempt; if the name is already owned by another
        /// integration, ConflictException includes that integration's identifier. An attempt
        /// still in progress may return ThrottlingException with retryAfterSeconds set to 1;
        /// retry with the same token and identical parameters. GitHub authorization codes are
        /// single use. Retry an unresolved attempt with its original token and unchanged parameters
        /// first. If the service reports a terminal failure, an expired attempt, or a successful
        /// token exchange whose integration could not be saved, restart GitHub authorization
        /// with a fresh token and authorization code. The service does not checkpoint provider
        /// results for recovery by another request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIntegration service method.</param>
        /// <returns>The response from the CreateIntegration service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota. Review your quota and request an increase
        /// if needed.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/CreateIntegration">REST API Reference for CreateIntegration Operation</seealso>
        public virtual CreateIntegrationResponse CreateIntegration(CreateIntegrationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIntegrationResponseUnmarshaller.Instance;

            return Invoke<CreateIntegrationResponse>(request, options);
        }
#else
        internal virtual CreateIntegrationResponse CreateIntegration(CreateIntegrationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIntegrationResponseUnmarshaller.Instance;

            return Invoke<CreateIntegrationResponse>(request, options);
        }
#endif

        /// <summary>
        /// Creates a new integration with an external source provider. Repeating an identical
        /// request with the same clientToken returns the original integrationId, integrationArn,
        /// and createdAt. Token records are retained for eight hours after success or terminal
        /// failure, including after the integration is deleted; replaying a deleted integration's
        /// token does not recreate it. An identical request with a retained terminal failure
        /// returns the recorded error. Reusing a token with different parameters returns ValidationException.
        /// A fresh token starts a new create attempt; if the name is already owned by another
        /// integration, ConflictException includes that integration's identifier. An attempt
        /// still in progress may return ThrottlingException with retryAfterSeconds set to 1;
        /// retry with the same token and identical parameters. GitHub authorization codes are
        /// single use. Retry an unresolved attempt with its original token and unchanged parameters
        /// first. If the service reports a terminal failure, an expired attempt, or a successful
        /// token exchange whose integration could not be saved, restart GitHub authorization
        /// with a fresh token and authorization code. The service does not checkpoint provider
        /// results for recovery by another request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateIntegration service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota. Review your quota and request an increase
        /// if needed.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/CreateIntegration">REST API Reference for CreateIntegration Operation</seealso>
        public virtual Task<CreateIntegrationResponse> CreateIntegrationAsync(CreateIntegrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIntegrationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateIntegrationResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Deletes the Collector for the caller's account. The Collector first enters PENDING_DELETION,
        /// then the service removes its schedule, AWS Config service-linked recorder, versioned
        /// S3 bucket, KMS key, and persisted record.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCollector service method.</param>
        /// <returns>The response from the DeleteCollector service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/DeleteCollector">REST API Reference for DeleteCollector Operation</seealso>
        public virtual DeleteCollectorResponse DeleteCollector(DeleteCollectorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCollectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCollectorResponseUnmarshaller.Instance;

            return Invoke<DeleteCollectorResponse>(request, options);
        }
#else
        internal virtual DeleteCollectorResponse DeleteCollector(DeleteCollectorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCollectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCollectorResponseUnmarshaller.Instance;

            return Invoke<DeleteCollectorResponse>(request, options);
        }
#endif

        /// <summary>
        /// Deletes the Collector for the caller's account. The Collector first enters PENDING_DELETION,
        /// then the service removes its schedule, AWS Config service-linked recorder, versioned
        /// S3 bucket, KMS key, and persisted record.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCollector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteCollector service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/DeleteCollector">REST API Reference for DeleteCollector Operation</seealso>
        public virtual Task<DeleteCollectorResponse> DeleteCollectorAsync(DeleteCollectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCollectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCollectorResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCollectorResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Deletes an environment and its associated resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironment service method.</param>
        /// <returns>The response from the DeleteEnvironment service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/DeleteEnvironment">REST API Reference for DeleteEnvironment Operation</seealso>
        public virtual DeleteEnvironmentResponse DeleteEnvironment(DeleteEnvironmentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEnvironmentResponseUnmarshaller.Instance;

            return Invoke<DeleteEnvironmentResponse>(request, options);
        }
#else
        internal virtual DeleteEnvironmentResponse DeleteEnvironment(DeleteEnvironmentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEnvironmentResponseUnmarshaller.Instance;

            return Invoke<DeleteEnvironmentResponse>(request, options);
        }
#endif

        /// <summary>
        /// Deletes an environment and its associated resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteEnvironment service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/DeleteEnvironment">REST API Reference for DeleteEnvironment Operation</seealso>
        public virtual Task<DeleteEnvironmentResponse> DeleteEnvironmentAsync(DeleteEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEnvironmentResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteEnvironmentResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Deletes an integration and releases its name and account quota. Its retained CreateIntegration
        /// token receipt can still replay the original result without recreating the integration.
        /// Shared provider registrations are retained: deleting one integration does not remove
        /// provider access used by another integration. A fresh GitHub CreateIntegration attempt
        /// requires a fresh OAuth authorization code and a new clientToken.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIntegration service method.</param>
        /// <returns>The response from the DeleteIntegration service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/DeleteIntegration">REST API Reference for DeleteIntegration Operation</seealso>
        public virtual DeleteIntegrationResponse DeleteIntegration(DeleteIntegrationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIntegrationResponseUnmarshaller.Instance;

            return Invoke<DeleteIntegrationResponse>(request, options);
        }
#else
        internal virtual DeleteIntegrationResponse DeleteIntegration(DeleteIntegrationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIntegrationResponseUnmarshaller.Instance;

            return Invoke<DeleteIntegrationResponse>(request, options);
        }
#endif

        /// <summary>
        /// Deletes an integration and releases its name and account quota. Its retained CreateIntegration
        /// token receipt can still replay the original result without recreating the integration.
        /// Shared provider registrations are retained: deleting one integration does not remove
        /// provider access used by another integration. A fresh GitHub CreateIntegration attempt
        /// requires a fresh OAuth authorization code and a new clientToken.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteIntegration service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/DeleteIntegration">REST API Reference for DeleteIntegration Operation</seealso>
        public virtual Task<DeleteIntegrationResponse> DeleteIntegrationAsync(DeleteIntegrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIntegrationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteIntegrationResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Removes one Collector association from this Environment, preserving its other associations.
        /// The stored Collector data-access role is cleared when no Collector associations remain.
        /// The Environment owner must have permission to disassociate. A current Collector access
        /// grant is not required, and the Collector does not need to remain active or present,
        /// so stale or revoked associations can be cleaned up.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateCollector service method.</param>
        /// <returns>The response from the DisassociateCollector service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/DisassociateCollector">REST API Reference for DisassociateCollector Operation</seealso>
        public virtual DisassociateCollectorResponse DisassociateCollector(DisassociateCollectorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateCollectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateCollectorResponseUnmarshaller.Instance;

            return Invoke<DisassociateCollectorResponse>(request, options);
        }
#else
        internal virtual DisassociateCollectorResponse DisassociateCollector(DisassociateCollectorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateCollectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateCollectorResponseUnmarshaller.Instance;

            return Invoke<DisassociateCollectorResponse>(request, options);
        }
#endif

        /// <summary>
        /// Removes one Collector association from this Environment, preserving its other associations.
        /// The stored Collector data-access role is cleared when no Collector associations remain.
        /// The Environment owner must have permission to disassociate. A current Collector access
        /// grant is not required, and the Collector does not need to remain active or present,
        /// so stale or revoked associations can be cleaned up.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateCollector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DisassociateCollector service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/DisassociateCollector">REST API Reference for DisassociateCollector Operation</seealso>
        public virtual Task<DisassociateCollectorResponse> DisassociateCollectorAsync(DisassociateCollectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateCollectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateCollectorResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateCollectorResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves the current state and details of a finding.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCodeFinding service method.</param>
        /// <returns>The response from the GetCodeFinding service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/GetCodeFinding">REST API Reference for GetCodeFinding Operation</seealso>
        public virtual GetCodeFindingResponse GetCodeFinding(GetCodeFindingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCodeFindingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCodeFindingResponseUnmarshaller.Instance;

            return Invoke<GetCodeFindingResponse>(request, options);
        }
#else
        internal virtual GetCodeFindingResponse GetCodeFinding(GetCodeFindingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCodeFindingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCodeFindingResponseUnmarshaller.Instance;

            return Invoke<GetCodeFindingResponse>(request, options);
        }
#endif

        /// <summary>
        /// Retrieves the current state and details of a finding.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCodeFinding service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetCodeFinding service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/GetCodeFinding">REST API Reference for GetCodeFinding Operation</seealso>
        public virtual Task<GetCodeFindingResponse> GetCodeFindingAsync(GetCodeFindingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCodeFindingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCodeFindingResponseUnmarshaller.Instance;

            return InvokeAsync<GetCodeFindingResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves the current state and details of an issue.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCodeIssue service method.</param>
        /// <returns>The response from the GetCodeIssue service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/GetCodeIssue">REST API Reference for GetCodeIssue Operation</seealso>
        public virtual GetCodeIssueResponse GetCodeIssue(GetCodeIssueRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCodeIssueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCodeIssueResponseUnmarshaller.Instance;

            return Invoke<GetCodeIssueResponse>(request, options);
        }
#else
        internal virtual GetCodeIssueResponse GetCodeIssue(GetCodeIssueRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCodeIssueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCodeIssueResponseUnmarshaller.Instance;

            return Invoke<GetCodeIssueResponse>(request, options);
        }
#endif

        /// <summary>
        /// Retrieves the current state and details of an issue.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCodeIssue service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetCodeIssue service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/GetCodeIssue">REST API Reference for GetCodeIssue Operation</seealso>
        public virtual Task<GetCodeIssueResponse> GetCodeIssueAsync(GetCodeIssueRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCodeIssueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCodeIssueResponseUnmarshaller.Instance;

            return InvokeAsync<GetCodeIssueResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves one immutable artifact attached to an issue, including its content.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCodeIssueArtifact service method.</param>
        /// <returns>The response from the GetCodeIssueArtifact service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/GetCodeIssueArtifact">REST API Reference for GetCodeIssueArtifact Operation</seealso>
        public virtual GetCodeIssueArtifactResponse GetCodeIssueArtifact(GetCodeIssueArtifactRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCodeIssueArtifactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCodeIssueArtifactResponseUnmarshaller.Instance;

            return Invoke<GetCodeIssueArtifactResponse>(request, options);
        }
#else
        internal virtual GetCodeIssueArtifactResponse GetCodeIssueArtifact(GetCodeIssueArtifactRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCodeIssueArtifactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCodeIssueArtifactResponseUnmarshaller.Instance;

            return Invoke<GetCodeIssueArtifactResponse>(request, options);
        }
#endif

        /// <summary>
        /// Retrieves one immutable artifact attached to an issue, including its content.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCodeIssueArtifact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetCodeIssueArtifact service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/GetCodeIssueArtifact">REST API Reference for GetCodeIssueArtifact Operation</seealso>
        public virtual Task<GetCodeIssueArtifactResponse> GetCodeIssueArtifactAsync(GetCodeIssueArtifactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCodeIssueArtifactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCodeIssueArtifactResponseUnmarshaller.Instance;

            return InvokeAsync<GetCodeIssueArtifactResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves one customer-visible environment scan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCodeScan service method.</param>
        /// <returns>The response from the GetCodeScan service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/GetCodeScan">REST API Reference for GetCodeScan Operation</seealso>
        public virtual GetCodeScanResponse GetCodeScan(GetCodeScanRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCodeScanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCodeScanResponseUnmarshaller.Instance;

            return Invoke<GetCodeScanResponse>(request, options);
        }
#else
        internal virtual GetCodeScanResponse GetCodeScan(GetCodeScanRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCodeScanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCodeScanResponseUnmarshaller.Instance;

            return Invoke<GetCodeScanResponse>(request, options);
        }
#endif

        /// <summary>
        /// Retrieves one customer-visible environment scan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCodeScan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetCodeScan service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/GetCodeScan">REST API Reference for GetCodeScan Operation</seealso>
        public virtual Task<GetCodeScanResponse> GetCodeScanAsync(GetCodeScanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCodeScanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCodeScanResponseUnmarshaller.Instance;

            return InvokeAsync<GetCodeScanResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves the current state of the Collector for the caller's account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCollector service method.</param>
        /// <returns>The response from the GetCollector service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/GetCollector">REST API Reference for GetCollector Operation</seealso>
        public virtual GetCollectorResponse GetCollector(GetCollectorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCollectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCollectorResponseUnmarshaller.Instance;

            return Invoke<GetCollectorResponse>(request, options);
        }
#else
        internal virtual GetCollectorResponse GetCollector(GetCollectorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCollectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCollectorResponseUnmarshaller.Instance;

            return Invoke<GetCollectorResponse>(request, options);
        }
#endif

        /// <summary>
        /// Retrieves the current state of the Collector for the caller's account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCollector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetCollector service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/GetCollector">REST API Reference for GetCollector Operation</seealso>
        public virtual Task<GetCollectorResponse> GetCollectorAsync(GetCollectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCollectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCollectorResponseUnmarshaller.Instance;

            return InvokeAsync<GetCollectorResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Authorizes an Environment's access to a Collector's data. Continuum calls this operation
        /// with the Environment's Collector data-access role before it reads the Collector's
        /// inventory, so grant continuum:GetCollectorDataAccessAuthorization to that role and,
        /// for a Collector in another account, in the Collector's resource policy. The operation
        /// evaluates the action against the exact Collector ARN and the Collector's current resource
        /// policy using IAM and the caller's authenticated request context, with environmentArn
        /// as the continuum:EnvironmentArn condition key. A successful request returns HTTP 200
        /// with no response members. If access is not granted, the operation returns AccessDeniedException
        /// without disclosing Collector existence, ownership, or the policy layer that denied
        /// access. The service does not reinterpret the policy using only an account ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCollectorDataAccessAuthorization service method.</param>
        /// <returns>The response from the GetCollectorDataAccessAuthorization service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/GetCollectorDataAccessAuthorization">REST API Reference for GetCollectorDataAccessAuthorization Operation</seealso>
        public virtual GetCollectorDataAccessAuthorizationResponse GetCollectorDataAccessAuthorization(GetCollectorDataAccessAuthorizationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCollectorDataAccessAuthorizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCollectorDataAccessAuthorizationResponseUnmarshaller.Instance;

            return Invoke<GetCollectorDataAccessAuthorizationResponse>(request, options);
        }
#else
        internal virtual GetCollectorDataAccessAuthorizationResponse GetCollectorDataAccessAuthorization(GetCollectorDataAccessAuthorizationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCollectorDataAccessAuthorizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCollectorDataAccessAuthorizationResponseUnmarshaller.Instance;

            return Invoke<GetCollectorDataAccessAuthorizationResponse>(request, options);
        }
#endif

        /// <summary>
        /// Authorizes an Environment's access to a Collector's data. Continuum calls this operation
        /// with the Environment's Collector data-access role before it reads the Collector's
        /// inventory, so grant continuum:GetCollectorDataAccessAuthorization to that role and,
        /// for a Collector in another account, in the Collector's resource policy. The operation
        /// evaluates the action against the exact Collector ARN and the Collector's current resource
        /// policy using IAM and the caller's authenticated request context, with environmentArn
        /// as the continuum:EnvironmentArn condition key. A successful request returns HTTP 200
        /// with no response members. If access is not granted, the operation returns AccessDeniedException
        /// without disclosing Collector existence, ownership, or the policy layer that denied
        /// access. The service does not reinterpret the policy using only an account ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCollectorDataAccessAuthorization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetCollectorDataAccessAuthorization service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/GetCollectorDataAccessAuthorization">REST API Reference for GetCollectorDataAccessAuthorization Operation</seealso>
        public virtual Task<GetCollectorDataAccessAuthorizationResponse> GetCollectorDataAccessAuthorizationAsync(GetCollectorDataAccessAuthorizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCollectorDataAccessAuthorizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCollectorDataAccessAuthorizationResponseUnmarshaller.Instance;

            return InvokeAsync<GetCollectorDataAccessAuthorizationResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves the current state and configuration of an environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEnvironment service method.</param>
        /// <returns>The response from the GetEnvironment service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/GetEnvironment">REST API Reference for GetEnvironment Operation</seealso>
        public virtual GetEnvironmentResponse GetEnvironment(GetEnvironmentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnvironmentResponseUnmarshaller.Instance;

            return Invoke<GetEnvironmentResponse>(request, options);
        }
#else
        internal virtual GetEnvironmentResponse GetEnvironment(GetEnvironmentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnvironmentResponseUnmarshaller.Instance;

            return Invoke<GetEnvironmentResponse>(request, options);
        }
#endif

        /// <summary>
        /// Retrieves the current state and configuration of an environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetEnvironment service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/GetEnvironment">REST API Reference for GetEnvironment Operation</seealso>
        public virtual Task<GetEnvironmentResponse> GetEnvironmentAsync(GetEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnvironmentResponseUnmarshaller.Instance;

            return InvokeAsync<GetEnvironmentResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves information about an integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIntegration service method.</param>
        /// <returns>The response from the GetIntegration service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/GetIntegration">REST API Reference for GetIntegration Operation</seealso>
        public virtual GetIntegrationResponse GetIntegration(GetIntegrationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIntegrationResponseUnmarshaller.Instance;

            return Invoke<GetIntegrationResponse>(request, options);
        }
#else
        internal virtual GetIntegrationResponse GetIntegration(GetIntegrationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIntegrationResponseUnmarshaller.Instance;

            return Invoke<GetIntegrationResponse>(request, options);
        }
#endif

        /// <summary>
        /// Retrieves information about an integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetIntegration service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/GetIntegration">REST API Reference for GetIntegration Operation</seealso>
        public virtual Task<GetIntegrationResponse> GetIntegrationAsync(GetIntegrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIntegrationResponseUnmarshaller.Instance;

            return InvokeAsync<GetIntegrationResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves the resource policy attached to a Continuum resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy service method.</param>
        /// <returns>The response from the GetResourcePolicy service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        public virtual GetResourcePolicyResponse GetResourcePolicy(GetResourcePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<GetResourcePolicyResponse>(request, options);
        }
#else
        internal virtual GetResourcePolicyResponse GetResourcePolicy(GetResourcePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<GetResourcePolicyResponse>(request, options);
        }
#endif

        /// <summary>
        /// Retrieves the resource policy attached to a Continuum resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetResourcePolicy service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        public virtual Task<GetResourcePolicyResponse> GetResourcePolicyAsync(GetResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetResourcePolicyResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Lists the Collectors currently associated with one Environment in ascending collectorId
        /// order. Each entry carries the Collector ARN, so a listed association can be passed
        /// straight to DisassociateCollector, including when the Collector belongs to another
        /// account. An association recorded before Continuum persisted the ARN is omitted from
        /// the response, because without the ARN it cannot be acted on.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssociatedCollectors service method.</param>
        /// <returns>The response from the ListAssociatedCollectors service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/ListAssociatedCollectors">REST API Reference for ListAssociatedCollectors Operation</seealso>
        public virtual ListAssociatedCollectorsResponse ListAssociatedCollectors(ListAssociatedCollectorsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAssociatedCollectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssociatedCollectorsResponseUnmarshaller.Instance;

            return Invoke<ListAssociatedCollectorsResponse>(request, options);
        }
#else
        internal virtual ListAssociatedCollectorsResponse ListAssociatedCollectors(ListAssociatedCollectorsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAssociatedCollectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssociatedCollectorsResponseUnmarshaller.Instance;

            return Invoke<ListAssociatedCollectorsResponse>(request, options);
        }
#endif

        /// <summary>
        /// Lists the Collectors currently associated with one Environment in ascending collectorId
        /// order. Each entry carries the Collector ARN, so a listed association can be passed
        /// straight to DisassociateCollector, including when the Collector belongs to another
        /// account. An association recorded before Continuum persisted the ARN is omitted from
        /// the response, because without the ARN it cannot be acted on.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssociatedCollectors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListAssociatedCollectors service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/ListAssociatedCollectors">REST API Reference for ListAssociatedCollectors Operation</seealso>
        public virtual Task<ListAssociatedCollectorsResponse> ListAssociatedCollectorsAsync(ListAssociatedCollectorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAssociatedCollectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssociatedCollectorsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAssociatedCollectorsResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Lists the Environments currently associated with one Collector in lexicographically
        /// ascending environmentArn order. The ARN identifies each Environment across accounts
        /// within the Collector's Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssociatedEnvironments service method.</param>
        /// <returns>The response from the ListAssociatedEnvironments service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/ListAssociatedEnvironments">REST API Reference for ListAssociatedEnvironments Operation</seealso>
        public virtual ListAssociatedEnvironmentsResponse ListAssociatedEnvironments(ListAssociatedEnvironmentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAssociatedEnvironmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssociatedEnvironmentsResponseUnmarshaller.Instance;

            return Invoke<ListAssociatedEnvironmentsResponse>(request, options);
        }
#else
        internal virtual ListAssociatedEnvironmentsResponse ListAssociatedEnvironments(ListAssociatedEnvironmentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAssociatedEnvironmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssociatedEnvironmentsResponseUnmarshaller.Instance;

            return Invoke<ListAssociatedEnvironmentsResponse>(request, options);
        }
#endif

        /// <summary>
        /// Lists the Environments currently associated with one Collector in lexicographically
        /// ascending environmentArn order. The ARN identifies each Environment across accounts
        /// within the Collector's Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssociatedEnvironments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListAssociatedEnvironments service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/ListAssociatedEnvironments">REST API Reference for ListAssociatedEnvironments Operation</seealso>
        public virtual Task<ListAssociatedEnvironmentsResponse> ListAssociatedEnvironmentsAsync(ListAssociatedEnvironmentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAssociatedEnvironmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssociatedEnvironmentsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAssociatedEnvironmentsResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Lists the findings in an environment in descending findingId order.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCodeFindings service method.</param>
        /// <returns>The response from the ListCodeFindings service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/ListCodeFindings">REST API Reference for ListCodeFindings Operation</seealso>
        public virtual ListCodeFindingsResponse ListCodeFindings(ListCodeFindingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCodeFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCodeFindingsResponseUnmarshaller.Instance;

            return Invoke<ListCodeFindingsResponse>(request, options);
        }
#else
        internal virtual ListCodeFindingsResponse ListCodeFindings(ListCodeFindingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCodeFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCodeFindingsResponseUnmarshaller.Instance;

            return Invoke<ListCodeFindingsResponse>(request, options);
        }
#endif

        /// <summary>
        /// Lists the findings in an environment in descending findingId order.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCodeFindings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListCodeFindings service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/ListCodeFindings">REST API Reference for ListCodeFindings Operation</seealso>
        public virtual Task<ListCodeFindingsResponse> ListCodeFindingsAsync(ListCodeFindingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCodeFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCodeFindingsResponseUnmarshaller.Instance;

            return InvokeAsync<ListCodeFindingsResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Lists the artifacts attached to an issue in descending artifactId order. Content is
        /// returned by GetCodeIssueArtifact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCodeIssueArtifacts service method.</param>
        /// <returns>The response from the ListCodeIssueArtifacts service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/ListCodeIssueArtifacts">REST API Reference for ListCodeIssueArtifacts Operation</seealso>
        public virtual ListCodeIssueArtifactsResponse ListCodeIssueArtifacts(ListCodeIssueArtifactsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCodeIssueArtifactsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCodeIssueArtifactsResponseUnmarshaller.Instance;

            return Invoke<ListCodeIssueArtifactsResponse>(request, options);
        }
#else
        internal virtual ListCodeIssueArtifactsResponse ListCodeIssueArtifacts(ListCodeIssueArtifactsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCodeIssueArtifactsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCodeIssueArtifactsResponseUnmarshaller.Instance;

            return Invoke<ListCodeIssueArtifactsResponse>(request, options);
        }
#endif

        /// <summary>
        /// Lists the artifacts attached to an issue in descending artifactId order. Content is
        /// returned by GetCodeIssueArtifact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCodeIssueArtifacts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListCodeIssueArtifacts service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/ListCodeIssueArtifacts">REST API Reference for ListCodeIssueArtifacts Operation</seealso>
        public virtual Task<ListCodeIssueArtifactsResponse> ListCodeIssueArtifactsAsync(ListCodeIssueArtifactsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCodeIssueArtifactsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCodeIssueArtifactsResponseUnmarshaller.Instance;

            return InvokeAsync<ListCodeIssueArtifactsResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Lists the issues in an environment in descending issueId order.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCodeIssues service method.</param>
        /// <returns>The response from the ListCodeIssues service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/ListCodeIssues">REST API Reference for ListCodeIssues Operation</seealso>
        public virtual ListCodeIssuesResponse ListCodeIssues(ListCodeIssuesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCodeIssuesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCodeIssuesResponseUnmarshaller.Instance;

            return Invoke<ListCodeIssuesResponse>(request, options);
        }
#else
        internal virtual ListCodeIssuesResponse ListCodeIssues(ListCodeIssuesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCodeIssuesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCodeIssuesResponseUnmarshaller.Instance;

            return Invoke<ListCodeIssuesResponse>(request, options);
        }
#endif

        /// <summary>
        /// Lists the issues in an environment in descending issueId order.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCodeIssues service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListCodeIssues service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/ListCodeIssues">REST API Reference for ListCodeIssues Operation</seealso>
        public virtual Task<ListCodeIssuesResponse> ListCodeIssuesAsync(ListCodeIssuesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCodeIssuesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCodeIssuesResponseUnmarshaller.Instance;

            return InvokeAsync<ListCodeIssuesResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Lists customer-visible scans for one environment in descending scanRunId order.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCodeScans service method.</param>
        /// <returns>The response from the ListCodeScans service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/ListCodeScans">REST API Reference for ListCodeScans Operation</seealso>
        public virtual ListCodeScansResponse ListCodeScans(ListCodeScansRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCodeScansRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCodeScansResponseUnmarshaller.Instance;

            return Invoke<ListCodeScansResponse>(request, options);
        }
#else
        internal virtual ListCodeScansResponse ListCodeScans(ListCodeScansRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCodeScansRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCodeScansResponseUnmarshaller.Instance;

            return Invoke<ListCodeScansResponse>(request, options);
        }
#endif

        /// <summary>
        /// Lists customer-visible scans for one environment in descending scanRunId order.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCodeScans service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListCodeScans service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/ListCodeScans">REST API Reference for ListCodeScans Operation</seealso>
        public virtual Task<ListCodeScansResponse> ListCodeScansAsync(ListCodeScansRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCodeScansRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCodeScansResponseUnmarshaller.Instance;

            return InvokeAsync<ListCodeScansResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Lists the Collectors owned by the authenticated caller's account, including a Collector
        /// whose deletion is in progress. A Collector that is still being created is omitted.
        /// The account-scoped Collector quota currently permits at most one result, so no result
        /// ordering applies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCollectors service method.</param>
        /// <returns>The response from the ListCollectors service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/ListCollectors">REST API Reference for ListCollectors Operation</seealso>
        public virtual ListCollectorsResponse ListCollectors(ListCollectorsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCollectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCollectorsResponseUnmarshaller.Instance;

            return Invoke<ListCollectorsResponse>(request, options);
        }
#else
        internal virtual ListCollectorsResponse ListCollectors(ListCollectorsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCollectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCollectorsResponseUnmarshaller.Instance;

            return Invoke<ListCollectorsResponse>(request, options);
        }
#endif

        /// <summary>
        /// Lists the Collectors owned by the authenticated caller's account, including a Collector
        /// whose deletion is in progress. A Collector that is still being created is omitted.
        /// The account-scoped Collector quota currently permits at most one result, so no result
        /// ordering applies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCollectors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListCollectors service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/ListCollectors">REST API Reference for ListCollectors Operation</seealso>
        public virtual Task<ListCollectorsResponse> ListCollectorsAsync(ListCollectorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCollectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCollectorsResponseUnmarshaller.Instance;

            return InvokeAsync<ListCollectorsResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Lists all environments in your account in descending environmentId order. This complete-inventory
        /// operation intentionally has no response filters; see the input documentation for the
        /// API standards justification.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironments service method.</param>
        /// <returns>The response from the ListEnvironments service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/ListEnvironments">REST API Reference for ListEnvironments Operation</seealso>
        public virtual ListEnvironmentsResponse ListEnvironments(ListEnvironmentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEnvironmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnvironmentsResponseUnmarshaller.Instance;

            return Invoke<ListEnvironmentsResponse>(request, options);
        }
#else
        internal virtual ListEnvironmentsResponse ListEnvironments(ListEnvironmentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEnvironmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnvironmentsResponseUnmarshaller.Instance;

            return Invoke<ListEnvironmentsResponse>(request, options);
        }
#endif

        /// <summary>
        /// Lists all environments in your account in descending environmentId order. This complete-inventory
        /// operation intentionally has no response filters; see the input documentation for the
        /// API standards justification.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListEnvironments service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/ListEnvironments">REST API Reference for ListEnvironments Operation</seealso>
        public virtual Task<ListEnvironmentsResponse> ListEnvironmentsAsync(ListEnvironmentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEnvironmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnvironmentsResponseUnmarshaller.Instance;

            return InvokeAsync<ListEnvironmentsResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Lists the integrations in your account in descending integrationId order.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIntegrations service method.</param>
        /// <returns>The response from the ListIntegrations service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/ListIntegrations">REST API Reference for ListIntegrations Operation</seealso>
        public virtual ListIntegrationsResponse ListIntegrations(ListIntegrationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListIntegrationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIntegrationsResponseUnmarshaller.Instance;

            return Invoke<ListIntegrationsResponse>(request, options);
        }
#else
        internal virtual ListIntegrationsResponse ListIntegrations(ListIntegrationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListIntegrationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIntegrationsResponseUnmarshaller.Instance;

            return Invoke<ListIntegrationsResponse>(request, options);
        }
#endif

        /// <summary>
        /// Lists the integrations in your account in descending integrationId order.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIntegrations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListIntegrations service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/ListIntegrations">REST API Reference for ListIntegrations Operation</seealso>
        public virtual Task<ListIntegrationsResponse> ListIntegrationsAsync(ListIntegrationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListIntegrationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIntegrationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListIntegrationsResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Creates or replaces the resource policy attached to a Continuum resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy service method.</param>
        /// <returns>The response from the PutResourcePolicy service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        public virtual PutResourcePolicyResponse PutResourcePolicy(PutResourcePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<PutResourcePolicyResponse>(request, options);
        }
#else
        internal virtual PutResourcePolicyResponse PutResourcePolicy(PutResourcePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<PutResourcePolicyResponse>(request, options);
        }
#endif

        /// <summary>
        /// Creates or replaces the resource policy attached to a Continuum resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the PutResourcePolicy service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        public virtual Task<PutResourcePolicyResponse> PutResourcePolicyAsync(PutResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourcePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutResourcePolicyResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Starts an OAuth authorization for a new integration and returns the values the caller
        /// sends to the provider's authorization endpoint. The authorization belongs to the calling
        /// AWS account, can be redeemed once by CreateIntegration from that same account, and
        /// expires after ten minutes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartIntegrationAuthorization service method.</param>
        /// <returns>The response from the StartIntegrationAuthorization service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/StartIntegrationAuthorization">REST API Reference for StartIntegrationAuthorization Operation</seealso>
        public virtual StartIntegrationAuthorizationResponse StartIntegrationAuthorization(StartIntegrationAuthorizationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartIntegrationAuthorizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartIntegrationAuthorizationResponseUnmarshaller.Instance;

            return Invoke<StartIntegrationAuthorizationResponse>(request, options);
        }
#else
        internal virtual StartIntegrationAuthorizationResponse StartIntegrationAuthorization(StartIntegrationAuthorizationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartIntegrationAuthorizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartIntegrationAuthorizationResponseUnmarshaller.Instance;

            return Invoke<StartIntegrationAuthorizationResponse>(request, options);
        }
#endif

        /// <summary>
        /// Starts an OAuth authorization for a new integration and returns the values the caller
        /// sends to the provider's authorization endpoint. The authorization belongs to the calling
        /// AWS account, can be redeemed once by CreateIntegration from that same account, and
        /// expires after ten minutes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartIntegrationAuthorization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the StartIntegrationAuthorization service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/StartIntegrationAuthorization">REST API Reference for StartIntegrationAuthorization Operation</seealso>
        public virtual Task<StartIntegrationAuthorizationResponse> StartIntegrationAuthorizationAsync(StartIntegrationAuthorizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartIntegrationAuthorizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartIntegrationAuthorizationResponseUnmarshaller.Instance;

            return InvokeAsync<StartIntegrationAuthorizationResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Updates the customer-controlled mutable properties of a Collector. Only the name and
        /// Kubernetes cluster IAM role can be changed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCollector service method.</param>
        /// <returns>The response from the UpdateCollector service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/UpdateCollector">REST API Reference for UpdateCollector Operation</seealso>
        public virtual UpdateCollectorResponse UpdateCollector(UpdateCollectorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCollectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCollectorResponseUnmarshaller.Instance;

            return Invoke<UpdateCollectorResponse>(request, options);
        }
#else
        internal virtual UpdateCollectorResponse UpdateCollector(UpdateCollectorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCollectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCollectorResponseUnmarshaller.Instance;

            return Invoke<UpdateCollectorResponse>(request, options);
        }
#endif

        /// <summary>
        /// Updates the customer-controlled mutable properties of a Collector. Only the name and
        /// Kubernetes cluster IAM role can be changed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCollector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateCollector service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/UpdateCollector">REST API Reference for UpdateCollector Operation</seealso>
        public virtual Task<UpdateCollectorResponse> UpdateCollectorAsync(UpdateCollectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCollectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCollectorResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateCollectorResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Updates the customer-controlled mutable properties of an environment. Only the name,
        /// the environment's S3 integration source and repository selections, its scan frequency,
        /// its network policy, and its patch creation policy can be changed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnvironment service method.</param>
        /// <returns>The response from the UpdateEnvironment service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/UpdateEnvironment">REST API Reference for UpdateEnvironment Operation</seealso>
        public virtual UpdateEnvironmentResponse UpdateEnvironment(UpdateEnvironmentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEnvironmentResponseUnmarshaller.Instance;

            return Invoke<UpdateEnvironmentResponse>(request, options);
        }
#else
        internal virtual UpdateEnvironmentResponse UpdateEnvironment(UpdateEnvironmentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEnvironmentResponseUnmarshaller.Instance;

            return Invoke<UpdateEnvironmentResponse>(request, options);
        }
#endif

        /// <summary>
        /// Updates the customer-controlled mutable properties of an environment. Only the name,
        /// the environment's S3 integration source and repository selections, its scan frequency,
        /// its network policy, and its patch creation policy can be changed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateEnvironment service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/UpdateEnvironment">REST API Reference for UpdateEnvironment Operation</seealso>
        public virtual Task<UpdateEnvironmentResponse> UpdateEnvironmentAsync(UpdateEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEnvironmentResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateEnvironmentResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Rotates the credentials used by an Amazon S3 integration. Only S3 integrations can
        /// be updated; GitHub integrations cannot be modified. The integration's name, provider
        /// type, and bucket remain fixed. The caller must have iam:PassRole permission for the
        /// supplied role, including when only the external ID changes. Continuum verifies that
        /// the role can be assumed with the requested external ID and can access the existing
        /// bucket before saving both credentials atomically. Omitting externalId preserves its
        /// current value. Repeating both current credentials leaves updatedAt unchanged, but
        /// still requires authorization and access validation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIntegration service method.</param>
        /// <returns>The response from the UpdateIntegration service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/UpdateIntegration">REST API Reference for UpdateIntegration Operation</seealso>
        public virtual UpdateIntegrationResponse UpdateIntegration(UpdateIntegrationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIntegrationResponseUnmarshaller.Instance;

            return Invoke<UpdateIntegrationResponse>(request, options);
        }
#else
        internal virtual UpdateIntegrationResponse UpdateIntegration(UpdateIntegrationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIntegrationResponseUnmarshaller.Instance;

            return Invoke<UpdateIntegrationResponse>(request, options);
        }
#endif

        /// <summary>
        /// Rotates the credentials used by an Amazon S3 integration. Only S3 integrations can
        /// be updated; GitHub integrations cannot be modified. The integration's name, provider
        /// type, and bucket remain fixed. The caller must have iam:PassRole permission for the
        /// supplied role, including when only the external ID changes. Continuum verifies that
        /// the role can be assumed with the requested external ID and can access the existing
        /// bucket before saving both credentials atomically. Omitting externalId preserves its
        /// current value. Repeating both current credentials leaves updatedAt unchanged, but
        /// still requires authorization and access validation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateIntegration service method, as returned by Continuum.</returns>
        /// <exception cref="Amazon.Continuum.Model.AccessDeniedException">
        /// The request is not authorized. Verify that your credentials and request signature
        /// are valid and that you have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.InternalServerException">
        /// The request couldn't be processed because of an internal server issue. Try again later.
        /// If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Continuum.Model.ValidationException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/continuum-2022-07-26/UpdateIntegration">REST API Reference for UpdateIntegration Operation</seealso>
        public virtual Task<UpdateIntegrationResponse> UpdateIntegrationAsync(UpdateIntegrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIntegrationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateIntegrationResponse>(request, options, cancellationToken);
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
