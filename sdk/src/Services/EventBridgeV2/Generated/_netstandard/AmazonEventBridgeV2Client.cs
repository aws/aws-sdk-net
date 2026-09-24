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
 * Do not modify this file. This file is generated from the eventbridgev2-2025-05-15.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.EventBridgeV2.Model;
using Amazon.EventBridgeV2.Model.Internal.MarshallTransformations;
using Amazon.EventBridgeV2.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.EventBridgeV2
{
    /// <summary>
    /// <para>Implementation for accessing EventBridgeV2</para>
    /// <para>
    /// Service client instances are thread-safe and can be shared across multiple threads.
    /// For a given service configuration, it is recommended to reuse a client instance
    /// for the lifetime of your application.
    /// </para>
    ///
    /// Amazon EventBridge event bus API. An event bus receives events published by your applications
    /// and AWS services, stores them for a configurable retention period, and delivers them
    /// to subscribers. A subscriber filters events, optionally transforms them, and invokes
    /// a target such as Lambda, SQS, SNS, Kinesis, Step Functions, or an HTTP endpoint. The
    /// API manages event buses, subscribers, event sources, resource policies, and tags,
    /// and publishes events through PutEvents and PutRawEvents.
    /// </summary>
    public partial class AmazonEventBridgeV2Client : AmazonServiceClient, IAmazonEventBridgeV2
    {
        private static IServiceMetadata serviceMetadata = new AmazonEventBridgeV2Metadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonEventBridgeV2Client with the credentials loaded from the application's
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
        public AmazonEventBridgeV2Client()
            : base(new AmazonEventBridgeV2Config()) { }

        /// <summary>
        /// Constructs AmazonEventBridgeV2Client with the credentials loaded from the application's
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
        public AmazonEventBridgeV2Client(RegionEndpoint region)
            : base(new AmazonEventBridgeV2Config{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonEventBridgeV2Client with the credentials loaded from the application's
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
        /// <param name="config">The AmazonEventBridgeV2Client Configuration Object</param>
        public AmazonEventBridgeV2Client(AmazonEventBridgeV2Config config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonEventBridgeV2Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonEventBridgeV2Client(AWSCredentials credentials)
            : this(credentials, new AmazonEventBridgeV2Config())
        {
        }

        /// <summary>
        /// Constructs AmazonEventBridgeV2Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonEventBridgeV2Client(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonEventBridgeV2Config{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonEventBridgeV2Client with AWS Credentials and an
        /// AmazonEventBridgeV2Client Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonEventBridgeV2Client Configuration Object</param>
        public AmazonEventBridgeV2Client(AWSCredentials credentials, AmazonEventBridgeV2Config clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonEventBridgeV2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonEventBridgeV2Client(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonEventBridgeV2Config())
        {
        }

        /// <summary>
        /// Constructs AmazonEventBridgeV2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonEventBridgeV2Client(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonEventBridgeV2Config() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonEventBridgeV2Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonEventBridgeV2Client Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonEventBridgeV2Client Configuration Object</param>
        public AmazonEventBridgeV2Client(string awsAccessKeyId, string awsSecretAccessKey, AmazonEventBridgeV2Config clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonEventBridgeV2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonEventBridgeV2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonEventBridgeV2Config())
        {
        }

        /// <summary>
        /// Constructs AmazonEventBridgeV2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonEventBridgeV2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonEventBridgeV2Config{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonEventBridgeV2Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonEventBridgeV2Client Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonEventBridgeV2Client Configuration Object</param>
        public AmazonEventBridgeV2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonEventBridgeV2Config clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IEventBridgeV2PaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IEventBridgeV2PaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new EventBridgeV2PaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

        #region Overrides

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonEventBridgeV2EndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonEventBridgeV2AuthSchemeHandler());
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


        #region  CreateEventBus

        internal virtual CreateEventBusResponse CreateEventBus(CreateEventBusRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEventBusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEventBusResponseUnmarshaller.Instance;

            return Invoke<CreateEventBusResponse>(request, options);
        }



        /// <summary>
        /// Creates an event bus. Provisioning is asynchronous: the bus is returned in the CREATING
        /// state and transitions to ACTIVE when ready (see the EventBusActive waiter). Retries
        /// carrying the same ClientToken are idempotent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEventBus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEventBus service method, as returned by EventBridgeV2.</returns>
        /// <exception cref="Amazon.EventBridgeV2.Model.AccessDeniedException">
        /// The caller does not have the permissions required to perform the operation. This error
        /// is also returned when the operation cannot use the AWS KMS key for the event bus.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.ConcurrentModificationException">
        /// Another change to the resource is already in progress. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.IdempotentParameterMismatchException">
        /// The request reuses the client token of an earlier request with different parameters.
        /// Use a new client token, or resend the earlier request unchanged.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.InternalException">
        /// The request failed because of an internal service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.InvalidInputException">
        /// A request parameter is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.InvalidStateException">
        /// The resource is not in a state that allows the operation. For example, an event bus
        /// that is still being created cannot accept events.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.LimitExceededException">
        /// The request would exceed a service quota for the account.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.ResourceAlreadyExistsException">
        /// A resource with the same name already exists.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.ThrottlingException">
        /// The request was throttled because it exceeds a request rate limit. Retry the request
        /// with backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridgev2-2025-05-15/CreateEventBus">REST API Reference for CreateEventBus Operation</seealso>
        public virtual Task<CreateEventBusResponse> CreateEventBusAsync(CreateEventBusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEventBusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEventBusResponseUnmarshaller.Instance;

            return InvokeAsync<CreateEventBusResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateEventSource

        internal virtual CreateEventSourceResponse CreateEventSource(CreateEventSourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEventSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEventSourceResponseUnmarshaller.Instance;

            return Invoke<CreateEventSourceResponse>(request, options);
        }



        /// <summary>
        /// Creates an EventSource, which forwards events from an origin (an AWS service or another
        /// account) onto an event bus. The bus must be ACTIVE. Retries carrying the same ClientToken
        /// are idempotent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEventSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEventSource service method, as returned by EventBridgeV2.</returns>
        /// <exception cref="Amazon.EventBridgeV2.Model.AccessDeniedException">
        /// The caller does not have the permissions required to perform the operation. This error
        /// is also returned when the operation cannot use the AWS KMS key for the event bus.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.ConcurrentModificationException">
        /// Another change to the resource is already in progress. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.IdempotentParameterMismatchException">
        /// The request reuses the client token of an earlier request with different parameters.
        /// Use a new client token, or resend the earlier request unchanged.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.InternalException">
        /// The request failed because of an internal service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.InvalidInputException">
        /// A request parameter is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.InvalidStateException">
        /// The resource is not in a state that allows the operation. For example, an event bus
        /// that is still being created cannot accept events.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.LimitExceededException">
        /// The request would exceed a service quota for the account.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.ResourceAlreadyExistsException">
        /// A resource with the same name already exists.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.ResourceNotFoundException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.ThrottlingException">
        /// The request was throttled because it exceeds a request rate limit. Retry the request
        /// with backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridgev2-2025-05-15/CreateEventSource">REST API Reference for CreateEventSource Operation</seealso>
        public virtual Task<CreateEventSourceResponse> CreateEventSourceAsync(CreateEventSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEventSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEventSourceResponseUnmarshaller.Instance;

            return InvokeAsync<CreateEventSourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateSubscriber

        internal virtual CreateSubscriberResponse CreateSubscriber(CreateSubscriberRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSubscriberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSubscriberResponseUnmarshaller.Instance;

            return Invoke<CreateSubscriberResponse>(request, options);
        }



        /// <summary>
        /// Creates a subscriber on an event bus, which delivers matching events to the configured
        /// target. The bus must be ACTIVE. Retries carrying the same ClientToken are idempotent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSubscriber service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSubscriber service method, as returned by EventBridgeV2.</returns>
        /// <exception cref="Amazon.EventBridgeV2.Model.AccessDeniedException">
        /// The caller does not have the permissions required to perform the operation. This error
        /// is also returned when the operation cannot use the AWS KMS key for the event bus.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.ConcurrentModificationException">
        /// Another change to the resource is already in progress. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.IdempotentParameterMismatchException">
        /// The request reuses the client token of an earlier request with different parameters.
        /// Use a new client token, or resend the earlier request unchanged.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.InternalException">
        /// The request failed because of an internal service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.InvalidInputException">
        /// A request parameter is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.InvalidStateException">
        /// The resource is not in a state that allows the operation. For example, an event bus
        /// that is still being created cannot accept events.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.LimitExceededException">
        /// The request would exceed a service quota for the account.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.ResourceAlreadyExistsException">
        /// A resource with the same name already exists.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.ResourceNotFoundException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.ThrottlingException">
        /// The request was throttled because it exceeds a request rate limit. Retry the request
        /// with backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridgev2-2025-05-15/CreateSubscriber">REST API Reference for CreateSubscriber Operation</seealso>
        public virtual Task<CreateSubscriberResponse> CreateSubscriberAsync(CreateSubscriberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSubscriberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSubscriberResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSubscriberResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteEventBus

        internal virtual DeleteEventBusResponse DeleteEventBus(DeleteEventBusRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEventBusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEventBusResponseUnmarshaller.Instance;

            return Invoke<DeleteEventBusResponse>(request, options);
        }



        /// <summary>
        /// Deletes an event bus. Deletion is asynchronous: the bus moves to DELETING and disappears
        /// when complete (see the EventBusDeleted waiter). A bus with subscribers or event sources
        /// cannot be deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventBus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEventBus service method, as returned by EventBridgeV2.</returns>
        /// <exception cref="Amazon.EventBridgeV2.Model.AccessDeniedException">
        /// The caller does not have the permissions required to perform the operation. This error
        /// is also returned when the operation cannot use the AWS KMS key for the event bus.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.ConcurrentModificationException">
        /// Another change to the resource is already in progress. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.InternalException">
        /// The request failed because of an internal service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.InvalidInputException">
        /// A request parameter is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.InvalidStateException">
        /// The resource is not in a state that allows the operation. For example, an event bus
        /// that is still being created cannot accept events.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.ResourceInUseException">
        /// The resource is in use and cannot be deleted. For example, an event bus with subscribers
        /// or event sources cannot be deleted until they are deleted.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.ResourceNotFoundException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.ThrottlingException">
        /// The request was throttled because it exceeds a request rate limit. Retry the request
        /// with backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridgev2-2025-05-15/DeleteEventBus">REST API Reference for DeleteEventBus Operation</seealso>
        public virtual Task<DeleteEventBusResponse> DeleteEventBusAsync(DeleteEventBusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEventBusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEventBusResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteEventBusResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteEventSource

        internal virtual DeleteEventSourceResponse DeleteEventSource(DeleteEventSourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEventSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEventSourceResponseUnmarshaller.Instance;

            return Invoke<DeleteEventSourceResponse>(request, options);
        }



        /// <summary>
        /// Deletes an EventSource. Forwarding from its origin stops.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEventSource service method, as returned by EventBridgeV2.</returns>
        /// <exception cref="Amazon.EventBridgeV2.Model.AccessDeniedException">
        /// The caller does not have the permissions required to perform the operation. This error
        /// is also returned when the operation cannot use the AWS KMS key for the event bus.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.ConcurrentModificationException">
        /// Another change to the resource is already in progress. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.InternalException">
        /// The request failed because of an internal service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.InvalidInputException">
        /// A request parameter is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.InvalidStateException">
        /// The resource is not in a state that allows the operation. For example, an event bus
        /// that is still being created cannot accept events.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.ResourceNotFoundException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.ThrottlingException">
        /// The request was throttled because it exceeds a request rate limit. Retry the request
        /// with backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridgev2-2025-05-15/DeleteEventSource">REST API Reference for DeleteEventSource Operation</seealso>
        public virtual Task<DeleteEventSourceResponse> DeleteEventSourceAsync(DeleteEventSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEventSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEventSourceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteEventSourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteResourcePolicy

        internal virtual DeleteResourcePolicyResponse DeleteResourcePolicy(DeleteResourcePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteResourcePolicyResponse>(request, options);
        }



        /// <summary>
        /// Deletes the named resource policy attached to an event bus.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteResourcePolicy service method, as returned by EventBridgeV2.</returns>
        /// <exception cref="Amazon.EventBridgeV2.Model.AccessDeniedException">
        /// The caller does not have the permissions required to perform the operation. This error
        /// is also returned when the operation cannot use the AWS KMS key for the event bus.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.ConcurrentModificationException">
        /// Another change to the resource is already in progress. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.ConflictException">
        /// A client-supplied precondition (e.g. ExpectedRevisionId on a resource-policy write)
        /// did not match the current state of the resource. Retrying the same request will fail
        /// again; re-read the resource and re-evaluate before retrying.
        /// 
        ///  
        /// <para>
        /// A conditional request is not retry-safe on its own. If an earlier attempt committed
        /// but its response never reached the caller, retrying fails with this error, which is
        /// indistinguishable from another writer having won. Compare the resource's current contents
        /// with what the request intended: a successful attempt stores a revision ID the caller
        /// never saw, so the revision alone cannot tell the two apart, but matching contents
        /// mean the change took effect.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.InternalException">
        /// The request failed because of an internal service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.InvalidInputException">
        /// A request parameter is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.ResourceNotFoundException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.ThrottlingException">
        /// The request was throttled because it exceeds a request rate limit. Retry the request
        /// with backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridgev2-2025-05-15/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        public virtual Task<DeleteResourcePolicyResponse> DeleteResourcePolicyAsync(DeleteResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourcePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteResourcePolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteSubscriber

        internal virtual DeleteSubscriberResponse DeleteSubscriber(DeleteSubscriberRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSubscriberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSubscriberResponseUnmarshaller.Instance;

            return Invoke<DeleteSubscriberResponse>(request, options);
        }



        /// <summary>
        /// Deletes a subscriber. Events are no longer delivered to its target.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubscriber service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSubscriber service method, as returned by EventBridgeV2.</returns>
        /// <exception cref="Amazon.EventBridgeV2.Model.AccessDeniedException">
        /// The caller does not have the permissions required to perform the operation. This error
        /// is also returned when the operation cannot use the AWS KMS key for the event bus.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.ConcurrentModificationException">
        /// Another change to the resource is already in progress. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.InternalException">
        /// The request failed because of an internal service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.InvalidInputException">
        /// A request parameter is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.ResourceNotFoundException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.ThrottlingException">
        /// The request was throttled because it exceeds a request rate limit. Retry the request
        /// with backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridgev2-2025-05-15/DeleteSubscriber">REST API Reference for DeleteSubscriber Operation</seealso>
        public virtual Task<DeleteSubscriberResponse> DeleteSubscriberAsync(DeleteSubscriberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSubscriberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSubscriberResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSubscriberResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeEventBus

        internal virtual DescribeEventBusResponse DescribeEventBus(DescribeEventBusRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEventBusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventBusResponseUnmarshaller.Instance;

            return Invoke<DescribeEventBusResponse>(request, options);
        }



        /// <summary>
        /// Returns the full configuration and lifecycle state of an event bus.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventBus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEventBus service method, as returned by EventBridgeV2.</returns>
        /// <exception cref="Amazon.EventBridgeV2.Model.AccessDeniedException">
        /// The caller does not have the permissions required to perform the operation. This error
        /// is also returned when the operation cannot use the AWS KMS key for the event bus.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.InternalException">
        /// The request failed because of an internal service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.InvalidInputException">
        /// A request parameter is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.ResourceNotFoundException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.ThrottlingException">
        /// The request was throttled because it exceeds a request rate limit. Retry the request
        /// with backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridgev2-2025-05-15/DescribeEventBus">REST API Reference for DescribeEventBus Operation</seealso>
        public virtual Task<DescribeEventBusResponse> DescribeEventBusAsync(DescribeEventBusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEventBusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventBusResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEventBusResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeEventSource

        internal virtual DescribeEventSourceResponse DescribeEventSource(DescribeEventSourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEventSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventSourceResponseUnmarshaller.Instance;

            return Invoke<DescribeEventSourceResponse>(request, options);
        }



        /// <summary>
        /// Returns the full configuration and lifecycle state of an EventSource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEventSource service method, as returned by EventBridgeV2.</returns>
        /// <exception cref="Amazon.EventBridgeV2.Model.AccessDeniedException">
        /// The caller does not have the permissions required to perform the operation. This error
        /// is also returned when the operation cannot use the AWS KMS key for the event bus.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.InternalException">
        /// The request failed because of an internal service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.InvalidInputException">
        /// A request parameter is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.ResourceNotFoundException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.ThrottlingException">
        /// The request was throttled because it exceeds a request rate limit. Retry the request
        /// with backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridgev2-2025-05-15/DescribeEventSource">REST API Reference for DescribeEventSource Operation</seealso>
        public virtual Task<DescribeEventSourceResponse> DescribeEventSourceAsync(DescribeEventSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEventSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventSourceResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEventSourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeSubscriber

        internal virtual DescribeSubscriberResponse DescribeSubscriber(DescribeSubscriberRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeSubscriberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSubscriberResponseUnmarshaller.Instance;

            return Invoke<DescribeSubscriberResponse>(request, options);
        }



        /// <summary>
        /// Returns the full configuration and state of a subscriber.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSubscriber service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSubscriber service method, as returned by EventBridgeV2.</returns>
        /// <exception cref="Amazon.EventBridgeV2.Model.AccessDeniedException">
        /// The caller does not have the permissions required to perform the operation. This error
        /// is also returned when the operation cannot use the AWS KMS key for the event bus.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.InternalException">
        /// The request failed because of an internal service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.InvalidInputException">
        /// A request parameter is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.ResourceNotFoundException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.ThrottlingException">
        /// The request was throttled because it exceeds a request rate limit. Retry the request
        /// with backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridgev2-2025-05-15/DescribeSubscriber">REST API Reference for DescribeSubscriber Operation</seealso>
        public virtual Task<DescribeSubscriberResponse> DescribeSubscriberAsync(DescribeSubscriberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeSubscriberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSubscriberResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSubscriberResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetResourcePolicy

        internal virtual GetResourcePolicyResponse GetResourcePolicy(GetResourcePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<GetResourcePolicyResponse>(request, options);
        }



        /// <summary>
        /// Returns the named resource policy attached to an event bus. Fails with ResourceNotFoundException
        /// when the event bus or the named policy does not exist.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetResourcePolicy service method, as returned by EventBridgeV2.</returns>
        /// <exception cref="Amazon.EventBridgeV2.Model.AccessDeniedException">
        /// The caller does not have the permissions required to perform the operation. This error
        /// is also returned when the operation cannot use the AWS KMS key for the event bus.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.InternalException">
        /// The request failed because of an internal service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.InvalidInputException">
        /// A request parameter is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.ResourceNotFoundException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.ThrottlingException">
        /// The request was throttled because it exceeds a request rate limit. Retry the request
        /// with backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridgev2-2025-05-15/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        public virtual Task<GetResourcePolicyResponse> GetResourcePolicyAsync(GetResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetResourcePolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListEventBuses

        internal virtual ListEventBusesResponse ListEventBuses(ListEventBusesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEventBusesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEventBusesResponseUnmarshaller.Instance;

            return Invoke<ListEventBusesResponse>(request, options);
        }



        /// <summary>
        /// Lists the event buses visible to the caller: buses the account owns and buses shared
        /// with it through AWS RAM. Shared entries carry identity fields only (Name, EventBusArn,
        /// EventBusAccountId); owned entries carry every summary field. Set EventBusAccountId
        /// to scope the list to one owner account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEventBuses service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEventBuses service method, as returned by EventBridgeV2.</returns>
        /// <exception cref="Amazon.EventBridgeV2.Model.AccessDeniedException">
        /// The caller does not have the permissions required to perform the operation. This error
        /// is also returned when the operation cannot use the AWS KMS key for the event bus.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.InternalException">
        /// The request failed because of an internal service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.InvalidInputException">
        /// A request parameter is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.ThrottlingException">
        /// The request was throttled because it exceeds a request rate limit. Retry the request
        /// with backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridgev2-2025-05-15/ListEventBuses">REST API Reference for ListEventBuses Operation</seealso>
        public virtual Task<ListEventBusesResponse> ListEventBusesAsync(ListEventBusesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEventBusesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEventBusesResponseUnmarshaller.Instance;

            return InvokeAsync<ListEventBusesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListEventSources

        internal virtual ListEventSourcesResponse ListEventSources(ListEventSourcesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEventSourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEventSourcesResponseUnmarshaller.Instance;

            return Invoke<ListEventSourcesResponse>(request, options);
        }



        /// <summary>
        /// Lists EventSources as summaries. By default the list spans the EventSources the caller
        /// account owns; set EventBusArn to scope it to one bus. Use DescribeEventSource to retrieve
        /// full configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEventSources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEventSources service method, as returned by EventBridgeV2.</returns>
        /// <exception cref="Amazon.EventBridgeV2.Model.AccessDeniedException">
        /// The caller does not have the permissions required to perform the operation. This error
        /// is also returned when the operation cannot use the AWS KMS key for the event bus.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.InternalException">
        /// The request failed because of an internal service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.InvalidInputException">
        /// A request parameter is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.ResourceNotFoundException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.ThrottlingException">
        /// The request was throttled because it exceeds a request rate limit. Retry the request
        /// with backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridgev2-2025-05-15/ListEventSources">REST API Reference for ListEventSources Operation</seealso>
        public virtual Task<ListEventSourcesResponse> ListEventSourcesAsync(ListEventSourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEventSourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEventSourcesResponseUnmarshaller.Instance;

            return InvokeAsync<ListEventSourcesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListResourcePolicies

        internal virtual ListResourcePoliciesResponse ListResourcePolicies(ListResourcePoliciesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListResourcePoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourcePoliciesResponseUnmarshaller.Instance;

            return Invoke<ListResourcePoliciesResponse>(request, options);
        }



        /// <summary>
        /// Lists the resource policies attached to an event bus as summaries (policy name and
        /// revision ID). Use GetResourcePolicy to retrieve a policy document.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourcePolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListResourcePolicies service method, as returned by EventBridgeV2.</returns>
        /// <exception cref="Amazon.EventBridgeV2.Model.AccessDeniedException">
        /// The caller does not have the permissions required to perform the operation. This error
        /// is also returned when the operation cannot use the AWS KMS key for the event bus.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.InternalException">
        /// The request failed because of an internal service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.InvalidInputException">
        /// A request parameter is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.ResourceNotFoundException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.ThrottlingException">
        /// The request was throttled because it exceeds a request rate limit. Retry the request
        /// with backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridgev2-2025-05-15/ListResourcePolicies">REST API Reference for ListResourcePolicies Operation</seealso>
        public virtual Task<ListResourcePoliciesResponse> ListResourcePoliciesAsync(ListResourcePoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListResourcePoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourcePoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<ListResourcePoliciesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListSubscribers

        internal virtual ListSubscribersResponse ListSubscribers(ListSubscribersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSubscribersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSubscribersResponseUnmarshaller.Instance;

            return Invoke<ListSubscribersResponse>(request, options);
        }



        /// <summary>
        /// Lists subscribers as summaries. By default the list spans the subscribers the caller
        /// account owns across all buses; set EventBusArn to scope it to one bus. Use DescribeSubscriber
        /// to retrieve full configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSubscribers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSubscribers service method, as returned by EventBridgeV2.</returns>
        /// <exception cref="Amazon.EventBridgeV2.Model.AccessDeniedException">
        /// The caller does not have the permissions required to perform the operation. This error
        /// is also returned when the operation cannot use the AWS KMS key for the event bus.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.InternalException">
        /// The request failed because of an internal service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.InvalidInputException">
        /// A request parameter is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.ResourceNotFoundException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.ThrottlingException">
        /// The request was throttled because it exceeds a request rate limit. Retry the request
        /// with backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridgev2-2025-05-15/ListSubscribers">REST API Reference for ListSubscribers Operation</seealso>
        public virtual Task<ListSubscribersResponse> ListSubscribersAsync(ListSubscribersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSubscribersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSubscribersResponseUnmarshaller.Instance;

            return InvokeAsync<ListSubscribersResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }



        /// <summary>
        /// Lists the tags on an event bus, subscriber, or event source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by EventBridgeV2.</returns>
        /// <exception cref="Amazon.EventBridgeV2.Model.AccessDeniedException">
        /// The caller does not have the permissions required to perform the operation. This error
        /// is also returned when the operation cannot use the AWS KMS key for the event bus.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.InternalException">
        /// The request failed because of an internal service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.InvalidInputException">
        /// A request parameter is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.ResourceNotFoundException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.ThrottlingException">
        /// The request was throttled because it exceeds a request rate limit. Retry the request
        /// with backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridgev2-2025-05-15/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutEvents

        internal virtual PutEventsResponse PutEvents(PutEventsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEventsResponseUnmarshaller.Instance;

            return Invoke<PutEventsResponse>(request, options);
        }



        /// <summary>
        /// Publishes events to an event bus.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutEvents service method, as returned by EventBridgeV2.</returns>
        /// <exception cref="Amazon.EventBridgeV2.Model.AccessDeniedException">
        /// The caller does not have the permissions required to perform the operation. This error
        /// is also returned when the operation cannot use the AWS KMS key for the event bus.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.InternalException">
        /// The request failed because of an internal service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.InvalidInputException">
        /// A request parameter is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.InvalidStateException">
        /// The resource is not in a state that allows the operation. For example, an event bus
        /// that is still being created cannot accept events.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.ResourceNotFoundException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.ThrottlingException">
        /// The request was throttled because it exceeds a request rate limit. Retry the request
        /// with backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridgev2-2025-05-15/PutEvents">REST API Reference for PutEvents Operation</seealso>
        public virtual Task<PutEventsResponse> PutEventsAsync(PutEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEventsResponseUnmarshaller.Instance;

            return InvokeAsync<PutEventsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutRawEvents

        internal virtual PutRawEventsResponse PutRawEvents(PutRawEventsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutRawEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRawEventsResponseUnmarshaller.Instance;

            return Invoke<PutRawEventsResponse>(request, options);
        }



        /// <summary>
        /// Publishes pre-shaped events to an event bus.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRawEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutRawEvents service method, as returned by EventBridgeV2.</returns>
        /// <exception cref="Amazon.EventBridgeV2.Model.AccessDeniedException">
        /// The caller does not have the permissions required to perform the operation. This error
        /// is also returned when the operation cannot use the AWS KMS key for the event bus.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.InternalException">
        /// The request failed because of an internal service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.InvalidInputException">
        /// A request parameter is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.InvalidStateException">
        /// The resource is not in a state that allows the operation. For example, an event bus
        /// that is still being created cannot accept events.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.ResourceNotFoundException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.SchemaRegistryUnavailableException">
        /// The configured schema registry could not be reached. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.ThrottlingException">
        /// The request was throttled because it exceeds a request rate limit. Retry the request
        /// with backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridgev2-2025-05-15/PutRawEvents">REST API Reference for PutRawEvents Operation</seealso>
        public virtual Task<PutRawEventsResponse> PutRawEventsAsync(PutRawEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutRawEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRawEventsResponseUnmarshaller.Instance;

            return InvokeAsync<PutRawEventsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutResourcePolicy

        internal virtual PutResourcePolicyResponse PutResourcePolicy(PutResourcePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<PutResourcePolicyResponse>(request, options);
        }



        /// <summary>
        /// Attaches a named resource policy to an event bus — the only resource type that supports
        /// policies; other resource ARNs are rejected. Each bus holds two named policies: &quot;default&quot;
        /// (customer-managed, full IAM policy language including Deny) and &quot;AWS_RAM&quot;
        /// (written exclusively by AWS Resource Access Manager to reflect resource shares). Both
        /// policies are evaluated on cross-account authorization; an explicit Deny in either
        /// overrides an Allow in the other. Operations that omit PolicyName target &quot;default&quot;.
        /// A &quot;default&quot; policy that would grant public access is rejected with PublicPolicyException
        /// and is not attached; this check is always on and cannot be disabled.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutResourcePolicy service method, as returned by EventBridgeV2.</returns>
        /// <exception cref="Amazon.EventBridgeV2.Model.AccessDeniedException">
        /// The caller does not have the permissions required to perform the operation. This error
        /// is also returned when the operation cannot use the AWS KMS key for the event bus.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.ConcurrentModificationException">
        /// Another change to the resource is already in progress. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.ConflictException">
        /// A client-supplied precondition (e.g. ExpectedRevisionId on a resource-policy write)
        /// did not match the current state of the resource. Retrying the same request will fail
        /// again; re-read the resource and re-evaluate before retrying.
        /// 
        ///  
        /// <para>
        /// A conditional request is not retry-safe on its own. If an earlier attempt committed
        /// but its response never reached the caller, retrying fails with this error, which is
        /// indistinguishable from another writer having won. Compare the resource's current contents
        /// with what the request intended: a successful attempt stores a revision ID the caller
        /// never saw, so the revision alone cannot tell the two apart, but matching contents
        /// mean the change took effect.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.InternalException">
        /// The request failed because of an internal service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.InvalidInputException">
        /// A request parameter is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.PolicyLengthExceededException">
        /// The policy document is larger than the account's resource policy size quota, or larger
        /// than the service maximum.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.PublicPolicyException">
        /// The policy was rejected because it would grant public access to the event bus. A statement
        /// grants public access when its principal is a wildcard and no condition limits the
        /// callers to specific AWS accounts or principals. To fix it, replace the wildcard principal
        /// with specific principals, or add a condition that limits the callers to specific AWS
        /// accounts. Conditions on event content (events:source, events:detail-type, events:Metadata/*)
        /// do not identify the caller and do not make a wildcard principal non-public. Returned
        /// only for the &quot;default&quot; policy; the &quot;AWS_RAM&quot; policy is composed
        /// by AWS Resource Access Manager and never grants public access.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.ResourceNotFoundException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.ThrottlingException">
        /// The request was throttled because it exceeds a request rate limit. Retry the request
        /// with backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridgev2-2025-05-15/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        public virtual Task<PutResourcePolicyResponse> PutResourcePolicyAsync(PutResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourcePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutResourcePolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RevokeResource

        internal virtual RevokeResourceResponse RevokeResource(RevokeResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RevokeResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeResourceResponseUnmarshaller.Instance;

            return Invoke<RevokeResourceResponse>(request, options);
        }



        /// <summary>
        /// Revokes a subscriber or an EventSource. The bus owner calls this to withdraw a misbehaving
        /// resource attached to their bus. Revocation is terminal: there is no operation that
        /// clears it. A revoked resource refuses mutating operations with InvalidStateException;
        /// delete stays available for cleanup.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RevokeResource service method, as returned by EventBridgeV2.</returns>
        /// <exception cref="Amazon.EventBridgeV2.Model.AccessDeniedException">
        /// The caller does not have the permissions required to perform the operation. This error
        /// is also returned when the operation cannot use the AWS KMS key for the event bus.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.ConcurrentModificationException">
        /// Another change to the resource is already in progress. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.InternalException">
        /// The request failed because of an internal service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.InvalidInputException">
        /// A request parameter is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.InvalidStateException">
        /// The resource is not in a state that allows the operation. For example, an event bus
        /// that is still being created cannot accept events.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.ResourceNotFoundException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.ThrottlingException">
        /// The request was throttled because it exceeds a request rate limit. Retry the request
        /// with backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridgev2-2025-05-15/RevokeResource">REST API Reference for RevokeResource Operation</seealso>
        public virtual Task<RevokeResourceResponse> RevokeResourceAsync(RevokeResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RevokeResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeResourceResponseUnmarshaller.Instance;

            return InvokeAsync<RevokeResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



        /// <summary>
        /// Adds or replaces tags on an event bus, subscriber, or event source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by EventBridgeV2.</returns>
        /// <exception cref="Amazon.EventBridgeV2.Model.AccessDeniedException">
        /// The caller does not have the permissions required to perform the operation. This error
        /// is also returned when the operation cannot use the AWS KMS key for the event bus.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.ConcurrentModificationException">
        /// Another change to the resource is already in progress. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.InternalException">
        /// The request failed because of an internal service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.InvalidInputException">
        /// A request parameter is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.InvalidStateException">
        /// The resource is not in a state that allows the operation. For example, an event bus
        /// that is still being created cannot accept events.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.LimitExceededException">
        /// The request would exceed a service quota for the account.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.ResourceNotFoundException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.ThrottlingException">
        /// The request was throttled because it exceeds a request rate limit. Retry the request
        /// with backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridgev2-2025-05-15/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }



        /// <summary>
        /// Removes tags from an event bus, subscriber, or event source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by EventBridgeV2.</returns>
        /// <exception cref="Amazon.EventBridgeV2.Model.AccessDeniedException">
        /// The caller does not have the permissions required to perform the operation. This error
        /// is also returned when the operation cannot use the AWS KMS key for the event bus.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.ConcurrentModificationException">
        /// Another change to the resource is already in progress. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.InternalException">
        /// The request failed because of an internal service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.InvalidInputException">
        /// A request parameter is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.InvalidStateException">
        /// The resource is not in a state that allows the operation. For example, an event bus
        /// that is still being created cannot accept events.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.ResourceNotFoundException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.ThrottlingException">
        /// The request was throttled because it exceeds a request rate limit. Retry the request
        /// with backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridgev2-2025-05-15/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateEventBus

        internal virtual UpdateEventBusResponse UpdateEventBus(UpdateEventBusRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateEventBusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEventBusResponseUnmarshaller.Instance;

            return Invoke<UpdateEventBusResponse>(request, options);
        }



        /// <summary>
        /// Updates an event bus. The update is asynchronous: the bus moves to UPDATING and returns
        /// to ACTIVE when the change is applied. Fields omitted from the request are left unchanged.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEventBus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateEventBus service method, as returned by EventBridgeV2.</returns>
        /// <exception cref="Amazon.EventBridgeV2.Model.AccessDeniedException">
        /// The caller does not have the permissions required to perform the operation. This error
        /// is also returned when the operation cannot use the AWS KMS key for the event bus.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.ConcurrentModificationException">
        /// Another change to the resource is already in progress. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.InternalException">
        /// The request failed because of an internal service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.InvalidInputException">
        /// A request parameter is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.InvalidStateException">
        /// The resource is not in a state that allows the operation. For example, an event bus
        /// that is still being created cannot accept events.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.ResourceNotFoundException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.ThrottlingException">
        /// The request was throttled because it exceeds a request rate limit. Retry the request
        /// with backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridgev2-2025-05-15/UpdateEventBus">REST API Reference for UpdateEventBus Operation</seealso>
        public virtual Task<UpdateEventBusResponse> UpdateEventBusAsync(UpdateEventBusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateEventBusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEventBusResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateEventBusResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateEventSource

        internal virtual UpdateEventSourceResponse UpdateEventSource(UpdateEventSourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateEventSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEventSourceResponseUnmarshaller.Instance;

            return Invoke<UpdateEventSourceResponse>(request, options);
        }



        /// <summary>
        /// Updates an EventSource. Fields omitted from the request are left unchanged.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEventSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateEventSource service method, as returned by EventBridgeV2.</returns>
        /// <exception cref="Amazon.EventBridgeV2.Model.AccessDeniedException">
        /// The caller does not have the permissions required to perform the operation. This error
        /// is also returned when the operation cannot use the AWS KMS key for the event bus.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.ConcurrentModificationException">
        /// Another change to the resource is already in progress. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.InternalException">
        /// The request failed because of an internal service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.InvalidInputException">
        /// A request parameter is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.InvalidStateException">
        /// The resource is not in a state that allows the operation. For example, an event bus
        /// that is still being created cannot accept events.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.ResourceNotFoundException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.ThrottlingException">
        /// The request was throttled because it exceeds a request rate limit. Retry the request
        /// with backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridgev2-2025-05-15/UpdateEventSource">REST API Reference for UpdateEventSource Operation</seealso>
        public virtual Task<UpdateEventSourceResponse> UpdateEventSourceAsync(UpdateEventSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateEventSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEventSourceResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateEventSourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateSubscriber

        internal virtual UpdateSubscriberResponse UpdateSubscriber(UpdateSubscriberRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSubscriberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSubscriberResponseUnmarshaller.Instance;

            return Invoke<UpdateSubscriberResponse>(request, options);
        }



        /// <summary>
        /// Updates a subscriber. Fields omitted from the request are left unchanged.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSubscriber service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSubscriber service method, as returned by EventBridgeV2.</returns>
        /// <exception cref="Amazon.EventBridgeV2.Model.AccessDeniedException">
        /// The caller does not have the permissions required to perform the operation. This error
        /// is also returned when the operation cannot use the AWS KMS key for the event bus.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.ConcurrentModificationException">
        /// Another change to the resource is already in progress. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.InternalException">
        /// The request failed because of an internal service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.InvalidInputException">
        /// A request parameter is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.InvalidStateException">
        /// The resource is not in a state that allows the operation. For example, an event bus
        /// that is still being created cannot accept events.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.LimitExceededException">
        /// The request would exceed a service quota for the account.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.ResourceNotFoundException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.EventBridgeV2.Model.ThrottlingException">
        /// The request was throttled because it exceeds a request rate limit. Retry the request
        /// with backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridgev2-2025-05-15/UpdateSubscriber">REST API Reference for UpdateSubscriber Operation</seealso>
        public virtual Task<UpdateSubscriberResponse> UpdateSubscriberAsync(UpdateSubscriberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSubscriberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSubscriberResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSubscriberResponse>(request, options, cancellationToken);
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