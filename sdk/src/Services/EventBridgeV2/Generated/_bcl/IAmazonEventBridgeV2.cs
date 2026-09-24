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
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.EventBridgeV2.Model;

#pragma warning disable CS1570
namespace Amazon.EventBridgeV2
{
    /// <summary>
    /// <para>Interface for accessing EventBridgeV2</para>
    ///
    /// Amazon EventBridge event bus API. An event bus receives events published by your applications
    /// and AWS services, stores them for a configurable retention period, and delivers them
    /// to subscribers. A subscriber filters events, optionally transforms them, and invokes
    /// a target such as Lambda, SQS, SNS, Kinesis, Step Functions, or an HTTP endpoint. The
    /// API manages event buses, subscribers, event sources, resource policies, and tags,
    /// and publishes events through PutEvents and PutRawEvents.
    /// </summary>
    public partial interface IAmazonEventBridgeV2 : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IEventBridgeV2PaginatorFactory Paginators { get; }

        
        #region  CreateEventBus


        /// <summary>
        /// Creates an event bus. Provisioning is asynchronous: the bus is returned in the CREATING
        /// state and transitions to ACTIVE when ready (see the EventBusActive waiter). Retries
        /// carrying the same ClientToken are idempotent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEventBus service method.</param>
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
        CreateEventBusResponse CreateEventBus(CreateEventBusRequest request);



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
        Task<CreateEventBusResponse> CreateEventBusAsync(CreateEventBusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateEventSource


        /// <summary>
        /// Creates an EventSource, which forwards events from an origin (an AWS service or another
        /// account) onto an event bus. The bus must be ACTIVE. Retries carrying the same ClientToken
        /// are idempotent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEventSource service method.</param>
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
        CreateEventSourceResponse CreateEventSource(CreateEventSourceRequest request);



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
        Task<CreateEventSourceResponse> CreateEventSourceAsync(CreateEventSourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateSubscriber


        /// <summary>
        /// Creates a subscriber on an event bus, which delivers matching events to the configured
        /// target. The bus must be ACTIVE. Retries carrying the same ClientToken are idempotent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSubscriber service method.</param>
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
        CreateSubscriberResponse CreateSubscriber(CreateSubscriberRequest request);



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
        Task<CreateSubscriberResponse> CreateSubscriberAsync(CreateSubscriberRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteEventBus


        /// <summary>
        /// Deletes an event bus. Deletion is asynchronous: the bus moves to DELETING and disappears
        /// when complete (see the EventBusDeleted waiter). A bus with subscribers or event sources
        /// cannot be deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventBus service method.</param>
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
        DeleteEventBusResponse DeleteEventBus(DeleteEventBusRequest request);



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
        Task<DeleteEventBusResponse> DeleteEventBusAsync(DeleteEventBusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteEventSource


        /// <summary>
        /// Deletes an EventSource. Forwarding from its origin stops.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventSource service method.</param>
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
        DeleteEventSourceResponse DeleteEventSource(DeleteEventSourceRequest request);



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
        Task<DeleteEventSourceResponse> DeleteEventSourceAsync(DeleteEventSourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteResourcePolicy


        /// <summary>
        /// Deletes the named resource policy attached to an event bus.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy service method.</param>
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
        DeleteResourcePolicyResponse DeleteResourcePolicy(DeleteResourcePolicyRequest request);



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
        Task<DeleteResourcePolicyResponse> DeleteResourcePolicyAsync(DeleteResourcePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteSubscriber


        /// <summary>
        /// Deletes a subscriber. Events are no longer delivered to its target.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubscriber service method.</param>
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
        DeleteSubscriberResponse DeleteSubscriber(DeleteSubscriberRequest request);



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
        Task<DeleteSubscriberResponse> DeleteSubscriberAsync(DeleteSubscriberRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeEventBus


        /// <summary>
        /// Returns the full configuration and lifecycle state of an event bus.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventBus service method.</param>
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
        DescribeEventBusResponse DescribeEventBus(DescribeEventBusRequest request);



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
        Task<DescribeEventBusResponse> DescribeEventBusAsync(DescribeEventBusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeEventSource


        /// <summary>
        /// Returns the full configuration and lifecycle state of an EventSource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventSource service method.</param>
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
        DescribeEventSourceResponse DescribeEventSource(DescribeEventSourceRequest request);



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
        Task<DescribeEventSourceResponse> DescribeEventSourceAsync(DescribeEventSourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeSubscriber


        /// <summary>
        /// Returns the full configuration and state of a subscriber.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSubscriber service method.</param>
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
        DescribeSubscriberResponse DescribeSubscriber(DescribeSubscriberRequest request);



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
        Task<DescribeSubscriberResponse> DescribeSubscriberAsync(DescribeSubscriberRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetResourcePolicy


        /// <summary>
        /// Returns the named resource policy attached to an event bus. Fails with ResourceNotFoundException
        /// when the event bus or the named policy does not exist.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy service method.</param>
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
        GetResourcePolicyResponse GetResourcePolicy(GetResourcePolicyRequest request);



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
        Task<GetResourcePolicyResponse> GetResourcePolicyAsync(GetResourcePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListEventBuses


        /// <summary>
        /// Lists the event buses visible to the caller: buses the account owns and buses shared
        /// with it through AWS RAM. Shared entries carry identity fields only (Name, EventBusArn,
        /// EventBusAccountId); owned entries carry every summary field. Set EventBusAccountId
        /// to scope the list to one owner account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEventBuses service method.</param>
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
        ListEventBusesResponse ListEventBuses(ListEventBusesRequest request);



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
        Task<ListEventBusesResponse> ListEventBusesAsync(ListEventBusesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListEventSources


        /// <summary>
        /// Lists EventSources as summaries. By default the list spans the EventSources the caller
        /// account owns; set EventBusArn to scope it to one bus. Use DescribeEventSource to retrieve
        /// full configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEventSources service method.</param>
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
        ListEventSourcesResponse ListEventSources(ListEventSourcesRequest request);



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
        Task<ListEventSourcesResponse> ListEventSourcesAsync(ListEventSourcesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListResourcePolicies


        /// <summary>
        /// Lists the resource policies attached to an event bus as summaries (policy name and
        /// revision ID). Use GetResourcePolicy to retrieve a policy document.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourcePolicies service method.</param>
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
        ListResourcePoliciesResponse ListResourcePolicies(ListResourcePoliciesRequest request);



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
        Task<ListResourcePoliciesResponse> ListResourcePoliciesAsync(ListResourcePoliciesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListSubscribers


        /// <summary>
        /// Lists subscribers as summaries. By default the list spans the subscribers the caller
        /// account owns across all buses; set EventBusArn to scope it to one bus. Use DescribeSubscriber
        /// to retrieve full configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSubscribers service method.</param>
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
        ListSubscribersResponse ListSubscribers(ListSubscribersRequest request);



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
        Task<ListSubscribersResponse> ListSubscribersAsync(ListSubscribersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags on an event bus, subscriber, or event source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
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
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



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
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutEvents


        /// <summary>
        /// Publishes events to an event bus.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEvents service method.</param>
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
        PutEventsResponse PutEvents(PutEventsRequest request);



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
        Task<PutEventsResponse> PutEventsAsync(PutEventsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutRawEvents


        /// <summary>
        /// Publishes pre-shaped events to an event bus.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRawEvents service method.</param>
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
        PutRawEventsResponse PutRawEvents(PutRawEventsRequest request);



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
        Task<PutRawEventsResponse> PutRawEventsAsync(PutRawEventsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutResourcePolicy


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
        PutResourcePolicyResponse PutResourcePolicy(PutResourcePolicyRequest request);



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
        Task<PutResourcePolicyResponse> PutResourcePolicyAsync(PutResourcePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RevokeResource


        /// <summary>
        /// Revokes a subscriber or an EventSource. The bus owner calls this to withdraw a misbehaving
        /// resource attached to their bus. Revocation is terminal: there is no operation that
        /// clears it. A revoked resource refuses mutating operations with InvalidStateException;
        /// delete stays available for cleanup.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeResource service method.</param>
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
        RevokeResourceResponse RevokeResource(RevokeResourceRequest request);



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
        Task<RevokeResourceResponse> RevokeResourceAsync(RevokeResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds or replaces tags on an event bus, subscriber, or event source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
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
        TagResourceResponse TagResource(TagResourceRequest request);



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
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes tags from an event bus, subscriber, or event source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
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
        UntagResourceResponse UntagResource(UntagResourceRequest request);



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
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateEventBus


        /// <summary>
        /// Updates an event bus. The update is asynchronous: the bus moves to UPDATING and returns
        /// to ACTIVE when the change is applied. Fields omitted from the request are left unchanged.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEventBus service method.</param>
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
        UpdateEventBusResponse UpdateEventBus(UpdateEventBusRequest request);



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
        Task<UpdateEventBusResponse> UpdateEventBusAsync(UpdateEventBusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateEventSource


        /// <summary>
        /// Updates an EventSource. Fields omitted from the request are left unchanged.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEventSource service method.</param>
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
        UpdateEventSourceResponse UpdateEventSource(UpdateEventSourceRequest request);



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
        Task<UpdateEventSourceResponse> UpdateEventSourceAsync(UpdateEventSourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateSubscriber


        /// <summary>
        /// Updates a subscriber. Fields omitted from the request are left unchanged.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSubscriber service method.</param>
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
        UpdateSubscriberResponse UpdateSubscriber(UpdateSubscriberRequest request);



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
        Task<UpdateSubscriberResponse> UpdateSubscriberAsync(UpdateSubscriberRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

    }
}