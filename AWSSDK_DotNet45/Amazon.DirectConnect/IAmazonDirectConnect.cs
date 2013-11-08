/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Threading;
using System.Threading.Tasks;

using Amazon.DirectConnect.Model;

namespace Amazon.DirectConnect
{
    /// <summary>
    /// Interface for accessing AmazonDirectConnect.
    /// 
    /// <para>AWS Direct Connect makes it easy to establish a dedicated network connection from your premises to Amazon Web Services (AWS). Using
    /// AWS Direct Connect, you can establish private connectivity between AWS and your data center, office, or colocation environment, which in
    /// many cases can reduce your network costs, increase bandwidth throughput, and provide a more consistent network experience than
    /// Internet-based connections.</para> <para>The AWS Direct Connect API Reference provides descriptions, syntax, and usage examples for each of
    /// the actions and data types for AWS Direct Connect. Use the following links to get started using the <i>AWS Direct Connect API Reference</i>
    /// :</para>
    /// <ul>
    /// <li> <a href="http://docs.aws.amazon.com/directconnect/latest/APIReference/API_Operations.html">Actions</a> : An alphabetical list of all
    /// AWS Direct Connect actions.</li>
    /// <li> <a href="http://docs.aws.amazon.com/directconnect/latest/APIReference/API_Types.html">Data Types</a> : An alphabetical list of all
    /// AWS Direct Connect data types.</li>
    /// <li> <a href="http://docs.aws.amazon.com/directconnect/latest/APIReference/CommonParameters.html">Common Query Parameters</a> : Parameters
    /// that all Query actions can use.</li>
    /// <li> <a href="http://docs.aws.amazon.com/directconnect/latest/APIReference/CommonErrors.html">Common Errors</a> : Client and server errors
    /// that all actions can return.</li>
    /// 
    /// </ul>
    /// </summary>
	public partial interface IAmazonDirectConnect : IDisposable
    {
 

