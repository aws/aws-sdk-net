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
using Amazon.ConnectScheduling.Model;
using Amazon.ConnectScheduling.Model.Internal.MarshallTransformations;
using Amazon.ConnectScheduling.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570

namespace Amazon.ConnectScheduling
{
    /// <summary>
    /// <para>Implementation for accessing ConnectScheduling</para>
    /// <para>
    /// Service client instances are thread-safe and can be shared across multiple threads.
    /// For a given service configuration, it is recommended to reuse a client instance
    /// for the lifetime of your application.
    /// </para>
    ///
    /// <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_Operations_Amazon_Connect_Scheduling.html">Scheduling
    /// actions</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_Types_Amazon_Connect_Scheduling.html">Scheduling
    /// data types</a> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Use the Amazon Connect Scheduling API to work programmatically with Connect Customer
    /// forecasting, capacity planning, and scheduling, and to integrate these capabilities
    /// with your own systems. In the Connect Customer admin website, you use them to forecast
    /// contact volume, plan capacity, and create and manage agent schedules.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/forecasting-capacity-planning-scheduling.html">Forecasting
    /// &amp; agent scheduling</a> in the <i>Connect Customer Administrator Guide</i>.
    /// </para>
    /// </summary>
    public partial class AmazonConnectSchedulingClient : AmazonServiceClient, IAmazonConnectScheduling
    {
        private static IServiceMetadata serviceMetadata = new AmazonConnectSchedulingMetadata();
        /// <summary>
        /// Constructs AmazonConnectSchedulingClient with the credentials loaded from the application's
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
        public AmazonConnectSchedulingClient() : base(new AmazonConnectSchedulingConfig()) { }

        /// <summary>
        /// Constructs AmazonConnectSchedulingClient with the credentials loaded from the application's
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
        public AmazonConnectSchedulingClient(RegionEndpoint region) : base(new AmazonConnectSchedulingConfig { RegionEndpoint = region }) { }

        /// <summary>
        /// Constructs AmazonConnectSchedulingClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonConnectSchedulingClient Configuration Object</param>
        public AmazonConnectSchedulingClient(AmazonConnectSchedulingConfig config) : base(config) { }

        /// <summary>
        /// Constructs AmazonConnectSchedulingClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonConnectSchedulingClient(AWSCredentials credentials)
            : this(credentials, new AmazonConnectSchedulingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonConnectSchedulingClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonConnectSchedulingClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonConnectSchedulingConfig { RegionEndpoint = region })
        {
        }

        /// <summary>
        /// Constructs AmazonConnectSchedulingClient with AWS Credentials and an
        /// AmazonConnectSchedulingClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonConnectSchedulingClient Configuration Object</param>
        public AmazonConnectSchedulingClient(AWSCredentials credentials, AmazonConnectSchedulingConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonConnectSchedulingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonConnectSchedulingClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonConnectSchedulingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonConnectSchedulingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonConnectSchedulingClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonConnectSchedulingConfig { RegionEndpoint = region })
        {
        }

        /// <summary>
        /// Constructs AmazonConnectSchedulingClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonConnectSchedulingClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonConnectSchedulingClient Configuration Object</param>
        public AmazonConnectSchedulingClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonConnectSchedulingConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonConnectSchedulingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonConnectSchedulingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonConnectSchedulingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonConnectSchedulingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonConnectSchedulingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonConnectSchedulingConfig { RegionEndpoint = region })
        {
        }

