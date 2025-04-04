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
 * Do not modify this file. This file is generated from the eventbridge-2015-10-07.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.EventBridge.Model;

#pragma warning disable CS1570
namespace Amazon.EventBridge
{
    /// <summary>
    /// <para>Interface for accessing EventBridge</para>
    ///
    /// Amazon EventBridge helps you to respond to state changes in your Amazon Web Services
    /// resources. When your resources change state, they automatically send events to an
    /// event stream. You can create rules that match selected events in the stream and route
    /// them to targets to take action. You can also use rules to take action on a predetermined
    /// schedule. For example, you can configure rules to:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Automatically invoke an Lambda function to update DNS entries when an event notifies
    /// you that Amazon EC2 instance enters the running state.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Direct specific API records from CloudTrail to an Amazon Kinesis data stream for detailed
    /// analysis of potential security or availability risks.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Periodically invoke a built-in target to create a snapshot of an Amazon EBS volume.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information about the features of Amazon EventBridge, see the <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide">Amazon
    /// EventBridge User Guide</a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonEventBridge : IAmazonService, IDisposable
    {




        
        #region  ActivateEventSource


        /// <summary>
        /// Activates a partner event source that has been deactivated. Once activated, your matching
        /// event bus will start receiving events from the event source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ActivateEventSource service method.</param>
        /// 
        /// <returns>The response from the ActivateEventSource service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InvalidStateException">
        /// The specified state is not a valid state for an event source.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.OperationDisabledException">
        /// The operation you are attempting is not available in this region.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/ActivateEventSource">REST API Reference for ActivateEventSource Operation</seealso>
        ActivateEventSourceResponse ActivateEventSource(ActivateEventSourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ActivateEventSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ActivateEventSource operation on AmazonEventBridgeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndActivateEventSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/ActivateEventSource">REST API Reference for ActivateEventSource Operation</seealso>
        IAsyncResult BeginActivateEventSource(ActivateEventSourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ActivateEventSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginActivateEventSource.</param>
        /// 
        /// <returns>Returns a  ActivateEventSourceResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/ActivateEventSource">REST API Reference for ActivateEventSource Operation</seealso>
        ActivateEventSourceResponse EndActivateEventSource(IAsyncResult asyncResult);

        #endregion
        
        #region  CancelReplay


        /// <summary>
        /// Cancels the specified replay.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelReplay service method.</param>
        /// 
        /// <returns>The response from the CancelReplay service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.IllegalStatusException">
        /// An error occurred because a replay can be canceled only when the state is Running
        /// or Starting.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/CancelReplay">REST API Reference for CancelReplay Operation</seealso>
        CancelReplayResponse CancelReplay(CancelReplayRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CancelReplay operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelReplay operation on AmazonEventBridgeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelReplay
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/CancelReplay">REST API Reference for CancelReplay Operation</seealso>
        IAsyncResult BeginCancelReplay(CancelReplayRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CancelReplay operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelReplay.</param>
        /// 
        /// <returns>Returns a  CancelReplayResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/CancelReplay">REST API Reference for CancelReplay Operation</seealso>
        CancelReplayResponse EndCancelReplay(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateApiDestination


        /// <summary>
        /// Creates an API destination, which is an HTTP invocation endpoint configured as a target
        /// for events.
        /// 
        ///  
        /// <para>
        /// API destinations do not support private destinations, such as interface VPC endpoints.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-api-destinations.html">API
        /// destinations</a> in the <i>EventBridge User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApiDestination service method.</param>
        /// 
        /// <returns>The response from the CreateApiDestination service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.LimitExceededException">
        /// The request failed because it attempted to create resource beyond the allowed service
        /// quota.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceAlreadyExistsException">
        /// The resource you are trying to create already exists.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/CreateApiDestination">REST API Reference for CreateApiDestination Operation</seealso>
        CreateApiDestinationResponse CreateApiDestination(CreateApiDestinationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateApiDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApiDestination operation on AmazonEventBridgeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateApiDestination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/CreateApiDestination">REST API Reference for CreateApiDestination Operation</seealso>
        IAsyncResult BeginCreateApiDestination(CreateApiDestinationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateApiDestination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateApiDestination.</param>
        /// 
        /// <returns>Returns a  CreateApiDestinationResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/CreateApiDestination">REST API Reference for CreateApiDestination Operation</seealso>
        CreateApiDestinationResponse EndCreateApiDestination(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateArchive


        /// <summary>
        /// Creates an archive of events with the specified settings. When you create an archive,
        /// incoming events might not immediately start being sent to the archive. Allow a short
        /// period of time for changes to take effect. If you do not specify a pattern to filter
        /// events sent to the archive, all events are sent to the archive except replayed events.
        /// Replayed events are not sent to an archive.
        /// 
        ///  <important> 
        /// <para>
        /// If you have specified that EventBridge use a customer managed key for encrypting the
        /// source event bus, we strongly recommend you also specify a customer managed key for
        /// any archives for the event bus as well. 
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/encryption-archives.html">Encrypting
        /// archives</a> in the <i>Amazon EventBridge User Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateArchive service method.</param>
        /// 
        /// <returns>The response from the CreateArchive service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InvalidEventPatternException">
        /// The event pattern is not valid.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.LimitExceededException">
        /// The request failed because it attempted to create resource beyond the allowed service
        /// quota.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceAlreadyExistsException">
        /// The resource you are trying to create already exists.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/CreateArchive">REST API Reference for CreateArchive Operation</seealso>
        CreateArchiveResponse CreateArchive(CreateArchiveRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateArchive operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateArchive operation on AmazonEventBridgeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateArchive
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/CreateArchive">REST API Reference for CreateArchive Operation</seealso>
        IAsyncResult BeginCreateArchive(CreateArchiveRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateArchive operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateArchive.</param>
        /// 
        /// <returns>Returns a  CreateArchiveResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/CreateArchive">REST API Reference for CreateArchive Operation</seealso>
        CreateArchiveResponse EndCreateArchive(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateConnection


        /// <summary>
        /// Creates a connection. A connection defines the authorization type and credentials
        /// to use for authorization with an API destination HTTP endpoint.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-target-connection.html">Connections
        /// for endpoint targets</a> in the <i>Amazon EventBridge User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConnection service method.</param>
        /// 
        /// <returns>The response from the CreateConnection service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.AccessDeniedException">
        /// You do not have the necessary permissions for this action.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.LimitExceededException">
        /// The request failed because it attempted to create resource beyond the allowed service
        /// quota.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceAlreadyExistsException">
        /// The resource you are trying to create already exists.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ThrottlingException">
        /// This request cannot be completed due to throttling issues.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/CreateConnection">REST API Reference for CreateConnection Operation</seealso>
        CreateConnectionResponse CreateConnection(CreateConnectionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConnection operation on AmazonEventBridgeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/CreateConnection">REST API Reference for CreateConnection Operation</seealso>
        IAsyncResult BeginCreateConnection(CreateConnectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateConnection.</param>
        /// 
        /// <returns>Returns a  CreateConnectionResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/CreateConnection">REST API Reference for CreateConnection Operation</seealso>
        CreateConnectionResponse EndCreateConnection(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateEndpoint


        /// <summary>
        /// Creates a global endpoint. Global endpoints improve your application's availability
        /// by making it regional-fault tolerant. To do this, you define a primary and secondary
        /// Region with event buses in each Region. You also create a Amazon Route 53 health check
        /// that will tell EventBridge to route events to the secondary Region when an "unhealthy"
        /// state is encountered and events will be routed back to the primary Region when the
        /// health check reports a "healthy" state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEndpoint service method.</param>
        /// 
        /// <returns>The response from the CreateEndpoint service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.LimitExceededException">
        /// The request failed because it attempted to create resource beyond the allowed service
        /// quota.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceAlreadyExistsException">
        /// The resource you are trying to create already exists.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/CreateEndpoint">REST API Reference for CreateEndpoint Operation</seealso>
        CreateEndpointResponse CreateEndpoint(CreateEndpointRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEndpoint operation on AmazonEventBridgeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/CreateEndpoint">REST API Reference for CreateEndpoint Operation</seealso>
        IAsyncResult BeginCreateEndpoint(CreateEndpointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEndpoint.</param>
        /// 
        /// <returns>Returns a  CreateEndpointResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/CreateEndpoint">REST API Reference for CreateEndpoint Operation</seealso>
        CreateEndpointResponse EndCreateEndpoint(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateEventBus


        /// <summary>
        /// Creates a new event bus within your account. This can be a custom event bus which
        /// you can use to receive events from your custom applications and services, or it can
        /// be a partner event bus which can be matched to a partner event source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEventBus service method.</param>
        /// 
        /// <returns>The response from the CreateEventBus service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InvalidStateException">
        /// The specified state is not a valid state for an event source.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.LimitExceededException">
        /// The request failed because it attempted to create resource beyond the allowed service
        /// quota.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.OperationDisabledException">
        /// The operation you are attempting is not available in this region.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceAlreadyExistsException">
        /// The resource you are trying to create already exists.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/CreateEventBus">REST API Reference for CreateEventBus Operation</seealso>
        CreateEventBusResponse CreateEventBus(CreateEventBusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEventBus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEventBus operation on AmazonEventBridgeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateEventBus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/CreateEventBus">REST API Reference for CreateEventBus Operation</seealso>
        IAsyncResult BeginCreateEventBus(CreateEventBusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEventBus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEventBus.</param>
        /// 
        /// <returns>Returns a  CreateEventBusResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/CreateEventBus">REST API Reference for CreateEventBus Operation</seealso>
        CreateEventBusResponse EndCreateEventBus(IAsyncResult asyncResult);

        #endregion
        
        #region  CreatePartnerEventSource


        /// <summary>
        /// Called by an SaaS partner to create a partner event source. This operation is not
        /// used by Amazon Web Services customers.
        /// 
        ///  
        /// <para>
        /// Each partner event source can be used by one Amazon Web Services account to create
        /// a matching partner event bus in that Amazon Web Services account. A SaaS partner must
        /// create one partner event source for each Amazon Web Services account that wants to
        /// receive those event types. 
        /// </para>
        ///  
        /// <para>
        /// A partner event source creates events based on resources within the SaaS partner's
        /// service or application.
        /// </para>
        ///  
        /// <para>
        /// An Amazon Web Services account that creates a partner event bus that matches the partner
        /// event source can use that event bus to receive events from the partner, and then process
        /// them using Amazon Web Services Events rules and targets.
        /// </para>
        ///  
        /// <para>
        /// Partner event source names follow this format:
        /// </para>
        ///  
        /// <para>
        ///  <c> <i>partner_name</i>/<i>event_namespace</i>/<i>event_name</i> </c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>partner_name</i> is determined during partner registration, and identifies the
        /// partner to Amazon Web Services customers. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>event_namespace</i> is determined by the partner, and is a way for the partner
        /// to categorize their events.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>event_name</i> is determined by the partner, and should uniquely identify an event-generating
        /// resource within the partner system. 
        /// </para>
        ///  
        /// <para>
        /// The <i>event_name</i> must be unique across all Amazon Web Services customers. This
        /// is because the event source is a shared resource between the partner and customer
        /// accounts, and each partner event source unique in the partner account.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The combination of <i>event_namespace</i> and <i>event_name</i> should help Amazon
        /// Web Services customers decide whether to create an event bus to receive these events.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePartnerEventSource service method.</param>
        /// 
        /// <returns>The response from the CreatePartnerEventSource service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.LimitExceededException">
        /// The request failed because it attempted to create resource beyond the allowed service
        /// quota.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.OperationDisabledException">
        /// The operation you are attempting is not available in this region.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceAlreadyExistsException">
        /// The resource you are trying to create already exists.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/CreatePartnerEventSource">REST API Reference for CreatePartnerEventSource Operation</seealso>
        CreatePartnerEventSourceResponse CreatePartnerEventSource(CreatePartnerEventSourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePartnerEventSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePartnerEventSource operation on AmazonEventBridgeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePartnerEventSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/CreatePartnerEventSource">REST API Reference for CreatePartnerEventSource Operation</seealso>
        IAsyncResult BeginCreatePartnerEventSource(CreatePartnerEventSourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePartnerEventSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePartnerEventSource.</param>
        /// 
        /// <returns>Returns a  CreatePartnerEventSourceResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/CreatePartnerEventSource">REST API Reference for CreatePartnerEventSource Operation</seealso>
        CreatePartnerEventSourceResponse EndCreatePartnerEventSource(IAsyncResult asyncResult);

        #endregion
        
        #region  DeactivateEventSource


        /// <summary>
        /// You can use this operation to temporarily stop receiving events from the specified
        /// partner event source. The matching event bus is not deleted. 
        /// 
        ///  
        /// <para>
        /// When you deactivate a partner event source, the source goes into PENDING state. If
        /// it remains in PENDING state for more than two weeks, it is deleted.
        /// </para>
        ///  
        /// <para>
        /// To activate a deactivated partner event source, use <a href="https://docs.aws.amazon.com/eventbridge/latest/APIReference/API_ActivateEventSource.html">ActivateEventSource</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeactivateEventSource service method.</param>
        /// 
        /// <returns>The response from the DeactivateEventSource service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InvalidStateException">
        /// The specified state is not a valid state for an event source.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.OperationDisabledException">
        /// The operation you are attempting is not available in this region.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DeactivateEventSource">REST API Reference for DeactivateEventSource Operation</seealso>
        DeactivateEventSourceResponse DeactivateEventSource(DeactivateEventSourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeactivateEventSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeactivateEventSource operation on AmazonEventBridgeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeactivateEventSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DeactivateEventSource">REST API Reference for DeactivateEventSource Operation</seealso>
        IAsyncResult BeginDeactivateEventSource(DeactivateEventSourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeactivateEventSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeactivateEventSource.</param>
        /// 
        /// <returns>Returns a  DeactivateEventSourceResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DeactivateEventSource">REST API Reference for DeactivateEventSource Operation</seealso>
        DeactivateEventSourceResponse EndDeactivateEventSource(IAsyncResult asyncResult);

        #endregion
        
        #region  DeauthorizeConnection


        /// <summary>
        /// Removes all authorization parameters from the connection. This lets you remove the
        /// secret from the connection so you can reuse it without having to create a new connection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeauthorizeConnection service method.</param>
        /// 
        /// <returns>The response from the DeauthorizeConnection service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DeauthorizeConnection">REST API Reference for DeauthorizeConnection Operation</seealso>
        DeauthorizeConnectionResponse DeauthorizeConnection(DeauthorizeConnectionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeauthorizeConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeauthorizeConnection operation on AmazonEventBridgeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeauthorizeConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DeauthorizeConnection">REST API Reference for DeauthorizeConnection Operation</seealso>
        IAsyncResult BeginDeauthorizeConnection(DeauthorizeConnectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeauthorizeConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeauthorizeConnection.</param>
        /// 
        /// <returns>Returns a  DeauthorizeConnectionResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DeauthorizeConnection">REST API Reference for DeauthorizeConnection Operation</seealso>
        DeauthorizeConnectionResponse EndDeauthorizeConnection(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteApiDestination


        /// <summary>
        /// Deletes the specified API destination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApiDestination service method.</param>
        /// 
        /// <returns>The response from the DeleteApiDestination service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DeleteApiDestination">REST API Reference for DeleteApiDestination Operation</seealso>
        DeleteApiDestinationResponse DeleteApiDestination(DeleteApiDestinationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApiDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApiDestination operation on AmazonEventBridgeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteApiDestination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DeleteApiDestination">REST API Reference for DeleteApiDestination Operation</seealso>
        IAsyncResult BeginDeleteApiDestination(DeleteApiDestinationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApiDestination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApiDestination.</param>
        /// 
        /// <returns>Returns a  DeleteApiDestinationResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DeleteApiDestination">REST API Reference for DeleteApiDestination Operation</seealso>
        DeleteApiDestinationResponse EndDeleteApiDestination(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteArchive


        /// <summary>
        /// Deletes the specified archive.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteArchive service method.</param>
        /// 
        /// <returns>The response from the DeleteArchive service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DeleteArchive">REST API Reference for DeleteArchive Operation</seealso>
        DeleteArchiveResponse DeleteArchive(DeleteArchiveRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteArchive operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteArchive operation on AmazonEventBridgeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteArchive
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DeleteArchive">REST API Reference for DeleteArchive Operation</seealso>
        IAsyncResult BeginDeleteArchive(DeleteArchiveRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteArchive operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteArchive.</param>
        /// 
        /// <returns>Returns a  DeleteArchiveResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DeleteArchive">REST API Reference for DeleteArchive Operation</seealso>
        DeleteArchiveResponse EndDeleteArchive(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteConnection


        /// <summary>
        /// Deletes a connection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnection service method.</param>
        /// 
        /// <returns>The response from the DeleteConnection service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DeleteConnection">REST API Reference for DeleteConnection Operation</seealso>
        DeleteConnectionResponse DeleteConnection(DeleteConnectionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnection operation on AmazonEventBridgeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DeleteConnection">REST API Reference for DeleteConnection Operation</seealso>
        IAsyncResult BeginDeleteConnection(DeleteConnectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConnection.</param>
        /// 
        /// <returns>Returns a  DeleteConnectionResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DeleteConnection">REST API Reference for DeleteConnection Operation</seealso>
        DeleteConnectionResponse EndDeleteConnection(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteEndpoint


        /// <summary>
        /// Delete an existing global endpoint. For more information about global endpoints, see
        /// <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-global-endpoints.html">Making
        /// applications Regional-fault tolerant with global endpoints and event replication</a>
        /// in the <i> <i>Amazon EventBridge User Guide</i> </i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEndpoint service method.</param>
        /// 
        /// <returns>The response from the DeleteEndpoint service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DeleteEndpoint">REST API Reference for DeleteEndpoint Operation</seealso>
        DeleteEndpointResponse DeleteEndpoint(DeleteEndpointRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEndpoint operation on AmazonEventBridgeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DeleteEndpoint">REST API Reference for DeleteEndpoint Operation</seealso>
        IAsyncResult BeginDeleteEndpoint(DeleteEndpointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEndpoint.</param>
        /// 
        /// <returns>Returns a  DeleteEndpointResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DeleteEndpoint">REST API Reference for DeleteEndpoint Operation</seealso>
        DeleteEndpointResponse EndDeleteEndpoint(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteEventBus


        /// <summary>
        /// Deletes the specified custom event bus or partner event bus. All rules associated
        /// with this event bus need to be deleted. You can't delete your account's default event
        /// bus.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventBus service method.</param>
        /// 
        /// <returns>The response from the DeleteEventBus service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DeleteEventBus">REST API Reference for DeleteEventBus Operation</seealso>
        DeleteEventBusResponse DeleteEventBus(DeleteEventBusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEventBus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventBus operation on AmazonEventBridgeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEventBus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DeleteEventBus">REST API Reference for DeleteEventBus Operation</seealso>
        IAsyncResult BeginDeleteEventBus(DeleteEventBusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEventBus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEventBus.</param>
        /// 
        /// <returns>Returns a  DeleteEventBusResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DeleteEventBus">REST API Reference for DeleteEventBus Operation</seealso>
        DeleteEventBusResponse EndDeleteEventBus(IAsyncResult asyncResult);

        #endregion
        
        #region  DeletePartnerEventSource


        /// <summary>
        /// This operation is used by SaaS partners to delete a partner event source. This operation
        /// is not used by Amazon Web Services customers.
        /// 
        ///  
        /// <para>
        /// When you delete an event source, the status of the corresponding partner event bus
        /// in the Amazon Web Services customer account becomes DELETED.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePartnerEventSource service method.</param>
        /// 
        /// <returns>The response from the DeletePartnerEventSource service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.OperationDisabledException">
        /// The operation you are attempting is not available in this region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DeletePartnerEventSource">REST API Reference for DeletePartnerEventSource Operation</seealso>
        DeletePartnerEventSourceResponse DeletePartnerEventSource(DeletePartnerEventSourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePartnerEventSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePartnerEventSource operation on AmazonEventBridgeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePartnerEventSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DeletePartnerEventSource">REST API Reference for DeletePartnerEventSource Operation</seealso>
        IAsyncResult BeginDeletePartnerEventSource(DeletePartnerEventSourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePartnerEventSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePartnerEventSource.</param>
        /// 
        /// <returns>Returns a  DeletePartnerEventSourceResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DeletePartnerEventSource">REST API Reference for DeletePartnerEventSource Operation</seealso>
        DeletePartnerEventSourceResponse EndDeletePartnerEventSource(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteRule


        /// <summary>
        /// Deletes the specified rule.
        /// 
        ///  
        /// <para>
        /// Before you can delete the rule, you must remove all targets, using <a href="https://docs.aws.amazon.com/eventbridge/latest/APIReference/API_RemoveTargets.html">RemoveTargets</a>.
        /// </para>
        ///  
        /// <para>
        /// When you delete a rule, incoming events might continue to match to the deleted rule.
        /// Allow a short period of time for changes to take effect.
        /// </para>
        ///  
        /// <para>
        /// If you call delete rule multiple times for the same rule, all calls will succeed.
        /// When you call delete rule for a non-existent custom eventbus, <c>ResourceNotFoundException</c>
        /// is returned.
        /// </para>
        ///  
        /// <para>
        /// Managed rules are rules created and managed by another Amazon Web Services service
        /// on your behalf. These rules are created by those other Amazon Web Services services
        /// to support functionality in those services. You can delete these rules using the <c>Force</c>
        /// option, but you should do so only if you are sure the other service is not still using
        /// that rule.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRule service method.</param>
        /// 
        /// <returns>The response from the DeleteRule service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ManagedRuleException">
        /// This rule was created by an Amazon Web Services service on behalf of your account.
        /// It is managed by that service. If you see this error in response to <c>DeleteRule</c>
        /// or <c>RemoveTargets</c>, you can use the <c>Force</c> parameter in those calls to
        /// delete the rule or remove targets from the rule. You cannot modify these managed rules
        /// by using <c>DisableRule</c>, <c>EnableRule</c>, <c>PutTargets</c>, <c>PutRule</c>,
        /// <c>TagResource</c>, or <c>UntagResource</c>.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DeleteRule">REST API Reference for DeleteRule Operation</seealso>
        DeleteRuleResponse DeleteRule(DeleteRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRule operation on AmazonEventBridgeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DeleteRule">REST API Reference for DeleteRule Operation</seealso>
        IAsyncResult BeginDeleteRule(DeleteRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRule.</param>
        /// 
        /// <returns>Returns a  DeleteRuleResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DeleteRule">REST API Reference for DeleteRule Operation</seealso>
        DeleteRuleResponse EndDeleteRule(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeApiDestination


        /// <summary>
        /// Retrieves details about an API destination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeApiDestination service method.</param>
        /// 
        /// <returns>The response from the DescribeApiDestination service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DescribeApiDestination">REST API Reference for DescribeApiDestination Operation</seealso>
        DescribeApiDestinationResponse DescribeApiDestination(DescribeApiDestinationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeApiDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeApiDestination operation on AmazonEventBridgeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeApiDestination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DescribeApiDestination">REST API Reference for DescribeApiDestination Operation</seealso>
        IAsyncResult BeginDescribeApiDestination(DescribeApiDestinationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeApiDestination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeApiDestination.</param>
        /// 
        /// <returns>Returns a  DescribeApiDestinationResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DescribeApiDestination">REST API Reference for DescribeApiDestination Operation</seealso>
        DescribeApiDestinationResponse EndDescribeApiDestination(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeArchive


        /// <summary>
        /// Retrieves details about an archive.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeArchive service method.</param>
        /// 
        /// <returns>The response from the DescribeArchive service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceAlreadyExistsException">
        /// The resource you are trying to create already exists.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DescribeArchive">REST API Reference for DescribeArchive Operation</seealso>
        DescribeArchiveResponse DescribeArchive(DescribeArchiveRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeArchive operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeArchive operation on AmazonEventBridgeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeArchive
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DescribeArchive">REST API Reference for DescribeArchive Operation</seealso>
        IAsyncResult BeginDescribeArchive(DescribeArchiveRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeArchive operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeArchive.</param>
        /// 
        /// <returns>Returns a  DescribeArchiveResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DescribeArchive">REST API Reference for DescribeArchive Operation</seealso>
        DescribeArchiveResponse EndDescribeArchive(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeConnection


        /// <summary>
        /// Retrieves details about a connection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnection service method.</param>
        /// 
        /// <returns>The response from the DescribeConnection service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DescribeConnection">REST API Reference for DescribeConnection Operation</seealso>
        DescribeConnectionResponse DescribeConnection(DescribeConnectionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnection operation on AmazonEventBridgeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DescribeConnection">REST API Reference for DescribeConnection Operation</seealso>
        IAsyncResult BeginDescribeConnection(DescribeConnectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeConnection.</param>
        /// 
        /// <returns>Returns a  DescribeConnectionResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DescribeConnection">REST API Reference for DescribeConnection Operation</seealso>
        DescribeConnectionResponse EndDescribeConnection(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeEndpoint


        /// <summary>
        /// Get the information about an existing global endpoint. For more information about
        /// global endpoints, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-global-endpoints.html">Making
        /// applications Regional-fault tolerant with global endpoints and event replication</a>
        /// in the <i> <i>Amazon EventBridge User Guide</i> </i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpoint service method.</param>
        /// 
        /// <returns>The response from the DescribeEndpoint service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DescribeEndpoint">REST API Reference for DescribeEndpoint Operation</seealso>
        DescribeEndpointResponse DescribeEndpoint(DescribeEndpointRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpoint operation on AmazonEventBridgeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DescribeEndpoint">REST API Reference for DescribeEndpoint Operation</seealso>
        IAsyncResult BeginDescribeEndpoint(DescribeEndpointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEndpoint.</param>
        /// 
        /// <returns>Returns a  DescribeEndpointResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DescribeEndpoint">REST API Reference for DescribeEndpoint Operation</seealso>
        DescribeEndpointResponse EndDescribeEndpoint(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeEventBus


        /// <summary>
        /// Displays details about an event bus in your account. This can include the external
        /// Amazon Web Services accounts that are permitted to write events to your default event
        /// bus, and the associated policy. For custom event buses and partner event buses, it
        /// displays the name, ARN, policy, state, and creation time.
        /// 
        ///  
        /// <para>
        ///  To enable your account to receive events from other accounts on its default event
        /// bus, use <a href="https://docs.aws.amazon.com/eventbridge/latest/APIReference/API_PutPermission.html">PutPermission</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information about partner event buses, see <a href="https://docs.aws.amazon.com/eventbridge/latest/APIReference/API_CreateEventBus.html">CreateEventBus</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventBus service method.</param>
        /// 
        /// <returns>The response from the DescribeEventBus service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DescribeEventBus">REST API Reference for DescribeEventBus Operation</seealso>
        DescribeEventBusResponse DescribeEventBus(DescribeEventBusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEventBus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventBus operation on AmazonEventBridgeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEventBus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DescribeEventBus">REST API Reference for DescribeEventBus Operation</seealso>
        IAsyncResult BeginDescribeEventBus(DescribeEventBusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEventBus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEventBus.</param>
        /// 
        /// <returns>Returns a  DescribeEventBusResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DescribeEventBus">REST API Reference for DescribeEventBus Operation</seealso>
        DescribeEventBusResponse EndDescribeEventBus(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeEventSource


        /// <summary>
        /// This operation lists details about a partner event source that is shared with your
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventSource service method.</param>
        /// 
        /// <returns>The response from the DescribeEventSource service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.OperationDisabledException">
        /// The operation you are attempting is not available in this region.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DescribeEventSource">REST API Reference for DescribeEventSource Operation</seealso>
        DescribeEventSourceResponse DescribeEventSource(DescribeEventSourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEventSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventSource operation on AmazonEventBridgeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEventSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DescribeEventSource">REST API Reference for DescribeEventSource Operation</seealso>
        IAsyncResult BeginDescribeEventSource(DescribeEventSourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEventSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEventSource.</param>
        /// 
        /// <returns>Returns a  DescribeEventSourceResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DescribeEventSource">REST API Reference for DescribeEventSource Operation</seealso>
        DescribeEventSourceResponse EndDescribeEventSource(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribePartnerEventSource


        /// <summary>
        /// An SaaS partner can use this operation to list details about a partner event source
        /// that they have created. Amazon Web Services customers do not use this operation. Instead,
        /// Amazon Web Services customers can use <a href="https://docs.aws.amazon.com/eventbridge/latest/APIReference/API_DescribeEventSource.html">DescribeEventSource</a>
        /// to see details about a partner event source that is shared with them.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePartnerEventSource service method.</param>
        /// 
        /// <returns>The response from the DescribePartnerEventSource service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.OperationDisabledException">
        /// The operation you are attempting is not available in this region.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DescribePartnerEventSource">REST API Reference for DescribePartnerEventSource Operation</seealso>
        DescribePartnerEventSourceResponse DescribePartnerEventSource(DescribePartnerEventSourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePartnerEventSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePartnerEventSource operation on AmazonEventBridgeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePartnerEventSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DescribePartnerEventSource">REST API Reference for DescribePartnerEventSource Operation</seealso>
        IAsyncResult BeginDescribePartnerEventSource(DescribePartnerEventSourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePartnerEventSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePartnerEventSource.</param>
        /// 
        /// <returns>Returns a  DescribePartnerEventSourceResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DescribePartnerEventSource">REST API Reference for DescribePartnerEventSource Operation</seealso>
        DescribePartnerEventSourceResponse EndDescribePartnerEventSource(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeReplay


        /// <summary>
        /// Retrieves details about a replay. Use <c>DescribeReplay</c> to determine the progress
        /// of a running replay. A replay processes events to replay based on the time in the
        /// event, and replays them using 1 minute intervals. If you use <c>StartReplay</c> and
        /// specify an <c>EventStartTime</c> and an <c>EventEndTime</c> that covers a 20 minute
        /// time range, the events are replayed from the first minute of that 20 minute range
        /// first. Then the events from the second minute are replayed. You can use <c>DescribeReplay</c>
        /// to determine the progress of a replay. The value returned for <c>EventLastReplayedTime</c>
        /// indicates the time within the specified time range associated with the last event
        /// replayed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplay service method.</param>
        /// 
        /// <returns>The response from the DescribeReplay service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DescribeReplay">REST API Reference for DescribeReplay Operation</seealso>
        DescribeReplayResponse DescribeReplay(DescribeReplayRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReplay operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplay operation on AmazonEventBridgeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeReplay
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DescribeReplay">REST API Reference for DescribeReplay Operation</seealso>
        IAsyncResult BeginDescribeReplay(DescribeReplayRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeReplay operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReplay.</param>
        /// 
        /// <returns>Returns a  DescribeReplayResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DescribeReplay">REST API Reference for DescribeReplay Operation</seealso>
        DescribeReplayResponse EndDescribeReplay(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeRule


        /// <summary>
        /// Describes the specified rule.
        /// 
        ///  
        /// <para>
        /// DescribeRule does not list the targets of a rule. To see the targets associated with
        /// a rule, use <a href="https://docs.aws.amazon.com/eventbridge/latest/APIReference/API_ListTargetsByRule.html">ListTargetsByRule</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRule service method.</param>
        /// 
        /// <returns>The response from the DescribeRule service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DescribeRule">REST API Reference for DescribeRule Operation</seealso>
        DescribeRuleResponse DescribeRule(DescribeRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRule operation on AmazonEventBridgeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DescribeRule">REST API Reference for DescribeRule Operation</seealso>
        IAsyncResult BeginDescribeRule(DescribeRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRule.</param>
        /// 
        /// <returns>Returns a  DescribeRuleResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DescribeRule">REST API Reference for DescribeRule Operation</seealso>
        DescribeRuleResponse EndDescribeRule(IAsyncResult asyncResult);

        #endregion
        
        #region  DisableRule


        /// <summary>
        /// Disables the specified rule. A disabled rule won't match any events, and won't self-trigger
        /// if it has a schedule expression.
        /// 
        ///  
        /// <para>
        /// When you disable a rule, incoming events might continue to match to the disabled rule.
        /// Allow a short period of time for changes to take effect.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableRule service method.</param>
        /// 
        /// <returns>The response from the DisableRule service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ManagedRuleException">
        /// This rule was created by an Amazon Web Services service on behalf of your account.
        /// It is managed by that service. If you see this error in response to <c>DeleteRule</c>
        /// or <c>RemoveTargets</c>, you can use the <c>Force</c> parameter in those calls to
        /// delete the rule or remove targets from the rule. You cannot modify these managed rules
        /// by using <c>DisableRule</c>, <c>EnableRule</c>, <c>PutTargets</c>, <c>PutRule</c>,
        /// <c>TagResource</c>, or <c>UntagResource</c>.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DisableRule">REST API Reference for DisableRule Operation</seealso>
        DisableRuleResponse DisableRule(DisableRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisableRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableRule operation on AmazonEventBridgeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisableRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DisableRule">REST API Reference for DisableRule Operation</seealso>
        IAsyncResult BeginDisableRule(DisableRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisableRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableRule.</param>
        /// 
        /// <returns>Returns a  DisableRuleResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DisableRule">REST API Reference for DisableRule Operation</seealso>
        DisableRuleResponse EndDisableRule(IAsyncResult asyncResult);

        #endregion
        
        #region  EnableRule


        /// <summary>
        /// Enables the specified rule. If the rule does not exist, the operation fails.
        /// 
        ///  
        /// <para>
        /// When you enable a rule, incoming events might not immediately start matching to a
        /// newly enabled rule. Allow a short period of time for changes to take effect.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableRule service method.</param>
        /// 
        /// <returns>The response from the EnableRule service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ManagedRuleException">
        /// This rule was created by an Amazon Web Services service on behalf of your account.
        /// It is managed by that service. If you see this error in response to <c>DeleteRule</c>
        /// or <c>RemoveTargets</c>, you can use the <c>Force</c> parameter in those calls to
        /// delete the rule or remove targets from the rule. You cannot modify these managed rules
        /// by using <c>DisableRule</c>, <c>EnableRule</c>, <c>PutTargets</c>, <c>PutRule</c>,
        /// <c>TagResource</c>, or <c>UntagResource</c>.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/EnableRule">REST API Reference for EnableRule Operation</seealso>
        EnableRuleResponse EnableRule(EnableRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the EnableRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableRule operation on AmazonEventBridgeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEnableRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/EnableRule">REST API Reference for EnableRule Operation</seealso>
        IAsyncResult BeginEnableRule(EnableRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  EnableRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableRule.</param>
        /// 
        /// <returns>Returns a  EnableRuleResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/EnableRule">REST API Reference for EnableRule Operation</seealso>
        EnableRuleResponse EndEnableRule(IAsyncResult asyncResult);

        #endregion
        
        #region  ListApiDestinations


        /// <summary>
        /// Retrieves a list of API destination in the account in the current Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApiDestinations service method.</param>
        /// 
        /// <returns>The response from the ListApiDestinations service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/ListApiDestinations">REST API Reference for ListApiDestinations Operation</seealso>
        ListApiDestinationsResponse ListApiDestinations(ListApiDestinationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListApiDestinations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListApiDestinations operation on AmazonEventBridgeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListApiDestinations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/ListApiDestinations">REST API Reference for ListApiDestinations Operation</seealso>
        IAsyncResult BeginListApiDestinations(ListApiDestinationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListApiDestinations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListApiDestinations.</param>
        /// 
        /// <returns>Returns a  ListApiDestinationsResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/ListApiDestinations">REST API Reference for ListApiDestinations Operation</seealso>
        ListApiDestinationsResponse EndListApiDestinations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListArchives


        /// <summary>
        /// Lists your archives. You can either list all the archives or you can provide a prefix
        /// to match to the archive names. Filter parameters are exclusive.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListArchives service method.</param>
        /// 
        /// <returns>The response from the ListArchives service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/ListArchives">REST API Reference for ListArchives Operation</seealso>
        ListArchivesResponse ListArchives(ListArchivesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListArchives operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListArchives operation on AmazonEventBridgeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListArchives
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/ListArchives">REST API Reference for ListArchives Operation</seealso>
        IAsyncResult BeginListArchives(ListArchivesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListArchives operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListArchives.</param>
        /// 
        /// <returns>Returns a  ListArchivesResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/ListArchives">REST API Reference for ListArchives Operation</seealso>
        ListArchivesResponse EndListArchives(IAsyncResult asyncResult);

        #endregion
        
        #region  ListConnections


        /// <summary>
        /// Retrieves a list of connections from the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConnections service method.</param>
        /// 
        /// <returns>The response from the ListConnections service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/ListConnections">REST API Reference for ListConnections Operation</seealso>
        ListConnectionsResponse ListConnections(ListConnectionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListConnections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListConnections operation on AmazonEventBridgeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListConnections
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/ListConnections">REST API Reference for ListConnections Operation</seealso>
        IAsyncResult BeginListConnections(ListConnectionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListConnections operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListConnections.</param>
        /// 
        /// <returns>Returns a  ListConnectionsResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/ListConnections">REST API Reference for ListConnections Operation</seealso>
        ListConnectionsResponse EndListConnections(IAsyncResult asyncResult);

        #endregion
        
        #region  ListEndpoints


        /// <summary>
        /// List the global endpoints associated with this account. For more information about
        /// global endpoints, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-global-endpoints.html">Making
        /// applications Regional-fault tolerant with global endpoints and event replication</a>
        /// in the <i> <i>Amazon EventBridge User Guide</i> </i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEndpoints service method.</param>
        /// 
        /// <returns>The response from the ListEndpoints service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/ListEndpoints">REST API Reference for ListEndpoints Operation</seealso>
        ListEndpointsResponse ListEndpoints(ListEndpointsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListEndpoints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEndpoints operation on AmazonEventBridgeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEndpoints
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/ListEndpoints">REST API Reference for ListEndpoints Operation</seealso>
        IAsyncResult BeginListEndpoints(ListEndpointsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListEndpoints operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEndpoints.</param>
        /// 
        /// <returns>Returns a  ListEndpointsResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/ListEndpoints">REST API Reference for ListEndpoints Operation</seealso>
        ListEndpointsResponse EndListEndpoints(IAsyncResult asyncResult);

        #endregion
        
        #region  ListEventBuses


        /// <summary>
        /// Lists all the event buses in your account, including the default event bus, custom
        /// event buses, and partner event buses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEventBuses service method.</param>
        /// 
        /// <returns>The response from the ListEventBuses service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/ListEventBuses">REST API Reference for ListEventBuses Operation</seealso>
        ListEventBusesResponse ListEventBuses(ListEventBusesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListEventBuses operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEventBuses operation on AmazonEventBridgeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEventBuses
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/ListEventBuses">REST API Reference for ListEventBuses Operation</seealso>
        IAsyncResult BeginListEventBuses(ListEventBusesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListEventBuses operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEventBuses.</param>
        /// 
        /// <returns>Returns a  ListEventBusesResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/ListEventBuses">REST API Reference for ListEventBuses Operation</seealso>
        ListEventBusesResponse EndListEventBuses(IAsyncResult asyncResult);

        #endregion
        
        #region  ListEventSources


        /// <summary>
        /// You can use this to see all the partner event sources that have been shared with your
        /// Amazon Web Services account. For more information about partner event sources, see
        /// <a href="https://docs.aws.amazon.com/eventbridge/latest/APIReference/API_CreateEventBus.html">CreateEventBus</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEventSources service method.</param>
        /// 
        /// <returns>The response from the ListEventSources service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.OperationDisabledException">
        /// The operation you are attempting is not available in this region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/ListEventSources">REST API Reference for ListEventSources Operation</seealso>
        ListEventSourcesResponse ListEventSources(ListEventSourcesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListEventSources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEventSources operation on AmazonEventBridgeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEventSources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/ListEventSources">REST API Reference for ListEventSources Operation</seealso>
        IAsyncResult BeginListEventSources(ListEventSourcesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListEventSources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEventSources.</param>
        /// 
        /// <returns>Returns a  ListEventSourcesResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/ListEventSources">REST API Reference for ListEventSources Operation</seealso>
        ListEventSourcesResponse EndListEventSources(IAsyncResult asyncResult);

        #endregion
        
        #region  ListPartnerEventSourceAccounts


        /// <summary>
        /// An SaaS partner can use this operation to display the Amazon Web Services account
        /// ID that a particular partner event source name is associated with. This operation
        /// is not used by Amazon Web Services customers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPartnerEventSourceAccounts service method.</param>
        /// 
        /// <returns>The response from the ListPartnerEventSourceAccounts service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.OperationDisabledException">
        /// The operation you are attempting is not available in this region.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/ListPartnerEventSourceAccounts">REST API Reference for ListPartnerEventSourceAccounts Operation</seealso>
        ListPartnerEventSourceAccountsResponse ListPartnerEventSourceAccounts(ListPartnerEventSourceAccountsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPartnerEventSourceAccounts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPartnerEventSourceAccounts operation on AmazonEventBridgeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPartnerEventSourceAccounts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/ListPartnerEventSourceAccounts">REST API Reference for ListPartnerEventSourceAccounts Operation</seealso>
        IAsyncResult BeginListPartnerEventSourceAccounts(ListPartnerEventSourceAccountsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPartnerEventSourceAccounts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPartnerEventSourceAccounts.</param>
        /// 
        /// <returns>Returns a  ListPartnerEventSourceAccountsResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/ListPartnerEventSourceAccounts">REST API Reference for ListPartnerEventSourceAccounts Operation</seealso>
        ListPartnerEventSourceAccountsResponse EndListPartnerEventSourceAccounts(IAsyncResult asyncResult);

        #endregion
        
        #region  ListPartnerEventSources


        /// <summary>
        /// An SaaS partner can use this operation to list all the partner event source names
        /// that they have created. This operation is not used by Amazon Web Services customers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPartnerEventSources service method.</param>
        /// 
        /// <returns>The response from the ListPartnerEventSources service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.OperationDisabledException">
        /// The operation you are attempting is not available in this region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/ListPartnerEventSources">REST API Reference for ListPartnerEventSources Operation</seealso>
        ListPartnerEventSourcesResponse ListPartnerEventSources(ListPartnerEventSourcesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPartnerEventSources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPartnerEventSources operation on AmazonEventBridgeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPartnerEventSources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/ListPartnerEventSources">REST API Reference for ListPartnerEventSources Operation</seealso>
        IAsyncResult BeginListPartnerEventSources(ListPartnerEventSourcesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPartnerEventSources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPartnerEventSources.</param>
        /// 
        /// <returns>Returns a  ListPartnerEventSourcesResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/ListPartnerEventSources">REST API Reference for ListPartnerEventSources Operation</seealso>
        ListPartnerEventSourcesResponse EndListPartnerEventSources(IAsyncResult asyncResult);

        #endregion
        
        #region  ListReplays


        /// <summary>
        /// Lists your replays. You can either list all the replays or you can provide a prefix
        /// to match to the replay names. Filter parameters are exclusive.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReplays service method.</param>
        /// 
        /// <returns>The response from the ListReplays service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/ListReplays">REST API Reference for ListReplays Operation</seealso>
        ListReplaysResponse ListReplays(ListReplaysRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListReplays operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListReplays operation on AmazonEventBridgeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListReplays
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/ListReplays">REST API Reference for ListReplays Operation</seealso>
        IAsyncResult BeginListReplays(ListReplaysRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListReplays operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListReplays.</param>
        /// 
        /// <returns>Returns a  ListReplaysResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/ListReplays">REST API Reference for ListReplays Operation</seealso>
        ListReplaysResponse EndListReplays(IAsyncResult asyncResult);

        #endregion
        
        #region  ListRuleNamesByTarget


        /// <summary>
        /// Lists the rules for the specified target. You can see which of the rules in Amazon
        /// EventBridge can invoke a specific target in your account.
        /// 
        ///  
        /// <para>
        /// The maximum number of results per page for requests is 100.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRuleNamesByTarget service method.</param>
        /// 
        /// <returns>The response from the ListRuleNamesByTarget service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/ListRuleNamesByTarget">REST API Reference for ListRuleNamesByTarget Operation</seealso>
        ListRuleNamesByTargetResponse ListRuleNamesByTarget(ListRuleNamesByTargetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListRuleNamesByTarget operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRuleNamesByTarget operation on AmazonEventBridgeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRuleNamesByTarget
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/ListRuleNamesByTarget">REST API Reference for ListRuleNamesByTarget Operation</seealso>
        IAsyncResult BeginListRuleNamesByTarget(ListRuleNamesByTargetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListRuleNamesByTarget operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRuleNamesByTarget.</param>
        /// 
        /// <returns>Returns a  ListRuleNamesByTargetResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/ListRuleNamesByTarget">REST API Reference for ListRuleNamesByTarget Operation</seealso>
        ListRuleNamesByTargetResponse EndListRuleNamesByTarget(IAsyncResult asyncResult);

        #endregion
        
        #region  ListRules


        /// <summary>
        /// Lists your Amazon EventBridge rules. You can either list all the rules or you can
        /// provide a prefix to match to the rule names.
        /// 
        ///  
        /// <para>
        /// The maximum number of results per page for requests is 100.
        /// </para>
        ///  
        /// <para>
        /// ListRules does not list the targets of a rule. To see the targets associated with
        /// a rule, use <a href="https://docs.aws.amazon.com/eventbridge/latest/APIReference/API_ListTargetsByRule.html">ListTargetsByRule</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRules service method.</param>
        /// 
        /// <returns>The response from the ListRules service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/ListRules">REST API Reference for ListRules Operation</seealso>
        ListRulesResponse ListRules(ListRulesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListRules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRules operation on AmazonEventBridgeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRules
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/ListRules">REST API Reference for ListRules Operation</seealso>
        IAsyncResult BeginListRules(ListRulesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListRules operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRules.</param>
        /// 
        /// <returns>Returns a  ListRulesResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/ListRules">REST API Reference for ListRules Operation</seealso>
        ListRulesResponse EndListRules(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Displays the tags associated with an EventBridge resource. In EventBridge, rules and
        /// event buses can be tagged.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonEventBridgeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTargetsByRule


        /// <summary>
        /// Lists the targets assigned to the specified rule.
        /// 
        ///  
        /// <para>
        /// The maximum number of results per page for requests is 100.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTargetsByRule service method.</param>
        /// 
        /// <returns>The response from the ListTargetsByRule service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/ListTargetsByRule">REST API Reference for ListTargetsByRule Operation</seealso>
        ListTargetsByRuleResponse ListTargetsByRule(ListTargetsByRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTargetsByRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTargetsByRule operation on AmazonEventBridgeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTargetsByRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/ListTargetsByRule">REST API Reference for ListTargetsByRule Operation</seealso>
        IAsyncResult BeginListTargetsByRule(ListTargetsByRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTargetsByRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTargetsByRule.</param>
        /// 
        /// <returns>Returns a  ListTargetsByRuleResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/ListTargetsByRule">REST API Reference for ListTargetsByRule Operation</seealso>
        ListTargetsByRuleResponse EndListTargetsByRule(IAsyncResult asyncResult);

        #endregion
        
        #region  PutEvents


        /// <summary>
        /// Sends custom events to Amazon EventBridge so that they can be matched to rules.
        /// 
        ///  
        /// <para>
        /// You can batch multiple event entries into one request for efficiency. However, the
        /// total entry size must be less than 256KB. You can calculate the entry size before
        /// you send the events. For more information, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-putevents.html#eb-putevent-size">Calculating
        /// PutEvents event entry size</a> in the <i> <i>Amazon EventBridge User Guide</i> </i>.
        /// </para>
        ///  
        /// <para>
        /// PutEvents accepts the data in JSON format. For the JSON number (integer) data type,
        /// the constraints are: a minimum value of -9,223,372,036,854,775,808 and a maximum value
        /// of 9,223,372,036,854,775,807.
        /// </para>
        ///  <note> 
        /// <para>
        /// PutEvents will only process nested JSON up to 1000 levels deep.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEvents service method.</param>
        /// 
        /// <returns>The response from the PutEvents service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/PutEvents">REST API Reference for PutEvents Operation</seealso>
        PutEventsResponse PutEvents(PutEventsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutEvents operation on AmazonEventBridgeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutEvents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/PutEvents">REST API Reference for PutEvents Operation</seealso>
        IAsyncResult BeginPutEvents(PutEventsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutEvents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutEvents.</param>
        /// 
        /// <returns>Returns a  PutEventsResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/PutEvents">REST API Reference for PutEvents Operation</seealso>
        PutEventsResponse EndPutEvents(IAsyncResult asyncResult);

        #endregion
        
        #region  PutPartnerEvents


        /// <summary>
        /// This is used by SaaS partners to write events to a customer's partner event bus. Amazon
        /// Web Services customers do not use this operation.
        /// 
        ///  
        /// <para>
        /// For information on calculating event batch size, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-putevent-size.html">Calculating
        /// EventBridge PutEvents event entry size</a> in the <i>EventBridge User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutPartnerEvents service method.</param>
        /// 
        /// <returns>The response from the PutPartnerEvents service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.OperationDisabledException">
        /// The operation you are attempting is not available in this region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/PutPartnerEvents">REST API Reference for PutPartnerEvents Operation</seealso>
        PutPartnerEventsResponse PutPartnerEvents(PutPartnerEventsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutPartnerEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutPartnerEvents operation on AmazonEventBridgeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutPartnerEvents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/PutPartnerEvents">REST API Reference for PutPartnerEvents Operation</seealso>
        IAsyncResult BeginPutPartnerEvents(PutPartnerEventsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutPartnerEvents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutPartnerEvents.</param>
        /// 
        /// <returns>Returns a  PutPartnerEventsResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/PutPartnerEvents">REST API Reference for PutPartnerEvents Operation</seealso>
        PutPartnerEventsResponse EndPutPartnerEvents(IAsyncResult asyncResult);

        #endregion
        
        #region  PutPermission


        /// <summary>
        /// Running <c>PutPermission</c> permits the specified Amazon Web Services account or
        /// Amazon Web Services organization to put events to the specified <i>event bus</i>.
        /// Amazon EventBridge rules in your account are triggered by these events arriving to
        /// an event bus in your account. 
        /// 
        ///  
        /// <para>
        /// For another account to send events to your account, that external account must have
        /// an EventBridge rule with your account's event bus as a target.
        /// </para>
        ///  
        /// <para>
        /// To enable multiple Amazon Web Services accounts to put events to your event bus, run
        /// <c>PutPermission</c> once for each of these accounts. Or, if all the accounts are
        /// members of the same Amazon Web Services organization, you can run <c>PutPermission</c>
        /// once specifying <c>Principal</c> as "*" and specifying the Amazon Web Services organization
        /// ID in <c>Condition</c>, to grant permissions to all accounts in that organization.
        /// </para>
        ///  
        /// <para>
        /// If you grant permissions using an organization, then accounts in that organization
        /// must specify a <c>RoleArn</c> with proper permissions when they use <c>PutTarget</c>
        /// to add your account's event bus as a target. For more information, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eventbridge-cross-account-event-delivery.html">Sending
        /// and Receiving Events Between Amazon Web Services Accounts</a> in the <i>Amazon EventBridge
        /// User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The permission policy on the event bus cannot exceed 10 KB in size.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutPermission service method.</param>
        /// 
        /// <returns>The response from the PutPermission service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.OperationDisabledException">
        /// The operation you are attempting is not available in this region.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.PolicyLengthExceededException">
        /// The event bus policy is too long. For more information, see the limits.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/PutPermission">REST API Reference for PutPermission Operation</seealso>
        PutPermissionResponse PutPermission(PutPermissionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutPermission operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutPermission operation on AmazonEventBridgeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutPermission
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/PutPermission">REST API Reference for PutPermission Operation</seealso>
        IAsyncResult BeginPutPermission(PutPermissionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutPermission operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutPermission.</param>
        /// 
        /// <returns>Returns a  PutPermissionResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/PutPermission">REST API Reference for PutPermission Operation</seealso>
        PutPermissionResponse EndPutPermission(IAsyncResult asyncResult);

        #endregion
        
        #region  PutRule


        /// <summary>
        /// Creates or updates the specified rule. Rules are enabled by default, or based on value
        /// of the state. You can disable a rule using <a href="https://docs.aws.amazon.com/eventbridge/latest/APIReference/API_DisableRule.html">DisableRule</a>.
        /// 
        ///  
        /// <para>
        /// A single rule watches for events from a single event bus. Events generated by Amazon
        /// Web Services services go to your account's default event bus. Events generated by
        /// SaaS partner services or applications go to the matching partner event bus. If you
        /// have custom applications or services, you can specify whether their events go to your
        /// default event bus or a custom event bus that you have created. For more information,
        /// see <a href="https://docs.aws.amazon.com/eventbridge/latest/APIReference/API_CreateEventBus.html">CreateEventBus</a>.
        /// </para>
        ///  
        /// <para>
        /// If you are updating an existing rule, the rule is replaced with what you specify in
        /// this <c>PutRule</c> command. If you omit arguments in <c>PutRule</c>, the old values
        /// for those arguments are not kept. Instead, they are replaced with null values.
        /// </para>
        ///  
        /// <para>
        /// When you create or update a rule, incoming events might not immediately start matching
        /// to new or updated rules. Allow a short period of time for changes to take effect.
        /// </para>
        ///  
        /// <para>
        /// A rule must contain at least an EventPattern or ScheduleExpression. Rules with EventPatterns
        /// are triggered when a matching event is observed. Rules with ScheduleExpressions self-trigger
        /// based on the given schedule. A rule can have both an EventPattern and a ScheduleExpression,
        /// in which case the rule triggers on matching events as well as on a schedule.
        /// </para>
        ///  
        /// <para>
        /// When you initially create a rule, you can optionally assign one or more tags to the
        /// rule. Tags can help you organize and categorize your resources. You can also use them
        /// to scope user permissions, by granting a user permission to access or change only
        /// rules with certain tag values. To use the <c>PutRule</c> operation and assign tags,
        /// you must have both the <c>events:PutRule</c> and <c>events:TagResource</c> permissions.
        /// </para>
        ///  
        /// <para>
        /// If you are updating an existing rule, any tags you specify in the <c>PutRule</c> operation
        /// are ignored. To update the tags of an existing rule, use <a href="https://docs.aws.amazon.com/eventbridge/latest/APIReference/API_TagResource.html">TagResource</a>
        /// and <a href="https://docs.aws.amazon.com/eventbridge/latest/APIReference/API_UntagResource.html">UntagResource</a>.
        /// </para>
        ///  
        /// <para>
        /// Most services in Amazon Web Services treat : or / as the same character in Amazon
        /// Resource Names (ARNs). However, EventBridge uses an exact match in event patterns
        /// and rules. Be sure to use the correct ARN characters when creating event patterns
        /// so that they match the ARN syntax in the event you want to match.
        /// </para>
        ///  
        /// <para>
        /// In EventBridge, it is possible to create rules that lead to infinite loops, where
        /// a rule is fired repeatedly. For example, a rule might detect that ACLs have changed
        /// on an S3 bucket, and trigger software to change them to the desired state. If the
        /// rule is not written carefully, the subsequent change to the ACLs fires the rule again,
        /// creating an infinite loop.
        /// </para>
        ///  
        /// <para>
        /// To prevent this, write the rules so that the triggered actions do not re-fire the
        /// same rule. For example, your rule could fire only if ACLs are found to be in a bad
        /// state, instead of after any change. 
        /// </para>
        ///  
        /// <para>
        /// An infinite loop can quickly cause higher than expected charges. We recommend that
        /// you use budgeting, which alerts you when charges exceed your specified limit. For
        /// more information, see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/budgets-managing-costs.html">Managing
        /// Your Costs with Budgets</a>.
        /// </para>
        ///  
        /// <para>
        /// To create a rule that filters for management events from Amazon Web Services services,
        /// see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-service-event-cloudtrail.html#eb-service-event-cloudtrail-management">Receiving
        /// read-only management events from Amazon Web Services services</a> in the <i>EventBridge
        /// User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRule service method.</param>
        /// 
        /// <returns>The response from the PutRule service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InvalidEventPatternException">
        /// The event pattern is not valid.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.LimitExceededException">
        /// The request failed because it attempted to create resource beyond the allowed service
        /// quota.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ManagedRuleException">
        /// This rule was created by an Amazon Web Services service on behalf of your account.
        /// It is managed by that service. If you see this error in response to <c>DeleteRule</c>
        /// or <c>RemoveTargets</c>, you can use the <c>Force</c> parameter in those calls to
        /// delete the rule or remove targets from the rule. You cannot modify these managed rules
        /// by using <c>DisableRule</c>, <c>EnableRule</c>, <c>PutTargets</c>, <c>PutRule</c>,
        /// <c>TagResource</c>, or <c>UntagResource</c>.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/PutRule">REST API Reference for PutRule Operation</seealso>
        PutRuleResponse PutRule(PutRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutRule operation on AmazonEventBridgeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/PutRule">REST API Reference for PutRule Operation</seealso>
        IAsyncResult BeginPutRule(PutRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutRule.</param>
        /// 
        /// <returns>Returns a  PutRuleResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/PutRule">REST API Reference for PutRule Operation</seealso>
        PutRuleResponse EndPutRule(IAsyncResult asyncResult);

        #endregion
        
        #region  PutTargets


        /// <summary>
        /// Adds the specified targets to the specified rule, or updates the targets if they are
        /// already associated with the rule.
        /// 
        ///  
        /// <para>
        /// Targets are the resources that are invoked when a rule is triggered.
        /// </para>
        ///  
        /// <para>
        /// The maximum number of entries per request is 10.
        /// </para>
        ///  <note> 
        /// <para>
        /// Each rule can have up to five (5) targets associated with it at one time.
        /// </para>
        ///  </note> 
        /// <para>
        /// For a list of services you can configure as targets for events, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-targets.html">EventBridge
        /// targets</a> in the <i> <i>Amazon EventBridge User Guide</i> </i>.
        /// </para>
        ///  
        /// <para>
        /// Creating rules with built-in targets is supported only in the Amazon Web Services
        /// Management Console. The built-in targets are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Amazon EBS CreateSnapshot API call</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Amazon EC2 RebootInstances API call</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Amazon EC2 StopInstances API call</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Amazon EC2 TerminateInstances API call</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For some target types, <c>PutTargets</c> provides target-specific parameters. If the
        /// target is a Kinesis data stream, you can optionally specify which shard the event
        /// goes to by using the <c>KinesisParameters</c> argument. To invoke a command on multiple
        /// EC2 instances with one rule, you can use the <c>RunCommandParameters</c> field.
        /// </para>
        ///  
        /// <para>
        /// To be able to make API calls against the resources that you own, Amazon EventBridge
        /// needs the appropriate permissions: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For Lambda and Amazon SNS resources, EventBridge relies on resource-based policies.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For EC2 instances, Kinesis Data Streams, Step Functions state machines and API Gateway
        /// APIs, EventBridge relies on IAM roles that you specify in the <c>RoleARN</c> argument
        /// in <c>PutTargets</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/auth-and-access-control-eventbridge.html">Authentication
        /// and Access Control</a> in the <i> <i>Amazon EventBridge User Guide</i> </i>.
        /// </para>
        ///  
        /// <para>
        /// If another Amazon Web Services account is in the same region and has granted you permission
        /// (using <c>PutPermission</c>), you can send events to that account. Set that account's
        /// event bus as a target of the rules in your account. To send the matched events to
        /// the other account, specify that account's event bus as the <c>Arn</c> value when you
        /// run <c>PutTargets</c>. If your account sends events to another account, your account
        /// is charged for each sent event. Each event sent to another account is charged as a
        /// custom event. The account receiving the event is not charged. For more information,
        /// see <a href="http://aws.amazon.com/eventbridge/pricing/">Amazon EventBridge Pricing</a>.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <c>Input</c>, <c>InputPath</c>, and <c>InputTransformer</c> are not available with
        /// <c>PutTarget</c> if the target is an event bus of a different Amazon Web Services
        /// account.
        /// </para>
        ///  </note> 
        /// <para>
        /// If you are setting the event bus of another account as the target, and that account
        /// granted permission to your account through an organization instead of directly by
        /// the account ID, then you must specify a <c>RoleArn</c> with proper permissions in
        /// the <c>Target</c> structure. For more information, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eventbridge-cross-account-event-delivery.html">Sending
        /// and Receiving Events Between Amazon Web Services Accounts</a> in the <i>Amazon EventBridge
        /// User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you have an IAM role on a cross-account event bus target, a <c>PutTargets</c> call
        /// without a role on the same target (same <c>Id</c> and <c>Arn</c>) will not remove
        /// the role.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information about enabling cross-account events, see <a href="https://docs.aws.amazon.com/eventbridge/latest/APIReference/API_PutPermission.html">PutPermission</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Input</b>, <b>InputPath</b>, and <b>InputTransformer</b> are mutually exclusive
        /// and optional parameters of a target. When a rule is triggered due to a matched event:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If none of the following arguments are specified for a target, then the entire event
        /// is passed to the target in JSON format (unless the target is Amazon EC2 Run Command
        /// or Amazon ECS task, in which case nothing from the event is passed to the target).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If <b>Input</b> is specified in the form of valid JSON, then the matched event is
        /// overridden with this constant.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If <b>InputPath</b> is specified in the form of JSONPath (for example, <c>$.detail</c>),
        /// then only the part of the event specified in the path is passed to the target (for
        /// example, only the detail part of the event is passed).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If <b>InputTransformer</b> is specified, then one or more specified JSONPaths are
        /// extracted from the event and used as values in a template that you specify as the
        /// input to the target.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When you specify <c>InputPath</c> or <c>InputTransformer</c>, you must use JSON dot
        /// notation, not bracket notation.
        /// </para>
        ///  
        /// <para>
        /// When you add targets to a rule and the associated rule triggers soon after, new or
        /// updated targets might not be immediately invoked. Allow a short period of time for
        /// changes to take effect.
        /// </para>
        ///  
        /// <para>
        /// This action can partially fail if too many requests are made at the same time. If
        /// that happens, <c>FailedEntryCount</c> is non-zero in the response and each entry in
        /// <c>FailedEntries</c> provides the ID of the failed target and the error code.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutTargets service method.</param>
        /// 
        /// <returns>The response from the PutTargets service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.LimitExceededException">
        /// The request failed because it attempted to create resource beyond the allowed service
        /// quota.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ManagedRuleException">
        /// This rule was created by an Amazon Web Services service on behalf of your account.
        /// It is managed by that service. If you see this error in response to <c>DeleteRule</c>
        /// or <c>RemoveTargets</c>, you can use the <c>Force</c> parameter in those calls to
        /// delete the rule or remove targets from the rule. You cannot modify these managed rules
        /// by using <c>DisableRule</c>, <c>EnableRule</c>, <c>PutTargets</c>, <c>PutRule</c>,
        /// <c>TagResource</c>, or <c>UntagResource</c>.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/PutTargets">REST API Reference for PutTargets Operation</seealso>
        PutTargetsResponse PutTargets(PutTargetsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutTargets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutTargets operation on AmazonEventBridgeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutTargets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/PutTargets">REST API Reference for PutTargets Operation</seealso>
        IAsyncResult BeginPutTargets(PutTargetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutTargets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutTargets.</param>
        /// 
        /// <returns>Returns a  PutTargetsResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/PutTargets">REST API Reference for PutTargets Operation</seealso>
        PutTargetsResponse EndPutTargets(IAsyncResult asyncResult);

        #endregion
        
        #region  RemovePermission


        /// <summary>
        /// Revokes the permission of another Amazon Web Services account to be able to put events
        /// to the specified event bus. Specify the account to revoke by the <c>StatementId</c>
        /// value that you associated with the account when you granted it permission with <c>PutPermission</c>.
        /// You can find the <c>StatementId</c> by using <a href="https://docs.aws.amazon.com/eventbridge/latest/APIReference/API_DescribeEventBus.html">DescribeEventBus</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemovePermission service method.</param>
        /// 
        /// <returns>The response from the RemovePermission service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.OperationDisabledException">
        /// The operation you are attempting is not available in this region.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/RemovePermission">REST API Reference for RemovePermission Operation</seealso>
        RemovePermissionResponse RemovePermission(RemovePermissionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RemovePermission operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemovePermission operation on AmazonEventBridgeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemovePermission
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/RemovePermission">REST API Reference for RemovePermission Operation</seealso>
        IAsyncResult BeginRemovePermission(RemovePermissionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RemovePermission operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemovePermission.</param>
        /// 
        /// <returns>Returns a  RemovePermissionResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/RemovePermission">REST API Reference for RemovePermission Operation</seealso>
        RemovePermissionResponse EndRemovePermission(IAsyncResult asyncResult);

        #endregion
        
        #region  RemoveTargets


        /// <summary>
        /// Removes the specified targets from the specified rule. When the rule is triggered,
        /// those targets are no longer be invoked.
        /// 
        ///  <note> 
        /// <para>
        /// A successful execution of <c>RemoveTargets</c> doesn't guarantee all targets are removed
        /// from the rule, it means that the target(s) listed in the request are removed.
        /// </para>
        ///  </note> 
        /// <para>
        /// When you remove a target, when the associated rule triggers, removed targets might
        /// continue to be invoked. Allow a short period of time for changes to take effect.
        /// </para>
        ///  
        /// <para>
        /// This action can partially fail if too many requests are made at the same time. If
        /// that happens, <c>FailedEntryCount</c> is non-zero in the response and each entry in
        /// <c>FailedEntries</c> provides the ID of the failed target and the error code.
        /// </para>
        ///  
        /// <para>
        /// The maximum number of entries per request is 10.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTargets service method.</param>
        /// 
        /// <returns>The response from the RemoveTargets service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ManagedRuleException">
        /// This rule was created by an Amazon Web Services service on behalf of your account.
        /// It is managed by that service. If you see this error in response to <c>DeleteRule</c>
        /// or <c>RemoveTargets</c>, you can use the <c>Force</c> parameter in those calls to
        /// delete the rule or remove targets from the rule. You cannot modify these managed rules
        /// by using <c>DisableRule</c>, <c>EnableRule</c>, <c>PutTargets</c>, <c>PutRule</c>,
        /// <c>TagResource</c>, or <c>UntagResource</c>.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/RemoveTargets">REST API Reference for RemoveTargets Operation</seealso>
        RemoveTargetsResponse RemoveTargets(RemoveTargetsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveTargets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveTargets operation on AmazonEventBridgeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveTargets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/RemoveTargets">REST API Reference for RemoveTargets Operation</seealso>
        IAsyncResult BeginRemoveTargets(RemoveTargetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveTargets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveTargets.</param>
        /// 
        /// <returns>Returns a  RemoveTargetsResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/RemoveTargets">REST API Reference for RemoveTargets Operation</seealso>
        RemoveTargetsResponse EndRemoveTargets(IAsyncResult asyncResult);

        #endregion
        
        #region  StartReplay


        /// <summary>
        /// Starts the specified replay. Events are not necessarily replayed in the exact same
        /// order that they were added to the archive. A replay processes events to replay based
        /// on the time in the event, and replays them using 1 minute intervals. If you specify
        /// an <c>EventStartTime</c> and an <c>EventEndTime</c> that covers a 20 minute time range,
        /// the events are replayed from the first minute of that 20 minute range first. Then
        /// the events from the second minute are replayed. You can use <c>DescribeReplay</c>
        /// to determine the progress of a replay. The value returned for <c>EventLastReplayedTime</c>
        /// indicates the time within the specified time range associated with the last event
        /// replayed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartReplay service method.</param>
        /// 
        /// <returns>The response from the StartReplay service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InvalidEventPatternException">
        /// The event pattern is not valid.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.LimitExceededException">
        /// The request failed because it attempted to create resource beyond the allowed service
        /// quota.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceAlreadyExistsException">
        /// The resource you are trying to create already exists.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/StartReplay">REST API Reference for StartReplay Operation</seealso>
        StartReplayResponse StartReplay(StartReplayRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartReplay operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartReplay operation on AmazonEventBridgeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartReplay
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/StartReplay">REST API Reference for StartReplay Operation</seealso>
        IAsyncResult BeginStartReplay(StartReplayRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartReplay operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartReplay.</param>
        /// 
        /// <returns>Returns a  StartReplayResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/StartReplay">REST API Reference for StartReplay Operation</seealso>
        StartReplayResponse EndStartReplay(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Assigns one or more tags (key-value pairs) to the specified EventBridge resource.
        /// Tags can help you organize and categorize your resources. You can also use them to
        /// scope user permissions by granting a user permission to access or change only resources
        /// with certain tag values. In EventBridge, rules and event buses can be tagged.
        /// 
        ///  
        /// <para>
        /// Tags don't have any semantic meaning to Amazon Web Services and are interpreted strictly
        /// as strings of characters.
        /// </para>
        ///  
        /// <para>
        /// You can use the <c>TagResource</c> action with a resource that already has tags. If
        /// you specify a new tag key, this tag is appended to the list of tags associated with
        /// the resource. If you specify a tag key that is already associated with the resource,
        /// the new tag value that you specify replaces the previous value for that tag.
        /// </para>
        ///  
        /// <para>
        /// You can associate as many as 50 tags with a resource.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ManagedRuleException">
        /// This rule was created by an Amazon Web Services service on behalf of your account.
        /// It is managed by that service. If you see this error in response to <c>DeleteRule</c>
        /// or <c>RemoveTargets</c>, you can use the <c>Force</c> parameter in those calls to
        /// delete the rule or remove targets from the rule. You cannot modify these managed rules
        /// by using <c>DisableRule</c>, <c>EnableRule</c>, <c>PutTargets</c>, <c>PutRule</c>,
        /// <c>TagResource</c>, or <c>UntagResource</c>.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonEventBridgeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  TestEventPattern


        /// <summary>
        /// Tests whether the specified event pattern matches the provided event.
        /// 
        ///  
        /// <para>
        /// Most services in Amazon Web Services treat : or / as the same character in Amazon
        /// Resource Names (ARNs). However, EventBridge uses an exact match in event patterns
        /// and rules. Be sure to use the correct ARN characters when creating event patterns
        /// so that they match the ARN syntax in the event you want to match.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestEventPattern service method.</param>
        /// 
        /// <returns>The response from the TestEventPattern service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InvalidEventPatternException">
        /// The event pattern is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/TestEventPattern">REST API Reference for TestEventPattern Operation</seealso>
        TestEventPatternResponse TestEventPattern(TestEventPatternRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TestEventPattern operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TestEventPattern operation on AmazonEventBridgeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTestEventPattern
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/TestEventPattern">REST API Reference for TestEventPattern Operation</seealso>
        IAsyncResult BeginTestEventPattern(TestEventPatternRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TestEventPattern operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTestEventPattern.</param>
        /// 
        /// <returns>Returns a  TestEventPatternResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/TestEventPattern">REST API Reference for TestEventPattern Operation</seealso>
        TestEventPatternResponse EndTestEventPattern(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes one or more tags from the specified EventBridge resource. In Amazon EventBridge,
        /// rules and event buses can be tagged.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ManagedRuleException">
        /// This rule was created by an Amazon Web Services service on behalf of your account.
        /// It is managed by that service. If you see this error in response to <c>DeleteRule</c>
        /// or <c>RemoveTargets</c>, you can use the <c>Force</c> parameter in those calls to
        /// delete the rule or remove targets from the rule. You cannot modify these managed rules
        /// by using <c>DisableRule</c>, <c>EnableRule</c>, <c>PutTargets</c>, <c>PutRule</c>,
        /// <c>TagResource</c>, or <c>UntagResource</c>.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonEventBridgeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateApiDestination


        /// <summary>
        /// Updates an API destination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApiDestination service method.</param>
        /// 
        /// <returns>The response from the UpdateApiDestination service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.LimitExceededException">
        /// The request failed because it attempted to create resource beyond the allowed service
        /// quota.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/UpdateApiDestination">REST API Reference for UpdateApiDestination Operation</seealso>
        UpdateApiDestinationResponse UpdateApiDestination(UpdateApiDestinationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApiDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApiDestination operation on AmazonEventBridgeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateApiDestination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/UpdateApiDestination">REST API Reference for UpdateApiDestination Operation</seealso>
        IAsyncResult BeginUpdateApiDestination(UpdateApiDestinationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateApiDestination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApiDestination.</param>
        /// 
        /// <returns>Returns a  UpdateApiDestinationResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/UpdateApiDestination">REST API Reference for UpdateApiDestination Operation</seealso>
        UpdateApiDestinationResponse EndUpdateApiDestination(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateArchive


        /// <summary>
        /// Updates the specified archive.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateArchive service method.</param>
        /// 
        /// <returns>The response from the UpdateArchive service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InvalidEventPatternException">
        /// The event pattern is not valid.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.LimitExceededException">
        /// The request failed because it attempted to create resource beyond the allowed service
        /// quota.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/UpdateArchive">REST API Reference for UpdateArchive Operation</seealso>
        UpdateArchiveResponse UpdateArchive(UpdateArchiveRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateArchive operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateArchive operation on AmazonEventBridgeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateArchive
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/UpdateArchive">REST API Reference for UpdateArchive Operation</seealso>
        IAsyncResult BeginUpdateArchive(UpdateArchiveRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateArchive operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateArchive.</param>
        /// 
        /// <returns>Returns a  UpdateArchiveResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/UpdateArchive">REST API Reference for UpdateArchive Operation</seealso>
        UpdateArchiveResponse EndUpdateArchive(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateConnection


        /// <summary>
        /// Updates settings for a connection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConnection service method.</param>
        /// 
        /// <returns>The response from the UpdateConnection service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.AccessDeniedException">
        /// You do not have the necessary permissions for this action.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.LimitExceededException">
        /// The request failed because it attempted to create resource beyond the allowed service
        /// quota.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ThrottlingException">
        /// This request cannot be completed due to throttling issues.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/UpdateConnection">REST API Reference for UpdateConnection Operation</seealso>
        UpdateConnectionResponse UpdateConnection(UpdateConnectionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateConnection operation on AmazonEventBridgeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/UpdateConnection">REST API Reference for UpdateConnection Operation</seealso>
        IAsyncResult BeginUpdateConnection(UpdateConnectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateConnection.</param>
        /// 
        /// <returns>Returns a  UpdateConnectionResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/UpdateConnection">REST API Reference for UpdateConnection Operation</seealso>
        UpdateConnectionResponse EndUpdateConnection(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateEndpoint


        /// <summary>
        /// Update an existing endpoint. For more information about global endpoints, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-global-endpoints.html">Making
        /// applications Regional-fault tolerant with global endpoints and event replication</a>
        /// in the <i> <i>Amazon EventBridge User Guide</i> </i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEndpoint service method.</param>
        /// 
        /// <returns>The response from the UpdateEndpoint service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/UpdateEndpoint">REST API Reference for UpdateEndpoint Operation</seealso>
        UpdateEndpointResponse UpdateEndpoint(UpdateEndpointRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEndpoint operation on AmazonEventBridgeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/UpdateEndpoint">REST API Reference for UpdateEndpoint Operation</seealso>
        IAsyncResult BeginUpdateEndpoint(UpdateEndpointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEndpoint.</param>
        /// 
        /// <returns>Returns a  UpdateEndpointResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/UpdateEndpoint">REST API Reference for UpdateEndpoint Operation</seealso>
        UpdateEndpointResponse EndUpdateEndpoint(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateEventBus


        /// <summary>
        /// Updates the specified event bus.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEventBus service method.</param>
        /// 
        /// <returns>The response from the UpdateEventBus service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.OperationDisabledException">
        /// The operation you are attempting is not available in this region.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/UpdateEventBus">REST API Reference for UpdateEventBus Operation</seealso>
        UpdateEventBusResponse UpdateEventBus(UpdateEventBusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEventBus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEventBus operation on AmazonEventBridgeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateEventBus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/UpdateEventBus">REST API Reference for UpdateEventBus Operation</seealso>
        IAsyncResult BeginUpdateEventBus(UpdateEventBusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEventBus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEventBus.</param>
        /// 
        /// <returns>Returns a  UpdateEventBusResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/UpdateEventBus">REST API Reference for UpdateEventBus Operation</seealso>
        UpdateEventBusResponse EndUpdateEventBus(IAsyncResult asyncResult);

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