        /// <summary>
        /// <para>Creates a hosted connection on an interconnect.</para> <para>Allocates a VLAN number and a specified amount of bandwidth for use by a
        /// hosted connection on the given interconnect.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AllocateConnectionOnInterconnect
        /// service method on AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the AllocateConnectionOnInterconnect service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectServerException" />
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectClientException" />
		AllocateConnectionOnInterconnectResponse AllocateConnectionOnInterconnect(AllocateConnectionOnInterconnectRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AllocateConnectionOnInterconnect operation.
        /// <seealso cref="Amazon.DirectConnect.IAmazonDirectConnect.AllocateConnectionOnInterconnect"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AllocateConnectionOnInterconnect operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<AllocateConnectionOnInterconnectResponse> AllocateConnectionOnInterconnectAsync(AllocateConnectionOnInterconnectRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Provisions a private virtual interface to be owned by a different customer.</para> <para>The owner of a connection calls this function
        /// to provision a private virtual interface which will be owned by another AWS customer.</para> <para>Virtual interfaces created using this
        /// function must be confirmed by the virtual interface owner by calling ConfirmPrivateVirtualInterface. Until this step has been completed,
        /// the virtual interface will be in 'Confirming' state, and will not be available for handling traffic.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AllocatePrivateVirtualInterface
        /// service method on AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the AllocatePrivateVirtualInterface service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectServerException" />
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectClientException" />
		AllocatePrivateVirtualInterfaceResponse AllocatePrivateVirtualInterface(AllocatePrivateVirtualInterfaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AllocatePrivateVirtualInterface operation.
        /// <seealso cref="Amazon.DirectConnect.IAmazonDirectConnect.AllocatePrivateVirtualInterface"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AllocatePrivateVirtualInterface operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<AllocatePrivateVirtualInterfaceResponse> AllocatePrivateVirtualInterfaceAsync(AllocatePrivateVirtualInterfaceRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Provisions a public virtual interface to be owned by a different customer.</para> <para>The owner of a connection calls this function
        /// to provision a public virtual interface which will be owned by another AWS customer.</para> <para>Virtual interfaces created using this
        /// function must be confirmed by the virtual interface owner by calling ConfirmPublicVirtualInterface. Until this step has been completed, the
        /// virtual interface will be in 'Confirming' state, and will not be available for handling traffic.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AllocatePublicVirtualInterface
        /// service method on AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the AllocatePublicVirtualInterface service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectServerException" />
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectClientException" />
		AllocatePublicVirtualInterfaceResponse AllocatePublicVirtualInterface(AllocatePublicVirtualInterfaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AllocatePublicVirtualInterface operation.
        /// <seealso cref="Amazon.DirectConnect.IAmazonDirectConnect.AllocatePublicVirtualInterface"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AllocatePublicVirtualInterface operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<AllocatePublicVirtualInterfaceResponse> AllocatePublicVirtualInterfaceAsync(AllocatePublicVirtualInterfaceRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Confirm the creation of a hosted connection on an interconnect.</para> <para>Upon creation, the hosted connection is initially in the
        /// 'Ordering' state, and will remain in this state until the owner calls ConfirmConnection to confirm creation of the hosted connection.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConfirmConnection service method on
        /// AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the ConfirmConnection service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectServerException" />
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectClientException" />
		ConfirmConnectionResponse ConfirmConnection(ConfirmConnectionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ConfirmConnection operation.
        /// <seealso cref="Amazon.DirectConnect.IAmazonDirectConnect.ConfirmConnection"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConfirmConnection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ConfirmConnectionResponse> ConfirmConnectionAsync(ConfirmConnectionRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Accept ownership of a private virtual interface created by another customer.</para> <para>After the virtual interface owner calls this
        /// function, the virtual interface will be created and attached to the given virtual private gateway, and will be available for handling
        /// traffic.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConfirmPrivateVirtualInterface
        /// service method on AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the ConfirmPrivateVirtualInterface service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectServerException" />
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectClientException" />
		ConfirmPrivateVirtualInterfaceResponse ConfirmPrivateVirtualInterface(ConfirmPrivateVirtualInterfaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ConfirmPrivateVirtualInterface operation.
        /// <seealso cref="Amazon.DirectConnect.IAmazonDirectConnect.ConfirmPrivateVirtualInterface"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConfirmPrivateVirtualInterface operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ConfirmPrivateVirtualInterfaceResponse> ConfirmPrivateVirtualInterfaceAsync(ConfirmPrivateVirtualInterfaceRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Accept ownership of a public virtual interface created by another customer.</para> <para>After the virtual interface owner calls this
        /// function, the specified virtual interface will be created and made available for handling traffic.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConfirmPublicVirtualInterface
        /// service method on AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the ConfirmPublicVirtualInterface service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectServerException" />
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectClientException" />
		ConfirmPublicVirtualInterfaceResponse ConfirmPublicVirtualInterface(ConfirmPublicVirtualInterfaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ConfirmPublicVirtualInterface operation.
        /// <seealso cref="Amazon.DirectConnect.IAmazonDirectConnect.ConfirmPublicVirtualInterface"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConfirmPublicVirtualInterface operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ConfirmPublicVirtualInterfaceResponse> ConfirmPublicVirtualInterfaceAsync(ConfirmPublicVirtualInterfaceRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Creates a new connection between the customer network and a specific AWS Direct Connect location.</para> <para>A connection links your
        /// internal network to an AWS Direct Connect location over a standard 1 gigabit or 10 gigabit Ethernet fiber-optic cable. One end of the cable
        /// is connected to your router, the other to an AWS Direct Connect router. A Direct Connect location provides access to Amazon Web Services in
        /// the region it is associated with. You can establish connections with AWS Direct Connect locations in multiple regions, but a connection in
        /// one region does not provide connectivity to other regions.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConnection service method on
        /// AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the CreateConnection service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectServerException" />
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectClientException" />
		CreateConnectionResponse CreateConnection(CreateConnectionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateConnection operation.
        /// <seealso cref="Amazon.DirectConnect.IAmazonDirectConnect.CreateConnection"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConnection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CreateConnectionResponse> CreateConnectionAsync(CreateConnectionRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Creates a new interconnect between a Direct Connect partner's network and a specific AWS Direct Connect location.</para> <para>An
        /// interconnect is a connection which is capable of hosting other connections. The AWS Direct Connect partner can use an interconnect to
        /// provide sub-1Gbps Direct Connect service to tier 2 customers who do not have their own connections. Like a standard connection, an
        /// interconnect links the Direct Connect partner's network to an AWS Direct Connect location over a standard 1 Gbps or 10 Gbps Ethernet
        /// fiber-optic cable. One end is connected to the partner's router, the other to an AWS Direct Connect router.</para> <para>For each end
        /// customer, the Direct Connect partner provisions a connection on their interconnect by calling AllocateConnectionOnInterconnect. The end
        /// customer can then connect to AWS resources by creating a virtual interface on their connection, using the VLAN assigned to them by the
        /// Direct Connect partner.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInterconnect service method on
        /// AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the CreateInterconnect service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectServerException" />
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectClientException" />
		CreateInterconnectResponse CreateInterconnect(CreateInterconnectRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateInterconnect operation.
        /// <seealso cref="Amazon.DirectConnect.IAmazonDirectConnect.CreateInterconnect"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInterconnect operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CreateInterconnectResponse> CreateInterconnectAsync(CreateInterconnectRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Creates a new private virtual interface. A virtual interface is the VLAN that transports AWS Direct Connect traffic. A private
        /// virtual interface supports sending traffic to a single Virtual Private Cloud (VPC).</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePrivateVirtualInterface
        /// service method on AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the CreatePrivateVirtualInterface service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectServerException" />
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectClientException" />
		CreatePrivateVirtualInterfaceResponse CreatePrivateVirtualInterface(CreatePrivateVirtualInterfaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePrivateVirtualInterface operation.
        /// <seealso cref="Amazon.DirectConnect.IAmazonDirectConnect.CreatePrivateVirtualInterface"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePrivateVirtualInterface operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CreatePrivateVirtualInterfaceResponse> CreatePrivateVirtualInterfaceAsync(CreatePrivateVirtualInterfaceRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Creates a new public virtual interface. A virtual interface is the VLAN that transports AWS Direct Connect traffic. A public virtual
        /// interface supports sending traffic to public services of AWS such as Amazon Simple Storage Service (Amazon S3).</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePublicVirtualInterface service
        /// method on AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the CreatePublicVirtualInterface service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectServerException" />
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectClientException" />
		CreatePublicVirtualInterfaceResponse CreatePublicVirtualInterface(CreatePublicVirtualInterfaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePublicVirtualInterface operation.
        /// <seealso cref="Amazon.DirectConnect.IAmazonDirectConnect.CreatePublicVirtualInterface"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePublicVirtualInterface operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CreatePublicVirtualInterfaceResponse> CreatePublicVirtualInterfaceAsync(CreatePublicVirtualInterfaceRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Deletes the connection.</para> <para>Deleting a connection only stops the AWS Direct Connect port hour and data transfer charges. You
        /// separately need to cancel any services or charges for cross-connects or network circuits that connect you to the AWS Direct Connect location
        /// with the providers of those services.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnection service method on
        /// AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the DeleteConnection service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectServerException" />
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectClientException" />
		DeleteConnectionResponse DeleteConnection(DeleteConnectionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConnection operation.
        /// <seealso cref="Amazon.DirectConnect.IAmazonDirectConnect.DeleteConnection"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeleteConnectionResponse> DeleteConnectionAsync(DeleteConnectionRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Deletes the specified interconnect.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInterconnect service method on
        /// AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the DeleteInterconnect service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectServerException" />
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectClientException" />
		DeleteInterconnectResponse DeleteInterconnect(DeleteInterconnectRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInterconnect operation.
        /// <seealso cref="Amazon.DirectConnect.IAmazonDirectConnect.DeleteInterconnect"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInterconnect operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeleteInterconnectResponse> DeleteInterconnectAsync(DeleteInterconnectRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Deletes a virtual interface.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVirtualInterface service method on
        /// AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the DeleteVirtualInterface service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectServerException" />
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectClientException" />
		DeleteVirtualInterfaceResponse DeleteVirtualInterface(DeleteVirtualInterfaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVirtualInterface operation.
        /// <seealso cref="Amazon.DirectConnect.IAmazonDirectConnect.DeleteVirtualInterface"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVirtualInterface operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeleteVirtualInterfaceResponse> DeleteVirtualInterfaceAsync(DeleteVirtualInterfaceRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Displays all connections in this region.</para> <para>If a connection ID is provided, it will only return this particular
        /// connection.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnections service method on
        /// AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the DescribeConnections service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectServerException" />
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectClientException" />
		DescribeConnectionsResponse DescribeConnections(DescribeConnectionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConnections operation.
        /// <seealso cref="Amazon.DirectConnect.IAmazonDirectConnect.DescribeConnections"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnections operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeConnectionsResponse> DescribeConnectionsAsync(DescribeConnectionsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Displays all connections in this region.</para> <para>If a connection ID is provided, it will only return this particular
        /// connection.</para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeConnections service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectServerException" />
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectClientException" />
		DescribeConnectionsResponse DescribeConnections();
 

        /// <summary>
        /// <para>Return a list of connections that have been provisioned on the given interconnect.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the
        /// DescribeConnectionsOnInterconnect service method on AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the DescribeConnectionsOnInterconnect service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectServerException" />
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectClientException" />
		DescribeConnectionsOnInterconnectResponse DescribeConnectionsOnInterconnect(DescribeConnectionsOnInterconnectRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConnectionsOnInterconnect operation.
        /// <seealso cref="Amazon.DirectConnect.IAmazonDirectConnect.DescribeConnectionsOnInterconnect"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnectionsOnInterconnect operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeConnectionsOnInterconnectResponse> DescribeConnectionsOnInterconnectAsync(DescribeConnectionsOnInterconnectRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Returns a list of interconnects owned by the AWS account.</para> <para>If an interconnect ID is provided, it will only return this
        /// particular interconnect.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInterconnects service method on
        /// AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the DescribeInterconnects service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectServerException" />
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectClientException" />
		DescribeInterconnectsResponse DescribeInterconnects(DescribeInterconnectsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInterconnects operation.
        /// <seealso cref="Amazon.DirectConnect.IAmazonDirectConnect.DescribeInterconnects"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInterconnects operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeInterconnectsResponse> DescribeInterconnectsAsync(DescribeInterconnectsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Returns a list of interconnects owned by the AWS account.</para> <para>If an interconnect ID is provided, it will only return this
        /// particular interconnect.</para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeInterconnects service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectServerException" />
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectClientException" />
		DescribeInterconnectsResponse DescribeInterconnects();
 

        /// <summary>
        /// <para>Returns the list of Direct Connect locations in the current AWS region. These are the locations that may be selected when calling
        /// CreateConnection or CreateInterconnect.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocations service method on
        /// AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the DescribeLocations service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectServerException" />
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectClientException" />
		DescribeLocationsResponse DescribeLocations(DescribeLocationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLocations operation.
        /// <seealso cref="Amazon.DirectConnect.IAmazonDirectConnect.DescribeLocations"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeLocationsResponse> DescribeLocationsAsync(DescribeLocationsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Returns the list of Direct Connect locations in the current AWS region. These are the locations that may be selected when calling
        /// CreateConnection or CreateInterconnect.</para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeLocations service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectServerException" />
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectClientException" />
		DescribeLocationsResponse DescribeLocations();
 

        /// <summary>
        /// <para>Returns a list of virtual private gateways owned by the AWS account.</para> <para>You can create one or more AWS Direct Connect
        /// private virtual interfaces linking to a virtual private gateway. A virtual private gateway can be managed via Amazon Virtual Private Cloud
        /// (VPC) console or the <a href="http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-CreateVpnGateway.html">EC2
        /// CreateVpnGateway</a> action.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVirtualGateways service method on
        /// AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the DescribeVirtualGateways service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectServerException" />
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectClientException" />
		DescribeVirtualGatewaysResponse DescribeVirtualGateways(DescribeVirtualGatewaysRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVirtualGateways operation.
        /// <seealso cref="Amazon.DirectConnect.IAmazonDirectConnect.DescribeVirtualGateways"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVirtualGateways operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeVirtualGatewaysResponse> DescribeVirtualGatewaysAsync(DescribeVirtualGatewaysRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Returns a list of virtual private gateways owned by the AWS account.</para> <para>You can create one or more AWS Direct Connect
        /// private virtual interfaces linking to a virtual private gateway. A virtual private gateway can be managed via Amazon Virtual Private Cloud
        /// (VPC) console or the <a href="http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-CreateVpnGateway.html">EC2
        /// CreateVpnGateway</a> action.</para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeVirtualGateways service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectServerException" />
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectClientException" />
		DescribeVirtualGatewaysResponse DescribeVirtualGateways();
 

        /// <summary>
        /// <para>Displays all virtual interfaces for an AWS account. Virtual interfaces deleted fewer than 15 minutes before DescribeVirtualInterfaces
        /// is called are also returned. If a connection ID is included then only virtual interfaces associated with this connection will be returned.
        /// If a virtual interface ID is included then only a single virtual interface will be returned.</para> <para> A virtual interface (VLAN)
        /// transmits the traffic between the Direct Connect location and the customer.</para> <para>If a connection ID is provided, only virtual
        /// interfaces provisioned on the specified connection will be returned. If a virtual interface ID is provided, only this particular virtual
        /// interface will be returned.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVirtualInterfaces service
        /// method on AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the DescribeVirtualInterfaces service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectServerException" />
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectClientException" />
		DescribeVirtualInterfacesResponse DescribeVirtualInterfaces(DescribeVirtualInterfacesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVirtualInterfaces operation.
        /// <seealso cref="Amazon.DirectConnect.IAmazonDirectConnect.DescribeVirtualInterfaces"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVirtualInterfaces operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeVirtualInterfacesResponse> DescribeVirtualInterfacesAsync(DescribeVirtualInterfacesRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Displays all virtual interfaces for an AWS account. Virtual interfaces deleted fewer than 15 minutes before DescribeVirtualInterfaces
        /// is called are also returned. If a connection ID is included then only virtual interfaces associated with this connection will be returned.
        /// If a virtual interface ID is included then only a single virtual interface will be returned.</para> <para> A virtual interface (VLAN)
        /// transmits the traffic between the Direct Connect location and the customer.</para> <para>If a connection ID is provided, only virtual
        /// interfaces provisioned on the specified connection will be returned. If a virtual interface ID is provided, only this particular virtual
        /// interface will be returned.</para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeVirtualInterfaces service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectServerException" />
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectClientException" />
		DescribeVirtualInterfacesResponse DescribeVirtualInterfaces();
    }
}
