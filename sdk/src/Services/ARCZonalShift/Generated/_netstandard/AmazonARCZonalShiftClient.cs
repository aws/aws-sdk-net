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
 * Do not modify this file. This file is generated from the arc-zonal-shift-2022-10-30.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.ARCZonalShift.Model;
using Amazon.ARCZonalShift.Model.Internal.MarshallTransformations;
using Amazon.ARCZonalShift.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.ARCZonalShift
{
    /// <summary>
    /// <para>Implementation for accessing ARCZonalShift</para>
    ///
    /// Welcome to the API Reference Guide for zonal shift and zonal autoshift in Amazon Application
    /// Recovery Controller (ARC).
    /// 
    ///  
    /// <para>
    /// You can start a zonal shift to move traffic for a load balancer resource away from
    /// an Availability Zone to help your application recover quickly from an impairment in
    /// an Availability Zone. For example, you can recover your application from a developer's
    /// bad code deployment or from an Amazon Web Services infrastructure failure in a single
    /// Availability Zone.
    /// </para>
    ///  
    /// <para>
    /// You can also configure zonal autoshift for supported load balancer resources. Zonal
    /// autoshift is a capability in ARC where you authorize Amazon Web Services to shift
    /// away application resource traffic from an Availability Zone during events, on your
    /// behalf, to help reduce your time to recovery. Amazon Web Services starts an autoshift
    /// when internal telemetry indicates that there is an Availability Zone impairment that
    /// could potentially impact customers.
    /// </para>
    ///  
    /// <para>
    /// For more information about using zonal shift and zonal autoshift, see the <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/what-is-route53-recovery.html">Amazon
    /// Application Recovery Controller Developer Guide</a>.
    /// </para>
    /// </summary>
    public partial class AmazonARCZonalShiftClient : AmazonServiceClient, IAmazonARCZonalShift
    {
        private static IServiceMetadata serviceMetadata = new AmazonARCZonalShiftMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonARCZonalShiftClient with the credentials loaded from the application's
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
        public AmazonARCZonalShiftClient()
            : base(new AmazonARCZonalShiftConfig()) { }

        /// <summary>
        /// Constructs AmazonARCZonalShiftClient with the credentials loaded from the application's
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
        public AmazonARCZonalShiftClient(RegionEndpoint region)
            : base(new AmazonARCZonalShiftConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonARCZonalShiftClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonARCZonalShiftClient Configuration Object</param>
        public AmazonARCZonalShiftClient(AmazonARCZonalShiftConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonARCZonalShiftClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonARCZonalShiftClient(AWSCredentials credentials)
            : this(credentials, new AmazonARCZonalShiftConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonARCZonalShiftClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonARCZonalShiftClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonARCZonalShiftConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonARCZonalShiftClient with AWS Credentials and an
        /// AmazonARCZonalShiftClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonARCZonalShiftClient Configuration Object</param>
        public AmazonARCZonalShiftClient(AWSCredentials credentials, AmazonARCZonalShiftConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonARCZonalShiftClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonARCZonalShiftClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonARCZonalShiftConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonARCZonalShiftClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonARCZonalShiftClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonARCZonalShiftConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonARCZonalShiftClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonARCZonalShiftClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonARCZonalShiftClient Configuration Object</param>
        public AmazonARCZonalShiftClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonARCZonalShiftConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonARCZonalShiftClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonARCZonalShiftClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonARCZonalShiftConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonARCZonalShiftClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonARCZonalShiftClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonARCZonalShiftConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonARCZonalShiftClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonARCZonalShiftClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonARCZonalShiftClient Configuration Object</param>
        public AmazonARCZonalShiftClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonARCZonalShiftConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IARCZonalShiftPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IARCZonalShiftPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new ARCZonalShiftPaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonARCZonalShiftEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonARCZonalShiftAuthSchemeHandler());
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


        #region  CancelPracticeRun

        internal virtual CancelPracticeRunResponse CancelPracticeRun(CancelPracticeRunRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelPracticeRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelPracticeRunResponseUnmarshaller.Instance;

            return Invoke<CancelPracticeRunResponse>(request, options);
        }



        /// <summary>
        /// Cancel an in-progress practice run zonal shift in Amazon Application Recovery Controller.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelPracticeRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelPracticeRun service method, as returned by ARCZonalShift.</returns>
        /// <exception cref="Amazon.ARCZonalShift.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ResourceNotFoundException">
        /// The input requested a resource that was not found.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/CancelPracticeRun">REST API Reference for CancelPracticeRun Operation</seealso>
        public virtual Task<CancelPracticeRunResponse> CancelPracticeRunAsync(CancelPracticeRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelPracticeRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelPracticeRunResponseUnmarshaller.Instance;

            return InvokeAsync<CancelPracticeRunResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CancelZonalShift

        internal virtual CancelZonalShiftResponse CancelZonalShift(CancelZonalShiftRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelZonalShiftRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelZonalShiftResponseUnmarshaller.Instance;

            return Invoke<CancelZonalShiftResponse>(request, options);
        }



        /// <summary>
        /// Cancel a zonal shift in Amazon Application Recovery Controller. To cancel the zonal
        /// shift, specify the zonal shift ID.
        /// 
        ///  
        /// <para>
        /// A zonal shift can be one that you've started for a resource in your Amazon Web Services
        /// account in an Amazon Web Services Region, or it can be a zonal shift started by a
        /// practice run with zonal autoshift. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelZonalShift service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelZonalShift service method, as returned by ARCZonalShift.</returns>
        /// <exception cref="Amazon.ARCZonalShift.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ResourceNotFoundException">
        /// The input requested a resource that was not found.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/CancelZonalShift">REST API Reference for CancelZonalShift Operation</seealso>
        public virtual Task<CancelZonalShiftResponse> CancelZonalShiftAsync(CancelZonalShiftRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelZonalShiftRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelZonalShiftResponseUnmarshaller.Instance;

            return InvokeAsync<CancelZonalShiftResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreatePracticeRunConfiguration

        internal virtual CreatePracticeRunConfigurationResponse CreatePracticeRunConfiguration(CreatePracticeRunConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePracticeRunConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePracticeRunConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreatePracticeRunConfigurationResponse>(request, options);
        }



        /// <summary>
        /// A practice run configuration for zonal autoshift is required when you enable zonal
        /// autoshift. A practice run configuration includes specifications for blocked dates
        /// and blocked time windows, and for Amazon CloudWatch alarms that you create to use
        /// with practice runs. The alarms that you specify are an <i>outcome alarm</i>, to monitor
        /// application health during practice runs and, optionally, a <i>blocking alarm</i>,
        /// to block practice runs from starting.
        /// 
        ///  
        /// <para>
        /// When a resource has a practice run configuration, ARC starts zonal shifts for the
        /// resource weekly, to shift traffic for practice runs. Practice runs help you to ensure
        /// that shifting away traffic from an Availability Zone during an autoshift is safe for
        /// your application.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/arc-zonal-autoshift.considerations.html">
        /// Considerations when you configure zonal autoshift</a> in the Amazon Application Recovery
        /// Controller Developer Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePracticeRunConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePracticeRunConfiguration service method, as returned by ARCZonalShift.</returns>
        /// <exception cref="Amazon.ARCZonalShift.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ResourceNotFoundException">
        /// The input requested a resource that was not found.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/CreatePracticeRunConfiguration">REST API Reference for CreatePracticeRunConfiguration Operation</seealso>
        public virtual Task<CreatePracticeRunConfigurationResponse> CreatePracticeRunConfigurationAsync(CreatePracticeRunConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePracticeRunConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePracticeRunConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePracticeRunConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeletePracticeRunConfiguration

        internal virtual DeletePracticeRunConfigurationResponse DeletePracticeRunConfiguration(DeletePracticeRunConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePracticeRunConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePracticeRunConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeletePracticeRunConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Deletes the practice run configuration for a resource. Before you can delete a practice
        /// run configuration for a resource., you must disable zonal autoshift for the resource.
        /// Practice runs must be configured for zonal autoshift to be enabled.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePracticeRunConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePracticeRunConfiguration service method, as returned by ARCZonalShift.</returns>
        /// <exception cref="Amazon.ARCZonalShift.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ResourceNotFoundException">
        /// The input requested a resource that was not found.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/DeletePracticeRunConfiguration">REST API Reference for DeletePracticeRunConfiguration Operation</seealso>
        public virtual Task<DeletePracticeRunConfigurationResponse> DeletePracticeRunConfigurationAsync(DeletePracticeRunConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePracticeRunConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePracticeRunConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePracticeRunConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetAutoshiftObserverNotificationStatus

        internal virtual GetAutoshiftObserverNotificationStatusResponse GetAutoshiftObserverNotificationStatus(GetAutoshiftObserverNotificationStatusRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAutoshiftObserverNotificationStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAutoshiftObserverNotificationStatusResponseUnmarshaller.Instance;

            return Invoke<GetAutoshiftObserverNotificationStatusResponse>(request, options);
        }



        /// <summary>
        /// Returns the status of the autoshift observer notification. Autoshift observer notifications
        /// notify you through Amazon EventBridge when there is an autoshift event for zonal autoshift.
        /// The status can be <c>ENABLED</c> or <c>DISABLED</c>. When <c>ENABLED</c>, a notification
        /// is sent when an autoshift is triggered. When <c>DISABLED</c>, notifications are not
        /// sent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAutoshiftObserverNotificationStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAutoshiftObserverNotificationStatus service method, as returned by ARCZonalShift.</returns>
        /// <exception cref="Amazon.ARCZonalShift.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/GetAutoshiftObserverNotificationStatus">REST API Reference for GetAutoshiftObserverNotificationStatus Operation</seealso>
        public virtual Task<GetAutoshiftObserverNotificationStatusResponse> GetAutoshiftObserverNotificationStatusAsync(GetAutoshiftObserverNotificationStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAutoshiftObserverNotificationStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAutoshiftObserverNotificationStatusResponseUnmarshaller.Instance;

            return InvokeAsync<GetAutoshiftObserverNotificationStatusResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetManagedResource

        internal virtual GetManagedResourceResponse GetManagedResource(GetManagedResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetManagedResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetManagedResourceResponseUnmarshaller.Instance;

            return Invoke<GetManagedResourceResponse>(request, options);
        }



        /// <summary>
        /// Get information about a resource that's been registered for zonal shifts with Amazon
        /// Application Recovery Controller in this Amazon Web Services Region. Resources that
        /// are registered for zonal shifts are managed resources in ARC. You can start zonal
        /// shifts and configure zonal autoshift for managed resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetManagedResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetManagedResource service method, as returned by ARCZonalShift.</returns>
        /// <exception cref="Amazon.ARCZonalShift.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ResourceNotFoundException">
        /// The input requested a resource that was not found.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/GetManagedResource">REST API Reference for GetManagedResource Operation</seealso>
        public virtual Task<GetManagedResourceResponse> GetManagedResourceAsync(GetManagedResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetManagedResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetManagedResourceResponseUnmarshaller.Instance;

            return InvokeAsync<GetManagedResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListAutoshifts

        internal virtual ListAutoshiftsResponse ListAutoshifts(ListAutoshiftsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAutoshiftsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAutoshiftsResponseUnmarshaller.Instance;

            return Invoke<ListAutoshiftsResponse>(request, options);
        }



        /// <summary>
        /// Returns the autoshifts for an Amazon Web Services Region. By default, the call returns
        /// only <c>ACTIVE</c> autoshifts. Optionally, you can specify the <c>status</c> parameter
        /// to return <c>COMPLETED</c> autoshifts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAutoshifts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAutoshifts service method, as returned by ARCZonalShift.</returns>
        /// <exception cref="Amazon.ARCZonalShift.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/ListAutoshifts">REST API Reference for ListAutoshifts Operation</seealso>
        public virtual Task<ListAutoshiftsResponse> ListAutoshiftsAsync(ListAutoshiftsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAutoshiftsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAutoshiftsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAutoshiftsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListManagedResources

        internal virtual ListManagedResourcesResponse ListManagedResources(ListManagedResourcesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListManagedResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListManagedResourcesResponseUnmarshaller.Instance;

            return Invoke<ListManagedResourcesResponse>(request, options);
        }



        /// <summary>
        /// Lists all the resources in your Amazon Web Services account in this Amazon Web Services
        /// Region that are managed for zonal shifts in Amazon Application Recovery Controller,
        /// and information about them. The information includes the zonal autoshift status for
        /// the resource, as well as the Amazon Resource Name (ARN), the Availability Zones that
        /// each resource is deployed in, and the resource name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListManagedResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListManagedResources service method, as returned by ARCZonalShift.</returns>
        /// <exception cref="Amazon.ARCZonalShift.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/ListManagedResources">REST API Reference for ListManagedResources Operation</seealso>
        public virtual Task<ListManagedResourcesResponse> ListManagedResourcesAsync(ListManagedResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListManagedResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListManagedResourcesResponseUnmarshaller.Instance;

            return InvokeAsync<ListManagedResourcesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListZonalShifts

        internal virtual ListZonalShiftsResponse ListZonalShifts(ListZonalShiftsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListZonalShiftsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListZonalShiftsResponseUnmarshaller.Instance;

            return Invoke<ListZonalShiftsResponse>(request, options);
        }



        /// <summary>
        /// Lists all active and completed zonal shifts in Amazon Application Recovery Controller
        /// in your Amazon Web Services account in this Amazon Web Services Region. <c>ListZonalShifts</c>
        /// returns customer-initiated zonal shifts, as well as practice run zonal shifts that
        /// ARC started on your behalf for zonal autoshift.
        /// 
        ///  
        /// <para>
        /// For more information about listing autoshifts, see <a href="https://docs.aws.amazon.com/arc-zonal-shift/latest/api/API_ListAutoshifts.html">"&gt;ListAutoshifts</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListZonalShifts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListZonalShifts service method, as returned by ARCZonalShift.</returns>
        /// <exception cref="Amazon.ARCZonalShift.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/ListZonalShifts">REST API Reference for ListZonalShifts Operation</seealso>
        public virtual Task<ListZonalShiftsResponse> ListZonalShiftsAsync(ListZonalShiftsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListZonalShiftsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListZonalShiftsResponseUnmarshaller.Instance;

            return InvokeAsync<ListZonalShiftsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartPracticeRun

        internal virtual StartPracticeRunResponse StartPracticeRun(StartPracticeRunRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartPracticeRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartPracticeRunResponseUnmarshaller.Instance;

            return Invoke<StartPracticeRunResponse>(request, options);
        }



        /// <summary>
        /// Start an on-demand practice run zonal shift in Amazon Application Recovery Controller.
        /// With zonal autoshift enabled, you can start an on-demand practice run to verify preparedness
        /// at any time. Amazon Web Services also runs automated practice runs about weekly when
        /// you have enabled zonal autoshift.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/arc-zonal-autoshift.considerations.html">
        /// Considerations when you configure zonal autoshift</a> in the Amazon Application Recovery
        /// Controller Developer Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartPracticeRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartPracticeRun service method, as returned by ARCZonalShift.</returns>
        /// <exception cref="Amazon.ARCZonalShift.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ResourceNotFoundException">
        /// The input requested a resource that was not found.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/StartPracticeRun">REST API Reference for StartPracticeRun Operation</seealso>
        public virtual Task<StartPracticeRunResponse> StartPracticeRunAsync(StartPracticeRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartPracticeRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartPracticeRunResponseUnmarshaller.Instance;

            return InvokeAsync<StartPracticeRunResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartZonalShift

        internal virtual StartZonalShiftResponse StartZonalShift(StartZonalShiftRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartZonalShiftRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartZonalShiftResponseUnmarshaller.Instance;

            return Invoke<StartZonalShiftResponse>(request, options);
        }



        /// <summary>
        /// You start a zonal shift to temporarily move load balancer traffic away from an Availability
        /// Zone in an Amazon Web Services Region, to help your application recover immediately,
        /// for example, from a developer's bad code deployment or from an Amazon Web Services
        /// infrastructure failure in a single Availability Zone. You can start a zonal shift
        /// in ARC only for managed resources in your Amazon Web Services account in an Amazon
        /// Web Services Region. Resources are automatically registered with ARC by Amazon Web
        /// Services services.
        /// 
        ///  
        /// <para>
        /// Amazon Application Recovery Controller currently supports enabling the following resources
        /// for zonal shift and zonal autoshift:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/arc-zonal-shift.resource-types.ec2-auto-scaling-groups.html">Amazon
        /// EC2 Auto Scaling groups</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/arc-zonal-shift.resource-types.eks.html">Amazon
        /// Elastic Kubernetes Service</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/arc-zonal-shift.resource-types.app-load-balancers.html">Application
        /// Load Balancer</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/arc-zonal-shift.resource-types.network-load-balancers.html">Network
        /// Load Balancer</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When you start a zonal shift, traffic for the resource is no longer routed to the
        /// Availability Zone. The zonal shift is created immediately in ARC. However, it can
        /// take a short time, typically up to a few minutes, for existing, in-progress connections
        /// in the Availability Zone to complete.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/arc-zonal-shift.html">Zonal
        /// shift</a> in the Amazon Application Recovery Controller Developer Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartZonalShift service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartZonalShift service method, as returned by ARCZonalShift.</returns>
        /// <exception cref="Amazon.ARCZonalShift.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ResourceNotFoundException">
        /// The input requested a resource that was not found.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/StartZonalShift">REST API Reference for StartZonalShift Operation</seealso>
        public virtual Task<StartZonalShiftResponse> StartZonalShiftAsync(StartZonalShiftRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartZonalShiftRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartZonalShiftResponseUnmarshaller.Instance;

            return InvokeAsync<StartZonalShiftResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateAutoshiftObserverNotificationStatus

        internal virtual UpdateAutoshiftObserverNotificationStatusResponse UpdateAutoshiftObserverNotificationStatus(UpdateAutoshiftObserverNotificationStatusRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAutoshiftObserverNotificationStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAutoshiftObserverNotificationStatusResponseUnmarshaller.Instance;

            return Invoke<UpdateAutoshiftObserverNotificationStatusResponse>(request, options);
        }



        /// <summary>
        /// Update the status of autoshift observer notification. Autoshift observer notification
        /// enables you to be notified, through Amazon EventBridge, when there is an autoshift
        /// event for zonal autoshift.
        /// 
        ///  
        /// <para>
        /// If the status is <c>ENABLED</c>, ARC includes all autoshift events when you use the
        /// EventBridge pattern <c>Autoshift In Progress</c>. When the status is <c>DISABLED</c>,
        /// ARC includes only autoshift events for autoshifts when one or more of your resources
        /// is included in the autoshift.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/arc-zonal-autoshift.how-it-works.html#ZAShiftNotification">
        /// Notifications for practice runs and autoshifts</a> in the Amazon Application Recovery
        /// Controller Developer Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAutoshiftObserverNotificationStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAutoshiftObserverNotificationStatus service method, as returned by ARCZonalShift.</returns>
        /// <exception cref="Amazon.ARCZonalShift.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/UpdateAutoshiftObserverNotificationStatus">REST API Reference for UpdateAutoshiftObserverNotificationStatus Operation</seealso>
        public virtual Task<UpdateAutoshiftObserverNotificationStatusResponse> UpdateAutoshiftObserverNotificationStatusAsync(UpdateAutoshiftObserverNotificationStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAutoshiftObserverNotificationStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAutoshiftObserverNotificationStatusResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAutoshiftObserverNotificationStatusResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdatePracticeRunConfiguration

        internal virtual UpdatePracticeRunConfigurationResponse UpdatePracticeRunConfiguration(UpdatePracticeRunConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePracticeRunConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePracticeRunConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdatePracticeRunConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Update a practice run configuration to change one or more of the following: add, change,
        /// or remove the blocking alarm; change the outcome alarm; or add, change, or remove
        /// blocking dates or time windows.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePracticeRunConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePracticeRunConfiguration service method, as returned by ARCZonalShift.</returns>
        /// <exception cref="Amazon.ARCZonalShift.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ResourceNotFoundException">
        /// The input requested a resource that was not found.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/UpdatePracticeRunConfiguration">REST API Reference for UpdatePracticeRunConfiguration Operation</seealso>
        public virtual Task<UpdatePracticeRunConfigurationResponse> UpdatePracticeRunConfigurationAsync(UpdatePracticeRunConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePracticeRunConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePracticeRunConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdatePracticeRunConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateZonalAutoshiftConfiguration

        internal virtual UpdateZonalAutoshiftConfigurationResponse UpdateZonalAutoshiftConfiguration(UpdateZonalAutoshiftConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateZonalAutoshiftConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateZonalAutoshiftConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateZonalAutoshiftConfigurationResponse>(request, options);
        }



        /// <summary>
        /// The zonal autoshift configuration for a resource includes the practice run configuration
        /// and the status for running autoshifts, zonal autoshift status. When a resource has
        /// a practice run configuration, ARC starts weekly zonal shifts for the resource, to
        /// shift traffic away from an Availability Zone. Weekly practice runs help you to make
        /// sure that your application can continue to operate normally with the loss of one Availability
        /// Zone.
        /// 
        ///  
        /// <para>
        /// You can update the zonal autoshift status to enable or disable zonal autoshift. When
        /// zonal autoshift is <c>ENABLED</c>, you authorize Amazon Web Services to shift away
        /// resource traffic for an application from an Availability Zone during events, on your
        /// behalf, to help reduce time to recovery. Traffic is also shifted away for the required
        /// weekly practice runs.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateZonalAutoshiftConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateZonalAutoshiftConfiguration service method, as returned by ARCZonalShift.</returns>
        /// <exception cref="Amazon.ARCZonalShift.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ResourceNotFoundException">
        /// The input requested a resource that was not found.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/UpdateZonalAutoshiftConfiguration">REST API Reference for UpdateZonalAutoshiftConfiguration Operation</seealso>
        public virtual Task<UpdateZonalAutoshiftConfigurationResponse> UpdateZonalAutoshiftConfigurationAsync(UpdateZonalAutoshiftConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateZonalAutoshiftConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateZonalAutoshiftConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateZonalAutoshiftConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateZonalShift

        internal virtual UpdateZonalShiftResponse UpdateZonalShift(UpdateZonalShiftRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateZonalShiftRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateZonalShiftResponseUnmarshaller.Instance;

            return Invoke<UpdateZonalShiftResponse>(request, options);
        }



        /// <summary>
        /// Update an active zonal shift in Amazon Application Recovery Controller in your Amazon
        /// Web Services account. You can update a zonal shift to set a new expiration, or edit
        /// or replace the comment for the zonal shift.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateZonalShift service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateZonalShift service method, as returned by ARCZonalShift.</returns>
        /// <exception cref="Amazon.ARCZonalShift.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ResourceNotFoundException">
        /// The input requested a resource that was not found.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/UpdateZonalShift">REST API Reference for UpdateZonalShift Operation</seealso>
        public virtual Task<UpdateZonalShiftResponse> UpdateZonalShiftAsync(UpdateZonalShiftRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateZonalShiftRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateZonalShiftResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateZonalShiftResponse>(request, options, cancellationToken);
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