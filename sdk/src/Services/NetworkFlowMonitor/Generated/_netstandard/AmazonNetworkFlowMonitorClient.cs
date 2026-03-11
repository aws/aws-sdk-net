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
 * Do not modify this file. This file is generated from the networkflowmonitor-2023-04-19.normal.json service model.
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
        
        #region Constructors

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
        public AmazonNetworkFlowMonitorClient()
            : base(new AmazonNetworkFlowMonitorConfig()) { }

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
        public AmazonNetworkFlowMonitorClient(RegionEndpoint region)
            : base(new AmazonNetworkFlowMonitorConfig{RegionEndpoint = region}) { }

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
        public AmazonNetworkFlowMonitorClient(AmazonNetworkFlowMonitorConfig config)
            : base(config) { }


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
            : this(credentials, new AmazonNetworkFlowMonitorConfig{RegionEndpoint = region})
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
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonNetworkFlowMonitorConfig() {RegionEndpoint=region})
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
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonNetworkFlowMonitorConfig{RegionEndpoint = region})
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

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
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
#endif

        #region Overrides

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


        #region  CreateMonitor

        internal virtual CreateMonitorResponse CreateMonitor(CreateMonitorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMonitorResponseUnmarshaller.Instance;

            return Invoke<CreateMonitorResponse>(request, options);
        }



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
        /// 
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
        #endregion
        
        #region  CreateScope

        internal virtual CreateScopeResponse CreateScope(CreateScopeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateScopeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateScopeResponseUnmarshaller.Instance;

            return Invoke<CreateScopeResponse>(request, options);
        }



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
        /// 
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
        #endregion
        
        #region  DeleteMonitor

        internal virtual DeleteMonitorResponse DeleteMonitor(DeleteMonitorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMonitorResponseUnmarshaller.Instance;

            return Invoke<DeleteMonitorResponse>(request, options);
        }



        /// <summary>
        /// Deletes a monitor in Network Flow Monitor.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMonitor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        #endregion
        
        #region  DeleteScope

        internal virtual DeleteScopeResponse DeleteScope(DeleteScopeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteScopeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteScopeResponseUnmarshaller.Instance;

            return Invoke<DeleteScopeResponse>(request, options);
        }



        /// <summary>
        /// Deletes a scope that has been defined.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteScope service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        #endregion
        
        #region  GetMonitor

        internal virtual GetMonitorResponse GetMonitor(GetMonitorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMonitorResponseUnmarshaller.Instance;

            return Invoke<GetMonitorResponse>(request, options);
        }



        /// <summary>
        /// Gets information about a monitor in Network Flow Monitor based on a monitor name.
        /// The information returned includes the Amazon Resource Name (ARN), create time, modified
        /// time, resources included in the monitor, and status information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMonitor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        #endregion
        
        #region  GetQueryResultsMonitorTopContributors

        internal virtual GetQueryResultsMonitorTopContributorsResponse GetQueryResultsMonitorTopContributors(GetQueryResultsMonitorTopContributorsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetQueryResultsMonitorTopContributorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueryResultsMonitorTopContributorsResponseUnmarshaller.Instance;

            return Invoke<GetQueryResultsMonitorTopContributorsResponse>(request, options);
        }



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
        /// 
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
        #endregion
        
        #region  GetQueryResultsWorkloadInsightsTopContributors

        internal virtual GetQueryResultsWorkloadInsightsTopContributorsResponse GetQueryResultsWorkloadInsightsTopContributors(GetQueryResultsWorkloadInsightsTopContributorsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetQueryResultsWorkloadInsightsTopContributorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueryResultsWorkloadInsightsTopContributorsResponseUnmarshaller.Instance;

            return Invoke<GetQueryResultsWorkloadInsightsTopContributorsResponse>(request, options);
        }



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
        /// 
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
        #endregion
        
        #region  GetQueryResultsWorkloadInsightsTopContributorsData

        internal virtual GetQueryResultsWorkloadInsightsTopContributorsDataResponse GetQueryResultsWorkloadInsightsTopContributorsData(GetQueryResultsWorkloadInsightsTopContributorsDataRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetQueryResultsWorkloadInsightsTopContributorsDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueryResultsWorkloadInsightsTopContributorsDataResponseUnmarshaller.Instance;

            return Invoke<GetQueryResultsWorkloadInsightsTopContributorsDataResponse>(request, options);
        }



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
        /// 
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
        #endregion
        
        #region  GetQueryStatusMonitorTopContributors

        internal virtual GetQueryStatusMonitorTopContributorsResponse GetQueryStatusMonitorTopContributors(GetQueryStatusMonitorTopContributorsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetQueryStatusMonitorTopContributorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueryStatusMonitorTopContributorsResponseUnmarshaller.Instance;

            return Invoke<GetQueryStatusMonitorTopContributorsResponse>(request, options);
        }



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
        /// 
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
        #endregion
        
        #region  GetQueryStatusWorkloadInsightsTopContributors

        internal virtual GetQueryStatusWorkloadInsightsTopContributorsResponse GetQueryStatusWorkloadInsightsTopContributors(GetQueryStatusWorkloadInsightsTopContributorsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetQueryStatusWorkloadInsightsTopContributorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueryStatusWorkloadInsightsTopContributorsResponseUnmarshaller.Instance;

            return Invoke<GetQueryStatusWorkloadInsightsTopContributorsResponse>(request, options);
        }



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
        /// 
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
        #endregion
        
        #region  GetQueryStatusWorkloadInsightsTopContributorsData

        internal virtual GetQueryStatusWorkloadInsightsTopContributorsDataResponse GetQueryStatusWorkloadInsightsTopContributorsData(GetQueryStatusWorkloadInsightsTopContributorsDataRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetQueryStatusWorkloadInsightsTopContributorsDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueryStatusWorkloadInsightsTopContributorsDataResponseUnmarshaller.Instance;

            return Invoke<GetQueryStatusWorkloadInsightsTopContributorsDataResponse>(request, options);
        }



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
        /// 
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
        #endregion
        
        #region  GetScope

        internal virtual GetScopeResponse GetScope(GetScopeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetScopeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetScopeResponseUnmarshaller.Instance;

            return Invoke<GetScopeResponse>(request, options);
        }



        /// <summary>
        /// Gets information about a scope, including the name, status, tags, and target details.
        /// The scope in Network Flow Monitor is an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetScope service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        #endregion
        
        #region  ListMonitors

        internal virtual ListMonitorsResponse ListMonitors(ListMonitorsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMonitorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMonitorsResponseUnmarshaller.Instance;

            return Invoke<ListMonitorsResponse>(request, options);
        }



        /// <summary>
        /// List all monitors in an account. Optionally, you can list only monitors that have
        /// a specific status, by using the <c>STATUS</c> parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMonitors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        #endregion
        
        #region  ListScopes

        internal virtual ListScopesResponse ListScopes(ListScopesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListScopesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListScopesResponseUnmarshaller.Instance;

            return Invoke<ListScopesResponse>(request, options);
        }



        /// <summary>
        /// List all the scopes for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListScopes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        /// Returns all the tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        #endregion
        
        #region  StartQueryMonitorTopContributors

        internal virtual StartQueryMonitorTopContributorsResponse StartQueryMonitorTopContributors(StartQueryMonitorTopContributorsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartQueryMonitorTopContributorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartQueryMonitorTopContributorsResponseUnmarshaller.Instance;

            return Invoke<StartQueryMonitorTopContributorsResponse>(request, options);
        }



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
        /// 
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
        #endregion
        
        #region  StartQueryWorkloadInsightsTopContributors

        internal virtual StartQueryWorkloadInsightsTopContributorsResponse StartQueryWorkloadInsightsTopContributors(StartQueryWorkloadInsightsTopContributorsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartQueryWorkloadInsightsTopContributorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartQueryWorkloadInsightsTopContributorsResponseUnmarshaller.Instance;

            return Invoke<StartQueryWorkloadInsightsTopContributorsResponse>(request, options);
        }



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
        /// 
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
        #endregion
        
        #region  StartQueryWorkloadInsightsTopContributorsData

        internal virtual StartQueryWorkloadInsightsTopContributorsDataResponse StartQueryWorkloadInsightsTopContributorsData(StartQueryWorkloadInsightsTopContributorsDataRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartQueryWorkloadInsightsTopContributorsDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartQueryWorkloadInsightsTopContributorsDataResponseUnmarshaller.Instance;

            return Invoke<StartQueryWorkloadInsightsTopContributorsDataResponse>(request, options);
        }



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
        /// 
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
        #endregion
        
        #region  StopQueryMonitorTopContributors

        internal virtual StopQueryMonitorTopContributorsResponse StopQueryMonitorTopContributors(StopQueryMonitorTopContributorsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopQueryMonitorTopContributorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopQueryMonitorTopContributorsResponseUnmarshaller.Instance;

            return Invoke<StopQueryMonitorTopContributorsResponse>(request, options);
        }



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
        /// 
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
        #endregion
        
        #region  StopQueryWorkloadInsightsTopContributors

        internal virtual StopQueryWorkloadInsightsTopContributorsResponse StopQueryWorkloadInsightsTopContributors(StopQueryWorkloadInsightsTopContributorsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopQueryWorkloadInsightsTopContributorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopQueryWorkloadInsightsTopContributorsResponseUnmarshaller.Instance;

            return Invoke<StopQueryWorkloadInsightsTopContributorsResponse>(request, options);
        }



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
        /// 
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
        #endregion
        
        #region  StopQueryWorkloadInsightsTopContributorsData

        internal virtual StopQueryWorkloadInsightsTopContributorsDataResponse StopQueryWorkloadInsightsTopContributorsData(StopQueryWorkloadInsightsTopContributorsDataRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopQueryWorkloadInsightsTopContributorsDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopQueryWorkloadInsightsTopContributorsDataResponseUnmarshaller.Instance;

            return Invoke<StopQueryWorkloadInsightsTopContributorsDataResponse>(request, options);
        }



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
        /// 
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
        /// Adds a tag to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        /// Removes a tag from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        #endregion
        
        #region  UpdateMonitor

        internal virtual UpdateMonitorResponse UpdateMonitor(UpdateMonitorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMonitorResponseUnmarshaller.Instance;

            return Invoke<UpdateMonitorResponse>(request, options);
        }



        /// <summary>
        /// Update a monitor to add or remove local or remote resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMonitor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        #endregion
        
        #region  UpdateScope

        internal virtual UpdateScopeResponse UpdateScope(UpdateScopeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateScopeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateScopeResponseUnmarshaller.Instance;

            return Invoke<UpdateScopeResponse>(request, options);
        }



        /// <summary>
        /// Update a scope to add or remove resources that you want to be available for Network
        /// Flow Monitor to generate metrics for, when you have active agents on those resources
        /// sending metrics reports to the Network Flow Monitor backend.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateScope service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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