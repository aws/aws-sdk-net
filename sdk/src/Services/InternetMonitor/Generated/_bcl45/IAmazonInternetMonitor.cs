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
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.InternetMonitor.Model;

#pragma warning disable CS1570
namespace Amazon.InternetMonitor
{
    /// <summary>
    /// <para>Interface for accessing InternetMonitor</para>
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
    public partial interface IAmazonInternetMonitor : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IInternetMonitorPaginatorFactory Paginators { get; }

        
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
        CreateMonitorResponse CreateMonitor(CreateMonitorRequest request);



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
        Task<CreateMonitorResponse> CreateMonitorAsync(CreateMonitorRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DeleteMonitorResponse DeleteMonitor(DeleteMonitorRequest request);



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
        Task<DeleteMonitorResponse> DeleteMonitorAsync(DeleteMonitorRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        GetHealthEventResponse GetHealthEvent(GetHealthEventRequest request);



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
        Task<GetHealthEventResponse> GetHealthEventAsync(GetHealthEventRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        GetInternetEventResponse GetInternetEvent(GetInternetEventRequest request);



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
        Task<GetInternetEventResponse> GetInternetEventAsync(GetInternetEventRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        GetMonitorResponse GetMonitor(GetMonitorRequest request);



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
        Task<GetMonitorResponse> GetMonitorAsync(GetMonitorRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        GetQueryResultsResponse GetQueryResults(GetQueryResultsRequest request);



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
        Task<GetQueryResultsResponse> GetQueryResultsAsync(GetQueryResultsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        GetQueryStatusResponse GetQueryStatus(GetQueryStatusRequest request);



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
        Task<GetQueryStatusResponse> GetQueryStatusAsync(GetQueryStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ListHealthEventsResponse ListHealthEvents(ListHealthEventsRequest request);



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
        Task<ListHealthEventsResponse> ListHealthEventsAsync(ListHealthEventsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ListInternetEventsResponse ListInternetEvents(ListInternetEventsRequest request);



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
        Task<ListInternetEventsResponse> ListInternetEventsAsync(ListInternetEventsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ListMonitorsResponse ListMonitors(ListMonitorsRequest request);



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
        Task<ListMonitorsResponse> ListMonitorsAsync(ListMonitorsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



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
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        StartQueryResponse StartQuery(StartQueryRequest request);



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
        Task<StartQueryResponse> StartQueryAsync(StartQueryRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        StopQueryResponse StopQuery(StopQueryRequest request);



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
        Task<StopQueryResponse> StopQueryAsync(StopQueryRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        TagResourceResponse TagResource(TagResourceRequest request);



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
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        UntagResourceResponse UntagResource(UntagResourceRequest request);



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
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        UpdateMonitorResponse UpdateMonitor(UpdateMonitorRequest request);



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
        Task<UpdateMonitorResponse> UpdateMonitorAsync(UpdateMonitorRequest request, CancellationToken cancellationToken = default(CancellationToken));

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