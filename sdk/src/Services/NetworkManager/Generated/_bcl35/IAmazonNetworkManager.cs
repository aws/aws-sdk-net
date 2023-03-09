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
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.NetworkManager.Model;

namespace Amazon.NetworkManager
{
    /// <summary>
    /// Interface for accessing NetworkManager
    ///
    /// Amazon Web Services enables you to centrally manage your Amazon Web Services Cloud
    /// WAN core network and your Transit Gateway network across Amazon Web Services accounts,
    /// Regions, and on-premises locations.
    /// </summary>
    public partial interface IAmazonNetworkManager : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        INetworkManagerPaginatorFactory Paginators { get; }
#endif


        
        #region  AcceptAttachment


        /// <summary>
        /// Accepts a core network attachment request. 
        /// 
        ///  
        /// <para>
        /// Once the attachment request is accepted by a core network owner, the attachment is
        /// created and connected to a core network.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptAttachment service method.</param>
        /// 
        /// <returns>The response from the AcceptAttachment service method, as returned by NetworkManager.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/AcceptAttachment">REST API Reference for AcceptAttachment Operation</seealso>
        AcceptAttachmentResponse AcceptAttachment(AcceptAttachmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AcceptAttachment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcceptAttachment operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAcceptAttachment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/AcceptAttachment">REST API Reference for AcceptAttachment Operation</seealso>
        IAsyncResult BeginAcceptAttachment(AcceptAttachmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AcceptAttachment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAcceptAttachment.</param>
        /// 
        /// <returns>Returns a  AcceptAttachmentResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/AcceptAttachment">REST API Reference for AcceptAttachment Operation</seealso>
        AcceptAttachmentResponse EndAcceptAttachment(IAsyncResult asyncResult);

        #endregion
        
        #region  AssociateConnectPeer


        /// <summary>
        /// Associates a core network Connect peer with a device and optionally, with a link.
        /// 
        /// 
        ///  
        /// <para>
        /// If you specify a link, it must be associated with the specified device. You can only
        /// associate core network Connect peers that have been created on a core network Connect
        /// attachment on a core network. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateConnectPeer service method.</param>
        /// 
        /// <returns>The response from the AssociateConnectPeer service method, as returned by NetworkManager.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/AssociateConnectPeer">REST API Reference for AssociateConnectPeer Operation</seealso>
        AssociateConnectPeerResponse AssociateConnectPeer(AssociateConnectPeerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateConnectPeer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateConnectPeer operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateConnectPeer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/AssociateConnectPeer">REST API Reference for AssociateConnectPeer Operation</seealso>
        IAsyncResult BeginAssociateConnectPeer(AssociateConnectPeerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateConnectPeer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateConnectPeer.</param>
        /// 
        /// <returns>Returns a  AssociateConnectPeerResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/AssociateConnectPeer">REST API Reference for AssociateConnectPeer Operation</seealso>
        AssociateConnectPeerResponse EndAssociateConnectPeer(IAsyncResult asyncResult);

        #endregion
        
        #region  AssociateCustomerGateway


        /// <summary>
        /// Associates a customer gateway with a device and optionally, with a link. If you specify
        /// a link, it must be associated with the specified device. 
        /// 
        ///  
        /// <para>
        /// You can only associate customer gateways that are connected to a VPN attachment on
        /// a transit gateway or core network registered in your global network. When you register
        /// a transit gateway or core network, customer gateways that are connected to the transit
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
        AssociateCustomerGatewayResponse AssociateCustomerGateway(AssociateCustomerGatewayRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateCustomerGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateCustomerGateway operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateCustomerGateway
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/AssociateCustomerGateway">REST API Reference for AssociateCustomerGateway Operation</seealso>
        IAsyncResult BeginAssociateCustomerGateway(AssociateCustomerGatewayRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateCustomerGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateCustomerGateway.</param>
        /// 
        /// <returns>Returns a  AssociateCustomerGatewayResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/AssociateCustomerGateway">REST API Reference for AssociateCustomerGateway Operation</seealso>
        AssociateCustomerGatewayResponse EndAssociateCustomerGateway(IAsyncResult asyncResult);

        #endregion
        
        #region  AssociateLink


        /// <summary>
        /// Associates a link to a device. A device can be associated to multiple links and a
        /// link can be associated to multiple devices. The device and link must be in the same
        /// global network and the same site.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateLink service method.</param>
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
        AssociateLinkResponse AssociateLink(AssociateLinkRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateLink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateLink operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateLink
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/AssociateLink">REST API Reference for AssociateLink Operation</seealso>
        IAsyncResult BeginAssociateLink(AssociateLinkRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateLink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateLink.</param>
        /// 
        /// <returns>Returns a  AssociateLinkResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/AssociateLink">REST API Reference for AssociateLink Operation</seealso>
        AssociateLinkResponse EndAssociateLink(IAsyncResult asyncResult);

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
        AssociateTransitGatewayConnectPeerResponse AssociateTransitGatewayConnectPeer(AssociateTransitGatewayConnectPeerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateTransitGatewayConnectPeer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateTransitGatewayConnectPeer operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateTransitGatewayConnectPeer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/AssociateTransitGatewayConnectPeer">REST API Reference for AssociateTransitGatewayConnectPeer Operation</seealso>
        IAsyncResult BeginAssociateTransitGatewayConnectPeer(AssociateTransitGatewayConnectPeerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateTransitGatewayConnectPeer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateTransitGatewayConnectPeer.</param>
        /// 
        /// <returns>Returns a  AssociateTransitGatewayConnectPeerResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/AssociateTransitGatewayConnectPeer">REST API Reference for AssociateTransitGatewayConnectPeer Operation</seealso>
        AssociateTransitGatewayConnectPeerResponse EndAssociateTransitGatewayConnectPeer(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateConnectAttachment


        /// <summary>
        /// Creates a core network Connect attachment from a specified core network attachment.
        /// 
        /// 
        ///  
        /// <para>
        /// A core network Connect attachment is a GRE-based tunnel attachment that you can use
        /// to establish a connection between a core network and an appliance. A core network
        /// Connect attachment uses an existing VPC attachment as the underlying transport mechanism.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConnectAttachment service method.</param>
        /// 
        /// <returns>The response from the CreateConnectAttachment service method, as returned by NetworkManager.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/CreateConnectAttachment">REST API Reference for CreateConnectAttachment Operation</seealso>
        CreateConnectAttachmentResponse CreateConnectAttachment(CreateConnectAttachmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateConnectAttachment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConnectAttachment operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateConnectAttachment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/CreateConnectAttachment">REST API Reference for CreateConnectAttachment Operation</seealso>
        IAsyncResult BeginCreateConnectAttachment(CreateConnectAttachmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateConnectAttachment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateConnectAttachment.</param>
        /// 
        /// <returns>Returns a  CreateConnectAttachmentResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/CreateConnectAttachment">REST API Reference for CreateConnectAttachment Operation</seealso>
        CreateConnectAttachmentResponse EndCreateConnectAttachment(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateConnection


        /// <summary>
        /// Creates a connection between two devices. The devices can be a physical or virtual
        /// appliance that connects to a third-party appliance in a VPC, or a physical appliance
        /// that connects to another physical appliance in an on-premises network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConnection service method.</param>
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
        CreateConnectionResponse CreateConnection(CreateConnectionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConnection operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/CreateConnection">REST API Reference for CreateConnection Operation</seealso>
        IAsyncResult BeginCreateConnection(CreateConnectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateConnection.</param>
        /// 
        /// <returns>Returns a  CreateConnectionResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/CreateConnection">REST API Reference for CreateConnection Operation</seealso>
        CreateConnectionResponse EndCreateConnection(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateConnectPeer


        /// <summary>
        /// Creates a core network Connect peer for a specified core network connect attachment
        /// between a core network and an appliance. The peer address and transit gateway address
        /// must be the same IP address family (IPv4 or IPv6).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConnectPeer service method.</param>
        /// 
        /// <returns>The response from the CreateConnectPeer service method, as returned by NetworkManager.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/CreateConnectPeer">REST API Reference for CreateConnectPeer Operation</seealso>
        CreateConnectPeerResponse CreateConnectPeer(CreateConnectPeerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateConnectPeer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConnectPeer operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateConnectPeer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/CreateConnectPeer">REST API Reference for CreateConnectPeer Operation</seealso>
        IAsyncResult BeginCreateConnectPeer(CreateConnectPeerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateConnectPeer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateConnectPeer.</param>
        /// 
        /// <returns>Returns a  CreateConnectPeerResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/CreateConnectPeer">REST API Reference for CreateConnectPeer Operation</seealso>
        CreateConnectPeerResponse EndCreateConnectPeer(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateCoreNetwork


        /// <summary>
        /// Creates a core network as part of your global network, and optionally, with a core
        /// network policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCoreNetwork service method.</param>
        /// 
        /// <returns>The response from the CreateCoreNetwork service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.CoreNetworkPolicyException">
        /// Describes a core network policy exception.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/CreateCoreNetwork">REST API Reference for CreateCoreNetwork Operation</seealso>
        CreateCoreNetworkResponse CreateCoreNetwork(CreateCoreNetworkRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCoreNetwork operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCoreNetwork operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCoreNetwork
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/CreateCoreNetwork">REST API Reference for CreateCoreNetwork Operation</seealso>
        IAsyncResult BeginCreateCoreNetwork(CreateCoreNetworkRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCoreNetwork operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCoreNetwork.</param>
        /// 
        /// <returns>Returns a  CreateCoreNetworkResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/CreateCoreNetwork">REST API Reference for CreateCoreNetwork Operation</seealso>
        CreateCoreNetworkResponse EndCreateCoreNetwork(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDevice


        /// <summary>
        /// Creates a new device in a global network. If you specify both a site ID and a location,
        /// the location of the site is used for visualization in the Network Manager console.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDevice service method.</param>
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
        CreateDeviceResponse CreateDevice(CreateDeviceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDevice operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDevice
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/CreateDevice">REST API Reference for CreateDevice Operation</seealso>
        IAsyncResult BeginCreateDevice(CreateDeviceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDevice operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDevice.</param>
        /// 
        /// <returns>Returns a  CreateDeviceResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/CreateDevice">REST API Reference for CreateDevice Operation</seealso>
        CreateDeviceResponse EndCreateDevice(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateGlobalNetwork


        /// <summary>
        /// Creates a new, empty global network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGlobalNetwork service method.</param>
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
        CreateGlobalNetworkResponse CreateGlobalNetwork(CreateGlobalNetworkRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateGlobalNetwork operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGlobalNetwork operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateGlobalNetwork
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/CreateGlobalNetwork">REST API Reference for CreateGlobalNetwork Operation</seealso>
        IAsyncResult BeginCreateGlobalNetwork(CreateGlobalNetworkRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateGlobalNetwork operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateGlobalNetwork.</param>
        /// 
        /// <returns>Returns a  CreateGlobalNetworkResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/CreateGlobalNetwork">REST API Reference for CreateGlobalNetwork Operation</seealso>
        CreateGlobalNetworkResponse EndCreateGlobalNetwork(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateLink


        /// <summary>
        /// Creates a new link for a specified site.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLink service method.</param>
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
        CreateLinkResponse CreateLink(CreateLinkRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLink operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLink
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/CreateLink">REST API Reference for CreateLink Operation</seealso>
        IAsyncResult BeginCreateLink(CreateLinkRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLink.</param>
        /// 
        /// <returns>Returns a  CreateLinkResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/CreateLink">REST API Reference for CreateLink Operation</seealso>
        CreateLinkResponse EndCreateLink(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateSite


        /// <summary>
        /// Creates a new site in a global network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSite service method.</param>
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
        CreateSiteResponse CreateSite(CreateSiteRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSite operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSite operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSite
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/CreateSite">REST API Reference for CreateSite Operation</seealso>
        IAsyncResult BeginCreateSite(CreateSiteRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSite operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSite.</param>
        /// 
        /// <returns>Returns a  CreateSiteResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/CreateSite">REST API Reference for CreateSite Operation</seealso>
        CreateSiteResponse EndCreateSite(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateSiteToSiteVpnAttachment


        /// <summary>
        /// Creates an Amazon Web Services site-to-site VPN attachment on an edge location of
        /// a core network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSiteToSiteVpnAttachment service method.</param>
        /// 
        /// <returns>The response from the CreateSiteToSiteVpnAttachment service method, as returned by NetworkManager.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/CreateSiteToSiteVpnAttachment">REST API Reference for CreateSiteToSiteVpnAttachment Operation</seealso>
        CreateSiteToSiteVpnAttachmentResponse CreateSiteToSiteVpnAttachment(CreateSiteToSiteVpnAttachmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSiteToSiteVpnAttachment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSiteToSiteVpnAttachment operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSiteToSiteVpnAttachment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/CreateSiteToSiteVpnAttachment">REST API Reference for CreateSiteToSiteVpnAttachment Operation</seealso>
        IAsyncResult BeginCreateSiteToSiteVpnAttachment(CreateSiteToSiteVpnAttachmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSiteToSiteVpnAttachment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSiteToSiteVpnAttachment.</param>
        /// 
        /// <returns>Returns a  CreateSiteToSiteVpnAttachmentResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/CreateSiteToSiteVpnAttachment">REST API Reference for CreateSiteToSiteVpnAttachment Operation</seealso>
        CreateSiteToSiteVpnAttachmentResponse EndCreateSiteToSiteVpnAttachment(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateTransitGatewayPeering


        /// <summary>
        /// Creates a transit gateway peering connection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTransitGatewayPeering service method.</param>
        /// 
        /// <returns>The response from the CreateTransitGatewayPeering service method, as returned by NetworkManager.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/CreateTransitGatewayPeering">REST API Reference for CreateTransitGatewayPeering Operation</seealso>
        CreateTransitGatewayPeeringResponse CreateTransitGatewayPeering(CreateTransitGatewayPeeringRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTransitGatewayPeering operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTransitGatewayPeering operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTransitGatewayPeering
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/CreateTransitGatewayPeering">REST API Reference for CreateTransitGatewayPeering Operation</seealso>
        IAsyncResult BeginCreateTransitGatewayPeering(CreateTransitGatewayPeeringRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTransitGatewayPeering operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTransitGatewayPeering.</param>
        /// 
        /// <returns>Returns a  CreateTransitGatewayPeeringResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/CreateTransitGatewayPeering">REST API Reference for CreateTransitGatewayPeering Operation</seealso>
        CreateTransitGatewayPeeringResponse EndCreateTransitGatewayPeering(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateTransitGatewayRouteTableAttachment


        /// <summary>
        /// Creates a transit gateway route table attachment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTransitGatewayRouteTableAttachment service method.</param>
        /// 
        /// <returns>The response from the CreateTransitGatewayRouteTableAttachment service method, as returned by NetworkManager.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/CreateTransitGatewayRouteTableAttachment">REST API Reference for CreateTransitGatewayRouteTableAttachment Operation</seealso>
        CreateTransitGatewayRouteTableAttachmentResponse CreateTransitGatewayRouteTableAttachment(CreateTransitGatewayRouteTableAttachmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTransitGatewayRouteTableAttachment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTransitGatewayRouteTableAttachment operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTransitGatewayRouteTableAttachment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/CreateTransitGatewayRouteTableAttachment">REST API Reference for CreateTransitGatewayRouteTableAttachment Operation</seealso>
        IAsyncResult BeginCreateTransitGatewayRouteTableAttachment(CreateTransitGatewayRouteTableAttachmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTransitGatewayRouteTableAttachment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTransitGatewayRouteTableAttachment.</param>
        /// 
        /// <returns>Returns a  CreateTransitGatewayRouteTableAttachmentResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/CreateTransitGatewayRouteTableAttachment">REST API Reference for CreateTransitGatewayRouteTableAttachment Operation</seealso>
        CreateTransitGatewayRouteTableAttachmentResponse EndCreateTransitGatewayRouteTableAttachment(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateVpcAttachment


        /// <summary>
        /// Creates a VPC attachment on an edge location of a core network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcAttachment service method.</param>
        /// 
        /// <returns>The response from the CreateVpcAttachment service method, as returned by NetworkManager.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/CreateVpcAttachment">REST API Reference for CreateVpcAttachment Operation</seealso>
        CreateVpcAttachmentResponse CreateVpcAttachment(CreateVpcAttachmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVpcAttachment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcAttachment operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVpcAttachment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/CreateVpcAttachment">REST API Reference for CreateVpcAttachment Operation</seealso>
        IAsyncResult BeginCreateVpcAttachment(CreateVpcAttachmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVpcAttachment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVpcAttachment.</param>
        /// 
        /// <returns>Returns a  CreateVpcAttachmentResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/CreateVpcAttachment">REST API Reference for CreateVpcAttachment Operation</seealso>
        CreateVpcAttachmentResponse EndCreateVpcAttachment(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAttachment


        /// <summary>
        /// Deletes an attachment. Supports all attachment types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAttachment service method.</param>
        /// 
        /// <returns>The response from the DeleteAttachment service method, as returned by NetworkManager.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DeleteAttachment">REST API Reference for DeleteAttachment Operation</seealso>
        DeleteAttachmentResponse DeleteAttachment(DeleteAttachmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAttachment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAttachment operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAttachment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DeleteAttachment">REST API Reference for DeleteAttachment Operation</seealso>
        IAsyncResult BeginDeleteAttachment(DeleteAttachmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAttachment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAttachment.</param>
        /// 
        /// <returns>Returns a  DeleteAttachmentResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DeleteAttachment">REST API Reference for DeleteAttachment Operation</seealso>
        DeleteAttachmentResponse EndDeleteAttachment(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteConnection


        /// <summary>
        /// Deletes the specified connection in your global network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnection service method.</param>
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
        DeleteConnectionResponse DeleteConnection(DeleteConnectionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnection operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DeleteConnection">REST API Reference for DeleteConnection Operation</seealso>
        IAsyncResult BeginDeleteConnection(DeleteConnectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConnection.</param>
        /// 
        /// <returns>Returns a  DeleteConnectionResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DeleteConnection">REST API Reference for DeleteConnection Operation</seealso>
        DeleteConnectionResponse EndDeleteConnection(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteConnectPeer


        /// <summary>
        /// Deletes a Connect peer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnectPeer service method.</param>
        /// 
        /// <returns>The response from the DeleteConnectPeer service method, as returned by NetworkManager.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DeleteConnectPeer">REST API Reference for DeleteConnectPeer Operation</seealso>
        DeleteConnectPeerResponse DeleteConnectPeer(DeleteConnectPeerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConnectPeer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnectPeer operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteConnectPeer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DeleteConnectPeer">REST API Reference for DeleteConnectPeer Operation</seealso>
        IAsyncResult BeginDeleteConnectPeer(DeleteConnectPeerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteConnectPeer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConnectPeer.</param>
        /// 
        /// <returns>Returns a  DeleteConnectPeerResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DeleteConnectPeer">REST API Reference for DeleteConnectPeer Operation</seealso>
        DeleteConnectPeerResponse EndDeleteConnectPeer(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteCoreNetwork


        /// <summary>
        /// Deletes a core network along with all core network policies. This can only be done
        /// if there are no attachments on a core network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCoreNetwork service method.</param>
        /// 
        /// <returns>The response from the DeleteCoreNetwork service method, as returned by NetworkManager.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DeleteCoreNetwork">REST API Reference for DeleteCoreNetwork Operation</seealso>
        DeleteCoreNetworkResponse DeleteCoreNetwork(DeleteCoreNetworkRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCoreNetwork operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCoreNetwork operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCoreNetwork
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DeleteCoreNetwork">REST API Reference for DeleteCoreNetwork Operation</seealso>
        IAsyncResult BeginDeleteCoreNetwork(DeleteCoreNetworkRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCoreNetwork operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCoreNetwork.</param>
        /// 
        /// <returns>Returns a  DeleteCoreNetworkResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DeleteCoreNetwork">REST API Reference for DeleteCoreNetwork Operation</seealso>
        DeleteCoreNetworkResponse EndDeleteCoreNetwork(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteCoreNetworkPolicyVersion


        /// <summary>
        /// Deletes a policy version from a core network. You can't delete the current LIVE policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCoreNetworkPolicyVersion service method.</param>
        /// 
        /// <returns>The response from the DeleteCoreNetworkPolicyVersion service method, as returned by NetworkManager.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DeleteCoreNetworkPolicyVersion">REST API Reference for DeleteCoreNetworkPolicyVersion Operation</seealso>
        DeleteCoreNetworkPolicyVersionResponse DeleteCoreNetworkPolicyVersion(DeleteCoreNetworkPolicyVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCoreNetworkPolicyVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCoreNetworkPolicyVersion operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCoreNetworkPolicyVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DeleteCoreNetworkPolicyVersion">REST API Reference for DeleteCoreNetworkPolicyVersion Operation</seealso>
        IAsyncResult BeginDeleteCoreNetworkPolicyVersion(DeleteCoreNetworkPolicyVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCoreNetworkPolicyVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCoreNetworkPolicyVersion.</param>
        /// 
        /// <returns>Returns a  DeleteCoreNetworkPolicyVersionResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DeleteCoreNetworkPolicyVersion">REST API Reference for DeleteCoreNetworkPolicyVersion Operation</seealso>
        DeleteCoreNetworkPolicyVersionResponse EndDeleteCoreNetworkPolicyVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDevice


        /// <summary>
        /// Deletes an existing device. You must first disassociate the device from any links
        /// and customer gateways.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDevice service method.</param>
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
        DeleteDeviceResponse DeleteDevice(DeleteDeviceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDevice operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDevice
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DeleteDevice">REST API Reference for DeleteDevice Operation</seealso>
        IAsyncResult BeginDeleteDevice(DeleteDeviceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDevice operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDevice.</param>
        /// 
        /// <returns>Returns a  DeleteDeviceResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DeleteDevice">REST API Reference for DeleteDevice Operation</seealso>
        DeleteDeviceResponse EndDeleteDevice(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteGlobalNetwork


        /// <summary>
        /// Deletes an existing global network. You must first delete all global network objects
        /// (devices, links, and sites), deregister all transit gateways, and delete any core
        /// networks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGlobalNetwork service method.</param>
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
        DeleteGlobalNetworkResponse DeleteGlobalNetwork(DeleteGlobalNetworkRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGlobalNetwork operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGlobalNetwork operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteGlobalNetwork
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DeleteGlobalNetwork">REST API Reference for DeleteGlobalNetwork Operation</seealso>
        IAsyncResult BeginDeleteGlobalNetwork(DeleteGlobalNetworkRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteGlobalNetwork operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteGlobalNetwork.</param>
        /// 
        /// <returns>Returns a  DeleteGlobalNetworkResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DeleteGlobalNetwork">REST API Reference for DeleteGlobalNetwork Operation</seealso>
        DeleteGlobalNetworkResponse EndDeleteGlobalNetwork(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteLink


        /// <summary>
        /// Deletes an existing link. You must first disassociate the link from any devices and
        /// customer gateways.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLink service method.</param>
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
        DeleteLinkResponse DeleteLink(DeleteLinkRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLink operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteLink
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DeleteLink">REST API Reference for DeleteLink Operation</seealso>
        IAsyncResult BeginDeleteLink(DeleteLinkRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLink.</param>
        /// 
        /// <returns>Returns a  DeleteLinkResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DeleteLink">REST API Reference for DeleteLink Operation</seealso>
        DeleteLinkResponse EndDeleteLink(IAsyncResult asyncResult);

        #endregion
        
        #region  DeletePeering


        /// <summary>
        /// Deletes an existing peering connection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePeering service method.</param>
        /// 
        /// <returns>The response from the DeletePeering service method, as returned by NetworkManager.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DeletePeering">REST API Reference for DeletePeering Operation</seealso>
        DeletePeeringResponse DeletePeering(DeletePeeringRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePeering operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePeering operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePeering
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DeletePeering">REST API Reference for DeletePeering Operation</seealso>
        IAsyncResult BeginDeletePeering(DeletePeeringRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePeering operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePeering.</param>
        /// 
        /// <returns>Returns a  DeletePeeringResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DeletePeering">REST API Reference for DeletePeering Operation</seealso>
        DeletePeeringResponse EndDeletePeering(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteResourcePolicy


        /// <summary>
        /// Deletes a resource policy for the specified resource. This revokes the access of the
        /// principals specified in the resource policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteResourcePolicy service method, as returned by NetworkManager.</returns>
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
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        DeleteResourcePolicyResponse DeleteResourcePolicy(DeleteResourcePolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteResourcePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        IAsyncResult BeginDeleteResourcePolicy(DeleteResourcePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteResourcePolicy.</param>
        /// 
        /// <returns>Returns a  DeleteResourcePolicyResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        DeleteResourcePolicyResponse EndDeleteResourcePolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteSite


        /// <summary>
        /// Deletes an existing site. The site cannot be associated with any device or link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSite service method.</param>
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
        DeleteSiteResponse DeleteSite(DeleteSiteRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSite operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSite operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSite
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DeleteSite">REST API Reference for DeleteSite Operation</seealso>
        IAsyncResult BeginDeleteSite(DeleteSiteRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSite operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSite.</param>
        /// 
        /// <returns>Returns a  DeleteSiteResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DeleteSite">REST API Reference for DeleteSite Operation</seealso>
        DeleteSiteResponse EndDeleteSite(IAsyncResult asyncResult);

        #endregion
        
        #region  DeregisterTransitGateway


        /// <summary>
        /// Deregisters a transit gateway from your global network. This action does not delete
        /// your transit gateway, or modify any of its attachments. This action removes any customer
        /// gateway associations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterTransitGateway service method.</param>
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
        DeregisterTransitGatewayResponse DeregisterTransitGateway(DeregisterTransitGatewayRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterTransitGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterTransitGateway operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeregisterTransitGateway
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DeregisterTransitGateway">REST API Reference for DeregisterTransitGateway Operation</seealso>
        IAsyncResult BeginDeregisterTransitGateway(DeregisterTransitGatewayRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeregisterTransitGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterTransitGateway.</param>
        /// 
        /// <returns>Returns a  DeregisterTransitGatewayResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DeregisterTransitGateway">REST API Reference for DeregisterTransitGateway Operation</seealso>
        DeregisterTransitGatewayResponse EndDeregisterTransitGateway(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeGlobalNetworks


        /// <summary>
        /// Describes one or more global networks. By default, all global networks are described.
        /// To describe the objects in your global network, you must use the appropriate <code>Get*</code>
        /// action. For example, to list the transit gateways in your global network, use <a>GetTransitGatewayRegistrations</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGlobalNetworks service method.</param>
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
        DescribeGlobalNetworksResponse DescribeGlobalNetworks(DescribeGlobalNetworksRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeGlobalNetworks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeGlobalNetworks operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeGlobalNetworks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DescribeGlobalNetworks">REST API Reference for DescribeGlobalNetworks Operation</seealso>
        IAsyncResult BeginDescribeGlobalNetworks(DescribeGlobalNetworksRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeGlobalNetworks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeGlobalNetworks.</param>
        /// 
        /// <returns>Returns a  DescribeGlobalNetworksResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DescribeGlobalNetworks">REST API Reference for DescribeGlobalNetworks Operation</seealso>
        DescribeGlobalNetworksResponse EndDescribeGlobalNetworks(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateConnectPeer


        /// <summary>
        /// Disassociates a core network Connect peer from a device and a link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateConnectPeer service method.</param>
        /// 
        /// <returns>The response from the DisassociateConnectPeer service method, as returned by NetworkManager.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DisassociateConnectPeer">REST API Reference for DisassociateConnectPeer Operation</seealso>
        DisassociateConnectPeerResponse DisassociateConnectPeer(DisassociateConnectPeerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateConnectPeer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateConnectPeer operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateConnectPeer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DisassociateConnectPeer">REST API Reference for DisassociateConnectPeer Operation</seealso>
        IAsyncResult BeginDisassociateConnectPeer(DisassociateConnectPeerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateConnectPeer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateConnectPeer.</param>
        /// 
        /// <returns>Returns a  DisassociateConnectPeerResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DisassociateConnectPeer">REST API Reference for DisassociateConnectPeer Operation</seealso>
        DisassociateConnectPeerResponse EndDisassociateConnectPeer(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateCustomerGateway


        /// <summary>
        /// Disassociates a customer gateway from a device and a link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateCustomerGateway service method.</param>
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
        DisassociateCustomerGatewayResponse DisassociateCustomerGateway(DisassociateCustomerGatewayRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateCustomerGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateCustomerGateway operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateCustomerGateway
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DisassociateCustomerGateway">REST API Reference for DisassociateCustomerGateway Operation</seealso>
        IAsyncResult BeginDisassociateCustomerGateway(DisassociateCustomerGatewayRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateCustomerGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateCustomerGateway.</param>
        /// 
        /// <returns>Returns a  DisassociateCustomerGatewayResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DisassociateCustomerGateway">REST API Reference for DisassociateCustomerGateway Operation</seealso>
        DisassociateCustomerGatewayResponse EndDisassociateCustomerGateway(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateLink


        /// <summary>
        /// Disassociates an existing device from a link. You must first disassociate any customer
        /// gateways that are associated with the link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateLink service method.</param>
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
        DisassociateLinkResponse DisassociateLink(DisassociateLinkRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateLink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateLink operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateLink
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DisassociateLink">REST API Reference for DisassociateLink Operation</seealso>
        IAsyncResult BeginDisassociateLink(DisassociateLinkRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateLink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateLink.</param>
        /// 
        /// <returns>Returns a  DisassociateLinkResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DisassociateLink">REST API Reference for DisassociateLink Operation</seealso>
        DisassociateLinkResponse EndDisassociateLink(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateTransitGatewayConnectPeer


        /// <summary>
        /// Disassociates a transit gateway Connect peer from a device and link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateTransitGatewayConnectPeer service method.</param>
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
        DisassociateTransitGatewayConnectPeerResponse DisassociateTransitGatewayConnectPeer(DisassociateTransitGatewayConnectPeerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateTransitGatewayConnectPeer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateTransitGatewayConnectPeer operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateTransitGatewayConnectPeer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DisassociateTransitGatewayConnectPeer">REST API Reference for DisassociateTransitGatewayConnectPeer Operation</seealso>
        IAsyncResult BeginDisassociateTransitGatewayConnectPeer(DisassociateTransitGatewayConnectPeerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateTransitGatewayConnectPeer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateTransitGatewayConnectPeer.</param>
        /// 
        /// <returns>Returns a  DisassociateTransitGatewayConnectPeerResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DisassociateTransitGatewayConnectPeer">REST API Reference for DisassociateTransitGatewayConnectPeer Operation</seealso>
        DisassociateTransitGatewayConnectPeerResponse EndDisassociateTransitGatewayConnectPeer(IAsyncResult asyncResult);

        #endregion
        
        #region  ExecuteCoreNetworkChangeSet


        /// <summary>
        /// Executes a change set on your core network. Deploys changes globally based on the
        /// policy submitted..
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteCoreNetworkChangeSet service method.</param>
        /// 
        /// <returns>The response from the ExecuteCoreNetworkChangeSet service method, as returned by NetworkManager.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/ExecuteCoreNetworkChangeSet">REST API Reference for ExecuteCoreNetworkChangeSet Operation</seealso>
        ExecuteCoreNetworkChangeSetResponse ExecuteCoreNetworkChangeSet(ExecuteCoreNetworkChangeSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ExecuteCoreNetworkChangeSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExecuteCoreNetworkChangeSet operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndExecuteCoreNetworkChangeSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/ExecuteCoreNetworkChangeSet">REST API Reference for ExecuteCoreNetworkChangeSet Operation</seealso>
        IAsyncResult BeginExecuteCoreNetworkChangeSet(ExecuteCoreNetworkChangeSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ExecuteCoreNetworkChangeSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExecuteCoreNetworkChangeSet.</param>
        /// 
        /// <returns>Returns a  ExecuteCoreNetworkChangeSetResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/ExecuteCoreNetworkChangeSet">REST API Reference for ExecuteCoreNetworkChangeSet Operation</seealso>
        ExecuteCoreNetworkChangeSetResponse EndExecuteCoreNetworkChangeSet(IAsyncResult asyncResult);

        #endregion
        
        #region  GetConnectAttachment


        /// <summary>
        /// Returns information about a core network Connect attachment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnectAttachment service method.</param>
        /// 
        /// <returns>The response from the GetConnectAttachment service method, as returned by NetworkManager.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetConnectAttachment">REST API Reference for GetConnectAttachment Operation</seealso>
        GetConnectAttachmentResponse GetConnectAttachment(GetConnectAttachmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetConnectAttachment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConnectAttachment operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetConnectAttachment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetConnectAttachment">REST API Reference for GetConnectAttachment Operation</seealso>
        IAsyncResult BeginGetConnectAttachment(GetConnectAttachmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetConnectAttachment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetConnectAttachment.</param>
        /// 
        /// <returns>Returns a  GetConnectAttachmentResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetConnectAttachment">REST API Reference for GetConnectAttachment Operation</seealso>
        GetConnectAttachmentResponse EndGetConnectAttachment(IAsyncResult asyncResult);

        #endregion
        
        #region  GetConnections


        /// <summary>
        /// Gets information about one or more of your connections in a global network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnections service method.</param>
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
        GetConnectionsResponse GetConnections(GetConnectionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetConnections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConnections operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetConnections
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetConnections">REST API Reference for GetConnections Operation</seealso>
        IAsyncResult BeginGetConnections(GetConnectionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetConnections operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetConnections.</param>
        /// 
        /// <returns>Returns a  GetConnectionsResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetConnections">REST API Reference for GetConnections Operation</seealso>
        GetConnectionsResponse EndGetConnections(IAsyncResult asyncResult);

        #endregion
        
        #region  GetConnectPeer


        /// <summary>
        /// Returns information about a core network Connect peer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnectPeer service method.</param>
        /// 
        /// <returns>The response from the GetConnectPeer service method, as returned by NetworkManager.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetConnectPeer">REST API Reference for GetConnectPeer Operation</seealso>
        GetConnectPeerResponse GetConnectPeer(GetConnectPeerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetConnectPeer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConnectPeer operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetConnectPeer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetConnectPeer">REST API Reference for GetConnectPeer Operation</seealso>
        IAsyncResult BeginGetConnectPeer(GetConnectPeerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetConnectPeer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetConnectPeer.</param>
        /// 
        /// <returns>Returns a  GetConnectPeerResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetConnectPeer">REST API Reference for GetConnectPeer Operation</seealso>
        GetConnectPeerResponse EndGetConnectPeer(IAsyncResult asyncResult);

        #endregion
        
        #region  GetConnectPeerAssociations


        /// <summary>
        /// Returns information about a core network Connect peer associations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnectPeerAssociations service method.</param>
        /// 
        /// <returns>The response from the GetConnectPeerAssociations service method, as returned by NetworkManager.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetConnectPeerAssociations">REST API Reference for GetConnectPeerAssociations Operation</seealso>
        GetConnectPeerAssociationsResponse GetConnectPeerAssociations(GetConnectPeerAssociationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetConnectPeerAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConnectPeerAssociations operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetConnectPeerAssociations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetConnectPeerAssociations">REST API Reference for GetConnectPeerAssociations Operation</seealso>
        IAsyncResult BeginGetConnectPeerAssociations(GetConnectPeerAssociationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetConnectPeerAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetConnectPeerAssociations.</param>
        /// 
        /// <returns>Returns a  GetConnectPeerAssociationsResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetConnectPeerAssociations">REST API Reference for GetConnectPeerAssociations Operation</seealso>
        GetConnectPeerAssociationsResponse EndGetConnectPeerAssociations(IAsyncResult asyncResult);

        #endregion
        
        #region  GetCoreNetwork


        /// <summary>
        /// Returns information about the LIVE policy for a core network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCoreNetwork service method.</param>
        /// 
        /// <returns>The response from the GetCoreNetwork service method, as returned by NetworkManager.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetCoreNetwork">REST API Reference for GetCoreNetwork Operation</seealso>
        GetCoreNetworkResponse GetCoreNetwork(GetCoreNetworkRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetCoreNetwork operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCoreNetwork operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCoreNetwork
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetCoreNetwork">REST API Reference for GetCoreNetwork Operation</seealso>
        IAsyncResult BeginGetCoreNetwork(GetCoreNetworkRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCoreNetwork operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCoreNetwork.</param>
        /// 
        /// <returns>Returns a  GetCoreNetworkResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetCoreNetwork">REST API Reference for GetCoreNetwork Operation</seealso>
        GetCoreNetworkResponse EndGetCoreNetwork(IAsyncResult asyncResult);

        #endregion
        
        #region  GetCoreNetworkChangeEvents


        /// <summary>
        /// Returns information about a core network change event.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCoreNetworkChangeEvents service method.</param>
        /// 
        /// <returns>The response from the GetCoreNetworkChangeEvents service method, as returned by NetworkManager.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetCoreNetworkChangeEvents">REST API Reference for GetCoreNetworkChangeEvents Operation</seealso>
        GetCoreNetworkChangeEventsResponse GetCoreNetworkChangeEvents(GetCoreNetworkChangeEventsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetCoreNetworkChangeEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCoreNetworkChangeEvents operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCoreNetworkChangeEvents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetCoreNetworkChangeEvents">REST API Reference for GetCoreNetworkChangeEvents Operation</seealso>
        IAsyncResult BeginGetCoreNetworkChangeEvents(GetCoreNetworkChangeEventsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCoreNetworkChangeEvents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCoreNetworkChangeEvents.</param>
        /// 
        /// <returns>Returns a  GetCoreNetworkChangeEventsResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetCoreNetworkChangeEvents">REST API Reference for GetCoreNetworkChangeEvents Operation</seealso>
        GetCoreNetworkChangeEventsResponse EndGetCoreNetworkChangeEvents(IAsyncResult asyncResult);

        #endregion
        
        #region  GetCoreNetworkChangeSet


        /// <summary>
        /// Returns a change set between the LIVE core network policy and a submitted policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCoreNetworkChangeSet service method.</param>
        /// 
        /// <returns>The response from the GetCoreNetworkChangeSet service method, as returned by NetworkManager.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetCoreNetworkChangeSet">REST API Reference for GetCoreNetworkChangeSet Operation</seealso>
        GetCoreNetworkChangeSetResponse GetCoreNetworkChangeSet(GetCoreNetworkChangeSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetCoreNetworkChangeSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCoreNetworkChangeSet operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCoreNetworkChangeSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetCoreNetworkChangeSet">REST API Reference for GetCoreNetworkChangeSet Operation</seealso>
        IAsyncResult BeginGetCoreNetworkChangeSet(GetCoreNetworkChangeSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCoreNetworkChangeSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCoreNetworkChangeSet.</param>
        /// 
        /// <returns>Returns a  GetCoreNetworkChangeSetResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetCoreNetworkChangeSet">REST API Reference for GetCoreNetworkChangeSet Operation</seealso>
        GetCoreNetworkChangeSetResponse EndGetCoreNetworkChangeSet(IAsyncResult asyncResult);

        #endregion
        
        #region  GetCoreNetworkPolicy


        /// <summary>
        /// Returns details about a core network policy. You can get details about your current
        /// live policy or any previous policy version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCoreNetworkPolicy service method.</param>
        /// 
        /// <returns>The response from the GetCoreNetworkPolicy service method, as returned by NetworkManager.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetCoreNetworkPolicy">REST API Reference for GetCoreNetworkPolicy Operation</seealso>
        GetCoreNetworkPolicyResponse GetCoreNetworkPolicy(GetCoreNetworkPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetCoreNetworkPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCoreNetworkPolicy operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCoreNetworkPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetCoreNetworkPolicy">REST API Reference for GetCoreNetworkPolicy Operation</seealso>
        IAsyncResult BeginGetCoreNetworkPolicy(GetCoreNetworkPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCoreNetworkPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCoreNetworkPolicy.</param>
        /// 
        /// <returns>Returns a  GetCoreNetworkPolicyResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetCoreNetworkPolicy">REST API Reference for GetCoreNetworkPolicy Operation</seealso>
        GetCoreNetworkPolicyResponse EndGetCoreNetworkPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  GetCustomerGatewayAssociations


        /// <summary>
        /// Gets the association information for customer gateways that are associated with devices
        /// and links in your global network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCustomerGatewayAssociations service method.</param>
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
        GetCustomerGatewayAssociationsResponse GetCustomerGatewayAssociations(GetCustomerGatewayAssociationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetCustomerGatewayAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCustomerGatewayAssociations operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCustomerGatewayAssociations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetCustomerGatewayAssociations">REST API Reference for GetCustomerGatewayAssociations Operation</seealso>
        IAsyncResult BeginGetCustomerGatewayAssociations(GetCustomerGatewayAssociationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCustomerGatewayAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCustomerGatewayAssociations.</param>
        /// 
        /// <returns>Returns a  GetCustomerGatewayAssociationsResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetCustomerGatewayAssociations">REST API Reference for GetCustomerGatewayAssociations Operation</seealso>
        GetCustomerGatewayAssociationsResponse EndGetCustomerGatewayAssociations(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDevices


        /// <summary>
        /// Gets information about one or more of your devices in a global network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDevices service method.</param>
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
        GetDevicesResponse GetDevices(GetDevicesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDevices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDevices operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDevices
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetDevices">REST API Reference for GetDevices Operation</seealso>
        IAsyncResult BeginGetDevices(GetDevicesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDevices operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDevices.</param>
        /// 
        /// <returns>Returns a  GetDevicesResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetDevices">REST API Reference for GetDevices Operation</seealso>
        GetDevicesResponse EndGetDevices(IAsyncResult asyncResult);

        #endregion
        
        #region  GetLinkAssociations


        /// <summary>
        /// Gets the link associations for a device or a link. Either the device ID or the link
        /// ID must be specified.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLinkAssociations service method.</param>
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
        GetLinkAssociationsResponse GetLinkAssociations(GetLinkAssociationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetLinkAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLinkAssociations operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLinkAssociations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetLinkAssociations">REST API Reference for GetLinkAssociations Operation</seealso>
        IAsyncResult BeginGetLinkAssociations(GetLinkAssociationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetLinkAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLinkAssociations.</param>
        /// 
        /// <returns>Returns a  GetLinkAssociationsResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetLinkAssociations">REST API Reference for GetLinkAssociations Operation</seealso>
        GetLinkAssociationsResponse EndGetLinkAssociations(IAsyncResult asyncResult);

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
        GetLinksResponse GetLinks(GetLinksRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetLinks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLinks operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLinks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetLinks">REST API Reference for GetLinks Operation</seealso>
        IAsyncResult BeginGetLinks(GetLinksRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetLinks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLinks.</param>
        /// 
        /// <returns>Returns a  GetLinksResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetLinks">REST API Reference for GetLinks Operation</seealso>
        GetLinksResponse EndGetLinks(IAsyncResult asyncResult);

        #endregion
        
        #region  GetNetworkResourceCounts


        /// <summary>
        /// Gets the count of network resources, by resource type, for the specified global network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNetworkResourceCounts service method.</param>
        /// 
        /// <returns>The response from the GetNetworkResourceCounts service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetNetworkResourceCounts">REST API Reference for GetNetworkResourceCounts Operation</seealso>
        GetNetworkResourceCountsResponse GetNetworkResourceCounts(GetNetworkResourceCountsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetNetworkResourceCounts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetNetworkResourceCounts operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetNetworkResourceCounts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetNetworkResourceCounts">REST API Reference for GetNetworkResourceCounts Operation</seealso>
        IAsyncResult BeginGetNetworkResourceCounts(GetNetworkResourceCountsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetNetworkResourceCounts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetNetworkResourceCounts.</param>
        /// 
        /// <returns>Returns a  GetNetworkResourceCountsResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetNetworkResourceCounts">REST API Reference for GetNetworkResourceCounts Operation</seealso>
        GetNetworkResourceCountsResponse EndGetNetworkResourceCounts(IAsyncResult asyncResult);

        #endregion
        
        #region  GetNetworkResourceRelationships


        /// <summary>
        /// Gets the network resource relationships for the specified global network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNetworkResourceRelationships service method.</param>
        /// 
        /// <returns>The response from the GetNetworkResourceRelationships service method, as returned by NetworkManager.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetNetworkResourceRelationships">REST API Reference for GetNetworkResourceRelationships Operation</seealso>
        GetNetworkResourceRelationshipsResponse GetNetworkResourceRelationships(GetNetworkResourceRelationshipsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetNetworkResourceRelationships operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetNetworkResourceRelationships operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetNetworkResourceRelationships
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetNetworkResourceRelationships">REST API Reference for GetNetworkResourceRelationships Operation</seealso>
        IAsyncResult BeginGetNetworkResourceRelationships(GetNetworkResourceRelationshipsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetNetworkResourceRelationships operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetNetworkResourceRelationships.</param>
        /// 
        /// <returns>Returns a  GetNetworkResourceRelationshipsResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetNetworkResourceRelationships">REST API Reference for GetNetworkResourceRelationships Operation</seealso>
        GetNetworkResourceRelationshipsResponse EndGetNetworkResourceRelationships(IAsyncResult asyncResult);

        #endregion
        
        #region  GetNetworkResources


        /// <summary>
        /// Describes the network resources for the specified global network.
        /// 
        ///  
        /// <para>
        /// The results include information from the corresponding Describe call for the resource,
        /// minus any sensitive information such as pre-shared keys.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNetworkResources service method.</param>
        /// 
        /// <returns>The response from the GetNetworkResources service method, as returned by NetworkManager.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetNetworkResources">REST API Reference for GetNetworkResources Operation</seealso>
        GetNetworkResourcesResponse GetNetworkResources(GetNetworkResourcesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetNetworkResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetNetworkResources operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetNetworkResources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetNetworkResources">REST API Reference for GetNetworkResources Operation</seealso>
        IAsyncResult BeginGetNetworkResources(GetNetworkResourcesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetNetworkResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetNetworkResources.</param>
        /// 
        /// <returns>Returns a  GetNetworkResourcesResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetNetworkResources">REST API Reference for GetNetworkResources Operation</seealso>
        GetNetworkResourcesResponse EndGetNetworkResources(IAsyncResult asyncResult);

        #endregion
        
        #region  GetNetworkRoutes


        /// <summary>
        /// Gets the network routes of the specified global network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNetworkRoutes service method.</param>
        /// 
        /// <returns>The response from the GetNetworkRoutes service method, as returned by NetworkManager.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetNetworkRoutes">REST API Reference for GetNetworkRoutes Operation</seealso>
        GetNetworkRoutesResponse GetNetworkRoutes(GetNetworkRoutesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetNetworkRoutes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetNetworkRoutes operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetNetworkRoutes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetNetworkRoutes">REST API Reference for GetNetworkRoutes Operation</seealso>
        IAsyncResult BeginGetNetworkRoutes(GetNetworkRoutesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetNetworkRoutes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetNetworkRoutes.</param>
        /// 
        /// <returns>Returns a  GetNetworkRoutesResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetNetworkRoutes">REST API Reference for GetNetworkRoutes Operation</seealso>
        GetNetworkRoutesResponse EndGetNetworkRoutes(IAsyncResult asyncResult);

        #endregion
        
        #region  GetNetworkTelemetry


        /// <summary>
        /// Gets the network telemetry of the specified global network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNetworkTelemetry service method.</param>
        /// 
        /// <returns>The response from the GetNetworkTelemetry service method, as returned by NetworkManager.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetNetworkTelemetry">REST API Reference for GetNetworkTelemetry Operation</seealso>
        GetNetworkTelemetryResponse GetNetworkTelemetry(GetNetworkTelemetryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetNetworkTelemetry operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetNetworkTelemetry operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetNetworkTelemetry
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetNetworkTelemetry">REST API Reference for GetNetworkTelemetry Operation</seealso>
        IAsyncResult BeginGetNetworkTelemetry(GetNetworkTelemetryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetNetworkTelemetry operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetNetworkTelemetry.</param>
        /// 
        /// <returns>Returns a  GetNetworkTelemetryResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetNetworkTelemetry">REST API Reference for GetNetworkTelemetry Operation</seealso>
        GetNetworkTelemetryResponse EndGetNetworkTelemetry(IAsyncResult asyncResult);

        #endregion
        
        #region  GetResourcePolicy


        /// <summary>
        /// Returns information about a resource policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the GetResourcePolicy service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        GetResourcePolicyResponse GetResourcePolicy(GetResourcePolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResourcePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        IAsyncResult BeginGetResourcePolicy(GetResourcePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResourcePolicy.</param>
        /// 
        /// <returns>Returns a  GetResourcePolicyResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        GetResourcePolicyResponse EndGetResourcePolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  GetRouteAnalysis


        /// <summary>
        /// Gets information about the specified route analysis.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRouteAnalysis service method.</param>
        /// 
        /// <returns>The response from the GetRouteAnalysis service method, as returned by NetworkManager.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetRouteAnalysis">REST API Reference for GetRouteAnalysis Operation</seealso>
        GetRouteAnalysisResponse GetRouteAnalysis(GetRouteAnalysisRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetRouteAnalysis operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRouteAnalysis operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRouteAnalysis
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetRouteAnalysis">REST API Reference for GetRouteAnalysis Operation</seealso>
        IAsyncResult BeginGetRouteAnalysis(GetRouteAnalysisRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRouteAnalysis operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRouteAnalysis.</param>
        /// 
        /// <returns>Returns a  GetRouteAnalysisResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetRouteAnalysis">REST API Reference for GetRouteAnalysis Operation</seealso>
        GetRouteAnalysisResponse EndGetRouteAnalysis(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSites


        /// <summary>
        /// Gets information about one or more of your sites in a global network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSites service method.</param>
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
        GetSitesResponse GetSites(GetSitesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSites operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSites operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSites
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetSites">REST API Reference for GetSites Operation</seealso>
        IAsyncResult BeginGetSites(GetSitesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSites operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSites.</param>
        /// 
        /// <returns>Returns a  GetSitesResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetSites">REST API Reference for GetSites Operation</seealso>
        GetSitesResponse EndGetSites(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSiteToSiteVpnAttachment


        /// <summary>
        /// Returns information about a site-to-site VPN attachment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSiteToSiteVpnAttachment service method.</param>
        /// 
        /// <returns>The response from the GetSiteToSiteVpnAttachment service method, as returned by NetworkManager.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetSiteToSiteVpnAttachment">REST API Reference for GetSiteToSiteVpnAttachment Operation</seealso>
        GetSiteToSiteVpnAttachmentResponse GetSiteToSiteVpnAttachment(GetSiteToSiteVpnAttachmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSiteToSiteVpnAttachment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSiteToSiteVpnAttachment operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSiteToSiteVpnAttachment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetSiteToSiteVpnAttachment">REST API Reference for GetSiteToSiteVpnAttachment Operation</seealso>
        IAsyncResult BeginGetSiteToSiteVpnAttachment(GetSiteToSiteVpnAttachmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSiteToSiteVpnAttachment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSiteToSiteVpnAttachment.</param>
        /// 
        /// <returns>Returns a  GetSiteToSiteVpnAttachmentResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetSiteToSiteVpnAttachment">REST API Reference for GetSiteToSiteVpnAttachment Operation</seealso>
        GetSiteToSiteVpnAttachmentResponse EndGetSiteToSiteVpnAttachment(IAsyncResult asyncResult);

        #endregion
        
        #region  GetTransitGatewayConnectPeerAssociations


        /// <summary>
        /// Gets information about one or more of your transit gateway Connect peer associations
        /// in a global network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTransitGatewayConnectPeerAssociations service method.</param>
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
        GetTransitGatewayConnectPeerAssociationsResponse GetTransitGatewayConnectPeerAssociations(GetTransitGatewayConnectPeerAssociationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetTransitGatewayConnectPeerAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTransitGatewayConnectPeerAssociations operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTransitGatewayConnectPeerAssociations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetTransitGatewayConnectPeerAssociations">REST API Reference for GetTransitGatewayConnectPeerAssociations Operation</seealso>
        IAsyncResult BeginGetTransitGatewayConnectPeerAssociations(GetTransitGatewayConnectPeerAssociationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTransitGatewayConnectPeerAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTransitGatewayConnectPeerAssociations.</param>
        /// 
        /// <returns>Returns a  GetTransitGatewayConnectPeerAssociationsResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetTransitGatewayConnectPeerAssociations">REST API Reference for GetTransitGatewayConnectPeerAssociations Operation</seealso>
        GetTransitGatewayConnectPeerAssociationsResponse EndGetTransitGatewayConnectPeerAssociations(IAsyncResult asyncResult);

        #endregion
        
        #region  GetTransitGatewayPeering


        /// <summary>
        /// Returns information about a transit gateway peer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTransitGatewayPeering service method.</param>
        /// 
        /// <returns>The response from the GetTransitGatewayPeering service method, as returned by NetworkManager.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetTransitGatewayPeering">REST API Reference for GetTransitGatewayPeering Operation</seealso>
        GetTransitGatewayPeeringResponse GetTransitGatewayPeering(GetTransitGatewayPeeringRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetTransitGatewayPeering operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTransitGatewayPeering operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTransitGatewayPeering
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetTransitGatewayPeering">REST API Reference for GetTransitGatewayPeering Operation</seealso>
        IAsyncResult BeginGetTransitGatewayPeering(GetTransitGatewayPeeringRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTransitGatewayPeering operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTransitGatewayPeering.</param>
        /// 
        /// <returns>Returns a  GetTransitGatewayPeeringResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetTransitGatewayPeering">REST API Reference for GetTransitGatewayPeering Operation</seealso>
        GetTransitGatewayPeeringResponse EndGetTransitGatewayPeering(IAsyncResult asyncResult);

        #endregion
        
        #region  GetTransitGatewayRegistrations


        /// <summary>
        /// Gets information about the transit gateway registrations in a specified global network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTransitGatewayRegistrations service method.</param>
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
        GetTransitGatewayRegistrationsResponse GetTransitGatewayRegistrations(GetTransitGatewayRegistrationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetTransitGatewayRegistrations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTransitGatewayRegistrations operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTransitGatewayRegistrations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetTransitGatewayRegistrations">REST API Reference for GetTransitGatewayRegistrations Operation</seealso>
        IAsyncResult BeginGetTransitGatewayRegistrations(GetTransitGatewayRegistrationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTransitGatewayRegistrations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTransitGatewayRegistrations.</param>
        /// 
        /// <returns>Returns a  GetTransitGatewayRegistrationsResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetTransitGatewayRegistrations">REST API Reference for GetTransitGatewayRegistrations Operation</seealso>
        GetTransitGatewayRegistrationsResponse EndGetTransitGatewayRegistrations(IAsyncResult asyncResult);

        #endregion
        
        #region  GetTransitGatewayRouteTableAttachment


        /// <summary>
        /// Returns information about a transit gateway route table attachment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTransitGatewayRouteTableAttachment service method.</param>
        /// 
        /// <returns>The response from the GetTransitGatewayRouteTableAttachment service method, as returned by NetworkManager.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetTransitGatewayRouteTableAttachment">REST API Reference for GetTransitGatewayRouteTableAttachment Operation</seealso>
        GetTransitGatewayRouteTableAttachmentResponse GetTransitGatewayRouteTableAttachment(GetTransitGatewayRouteTableAttachmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetTransitGatewayRouteTableAttachment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTransitGatewayRouteTableAttachment operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTransitGatewayRouteTableAttachment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetTransitGatewayRouteTableAttachment">REST API Reference for GetTransitGatewayRouteTableAttachment Operation</seealso>
        IAsyncResult BeginGetTransitGatewayRouteTableAttachment(GetTransitGatewayRouteTableAttachmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTransitGatewayRouteTableAttachment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTransitGatewayRouteTableAttachment.</param>
        /// 
        /// <returns>Returns a  GetTransitGatewayRouteTableAttachmentResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetTransitGatewayRouteTableAttachment">REST API Reference for GetTransitGatewayRouteTableAttachment Operation</seealso>
        GetTransitGatewayRouteTableAttachmentResponse EndGetTransitGatewayRouteTableAttachment(IAsyncResult asyncResult);

        #endregion
        
        #region  GetVpcAttachment


        /// <summary>
        /// Returns information about a VPC attachment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVpcAttachment service method.</param>
        /// 
        /// <returns>The response from the GetVpcAttachment service method, as returned by NetworkManager.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetVpcAttachment">REST API Reference for GetVpcAttachment Operation</seealso>
        GetVpcAttachmentResponse GetVpcAttachment(GetVpcAttachmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetVpcAttachment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVpcAttachment operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVpcAttachment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetVpcAttachment">REST API Reference for GetVpcAttachment Operation</seealso>
        IAsyncResult BeginGetVpcAttachment(GetVpcAttachmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetVpcAttachment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVpcAttachment.</param>
        /// 
        /// <returns>Returns a  GetVpcAttachmentResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetVpcAttachment">REST API Reference for GetVpcAttachment Operation</seealso>
        GetVpcAttachmentResponse EndGetVpcAttachment(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAttachments


        /// <summary>
        /// Returns a list of core network attachments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAttachments service method.</param>
        /// 
        /// <returns>The response from the ListAttachments service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/ListAttachments">REST API Reference for ListAttachments Operation</seealso>
        ListAttachmentsResponse ListAttachments(ListAttachmentsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAttachments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAttachments operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAttachments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/ListAttachments">REST API Reference for ListAttachments Operation</seealso>
        IAsyncResult BeginListAttachments(ListAttachmentsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAttachments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAttachments.</param>
        /// 
        /// <returns>Returns a  ListAttachmentsResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/ListAttachments">REST API Reference for ListAttachments Operation</seealso>
        ListAttachmentsResponse EndListAttachments(IAsyncResult asyncResult);

        #endregion
        
        #region  ListConnectPeers


        /// <summary>
        /// Returns a list of core network Connect peers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConnectPeers service method.</param>
        /// 
        /// <returns>The response from the ListConnectPeers service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/ListConnectPeers">REST API Reference for ListConnectPeers Operation</seealso>
        ListConnectPeersResponse ListConnectPeers(ListConnectPeersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListConnectPeers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListConnectPeers operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListConnectPeers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/ListConnectPeers">REST API Reference for ListConnectPeers Operation</seealso>
        IAsyncResult BeginListConnectPeers(ListConnectPeersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListConnectPeers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListConnectPeers.</param>
        /// 
        /// <returns>Returns a  ListConnectPeersResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/ListConnectPeers">REST API Reference for ListConnectPeers Operation</seealso>
        ListConnectPeersResponse EndListConnectPeers(IAsyncResult asyncResult);

        #endregion
        
        #region  ListCoreNetworkPolicyVersions


        /// <summary>
        /// Returns a list of core network policy versions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCoreNetworkPolicyVersions service method.</param>
        /// 
        /// <returns>The response from the ListCoreNetworkPolicyVersions service method, as returned by NetworkManager.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/ListCoreNetworkPolicyVersions">REST API Reference for ListCoreNetworkPolicyVersions Operation</seealso>
        ListCoreNetworkPolicyVersionsResponse ListCoreNetworkPolicyVersions(ListCoreNetworkPolicyVersionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListCoreNetworkPolicyVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCoreNetworkPolicyVersions operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCoreNetworkPolicyVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/ListCoreNetworkPolicyVersions">REST API Reference for ListCoreNetworkPolicyVersions Operation</seealso>
        IAsyncResult BeginListCoreNetworkPolicyVersions(ListCoreNetworkPolicyVersionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListCoreNetworkPolicyVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCoreNetworkPolicyVersions.</param>
        /// 
        /// <returns>Returns a  ListCoreNetworkPolicyVersionsResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/ListCoreNetworkPolicyVersions">REST API Reference for ListCoreNetworkPolicyVersions Operation</seealso>
        ListCoreNetworkPolicyVersionsResponse EndListCoreNetworkPolicyVersions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListCoreNetworks


        /// <summary>
        /// Returns a list of owned and shared core networks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCoreNetworks service method.</param>
        /// 
        /// <returns>The response from the ListCoreNetworks service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/ListCoreNetworks">REST API Reference for ListCoreNetworks Operation</seealso>
        ListCoreNetworksResponse ListCoreNetworks(ListCoreNetworksRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListCoreNetworks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCoreNetworks operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCoreNetworks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/ListCoreNetworks">REST API Reference for ListCoreNetworks Operation</seealso>
        IAsyncResult BeginListCoreNetworks(ListCoreNetworksRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListCoreNetworks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCoreNetworks.</param>
        /// 
        /// <returns>Returns a  ListCoreNetworksResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/ListCoreNetworks">REST API Reference for ListCoreNetworks Operation</seealso>
        ListCoreNetworksResponse EndListCoreNetworks(IAsyncResult asyncResult);

        #endregion
        
        #region  ListOrganizationServiceAccessStatus


        /// <summary>
        /// Gets the status of the Service Linked Role (SLR) deployment for the accounts in a
        /// given Amazon Web Services Organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOrganizationServiceAccessStatus service method.</param>
        /// 
        /// <returns>The response from the ListOrganizationServiceAccessStatus service method, as returned by NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/ListOrganizationServiceAccessStatus">REST API Reference for ListOrganizationServiceAccessStatus Operation</seealso>
        ListOrganizationServiceAccessStatusResponse ListOrganizationServiceAccessStatus(ListOrganizationServiceAccessStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListOrganizationServiceAccessStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOrganizationServiceAccessStatus operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListOrganizationServiceAccessStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/ListOrganizationServiceAccessStatus">REST API Reference for ListOrganizationServiceAccessStatus Operation</seealso>
        IAsyncResult BeginListOrganizationServiceAccessStatus(ListOrganizationServiceAccessStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListOrganizationServiceAccessStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListOrganizationServiceAccessStatus.</param>
        /// 
        /// <returns>Returns a  ListOrganizationServiceAccessStatusResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/ListOrganizationServiceAccessStatus">REST API Reference for ListOrganizationServiceAccessStatus Operation</seealso>
        ListOrganizationServiceAccessStatusResponse EndListOrganizationServiceAccessStatus(IAsyncResult asyncResult);

        #endregion
        
        #region  ListPeerings


        /// <summary>
        /// Lists the peerings for a core network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPeerings service method.</param>
        /// 
        /// <returns>The response from the ListPeerings service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/ListPeerings">REST API Reference for ListPeerings Operation</seealso>
        ListPeeringsResponse ListPeerings(ListPeeringsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPeerings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPeerings operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPeerings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/ListPeerings">REST API Reference for ListPeerings Operation</seealso>
        IAsyncResult BeginListPeerings(ListPeeringsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPeerings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPeerings.</param>
        /// 
        /// <returns>Returns a  ListPeeringsResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/ListPeerings">REST API Reference for ListPeerings Operation</seealso>
        ListPeeringsResponse EndListPeerings(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags for a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
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
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  PutCoreNetworkPolicy


        /// <summary>
        /// Creates a new, immutable version of a core network policy. A subsequent change set
        /// is created showing the differences between the LIVE policy and the submitted policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutCoreNetworkPolicy service method.</param>
        /// 
        /// <returns>The response from the PutCoreNetworkPolicy service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.CoreNetworkPolicyException">
        /// Describes a core network policy exception.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/PutCoreNetworkPolicy">REST API Reference for PutCoreNetworkPolicy Operation</seealso>
        PutCoreNetworkPolicyResponse PutCoreNetworkPolicy(PutCoreNetworkPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutCoreNetworkPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutCoreNetworkPolicy operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutCoreNetworkPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/PutCoreNetworkPolicy">REST API Reference for PutCoreNetworkPolicy Operation</seealso>
        IAsyncResult BeginPutCoreNetworkPolicy(PutCoreNetworkPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutCoreNetworkPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutCoreNetworkPolicy.</param>
        /// 
        /// <returns>Returns a  PutCoreNetworkPolicyResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/PutCoreNetworkPolicy">REST API Reference for PutCoreNetworkPolicy Operation</seealso>
        PutCoreNetworkPolicyResponse EndPutCoreNetworkPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  PutResourcePolicy


        /// <summary>
        /// Creates or updates a resource policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the PutResourcePolicy service method, as returned by NetworkManager.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        PutResourcePolicyResponse PutResourcePolicy(PutResourcePolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutResourcePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        IAsyncResult BeginPutResourcePolicy(PutResourcePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutResourcePolicy.</param>
        /// 
        /// <returns>Returns a  PutResourcePolicyResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        PutResourcePolicyResponse EndPutResourcePolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  RegisterTransitGateway


        /// <summary>
        /// Registers a transit gateway in your global network. Not all Regions support transit
        /// gateways for global networks. For a list of the supported Regions, see <a href="https://docs.aws.amazon.com/network-manager/latest/tgwnm/what-are-global-networks.html#nm-available-regions">Region
        /// Availability</a> in the <i>Amazon Web Services Transit Gateways for Global Networks
        /// User Guide</i>. The transit gateway can be in any of the supported Amazon Web Services
        /// Regions, but it must be owned by the same Amazon Web Services account that owns the
        /// global network. You cannot register a transit gateway in more than one global network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterTransitGateway service method.</param>
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
        RegisterTransitGatewayResponse RegisterTransitGateway(RegisterTransitGatewayRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterTransitGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterTransitGateway operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterTransitGateway
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/RegisterTransitGateway">REST API Reference for RegisterTransitGateway Operation</seealso>
        IAsyncResult BeginRegisterTransitGateway(RegisterTransitGatewayRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterTransitGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterTransitGateway.</param>
        /// 
        /// <returns>Returns a  RegisterTransitGatewayResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/RegisterTransitGateway">REST API Reference for RegisterTransitGateway Operation</seealso>
        RegisterTransitGatewayResponse EndRegisterTransitGateway(IAsyncResult asyncResult);

        #endregion
        
        #region  RejectAttachment


        /// <summary>
        /// Rejects a core network attachment request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectAttachment service method.</param>
        /// 
        /// <returns>The response from the RejectAttachment service method, as returned by NetworkManager.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/RejectAttachment">REST API Reference for RejectAttachment Operation</seealso>
        RejectAttachmentResponse RejectAttachment(RejectAttachmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RejectAttachment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RejectAttachment operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRejectAttachment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/RejectAttachment">REST API Reference for RejectAttachment Operation</seealso>
        IAsyncResult BeginRejectAttachment(RejectAttachmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RejectAttachment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRejectAttachment.</param>
        /// 
        /// <returns>Returns a  RejectAttachmentResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/RejectAttachment">REST API Reference for RejectAttachment Operation</seealso>
        RejectAttachmentResponse EndRejectAttachment(IAsyncResult asyncResult);

        #endregion
        
        #region  RestoreCoreNetworkPolicyVersion


        /// <summary>
        /// Restores a previous policy version as a new, immutable version of a core network policy.
        /// A subsequent change set is created showing the differences between the LIVE policy
        /// and restored policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreCoreNetworkPolicyVersion service method.</param>
        /// 
        /// <returns>The response from the RestoreCoreNetworkPolicyVersion service method, as returned by NetworkManager.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/RestoreCoreNetworkPolicyVersion">REST API Reference for RestoreCoreNetworkPolicyVersion Operation</seealso>
        RestoreCoreNetworkPolicyVersionResponse RestoreCoreNetworkPolicyVersion(RestoreCoreNetworkPolicyVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RestoreCoreNetworkPolicyVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreCoreNetworkPolicyVersion operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRestoreCoreNetworkPolicyVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/RestoreCoreNetworkPolicyVersion">REST API Reference for RestoreCoreNetworkPolicyVersion Operation</seealso>
        IAsyncResult BeginRestoreCoreNetworkPolicyVersion(RestoreCoreNetworkPolicyVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RestoreCoreNetworkPolicyVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRestoreCoreNetworkPolicyVersion.</param>
        /// 
        /// <returns>Returns a  RestoreCoreNetworkPolicyVersionResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/RestoreCoreNetworkPolicyVersion">REST API Reference for RestoreCoreNetworkPolicyVersion Operation</seealso>
        RestoreCoreNetworkPolicyVersionResponse EndRestoreCoreNetworkPolicyVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  StartOrganizationServiceAccessUpdate


        /// <summary>
        /// Enables the Network Manager service for an Amazon Web Services Organization. This
        /// can only be called by a management account within the organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartOrganizationServiceAccessUpdate service method.</param>
        /// 
        /// <returns>The response from the StartOrganizationServiceAccessUpdate service method, as returned by NetworkManager.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/StartOrganizationServiceAccessUpdate">REST API Reference for StartOrganizationServiceAccessUpdate Operation</seealso>
        StartOrganizationServiceAccessUpdateResponse StartOrganizationServiceAccessUpdate(StartOrganizationServiceAccessUpdateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartOrganizationServiceAccessUpdate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartOrganizationServiceAccessUpdate operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartOrganizationServiceAccessUpdate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/StartOrganizationServiceAccessUpdate">REST API Reference for StartOrganizationServiceAccessUpdate Operation</seealso>
        IAsyncResult BeginStartOrganizationServiceAccessUpdate(StartOrganizationServiceAccessUpdateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartOrganizationServiceAccessUpdate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartOrganizationServiceAccessUpdate.</param>
        /// 
        /// <returns>Returns a  StartOrganizationServiceAccessUpdateResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/StartOrganizationServiceAccessUpdate">REST API Reference for StartOrganizationServiceAccessUpdate Operation</seealso>
        StartOrganizationServiceAccessUpdateResponse EndStartOrganizationServiceAccessUpdate(IAsyncResult asyncResult);

        #endregion
        
        #region  StartRouteAnalysis


        /// <summary>
        /// Starts analyzing the routing path between the specified source and destination. For
        /// more information, see <a href="https://docs.aws.amazon.com/vpc/latest/tgw/route-analyzer.html">Route
        /// Analyzer</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartRouteAnalysis service method.</param>
        /// 
        /// <returns>The response from the StartRouteAnalysis service method, as returned by NetworkManager.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/StartRouteAnalysis">REST API Reference for StartRouteAnalysis Operation</seealso>
        StartRouteAnalysisResponse StartRouteAnalysis(StartRouteAnalysisRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartRouteAnalysis operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartRouteAnalysis operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartRouteAnalysis
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/StartRouteAnalysis">REST API Reference for StartRouteAnalysis Operation</seealso>
        IAsyncResult BeginStartRouteAnalysis(StartRouteAnalysisRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartRouteAnalysis operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartRouteAnalysis.</param>
        /// 
        /// <returns>Returns a  StartRouteAnalysisResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/StartRouteAnalysis">REST API Reference for StartRouteAnalysis Operation</seealso>
        StartRouteAnalysisResponse EndStartRouteAnalysis(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Tags a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
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
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes tags from a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
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
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateConnection


        /// <summary>
        /// Updates the information for an existing connection. To remove information for any
        /// of the parameters, specify an empty string.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConnection service method.</param>
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
        UpdateConnectionResponse UpdateConnection(UpdateConnectionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateConnection operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/UpdateConnection">REST API Reference for UpdateConnection Operation</seealso>
        IAsyncResult BeginUpdateConnection(UpdateConnectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateConnection.</param>
        /// 
        /// <returns>Returns a  UpdateConnectionResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/UpdateConnection">REST API Reference for UpdateConnection Operation</seealso>
        UpdateConnectionResponse EndUpdateConnection(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateCoreNetwork


        /// <summary>
        /// Updates the description of a core network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCoreNetwork service method.</param>
        /// 
        /// <returns>The response from the UpdateCoreNetwork service method, as returned by NetworkManager.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/UpdateCoreNetwork">REST API Reference for UpdateCoreNetwork Operation</seealso>
        UpdateCoreNetworkResponse UpdateCoreNetwork(UpdateCoreNetworkRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCoreNetwork operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCoreNetwork operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCoreNetwork
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/UpdateCoreNetwork">REST API Reference for UpdateCoreNetwork Operation</seealso>
        IAsyncResult BeginUpdateCoreNetwork(UpdateCoreNetworkRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCoreNetwork operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCoreNetwork.</param>
        /// 
        /// <returns>Returns a  UpdateCoreNetworkResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/UpdateCoreNetwork">REST API Reference for UpdateCoreNetwork Operation</seealso>
        UpdateCoreNetworkResponse EndUpdateCoreNetwork(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDevice


        /// <summary>
        /// Updates the details for an existing device. To remove information for any of the parameters,
        /// specify an empty string.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDevice service method.</param>
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
        UpdateDeviceResponse UpdateDevice(UpdateDeviceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDevice operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDevice
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/UpdateDevice">REST API Reference for UpdateDevice Operation</seealso>
        IAsyncResult BeginUpdateDevice(UpdateDeviceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDevice operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDevice.</param>
        /// 
        /// <returns>Returns a  UpdateDeviceResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/UpdateDevice">REST API Reference for UpdateDevice Operation</seealso>
        UpdateDeviceResponse EndUpdateDevice(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateGlobalNetwork


        /// <summary>
        /// Updates an existing global network. To remove information for any of the parameters,
        /// specify an empty string.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGlobalNetwork service method.</param>
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
        UpdateGlobalNetworkResponse UpdateGlobalNetwork(UpdateGlobalNetworkRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGlobalNetwork operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGlobalNetwork operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateGlobalNetwork
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/UpdateGlobalNetwork">REST API Reference for UpdateGlobalNetwork Operation</seealso>
        IAsyncResult BeginUpdateGlobalNetwork(UpdateGlobalNetworkRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateGlobalNetwork operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateGlobalNetwork.</param>
        /// 
        /// <returns>Returns a  UpdateGlobalNetworkResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/UpdateGlobalNetwork">REST API Reference for UpdateGlobalNetwork Operation</seealso>
        UpdateGlobalNetworkResponse EndUpdateGlobalNetwork(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateLink


        /// <summary>
        /// Updates the details for an existing link. To remove information for any of the parameters,
        /// specify an empty string.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLink service method.</param>
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
        UpdateLinkResponse UpdateLink(UpdateLinkRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLink operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateLink
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/UpdateLink">REST API Reference for UpdateLink Operation</seealso>
        IAsyncResult BeginUpdateLink(UpdateLinkRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateLink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateLink.</param>
        /// 
        /// <returns>Returns a  UpdateLinkResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/UpdateLink">REST API Reference for UpdateLink Operation</seealso>
        UpdateLinkResponse EndUpdateLink(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateNetworkResourceMetadata


        /// <summary>
        /// Updates the resource metadata for the specified global network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNetworkResourceMetadata service method.</param>
        /// 
        /// <returns>The response from the UpdateNetworkResourceMetadata service method, as returned by NetworkManager.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/UpdateNetworkResourceMetadata">REST API Reference for UpdateNetworkResourceMetadata Operation</seealso>
        UpdateNetworkResourceMetadataResponse UpdateNetworkResourceMetadata(UpdateNetworkResourceMetadataRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateNetworkResourceMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateNetworkResourceMetadata operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateNetworkResourceMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/UpdateNetworkResourceMetadata">REST API Reference for UpdateNetworkResourceMetadata Operation</seealso>
        IAsyncResult BeginUpdateNetworkResourceMetadata(UpdateNetworkResourceMetadataRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateNetworkResourceMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateNetworkResourceMetadata.</param>
        /// 
        /// <returns>Returns a  UpdateNetworkResourceMetadataResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/UpdateNetworkResourceMetadata">REST API Reference for UpdateNetworkResourceMetadata Operation</seealso>
        UpdateNetworkResourceMetadataResponse EndUpdateNetworkResourceMetadata(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateSite


        /// <summary>
        /// Updates the information for an existing site. To remove information for any of the
        /// parameters, specify an empty string.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSite service method.</param>
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
        UpdateSiteResponse UpdateSite(UpdateSiteRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSite operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSite operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSite
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/UpdateSite">REST API Reference for UpdateSite Operation</seealso>
        IAsyncResult BeginUpdateSite(UpdateSiteRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSite operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSite.</param>
        /// 
        /// <returns>Returns a  UpdateSiteResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/UpdateSite">REST API Reference for UpdateSite Operation</seealso>
        UpdateSiteResponse EndUpdateSite(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateVpcAttachment


        /// <summary>
        /// Updates a VPC attachment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVpcAttachment service method.</param>
        /// 
        /// <returns>The response from the UpdateVpcAttachment service method, as returned by NetworkManager.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/UpdateVpcAttachment">REST API Reference for UpdateVpcAttachment Operation</seealso>
        UpdateVpcAttachmentResponse UpdateVpcAttachment(UpdateVpcAttachmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateVpcAttachment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateVpcAttachment operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateVpcAttachment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/UpdateVpcAttachment">REST API Reference for UpdateVpcAttachment Operation</seealso>
        IAsyncResult BeginUpdateVpcAttachment(UpdateVpcAttachmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateVpcAttachment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateVpcAttachment.</param>
        /// 
        /// <returns>Returns a  UpdateVpcAttachmentResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/UpdateVpcAttachment">REST API Reference for UpdateVpcAttachment Operation</seealso>
        UpdateVpcAttachmentResponse EndUpdateVpcAttachment(IAsyncResult asyncResult);

        #endregion
        
    }
}