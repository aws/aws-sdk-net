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
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.DirectConnect.Model;

namespace Amazon.DirectConnect
{
    /// <summary>
    /// Interface for accessing DirectConnect
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
        /// Accepts a proposal request to attach a virtual private gateway or transit gateway
        /// to a Direct Connect gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptDirectConnectGatewayAssociationProposal service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AcceptDirectConnectGatewayAssociationProposal service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/AcceptDirectConnectGatewayAssociationProposal">REST API Reference for AcceptDirectConnectGatewayAssociationProposal Operation</seealso>
        Task<AcceptDirectConnectGatewayAssociationProposalResponse> AcceptDirectConnectGatewayAssociationProposalAsync(AcceptDirectConnectGatewayAssociationProposalRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AllocateConnectionOnInterconnect


        /// <summary>
        /// Deprecated. Use <a>AllocateHostedConnection</a> instead.
        /// 
        ///  
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
        /// Deprecated. Use <a>AllocateHostedConnection</a> instead.
        /// 
        ///  
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<AllocateConnectionOnInterconnectResponse> AllocateConnectionOnInterconnectAsync(AllocateConnectionOnInterconnectRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<AllocateHostedConnectionResponse> AllocateHostedConnectionAsync(AllocateHostedConnectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <code>Confirming</code> state and is not available to handle traffic.
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
        /// Provisions a private virtual interface to be owned by the specified Amazon Web Services
        /// account.
        /// 
        ///  
        /// <para>
        /// Virtual interfaces created using this action must be confirmed by the owner using
        /// <a>ConfirmPrivateVirtualInterface</a>. Until then, the virtual interface is in the
        /// <code>Confirming</code> state and is not available to handle traffic.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AllocatePrivateVirtualInterface service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<AllocatePrivateVirtualInterfaceResponse> AllocatePrivateVirtualInterfaceAsync(AllocatePrivateVirtualInterfaceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// interface is in the <code>confirming</code> state and is not available to handle traffic.
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
        /// interface is in the <code>confirming</code> state and is not available to handle traffic.
        /// </para>
        ///  
        /// <para>
        /// When creating an IPv6 public virtual interface, omit the Amazon address and customer
        /// address. IPv6 addresses are automatically assigned from the Amazon pool of IPv6 addresses;
        /// you cannot specify custom IPv6 addresses.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AllocatePublicVirtualInterface service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<AllocatePublicVirtualInterfaceResponse> AllocatePublicVirtualInterfaceAsync(AllocatePublicVirtualInterfaceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// virtual interface is in the <code>requested</code> state and is not available to handle
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
        /// virtual interface is in the <code>requested</code> state and is not available to handle
        /// traffic.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AllocateTransitVirtualInterface service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<AllocateTransitVirtualInterfaceResponse> AllocateTransitVirtualInterfaceAsync(AllocateTransitVirtualInterfaceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateConnectionWithLag service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/AssociateConnectionWithLag">REST API Reference for AssociateConnectionWithLag Operation</seealso>
        Task<AssociateConnectionWithLagResponse> AssociateConnectionWithLagAsync(AssociateConnectionWithLagRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateHostedConnection service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/AssociateHostedConnection">REST API Reference for AssociateHostedConnection Operation</seealso>
        Task<AssociateHostedConnectionResponse> AssociateHostedConnectionAsync(AssociateHostedConnectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AssociateMacSecKey


        /// <summary>
        /// Associates a MAC Security (MACsec) Connection Key Name (CKN)/ Connectivity Association
        /// Key (CAK) pair with an Direct Connect dedicated connection.
        /// 
        ///  
        /// <para>
        /// You must supply either the <code>secretARN,</code> or the CKN/CAK (<code>ckn</code>
        /// and <code>cak</code>) pair in the request.
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
        /// Associates a MAC Security (MACsec) Connection Key Name (CKN)/ Connectivity Association
        /// Key (CAK) pair with an Direct Connect dedicated connection.
        /// 
        ///  
        /// <para>
        /// You must supply either the <code>secretARN,</code> or the CKN/CAK (<code>ckn</code>
        /// and <code>cak</code>) pair in the request.
        /// </para>
        ///  
        /// <para>
        /// For information about MAC Security (MACsec) key considerations, see <a href="https://docs.aws.amazon.com/directconnect/latest/UserGuide/direct-connect-mac-sec-getting-started.html#mac-sec-key-consideration">MACsec
        /// pre-shared CKN/CAK key considerations </a> in the <i>Direct Connect User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateMacSecKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateMacSecKey service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/AssociateMacSecKey">REST API Reference for AssociateMacSecKey Operation</seealso>
        Task<AssociateMacSecKeyResponse> AssociateMacSecKeyAsync(AssociateMacSecKeyRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateVirtualInterface service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/AssociateVirtualInterface">REST API Reference for AssociateVirtualInterface Operation</seealso>
        Task<AssociateVirtualInterfaceResponse> AssociateVirtualInterfaceAsync(AssociateVirtualInterfaceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ConfirmConnection


        /// <summary>
        /// Confirms the creation of the specified hosted connection on an interconnect.
        /// 
        ///  
        /// <para>
        /// Upon creation, the hosted connection is initially in the <code>Ordering</code> state,
        /// and remains in this state until the owner confirms creation of the hosted connection.
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
        /// Confirms the creation of the specified hosted connection on an interconnect.
        /// 
        ///  
        /// <para>
        /// Upon creation, the hosted connection is initially in the <code>Ordering</code> state,
        /// and remains in this state until the owner confirms creation of the hosted connection.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConfirmConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ConfirmConnection service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/ConfirmConnection">REST API Reference for ConfirmConnection Operation</seealso>
        Task<ConfirmConnectionResponse> ConfirmConnectionAsync(ConfirmConnectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// The confirmation of the terms of agreement when creating the connection/link aggregation
        /// group (LAG).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConfirmCustomerAgreement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ConfirmCustomerAgreement service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/ConfirmCustomerAgreement">REST API Reference for ConfirmCustomerAgreement Operation</seealso>
        Task<ConfirmCustomerAgreementResponse> ConfirmCustomerAgreementAsync(ConfirmCustomerAgreementRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ConfirmPrivateVirtualInterface service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/ConfirmPrivateVirtualInterface">REST API Reference for ConfirmPrivateVirtualInterface Operation</seealso>
        Task<ConfirmPrivateVirtualInterfaceResponse> ConfirmPrivateVirtualInterfaceAsync(ConfirmPrivateVirtualInterfaceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ConfirmPublicVirtualInterface service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/ConfirmPublicVirtualInterface">REST API Reference for ConfirmPublicVirtualInterface Operation</seealso>
        Task<ConfirmPublicVirtualInterfaceResponse> ConfirmPublicVirtualInterfaceAsync(ConfirmPublicVirtualInterfaceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ConfirmTransitVirtualInterface service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/ConfirmTransitVirtualInterface">REST API Reference for ConfirmTransitVirtualInterface Operation</seealso>
        Task<ConfirmTransitVirtualInterfaceResponse> ConfirmTransitVirtualInterfaceAsync(ConfirmTransitVirtualInterfaceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateBGPPeer service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/CreateBGPPeer">REST API Reference for CreateBGPPeer Operation</seealso>
        Task<CreateBGPPeerResponse> CreateBGPPeerAsync(CreateBGPPeerRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateConnectionResponse> CreateConnectionAsync(CreateConnectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Creates a Direct Connect gateway, which is an intermediate object that enables you
        /// to connect a set of virtual interfaces and virtual private gateways. A Direct Connect
        /// gateway is global and visible in any Amazon Web Services Region after it is created.
        /// The virtual interfaces and virtual private gateways that are connected through a Direct
        /// Connect gateway can be in different Amazon Web Services Regions. This enables you
        /// to connect to a VPC in any Region, regardless of the Region in which the virtual interfaces
        /// are located, and pass traffic between them.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDirectConnectGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDirectConnectGateway service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/CreateDirectConnectGateway">REST API Reference for CreateDirectConnectGateway Operation</seealso>
        Task<CreateDirectConnectGatewayResponse> CreateDirectConnectGatewayAsync(CreateDirectConnectGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Creates an association between a Direct Connect gateway and a virtual private gateway.
        /// The virtual private gateway must be attached to a VPC and must not be associated with
        /// another Direct Connect gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDirectConnectGatewayAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDirectConnectGatewayAssociation service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/CreateDirectConnectGatewayAssociation">REST API Reference for CreateDirectConnectGatewayAssociation Operation</seealso>
        Task<CreateDirectConnectGatewayAssociationResponse> CreateDirectConnectGatewayAssociationAsync(CreateDirectConnectGatewayAssociationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDirectConnectGatewayAssociationProposal service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/CreateDirectConnectGatewayAssociationProposal">REST API Reference for CreateDirectConnectGatewayAssociationProposal Operation</seealso>
        Task<CreateDirectConnectGatewayAssociationProposalResponse> CreateDirectConnectGatewayAssociationProposalAsync(CreateDirectConnectGatewayAssociationProposalRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateInterconnectResponse> CreateInterconnectAsync(CreateInterconnectRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// All connections in a LAG must use the same bandwidth (either 1Gbps or 10Gbps) and
        /// must terminate at the same Direct Connect endpoint.
        /// </para>
        ///  
        /// <para>
        /// You can have up to 10 dedicated connections per LAG. Regardless of this limit, if
        /// you request more connections for the LAG than Direct Connect can allocate on a single
        /// endpoint, no LAG is created.
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
        /// Creates a link aggregation group (LAG) with the specified number of bundled physical
        /// dedicated connections between the customer network and a specific Direct Connect location.
        /// A LAG is a logical interface that uses the Link Aggregation Control Protocol (LACP)
        /// to aggregate multiple interfaces, enabling you to treat them as a single interface.
        /// 
        ///  
        /// <para>
        /// All connections in a LAG must use the same bandwidth (either 1Gbps or 10Gbps) and
        /// must terminate at the same Direct Connect endpoint.
        /// </para>
        ///  
        /// <para>
        /// You can have up to 10 dedicated connections per LAG. Regardless of this limit, if
        /// you request more connections for the LAG than Direct Connect can allocate on a single
        /// endpoint, no LAG is created.
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateLagResponse> CreateLagAsync(CreateLagRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Setting the MTU of a virtual interface to 9001 (jumbo frames) can cause an update
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
        /// Creates a private virtual interface. A virtual interface is the VLAN that transports
        /// Direct Connect traffic. A private virtual interface can be connected to either a Direct
        /// Connect gateway or a Virtual Private Gateway (VGW). Connecting the private virtual
        /// interface to a Direct Connect gateway enables the possibility for connecting to multiple
        /// VPCs, including VPCs in different Amazon Web Services Regions. Connecting the private
        /// virtual interface to a VGW only provides access to a single VPC within the same Region.
        /// 
        ///  
        /// <para>
        /// Setting the MTU of a virtual interface to 9001 (jumbo frames) can cause an update
        /// to the underlying physical connection if it wasn't updated to support jumbo frames.
        /// Updating the connection disrupts network connectivity for all virtual interfaces associated
        /// with the connection for up to 30 seconds. To check whether your connection supports
        /// jumbo frames, call <a>DescribeConnections</a>. To check whether your virtual interface
        /// supports jumbo frames, call <a>DescribeVirtualInterfaces</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePrivateVirtualInterface service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreatePrivateVirtualInterfaceResponse> CreatePrivateVirtualInterfaceAsync(CreatePrivateVirtualInterfaceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreatePublicVirtualInterface


        /// <summary>
        /// Creates a public virtual interface. A virtual interface is the VLAN that transports
        /// Direct Connect traffic. A public virtual interface supports sending traffic to public
        /// services of Amazon Web Services such as Amazon S3.
        /// 
        ///  
        /// <para>
        /// When creating an IPv6 public virtual interface (<code>addressFamily</code> is <code>ipv6</code>),
        /// leave the <code>customer</code> and <code>amazon</code> address fields blank to use
        /// auto-assigned IPv6 space. Custom IPv6 addresses are not supported.
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
        /// Creates a public virtual interface. A virtual interface is the VLAN that transports
        /// Direct Connect traffic. A public virtual interface supports sending traffic to public
        /// services of Amazon Web Services such as Amazon S3.
        /// 
        ///  
        /// <para>
        /// When creating an IPv6 public virtual interface (<code>addressFamily</code> is <code>ipv6</code>),
        /// leave the <code>customer</code> and <code>amazon</code> address fields blank to use
        /// auto-assigned IPv6 space. Custom IPv6 addresses are not supported.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePublicVirtualInterface service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreatePublicVirtualInterfaceResponse> CreatePublicVirtualInterfaceAsync(CreatePublicVirtualInterfaceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateTransitVirtualInterfaceResponse> CreateTransitVirtualInterfaceAsync(CreateTransitVirtualInterfaceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Deletes the specified BGP peer on the specified virtual interface with the specified
        /// customer address and ASN.
        /// 
        ///  
        /// <para>
        /// You cannot delete the last BGP peer from a virtual interface.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBGPPeer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBGPPeer service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DeleteBGPPeer">REST API Reference for DeleteBGPPeer Operation</seealso>
        Task<DeleteBGPPeerResponse> DeleteBGPPeerAsync(DeleteBGPPeerRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteConnection service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DeleteConnection">REST API Reference for DeleteConnection Operation</seealso>
        Task<DeleteConnectionResponse> DeleteConnectionAsync(DeleteConnectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Deletes the specified Direct Connect gateway. You must first delete all virtual interfaces
        /// that are attached to the Direct Connect gateway and disassociate all virtual private
        /// gateways associated with the Direct Connect gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDirectConnectGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDirectConnectGateway service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DeleteDirectConnectGateway">REST API Reference for DeleteDirectConnectGateway Operation</seealso>
        Task<DeleteDirectConnectGatewayResponse> DeleteDirectConnectGatewayAsync(DeleteDirectConnectGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteDirectConnectGatewayAssociation


        /// <summary>
        /// Deletes the association between the specified Direct Connect gateway and virtual private
        /// gateway.
        /// 
        ///  
        /// <para>
        /// We recommend that you specify the <code>associationID</code> to delete the association.
        /// Alternatively, if you own virtual gateway and a Direct Connect gateway association,
        /// you can specify the <code>virtualGatewayId</code> and <code>directConnectGatewayId</code>
        /// to delete an association.
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
        /// Deletes the association between the specified Direct Connect gateway and virtual private
        /// gateway.
        /// 
        ///  
        /// <para>
        /// We recommend that you specify the <code>associationID</code> to delete the association.
        /// Alternatively, if you own virtual gateway and a Direct Connect gateway association,
        /// you can specify the <code>virtualGatewayId</code> and <code>directConnectGatewayId</code>
        /// to delete an association.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDirectConnectGatewayAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDirectConnectGatewayAssociation service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DeleteDirectConnectGatewayAssociation">REST API Reference for DeleteDirectConnectGatewayAssociation Operation</seealso>
        Task<DeleteDirectConnectGatewayAssociationResponse> DeleteDirectConnectGatewayAssociationAsync(DeleteDirectConnectGatewayAssociationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Deletes the association proposal request between the specified Direct Connect gateway
        /// and virtual private gateway or transit gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDirectConnectGatewayAssociationProposal service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDirectConnectGatewayAssociationProposal service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DeleteDirectConnectGatewayAssociationProposal">REST API Reference for DeleteDirectConnectGatewayAssociationProposal Operation</seealso>
        Task<DeleteDirectConnectGatewayAssociationProposalResponse> DeleteDirectConnectGatewayAssociationProposalAsync(DeleteDirectConnectGatewayAssociationProposalRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Deletes the specified interconnect.
        /// 
        ///  <note> 
        /// <para>
        /// Intended for use by Direct Connect Partners only.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInterconnect service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteInterconnect service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DeleteInterconnect">REST API Reference for DeleteInterconnect Operation</seealso>
        Task<DeleteInterconnectResponse> DeleteInterconnectAsync(DeleteInterconnectRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Deletes the specified link aggregation group (LAG). You cannot delete a LAG if it
        /// has active virtual interfaces or hosted connections.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLag service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLag service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DeleteLag">REST API Reference for DeleteLag Operation</seealso>
        Task<DeleteLagResponse> DeleteLagAsync(DeleteLagRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Deletes a virtual interface.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVirtualInterface service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVirtualInterface service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DeleteVirtualInterface">REST API Reference for DeleteVirtualInterface Operation</seealso>
        Task<DeleteVirtualInterfaceResponse> DeleteVirtualInterfaceAsync(DeleteVirtualInterfaceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeConnectionLoa


        /// <summary>
        /// Deprecated. Use <a>DescribeLoa</a> instead.
        /// 
        ///  
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
        /// Deprecated. Use <a>DescribeLoa</a> instead.
        /// 
        ///  
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeConnectionLoaResponse> DescribeConnectionLoaAsync(DescribeConnectionLoaRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Displays the specified connection or all connections in this Region.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeConnections service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeConnections">REST API Reference for DescribeConnections Operation</seealso>
        Task<DescribeConnectionsResponse> DescribeConnectionsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Displays the specified connection or all connections in this Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnections service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeConnections service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeConnections">REST API Reference for DescribeConnections Operation</seealso>
        Task<DescribeConnectionsResponse> DescribeConnectionsAsync(DescribeConnectionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeConnectionsOnInterconnect


        /// <summary>
        /// Deprecated. Use <a>DescribeHostedConnections</a> instead.
        /// 
        ///  
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
        /// Deprecated. Use <a>DescribeHostedConnections</a> instead.
        /// 
        ///  
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeConnectionsOnInterconnectResponse> DescribeConnectionsOnInterconnectAsync(DescribeConnectionsOnInterconnectRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Get and view a list of customer agreements, along with their signed status and whether
        /// the customer is an NNIPartner, NNIPartnerV2, or a nonPartner.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCustomerMetadata service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCustomerMetadata service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeCustomerMetadata">REST API Reference for DescribeCustomerMetadata Operation</seealso>
        Task<DescribeCustomerMetadataResponse> DescribeCustomerMetadataAsync(DescribeCustomerMetadataRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Describes one or more association proposals for connection between a virtual private
        /// gateway or transit gateway and a Direct Connect gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDirectConnectGatewayAssociationProposals service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDirectConnectGatewayAssociationProposals service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeDirectConnectGatewayAssociationProposals">REST API Reference for DescribeDirectConnectGatewayAssociationProposals Operation</seealso>
        Task<DescribeDirectConnectGatewayAssociationProposalsResponse> DescribeDirectConnectGatewayAssociationProposalsAsync(DescribeDirectConnectGatewayAssociationProposalsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDirectConnectGatewayAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDirectConnectGatewayAssociations service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeDirectConnectGatewayAssociations">REST API Reference for DescribeDirectConnectGatewayAssociations Operation</seealso>
        Task<DescribeDirectConnectGatewayAssociationsResponse> DescribeDirectConnectGatewayAssociationsAsync(DescribeDirectConnectGatewayAssociationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists the attachments between your Direct Connect gateways and virtual interfaces.
        /// You must specify a Direct Connect gateway, a virtual interface, or both. If you specify
        /// a Direct Connect gateway, the response contains all virtual interfaces attached to
        /// the Direct Connect gateway. If you specify a virtual interface, the response contains
        /// all Direct Connect gateways attached to the virtual interface. If you specify both,
        /// the response contains the attachment between the Direct Connect gateway and the virtual
        /// interface.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDirectConnectGatewayAttachments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDirectConnectGatewayAttachments service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeDirectConnectGatewayAttachments">REST API Reference for DescribeDirectConnectGatewayAttachments Operation</seealso>
        Task<DescribeDirectConnectGatewayAttachmentsResponse> DescribeDirectConnectGatewayAttachmentsAsync(DescribeDirectConnectGatewayAttachmentsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists all your Direct Connect gateways or only the specified Direct Connect gateway.
        /// Deleted Direct Connect gateways are not returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDirectConnectGateways service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDirectConnectGateways service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeDirectConnectGateways">REST API Reference for DescribeDirectConnectGateways Operation</seealso>
        Task<DescribeDirectConnectGatewaysResponse> DescribeDirectConnectGatewaysAsync(DescribeDirectConnectGatewaysRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeHostedConnections service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeHostedConnections">REST API Reference for DescribeHostedConnections Operation</seealso>
        Task<DescribeHostedConnectionsResponse> DescribeHostedConnectionsAsync(DescribeHostedConnectionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeInterconnectLoa


        /// <summary>
        /// Deprecated. Use <a>DescribeLoa</a> instead.
        /// 
        ///  
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
        /// Deprecated. Use <a>DescribeLoa</a> instead.
        /// 
        ///  
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeInterconnectLoaResponse> DescribeInterconnectLoaAsync(DescribeInterconnectLoaRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists the interconnects owned by the Amazon Web Services account or only the specified
        /// interconnect.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeInterconnects service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeInterconnects">REST API Reference for DescribeInterconnects Operation</seealso>
        Task<DescribeInterconnectsResponse> DescribeInterconnectsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Lists the interconnects owned by the Amazon Web Services account or only the specified
        /// interconnect.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInterconnects service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeInterconnects service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeInterconnects">REST API Reference for DescribeInterconnects Operation</seealso>
        Task<DescribeInterconnectsResponse> DescribeInterconnectsAsync(DescribeInterconnectsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Describes all your link aggregation groups (LAG) or the specified LAG.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLags service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeLags">REST API Reference for DescribeLags Operation</seealso>
        Task<DescribeLagsResponse> DescribeLagsAsync(DescribeLagsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLoa service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeLoa">REST API Reference for DescribeLoa Operation</seealso>
        Task<DescribeLoaResponse> DescribeLoaAsync(DescribeLoaRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists the Direct Connect locations in the current Amazon Web Services Region. These
        /// are the locations that can be selected when calling <a>CreateConnection</a> or <a>CreateInterconnect</a>.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLocations service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeLocations">REST API Reference for DescribeLocations Operation</seealso>
        Task<DescribeLocationsResponse> DescribeLocationsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Lists the Direct Connect locations in the current Amazon Web Services Region. These
        /// are the locations that can be selected when calling <a>CreateConnection</a> or <a>CreateInterconnect</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLocations service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeLocations">REST API Reference for DescribeLocations Operation</seealso>
        Task<DescribeLocationsResponse> DescribeLocationsAsync(DescribeLocationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Details about the router.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRouterConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRouterConfiguration service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeRouterConfiguration">REST API Reference for DescribeRouterConfiguration Operation</seealso>
        Task<DescribeRouterConfigurationResponse> DescribeRouterConfigurationAsync(DescribeRouterConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Describes the tags associated with the specified Direct Connect resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTags service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeTags">REST API Reference for DescribeTags Operation</seealso>
        Task<DescribeTagsResponse> DescribeTagsAsync(DescribeTagsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeVirtualGateways


        /// <summary>
        /// Lists the virtual private gateways owned by the Amazon Web Services account.
        /// 
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
        /// Lists the virtual private gateways owned by the Amazon Web Services account.
        /// 
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
        /// Lists the virtual private gateways owned by the Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// You can create one or more Direct Connect private virtual interfaces linked to a virtual
        /// private gateway.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVirtualGateways service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeVirtualGateways">REST API Reference for DescribeVirtualGateways Operation</seealso>
        Task<DescribeVirtualGatewaysResponse> DescribeVirtualGatewaysAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Lists the virtual private gateways owned by the Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// You can create one or more Direct Connect private virtual interfaces linked to a virtual
        /// private gateway.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVirtualGateways service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVirtualGateways service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeVirtualGateways">REST API Reference for DescribeVirtualGateways Operation</seealso>
        Task<DescribeVirtualGatewaysResponse> DescribeVirtualGatewaysAsync(DescribeVirtualGatewaysRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVirtualInterfaces service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeVirtualInterfaces">REST API Reference for DescribeVirtualInterfaces Operation</seealso>
        Task<DescribeVirtualInterfacesResponse> DescribeVirtualInterfacesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVirtualInterfaces service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeVirtualInterfaces">REST API Reference for DescribeVirtualInterfaces Operation</seealso>
        Task<DescribeVirtualInterfacesResponse> DescribeVirtualInterfacesAsync(DescribeVirtualInterfacesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateConnectionFromLag service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DisassociateConnectionFromLag">REST API Reference for DisassociateConnectionFromLag Operation</seealso>
        Task<DisassociateConnectionFromLagResponse> DisassociateConnectionFromLagAsync(DisassociateConnectionFromLagRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Removes the association between a MAC Security (MACsec) security key and an Direct
        /// Connect dedicated connection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMacSecKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateMacSecKey service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DisassociateMacSecKey">REST API Reference for DisassociateMacSecKey Operation</seealso>
        Task<DisassociateMacSecKeyResponse> DisassociateMacSecKeyAsync(DisassociateMacSecKeyRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists the virtual interface failover test history.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVirtualInterfaceTestHistory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListVirtualInterfaceTestHistory service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/ListVirtualInterfaceTestHistory">REST API Reference for ListVirtualInterfaceTestHistory Operation</seealso>
        Task<ListVirtualInterfaceTestHistoryResponse> ListVirtualInterfaceTestHistoryAsync(ListVirtualInterfaceTestHistoryRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartBgpFailoverTest service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/StartBgpFailoverTest">REST API Reference for StartBgpFailoverTest Operation</seealso>
        Task<StartBgpFailoverTestResponse> StartBgpFailoverTestAsync(StartBgpFailoverTestRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Stops the virtual interface failover test.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopBgpFailoverTest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopBgpFailoverTest service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/StopBgpFailoverTest">REST API Reference for StopBgpFailoverTest Operation</seealso>
        Task<StopBgpFailoverTestResponse> StopBgpFailoverTestAsync(StopBgpFailoverTestRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Removes one or more tags from the specified Direct Connect resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateConnection service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/UpdateConnection">REST API Reference for UpdateConnection Operation</seealso>
        Task<UpdateConnectionResponse> UpdateConnectionAsync(UpdateConnectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Updates the name of a current Direct Connect gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDirectConnectGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDirectConnectGateway service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/UpdateDirectConnectGateway">REST API Reference for UpdateDirectConnectGateway Operation</seealso>
        Task<UpdateDirectConnectGatewayResponse> UpdateDirectConnectGatewayAsync(UpdateDirectConnectGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Updates the specified attributes of the Direct Connect gateway association.
        /// 
        ///  
        /// <para>
        /// Add or remove prefixes from the association.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDirectConnectGatewayAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDirectConnectGatewayAssociation service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/UpdateDirectConnectGatewayAssociation">REST API Reference for UpdateDirectConnectGatewayAssociation Operation</seealso>
        Task<UpdateDirectConnectGatewayAssociationResponse> UpdateDirectConnectGatewayAssociationAsync(UpdateDirectConnectGatewayAssociationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateLag service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/UpdateLag">REST API Reference for UpdateLag Operation</seealso>
        Task<UpdateLagResponse> UpdateLagAsync(UpdateLagRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateVirtualInterfaceAttributes


        /// <summary>
        /// Updates the specified attributes of the specified virtual private interface.
        /// 
        ///  
        /// <para>
        /// Setting the MTU of a virtual interface to 9001 (jumbo frames) can cause an update
        /// to the underlying physical connection if it wasn't updated to support jumbo frames.
        /// Updating the connection disrupts network connectivity for all virtual interfaces associated
        /// with the connection for up to 30 seconds. To check whether your connection supports
        /// jumbo frames, call <a>DescribeConnections</a>. To check whether your virtual q interface
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
        /// Updates the specified attributes of the specified virtual private interface.
        /// 
        ///  
        /// <para>
        /// Setting the MTU of a virtual interface to 9001 (jumbo frames) can cause an update
        /// to the underlying physical connection if it wasn't updated to support jumbo frames.
        /// Updating the connection disrupts network connectivity for all virtual interfaces associated
        /// with the connection for up to 30 seconds. To check whether your connection supports
        /// jumbo frames, call <a>DescribeConnections</a>. To check whether your virtual q interface
        /// supports jumbo frames, call <a>DescribeVirtualInterfaces</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVirtualInterfaceAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateVirtualInterfaceAttributes service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/UpdateVirtualInterfaceAttributes">REST API Reference for UpdateVirtualInterfaceAttributes Operation</seealso>
        Task<UpdateVirtualInterfaceAttributesResponse> UpdateVirtualInterfaceAttributesAsync(UpdateVirtualInterfaceAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}