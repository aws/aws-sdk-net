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
 * Do not modify this file. This file is generated from the networkmanager-2019-07-05.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.NetworkManager.Model;

namespace Amazon.NetworkManager
{
    /// <summary>
    /// Interface for accessing NetworkManager
    ///
    /// Transit Gateway Network Manager (Network Manager) enables you to create a global network,
    /// in which you can monitor your AWS and on-premises networks that are built around transit
    /// gateways.
    /// 
    ///  
    /// <para>
    /// The Network Manager APIs are supported in the US West (Oregon) Region only. You must
    /// specify the <code>us-west-2</code> Region in all requests made to Network Manager.
    /// </para>
    /// </summary>
#if NETSTANDARD13
    [Obsolete("Support for .NET Standard 1.3 is in maintenance mode and will only receive critical bug fixes and security patches. Visit https://docs.aws.amazon.com/sdk-for-net/v3/developer-guide/migration-from-net-standard-1-3.html for further details.")]
#endif
    public partial interface IAmazonNetworkManager : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        INetworkManagerPaginatorFactory Paginators { get; }
#endif
                
        #region  AssociateCustomerGateway



        /// <summary>
        /// Associates a customer gateway with a device and optionally, with a link. If you specify
        /// a link, it must be associated with the specified device. 
        /// 
        ///  
        /// <para>
        /// You can only associate customer gateways that are connected to a VPN attachment on
        /// a transit gateway. The transit gateway must be registered in your global network.
        /// When you register a transit gateway, customer gateways that are connected to the transit
        /// gateway are automatically included in the global network. To list customer gateways
        /// that are connected to a transit gateway, use the <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DescribeVpnConnections.html">DescribeVpnConnections</a>
        /// EC2 API and filter by <code>transit-gateway-id</code>.
        /// </para>
        ///  
        /// <para>
        /// You cannot associate a customer gateway with more than one device and link. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateCustomerGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateCustomerGateway service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ServiceQuotaExceededException">
        /// A service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/AssociateCustomerGateway">REST API Reference for AssociateCustomerGateway Operation</seealso>
        Task<AssociateCustomerGatewayResponse> AssociateCustomerGatewayAsync(AssociateCustomerGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AssociateLink



        /// <summary>
        /// Associates a link to a device. A device can be associated to multiple links and a
        /// link can be associated to multiple devices. The device and link must be in the same
        /// global network and the same site.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateLink service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateLink service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ServiceQuotaExceededException">
        /// A service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/AssociateLink">REST API Reference for AssociateLink Operation</seealso>
        Task<AssociateLinkResponse> AssociateLinkAsync(AssociateLinkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AssociateTransitGatewayConnectPeer



        /// <summary>
        /// Associates a transit gateway Connect peer with a device, and optionally, with a link.
        /// If you specify a link, it must be associated with the specified device. 
        /// 
        ///  
        /// <para>
        /// You can only associate transit gateway Connect peers that have been created on a transit
        /// gateway that's registered in your global network.
        /// </para>
        ///  
        /// <para>
        /// You cannot associate a transit gateway Connect peer with more than one device and
        /// link. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateTransitGatewayConnectPeer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateTransitGatewayConnectPeer service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ServiceQuotaExceededException">
        /// A service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/AssociateTransitGatewayConnectPeer">REST API Reference for AssociateTransitGatewayConnectPeer Operation</seealso>
        Task<AssociateTransitGatewayConnectPeerResponse> AssociateTransitGatewayConnectPeerAsync(AssociateTransitGatewayConnectPeerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateConnection



        /// <summary>
        /// Creates a connection between two devices. The devices can be a physical or virtual
        /// appliance that connects to a third-party appliance in a VPC, or a physical appliance
        /// that connects to another physical appliance in an on-premises network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateConnection service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ServiceQuotaExceededException">
        /// A service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/CreateConnection">REST API Reference for CreateConnection Operation</seealso>
        Task<CreateConnectionResponse> CreateConnectionAsync(CreateConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateDevice



        /// <summary>
        /// Creates a new device in a global network. If you specify both a site ID and a location,
        /// the location of the site is used for visualization in the Network Manager console.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDevice service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDevice service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ServiceQuotaExceededException">
        /// A service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/CreateDevice">REST API Reference for CreateDevice Operation</seealso>
        Task<CreateDeviceResponse> CreateDeviceAsync(CreateDeviceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateGlobalNetwork



        /// <summary>
        /// Creates a new, empty global network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGlobalNetwork service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateGlobalNetwork service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ServiceQuotaExceededException">
        /// A service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/CreateGlobalNetwork">REST API Reference for CreateGlobalNetwork Operation</seealso>
        Task<CreateGlobalNetworkResponse> CreateGlobalNetworkAsync(CreateGlobalNetworkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateLink



        /// <summary>
        /// Creates a new link for a specified site.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLink service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLink service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ServiceQuotaExceededException">
        /// A service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/CreateLink">REST API Reference for CreateLink Operation</seealso>
        Task<CreateLinkResponse> CreateLinkAsync(CreateLinkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateSite



        /// <summary>
        /// Creates a new site in a global network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSite service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSite service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ServiceQuotaExceededException">
        /// A service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/CreateSite">REST API Reference for CreateSite Operation</seealso>
        Task<CreateSiteResponse> CreateSiteAsync(CreateSiteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteConnection



        /// <summary>
        /// Deletes the specified connection in your global network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteConnection service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DeleteConnection">REST API Reference for DeleteConnection Operation</seealso>
        Task<DeleteConnectionResponse> DeleteConnectionAsync(DeleteConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteDevice



        /// <summary>
        /// Deletes an existing device. You must first disassociate the device from any links
        /// and customer gateways.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDevice service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDevice service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DeleteDevice">REST API Reference for DeleteDevice Operation</seealso>
        Task<DeleteDeviceResponse> DeleteDeviceAsync(DeleteDeviceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteGlobalNetwork



        /// <summary>
        /// Deletes an existing global network. You must first delete all global network objects
        /// (devices, links, and sites) and deregister all transit gateways.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGlobalNetwork service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteGlobalNetwork service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DeleteGlobalNetwork">REST API Reference for DeleteGlobalNetwork Operation</seealso>
        Task<DeleteGlobalNetworkResponse> DeleteGlobalNetworkAsync(DeleteGlobalNetworkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteLink



        /// <summary>
        /// Deletes an existing link. You must first disassociate the link from any devices and
        /// customer gateways.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLink service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLink service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DeleteLink">REST API Reference for DeleteLink Operation</seealso>
        Task<DeleteLinkResponse> DeleteLinkAsync(DeleteLinkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteSite



        /// <summary>
        /// Deletes an existing site. The site cannot be associated with any device or link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSite service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSite service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DeleteSite">REST API Reference for DeleteSite Operation</seealso>
        Task<DeleteSiteResponse> DeleteSiteAsync(DeleteSiteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeregisterTransitGateway



        /// <summary>
        /// Deregisters a transit gateway from your global network. This action does not delete
        /// your transit gateway, or modify any of its attachments. This action removes any customer
        /// gateway associations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterTransitGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeregisterTransitGateway service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DeregisterTransitGateway">REST API Reference for DeregisterTransitGateway Operation</seealso>
        Task<DeregisterTransitGatewayResponse> DeregisterTransitGatewayAsync(DeregisterTransitGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeGlobalNetworks



        /// <summary>
        /// Describes one or more global networks. By default, all global networks are described.
        /// To describe the objects in your global network, you must use the appropriate <code>Get*</code>
        /// action. For example, to list the transit gateways in your global network, use <a>GetTransitGatewayRegistrations</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGlobalNetworks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeGlobalNetworks service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DescribeGlobalNetworks">REST API Reference for DescribeGlobalNetworks Operation</seealso>
        Task<DescribeGlobalNetworksResponse> DescribeGlobalNetworksAsync(DescribeGlobalNetworksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisassociateCustomerGateway



        /// <summary>
        /// Disassociates a customer gateway from a device and a link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateCustomerGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateCustomerGateway service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DisassociateCustomerGateway">REST API Reference for DisassociateCustomerGateway Operation</seealso>
        Task<DisassociateCustomerGatewayResponse> DisassociateCustomerGatewayAsync(DisassociateCustomerGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisassociateLink



        /// <summary>
        /// Disassociates an existing device from a link. You must first disassociate any customer
        /// gateways that are associated with the link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateLink service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateLink service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DisassociateLink">REST API Reference for DisassociateLink Operation</seealso>
        Task<DisassociateLinkResponse> DisassociateLinkAsync(DisassociateLinkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisassociateTransitGatewayConnectPeer



        /// <summary>
        /// Disassociates a transit gateway Connect peer from a device and link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateTransitGatewayConnectPeer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateTransitGatewayConnectPeer service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DisassociateTransitGatewayConnectPeer">REST API Reference for DisassociateTransitGatewayConnectPeer Operation</seealso>
        Task<DisassociateTransitGatewayConnectPeerResponse> DisassociateTransitGatewayConnectPeerAsync(DisassociateTransitGatewayConnectPeerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetConnections



        /// <summary>
        /// Gets information about one or more of your connections in a global network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnections service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetConnections service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetConnections">REST API Reference for GetConnections Operation</seealso>
        Task<GetConnectionsResponse> GetConnectionsAsync(GetConnectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetCustomerGatewayAssociations



        /// <summary>
        /// Gets the association information for customer gateways that are associated with devices
        /// and links in your global network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCustomerGatewayAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCustomerGatewayAssociations service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetCustomerGatewayAssociations">REST API Reference for GetCustomerGatewayAssociations Operation</seealso>
        Task<GetCustomerGatewayAssociationsResponse> GetCustomerGatewayAssociationsAsync(GetCustomerGatewayAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetDevices



        /// <summary>
        /// Gets information about one or more of your devices in a global network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDevices service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDevices service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetDevices">REST API Reference for GetDevices Operation</seealso>
        Task<GetDevicesResponse> GetDevicesAsync(GetDevicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetLinkAssociations



        /// <summary>
        /// Gets the link associations for a device or a link. Either the device ID or the link
        /// ID must be specified.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLinkAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLinkAssociations service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetLinkAssociations">REST API Reference for GetLinkAssociations Operation</seealso>
        Task<GetLinkAssociationsResponse> GetLinkAssociationsAsync(GetLinkAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetLinks



        /// <summary>
        /// Gets information about one or more links in a specified global network.
        /// 
        ///  
        /// <para>
        /// If you specify the site ID, you cannot specify the type or provider in the same request.
        /// You can specify the type and provider in the same request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLinks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLinks service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetLinks">REST API Reference for GetLinks Operation</seealso>
        Task<GetLinksResponse> GetLinksAsync(GetLinksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSites



        /// <summary>
        /// Gets information about one or more of your sites in a global network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSites service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSites service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetSites">REST API Reference for GetSites Operation</seealso>
        Task<GetSitesResponse> GetSitesAsync(GetSitesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetTransitGatewayConnectPeerAssociations



        /// <summary>
        /// Gets information about one or more of your transit gateway Connect peer associations
        /// in a global network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTransitGatewayConnectPeerAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTransitGatewayConnectPeerAssociations service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetTransitGatewayConnectPeerAssociations">REST API Reference for GetTransitGatewayConnectPeerAssociations Operation</seealso>
        Task<GetTransitGatewayConnectPeerAssociationsResponse> GetTransitGatewayConnectPeerAssociationsAsync(GetTransitGatewayConnectPeerAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetTransitGatewayRegistrations



        /// <summary>
        /// Gets information about the transit gateway registrations in a specified global network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTransitGatewayRegistrations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTransitGatewayRegistrations service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetTransitGatewayRegistrations">REST API Reference for GetTransitGatewayRegistrations Operation</seealso>
        Task<GetTransitGatewayRegistrationsResponse> GetTransitGatewayRegistrationsAsync(GetTransitGatewayRegistrationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Lists the tags for a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RegisterTransitGateway



        /// <summary>
        /// Registers a transit gateway in your global network. The transit gateway can be in
        /// any AWS Region, but it must be owned by the same AWS account that owns the global
        /// network. You cannot register a transit gateway in more than one global network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterTransitGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterTransitGateway service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/RegisterTransitGateway">REST API Reference for RegisterTransitGateway Operation</seealso>
        Task<RegisterTransitGatewayResponse> RegisterTransitGatewayAsync(RegisterTransitGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Tags a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ServiceQuotaExceededException">
        /// A service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes tags from a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateConnection



        /// <summary>
        /// Updates the information for an existing connection. To remove information for any
        /// of the parameters, specify an empty string.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateConnection service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/UpdateConnection">REST API Reference for UpdateConnection Operation</seealso>
        Task<UpdateConnectionResponse> UpdateConnectionAsync(UpdateConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateDevice



        /// <summary>
        /// Updates the details for an existing device. To remove information for any of the parameters,
        /// specify an empty string.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDevice service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDevice service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/UpdateDevice">REST API Reference for UpdateDevice Operation</seealso>
        Task<UpdateDeviceResponse> UpdateDeviceAsync(UpdateDeviceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateGlobalNetwork



        /// <summary>
        /// Updates an existing global network. To remove information for any of the parameters,
        /// specify an empty string.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGlobalNetwork service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateGlobalNetwork service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/UpdateGlobalNetwork">REST API Reference for UpdateGlobalNetwork Operation</seealso>
        Task<UpdateGlobalNetworkResponse> UpdateGlobalNetworkAsync(UpdateGlobalNetworkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateLink



        /// <summary>
        /// Updates the details for an existing link. To remove information for any of the parameters,
        /// specify an empty string.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLink service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateLink service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ServiceQuotaExceededException">
        /// A service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/UpdateLink">REST API Reference for UpdateLink Operation</seealso>
        Task<UpdateLinkResponse> UpdateLinkAsync(UpdateLinkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateSite



        /// <summary>
        /// Updates the information for an existing site. To remove information for any of the
        /// parameters, specify an empty string.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSite service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSite service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/UpdateSite">REST API Reference for UpdateSite Operation</seealso>
        Task<UpdateSiteResponse> UpdateSiteAsync(UpdateSiteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}