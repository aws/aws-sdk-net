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
using System.Net;

using Amazon.EventBridge.Model;
using Amazon.EventBridge.Model.Internal.MarshallTransformations;
using Amazon.EventBridge.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.EventBridge
{
    /// <summary>
    /// Implementation for accessing EventBridge
    ///
    /// Amazon EventBridge helps you to respond to state changes in your AWS resources. When
    /// your resources change state, they automatically send events into an event stream.
    /// You can create rules that match selected events in the stream and route them to targets
    /// to take action. You can also use rules to take action on a predetermined schedule.
    /// For example, you can configure rules to:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Automatically invoke an AWS Lambda function to update DNS entries when an event notifies
    /// you that Amazon EC2 instance enters the running state.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Direct specific API records from AWS CloudTrail to an Amazon Kinesis data stream for
    /// detailed analysis of potential security or availability risks.
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
    public partial class AmazonEventBridgeClient : AmazonServiceClient, IAmazonEventBridge
    {
        private static IServiceMetadata serviceMetadata = new AmazonEventBridgeMetadata();

        #region Constructors

        /// <summary>
        /// Constructs AmazonEventBridgeClient with the credentials loaded from the application's
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
        public AmazonEventBridgeClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonEventBridgeConfig()) { }

        /// <summary>
        /// Constructs AmazonEventBridgeClient with the credentials loaded from the application's
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
        public AmazonEventBridgeClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonEventBridgeConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonEventBridgeClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonEventBridgeClient Configuration Object</param>
        public AmazonEventBridgeClient(AmazonEventBridgeConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonEventBridgeClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonEventBridgeClient(AWSCredentials credentials)
            : this(credentials, new AmazonEventBridgeConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonEventBridgeClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonEventBridgeClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonEventBridgeConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonEventBridgeClient with AWS Credentials and an
        /// AmazonEventBridgeClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonEventBridgeClient Configuration Object</param>
        public AmazonEventBridgeClient(AWSCredentials credentials, AmazonEventBridgeConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonEventBridgeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonEventBridgeClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonEventBridgeConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonEventBridgeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonEventBridgeClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonEventBridgeConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonEventBridgeClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonEventBridgeClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonEventBridgeClient Configuration Object</param>
        public AmazonEventBridgeClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonEventBridgeConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonEventBridgeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonEventBridgeClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonEventBridgeConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonEventBridgeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonEventBridgeClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonEventBridgeConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonEventBridgeClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonEventBridgeClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonEventBridgeClient Configuration Object</param>
        public AmazonEventBridgeClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonEventBridgeConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        
        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
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
        public virtual ActivateEventSourceResponse ActivateEventSource(ActivateEventSourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ActivateEventSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ActivateEventSourceResponseUnmarshaller.Instance;

            return Invoke<ActivateEventSourceResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginActivateEventSource(ActivateEventSourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ActivateEventSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ActivateEventSourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ActivateEventSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginActivateEventSource.</param>
        /// 
        /// <returns>Returns a  ActivateEventSourceResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/ActivateEventSource">REST API Reference for ActivateEventSource Operation</seealso>
        public virtual ActivateEventSourceResponse EndActivateEventSource(IAsyncResult asyncResult)
        {
            return EndInvoke<ActivateEventSourceResponse>(asyncResult);
        }

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
        public virtual CancelReplayResponse CancelReplay(CancelReplayRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelReplayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelReplayResponseUnmarshaller.Instance;

            return Invoke<CancelReplayResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginCancelReplay(CancelReplayRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelReplayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelReplayResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CancelReplay operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelReplay.</param>
        /// 
        /// <returns>Returns a  CancelReplayResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/CancelReplay">REST API Reference for CancelReplay Operation</seealso>
        public virtual CancelReplayResponse EndCancelReplay(IAsyncResult asyncResult)
        {
            return EndInvoke<CancelReplayResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateArchive

        /// <summary>
        /// Creates an archive of events with the specified settings. When you create an archive,
        /// incoming events might not immediately start being sent to the archive. Allow a short
        /// period of time for changes to take effect. If you do not specify a pattern to filter
        /// events sent to the archive, all events are sent to the archive except replayed events.
        /// Replayed events are not sent to an archive.
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
        public virtual CreateArchiveResponse CreateArchive(CreateArchiveRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateArchiveRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateArchiveResponseUnmarshaller.Instance;

            return Invoke<CreateArchiveResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginCreateArchive(CreateArchiveRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateArchiveRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateArchiveResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateArchive operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateArchive.</param>
        /// 
        /// <returns>Returns a  CreateArchiveResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/CreateArchive">REST API Reference for CreateArchive Operation</seealso>
        public virtual CreateArchiveResponse EndCreateArchive(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateArchiveResponse>(asyncResult);
        }

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
        public virtual CreateEventBusResponse CreateEventBus(CreateEventBusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEventBusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEventBusResponseUnmarshaller.Instance;

            return Invoke<CreateEventBusResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginCreateEventBus(CreateEventBusRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEventBusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEventBusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEventBus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEventBus.</param>
        /// 
        /// <returns>Returns a  CreateEventBusResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/CreateEventBus">REST API Reference for CreateEventBus Operation</seealso>
        public virtual CreateEventBusResponse EndCreateEventBus(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateEventBusResponse>(asyncResult);
        }

        #endregion
        
        #region  CreatePartnerEventSource

        /// <summary>
        /// Called by an SaaS partner to create a partner event source. This operation is not
        /// used by AWS customers.
        /// 
        ///  
        /// <para>
        /// Each partner event source can be used by one AWS account to create a matching partner
        /// event bus in that AWS account. A SaaS partner must create one partner event source
        /// for each AWS account that wants to receive those event types. 
        /// </para>
        ///  
        /// <para>
        /// A partner event source creates events based on resources within the SaaS partner's
        /// service or application.
        /// </para>
        ///  
        /// <para>
        /// An AWS account that creates a partner event bus that matches the partner event source
        /// can use that event bus to receive events from the partner, and then process them using
        /// AWS Events rules and targets.
        /// </para>
        ///  
        /// <para>
        /// Partner event source names follow this format:
        /// </para>
        ///  
        /// <para>
        ///  <code> <i>partner_name</i>/<i>event_namespace</i>/<i>event_name</i> </code> 
        /// </para>
        ///  
        /// <para>
        ///  <i>partner_name</i> is determined during partner registration and identifies the
        /// partner to AWS customers. <i>event_namespace</i> is determined by the partner and
        /// is a way for the partner to categorize their events. <i>event_name</i> is determined
        /// by the partner, and should uniquely identify an event-generating resource within the
        /// partner system. The combination of <i>event_namespace</i> and <i>event_name</i> should
        /// help AWS customers decide whether to create an event bus to receive these events.
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
        public virtual CreatePartnerEventSourceResponse CreatePartnerEventSource(CreatePartnerEventSourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePartnerEventSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePartnerEventSourceResponseUnmarshaller.Instance;

            return Invoke<CreatePartnerEventSourceResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginCreatePartnerEventSource(CreatePartnerEventSourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePartnerEventSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePartnerEventSourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePartnerEventSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePartnerEventSource.</param>
        /// 
        /// <returns>Returns a  CreatePartnerEventSourceResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/CreatePartnerEventSource">REST API Reference for CreatePartnerEventSource Operation</seealso>
        public virtual CreatePartnerEventSourceResponse EndCreatePartnerEventSource(IAsyncResult asyncResult)
        {
            return EndInvoke<CreatePartnerEventSourceResponse>(asyncResult);
        }

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
        /// To activate a deactivated partner event source, use <a>ActivateEventSource</a>.
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
        public virtual DeactivateEventSourceResponse DeactivateEventSource(DeactivateEventSourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeactivateEventSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeactivateEventSourceResponseUnmarshaller.Instance;

            return Invoke<DeactivateEventSourceResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginDeactivateEventSource(DeactivateEventSourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeactivateEventSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeactivateEventSourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeactivateEventSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeactivateEventSource.</param>
        /// 
        /// <returns>Returns a  DeactivateEventSourceResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DeactivateEventSource">REST API Reference for DeactivateEventSource Operation</seealso>
        public virtual DeactivateEventSourceResponse EndDeactivateEventSource(IAsyncResult asyncResult)
        {
            return EndInvoke<DeactivateEventSourceResponse>(asyncResult);
        }

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
        public virtual DeleteArchiveResponse DeleteArchive(DeleteArchiveRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteArchiveRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteArchiveResponseUnmarshaller.Instance;

            return Invoke<DeleteArchiveResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginDeleteArchive(DeleteArchiveRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteArchiveRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteArchiveResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteArchive operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteArchive.</param>
        /// 
        /// <returns>Returns a  DeleteArchiveResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DeleteArchive">REST API Reference for DeleteArchive Operation</seealso>
        public virtual DeleteArchiveResponse EndDeleteArchive(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteArchiveResponse>(asyncResult);
        }

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
        public virtual DeleteEventBusResponse DeleteEventBus(DeleteEventBusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEventBusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEventBusResponseUnmarshaller.Instance;

            return Invoke<DeleteEventBusResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginDeleteEventBus(DeleteEventBusRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEventBusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEventBusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEventBus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEventBus.</param>
        /// 
        /// <returns>Returns a  DeleteEventBusResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DeleteEventBus">REST API Reference for DeleteEventBus Operation</seealso>
        public virtual DeleteEventBusResponse EndDeleteEventBus(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteEventBusResponse>(asyncResult);
        }

        #endregion
        
        #region  DeletePartnerEventSource

        /// <summary>
        /// This operation is used by SaaS partners to delete a partner event source. This operation
        /// is not used by AWS customers.
        /// 
        ///  
        /// <para>
        /// When you delete an event source, the status of the corresponding partner event bus
        /// in the AWS customer account becomes DELETED.
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
        public virtual DeletePartnerEventSourceResponse DeletePartnerEventSource(DeletePartnerEventSourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePartnerEventSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePartnerEventSourceResponseUnmarshaller.Instance;

            return Invoke<DeletePartnerEventSourceResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginDeletePartnerEventSource(DeletePartnerEventSourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePartnerEventSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePartnerEventSourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePartnerEventSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePartnerEventSource.</param>
        /// 
        /// <returns>Returns a  DeletePartnerEventSourceResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DeletePartnerEventSource">REST API Reference for DeletePartnerEventSource Operation</seealso>
        public virtual DeletePartnerEventSourceResponse EndDeletePartnerEventSource(IAsyncResult asyncResult)
        {
            return EndInvoke<DeletePartnerEventSourceResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteRule

        /// <summary>
        /// Deletes the specified rule.
        /// 
        ///  
        /// <para>
        /// Before you can delete the rule, you must remove all targets, using <a>RemoveTargets</a>.
        /// </para>
        ///  
        /// <para>
        /// When you delete a rule, incoming events might continue to match to the deleted rule.
        /// Allow a short period of time for changes to take effect.
        /// </para>
        ///  
        /// <para>
        /// Managed rules are rules created and managed by another AWS service on your behalf.
        /// These rules are created by those other AWS services to support functionality in those
        /// services. You can delete these rules using the <code>Force</code> option, but you
        /// should do so only if you are sure the other service is not still using that rule.
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
        /// This rule was created by an AWS service on behalf of your account. It is managed by
        /// that service. If you see this error in response to <code>DeleteRule</code> or <code>RemoveTargets</code>,
        /// you can use the <code>Force</code> parameter in those calls to delete the rule or
        /// remove targets from the rule. You cannot modify these managed rules by using <code>DisableRule</code>,
        /// <code>EnableRule</code>, <code>PutTargets</code>, <code>PutRule</code>, <code>TagResource</code>,
        /// or <code>UntagResource</code>.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DeleteRule">REST API Reference for DeleteRule Operation</seealso>
        public virtual DeleteRuleResponse DeleteRule(DeleteRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRuleResponseUnmarshaller.Instance;

            return Invoke<DeleteRuleResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginDeleteRule(DeleteRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRule.</param>
        /// 
        /// <returns>Returns a  DeleteRuleResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DeleteRule">REST API Reference for DeleteRule Operation</seealso>
        public virtual DeleteRuleResponse EndDeleteRule(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteRuleResponse>(asyncResult);
        }

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
        public virtual DescribeArchiveResponse DescribeArchive(DescribeArchiveRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeArchiveRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeArchiveResponseUnmarshaller.Instance;

            return Invoke<DescribeArchiveResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginDescribeArchive(DescribeArchiveRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeArchiveRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeArchiveResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeArchive operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeArchive.</param>
        /// 
        /// <returns>Returns a  DescribeArchiveResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DescribeArchive">REST API Reference for DescribeArchive Operation</seealso>
        public virtual DescribeArchiveResponse EndDescribeArchive(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeArchiveResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeEventBus

        /// <summary>
        /// Displays details about an event bus in your account. This can include the external
        /// AWS accounts that are permitted to write events to your default event bus, and the
        /// associated policy. For custom event buses and partner event buses, it displays the
        /// name, ARN, policy, state, and creation time.
        /// 
        ///  
        /// <para>
        ///  To enable your account to receive events from other accounts on its default event
        /// bus, use <a>PutPermission</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information about partner event buses, see <a>CreateEventBus</a>.
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
        public virtual DescribeEventBusResponse DescribeEventBus(DescribeEventBusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEventBusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventBusResponseUnmarshaller.Instance;

            return Invoke<DescribeEventBusResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginDescribeEventBus(DescribeEventBusRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEventBusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventBusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEventBus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEventBus.</param>
        /// 
        /// <returns>Returns a  DescribeEventBusResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DescribeEventBus">REST API Reference for DescribeEventBus Operation</seealso>
        public virtual DescribeEventBusResponse EndDescribeEventBus(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeEventBusResponse>(asyncResult);
        }

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
        public virtual DescribeEventSourceResponse DescribeEventSource(DescribeEventSourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEventSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventSourceResponseUnmarshaller.Instance;

            return Invoke<DescribeEventSourceResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginDescribeEventSource(DescribeEventSourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEventSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventSourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEventSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEventSource.</param>
        /// 
        /// <returns>Returns a  DescribeEventSourceResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DescribeEventSource">REST API Reference for DescribeEventSource Operation</seealso>
        public virtual DescribeEventSourceResponse EndDescribeEventSource(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeEventSourceResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribePartnerEventSource

        /// <summary>
        /// An SaaS partner can use this operation to list details about a partner event source
        /// that they have created. AWS customers do not use this operation. Instead, AWS customers
        /// can use <a>DescribeEventSource</a> to see details about a partner event source that
        /// is shared with them.
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
        public virtual DescribePartnerEventSourceResponse DescribePartnerEventSource(DescribePartnerEventSourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePartnerEventSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePartnerEventSourceResponseUnmarshaller.Instance;

            return Invoke<DescribePartnerEventSourceResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginDescribePartnerEventSource(DescribePartnerEventSourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePartnerEventSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePartnerEventSourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePartnerEventSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePartnerEventSource.</param>
        /// 
        /// <returns>Returns a  DescribePartnerEventSourceResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DescribePartnerEventSource">REST API Reference for DescribePartnerEventSource Operation</seealso>
        public virtual DescribePartnerEventSourceResponse EndDescribePartnerEventSource(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribePartnerEventSourceResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeReplay

        /// <summary>
        /// Retrieves details about a replay. Use <code>DescribeReplay</code> to determine the
        /// progress of a running replay. A replay processes events to replay based on the time
        /// in the event, and replays them using 1 minute intervals. If you use <code>StartReplay</code>
        /// and specify an <code>EventStartTime</code> and an <code>EventEndTime</code> that covers
        /// a 20 minute time range, the events are replayed from the first minute of that 20 minute
        /// range first. Then the events from the second minute are replayed. You can use <code>DescribeReplay</code>
        /// to determine the progress of a replay. The value returned for <code>EventLastReplayedTime</code>
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
        public virtual DescribeReplayResponse DescribeReplay(DescribeReplayRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReplayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReplayResponseUnmarshaller.Instance;

            return Invoke<DescribeReplayResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginDescribeReplay(DescribeReplayRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReplayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReplayResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeReplay operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReplay.</param>
        /// 
        /// <returns>Returns a  DescribeReplayResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DescribeReplay">REST API Reference for DescribeReplay Operation</seealso>
        public virtual DescribeReplayResponse EndDescribeReplay(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeReplayResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeRule

        /// <summary>
        /// Describes the specified rule.
        /// 
        ///  
        /// <para>
        /// DescribeRule does not list the targets of a rule. To see the targets associated with
        /// a rule, use <a>ListTargetsByRule</a>.
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
        public virtual DescribeRuleResponse DescribeRule(DescribeRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRuleResponseUnmarshaller.Instance;

            return Invoke<DescribeRuleResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginDescribeRule(DescribeRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRule.</param>
        /// 
        /// <returns>Returns a  DescribeRuleResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DescribeRule">REST API Reference for DescribeRule Operation</seealso>
        public virtual DescribeRuleResponse EndDescribeRule(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeRuleResponse>(asyncResult);
        }

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
        /// This rule was created by an AWS service on behalf of your account. It is managed by
        /// that service. If you see this error in response to <code>DeleteRule</code> or <code>RemoveTargets</code>,
        /// you can use the <code>Force</code> parameter in those calls to delete the rule or
        /// remove targets from the rule. You cannot modify these managed rules by using <code>DisableRule</code>,
        /// <code>EnableRule</code>, <code>PutTargets</code>, <code>PutRule</code>, <code>TagResource</code>,
        /// or <code>UntagResource</code>.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DisableRule">REST API Reference for DisableRule Operation</seealso>
        public virtual DisableRuleResponse DisableRule(DisableRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableRuleResponseUnmarshaller.Instance;

            return Invoke<DisableRuleResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginDisableRule(DisableRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisableRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableRule.</param>
        /// 
        /// <returns>Returns a  DisableRuleResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DisableRule">REST API Reference for DisableRule Operation</seealso>
        public virtual DisableRuleResponse EndDisableRule(IAsyncResult asyncResult)
        {
            return EndInvoke<DisableRuleResponse>(asyncResult);
        }

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
        /// This rule was created by an AWS service on behalf of your account. It is managed by
        /// that service. If you see this error in response to <code>DeleteRule</code> or <code>RemoveTargets</code>,
        /// you can use the <code>Force</code> parameter in those calls to delete the rule or
        /// remove targets from the rule. You cannot modify these managed rules by using <code>DisableRule</code>,
        /// <code>EnableRule</code>, <code>PutTargets</code>, <code>PutRule</code>, <code>TagResource</code>,
        /// or <code>UntagResource</code>.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/EnableRule">REST API Reference for EnableRule Operation</seealso>
        public virtual EnableRuleResponse EnableRule(EnableRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableRuleResponseUnmarshaller.Instance;

            return Invoke<EnableRuleResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginEnableRule(EnableRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  EnableRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableRule.</param>
        /// 
        /// <returns>Returns a  EnableRuleResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/EnableRule">REST API Reference for EnableRule Operation</seealso>
        public virtual EnableRuleResponse EndEnableRule(IAsyncResult asyncResult)
        {
            return EndInvoke<EnableRuleResponse>(asyncResult);
        }

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
        public virtual ListArchivesResponse ListArchives(ListArchivesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListArchivesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListArchivesResponseUnmarshaller.Instance;

            return Invoke<ListArchivesResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginListArchives(ListArchivesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListArchivesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListArchivesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListArchives operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListArchives.</param>
        /// 
        /// <returns>Returns a  ListArchivesResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/ListArchives">REST API Reference for ListArchives Operation</seealso>
        public virtual ListArchivesResponse EndListArchives(IAsyncResult asyncResult)
        {
            return EndInvoke<ListArchivesResponse>(asyncResult);
        }

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
        public virtual ListEventBusesResponse ListEventBuses(ListEventBusesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEventBusesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEventBusesResponseUnmarshaller.Instance;

            return Invoke<ListEventBusesResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginListEventBuses(ListEventBusesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEventBusesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEventBusesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListEventBuses operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEventBuses.</param>
        /// 
        /// <returns>Returns a  ListEventBusesResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/ListEventBuses">REST API Reference for ListEventBuses Operation</seealso>
        public virtual ListEventBusesResponse EndListEventBuses(IAsyncResult asyncResult)
        {
            return EndInvoke<ListEventBusesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListEventSources

        /// <summary>
        /// You can use this to see all the partner event sources that have been shared with your
        /// AWS account. For more information about partner event sources, see <a>CreateEventBus</a>.
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
        public virtual ListEventSourcesResponse ListEventSources(ListEventSourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEventSourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEventSourcesResponseUnmarshaller.Instance;

            return Invoke<ListEventSourcesResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginListEventSources(ListEventSourcesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEventSourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEventSourcesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListEventSources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEventSources.</param>
        /// 
        /// <returns>Returns a  ListEventSourcesResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/ListEventSources">REST API Reference for ListEventSources Operation</seealso>
        public virtual ListEventSourcesResponse EndListEventSources(IAsyncResult asyncResult)
        {
            return EndInvoke<ListEventSourcesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPartnerEventSourceAccounts

        /// <summary>
        /// An SaaS partner can use this operation to display the AWS account ID that a particular
        /// partner event source name is associated with. This operation is not used by AWS customers.
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
        public virtual ListPartnerEventSourceAccountsResponse ListPartnerEventSourceAccounts(ListPartnerEventSourceAccountsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPartnerEventSourceAccountsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPartnerEventSourceAccountsResponseUnmarshaller.Instance;

            return Invoke<ListPartnerEventSourceAccountsResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginListPartnerEventSourceAccounts(ListPartnerEventSourceAccountsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPartnerEventSourceAccountsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPartnerEventSourceAccountsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPartnerEventSourceAccounts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPartnerEventSourceAccounts.</param>
        /// 
        /// <returns>Returns a  ListPartnerEventSourceAccountsResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/ListPartnerEventSourceAccounts">REST API Reference for ListPartnerEventSourceAccounts Operation</seealso>
        public virtual ListPartnerEventSourceAccountsResponse EndListPartnerEventSourceAccounts(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPartnerEventSourceAccountsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPartnerEventSources

        /// <summary>
        /// An SaaS partner can use this operation to list all the partner event source names
        /// that they have created. This operation is not used by AWS customers.
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
        public virtual ListPartnerEventSourcesResponse ListPartnerEventSources(ListPartnerEventSourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPartnerEventSourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPartnerEventSourcesResponseUnmarshaller.Instance;

            return Invoke<ListPartnerEventSourcesResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginListPartnerEventSources(ListPartnerEventSourcesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPartnerEventSourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPartnerEventSourcesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPartnerEventSources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPartnerEventSources.</param>
        /// 
        /// <returns>Returns a  ListPartnerEventSourcesResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/ListPartnerEventSources">REST API Reference for ListPartnerEventSources Operation</seealso>
        public virtual ListPartnerEventSourcesResponse EndListPartnerEventSources(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPartnerEventSourcesResponse>(asyncResult);
        }

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
        public virtual ListReplaysResponse ListReplays(ListReplaysRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListReplaysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReplaysResponseUnmarshaller.Instance;

            return Invoke<ListReplaysResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginListReplays(ListReplaysRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListReplaysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReplaysResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListReplays operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListReplays.</param>
        /// 
        /// <returns>Returns a  ListReplaysResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/ListReplays">REST API Reference for ListReplays Operation</seealso>
        public virtual ListReplaysResponse EndListReplays(IAsyncResult asyncResult)
        {
            return EndInvoke<ListReplaysResponse>(asyncResult);
        }

        #endregion
        
        #region  ListRuleNamesByTarget

        /// <summary>
        /// Lists the rules for the specified target. You can see which of the rules in Amazon
        /// EventBridge can invoke a specific target in your account.
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
        public virtual ListRuleNamesByTargetResponse ListRuleNamesByTarget(ListRuleNamesByTargetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRuleNamesByTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRuleNamesByTargetResponseUnmarshaller.Instance;

            return Invoke<ListRuleNamesByTargetResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginListRuleNamesByTarget(ListRuleNamesByTargetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRuleNamesByTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRuleNamesByTargetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRuleNamesByTarget operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRuleNamesByTarget.</param>
        /// 
        /// <returns>Returns a  ListRuleNamesByTargetResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/ListRuleNamesByTarget">REST API Reference for ListRuleNamesByTarget Operation</seealso>
        public virtual ListRuleNamesByTargetResponse EndListRuleNamesByTarget(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRuleNamesByTargetResponse>(asyncResult);
        }

        #endregion
        
        #region  ListRules

        /// <summary>
        /// Lists your Amazon EventBridge rules. You can either list all the rules or you can
        /// provide a prefix to match to the rule names.
        /// 
        ///  
        /// <para>
        /// ListRules does not list the targets of a rule. To see the targets associated with
        /// a rule, use <a>ListTargetsByRule</a>.
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
        public virtual ListRulesResponse ListRules(ListRulesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRulesResponseUnmarshaller.Instance;

            return Invoke<ListRulesResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginListRules(ListRulesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRulesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRules operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRules.</param>
        /// 
        /// <returns>Returns a  ListRulesResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/ListRules">REST API Reference for ListRules Operation</seealso>
        public virtual ListRulesResponse EndListRules(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRulesResponse>(asyncResult);
        }

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
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTargetsByRule

        /// <summary>
        /// Lists the targets assigned to the specified rule.
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
        public virtual ListTargetsByRuleResponse ListTargetsByRule(ListTargetsByRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTargetsByRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTargetsByRuleResponseUnmarshaller.Instance;

            return Invoke<ListTargetsByRuleResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginListTargetsByRule(ListTargetsByRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTargetsByRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTargetsByRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTargetsByRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTargetsByRule.</param>
        /// 
        /// <returns>Returns a  ListTargetsByRuleResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/ListTargetsByRule">REST API Reference for ListTargetsByRule Operation</seealso>
        public virtual ListTargetsByRuleResponse EndListTargetsByRule(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTargetsByRuleResponse>(asyncResult);
        }

        #endregion
        
        #region  PutEvents

        /// <summary>
        /// Sends custom events to Amazon EventBridge so that they can be matched to rules.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEvents service method.</param>
        /// 
        /// <returns>The response from the PutEvents service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/PutEvents">REST API Reference for PutEvents Operation</seealso>
        public virtual PutEventsResponse PutEvents(PutEventsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEventsResponseUnmarshaller.Instance;

            return Invoke<PutEventsResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginPutEvents(PutEventsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEventsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutEvents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutEvents.</param>
        /// 
        /// <returns>Returns a  PutEventsResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/PutEvents">REST API Reference for PutEvents Operation</seealso>
        public virtual PutEventsResponse EndPutEvents(IAsyncResult asyncResult)
        {
            return EndInvoke<PutEventsResponse>(asyncResult);
        }

        #endregion
        
        #region  PutPartnerEvents

        /// <summary>
        /// This is used by SaaS partners to write events to a customer's partner event bus. AWS
        /// customers do not use this operation.
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
        public virtual PutPartnerEventsResponse PutPartnerEvents(PutPartnerEventsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutPartnerEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutPartnerEventsResponseUnmarshaller.Instance;

            return Invoke<PutPartnerEventsResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginPutPartnerEvents(PutPartnerEventsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutPartnerEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutPartnerEventsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutPartnerEvents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutPartnerEvents.</param>
        /// 
        /// <returns>Returns a  PutPartnerEventsResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/PutPartnerEvents">REST API Reference for PutPartnerEvents Operation</seealso>
        public virtual PutPartnerEventsResponse EndPutPartnerEvents(IAsyncResult asyncResult)
        {
            return EndInvoke<PutPartnerEventsResponse>(asyncResult);
        }

        #endregion
        
        #region  PutPermission

        /// <summary>
        /// Running <code>PutPermission</code> permits the specified AWS account or AWS organization
        /// to put events to the specified <i>event bus</i>. Amazon EventBridge (CloudWatch Events)
        /// rules in your account are triggered by these events arriving to an event bus in your
        /// account. 
        /// 
        ///  
        /// <para>
        /// For another account to send events to your account, that external account must have
        /// an EventBridge rule with your account's event bus as a target.
        /// </para>
        ///  
        /// <para>
        /// To enable multiple AWS accounts to put events to your event bus, run <code>PutPermission</code>
        /// once for each of these accounts. Or, if all the accounts are members of the same AWS
        /// organization, you can run <code>PutPermission</code> once specifying <code>Principal</code>
        /// as "*" and specifying the AWS organization ID in <code>Condition</code>, to grant
        /// permissions to all accounts in that organization.
        /// </para>
        ///  
        /// <para>
        /// If you grant permissions using an organization, then accounts in that organization
        /// must specify a <code>RoleArn</code> with proper permissions when they use <code>PutTarget</code>
        /// to add your account's event bus as a target. For more information, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eventbridge-cross-account-event-delivery.html">Sending
        /// and Receiving Events Between AWS Accounts</a> in the <i>Amazon EventBridge User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The permission policy on the default event bus cannot exceed 10 KB in size.
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
        public virtual PutPermissionResponse PutPermission(PutPermissionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutPermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutPermissionResponseUnmarshaller.Instance;

            return Invoke<PutPermissionResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginPutPermission(PutPermissionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutPermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutPermissionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutPermission operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutPermission.</param>
        /// 
        /// <returns>Returns a  PutPermissionResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/PutPermission">REST API Reference for PutPermission Operation</seealso>
        public virtual PutPermissionResponse EndPutPermission(IAsyncResult asyncResult)
        {
            return EndInvoke<PutPermissionResponse>(asyncResult);
        }

        #endregion
        
        #region  PutRule

        /// <summary>
        /// Creates or updates the specified rule. Rules are enabled by default, or based on value
        /// of the state. You can disable a rule using <a>DisableRule</a>.
        /// 
        ///  
        /// <para>
        /// A single rule watches for events from a single event bus. Events generated by AWS
        /// services go to your account's default event bus. Events generated by SaaS partner
        /// services or applications go to the matching partner event bus. If you have custom
        /// applications or services, you can specify whether their events go to your default
        /// event bus or a custom event bus that you have created. For more information, see <a>CreateEventBus</a>.
        /// </para>
        ///  
        /// <para>
        /// If you are updating an existing rule, the rule is replaced with what you specify in
        /// this <code>PutRule</code> command. If you omit arguments in <code>PutRule</code>,
        /// the old values for those arguments are not kept. Instead, they are replaced with null
        /// values.
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
        /// rules with certain tag values. To use the <code>PutRule</code> operation and assign
        /// tags, you must have both the <code>events:PutRule</code> and <code>events:TagResource</code>
        /// permissions.
        /// </para>
        ///  
        /// <para>
        /// If you are updating an existing rule, any tags you specify in the <code>PutRule</code>
        /// operation are ignored. To update the tags of an existing rule, use <a>TagResource</a>
        /// and <a>UntagResource</a>.
        /// </para>
        ///  
        /// <para>
        /// Most services in AWS treat : or / as the same character in Amazon Resource Names (ARNs).
        /// However, EventBridge uses an exact match in event patterns and rules. Be sure to use
        /// the correct ARN characters when creating event patterns so that they match the ARN
        /// syntax in the event you want to match.
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
        /// This rule was created by an AWS service on behalf of your account. It is managed by
        /// that service. If you see this error in response to <code>DeleteRule</code> or <code>RemoveTargets</code>,
        /// you can use the <code>Force</code> parameter in those calls to delete the rule or
        /// remove targets from the rule. You cannot modify these managed rules by using <code>DisableRule</code>,
        /// <code>EnableRule</code>, <code>PutTargets</code>, <code>PutRule</code>, <code>TagResource</code>,
        /// or <code>UntagResource</code>.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/PutRule">REST API Reference for PutRule Operation</seealso>
        public virtual PutRuleResponse PutRule(PutRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRuleResponseUnmarshaller.Instance;

            return Invoke<PutRuleResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginPutRule(PutRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutRule.</param>
        /// 
        /// <returns>Returns a  PutRuleResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/PutRule">REST API Reference for PutRule Operation</seealso>
        public virtual PutRuleResponse EndPutRule(IAsyncResult asyncResult)
        {
            return EndInvoke<PutRuleResponse>(asyncResult);
        }

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
        /// You can configure the following as targets for Events:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// EC2 instances
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Run Command
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Automation
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AWS Lambda functions
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Data streams in Amazon Kinesis Data Streams
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Data delivery streams in Amazon Kinesis Data Firehose
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon ECS tasks
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AWS Step Functions state machines
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AWS Batch jobs
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AWS CodeBuild projects
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Pipelines in AWS CodePipeline
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Inspector assessment templates
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon SNS topics
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon SQS queues, including FIFO queues
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The default event bus of another AWS account
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon API Gateway REST APIs
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Redshift Clusters to invoke Data API ExecuteStatement on
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Creating rules with built-in targets is supported only in the AWS Management Console.
        /// The built-in targets are <code>EC2 CreateSnapshot API call</code>, <code>EC2 RebootInstances
        /// API call</code>, <code>EC2 StopInstances API call</code>, and <code>EC2 TerminateInstances
        /// API call</code>. 
        /// </para>
        ///  
        /// <para>
        /// For some target types, <code>PutTargets</code> provides target-specific parameters.
        /// If the target is a Kinesis data stream, you can optionally specify which shard the
        /// event goes to by using the <code>KinesisParameters</code> argument. To invoke a command
        /// on multiple EC2 instances with one rule, you can use the <code>RunCommandParameters</code>
        /// field.
        /// </para>
        ///  
        /// <para>
        /// To be able to make API calls against the resources that you own, Amazon EventBridge
        /// (CloudWatch Events) needs the appropriate permissions. For AWS Lambda and Amazon SNS
        /// resources, EventBridge relies on resource-based policies. For EC2 instances, Kinesis
        /// data streams, AWS Step Functions state machines and API Gateway REST APIs, EventBridge
        /// relies on IAM roles that you specify in the <code>RoleARN</code> argument in <code>PutTargets</code>.
        /// For more information, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/auth-and-access-control-eventbridge.html">Authentication
        /// and Access Control</a> in the <i>Amazon EventBridge User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If another AWS account is in the same region and has granted you permission (using
        /// <code>PutPermission</code>), you can send events to that account. Set that account's
        /// event bus as a target of the rules in your account. To send the matched events to
        /// the other account, specify that account's event bus as the <code>Arn</code> value
        /// when you run <code>PutTargets</code>. If your account sends events to another account,
        /// your account is charged for each sent event. Each event sent to another account is
        /// charged as a custom event. The account receiving the event is not charged. For more
        /// information, see <a href="https://aws.amazon.com/eventbridge/pricing/">Amazon EventBridge
        /// (CloudWatch Events) Pricing</a>.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <code>Input</code>, <code>InputPath</code>, and <code>InputTransformer</code> are
        /// not available with <code>PutTarget</code> if the target is an event bus of a different
        /// AWS account.
        /// </para>
        ///  </note> 
        /// <para>
        /// If you are setting the event bus of another account as the target, and that account
        /// granted permission to your account through an organization instead of directly by
        /// the account ID, then you must specify a <code>RoleArn</code> with proper permissions
        /// in the <code>Target</code> structure. For more information, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eventbridge-cross-account-event-delivery.html">Sending
        /// and Receiving Events Between AWS Accounts</a> in the <i>Amazon EventBridge User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information about enabling cross-account events, see <a>PutPermission</a>.
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
        /// If <b>InputPath</b> is specified in the form of JSONPath (for example, <code>$.detail</code>),
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
        /// When you specify <code>InputPath</code> or <code>InputTransformer</code>, you must
        /// use JSON dot notation, not bracket notation.
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
        /// that happens, <code>FailedEntryCount</code> is non-zero in the response and each entry
        /// in <code>FailedEntries</code> provides the ID of the failed target and the error code.
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
        /// This rule was created by an AWS service on behalf of your account. It is managed by
        /// that service. If you see this error in response to <code>DeleteRule</code> or <code>RemoveTargets</code>,
        /// you can use the <code>Force</code> parameter in those calls to delete the rule or
        /// remove targets from the rule. You cannot modify these managed rules by using <code>DisableRule</code>,
        /// <code>EnableRule</code>, <code>PutTargets</code>, <code>PutRule</code>, <code>TagResource</code>,
        /// or <code>UntagResource</code>.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/PutTargets">REST API Reference for PutTargets Operation</seealso>
        public virtual PutTargetsResponse PutTargets(PutTargetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutTargetsResponseUnmarshaller.Instance;

            return Invoke<PutTargetsResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginPutTargets(PutTargetsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutTargetsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutTargets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutTargets.</param>
        /// 
        /// <returns>Returns a  PutTargetsResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/PutTargets">REST API Reference for PutTargets Operation</seealso>
        public virtual PutTargetsResponse EndPutTargets(IAsyncResult asyncResult)
        {
            return EndInvoke<PutTargetsResponse>(asyncResult);
        }

        #endregion
        
        #region  RemovePermission

        /// <summary>
        /// Revokes the permission of another AWS account to be able to put events to the specified
        /// event bus. Specify the account to revoke by the <code>StatementId</code> value that
        /// you associated with the account when you granted it permission with <code>PutPermission</code>.
        /// You can find the <code>StatementId</code> by using <a>DescribeEventBus</a>.
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
        public virtual RemovePermissionResponse RemovePermission(RemovePermissionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemovePermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemovePermissionResponseUnmarshaller.Instance;

            return Invoke<RemovePermissionResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginRemovePermission(RemovePermissionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemovePermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemovePermissionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RemovePermission operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemovePermission.</param>
        /// 
        /// <returns>Returns a  RemovePermissionResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/RemovePermission">REST API Reference for RemovePermission Operation</seealso>
        public virtual RemovePermissionResponse EndRemovePermission(IAsyncResult asyncResult)
        {
            return EndInvoke<RemovePermissionResponse>(asyncResult);
        }

        #endregion
        
        #region  RemoveTargets

        /// <summary>
        /// Removes the specified targets from the specified rule. When the rule is triggered,
        /// those targets are no longer be invoked.
        /// 
        ///  
        /// <para>
        /// When you remove a target, when the associated rule triggers, removed targets might
        /// continue to be invoked. Allow a short period of time for changes to take effect.
        /// </para>
        ///  
        /// <para>
        /// This action can partially fail if too many requests are made at the same time. If
        /// that happens, <code>FailedEntryCount</code> is non-zero in the response and each entry
        /// in <code>FailedEntries</code> provides the ID of the failed target and the error code.
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
        /// This rule was created by an AWS service on behalf of your account. It is managed by
        /// that service. If you see this error in response to <code>DeleteRule</code> or <code>RemoveTargets</code>,
        /// you can use the <code>Force</code> parameter in those calls to delete the rule or
        /// remove targets from the rule. You cannot modify these managed rules by using <code>DisableRule</code>,
        /// <code>EnableRule</code>, <code>PutTargets</code>, <code>PutRule</code>, <code>TagResource</code>,
        /// or <code>UntagResource</code>.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/RemoveTargets">REST API Reference for RemoveTargets Operation</seealso>
        public virtual RemoveTargetsResponse RemoveTargets(RemoveTargetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTargetsResponseUnmarshaller.Instance;

            return Invoke<RemoveTargetsResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginRemoveTargets(RemoveTargetsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTargetsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveTargets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveTargets.</param>
        /// 
        /// <returns>Returns a  RemoveTargetsResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/RemoveTargets">REST API Reference for RemoveTargets Operation</seealso>
        public virtual RemoveTargetsResponse EndRemoveTargets(IAsyncResult asyncResult)
        {
            return EndInvoke<RemoveTargetsResponse>(asyncResult);
        }

        #endregion
        
        #region  StartReplay

        /// <summary>
        /// Starts the specified replay. Events are not necessarily replayed in the exact same
        /// order that they were added to the archive. A replay processes events to replay based
        /// on the time in the event, and replays them using 1 minute intervals. If you specify
        /// an <code>EventStartTime</code> and an <code>EventEndTime</code> that covers a 20 minute
        /// time range, the events are replayed from the first minute of that 20 minute range
        /// first. Then the events from the second minute are replayed. You can use <code>DescribeReplay</code>
        /// to determine the progress of a replay. The value returned for <code>EventLastReplayedTime</code>
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
        public virtual StartReplayResponse StartReplay(StartReplayRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartReplayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartReplayResponseUnmarshaller.Instance;

            return Invoke<StartReplayResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginStartReplay(StartReplayRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartReplayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartReplayResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartReplay operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartReplay.</param>
        /// 
        /// <returns>Returns a  StartReplayResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/StartReplay">REST API Reference for StartReplay Operation</seealso>
        public virtual StartReplayResponse EndStartReplay(IAsyncResult asyncResult)
        {
            return EndInvoke<StartReplayResponse>(asyncResult);
        }

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
        /// Tags don't have any semantic meaning to AWS and are interpreted strictly as strings
        /// of characters.
        /// </para>
        ///  
        /// <para>
        /// You can use the <code>TagResource</code> action with a resource that already has tags.
        /// If you specify a new tag key, this tag is appended to the list of tags associated
        /// with the resource. If you specify a tag key that is already associated with the resource,
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
        /// This rule was created by an AWS service on behalf of your account. It is managed by
        /// that service. If you see this error in response to <code>DeleteRule</code> or <code>RemoveTargets</code>,
        /// you can use the <code>Force</code> parameter in those calls to delete the rule or
        /// remove targets from the rule. You cannot modify these managed rules by using <code>DisableRule</code>,
        /// <code>EnableRule</code>, <code>PutTargets</code>, <code>PutRule</code>, <code>TagResource</code>,
        /// or <code>UntagResource</code>.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  TestEventPattern

        /// <summary>
        /// Tests whether the specified event pattern matches the provided event.
        /// 
        ///  
        /// <para>
        /// Most services in AWS treat : or / as the same character in Amazon Resource Names (ARNs).
        /// However, EventBridge uses an exact match in event patterns and rules. Be sure to use
        /// the correct ARN characters when creating event patterns so that they match the ARN
        /// syntax in the event you want to match.
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
        public virtual TestEventPatternResponse TestEventPattern(TestEventPatternRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TestEventPatternRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestEventPatternResponseUnmarshaller.Instance;

            return Invoke<TestEventPatternResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginTestEventPattern(TestEventPatternRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TestEventPatternRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestEventPatternResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TestEventPattern operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTestEventPattern.</param>
        /// 
        /// <returns>Returns a  TestEventPatternResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/TestEventPattern">REST API Reference for TestEventPattern Operation</seealso>
        public virtual TestEventPatternResponse EndTestEventPattern(IAsyncResult asyncResult)
        {
            return EndInvoke<TestEventPatternResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes one or more tags from the specified EventBridge resource. In Amazon EventBridge
        /// (CloudWatch Events, rules and event buses can be tagged.
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
        /// This rule was created by an AWS service on behalf of your account. It is managed by
        /// that service. If you see this error in response to <code>DeleteRule</code> or <code>RemoveTargets</code>,
        /// you can use the <code>Force</code> parameter in those calls to delete the rule or
        /// remove targets from the rule. You cannot modify these managed rules by using <code>DisableRule</code>,
        /// <code>EnableRule</code>, <code>PutTargets</code>, <code>PutRule</code>, <code>TagResource</code>,
        /// or <code>UntagResource</code>.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

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
        public virtual UpdateArchiveResponse UpdateArchive(UpdateArchiveRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateArchiveRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateArchiveResponseUnmarshaller.Instance;

            return Invoke<UpdateArchiveResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginUpdateArchive(UpdateArchiveRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateArchiveRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateArchiveResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateArchive operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateArchive.</param>
        /// 
        /// <returns>Returns a  UpdateArchiveResult from EventBridge.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/UpdateArchive">REST API Reference for UpdateArchive Operation</seealso>
        public virtual UpdateArchiveResponse EndUpdateArchive(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateArchiveResponse>(asyncResult);
        }

        #endregion
        
    }
}