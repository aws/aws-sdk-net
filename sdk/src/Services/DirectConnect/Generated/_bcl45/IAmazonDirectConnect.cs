/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// AWS Direct Connect links your internal network to an AWS Direct Connect location over
    /// a standard 1 gigabit or 10 gigabit Ethernet fiber-optic cable. One end of the cable
    /// is connected to your router, the other to an AWS Direct Connect router. With this
    /// connection in place, you can create virtual interfaces directly to the AWS cloud (for
    /// example, to Amazon Elastic Compute Cloud (Amazon EC2) and Amazon Simple Storage Service
    /// (Amazon S3)) and to Amazon Virtual Private Cloud (Amazon VPC), bypassing Internet
    /// service providers in your network path. An AWS Direct Connect location provides access
    /// to AWS in the region it is associated with, as well as access to other US regions.
    /// For example, you can provision a single connection to any AWS Direct Connect location
    /// in the US and use it to access public AWS services in all US Regions and AWS GovCloud
    /// (US).
    /// </summary>
    public partial interface IAmazonDirectConnect : IAmazonService, IDisposable
    {

        
        #region  AllocateConnectionOnInterconnect


        /// <summary>
        /// Creates a hosted connection on an interconnect.
        /// 
        ///  
        /// <para>
        /// Allocates a VLAN number and a specified amount of bandwidth for use by a hosted connection
        /// on the given interconnect.
        /// </para>
        ///  <note> 
        /// <para>
        /// This is intended for use by AWS Direct Connect partners only.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AllocateConnectionOnInterconnect service method.</param>
        /// 
        /// <returns>The response from the AllocateConnectionOnInterconnect service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        AllocateConnectionOnInterconnectResponse AllocateConnectionOnInterconnect(AllocateConnectionOnInterconnectRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the AllocateConnectionOnInterconnect operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AllocateConnectionOnInterconnect operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<AllocateConnectionOnInterconnectResponse> AllocateConnectionOnInterconnectAsync(AllocateConnectionOnInterconnectRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AllocatePrivateVirtualInterface


        /// <summary>
        /// Provisions a private virtual interface to be owned by a different customer.
        /// 
        ///  
        /// <para>
        /// The owner of a connection calls this function to provision a private virtual interface
        /// which will be owned by another AWS customer.
        /// </para>
        ///  
        /// <para>
        /// Virtual interfaces created using this function must be confirmed by the virtual interface
        /// owner by calling ConfirmPrivateVirtualInterface. Until this step has been completed,
        /// the virtual interface will be in 'Confirming' state, and will not be available for
        /// handling traffic.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AllocatePrivateVirtualInterface service method.</param>
        /// 
        /// <returns>The response from the AllocatePrivateVirtualInterface service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        AllocatePrivateVirtualInterfaceResponse AllocatePrivateVirtualInterface(AllocatePrivateVirtualInterfaceRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the AllocatePrivateVirtualInterface operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AllocatePrivateVirtualInterface operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<AllocatePrivateVirtualInterfaceResponse> AllocatePrivateVirtualInterfaceAsync(AllocatePrivateVirtualInterfaceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AllocatePublicVirtualInterface


        /// <summary>
        /// Provisions a public virtual interface to be owned by a different customer.
        /// 
        ///  
        /// <para>
        /// The owner of a connection calls this function to provision a public virtual interface
        /// which will be owned by another AWS customer.
        /// </para>
        ///  
        /// <para>
        /// Virtual interfaces created using this function must be confirmed by the virtual interface
        /// owner by calling ConfirmPublicVirtualInterface. Until this step has been completed,
        /// the virtual interface will be in 'Confirming' state, and will not be available for
        /// handling traffic.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AllocatePublicVirtualInterface service method.</param>
        /// 
        /// <returns>The response from the AllocatePublicVirtualInterface service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        AllocatePublicVirtualInterfaceResponse AllocatePublicVirtualInterface(AllocatePublicVirtualInterfaceRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the AllocatePublicVirtualInterface operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AllocatePublicVirtualInterface operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<AllocatePublicVirtualInterfaceResponse> AllocatePublicVirtualInterfaceAsync(AllocatePublicVirtualInterfaceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ConfirmConnection


        /// <summary>
        /// Confirm the creation of a hosted connection on an interconnect.
        /// 
        ///  
        /// <para>
        /// Upon creation, the hosted connection is initially in the 'Ordering' state, and will
        /// remain in this state until the owner calls ConfirmConnection to confirm creation of
        /// the hosted connection.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConfirmConnection service method.</param>
        /// 
        /// <returns>The response from the ConfirmConnection service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        ConfirmConnectionResponse ConfirmConnection(ConfirmConnectionRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ConfirmConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConfirmConnection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ConfirmConnectionResponse> ConfirmConnectionAsync(ConfirmConnectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ConfirmPrivateVirtualInterface


        /// <summary>
        /// Accept ownership of a private virtual interface created by another customer.
        /// 
        ///  
        /// <para>
        /// After the virtual interface owner calls this function, the virtual interface will
        /// be created and attached to the given virtual private gateway, and will be available
        /// for handling traffic.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConfirmPrivateVirtualInterface service method.</param>
        /// 
        /// <returns>The response from the ConfirmPrivateVirtualInterface service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        ConfirmPrivateVirtualInterfaceResponse ConfirmPrivateVirtualInterface(ConfirmPrivateVirtualInterfaceRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ConfirmPrivateVirtualInterface operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConfirmPrivateVirtualInterface operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ConfirmPrivateVirtualInterfaceResponse> ConfirmPrivateVirtualInterfaceAsync(ConfirmPrivateVirtualInterfaceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ConfirmPublicVirtualInterface


        /// <summary>
        /// Accept ownership of a public virtual interface created by another customer.
        /// 
        ///  
        /// <para>
        /// After the virtual interface owner calls this function, the specified virtual interface
        /// will be created and made available for handling traffic.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConfirmPublicVirtualInterface service method.</param>
        /// 
        /// <returns>The response from the ConfirmPublicVirtualInterface service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        ConfirmPublicVirtualInterfaceResponse ConfirmPublicVirtualInterface(ConfirmPublicVirtualInterfaceRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ConfirmPublicVirtualInterface operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConfirmPublicVirtualInterface operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ConfirmPublicVirtualInterfaceResponse> ConfirmPublicVirtualInterfaceAsync(ConfirmPublicVirtualInterfaceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateConnection


        /// <summary>
        /// Creates a new connection between the customer network and a specific AWS Direct Connect
        /// location.
        /// 
        ///  
        /// <para>
        /// A connection links your internal network to an AWS Direct Connect location over a
        /// standard 1 gigabit or 10 gigabit Ethernet fiber-optic cable. One end of the cable
        /// is connected to your router, the other to an AWS Direct Connect router. An AWS Direct
        /// Connect location provides access to Amazon Web Services in the region it is associated
        /// with. You can establish connections with AWS Direct Connect locations in multiple
        /// regions, but a connection in one region does not provide connectivity to other regions.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConnection service method.</param>
        /// 
        /// <returns>The response from the CreateConnection service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        CreateConnectionResponse CreateConnection(CreateConnectionRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConnection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateConnectionResponse> CreateConnectionAsync(CreateConnectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateInterconnect


        /// <summary>
        /// Creates a new interconnect between a AWS Direct Connect partner's network and a specific
        /// AWS Direct Connect location.
        /// 
        ///  
        /// <para>
        /// An interconnect is a connection which is capable of hosting other connections. The
        /// AWS Direct Connect partner can use an interconnect to provide sub-1Gbps AWS Direct
        /// Connect service to tier 2 customers who do not have their own connections. Like a
        /// standard connection, an interconnect links the AWS Direct Connect partner's network
        /// to an AWS Direct Connect location over a standard 1 Gbps or 10 Gbps Ethernet fiber-optic
        /// cable. One end is connected to the partner's router, the other to an AWS Direct Connect
        /// router.
        /// </para>
        ///  
        /// <para>
        /// For each end customer, the AWS Direct Connect partner provisions a connection on their
        /// interconnect by calling AllocateConnectionOnInterconnect. The end customer can then
        /// connect to AWS resources by creating a virtual interface on their connection, using
        /// the VLAN assigned to them by the AWS Direct Connect partner.
        /// </para>
        ///  <note> 
        /// <para>
        /// This is intended for use by AWS Direct Connect partners only.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInterconnect service method.</param>
        /// 
        /// <returns>The response from the CreateInterconnect service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        CreateInterconnectResponse CreateInterconnect(CreateInterconnectRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateInterconnect operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInterconnect operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateInterconnectResponse> CreateInterconnectAsync(CreateInterconnectRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreatePrivateVirtualInterface


        /// <summary>
        /// Creates a new private virtual interface. A virtual interface is the VLAN that transports
        /// AWS Direct Connect traffic. A private virtual interface supports sending traffic to
        /// a single virtual private cloud (VPC).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePrivateVirtualInterface service method.</param>
        /// 
        /// <returns>The response from the CreatePrivateVirtualInterface service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        CreatePrivateVirtualInterfaceResponse CreatePrivateVirtualInterface(CreatePrivateVirtualInterfaceRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreatePrivateVirtualInterface operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePrivateVirtualInterface operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreatePrivateVirtualInterfaceResponse> CreatePrivateVirtualInterfaceAsync(CreatePrivateVirtualInterfaceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreatePublicVirtualInterface


        /// <summary>
        /// Creates a new public virtual interface. A virtual interface is the VLAN that transports
        /// AWS Direct Connect traffic. A public virtual interface supports sending traffic to
        /// public services of AWS such as Amazon Simple Storage Service (Amazon S3).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePublicVirtualInterface service method.</param>
        /// 
        /// <returns>The response from the CreatePublicVirtualInterface service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        CreatePublicVirtualInterfaceResponse CreatePublicVirtualInterface(CreatePublicVirtualInterfaceRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreatePublicVirtualInterface operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePublicVirtualInterface operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreatePublicVirtualInterfaceResponse> CreatePublicVirtualInterfaceAsync(CreatePublicVirtualInterfaceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteConnection


        /// <summary>
        /// Deletes the connection.
        /// 
        ///  
        /// <para>
        /// Deleting a connection only stops the AWS Direct Connect port hour and data transfer
        /// charges. You need to cancel separately with the providers any services or charges
        /// for cross-connects or network circuits that connect you to the AWS Direct Connect
        /// location.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnection service method.</param>
        /// 
        /// <returns>The response from the DeleteConnection service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        DeleteConnectionResponse DeleteConnection(DeleteConnectionRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteConnectionResponse> DeleteConnectionAsync(DeleteConnectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteInterconnect


        /// <summary>
        /// Deletes the specified interconnect.
        /// 
        ///  <note> 
        /// <para>
        /// This is intended for use by AWS Direct Connect partners only.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInterconnect service method.</param>
        /// 
        /// <returns>The response from the DeleteInterconnect service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        DeleteInterconnectResponse DeleteInterconnect(DeleteInterconnectRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInterconnect operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInterconnect operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteInterconnectResponse> DeleteInterconnectAsync(DeleteInterconnectRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteVirtualInterface


        /// <summary>
        /// Deletes a virtual interface.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVirtualInterface service method.</param>
        /// 
        /// <returns>The response from the DeleteVirtualInterface service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        DeleteVirtualInterfaceResponse DeleteVirtualInterface(DeleteVirtualInterfaceRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVirtualInterface operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVirtualInterface operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteVirtualInterfaceResponse> DeleteVirtualInterfaceAsync(DeleteVirtualInterfaceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeConnectionLoa


        /// <summary>
        /// Returns the LOA-CFA for a Connection.
        /// 
        ///  
        /// <para>
        /// The Letter of Authorization - Connecting Facility Assignment (LOA-CFA) is a document
        /// that your APN partner or service provider uses when establishing your cross connect
        /// to AWS at the colocation facility. For more information, see <a href="http://docs.aws.amazon.com/directconnect/latest/UserGuide/Colocation.html">Requesting
        /// Cross Connects at AWS Direct Connect Locations</a> in the AWS Direct Connect user
        /// guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnectionLoa service method.</param>
        /// 
        /// <returns>The response from the DescribeConnectionLoa service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        DescribeConnectionLoaResponse DescribeConnectionLoa(DescribeConnectionLoaRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConnectionLoa operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnectionLoa operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeConnectionLoaResponse> DescribeConnectionLoaAsync(DescribeConnectionLoaRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeConnections


        /// <summary>
        /// Displays all connections in this region.
        /// 
        ///  
        /// <para>
        /// If a connection ID is provided, the call returns only that particular connection.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeConnections service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        DescribeConnectionsResponse DescribeConnections();


        /// <summary>
        /// Displays all connections in this region.
        /// 
        ///  
        /// <para>
        /// If a connection ID is provided, the call returns only that particular connection.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnections service method.</param>
        /// 
        /// <returns>The response from the DescribeConnections service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        DescribeConnectionsResponse DescribeConnections(DescribeConnectionsRequest request);


        /// <summary>
        /// Displays all connections in this region.
        /// 
        ///  
        /// <para>
        /// If a connection ID is provided, the call returns only that particular connection.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeConnections service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        Task<DescribeConnectionsResponse> DescribeConnectionsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConnections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnections operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeConnectionsResponse> DescribeConnectionsAsync(DescribeConnectionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeConnectionsOnInterconnect


        /// <summary>
        /// Return a list of connections that have been provisioned on the given interconnect.
        /// 
        ///  <note> 
        /// <para>
        /// This is intended for use by AWS Direct Connect partners only.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnectionsOnInterconnect service method.</param>
        /// 
        /// <returns>The response from the DescribeConnectionsOnInterconnect service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        DescribeConnectionsOnInterconnectResponse DescribeConnectionsOnInterconnect(DescribeConnectionsOnInterconnectRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConnectionsOnInterconnect operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnectionsOnInterconnect operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeConnectionsOnInterconnectResponse> DescribeConnectionsOnInterconnectAsync(DescribeConnectionsOnInterconnectRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeInterconnectLoa


        /// <summary>
        /// Returns the LOA-CFA for an Interconnect.
        /// 
        ///  
        /// <para>
        /// The Letter of Authorization - Connecting Facility Assignment (LOA-CFA) is a document
        /// that is used when establishing your cross connect to AWS at the colocation facility.
        /// For more information, see <a href="http://docs.aws.amazon.com/directconnect/latest/UserGuide/Colocation.html">Requesting
        /// Cross Connects at AWS Direct Connect Locations</a> in the AWS Direct Connect user
        /// guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInterconnectLoa service method.</param>
        /// 
        /// <returns>The response from the DescribeInterconnectLoa service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        DescribeInterconnectLoaResponse DescribeInterconnectLoa(DescribeInterconnectLoaRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInterconnectLoa operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInterconnectLoa operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeInterconnectLoaResponse> DescribeInterconnectLoaAsync(DescribeInterconnectLoaRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeInterconnects


        /// <summary>
        /// Returns a list of interconnects owned by the AWS account.
        /// 
        ///  
        /// <para>
        /// If an interconnect ID is provided, it will only return this particular interconnect.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeInterconnects service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        DescribeInterconnectsResponse DescribeInterconnects();


        /// <summary>
        /// Returns a list of interconnects owned by the AWS account.
        /// 
        ///  
        /// <para>
        /// If an interconnect ID is provided, it will only return this particular interconnect.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInterconnects service method.</param>
        /// 
        /// <returns>The response from the DescribeInterconnects service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        DescribeInterconnectsResponse DescribeInterconnects(DescribeInterconnectsRequest request);


        /// <summary>
        /// Returns a list of interconnects owned by the AWS account.
        /// 
        ///  
        /// <para>
        /// If an interconnect ID is provided, it will only return this particular interconnect.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeInterconnects service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        Task<DescribeInterconnectsResponse> DescribeInterconnectsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInterconnects operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInterconnects operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeInterconnectsResponse> DescribeInterconnectsAsync(DescribeInterconnectsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeLocations


        /// <summary>
        /// Returns the list of AWS Direct Connect locations in the current AWS region. These
        /// are the locations that may be selected when calling CreateConnection or CreateInterconnect.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeLocations service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        DescribeLocationsResponse DescribeLocations();


        /// <summary>
        /// Returns the list of AWS Direct Connect locations in the current AWS region. These
        /// are the locations that may be selected when calling CreateConnection or CreateInterconnect.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocations service method.</param>
        /// 
        /// <returns>The response from the DescribeLocations service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        DescribeLocationsResponse DescribeLocations(DescribeLocationsRequest request);


        /// <summary>
        /// Returns the list of AWS Direct Connect locations in the current AWS region. These
        /// are the locations that may be selected when calling CreateConnection or CreateInterconnect.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLocations service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        Task<DescribeLocationsResponse> DescribeLocationsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLocations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeLocationsResponse> DescribeLocationsAsync(DescribeLocationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeVirtualGateways


        /// <summary>
        /// Returns a list of virtual private gateways owned by the AWS account.
        /// 
        ///  
        /// <para>
        /// You can create one or more AWS Direct Connect private virtual interfaces linking to
        /// a virtual private gateway. A virtual private gateway can be managed via Amazon Virtual
        /// Private Cloud (VPC) console or the <a href="http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-CreateVpnGateway.html">EC2
        /// CreateVpnGateway</a> action.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeVirtualGateways service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        DescribeVirtualGatewaysResponse DescribeVirtualGateways();


        /// <summary>
        /// Returns a list of virtual private gateways owned by the AWS account.
        /// 
        ///  
        /// <para>
        /// You can create one or more AWS Direct Connect private virtual interfaces linking to
        /// a virtual private gateway. A virtual private gateway can be managed via Amazon Virtual
        /// Private Cloud (VPC) console or the <a href="http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-CreateVpnGateway.html">EC2
        /// CreateVpnGateway</a> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVirtualGateways service method.</param>
        /// 
        /// <returns>The response from the DescribeVirtualGateways service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        DescribeVirtualGatewaysResponse DescribeVirtualGateways(DescribeVirtualGatewaysRequest request);


        /// <summary>
        /// Returns a list of virtual private gateways owned by the AWS account.
        /// 
        ///  
        /// <para>
        /// You can create one or more AWS Direct Connect private virtual interfaces linking to
        /// a virtual private gateway. A virtual private gateway can be managed via Amazon Virtual
        /// Private Cloud (VPC) console or the <a href="http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-CreateVpnGateway.html">EC2
        /// CreateVpnGateway</a> action.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVirtualGateways service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        Task<DescribeVirtualGatewaysResponse> DescribeVirtualGatewaysAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVirtualGateways operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVirtualGateways operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeVirtualGatewaysResponse> DescribeVirtualGatewaysAsync(DescribeVirtualGatewaysRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeVirtualInterfaces


        /// <summary>
        /// Displays all virtual interfaces for an AWS account. Virtual interfaces deleted fewer
        /// than 15 minutes before DescribeVirtualInterfaces is called are also returned. If a
        /// connection ID is included then only virtual interfaces associated with this connection
        /// will be returned. If a virtual interface ID is included then only a single virtual
        /// interface will be returned.
        /// 
        ///  
        /// <para>
        /// A virtual interface (VLAN) transmits the traffic between the AWS Direct Connect location
        /// and the customer.
        /// </para>
        ///  
        /// <para>
        /// If a connection ID is provided, only virtual interfaces provisioned on the specified
        /// connection will be returned. If a virtual interface ID is provided, only this particular
        /// virtual interface will be returned.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeVirtualInterfaces service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        DescribeVirtualInterfacesResponse DescribeVirtualInterfaces();


        /// <summary>
        /// Displays all virtual interfaces for an AWS account. Virtual interfaces deleted fewer
        /// than 15 minutes before DescribeVirtualInterfaces is called are also returned. If a
        /// connection ID is included then only virtual interfaces associated with this connection
        /// will be returned. If a virtual interface ID is included then only a single virtual
        /// interface will be returned.
        /// 
        ///  
        /// <para>
        /// A virtual interface (VLAN) transmits the traffic between the AWS Direct Connect location
        /// and the customer.
        /// </para>
        ///  
        /// <para>
        /// If a connection ID is provided, only virtual interfaces provisioned on the specified
        /// connection will be returned. If a virtual interface ID is provided, only this particular
        /// virtual interface will be returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVirtualInterfaces service method.</param>
        /// 
        /// <returns>The response from the DescribeVirtualInterfaces service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        DescribeVirtualInterfacesResponse DescribeVirtualInterfaces(DescribeVirtualInterfacesRequest request);


        /// <summary>
        /// Displays all virtual interfaces for an AWS account. Virtual interfaces deleted fewer
        /// than 15 minutes before DescribeVirtualInterfaces is called are also returned. If a
        /// connection ID is included then only virtual interfaces associated with this connection
        /// will be returned. If a virtual interface ID is included then only a single virtual
        /// interface will be returned.
        /// 
        ///  
        /// <para>
        /// A virtual interface (VLAN) transmits the traffic between the AWS Direct Connect location
        /// and the customer.
        /// </para>
        ///  
        /// <para>
        /// If a connection ID is provided, only virtual interfaces provisioned on the specified
        /// connection will be returned. If a virtual interface ID is provided, only this particular
        /// virtual interface will be returned.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVirtualInterfaces service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        Task<DescribeVirtualInterfacesResponse> DescribeVirtualInterfacesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVirtualInterfaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVirtualInterfaces operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeVirtualInterfacesResponse> DescribeVirtualInterfacesAsync(DescribeVirtualInterfacesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}