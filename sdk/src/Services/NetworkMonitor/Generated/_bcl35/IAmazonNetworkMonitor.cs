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
 * Do not modify this file. This file is generated from the networkmonitor-2023-08-01.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.NetworkMonitor.Model;

#pragma warning disable CS1570
namespace Amazon.NetworkMonitor
{
    /// <summary>
    /// <para>Interface for accessing NetworkMonitor</para>
    ///
    /// Amazon CloudWatch Network Monitor is an Amazon Web Services active network monitoring
    /// service that identifies if a network issues exists within the Amazon Web Services
    /// network or your own company network. Within Network Monitor you'll choose the source
    /// VPCs and subnets from the Amazon Web Services network in which you operate and then
    /// you'll choose the destination IP addresses from your on-premises network. From these
    /// sources and destinations, Network Monitor creates a monitor containing all the possible
    /// source and destination combinations, each of which is called a probe, within a single
    /// monitor. These probes then monitor network traffic to help you identify where network
    /// issues might be affecting your traffic.
    /// 
    ///  
    /// <para>
    /// Before you begin, ensure the Amazon Web Services CLI is configured in the Amazon Web
    /// Services Account where you will create the Network Monitor resource. Network Monitor
    /// doesn’t support creation on cross-account resources, but you can create a Network
    /// Monitor in any subnet belonging to a VPC owned by your Account.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/what-is-network-monitor.html">Using
    /// Amazon CloudWatch Network Monitor</a> in the <i>Amazon CloudWatch User Guide</i>.
    /// </para>
    /// </summary>
    public partial interface IAmazonNetworkMonitor : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        INetworkMonitorPaginatorFactory Paginators { get; }
#endif


        
        #region  CreateMonitor


