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
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.InternetMonitor.Model;

namespace Amazon.InternetMonitor
{
    /// <summary>
    /// Interface for accessing InternetMonitor
    ///
    /// Amazon CloudWatch Internet Monitor provides visibility into how internet issues impact
    /// the performance and availability between your applications hosted on Amazon Web Services
    /// and your end users. It reduces the time it takes for you to diagnose internet issues
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
    /// resources with it, VPCs, CloudFront distributions, or WorkSpaces directories, to enable
    /// Internet Monitor to know where your application's internet traffic is. Internet Monitor
    /// then provides internet measurements from Amazon Web Services that are specific to
    /// the locations and networks that communicate with your application.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-InternetMonitor.html">Using
    /// Amazon CloudWatch Internet Monitor</a> in the <i>Amazon CloudWatch User Guide</i>.
    /// </para>
    /// </summary>
    public partial interface IAmazonInternetMonitor : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IInternetMonitorPaginatorFactory Paginators { get; }
#endif


        
        #region  CreateMonitor


        /// <summary>
        /// Creates a monitor in Amazon CloudWatch Internet Monitor. A monitor is built based
        /// on information from the application resources that you add: Amazon Virtual Private
        /// Clouds (VPCs), Amazon CloudFront distributions, and WorkSpaces directories. Internet
        /// Monitor then publishes internet measurements from Amazon Web Services that are specific
        /// to the <i>city-networks</i>, that is, the locations and ASNs (typically internet service
        /// providers or ISPs), where clients access your application. For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-InternetMonitor.html">Using
        /// Amazon CloudWatch Internet Monitor</a> in the <i>Amazon CloudWatch User Guide</i>.
        /// 
        ///  
        /// <para>
        /// When you create a monitor, you set a maximum limit for the number of city-networks
        /// where client traffic is monitored. The city-network maximum that you choose is the
        /// limit, but you only pay for the number of city-networks that are actually monitored.
        /// You can change the maximum at any time by updating your monitor. For more information,
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
        /// Initiates the asynchronous execution of the CreateMonitor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMonitor operation on AmazonInternetMonitorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMonitor
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/internetmonitor-2021-06-03/CreateMonitor">REST API Reference for CreateMonitor Operation</seealso>
        IAsyncResult BeginCreateMonitor(CreateMonitorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMonitor operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMonitor.</param>
        /// 
        /// <returns>Returns a  CreateMonitorResult from InternetMonitor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/internetmonitor-2021-06-03/CreateMonitor">REST API Reference for CreateMonitor Operation</seealso>
        CreateMonitorResponse EndCreateMonitor(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DeleteMonitor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMonitor operation on AmazonInternetMonitorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMonitor
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/internetmonitor-2021-06-03/DeleteMonitor">REST API Reference for DeleteMonitor Operation</seealso>
        IAsyncResult BeginDeleteMonitor(DeleteMonitorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMonitor operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMonitor.</param>
        /// 
        /// <returns>Returns a  DeleteMonitorResult from InternetMonitor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/internetmonitor-2021-06-03/DeleteMonitor">REST API Reference for DeleteMonitor Operation</seealso>
        DeleteMonitorResponse EndDeleteMonitor(IAsyncResult asyncResult);

        #endregion
        
        #region  GetHealthEvent


        /// <summary>
        /// Gets information the Amazon CloudWatch Internet Monitor has created and stored about
        /// a health event for a specified monitor. This information includes the impacted locations,
        /// and all of the information related to the event by location.
        /// 
        ///  
        /// <para>
        /// The information returned includes the performance, availability, and round-trip time
        /// impact, information about the network providers, the event type, and so on.
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
        /// Initiates the asynchronous execution of the GetHealthEvent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetHealthEvent operation on AmazonInternetMonitorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetHealthEvent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/internetmonitor-2021-06-03/GetHealthEvent">REST API Reference for GetHealthEvent Operation</seealso>
        IAsyncResult BeginGetHealthEvent(GetHealthEventRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetHealthEvent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetHealthEvent.</param>
        /// 
        /// <returns>Returns a  GetHealthEventResult from InternetMonitor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/internetmonitor-2021-06-03/GetHealthEvent">REST API Reference for GetHealthEvent Operation</seealso>
        GetHealthEventResponse EndGetHealthEvent(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetMonitor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMonitor operation on AmazonInternetMonitorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMonitor
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/internetmonitor-2021-06-03/GetMonitor">REST API Reference for GetMonitor Operation</seealso>
        IAsyncResult BeginGetMonitor(GetMonitorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetMonitor operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMonitor.</param>
        /// 
        /// <returns>Returns a  GetMonitorResult from InternetMonitor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/internetmonitor-2021-06-03/GetMonitor">REST API Reference for GetMonitor Operation</seealso>
        GetMonitorResponse EndGetMonitor(IAsyncResult asyncResult);

        #endregion
        
        #region  ListHealthEvents


        /// <summary>
        /// Lists all health events for a monitor in Amazon CloudWatch Internet Monitor. Returns
        /// all information for health events including the client location information the network
        /// cause and status, event start and end time, percentage of total traffic impacted,
        /// and status.
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
        /// Initiates the asynchronous execution of the ListHealthEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListHealthEvents operation on AmazonInternetMonitorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListHealthEvents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/internetmonitor-2021-06-03/ListHealthEvents">REST API Reference for ListHealthEvents Operation</seealso>
        IAsyncResult BeginListHealthEvents(ListHealthEventsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListHealthEvents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListHealthEvents.</param>
        /// 
        /// <returns>Returns a  ListHealthEventsResult from InternetMonitor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/internetmonitor-2021-06-03/ListHealthEvents">REST API Reference for ListHealthEvents Operation</seealso>
        ListHealthEventsResponse EndListHealthEvents(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListMonitors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMonitors operation on AmazonInternetMonitorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMonitors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/internetmonitor-2021-06-03/ListMonitors">REST API Reference for ListMonitors Operation</seealso>
        IAsyncResult BeginListMonitors(ListMonitorsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListMonitors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMonitors.</param>
        /// 
        /// <returns>Returns a  ListMonitorsResult from InternetMonitor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/internetmonitor-2021-06-03/ListMonitors">REST API Reference for ListMonitors Operation</seealso>
        ListMonitorsResponse EndListMonitors(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonInternetMonitorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/internetmonitor-2021-06-03/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from InternetMonitor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/internetmonitor-2021-06-03/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds a tag to a resource. Tags are supported only for monitors in Amazon CloudWatch
        /// Internet Monitor. You can add a maximum of 50 tags in Internet Monitor.
        /// 
        ///  
        /// <para>
        /// A minimum of one tag is required for this call. It returns an error if you use the
        /// <code>TagResource</code> request with 0 tags.
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
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonInternetMonitorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/internetmonitor-2021-06-03/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from InternetMonitor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/internetmonitor-2021-06-03/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonInternetMonitorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/internetmonitor-2021-06-03/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from InternetMonitor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/internetmonitor-2021-06-03/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateMonitor


        /// <summary>
        /// Updates a monitor. You can update a monitor to change the maximum number of city-networks
        /// (locations and ASNs or internet service providers), to add or remove resources, or
        /// to change the status of the monitor. Note that you can't change the name of a monitor.
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
        /// Initiates the asynchronous execution of the UpdateMonitor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMonitor operation on AmazonInternetMonitorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateMonitor
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/internetmonitor-2021-06-03/UpdateMonitor">REST API Reference for UpdateMonitor Operation</seealso>
        IAsyncResult BeginUpdateMonitor(UpdateMonitorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateMonitor operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateMonitor.</param>
        /// 
        /// <returns>Returns a  UpdateMonitorResult from InternetMonitor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/internetmonitor-2021-06-03/UpdateMonitor">REST API Reference for UpdateMonitor Operation</seealso>
        UpdateMonitorResponse EndUpdateMonitor(IAsyncResult asyncResult);

        #endregion
        
    }
}