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
using Amazon.NetworkFlowMonitor.Model;
using Amazon.NetworkFlowMonitor.Model.Internal.MarshallTransformations;
using Amazon.NetworkFlowMonitor.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570

namespace Amazon.NetworkFlowMonitor
{
    /// <summary>
    /// <para>Implementation for accessing NetworkFlowMonitor</para>
    /// <para>
    /// Service client instances are thread-safe and can be shared across multiple threads.
    /// For a given service configuration, it is recommended to reuse a client instance
    /// for the lifetime of your application.
    /// </para>
    ///
    /// Network Flow Monitor is a feature of Amazon CloudWatch Network Monitoring that provides
    /// visibility into the performance of network flows for your Amazon Web Services workloads,
    /// between instances in subnets, as well as to and from Amazon Web Services. Lightweight
    /// agents that you install on the instances capture performance metrics for your network
    /// flows, such as packet loss and latency, and send them to the Network Flow Monitor
    /// backend. Then, you can view and analyze metrics from the top contributors for each
    /// metric type, to help troubleshoot issues.
    /// 
    ///  
    /// <para>
    /// In addition, when you create a monitor, Network Flow Monitor provides a network health
    /// indicator (NHI) that informs you whether there were Amazon Web Services network issues
    /// for one or more of the network flows tracked by a monitor, during a time period that
    /// you choose. By using this value, you can independently determine if the Amazon Web
    /// Services network is impacting your workload during a specific time frame, to help
    /// you focus troubleshooting efforts.
    /// </para>
    ///  
    /// <para>
    /// To learn more about Network Flow Monitor, see the <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-NetworkFlowMonitor.html">Network
    /// Flow Monitor User Guide</a> in the Amazon CloudWatch User Guide.
    /// </para>
    /// </summary>
    public partial class AmazonNetworkFlowMonitorClient : AmazonServiceClient, IAmazonNetworkFlowMonitor
    {
        private static IServiceMetadata serviceMetadata = new AmazonNetworkFlowMonitorMetadata();
        private INetworkFlowMonitorPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public INetworkFlowMonitorPaginatorFactory Paginators
        {
            get
            {
                if (this._paginators == null)
                {
                    this._paginators = new NetworkFlowMonitorPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        /// <summary>
        /// Constructs AmazonNetworkFlowMonitorClient with the credentials loaded from the application's
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
        public AmazonNetworkFlowMonitorClient() : base(new AmazonNetworkFlowMonitorConfig()) { }

        /// <summary>
        /// Constructs AmazonNetworkFlowMonitorClient with the credentials loaded from the application's
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
        public AmazonNetworkFlowMonitorClient(RegionEndpoint region) : base(new AmazonNetworkFlowMonitorConfig { RegionEndpoint = region }) { }

        /// <summary>
        /// Constructs AmazonNetworkFlowMonitorClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonNetworkFlowMonitorClient Configuration Object</param>
        public AmazonNetworkFlowMonitorClient(AmazonNetworkFlowMonitorConfig config) : base(config) { }

        /// <summary>
        /// Constructs AmazonNetworkFlowMonitorClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonNetworkFlowMonitorClient(AWSCredentials credentials)
            : this(credentials, new AmazonNetworkFlowMonitorConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonNetworkFlowMonitorClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonNetworkFlowMonitorClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonNetworkFlowMonitorConfig { RegionEndpoint = region })
        {
        }

        /// <summary>
        /// Constructs AmazonNetworkFlowMonitorClient with AWS Credentials and an
        /// AmazonNetworkFlowMonitorClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonNetworkFlowMonitorClient Configuration Object</param>
        public AmazonNetworkFlowMonitorClient(AWSCredentials credentials, AmazonNetworkFlowMonitorConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonNetworkFlowMonitorClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonNetworkFlowMonitorClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonNetworkFlowMonitorConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonNetworkFlowMonitorClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonNetworkFlowMonitorClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonNetworkFlowMonitorConfig { RegionEndpoint = region })
        {
        }

        /// <summary>
        /// Constructs AmazonNetworkFlowMonitorClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonNetworkFlowMonitorClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonNetworkFlowMonitorClient Configuration Object</param>
        public AmazonNetworkFlowMonitorClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonNetworkFlowMonitorConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonNetworkFlowMonitorClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonNetworkFlowMonitorClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonNetworkFlowMonitorConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonNetworkFlowMonitorClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonNetworkFlowMonitorClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonNetworkFlowMonitorConfig { RegionEndpoint = region })
        {
        }

        /// <summary>
        /// Constructs AmazonNetworkFlowMonitorClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonNetworkFlowMonitorClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonNetworkFlowMonitorClient Configuration Object</param>
        public AmazonNetworkFlowMonitorClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonNetworkFlowMonitorConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonNetworkFlowMonitorEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonNetworkFlowMonitorAuthSchemeHandler());
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
        /// Create a monitor for specific network flows between local and remote resources, so
        /// that you can monitor network performance for one or several of your workloads. For
        /// each monitor, Network Flow Monitor publishes detailed end-to-end performance metrics
        /// and a network health indicator (NHI) that informs you whether there were Amazon Web
        /// Services network issues for one or more of the network flows tracked by a monitor,
        /// during a time period that you choose.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMonitor service method.</param>
        /// <returns>The response from the CreateMonitor service method, as returned by NetworkFlowMonitor.</returns>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ConflictException">
        /// The requested resource is in use.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ServiceQuotaExceededException">
        /// The request exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/CreateMonitor">REST API Reference for CreateMonitor Operation</seealso>
        public virtual CreateMonitorResponse CreateMonitor(CreateMonitorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMonitorResponseUnmarshaller.Instance;

            return Invoke<CreateMonitorResponse>(request, options);
        }
#else
        internal virtual CreateMonitorResponse CreateMonitor(CreateMonitorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMonitorResponseUnmarshaller.Instance;

            return Invoke<CreateMonitorResponse>(request, options);
        }
#endif

        /// <summary>
        /// Create a monitor for specific network flows between local and remote resources, so
        /// that you can monitor network performance for one or several of your workloads. For
        /// each monitor, Network Flow Monitor publishes detailed end-to-end performance metrics
        /// and a network health indicator (NHI) that informs you whether there were Amazon Web
        /// Services network issues for one or more of the network flows tracked by a monitor,
        /// during a time period that you choose.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMonitor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateMonitor service method, as returned by NetworkFlowMonitor.</returns>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ConflictException">
        /// The requested resource is in use.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ServiceQuotaExceededException">
        /// The request exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/CreateMonitor">REST API Reference for CreateMonitor Operation</seealso>
        public virtual Task<CreateMonitorResponse> CreateMonitorAsync(CreateMonitorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMonitorResponseUnmarshaller.Instance;

            return InvokeAsync<CreateMonitorResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Create a performance monitor to monitor the traffic of the Amazon Virtual Private
        /// Clouds (VPCs) that you specify as targets, to determine whether the Amazon Web Services
        /// network is causing issues for your workloads. With a performance monitor, you can
        /// identify network degradation across paths between Availability Zones and across Amazon
        /// Web Services Regions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePerformanceMonitor service method.</param>
        /// <returns>The response from the CreatePerformanceMonitor service method, as returned by NetworkFlowMonitor.</returns>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ConflictException">
        /// The requested resource is in use.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ServiceQuotaExceededException">
        /// The request exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/CreatePerformanceMonitor">REST API Reference for CreatePerformanceMonitor Operation</seealso>
        public virtual CreatePerformanceMonitorResponse CreatePerformanceMonitor(CreatePerformanceMonitorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePerformanceMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePerformanceMonitorResponseUnmarshaller.Instance;

            return Invoke<CreatePerformanceMonitorResponse>(request, options);
        }
#else
        internal virtual CreatePerformanceMonitorResponse CreatePerformanceMonitor(CreatePerformanceMonitorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePerformanceMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePerformanceMonitorResponseUnmarshaller.Instance;

            return Invoke<CreatePerformanceMonitorResponse>(request, options);
        }
#endif

        /// <summary>
        /// Create a performance monitor to monitor the traffic of the Amazon Virtual Private
        /// Clouds (VPCs) that you specify as targets, to determine whether the Amazon Web Services
        /// network is causing issues for your workloads. With a performance monitor, you can
        /// identify network degradation across paths between Availability Zones and across Amazon
        /// Web Services Regions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePerformanceMonitor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreatePerformanceMonitor service method, as returned by NetworkFlowMonitor.</returns>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ConflictException">
        /// The requested resource is in use.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ServiceQuotaExceededException">
        /// The request exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/CreatePerformanceMonitor">REST API Reference for CreatePerformanceMonitor Operation</seealso>
        public virtual Task<CreatePerformanceMonitorResponse> CreatePerformanceMonitorAsync(CreatePerformanceMonitorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePerformanceMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePerformanceMonitorResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePerformanceMonitorResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// In Network Flow Monitor, you specify a scope for the service to generate metrics for.
        /// By using the scope, Network Flow Monitor can generate a topology of all the resources
        /// to measure performance metrics for. When you create a scope, you enable permissions
        /// for Network Flow Monitor.
        /// 
        ///  
        /// <para>
        /// A scope is a Region-account pair or multiple Region-account pairs. Network Flow Monitor
        /// uses your scope to determine all the resources (the topology) where Network Flow Monitor
        /// will gather network flow performance metrics for you. To provide performance metrics,
        /// Network Flow Monitor uses the data that is sent by the Network Flow Monitor agents
        /// you install on the resources.
        /// </para>
        ///  
        /// <para>
        /// To define the Region-account pairs for your scope, the Network Flow Monitor API uses
        /// the following constucts, which allow for future flexibility in defining scopes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>Targets</i>, which are arrays of targetResources.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Target resources</i>, which are Region-targetIdentifier pairs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Target identifiers</i>, made up of a targetID (currently always an account ID)
        /// and a targetType (currently always an account). 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateScope service method.</param>
        /// <returns>The response from the CreateScope service method, as returned by NetworkFlowMonitor.</returns>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ConflictException">
        /// The requested resource is in use.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ServiceQuotaExceededException">
        /// The request exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/CreateScope">REST API Reference for CreateScope Operation</seealso>
        public virtual CreateScopeResponse CreateScope(CreateScopeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateScopeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateScopeResponseUnmarshaller.Instance;

            return Invoke<CreateScopeResponse>(request, options);
        }
#else
        internal virtual CreateScopeResponse CreateScope(CreateScopeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateScopeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateScopeResponseUnmarshaller.Instance;

            return Invoke<CreateScopeResponse>(request, options);
        }
#endif

        /// <summary>
        /// In Network Flow Monitor, you specify a scope for the service to generate metrics for.
        /// By using the scope, Network Flow Monitor can generate a topology of all the resources
        /// to measure performance metrics for. When you create a scope, you enable permissions
        /// for Network Flow Monitor.
        /// 
        ///  
        /// <para>
        /// A scope is a Region-account pair or multiple Region-account pairs. Network Flow Monitor
        /// uses your scope to determine all the resources (the topology) where Network Flow Monitor
        /// will gather network flow performance metrics for you. To provide performance metrics,
        /// Network Flow Monitor uses the data that is sent by the Network Flow Monitor agents
        /// you install on the resources.
        /// </para>
        ///  
        /// <para>
        /// To define the Region-account pairs for your scope, the Network Flow Monitor API uses
        /// the following constucts, which allow for future flexibility in defining scopes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>Targets</i>, which are arrays of targetResources.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Target resources</i>, which are Region-targetIdentifier pairs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Target identifiers</i>, made up of a targetID (currently always an account ID)
        /// and a targetType (currently always an account). 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateScope service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateScope service method, as returned by NetworkFlowMonitor.</returns>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ConflictException">
        /// The requested resource is in use.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ServiceQuotaExceededException">
        /// The request exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/CreateScope">REST API Reference for CreateScope Operation</seealso>
        public virtual Task<CreateScopeResponse> CreateScopeAsync(CreateScopeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateScopeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateScopeResponseUnmarshaller.Instance;

            return InvokeAsync<CreateScopeResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Deletes a monitor in Network Flow Monitor.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMonitor service method.</param>
        /// <returns>The response from the DeleteMonitor service method, as returned by NetworkFlowMonitor.</returns>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ConflictException">
        /// The requested resource is in use.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ResourceNotFoundException">
        /// The request specifies a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/DeleteMonitor">REST API Reference for DeleteMonitor Operation</seealso>
        public virtual DeleteMonitorResponse DeleteMonitor(DeleteMonitorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMonitorResponseUnmarshaller.Instance;

            return Invoke<DeleteMonitorResponse>(request, options);
        }
#else
        internal virtual DeleteMonitorResponse DeleteMonitor(DeleteMonitorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMonitorResponseUnmarshaller.Instance;

            return Invoke<DeleteMonitorResponse>(request, options);
        }
#endif

        /// <summary>
        /// Deletes a monitor in Network Flow Monitor.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMonitor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteMonitor service method, as returned by NetworkFlowMonitor.</returns>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ConflictException">
        /// The requested resource is in use.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ResourceNotFoundException">
        /// The request specifies a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/DeleteMonitor">REST API Reference for DeleteMonitor Operation</seealso>
        public virtual Task<DeleteMonitorResponse> DeleteMonitorAsync(DeleteMonitorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMonitorResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteMonitorResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Delete a performance monitor. Network Flow Monitor stops tracking network performance
        /// for the resources that the monitor included.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePerformanceMonitor service method.</param>
        /// <returns>The response from the DeletePerformanceMonitor service method, as returned by NetworkFlowMonitor.</returns>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ConflictException">
        /// The requested resource is in use.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ResourceNotFoundException">
        /// The request specifies a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/DeletePerformanceMonitor">REST API Reference for DeletePerformanceMonitor Operation</seealso>
        public virtual DeletePerformanceMonitorResponse DeletePerformanceMonitor(DeletePerformanceMonitorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePerformanceMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePerformanceMonitorResponseUnmarshaller.Instance;

            return Invoke<DeletePerformanceMonitorResponse>(request, options);
        }
#else
        internal virtual DeletePerformanceMonitorResponse DeletePerformanceMonitor(DeletePerformanceMonitorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePerformanceMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePerformanceMonitorResponseUnmarshaller.Instance;

            return Invoke<DeletePerformanceMonitorResponse>(request, options);
        }
#endif

        /// <summary>
        /// Delete a performance monitor. Network Flow Monitor stops tracking network performance
        /// for the resources that the monitor included.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePerformanceMonitor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeletePerformanceMonitor service method, as returned by NetworkFlowMonitor.</returns>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ConflictException">
        /// The requested resource is in use.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ResourceNotFoundException">
        /// The request specifies a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/DeletePerformanceMonitor">REST API Reference for DeletePerformanceMonitor Operation</seealso>
        public virtual Task<DeletePerformanceMonitorResponse> DeletePerformanceMonitorAsync(DeletePerformanceMonitorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePerformanceMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePerformanceMonitorResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePerformanceMonitorResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Deletes a scope that has been defined.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteScope service method.</param>
        /// <returns>The response from the DeleteScope service method, as returned by NetworkFlowMonitor.</returns>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ConflictException">
        /// The requested resource is in use.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ResourceNotFoundException">
        /// The request specifies a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ServiceQuotaExceededException">
        /// The request exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/DeleteScope">REST API Reference for DeleteScope Operation</seealso>
        public virtual DeleteScopeResponse DeleteScope(DeleteScopeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteScopeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteScopeResponseUnmarshaller.Instance;

            return Invoke<DeleteScopeResponse>(request, options);
        }
#else
        internal virtual DeleteScopeResponse DeleteScope(DeleteScopeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteScopeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteScopeResponseUnmarshaller.Instance;

            return Invoke<DeleteScopeResponse>(request, options);
        }
#endif

        /// <summary>
        /// Deletes a scope that has been defined.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteScope service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteScope service method, as returned by NetworkFlowMonitor.</returns>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ConflictException">
        /// The requested resource is in use.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ResourceNotFoundException">
        /// The request specifies a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ServiceQuotaExceededException">
        /// The request exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/DeleteScope">REST API Reference for DeleteScope Operation</seealso>
        public virtual Task<DeleteScopeResponse> DeleteScopeAsync(DeleteScopeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteScopeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteScopeResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteScopeResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Gets information about a monitor in Network Flow Monitor based on a monitor name.
        /// The information returned includes the Amazon Resource Name (ARN), create time, modified
        /// time, resources included in the monitor, and status information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMonitor service method.</param>
        /// <returns>The response from the GetMonitor service method, as returned by NetworkFlowMonitor.</returns>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ResourceNotFoundException">
        /// The request specifies a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/GetMonitor">REST API Reference for GetMonitor Operation</seealso>
        public virtual GetMonitorResponse GetMonitor(GetMonitorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMonitorResponseUnmarshaller.Instance;

            return Invoke<GetMonitorResponse>(request, options);
        }
#else
        internal virtual GetMonitorResponse GetMonitor(GetMonitorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMonitorResponseUnmarshaller.Instance;

            return Invoke<GetMonitorResponse>(request, options);
        }
#endif

        /// <summary>
        /// Gets information about a monitor in Network Flow Monitor based on a monitor name.
        /// The information returned includes the Amazon Resource Name (ARN), create time, modified
        /// time, resources included in the monitor, and status information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMonitor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetMonitor service method, as returned by NetworkFlowMonitor.</returns>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ResourceNotFoundException">
        /// The request specifies a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/GetMonitor">REST API Reference for GetMonitor Operation</seealso>
        public virtual Task<GetMonitorResponse> GetMonitorAsync(GetMonitorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMonitorResponseUnmarshaller.Instance;

            return InvokeAsync<GetMonitorResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Returns the accounts that are sending traffic to, or receiving traffic from, resources
        /// in a monitor, but that aren't included in the monitoring scope for the monitor. By
        /// adding the suggested accounts to your scope, you enable Network Flow Monitor to resolve
        /// the network paths for that traffic.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMonitorScopeSuggestions service method.</param>
        /// <returns>The response from the GetMonitorScopeSuggestions service method, as returned by NetworkFlowMonitor.</returns>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ResourceNotFoundException">
        /// The request specifies a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/GetMonitorScopeSuggestions">REST API Reference for GetMonitorScopeSuggestions Operation</seealso>
        public virtual GetMonitorScopeSuggestionsResponse GetMonitorScopeSuggestions(GetMonitorScopeSuggestionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMonitorScopeSuggestionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMonitorScopeSuggestionsResponseUnmarshaller.Instance;

            return Invoke<GetMonitorScopeSuggestionsResponse>(request, options);
        }
#else
        internal virtual GetMonitorScopeSuggestionsResponse GetMonitorScopeSuggestions(GetMonitorScopeSuggestionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMonitorScopeSuggestionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMonitorScopeSuggestionsResponseUnmarshaller.Instance;

            return Invoke<GetMonitorScopeSuggestionsResponse>(request, options);
        }
#endif

        /// <summary>
        /// Returns the accounts that are sending traffic to, or receiving traffic from, resources
        /// in a monitor, but that aren't included in the monitoring scope for the monitor. By
        /// adding the suggested accounts to your scope, you enable Network Flow Monitor to resolve
        /// the network paths for that traffic.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMonitorScopeSuggestions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetMonitorScopeSuggestions service method, as returned by NetworkFlowMonitor.</returns>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ResourceNotFoundException">
        /// The request specifies a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/GetMonitorScopeSuggestions">REST API Reference for GetMonitorScopeSuggestions Operation</seealso>
        public virtual Task<GetMonitorScopeSuggestionsResponse> GetMonitorScopeSuggestionsAsync(GetMonitorScopeSuggestionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMonitorScopeSuggestionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMonitorScopeSuggestionsResponseUnmarshaller.Instance;

            return InvokeAsync<GetMonitorScopeSuggestionsResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Returns information about a performance monitor, including the resources that it monitors,
        /// its status, and the tags for the monitor.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPerformanceMonitor service method.</param>
        /// <returns>The response from the GetPerformanceMonitor service method, as returned by NetworkFlowMonitor.</returns>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ResourceNotFoundException">
        /// The request specifies a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/GetPerformanceMonitor">REST API Reference for GetPerformanceMonitor Operation</seealso>
        public virtual GetPerformanceMonitorResponse GetPerformanceMonitor(GetPerformanceMonitorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPerformanceMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPerformanceMonitorResponseUnmarshaller.Instance;

            return Invoke<GetPerformanceMonitorResponse>(request, options);
        }
#else
        internal virtual GetPerformanceMonitorResponse GetPerformanceMonitor(GetPerformanceMonitorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPerformanceMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPerformanceMonitorResponseUnmarshaller.Instance;

            return Invoke<GetPerformanceMonitorResponse>(request, options);
        }
#endif

        /// <summary>
        /// Returns information about a performance monitor, including the resources that it monitors,
        /// its status, and the tags for the monitor.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPerformanceMonitor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetPerformanceMonitor service method, as returned by NetworkFlowMonitor.</returns>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ResourceNotFoundException">
        /// The request specifies a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/GetPerformanceMonitor">REST API Reference for GetPerformanceMonitor Operation</seealso>
        public virtual Task<GetPerformanceMonitorResponse> GetPerformanceMonitorAsync(GetPerformanceMonitorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPerformanceMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPerformanceMonitorResponseUnmarshaller.Instance;

            return InvokeAsync<GetPerformanceMonitorResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Return the data for a query with the Network Flow Monitor query interface. You specify
        /// the query that you want to return results for by providing a query ID and a monitor
        /// name. This query returns the top contributors for a specific monitor.
        /// 
        ///  
        /// <para>
        /// Create a query ID for this call by calling the corresponding API call to start the
        /// query, <c>StartQueryMonitorTopContributors</c>. Use the scope ID that was returned
        /// for your account by <c>CreateScope</c>.
        /// </para>
        ///  
        /// <para>
        /// Top contributors in Network Flow Monitor are network flows with the highest values
        /// for a specific metric type. Top contributors can be across all workload insights,
        /// for a given scope, or for a specific monitor. Use the applicable call for the top
        /// contributors that you want to be returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQueryResultsMonitorTopContributors service method.</param>
        /// <returns>The response from the GetQueryResultsMonitorTopContributors service method, as returned by NetworkFlowMonitor.</returns>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ResourceNotFoundException">
        /// The request specifies a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ServiceQuotaExceededException">
        /// The request exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/GetQueryResultsMonitorTopContributors">REST API Reference for GetQueryResultsMonitorTopContributors Operation</seealso>
        public virtual GetQueryResultsMonitorTopContributorsResponse GetQueryResultsMonitorTopContributors(GetQueryResultsMonitorTopContributorsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetQueryResultsMonitorTopContributorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueryResultsMonitorTopContributorsResponseUnmarshaller.Instance;

            return Invoke<GetQueryResultsMonitorTopContributorsResponse>(request, options);
        }
#else
        internal virtual GetQueryResultsMonitorTopContributorsResponse GetQueryResultsMonitorTopContributors(GetQueryResultsMonitorTopContributorsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetQueryResultsMonitorTopContributorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueryResultsMonitorTopContributorsResponseUnmarshaller.Instance;

            return Invoke<GetQueryResultsMonitorTopContributorsResponse>(request, options);
        }
#endif

        /// <summary>
        /// Return the data for a query with the Network Flow Monitor query interface. You specify
        /// the query that you want to return results for by providing a query ID and a monitor
        /// name. This query returns the top contributors for a specific monitor.
        /// 
        ///  
        /// <para>
        /// Create a query ID for this call by calling the corresponding API call to start the
        /// query, <c>StartQueryMonitorTopContributors</c>. Use the scope ID that was returned
        /// for your account by <c>CreateScope</c>.
        /// </para>
        ///  
        /// <para>
        /// Top contributors in Network Flow Monitor are network flows with the highest values
        /// for a specific metric type. Top contributors can be across all workload insights,
        /// for a given scope, or for a specific monitor. Use the applicable call for the top
        /// contributors that you want to be returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQueryResultsMonitorTopContributors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetQueryResultsMonitorTopContributors service method, as returned by NetworkFlowMonitor.</returns>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ResourceNotFoundException">
        /// The request specifies a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ServiceQuotaExceededException">
        /// The request exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/GetQueryResultsMonitorTopContributors">REST API Reference for GetQueryResultsMonitorTopContributors Operation</seealso>
        public virtual Task<GetQueryResultsMonitorTopContributorsResponse> GetQueryResultsMonitorTopContributorsAsync(GetQueryResultsMonitorTopContributorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetQueryResultsMonitorTopContributorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueryResultsMonitorTopContributorsResponseUnmarshaller.Instance;

            return InvokeAsync<GetQueryResultsMonitorTopContributorsResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Returns the results of a query for the Network Flow Monitor query interface, for a
        /// specified query ID and performance monitor. This call returns the top paths for a
        /// performance monitor.
        /// 
        ///  
        /// <para>
        /// Create a query with <a href="https://docs.aws.amazon.com/networkflowmonitor/2.0/APIReference/API_StartQueryPerformanceMonitor.html">
        /// StartQueryPerformanceMonitor</a>, and then use the query ID with this call to return
        /// the results.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQueryResultsPerformanceMonitor service method.</param>
        /// <returns>The response from the GetQueryResultsPerformanceMonitor service method, as returned by NetworkFlowMonitor.</returns>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ResourceNotFoundException">
        /// The request specifies a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ServiceQuotaExceededException">
        /// The request exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/GetQueryResultsPerformanceMonitor">REST API Reference for GetQueryResultsPerformanceMonitor Operation</seealso>
        public virtual GetQueryResultsPerformanceMonitorResponse GetQueryResultsPerformanceMonitor(GetQueryResultsPerformanceMonitorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetQueryResultsPerformanceMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueryResultsPerformanceMonitorResponseUnmarshaller.Instance;

            return Invoke<GetQueryResultsPerformanceMonitorResponse>(request, options);
        }
#else
        internal virtual GetQueryResultsPerformanceMonitorResponse GetQueryResultsPerformanceMonitor(GetQueryResultsPerformanceMonitorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetQueryResultsPerformanceMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueryResultsPerformanceMonitorResponseUnmarshaller.Instance;

            return Invoke<GetQueryResultsPerformanceMonitorResponse>(request, options);
        }
#endif

        /// <summary>
        /// Returns the results of a query for the Network Flow Monitor query interface, for a
        /// specified query ID and performance monitor. This call returns the top paths for a
        /// performance monitor.
        /// 
        ///  
        /// <para>
        /// Create a query with <a href="https://docs.aws.amazon.com/networkflowmonitor/2.0/APIReference/API_StartQueryPerformanceMonitor.html">
        /// StartQueryPerformanceMonitor</a>, and then use the query ID with this call to return
        /// the results.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQueryResultsPerformanceMonitor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetQueryResultsPerformanceMonitor service method, as returned by NetworkFlowMonitor.</returns>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ResourceNotFoundException">
        /// The request specifies a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ServiceQuotaExceededException">
        /// The request exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/GetQueryResultsPerformanceMonitor">REST API Reference for GetQueryResultsPerformanceMonitor Operation</seealso>
        public virtual Task<GetQueryResultsPerformanceMonitorResponse> GetQueryResultsPerformanceMonitorAsync(GetQueryResultsPerformanceMonitorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetQueryResultsPerformanceMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueryResultsPerformanceMonitorResponseUnmarshaller.Instance;

            return InvokeAsync<GetQueryResultsPerformanceMonitorResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Return the data for a query with the Network Flow Monitor query interface. You specify
        /// the query that you want to return results for by providing a query ID and a monitor
        /// name.
        /// 
        ///  
        /// <para>
        /// This query returns the top contributors for a scope for workload insights. Workload
        /// insights provide a high level view of network flow performance data collected by agents.
        /// To return the data for the top contributors, see <c>GetQueryResultsWorkloadInsightsTopContributorsData</c>.
        /// </para>
        ///  
        /// <para>
        /// Create a query ID for this call by calling the corresponding API call to start the
        /// query, <c>StartQueryWorkloadInsightsTopContributors</c>. Use the scope ID that was
        /// returned for your account by <c>CreateScope</c>.
        /// </para>
        ///  
        /// <para>
        /// Top contributors in Network Flow Monitor are network flows with the highest values
        /// for a specific metric type. Top contributors can be across all workload insights,
        /// for a given scope, or for a specific monitor. Use the applicable call for the top
        /// contributors that you want to be returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQueryResultsWorkloadInsightsTopContributors service method.</param>
        /// <returns>The response from the GetQueryResultsWorkloadInsightsTopContributors service method, as returned by NetworkFlowMonitor.</returns>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ResourceNotFoundException">
        /// The request specifies a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ServiceQuotaExceededException">
        /// The request exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/GetQueryResultsWorkloadInsightsTopContributors">REST API Reference for GetQueryResultsWorkloadInsightsTopContributors Operation</seealso>
        public virtual GetQueryResultsWorkloadInsightsTopContributorsResponse GetQueryResultsWorkloadInsightsTopContributors(GetQueryResultsWorkloadInsightsTopContributorsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetQueryResultsWorkloadInsightsTopContributorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueryResultsWorkloadInsightsTopContributorsResponseUnmarshaller.Instance;

            return Invoke<GetQueryResultsWorkloadInsightsTopContributorsResponse>(request, options);
        }
#else
        internal virtual GetQueryResultsWorkloadInsightsTopContributorsResponse GetQueryResultsWorkloadInsightsTopContributors(GetQueryResultsWorkloadInsightsTopContributorsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetQueryResultsWorkloadInsightsTopContributorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueryResultsWorkloadInsightsTopContributorsResponseUnmarshaller.Instance;

            return Invoke<GetQueryResultsWorkloadInsightsTopContributorsResponse>(request, options);
        }
#endif

        /// <summary>
        /// Return the data for a query with the Network Flow Monitor query interface. You specify
        /// the query that you want to return results for by providing a query ID and a monitor
        /// name.
        /// 
        ///  
        /// <para>
        /// This query returns the top contributors for a scope for workload insights. Workload
        /// insights provide a high level view of network flow performance data collected by agents.
        /// To return the data for the top contributors, see <c>GetQueryResultsWorkloadInsightsTopContributorsData</c>.
        /// </para>
        ///  
        /// <para>
        /// Create a query ID for this call by calling the corresponding API call to start the
        /// query, <c>StartQueryWorkloadInsightsTopContributors</c>. Use the scope ID that was
        /// returned for your account by <c>CreateScope</c>.
        /// </para>
        ///  
        /// <para>
        /// Top contributors in Network Flow Monitor are network flows with the highest values
        /// for a specific metric type. Top contributors can be across all workload insights,
        /// for a given scope, or for a specific monitor. Use the applicable call for the top
        /// contributors that you want to be returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQueryResultsWorkloadInsightsTopContributors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetQueryResultsWorkloadInsightsTopContributors service method, as returned by NetworkFlowMonitor.</returns>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ResourceNotFoundException">
        /// The request specifies a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ServiceQuotaExceededException">
        /// The request exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/GetQueryResultsWorkloadInsightsTopContributors">REST API Reference for GetQueryResultsWorkloadInsightsTopContributors Operation</seealso>
        public virtual Task<GetQueryResultsWorkloadInsightsTopContributorsResponse> GetQueryResultsWorkloadInsightsTopContributorsAsync(GetQueryResultsWorkloadInsightsTopContributorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetQueryResultsWorkloadInsightsTopContributorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueryResultsWorkloadInsightsTopContributorsResponseUnmarshaller.Instance;

            return InvokeAsync<GetQueryResultsWorkloadInsightsTopContributorsResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Return the data for a query with the Network Flow Monitor query interface. Specify
        /// the query that you want to return results for by providing a query ID and a scope
        /// ID.
        /// 
        ///  
        /// <para>
        /// This query returns the data for top contributors for workload insights for a specific
        /// scope. Workload insights provide a high level view of network flow performance data
        /// collected by agents for a scope. To return just the top contributors, see <c>GetQueryResultsWorkloadInsightsTopContributors</c>.
        /// </para>
        ///  
        /// <para>
        /// Create a query ID for this call by calling the corresponding API call to start the
        /// query, <c>StartQueryWorkloadInsightsTopContributorsData</c>. Use the scope ID that
        /// was returned for your account by <c>CreateScope</c>.
        /// </para>
        ///  
        /// <para>
        /// Top contributors in Network Flow Monitor are network flows with the highest values
        /// for a specific metric type. Top contributors can be across all workload insights,
        /// for a given scope, or for a specific monitor. Use the applicable call for the top
        /// contributors that you want to be returned.
        /// </para>
        ///  
        /// <para>
        /// The top contributor network flows overall are for a specific metric type, for example,
        /// the number of retransmissions.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQueryResultsWorkloadInsightsTopContributorsData service method.</param>
        /// <returns>The response from the GetQueryResultsWorkloadInsightsTopContributorsData service method, as returned by NetworkFlowMonitor.</returns>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ResourceNotFoundException">
        /// The request specifies a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ServiceQuotaExceededException">
        /// The request exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/GetQueryResultsWorkloadInsightsTopContributorsData">REST API Reference for GetQueryResultsWorkloadInsightsTopContributorsData Operation</seealso>
        public virtual GetQueryResultsWorkloadInsightsTopContributorsDataResponse GetQueryResultsWorkloadInsightsTopContributorsData(GetQueryResultsWorkloadInsightsTopContributorsDataRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetQueryResultsWorkloadInsightsTopContributorsDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueryResultsWorkloadInsightsTopContributorsDataResponseUnmarshaller.Instance;

            return Invoke<GetQueryResultsWorkloadInsightsTopContributorsDataResponse>(request, options);
        }
#else
        internal virtual GetQueryResultsWorkloadInsightsTopContributorsDataResponse GetQueryResultsWorkloadInsightsTopContributorsData(GetQueryResultsWorkloadInsightsTopContributorsDataRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetQueryResultsWorkloadInsightsTopContributorsDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueryResultsWorkloadInsightsTopContributorsDataResponseUnmarshaller.Instance;

            return Invoke<GetQueryResultsWorkloadInsightsTopContributorsDataResponse>(request, options);
        }
#endif

        /// <summary>
        /// Return the data for a query with the Network Flow Monitor query interface. Specify
        /// the query that you want to return results for by providing a query ID and a scope
        /// ID.
        /// 
        ///  
        /// <para>
        /// This query returns the data for top contributors for workload insights for a specific
        /// scope. Workload insights provide a high level view of network flow performance data
        /// collected by agents for a scope. To return just the top contributors, see <c>GetQueryResultsWorkloadInsightsTopContributors</c>.
        /// </para>
        ///  
        /// <para>
        /// Create a query ID for this call by calling the corresponding API call to start the
        /// query, <c>StartQueryWorkloadInsightsTopContributorsData</c>. Use the scope ID that
        /// was returned for your account by <c>CreateScope</c>.
        /// </para>
        ///  
        /// <para>
        /// Top contributors in Network Flow Monitor are network flows with the highest values
        /// for a specific metric type. Top contributors can be across all workload insights,
        /// for a given scope, or for a specific monitor. Use the applicable call for the top
        /// contributors that you want to be returned.
        /// </para>
        ///  
        /// <para>
        /// The top contributor network flows overall are for a specific metric type, for example,
        /// the number of retransmissions.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQueryResultsWorkloadInsightsTopContributorsData service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetQueryResultsWorkloadInsightsTopContributorsData service method, as returned by NetworkFlowMonitor.</returns>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ResourceNotFoundException">
        /// The request specifies a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ServiceQuotaExceededException">
        /// The request exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/GetQueryResultsWorkloadInsightsTopContributorsData">REST API Reference for GetQueryResultsWorkloadInsightsTopContributorsData Operation</seealso>
        public virtual Task<GetQueryResultsWorkloadInsightsTopContributorsDataResponse> GetQueryResultsWorkloadInsightsTopContributorsDataAsync(GetQueryResultsWorkloadInsightsTopContributorsDataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetQueryResultsWorkloadInsightsTopContributorsDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueryResultsWorkloadInsightsTopContributorsDataResponseUnmarshaller.Instance;

            return InvokeAsync<GetQueryResultsWorkloadInsightsTopContributorsDataResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Returns the current status of a query for the Network Flow Monitor query interface,
        /// for a specified query ID and monitor. This call returns the query status for the top
        /// contributors for a monitor.
        /// 
        ///  
        /// <para>
        /// When you create a query, use this call to check the status of the query to make sure
        /// that it has has <c>SUCCEEDED</c> before you review the results. Use the same query
        /// ID that you used for the corresponding API call to start (create) the query, <c>StartQueryMonitorTopContributors</c>.
        /// </para>
        ///  
        /// <para>
        /// When you run a query, use this call to check the status of the query to make sure
        /// that the query has <c>SUCCEEDED</c> before you review the results.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQueryStatusMonitorTopContributors service method.</param>
        /// <returns>The response from the GetQueryStatusMonitorTopContributors service method, as returned by NetworkFlowMonitor.</returns>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ServiceQuotaExceededException">
        /// The request exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/GetQueryStatusMonitorTopContributors">REST API Reference for GetQueryStatusMonitorTopContributors Operation</seealso>
        public virtual GetQueryStatusMonitorTopContributorsResponse GetQueryStatusMonitorTopContributors(GetQueryStatusMonitorTopContributorsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetQueryStatusMonitorTopContributorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueryStatusMonitorTopContributorsResponseUnmarshaller.Instance;

            return Invoke<GetQueryStatusMonitorTopContributorsResponse>(request, options);
        }
#else
        internal virtual GetQueryStatusMonitorTopContributorsResponse GetQueryStatusMonitorTopContributors(GetQueryStatusMonitorTopContributorsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetQueryStatusMonitorTopContributorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueryStatusMonitorTopContributorsResponseUnmarshaller.Instance;

            return Invoke<GetQueryStatusMonitorTopContributorsResponse>(request, options);
        }
#endif

        /// <summary>
        /// Returns the current status of a query for the Network Flow Monitor query interface,
        /// for a specified query ID and monitor. This call returns the query status for the top
        /// contributors for a monitor.
        /// 
        ///  
        /// <para>
        /// When you create a query, use this call to check the status of the query to make sure
        /// that it has has <c>SUCCEEDED</c> before you review the results. Use the same query
        /// ID that you used for the corresponding API call to start (create) the query, <c>StartQueryMonitorTopContributors</c>.
        /// </para>
        ///  
        /// <para>
        /// When you run a query, use this call to check the status of the query to make sure
        /// that the query has <c>SUCCEEDED</c> before you review the results.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQueryStatusMonitorTopContributors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetQueryStatusMonitorTopContributors service method, as returned by NetworkFlowMonitor.</returns>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ServiceQuotaExceededException">
        /// The request exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/GetQueryStatusMonitorTopContributors">REST API Reference for GetQueryStatusMonitorTopContributors Operation</seealso>
        public virtual Task<GetQueryStatusMonitorTopContributorsResponse> GetQueryStatusMonitorTopContributorsAsync(GetQueryStatusMonitorTopContributorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetQueryStatusMonitorTopContributorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueryStatusMonitorTopContributorsResponseUnmarshaller.Instance;

            return InvokeAsync<GetQueryStatusMonitorTopContributorsResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Returns the current status of a query for the Network Flow Monitor query interface,
        /// for a specified query ID and performance monitor. This call returns the query status
        /// for the top paths for a performance monitor.
        /// 
        ///  
        /// <para>
        /// When you run a query, use this call to check the status of the query to make sure
        /// that the query has <c>SUCCEEDED</c> before you review the results. Use the same query
        /// ID that you used for the corresponding API call to start (create) the query, <c>StartQueryPerformanceMonitor</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQueryStatusPerformanceMonitor service method.</param>
        /// <returns>The response from the GetQueryStatusPerformanceMonitor service method, as returned by NetworkFlowMonitor.</returns>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ResourceNotFoundException">
        /// The request specifies a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ServiceQuotaExceededException">
        /// The request exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/GetQueryStatusPerformanceMonitor">REST API Reference for GetQueryStatusPerformanceMonitor Operation</seealso>
        public virtual GetQueryStatusPerformanceMonitorResponse GetQueryStatusPerformanceMonitor(GetQueryStatusPerformanceMonitorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetQueryStatusPerformanceMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueryStatusPerformanceMonitorResponseUnmarshaller.Instance;

            return Invoke<GetQueryStatusPerformanceMonitorResponse>(request, options);
        }
#else
        internal virtual GetQueryStatusPerformanceMonitorResponse GetQueryStatusPerformanceMonitor(GetQueryStatusPerformanceMonitorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetQueryStatusPerformanceMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueryStatusPerformanceMonitorResponseUnmarshaller.Instance;

            return Invoke<GetQueryStatusPerformanceMonitorResponse>(request, options);
        }
#endif

        /// <summary>
        /// Returns the current status of a query for the Network Flow Monitor query interface,
        /// for a specified query ID and performance monitor. This call returns the query status
        /// for the top paths for a performance monitor.
        /// 
        ///  
        /// <para>
        /// When you run a query, use this call to check the status of the query to make sure
        /// that the query has <c>SUCCEEDED</c> before you review the results. Use the same query
        /// ID that you used for the corresponding API call to start (create) the query, <c>StartQueryPerformanceMonitor</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQueryStatusPerformanceMonitor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetQueryStatusPerformanceMonitor service method, as returned by NetworkFlowMonitor.</returns>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ResourceNotFoundException">
        /// The request specifies a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ServiceQuotaExceededException">
        /// The request exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/GetQueryStatusPerformanceMonitor">REST API Reference for GetQueryStatusPerformanceMonitor Operation</seealso>
        public virtual Task<GetQueryStatusPerformanceMonitorResponse> GetQueryStatusPerformanceMonitorAsync(GetQueryStatusPerformanceMonitorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetQueryStatusPerformanceMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueryStatusPerformanceMonitorResponseUnmarshaller.Instance;

            return InvokeAsync<GetQueryStatusPerformanceMonitorResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Return the data for a query with the Network Flow Monitor query interface. Specify
        /// the query that you want to return results for by providing a query ID and a monitor
        /// name. This query returns the top contributors for workload insights.
        /// 
        ///  
        /// <para>
        /// When you start a query, use this call to check the status of the query to make sure
        /// that it has has <c>SUCCEEDED</c> before you review the results. Use the same query
        /// ID that you used for the corresponding API call to start the query, <c>StartQueryWorkloadInsightsTopContributors</c>.
        /// </para>
        ///  
        /// <para>
        /// Top contributors in Network Flow Monitor are network flows with the highest values
        /// for a specific metric type. Top contributors can be across all workload insights,
        /// for a given scope, or for a specific monitor. Use the applicable call for the top
        /// contributors that you want to be returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQueryStatusWorkloadInsightsTopContributors service method.</param>
        /// <returns>The response from the GetQueryStatusWorkloadInsightsTopContributors service method, as returned by NetworkFlowMonitor.</returns>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ServiceQuotaExceededException">
        /// The request exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/GetQueryStatusWorkloadInsightsTopContributors">REST API Reference for GetQueryStatusWorkloadInsightsTopContributors Operation</seealso>
        public virtual GetQueryStatusWorkloadInsightsTopContributorsResponse GetQueryStatusWorkloadInsightsTopContributors(GetQueryStatusWorkloadInsightsTopContributorsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetQueryStatusWorkloadInsightsTopContributorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueryStatusWorkloadInsightsTopContributorsResponseUnmarshaller.Instance;

            return Invoke<GetQueryStatusWorkloadInsightsTopContributorsResponse>(request, options);
        }
#else
        internal virtual GetQueryStatusWorkloadInsightsTopContributorsResponse GetQueryStatusWorkloadInsightsTopContributors(GetQueryStatusWorkloadInsightsTopContributorsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetQueryStatusWorkloadInsightsTopContributorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueryStatusWorkloadInsightsTopContributorsResponseUnmarshaller.Instance;

            return Invoke<GetQueryStatusWorkloadInsightsTopContributorsResponse>(request, options);
        }
#endif

        /// <summary>
        /// Return the data for a query with the Network Flow Monitor query interface. Specify
        /// the query that you want to return results for by providing a query ID and a monitor
        /// name. This query returns the top contributors for workload insights.
        /// 
        ///  
        /// <para>
        /// When you start a query, use this call to check the status of the query to make sure
        /// that it has has <c>SUCCEEDED</c> before you review the results. Use the same query
        /// ID that you used for the corresponding API call to start the query, <c>StartQueryWorkloadInsightsTopContributors</c>.
        /// </para>
        ///  
        /// <para>
        /// Top contributors in Network Flow Monitor are network flows with the highest values
        /// for a specific metric type. Top contributors can be across all workload insights,
        /// for a given scope, or for a specific monitor. Use the applicable call for the top
        /// contributors that you want to be returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQueryStatusWorkloadInsightsTopContributors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetQueryStatusWorkloadInsightsTopContributors service method, as returned by NetworkFlowMonitor.</returns>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ServiceQuotaExceededException">
        /// The request exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/GetQueryStatusWorkloadInsightsTopContributors">REST API Reference for GetQueryStatusWorkloadInsightsTopContributors Operation</seealso>
        public virtual Task<GetQueryStatusWorkloadInsightsTopContributorsResponse> GetQueryStatusWorkloadInsightsTopContributorsAsync(GetQueryStatusWorkloadInsightsTopContributorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetQueryStatusWorkloadInsightsTopContributorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueryStatusWorkloadInsightsTopContributorsResponseUnmarshaller.Instance;

            return InvokeAsync<GetQueryStatusWorkloadInsightsTopContributorsResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Returns the current status of a query for the Network Flow Monitor query interface,
        /// for a specified query ID and monitor. This call returns the query status for the top
        /// contributors data for workload insights.
        /// 
        ///  
        /// <para>
        /// When you start a query, use this call to check the status of the query to make sure
        /// that it has has <c>SUCCEEDED</c> before you review the results. Use the same query
        /// ID that you used for the corresponding API call to start the query, <c>StartQueryWorkloadInsightsTopContributorsData</c>.
        /// </para>
        ///  
        /// <para>
        /// Top contributors in Network Flow Monitor are network flows with the highest values
        /// for a specific metric type. Top contributors can be across all workload insights,
        /// for a given scope, or for a specific monitor. Use the applicable call for the top
        /// contributors that you want to be returned.
        /// </para>
        ///  
        /// <para>
        /// The top contributor network flows overall are for a specific metric type, for example,
        /// the number of retransmissions.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQueryStatusWorkloadInsightsTopContributorsData service method.</param>
        /// <returns>The response from the GetQueryStatusWorkloadInsightsTopContributorsData service method, as returned by NetworkFlowMonitor.</returns>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ServiceQuotaExceededException">
        /// The request exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/GetQueryStatusWorkloadInsightsTopContributorsData">REST API Reference for GetQueryStatusWorkloadInsightsTopContributorsData Operation</seealso>
        public virtual GetQueryStatusWorkloadInsightsTopContributorsDataResponse GetQueryStatusWorkloadInsightsTopContributorsData(GetQueryStatusWorkloadInsightsTopContributorsDataRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetQueryStatusWorkloadInsightsTopContributorsDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueryStatusWorkloadInsightsTopContributorsDataResponseUnmarshaller.Instance;

            return Invoke<GetQueryStatusWorkloadInsightsTopContributorsDataResponse>(request, options);
        }
#else
        internal virtual GetQueryStatusWorkloadInsightsTopContributorsDataResponse GetQueryStatusWorkloadInsightsTopContributorsData(GetQueryStatusWorkloadInsightsTopContributorsDataRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetQueryStatusWorkloadInsightsTopContributorsDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueryStatusWorkloadInsightsTopContributorsDataResponseUnmarshaller.Instance;

            return Invoke<GetQueryStatusWorkloadInsightsTopContributorsDataResponse>(request, options);
        }
#endif

        /// <summary>
        /// Returns the current status of a query for the Network Flow Monitor query interface,
        /// for a specified query ID and monitor. This call returns the query status for the top
        /// contributors data for workload insights.
        /// 
        ///  
        /// <para>
        /// When you start a query, use this call to check the status of the query to make sure
        /// that it has has <c>SUCCEEDED</c> before you review the results. Use the same query
        /// ID that you used for the corresponding API call to start the query, <c>StartQueryWorkloadInsightsTopContributorsData</c>.
        /// </para>
        ///  
        /// <para>
        /// Top contributors in Network Flow Monitor are network flows with the highest values
        /// for a specific metric type. Top contributors can be across all workload insights,
        /// for a given scope, or for a specific monitor. Use the applicable call for the top
        /// contributors that you want to be returned.
        /// </para>
        ///  
        /// <para>
        /// The top contributor network flows overall are for a specific metric type, for example,
        /// the number of retransmissions.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQueryStatusWorkloadInsightsTopContributorsData service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetQueryStatusWorkloadInsightsTopContributorsData service method, as returned by NetworkFlowMonitor.</returns>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ServiceQuotaExceededException">
        /// The request exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/GetQueryStatusWorkloadInsightsTopContributorsData">REST API Reference for GetQueryStatusWorkloadInsightsTopContributorsData Operation</seealso>
        public virtual Task<GetQueryStatusWorkloadInsightsTopContributorsDataResponse> GetQueryStatusWorkloadInsightsTopContributorsDataAsync(GetQueryStatusWorkloadInsightsTopContributorsDataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetQueryStatusWorkloadInsightsTopContributorsDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueryStatusWorkloadInsightsTopContributorsDataResponseUnmarshaller.Instance;

            return InvokeAsync<GetQueryStatusWorkloadInsightsTopContributorsDataResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Gets information about a scope, including the name, status, tags, and target details.
        /// The scope in Network Flow Monitor is an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetScope service method.</param>
        /// <returns>The response from the GetScope service method, as returned by NetworkFlowMonitor.</returns>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ResourceNotFoundException">
        /// The request specifies a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ServiceQuotaExceededException">
        /// The request exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/GetScope">REST API Reference for GetScope Operation</seealso>
        public virtual GetScopeResponse GetScope(GetScopeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetScopeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetScopeResponseUnmarshaller.Instance;

            return Invoke<GetScopeResponse>(request, options);
        }
#else
        internal virtual GetScopeResponse GetScope(GetScopeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetScopeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetScopeResponseUnmarshaller.Instance;

            return Invoke<GetScopeResponse>(request, options);
        }
#endif

        /// <summary>
        /// Gets information about a scope, including the name, status, tags, and target details.
        /// The scope in Network Flow Monitor is an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetScope service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetScope service method, as returned by NetworkFlowMonitor.</returns>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ResourceNotFoundException">
        /// The request specifies a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ServiceQuotaExceededException">
        /// The request exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/GetScope">REST API Reference for GetScope Operation</seealso>
        public virtual Task<GetScopeResponse> GetScopeAsync(GetScopeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetScopeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetScopeResponseUnmarshaller.Instance;

            return InvokeAsync<GetScopeResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// List all monitors in an account. Optionally, you can list only monitors that have
        /// a specific status, by using the <c>STATUS</c> parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMonitors service method.</param>
        /// <returns>The response from the ListMonitors service method, as returned by NetworkFlowMonitor.</returns>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/ListMonitors">REST API Reference for ListMonitors Operation</seealso>
        public virtual ListMonitorsResponse ListMonitors(ListMonitorsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMonitorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMonitorsResponseUnmarshaller.Instance;

            return Invoke<ListMonitorsResponse>(request, options);
        }
#else
        internal virtual ListMonitorsResponse ListMonitors(ListMonitorsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMonitorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMonitorsResponseUnmarshaller.Instance;

            return Invoke<ListMonitorsResponse>(request, options);
        }
#endif

        /// <summary>
        /// List all monitors in an account. Optionally, you can list only monitors that have
        /// a specific status, by using the <c>STATUS</c> parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMonitors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListMonitors service method, as returned by NetworkFlowMonitor.</returns>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/ListMonitors">REST API Reference for ListMonitors Operation</seealso>
        public virtual Task<ListMonitorsResponse> ListMonitorsAsync(ListMonitorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMonitorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMonitorsResponseUnmarshaller.Instance;

            return InvokeAsync<ListMonitorsResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Returns a list of the performance monitors in an account. You can optionally return
        /// only the monitors that have a specific status or type.
        /// 
        ///  
        /// <para>
        /// Results are paginated. Use the <c>nextToken</c> parameter to return additional results.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPerformanceMonitors service method.</param>
        /// <returns>The response from the ListPerformanceMonitors service method, as returned by NetworkFlowMonitor.</returns>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/ListPerformanceMonitors">REST API Reference for ListPerformanceMonitors Operation</seealso>
        public virtual ListPerformanceMonitorsResponse ListPerformanceMonitors(ListPerformanceMonitorsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPerformanceMonitorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPerformanceMonitorsResponseUnmarshaller.Instance;

            return Invoke<ListPerformanceMonitorsResponse>(request, options);
        }
#else
        internal virtual ListPerformanceMonitorsResponse ListPerformanceMonitors(ListPerformanceMonitorsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPerformanceMonitorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPerformanceMonitorsResponseUnmarshaller.Instance;

            return Invoke<ListPerformanceMonitorsResponse>(request, options);
        }
#endif

        /// <summary>
        /// Returns a list of the performance monitors in an account. You can optionally return
        /// only the monitors that have a specific status or type.
        /// 
        ///  
        /// <para>
        /// Results are paginated. Use the <c>nextToken</c> parameter to return additional results.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPerformanceMonitors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListPerformanceMonitors service method, as returned by NetworkFlowMonitor.</returns>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/ListPerformanceMonitors">REST API Reference for ListPerformanceMonitors Operation</seealso>
        public virtual Task<ListPerformanceMonitorsResponse> ListPerformanceMonitorsAsync(ListPerformanceMonitorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPerformanceMonitorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPerformanceMonitorsResponseUnmarshaller.Instance;

            return InvokeAsync<ListPerformanceMonitorsResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// List all the scopes for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListScopes service method.</param>
        /// <returns>The response from the ListScopes service method, as returned by NetworkFlowMonitor.</returns>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ServiceQuotaExceededException">
        /// The request exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/ListScopes">REST API Reference for ListScopes Operation</seealso>
        public virtual ListScopesResponse ListScopes(ListScopesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListScopesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListScopesResponseUnmarshaller.Instance;

            return Invoke<ListScopesResponse>(request, options);
        }
#else
        internal virtual ListScopesResponse ListScopes(ListScopesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListScopesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListScopesResponseUnmarshaller.Instance;

            return Invoke<ListScopesResponse>(request, options);
        }
#endif

        /// <summary>
        /// List all the scopes for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListScopes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListScopes service method, as returned by NetworkFlowMonitor.</returns>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ServiceQuotaExceededException">
        /// The request exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/ListScopes">REST API Reference for ListScopes Operation</seealso>
        public virtual Task<ListScopesResponse> ListScopesAsync(ListScopesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListScopesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListScopesResponseUnmarshaller.Instance;

            return InvokeAsync<ListScopesResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Returns all the tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <returns>The response from the ListTagsForResource service method, as returned by NetworkFlowMonitor.</returns>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ConflictException">
        /// The requested resource is in use.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ResourceNotFoundException">
        /// The request specifies a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// Returns all the tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListTagsForResource service method, as returned by NetworkFlowMonitor.</returns>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ConflictException">
        /// The requested resource is in use.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ResourceNotFoundException">
        /// The request specifies a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Create a query that you can use with the Network Flow Monitor query interface to return
        /// the top contributors for a monitor. Specify the monitor that you want to create the
        /// query for. 
        /// 
        ///  
        /// <para>
        /// The call returns a query ID that you can use with <a href="https://docs.aws.amazon.com/networkflowmonitor/2.0/APIReference/API_GetQueryResultsMonitorTopContributors.html">
        /// GetQueryResultsMonitorTopContributors</a> to run the query and return the top contributors
        /// for a specific monitor.
        /// </para>
        ///  
        /// <para>
        /// Top contributors in Network Flow Monitor are network flows with the highest values
        /// for a specific metric type. Top contributors can be across all workload insights,
        /// for a given scope, or for a specific monitor. Use the applicable APIs for the top
        /// contributors that you want to be returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartQueryMonitorTopContributors service method.</param>
        /// <returns>The response from the StartQueryMonitorTopContributors service method, as returned by NetworkFlowMonitor.</returns>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ServiceQuotaExceededException">
        /// The request exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/StartQueryMonitorTopContributors">REST API Reference for StartQueryMonitorTopContributors Operation</seealso>
        public virtual StartQueryMonitorTopContributorsResponse StartQueryMonitorTopContributors(StartQueryMonitorTopContributorsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartQueryMonitorTopContributorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartQueryMonitorTopContributorsResponseUnmarshaller.Instance;

            return Invoke<StartQueryMonitorTopContributorsResponse>(request, options);
        }
#else
        internal virtual StartQueryMonitorTopContributorsResponse StartQueryMonitorTopContributors(StartQueryMonitorTopContributorsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartQueryMonitorTopContributorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartQueryMonitorTopContributorsResponseUnmarshaller.Instance;

            return Invoke<StartQueryMonitorTopContributorsResponse>(request, options);
        }
#endif

        /// <summary>
        /// Create a query that you can use with the Network Flow Monitor query interface to return
        /// the top contributors for a monitor. Specify the monitor that you want to create the
        /// query for. 
        /// 
        ///  
        /// <para>
        /// The call returns a query ID that you can use with <a href="https://docs.aws.amazon.com/networkflowmonitor/2.0/APIReference/API_GetQueryResultsMonitorTopContributors.html">
        /// GetQueryResultsMonitorTopContributors</a> to run the query and return the top contributors
        /// for a specific monitor.
        /// </para>
        ///  
        /// <para>
        /// Top contributors in Network Flow Monitor are network flows with the highest values
        /// for a specific metric type. Top contributors can be across all workload insights,
        /// for a given scope, or for a specific monitor. Use the applicable APIs for the top
        /// contributors that you want to be returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartQueryMonitorTopContributors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the StartQueryMonitorTopContributors service method, as returned by NetworkFlowMonitor.</returns>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ServiceQuotaExceededException">
        /// The request exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/StartQueryMonitorTopContributors">REST API Reference for StartQueryMonitorTopContributors Operation</seealso>
        public virtual Task<StartQueryMonitorTopContributorsResponse> StartQueryMonitorTopContributorsAsync(StartQueryMonitorTopContributorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartQueryMonitorTopContributorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartQueryMonitorTopContributorsResponseUnmarshaller.Instance;

            return InvokeAsync<StartQueryMonitorTopContributorsResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Create a query that you can use with the Network Flow Monitor query interface to return
        /// the top paths for a performance monitor. Specify the performance monitor that you
        /// want to create the query for.
        /// 
        ///  
        /// <para>
        /// The call returns a query ID that you can use with <a href="https://docs.aws.amazon.com/networkflowmonitor/2.0/APIReference/API_GetQueryResultsPerformanceMonitor.html">
        /// GetQueryResultsPerformanceMonitor</a> to return the results of the query.
        /// </para>
        ///  
        /// <para>
        /// Top paths in Network Flow Monitor are the network paths used by the traffic for the
        /// resources that a performance monitor tracks, ranked by impact score and then by traffic
        /// volume. Each path includes the traffic and round-trip time for the path, together
        /// with a breakdown of the subnet pairs that the path includes.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartQueryPerformanceMonitor service method.</param>
        /// <returns>The response from the StartQueryPerformanceMonitor service method, as returned by NetworkFlowMonitor.</returns>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ResourceNotFoundException">
        /// The request specifies a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ServiceQuotaExceededException">
        /// The request exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/StartQueryPerformanceMonitor">REST API Reference for StartQueryPerformanceMonitor Operation</seealso>
        public virtual StartQueryPerformanceMonitorResponse StartQueryPerformanceMonitor(StartQueryPerformanceMonitorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartQueryPerformanceMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartQueryPerformanceMonitorResponseUnmarshaller.Instance;

            return Invoke<StartQueryPerformanceMonitorResponse>(request, options);
        }
#else
        internal virtual StartQueryPerformanceMonitorResponse StartQueryPerformanceMonitor(StartQueryPerformanceMonitorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartQueryPerformanceMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartQueryPerformanceMonitorResponseUnmarshaller.Instance;

            return Invoke<StartQueryPerformanceMonitorResponse>(request, options);
        }
#endif

        /// <summary>
        /// Create a query that you can use with the Network Flow Monitor query interface to return
        /// the top paths for a performance monitor. Specify the performance monitor that you
        /// want to create the query for.
        /// 
        ///  
        /// <para>
        /// The call returns a query ID that you can use with <a href="https://docs.aws.amazon.com/networkflowmonitor/2.0/APIReference/API_GetQueryResultsPerformanceMonitor.html">
        /// GetQueryResultsPerformanceMonitor</a> to return the results of the query.
        /// </para>
        ///  
        /// <para>
        /// Top paths in Network Flow Monitor are the network paths used by the traffic for the
        /// resources that a performance monitor tracks, ranked by impact score and then by traffic
        /// volume. Each path includes the traffic and round-trip time for the path, together
        /// with a breakdown of the subnet pairs that the path includes.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartQueryPerformanceMonitor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the StartQueryPerformanceMonitor service method, as returned by NetworkFlowMonitor.</returns>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ResourceNotFoundException">
        /// The request specifies a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ServiceQuotaExceededException">
        /// The request exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/StartQueryPerformanceMonitor">REST API Reference for StartQueryPerformanceMonitor Operation</seealso>
        public virtual Task<StartQueryPerformanceMonitorResponse> StartQueryPerformanceMonitorAsync(StartQueryPerformanceMonitorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartQueryPerformanceMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartQueryPerformanceMonitorResponseUnmarshaller.Instance;

            return InvokeAsync<StartQueryPerformanceMonitorResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Create a query with the Network Flow Monitor query interface that you can run to return
        /// workload insights top contributors. Specify the scope that you want to create a query
        /// for.
        /// 
        ///  
        /// <para>
        /// The call returns a query ID that you can use with <a href="https://docs.aws.amazon.com/networkflowmonitor/2.0/APIReference/API_GetQueryResultsWorkloadInsightsTopContributors.html">
        /// GetQueryResultsWorkloadInsightsTopContributors</a> to run the query and return the
        /// top contributors for the workload insights for a scope.
        /// </para>
        ///  
        /// <para>
        /// Top contributors in Network Flow Monitor are network flows with the highest values
        /// for a specific metric type. Top contributors can be across all workload insights,
        /// for a given scope, or for a specific monitor. Use the applicable APIs for the top
        /// contributors that you want to be returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartQueryWorkloadInsightsTopContributors service method.</param>
        /// <returns>The response from the StartQueryWorkloadInsightsTopContributors service method, as returned by NetworkFlowMonitor.</returns>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ServiceQuotaExceededException">
        /// The request exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/StartQueryWorkloadInsightsTopContributors">REST API Reference for StartQueryWorkloadInsightsTopContributors Operation</seealso>
        public virtual StartQueryWorkloadInsightsTopContributorsResponse StartQueryWorkloadInsightsTopContributors(StartQueryWorkloadInsightsTopContributorsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartQueryWorkloadInsightsTopContributorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartQueryWorkloadInsightsTopContributorsResponseUnmarshaller.Instance;

            return Invoke<StartQueryWorkloadInsightsTopContributorsResponse>(request, options);
        }
#else
        internal virtual StartQueryWorkloadInsightsTopContributorsResponse StartQueryWorkloadInsightsTopContributors(StartQueryWorkloadInsightsTopContributorsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartQueryWorkloadInsightsTopContributorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartQueryWorkloadInsightsTopContributorsResponseUnmarshaller.Instance;

            return Invoke<StartQueryWorkloadInsightsTopContributorsResponse>(request, options);
        }
#endif

        /// <summary>
        /// Create a query with the Network Flow Monitor query interface that you can run to return
        /// workload insights top contributors. Specify the scope that you want to create a query
        /// for.
        /// 
        ///  
        /// <para>
        /// The call returns a query ID that you can use with <a href="https://docs.aws.amazon.com/networkflowmonitor/2.0/APIReference/API_GetQueryResultsWorkloadInsightsTopContributors.html">
        /// GetQueryResultsWorkloadInsightsTopContributors</a> to run the query and return the
        /// top contributors for the workload insights for a scope.
        /// </para>
        ///  
        /// <para>
        /// Top contributors in Network Flow Monitor are network flows with the highest values
        /// for a specific metric type. Top contributors can be across all workload insights,
        /// for a given scope, or for a specific monitor. Use the applicable APIs for the top
        /// contributors that you want to be returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartQueryWorkloadInsightsTopContributors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the StartQueryWorkloadInsightsTopContributors service method, as returned by NetworkFlowMonitor.</returns>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ServiceQuotaExceededException">
        /// The request exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/StartQueryWorkloadInsightsTopContributors">REST API Reference for StartQueryWorkloadInsightsTopContributors Operation</seealso>
        public virtual Task<StartQueryWorkloadInsightsTopContributorsResponse> StartQueryWorkloadInsightsTopContributorsAsync(StartQueryWorkloadInsightsTopContributorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartQueryWorkloadInsightsTopContributorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartQueryWorkloadInsightsTopContributorsResponseUnmarshaller.Instance;

            return InvokeAsync<StartQueryWorkloadInsightsTopContributorsResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Create a query with the Network Flow Monitor query interface that you can run to return
        /// data for workload insights top contributors. Specify the scope that you want to create
        /// a query for.
        /// 
        ///  
        /// <para>
        /// The call returns a query ID that you can use with <a href="https://docs.aws.amazon.com/networkflowmonitor/2.0/APIReference/API_GetQueryResultsWorkloadInsightsTopContributorsData.html">
        /// GetQueryResultsWorkloadInsightsTopContributorsData</a> to run the query and return
        /// the data for the top contributors for the workload insights for a scope.
        /// </para>
        ///  
        /// <para>
        /// Top contributors in Network Flow Monitor are network flows with the highest values
        /// for a specific metric type. Top contributors can be across all workload insights,
        /// for a given scope, or for a specific monitor. Use the applicable call for the top
        /// contributors that you want to be returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartQueryWorkloadInsightsTopContributorsData service method.</param>
        /// <returns>The response from the StartQueryWorkloadInsightsTopContributorsData service method, as returned by NetworkFlowMonitor.</returns>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ServiceQuotaExceededException">
        /// The request exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/StartQueryWorkloadInsightsTopContributorsData">REST API Reference for StartQueryWorkloadInsightsTopContributorsData Operation</seealso>
        public virtual StartQueryWorkloadInsightsTopContributorsDataResponse StartQueryWorkloadInsightsTopContributorsData(StartQueryWorkloadInsightsTopContributorsDataRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartQueryWorkloadInsightsTopContributorsDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartQueryWorkloadInsightsTopContributorsDataResponseUnmarshaller.Instance;

            return Invoke<StartQueryWorkloadInsightsTopContributorsDataResponse>(request, options);
        }
#else
        internal virtual StartQueryWorkloadInsightsTopContributorsDataResponse StartQueryWorkloadInsightsTopContributorsData(StartQueryWorkloadInsightsTopContributorsDataRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartQueryWorkloadInsightsTopContributorsDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartQueryWorkloadInsightsTopContributorsDataResponseUnmarshaller.Instance;

            return Invoke<StartQueryWorkloadInsightsTopContributorsDataResponse>(request, options);
        }
#endif

        /// <summary>
        /// Create a query with the Network Flow Monitor query interface that you can run to return
        /// data for workload insights top contributors. Specify the scope that you want to create
        /// a query for.
        /// 
        ///  
        /// <para>
        /// The call returns a query ID that you can use with <a href="https://docs.aws.amazon.com/networkflowmonitor/2.0/APIReference/API_GetQueryResultsWorkloadInsightsTopContributorsData.html">
        /// GetQueryResultsWorkloadInsightsTopContributorsData</a> to run the query and return
        /// the data for the top contributors for the workload insights for a scope.
        /// </para>
        ///  
        /// <para>
        /// Top contributors in Network Flow Monitor are network flows with the highest values
        /// for a specific metric type. Top contributors can be across all workload insights,
        /// for a given scope, or for a specific monitor. Use the applicable call for the top
        /// contributors that you want to be returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartQueryWorkloadInsightsTopContributorsData service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the StartQueryWorkloadInsightsTopContributorsData service method, as returned by NetworkFlowMonitor.</returns>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ServiceQuotaExceededException">
        /// The request exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/StartQueryWorkloadInsightsTopContributorsData">REST API Reference for StartQueryWorkloadInsightsTopContributorsData Operation</seealso>
        public virtual Task<StartQueryWorkloadInsightsTopContributorsDataResponse> StartQueryWorkloadInsightsTopContributorsDataAsync(StartQueryWorkloadInsightsTopContributorsDataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartQueryWorkloadInsightsTopContributorsDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartQueryWorkloadInsightsTopContributorsDataResponseUnmarshaller.Instance;

            return InvokeAsync<StartQueryWorkloadInsightsTopContributorsDataResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Stop a top contributors query for a monitor. Specify the query that you want to stop
        /// by providing a query ID and a monitor name. 
        /// 
        ///  
        /// <para>
        /// Top contributors in Network Flow Monitor are network flows with the highest values
        /// for a specific metric type. Top contributors can be across all workload insights,
        /// for a given scope, or for a specific monitor. Use the applicable call for the top
        /// contributors that you want to be returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopQueryMonitorTopContributors service method.</param>
        /// <returns>The response from the StopQueryMonitorTopContributors service method, as returned by NetworkFlowMonitor.</returns>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ServiceQuotaExceededException">
        /// The request exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/StopQueryMonitorTopContributors">REST API Reference for StopQueryMonitorTopContributors Operation</seealso>
        public virtual StopQueryMonitorTopContributorsResponse StopQueryMonitorTopContributors(StopQueryMonitorTopContributorsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopQueryMonitorTopContributorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopQueryMonitorTopContributorsResponseUnmarshaller.Instance;

            return Invoke<StopQueryMonitorTopContributorsResponse>(request, options);
        }
#else
        internal virtual StopQueryMonitorTopContributorsResponse StopQueryMonitorTopContributors(StopQueryMonitorTopContributorsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopQueryMonitorTopContributorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopQueryMonitorTopContributorsResponseUnmarshaller.Instance;

            return Invoke<StopQueryMonitorTopContributorsResponse>(request, options);
        }
#endif

        /// <summary>
        /// Stop a top contributors query for a monitor. Specify the query that you want to stop
        /// by providing a query ID and a monitor name. 
        /// 
        ///  
        /// <para>
        /// Top contributors in Network Flow Monitor are network flows with the highest values
        /// for a specific metric type. Top contributors can be across all workload insights,
        /// for a given scope, or for a specific monitor. Use the applicable call for the top
        /// contributors that you want to be returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopQueryMonitorTopContributors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the StopQueryMonitorTopContributors service method, as returned by NetworkFlowMonitor.</returns>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ServiceQuotaExceededException">
        /// The request exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/StopQueryMonitorTopContributors">REST API Reference for StopQueryMonitorTopContributors Operation</seealso>
        public virtual Task<StopQueryMonitorTopContributorsResponse> StopQueryMonitorTopContributorsAsync(StopQueryMonitorTopContributorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopQueryMonitorTopContributorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopQueryMonitorTopContributorsResponseUnmarshaller.Instance;

            return InvokeAsync<StopQueryMonitorTopContributorsResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Stop a query for the Network Flow Monitor query interface, for a specified query ID
        /// and performance monitor. Use the same query ID that you used for the corresponding
        /// API call to start the query, <c>StartQueryPerformanceMonitor</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopQueryPerformanceMonitor service method.</param>
        /// <returns>The response from the StopQueryPerformanceMonitor service method, as returned by NetworkFlowMonitor.</returns>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ResourceNotFoundException">
        /// The request specifies a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ServiceQuotaExceededException">
        /// The request exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/StopQueryPerformanceMonitor">REST API Reference for StopQueryPerformanceMonitor Operation</seealso>
        public virtual StopQueryPerformanceMonitorResponse StopQueryPerformanceMonitor(StopQueryPerformanceMonitorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopQueryPerformanceMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopQueryPerformanceMonitorResponseUnmarshaller.Instance;

            return Invoke<StopQueryPerformanceMonitorResponse>(request, options);
        }
#else
        internal virtual StopQueryPerformanceMonitorResponse StopQueryPerformanceMonitor(StopQueryPerformanceMonitorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopQueryPerformanceMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopQueryPerformanceMonitorResponseUnmarshaller.Instance;

            return Invoke<StopQueryPerformanceMonitorResponse>(request, options);
        }
#endif

        /// <summary>
        /// Stop a query for the Network Flow Monitor query interface, for a specified query ID
        /// and performance monitor. Use the same query ID that you used for the corresponding
        /// API call to start the query, <c>StartQueryPerformanceMonitor</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopQueryPerformanceMonitor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the StopQueryPerformanceMonitor service method, as returned by NetworkFlowMonitor.</returns>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ResourceNotFoundException">
        /// The request specifies a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ServiceQuotaExceededException">
        /// The request exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/StopQueryPerformanceMonitor">REST API Reference for StopQueryPerformanceMonitor Operation</seealso>
        public virtual Task<StopQueryPerformanceMonitorResponse> StopQueryPerformanceMonitorAsync(StopQueryPerformanceMonitorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopQueryPerformanceMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopQueryPerformanceMonitorResponseUnmarshaller.Instance;

            return InvokeAsync<StopQueryPerformanceMonitorResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Stop a top contributors query for workload insights. Specify the query that you want
        /// to stop by providing a query ID and a scope ID. 
        /// 
        ///  
        /// <para>
        /// Top contributors in Network Flow Monitor are network flows with the highest values
        /// for a specific metric type. Top contributors can be across all workload insights,
        /// for a given scope, or for a specific monitor. Use the applicable call for the top
        /// contributors that you want to be returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopQueryWorkloadInsightsTopContributors service method.</param>
        /// <returns>The response from the StopQueryWorkloadInsightsTopContributors service method, as returned by NetworkFlowMonitor.</returns>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ServiceQuotaExceededException">
        /// The request exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/StopQueryWorkloadInsightsTopContributors">REST API Reference for StopQueryWorkloadInsightsTopContributors Operation</seealso>
        public virtual StopQueryWorkloadInsightsTopContributorsResponse StopQueryWorkloadInsightsTopContributors(StopQueryWorkloadInsightsTopContributorsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopQueryWorkloadInsightsTopContributorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopQueryWorkloadInsightsTopContributorsResponseUnmarshaller.Instance;

            return Invoke<StopQueryWorkloadInsightsTopContributorsResponse>(request, options);
        }
#else
        internal virtual StopQueryWorkloadInsightsTopContributorsResponse StopQueryWorkloadInsightsTopContributors(StopQueryWorkloadInsightsTopContributorsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopQueryWorkloadInsightsTopContributorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopQueryWorkloadInsightsTopContributorsResponseUnmarshaller.Instance;

            return Invoke<StopQueryWorkloadInsightsTopContributorsResponse>(request, options);
        }
#endif

        /// <summary>
        /// Stop a top contributors query for workload insights. Specify the query that you want
        /// to stop by providing a query ID and a scope ID. 
        /// 
        ///  
        /// <para>
        /// Top contributors in Network Flow Monitor are network flows with the highest values
        /// for a specific metric type. Top contributors can be across all workload insights,
        /// for a given scope, or for a specific monitor. Use the applicable call for the top
        /// contributors that you want to be returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopQueryWorkloadInsightsTopContributors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the StopQueryWorkloadInsightsTopContributors service method, as returned by NetworkFlowMonitor.</returns>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ServiceQuotaExceededException">
        /// The request exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/StopQueryWorkloadInsightsTopContributors">REST API Reference for StopQueryWorkloadInsightsTopContributors Operation</seealso>
        public virtual Task<StopQueryWorkloadInsightsTopContributorsResponse> StopQueryWorkloadInsightsTopContributorsAsync(StopQueryWorkloadInsightsTopContributorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopQueryWorkloadInsightsTopContributorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopQueryWorkloadInsightsTopContributorsResponseUnmarshaller.Instance;

            return InvokeAsync<StopQueryWorkloadInsightsTopContributorsResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Stop a top contributors data query for workload insights. Specify the query that you
        /// want to stop by providing a query ID and a scope ID. 
        /// 
        ///  
        /// <para>
        /// Top contributors in Network Flow Monitor are network flows with the highest values
        /// for a specific metric type. Top contributors can be across all workload insights,
        /// for a given scope, or for a specific monitor. Use the applicable call for the top
        /// contributors that you want to be returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopQueryWorkloadInsightsTopContributorsData service method.</param>
        /// <returns>The response from the StopQueryWorkloadInsightsTopContributorsData service method, as returned by NetworkFlowMonitor.</returns>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ServiceQuotaExceededException">
        /// The request exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/StopQueryWorkloadInsightsTopContributorsData">REST API Reference for StopQueryWorkloadInsightsTopContributorsData Operation</seealso>
        public virtual StopQueryWorkloadInsightsTopContributorsDataResponse StopQueryWorkloadInsightsTopContributorsData(StopQueryWorkloadInsightsTopContributorsDataRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopQueryWorkloadInsightsTopContributorsDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopQueryWorkloadInsightsTopContributorsDataResponseUnmarshaller.Instance;

            return Invoke<StopQueryWorkloadInsightsTopContributorsDataResponse>(request, options);
        }
#else
        internal virtual StopQueryWorkloadInsightsTopContributorsDataResponse StopQueryWorkloadInsightsTopContributorsData(StopQueryWorkloadInsightsTopContributorsDataRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopQueryWorkloadInsightsTopContributorsDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopQueryWorkloadInsightsTopContributorsDataResponseUnmarshaller.Instance;

            return Invoke<StopQueryWorkloadInsightsTopContributorsDataResponse>(request, options);
        }
#endif

        /// <summary>
        /// Stop a top contributors data query for workload insights. Specify the query that you
        /// want to stop by providing a query ID and a scope ID. 
        /// 
        ///  
        /// <para>
        /// Top contributors in Network Flow Monitor are network flows with the highest values
        /// for a specific metric type. Top contributors can be across all workload insights,
        /// for a given scope, or for a specific monitor. Use the applicable call for the top
        /// contributors that you want to be returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopQueryWorkloadInsightsTopContributorsData service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the StopQueryWorkloadInsightsTopContributorsData service method, as returned by NetworkFlowMonitor.</returns>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ServiceQuotaExceededException">
        /// The request exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/StopQueryWorkloadInsightsTopContributorsData">REST API Reference for StopQueryWorkloadInsightsTopContributorsData Operation</seealso>
        public virtual Task<StopQueryWorkloadInsightsTopContributorsDataResponse> StopQueryWorkloadInsightsTopContributorsDataAsync(StopQueryWorkloadInsightsTopContributorsDataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopQueryWorkloadInsightsTopContributorsDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopQueryWorkloadInsightsTopContributorsDataResponseUnmarshaller.Instance;

            return InvokeAsync<StopQueryWorkloadInsightsTopContributorsDataResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Adds a tag to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <returns>The response from the TagResource service method, as returned by NetworkFlowMonitor.</returns>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ConflictException">
        /// The requested resource is in use.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ResourceNotFoundException">
        /// The request specifies a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>The response from the TagResource service method, as returned by NetworkFlowMonitor.</returns>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ConflictException">
        /// The requested resource is in use.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ResourceNotFoundException">
        /// The request specifies a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>The response from the UntagResource service method, as returned by NetworkFlowMonitor.</returns>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ConflictException">
        /// The requested resource is in use.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ResourceNotFoundException">
        /// The request specifies a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>The response from the UntagResource service method, as returned by NetworkFlowMonitor.</returns>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ConflictException">
        /// The requested resource is in use.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ResourceNotFoundException">
        /// The request specifies a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Update a monitor to add or remove local or remote resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMonitor service method.</param>
        /// <returns>The response from the UpdateMonitor service method, as returned by NetworkFlowMonitor.</returns>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ResourceNotFoundException">
        /// The request specifies a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/UpdateMonitor">REST API Reference for UpdateMonitor Operation</seealso>
        public virtual UpdateMonitorResponse UpdateMonitor(UpdateMonitorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMonitorResponseUnmarshaller.Instance;

            return Invoke<UpdateMonitorResponse>(request, options);
        }
#else
        internal virtual UpdateMonitorResponse UpdateMonitor(UpdateMonitorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMonitorResponseUnmarshaller.Instance;

            return Invoke<UpdateMonitorResponse>(request, options);
        }
#endif

        /// <summary>
        /// Update a monitor to add or remove local or remote resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMonitor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateMonitor service method, as returned by NetworkFlowMonitor.</returns>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ResourceNotFoundException">
        /// The request specifies a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/UpdateMonitor">REST API Reference for UpdateMonitor Operation</seealso>
        public virtual Task<UpdateMonitorResponse> UpdateMonitorAsync(UpdateMonitorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMonitorResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateMonitorResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Update a performance monitor, to add or remove the resources that the monitor tracks
        /// network performance for.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePerformanceMonitor service method.</param>
        /// <returns>The response from the UpdatePerformanceMonitor service method, as returned by NetworkFlowMonitor.</returns>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ConflictException">
        /// The requested resource is in use.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ResourceNotFoundException">
        /// The request specifies a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ServiceQuotaExceededException">
        /// The request exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/UpdatePerformanceMonitor">REST API Reference for UpdatePerformanceMonitor Operation</seealso>
        public virtual UpdatePerformanceMonitorResponse UpdatePerformanceMonitor(UpdatePerformanceMonitorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePerformanceMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePerformanceMonitorResponseUnmarshaller.Instance;

            return Invoke<UpdatePerformanceMonitorResponse>(request, options);
        }
#else
        internal virtual UpdatePerformanceMonitorResponse UpdatePerformanceMonitor(UpdatePerformanceMonitorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePerformanceMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePerformanceMonitorResponseUnmarshaller.Instance;

            return Invoke<UpdatePerformanceMonitorResponse>(request, options);
        }
#endif

        /// <summary>
        /// Update a performance monitor, to add or remove the resources that the monitor tracks
        /// network performance for.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePerformanceMonitor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdatePerformanceMonitor service method, as returned by NetworkFlowMonitor.</returns>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ConflictException">
        /// The requested resource is in use.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ResourceNotFoundException">
        /// The request specifies a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ServiceQuotaExceededException">
        /// The request exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/UpdatePerformanceMonitor">REST API Reference for UpdatePerformanceMonitor Operation</seealso>
        public virtual Task<UpdatePerformanceMonitorResponse> UpdatePerformanceMonitorAsync(UpdatePerformanceMonitorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePerformanceMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePerformanceMonitorResponseUnmarshaller.Instance;

            return InvokeAsync<UpdatePerformanceMonitorResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Update a scope to add or remove resources that you want to be available for Network
        /// Flow Monitor to generate metrics for, when you have active agents on those resources
        /// sending metrics reports to the Network Flow Monitor backend.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateScope service method.</param>
        /// <returns>The response from the UpdateScope service method, as returned by NetworkFlowMonitor.</returns>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ConflictException">
        /// The requested resource is in use.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ResourceNotFoundException">
        /// The request specifies a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ServiceQuotaExceededException">
        /// The request exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/UpdateScope">REST API Reference for UpdateScope Operation</seealso>
        public virtual UpdateScopeResponse UpdateScope(UpdateScopeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateScopeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateScopeResponseUnmarshaller.Instance;

            return Invoke<UpdateScopeResponse>(request, options);
        }
#else
        internal virtual UpdateScopeResponse UpdateScope(UpdateScopeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateScopeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateScopeResponseUnmarshaller.Instance;

            return Invoke<UpdateScopeResponse>(request, options);
        }
#endif

        /// <summary>
        /// Update a scope to add or remove resources that you want to be available for Network
        /// Flow Monitor to generate metrics for, when you have active agents on those resources
        /// sending metrics reports to the Network Flow Monitor backend.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateScope service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateScope service method, as returned by NetworkFlowMonitor.</returns>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ConflictException">
        /// The requested resource is in use.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ResourceNotFoundException">
        /// The request specifies a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ServiceQuotaExceededException">
        /// The request exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkFlowMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/UpdateScope">REST API Reference for UpdateScope Operation</seealso>
        public virtual Task<UpdateScopeResponse> UpdateScopeAsync(UpdateScopeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateScopeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateScopeResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateScopeResponse>(request, options, cancellationToken);
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
