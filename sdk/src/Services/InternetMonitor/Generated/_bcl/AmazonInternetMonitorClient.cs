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
 * Do not modify this file. This file is generated from the internetmonitor-2021-06-03.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.InternetMonitor.Model;
using Amazon.InternetMonitor.Model.Internal.MarshallTransformations;
using Amazon.InternetMonitor.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.InternetMonitor
{
    /// <summary>
    /// <para>Implementation for accessing InternetMonitor</para>
    ///
    /// Amazon CloudWatch Internet Monitor provides visibility into how internet issues impact
    /// the performance and availability between your applications hosted on Amazon Web Services
    /// and your end users. It can reduce the time it takes for you to diagnose internet issues
    /// from days to minutes. Internet Monitor uses the connectivity data that Amazon Web
    /// Services captures from its global networking footprint to calculate a baseline of
    /// performance and availability for internet traffic. This is the same data that Amazon
    /// Web Services uses to monitor internet uptime and availability. With those measurements
    /// as a baseline, Internet Monitor raises awareness for you when there are significant
    /// problems for your end users in the different geographic locations where your application
    /// runs.
    /// 
    ///  
    /// <para>
    /// Internet Monitor publishes internet measurements to CloudWatch Logs and CloudWatch
    /// Metrics, to easily support using CloudWatch tools with health information for geographies
    /// and networks specific to your application. Internet Monitor sends health events to
    /// Amazon EventBridge so that you can set up notifications. If an issue is caused by
    /// the Amazon Web Services network, you also automatically receive an Amazon Web Services
    /// Health Dashboard notification with the steps that Amazon Web Services is taking to
    /// mitigate the problem.
    /// </para>
    ///  
    /// <para>
    /// To use Internet Monitor, you create a <i>monitor</i> and associate your application's
    /// resources with it - VPCs, NLBs, CloudFront distributions, or WorkSpaces directories
    /// - so Internet Monitor can determine where your application's internet traffic is.
    /// Internet Monitor then provides internet measurements from Amazon Web Services that
    /// are specific to the locations and ASNs (typically, internet service providers or ISPs)
    /// that communicate with your application.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-InternetMonitor.html">Using
    /// Amazon CloudWatch Internet Monitor</a> in the <i>Amazon CloudWatch User Guide</i>.
    /// </para>
    /// </summary>
    public partial class AmazonInternetMonitorClient : AmazonServiceClient, IAmazonInternetMonitor
    {
        private static IServiceMetadata serviceMetadata = new AmazonInternetMonitorMetadata();
        private IInternetMonitorPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IInternetMonitorPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new InternetMonitorPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonInternetMonitorClient with the credentials loaded from the application's
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
        public AmazonInternetMonitorClient()
            : base(new AmazonInternetMonitorConfig()) { }

        /// <summary>
        /// Constructs AmazonInternetMonitorClient with the credentials loaded from the application's
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
        public AmazonInternetMonitorClient(RegionEndpoint region)
            : base(new AmazonInternetMonitorConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonInternetMonitorClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonInternetMonitorClient Configuration Object</param>
        public AmazonInternetMonitorClient(AmazonInternetMonitorConfig config)
            : base(config) { }

        /// <summary>
        /// Constructs AmazonInternetMonitorClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonInternetMonitorClient(AWSCredentials credentials)
            : this(credentials, new AmazonInternetMonitorConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonInternetMonitorClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonInternetMonitorClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonInternetMonitorConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonInternetMonitorClient with AWS Credentials and an
        /// AmazonInternetMonitorClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonInternetMonitorClient Configuration Object</param>
        public AmazonInternetMonitorClient(AWSCredentials credentials, AmazonInternetMonitorConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonInternetMonitorClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonInternetMonitorClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonInternetMonitorConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonInternetMonitorClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonInternetMonitorClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonInternetMonitorConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonInternetMonitorClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonInternetMonitorClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonInternetMonitorClient Configuration Object</param>
        public AmazonInternetMonitorClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonInternetMonitorConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonInternetMonitorClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonInternetMonitorClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonInternetMonitorConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonInternetMonitorClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonInternetMonitorClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonInternetMonitorConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonInternetMonitorClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonInternetMonitorClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonInternetMonitorClient Configuration Object</param>
        public AmazonInternetMonitorClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonInternetMonitorConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides  

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonInternetMonitorEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonInternetMonitorAuthSchemeHandler());
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


        /// <summary>
        /// Creates a monitor in Amazon CloudWatch Internet Monitor. A monitor is built based
        /// on information from the application resources that you add: VPCs, Network Load Balancers
        /// (NLBs), Amazon CloudFront distributions, and Amazon WorkSpaces directories. Internet
        /// Monitor then publishes internet measurements from Amazon Web Services that are specific
        /// to the <i>city-networks</i>. That is, the locations and ASNs (typically internet service
        /// providers or ISPs), where clients access your application. For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-InternetMonitor.html">Using
        /// Amazon CloudWatch Internet Monitor</a> in the <i>Amazon CloudWatch User Guide</i>.
        /// 
        ///  
        /// <para>
        /// When you create a monitor, you choose the percentage of traffic that you want to monitor.
        /// You can also set a maximum limit for the number of city-networks where client traffic
        /// is monitored, that caps the total traffic that Internet Monitor monitors. A city-network
        /// maximum is the limit of city-networks, but you only pay for the number of city-networks
        /// that are actually monitored. You can update your monitor at any time to change the
        /// percentage of traffic to monitor or the city-networks maximum. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/IMCityNetworksMaximum.html">Choosing
        /// a city-network maximum value</a> in the <i>Amazon CloudWatch User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMonitor service method.</param>
        /// 
        /// <returns>The response from the CreateMonitor service method, as returned by InternetMonitor.</returns>
        /// <exception cref="Amazon.InternetMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.ConflictException">
        /// The requested resource is in use.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.LimitExceededException">
        /// The request exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/internetmonitor-2021-06-03/CreateMonitor">REST API Reference for CreateMonitor Operation</seealso>
        public virtual CreateMonitorResponse CreateMonitor(CreateMonitorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMonitorResponseUnmarshaller.Instance;

            return Invoke<CreateMonitorResponse>(request, options);
        }


        /// <summary>
        /// Creates a monitor in Amazon CloudWatch Internet Monitor. A monitor is built based
        /// on information from the application resources that you add: VPCs, Network Load Balancers
        /// (NLBs), Amazon CloudFront distributions, and Amazon WorkSpaces directories. Internet
        /// Monitor then publishes internet measurements from Amazon Web Services that are specific
        /// to the <i>city-networks</i>. That is, the locations and ASNs (typically internet service
        /// providers or ISPs), where clients access your application. For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-InternetMonitor.html">Using
        /// Amazon CloudWatch Internet Monitor</a> in the <i>Amazon CloudWatch User Guide</i>.
        /// 
        ///  
        /// <para>
        /// When you create a monitor, you choose the percentage of traffic that you want to monitor.
        /// You can also set a maximum limit for the number of city-networks where client traffic
        /// is monitored, that caps the total traffic that Internet Monitor monitors. A city-network
        /// maximum is the limit of city-networks, but you only pay for the number of city-networks
        /// that are actually monitored. You can update your monitor at any time to change the
        /// percentage of traffic to monitor or the city-networks maximum. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/IMCityNetworksMaximum.html">Choosing
        /// a city-network maximum value</a> in the <i>Amazon CloudWatch User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMonitor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMonitor service method, as returned by InternetMonitor.</returns>
        /// <exception cref="Amazon.InternetMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.ConflictException">
        /// The requested resource is in use.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.LimitExceededException">
        /// The request exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/internetmonitor-2021-06-03/CreateMonitor">REST API Reference for CreateMonitor Operation</seealso>
        public virtual Task<CreateMonitorResponse> CreateMonitorAsync(CreateMonitorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMonitorResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateMonitorResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteMonitor


        /// <summary>
        /// Deletes a monitor in Amazon CloudWatch Internet Monitor.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMonitor service method.</param>
        /// 
        /// <returns>The response from the DeleteMonitor service method, as returned by InternetMonitor.</returns>
        /// <exception cref="Amazon.InternetMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/internetmonitor-2021-06-03/DeleteMonitor">REST API Reference for DeleteMonitor Operation</seealso>
        public virtual DeleteMonitorResponse DeleteMonitor(DeleteMonitorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMonitorResponseUnmarshaller.Instance;

            return Invoke<DeleteMonitorResponse>(request, options);
        }


        /// <summary>
        /// Deletes a monitor in Amazon CloudWatch Internet Monitor.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMonitor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMonitor service method, as returned by InternetMonitor.</returns>
        /// <exception cref="Amazon.InternetMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/internetmonitor-2021-06-03/DeleteMonitor">REST API Reference for DeleteMonitor Operation</seealso>
        public virtual Task<DeleteMonitorResponse> DeleteMonitorAsync(DeleteMonitorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMonitorResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteMonitorResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetHealthEvent


        /// <summary>
        /// Gets information that Amazon CloudWatch Internet Monitor has created and stored about
        /// a health event for a specified monitor. This information includes the impacted locations,
        /// and all the information related to the event, by location.
        /// 
        ///  
        /// <para>
        /// The information returned includes the impact on performance, availability, and round-trip
        /// time, information about the network providers (ASNs), the event type, and so on.
        /// </para>
        ///  
        /// <para>
        /// Information rolled up at the global traffic level is also returned, including the
        /// impact type and total traffic impact.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetHealthEvent service method.</param>
        /// 
        /// <returns>The response from the GetHealthEvent service method, as returned by InternetMonitor.</returns>
        /// <exception cref="Amazon.InternetMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/internetmonitor-2021-06-03/GetHealthEvent">REST API Reference for GetHealthEvent Operation</seealso>
        public virtual GetHealthEventResponse GetHealthEvent(GetHealthEventRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetHealthEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetHealthEventResponseUnmarshaller.Instance;

            return Invoke<GetHealthEventResponse>(request, options);
        }


        /// <summary>
        /// Gets information that Amazon CloudWatch Internet Monitor has created and stored about
        /// a health event for a specified monitor. This information includes the impacted locations,
        /// and all the information related to the event, by location.
        /// 
        ///  
        /// <para>
        /// The information returned includes the impact on performance, availability, and round-trip
        /// time, information about the network providers (ASNs), the event type, and so on.
        /// </para>
        ///  
        /// <para>
        /// Information rolled up at the global traffic level is also returned, including the
        /// impact type and total traffic impact.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetHealthEvent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetHealthEvent service method, as returned by InternetMonitor.</returns>
        /// <exception cref="Amazon.InternetMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/internetmonitor-2021-06-03/GetHealthEvent">REST API Reference for GetHealthEvent Operation</seealso>
        public virtual Task<GetHealthEventResponse> GetHealthEventAsync(GetHealthEventRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetHealthEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetHealthEventResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetHealthEventResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetInternetEvent


        /// <summary>
        /// Gets information that Amazon CloudWatch Internet Monitor has generated about an internet
        /// event. Internet Monitor displays information about recent global health events, called
        /// internet events, on a global outages map that is available to all Amazon Web Services
        /// customers. 
        /// 
        ///  
        /// <para>
        /// The information returned here includes the impacted location, when the event started
        /// and (if the event is over) ended, the type of event (<c>PERFORMANCE</c> or <c>AVAILABILITY</c>),
        /// and the status (<c>ACTIVE</c> or <c>RESOLVED</c>).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInternetEvent service method.</param>
        /// 
        /// <returns>The response from the GetInternetEvent service method, as returned by InternetMonitor.</returns>
        /// <exception cref="Amazon.InternetMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/internetmonitor-2021-06-03/GetInternetEvent">REST API Reference for GetInternetEvent Operation</seealso>
        public virtual GetInternetEventResponse GetInternetEvent(GetInternetEventRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetInternetEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInternetEventResponseUnmarshaller.Instance;

            return Invoke<GetInternetEventResponse>(request, options);
        }


        /// <summary>
        /// Gets information that Amazon CloudWatch Internet Monitor has generated about an internet
        /// event. Internet Monitor displays information about recent global health events, called
        /// internet events, on a global outages map that is available to all Amazon Web Services
        /// customers. 
        /// 
        ///  
        /// <para>
        /// The information returned here includes the impacted location, when the event started
        /// and (if the event is over) ended, the type of event (<c>PERFORMANCE</c> or <c>AVAILABILITY</c>),
        /// and the status (<c>ACTIVE</c> or <c>RESOLVED</c>).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInternetEvent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetInternetEvent service method, as returned by InternetMonitor.</returns>
        /// <exception cref="Amazon.InternetMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/internetmonitor-2021-06-03/GetInternetEvent">REST API Reference for GetInternetEvent Operation</seealso>
        public virtual Task<GetInternetEventResponse> GetInternetEventAsync(GetInternetEventRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetInternetEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInternetEventResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetInternetEventResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetMonitor


        /// <summary>
        /// Gets information about a monitor in Amazon CloudWatch Internet Monitor based on a
        /// monitor name. The information returned includes the Amazon Resource Name (ARN), create
        /// time, modified time, resources included in the monitor, and status information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMonitor service method.</param>
        /// 
        /// <returns>The response from the GetMonitor service method, as returned by InternetMonitor.</returns>
        /// <exception cref="Amazon.InternetMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/internetmonitor-2021-06-03/GetMonitor">REST API Reference for GetMonitor Operation</seealso>
        public virtual GetMonitorResponse GetMonitor(GetMonitorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMonitorResponseUnmarshaller.Instance;

            return Invoke<GetMonitorResponse>(request, options);
        }


        /// <summary>
        /// Gets information about a monitor in Amazon CloudWatch Internet Monitor based on a
        /// monitor name. The information returned includes the Amazon Resource Name (ARN), create
        /// time, modified time, resources included in the monitor, and status information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMonitor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMonitor service method, as returned by InternetMonitor.</returns>
        /// <exception cref="Amazon.InternetMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/internetmonitor-2021-06-03/GetMonitor">REST API Reference for GetMonitor Operation</seealso>
        public virtual Task<GetMonitorResponse> GetMonitorAsync(GetMonitorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMonitorResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetMonitorResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetQueryResults


        /// <summary>
        /// Return the data for a query with the Amazon CloudWatch Internet Monitor query interface.
        /// Specify the query that you want to return results for by providing a <c>QueryId</c>
        /// and a monitor name.
        /// 
        ///  
        /// <para>
        /// For more information about using the query interface, including examples, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-IM-view-cw-tools-cwim-query.html">Using
        /// the Amazon CloudWatch Internet Monitor query interface</a> in the Amazon CloudWatch
        /// Internet Monitor User Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQueryResults service method.</param>
        /// 
        /// <returns>The response from the GetQueryResults service method, as returned by InternetMonitor.</returns>
        /// <exception cref="Amazon.InternetMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.LimitExceededException">
        /// The request exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/internetmonitor-2021-06-03/GetQueryResults">REST API Reference for GetQueryResults Operation</seealso>
        public virtual GetQueryResultsResponse GetQueryResults(GetQueryResultsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetQueryResultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueryResultsResponseUnmarshaller.Instance;

            return Invoke<GetQueryResultsResponse>(request, options);
        }


        /// <summary>
        /// Return the data for a query with the Amazon CloudWatch Internet Monitor query interface.
        /// Specify the query that you want to return results for by providing a <c>QueryId</c>
        /// and a monitor name.
        /// 
        ///  
        /// <para>
        /// For more information about using the query interface, including examples, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-IM-view-cw-tools-cwim-query.html">Using
        /// the Amazon CloudWatch Internet Monitor query interface</a> in the Amazon CloudWatch
        /// Internet Monitor User Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQueryResults service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetQueryResults service method, as returned by InternetMonitor.</returns>
        /// <exception cref="Amazon.InternetMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.LimitExceededException">
        /// The request exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/internetmonitor-2021-06-03/GetQueryResults">REST API Reference for GetQueryResults Operation</seealso>
        public virtual Task<GetQueryResultsResponse> GetQueryResultsAsync(GetQueryResultsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetQueryResultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueryResultsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetQueryResultsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetQueryStatus


        /// <summary>
        /// Returns the current status of a query for the Amazon CloudWatch Internet Monitor query
        /// interface, for a specified query ID and monitor. When you run a query, check the status
        /// to make sure that the query has <c>SUCCEEDED</c> before you review the results.
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <c>QUEUED</c>: The query is scheduled to run.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RUNNING</c>: The query is in progress but not complete.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SUCCEEDED</c>: The query completed sucessfully.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c>: The query failed due to an error.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CANCELED</c>: The query was canceled.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQueryStatus service method.</param>
        /// 
        /// <returns>The response from the GetQueryStatus service method, as returned by InternetMonitor.</returns>
        /// <exception cref="Amazon.InternetMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.LimitExceededException">
        /// The request exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/internetmonitor-2021-06-03/GetQueryStatus">REST API Reference for GetQueryStatus Operation</seealso>
        public virtual GetQueryStatusResponse GetQueryStatus(GetQueryStatusRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetQueryStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueryStatusResponseUnmarshaller.Instance;

            return Invoke<GetQueryStatusResponse>(request, options);
        }


        /// <summary>
        /// Returns the current status of a query for the Amazon CloudWatch Internet Monitor query
        /// interface, for a specified query ID and monitor. When you run a query, check the status
        /// to make sure that the query has <c>SUCCEEDED</c> before you review the results.
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <c>QUEUED</c>: The query is scheduled to run.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RUNNING</c>: The query is in progress but not complete.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SUCCEEDED</c>: The query completed sucessfully.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c>: The query failed due to an error.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CANCELED</c>: The query was canceled.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQueryStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetQueryStatus service method, as returned by InternetMonitor.</returns>
        /// <exception cref="Amazon.InternetMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.LimitExceededException">
        /// The request exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/internetmonitor-2021-06-03/GetQueryStatus">REST API Reference for GetQueryStatus Operation</seealso>
        public virtual Task<GetQueryStatusResponse> GetQueryStatusAsync(GetQueryStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetQueryStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueryStatusResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetQueryStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListHealthEvents


        /// <summary>
        /// Lists all health events for a monitor in Amazon CloudWatch Internet Monitor. Returns
        /// information for health events including the event start and end times, and the status.
        /// 
        ///  <note> 
        /// <para>
        /// Health events that have start times during the time frame that is requested are not
        /// included in the list of health events.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHealthEvents service method.</param>
        /// 
        /// <returns>The response from the ListHealthEvents service method, as returned by InternetMonitor.</returns>
        /// <exception cref="Amazon.InternetMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/internetmonitor-2021-06-03/ListHealthEvents">REST API Reference for ListHealthEvents Operation</seealso>
        public virtual ListHealthEventsResponse ListHealthEvents(ListHealthEventsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListHealthEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListHealthEventsResponseUnmarshaller.Instance;

            return Invoke<ListHealthEventsResponse>(request, options);
        }


        /// <summary>
        /// Lists all health events for a monitor in Amazon CloudWatch Internet Monitor. Returns
        /// information for health events including the event start and end times, and the status.
        /// 
        ///  <note> 
        /// <para>
        /// Health events that have start times during the time frame that is requested are not
        /// included in the list of health events.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHealthEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListHealthEvents service method, as returned by InternetMonitor.</returns>
        /// <exception cref="Amazon.InternetMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/internetmonitor-2021-06-03/ListHealthEvents">REST API Reference for ListHealthEvents Operation</seealso>
        public virtual Task<ListHealthEventsResponse> ListHealthEventsAsync(ListHealthEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListHealthEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListHealthEventsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListHealthEventsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListInternetEvents


        /// <summary>
        /// Lists internet events that cause performance or availability issues for client locations.
        /// Amazon CloudWatch Internet Monitor displays information about recent global health
        /// events, called internet events, on a global outages map that is available to all Amazon
        /// Web Services customers. 
        /// 
        ///  
        /// <para>
        /// You can constrain the list of internet events returned by providing a start time and
        /// end time to define a total time frame for events you want to list. Both start time
        /// and end time specify the time when an event started. End time is optional. If you
        /// don't include it, the default end time is the current time.
        /// </para>
        ///  
        /// <para>
        /// You can also limit the events returned to a specific status (<c>ACTIVE</c> or <c>RESOLVED</c>)
        /// or type (<c>PERFORMANCE</c> or <c>AVAILABILITY</c>).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInternetEvents service method.</param>
        /// 
        /// <returns>The response from the ListInternetEvents service method, as returned by InternetMonitor.</returns>
        /// <exception cref="Amazon.InternetMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/internetmonitor-2021-06-03/ListInternetEvents">REST API Reference for ListInternetEvents Operation</seealso>
        public virtual ListInternetEventsResponse ListInternetEvents(ListInternetEventsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListInternetEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInternetEventsResponseUnmarshaller.Instance;

            return Invoke<ListInternetEventsResponse>(request, options);
        }


        /// <summary>
        /// Lists internet events that cause performance or availability issues for client locations.
        /// Amazon CloudWatch Internet Monitor displays information about recent global health
        /// events, called internet events, on a global outages map that is available to all Amazon
        /// Web Services customers. 
        /// 
        ///  
        /// <para>
        /// You can constrain the list of internet events returned by providing a start time and
        /// end time to define a total time frame for events you want to list. Both start time
        /// and end time specify the time when an event started. End time is optional. If you
        /// don't include it, the default end time is the current time.
        /// </para>
        ///  
        /// <para>
        /// You can also limit the events returned to a specific status (<c>ACTIVE</c> or <c>RESOLVED</c>)
        /// or type (<c>PERFORMANCE</c> or <c>AVAILABILITY</c>).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInternetEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListInternetEvents service method, as returned by InternetMonitor.</returns>
        /// <exception cref="Amazon.InternetMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/internetmonitor-2021-06-03/ListInternetEvents">REST API Reference for ListInternetEvents Operation</seealso>
        public virtual Task<ListInternetEventsResponse> ListInternetEventsAsync(ListInternetEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListInternetEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInternetEventsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListInternetEventsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListMonitors


        /// <summary>
        /// Lists all of your monitors for Amazon CloudWatch Internet Monitor and their statuses,
        /// along with the Amazon Resource Name (ARN) and name of each monitor.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMonitors service method.</param>
        /// 
        /// <returns>The response from the ListMonitors service method, as returned by InternetMonitor.</returns>
        /// <exception cref="Amazon.InternetMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/internetmonitor-2021-06-03/ListMonitors">REST API Reference for ListMonitors Operation</seealso>
        public virtual ListMonitorsResponse ListMonitors(ListMonitorsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMonitorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMonitorsResponseUnmarshaller.Instance;

            return Invoke<ListMonitorsResponse>(request, options);
        }


        /// <summary>
        /// Lists all of your monitors for Amazon CloudWatch Internet Monitor and their statuses,
        /// along with the Amazon Resource Name (ARN) and name of each monitor.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMonitors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMonitors service method, as returned by InternetMonitor.</returns>
        /// <exception cref="Amazon.InternetMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/internetmonitor-2021-06-03/ListMonitors">REST API Reference for ListMonitors Operation</seealso>
        public virtual Task<ListMonitorsResponse> ListMonitorsAsync(ListMonitorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMonitorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMonitorsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListMonitorsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags for a resource. Tags are supported only for monitors in Amazon CloudWatch
        /// Internet Monitor.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by InternetMonitor.</returns>
        /// <exception cref="Amazon.InternetMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.BadRequestException">
        /// A bad request was received.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.InternalServerErrorException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.NotFoundException">
        /// The request specifies something that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.TooManyRequestsException">
        /// There were too many requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/internetmonitor-2021-06-03/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


        /// <summary>
        /// Lists the tags for a resource. Tags are supported only for monitors in Amazon CloudWatch
        /// Internet Monitor.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by InternetMonitor.</returns>
        /// <exception cref="Amazon.InternetMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.BadRequestException">
        /// A bad request was received.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.InternalServerErrorException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.NotFoundException">
        /// The request specifies something that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.TooManyRequestsException">
        /// There were too many requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/internetmonitor-2021-06-03/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartQuery


        /// <summary>
        /// Start a query to return data for a specific query type for the Amazon CloudWatch Internet
        /// Monitor query interface. Specify a time period for the data that you want returned
        /// by using <c>StartTime</c> and <c>EndTime</c>. You filter the query results to return
        /// by providing parameters that you specify with <c>FilterParameters</c>.
        /// 
        ///  
        /// <para>
        /// For more information about using the query interface, including examples, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-IM-view-cw-tools-cwim-query.html">Using
        /// the Amazon CloudWatch Internet Monitor query interface</a> in the Amazon CloudWatch
        /// Internet Monitor User Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartQuery service method.</param>
        /// 
        /// <returns>The response from the StartQuery service method, as returned by InternetMonitor.</returns>
        /// <exception cref="Amazon.InternetMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.LimitExceededException">
        /// The request exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/internetmonitor-2021-06-03/StartQuery">REST API Reference for StartQuery Operation</seealso>
        public virtual StartQueryResponse StartQuery(StartQueryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartQueryResponseUnmarshaller.Instance;

            return Invoke<StartQueryResponse>(request, options);
        }


        /// <summary>
        /// Start a query to return data for a specific query type for the Amazon CloudWatch Internet
        /// Monitor query interface. Specify a time period for the data that you want returned
        /// by using <c>StartTime</c> and <c>EndTime</c>. You filter the query results to return
        /// by providing parameters that you specify with <c>FilterParameters</c>.
        /// 
        ///  
        /// <para>
        /// For more information about using the query interface, including examples, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-IM-view-cw-tools-cwim-query.html">Using
        /// the Amazon CloudWatch Internet Monitor query interface</a> in the Amazon CloudWatch
        /// Internet Monitor User Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartQuery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartQuery service method, as returned by InternetMonitor.</returns>
        /// <exception cref="Amazon.InternetMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.LimitExceededException">
        /// The request exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/internetmonitor-2021-06-03/StartQuery">REST API Reference for StartQuery Operation</seealso>
        public virtual Task<StartQueryResponse> StartQueryAsync(StartQueryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartQueryResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartQueryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopQuery


        /// <summary>
        /// Stop a query that is progress for a specific monitor.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopQuery service method.</param>
        /// 
        /// <returns>The response from the StopQuery service method, as returned by InternetMonitor.</returns>
        /// <exception cref="Amazon.InternetMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.LimitExceededException">
        /// The request exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/internetmonitor-2021-06-03/StopQuery">REST API Reference for StopQuery Operation</seealso>
        public virtual StopQueryResponse StopQuery(StopQueryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopQueryResponseUnmarshaller.Instance;

            return Invoke<StopQueryResponse>(request, options);
        }


        /// <summary>
        /// Stop a query that is progress for a specific monitor.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopQuery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopQuery service method, as returned by InternetMonitor.</returns>
        /// <exception cref="Amazon.InternetMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.LimitExceededException">
        /// The request exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/internetmonitor-2021-06-03/StopQuery">REST API Reference for StopQuery Operation</seealso>
        public virtual Task<StopQueryResponse> StopQueryAsync(StopQueryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopQueryResponseUnmarshaller.Instance;
            
            return InvokeAsync<StopQueryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds a tag to a resource. Tags are supported only for monitors in Amazon CloudWatch
        /// Internet Monitor. You can add a maximum of 50 tags in Internet Monitor.
        /// 
        ///  
        /// <para>
        /// A minimum of one tag is required for this call. It returns an error if you use the
        /// <c>TagResource</c> request with 0 tags.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by InternetMonitor.</returns>
        /// <exception cref="Amazon.InternetMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.BadRequestException">
        /// A bad request was received.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.InternalServerErrorException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.NotFoundException">
        /// The request specifies something that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.TooManyRequestsException">
        /// There were too many requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/internetmonitor-2021-06-03/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


        /// <summary>
        /// Adds a tag to a resource. Tags are supported only for monitors in Amazon CloudWatch
        /// Internet Monitor. You can add a maximum of 50 tags in Internet Monitor.
        /// 
        ///  
        /// <para>
        /// A minimum of one tag is required for this call. It returns an error if you use the
        /// <c>TagResource</c> request with 0 tags.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by InternetMonitor.</returns>
        /// <exception cref="Amazon.InternetMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.BadRequestException">
        /// A bad request was received.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.InternalServerErrorException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.NotFoundException">
        /// The request specifies something that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.TooManyRequestsException">
        /// There were too many requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/internetmonitor-2021-06-03/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes a tag from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by InternetMonitor.</returns>
        /// <exception cref="Amazon.InternetMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.BadRequestException">
        /// A bad request was received.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.InternalServerErrorException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.NotFoundException">
        /// The request specifies something that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.TooManyRequestsException">
        /// There were too many requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/internetmonitor-2021-06-03/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
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
        /// <returns>The response from the UntagResource service method, as returned by InternetMonitor.</returns>
        /// <exception cref="Amazon.InternetMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.BadRequestException">
        /// A bad request was received.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.InternalServerErrorException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.NotFoundException">
        /// The request specifies something that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.TooManyRequestsException">
        /// There were too many requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/internetmonitor-2021-06-03/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateMonitor


        /// <summary>
        /// Updates a monitor. You can update a monitor to change the percentage of traffic to
        /// monitor or the maximum number of city-networks (locations and ASNs), to add or remove
        /// resources, or to change the status of the monitor. Note that you can't change the
        /// name of a monitor.
        /// 
        ///  
        /// <para>
        /// The city-network maximum that you choose is the limit, but you only pay for the number
        /// of city-networks that are actually monitored. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/IMCityNetworksMaximum.html">Choosing
        /// a city-network maximum value</a> in the <i>Amazon CloudWatch User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMonitor service method.</param>
        /// 
        /// <returns>The response from the UpdateMonitor service method, as returned by InternetMonitor.</returns>
        /// <exception cref="Amazon.InternetMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.LimitExceededException">
        /// The request exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.ResourceNotFoundException">
        /// The request specifies a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/internetmonitor-2021-06-03/UpdateMonitor">REST API Reference for UpdateMonitor Operation</seealso>
        public virtual UpdateMonitorResponse UpdateMonitor(UpdateMonitorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMonitorResponseUnmarshaller.Instance;

            return Invoke<UpdateMonitorResponse>(request, options);
        }


        /// <summary>
        /// Updates a monitor. You can update a monitor to change the percentage of traffic to
        /// monitor or the maximum number of city-networks (locations and ASNs), to add or remove
        /// resources, or to change the status of the monitor. Note that you can't change the
        /// name of a monitor.
        /// 
        ///  
        /// <para>
        /// The city-network maximum that you choose is the limit, but you only pay for the number
        /// of city-networks that are actually monitored. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/IMCityNetworksMaximum.html">Choosing
        /// a city-network maximum value</a> in the <i>Amazon CloudWatch User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMonitor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateMonitor service method, as returned by InternetMonitor.</returns>
        /// <exception cref="Amazon.InternetMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.LimitExceededException">
        /// The request exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.ResourceNotFoundException">
        /// The request specifies a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/internetmonitor-2021-06-03/UpdateMonitor">REST API Reference for UpdateMonitor Operation</seealso>
        public virtual Task<UpdateMonitorResponse> UpdateMonitorAsync(UpdateMonitorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMonitorResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateMonitorResponse>(request, options, cancellationToken);
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