        /// <summary>
        /// Creates a monitor between a source subnet and destination IP address. Within a monitor
        /// you'll create one or more probes that monitor network traffic between your source
        /// Amazon Web Services VPC subnets and your destination IP addresses. Each probe then
        /// aggregates and sends metrics to Amazon CloudWatch.
        /// 
        ///  
        /// <para>
        /// You can also create a monitor with probes using this command. For each probe, you
        /// define the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>source</c>—The subnet IDs where the probes will be created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>destination</c>— The target destination IP address for the probe.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>destinationPort</c>—Required only if the protocol is <c>TCP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>protocol</c>—The communication protocol between the source and destination. This
        /// will be either <c>TCP</c> or <c>ICMP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>packetSize</c>—The size of the packets. This must be a number between <c>56</c>
        /// and <c>8500</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// (Optional) <c>tags</c> —Key-value pairs created and assigned to the probe.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMonitor service method.</param>
        /// 
        /// <returns>The response from the CreateMonitor service method, as returned by NetworkMonitor.</returns>
        /// <exception cref="Amazon.NetworkMonitor.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkMonitor.Model.ConflictException">
        /// This operation attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.NetworkMonitor.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.NetworkMonitor.Model.ServiceQuotaExceededException">
        /// This request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling
        /// </exception>
        /// <exception cref="Amazon.NetworkMonitor.Model.ValidationException">
        /// One of the parameters for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmonitor-2023-08-01/CreateMonitor">REST API Reference for CreateMonitor Operation</seealso>
        CreateMonitorResponse CreateMonitor(CreateMonitorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateMonitor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMonitor operation on AmazonNetworkMonitorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMonitor
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmonitor-2023-08-01/CreateMonitor">REST API Reference for CreateMonitor Operation</seealso>
        IAsyncResult BeginCreateMonitor(CreateMonitorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMonitor operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMonitor.</param>
        /// 
        /// <returns>Returns a  CreateMonitorResult from NetworkMonitor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmonitor-2023-08-01/CreateMonitor">REST API Reference for CreateMonitor Operation</seealso>
        CreateMonitorResponse EndCreateMonitor(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateProbe


        /// <summary>
        /// Create a probe within a monitor. Once you create a probe, and it begins monitoring
        /// your network traffic, you'll incur billing charges for that probe. This action requires
        /// the <c>monitorName</c> parameter. Run <c>ListMonitors</c> to get a list of monitor
        /// names. Note the name of the <c>monitorName</c> you want to create the probe for.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProbe service method.</param>
        /// 
        /// <returns>The response from the CreateProbe service method, as returned by NetworkMonitor.</returns>
        /// <exception cref="Amazon.NetworkMonitor.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkMonitor.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.NetworkMonitor.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.NetworkMonitor.Model.ServiceQuotaExceededException">
        /// This request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling
        /// </exception>
        /// <exception cref="Amazon.NetworkMonitor.Model.ValidationException">
        /// One of the parameters for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmonitor-2023-08-01/CreateProbe">REST API Reference for CreateProbe Operation</seealso>
        CreateProbeResponse CreateProbe(CreateProbeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateProbe operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateProbe operation on AmazonNetworkMonitorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateProbe
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmonitor-2023-08-01/CreateProbe">REST API Reference for CreateProbe Operation</seealso>
        IAsyncResult BeginCreateProbe(CreateProbeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateProbe operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateProbe.</param>
        /// 
        /// <returns>Returns a  CreateProbeResult from NetworkMonitor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmonitor-2023-08-01/CreateProbe">REST API Reference for CreateProbe Operation</seealso>
        CreateProbeResponse EndCreateProbe(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteMonitor


        /// <summary>
        /// Deletes a specified monitor.
        /// 
        ///  
        /// <para>
        /// This action requires the <c>monitorName</c> parameter. Run <c>ListMonitors</c> to
        /// get a list of monitor names. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMonitor service method.</param>
        /// 
        /// <returns>The response from the DeleteMonitor service method, as returned by NetworkMonitor.</returns>
        /// <exception cref="Amazon.NetworkMonitor.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkMonitor.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.NetworkMonitor.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.NetworkMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling
        /// </exception>
        /// <exception cref="Amazon.NetworkMonitor.Model.ValidationException">
        /// One of the parameters for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmonitor-2023-08-01/DeleteMonitor">REST API Reference for DeleteMonitor Operation</seealso>
        DeleteMonitorResponse DeleteMonitor(DeleteMonitorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMonitor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMonitor operation on AmazonNetworkMonitorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMonitor
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmonitor-2023-08-01/DeleteMonitor">REST API Reference for DeleteMonitor Operation</seealso>
        IAsyncResult BeginDeleteMonitor(DeleteMonitorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMonitor operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMonitor.</param>
        /// 
        /// <returns>Returns a  DeleteMonitorResult from NetworkMonitor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmonitor-2023-08-01/DeleteMonitor">REST API Reference for DeleteMonitor Operation</seealso>
        DeleteMonitorResponse EndDeleteMonitor(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteProbe


        /// <summary>
        /// Deletes the specified probe. Once a probe is deleted you'll no longer incur any billing
        /// fees for that probe.
        /// 
        ///  
        /// <para>
        /// This action requires both the <c>monitorName</c> and <c>probeId</c> parameters. Run
        /// <c>ListMonitors</c> to get a list of monitor names. Run <c>GetMonitor</c> to get a
        /// list of probes and probe IDs. You can only delete a single probe at a time using this
        /// action. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProbe service method.</param>
        /// 
        /// <returns>The response from the DeleteProbe service method, as returned by NetworkMonitor.</returns>
        /// <exception cref="Amazon.NetworkMonitor.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkMonitor.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.NetworkMonitor.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.NetworkMonitor.Model.ServiceQuotaExceededException">
        /// This request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling
        /// </exception>
        /// <exception cref="Amazon.NetworkMonitor.Model.ValidationException">
        /// One of the parameters for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmonitor-2023-08-01/DeleteProbe">REST API Reference for DeleteProbe Operation</seealso>
        DeleteProbeResponse DeleteProbe(DeleteProbeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteProbe operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteProbe operation on AmazonNetworkMonitorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteProbe
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmonitor-2023-08-01/DeleteProbe">REST API Reference for DeleteProbe Operation</seealso>
        IAsyncResult BeginDeleteProbe(DeleteProbeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteProbe operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteProbe.</param>
        /// 
        /// <returns>Returns a  DeleteProbeResult from NetworkMonitor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmonitor-2023-08-01/DeleteProbe">REST API Reference for DeleteProbe Operation</seealso>
        DeleteProbeResponse EndDeleteProbe(IAsyncResult asyncResult);

        #endregion
        
        #region  GetMonitor


        /// <summary>
        /// Returns details about a specific monitor. 
        /// 
        ///  
        /// <para>
        /// This action requires the <c>monitorName</c> parameter. Run <c>ListMonitors</c> to
        /// get a list of monitor names. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMonitor service method.</param>
        /// 
        /// <returns>The response from the GetMonitor service method, as returned by NetworkMonitor.</returns>
        /// <exception cref="Amazon.NetworkMonitor.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkMonitor.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.NetworkMonitor.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.NetworkMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling
        /// </exception>
        /// <exception cref="Amazon.NetworkMonitor.Model.ValidationException">
        /// One of the parameters for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmonitor-2023-08-01/GetMonitor">REST API Reference for GetMonitor Operation</seealso>
        GetMonitorResponse GetMonitor(GetMonitorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetMonitor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMonitor operation on AmazonNetworkMonitorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMonitor
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmonitor-2023-08-01/GetMonitor">REST API Reference for GetMonitor Operation</seealso>
        IAsyncResult BeginGetMonitor(GetMonitorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetMonitor operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMonitor.</param>
        /// 
        /// <returns>Returns a  GetMonitorResult from NetworkMonitor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmonitor-2023-08-01/GetMonitor">REST API Reference for GetMonitor Operation</seealso>
        GetMonitorResponse EndGetMonitor(IAsyncResult asyncResult);

        #endregion
        
        #region  GetProbe


        /// <summary>
        /// Returns the details about a probe. This action requires both the <c>monitorName</c>
        /// and <c>probeId</c> parameters. Run <c>ListMonitors</c> to get a list of monitor names.
        /// Run <c>GetMonitor</c> to get a list of probes and probe IDs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProbe service method.</param>
        /// 
        /// <returns>The response from the GetProbe service method, as returned by NetworkMonitor.</returns>
        /// <exception cref="Amazon.NetworkMonitor.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkMonitor.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.NetworkMonitor.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.NetworkMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling
        /// </exception>
        /// <exception cref="Amazon.NetworkMonitor.Model.ValidationException">
        /// One of the parameters for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmonitor-2023-08-01/GetProbe">REST API Reference for GetProbe Operation</seealso>
        GetProbeResponse GetProbe(GetProbeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetProbe operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetProbe operation on AmazonNetworkMonitorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetProbe
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmonitor-2023-08-01/GetProbe">REST API Reference for GetProbe Operation</seealso>
        IAsyncResult BeginGetProbe(GetProbeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetProbe operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetProbe.</param>
        /// 
        /// <returns>Returns a  GetProbeResult from NetworkMonitor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmonitor-2023-08-01/GetProbe">REST API Reference for GetProbe Operation</seealso>
        GetProbeResponse EndGetProbe(IAsyncResult asyncResult);

        #endregion
        
        #region  ListMonitors


        /// <summary>
        /// Returns a list of all of your monitors.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMonitors service method.</param>
        /// 
        /// <returns>The response from the ListMonitors service method, as returned by NetworkMonitor.</returns>
        /// <exception cref="Amazon.NetworkMonitor.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkMonitor.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.NetworkMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling
        /// </exception>
        /// <exception cref="Amazon.NetworkMonitor.Model.ValidationException">
        /// One of the parameters for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmonitor-2023-08-01/ListMonitors">REST API Reference for ListMonitors Operation</seealso>
        ListMonitorsResponse ListMonitors(ListMonitorsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListMonitors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMonitors operation on AmazonNetworkMonitorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMonitors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmonitor-2023-08-01/ListMonitors">REST API Reference for ListMonitors Operation</seealso>
        IAsyncResult BeginListMonitors(ListMonitorsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListMonitors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMonitors.</param>
        /// 
        /// <returns>Returns a  ListMonitorsResult from NetworkMonitor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmonitor-2023-08-01/ListMonitors">REST API Reference for ListMonitors Operation</seealso>
        ListMonitorsResponse EndListMonitors(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags assigned to this resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by NetworkMonitor.</returns>
        /// <exception cref="Amazon.NetworkMonitor.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkMonitor.Model.ConflictException">
        /// This operation attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.NetworkMonitor.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.NetworkMonitor.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.NetworkMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling
        /// </exception>
        /// <exception cref="Amazon.NetworkMonitor.Model.ValidationException">
        /// One of the parameters for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmonitor-2023-08-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonNetworkMonitorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmonitor-2023-08-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from NetworkMonitor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmonitor-2023-08-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds key-value pairs to a monitor or probe.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by NetworkMonitor.</returns>
        /// <exception cref="Amazon.NetworkMonitor.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkMonitor.Model.ConflictException">
        /// This operation attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.NetworkMonitor.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.NetworkMonitor.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.NetworkMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling
        /// </exception>
        /// <exception cref="Amazon.NetworkMonitor.Model.ValidationException">
        /// One of the parameters for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmonitor-2023-08-01/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonNetworkMonitorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmonitor-2023-08-01/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from NetworkMonitor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmonitor-2023-08-01/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes a key-value pair from a monitor or probe.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by NetworkMonitor.</returns>
        /// <exception cref="Amazon.NetworkMonitor.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkMonitor.Model.ConflictException">
        /// This operation attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.NetworkMonitor.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.NetworkMonitor.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.NetworkMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling
        /// </exception>
        /// <exception cref="Amazon.NetworkMonitor.Model.ValidationException">
        /// One of the parameters for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmonitor-2023-08-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonNetworkMonitorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmonitor-2023-08-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from NetworkMonitor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmonitor-2023-08-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateMonitor


        /// <summary>
        /// Updates the <c>aggregationPeriod</c> for a monitor. Monitors support an <c>aggregationPeriod</c>
        /// of either <c>30</c> or <c>60</c> seconds. This action requires the <c>monitorName</c>
        /// and <c>probeId</c> parameter. Run <c>ListMonitors</c> to get a list of monitor names.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMonitor service method.</param>
        /// 
        /// <returns>The response from the UpdateMonitor service method, as returned by NetworkMonitor.</returns>
        /// <exception cref="Amazon.NetworkMonitor.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkMonitor.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.NetworkMonitor.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.NetworkMonitor.Model.ServiceQuotaExceededException">
        /// This request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling
        /// </exception>
        /// <exception cref="Amazon.NetworkMonitor.Model.ValidationException">
        /// One of the parameters for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmonitor-2023-08-01/UpdateMonitor">REST API Reference for UpdateMonitor Operation</seealso>
        UpdateMonitorResponse UpdateMonitor(UpdateMonitorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateMonitor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMonitor operation on AmazonNetworkMonitorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateMonitor
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmonitor-2023-08-01/UpdateMonitor">REST API Reference for UpdateMonitor Operation</seealso>
        IAsyncResult BeginUpdateMonitor(UpdateMonitorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateMonitor operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateMonitor.</param>
        /// 
        /// <returns>Returns a  UpdateMonitorResult from NetworkMonitor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmonitor-2023-08-01/UpdateMonitor">REST API Reference for UpdateMonitor Operation</seealso>
        UpdateMonitorResponse EndUpdateMonitor(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateProbe


        /// <summary>
        /// Updates a monitor probe. This action requires both the <c>monitorName</c> and <c>probeId</c>
        /// parameters. Run <c>ListMonitors</c> to get a list of monitor names. Run <c>GetMonitor</c>
        /// to get a list of probes and probe IDs. 
        /// 
        ///  
        /// <para>
        /// You can update the following para create a monitor with probes using this command.
        /// For each probe, you define the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>state</c>—The state of the probe.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>destination</c>— The target destination IP address for the probe.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>destinationPort</c>—Required only if the protocol is <c>TCP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>protocol</c>—The communication protocol between the source and destination. This
        /// will be either <c>TCP</c> or <c>ICMP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>packetSize</c>—The size of the packets. This must be a number between <c>56</c>
        /// and <c>8500</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// (Optional) <c>tags</c> —Key-value pairs created and assigned to the probe.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProbe service method.</param>
        /// 
        /// <returns>The response from the UpdateProbe service method, as returned by NetworkMonitor.</returns>
        /// <exception cref="Amazon.NetworkMonitor.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkMonitor.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.NetworkMonitor.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.NetworkMonitor.Model.ServiceQuotaExceededException">
        /// This request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling
        /// </exception>
        /// <exception cref="Amazon.NetworkMonitor.Model.ValidationException">
        /// One of the parameters for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmonitor-2023-08-01/UpdateProbe">REST API Reference for UpdateProbe Operation</seealso>
        UpdateProbeResponse UpdateProbe(UpdateProbeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateProbe operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateProbe operation on AmazonNetworkMonitorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateProbe
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmonitor-2023-08-01/UpdateProbe">REST API Reference for UpdateProbe Operation</seealso>
        IAsyncResult BeginUpdateProbe(UpdateProbeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateProbe operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateProbe.</param>
        /// 
        /// <returns>Returns a  UpdateProbeResult from NetworkMonitor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmonitor-2023-08-01/UpdateProbe">REST API Reference for UpdateProbe Operation</seealso>
        UpdateProbeResponse EndUpdateProbe(IAsyncResult asyncResult);

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