        /// <summary>
        /// Constructs AmazonConnectSchedulingClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonConnectSchedulingClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonConnectSchedulingClient Configuration Object</param>
        public AmazonConnectSchedulingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonConnectSchedulingConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonConnectSchedulingEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonConnectSchedulingAuthSchemeHandler());
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
        /// Approves a time off request. Evaluates agent time off balances and group time off
        /// allowances before approving. <c>RuleFailureAction</c> controls what happens when these
        /// evaluations fail. The request is rejected with <c>CONFLICTING_TIME_OFF_REQUEST</c>
        /// if it overlaps another time off request for the user that is <c>APPROVED</c> or being
        /// approved.
        /// 
        ///  
        /// <para>
        /// The time off request is processed asynchronously, so a successful call doesn't indicate
        /// the final status. Read the resulting status with <c>GetTimeOff</c> or from the time
        /// off state-change events.
        /// </para>
        ///  
        /// <para>
        /// Approving an <c>APPROVED</c> request succeeds without a change. Approving a <c>REJECTED</c>
        /// request evaluates the rules again, so it can end <c>APPROVED</c> or <c>REJECTED</c>,
        /// and repeating the call can give a different result. Check the status with <c>GetTimeOff</c>
        /// before you retry.
        /// </para>
        ///  
        /// <para>
        /// Returns <c>ConflictException</c> if the request is <c>PENDING</c> or <c>CANCELLED</c>.
        /// <c>PENDING</c> means Connect Customer is still processing the request asynchronously.
        /// Wait until <c>GetTimeOff</c> returns a status other than <c>PENDING</c>, and then
        /// retry.
        /// </para>
        ///  <important> 
        /// <para>
        /// When the approval succeeds, Connect Customer cancels any overtime or voluntary time
        /// off activity that overlaps the approved window.
        /// </para>
        ///  </important> <note> 
        /// <para>
        /// Connect Customer doesn't check whether the principal that calls this operation supervises
        /// the user. The staffing group's approval settings also don't apply. IAM permissions
        /// are the only control. If you allow a principal to call this operation, that principal
        /// can send <c>RuleFailureAction</c> <c>OVERRIDE</c> and approve a request past failed
        /// rules. Grant permission for this operation only to principals that you trust to override
        /// time off rules.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ApproveTimeOff service method.</param>
        /// <returns>The response from the ApproveTimeOff service method, as returned by ConnectScheduling.</returns>
        /// <exception cref="Amazon.ConnectScheduling.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectScheduling.Model.ConflictException">
        /// The request could not be processed because of a conflict with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectScheduling.Model.InternalServerException">
        /// The request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectScheduling.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectScheduling.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectScheduling.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectscheduling-2026-07-16/ApproveTimeOff">REST API Reference for ApproveTimeOff Operation</seealso>
        public virtual ApproveTimeOffResponse ApproveTimeOff(ApproveTimeOffRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ApproveTimeOffRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ApproveTimeOffResponseUnmarshaller.Instance;

            return Invoke<ApproveTimeOffResponse>(request, options);
        }
#else
        internal virtual ApproveTimeOffResponse ApproveTimeOff(ApproveTimeOffRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ApproveTimeOffRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ApproveTimeOffResponseUnmarshaller.Instance;

            return Invoke<ApproveTimeOffResponse>(request, options);
        }
