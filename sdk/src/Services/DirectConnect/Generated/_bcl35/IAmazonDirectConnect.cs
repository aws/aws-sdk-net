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
 * Do not modify this file. This file is generated from the directconnect-2012-10-25.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.DirectConnect.Model;

#pragma warning disable CS1570
namespace Amazon.DirectConnect
{
    /// <summary>
    /// <para>Interface for accessing DirectConnect</para>
    ///
    /// Direct Connect links your internal network to an Direct Connect location over a standard
    /// Ethernet fiber-optic cable. One end of the cable is connected to your router, the
    /// other to an Direct Connect router. With this connection in place, you can create virtual
    /// interfaces directly to the Amazon Web Services Cloud (for example, to Amazon EC2 and
    /// Amazon S3) and to Amazon VPC, bypassing Internet service providers in your network
    /// path. A connection provides access to all Amazon Web Services Regions except the China
    /// (Beijing) and (China) Ningxia Regions. Amazon Web Services resources in the China
    /// Regions can only be accessed through locations associated with those Regions.
    /// </summary>
    public partial interface IAmazonDirectConnect : IAmazonService, IDisposable
    {




        
        #region  AcceptDirectConnectGatewayAssociationProposal


        /// <summary>
        /// Accepts a proposal request to attach a virtual private gateway or transit gateway
        /// to a Direct Connect gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptDirectConnectGatewayAssociationProposal service method.</param>
        /// 
        /// <returns>The response from the AcceptDirectConnectGatewayAssociationProposal service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/AcceptDirectConnectGatewayAssociationProposal">REST API Reference for AcceptDirectConnectGatewayAssociationProposal Operation</seealso>
        AcceptDirectConnectGatewayAssociationProposalResponse AcceptDirectConnectGatewayAssociationProposal(AcceptDirectConnectGatewayAssociationProposalRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AcceptDirectConnectGatewayAssociationProposal operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcceptDirectConnectGatewayAssociationProposal operation on AmazonDirectConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAcceptDirectConnectGatewayAssociationProposal
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/AcceptDirectConnectGatewayAssociationProposal">REST API Reference for AcceptDirectConnectGatewayAssociationProposal Operation</seealso>
        IAsyncResult BeginAcceptDirectConnectGatewayAssociationProposal(AcceptDirectConnectGatewayAssociationProposalRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AcceptDirectConnectGatewayAssociationProposal operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAcceptDirectConnectGatewayAssociationProposal.</param>
        /// 
        /// <returns>Returns a  AcceptDirectConnectGatewayAssociationProposalResult from DirectConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/AcceptDirectConnectGatewayAssociationProposal">REST API Reference for AcceptDirectConnectGatewayAssociationProposal Operation</seealso>
        AcceptDirectConnectGatewayAssociationProposalResponse EndAcceptDirectConnectGatewayAssociationProposal(IAsyncResult asyncResult);

        #endregion
        
        #region  AllocateConnectionOnInterconnect


        /// <summary>
        /// <note> 
        /// <para>
        /// Deprecated. Use <a>AllocateHostedConnection</a> instead.
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates a hosted connection on an interconnect.
        /// </para>
        ///  
        /// <para>
        /// Allocates a VLAN number and a specified amount of bandwidth for use by a hosted connection
        /// on the specified interconnect.
        /// </para>
        ///  <note> 
        /// <para>
        /// Intended for use by Direct Connect Partners only.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AllocateConnectionOnInterconnect service method.</param>
        /// 
        /// <returns>The response from the AllocateConnectionOnInterconnect service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/AllocateConnectionOnInterconnect">REST API Reference for AllocateConnectionOnInterconnect Operation</seealso>
        [Obsolete("Deprecated in favor of AllocateHostedConnection.")]
        AllocateConnectionOnInterconnectResponse AllocateConnectionOnInterconnect(AllocateConnectionOnInterconnectRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AllocateConnectionOnInterconnect operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AllocateConnectionOnInterconnect operation on AmazonDirectConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAllocateConnectionOnInterconnect
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/AllocateConnectionOnInterconnect">REST API Reference for AllocateConnectionOnInterconnect Operation</seealso>
        [Obsolete("Deprecated in favor of AllocateHostedConnection.")]
        IAsyncResult BeginAllocateConnectionOnInterconnect(AllocateConnectionOnInterconnectRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AllocateConnectionOnInterconnect operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAllocateConnectionOnInterconnect.</param>
        /// 
        /// <returns>Returns a  AllocateConnectionOnInterconnectResult from DirectConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/AllocateConnectionOnInterconnect">REST API Reference for AllocateConnectionOnInterconnect Operation</seealso>
        [Obsolete("Deprecated in favor of AllocateHostedConnection.")]
        AllocateConnectionOnInterconnectResponse EndAllocateConnectionOnInterconnect(IAsyncResult asyncResult);

        #endregion
        
        #region  AllocateHostedConnection


        /// <summary>
        /// Creates a hosted connection on the specified interconnect or a link aggregation group
        /// (LAG) of interconnects.
        /// 
        ///  
        /// <para>
        /// Allocates a VLAN number and a specified amount of capacity (bandwidth) for use by
        /// a hosted connection on the specified interconnect or LAG of interconnects. Amazon
        /// Web Services polices the hosted connection for the specified capacity and the Direct
        /// Connect Partner must also police the hosted connection for the specified capacity.
        /// </para>
        ///  <note> 
        /// <para>
        /// Intended for use by Direct Connect Partners only.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AllocateHostedConnection service method.</param>
        /// 
        /// <returns>The response from the AllocateHostedConnection service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DuplicateTagKeysException">
        /// A tag key was specified more than once.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.TooManyTagsException">
        /// You have reached the limit on the number of tags that can be assigned.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/AllocateHostedConnection">REST API Reference for AllocateHostedConnection Operation</seealso>
        AllocateHostedConnectionResponse AllocateHostedConnection(AllocateHostedConnectionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AllocateHostedConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AllocateHostedConnection operation on AmazonDirectConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAllocateHostedConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/AllocateHostedConnection">REST API Reference for AllocateHostedConnection Operation</seealso>
        IAsyncResult BeginAllocateHostedConnection(AllocateHostedConnectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AllocateHostedConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAllocateHostedConnection.</param>
        /// 
        /// <returns>Returns a  AllocateHostedConnectionResult from DirectConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/AllocateHostedConnection">REST API Reference for AllocateHostedConnection Operation</seealso>
        AllocateHostedConnectionResponse EndAllocateHostedConnection(IAsyncResult asyncResult);

        #endregion
        
        #region  AllocatePrivateVirtualInterface


        /// <summary>
        /// Provisions a private virtual interface to be owned by the specified Amazon Web Services
        /// account.
        /// 
        ///  
        /// <para>
        /// Virtual interfaces created using this action must be confirmed by the owner using
        /// <a>ConfirmPrivateVirtualInterface</a>. Until then, the virtual interface is in the
        /// <c>Confirming</c> state and is not available to handle traffic.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AllocatePrivateVirtualInterface service method.</param>
        /// 
        /// <returns>The response from the AllocatePrivateVirtualInterface service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DuplicateTagKeysException">
        /// A tag key was specified more than once.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.TooManyTagsException">
        /// You have reached the limit on the number of tags that can be assigned.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/AllocatePrivateVirtualInterface">REST API Reference for AllocatePrivateVirtualInterface Operation</seealso>
        AllocatePrivateVirtualInterfaceResponse AllocatePrivateVirtualInterface(AllocatePrivateVirtualInterfaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AllocatePrivateVirtualInterface operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AllocatePrivateVirtualInterface operation on AmazonDirectConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAllocatePrivateVirtualInterface
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/AllocatePrivateVirtualInterface">REST API Reference for AllocatePrivateVirtualInterface Operation</seealso>
        IAsyncResult BeginAllocatePrivateVirtualInterface(AllocatePrivateVirtualInterfaceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AllocatePrivateVirtualInterface operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAllocatePrivateVirtualInterface.</param>
        /// 
        /// <returns>Returns a  AllocatePrivateVirtualInterfaceResult from DirectConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/AllocatePrivateVirtualInterface">REST API Reference for AllocatePrivateVirtualInterface Operation</seealso>
        AllocatePrivateVirtualInterfaceResponse EndAllocatePrivateVirtualInterface(IAsyncResult asyncResult);

        #endregion
        
        #region  AllocatePublicVirtualInterface


        /// <summary>
        /// Provisions a public virtual interface to be owned by the specified Amazon Web Services
        /// account.
        /// 
        ///  
        /// <para>
        /// The owner of a connection calls this function to provision a public virtual interface
        /// to be owned by the specified Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        /// Virtual interfaces created using this function must be confirmed by the owner using
        /// <a>ConfirmPublicVirtualInterface</a>. Until this step has been completed, the virtual
        /// interface is in the <c>confirming</c> state and is not available to handle traffic.
        /// </para>
        ///  
        /// <para>
        /// When creating an IPv6 public virtual interface, omit the Amazon address and customer
        /// address. IPv6 addresses are automatically assigned from the Amazon pool of IPv6 addresses;
        /// you cannot specify custom IPv6 addresses.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AllocatePublicVirtualInterface service method.</param>
        /// 
        /// <returns>The response from the AllocatePublicVirtualInterface service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DuplicateTagKeysException">
        /// A tag key was specified more than once.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.TooManyTagsException">
        /// You have reached the limit on the number of tags that can be assigned.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/AllocatePublicVirtualInterface">REST API Reference for AllocatePublicVirtualInterface Operation</seealso>
        AllocatePublicVirtualInterfaceResponse AllocatePublicVirtualInterface(AllocatePublicVirtualInterfaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AllocatePublicVirtualInterface operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AllocatePublicVirtualInterface operation on AmazonDirectConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAllocatePublicVirtualInterface
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/AllocatePublicVirtualInterface">REST API Reference for AllocatePublicVirtualInterface Operation</seealso>
        IAsyncResult BeginAllocatePublicVirtualInterface(AllocatePublicVirtualInterfaceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AllocatePublicVirtualInterface operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAllocatePublicVirtualInterface.</param>
        /// 
        /// <returns>Returns a  AllocatePublicVirtualInterfaceResult from DirectConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/AllocatePublicVirtualInterface">REST API Reference for AllocatePublicVirtualInterface Operation</seealso>
        AllocatePublicVirtualInterfaceResponse EndAllocatePublicVirtualInterface(IAsyncResult asyncResult);

        #endregion
        
        #region  AllocateTransitVirtualInterface


        /// <summary>
        /// Provisions a transit virtual interface to be owned by the specified Amazon Web Services
        /// account. Use this type of interface to connect a transit gateway to your Direct Connect
        /// gateway.
        /// 
        ///  
        /// <para>
        /// The owner of a connection provisions a transit virtual interface to be owned by the
        /// specified Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        /// After you create a transit virtual interface, it must be confirmed by the owner using
        /// <a>ConfirmTransitVirtualInterface</a>. Until this step has been completed, the transit
        /// virtual interface is in the <c>requested</c> state and is not available to handle
        /// traffic.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AllocateTransitVirtualInterface service method.</param>
        /// 
        /// <returns>The response from the AllocateTransitVirtualInterface service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DuplicateTagKeysException">
        /// A tag key was specified more than once.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.TooManyTagsException">
        /// You have reached the limit on the number of tags that can be assigned.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/AllocateTransitVirtualInterface">REST API Reference for AllocateTransitVirtualInterface Operation</seealso>
        AllocateTransitVirtualInterfaceResponse AllocateTransitVirtualInterface(AllocateTransitVirtualInterfaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AllocateTransitVirtualInterface operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AllocateTransitVirtualInterface operation on AmazonDirectConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAllocateTransitVirtualInterface
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/AllocateTransitVirtualInterface">REST API Reference for AllocateTransitVirtualInterface Operation</seealso>
        IAsyncResult BeginAllocateTransitVirtualInterface(AllocateTransitVirtualInterfaceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AllocateTransitVirtualInterface operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAllocateTransitVirtualInterface.</param>
        /// 
        /// <returns>Returns a  AllocateTransitVirtualInterfaceResult from DirectConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/AllocateTransitVirtualInterface">REST API Reference for AllocateTransitVirtualInterface Operation</seealso>
        AllocateTransitVirtualInterfaceResponse EndAllocateTransitVirtualInterface(IAsyncResult asyncResult);

        #endregion
        
        #region  AssociateConnectionWithLag


        /// <summary>
        /// Associates an existing connection with a link aggregation group (LAG). The connection
        /// is interrupted and re-established as a member of the LAG (connectivity to Amazon Web
        /// Services is interrupted). The connection must be hosted on the same Direct Connect
        /// endpoint as the LAG, and its bandwidth must match the bandwidth for the LAG. You can
        /// re-associate a connection that's currently associated with a different LAG; however,
        /// if removing the connection would cause the original LAG to fall below its setting
        /// for minimum number of operational connections, the request fails.
        /// 
        ///  
        /// <para>
        /// Any virtual interfaces that are directly associated with the connection are automatically
        /// re-associated with the LAG. If the connection was originally associated with a different
        /// LAG, the virtual interfaces remain associated with the original LAG.
        /// </para>
        ///  
        /// <para>
        /// For interconnects, any hosted connections are automatically re-associated with the
        /// LAG. If the interconnect was originally associated with a different LAG, the hosted
        /// connections remain associated with the original LAG.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateConnectionWithLag service method.</param>
        /// 
        /// <returns>The response from the AssociateConnectionWithLag service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/AssociateConnectionWithLag">REST API Reference for AssociateConnectionWithLag Operation</seealso>
        AssociateConnectionWithLagResponse AssociateConnectionWithLag(AssociateConnectionWithLagRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateConnectionWithLag operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateConnectionWithLag operation on AmazonDirectConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateConnectionWithLag
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/AssociateConnectionWithLag">REST API Reference for AssociateConnectionWithLag Operation</seealso>
        IAsyncResult BeginAssociateConnectionWithLag(AssociateConnectionWithLagRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateConnectionWithLag operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateConnectionWithLag.</param>
        /// 
        /// <returns>Returns a  AssociateConnectionWithLagResult from DirectConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/AssociateConnectionWithLag">REST API Reference for AssociateConnectionWithLag Operation</seealso>
        AssociateConnectionWithLagResponse EndAssociateConnectionWithLag(IAsyncResult asyncResult);

        #endregion
        
        #region  AssociateHostedConnection


        /// <summary>
        /// Associates a hosted connection and its virtual interfaces with a link aggregation
        /// group (LAG) or interconnect. If the target interconnect or LAG has an existing hosted
        /// connection with a conflicting VLAN number or IP address, the operation fails. This
        /// action temporarily interrupts the hosted connection's connectivity to Amazon Web Services
        /// as it is being migrated.
        /// 
        ///  <note> 
        /// <para>
        /// Intended for use by Direct Connect Partners only.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateHostedConnection service method.</param>
        /// 
        /// <returns>The response from the AssociateHostedConnection service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/AssociateHostedConnection">REST API Reference for AssociateHostedConnection Operation</seealso>
        AssociateHostedConnectionResponse AssociateHostedConnection(AssociateHostedConnectionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateHostedConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateHostedConnection operation on AmazonDirectConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateHostedConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/AssociateHostedConnection">REST API Reference for AssociateHostedConnection Operation</seealso>
        IAsyncResult BeginAssociateHostedConnection(AssociateHostedConnectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateHostedConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateHostedConnection.</param>
        /// 
        /// <returns>Returns a  AssociateHostedConnectionResult from DirectConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/AssociateHostedConnection">REST API Reference for AssociateHostedConnection Operation</seealso>
        AssociateHostedConnectionResponse EndAssociateHostedConnection(IAsyncResult asyncResult);

        #endregion
        
        #region  AssociateMacSecKey


        /// <summary>
        /// Associates a MAC Security (MACsec) Connection Key Name (CKN)/ Connectivity Association
        /// Key (CAK) pair with an Direct Connect dedicated connection.
        /// 
        ///  
        /// <para>
        /// You must supply either the <c>secretARN,</c> or the CKN/CAK (<c>ckn</c> and <c>cak</c>)
        /// pair in the request.
        /// </para>
        ///  
        /// <para>
        /// For information about MAC Security (MACsec) key considerations, see <a href="https://docs.aws.amazon.com/directconnect/latest/UserGuide/direct-connect-mac-sec-getting-started.html#mac-sec-key-consideration">MACsec
        /// pre-shared CKN/CAK key considerations </a> in the <i>Direct Connect User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateMacSecKey service method.</param>
        /// 
        /// <returns>The response from the AssociateMacSecKey service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/AssociateMacSecKey">REST API Reference for AssociateMacSecKey Operation</seealso>
        AssociateMacSecKeyResponse AssociateMacSecKey(AssociateMacSecKeyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateMacSecKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateMacSecKey operation on AmazonDirectConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateMacSecKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/AssociateMacSecKey">REST API Reference for AssociateMacSecKey Operation</seealso>
        IAsyncResult BeginAssociateMacSecKey(AssociateMacSecKeyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateMacSecKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateMacSecKey.</param>
        /// 
        /// <returns>Returns a  AssociateMacSecKeyResult from DirectConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/AssociateMacSecKey">REST API Reference for AssociateMacSecKey Operation</seealso>
        AssociateMacSecKeyResponse EndAssociateMacSecKey(IAsyncResult asyncResult);

        #endregion
        
        #region  AssociateVirtualInterface


        /// <summary>
        /// Associates a virtual interface with a specified link aggregation group (LAG) or connection.
        /// Connectivity to Amazon Web Services is temporarily interrupted as the virtual interface
        /// is being migrated. If the target connection or LAG has an associated virtual interface
        /// with a conflicting VLAN number or a conflicting IP address, the operation fails.
        /// 
        ///  
        /// <para>
        /// Virtual interfaces associated with a hosted connection cannot be associated with a
        /// LAG; hosted connections must be migrated along with their virtual interfaces using
        /// <a>AssociateHostedConnection</a>.
        /// </para>
        ///  
        /// <para>
        /// To reassociate a virtual interface to a new connection or LAG, the requester must
        /// own either the virtual interface itself or the connection to which the virtual interface
        /// is currently associated. Additionally, the requester must own the connection or LAG
        /// for the association.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateVirtualInterface service method.</param>
        /// 
        /// <returns>The response from the AssociateVirtualInterface service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/AssociateVirtualInterface">REST API Reference for AssociateVirtualInterface Operation</seealso>
        AssociateVirtualInterfaceResponse AssociateVirtualInterface(AssociateVirtualInterfaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateVirtualInterface operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateVirtualInterface operation on AmazonDirectConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateVirtualInterface
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/AssociateVirtualInterface">REST API Reference for AssociateVirtualInterface Operation</seealso>
        IAsyncResult BeginAssociateVirtualInterface(AssociateVirtualInterfaceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateVirtualInterface operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateVirtualInterface.</param>
        /// 
        /// <returns>Returns a  AssociateVirtualInterfaceResult from DirectConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/AssociateVirtualInterface">REST API Reference for AssociateVirtualInterface Operation</seealso>
        AssociateVirtualInterfaceResponse EndAssociateVirtualInterface(IAsyncResult asyncResult);

        #endregion
        
        #region  ConfirmConnection


        /// <summary>
        /// Confirms the creation of the specified hosted connection on an interconnect.
        /// 
        ///  
        /// <para>
        /// Upon creation, the hosted connection is initially in the <c>Ordering</c> state, and
        /// remains in this state until the owner confirms creation of the hosted connection.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConfirmConnection service method.</param>
        /// 
        /// <returns>The response from the ConfirmConnection service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/ConfirmConnection">REST API Reference for ConfirmConnection Operation</seealso>
        ConfirmConnectionResponse ConfirmConnection(ConfirmConnectionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ConfirmConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConfirmConnection operation on AmazonDirectConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndConfirmConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/ConfirmConnection">REST API Reference for ConfirmConnection Operation</seealso>
        IAsyncResult BeginConfirmConnection(ConfirmConnectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ConfirmConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginConfirmConnection.</param>
        /// 
        /// <returns>Returns a  ConfirmConnectionResult from DirectConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/ConfirmConnection">REST API Reference for ConfirmConnection Operation</seealso>
        ConfirmConnectionResponse EndConfirmConnection(IAsyncResult asyncResult);

        #endregion
        
        #region  ConfirmCustomerAgreement


        /// <summary>
        /// The confirmation of the terms of agreement when creating the connection/link aggregation
        /// group (LAG).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConfirmCustomerAgreement service method.</param>
        /// 
        /// <returns>The response from the ConfirmCustomerAgreement service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/ConfirmCustomerAgreement">REST API Reference for ConfirmCustomerAgreement Operation</seealso>
        ConfirmCustomerAgreementResponse ConfirmCustomerAgreement(ConfirmCustomerAgreementRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ConfirmCustomerAgreement operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConfirmCustomerAgreement operation on AmazonDirectConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndConfirmCustomerAgreement
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/ConfirmCustomerAgreement">REST API Reference for ConfirmCustomerAgreement Operation</seealso>
        IAsyncResult BeginConfirmCustomerAgreement(ConfirmCustomerAgreementRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ConfirmCustomerAgreement operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginConfirmCustomerAgreement.</param>
        /// 
        /// <returns>Returns a  ConfirmCustomerAgreementResult from DirectConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/ConfirmCustomerAgreement">REST API Reference for ConfirmCustomerAgreement Operation</seealso>
        ConfirmCustomerAgreementResponse EndConfirmCustomerAgreement(IAsyncResult asyncResult);

        #endregion
        
        #region  ConfirmPrivateVirtualInterface


        /// <summary>
        /// Accepts ownership of a private virtual interface created by another Amazon Web Services
        /// account.
        /// 
        ///  
        /// <para>
        /// After the virtual interface owner makes this call, the virtual interface is created
        /// and attached to the specified virtual private gateway or Direct Connect gateway, and
        /// is made available to handle traffic.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConfirmPrivateVirtualInterface service method.</param>
        /// 
        /// <returns>The response from the ConfirmPrivateVirtualInterface service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/ConfirmPrivateVirtualInterface">REST API Reference for ConfirmPrivateVirtualInterface Operation</seealso>
        ConfirmPrivateVirtualInterfaceResponse ConfirmPrivateVirtualInterface(ConfirmPrivateVirtualInterfaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ConfirmPrivateVirtualInterface operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConfirmPrivateVirtualInterface operation on AmazonDirectConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndConfirmPrivateVirtualInterface
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/ConfirmPrivateVirtualInterface">REST API Reference for ConfirmPrivateVirtualInterface Operation</seealso>
        IAsyncResult BeginConfirmPrivateVirtualInterface(ConfirmPrivateVirtualInterfaceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ConfirmPrivateVirtualInterface operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginConfirmPrivateVirtualInterface.</param>
        /// 
        /// <returns>Returns a  ConfirmPrivateVirtualInterfaceResult from DirectConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/ConfirmPrivateVirtualInterface">REST API Reference for ConfirmPrivateVirtualInterface Operation</seealso>
        ConfirmPrivateVirtualInterfaceResponse EndConfirmPrivateVirtualInterface(IAsyncResult asyncResult);

        #endregion
        
        #region  ConfirmPublicVirtualInterface


        /// <summary>
        /// Accepts ownership of a public virtual interface created by another Amazon Web Services
        /// account.
        /// 
        ///  
        /// <para>
        /// After the virtual interface owner makes this call, the specified virtual interface
        /// is created and made available to handle traffic.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConfirmPublicVirtualInterface service method.</param>
        /// 
        /// <returns>The response from the ConfirmPublicVirtualInterface service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/ConfirmPublicVirtualInterface">REST API Reference for ConfirmPublicVirtualInterface Operation</seealso>
        ConfirmPublicVirtualInterfaceResponse ConfirmPublicVirtualInterface(ConfirmPublicVirtualInterfaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ConfirmPublicVirtualInterface operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConfirmPublicVirtualInterface operation on AmazonDirectConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndConfirmPublicVirtualInterface
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/ConfirmPublicVirtualInterface">REST API Reference for ConfirmPublicVirtualInterface Operation</seealso>
        IAsyncResult BeginConfirmPublicVirtualInterface(ConfirmPublicVirtualInterfaceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ConfirmPublicVirtualInterface operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginConfirmPublicVirtualInterface.</param>
        /// 
        /// <returns>Returns a  ConfirmPublicVirtualInterfaceResult from DirectConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/ConfirmPublicVirtualInterface">REST API Reference for ConfirmPublicVirtualInterface Operation</seealso>
        ConfirmPublicVirtualInterfaceResponse EndConfirmPublicVirtualInterface(IAsyncResult asyncResult);

        #endregion
        
        #region  ConfirmTransitVirtualInterface


        /// <summary>
        /// Accepts ownership of a transit virtual interface created by another Amazon Web Services
        /// account.
        /// 
        ///  
        /// <para>
        ///  After the owner of the transit virtual interface makes this call, the specified transit
        /// virtual interface is created and made available to handle traffic.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConfirmTransitVirtualInterface service method.</param>
        /// 
        /// <returns>The response from the ConfirmTransitVirtualInterface service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/ConfirmTransitVirtualInterface">REST API Reference for ConfirmTransitVirtualInterface Operation</seealso>
        ConfirmTransitVirtualInterfaceResponse ConfirmTransitVirtualInterface(ConfirmTransitVirtualInterfaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ConfirmTransitVirtualInterface operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConfirmTransitVirtualInterface operation on AmazonDirectConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndConfirmTransitVirtualInterface
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/ConfirmTransitVirtualInterface">REST API Reference for ConfirmTransitVirtualInterface Operation</seealso>
        IAsyncResult BeginConfirmTransitVirtualInterface(ConfirmTransitVirtualInterfaceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ConfirmTransitVirtualInterface operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginConfirmTransitVirtualInterface.</param>
        /// 
        /// <returns>Returns a  ConfirmTransitVirtualInterfaceResult from DirectConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/ConfirmTransitVirtualInterface">REST API Reference for ConfirmTransitVirtualInterface Operation</seealso>
        ConfirmTransitVirtualInterfaceResponse EndConfirmTransitVirtualInterface(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateBGPPeer


        /// <summary>
        /// Creates a BGP peer on the specified virtual interface.
        /// 
        ///  
        /// <para>
        /// You must create a BGP peer for the corresponding address family (IPv4/IPv6) in order
        /// to access Amazon Web Services resources that also use that address family.
        /// </para>
        ///  
        /// <para>
        /// If logical redundancy is not supported by the connection, interconnect, or LAG, the
        /// BGP peer cannot be in the same address family as an existing BGP peer on the virtual
        /// interface.
        /// </para>
        ///  
        /// <para>
        /// When creating a IPv6 BGP peer, omit the Amazon address and customer address. IPv6
        /// addresses are automatically assigned from the Amazon pool of IPv6 addresses; you cannot
        /// specify custom IPv6 addresses.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you let Amazon Web Services auto-assign IPv4 addresses, a /30 CIDR will be allocated
        /// from 169.254.0.0/16. Amazon Web Services does not recommend this option if you intend
        /// to use the customer router peer IP address as the source and destination for traffic.
        /// Instead you should use RFC 1918 or other addressing, and specify the address yourself.
        /// For more information about RFC 1918 see <a href="https://datatracker.ietf.org/doc/html/rfc1918">
        /// Address Allocation for Private Internets</a>.
        /// </para>
        ///  </important> 
        /// <para>
        /// For a public virtual interface, the Autonomous System Number (ASN) must be private
        /// or already on the allow list for the virtual interface.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBGPPeer service method.</param>
        /// 
        /// <returns>The response from the CreateBGPPeer service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/CreateBGPPeer">REST API Reference for CreateBGPPeer Operation</seealso>
        CreateBGPPeerResponse CreateBGPPeer(CreateBGPPeerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateBGPPeer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBGPPeer operation on AmazonDirectConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateBGPPeer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/CreateBGPPeer">REST API Reference for CreateBGPPeer Operation</seealso>
        IAsyncResult BeginCreateBGPPeer(CreateBGPPeerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBGPPeer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBGPPeer.</param>
        /// 
        /// <returns>Returns a  CreateBGPPeerResult from DirectConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/CreateBGPPeer">REST API Reference for CreateBGPPeer Operation</seealso>
        CreateBGPPeerResponse EndCreateBGPPeer(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateConnection


        /// <summary>
        /// Creates a connection between a customer network and a specific Direct Connect location.
        /// 
        ///  
        /// <para>
        /// A connection links your internal network to an Direct Connect location over a standard
        /// Ethernet fiber-optic cable. One end of the cable is connected to your router, the
        /// other to an Direct Connect router.
        /// </para>
        ///  
        /// <para>
        /// To find the locations for your Region, use <a>DescribeLocations</a>.
        /// </para>
        ///  
        /// <para>
        /// You can automatically add the new connection to a link aggregation group (LAG) by
        /// specifying a LAG ID in the request. This ensures that the new connection is allocated
        /// on the same Direct Connect endpoint that hosts the specified LAG. If there are no
        /// available ports on the endpoint, the request fails and no connection is created.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConnection service method.</param>
        /// 
        /// <returns>The response from the CreateConnection service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DuplicateTagKeysException">
        /// A tag key was specified more than once.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.TooManyTagsException">
        /// You have reached the limit on the number of tags that can be assigned.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/CreateConnection">REST API Reference for CreateConnection Operation</seealso>
        CreateConnectionResponse CreateConnection(CreateConnectionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConnection operation on AmazonDirectConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/CreateConnection">REST API Reference for CreateConnection Operation</seealso>
        IAsyncResult BeginCreateConnection(CreateConnectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateConnection.</param>
        /// 
        /// <returns>Returns a  CreateConnectionResult from DirectConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/CreateConnection">REST API Reference for CreateConnection Operation</seealso>
        CreateConnectionResponse EndCreateConnection(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDirectConnectGateway


        /// <summary>
        /// Creates a Direct Connect gateway, which is an intermediate object that enables you
        /// to connect a set of virtual interfaces and virtual private gateways. A Direct Connect
        /// gateway is global and visible in any Amazon Web Services Region after it is created.
        /// The virtual interfaces and virtual private gateways that are connected through a Direct
        /// Connect gateway can be in different Amazon Web Services Regions. This enables you
        /// to connect to a VPC in any Region, regardless of the Region in which the virtual interfaces
        /// are located, and pass traffic between them.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDirectConnectGateway service method.</param>
        /// 
        /// <returns>The response from the CreateDirectConnectGateway service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/CreateDirectConnectGateway">REST API Reference for CreateDirectConnectGateway Operation</seealso>
        CreateDirectConnectGatewayResponse CreateDirectConnectGateway(CreateDirectConnectGatewayRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDirectConnectGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDirectConnectGateway operation on AmazonDirectConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDirectConnectGateway
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/CreateDirectConnectGateway">REST API Reference for CreateDirectConnectGateway Operation</seealso>
        IAsyncResult BeginCreateDirectConnectGateway(CreateDirectConnectGatewayRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDirectConnectGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDirectConnectGateway.</param>
        /// 
        /// <returns>Returns a  CreateDirectConnectGatewayResult from DirectConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/CreateDirectConnectGateway">REST API Reference for CreateDirectConnectGateway Operation</seealso>
        CreateDirectConnectGatewayResponse EndCreateDirectConnectGateway(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDirectConnectGatewayAssociation


        /// <summary>
        /// Creates an association between a Direct Connect gateway and a virtual private gateway.
        /// The virtual private gateway must be attached to a VPC and must not be associated with
        /// another Direct Connect gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDirectConnectGatewayAssociation service method.</param>
        /// 
        /// <returns>The response from the CreateDirectConnectGatewayAssociation service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/CreateDirectConnectGatewayAssociation">REST API Reference for CreateDirectConnectGatewayAssociation Operation</seealso>
        CreateDirectConnectGatewayAssociationResponse CreateDirectConnectGatewayAssociation(CreateDirectConnectGatewayAssociationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDirectConnectGatewayAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDirectConnectGatewayAssociation operation on AmazonDirectConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDirectConnectGatewayAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/CreateDirectConnectGatewayAssociation">REST API Reference for CreateDirectConnectGatewayAssociation Operation</seealso>
        IAsyncResult BeginCreateDirectConnectGatewayAssociation(CreateDirectConnectGatewayAssociationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDirectConnectGatewayAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDirectConnectGatewayAssociation.</param>
        /// 
        /// <returns>Returns a  CreateDirectConnectGatewayAssociationResult from DirectConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/CreateDirectConnectGatewayAssociation">REST API Reference for CreateDirectConnectGatewayAssociation Operation</seealso>
        CreateDirectConnectGatewayAssociationResponse EndCreateDirectConnectGatewayAssociation(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDirectConnectGatewayAssociationProposal


        /// <summary>
        /// Creates a proposal to associate the specified virtual private gateway or transit gateway
        /// with the specified Direct Connect gateway.
        /// 
        ///  
        /// <para>
        /// You can associate a Direct Connect gateway and virtual private gateway or transit
        /// gateway that is owned by any Amazon Web Services account. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDirectConnectGatewayAssociationProposal service method.</param>
        /// 
        /// <returns>The response from the CreateDirectConnectGatewayAssociationProposal service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/CreateDirectConnectGatewayAssociationProposal">REST API Reference for CreateDirectConnectGatewayAssociationProposal Operation</seealso>
        CreateDirectConnectGatewayAssociationProposalResponse CreateDirectConnectGatewayAssociationProposal(CreateDirectConnectGatewayAssociationProposalRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDirectConnectGatewayAssociationProposal operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDirectConnectGatewayAssociationProposal operation on AmazonDirectConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDirectConnectGatewayAssociationProposal
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/CreateDirectConnectGatewayAssociationProposal">REST API Reference for CreateDirectConnectGatewayAssociationProposal Operation</seealso>
        IAsyncResult BeginCreateDirectConnectGatewayAssociationProposal(CreateDirectConnectGatewayAssociationProposalRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDirectConnectGatewayAssociationProposal operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDirectConnectGatewayAssociationProposal.</param>
        /// 
        /// <returns>Returns a  CreateDirectConnectGatewayAssociationProposalResult from DirectConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/CreateDirectConnectGatewayAssociationProposal">REST API Reference for CreateDirectConnectGatewayAssociationProposal Operation</seealso>
        CreateDirectConnectGatewayAssociationProposalResponse EndCreateDirectConnectGatewayAssociationProposal(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateInterconnect


        /// <summary>
        /// Creates an interconnect between an Direct Connect Partner's network and a specific
        /// Direct Connect location.
        /// 
        ///  
        /// <para>
        /// An interconnect is a connection that is capable of hosting other connections. The
        /// Direct Connect Partner can use an interconnect to provide Direct Connect hosted connections
        /// to customers through their own network services. Like a standard connection, an interconnect
        /// links the partner's network to an Direct Connect location over a standard Ethernet
        /// fiber-optic cable. One end is connected to the partner's router, the other to an Direct
        /// Connect router.
        /// </para>
        ///  
        /// <para>
        /// You can automatically add the new interconnect to a link aggregation group (LAG) by
        /// specifying a LAG ID in the request. This ensures that the new interconnect is allocated
        /// on the same Direct Connect endpoint that hosts the specified LAG. If there are no
        /// available ports on the endpoint, the request fails and no interconnect is created.
        /// </para>
        ///  
        /// <para>
        /// For each end customer, the Direct Connect Partner provisions a connection on their
        /// interconnect by calling <a>AllocateHostedConnection</a>. The end customer can then
        /// connect to Amazon Web Services resources by creating a virtual interface on their
        /// connection, using the VLAN assigned to them by the Direct Connect Partner.
        /// </para>
        ///  <note> 
        /// <para>
        /// Intended for use by Direct Connect Partners only.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInterconnect service method.</param>
        /// 
        /// <returns>The response from the CreateInterconnect service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DuplicateTagKeysException">
        /// A tag key was specified more than once.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.TooManyTagsException">
        /// You have reached the limit on the number of tags that can be assigned.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/CreateInterconnect">REST API Reference for CreateInterconnect Operation</seealso>
        CreateInterconnectResponse CreateInterconnect(CreateInterconnectRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateInterconnect operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInterconnect operation on AmazonDirectConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateInterconnect
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/CreateInterconnect">REST API Reference for CreateInterconnect Operation</seealso>
        IAsyncResult BeginCreateInterconnect(CreateInterconnectRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateInterconnect operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateInterconnect.</param>
        /// 
        /// <returns>Returns a  CreateInterconnectResult from DirectConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/CreateInterconnect">REST API Reference for CreateInterconnect Operation</seealso>
        CreateInterconnectResponse EndCreateInterconnect(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateLag


        /// <summary>
        /// Creates a link aggregation group (LAG) with the specified number of bundled physical
        /// dedicated connections between the customer network and a specific Direct Connect location.
        /// A LAG is a logical interface that uses the Link Aggregation Control Protocol (LACP)
        /// to aggregate multiple interfaces, enabling you to treat them as a single interface.
        /// 
        ///  
        /// <para>
        /// All connections in a LAG must use the same bandwidth (either 1Gbps, 10Gbps, 100Gbps,
        /// or 400Gbps) and must terminate at the same Direct Connect endpoint.
        /// </para>
        ///  
        /// <para>
        /// You can have up to 10 dedicated connections per location. Regardless of this limit,
        /// if you request more connections for the LAG than Direct Connect can allocate on a
        /// single endpoint, no LAG is created..
        /// </para>
        ///  
        /// <para>
        /// You can specify an existing physical dedicated connection or interconnect to include
        /// in the LAG (which counts towards the total number of connections). Doing so interrupts
        /// the current physical dedicated connection, and re-establishes them as a member of
        /// the LAG. The LAG will be created on the same Direct Connect endpoint to which the
        /// dedicated connection terminates. Any virtual interfaces associated with the dedicated
        /// connection are automatically disassociated and re-associated with the LAG. The connection
        /// ID does not change.
        /// </para>
        ///  
        /// <para>
        /// If the Amazon Web Services account used to create a LAG is a registered Direct Connect
        /// Partner, the LAG is automatically enabled to host sub-connections. For a LAG owned
        /// by a partner, any associated virtual interfaces cannot be directly configured.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLag service method.</param>
        /// 
        /// <returns>The response from the CreateLag service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DuplicateTagKeysException">
        /// A tag key was specified more than once.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.TooManyTagsException">
        /// You have reached the limit on the number of tags that can be assigned.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/CreateLag">REST API Reference for CreateLag Operation</seealso>
        CreateLagResponse CreateLag(CreateLagRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLag operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLag operation on AmazonDirectConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLag
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/CreateLag">REST API Reference for CreateLag Operation</seealso>
        IAsyncResult BeginCreateLag(CreateLagRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLag operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLag.</param>
        /// 
        /// <returns>Returns a  CreateLagResult from DirectConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/CreateLag">REST API Reference for CreateLag Operation</seealso>
        CreateLagResponse EndCreateLag(IAsyncResult asyncResult);

        #endregion
        
        #region  CreatePrivateVirtualInterface


        /// <summary>
        /// Creates a private virtual interface. A virtual interface is the VLAN that transports
        /// Direct Connect traffic. A private virtual interface can be connected to either a Direct
        /// Connect gateway or a Virtual Private Gateway (VGW). Connecting the private virtual
        /// interface to a Direct Connect gateway enables the possibility for connecting to multiple
        /// VPCs, including VPCs in different Amazon Web Services Regions. Connecting the private
        /// virtual interface to a VGW only provides access to a single VPC within the same Region.
        /// 
        ///  
        /// <para>
        /// Setting the MTU of a virtual interface to 8500 (jumbo frames) can cause an update
        /// to the underlying physical connection if it wasn't updated to support jumbo frames.
        /// Updating the connection disrupts network connectivity for all virtual interfaces associated
        /// with the connection for up to 30 seconds. To check whether your connection supports
        /// jumbo frames, call <a>DescribeConnections</a>. To check whether your virtual interface
        /// supports jumbo frames, call <a>DescribeVirtualInterfaces</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePrivateVirtualInterface service method.</param>
        /// 
        /// <returns>The response from the CreatePrivateVirtualInterface service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DuplicateTagKeysException">
        /// A tag key was specified more than once.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.TooManyTagsException">
        /// You have reached the limit on the number of tags that can be assigned.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/CreatePrivateVirtualInterface">REST API Reference for CreatePrivateVirtualInterface Operation</seealso>
        CreatePrivateVirtualInterfaceResponse CreatePrivateVirtualInterface(CreatePrivateVirtualInterfaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePrivateVirtualInterface operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePrivateVirtualInterface operation on AmazonDirectConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePrivateVirtualInterface
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/CreatePrivateVirtualInterface">REST API Reference for CreatePrivateVirtualInterface Operation</seealso>
        IAsyncResult BeginCreatePrivateVirtualInterface(CreatePrivateVirtualInterfaceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePrivateVirtualInterface operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePrivateVirtualInterface.</param>
        /// 
        /// <returns>Returns a  CreatePrivateVirtualInterfaceResult from DirectConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/CreatePrivateVirtualInterface">REST API Reference for CreatePrivateVirtualInterface Operation</seealso>
        CreatePrivateVirtualInterfaceResponse EndCreatePrivateVirtualInterface(IAsyncResult asyncResult);

        #endregion
        
        #region  CreatePublicVirtualInterface


        /// <summary>
        /// Creates a public virtual interface. A virtual interface is the VLAN that transports
        /// Direct Connect traffic. A public virtual interface supports sending traffic to public
        /// services of Amazon Web Services such as Amazon S3.
        /// 
        ///  
        /// <para>
        /// When creating an IPv6 public virtual interface (<c>addressFamily</c> is <c>ipv6</c>),
        /// leave the <c>customer</c> and <c>amazon</c> address fields blank to use auto-assigned
        /// IPv6 space. Custom IPv6 addresses are not supported.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePublicVirtualInterface service method.</param>
        /// 
        /// <returns>The response from the CreatePublicVirtualInterface service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DuplicateTagKeysException">
        /// A tag key was specified more than once.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.TooManyTagsException">
        /// You have reached the limit on the number of tags that can be assigned.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/CreatePublicVirtualInterface">REST API Reference for CreatePublicVirtualInterface Operation</seealso>
        CreatePublicVirtualInterfaceResponse CreatePublicVirtualInterface(CreatePublicVirtualInterfaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePublicVirtualInterface operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePublicVirtualInterface operation on AmazonDirectConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePublicVirtualInterface
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/CreatePublicVirtualInterface">REST API Reference for CreatePublicVirtualInterface Operation</seealso>
        IAsyncResult BeginCreatePublicVirtualInterface(CreatePublicVirtualInterfaceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePublicVirtualInterface operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePublicVirtualInterface.</param>
        /// 
        /// <returns>Returns a  CreatePublicVirtualInterfaceResult from DirectConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/CreatePublicVirtualInterface">REST API Reference for CreatePublicVirtualInterface Operation</seealso>
        CreatePublicVirtualInterfaceResponse EndCreatePublicVirtualInterface(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateTransitVirtualInterface


        /// <summary>
        /// Creates a transit virtual interface. A transit virtual interface should be used to
        /// access one or more transit gateways associated with Direct Connect gateways. A transit
        /// virtual interface enables the connection of multiple VPCs attached to a transit gateway
        /// to a Direct Connect gateway.
        /// 
        ///  <important> 
        /// <para>
        /// If you associate your transit gateway with one or more Direct Connect gateways, the
        /// Autonomous System Number (ASN) used by the transit gateway and the Direct Connect
        /// gateway must be different. For example, if you use the default ASN 64512 for both
        /// your the transit gateway and Direct Connect gateway, the association request fails.
        /// </para>
        ///  </important> 
        /// <para>
        /// A jumbo MTU value must be either 1500 or 8500. No other values will be accepted. Setting
        /// the MTU of a virtual interface to 8500 (jumbo frames) can cause an update to the underlying
        /// physical connection if it wasn't updated to support jumbo frames. Updating the connection
        /// disrupts network connectivity for all virtual interfaces associated with the connection
        /// for up to 30 seconds. To check whether your connection supports jumbo frames, call
        /// <a>DescribeConnections</a>. To check whether your virtual interface supports jumbo
        /// frames, call <a>DescribeVirtualInterfaces</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTransitVirtualInterface service method.</param>
        /// 
        /// <returns>The response from the CreateTransitVirtualInterface service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DuplicateTagKeysException">
        /// A tag key was specified more than once.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.TooManyTagsException">
        /// You have reached the limit on the number of tags that can be assigned.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/CreateTransitVirtualInterface">REST API Reference for CreateTransitVirtualInterface Operation</seealso>
        CreateTransitVirtualInterfaceResponse CreateTransitVirtualInterface(CreateTransitVirtualInterfaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTransitVirtualInterface operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTransitVirtualInterface operation on AmazonDirectConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTransitVirtualInterface
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/CreateTransitVirtualInterface">REST API Reference for CreateTransitVirtualInterface Operation</seealso>
        IAsyncResult BeginCreateTransitVirtualInterface(CreateTransitVirtualInterfaceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTransitVirtualInterface operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTransitVirtualInterface.</param>
        /// 
        /// <returns>Returns a  CreateTransitVirtualInterfaceResult from DirectConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/CreateTransitVirtualInterface">REST API Reference for CreateTransitVirtualInterface Operation</seealso>
        CreateTransitVirtualInterfaceResponse EndCreateTransitVirtualInterface(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteBGPPeer


        /// <summary>
        /// Deletes the specified BGP peer on the specified virtual interface with the specified
        /// customer address and ASN.
        /// 
        ///  
        /// <para>
        /// You cannot delete the last BGP peer from a virtual interface.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBGPPeer service method.</param>
        /// 
        /// <returns>The response from the DeleteBGPPeer service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DeleteBGPPeer">REST API Reference for DeleteBGPPeer Operation</seealso>
        DeleteBGPPeerResponse DeleteBGPPeer(DeleteBGPPeerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBGPPeer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBGPPeer operation on AmazonDirectConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBGPPeer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DeleteBGPPeer">REST API Reference for DeleteBGPPeer Operation</seealso>
        IAsyncResult BeginDeleteBGPPeer(DeleteBGPPeerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBGPPeer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBGPPeer.</param>
        /// 
        /// <returns>Returns a  DeleteBGPPeerResult from DirectConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DeleteBGPPeer">REST API Reference for DeleteBGPPeer Operation</seealso>
        DeleteBGPPeerResponse EndDeleteBGPPeer(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteConnection


        /// <summary>
        /// Deletes the specified connection.
        /// 
        ///  
        /// <para>
        /// Deleting a connection only stops the Direct Connect port hour and data transfer charges.
        /// If you are partnering with any third parties to connect with the Direct Connect location,
        /// you must cancel your service with them separately.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnection service method.</param>
        /// 
        /// <returns>The response from the DeleteConnection service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DeleteConnection">REST API Reference for DeleteConnection Operation</seealso>
        DeleteConnectionResponse DeleteConnection(DeleteConnectionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnection operation on AmazonDirectConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DeleteConnection">REST API Reference for DeleteConnection Operation</seealso>
        IAsyncResult BeginDeleteConnection(DeleteConnectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConnection.</param>
        /// 
        /// <returns>Returns a  DeleteConnectionResult from DirectConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DeleteConnection">REST API Reference for DeleteConnection Operation</seealso>
        DeleteConnectionResponse EndDeleteConnection(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDirectConnectGateway


        /// <summary>
        /// Deletes the specified Direct Connect gateway. You must first delete all virtual interfaces
        /// that are attached to the Direct Connect gateway and disassociate all virtual private
        /// gateways associated with the Direct Connect gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDirectConnectGateway service method.</param>
        /// 
        /// <returns>The response from the DeleteDirectConnectGateway service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DeleteDirectConnectGateway">REST API Reference for DeleteDirectConnectGateway Operation</seealso>
        DeleteDirectConnectGatewayResponse DeleteDirectConnectGateway(DeleteDirectConnectGatewayRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDirectConnectGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDirectConnectGateway operation on AmazonDirectConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDirectConnectGateway
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DeleteDirectConnectGateway">REST API Reference for DeleteDirectConnectGateway Operation</seealso>
        IAsyncResult BeginDeleteDirectConnectGateway(DeleteDirectConnectGatewayRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDirectConnectGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDirectConnectGateway.</param>
        /// 
        /// <returns>Returns a  DeleteDirectConnectGatewayResult from DirectConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DeleteDirectConnectGateway">REST API Reference for DeleteDirectConnectGateway Operation</seealso>
        DeleteDirectConnectGatewayResponse EndDeleteDirectConnectGateway(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDirectConnectGatewayAssociation


        /// <summary>
        /// Deletes the association between the specified Direct Connect gateway and virtual private
        /// gateway.
        /// 
        ///  
        /// <para>
        /// We recommend that you specify the <c>associationID</c> to delete the association.
        /// Alternatively, if you own virtual gateway and a Direct Connect gateway association,
        /// you can specify the <c>virtualGatewayId</c> and <c>directConnectGatewayId</c> to delete
        /// an association.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDirectConnectGatewayAssociation service method.</param>
        /// 
        /// <returns>The response from the DeleteDirectConnectGatewayAssociation service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DeleteDirectConnectGatewayAssociation">REST API Reference for DeleteDirectConnectGatewayAssociation Operation</seealso>
        DeleteDirectConnectGatewayAssociationResponse DeleteDirectConnectGatewayAssociation(DeleteDirectConnectGatewayAssociationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDirectConnectGatewayAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDirectConnectGatewayAssociation operation on AmazonDirectConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDirectConnectGatewayAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DeleteDirectConnectGatewayAssociation">REST API Reference for DeleteDirectConnectGatewayAssociation Operation</seealso>
        IAsyncResult BeginDeleteDirectConnectGatewayAssociation(DeleteDirectConnectGatewayAssociationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDirectConnectGatewayAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDirectConnectGatewayAssociation.</param>
        /// 
        /// <returns>Returns a  DeleteDirectConnectGatewayAssociationResult from DirectConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DeleteDirectConnectGatewayAssociation">REST API Reference for DeleteDirectConnectGatewayAssociation Operation</seealso>
        DeleteDirectConnectGatewayAssociationResponse EndDeleteDirectConnectGatewayAssociation(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDirectConnectGatewayAssociationProposal


        /// <summary>
        /// Deletes the association proposal request between the specified Direct Connect gateway
        /// and virtual private gateway or transit gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDirectConnectGatewayAssociationProposal service method.</param>
        /// 
        /// <returns>The response from the DeleteDirectConnectGatewayAssociationProposal service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DeleteDirectConnectGatewayAssociationProposal">REST API Reference for DeleteDirectConnectGatewayAssociationProposal Operation</seealso>
        DeleteDirectConnectGatewayAssociationProposalResponse DeleteDirectConnectGatewayAssociationProposal(DeleteDirectConnectGatewayAssociationProposalRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDirectConnectGatewayAssociationProposal operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDirectConnectGatewayAssociationProposal operation on AmazonDirectConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDirectConnectGatewayAssociationProposal
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DeleteDirectConnectGatewayAssociationProposal">REST API Reference for DeleteDirectConnectGatewayAssociationProposal Operation</seealso>
        IAsyncResult BeginDeleteDirectConnectGatewayAssociationProposal(DeleteDirectConnectGatewayAssociationProposalRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDirectConnectGatewayAssociationProposal operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDirectConnectGatewayAssociationProposal.</param>
        /// 
        /// <returns>Returns a  DeleteDirectConnectGatewayAssociationProposalResult from DirectConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DeleteDirectConnectGatewayAssociationProposal">REST API Reference for DeleteDirectConnectGatewayAssociationProposal Operation</seealso>
        DeleteDirectConnectGatewayAssociationProposalResponse EndDeleteDirectConnectGatewayAssociationProposal(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteInterconnect


        /// <summary>
        /// Deletes the specified interconnect.
        /// 
        ///  <note> 
        /// <para>
        /// Intended for use by Direct Connect Partners only.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInterconnect service method.</param>
        /// 
        /// <returns>The response from the DeleteInterconnect service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DeleteInterconnect">REST API Reference for DeleteInterconnect Operation</seealso>
        DeleteInterconnectResponse DeleteInterconnect(DeleteInterconnectRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInterconnect operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInterconnect operation on AmazonDirectConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteInterconnect
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DeleteInterconnect">REST API Reference for DeleteInterconnect Operation</seealso>
        IAsyncResult BeginDeleteInterconnect(DeleteInterconnectRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteInterconnect operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteInterconnect.</param>
        /// 
        /// <returns>Returns a  DeleteInterconnectResult from DirectConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DeleteInterconnect">REST API Reference for DeleteInterconnect Operation</seealso>
        DeleteInterconnectResponse EndDeleteInterconnect(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteLag


        /// <summary>
        /// Deletes the specified link aggregation group (LAG). You cannot delete a LAG if it
        /// has active virtual interfaces or hosted connections.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLag service method.</param>
        /// 
        /// <returns>The response from the DeleteLag service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DeleteLag">REST API Reference for DeleteLag Operation</seealso>
        DeleteLagResponse DeleteLag(DeleteLagRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLag operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLag operation on AmazonDirectConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteLag
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DeleteLag">REST API Reference for DeleteLag Operation</seealso>
        IAsyncResult BeginDeleteLag(DeleteLagRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLag operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLag.</param>
        /// 
        /// <returns>Returns a  DeleteLagResult from DirectConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DeleteLag">REST API Reference for DeleteLag Operation</seealso>
        DeleteLagResponse EndDeleteLag(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteVirtualInterface


        /// <summary>
        /// Deletes a virtual interface.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVirtualInterface service method.</param>
        /// 
        /// <returns>The response from the DeleteVirtualInterface service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DeleteVirtualInterface">REST API Reference for DeleteVirtualInterface Operation</seealso>
        DeleteVirtualInterfaceResponse DeleteVirtualInterface(DeleteVirtualInterfaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVirtualInterface operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVirtualInterface operation on AmazonDirectConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVirtualInterface
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DeleteVirtualInterface">REST API Reference for DeleteVirtualInterface Operation</seealso>
        IAsyncResult BeginDeleteVirtualInterface(DeleteVirtualInterfaceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVirtualInterface operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVirtualInterface.</param>
        /// 
        /// <returns>Returns a  DeleteVirtualInterfaceResult from DirectConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DeleteVirtualInterface">REST API Reference for DeleteVirtualInterface Operation</seealso>
        DeleteVirtualInterfaceResponse EndDeleteVirtualInterface(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeConnectionLoa


        /// <summary>
        /// <note> 
        /// <para>
        /// Deprecated. Use <a>DescribeLoa</a> instead.
        /// </para>
        ///  </note> 
        /// <para>
        /// Gets the LOA-CFA for a connection.
        /// </para>
        ///  
        /// <para>
        /// The Letter of Authorization - Connecting Facility Assignment (LOA-CFA) is a document
        /// that your APN partner or service provider uses when establishing your cross connect
        /// to Amazon Web Services at the colocation facility. For more information, see <a href="https://docs.aws.amazon.com/directconnect/latest/UserGuide/Colocation.html">Requesting
        /// Cross Connects at Direct Connect Locations</a> in the <i>Direct Connect User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnectionLoa service method.</param>
        /// 
        /// <returns>The response from the DescribeConnectionLoa service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeConnectionLoa">REST API Reference for DescribeConnectionLoa Operation</seealso>
        [Obsolete("Deprecated in favor of DescribeLoa.")]
        DescribeConnectionLoaResponse DescribeConnectionLoa(DescribeConnectionLoaRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConnectionLoa operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnectionLoa operation on AmazonDirectConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeConnectionLoa
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeConnectionLoa">REST API Reference for DescribeConnectionLoa Operation</seealso>
        [Obsolete("Deprecated in favor of DescribeLoa.")]
        IAsyncResult BeginDescribeConnectionLoa(DescribeConnectionLoaRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeConnectionLoa operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeConnectionLoa.</param>
        /// 
        /// <returns>Returns a  DescribeConnectionLoaResult from DirectConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeConnectionLoa">REST API Reference for DescribeConnectionLoa Operation</seealso>
        [Obsolete("Deprecated in favor of DescribeLoa.")]
        DescribeConnectionLoaResponse EndDescribeConnectionLoa(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeConnections


        /// <summary>
        /// Displays the specified connection or all connections in this Region.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeConnections service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeConnections">REST API Reference for DescribeConnections Operation</seealso>
        DescribeConnectionsResponse DescribeConnections();

        /// <summary>
        /// Displays the specified connection or all connections in this Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnections service method.</param>
        /// 
        /// <returns>The response from the DescribeConnections service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeConnections">REST API Reference for DescribeConnections Operation</seealso>
        DescribeConnectionsResponse DescribeConnections(DescribeConnectionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConnections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnections operation on AmazonDirectConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeConnections
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeConnections">REST API Reference for DescribeConnections Operation</seealso>
        IAsyncResult BeginDescribeConnections(DescribeConnectionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeConnections operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeConnections.</param>
        /// 
        /// <returns>Returns a  DescribeConnectionsResult from DirectConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeConnections">REST API Reference for DescribeConnections Operation</seealso>
        DescribeConnectionsResponse EndDescribeConnections(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeConnectionsOnInterconnect


        /// <summary>
        /// <note> 
        /// <para>
        /// Deprecated. Use <a>DescribeHostedConnections</a> instead.
        /// </para>
        ///  </note> 
        /// <para>
        /// Lists the connections that have been provisioned on the specified interconnect.
        /// </para>
        ///  <note> 
        /// <para>
        /// Intended for use by Direct Connect Partners only.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnectionsOnInterconnect service method.</param>
        /// 
        /// <returns>The response from the DescribeConnectionsOnInterconnect service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeConnectionsOnInterconnect">REST API Reference for DescribeConnectionsOnInterconnect Operation</seealso>
        [Obsolete("Deprecated in favor of DescribeHostedConnections.")]
        DescribeConnectionsOnInterconnectResponse DescribeConnectionsOnInterconnect(DescribeConnectionsOnInterconnectRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConnectionsOnInterconnect operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnectionsOnInterconnect operation on AmazonDirectConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeConnectionsOnInterconnect
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeConnectionsOnInterconnect">REST API Reference for DescribeConnectionsOnInterconnect Operation</seealso>
        [Obsolete("Deprecated in favor of DescribeHostedConnections.")]
        IAsyncResult BeginDescribeConnectionsOnInterconnect(DescribeConnectionsOnInterconnectRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeConnectionsOnInterconnect operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeConnectionsOnInterconnect.</param>
        /// 
        /// <returns>Returns a  DescribeConnectionsOnInterconnectResult from DirectConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeConnectionsOnInterconnect">REST API Reference for DescribeConnectionsOnInterconnect Operation</seealso>
        [Obsolete("Deprecated in favor of DescribeHostedConnections.")]
        DescribeConnectionsOnInterconnectResponse EndDescribeConnectionsOnInterconnect(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeCustomerMetadata


        /// <summary>
        /// Get and view a list of customer agreements, along with their signed status and whether
        /// the customer is an NNIPartner, NNIPartnerV2, or a nonPartner.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCustomerMetadata service method.</param>
        /// 
        /// <returns>The response from the DescribeCustomerMetadata service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeCustomerMetadata">REST API Reference for DescribeCustomerMetadata Operation</seealso>
        DescribeCustomerMetadataResponse DescribeCustomerMetadata(DescribeCustomerMetadataRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCustomerMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCustomerMetadata operation on AmazonDirectConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCustomerMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeCustomerMetadata">REST API Reference for DescribeCustomerMetadata Operation</seealso>
        IAsyncResult BeginDescribeCustomerMetadata(DescribeCustomerMetadataRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCustomerMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCustomerMetadata.</param>
        /// 
        /// <returns>Returns a  DescribeCustomerMetadataResult from DirectConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeCustomerMetadata">REST API Reference for DescribeCustomerMetadata Operation</seealso>
        DescribeCustomerMetadataResponse EndDescribeCustomerMetadata(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeDirectConnectGatewayAssociationProposals


        /// <summary>
        /// Describes one or more association proposals for connection between a virtual private
        /// gateway or transit gateway and a Direct Connect gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDirectConnectGatewayAssociationProposals service method.</param>
        /// 
        /// <returns>The response from the DescribeDirectConnectGatewayAssociationProposals service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeDirectConnectGatewayAssociationProposals">REST API Reference for DescribeDirectConnectGatewayAssociationProposals Operation</seealso>
        DescribeDirectConnectGatewayAssociationProposalsResponse DescribeDirectConnectGatewayAssociationProposals(DescribeDirectConnectGatewayAssociationProposalsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDirectConnectGatewayAssociationProposals operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDirectConnectGatewayAssociationProposals operation on AmazonDirectConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDirectConnectGatewayAssociationProposals
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeDirectConnectGatewayAssociationProposals">REST API Reference for DescribeDirectConnectGatewayAssociationProposals Operation</seealso>
        IAsyncResult BeginDescribeDirectConnectGatewayAssociationProposals(DescribeDirectConnectGatewayAssociationProposalsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDirectConnectGatewayAssociationProposals operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDirectConnectGatewayAssociationProposals.</param>
        /// 
        /// <returns>Returns a  DescribeDirectConnectGatewayAssociationProposalsResult from DirectConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeDirectConnectGatewayAssociationProposals">REST API Reference for DescribeDirectConnectGatewayAssociationProposals Operation</seealso>
        DescribeDirectConnectGatewayAssociationProposalsResponse EndDescribeDirectConnectGatewayAssociationProposals(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeDirectConnectGatewayAssociations


        /// <summary>
        /// Lists the associations between your Direct Connect gateways and virtual private gateways
        /// and transit gateways. You must specify one of the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// A Direct Connect gateway
        /// </para>
        ///  
        /// <para>
        /// The response contains all virtual private gateways and transit gateways associated
        /// with the Direct Connect gateway.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A virtual private gateway
        /// </para>
        ///  
        /// <para>
        /// The response contains the Direct Connect gateway.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A transit gateway
        /// </para>
        ///  
        /// <para>
        /// The response contains the Direct Connect gateway.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A Direct Connect gateway and a virtual private gateway
        /// </para>
        ///  
        /// <para>
        /// The response contains the association between the Direct Connect gateway and virtual
        /// private gateway.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A Direct Connect gateway and a transit gateway
        /// </para>
        ///  
        /// <para>
        /// The response contains the association between the Direct Connect gateway and transit
        /// gateway.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A Direct Connect gateway and a virtual private gateway
        /// </para>
        ///  
        /// <para>
        /// The response contains the association between the Direct Connect gateway and virtual
        /// private gateway.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A Direct Connect gateway association to a Cloud WAN core network
        /// </para>
        ///  
        /// <para>
        /// The response contains the Cloud WAN core network ID that the Direct Connect gateway
        /// is associated to.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDirectConnectGatewayAssociations service method.</param>
        /// 
        /// <returns>The response from the DescribeDirectConnectGatewayAssociations service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeDirectConnectGatewayAssociations">REST API Reference for DescribeDirectConnectGatewayAssociations Operation</seealso>
        DescribeDirectConnectGatewayAssociationsResponse DescribeDirectConnectGatewayAssociations(DescribeDirectConnectGatewayAssociationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDirectConnectGatewayAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDirectConnectGatewayAssociations operation on AmazonDirectConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDirectConnectGatewayAssociations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeDirectConnectGatewayAssociations">REST API Reference for DescribeDirectConnectGatewayAssociations Operation</seealso>
        IAsyncResult BeginDescribeDirectConnectGatewayAssociations(DescribeDirectConnectGatewayAssociationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDirectConnectGatewayAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDirectConnectGatewayAssociations.</param>
        /// 
        /// <returns>Returns a  DescribeDirectConnectGatewayAssociationsResult from DirectConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeDirectConnectGatewayAssociations">REST API Reference for DescribeDirectConnectGatewayAssociations Operation</seealso>
        DescribeDirectConnectGatewayAssociationsResponse EndDescribeDirectConnectGatewayAssociations(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeDirectConnectGatewayAttachments


        /// <summary>
        /// Lists the attachments between your Direct Connect gateways and virtual interfaces.
        /// You must specify a Direct Connect gateway, a virtual interface, or both. If you specify
        /// a Direct Connect gateway, the response contains all virtual interfaces attached to
        /// the Direct Connect gateway. If you specify a virtual interface, the response contains
        /// all Direct Connect gateways attached to the virtual interface. If you specify both,
        /// the response contains the attachment between the Direct Connect gateway and the virtual
        /// interface.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDirectConnectGatewayAttachments service method.</param>
        /// 
        /// <returns>The response from the DescribeDirectConnectGatewayAttachments service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeDirectConnectGatewayAttachments">REST API Reference for DescribeDirectConnectGatewayAttachments Operation</seealso>
        DescribeDirectConnectGatewayAttachmentsResponse DescribeDirectConnectGatewayAttachments(DescribeDirectConnectGatewayAttachmentsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDirectConnectGatewayAttachments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDirectConnectGatewayAttachments operation on AmazonDirectConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDirectConnectGatewayAttachments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeDirectConnectGatewayAttachments">REST API Reference for DescribeDirectConnectGatewayAttachments Operation</seealso>
        IAsyncResult BeginDescribeDirectConnectGatewayAttachments(DescribeDirectConnectGatewayAttachmentsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDirectConnectGatewayAttachments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDirectConnectGatewayAttachments.</param>
        /// 
        /// <returns>Returns a  DescribeDirectConnectGatewayAttachmentsResult from DirectConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeDirectConnectGatewayAttachments">REST API Reference for DescribeDirectConnectGatewayAttachments Operation</seealso>
        DescribeDirectConnectGatewayAttachmentsResponse EndDescribeDirectConnectGatewayAttachments(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeDirectConnectGateways


        /// <summary>
        /// Lists all your Direct Connect gateways or only the specified Direct Connect gateway.
        /// Deleted Direct Connect gateways are not returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDirectConnectGateways service method.</param>
        /// 
        /// <returns>The response from the DescribeDirectConnectGateways service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeDirectConnectGateways">REST API Reference for DescribeDirectConnectGateways Operation</seealso>
        DescribeDirectConnectGatewaysResponse DescribeDirectConnectGateways(DescribeDirectConnectGatewaysRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDirectConnectGateways operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDirectConnectGateways operation on AmazonDirectConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDirectConnectGateways
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeDirectConnectGateways">REST API Reference for DescribeDirectConnectGateways Operation</seealso>
        IAsyncResult BeginDescribeDirectConnectGateways(DescribeDirectConnectGatewaysRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDirectConnectGateways operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDirectConnectGateways.</param>
        /// 
        /// <returns>Returns a  DescribeDirectConnectGatewaysResult from DirectConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeDirectConnectGateways">REST API Reference for DescribeDirectConnectGateways Operation</seealso>
        DescribeDirectConnectGatewaysResponse EndDescribeDirectConnectGateways(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeHostedConnections


        /// <summary>
        /// Lists the hosted connections that have been provisioned on the specified interconnect
        /// or link aggregation group (LAG).
        /// 
        ///  <note> 
        /// <para>
        /// Intended for use by Direct Connect Partners only.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeHostedConnections service method.</param>
        /// 
        /// <returns>The response from the DescribeHostedConnections service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeHostedConnections">REST API Reference for DescribeHostedConnections Operation</seealso>
        DescribeHostedConnectionsResponse DescribeHostedConnections(DescribeHostedConnectionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeHostedConnections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeHostedConnections operation on AmazonDirectConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeHostedConnections
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeHostedConnections">REST API Reference for DescribeHostedConnections Operation</seealso>
        IAsyncResult BeginDescribeHostedConnections(DescribeHostedConnectionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeHostedConnections operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeHostedConnections.</param>
        /// 
        /// <returns>Returns a  DescribeHostedConnectionsResult from DirectConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeHostedConnections">REST API Reference for DescribeHostedConnections Operation</seealso>
        DescribeHostedConnectionsResponse EndDescribeHostedConnections(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeInterconnectLoa


        /// <summary>
        /// <note> 
        /// <para>
        /// Deprecated. Use <a>DescribeLoa</a> instead.
        /// </para>
        ///  </note> 
        /// <para>
        /// Gets the LOA-CFA for the specified interconnect.
        /// </para>
        ///  
        /// <para>
        /// The Letter of Authorization - Connecting Facility Assignment (LOA-CFA) is a document
        /// that is used when establishing your cross connect to Amazon Web Services at the colocation
        /// facility. For more information, see <a href="https://docs.aws.amazon.com/directconnect/latest/UserGuide/Colocation.html">Requesting
        /// Cross Connects at Direct Connect Locations</a> in the <i>Direct Connect User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInterconnectLoa service method.</param>
        /// 
        /// <returns>The response from the DescribeInterconnectLoa service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeInterconnectLoa">REST API Reference for DescribeInterconnectLoa Operation</seealso>
        [Obsolete("Deprecated in favor of DescribeLoa.")]
        DescribeInterconnectLoaResponse DescribeInterconnectLoa(DescribeInterconnectLoaRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInterconnectLoa operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInterconnectLoa operation on AmazonDirectConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeInterconnectLoa
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeInterconnectLoa">REST API Reference for DescribeInterconnectLoa Operation</seealso>
        [Obsolete("Deprecated in favor of DescribeLoa.")]
        IAsyncResult BeginDescribeInterconnectLoa(DescribeInterconnectLoaRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeInterconnectLoa operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeInterconnectLoa.</param>
        /// 
        /// <returns>Returns a  DescribeInterconnectLoaResult from DirectConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeInterconnectLoa">REST API Reference for DescribeInterconnectLoa Operation</seealso>
        [Obsolete("Deprecated in favor of DescribeLoa.")]
        DescribeInterconnectLoaResponse EndDescribeInterconnectLoa(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeInterconnects


        /// <summary>
        /// Lists the interconnects owned by the Amazon Web Services account or only the specified
        /// interconnect.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeInterconnects service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeInterconnects">REST API Reference for DescribeInterconnects Operation</seealso>
        DescribeInterconnectsResponse DescribeInterconnects();

        /// <summary>
        /// Lists the interconnects owned by the Amazon Web Services account or only the specified
        /// interconnect.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInterconnects service method.</param>
        /// 
        /// <returns>The response from the DescribeInterconnects service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeInterconnects">REST API Reference for DescribeInterconnects Operation</seealso>
        DescribeInterconnectsResponse DescribeInterconnects(DescribeInterconnectsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInterconnects operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInterconnects operation on AmazonDirectConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeInterconnects
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeInterconnects">REST API Reference for DescribeInterconnects Operation</seealso>
        IAsyncResult BeginDescribeInterconnects(DescribeInterconnectsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeInterconnects operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeInterconnects.</param>
        /// 
        /// <returns>Returns a  DescribeInterconnectsResult from DirectConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeInterconnects">REST API Reference for DescribeInterconnects Operation</seealso>
        DescribeInterconnectsResponse EndDescribeInterconnects(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeLags


        /// <summary>
        /// Describes all your link aggregation groups (LAG) or the specified LAG.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLags service method.</param>
        /// 
        /// <returns>The response from the DescribeLags service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeLags">REST API Reference for DescribeLags Operation</seealso>
        DescribeLagsResponse DescribeLags(DescribeLagsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLags operation on AmazonDirectConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeLags">REST API Reference for DescribeLags Operation</seealso>
        IAsyncResult BeginDescribeLags(DescribeLagsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLags.</param>
        /// 
        /// <returns>Returns a  DescribeLagsResult from DirectConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeLags">REST API Reference for DescribeLags Operation</seealso>
        DescribeLagsResponse EndDescribeLags(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeLoa


        /// <summary>
        /// Gets the LOA-CFA for a connection, interconnect, or link aggregation group (LAG).
        /// 
        ///  
        /// <para>
        /// The Letter of Authorization - Connecting Facility Assignment (LOA-CFA) is a document
        /// that is used when establishing your cross connect to Amazon Web Services at the colocation
        /// facility. For more information, see <a href="https://docs.aws.amazon.com/directconnect/latest/UserGuide/Colocation.html">Requesting
        /// Cross Connects at Direct Connect Locations</a> in the <i>Direct Connect User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoa service method.</param>
        /// 
        /// <returns>The response from the DescribeLoa service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeLoa">REST API Reference for DescribeLoa Operation</seealso>
        DescribeLoaResponse DescribeLoa(DescribeLoaRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLoa operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoa operation on AmazonDirectConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLoa
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeLoa">REST API Reference for DescribeLoa Operation</seealso>
        IAsyncResult BeginDescribeLoa(DescribeLoaRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLoa operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLoa.</param>
        /// 
        /// <returns>Returns a  DescribeLoaResult from DirectConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeLoa">REST API Reference for DescribeLoa Operation</seealso>
        DescribeLoaResponse EndDescribeLoa(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeLocations


        /// <summary>
        /// Lists the Direct Connect locations in the current Amazon Web Services Region. These
        /// are the locations that can be selected when calling <a>CreateConnection</a> or <a>CreateInterconnect</a>.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeLocations service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeLocations">REST API Reference for DescribeLocations Operation</seealso>
        DescribeLocationsResponse DescribeLocations();

        /// <summary>
        /// Lists the Direct Connect locations in the current Amazon Web Services Region. These
        /// are the locations that can be selected when calling <a>CreateConnection</a> or <a>CreateInterconnect</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocations service method.</param>
        /// 
        /// <returns>The response from the DescribeLocations service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeLocations">REST API Reference for DescribeLocations Operation</seealso>
        DescribeLocationsResponse DescribeLocations(DescribeLocationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLocations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocations operation on AmazonDirectConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLocations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeLocations">REST API Reference for DescribeLocations Operation</seealso>
        IAsyncResult BeginDescribeLocations(DescribeLocationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLocations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLocations.</param>
        /// 
        /// <returns>Returns a  DescribeLocationsResult from DirectConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeLocations">REST API Reference for DescribeLocations Operation</seealso>
        DescribeLocationsResponse EndDescribeLocations(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeRouterConfiguration


        /// <summary>
        /// Details about the router.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRouterConfiguration service method.</param>
        /// 
        /// <returns>The response from the DescribeRouterConfiguration service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeRouterConfiguration">REST API Reference for DescribeRouterConfiguration Operation</seealso>
        DescribeRouterConfigurationResponse DescribeRouterConfiguration(DescribeRouterConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRouterConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRouterConfiguration operation on AmazonDirectConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeRouterConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeRouterConfiguration">REST API Reference for DescribeRouterConfiguration Operation</seealso>
        IAsyncResult BeginDescribeRouterConfiguration(DescribeRouterConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRouterConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRouterConfiguration.</param>
        /// 
        /// <returns>Returns a  DescribeRouterConfigurationResult from DirectConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeRouterConfiguration">REST API Reference for DescribeRouterConfiguration Operation</seealso>
        DescribeRouterConfigurationResponse EndDescribeRouterConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeTags


        /// <summary>
        /// Describes the tags associated with the specified Direct Connect resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags service method.</param>
        /// 
        /// <returns>The response from the DescribeTags service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeTags">REST API Reference for DescribeTags Operation</seealso>
        DescribeTagsResponse DescribeTags(DescribeTagsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags operation on AmazonDirectConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeTags">REST API Reference for DescribeTags Operation</seealso>
        IAsyncResult BeginDescribeTags(DescribeTagsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTags.</param>
        /// 
        /// <returns>Returns a  DescribeTagsResult from DirectConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeTags">REST API Reference for DescribeTags Operation</seealso>
        DescribeTagsResponse EndDescribeTags(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeVirtualGateways


        /// <summary>
        /// <note> 
        /// <para>
        /// Deprecated. Use <c>DescribeVpnGateways</c> instead. See <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DescribeVpnGateways.html">DescribeVPNGateways</a>
        /// in the <i>Amazon Elastic Compute Cloud API Reference</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Lists the virtual private gateways owned by the Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        /// You can create one or more Direct Connect private virtual interfaces linked to a virtual
        /// private gateway.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeVirtualGateways service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeVirtualGateways">REST API Reference for DescribeVirtualGateways Operation</seealso>
        DescribeVirtualGatewaysResponse DescribeVirtualGateways();

        /// <summary>
        /// <note> 
        /// <para>
        /// Deprecated. Use <c>DescribeVpnGateways</c> instead. See <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DescribeVpnGateways.html">DescribeVPNGateways</a>
        /// in the <i>Amazon Elastic Compute Cloud API Reference</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Lists the virtual private gateways owned by the Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        /// You can create one or more Direct Connect private virtual interfaces linked to a virtual
        /// private gateway.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVirtualGateways service method.</param>
        /// 
        /// <returns>The response from the DescribeVirtualGateways service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeVirtualGateways">REST API Reference for DescribeVirtualGateways Operation</seealso>
        DescribeVirtualGatewaysResponse DescribeVirtualGateways(DescribeVirtualGatewaysRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVirtualGateways operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVirtualGateways operation on AmazonDirectConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeVirtualGateways
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeVirtualGateways">REST API Reference for DescribeVirtualGateways Operation</seealso>
        IAsyncResult BeginDescribeVirtualGateways(DescribeVirtualGatewaysRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeVirtualGateways operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVirtualGateways.</param>
        /// 
        /// <returns>Returns a  DescribeVirtualGatewaysResult from DirectConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeVirtualGateways">REST API Reference for DescribeVirtualGateways Operation</seealso>
        DescribeVirtualGatewaysResponse EndDescribeVirtualGateways(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeVirtualInterfaces


        /// <summary>
        /// Displays all virtual interfaces for an Amazon Web Services account. Virtual interfaces
        /// deleted fewer than 15 minutes before you make the request are also returned. If you
        /// specify a connection ID, only the virtual interfaces associated with the connection
        /// are returned. If you specify a virtual interface ID, then only a single virtual interface
        /// is returned.
        /// 
        ///  
        /// <para>
        /// A virtual interface (VLAN) transmits the traffic between the Direct Connect location
        /// and the customer network.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeVirtualInterfaces service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeVirtualInterfaces">REST API Reference for DescribeVirtualInterfaces Operation</seealso>
        DescribeVirtualInterfacesResponse DescribeVirtualInterfaces();

        /// <summary>
        /// Displays all virtual interfaces for an Amazon Web Services account. Virtual interfaces
        /// deleted fewer than 15 minutes before you make the request are also returned. If you
        /// specify a connection ID, only the virtual interfaces associated with the connection
        /// are returned. If you specify a virtual interface ID, then only a single virtual interface
        /// is returned.
        /// 
        ///  
        /// <para>
        /// A virtual interface (VLAN) transmits the traffic between the Direct Connect location
        /// and the customer network.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVirtualInterfaces service method.</param>
        /// 
        /// <returns>The response from the DescribeVirtualInterfaces service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeVirtualInterfaces">REST API Reference for DescribeVirtualInterfaces Operation</seealso>
        DescribeVirtualInterfacesResponse DescribeVirtualInterfaces(DescribeVirtualInterfacesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVirtualInterfaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVirtualInterfaces operation on AmazonDirectConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeVirtualInterfaces
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeVirtualInterfaces">REST API Reference for DescribeVirtualInterfaces Operation</seealso>
        IAsyncResult BeginDescribeVirtualInterfaces(DescribeVirtualInterfacesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeVirtualInterfaces operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVirtualInterfaces.</param>
        /// 
        /// <returns>Returns a  DescribeVirtualInterfacesResult from DirectConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeVirtualInterfaces">REST API Reference for DescribeVirtualInterfaces Operation</seealso>
        DescribeVirtualInterfacesResponse EndDescribeVirtualInterfaces(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateConnectionFromLag


        /// <summary>
        /// Disassociates a connection from a link aggregation group (LAG). The connection is
        /// interrupted and re-established as a standalone connection (the connection is not deleted;
        /// to delete the connection, use the <a>DeleteConnection</a> request). If the LAG has
        /// associated virtual interfaces or hosted connections, they remain associated with the
        /// LAG. A disassociated connection owned by an Direct Connect Partner is automatically
        /// converted to an interconnect.
        /// 
        ///  
        /// <para>
        /// If disassociating the connection would cause the LAG to fall below its setting for
        /// minimum number of operational connections, the request fails, except when it's the
        /// last member of the LAG. If all connections are disassociated, the LAG continues to
        /// exist as an empty LAG with no physical connections. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateConnectionFromLag service method.</param>
        /// 
        /// <returns>The response from the DisassociateConnectionFromLag service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DisassociateConnectionFromLag">REST API Reference for DisassociateConnectionFromLag Operation</seealso>
        DisassociateConnectionFromLagResponse DisassociateConnectionFromLag(DisassociateConnectionFromLagRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateConnectionFromLag operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateConnectionFromLag operation on AmazonDirectConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateConnectionFromLag
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DisassociateConnectionFromLag">REST API Reference for DisassociateConnectionFromLag Operation</seealso>
        IAsyncResult BeginDisassociateConnectionFromLag(DisassociateConnectionFromLagRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateConnectionFromLag operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateConnectionFromLag.</param>
        /// 
        /// <returns>Returns a  DisassociateConnectionFromLagResult from DirectConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DisassociateConnectionFromLag">REST API Reference for DisassociateConnectionFromLag Operation</seealso>
        DisassociateConnectionFromLagResponse EndDisassociateConnectionFromLag(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateMacSecKey


        /// <summary>
        /// Removes the association between a MAC Security (MACsec) security key and an Direct
        /// Connect dedicated connection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMacSecKey service method.</param>
        /// 
        /// <returns>The response from the DisassociateMacSecKey service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DisassociateMacSecKey">REST API Reference for DisassociateMacSecKey Operation</seealso>
        DisassociateMacSecKeyResponse DisassociateMacSecKey(DisassociateMacSecKeyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateMacSecKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMacSecKey operation on AmazonDirectConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateMacSecKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DisassociateMacSecKey">REST API Reference for DisassociateMacSecKey Operation</seealso>
        IAsyncResult BeginDisassociateMacSecKey(DisassociateMacSecKeyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateMacSecKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateMacSecKey.</param>
        /// 
        /// <returns>Returns a  DisassociateMacSecKeyResult from DirectConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DisassociateMacSecKey">REST API Reference for DisassociateMacSecKey Operation</seealso>
        DisassociateMacSecKeyResponse EndDisassociateMacSecKey(IAsyncResult asyncResult);

        #endregion
        
        #region  ListVirtualInterfaceTestHistory


        /// <summary>
        /// Lists the virtual interface failover test history.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVirtualInterfaceTestHistory service method.</param>
        /// 
        /// <returns>The response from the ListVirtualInterfaceTestHistory service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/ListVirtualInterfaceTestHistory">REST API Reference for ListVirtualInterfaceTestHistory Operation</seealso>
        ListVirtualInterfaceTestHistoryResponse ListVirtualInterfaceTestHistory(ListVirtualInterfaceTestHistoryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListVirtualInterfaceTestHistory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVirtualInterfaceTestHistory operation on AmazonDirectConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListVirtualInterfaceTestHistory
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/ListVirtualInterfaceTestHistory">REST API Reference for ListVirtualInterfaceTestHistory Operation</seealso>
        IAsyncResult BeginListVirtualInterfaceTestHistory(ListVirtualInterfaceTestHistoryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListVirtualInterfaceTestHistory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVirtualInterfaceTestHistory.</param>
        /// 
        /// <returns>Returns a  ListVirtualInterfaceTestHistoryResult from DirectConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/ListVirtualInterfaceTestHistory">REST API Reference for ListVirtualInterfaceTestHistory Operation</seealso>
        ListVirtualInterfaceTestHistoryResponse EndListVirtualInterfaceTestHistory(IAsyncResult asyncResult);

        #endregion
        
        #region  StartBgpFailoverTest


        /// <summary>
        /// Starts the virtual interface failover test that verifies your configuration meets
        /// your resiliency requirements by placing the BGP peering session in the DOWN state.
        /// You can then send traffic to verify that there are no outages.
        /// 
        ///  
        /// <para>
        /// You can run the test on public, private, transit, and hosted virtual interfaces.
        /// </para>
        ///  
        /// <para>
        /// You can use <a href="https://docs.aws.amazon.com/directconnect/latest/APIReference/API_ListVirtualInterfaceTestHistory.html">ListVirtualInterfaceTestHistory</a>
        /// to view the virtual interface test history.
        /// </para>
        ///  
        /// <para>
        /// If you need to stop the test before the test interval completes, use <a href="https://docs.aws.amazon.com/directconnect/latest/APIReference/API_StopBgpFailoverTest.html">StopBgpFailoverTest</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartBgpFailoverTest service method.</param>
        /// 
        /// <returns>The response from the StartBgpFailoverTest service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/StartBgpFailoverTest">REST API Reference for StartBgpFailoverTest Operation</seealso>
        StartBgpFailoverTestResponse StartBgpFailoverTest(StartBgpFailoverTestRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartBgpFailoverTest operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartBgpFailoverTest operation on AmazonDirectConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartBgpFailoverTest
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/StartBgpFailoverTest">REST API Reference for StartBgpFailoverTest Operation</seealso>
        IAsyncResult BeginStartBgpFailoverTest(StartBgpFailoverTestRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartBgpFailoverTest operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartBgpFailoverTest.</param>
        /// 
        /// <returns>Returns a  StartBgpFailoverTestResult from DirectConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/StartBgpFailoverTest">REST API Reference for StartBgpFailoverTest Operation</seealso>
        StartBgpFailoverTestResponse EndStartBgpFailoverTest(IAsyncResult asyncResult);

        #endregion
        
        #region  StopBgpFailoverTest


        /// <summary>
        /// Stops the virtual interface failover test.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopBgpFailoverTest service method.</param>
        /// 
        /// <returns>The response from the StopBgpFailoverTest service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/StopBgpFailoverTest">REST API Reference for StopBgpFailoverTest Operation</seealso>
        StopBgpFailoverTestResponse StopBgpFailoverTest(StopBgpFailoverTestRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopBgpFailoverTest operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopBgpFailoverTest operation on AmazonDirectConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopBgpFailoverTest
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/StopBgpFailoverTest">REST API Reference for StopBgpFailoverTest Operation</seealso>
        IAsyncResult BeginStopBgpFailoverTest(StopBgpFailoverTestRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopBgpFailoverTest operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopBgpFailoverTest.</param>
        /// 
        /// <returns>Returns a  StopBgpFailoverTestResult from DirectConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/StopBgpFailoverTest">REST API Reference for StopBgpFailoverTest Operation</seealso>
        StopBgpFailoverTestResponse EndStopBgpFailoverTest(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds the specified tags to the specified Direct Connect resource. Each resource can
        /// have a maximum of 50 tags.
        /// 
        ///  
        /// <para>
        /// Each tag consists of a key and an optional value. If a tag with the same key is already
        /// associated with the resource, this action updates its value.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DuplicateTagKeysException">
        /// A tag key was specified more than once.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.TooManyTagsException">
        /// You have reached the limit on the number of tags that can be assigned.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonDirectConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from DirectConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes one or more tags from the specified Direct Connect resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonDirectConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from DirectConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateConnection


        /// <summary>
        /// Updates the Direct Connect dedicated connection configuration.
        /// 
        ///  
        /// <para>
        /// You can update the following parameters for a connection:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The connection name
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The connection's MAC Security (MACsec) encryption mode.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConnection service method.</param>
        /// 
        /// <returns>The response from the UpdateConnection service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/UpdateConnection">REST API Reference for UpdateConnection Operation</seealso>
        UpdateConnectionResponse UpdateConnection(UpdateConnectionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateConnection operation on AmazonDirectConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/UpdateConnection">REST API Reference for UpdateConnection Operation</seealso>
        IAsyncResult BeginUpdateConnection(UpdateConnectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateConnection.</param>
        /// 
        /// <returns>Returns a  UpdateConnectionResult from DirectConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/UpdateConnection">REST API Reference for UpdateConnection Operation</seealso>
        UpdateConnectionResponse EndUpdateConnection(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDirectConnectGateway


        /// <summary>
        /// Updates the name of a current Direct Connect gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDirectConnectGateway service method.</param>
        /// 
        /// <returns>The response from the UpdateDirectConnectGateway service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/UpdateDirectConnectGateway">REST API Reference for UpdateDirectConnectGateway Operation</seealso>
        UpdateDirectConnectGatewayResponse UpdateDirectConnectGateway(UpdateDirectConnectGatewayRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDirectConnectGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDirectConnectGateway operation on AmazonDirectConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDirectConnectGateway
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/UpdateDirectConnectGateway">REST API Reference for UpdateDirectConnectGateway Operation</seealso>
        IAsyncResult BeginUpdateDirectConnectGateway(UpdateDirectConnectGatewayRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDirectConnectGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDirectConnectGateway.</param>
        /// 
        /// <returns>Returns a  UpdateDirectConnectGatewayResult from DirectConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/UpdateDirectConnectGateway">REST API Reference for UpdateDirectConnectGateway Operation</seealso>
        UpdateDirectConnectGatewayResponse EndUpdateDirectConnectGateway(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDirectConnectGatewayAssociation


        /// <summary>
        /// Updates the specified attributes of the Direct Connect gateway association.
        /// 
        ///  
        /// <para>
        /// Add or remove prefixes from the association.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDirectConnectGatewayAssociation service method.</param>
        /// 
        /// <returns>The response from the UpdateDirectConnectGatewayAssociation service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/UpdateDirectConnectGatewayAssociation">REST API Reference for UpdateDirectConnectGatewayAssociation Operation</seealso>
        UpdateDirectConnectGatewayAssociationResponse UpdateDirectConnectGatewayAssociation(UpdateDirectConnectGatewayAssociationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDirectConnectGatewayAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDirectConnectGatewayAssociation operation on AmazonDirectConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDirectConnectGatewayAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/UpdateDirectConnectGatewayAssociation">REST API Reference for UpdateDirectConnectGatewayAssociation Operation</seealso>
        IAsyncResult BeginUpdateDirectConnectGatewayAssociation(UpdateDirectConnectGatewayAssociationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDirectConnectGatewayAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDirectConnectGatewayAssociation.</param>
        /// 
        /// <returns>Returns a  UpdateDirectConnectGatewayAssociationResult from DirectConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/UpdateDirectConnectGatewayAssociation">REST API Reference for UpdateDirectConnectGatewayAssociation Operation</seealso>
        UpdateDirectConnectGatewayAssociationResponse EndUpdateDirectConnectGatewayAssociation(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateLag


        /// <summary>
        /// Updates the attributes of the specified link aggregation group (LAG).
        /// 
        ///  
        /// <para>
        /// You can update the following LAG attributes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The name of the LAG.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The value for the minimum number of connections that must be operational for the LAG
        /// itself to be operational. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The LAG's MACsec encryption mode.
        /// </para>
        ///  
        /// <para>
        /// Amazon Web Services assigns this value to each connection which is part of the LAG.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The tags
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// If you adjust the threshold value for the minimum number of operational connections,
        /// ensure that the new value does not cause the LAG to fall below the threshold and become
        /// non-operational.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLag service method.</param>
        /// 
        /// <returns>The response from the UpdateLag service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/UpdateLag">REST API Reference for UpdateLag Operation</seealso>
        UpdateLagResponse UpdateLag(UpdateLagRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLag operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLag operation on AmazonDirectConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateLag
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/UpdateLag">REST API Reference for UpdateLag Operation</seealso>
        IAsyncResult BeginUpdateLag(UpdateLagRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateLag operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateLag.</param>
        /// 
        /// <returns>Returns a  UpdateLagResult from DirectConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/UpdateLag">REST API Reference for UpdateLag Operation</seealso>
        UpdateLagResponse EndUpdateLag(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateVirtualInterfaceAttributes


        /// <summary>
        /// Updates the specified attributes of the specified virtual private interface.
        /// 
        ///  
        /// <para>
        /// Setting the MTU of a virtual interface to 8500 (jumbo frames) can cause an update
        /// to the underlying physical connection if it wasn't updated to support jumbo frames.
        /// Updating the connection disrupts network connectivity for all virtual interfaces associated
        /// with the connection for up to 30 seconds. To check whether your connection supports
        /// jumbo frames, call <a>DescribeConnections</a>. To check whether your virtual interface
        /// supports jumbo frames, call <a>DescribeVirtualInterfaces</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVirtualInterfaceAttributes service method.</param>
        /// 
        /// <returns>The response from the UpdateVirtualInterfaceAttributes service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/UpdateVirtualInterfaceAttributes">REST API Reference for UpdateVirtualInterfaceAttributes Operation</seealso>
        UpdateVirtualInterfaceAttributesResponse UpdateVirtualInterfaceAttributes(UpdateVirtualInterfaceAttributesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateVirtualInterfaceAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateVirtualInterfaceAttributes operation on AmazonDirectConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateVirtualInterfaceAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/UpdateVirtualInterfaceAttributes">REST API Reference for UpdateVirtualInterfaceAttributes Operation</seealso>
        IAsyncResult BeginUpdateVirtualInterfaceAttributes(UpdateVirtualInterfaceAttributesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateVirtualInterfaceAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateVirtualInterfaceAttributes.</param>
        /// 
        /// <returns>Returns a  UpdateVirtualInterfaceAttributesResult from DirectConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/UpdateVirtualInterfaceAttributes">REST API Reference for UpdateVirtualInterfaceAttributes Operation</seealso>
        UpdateVirtualInterfaceAttributesResponse EndUpdateVirtualInterfaceAttributes(IAsyncResult asyncResult);

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