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
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.NetworkFlowMonitor.Model;

#pragma warning disable CS1570
namespace Amazon.NetworkFlowMonitor
{
    /// <summary>
    /// <para>Interface for accessing NetworkFlowMonitor</para>
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
    public partial interface IAmazonNetworkFlowMonitor : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        INetworkFlowMonitorPaginatorFactory Paginators { get; }
#endif


        
        #region  CreateMonitor


        /// <summary>
        /// Create a monitor for specific network flows between local and remote resources, so
        /// that you can monitor network performance for one or several of your workloads. For
        /// each monitor, Network Flow Monitor publishes detailed end-to-end performance metrics
        /// and a network health indicator (NHI) that informs you whether there were Amazon Web
        /// Services network issues for one or more of the network flows tracked by a monitor,
        /// during a time period that you choose.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMonitor service method.</param>
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
        CreateMonitorResponse CreateMonitor(CreateMonitorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateMonitor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMonitor operation on AmazonNetworkFlowMonitorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMonitor
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/CreateMonitor">REST API Reference for CreateMonitor Operation</seealso>
        IAsyncResult BeginCreateMonitor(CreateMonitorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMonitor operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMonitor.</param>
        /// 
        /// <returns>Returns a  CreateMonitorResult from NetworkFlowMonitor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/CreateMonitor">REST API Reference for CreateMonitor Operation</seealso>
        CreateMonitorResponse EndCreateMonitor(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateScope


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
        CreateScopeResponse CreateScope(CreateScopeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateScope operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateScope operation on AmazonNetworkFlowMonitorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateScope
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/CreateScope">REST API Reference for CreateScope Operation</seealso>
        IAsyncResult BeginCreateScope(CreateScopeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateScope operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateScope.</param>
        /// 
        /// <returns>Returns a  CreateScopeResult from NetworkFlowMonitor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/CreateScope">REST API Reference for CreateScope Operation</seealso>
        CreateScopeResponse EndCreateScope(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteMonitor


        /// <summary>
        /// Deletes a monitor in Network Flow Monitor.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMonitor service method.</param>
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
        DeleteMonitorResponse DeleteMonitor(DeleteMonitorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMonitor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMonitor operation on AmazonNetworkFlowMonitorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMonitor
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/DeleteMonitor">REST API Reference for DeleteMonitor Operation</seealso>
        IAsyncResult BeginDeleteMonitor(DeleteMonitorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMonitor operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMonitor.</param>
        /// 
        /// <returns>Returns a  DeleteMonitorResult from NetworkFlowMonitor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/DeleteMonitor">REST API Reference for DeleteMonitor Operation</seealso>
        DeleteMonitorResponse EndDeleteMonitor(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteScope


        /// <summary>
        /// Deletes a scope that has been defined.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteScope service method.</param>
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
        DeleteScopeResponse DeleteScope(DeleteScopeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteScope operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteScope operation on AmazonNetworkFlowMonitorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteScope
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/DeleteScope">REST API Reference for DeleteScope Operation</seealso>
        IAsyncResult BeginDeleteScope(DeleteScopeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteScope operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteScope.</param>
        /// 
        /// <returns>Returns a  DeleteScopeResult from NetworkFlowMonitor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/DeleteScope">REST API Reference for DeleteScope Operation</seealso>
        DeleteScopeResponse EndDeleteScope(IAsyncResult asyncResult);

        #endregion
        
        #region  GetMonitor


        /// <summary>
        /// Gets information about a monitor in Network Flow Monitor based on a monitor name.
        /// The information returned includes the Amazon Resource Name (ARN), create time, modified
        /// time, resources included in the monitor, and status information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMonitor service method.</param>
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
        GetMonitorResponse GetMonitor(GetMonitorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetMonitor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMonitor operation on AmazonNetworkFlowMonitorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMonitor
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/GetMonitor">REST API Reference for GetMonitor Operation</seealso>
        IAsyncResult BeginGetMonitor(GetMonitorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetMonitor operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMonitor.</param>
        /// 
        /// <returns>Returns a  GetMonitorResult from NetworkFlowMonitor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/GetMonitor">REST API Reference for GetMonitor Operation</seealso>
        GetMonitorResponse EndGetMonitor(IAsyncResult asyncResult);

        #endregion
        
        #region  GetQueryResultsMonitorTopContributors


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
        GetQueryResultsMonitorTopContributorsResponse GetQueryResultsMonitorTopContributors(GetQueryResultsMonitorTopContributorsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetQueryResultsMonitorTopContributors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetQueryResultsMonitorTopContributors operation on AmazonNetworkFlowMonitorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetQueryResultsMonitorTopContributors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/GetQueryResultsMonitorTopContributors">REST API Reference for GetQueryResultsMonitorTopContributors Operation</seealso>
        IAsyncResult BeginGetQueryResultsMonitorTopContributors(GetQueryResultsMonitorTopContributorsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetQueryResultsMonitorTopContributors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetQueryResultsMonitorTopContributors.</param>
        /// 
        /// <returns>Returns a  GetQueryResultsMonitorTopContributorsResult from NetworkFlowMonitor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/GetQueryResultsMonitorTopContributors">REST API Reference for GetQueryResultsMonitorTopContributors Operation</seealso>
        GetQueryResultsMonitorTopContributorsResponse EndGetQueryResultsMonitorTopContributors(IAsyncResult asyncResult);

        #endregion
        
        #region  GetQueryResultsWorkloadInsightsTopContributors


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
        GetQueryResultsWorkloadInsightsTopContributorsResponse GetQueryResultsWorkloadInsightsTopContributors(GetQueryResultsWorkloadInsightsTopContributorsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetQueryResultsWorkloadInsightsTopContributors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetQueryResultsWorkloadInsightsTopContributors operation on AmazonNetworkFlowMonitorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetQueryResultsWorkloadInsightsTopContributors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/GetQueryResultsWorkloadInsightsTopContributors">REST API Reference for GetQueryResultsWorkloadInsightsTopContributors Operation</seealso>
        IAsyncResult BeginGetQueryResultsWorkloadInsightsTopContributors(GetQueryResultsWorkloadInsightsTopContributorsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetQueryResultsWorkloadInsightsTopContributors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetQueryResultsWorkloadInsightsTopContributors.</param>
        /// 
        /// <returns>Returns a  GetQueryResultsWorkloadInsightsTopContributorsResult from NetworkFlowMonitor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/GetQueryResultsWorkloadInsightsTopContributors">REST API Reference for GetQueryResultsWorkloadInsightsTopContributors Operation</seealso>
        GetQueryResultsWorkloadInsightsTopContributorsResponse EndGetQueryResultsWorkloadInsightsTopContributors(IAsyncResult asyncResult);

        #endregion
        
        #region  GetQueryResultsWorkloadInsightsTopContributorsData


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
        GetQueryResultsWorkloadInsightsTopContributorsDataResponse GetQueryResultsWorkloadInsightsTopContributorsData(GetQueryResultsWorkloadInsightsTopContributorsDataRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetQueryResultsWorkloadInsightsTopContributorsData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetQueryResultsWorkloadInsightsTopContributorsData operation on AmazonNetworkFlowMonitorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetQueryResultsWorkloadInsightsTopContributorsData
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/GetQueryResultsWorkloadInsightsTopContributorsData">REST API Reference for GetQueryResultsWorkloadInsightsTopContributorsData Operation</seealso>
        IAsyncResult BeginGetQueryResultsWorkloadInsightsTopContributorsData(GetQueryResultsWorkloadInsightsTopContributorsDataRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetQueryResultsWorkloadInsightsTopContributorsData operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetQueryResultsWorkloadInsightsTopContributorsData.</param>
        /// 
        /// <returns>Returns a  GetQueryResultsWorkloadInsightsTopContributorsDataResult from NetworkFlowMonitor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/GetQueryResultsWorkloadInsightsTopContributorsData">REST API Reference for GetQueryResultsWorkloadInsightsTopContributorsData Operation</seealso>
        GetQueryResultsWorkloadInsightsTopContributorsDataResponse EndGetQueryResultsWorkloadInsightsTopContributorsData(IAsyncResult asyncResult);

        #endregion
        
        #region  GetQueryStatusMonitorTopContributors


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
        GetQueryStatusMonitorTopContributorsResponse GetQueryStatusMonitorTopContributors(GetQueryStatusMonitorTopContributorsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetQueryStatusMonitorTopContributors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetQueryStatusMonitorTopContributors operation on AmazonNetworkFlowMonitorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetQueryStatusMonitorTopContributors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/GetQueryStatusMonitorTopContributors">REST API Reference for GetQueryStatusMonitorTopContributors Operation</seealso>
        IAsyncResult BeginGetQueryStatusMonitorTopContributors(GetQueryStatusMonitorTopContributorsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetQueryStatusMonitorTopContributors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetQueryStatusMonitorTopContributors.</param>
        /// 
        /// <returns>Returns a  GetQueryStatusMonitorTopContributorsResult from NetworkFlowMonitor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/GetQueryStatusMonitorTopContributors">REST API Reference for GetQueryStatusMonitorTopContributors Operation</seealso>
        GetQueryStatusMonitorTopContributorsResponse EndGetQueryStatusMonitorTopContributors(IAsyncResult asyncResult);

        #endregion
        
        #region  GetQueryStatusWorkloadInsightsTopContributors


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
        GetQueryStatusWorkloadInsightsTopContributorsResponse GetQueryStatusWorkloadInsightsTopContributors(GetQueryStatusWorkloadInsightsTopContributorsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetQueryStatusWorkloadInsightsTopContributors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetQueryStatusWorkloadInsightsTopContributors operation on AmazonNetworkFlowMonitorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetQueryStatusWorkloadInsightsTopContributors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/GetQueryStatusWorkloadInsightsTopContributors">REST API Reference for GetQueryStatusWorkloadInsightsTopContributors Operation</seealso>
        IAsyncResult BeginGetQueryStatusWorkloadInsightsTopContributors(GetQueryStatusWorkloadInsightsTopContributorsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetQueryStatusWorkloadInsightsTopContributors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetQueryStatusWorkloadInsightsTopContributors.</param>
        /// 
        /// <returns>Returns a  GetQueryStatusWorkloadInsightsTopContributorsResult from NetworkFlowMonitor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/GetQueryStatusWorkloadInsightsTopContributors">REST API Reference for GetQueryStatusWorkloadInsightsTopContributors Operation</seealso>
        GetQueryStatusWorkloadInsightsTopContributorsResponse EndGetQueryStatusWorkloadInsightsTopContributors(IAsyncResult asyncResult);

        #endregion
        
        #region  GetQueryStatusWorkloadInsightsTopContributorsData


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
        GetQueryStatusWorkloadInsightsTopContributorsDataResponse GetQueryStatusWorkloadInsightsTopContributorsData(GetQueryStatusWorkloadInsightsTopContributorsDataRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetQueryStatusWorkloadInsightsTopContributorsData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetQueryStatusWorkloadInsightsTopContributorsData operation on AmazonNetworkFlowMonitorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetQueryStatusWorkloadInsightsTopContributorsData
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/GetQueryStatusWorkloadInsightsTopContributorsData">REST API Reference for GetQueryStatusWorkloadInsightsTopContributorsData Operation</seealso>
        IAsyncResult BeginGetQueryStatusWorkloadInsightsTopContributorsData(GetQueryStatusWorkloadInsightsTopContributorsDataRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetQueryStatusWorkloadInsightsTopContributorsData operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetQueryStatusWorkloadInsightsTopContributorsData.</param>
        /// 
        /// <returns>Returns a  GetQueryStatusWorkloadInsightsTopContributorsDataResult from NetworkFlowMonitor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/GetQueryStatusWorkloadInsightsTopContributorsData">REST API Reference for GetQueryStatusWorkloadInsightsTopContributorsData Operation</seealso>
        GetQueryStatusWorkloadInsightsTopContributorsDataResponse EndGetQueryStatusWorkloadInsightsTopContributorsData(IAsyncResult asyncResult);

        #endregion
        
        #region  GetScope


        /// <summary>
        /// Gets information about a scope, including the name, status, tags, and target details.
        /// The scope in Network Flow Monitor is an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetScope service method.</param>
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
        GetScopeResponse GetScope(GetScopeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetScope operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetScope operation on AmazonNetworkFlowMonitorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetScope
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/GetScope">REST API Reference for GetScope Operation</seealso>
        IAsyncResult BeginGetScope(GetScopeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetScope operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetScope.</param>
        /// 
        /// <returns>Returns a  GetScopeResult from NetworkFlowMonitor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/GetScope">REST API Reference for GetScope Operation</seealso>
        GetScopeResponse EndGetScope(IAsyncResult asyncResult);

        #endregion
        
        #region  ListMonitors


        /// <summary>
        /// List all monitors in an account. Optionally, you can list only monitors that have
        /// a specific status, by using the <c>STATUS</c> parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMonitors service method.</param>
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
        ListMonitorsResponse ListMonitors(ListMonitorsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListMonitors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMonitors operation on AmazonNetworkFlowMonitorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMonitors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/ListMonitors">REST API Reference for ListMonitors Operation</seealso>
        IAsyncResult BeginListMonitors(ListMonitorsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListMonitors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMonitors.</param>
        /// 
        /// <returns>Returns a  ListMonitorsResult from NetworkFlowMonitor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/ListMonitors">REST API Reference for ListMonitors Operation</seealso>
        ListMonitorsResponse EndListMonitors(IAsyncResult asyncResult);

        #endregion
        
        #region  ListScopes


        /// <summary>
        /// List all the scopes for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListScopes service method.</param>
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
        ListScopesResponse ListScopes(ListScopesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListScopes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListScopes operation on AmazonNetworkFlowMonitorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListScopes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/ListScopes">REST API Reference for ListScopes Operation</seealso>
        IAsyncResult BeginListScopes(ListScopesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListScopes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListScopes.</param>
        /// 
        /// <returns>Returns a  ListScopesResult from NetworkFlowMonitor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/ListScopes">REST API Reference for ListScopes Operation</seealso>
        ListScopesResponse EndListScopes(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Returns all the tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
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
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonNetworkFlowMonitorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from NetworkFlowMonitor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  StartQueryMonitorTopContributors


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
        StartQueryMonitorTopContributorsResponse StartQueryMonitorTopContributors(StartQueryMonitorTopContributorsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartQueryMonitorTopContributors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartQueryMonitorTopContributors operation on AmazonNetworkFlowMonitorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartQueryMonitorTopContributors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/StartQueryMonitorTopContributors">REST API Reference for StartQueryMonitorTopContributors Operation</seealso>
        IAsyncResult BeginStartQueryMonitorTopContributors(StartQueryMonitorTopContributorsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartQueryMonitorTopContributors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartQueryMonitorTopContributors.</param>
        /// 
        /// <returns>Returns a  StartQueryMonitorTopContributorsResult from NetworkFlowMonitor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/StartQueryMonitorTopContributors">REST API Reference for StartQueryMonitorTopContributors Operation</seealso>
        StartQueryMonitorTopContributorsResponse EndStartQueryMonitorTopContributors(IAsyncResult asyncResult);

        #endregion
        
        #region  StartQueryWorkloadInsightsTopContributors


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
        StartQueryWorkloadInsightsTopContributorsResponse StartQueryWorkloadInsightsTopContributors(StartQueryWorkloadInsightsTopContributorsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartQueryWorkloadInsightsTopContributors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartQueryWorkloadInsightsTopContributors operation on AmazonNetworkFlowMonitorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartQueryWorkloadInsightsTopContributors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/StartQueryWorkloadInsightsTopContributors">REST API Reference for StartQueryWorkloadInsightsTopContributors Operation</seealso>
        IAsyncResult BeginStartQueryWorkloadInsightsTopContributors(StartQueryWorkloadInsightsTopContributorsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartQueryWorkloadInsightsTopContributors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartQueryWorkloadInsightsTopContributors.</param>
        /// 
        /// <returns>Returns a  StartQueryWorkloadInsightsTopContributorsResult from NetworkFlowMonitor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/StartQueryWorkloadInsightsTopContributors">REST API Reference for StartQueryWorkloadInsightsTopContributors Operation</seealso>
        StartQueryWorkloadInsightsTopContributorsResponse EndStartQueryWorkloadInsightsTopContributors(IAsyncResult asyncResult);

        #endregion
        
        #region  StartQueryWorkloadInsightsTopContributorsData


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
        StartQueryWorkloadInsightsTopContributorsDataResponse StartQueryWorkloadInsightsTopContributorsData(StartQueryWorkloadInsightsTopContributorsDataRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartQueryWorkloadInsightsTopContributorsData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartQueryWorkloadInsightsTopContributorsData operation on AmazonNetworkFlowMonitorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartQueryWorkloadInsightsTopContributorsData
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/StartQueryWorkloadInsightsTopContributorsData">REST API Reference for StartQueryWorkloadInsightsTopContributorsData Operation</seealso>
        IAsyncResult BeginStartQueryWorkloadInsightsTopContributorsData(StartQueryWorkloadInsightsTopContributorsDataRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartQueryWorkloadInsightsTopContributorsData operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartQueryWorkloadInsightsTopContributorsData.</param>
        /// 
        /// <returns>Returns a  StartQueryWorkloadInsightsTopContributorsDataResult from NetworkFlowMonitor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/StartQueryWorkloadInsightsTopContributorsData">REST API Reference for StartQueryWorkloadInsightsTopContributorsData Operation</seealso>
        StartQueryWorkloadInsightsTopContributorsDataResponse EndStartQueryWorkloadInsightsTopContributorsData(IAsyncResult asyncResult);

        #endregion
        
        #region  StopQueryMonitorTopContributors


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
        StopQueryMonitorTopContributorsResponse StopQueryMonitorTopContributors(StopQueryMonitorTopContributorsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopQueryMonitorTopContributors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopQueryMonitorTopContributors operation on AmazonNetworkFlowMonitorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopQueryMonitorTopContributors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/StopQueryMonitorTopContributors">REST API Reference for StopQueryMonitorTopContributors Operation</seealso>
        IAsyncResult BeginStopQueryMonitorTopContributors(StopQueryMonitorTopContributorsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopQueryMonitorTopContributors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopQueryMonitorTopContributors.</param>
        /// 
        /// <returns>Returns a  StopQueryMonitorTopContributorsResult from NetworkFlowMonitor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/StopQueryMonitorTopContributors">REST API Reference for StopQueryMonitorTopContributors Operation</seealso>
        StopQueryMonitorTopContributorsResponse EndStopQueryMonitorTopContributors(IAsyncResult asyncResult);

        #endregion
        
        #region  StopQueryWorkloadInsightsTopContributors


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
        StopQueryWorkloadInsightsTopContributorsResponse StopQueryWorkloadInsightsTopContributors(StopQueryWorkloadInsightsTopContributorsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopQueryWorkloadInsightsTopContributors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopQueryWorkloadInsightsTopContributors operation on AmazonNetworkFlowMonitorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopQueryWorkloadInsightsTopContributors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/StopQueryWorkloadInsightsTopContributors">REST API Reference for StopQueryWorkloadInsightsTopContributors Operation</seealso>
        IAsyncResult BeginStopQueryWorkloadInsightsTopContributors(StopQueryWorkloadInsightsTopContributorsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopQueryWorkloadInsightsTopContributors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopQueryWorkloadInsightsTopContributors.</param>
        /// 
        /// <returns>Returns a  StopQueryWorkloadInsightsTopContributorsResult from NetworkFlowMonitor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/StopQueryWorkloadInsightsTopContributors">REST API Reference for StopQueryWorkloadInsightsTopContributors Operation</seealso>
        StopQueryWorkloadInsightsTopContributorsResponse EndStopQueryWorkloadInsightsTopContributors(IAsyncResult asyncResult);

        #endregion
        
        #region  StopQueryWorkloadInsightsTopContributorsData


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
        StopQueryWorkloadInsightsTopContributorsDataResponse StopQueryWorkloadInsightsTopContributorsData(StopQueryWorkloadInsightsTopContributorsDataRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopQueryWorkloadInsightsTopContributorsData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopQueryWorkloadInsightsTopContributorsData operation on AmazonNetworkFlowMonitorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopQueryWorkloadInsightsTopContributorsData
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/StopQueryWorkloadInsightsTopContributorsData">REST API Reference for StopQueryWorkloadInsightsTopContributorsData Operation</seealso>
        IAsyncResult BeginStopQueryWorkloadInsightsTopContributorsData(StopQueryWorkloadInsightsTopContributorsDataRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopQueryWorkloadInsightsTopContributorsData operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopQueryWorkloadInsightsTopContributorsData.</param>
        /// 
        /// <returns>Returns a  StopQueryWorkloadInsightsTopContributorsDataResult from NetworkFlowMonitor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/StopQueryWorkloadInsightsTopContributorsData">REST API Reference for StopQueryWorkloadInsightsTopContributorsData Operation</seealso>
        StopQueryWorkloadInsightsTopContributorsDataResponse EndStopQueryWorkloadInsightsTopContributorsData(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds a tag to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
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
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonNetworkFlowMonitorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from NetworkFlowMonitor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes a tag from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
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
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonNetworkFlowMonitorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from NetworkFlowMonitor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateMonitor


        /// <summary>
        /// Update a monitor to add or remove local or remote resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMonitor service method.</param>
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
        UpdateMonitorResponse UpdateMonitor(UpdateMonitorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateMonitor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMonitor operation on AmazonNetworkFlowMonitorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateMonitor
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/UpdateMonitor">REST API Reference for UpdateMonitor Operation</seealso>
        IAsyncResult BeginUpdateMonitor(UpdateMonitorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateMonitor operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateMonitor.</param>
        /// 
        /// <returns>Returns a  UpdateMonitorResult from NetworkFlowMonitor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/UpdateMonitor">REST API Reference for UpdateMonitor Operation</seealso>
        UpdateMonitorResponse EndUpdateMonitor(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateScope


        /// <summary>
        /// Update a scope to add or remove resources that you want to be available for Network
        /// Flow Monitor to generate metrics for, when you have active agents on those resources
        /// sending metrics reports to the Network Flow Monitor backend.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateScope service method.</param>
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
        UpdateScopeResponse UpdateScope(UpdateScopeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateScope operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateScope operation on AmazonNetworkFlowMonitorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateScope
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/UpdateScope">REST API Reference for UpdateScope Operation</seealso>
        IAsyncResult BeginUpdateScope(UpdateScopeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateScope operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateScope.</param>
        /// 
        /// <returns>Returns a  UpdateScopeResult from NetworkFlowMonitor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkflowmonitor-2023-04-19/UpdateScope">REST API Reference for UpdateScope Operation</seealso>
        UpdateScopeResponse EndUpdateScope(IAsyncResult asyncResult);

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