#endif

        /// <summary>
        /// Approves a time off request. Evaluates agent time off balances and group time off
        /// allowances before approving. <c>RuleFailureAction</c> controls what happens when these
        /// evaluations fail. The request is rejected with <c>CONFLICTING_TIME_OFF_REQUEST</c>
        /// if it overlaps another time off request for the user that is <c>APPROVED</c> or being
        /// approved.
        /// 
        ///  
        /// <para>
        /// The time off request is processed asynchronously, so a successful call doesn't indicate
        /// the final status. Read the resulting status with <c>GetTimeOff</c> or from the time
        /// off state-change events.
        /// </para>
        ///  
        /// <para>
        /// Approving an <c>APPROVED</c> request succeeds without a change. Approving a <c>REJECTED</c>
        /// request evaluates the rules again, so it can end <c>APPROVED</c> or <c>REJECTED</c>,
        /// and repeating the call can give a different result. Check the status with <c>GetTimeOff</c>
        /// before you retry.
        /// </para>
        ///  
        /// <para>
        /// Returns <c>ConflictException</c> if the request is <c>PENDING</c> or <c>CANCELLED</c>.
        /// <c>PENDING</c> means Connect Customer is still processing the request asynchronously.
        /// Wait until <c>GetTimeOff</c> returns a status other than <c>PENDING</c>, and then
        /// retry.
        /// </para>
        ///  <important> 
        /// <para>
        /// When the approval succeeds, Connect Customer cancels any overtime or voluntary time
        /// off activity that overlaps the approved window.
        /// </para>
        ///  </important> <note> 
        /// <para>
        /// Connect Customer doesn't check whether the principal that calls this operation supervises
        /// the user. The staffing group's approval settings also don't apply. IAM permissions
        /// are the only control. If you allow a principal to call this operation, that principal
        /// can send <c>RuleFailureAction</c> <c>OVERRIDE</c> and approve a request past failed
        /// rules. Grant permission for this operation only to principals that you trust to override
        /// time off rules.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ApproveTimeOff service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ApproveTimeOff service method, as returned by ConnectScheduling.</returns>
        /// <exception cref="Amazon.ConnectScheduling.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectScheduling.Model.ConflictException">
        /// The request could not be processed because of a conflict with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectScheduling.Model.InternalServerException">
        /// The request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectScheduling.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectScheduling.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectScheduling.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectscheduling-2026-07-16/ApproveTimeOff">REST API Reference for ApproveTimeOff Operation</seealso>
        public virtual Task<ApproveTimeOffResponse> ApproveTimeOffAsync(ApproveTimeOffRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ApproveTimeOffRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ApproveTimeOffResponseUnmarshaller.Instance;

            return InvokeAsync<ApproveTimeOffResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Cancels a time off request.
        /// 
        ///  
        /// <para>
        /// Cancelling a <c>CANCELLED</c> request succeeds without a change. Returns <c>ConflictException</c>
        /// if the request is <c>PENDING</c>, which means Connect Customer is still processing
        /// the request asynchronously. Wait until <c>GetTimeOff</c> returns a status other than
        /// <c>PENDING</c>, and then retry.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelTimeOff service method.</param>
        /// <returns>The response from the CancelTimeOff service method, as returned by ConnectScheduling.</returns>
        /// <exception cref="Amazon.ConnectScheduling.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectScheduling.Model.ConflictException">
        /// The request could not be processed because of a conflict with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectScheduling.Model.InternalServerException">
        /// The request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectScheduling.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectScheduling.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectScheduling.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectscheduling-2026-07-16/CancelTimeOff">REST API Reference for CancelTimeOff Operation</seealso>
        public virtual CancelTimeOffResponse CancelTimeOff(CancelTimeOffRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelTimeOffRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelTimeOffResponseUnmarshaller.Instance;

            return Invoke<CancelTimeOffResponse>(request, options);
        }
#else
        internal virtual CancelTimeOffResponse CancelTimeOff(CancelTimeOffRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelTimeOffRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelTimeOffResponseUnmarshaller.Instance;

            return Invoke<CancelTimeOffResponse>(request, options);
        }
#endif

        /// <summary>
        /// Cancels a time off request.
        /// 
        ///  
        /// <para>
        /// Cancelling a <c>CANCELLED</c> request succeeds without a change. Returns <c>ConflictException</c>
        /// if the request is <c>PENDING</c>, which means Connect Customer is still processing
        /// the request asynchronously. Wait until <c>GetTimeOff</c> returns a status other than
        /// <c>PENDING</c>, and then retry.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelTimeOff service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CancelTimeOff service method, as returned by ConnectScheduling.</returns>
        /// <exception cref="Amazon.ConnectScheduling.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectScheduling.Model.ConflictException">
        /// The request could not be processed because of a conflict with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectScheduling.Model.InternalServerException">
        /// The request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectScheduling.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectScheduling.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectScheduling.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectscheduling-2026-07-16/CancelTimeOff">REST API Reference for CancelTimeOff Operation</seealso>
        public virtual Task<CancelTimeOffResponse> CancelTimeOffAsync(CancelTimeOffRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelTimeOffRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelTimeOffResponseUnmarshaller.Instance;

            return InvokeAsync<CancelTimeOffResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Creates a time off request for a user. You don't provide a status, because Connect
        /// Customer owns the request lifecycle. To get the decided status, call <c>GetTimeOff</c>
        /// or use the time off state-change events.
        /// 
        ///  
        /// <para>
        ///  <c>ApprovalType</c> controls who approves the request. You can specify one of the
        /// following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AWAIT_APPROVAL</c>: the request waits in <c>AWAITING_APPROVAL</c> until you call
        /// <c>ApproveTimeOff</c> or <c>RejectTimeOff</c>. Rule evaluation and the overlap check
        /// run at approval, not at creation. A waiting request doesn't reserve its window, so
        /// another request for the same window can be approved first.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AUTOMATIC</c>: Connect Customer evaluates the rules (time off balances and group
        /// allowances) and decides the request. The request can be <c>PENDING</c> while Connect
        /// Customer decides, and then ends <c>APPROVED</c> or <c>REJECTED</c>. If it overlaps
        /// another time off request for the user, the requested time off ends <c>REJECTED</c>
        /// with <c>CONFLICTING_TIME_OFF_REQUEST</c>. It also ends <c>REJECTED</c> if it overlaps
        /// overtime or voluntary time off. If the whole window is in the past, Connect Customer
        /// records failed rules as <c>WARNING</c> and doesn't reject the request, whatever the
        /// <c>RuleFailureAction</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The staffing group's <i>Supervisor approval needed</i> setting doesn't apply to this
        /// operation. <c>ApprovalType</c> alone decides whether the request waits for approval.
        /// The operation fails with <c>ValidationException</c> on <c>UserId</c> in the following
        /// cases:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The user isn't in a staffing group, or the staffing group isn't associated with a
        /// forecast group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Time off isn't <a href="https://docs.aws.amazon.com/connect/latest/adminguide/enable-to.html">enabled</a>
        /// for the user's staffing group, or the user's staff rules don't allow time off.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To change the dates of a request, cancel it with <c>CancelTimeOff</c> and create a
        /// new request. The new request has a new <c>TimeOffId</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Connect Customer doesn't check whether the principal that calls this operation supervises
        /// the user. The staffing group's approval settings also don't apply. IAM permissions
        /// are the only control. If you allow a principal to call this operation, that principal
        /// can send <c>ApprovalType</c> <c>AUTOMATIC</c> with <c>RuleFailureAction</c> <c>OVERRIDE</c>
        /// and approve a request past failed rules. Grant permission for this operation only
        /// to principals that you trust to override time off rules.
        /// </para>
        ///  </note> 
        /// <para>
        /// For information about time off in the Connect Customer admin website, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/scheduling-time-off.html">Time
        /// off management</a> in the <i>Connect Customer Administrator Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTimeOff service method.</param>
        /// <returns>The response from the CreateTimeOff service method, as returned by ConnectScheduling.</returns>
        /// <exception cref="Amazon.ConnectScheduling.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectScheduling.Model.ConflictException">
        /// The request could not be processed because of a conflict with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectScheduling.Model.InternalServerException">
        /// The request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectScheduling.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectScheduling.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.ConnectScheduling.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectScheduling.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectscheduling-2026-07-16/CreateTimeOff">REST API Reference for CreateTimeOff Operation</seealso>
        public virtual CreateTimeOffResponse CreateTimeOff(CreateTimeOffRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTimeOffRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTimeOffResponseUnmarshaller.Instance;

            return Invoke<CreateTimeOffResponse>(request, options);
        }
#else
        internal virtual CreateTimeOffResponse CreateTimeOff(CreateTimeOffRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTimeOffRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTimeOffResponseUnmarshaller.Instance;

            return Invoke<CreateTimeOffResponse>(request, options);
        }
#endif

        /// <summary>
        /// Creates a time off request for a user. You don't provide a status, because Connect
        /// Customer owns the request lifecycle. To get the decided status, call <c>GetTimeOff</c>
        /// or use the time off state-change events.
        /// 
        ///  
        /// <para>
        ///  <c>ApprovalType</c> controls who approves the request. You can specify one of the
        /// following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AWAIT_APPROVAL</c>: the request waits in <c>AWAITING_APPROVAL</c> until you call
        /// <c>ApproveTimeOff</c> or <c>RejectTimeOff</c>. Rule evaluation and the overlap check
        /// run at approval, not at creation. A waiting request doesn't reserve its window, so
        /// another request for the same window can be approved first.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AUTOMATIC</c>: Connect Customer evaluates the rules (time off balances and group
        /// allowances) and decides the request. The request can be <c>PENDING</c> while Connect
        /// Customer decides, and then ends <c>APPROVED</c> or <c>REJECTED</c>. If it overlaps
        /// another time off request for the user, the requested time off ends <c>REJECTED</c>
        /// with <c>CONFLICTING_TIME_OFF_REQUEST</c>. It also ends <c>REJECTED</c> if it overlaps
        /// overtime or voluntary time off. If the whole window is in the past, Connect Customer
        /// records failed rules as <c>WARNING</c> and doesn't reject the request, whatever the
        /// <c>RuleFailureAction</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The staffing group's <i>Supervisor approval needed</i> setting doesn't apply to this
        /// operation. <c>ApprovalType</c> alone decides whether the request waits for approval.
        /// The operation fails with <c>ValidationException</c> on <c>UserId</c> in the following
        /// cases:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The user isn't in a staffing group, or the staffing group isn't associated with a
        /// forecast group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Time off isn't <a href="https://docs.aws.amazon.com/connect/latest/adminguide/enable-to.html">enabled</a>
        /// for the user's staffing group, or the user's staff rules don't allow time off.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To change the dates of a request, cancel it with <c>CancelTimeOff</c> and create a
        /// new request. The new request has a new <c>TimeOffId</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Connect Customer doesn't check whether the principal that calls this operation supervises
        /// the user. The staffing group's approval settings also don't apply. IAM permissions
        /// are the only control. If you allow a principal to call this operation, that principal
        /// can send <c>ApprovalType</c> <c>AUTOMATIC</c> with <c>RuleFailureAction</c> <c>OVERRIDE</c>
        /// and approve a request past failed rules. Grant permission for this operation only
        /// to principals that you trust to override time off rules.
        /// </para>
        ///  </note> 
        /// <para>
        /// For information about time off in the Connect Customer admin website, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/scheduling-time-off.html">Time
        /// off management</a> in the <i>Connect Customer Administrator Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTimeOff service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateTimeOff service method, as returned by ConnectScheduling.</returns>
        /// <exception cref="Amazon.ConnectScheduling.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectScheduling.Model.ConflictException">
        /// The request could not be processed because of a conflict with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectScheduling.Model.InternalServerException">
        /// The request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectScheduling.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectScheduling.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.ConnectScheduling.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectScheduling.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectscheduling-2026-07-16/CreateTimeOff">REST API Reference for CreateTimeOff Operation</seealso>
        public virtual Task<CreateTimeOffResponse> CreateTimeOffAsync(CreateTimeOffRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTimeOffRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTimeOffResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTimeOffResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Returns a time off request, including its current status and validation results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTimeOff service method.</param>
        /// <returns>The response from the GetTimeOff service method, as returned by ConnectScheduling.</returns>
        /// <exception cref="Amazon.ConnectScheduling.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectScheduling.Model.InternalServerException">
        /// The request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectScheduling.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectScheduling.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectScheduling.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectscheduling-2026-07-16/GetTimeOff">REST API Reference for GetTimeOff Operation</seealso>
        public virtual GetTimeOffResponse GetTimeOff(GetTimeOffRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTimeOffRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTimeOffResponseUnmarshaller.Instance;

            return Invoke<GetTimeOffResponse>(request, options);
        }
#else
        internal virtual GetTimeOffResponse GetTimeOff(GetTimeOffRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTimeOffRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTimeOffResponseUnmarshaller.Instance;

            return Invoke<GetTimeOffResponse>(request, options);
        }
#endif

        /// <summary>
        /// Returns a time off request, including its current status and validation results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTimeOff service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetTimeOff service method, as returned by ConnectScheduling.</returns>
        /// <exception cref="Amazon.ConnectScheduling.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectScheduling.Model.InternalServerException">
        /// The request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectScheduling.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectScheduling.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectScheduling.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectscheduling-2026-07-16/GetTimeOff">REST API Reference for GetTimeOff Operation</seealso>
        public virtual Task<GetTimeOffResponse> GetTimeOffAsync(GetTimeOffRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTimeOffRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTimeOffResponseUnmarshaller.Instance;

            return InvokeAsync<GetTimeOffResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Sets the time off balance for one user and shift activity. The value replaces the
        /// existing balance rather than adjusting it, so you can safely retry the call. This
        /// operation can't remove a balance. To remove one, upload a blank balance in the Connect
        /// Customer admin website. For more information, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/upload-timeoff-balance.html">Import
        /// an agent's time off balance</a> in the <i>Connect Customer Administrator Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutTimeOffBalance service method.</param>
        /// <returns>The response from the PutTimeOffBalance service method, as returned by ConnectScheduling.</returns>
        /// <exception cref="Amazon.ConnectScheduling.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectScheduling.Model.ConflictException">
        /// The request could not be processed because of a conflict with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectScheduling.Model.InternalServerException">
        /// The request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectScheduling.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectScheduling.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectScheduling.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectscheduling-2026-07-16/PutTimeOffBalance">REST API Reference for PutTimeOffBalance Operation</seealso>
        public virtual PutTimeOffBalanceResponse PutTimeOffBalance(PutTimeOffBalanceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutTimeOffBalanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutTimeOffBalanceResponseUnmarshaller.Instance;

            return Invoke<PutTimeOffBalanceResponse>(request, options);
        }
#else
        internal virtual PutTimeOffBalanceResponse PutTimeOffBalance(PutTimeOffBalanceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutTimeOffBalanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutTimeOffBalanceResponseUnmarshaller.Instance;

            return Invoke<PutTimeOffBalanceResponse>(request, options);
        }
#endif

        /// <summary>
        /// Sets the time off balance for one user and shift activity. The value replaces the
        /// existing balance rather than adjusting it, so you can safely retry the call. This
        /// operation can't remove a balance. To remove one, upload a blank balance in the Connect
        /// Customer admin website. For more information, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/upload-timeoff-balance.html">Import
        /// an agent's time off balance</a> in the <i>Connect Customer Administrator Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutTimeOffBalance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the PutTimeOffBalance service method, as returned by ConnectScheduling.</returns>
        /// <exception cref="Amazon.ConnectScheduling.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectScheduling.Model.ConflictException">
        /// The request could not be processed because of a conflict with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectScheduling.Model.InternalServerException">
        /// The request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectScheduling.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectScheduling.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectScheduling.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectscheduling-2026-07-16/PutTimeOffBalance">REST API Reference for PutTimeOffBalance Operation</seealso>
        public virtual Task<PutTimeOffBalanceResponse> PutTimeOffBalanceAsync(PutTimeOffBalanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutTimeOffBalanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutTimeOffBalanceResponseUnmarshaller.Instance;

            return InvokeAsync<PutTimeOffBalanceResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Rejects a time off request.
        /// 
        ///  
        /// <para>
        /// Rejecting a <c>REJECTED</c> request succeeds without a change. Returns <c>ConflictException</c>
        /// if the request is <c>PENDING</c> or <c>CANCELLED</c>. <c>PENDING</c> means Connect
        /// Customer is still processing the request asynchronously. Wait until <c>GetTimeOff</c>
        /// returns a status other than <c>PENDING</c>, and then retry.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectTimeOff service method.</param>
        /// <returns>The response from the RejectTimeOff service method, as returned by ConnectScheduling.</returns>
        /// <exception cref="Amazon.ConnectScheduling.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectScheduling.Model.ConflictException">
        /// The request could not be processed because of a conflict with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectScheduling.Model.InternalServerException">
        /// The request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectScheduling.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectScheduling.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectScheduling.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectscheduling-2026-07-16/RejectTimeOff">REST API Reference for RejectTimeOff Operation</seealso>
        public virtual RejectTimeOffResponse RejectTimeOff(RejectTimeOffRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RejectTimeOffRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectTimeOffResponseUnmarshaller.Instance;

            return Invoke<RejectTimeOffResponse>(request, options);
        }
#else
        internal virtual RejectTimeOffResponse RejectTimeOff(RejectTimeOffRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RejectTimeOffRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectTimeOffResponseUnmarshaller.Instance;

            return Invoke<RejectTimeOffResponse>(request, options);
        }
#endif

        /// <summary>
        /// Rejects a time off request.
        /// 
        ///  
        /// <para>
        /// Rejecting a <c>REJECTED</c> request succeeds without a change. Returns <c>ConflictException</c>
        /// if the request is <c>PENDING</c> or <c>CANCELLED</c>. <c>PENDING</c> means Connect
        /// Customer is still processing the request asynchronously. Wait until <c>GetTimeOff</c>
        /// returns a status other than <c>PENDING</c>, and then retry.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectTimeOff service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the RejectTimeOff service method, as returned by ConnectScheduling.</returns>
        /// <exception cref="Amazon.ConnectScheduling.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectScheduling.Model.ConflictException">
        /// The request could not be processed because of a conflict with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectScheduling.Model.InternalServerException">
        /// The request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectScheduling.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectScheduling.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectScheduling.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectscheduling-2026-07-16/RejectTimeOff">REST API Reference for RejectTimeOff Operation</seealso>
        public virtual Task<RejectTimeOffResponse> RejectTimeOffAsync(RejectTimeOffRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RejectTimeOffRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectTimeOffResponseUnmarshaller.Instance;

            return InvokeAsync<RejectTimeOffResponse>(request, options, cancellationToken);
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
