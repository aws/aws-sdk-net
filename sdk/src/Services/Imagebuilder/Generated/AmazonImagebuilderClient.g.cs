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
using Amazon.Imagebuilder.Model;
using Amazon.Imagebuilder.Model.Internal.MarshallTransformations;
using Amazon.Imagebuilder.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570

namespace Amazon.Imagebuilder
{
    /// <summary>
    /// <para>Implementation for accessing Imagebuilder</para>
    /// <para>
    /// Service client instances are thread-safe and can be shared across multiple threads.
    /// For a given service configuration, it is recommended to reuse a client instance
    /// for the lifetime of your application.
    /// </para>
    ///
    /// EC2 Image Builder automates the creation, management, and deployment of customized,
    /// secure, and up-to-date server images. You can build Amazon Machine Images (AMIs) and
    /// container images that are pre-installed and pre-configured with software and settings
    /// to meet specific IT standards.
    /// 
    ///  
    /// <para>
    /// For an introduction to the service concepts that these API operations work with, see
    /// <a href="https://docs.aws.amazon.com/imagebuilder/latest/userguide/how-image-builder-works.html">How
    /// Image Builder works</a> in the <i>EC2 Image Builder User Guide</i>.
    /// </para>
    /// </summary>
    public partial class AmazonImagebuilderClient : AmazonServiceClient, IAmazonImagebuilder
    {
        private static IServiceMetadata serviceMetadata = new AmazonImagebuilderMetadata();
        private IImagebuilderPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IImagebuilderPaginatorFactory Paginators
        {
            get
            {
                if (this._paginators == null)
                {
                    this._paginators = new ImagebuilderPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        /// <summary>
        /// Constructs AmazonImagebuilderClient with the credentials loaded from the application's
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
        public AmazonImagebuilderClient() : base(new AmazonImagebuilderConfig()) { }

        /// <summary>
        /// Constructs AmazonImagebuilderClient with the credentials loaded from the application's
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
        public AmazonImagebuilderClient(RegionEndpoint region) : base(new AmazonImagebuilderConfig { RegionEndpoint = region }) { }

        /// <summary>
        /// Constructs AmazonImagebuilderClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonImagebuilderClient Configuration Object</param>
        public AmazonImagebuilderClient(AmazonImagebuilderConfig config) : base(config) { }

        /// <summary>
        /// Constructs AmazonImagebuilderClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonImagebuilderClient(AWSCredentials credentials)
            : this(credentials, new AmazonImagebuilderConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonImagebuilderClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonImagebuilderClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonImagebuilderConfig { RegionEndpoint = region })
        {
        }

        /// <summary>
        /// Constructs AmazonImagebuilderClient with AWS Credentials and an
        /// AmazonImagebuilderClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonImagebuilderClient Configuration Object</param>
        public AmazonImagebuilderClient(AWSCredentials credentials, AmazonImagebuilderConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonImagebuilderClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonImagebuilderClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonImagebuilderConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonImagebuilderClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonImagebuilderClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonImagebuilderConfig { RegionEndpoint = region })
        {
        }

        /// <summary>
        /// Constructs AmazonImagebuilderClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonImagebuilderClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonImagebuilderClient Configuration Object</param>
        public AmazonImagebuilderClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonImagebuilderConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonImagebuilderClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonImagebuilderClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonImagebuilderConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonImagebuilderClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonImagebuilderClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonImagebuilderConfig { RegionEndpoint = region })
        {
        }

        /// <summary>
        /// Constructs AmazonImagebuilderClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonImagebuilderClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonImagebuilderClient Configuration Object</param>
        public AmazonImagebuilderClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonImagebuilderConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonImagebuilderEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonImagebuilderAuthSchemeHandler());
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
        /// Cancels the creation of an image. This operation can only be used on images in a non-terminal
        /// state. Cancellation is asynchronous: the request returns immediately, then Image Builder
        /// stops the running build and moves the image to the <c>CANCELLED</c> state. Output
        /// resources that the build already created, such as AMIs and snapshots, aren't removed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelImageCreation service method.</param>
        /// <returns>The response from the CancelImageCreation service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.IdempotentParameterMismatchException">
        /// You have specified a client token for an operation using parameter values that differ
        /// from a previous request that used the same client token.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceInUseException">
        /// The resource that you are trying to operate on is currently in use. Review the message
        /// details and retry later.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/CancelImageCreation">REST API Reference for CancelImageCreation Operation</seealso>
        public virtual CancelImageCreationResponse CancelImageCreation(CancelImageCreationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelImageCreationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelImageCreationResponseUnmarshaller.Instance;

            return Invoke<CancelImageCreationResponse>(request, options);
        }
#else
        internal virtual CancelImageCreationResponse CancelImageCreation(CancelImageCreationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelImageCreationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelImageCreationResponseUnmarshaller.Instance;

            return Invoke<CancelImageCreationResponse>(request, options);
        }
#endif

        /// <summary>
        /// Cancels the creation of an image. This operation can only be used on images in a non-terminal
        /// state. Cancellation is asynchronous: the request returns immediately, then Image Builder
        /// stops the running build and moves the image to the <c>CANCELLED</c> state. Output
        /// resources that the build already created, such as AMIs and snapshots, aren't removed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelImageCreation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CancelImageCreation service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.IdempotentParameterMismatchException">
        /// You have specified a client token for an operation using parameter values that differ
        /// from a previous request that used the same client token.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceInUseException">
        /// The resource that you are trying to operate on is currently in use. Review the message
        /// details and retry later.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/CancelImageCreation">REST API Reference for CancelImageCreation Operation</seealso>
        public virtual Task<CancelImageCreationResponse> CancelImageCreationAsync(CancelImageCreationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelImageCreationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelImageCreationResponseUnmarshaller.Instance;

            return InvokeAsync<CancelImageCreationResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Cancels a lifecycle execution – a single run of lifecycle actions that a lifecycle
        /// policy or a <a>StartResourceStateUpdate</a> request started. You can only cancel an
        /// execution that hasn't reached a terminal state. Cancellation is asynchronous and doesn't
        /// undo completed lifecycle actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelLifecycleExecution service method.</param>
        /// <returns>The response from the CancelLifecycleExecution service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.IdempotentParameterMismatchException">
        /// You have specified a client token for an operation using parameter values that differ
        /// from a previous request that used the same client token.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceInUseException">
        /// The resource that you are trying to operate on is currently in use. Review the message
        /// details and retry later.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/CancelLifecycleExecution">REST API Reference for CancelLifecycleExecution Operation</seealso>
        public virtual CancelLifecycleExecutionResponse CancelLifecycleExecution(CancelLifecycleExecutionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelLifecycleExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelLifecycleExecutionResponseUnmarshaller.Instance;

            return Invoke<CancelLifecycleExecutionResponse>(request, options);
        }
#else
        internal virtual CancelLifecycleExecutionResponse CancelLifecycleExecution(CancelLifecycleExecutionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelLifecycleExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelLifecycleExecutionResponseUnmarshaller.Instance;

            return Invoke<CancelLifecycleExecutionResponse>(request, options);
        }
#endif

        /// <summary>
        /// Cancels a lifecycle execution – a single run of lifecycle actions that a lifecycle
        /// policy or a <a>StartResourceStateUpdate</a> request started. You can only cancel an
        /// execution that hasn't reached a terminal state. Cancellation is asynchronous and doesn't
        /// undo completed lifecycle actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelLifecycleExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CancelLifecycleExecution service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.IdempotentParameterMismatchException">
        /// You have specified a client token for an operation using parameter values that differ
        /// from a previous request that used the same client token.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceInUseException">
        /// The resource that you are trying to operate on is currently in use. Review the message
        /// details and retry later.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/CancelLifecycleExecution">REST API Reference for CancelLifecycleExecution Operation</seealso>
        public virtual Task<CancelLifecycleExecutionResponse> CancelLifecycleExecutionAsync(CancelLifecycleExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelLifecycleExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelLifecycleExecutionResponseUnmarshaller.Instance;

            return InvokeAsync<CancelLifecycleExecutionResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Creates a new component that can be used to build, validate, test, and assess your
        /// image. The component is based on a YAML document that you specify using exactly one
        /// of the following methods:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Inline, using the <c>data</c> property in the request body.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A URL that points to a YAML document file stored in Amazon S3, using the <c>uri</c>
        /// property in the request body.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Image Builder determines the component type from the document. If the document contains
        /// a single phase named <c>test</c>, the component type is <c>TEST</c>. Otherwise, the
        /// component type is <c>BUILD</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateComponent service method.</param>
        /// <returns>The response from the CreateComponent service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.DryRunOperationException">
        /// The dry run operation of the resource was successful, and no resources or mutations
        /// were actually performed due to the dry run flag in the request.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.IdempotentParameterMismatchException">
        /// You have specified a client token for an operation using parameter values that differ
        /// from a previous request that used the same client token.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidParameterCombinationException">
        /// You have specified a combination of parameters that isn't valid. For example, two
        /// mutually exclusive parameters, or a parameter without its required companion parameter.
        /// Review the error message for details.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidVersionNumberException">
        /// Your version number is out of bounds or does not follow the required syntax.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceInUseException">
        /// The resource that you are trying to operate on is currently in use. Review the message
        /// details and retry later.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceQuotaExceededException">
        /// You have exceeded the number of permitted resources or operations for this service.
        /// For service quotas, see <a href="https://docs.aws.amazon.com/general/latest/gr/imagebuilder.html#limits_imagebuilder">EC2
        /// Image Builder endpoints and quotas</a>.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/CreateComponent">REST API Reference for CreateComponent Operation</seealso>
        public virtual CreateComponentResponse CreateComponent(CreateComponentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateComponentResponseUnmarshaller.Instance;

            return Invoke<CreateComponentResponse>(request, options);
        }
#else
        internal virtual CreateComponentResponse CreateComponent(CreateComponentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateComponentResponseUnmarshaller.Instance;

            return Invoke<CreateComponentResponse>(request, options);
        }
#endif

        /// <summary>
        /// Creates a new component that can be used to build, validate, test, and assess your
        /// image. The component is based on a YAML document that you specify using exactly one
        /// of the following methods:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Inline, using the <c>data</c> property in the request body.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A URL that points to a YAML document file stored in Amazon S3, using the <c>uri</c>
        /// property in the request body.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Image Builder determines the component type from the document. If the document contains
        /// a single phase named <c>test</c>, the component type is <c>TEST</c>. Otherwise, the
        /// component type is <c>BUILD</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateComponent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateComponent service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.DryRunOperationException">
        /// The dry run operation of the resource was successful, and no resources or mutations
        /// were actually performed due to the dry run flag in the request.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.IdempotentParameterMismatchException">
        /// You have specified a client token for an operation using parameter values that differ
        /// from a previous request that used the same client token.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidParameterCombinationException">
        /// You have specified a combination of parameters that isn't valid. For example, two
        /// mutually exclusive parameters, or a parameter without its required companion parameter.
        /// Review the error message for details.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidVersionNumberException">
        /// Your version number is out of bounds or does not follow the required syntax.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceInUseException">
        /// The resource that you are trying to operate on is currently in use. Review the message
        /// details and retry later.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceQuotaExceededException">
        /// You have exceeded the number of permitted resources or operations for this service.
        /// For service quotas, see <a href="https://docs.aws.amazon.com/general/latest/gr/imagebuilder.html#limits_imagebuilder">EC2
        /// Image Builder endpoints and quotas</a>.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/CreateComponent">REST API Reference for CreateComponent Operation</seealso>
        public virtual Task<CreateComponentResponse> CreateComponentAsync(CreateComponentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateComponentResponseUnmarshaller.Instance;

            return InvokeAsync<CreateComponentResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Creates a new container recipe. Container recipes define how images are configured,
        /// tested, and assessed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateContainerRecipe service method.</param>
        /// <returns>The response from the CreateContainerRecipe service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.DryRunOperationException">
        /// The dry run operation of the resource was successful, and no resources or mutations
        /// were actually performed due to the dry run flag in the request.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.IdempotentParameterMismatchException">
        /// You have specified a client token for an operation using parameter values that differ
        /// from a previous request that used the same client token.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidVersionNumberException">
        /// Your version number is out of bounds or does not follow the required syntax.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceAlreadyExistsException">
        /// The resource that you are trying to create already exists.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceInUseException">
        /// The resource that you are trying to operate on is currently in use. Review the message
        /// details and retry later.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceQuotaExceededException">
        /// You have exceeded the number of permitted resources or operations for this service.
        /// For service quotas, see <a href="https://docs.aws.amazon.com/general/latest/gr/imagebuilder.html#limits_imagebuilder">EC2
        /// Image Builder endpoints and quotas</a>.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/CreateContainerRecipe">REST API Reference for CreateContainerRecipe Operation</seealso>
        public virtual CreateContainerRecipeResponse CreateContainerRecipe(CreateContainerRecipeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateContainerRecipeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateContainerRecipeResponseUnmarshaller.Instance;

            return Invoke<CreateContainerRecipeResponse>(request, options);
        }
#else
        internal virtual CreateContainerRecipeResponse CreateContainerRecipe(CreateContainerRecipeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateContainerRecipeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateContainerRecipeResponseUnmarshaller.Instance;

            return Invoke<CreateContainerRecipeResponse>(request, options);
        }
#endif

        /// <summary>
        /// Creates a new container recipe. Container recipes define how images are configured,
        /// tested, and assessed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateContainerRecipe service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateContainerRecipe service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.DryRunOperationException">
        /// The dry run operation of the resource was successful, and no resources or mutations
        /// were actually performed due to the dry run flag in the request.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.IdempotentParameterMismatchException">
        /// You have specified a client token for an operation using parameter values that differ
        /// from a previous request that used the same client token.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidVersionNumberException">
        /// Your version number is out of bounds or does not follow the required syntax.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceAlreadyExistsException">
        /// The resource that you are trying to create already exists.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceInUseException">
        /// The resource that you are trying to operate on is currently in use. Review the message
        /// details and retry later.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceQuotaExceededException">
        /// You have exceeded the number of permitted resources or operations for this service.
        /// For service quotas, see <a href="https://docs.aws.amazon.com/general/latest/gr/imagebuilder.html#limits_imagebuilder">EC2
        /// Image Builder endpoints and quotas</a>.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/CreateContainerRecipe">REST API Reference for CreateContainerRecipe Operation</seealso>
        public virtual Task<CreateContainerRecipeResponse> CreateContainerRecipeAsync(CreateContainerRecipeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateContainerRecipeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateContainerRecipeResponseUnmarshaller.Instance;

            return InvokeAsync<CreateContainerRecipeResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Creates a new distribution configuration. Distribution configurations define and configure
        /// the outputs for your images, including the target Regions, accounts, and settings
        /// for each Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDistributionConfiguration service method.</param>
        /// <returns>The response from the CreateDistributionConfiguration service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.DryRunOperationException">
        /// The dry run operation of the resource was successful, and no resources or mutations
        /// were actually performed due to the dry run flag in the request.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.IdempotentParameterMismatchException">
        /// You have specified a client token for an operation using parameter values that differ
        /// from a previous request that used the same client token.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidParameterCombinationException">
        /// You have specified a combination of parameters that isn't valid. For example, two
        /// mutually exclusive parameters, or a parameter without its required companion parameter.
        /// Review the error message for details.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceAlreadyExistsException">
        /// The resource that you are trying to create already exists.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceInUseException">
        /// The resource that you are trying to operate on is currently in use. Review the message
        /// details and retry later.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceQuotaExceededException">
        /// You have exceeded the number of permitted resources or operations for this service.
        /// For service quotas, see <a href="https://docs.aws.amazon.com/general/latest/gr/imagebuilder.html#limits_imagebuilder">EC2
        /// Image Builder endpoints and quotas</a>.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/CreateDistributionConfiguration">REST API Reference for CreateDistributionConfiguration Operation</seealso>
        public virtual CreateDistributionConfigurationResponse CreateDistributionConfiguration(CreateDistributionConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDistributionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDistributionConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateDistributionConfigurationResponse>(request, options);
        }
#else
        internal virtual CreateDistributionConfigurationResponse CreateDistributionConfiguration(CreateDistributionConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDistributionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDistributionConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateDistributionConfigurationResponse>(request, options);
        }
#endif

        /// <summary>
        /// Creates a new distribution configuration. Distribution configurations define and configure
        /// the outputs for your images, including the target Regions, accounts, and settings
        /// for each Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDistributionConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateDistributionConfiguration service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.DryRunOperationException">
        /// The dry run operation of the resource was successful, and no resources or mutations
        /// were actually performed due to the dry run flag in the request.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.IdempotentParameterMismatchException">
        /// You have specified a client token for an operation using parameter values that differ
        /// from a previous request that used the same client token.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidParameterCombinationException">
        /// You have specified a combination of parameters that isn't valid. For example, two
        /// mutually exclusive parameters, or a parameter without its required companion parameter.
        /// Review the error message for details.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceAlreadyExistsException">
        /// The resource that you are trying to create already exists.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceInUseException">
        /// The resource that you are trying to operate on is currently in use. Review the message
        /// details and retry later.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceQuotaExceededException">
        /// You have exceeded the number of permitted resources or operations for this service.
        /// For service quotas, see <a href="https://docs.aws.amazon.com/general/latest/gr/imagebuilder.html#limits_imagebuilder">EC2
        /// Image Builder endpoints and quotas</a>.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/CreateDistributionConfiguration">REST API Reference for CreateDistributionConfiguration Operation</seealso>
        public virtual Task<CreateDistributionConfigurationResponse> CreateDistributionConfigurationAsync(CreateDistributionConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDistributionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDistributionConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDistributionConfigurationResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Creates a new image along with all configured output resources defined in the distribution
        /// configuration. You must specify exactly one recipe for your image, using either a
        /// <c>containerRecipeArn</c> or an <c>imageRecipeArn</c>.
        /// 
        ///  
        /// <para>
        /// The response returns as soon as Image Builder creates the new image resource. The
        /// image build process runs asynchronously. To check its progress, call <a href="https://docs.aws.amazon.com/imagebuilder/latest/APIReference/API_GetImage.html">GetImage</a>
        /// and check the image status.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateImage service method.</param>
        /// <returns>The response from the CreateImage service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.IdempotentParameterMismatchException">
        /// You have specified a client token for an operation using parameter values that differ
        /// from a previous request that used the same client token.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceInUseException">
        /// The resource that you are trying to operate on is currently in use. Review the message
        /// details and retry later.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceQuotaExceededException">
        /// You have exceeded the number of permitted resources or operations for this service.
        /// For service quotas, see <a href="https://docs.aws.amazon.com/general/latest/gr/imagebuilder.html#limits_imagebuilder">EC2
        /// Image Builder endpoints and quotas</a>.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/CreateImage">REST API Reference for CreateImage Operation</seealso>
        public virtual CreateImageResponse CreateImage(CreateImageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateImageResponseUnmarshaller.Instance;

            return Invoke<CreateImageResponse>(request, options);
        }
#else
        internal virtual CreateImageResponse CreateImage(CreateImageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateImageResponseUnmarshaller.Instance;

            return Invoke<CreateImageResponse>(request, options);
        }
#endif

        /// <summary>
        /// Creates a new image along with all configured output resources defined in the distribution
        /// configuration. You must specify exactly one recipe for your image, using either a
        /// <c>containerRecipeArn</c> or an <c>imageRecipeArn</c>.
        /// 
        ///  
        /// <para>
        /// The response returns as soon as Image Builder creates the new image resource. The
        /// image build process runs asynchronously. To check its progress, call <a href="https://docs.aws.amazon.com/imagebuilder/latest/APIReference/API_GetImage.html">GetImage</a>
        /// and check the image status.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateImage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateImage service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.IdempotentParameterMismatchException">
        /// You have specified a client token for an operation using parameter values that differ
        /// from a previous request that used the same client token.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceInUseException">
        /// The resource that you are trying to operate on is currently in use. Review the message
        /// details and retry later.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceQuotaExceededException">
        /// You have exceeded the number of permitted resources or operations for this service.
        /// For service quotas, see <a href="https://docs.aws.amazon.com/general/latest/gr/imagebuilder.html#limits_imagebuilder">EC2
        /// Image Builder endpoints and quotas</a>.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/CreateImage">REST API Reference for CreateImage Operation</seealso>
        public virtual Task<CreateImageResponse> CreateImageAsync(CreateImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateImageResponseUnmarshaller.Instance;

            return InvokeAsync<CreateImageResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Creates a new image pipeline. Use image pipelines to automate the creation and distribution
        /// of images. You must specify exactly one recipe for the pipeline, using either a <c>containerRecipeArn</c>
        /// or an <c>imageRecipeArn</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateImagePipeline service method.</param>
        /// <returns>The response from the CreateImagePipeline service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.DryRunOperationException">
        /// The dry run operation of the resource was successful, and no resources or mutations
        /// were actually performed due to the dry run flag in the request.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.IdempotentParameterMismatchException">
        /// You have specified a client token for an operation using parameter values that differ
        /// from a previous request that used the same client token.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceAlreadyExistsException">
        /// The resource that you are trying to create already exists.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceInUseException">
        /// The resource that you are trying to operate on is currently in use. Review the message
        /// details and retry later.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceQuotaExceededException">
        /// You have exceeded the number of permitted resources or operations for this service.
        /// For service quotas, see <a href="https://docs.aws.amazon.com/general/latest/gr/imagebuilder.html#limits_imagebuilder">EC2
        /// Image Builder endpoints and quotas</a>.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/CreateImagePipeline">REST API Reference for CreateImagePipeline Operation</seealso>
        public virtual CreateImagePipelineResponse CreateImagePipeline(CreateImagePipelineRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateImagePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateImagePipelineResponseUnmarshaller.Instance;

            return Invoke<CreateImagePipelineResponse>(request, options);
        }
#else
        internal virtual CreateImagePipelineResponse CreateImagePipeline(CreateImagePipelineRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateImagePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateImagePipelineResponseUnmarshaller.Instance;

            return Invoke<CreateImagePipelineResponse>(request, options);
        }
#endif

        /// <summary>
        /// Creates a new image pipeline. Use image pipelines to automate the creation and distribution
        /// of images. You must specify exactly one recipe for the pipeline, using either a <c>containerRecipeArn</c>
        /// or an <c>imageRecipeArn</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateImagePipeline service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateImagePipeline service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.DryRunOperationException">
        /// The dry run operation of the resource was successful, and no resources or mutations
        /// were actually performed due to the dry run flag in the request.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.IdempotentParameterMismatchException">
        /// You have specified a client token for an operation using parameter values that differ
        /// from a previous request that used the same client token.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceAlreadyExistsException">
        /// The resource that you are trying to create already exists.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceInUseException">
        /// The resource that you are trying to operate on is currently in use. Review the message
        /// details and retry later.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceQuotaExceededException">
        /// You have exceeded the number of permitted resources or operations for this service.
        /// For service quotas, see <a href="https://docs.aws.amazon.com/general/latest/gr/imagebuilder.html#limits_imagebuilder">EC2
        /// Image Builder endpoints and quotas</a>.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/CreateImagePipeline">REST API Reference for CreateImagePipeline Operation</seealso>
        public virtual Task<CreateImagePipelineResponse> CreateImagePipelineAsync(CreateImagePipelineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateImagePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateImagePipelineResponseUnmarshaller.Instance;

            return InvokeAsync<CreateImagePipelineResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Creates a new image recipe. Image recipes define how images are configured, tested,
        /// and assessed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateImageRecipe service method.</param>
        /// <returns>The response from the CreateImageRecipe service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.DryRunOperationException">
        /// The dry run operation of the resource was successful, and no resources or mutations
        /// were actually performed due to the dry run flag in the request.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.IdempotentParameterMismatchException">
        /// You have specified a client token for an operation using parameter values that differ
        /// from a previous request that used the same client token.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidVersionNumberException">
        /// Your version number is out of bounds or does not follow the required syntax.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceAlreadyExistsException">
        /// The resource that you are trying to create already exists.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceInUseException">
        /// The resource that you are trying to operate on is currently in use. Review the message
        /// details and retry later.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceQuotaExceededException">
        /// You have exceeded the number of permitted resources or operations for this service.
        /// For service quotas, see <a href="https://docs.aws.amazon.com/general/latest/gr/imagebuilder.html#limits_imagebuilder">EC2
        /// Image Builder endpoints and quotas</a>.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/CreateImageRecipe">REST API Reference for CreateImageRecipe Operation</seealso>
        public virtual CreateImageRecipeResponse CreateImageRecipe(CreateImageRecipeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateImageRecipeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateImageRecipeResponseUnmarshaller.Instance;

            return Invoke<CreateImageRecipeResponse>(request, options);
        }
#else
        internal virtual CreateImageRecipeResponse CreateImageRecipe(CreateImageRecipeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateImageRecipeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateImageRecipeResponseUnmarshaller.Instance;

            return Invoke<CreateImageRecipeResponse>(request, options);
        }
#endif

        /// <summary>
        /// Creates a new image recipe. Image recipes define how images are configured, tested,
        /// and assessed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateImageRecipe service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateImageRecipe service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.DryRunOperationException">
        /// The dry run operation of the resource was successful, and no resources or mutations
        /// were actually performed due to the dry run flag in the request.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.IdempotentParameterMismatchException">
        /// You have specified a client token for an operation using parameter values that differ
        /// from a previous request that used the same client token.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidVersionNumberException">
        /// Your version number is out of bounds or does not follow the required syntax.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceAlreadyExistsException">
        /// The resource that you are trying to create already exists.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceInUseException">
        /// The resource that you are trying to operate on is currently in use. Review the message
        /// details and retry later.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceQuotaExceededException">
        /// You have exceeded the number of permitted resources or operations for this service.
        /// For service quotas, see <a href="https://docs.aws.amazon.com/general/latest/gr/imagebuilder.html#limits_imagebuilder">EC2
        /// Image Builder endpoints and quotas</a>.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/CreateImageRecipe">REST API Reference for CreateImageRecipe Operation</seealso>
        public virtual Task<CreateImageRecipeResponse> CreateImageRecipeAsync(CreateImageRecipeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateImageRecipeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateImageRecipeResponseUnmarshaller.Instance;

            return InvokeAsync<CreateImageRecipeResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Creates a new infrastructure configuration. An infrastructure configuration defines
        /// the environment in which your image will be built and tested.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInfrastructureConfiguration service method.</param>
        /// <returns>The response from the CreateInfrastructureConfiguration service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.DryRunOperationException">
        /// The dry run operation of the resource was successful, and no resources or mutations
        /// were actually performed due to the dry run flag in the request.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.IdempotentParameterMismatchException">
        /// You have specified a client token for an operation using parameter values that differ
        /// from a previous request that used the same client token.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceAlreadyExistsException">
        /// The resource that you are trying to create already exists.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceInUseException">
        /// The resource that you are trying to operate on is currently in use. Review the message
        /// details and retry later.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceQuotaExceededException">
        /// You have exceeded the number of permitted resources or operations for this service.
        /// For service quotas, see <a href="https://docs.aws.amazon.com/general/latest/gr/imagebuilder.html#limits_imagebuilder">EC2
        /// Image Builder endpoints and quotas</a>.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/CreateInfrastructureConfiguration">REST API Reference for CreateInfrastructureConfiguration Operation</seealso>
        public virtual CreateInfrastructureConfigurationResponse CreateInfrastructureConfiguration(CreateInfrastructureConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateInfrastructureConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInfrastructureConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateInfrastructureConfigurationResponse>(request, options);
        }
#else
        internal virtual CreateInfrastructureConfigurationResponse CreateInfrastructureConfiguration(CreateInfrastructureConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateInfrastructureConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInfrastructureConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateInfrastructureConfigurationResponse>(request, options);
        }
#endif

        /// <summary>
        /// Creates a new infrastructure configuration. An infrastructure configuration defines
        /// the environment in which your image will be built and tested.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInfrastructureConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateInfrastructureConfiguration service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.DryRunOperationException">
        /// The dry run operation of the resource was successful, and no resources or mutations
        /// were actually performed due to the dry run flag in the request.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.IdempotentParameterMismatchException">
        /// You have specified a client token for an operation using parameter values that differ
        /// from a previous request that used the same client token.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceAlreadyExistsException">
        /// The resource that you are trying to create already exists.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceInUseException">
        /// The resource that you are trying to operate on is currently in use. Review the message
        /// details and retry later.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceQuotaExceededException">
        /// You have exceeded the number of permitted resources or operations for this service.
        /// For service quotas, see <a href="https://docs.aws.amazon.com/general/latest/gr/imagebuilder.html#limits_imagebuilder">EC2
        /// Image Builder endpoints and quotas</a>.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/CreateInfrastructureConfiguration">REST API Reference for CreateInfrastructureConfiguration Operation</seealso>
        public virtual Task<CreateInfrastructureConfigurationResponse> CreateInfrastructureConfigurationAsync(CreateInfrastructureConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateInfrastructureConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInfrastructureConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateInfrastructureConfigurationResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Creates a lifecycle policy resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLifecyclePolicy service method.</param>
        /// <returns>The response from the CreateLifecyclePolicy service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.DryRunOperationException">
        /// The dry run operation of the resource was successful, and no resources or mutations
        /// were actually performed due to the dry run flag in the request.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.IdempotentParameterMismatchException">
        /// You have specified a client token for an operation using parameter values that differ
        /// from a previous request that used the same client token.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceAlreadyExistsException">
        /// The resource that you are trying to create already exists.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceInUseException">
        /// The resource that you are trying to operate on is currently in use. Review the message
        /// details and retry later.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceQuotaExceededException">
        /// You have exceeded the number of permitted resources or operations for this service.
        /// For service quotas, see <a href="https://docs.aws.amazon.com/general/latest/gr/imagebuilder.html#limits_imagebuilder">EC2
        /// Image Builder endpoints and quotas</a>.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/CreateLifecyclePolicy">REST API Reference for CreateLifecyclePolicy Operation</seealso>
        public virtual CreateLifecyclePolicyResponse CreateLifecyclePolicy(CreateLifecyclePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateLifecyclePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLifecyclePolicyResponseUnmarshaller.Instance;

            return Invoke<CreateLifecyclePolicyResponse>(request, options);
        }
#else
        internal virtual CreateLifecyclePolicyResponse CreateLifecyclePolicy(CreateLifecyclePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateLifecyclePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLifecyclePolicyResponseUnmarshaller.Instance;

            return Invoke<CreateLifecyclePolicyResponse>(request, options);
        }
#endif

        /// <summary>
        /// Creates a lifecycle policy resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLifecyclePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateLifecyclePolicy service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.DryRunOperationException">
        /// The dry run operation of the resource was successful, and no resources or mutations
        /// were actually performed due to the dry run flag in the request.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.IdempotentParameterMismatchException">
        /// You have specified a client token for an operation using parameter values that differ
        /// from a previous request that used the same client token.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceAlreadyExistsException">
        /// The resource that you are trying to create already exists.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceInUseException">
        /// The resource that you are trying to operate on is currently in use. Review the message
        /// details and retry later.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceQuotaExceededException">
        /// You have exceeded the number of permitted resources or operations for this service.
        /// For service quotas, see <a href="https://docs.aws.amazon.com/general/latest/gr/imagebuilder.html#limits_imagebuilder">EC2
        /// Image Builder endpoints and quotas</a>.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/CreateLifecyclePolicy">REST API Reference for CreateLifecyclePolicy Operation</seealso>
        public virtual Task<CreateLifecyclePolicyResponse> CreateLifecyclePolicyAsync(CreateLifecyclePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateLifecyclePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLifecyclePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLifecyclePolicyResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Creates a new workflow or a new version of an existing workflow. If a workflow with
        /// the same name and semantic version already exists, and your request changes its configuration,
        /// Image Builder creates a new build version. If the configuration is identical to the
        /// latest build version, the request fails because that workflow configuration already
        /// exists.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkflow service method.</param>
        /// <returns>The response from the CreateWorkflow service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.DryRunOperationException">
        /// The dry run operation of the resource was successful, and no resources or mutations
        /// were actually performed due to the dry run flag in the request.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.IdempotentParameterMismatchException">
        /// You have specified a client token for an operation using parameter values that differ
        /// from a previous request that used the same client token.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidParameterCombinationException">
        /// You have specified a combination of parameters that isn't valid. For example, two
        /// mutually exclusive parameters, or a parameter without its required companion parameter.
        /// Review the error message for details.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidVersionNumberException">
        /// Your version number is out of bounds or does not follow the required syntax.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceInUseException">
        /// The resource that you are trying to operate on is currently in use. Review the message
        /// details and retry later.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceQuotaExceededException">
        /// You have exceeded the number of permitted resources or operations for this service.
        /// For service quotas, see <a href="https://docs.aws.amazon.com/general/latest/gr/imagebuilder.html#limits_imagebuilder">EC2
        /// Image Builder endpoints and quotas</a>.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/CreateWorkflow">REST API Reference for CreateWorkflow Operation</seealso>
        public virtual CreateWorkflowResponse CreateWorkflow(CreateWorkflowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkflowResponseUnmarshaller.Instance;

            return Invoke<CreateWorkflowResponse>(request, options);
        }
#else
        internal virtual CreateWorkflowResponse CreateWorkflow(CreateWorkflowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkflowResponseUnmarshaller.Instance;

            return Invoke<CreateWorkflowResponse>(request, options);
        }
#endif

        /// <summary>
        /// Creates a new workflow or a new version of an existing workflow. If a workflow with
        /// the same name and semantic version already exists, and your request changes its configuration,
        /// Image Builder creates a new build version. If the configuration is identical to the
        /// latest build version, the request fails because that workflow configuration already
        /// exists.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkflow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateWorkflow service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.DryRunOperationException">
        /// The dry run operation of the resource was successful, and no resources or mutations
        /// were actually performed due to the dry run flag in the request.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.IdempotentParameterMismatchException">
        /// You have specified a client token for an operation using parameter values that differ
        /// from a previous request that used the same client token.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidParameterCombinationException">
        /// You have specified a combination of parameters that isn't valid. For example, two
        /// mutually exclusive parameters, or a parameter without its required companion parameter.
        /// Review the error message for details.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidVersionNumberException">
        /// Your version number is out of bounds or does not follow the required syntax.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceInUseException">
        /// The resource that you are trying to operate on is currently in use. Review the message
        /// details and retry later.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceQuotaExceededException">
        /// You have exceeded the number of permitted resources or operations for this service.
        /// For service quotas, see <a href="https://docs.aws.amazon.com/general/latest/gr/imagebuilder.html#limits_imagebuilder">EC2
        /// Image Builder endpoints and quotas</a>.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/CreateWorkflow">REST API Reference for CreateWorkflow Operation</seealso>
        public virtual Task<CreateWorkflowResponse> CreateWorkflowAsync(CreateWorkflowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkflowResponseUnmarshaller.Instance;

            return InvokeAsync<CreateWorkflowResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Deletes a component build version. The request fails with <c>ResourceDependencyException</c>
        /// if an image recipe or container recipe references this component version. It also
        /// fails if the component build version is shared with other accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteComponent service method.</param>
        /// <returns>The response from the DeleteComponent service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceDependencyException">
        /// You have attempted to mutate or delete a resource with a dependency that prohibits
        /// this action. See the error message for more details.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/DeleteComponent">REST API Reference for DeleteComponent Operation</seealso>
        public virtual DeleteComponentResponse DeleteComponent(DeleteComponentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteComponentResponseUnmarshaller.Instance;

            return Invoke<DeleteComponentResponse>(request, options);
        }
#else
        internal virtual DeleteComponentResponse DeleteComponent(DeleteComponentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteComponentResponseUnmarshaller.Instance;

            return Invoke<DeleteComponentResponse>(request, options);
        }
#endif

        /// <summary>
        /// Deletes a component build version. The request fails with <c>ResourceDependencyException</c>
        /// if an image recipe or container recipe references this component version. It also
        /// fails if the component build version is shared with other accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteComponent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteComponent service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceDependencyException">
        /// You have attempted to mutate or delete a resource with a dependency that prohibits
        /// this action. See the error message for more details.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/DeleteComponent">REST API Reference for DeleteComponent Operation</seealso>
        public virtual Task<DeleteComponentResponse> DeleteComponentAsync(DeleteComponentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteComponentResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteComponentResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Deletes a container recipe. The request fails with <c>ResourceDependencyException</c>
        /// if the recipe is shared with other accounts, or if an image pipeline references it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteContainerRecipe service method.</param>
        /// <returns>The response from the DeleteContainerRecipe service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceDependencyException">
        /// You have attempted to mutate or delete a resource with a dependency that prohibits
        /// this action. See the error message for more details.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/DeleteContainerRecipe">REST API Reference for DeleteContainerRecipe Operation</seealso>
        public virtual DeleteContainerRecipeResponse DeleteContainerRecipe(DeleteContainerRecipeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteContainerRecipeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteContainerRecipeResponseUnmarshaller.Instance;

            return Invoke<DeleteContainerRecipeResponse>(request, options);
        }
#else
        internal virtual DeleteContainerRecipeResponse DeleteContainerRecipe(DeleteContainerRecipeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteContainerRecipeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteContainerRecipeResponseUnmarshaller.Instance;

            return Invoke<DeleteContainerRecipeResponse>(request, options);
        }
#endif

        /// <summary>
        /// Deletes a container recipe. The request fails with <c>ResourceDependencyException</c>
        /// if the recipe is shared with other accounts, or if an image pipeline references it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteContainerRecipe service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteContainerRecipe service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceDependencyException">
        /// You have attempted to mutate or delete a resource with a dependency that prohibits
        /// this action. See the error message for more details.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/DeleteContainerRecipe">REST API Reference for DeleteContainerRecipe Operation</seealso>
        public virtual Task<DeleteContainerRecipeResponse> DeleteContainerRecipeAsync(DeleteContainerRecipeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteContainerRecipeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteContainerRecipeResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteContainerRecipeResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Deletes a distribution configuration. You can't delete a configuration that an image
        /// pipeline still references. The request fails with <c>ResourceDependencyException</c>.
        /// Update or delete the referencing pipelines first.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDistributionConfiguration service method.</param>
        /// <returns>The response from the DeleteDistributionConfiguration service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceDependencyException">
        /// You have attempted to mutate or delete a resource with a dependency that prohibits
        /// this action. See the error message for more details.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/DeleteDistributionConfiguration">REST API Reference for DeleteDistributionConfiguration Operation</seealso>
        public virtual DeleteDistributionConfigurationResponse DeleteDistributionConfiguration(DeleteDistributionConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDistributionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDistributionConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteDistributionConfigurationResponse>(request, options);
        }
#else
        internal virtual DeleteDistributionConfigurationResponse DeleteDistributionConfiguration(DeleteDistributionConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDistributionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDistributionConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteDistributionConfigurationResponse>(request, options);
        }
#endif

        /// <summary>
        /// Deletes a distribution configuration. You can't delete a configuration that an image
        /// pipeline still references. The request fails with <c>ResourceDependencyException</c>.
        /// Update or delete the referencing pipelines first.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDistributionConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteDistributionConfiguration service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceDependencyException">
        /// You have attempted to mutate or delete a resource with a dependency that prohibits
        /// this action. See the error message for more details.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/DeleteDistributionConfiguration">REST API Reference for DeleteDistributionConfiguration Operation</seealso>
        public virtual Task<DeleteDistributionConfigurationResponse> DeleteDistributionConfigurationAsync(DeleteDistributionConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDistributionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDistributionConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDistributionConfigurationResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Deletes an Image Builder image resource. This does not delete any EC2 AMIs or ECR
        /// container images that are created during the image build process. You must clean those
        /// up separately, using the appropriate Amazon EC2 or Amazon ECR console actions, or
        /// API or CLI commands.
        /// 
        ///  
        /// <para>
        /// The request fails with <c>ResourceDependencyException</c> if the image is shared with
        /// other accounts, or if other resources depend on it. It also fails while the image
        /// build is still running. Cancel an in-progress build with <a>CancelImageCreation</a>
        /// before you delete the image.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To deregister an EC2 Linux AMI, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/deregister-ami.html">Deregister
        /// your Linux AMI</a> in the <i> <i>Amazon EC2 User Guide</i> </i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To deregister an EC2 Windows AMI, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/WindowsGuide/deregister-ami.html">Deregister
        /// your Windows AMI</a> in the <i> <i>Amazon EC2 Windows Guide</i> </i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To delete a container image from Amazon ECR, see <a href="https://docs.aws.amazon.com/AmazonECR/latest/userguide/delete_image.html">Deleting
        /// an image</a> in the <i>Amazon ECR User Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteImage service method.</param>
        /// <returns>The response from the DeleteImage service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceDependencyException">
        /// You have attempted to mutate or delete a resource with a dependency that prohibits
        /// this action. See the error message for more details.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/DeleteImage">REST API Reference for DeleteImage Operation</seealso>
        public virtual DeleteImageResponse DeleteImage(DeleteImageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteImageResponseUnmarshaller.Instance;

            return Invoke<DeleteImageResponse>(request, options);
        }
#else
        internal virtual DeleteImageResponse DeleteImage(DeleteImageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteImageResponseUnmarshaller.Instance;

            return Invoke<DeleteImageResponse>(request, options);
        }
#endif

        /// <summary>
        /// Deletes an Image Builder image resource. This does not delete any EC2 AMIs or ECR
        /// container images that are created during the image build process. You must clean those
        /// up separately, using the appropriate Amazon EC2 or Amazon ECR console actions, or
        /// API or CLI commands.
        /// 
        ///  
        /// <para>
        /// The request fails with <c>ResourceDependencyException</c> if the image is shared with
        /// other accounts, or if other resources depend on it. It also fails while the image
        /// build is still running. Cancel an in-progress build with <a>CancelImageCreation</a>
        /// before you delete the image.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To deregister an EC2 Linux AMI, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/deregister-ami.html">Deregister
        /// your Linux AMI</a> in the <i> <i>Amazon EC2 User Guide</i> </i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To deregister an EC2 Windows AMI, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/WindowsGuide/deregister-ami.html">Deregister
        /// your Windows AMI</a> in the <i> <i>Amazon EC2 Windows Guide</i> </i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To delete a container image from Amazon ECR, see <a href="https://docs.aws.amazon.com/AmazonECR/latest/userguide/delete_image.html">Deleting
        /// an image</a> in the <i>Amazon ECR User Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteImage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteImage service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceDependencyException">
        /// You have attempted to mutate or delete a resource with a dependency that prohibits
        /// this action. See the error message for more details.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/DeleteImage">REST API Reference for DeleteImage Operation</seealso>
        public virtual Task<DeleteImageResponse> DeleteImageAsync(DeleteImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteImageResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteImageResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Deletes an image pipeline. Images that the pipeline created aren't deleted - remove
        /// those separately with <a>DeleteImage</a>. You can delete a pipeline while a build
        /// that it started is still running. The build continues independently.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteImagePipeline service method.</param>
        /// <returns>The response from the DeleteImagePipeline service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceDependencyException">
        /// You have attempted to mutate or delete a resource with a dependency that prohibits
        /// this action. See the error message for more details.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/DeleteImagePipeline">REST API Reference for DeleteImagePipeline Operation</seealso>
        public virtual DeleteImagePipelineResponse DeleteImagePipeline(DeleteImagePipelineRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteImagePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteImagePipelineResponseUnmarshaller.Instance;

            return Invoke<DeleteImagePipelineResponse>(request, options);
        }
#else
        internal virtual DeleteImagePipelineResponse DeleteImagePipeline(DeleteImagePipelineRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteImagePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteImagePipelineResponseUnmarshaller.Instance;

            return Invoke<DeleteImagePipelineResponse>(request, options);
        }
#endif

        /// <summary>
        /// Deletes an image pipeline. Images that the pipeline created aren't deleted - remove
        /// those separately with <a>DeleteImage</a>. You can delete a pipeline while a build
        /// that it started is still running. The build continues independently.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteImagePipeline service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteImagePipeline service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceDependencyException">
        /// You have attempted to mutate or delete a resource with a dependency that prohibits
        /// this action. See the error message for more details.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/DeleteImagePipeline">REST API Reference for DeleteImagePipeline Operation</seealso>
        public virtual Task<DeleteImagePipelineResponse> DeleteImagePipelineAsync(DeleteImagePipelineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteImagePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteImagePipelineResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteImagePipelineResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Deletes an image recipe.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteImageRecipe service method.</param>
        /// <returns>The response from the DeleteImageRecipe service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceDependencyException">
        /// You have attempted to mutate or delete a resource with a dependency that prohibits
        /// this action. See the error message for more details.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/DeleteImageRecipe">REST API Reference for DeleteImageRecipe Operation</seealso>
        public virtual DeleteImageRecipeResponse DeleteImageRecipe(DeleteImageRecipeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteImageRecipeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteImageRecipeResponseUnmarshaller.Instance;

            return Invoke<DeleteImageRecipeResponse>(request, options);
        }
#else
        internal virtual DeleteImageRecipeResponse DeleteImageRecipe(DeleteImageRecipeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteImageRecipeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteImageRecipeResponseUnmarshaller.Instance;

            return Invoke<DeleteImageRecipeResponse>(request, options);
        }
#endif

        /// <summary>
        /// Deletes an image recipe.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteImageRecipe service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteImageRecipe service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceDependencyException">
        /// You have attempted to mutate or delete a resource with a dependency that prohibits
        /// this action. See the error message for more details.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/DeleteImageRecipe">REST API Reference for DeleteImageRecipe Operation</seealso>
        public virtual Task<DeleteImageRecipeResponse> DeleteImageRecipeAsync(DeleteImageRecipeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteImageRecipeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteImageRecipeResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteImageRecipeResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Deletes an infrastructure configuration. You can't delete a configuration that an
        /// image pipeline still references. The request fails with <c>ResourceDependencyException</c>.
        /// Update or delete the referencing pipelines first.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInfrastructureConfiguration service method.</param>
        /// <returns>The response from the DeleteInfrastructureConfiguration service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceDependencyException">
        /// You have attempted to mutate or delete a resource with a dependency that prohibits
        /// this action. See the error message for more details.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/DeleteInfrastructureConfiguration">REST API Reference for DeleteInfrastructureConfiguration Operation</seealso>
        public virtual DeleteInfrastructureConfigurationResponse DeleteInfrastructureConfiguration(DeleteInfrastructureConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteInfrastructureConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInfrastructureConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteInfrastructureConfigurationResponse>(request, options);
        }
#else
        internal virtual DeleteInfrastructureConfigurationResponse DeleteInfrastructureConfiguration(DeleteInfrastructureConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteInfrastructureConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInfrastructureConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteInfrastructureConfigurationResponse>(request, options);
        }
#endif

        /// <summary>
        /// Deletes an infrastructure configuration. You can't delete a configuration that an
        /// image pipeline still references. The request fails with <c>ResourceDependencyException</c>.
        /// Update or delete the referencing pipelines first.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInfrastructureConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteInfrastructureConfiguration service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceDependencyException">
        /// You have attempted to mutate or delete a resource with a dependency that prohibits
        /// this action. See the error message for more details.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/DeleteInfrastructureConfiguration">REST API Reference for DeleteInfrastructureConfiguration Operation</seealso>
        public virtual Task<DeleteInfrastructureConfigurationResponse> DeleteInfrastructureConfigurationAsync(DeleteInfrastructureConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteInfrastructureConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInfrastructureConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteInfrastructureConfigurationResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Deletes the specified lifecycle policy resource. Deleting the policy removes its schedule,
        /// so no further lifecycle runs occur for that policy. If a lifecycle execution is in
        /// progress for the policy, Image Builder cancels it. Deletion doesn't revert actions
        /// that the policy already applied to your resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLifecyclePolicy service method.</param>
        /// <returns>The response from the DeleteLifecyclePolicy service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceDependencyException">
        /// You have attempted to mutate or delete a resource with a dependency that prohibits
        /// this action. See the error message for more details.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/DeleteLifecyclePolicy">REST API Reference for DeleteLifecyclePolicy Operation</seealso>
        public virtual DeleteLifecyclePolicyResponse DeleteLifecyclePolicy(DeleteLifecyclePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteLifecyclePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLifecyclePolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteLifecyclePolicyResponse>(request, options);
        }
#else
        internal virtual DeleteLifecyclePolicyResponse DeleteLifecyclePolicy(DeleteLifecyclePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteLifecyclePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLifecyclePolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteLifecyclePolicyResponse>(request, options);
        }
#endif

        /// <summary>
        /// Deletes the specified lifecycle policy resource. Deleting the policy removes its schedule,
        /// so no further lifecycle runs occur for that policy. If a lifecycle execution is in
        /// progress for the policy, Image Builder cancels it. Deletion doesn't revert actions
        /// that the policy already applied to your resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLifecyclePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteLifecyclePolicy service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceDependencyException">
        /// You have attempted to mutate or delete a resource with a dependency that prohibits
        /// this action. See the error message for more details.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/DeleteLifecyclePolicy">REST API Reference for DeleteLifecyclePolicy Operation</seealso>
        public virtual Task<DeleteLifecyclePolicyResponse> DeleteLifecyclePolicyAsync(DeleteLifecyclePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteLifecyclePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLifecyclePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteLifecyclePolicyResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Deletes a specific workflow resource. You can't delete a workflow build version while
        /// an image pipeline references it. The request fails with <c>ResourceDependencyException</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkflow service method.</param>
        /// <returns>The response from the DeleteWorkflow service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceDependencyException">
        /// You have attempted to mutate or delete a resource with a dependency that prohibits
        /// this action. See the error message for more details.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/DeleteWorkflow">REST API Reference for DeleteWorkflow Operation</seealso>
        public virtual DeleteWorkflowResponse DeleteWorkflow(DeleteWorkflowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkflowResponseUnmarshaller.Instance;

            return Invoke<DeleteWorkflowResponse>(request, options);
        }
#else
        internal virtual DeleteWorkflowResponse DeleteWorkflow(DeleteWorkflowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkflowResponseUnmarshaller.Instance;

            return Invoke<DeleteWorkflowResponse>(request, options);
        }
#endif

        /// <summary>
        /// Deletes a specific workflow resource. You can't delete a workflow build version while
        /// an image pipeline references it. The request fails with <c>ResourceDependencyException</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkflow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteWorkflow service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceDependencyException">
        /// You have attempted to mutate or delete a resource with a dependency that prohibits
        /// this action. See the error message for more details.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/DeleteWorkflow">REST API Reference for DeleteWorkflow Operation</seealso>
        public virtual Task<DeleteWorkflowResponse> DeleteWorkflowAsync(DeleteWorkflowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkflowResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteWorkflowResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Distributes an existing AMI to target Regions and accounts without running the full
        /// image build process. This operation only runs the distribution phase on an image that
        /// has already been built.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DistributeImage service method.</param>
        /// <returns>The response from the DistributeImage service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.AccessDeniedException">
        /// You do not have permissions to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.IdempotentParameterMismatchException">
        /// You have specified a client token for an operation using parameter values that differ
        /// from a previous request that used the same client token.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceInUseException">
        /// The resource that you are trying to operate on is currently in use. Review the message
        /// details and retry later.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceNotFoundException">
        /// At least one of the resources referenced by your request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceQuotaExceededException">
        /// You have exceeded the number of permitted resources or operations for this service.
        /// For service quotas, see <a href="https://docs.aws.amazon.com/general/latest/gr/imagebuilder.html#limits_imagebuilder">EC2
        /// Image Builder endpoints and quotas</a>.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.TooManyRequestsException">
        /// You have attempted too many requests for the specific operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/DistributeImage">REST API Reference for DistributeImage Operation</seealso>
        public virtual DistributeImageResponse DistributeImage(DistributeImageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DistributeImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DistributeImageResponseUnmarshaller.Instance;

            return Invoke<DistributeImageResponse>(request, options);
        }
#else
        internal virtual DistributeImageResponse DistributeImage(DistributeImageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DistributeImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DistributeImageResponseUnmarshaller.Instance;

            return Invoke<DistributeImageResponse>(request, options);
        }
#endif

        /// <summary>
        /// Distributes an existing AMI to target Regions and accounts without running the full
        /// image build process. This operation only runs the distribution phase on an image that
        /// has already been built.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DistributeImage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DistributeImage service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.AccessDeniedException">
        /// You do not have permissions to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.IdempotentParameterMismatchException">
        /// You have specified a client token for an operation using parameter values that differ
        /// from a previous request that used the same client token.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceInUseException">
        /// The resource that you are trying to operate on is currently in use. Review the message
        /// details and retry later.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceNotFoundException">
        /// At least one of the resources referenced by your request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceQuotaExceededException">
        /// You have exceeded the number of permitted resources or operations for this service.
        /// For service quotas, see <a href="https://docs.aws.amazon.com/general/latest/gr/imagebuilder.html#limits_imagebuilder">EC2
        /// Image Builder endpoints and quotas</a>.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.TooManyRequestsException">
        /// You have attempted too many requests for the specific operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/DistributeImage">REST API Reference for DistributeImage Operation</seealso>
        public virtual Task<DistributeImageResponse> DistributeImageAsync(DistributeImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DistributeImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DistributeImageResponseUnmarshaller.Instance;

            return InvokeAsync<DistributeImageResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves a component object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetComponent service method.</param>
        /// <returns>The response from the GetComponent service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/GetComponent">REST API Reference for GetComponent Operation</seealso>
        public virtual GetComponentResponse GetComponent(GetComponentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetComponentResponseUnmarshaller.Instance;

            return Invoke<GetComponentResponse>(request, options);
        }
#else
        internal virtual GetComponentResponse GetComponent(GetComponentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetComponentResponseUnmarshaller.Instance;

            return Invoke<GetComponentResponse>(request, options);
        }
#endif

        /// <summary>
        /// Retrieves a component object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetComponent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetComponent service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/GetComponent">REST API Reference for GetComponent Operation</seealso>
        public virtual Task<GetComponentResponse> GetComponentAsync(GetComponentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetComponentResponseUnmarshaller.Instance;

            return InvokeAsync<GetComponentResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves a component policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetComponentPolicy service method.</param>
        /// <returns>The response from the GetComponentPolicy service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceNotFoundException">
        /// At least one of the resources referenced by your request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/GetComponentPolicy">REST API Reference for GetComponentPolicy Operation</seealso>
        public virtual GetComponentPolicyResponse GetComponentPolicy(GetComponentPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetComponentPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetComponentPolicyResponseUnmarshaller.Instance;

            return Invoke<GetComponentPolicyResponse>(request, options);
        }
#else
        internal virtual GetComponentPolicyResponse GetComponentPolicy(GetComponentPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetComponentPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetComponentPolicyResponseUnmarshaller.Instance;

            return Invoke<GetComponentPolicyResponse>(request, options);
        }
#endif

        /// <summary>
        /// Retrieves a component policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetComponentPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetComponentPolicy service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceNotFoundException">
        /// At least one of the resources referenced by your request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/GetComponentPolicy">REST API Reference for GetComponentPolicy Operation</seealso>
        public virtual Task<GetComponentPolicyResponse> GetComponentPolicyAsync(GetComponentPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetComponentPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetComponentPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetComponentPolicyResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves a container recipe.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContainerRecipe service method.</param>
        /// <returns>The response from the GetContainerRecipe service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/GetContainerRecipe">REST API Reference for GetContainerRecipe Operation</seealso>
        public virtual GetContainerRecipeResponse GetContainerRecipe(GetContainerRecipeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetContainerRecipeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContainerRecipeResponseUnmarshaller.Instance;

            return Invoke<GetContainerRecipeResponse>(request, options);
        }
#else
        internal virtual GetContainerRecipeResponse GetContainerRecipe(GetContainerRecipeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetContainerRecipeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContainerRecipeResponseUnmarshaller.Instance;

            return Invoke<GetContainerRecipeResponse>(request, options);
        }
#endif

        /// <summary>
        /// Retrieves a container recipe.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContainerRecipe service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetContainerRecipe service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/GetContainerRecipe">REST API Reference for GetContainerRecipe Operation</seealso>
        public virtual Task<GetContainerRecipeResponse> GetContainerRecipeAsync(GetContainerRecipeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetContainerRecipeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContainerRecipeResponseUnmarshaller.Instance;

            return InvokeAsync<GetContainerRecipeResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves the policy for a container recipe.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContainerRecipePolicy service method.</param>
        /// <returns>The response from the GetContainerRecipePolicy service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceNotFoundException">
        /// At least one of the resources referenced by your request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/GetContainerRecipePolicy">REST API Reference for GetContainerRecipePolicy Operation</seealso>
        public virtual GetContainerRecipePolicyResponse GetContainerRecipePolicy(GetContainerRecipePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetContainerRecipePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContainerRecipePolicyResponseUnmarshaller.Instance;

            return Invoke<GetContainerRecipePolicyResponse>(request, options);
        }
#else
        internal virtual GetContainerRecipePolicyResponse GetContainerRecipePolicy(GetContainerRecipePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetContainerRecipePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContainerRecipePolicyResponseUnmarshaller.Instance;

            return Invoke<GetContainerRecipePolicyResponse>(request, options);
        }
#endif

        /// <summary>
        /// Retrieves the policy for a container recipe.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContainerRecipePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetContainerRecipePolicy service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceNotFoundException">
        /// At least one of the resources referenced by your request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/GetContainerRecipePolicy">REST API Reference for GetContainerRecipePolicy Operation</seealso>
        public virtual Task<GetContainerRecipePolicyResponse> GetContainerRecipePolicyAsync(GetContainerRecipePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetContainerRecipePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContainerRecipePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetContainerRecipePolicyResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves a distribution configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDistributionConfiguration service method.</param>
        /// <returns>The response from the GetDistributionConfiguration service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/GetDistributionConfiguration">REST API Reference for GetDistributionConfiguration Operation</seealso>
        public virtual GetDistributionConfigurationResponse GetDistributionConfiguration(GetDistributionConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDistributionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDistributionConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetDistributionConfigurationResponse>(request, options);
        }
#else
        internal virtual GetDistributionConfigurationResponse GetDistributionConfiguration(GetDistributionConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDistributionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDistributionConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetDistributionConfigurationResponse>(request, options);
        }
#endif

        /// <summary>
        /// Retrieves a distribution configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDistributionConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetDistributionConfiguration service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/GetDistributionConfiguration">REST API Reference for GetDistributionConfiguration Operation</seealso>
        public virtual Task<GetDistributionConfigurationResponse> GetDistributionConfigurationAsync(GetDistributionConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDistributionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDistributionConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<GetDistributionConfigurationResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves an image.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetImage service method.</param>
        /// <returns>The response from the GetImage service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/GetImage">REST API Reference for GetImage Operation</seealso>
        public virtual GetImageResponse GetImage(GetImageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetImageResponseUnmarshaller.Instance;

            return Invoke<GetImageResponse>(request, options);
        }
#else
        internal virtual GetImageResponse GetImage(GetImageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetImageResponseUnmarshaller.Instance;

            return Invoke<GetImageResponse>(request, options);
        }
#endif

        /// <summary>
        /// Retrieves an image.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetImage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetImage service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/GetImage">REST API Reference for GetImage Operation</seealso>
        public virtual Task<GetImageResponse> GetImageAsync(GetImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetImageResponseUnmarshaller.Instance;

            return InvokeAsync<GetImageResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves an image pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetImagePipeline service method.</param>
        /// <returns>The response from the GetImagePipeline service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/GetImagePipeline">REST API Reference for GetImagePipeline Operation</seealso>
        public virtual GetImagePipelineResponse GetImagePipeline(GetImagePipelineRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetImagePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetImagePipelineResponseUnmarshaller.Instance;

            return Invoke<GetImagePipelineResponse>(request, options);
        }
#else
        internal virtual GetImagePipelineResponse GetImagePipeline(GetImagePipelineRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetImagePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetImagePipelineResponseUnmarshaller.Instance;

            return Invoke<GetImagePipelineResponse>(request, options);
        }
#endif

        /// <summary>
        /// Retrieves an image pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetImagePipeline service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetImagePipeline service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/GetImagePipeline">REST API Reference for GetImagePipeline Operation</seealso>
        public virtual Task<GetImagePipelineResponse> GetImagePipelineAsync(GetImagePipelineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetImagePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetImagePipelineResponseUnmarshaller.Instance;

            return InvokeAsync<GetImagePipelineResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves an image policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetImagePolicy service method.</param>
        /// <returns>The response from the GetImagePolicy service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceNotFoundException">
        /// At least one of the resources referenced by your request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/GetImagePolicy">REST API Reference for GetImagePolicy Operation</seealso>
        public virtual GetImagePolicyResponse GetImagePolicy(GetImagePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetImagePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetImagePolicyResponseUnmarshaller.Instance;

            return Invoke<GetImagePolicyResponse>(request, options);
        }
#else
        internal virtual GetImagePolicyResponse GetImagePolicy(GetImagePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetImagePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetImagePolicyResponseUnmarshaller.Instance;

            return Invoke<GetImagePolicyResponse>(request, options);
        }
#endif

        /// <summary>
        /// Retrieves an image policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetImagePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetImagePolicy service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceNotFoundException">
        /// At least one of the resources referenced by your request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/GetImagePolicy">REST API Reference for GetImagePolicy Operation</seealso>
        public virtual Task<GetImagePolicyResponse> GetImagePolicyAsync(GetImagePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetImagePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetImagePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetImagePolicyResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves an image recipe.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetImageRecipe service method.</param>
        /// <returns>The response from the GetImageRecipe service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/GetImageRecipe">REST API Reference for GetImageRecipe Operation</seealso>
        public virtual GetImageRecipeResponse GetImageRecipe(GetImageRecipeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetImageRecipeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetImageRecipeResponseUnmarshaller.Instance;

            return Invoke<GetImageRecipeResponse>(request, options);
        }
#else
        internal virtual GetImageRecipeResponse GetImageRecipe(GetImageRecipeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetImageRecipeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetImageRecipeResponseUnmarshaller.Instance;

            return Invoke<GetImageRecipeResponse>(request, options);
        }
#endif

        /// <summary>
        /// Retrieves an image recipe.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetImageRecipe service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetImageRecipe service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/GetImageRecipe">REST API Reference for GetImageRecipe Operation</seealso>
        public virtual Task<GetImageRecipeResponse> GetImageRecipeAsync(GetImageRecipeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetImageRecipeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetImageRecipeResponseUnmarshaller.Instance;

            return InvokeAsync<GetImageRecipeResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves an image recipe policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetImageRecipePolicy service method.</param>
        /// <returns>The response from the GetImageRecipePolicy service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceNotFoundException">
        /// At least one of the resources referenced by your request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/GetImageRecipePolicy">REST API Reference for GetImageRecipePolicy Operation</seealso>
        public virtual GetImageRecipePolicyResponse GetImageRecipePolicy(GetImageRecipePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetImageRecipePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetImageRecipePolicyResponseUnmarshaller.Instance;

            return Invoke<GetImageRecipePolicyResponse>(request, options);
        }
#else
        internal virtual GetImageRecipePolicyResponse GetImageRecipePolicy(GetImageRecipePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetImageRecipePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetImageRecipePolicyResponseUnmarshaller.Instance;

            return Invoke<GetImageRecipePolicyResponse>(request, options);
        }
#endif

        /// <summary>
        /// Retrieves an image recipe policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetImageRecipePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetImageRecipePolicy service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceNotFoundException">
        /// At least one of the resources referenced by your request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/GetImageRecipePolicy">REST API Reference for GetImageRecipePolicy Operation</seealso>
        public virtual Task<GetImageRecipePolicyResponse> GetImageRecipePolicyAsync(GetImageRecipePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetImageRecipePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetImageRecipePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetImageRecipePolicyResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves an infrastructure configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInfrastructureConfiguration service method.</param>
        /// <returns>The response from the GetInfrastructureConfiguration service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/GetInfrastructureConfiguration">REST API Reference for GetInfrastructureConfiguration Operation</seealso>
        public virtual GetInfrastructureConfigurationResponse GetInfrastructureConfiguration(GetInfrastructureConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetInfrastructureConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInfrastructureConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetInfrastructureConfigurationResponse>(request, options);
        }
#else
        internal virtual GetInfrastructureConfigurationResponse GetInfrastructureConfiguration(GetInfrastructureConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetInfrastructureConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInfrastructureConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetInfrastructureConfigurationResponse>(request, options);
        }
#endif

        /// <summary>
        /// Retrieves an infrastructure configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInfrastructureConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetInfrastructureConfiguration service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/GetInfrastructureConfiguration">REST API Reference for GetInfrastructureConfiguration Operation</seealso>
        public virtual Task<GetInfrastructureConfigurationResponse> GetInfrastructureConfigurationAsync(GetInfrastructureConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetInfrastructureConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInfrastructureConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<GetInfrastructureConfigurationResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves runtime information for a lifecycle execution – a single run of lifecycle
        /// actions that a lifecycle policy or a <a>StartResourceStateUpdate</a> request started.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLifecycleExecution service method.</param>
        /// <returns>The response from the GetLifecycleExecution service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/GetLifecycleExecution">REST API Reference for GetLifecycleExecution Operation</seealso>
        public virtual GetLifecycleExecutionResponse GetLifecycleExecution(GetLifecycleExecutionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetLifecycleExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLifecycleExecutionResponseUnmarshaller.Instance;

            return Invoke<GetLifecycleExecutionResponse>(request, options);
        }
#else
        internal virtual GetLifecycleExecutionResponse GetLifecycleExecution(GetLifecycleExecutionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetLifecycleExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLifecycleExecutionResponseUnmarshaller.Instance;

            return Invoke<GetLifecycleExecutionResponse>(request, options);
        }
#endif

        /// <summary>
        /// Retrieves runtime information for a lifecycle execution – a single run of lifecycle
        /// actions that a lifecycle policy or a <a>StartResourceStateUpdate</a> request started.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLifecycleExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetLifecycleExecution service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/GetLifecycleExecution">REST API Reference for GetLifecycleExecution Operation</seealso>
        public virtual Task<GetLifecycleExecutionResponse> GetLifecycleExecutionAsync(GetLifecycleExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetLifecycleExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLifecycleExecutionResponseUnmarshaller.Instance;

            return InvokeAsync<GetLifecycleExecutionResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves details for the specified image lifecycle policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLifecyclePolicy service method.</param>
        /// <returns>The response from the GetLifecyclePolicy service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/GetLifecyclePolicy">REST API Reference for GetLifecyclePolicy Operation</seealso>
        public virtual GetLifecyclePolicyResponse GetLifecyclePolicy(GetLifecyclePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetLifecyclePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLifecyclePolicyResponseUnmarshaller.Instance;

            return Invoke<GetLifecyclePolicyResponse>(request, options);
        }
#else
        internal virtual GetLifecyclePolicyResponse GetLifecyclePolicy(GetLifecyclePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetLifecyclePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLifecyclePolicyResponseUnmarshaller.Instance;

            return Invoke<GetLifecyclePolicyResponse>(request, options);
        }
#endif

        /// <summary>
        /// Retrieves details for the specified image lifecycle policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLifecyclePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetLifecyclePolicy service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/GetLifecyclePolicy">REST API Reference for GetLifecyclePolicy Operation</seealso>
        public virtual Task<GetLifecyclePolicyResponse> GetLifecyclePolicyAsync(GetLifecyclePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetLifecyclePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLifecyclePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetLifecyclePolicyResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Verifies the subscription and performs resource dependency checks on the requested
        /// Amazon Web Services Marketplace resource. The caller must be entitled to the resource.
        /// For Amazon Web Services Marketplace components, the response contains fields to download
        /// the components and their artifacts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMarketplaceResource service method.</param>
        /// <returns>The response from the GetMarketplaceResource service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/GetMarketplaceResource">REST API Reference for GetMarketplaceResource Operation</seealso>
        public virtual GetMarketplaceResourceResponse GetMarketplaceResource(GetMarketplaceResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMarketplaceResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMarketplaceResourceResponseUnmarshaller.Instance;

            return Invoke<GetMarketplaceResourceResponse>(request, options);
        }
#else
        internal virtual GetMarketplaceResourceResponse GetMarketplaceResource(GetMarketplaceResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMarketplaceResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMarketplaceResourceResponseUnmarshaller.Instance;

            return Invoke<GetMarketplaceResourceResponse>(request, options);
        }
#endif

        /// <summary>
        /// Verifies the subscription and performs resource dependency checks on the requested
        /// Amazon Web Services Marketplace resource. The caller must be entitled to the resource.
        /// For Amazon Web Services Marketplace components, the response contains fields to download
        /// the components and their artifacts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMarketplaceResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetMarketplaceResource service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/GetMarketplaceResource">REST API Reference for GetMarketplaceResource Operation</seealso>
        public virtual Task<GetMarketplaceResourceResponse> GetMarketplaceResourceAsync(GetMarketplaceResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMarketplaceResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMarketplaceResourceResponseUnmarshaller.Instance;

            return InvokeAsync<GetMarketplaceResourceResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves a workflow resource object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflow service method.</param>
        /// <returns>The response from the GetWorkflow service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/GetWorkflow">REST API Reference for GetWorkflow Operation</seealso>
        public virtual GetWorkflowResponse GetWorkflow(GetWorkflowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkflowResponseUnmarshaller.Instance;

            return Invoke<GetWorkflowResponse>(request, options);
        }
#else
        internal virtual GetWorkflowResponse GetWorkflow(GetWorkflowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkflowResponseUnmarshaller.Instance;

            return Invoke<GetWorkflowResponse>(request, options);
        }
#endif

        /// <summary>
        /// Retrieves a workflow resource object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetWorkflow service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/GetWorkflow">REST API Reference for GetWorkflow Operation</seealso>
        public virtual Task<GetWorkflowResponse> GetWorkflowAsync(GetWorkflowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkflowResponseUnmarshaller.Instance;

            return InvokeAsync<GetWorkflowResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves runtime information for a specific runtime instance of the workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflowExecution service method.</param>
        /// <returns>The response from the GetWorkflowExecution service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/GetWorkflowExecution">REST API Reference for GetWorkflowExecution Operation</seealso>
        public virtual GetWorkflowExecutionResponse GetWorkflowExecution(GetWorkflowExecutionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWorkflowExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkflowExecutionResponseUnmarshaller.Instance;

            return Invoke<GetWorkflowExecutionResponse>(request, options);
        }
#else
        internal virtual GetWorkflowExecutionResponse GetWorkflowExecution(GetWorkflowExecutionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWorkflowExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkflowExecutionResponseUnmarshaller.Instance;

            return Invoke<GetWorkflowExecutionResponse>(request, options);
        }
#endif

        /// <summary>
        /// Retrieves runtime information for a specific runtime instance of the workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflowExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetWorkflowExecution service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/GetWorkflowExecution">REST API Reference for GetWorkflowExecution Operation</seealso>
        public virtual Task<GetWorkflowExecutionResponse> GetWorkflowExecutionAsync(GetWorkflowExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWorkflowExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkflowExecutionResponseUnmarshaller.Instance;

            return InvokeAsync<GetWorkflowExecutionResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves runtime information for a specific runtime instance of the workflow step.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflowStepExecution service method.</param>
        /// <returns>The response from the GetWorkflowStepExecution service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/GetWorkflowStepExecution">REST API Reference for GetWorkflowStepExecution Operation</seealso>
        public virtual GetWorkflowStepExecutionResponse GetWorkflowStepExecution(GetWorkflowStepExecutionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWorkflowStepExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkflowStepExecutionResponseUnmarshaller.Instance;

            return Invoke<GetWorkflowStepExecutionResponse>(request, options);
        }
#else
        internal virtual GetWorkflowStepExecutionResponse GetWorkflowStepExecution(GetWorkflowStepExecutionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWorkflowStepExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkflowStepExecutionResponseUnmarshaller.Instance;

            return Invoke<GetWorkflowStepExecutionResponse>(request, options);
        }
#endif

        /// <summary>
        /// Retrieves runtime information for a specific runtime instance of the workflow step.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflowStepExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetWorkflowStepExecution service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/GetWorkflowStepExecution">REST API Reference for GetWorkflowStepExecution Operation</seealso>
        public virtual Task<GetWorkflowStepExecutionResponse> GetWorkflowStepExecutionAsync(GetWorkflowStepExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWorkflowStepExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkflowStepExecutionResponseUnmarshaller.Instance;

            return InvokeAsync<GetWorkflowStepExecutionResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Imports a component and transforms its data into a component document. For the <c>SHELL</c>
        /// format, Image Builder wraps your script in a component document with a single step
        /// that runs the script.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportComponent service method.</param>
        /// <returns>The response from the ImportComponent service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.IdempotentParameterMismatchException">
        /// You have specified a client token for an operation using parameter values that differ
        /// from a previous request that used the same client token.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidParameterCombinationException">
        /// You have specified a combination of parameters that isn't valid. For example, two
        /// mutually exclusive parameters, or a parameter without its required companion parameter.
        /// Review the error message for details.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidVersionNumberException">
        /// Your version number is out of bounds or does not follow the required syntax.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceInUseException">
        /// The resource that you are trying to operate on is currently in use. Review the message
        /// details and retry later.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ImportComponent">REST API Reference for ImportComponent Operation</seealso>
        public virtual ImportComponentResponse ImportComponent(ImportComponentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ImportComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportComponentResponseUnmarshaller.Instance;

            return Invoke<ImportComponentResponse>(request, options);
        }
#else
        internal virtual ImportComponentResponse ImportComponent(ImportComponentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ImportComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportComponentResponseUnmarshaller.Instance;

            return Invoke<ImportComponentResponse>(request, options);
        }
#endif

        /// <summary>
        /// Imports a component and transforms its data into a component document. For the <c>SHELL</c>
        /// format, Image Builder wraps your script in a component document with a single step
        /// that runs the script.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportComponent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ImportComponent service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.IdempotentParameterMismatchException">
        /// You have specified a client token for an operation using parameter values that differ
        /// from a previous request that used the same client token.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidParameterCombinationException">
        /// You have specified a combination of parameters that isn't valid. For example, two
        /// mutually exclusive parameters, or a parameter without its required companion parameter.
        /// Review the error message for details.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidVersionNumberException">
        /// Your version number is out of bounds or does not follow the required syntax.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceInUseException">
        /// The resource that you are trying to operate on is currently in use. Review the message
        /// details and retry later.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ImportComponent">REST API Reference for ImportComponent Operation</seealso>
        public virtual Task<ImportComponentResponse> ImportComponentAsync(ImportComponentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ImportComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportComponentResponseUnmarshaller.Instance;

            return InvokeAsync<ImportComponentResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Imports a Windows operating system image from a verified Microsoft ISO disk file.
        /// The following disk images are supported:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Windows 11 Enterprise
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The response returns as soon as Image Builder creates the new image resource in the
        /// <c>PENDING</c> state. The conversion from ISO file to AMI then runs asynchronously
        /// on an EC2 instance that Image Builder launches with the specified infrastructure configuration.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportDiskImage service method.</param>
        /// <returns>The response from the ImportDiskImage service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.AccessDeniedException">
        /// You do not have permissions to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.TooManyRequestsException">
        /// You have attempted too many requests for the specific operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ImportDiskImage">REST API Reference for ImportDiskImage Operation</seealso>
        public virtual ImportDiskImageResponse ImportDiskImage(ImportDiskImageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ImportDiskImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportDiskImageResponseUnmarshaller.Instance;

            return Invoke<ImportDiskImageResponse>(request, options);
        }
#else
        internal virtual ImportDiskImageResponse ImportDiskImage(ImportDiskImageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ImportDiskImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportDiskImageResponseUnmarshaller.Instance;

            return Invoke<ImportDiskImageResponse>(request, options);
        }
#endif

        /// <summary>
        /// Imports a Windows operating system image from a verified Microsoft ISO disk file.
        /// The following disk images are supported:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Windows 11 Enterprise
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The response returns as soon as Image Builder creates the new image resource in the
        /// <c>PENDING</c> state. The conversion from ISO file to AMI then runs asynchronously
        /// on an EC2 instance that Image Builder launches with the specified infrastructure configuration.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportDiskImage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ImportDiskImage service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.AccessDeniedException">
        /// You do not have permissions to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.TooManyRequestsException">
        /// You have attempted too many requests for the specific operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ImportDiskImage">REST API Reference for ImportDiskImage Operation</seealso>
        public virtual Task<ImportDiskImageResponse> ImportDiskImageAsync(ImportDiskImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ImportDiskImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportDiskImageResponseUnmarshaller.Instance;

            return InvokeAsync<ImportDiskImageResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Creates an Image Builder image resource from an Amazon EC2 VM import task. The response
        /// returns as soon as Image Builder creates the image resource in the <c>PENDING</c>
        /// state. Image Builder then monitors the import task asynchronously. When the task completes,
        /// Image Builder records the AMI that it produced as the new image's output resource
        /// and marks the image <c>AVAILABLE</c>. You can then use the imported image as the base
        /// image for your recipes.
        /// 
        ///  
        /// <para>
        /// To create the VM import task, use the Amazon EC2 API <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_ImportImage.html">ImportImage</a>
        /// operation, or the <a href="https://docs.aws.amazon.com/cli/latest/reference/ec2/import-image.html">import-image</a>
        /// CLI command.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportVmImage service method.</param>
        /// <returns>The response from the ImportVmImage service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ImportVmImage">REST API Reference for ImportVmImage Operation</seealso>
        public virtual ImportVmImageResponse ImportVmImage(ImportVmImageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ImportVmImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportVmImageResponseUnmarshaller.Instance;

            return Invoke<ImportVmImageResponse>(request, options);
        }
#else
        internal virtual ImportVmImageResponse ImportVmImage(ImportVmImageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ImportVmImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportVmImageResponseUnmarshaller.Instance;

            return Invoke<ImportVmImageResponse>(request, options);
        }
#endif

        /// <summary>
        /// Creates an Image Builder image resource from an Amazon EC2 VM import task. The response
        /// returns as soon as Image Builder creates the image resource in the <c>PENDING</c>
        /// state. Image Builder then monitors the import task asynchronously. When the task completes,
        /// Image Builder records the AMI that it produced as the new image's output resource
        /// and marks the image <c>AVAILABLE</c>. You can then use the imported image as the base
        /// image for your recipes.
        /// 
        ///  
        /// <para>
        /// To create the VM import task, use the Amazon EC2 API <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_ImportImage.html">ImportImage</a>
        /// operation, or the <a href="https://docs.aws.amazon.com/cli/latest/reference/ec2/import-image.html">import-image</a>
        /// CLI command.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportVmImage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ImportVmImage service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ImportVmImage">REST API Reference for ImportVmImage Operation</seealso>
        public virtual Task<ImportVmImageResponse> ImportVmImageAsync(ImportVmImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ImportVmImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportVmImageResponseUnmarshaller.Instance;

            return InvokeAsync<ImportVmImageResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Returns a list of component build versions for the specified component version ARN.
        /// You can only list build versions for components that your account owns. Deprecated
        /// build versions aren't included in the results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListComponentBuildVersions service method.</param>
        /// <returns>The response from the ListComponentBuildVersions service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidPaginationTokenException">
        /// You have provided an invalid pagination token in your request.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ListComponentBuildVersions">REST API Reference for ListComponentBuildVersions Operation</seealso>
        public virtual ListComponentBuildVersionsResponse ListComponentBuildVersions(ListComponentBuildVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListComponentBuildVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListComponentBuildVersionsResponseUnmarshaller.Instance;

            return Invoke<ListComponentBuildVersionsResponse>(request, options);
        }
#else
        internal virtual ListComponentBuildVersionsResponse ListComponentBuildVersions(ListComponentBuildVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListComponentBuildVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListComponentBuildVersionsResponseUnmarshaller.Instance;

            return Invoke<ListComponentBuildVersionsResponse>(request, options);
        }
#endif

        /// <summary>
        /// Returns a list of component build versions for the specified component version ARN.
        /// You can only list build versions for components that your account owns. Deprecated
        /// build versions aren't included in the results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListComponentBuildVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListComponentBuildVersions service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidPaginationTokenException">
        /// You have provided an invalid pagination token in your request.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ListComponentBuildVersions">REST API Reference for ListComponentBuildVersions Operation</seealso>
        public virtual Task<ListComponentBuildVersionsResponse> ListComponentBuildVersionsAsync(ListComponentBuildVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListComponentBuildVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListComponentBuildVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListComponentBuildVersionsResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Returns the list of components that you have access to. By default, the response doesn't
        /// include components in the <c>DEPRECATED</c> state. To list deprecated components,
        /// use the <c>status</c> filter with the value <c>DEPRECATED</c>.
        /// 
        ///  <note> 
        /// <para>
        /// The semantic version has four nodes: &lt;major&gt;.&lt;minor&gt;.&lt;patch&gt;/&lt;build&gt;.
        /// You can assign values for the first three, and can filter on all of them.
        /// </para>
        ///  
        /// <para>
        ///  <b>Filtering:</b> You can use wildcards (x) to specify the most recent versions or
        /// nodes when selecting the base image or components for your recipe. When you use a
        /// wildcard in any node, all nodes to the right of the first wildcard must also be wildcards.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListComponents service method.</param>
        /// <returns>The response from the ListComponents service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidPaginationTokenException">
        /// You have provided an invalid pagination token in your request.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ListComponents">REST API Reference for ListComponents Operation</seealso>
        public virtual ListComponentsResponse ListComponents(ListComponentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListComponentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListComponentsResponseUnmarshaller.Instance;

            return Invoke<ListComponentsResponse>(request, options);
        }
#else
        internal virtual ListComponentsResponse ListComponents(ListComponentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListComponentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListComponentsResponseUnmarshaller.Instance;

            return Invoke<ListComponentsResponse>(request, options);
        }
#endif

        /// <summary>
        /// Returns the list of components that you have access to. By default, the response doesn't
        /// include components in the <c>DEPRECATED</c> state. To list deprecated components,
        /// use the <c>status</c> filter with the value <c>DEPRECATED</c>.
        /// 
        ///  <note> 
        /// <para>
        /// The semantic version has four nodes: &lt;major&gt;.&lt;minor&gt;.&lt;patch&gt;/&lt;build&gt;.
        /// You can assign values for the first three, and can filter on all of them.
        /// </para>
        ///  
        /// <para>
        ///  <b>Filtering:</b> You can use wildcards (x) to specify the most recent versions or
        /// nodes when selecting the base image or components for your recipe. When you use a
        /// wildcard in any node, all nodes to the right of the first wildcard must also be wildcards.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListComponents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListComponents service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidPaginationTokenException">
        /// You have provided an invalid pagination token in your request.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ListComponents">REST API Reference for ListComponents Operation</seealso>
        public virtual Task<ListComponentsResponse> ListComponentsAsync(ListComponentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListComponentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListComponentsResponseUnmarshaller.Instance;

            return InvokeAsync<ListComponentsResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Returns a list of container recipes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListContainerRecipes service method.</param>
        /// <returns>The response from the ListContainerRecipes service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidPaginationTokenException">
        /// You have provided an invalid pagination token in your request.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ListContainerRecipes">REST API Reference for ListContainerRecipes Operation</seealso>
        public virtual ListContainerRecipesResponse ListContainerRecipes(ListContainerRecipesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListContainerRecipesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListContainerRecipesResponseUnmarshaller.Instance;

            return Invoke<ListContainerRecipesResponse>(request, options);
        }
#else
        internal virtual ListContainerRecipesResponse ListContainerRecipes(ListContainerRecipesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListContainerRecipesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListContainerRecipesResponseUnmarshaller.Instance;

            return Invoke<ListContainerRecipesResponse>(request, options);
        }
#endif

        /// <summary>
        /// Returns a list of container recipes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListContainerRecipes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListContainerRecipes service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidPaginationTokenException">
        /// You have provided an invalid pagination token in your request.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ListContainerRecipes">REST API Reference for ListContainerRecipes Operation</seealso>
        public virtual Task<ListContainerRecipesResponse> ListContainerRecipesAsync(ListContainerRecipesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListContainerRecipesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListContainerRecipesResponseUnmarshaller.Instance;

            return InvokeAsync<ListContainerRecipesResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Returns a list of distribution configurations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDistributionConfigurations service method.</param>
        /// <returns>The response from the ListDistributionConfigurations service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidPaginationTokenException">
        /// You have provided an invalid pagination token in your request.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ListDistributionConfigurations">REST API Reference for ListDistributionConfigurations Operation</seealso>
        public virtual ListDistributionConfigurationsResponse ListDistributionConfigurations(ListDistributionConfigurationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDistributionConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDistributionConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListDistributionConfigurationsResponse>(request, options);
        }
#else
        internal virtual ListDistributionConfigurationsResponse ListDistributionConfigurations(ListDistributionConfigurationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDistributionConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDistributionConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListDistributionConfigurationsResponse>(request, options);
        }
#endif

        /// <summary>
        /// Returns a list of distribution configurations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDistributionConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListDistributionConfigurations service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidPaginationTokenException">
        /// You have provided an invalid pagination token in your request.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ListDistributionConfigurations">REST API Reference for ListDistributionConfigurations Operation</seealso>
        public virtual Task<ListDistributionConfigurationsResponse> ListDistributionConfigurationsAsync(ListDistributionConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDistributionConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDistributionConfigurationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDistributionConfigurationsResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Returns a list of image build versions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListImageBuildVersions service method.</param>
        /// <returns>The response from the ListImageBuildVersions service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidPaginationTokenException">
        /// You have provided an invalid pagination token in your request.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ListImageBuildVersions">REST API Reference for ListImageBuildVersions Operation</seealso>
        public virtual ListImageBuildVersionsResponse ListImageBuildVersions(ListImageBuildVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListImageBuildVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListImageBuildVersionsResponseUnmarshaller.Instance;

            return Invoke<ListImageBuildVersionsResponse>(request, options);
        }
#else
        internal virtual ListImageBuildVersionsResponse ListImageBuildVersions(ListImageBuildVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListImageBuildVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListImageBuildVersionsResponseUnmarshaller.Instance;

            return Invoke<ListImageBuildVersionsResponse>(request, options);
        }
#endif

        /// <summary>
        /// Returns a list of image build versions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListImageBuildVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListImageBuildVersions service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidPaginationTokenException">
        /// You have provided an invalid pagination token in your request.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ListImageBuildVersions">REST API Reference for ListImageBuildVersions Operation</seealso>
        public virtual Task<ListImageBuildVersionsResponse> ListImageBuildVersionsAsync(ListImageBuildVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListImageBuildVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListImageBuildVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListImageBuildVersionsResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Lists the packages that are associated with an image build version, as determined
        /// by Amazon Web Services Systems Manager Inventory at build time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListImagePackages service method.</param>
        /// <returns>The response from the ListImagePackages service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidPaginationTokenException">
        /// You have provided an invalid pagination token in your request.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceNotFoundException">
        /// At least one of the resources referenced by your request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ListImagePackages">REST API Reference for ListImagePackages Operation</seealso>
        public virtual ListImagePackagesResponse ListImagePackages(ListImagePackagesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListImagePackagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListImagePackagesResponseUnmarshaller.Instance;

            return Invoke<ListImagePackagesResponse>(request, options);
        }
#else
        internal virtual ListImagePackagesResponse ListImagePackages(ListImagePackagesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListImagePackagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListImagePackagesResponseUnmarshaller.Instance;

            return Invoke<ListImagePackagesResponse>(request, options);
        }
#endif

        /// <summary>
        /// Lists the packages that are associated with an image build version, as determined
        /// by Amazon Web Services Systems Manager Inventory at build time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListImagePackages service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListImagePackages service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidPaginationTokenException">
        /// You have provided an invalid pagination token in your request.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceNotFoundException">
        /// At least one of the resources referenced by your request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ListImagePackages">REST API Reference for ListImagePackages Operation</seealso>
        public virtual Task<ListImagePackagesResponse> ListImagePackagesAsync(ListImagePackagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListImagePackagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListImagePackagesResponseUnmarshaller.Instance;

            return InvokeAsync<ListImagePackagesResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Returns a list of images created by the specified pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListImagePipelineImages service method.</param>
        /// <returns>The response from the ListImagePipelineImages service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidPaginationTokenException">
        /// You have provided an invalid pagination token in your request.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceNotFoundException">
        /// At least one of the resources referenced by your request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ListImagePipelineImages">REST API Reference for ListImagePipelineImages Operation</seealso>
        public virtual ListImagePipelineImagesResponse ListImagePipelineImages(ListImagePipelineImagesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListImagePipelineImagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListImagePipelineImagesResponseUnmarshaller.Instance;

            return Invoke<ListImagePipelineImagesResponse>(request, options);
        }
#else
        internal virtual ListImagePipelineImagesResponse ListImagePipelineImages(ListImagePipelineImagesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListImagePipelineImagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListImagePipelineImagesResponseUnmarshaller.Instance;

            return Invoke<ListImagePipelineImagesResponse>(request, options);
        }
#endif

        /// <summary>
        /// Returns a list of images created by the specified pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListImagePipelineImages service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListImagePipelineImages service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidPaginationTokenException">
        /// You have provided an invalid pagination token in your request.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceNotFoundException">
        /// At least one of the resources referenced by your request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ListImagePipelineImages">REST API Reference for ListImagePipelineImages Operation</seealso>
        public virtual Task<ListImagePipelineImagesResponse> ListImagePipelineImagesAsync(ListImagePipelineImagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListImagePipelineImagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListImagePipelineImagesResponseUnmarshaller.Instance;

            return InvokeAsync<ListImagePipelineImagesResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Returns a list of image pipelines.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListImagePipelines service method.</param>
        /// <returns>The response from the ListImagePipelines service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidPaginationTokenException">
        /// You have provided an invalid pagination token in your request.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ListImagePipelines">REST API Reference for ListImagePipelines Operation</seealso>
        public virtual ListImagePipelinesResponse ListImagePipelines(ListImagePipelinesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListImagePipelinesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListImagePipelinesResponseUnmarshaller.Instance;

            return Invoke<ListImagePipelinesResponse>(request, options);
        }
#else
        internal virtual ListImagePipelinesResponse ListImagePipelines(ListImagePipelinesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListImagePipelinesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListImagePipelinesResponseUnmarshaller.Instance;

            return Invoke<ListImagePipelinesResponse>(request, options);
        }
#endif

        /// <summary>
        /// Returns a list of image pipelines.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListImagePipelines service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListImagePipelines service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidPaginationTokenException">
        /// You have provided an invalid pagination token in your request.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ListImagePipelines">REST API Reference for ListImagePipelines Operation</seealso>
        public virtual Task<ListImagePipelinesResponse> ListImagePipelinesAsync(ListImagePipelinesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListImagePipelinesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListImagePipelinesResponseUnmarshaller.Instance;

            return InvokeAsync<ListImagePipelinesResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Returns a list of image recipes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListImageRecipes service method.</param>
        /// <returns>The response from the ListImageRecipes service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidPaginationTokenException">
        /// You have provided an invalid pagination token in your request.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ListImageRecipes">REST API Reference for ListImageRecipes Operation</seealso>
        public virtual ListImageRecipesResponse ListImageRecipes(ListImageRecipesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListImageRecipesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListImageRecipesResponseUnmarshaller.Instance;

            return Invoke<ListImageRecipesResponse>(request, options);
        }
#else
        internal virtual ListImageRecipesResponse ListImageRecipes(ListImageRecipesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListImageRecipesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListImageRecipesResponseUnmarshaller.Instance;

            return Invoke<ListImageRecipesResponse>(request, options);
        }
#endif

        /// <summary>
        /// Returns a list of image recipes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListImageRecipes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListImageRecipes service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidPaginationTokenException">
        /// You have provided an invalid pagination token in your request.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ListImageRecipes">REST API Reference for ListImageRecipes Operation</seealso>
        public virtual Task<ListImageRecipesResponse> ListImageRecipesAsync(ListImageRecipesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListImageRecipesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListImageRecipesResponseUnmarshaller.Instance;

            return InvokeAsync<ListImageRecipesResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Returns a list of image scan aggregations for your account. You can filter by the
        /// type of key that Image Builder uses to group results. For example, if you want to
        /// get a list of findings by severity level for one of your pipelines, you might specify
        /// your pipeline with the <c>imagePipelineArn</c> filter. If you don't specify a filter,
        /// Image Builder returns an aggregation for your account.
        /// 
        ///  
        /// <para>
        /// To streamline results, you can use the following filters in your request:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>imageBuildVersionArn</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>imagePipelineArn</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>vulnerabilityId</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListImageScanFindingAggregations service method.</param>
        /// <returns>The response from the ListImageScanFindingAggregations service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidPaginationTokenException">
        /// You have provided an invalid pagination token in your request.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ListImageScanFindingAggregations">REST API Reference for ListImageScanFindingAggregations Operation</seealso>
        public virtual ListImageScanFindingAggregationsResponse ListImageScanFindingAggregations(ListImageScanFindingAggregationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListImageScanFindingAggregationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListImageScanFindingAggregationsResponseUnmarshaller.Instance;

            return Invoke<ListImageScanFindingAggregationsResponse>(request, options);
        }
#else
        internal virtual ListImageScanFindingAggregationsResponse ListImageScanFindingAggregations(ListImageScanFindingAggregationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListImageScanFindingAggregationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListImageScanFindingAggregationsResponseUnmarshaller.Instance;

            return Invoke<ListImageScanFindingAggregationsResponse>(request, options);
        }
#endif

        /// <summary>
        /// Returns a list of image scan aggregations for your account. You can filter by the
        /// type of key that Image Builder uses to group results. For example, if you want to
        /// get a list of findings by severity level for one of your pipelines, you might specify
        /// your pipeline with the <c>imagePipelineArn</c> filter. If you don't specify a filter,
        /// Image Builder returns an aggregation for your account.
        /// 
        ///  
        /// <para>
        /// To streamline results, you can use the following filters in your request:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>imageBuildVersionArn</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>imagePipelineArn</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>vulnerabilityId</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListImageScanFindingAggregations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListImageScanFindingAggregations service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidPaginationTokenException">
        /// You have provided an invalid pagination token in your request.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ListImageScanFindingAggregations">REST API Reference for ListImageScanFindingAggregations Operation</seealso>
        public virtual Task<ListImageScanFindingAggregationsResponse> ListImageScanFindingAggregationsAsync(ListImageScanFindingAggregationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListImageScanFindingAggregationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListImageScanFindingAggregationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListImageScanFindingAggregationsResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Returns a list of image scan findings for your account. Amazon Inspector generates
        /// the findings when it scans images that have scanning enabled.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListImageScanFindings service method.</param>
        /// <returns>The response from the ListImageScanFindings service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidPaginationTokenException">
        /// You have provided an invalid pagination token in your request.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ListImageScanFindings">REST API Reference for ListImageScanFindings Operation</seealso>
        public virtual ListImageScanFindingsResponse ListImageScanFindings(ListImageScanFindingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListImageScanFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListImageScanFindingsResponseUnmarshaller.Instance;

            return Invoke<ListImageScanFindingsResponse>(request, options);
        }
#else
        internal virtual ListImageScanFindingsResponse ListImageScanFindings(ListImageScanFindingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListImageScanFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListImageScanFindingsResponseUnmarshaller.Instance;

            return Invoke<ListImageScanFindingsResponse>(request, options);
        }
#endif

        /// <summary>
        /// Returns a list of image scan findings for your account. Amazon Inspector generates
        /// the findings when it scans images that have scanning enabled.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListImageScanFindings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListImageScanFindings service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidPaginationTokenException">
        /// You have provided an invalid pagination token in your request.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ListImageScanFindings">REST API Reference for ListImageScanFindings Operation</seealso>
        public virtual Task<ListImageScanFindingsResponse> ListImageScanFindingsAsync(ListImageScanFindingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListImageScanFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListImageScanFindingsResponseUnmarshaller.Instance;

            return InvokeAsync<ListImageScanFindingsResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Returns the list of images that you have access to.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListImages service method.</param>
        /// <returns>The response from the ListImages service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidPaginationTokenException">
        /// You have provided an invalid pagination token in your request.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ListImages">REST API Reference for ListImages Operation</seealso>
        public virtual ListImagesResponse ListImages(ListImagesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListImagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListImagesResponseUnmarshaller.Instance;

            return Invoke<ListImagesResponse>(request, options);
        }
#else
        internal virtual ListImagesResponse ListImages(ListImagesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListImagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListImagesResponseUnmarshaller.Instance;

            return Invoke<ListImagesResponse>(request, options);
        }
#endif

        /// <summary>
        /// Returns the list of images that you have access to.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListImages service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListImages service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidPaginationTokenException">
        /// You have provided an invalid pagination token in your request.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ListImages">REST API Reference for ListImages Operation</seealso>
        public virtual Task<ListImagesResponse> ListImagesAsync(ListImagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListImagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListImagesResponseUnmarshaller.Instance;

            return InvokeAsync<ListImagesResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Returns a list of infrastructure configurations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInfrastructureConfigurations service method.</param>
        /// <returns>The response from the ListInfrastructureConfigurations service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidPaginationTokenException">
        /// You have provided an invalid pagination token in your request.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ListInfrastructureConfigurations">REST API Reference for ListInfrastructureConfigurations Operation</seealso>
        public virtual ListInfrastructureConfigurationsResponse ListInfrastructureConfigurations(ListInfrastructureConfigurationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListInfrastructureConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInfrastructureConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListInfrastructureConfigurationsResponse>(request, options);
        }
#else
        internal virtual ListInfrastructureConfigurationsResponse ListInfrastructureConfigurations(ListInfrastructureConfigurationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListInfrastructureConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInfrastructureConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListInfrastructureConfigurationsResponse>(request, options);
        }
#endif

        /// <summary>
        /// Returns a list of infrastructure configurations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInfrastructureConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListInfrastructureConfigurations service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidPaginationTokenException">
        /// You have provided an invalid pagination token in your request.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ListInfrastructureConfigurations">REST API Reference for ListInfrastructureConfigurations Operation</seealso>
        public virtual Task<ListInfrastructureConfigurationsResponse> ListInfrastructureConfigurationsAsync(ListInfrastructureConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListInfrastructureConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInfrastructureConfigurationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListInfrastructureConfigurationsResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Lists resources that the runtime instance of the image lifecycle identified for lifecycle
        /// actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLifecycleExecutionResources service method.</param>
        /// <returns>The response from the ListLifecycleExecutionResources service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidPaginationTokenException">
        /// You have provided an invalid pagination token in your request.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ListLifecycleExecutionResources">REST API Reference for ListLifecycleExecutionResources Operation</seealso>
        public virtual ListLifecycleExecutionResourcesResponse ListLifecycleExecutionResources(ListLifecycleExecutionResourcesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListLifecycleExecutionResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLifecycleExecutionResourcesResponseUnmarshaller.Instance;

            return Invoke<ListLifecycleExecutionResourcesResponse>(request, options);
        }
#else
        internal virtual ListLifecycleExecutionResourcesResponse ListLifecycleExecutionResources(ListLifecycleExecutionResourcesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListLifecycleExecutionResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLifecycleExecutionResourcesResponseUnmarshaller.Instance;

            return Invoke<ListLifecycleExecutionResourcesResponse>(request, options);
        }
#endif

        /// <summary>
        /// Lists resources that the runtime instance of the image lifecycle identified for lifecycle
        /// actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLifecycleExecutionResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListLifecycleExecutionResources service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidPaginationTokenException">
        /// You have provided an invalid pagination token in your request.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ListLifecycleExecutionResources">REST API Reference for ListLifecycleExecutionResources Operation</seealso>
        public virtual Task<ListLifecycleExecutionResourcesResponse> ListLifecycleExecutionResourcesAsync(ListLifecycleExecutionResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListLifecycleExecutionResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLifecycleExecutionResourcesResponseUnmarshaller.Instance;

            return InvokeAsync<ListLifecycleExecutionResourcesResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves the lifecycle runtime history for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLifecycleExecutions service method.</param>
        /// <returns>The response from the ListLifecycleExecutions service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidPaginationTokenException">
        /// You have provided an invalid pagination token in your request.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ListLifecycleExecutions">REST API Reference for ListLifecycleExecutions Operation</seealso>
        public virtual ListLifecycleExecutionsResponse ListLifecycleExecutions(ListLifecycleExecutionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListLifecycleExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLifecycleExecutionsResponseUnmarshaller.Instance;

            return Invoke<ListLifecycleExecutionsResponse>(request, options);
        }
#else
        internal virtual ListLifecycleExecutionsResponse ListLifecycleExecutions(ListLifecycleExecutionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListLifecycleExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLifecycleExecutionsResponseUnmarshaller.Instance;

            return Invoke<ListLifecycleExecutionsResponse>(request, options);
        }
#endif

        /// <summary>
        /// Retrieves the lifecycle runtime history for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLifecycleExecutions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListLifecycleExecutions service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidPaginationTokenException">
        /// You have provided an invalid pagination token in your request.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ListLifecycleExecutions">REST API Reference for ListLifecycleExecutions Operation</seealso>
        public virtual Task<ListLifecycleExecutionsResponse> ListLifecycleExecutionsAsync(ListLifecycleExecutionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListLifecycleExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLifecycleExecutionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListLifecycleExecutionsResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves a list of lifecycle policies in your Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLifecyclePolicies service method.</param>
        /// <returns>The response from the ListLifecyclePolicies service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidPaginationTokenException">
        /// You have provided an invalid pagination token in your request.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ListLifecyclePolicies">REST API Reference for ListLifecyclePolicies Operation</seealso>
        public virtual ListLifecyclePoliciesResponse ListLifecyclePolicies(ListLifecyclePoliciesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListLifecyclePoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLifecyclePoliciesResponseUnmarshaller.Instance;

            return Invoke<ListLifecyclePoliciesResponse>(request, options);
        }
#else
        internal virtual ListLifecyclePoliciesResponse ListLifecyclePolicies(ListLifecyclePoliciesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListLifecyclePoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLifecyclePoliciesResponseUnmarshaller.Instance;

            return Invoke<ListLifecyclePoliciesResponse>(request, options);
        }
#endif

        /// <summary>
        /// Retrieves a list of lifecycle policies in your Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLifecyclePolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListLifecyclePolicies service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidPaginationTokenException">
        /// You have provided an invalid pagination token in your request.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ListLifecyclePolicies">REST API Reference for ListLifecyclePolicies Operation</seealso>
        public virtual Task<ListLifecyclePoliciesResponse> ListLifecyclePoliciesAsync(ListLifecyclePoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListLifecyclePoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLifecyclePoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<ListLifecyclePoliciesResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Returns the list of tags for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <returns>The response from the ListTagsForResource service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceNotFoundException">
        /// At least one of the resources referenced by your request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// Returns the list of tags for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListTagsForResource service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceNotFoundException">
        /// At least one of the resources referenced by your request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Lists the workflow steps in your Amazon Web Services account that have paused at a
        /// <c>WaitForAction</c> step, and are waiting for you to respond. To send a response,
        /// call <a>SendWorkflowStepAction</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWaitingWorkflowSteps service method.</param>
        /// <returns>The response from the ListWaitingWorkflowSteps service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidPaginationTokenException">
        /// You have provided an invalid pagination token in your request.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ListWaitingWorkflowSteps">REST API Reference for ListWaitingWorkflowSteps Operation</seealso>
        public virtual ListWaitingWorkflowStepsResponse ListWaitingWorkflowSteps(ListWaitingWorkflowStepsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWaitingWorkflowStepsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWaitingWorkflowStepsResponseUnmarshaller.Instance;

            return Invoke<ListWaitingWorkflowStepsResponse>(request, options);
        }
#else
        internal virtual ListWaitingWorkflowStepsResponse ListWaitingWorkflowSteps(ListWaitingWorkflowStepsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWaitingWorkflowStepsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWaitingWorkflowStepsResponseUnmarshaller.Instance;

            return Invoke<ListWaitingWorkflowStepsResponse>(request, options);
        }
#endif

        /// <summary>
        /// Lists the workflow steps in your Amazon Web Services account that have paused at a
        /// <c>WaitForAction</c> step, and are waiting for you to respond. To send a response,
        /// call <a>SendWorkflowStepAction</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWaitingWorkflowSteps service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListWaitingWorkflowSteps service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidPaginationTokenException">
        /// You have provided an invalid pagination token in your request.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ListWaitingWorkflowSteps">REST API Reference for ListWaitingWorkflowSteps Operation</seealso>
        public virtual Task<ListWaitingWorkflowStepsResponse> ListWaitingWorkflowStepsAsync(ListWaitingWorkflowStepsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWaitingWorkflowStepsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWaitingWorkflowStepsResponseUnmarshaller.Instance;

            return InvokeAsync<ListWaitingWorkflowStepsResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Returns a list of build versions for a specific workflow resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkflowBuildVersions service method.</param>
        /// <returns>The response from the ListWorkflowBuildVersions service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidPaginationTokenException">
        /// You have provided an invalid pagination token in your request.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ListWorkflowBuildVersions">REST API Reference for ListWorkflowBuildVersions Operation</seealso>
        public virtual ListWorkflowBuildVersionsResponse ListWorkflowBuildVersions(ListWorkflowBuildVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWorkflowBuildVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkflowBuildVersionsResponseUnmarshaller.Instance;

            return Invoke<ListWorkflowBuildVersionsResponse>(request, options);
        }
#else
        internal virtual ListWorkflowBuildVersionsResponse ListWorkflowBuildVersions(ListWorkflowBuildVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWorkflowBuildVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkflowBuildVersionsResponseUnmarshaller.Instance;

            return Invoke<ListWorkflowBuildVersionsResponse>(request, options);
        }
#endif

        /// <summary>
        /// Returns a list of build versions for a specific workflow resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkflowBuildVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListWorkflowBuildVersions service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidPaginationTokenException">
        /// You have provided an invalid pagination token in your request.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ListWorkflowBuildVersions">REST API Reference for ListWorkflowBuildVersions Operation</seealso>
        public virtual Task<ListWorkflowBuildVersionsResponse> ListWorkflowBuildVersionsAsync(ListWorkflowBuildVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWorkflowBuildVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkflowBuildVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListWorkflowBuildVersionsResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Returns a list of workflow runtime instance metadata objects for a specific image
        /// build version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkflowExecutions service method.</param>
        /// <returns>The response from the ListWorkflowExecutions service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidPaginationTokenException">
        /// You have provided an invalid pagination token in your request.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ListWorkflowExecutions">REST API Reference for ListWorkflowExecutions Operation</seealso>
        public virtual ListWorkflowExecutionsResponse ListWorkflowExecutions(ListWorkflowExecutionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWorkflowExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkflowExecutionsResponseUnmarshaller.Instance;

            return Invoke<ListWorkflowExecutionsResponse>(request, options);
        }
#else
        internal virtual ListWorkflowExecutionsResponse ListWorkflowExecutions(ListWorkflowExecutionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWorkflowExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkflowExecutionsResponseUnmarshaller.Instance;

            return Invoke<ListWorkflowExecutionsResponse>(request, options);
        }
#endif

        /// <summary>
        /// Returns a list of workflow runtime instance metadata objects for a specific image
        /// build version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkflowExecutions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListWorkflowExecutions service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidPaginationTokenException">
        /// You have provided an invalid pagination token in your request.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ListWorkflowExecutions">REST API Reference for ListWorkflowExecutions Operation</seealso>
        public virtual Task<ListWorkflowExecutionsResponse> ListWorkflowExecutionsAsync(ListWorkflowExecutionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWorkflowExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkflowExecutionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListWorkflowExecutionsResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Returns runtime data for each step in a runtime instance of the workflow that you
        /// specify in the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkflowStepExecutions service method.</param>
        /// <returns>The response from the ListWorkflowStepExecutions service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidPaginationTokenException">
        /// You have provided an invalid pagination token in your request.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ListWorkflowStepExecutions">REST API Reference for ListWorkflowStepExecutions Operation</seealso>
        public virtual ListWorkflowStepExecutionsResponse ListWorkflowStepExecutions(ListWorkflowStepExecutionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWorkflowStepExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkflowStepExecutionsResponseUnmarshaller.Instance;

            return Invoke<ListWorkflowStepExecutionsResponse>(request, options);
        }
#else
        internal virtual ListWorkflowStepExecutionsResponse ListWorkflowStepExecutions(ListWorkflowStepExecutionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWorkflowStepExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkflowStepExecutionsResponseUnmarshaller.Instance;

            return Invoke<ListWorkflowStepExecutionsResponse>(request, options);
        }
#endif

        /// <summary>
        /// Returns runtime data for each step in a runtime instance of the workflow that you
        /// specify in the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkflowStepExecutions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListWorkflowStepExecutions service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidPaginationTokenException">
        /// You have provided an invalid pagination token in your request.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ListWorkflowStepExecutions">REST API Reference for ListWorkflowStepExecutions Operation</seealso>
        public virtual Task<ListWorkflowStepExecutionsResponse> ListWorkflowStepExecutionsAsync(ListWorkflowStepExecutionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWorkflowStepExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkflowStepExecutionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListWorkflowStepExecutionsResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Lists workflow versions based on filtering parameters. To list the build versions
        /// of a specific workflow version, call <a>ListWorkflowBuildVersions</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkflows service method.</param>
        /// <returns>The response from the ListWorkflows service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidPaginationTokenException">
        /// You have provided an invalid pagination token in your request.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ListWorkflows">REST API Reference for ListWorkflows Operation</seealso>
        public virtual ListWorkflowsResponse ListWorkflows(ListWorkflowsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWorkflowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkflowsResponseUnmarshaller.Instance;

            return Invoke<ListWorkflowsResponse>(request, options);
        }
#else
        internal virtual ListWorkflowsResponse ListWorkflows(ListWorkflowsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWorkflowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkflowsResponseUnmarshaller.Instance;

            return Invoke<ListWorkflowsResponse>(request, options);
        }
#endif

        /// <summary>
        /// Lists workflow versions based on filtering parameters. To list the build versions
        /// of a specific workflow version, call <a>ListWorkflowBuildVersions</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkflows service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListWorkflows service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidPaginationTokenException">
        /// You have provided an invalid pagination token in your request.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ListWorkflows">REST API Reference for ListWorkflows Operation</seealso>
        public virtual Task<ListWorkflowsResponse> ListWorkflowsAsync(ListWorkflowsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWorkflowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkflowsResponseUnmarshaller.Instance;

            return InvokeAsync<ListWorkflowsResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Applies a policy to a component. The preferred way to share resources is with the
        /// RAM API <a href="https://docs.aws.amazon.com/ram/latest/APIReference/API_CreateResourceShare.html">CreateResourceShare</a>.
        /// If you use the PutComponentPolicy operation instead, you must also call the RAM API
        /// <a href="https://docs.aws.amazon.com/ram/latest/APIReference/API_PromoteResourceShareCreatedFromPolicy.html">PromoteResourceShareCreatedFromPolicy</a>.
        /// Otherwise, the resource isn't visible to the principals that it's shared with.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutComponentPolicy service method.</param>
        /// <returns>The response from the PutComponentPolicy service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidParameterValueException">
        /// The value that you provided for the specified parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceNotFoundException">
        /// At least one of the resources referenced by your request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/PutComponentPolicy">REST API Reference for PutComponentPolicy Operation</seealso>
        public virtual PutComponentPolicyResponse PutComponentPolicy(PutComponentPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutComponentPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutComponentPolicyResponseUnmarshaller.Instance;

            return Invoke<PutComponentPolicyResponse>(request, options);
        }
#else
        internal virtual PutComponentPolicyResponse PutComponentPolicy(PutComponentPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutComponentPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutComponentPolicyResponseUnmarshaller.Instance;

            return Invoke<PutComponentPolicyResponse>(request, options);
        }
#endif

        /// <summary>
        /// Applies a policy to a component. The preferred way to share resources is with the
        /// RAM API <a href="https://docs.aws.amazon.com/ram/latest/APIReference/API_CreateResourceShare.html">CreateResourceShare</a>.
        /// If you use the PutComponentPolicy operation instead, you must also call the RAM API
        /// <a href="https://docs.aws.amazon.com/ram/latest/APIReference/API_PromoteResourceShareCreatedFromPolicy.html">PromoteResourceShareCreatedFromPolicy</a>.
        /// Otherwise, the resource isn't visible to the principals that it's shared with.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutComponentPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the PutComponentPolicy service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidParameterValueException">
        /// The value that you provided for the specified parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceNotFoundException">
        /// At least one of the resources referenced by your request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/PutComponentPolicy">REST API Reference for PutComponentPolicy Operation</seealso>
        public virtual Task<PutComponentPolicyResponse> PutComponentPolicyAsync(PutComponentPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutComponentPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutComponentPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutComponentPolicyResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Applies a policy to a container recipe. The preferred way to share resources is with
        /// the RAM API <a href="https://docs.aws.amazon.com/ram/latest/APIReference/API_CreateResourceShare.html">CreateResourceShare</a>.
        /// If you use the PutContainerRecipePolicy operation instead, you must also call the
        /// RAM API <a href="https://docs.aws.amazon.com/ram/latest/APIReference/API_PromoteResourceShareCreatedFromPolicy.html">PromoteResourceShareCreatedFromPolicy</a>.
        /// Otherwise, the resource isn't visible to the principals that it's shared with.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutContainerRecipePolicy service method.</param>
        /// <returns>The response from the PutContainerRecipePolicy service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidParameterValueException">
        /// The value that you provided for the specified parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceNotFoundException">
        /// At least one of the resources referenced by your request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/PutContainerRecipePolicy">REST API Reference for PutContainerRecipePolicy Operation</seealso>
        public virtual PutContainerRecipePolicyResponse PutContainerRecipePolicy(PutContainerRecipePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutContainerRecipePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutContainerRecipePolicyResponseUnmarshaller.Instance;

            return Invoke<PutContainerRecipePolicyResponse>(request, options);
        }
#else
        internal virtual PutContainerRecipePolicyResponse PutContainerRecipePolicy(PutContainerRecipePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutContainerRecipePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutContainerRecipePolicyResponseUnmarshaller.Instance;

            return Invoke<PutContainerRecipePolicyResponse>(request, options);
        }
#endif

        /// <summary>
        /// Applies a policy to a container recipe. The preferred way to share resources is with
        /// the RAM API <a href="https://docs.aws.amazon.com/ram/latest/APIReference/API_CreateResourceShare.html">CreateResourceShare</a>.
        /// If you use the PutContainerRecipePolicy operation instead, you must also call the
        /// RAM API <a href="https://docs.aws.amazon.com/ram/latest/APIReference/API_PromoteResourceShareCreatedFromPolicy.html">PromoteResourceShareCreatedFromPolicy</a>.
        /// Otherwise, the resource isn't visible to the principals that it's shared with.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutContainerRecipePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the PutContainerRecipePolicy service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidParameterValueException">
        /// The value that you provided for the specified parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceNotFoundException">
        /// At least one of the resources referenced by your request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/PutContainerRecipePolicy">REST API Reference for PutContainerRecipePolicy Operation</seealso>
        public virtual Task<PutContainerRecipePolicyResponse> PutContainerRecipePolicyAsync(PutContainerRecipePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutContainerRecipePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutContainerRecipePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutContainerRecipePolicyResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Applies a policy to an image. The preferred way to share resources is with the RAM
        /// API <a href="https://docs.aws.amazon.com/ram/latest/APIReference/API_CreateResourceShare.html">CreateResourceShare</a>.
        /// If you use the PutImagePolicy operation instead, you must also call the RAM API <a
        /// href="https://docs.aws.amazon.com/ram/latest/APIReference/API_PromoteResourceShareCreatedFromPolicy.html">PromoteResourceShareCreatedFromPolicy</a>.
        /// Otherwise, the resource isn't visible to the principals that it's shared with.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutImagePolicy service method.</param>
        /// <returns>The response from the PutImagePolicy service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidParameterValueException">
        /// The value that you provided for the specified parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceNotFoundException">
        /// At least one of the resources referenced by your request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/PutImagePolicy">REST API Reference for PutImagePolicy Operation</seealso>
        public virtual PutImagePolicyResponse PutImagePolicy(PutImagePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutImagePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutImagePolicyResponseUnmarshaller.Instance;

            return Invoke<PutImagePolicyResponse>(request, options);
        }
#else
        internal virtual PutImagePolicyResponse PutImagePolicy(PutImagePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutImagePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutImagePolicyResponseUnmarshaller.Instance;

            return Invoke<PutImagePolicyResponse>(request, options);
        }
#endif

        /// <summary>
        /// Applies a policy to an image. The preferred way to share resources is with the RAM
        /// API <a href="https://docs.aws.amazon.com/ram/latest/APIReference/API_CreateResourceShare.html">CreateResourceShare</a>.
        /// If you use the PutImagePolicy operation instead, you must also call the RAM API <a
        /// href="https://docs.aws.amazon.com/ram/latest/APIReference/API_PromoteResourceShareCreatedFromPolicy.html">PromoteResourceShareCreatedFromPolicy</a>.
        /// Otherwise, the resource isn't visible to the principals that it's shared with.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutImagePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the PutImagePolicy service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidParameterValueException">
        /// The value that you provided for the specified parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceNotFoundException">
        /// At least one of the resources referenced by your request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/PutImagePolicy">REST API Reference for PutImagePolicy Operation</seealso>
        public virtual Task<PutImagePolicyResponse> PutImagePolicyAsync(PutImagePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutImagePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutImagePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutImagePolicyResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Applies a policy to an image recipe. The preferred way to share resources is with
        /// the RAM API <a href="https://docs.aws.amazon.com/ram/latest/APIReference/API_CreateResourceShare.html">CreateResourceShare</a>.
        /// If you use the PutImageRecipePolicy operation instead, you must also call the RAM
        /// API <a href="https://docs.aws.amazon.com/ram/latest/APIReference/API_PromoteResourceShareCreatedFromPolicy.html">PromoteResourceShareCreatedFromPolicy</a>.
        /// Otherwise, the resource isn't visible to the principals that it's shared with.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutImageRecipePolicy service method.</param>
        /// <returns>The response from the PutImageRecipePolicy service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidParameterValueException">
        /// The value that you provided for the specified parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceNotFoundException">
        /// At least one of the resources referenced by your request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/PutImageRecipePolicy">REST API Reference for PutImageRecipePolicy Operation</seealso>
        public virtual PutImageRecipePolicyResponse PutImageRecipePolicy(PutImageRecipePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutImageRecipePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutImageRecipePolicyResponseUnmarshaller.Instance;

            return Invoke<PutImageRecipePolicyResponse>(request, options);
        }
#else
        internal virtual PutImageRecipePolicyResponse PutImageRecipePolicy(PutImageRecipePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutImageRecipePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutImageRecipePolicyResponseUnmarshaller.Instance;

            return Invoke<PutImageRecipePolicyResponse>(request, options);
        }
#endif

        /// <summary>
        /// Applies a policy to an image recipe. The preferred way to share resources is with
        /// the RAM API <a href="https://docs.aws.amazon.com/ram/latest/APIReference/API_CreateResourceShare.html">CreateResourceShare</a>.
        /// If you use the PutImageRecipePolicy operation instead, you must also call the RAM
        /// API <a href="https://docs.aws.amazon.com/ram/latest/APIReference/API_PromoteResourceShareCreatedFromPolicy.html">PromoteResourceShareCreatedFromPolicy</a>.
        /// Otherwise, the resource isn't visible to the principals that it's shared with.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutImageRecipePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the PutImageRecipePolicy service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidParameterValueException">
        /// The value that you provided for the specified parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceNotFoundException">
        /// At least one of the resources referenced by your request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/PutImageRecipePolicy">REST API Reference for PutImageRecipePolicy Operation</seealso>
        public virtual Task<PutImageRecipePolicyResponse> PutImageRecipePolicyAsync(PutImageRecipePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutImageRecipePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutImageRecipePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutImageRecipePolicyResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Retries a failed or canceled image build without rebuilding the phases that already
        /// completed. The image re-runs asynchronously in place: the same build version returns
        /// to the test or distribution phase where it failed and continues from there. No new
        /// image build version is created. Retry is only supported for AMI-based images.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RetryImage service method.</param>
        /// <returns>The response from the RetryImage service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.IdempotentParameterMismatchException">
        /// You have specified a client token for an operation using parameter values that differ
        /// from a previous request that used the same client token.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceInUseException">
        /// The resource that you are trying to operate on is currently in use. Review the message
        /// details and retry later.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/RetryImage">REST API Reference for RetryImage Operation</seealso>
        public virtual RetryImageResponse RetryImage(RetryImageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RetryImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RetryImageResponseUnmarshaller.Instance;

            return Invoke<RetryImageResponse>(request, options);
        }
#else
        internal virtual RetryImageResponse RetryImage(RetryImageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RetryImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RetryImageResponseUnmarshaller.Instance;

            return Invoke<RetryImageResponse>(request, options);
        }
#endif

        /// <summary>
        /// Retries a failed or canceled image build without rebuilding the phases that already
        /// completed. The image re-runs asynchronously in place: the same build version returns
        /// to the test or distribution phase where it failed and continues from there. No new
        /// image build version is created. Retry is only supported for AMI-based images.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RetryImage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the RetryImage service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.IdempotentParameterMismatchException">
        /// You have specified a client token for an operation using parameter values that differ
        /// from a previous request that used the same client token.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceInUseException">
        /// The resource that you are trying to operate on is currently in use. Review the message
        /// details and retry later.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/RetryImage">REST API Reference for RetryImage Operation</seealso>
        public virtual Task<RetryImageResponse> RetryImageAsync(RetryImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RetryImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RetryImageResponseUnmarshaller.Instance;

            return InvokeAsync<RetryImageResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Sends an action to a workflow step that has paused at a <c>WaitForAction</c> step,
        /// so that image creation can continue. To find the steps that are waiting for an action,
        /// call <a>ListWaitingWorkflowSteps</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendWorkflowStepAction service method.</param>
        /// <returns>The response from the SendWorkflowStepAction service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.IdempotentParameterMismatchException">
        /// You have specified a client token for an operation using parameter values that differ
        /// from a previous request that used the same client token.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidParameterValueException">
        /// The value that you provided for the specified parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceInUseException">
        /// The resource that you are trying to operate on is currently in use. Review the message
        /// details and retry later.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceNotFoundException">
        /// At least one of the resources referenced by your request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/SendWorkflowStepAction">REST API Reference for SendWorkflowStepAction Operation</seealso>
        public virtual SendWorkflowStepActionResponse SendWorkflowStepAction(SendWorkflowStepActionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SendWorkflowStepActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendWorkflowStepActionResponseUnmarshaller.Instance;

            return Invoke<SendWorkflowStepActionResponse>(request, options);
        }
#else
        internal virtual SendWorkflowStepActionResponse SendWorkflowStepAction(SendWorkflowStepActionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SendWorkflowStepActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendWorkflowStepActionResponseUnmarshaller.Instance;

            return Invoke<SendWorkflowStepActionResponse>(request, options);
        }
#endif

        /// <summary>
        /// Sends an action to a workflow step that has paused at a <c>WaitForAction</c> step,
        /// so that image creation can continue. To find the steps that are waiting for an action,
        /// call <a>ListWaitingWorkflowSteps</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendWorkflowStepAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the SendWorkflowStepAction service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.IdempotentParameterMismatchException">
        /// You have specified a client token for an operation using parameter values that differ
        /// from a previous request that used the same client token.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidParameterValueException">
        /// The value that you provided for the specified parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceInUseException">
        /// The resource that you are trying to operate on is currently in use. Review the message
        /// details and retry later.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceNotFoundException">
        /// At least one of the resources referenced by your request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/SendWorkflowStepAction">REST API Reference for SendWorkflowStepAction Operation</seealso>
        public virtual Task<SendWorkflowStepActionResponse> SendWorkflowStepActionAsync(SendWorkflowStepActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SendWorkflowStepActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendWorkflowStepActionResponseUnmarshaller.Instance;

            return InvokeAsync<SendWorkflowStepActionResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Manually triggers a pipeline to create an image. You can start a build this way whether
        /// the pipeline is enabled or disabled. The response returns as soon as Image Builder
        /// creates the new image resource and queues the build. Use the returned <c>imageBuildVersionArn</c>
        /// with <a>GetImage</a> to track build progress.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartImagePipelineExecution service method.</param>
        /// <returns>The response from the StartImagePipelineExecution service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.IdempotentParameterMismatchException">
        /// You have specified a client token for an operation using parameter values that differ
        /// from a previous request that used the same client token.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceInUseException">
        /// The resource that you are trying to operate on is currently in use. Review the message
        /// details and retry later.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceNotFoundException">
        /// At least one of the resources referenced by your request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/StartImagePipelineExecution">REST API Reference for StartImagePipelineExecution Operation</seealso>
        public virtual StartImagePipelineExecutionResponse StartImagePipelineExecution(StartImagePipelineExecutionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartImagePipelineExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartImagePipelineExecutionResponseUnmarshaller.Instance;

            return Invoke<StartImagePipelineExecutionResponse>(request, options);
        }
#else
        internal virtual StartImagePipelineExecutionResponse StartImagePipelineExecution(StartImagePipelineExecutionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartImagePipelineExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartImagePipelineExecutionResponseUnmarshaller.Instance;

            return Invoke<StartImagePipelineExecutionResponse>(request, options);
        }
#endif

        /// <summary>
        /// Manually triggers a pipeline to create an image. You can start a build this way whether
        /// the pipeline is enabled or disabled. The response returns as soon as Image Builder
        /// creates the new image resource and queues the build. Use the returned <c>imageBuildVersionArn</c>
        /// with <a>GetImage</a> to track build progress.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartImagePipelineExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the StartImagePipelineExecution service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.IdempotentParameterMismatchException">
        /// You have specified a client token for an operation using parameter values that differ
        /// from a previous request that used the same client token.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceInUseException">
        /// The resource that you are trying to operate on is currently in use. Review the message
        /// details and retry later.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceNotFoundException">
        /// At least one of the resources referenced by your request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/StartImagePipelineExecution">REST API Reference for StartImagePipelineExecution Operation</seealso>
        public virtual Task<StartImagePipelineExecutionResponse> StartImagePipelineExecutionAsync(StartImagePipelineExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartImagePipelineExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartImagePipelineExecutionResponseUnmarshaller.Instance;

            return InvokeAsync<StartImagePipelineExecutionResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Begins an ad-hoc state change for the specified image build version. This is a one-time
        /// operation - if you schedule the update, it runs only once. If the request includes
        /// underlying resources, or schedules the update far enough in the future, Image Builder
        /// runs the update as an asynchronous lifecycle execution and returns its identifier.
        /// Otherwise, for target states other than <c>DELETED</c>, the state change applies immediately.
        /// If a request that starts a lifecycle execution arrives while the image already has
        /// one in progress, Image Builder rejects it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartResourceStateUpdate service method.</param>
        /// <returns>The response from the StartResourceStateUpdate service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.IdempotentParameterMismatchException">
        /// You have specified a client token for an operation using parameter values that differ
        /// from a previous request that used the same client token.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceInUseException">
        /// The resource that you are trying to operate on is currently in use. Review the message
        /// details and retry later.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceNotFoundException">
        /// At least one of the resources referenced by your request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/StartResourceStateUpdate">REST API Reference for StartResourceStateUpdate Operation</seealso>
        public virtual StartResourceStateUpdateResponse StartResourceStateUpdate(StartResourceStateUpdateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartResourceStateUpdateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartResourceStateUpdateResponseUnmarshaller.Instance;

            return Invoke<StartResourceStateUpdateResponse>(request, options);
        }
#else
        internal virtual StartResourceStateUpdateResponse StartResourceStateUpdate(StartResourceStateUpdateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartResourceStateUpdateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartResourceStateUpdateResponseUnmarshaller.Instance;

            return Invoke<StartResourceStateUpdateResponse>(request, options);
        }
#endif

        /// <summary>
        /// Begins an ad-hoc state change for the specified image build version. This is a one-time
        /// operation - if you schedule the update, it runs only once. If the request includes
        /// underlying resources, or schedules the update far enough in the future, Image Builder
        /// runs the update as an asynchronous lifecycle execution and returns its identifier.
        /// Otherwise, for target states other than <c>DELETED</c>, the state change applies immediately.
        /// If a request that starts a lifecycle execution arrives while the image already has
        /// one in progress, Image Builder rejects it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartResourceStateUpdate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the StartResourceStateUpdate service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.IdempotentParameterMismatchException">
        /// You have specified a client token for an operation using parameter values that differ
        /// from a previous request that used the same client token.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceInUseException">
        /// The resource that you are trying to operate on is currently in use. Review the message
        /// details and retry later.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceNotFoundException">
        /// At least one of the resources referenced by your request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/StartResourceStateUpdate">REST API Reference for StartResourceStateUpdate Operation</seealso>
        public virtual Task<StartResourceStateUpdateResponse> StartResourceStateUpdateAsync(StartResourceStateUpdateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartResourceStateUpdateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartResourceStateUpdateResponseUnmarshaller.Instance;

            return InvokeAsync<StartResourceStateUpdateResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Adds a tag to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <returns>The response from the TagResource service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceNotFoundException">
        /// At least one of the resources referenced by your request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Adds a tag to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the TagResource service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceNotFoundException">
        /// At least one of the resources referenced by your request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Removes a tag from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <returns>The response from the UntagResource service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceNotFoundException">
        /// At least one of the resources referenced by your request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// Removes a tag from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UntagResource service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceNotFoundException">
        /// At least one of the resources referenced by your request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Updates a distribution configuration. Distribution configurations define and configure
        /// the outputs for your images, including the target Regions, accounts, and settings
        /// for each Region.
        /// 
        ///  <note> 
        /// <para>
        /// This operation doesn't support selective updates. The request replaces the stored
        /// configuration, so include every setting that you want to keep.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDistributionConfiguration service method.</param>
        /// <returns>The response from the UpdateDistributionConfiguration service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.IdempotentParameterMismatchException">
        /// You have specified a client token for an operation using parameter values that differ
        /// from a previous request that used the same client token.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidParameterCombinationException">
        /// You have specified a combination of parameters that isn't valid. For example, two
        /// mutually exclusive parameters, or a parameter without its required companion parameter.
        /// Review the error message for details.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceInUseException">
        /// The resource that you are trying to operate on is currently in use. Review the message
        /// details and retry later.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/UpdateDistributionConfiguration">REST API Reference for UpdateDistributionConfiguration Operation</seealso>
        public virtual UpdateDistributionConfigurationResponse UpdateDistributionConfiguration(UpdateDistributionConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDistributionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDistributionConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateDistributionConfigurationResponse>(request, options);
        }
#else
        internal virtual UpdateDistributionConfigurationResponse UpdateDistributionConfiguration(UpdateDistributionConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDistributionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDistributionConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateDistributionConfigurationResponse>(request, options);
        }
#endif

        /// <summary>
        /// Updates a distribution configuration. Distribution configurations define and configure
        /// the outputs for your images, including the target Regions, accounts, and settings
        /// for each Region.
        /// 
        ///  <note> 
        /// <para>
        /// This operation doesn't support selective updates. The request replaces the stored
        /// configuration, so include every setting that you want to keep.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDistributionConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateDistributionConfiguration service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.IdempotentParameterMismatchException">
        /// You have specified a client token for an operation using parameter values that differ
        /// from a previous request that used the same client token.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidParameterCombinationException">
        /// You have specified a combination of parameters that isn't valid. For example, two
        /// mutually exclusive parameters, or a parameter without its required companion parameter.
        /// Review the error message for details.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceInUseException">
        /// The resource that you are trying to operate on is currently in use. Review the message
        /// details and retry later.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/UpdateDistributionConfiguration">REST API Reference for UpdateDistributionConfiguration Operation</seealso>
        public virtual Task<UpdateDistributionConfigurationResponse> UpdateDistributionConfigurationAsync(UpdateDistributionConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDistributionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDistributionConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDistributionConfigurationResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Updates an image pipeline. Use image pipelines to automate the creation and distribution
        /// of images. You must specify exactly one recipe for your image, using either a <c>containerRecipeArn</c>
        /// or an <c>imageRecipeArn</c>. The recipe must be the same type, image or container,
        /// as the pipeline's current recipe.
        /// 
        ///  <note> 
        /// <para>
        /// UpdateImagePipeline does not support selective updates. The request replaces the pipeline's
        /// entire configuration, so include every setting that you want to keep. Any optional
        /// property that you omit is removed or reset to its default.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateImagePipeline service method.</param>
        /// <returns>The response from the UpdateImagePipeline service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.IdempotentParameterMismatchException">
        /// You have specified a client token for an operation using parameter values that differ
        /// from a previous request that used the same client token.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceInUseException">
        /// The resource that you are trying to operate on is currently in use. Review the message
        /// details and retry later.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/UpdateImagePipeline">REST API Reference for UpdateImagePipeline Operation</seealso>
        public virtual UpdateImagePipelineResponse UpdateImagePipeline(UpdateImagePipelineRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateImagePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateImagePipelineResponseUnmarshaller.Instance;

            return Invoke<UpdateImagePipelineResponse>(request, options);
        }
#else
        internal virtual UpdateImagePipelineResponse UpdateImagePipeline(UpdateImagePipelineRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateImagePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateImagePipelineResponseUnmarshaller.Instance;

            return Invoke<UpdateImagePipelineResponse>(request, options);
        }
#endif

        /// <summary>
        /// Updates an image pipeline. Use image pipelines to automate the creation and distribution
        /// of images. You must specify exactly one recipe for your image, using either a <c>containerRecipeArn</c>
        /// or an <c>imageRecipeArn</c>. The recipe must be the same type, image or container,
        /// as the pipeline's current recipe.
        /// 
        ///  <note> 
        /// <para>
        /// UpdateImagePipeline does not support selective updates. The request replaces the pipeline's
        /// entire configuration, so include every setting that you want to keep. Any optional
        /// property that you omit is removed or reset to its default.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateImagePipeline service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateImagePipeline service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.IdempotentParameterMismatchException">
        /// You have specified a client token for an operation using parameter values that differ
        /// from a previous request that used the same client token.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceInUseException">
        /// The resource that you are trying to operate on is currently in use. Review the message
        /// details and retry later.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/UpdateImagePipeline">REST API Reference for UpdateImagePipeline Operation</seealso>
        public virtual Task<UpdateImagePipelineResponse> UpdateImagePipelineAsync(UpdateImagePipelineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateImagePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateImagePipelineResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateImagePipelineResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Updates an infrastructure configuration. An infrastructure configuration defines the
        /// environment in which Image Builder builds and tests your image.
        /// 
        ///  <note> 
        /// <para>
        /// This operation doesn't support selective updates. The request replaces the configuration,
        /// so include every setting that you want to keep. Omitted optional properties are cleared.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateInfrastructureConfiguration service method.</param>
        /// <returns>The response from the UpdateInfrastructureConfiguration service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.IdempotentParameterMismatchException">
        /// You have specified a client token for an operation using parameter values that differ
        /// from a previous request that used the same client token.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceInUseException">
        /// The resource that you are trying to operate on is currently in use. Review the message
        /// details and retry later.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/UpdateInfrastructureConfiguration">REST API Reference for UpdateInfrastructureConfiguration Operation</seealso>
        public virtual UpdateInfrastructureConfigurationResponse UpdateInfrastructureConfiguration(UpdateInfrastructureConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateInfrastructureConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateInfrastructureConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateInfrastructureConfigurationResponse>(request, options);
        }
#else
        internal virtual UpdateInfrastructureConfigurationResponse UpdateInfrastructureConfiguration(UpdateInfrastructureConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateInfrastructureConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateInfrastructureConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateInfrastructureConfigurationResponse>(request, options);
        }
#endif

        /// <summary>
        /// Updates an infrastructure configuration. An infrastructure configuration defines the
        /// environment in which Image Builder builds and tests your image.
        /// 
        ///  <note> 
        /// <para>
        /// This operation doesn't support selective updates. The request replaces the configuration,
        /// so include every setting that you want to keep. Omitted optional properties are cleared.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateInfrastructureConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateInfrastructureConfiguration service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.IdempotentParameterMismatchException">
        /// You have specified a client token for an operation using parameter values that differ
        /// from a previous request that used the same client token.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceInUseException">
        /// The resource that you are trying to operate on is currently in use. Review the message
        /// details and retry later.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/UpdateInfrastructureConfiguration">REST API Reference for UpdateInfrastructureConfiguration Operation</seealso>
        public virtual Task<UpdateInfrastructureConfigurationResponse> UpdateInfrastructureConfigurationAsync(UpdateInfrastructureConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateInfrastructureConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateInfrastructureConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateInfrastructureConfigurationResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Updates the specified lifecycle policy. The request replaces the existing policy configuration
        /// rather than merging changes, so re-specify every setting that you want to keep. The
        /// <c>resourceType</c> must match the existing policy's value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLifecyclePolicy service method.</param>
        /// <returns>The response from the UpdateLifecyclePolicy service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.IdempotentParameterMismatchException">
        /// You have specified a client token for an operation using parameter values that differ
        /// from a previous request that used the same client token.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidParameterCombinationException">
        /// You have specified a combination of parameters that isn't valid. For example, two
        /// mutually exclusive parameters, or a parameter without its required companion parameter.
        /// Review the error message for details.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceInUseException">
        /// The resource that you are trying to operate on is currently in use. Review the message
        /// details and retry later.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/UpdateLifecyclePolicy">REST API Reference for UpdateLifecyclePolicy Operation</seealso>
        public virtual UpdateLifecyclePolicyResponse UpdateLifecyclePolicy(UpdateLifecyclePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateLifecyclePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLifecyclePolicyResponseUnmarshaller.Instance;

            return Invoke<UpdateLifecyclePolicyResponse>(request, options);
        }
#else
        internal virtual UpdateLifecyclePolicyResponse UpdateLifecyclePolicy(UpdateLifecyclePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateLifecyclePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLifecyclePolicyResponseUnmarshaller.Instance;

            return Invoke<UpdateLifecyclePolicyResponse>(request, options);
        }
#endif

        /// <summary>
        /// Updates the specified lifecycle policy. The request replaces the existing policy configuration
        /// rather than merging changes, so re-specify every setting that you want to keep. The
        /// <c>resourceType</c> must match the existing policy's value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLifecyclePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateLifecyclePolicy service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the Amazon EC2 APIs that Image Builder
        /// calls on your behalf. Retry with an increasing or variable delay between requests.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// A generic client error. This error usually indicates that the request failed a validation
        /// check, such as when a downstream service rejects a configured value.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.IdempotentParameterMismatchException">
        /// You have specified a client token for an operation using parameter values that differ
        /// from a previous request that used the same client token.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidParameterCombinationException">
        /// You have specified a combination of parameters that isn't valid. For example, two
        /// mutually exclusive parameters, or a parameter without its required companion parameter.
        /// Review the error message for details.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// The request is malformed or otherwise invalid. Verify the request and try again.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceInUseException">
        /// The resource that you are trying to operate on is currently in use. Review the message
        /// details and retry later.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// An internal server error occurred while Image Builder processed the request. Retrying
        /// the request may succeed.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/UpdateLifecyclePolicy">REST API Reference for UpdateLifecyclePolicy Operation</seealso>
        public virtual Task<UpdateLifecyclePolicyResponse> UpdateLifecyclePolicyAsync(UpdateLifecyclePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateLifecyclePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLifecyclePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateLifecyclePolicyResponse>(request, options, cancellationToken);
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
