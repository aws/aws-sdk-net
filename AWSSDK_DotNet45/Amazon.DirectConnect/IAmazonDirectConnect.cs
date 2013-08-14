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
    /// <li> Actions: An alphabetical list of all AWS Direct Connect actions.</li>
    /// <li> Data Types: An alphabetical list of all AWS Direct Connect data types.</li>
    /// <li> Common Query Parameters: Parameters that all Query actions can use.</li>
    /// <li> Common Errors: Client and server errors that all actions can return.</li>
    /// 
    /// </ul>
    /// </summary>
	public partial interface IAmazonDirectConnect : IDisposable
    {
 

        /// <summary>
        /// <para>Creates a new network connection between the customer network and a specific AWS Direct Connect location.</para> <para>A connection
        /// links your internal network to an AWS Direct Connect location over a standard 1 gigabit or 10 gigabit Ethernet fiber-optic cable. One end of
        /// the cable is connected to your router, the other to an AWS Direct Connect router. A Direct Connect location provides access to Amazon Web
        /// Services in the region it is associated with. You can establish connections with AWS Direct Connect locations in multiple regions, but a
        /// connection in one region does not provide connectivity to other regions.</para>
        /// </summary>
        /// 
        /// <param name="createConnectionRequest">Container for the necessary parameters to execute the CreateConnection service method on
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
        /// <para> Creates a new private virtual interface. A virtual interface is the VLAN that transports AWS Direct Connect traffic. A private
        /// virtual interface supports sending traffic to a single Virtual Private Cloud (VPC). </para>
        /// </summary>
        /// 
        /// <param name="createPrivateVirtualInterfaceRequest">Container for the necessary parameters to execute the CreatePrivateVirtualInterface
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
        /// <para> Creates a new private virtual interface. A virtual interface is the VLAN that transports AWS Direct Connect traffic. A private
        /// virtual interface supports sending traffic to a single Virtual Private Cloud (VPC). </para>
        /// </summary>
        /// 
        /// <param name="createPrivateVirtualInterfaceRequest">Container for the necessary parameters to execute the CreatePrivateVirtualInterface
        /// service method on AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the CreatePrivateVirtualInterface service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectServerException" />
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectClientException" />
		CreatePrivateVirtualInterfaceResponse CreatePrivateVirtualInterface();
 

        /// <summary>
        /// <para> Creates a new public virtual interface. A virtual interface is the VLAN that transports AWS Direct Connect traffic. A public virtual
        /// interface supports sending traffic to public services of AWS such as Amazon Simple Storage Service (Amazon S3). </para>
        /// </summary>
        /// 
        /// <param name="createPublicVirtualInterfaceRequest">Container for the necessary parameters to execute the CreatePublicVirtualInterface service
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
        /// <para> Creates a new public virtual interface. A virtual interface is the VLAN that transports AWS Direct Connect traffic. A public virtual
        /// interface supports sending traffic to public services of AWS such as Amazon Simple Storage Service (Amazon S3). </para>
        /// </summary>
        /// 
        /// <param name="createPublicVirtualInterfaceRequest">Container for the necessary parameters to execute the CreatePublicVirtualInterface service
        /// method on AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the CreatePublicVirtualInterface service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectServerException" />
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectClientException" />
		CreatePublicVirtualInterfaceResponse CreatePublicVirtualInterface();
 

        /// <summary>
        /// <para>Deletes the connection.</para> <para>Deleting a connection only stops the AWS Direct Connect port hour and data transfer charges. You
        /// separately need to cancel any services or charges for cross-connects or network circuits that connect you to the AWS Direct Connect location
        /// with the providers of those services.</para>
        /// </summary>
        /// 
        /// <param name="deleteConnectionRequest">Container for the necessary parameters to execute the DeleteConnection service method on
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
        /// <para> Deletes a virtual interface. </para>
        /// </summary>
        /// 
        /// <param name="deleteVirtualInterfaceRequest">Container for the necessary parameters to execute the DeleteVirtualInterface service method on
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
        /// <para> Deletes a virtual interface. </para>
        /// </summary>
        /// 
        /// <param name="deleteVirtualInterfaceRequest">Container for the necessary parameters to execute the DeleteVirtualInterface service method on
        /// AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the DeleteVirtualInterface service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectServerException" />
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectClientException" />
		DeleteVirtualInterfaceResponse DeleteVirtualInterface();
 

        /// <summary>
        /// <para>Displays details about a specific connection including the order steps for the connection and the current state of the connection
        /// order.</para>
        /// </summary>
        /// 
        /// <param name="describeConnectionDetailRequest">Container for the necessary parameters to execute the DescribeConnectionDetail service method
        /// on AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the DescribeConnectionDetail service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectServerException" />
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectClientException" />
		DescribeConnectionDetailResponse DescribeConnectionDetail(DescribeConnectionDetailRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConnectionDetail operation.
        /// <seealso cref="Amazon.DirectConnect.IAmazonDirectConnect.DescribeConnectionDetail"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnectionDetail operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeConnectionDetailResponse> DescribeConnectionDetailAsync(DescribeConnectionDetailRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Displays all connections in this region.</para> <para>If a connection ID is provided, it will only return this particular
        /// connection.</para>
        /// </summary>
        /// 
        /// <param name="describeConnectionsRequest">Container for the necessary parameters to execute the DescribeConnections service method on
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
        /// <param name="describeConnectionsRequest">Container for the necessary parameters to execute the DescribeConnections service method on
        /// AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the DescribeConnections service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectServerException" />
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectClientException" />
		DescribeConnectionsResponse DescribeConnections();
 

        /// <summary>
        /// <para>Displays additional ordering step details for a specified offering.</para>
        /// </summary>
        /// 
        /// <param name="describeOfferingDetailRequest">Container for the necessary parameters to execute the DescribeOfferingDetail service method on
        /// AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the DescribeOfferingDetail service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectServerException" />
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectClientException" />
		DescribeOfferingDetailResponse DescribeOfferingDetail(DescribeOfferingDetailRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeOfferingDetail operation.
        /// <seealso cref="Amazon.DirectConnect.IAmazonDirectConnect.DescribeOfferingDetail"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeOfferingDetail operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeOfferingDetailResponse> DescribeOfferingDetailAsync(DescribeOfferingDetailRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Describes one or more of the offerings that are currently available for creating new connections. The results include offerings for
        /// all regions.</para> <para>To order a new connection you need to select a specific offering ID.</para>
        /// </summary>
        /// 
        /// <param name="describeOfferingsRequest">Container for the necessary parameters to execute the DescribeOfferings service method on
        /// AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the DescribeOfferings service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectServerException" />
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectClientException" />
		DescribeOfferingsResponse DescribeOfferings(DescribeOfferingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeOfferings operation.
        /// <seealso cref="Amazon.DirectConnect.IAmazonDirectConnect.DescribeOfferings"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeOfferings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeOfferingsResponse> DescribeOfferingsAsync(DescribeOfferingsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Describes one or more of the offerings that are currently available for creating new connections. The results include offerings for
        /// all regions.</para> <para>To order a new connection you need to select a specific offering ID.</para>
        /// </summary>
        /// 
        /// <param name="describeOfferingsRequest">Container for the necessary parameters to execute the DescribeOfferings service method on
        /// AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the DescribeOfferings service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectServerException" />
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectClientException" />
		DescribeOfferingsResponse DescribeOfferings();
 

        /// <summary>
        /// <para>Returns a list of virtual private gateways owned by the AWS account.</para> <para>You can create one or more AWS Direct Connect
        /// private virtual interfaces linking to a virtual private gateway. A virtual private gateway can be managed via Amazon Virtual Private Cloud
        /// (VPC) console or the EC2 CreateVpnGateway action.</para>
        /// </summary>
        /// 
        /// <param name="describeVirtualGatewaysRequest">Container for the necessary parameters to execute the DescribeVirtualGateways service method on
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
        /// (VPC) console or the EC2 CreateVpnGateway action.</para>
        /// </summary>
        /// 
        /// <param name="describeVirtualGatewaysRequest">Container for the necessary parameters to execute the DescribeVirtualGateways service method on
        /// AmazonDirectConnect.</param>
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
        /// transmits the traffic between the Direct Connect location and the customer.</para>
        /// </summary>
        /// 
        /// <param name="describeVirtualInterfacesRequest">Container for the necessary parameters to execute the DescribeVirtualInterfaces service
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
        /// transmits the traffic between the Direct Connect location and the customer.</para>
        /// </summary>
        /// 
        /// <param name="describeVirtualInterfacesRequest">Container for the necessary parameters to execute the DescribeVirtualInterfaces service
        /// method on AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the DescribeVirtualInterfaces service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectServerException" />
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectClientException" />
		DescribeVirtualInterfacesResponse DescribeVirtualInterfaces();
    }
}
