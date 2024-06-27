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
using System.Threading;
using System.Threading.Tasks;
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
#if AWS_ASYNC_ENUMERABLES_API
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateMonitorResponse> CreateMonitorAsync(CreateMonitorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateProbe



        /// <summary>
        /// Create a probe within a monitor. Once you create a probe, and it begins monitoring
        /// your network traffic, you'll incur billing charges for that probe. This action requires
        /// the <c>monitorName</c> parameter. Run <c>ListMonitors</c> to get a list of monitor
        /// names. Note the name of the <c>monitorName</c> you want to create the probe for.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProbe service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateProbeResponse> CreateProbeAsync(CreateProbeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteMonitorResponse> DeleteMonitorAsync(DeleteMonitorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteProbeResponse> DeleteProbeAsync(DeleteProbeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetMonitorResponse> GetMonitorAsync(GetMonitorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetProbe



        /// <summary>
        /// Returns the details about a probe. This action requires both the <c>monitorName</c>
        /// and <c>probeId</c> parameters. Run <c>ListMonitors</c> to get a list of monitor names.
        /// Run <c>GetMonitor</c> to get a list of probes and probe IDs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProbe service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetProbeResponse> GetProbeAsync(GetProbeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListMonitors



        /// <summary>
        /// Returns a list of all of your monitors.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMonitors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListMonitorsResponse> ListMonitorsAsync(ListMonitorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Lists the tags assigned to this resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Adds key-value pairs to a monitor or probe.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes a key-value pair from a monitor or probe.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateMonitor



        /// <summary>
        /// Updates the <c>aggregationPeriod</c> for a monitor. Monitors support an <c>aggregationPeriod</c>
        /// of either <c>30</c> or <c>60</c> seconds. This action requires the <c>monitorName</c>
        /// and <c>probeId</c> parameter. Run <c>ListMonitors</c> to get a list of monitor names.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMonitor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateMonitorResponse> UpdateMonitorAsync(UpdateMonitorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateProbeResponse> UpdateProbeAsync(UpdateProbeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

        #region Static factory interface methods
#if NET8_0_OR_GREATER
// Warning CA1033 is issued when the child types can not call the method defined in parent types.
// In this use case the intended caller is only meant to be the interface as a factory
// method to create the child types. Given the SDK use case the warning can be ignored.
#pragma warning disable CA1033
        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonNetworkMonitorConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonNetworkMonitorConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonNetworkMonitorConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonNetworkMonitorConfig to create AmazonNetworkMonitorClient");
            }

            return awsCredentials == null ? 
                    new AmazonNetworkMonitorClient(serviceClientConfig) :
                    new AmazonNetworkMonitorClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}