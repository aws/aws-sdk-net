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
using System.Threading;
using System.Threading.Tasks;
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
        /// <summary>
        /// Paginators for the service
        /// </summary>
        INetworkFlowMonitorPaginatorFactory Paginators { get; }

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
        CreateMonitorResponse CreateMonitor(CreateMonitorRequest request);
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
        Task<CreateMonitorResponse> CreateMonitorAsync(CreateMonitorRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        CreatePerformanceMonitorResponse CreatePerformanceMonitor(CreatePerformanceMonitorRequest request);
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
        Task<CreatePerformanceMonitorResponse> CreatePerformanceMonitorAsync(CreatePerformanceMonitorRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        CreateScopeResponse CreateScope(CreateScopeRequest request);
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
        Task<CreateScopeResponse> CreateScopeAsync(CreateScopeRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DeleteMonitorResponse DeleteMonitor(DeleteMonitorRequest request);
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
        Task<DeleteMonitorResponse> DeleteMonitorAsync(DeleteMonitorRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DeletePerformanceMonitorResponse DeletePerformanceMonitor(DeletePerformanceMonitorRequest request);
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
        Task<DeletePerformanceMonitorResponse> DeletePerformanceMonitorAsync(DeletePerformanceMonitorRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DeleteScopeResponse DeleteScope(DeleteScopeRequest request);
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
        Task<DeleteScopeResponse> DeleteScopeAsync(DeleteScopeRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        GetMonitorResponse GetMonitor(GetMonitorRequest request);
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
        Task<GetMonitorResponse> GetMonitorAsync(GetMonitorRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        GetMonitorScopeSuggestionsResponse GetMonitorScopeSuggestions(GetMonitorScopeSuggestionsRequest request);
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
        Task<GetMonitorScopeSuggestionsResponse> GetMonitorScopeSuggestionsAsync(GetMonitorScopeSuggestionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        GetPerformanceMonitorResponse GetPerformanceMonitor(GetPerformanceMonitorRequest request);
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
        Task<GetPerformanceMonitorResponse> GetPerformanceMonitorAsync(GetPerformanceMonitorRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        GetQueryResultsMonitorTopContributorsResponse GetQueryResultsMonitorTopContributors(GetQueryResultsMonitorTopContributorsRequest request);
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
        Task<GetQueryResultsMonitorTopContributorsResponse> GetQueryResultsMonitorTopContributorsAsync(GetQueryResultsMonitorTopContributorsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        GetQueryResultsPerformanceMonitorResponse GetQueryResultsPerformanceMonitor(GetQueryResultsPerformanceMonitorRequest request);
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
        Task<GetQueryResultsPerformanceMonitorResponse> GetQueryResultsPerformanceMonitorAsync(GetQueryResultsPerformanceMonitorRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        GetQueryResultsWorkloadInsightsTopContributorsResponse GetQueryResultsWorkloadInsightsTopContributors(GetQueryResultsWorkloadInsightsTopContributorsRequest request);
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
        Task<GetQueryResultsWorkloadInsightsTopContributorsResponse> GetQueryResultsWorkloadInsightsTopContributorsAsync(GetQueryResultsWorkloadInsightsTopContributorsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        GetQueryResultsWorkloadInsightsTopContributorsDataResponse GetQueryResultsWorkloadInsightsTopContributorsData(GetQueryResultsWorkloadInsightsTopContributorsDataRequest request);
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
        Task<GetQueryResultsWorkloadInsightsTopContributorsDataResponse> GetQueryResultsWorkloadInsightsTopContributorsDataAsync(GetQueryResultsWorkloadInsightsTopContributorsDataRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        GetQueryStatusMonitorTopContributorsResponse GetQueryStatusMonitorTopContributors(GetQueryStatusMonitorTopContributorsRequest request);
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
        Task<GetQueryStatusMonitorTopContributorsResponse> GetQueryStatusMonitorTopContributorsAsync(GetQueryStatusMonitorTopContributorsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        GetQueryStatusPerformanceMonitorResponse GetQueryStatusPerformanceMonitor(GetQueryStatusPerformanceMonitorRequest request);
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
        Task<GetQueryStatusPerformanceMonitorResponse> GetQueryStatusPerformanceMonitorAsync(GetQueryStatusPerformanceMonitorRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        GetQueryStatusWorkloadInsightsTopContributorsResponse GetQueryStatusWorkloadInsightsTopContributors(GetQueryStatusWorkloadInsightsTopContributorsRequest request);
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
        Task<GetQueryStatusWorkloadInsightsTopContributorsResponse> GetQueryStatusWorkloadInsightsTopContributorsAsync(GetQueryStatusWorkloadInsightsTopContributorsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        GetQueryStatusWorkloadInsightsTopContributorsDataResponse GetQueryStatusWorkloadInsightsTopContributorsData(GetQueryStatusWorkloadInsightsTopContributorsDataRequest request);
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
        Task<GetQueryStatusWorkloadInsightsTopContributorsDataResponse> GetQueryStatusWorkloadInsightsTopContributorsDataAsync(GetQueryStatusWorkloadInsightsTopContributorsDataRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        GetScopeResponse GetScope(GetScopeRequest request);
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
        Task<GetScopeResponse> GetScopeAsync(GetScopeRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ListMonitorsResponse ListMonitors(ListMonitorsRequest request);
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
        Task<ListMonitorsResponse> ListMonitorsAsync(ListMonitorsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ListPerformanceMonitorsResponse ListPerformanceMonitors(ListPerformanceMonitorsRequest request);
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
        Task<ListPerformanceMonitorsResponse> ListPerformanceMonitorsAsync(ListPerformanceMonitorsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ListScopesResponse ListScopes(ListScopesRequest request);
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
        Task<ListScopesResponse> ListScopesAsync(ListScopesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);
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
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        StartQueryMonitorTopContributorsResponse StartQueryMonitorTopContributors(StartQueryMonitorTopContributorsRequest request);
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
        Task<StartQueryMonitorTopContributorsResponse> StartQueryMonitorTopContributorsAsync(StartQueryMonitorTopContributorsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        StartQueryPerformanceMonitorResponse StartQueryPerformanceMonitor(StartQueryPerformanceMonitorRequest request);
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
        Task<StartQueryPerformanceMonitorResponse> StartQueryPerformanceMonitorAsync(StartQueryPerformanceMonitorRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        StartQueryWorkloadInsightsTopContributorsResponse StartQueryWorkloadInsightsTopContributors(StartQueryWorkloadInsightsTopContributorsRequest request);
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
        Task<StartQueryWorkloadInsightsTopContributorsResponse> StartQueryWorkloadInsightsTopContributorsAsync(StartQueryWorkloadInsightsTopContributorsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        StartQueryWorkloadInsightsTopContributorsDataResponse StartQueryWorkloadInsightsTopContributorsData(StartQueryWorkloadInsightsTopContributorsDataRequest request);
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
        Task<StartQueryWorkloadInsightsTopContributorsDataResponse> StartQueryWorkloadInsightsTopContributorsDataAsync(StartQueryWorkloadInsightsTopContributorsDataRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        StopQueryMonitorTopContributorsResponse StopQueryMonitorTopContributors(StopQueryMonitorTopContributorsRequest request);
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
        Task<StopQueryMonitorTopContributorsResponse> StopQueryMonitorTopContributorsAsync(StopQueryMonitorTopContributorsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        StopQueryPerformanceMonitorResponse StopQueryPerformanceMonitor(StopQueryPerformanceMonitorRequest request);
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
        Task<StopQueryPerformanceMonitorResponse> StopQueryPerformanceMonitorAsync(StopQueryPerformanceMonitorRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        StopQueryWorkloadInsightsTopContributorsResponse StopQueryWorkloadInsightsTopContributors(StopQueryWorkloadInsightsTopContributorsRequest request);
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
        Task<StopQueryWorkloadInsightsTopContributorsResponse> StopQueryWorkloadInsightsTopContributorsAsync(StopQueryWorkloadInsightsTopContributorsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        StopQueryWorkloadInsightsTopContributorsDataResponse StopQueryWorkloadInsightsTopContributorsData(StopQueryWorkloadInsightsTopContributorsDataRequest request);
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
        Task<StopQueryWorkloadInsightsTopContributorsDataResponse> StopQueryWorkloadInsightsTopContributorsDataAsync(StopQueryWorkloadInsightsTopContributorsDataRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        TagResourceResponse TagResource(TagResourceRequest request);
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
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        UntagResourceResponse UntagResource(UntagResourceRequest request);
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
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        UpdateMonitorResponse UpdateMonitor(UpdateMonitorRequest request);
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
        Task<UpdateMonitorResponse> UpdateMonitorAsync(UpdateMonitorRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        UpdatePerformanceMonitorResponse UpdatePerformanceMonitor(UpdatePerformanceMonitorRequest request);
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
        Task<UpdatePerformanceMonitorResponse> UpdatePerformanceMonitorAsync(UpdatePerformanceMonitorRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        UpdateScopeResponse UpdateScope(UpdateScopeRequest request);
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
        Task<UpdateScopeResponse> UpdateScopeAsync(UpdateScopeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);

#if NET8_0_OR_GREATER
        // Warning CA1033 is issued when the child types can not call the method defined in parent types.
        // In this use case the intended caller is only meant to be the interface as a factory
        // method to create the child types. Given the SDK use case the warning can be ignored.
#pragma warning disable CA1033
        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonNetworkFlowMonitorConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonNetworkFlowMonitorConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
            Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonNetworkFlowMonitorConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonNetworkFlowMonitorConfig to create AmazonNetworkFlowMonitorClient");
            }

            return awsCredentials == null ?
                    new AmazonNetworkFlowMonitorClient(serviceClientConfig) :
                    new AmazonNetworkFlowMonitorClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
    }
}
