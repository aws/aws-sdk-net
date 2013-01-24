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

using Amazon.DirectConnect;
using Amazon.DirectConnect.Model;

namespace Amazon.DirectConnect
{
    /// <summary>
    /// Interface for accessing AmazonDirectConnect.
    ///  
    ///  <para>AWS Direct Connect makes it easy to establish a dedicated network connection from your premise to Amazon Web Services. Using AWS
    /// Direct Connect, you can establish private connectivity between AWS and your data center, office, or colocation environment, which in many
    /// cases can reduce your network costs, increase bandwidth throughput, and provide a more consistent network experience than Internet-based
    /// connections.</para> <para>Use the following links to get started using the <i>AWS Direct Connect API Reference</i> :</para>
    /// <ul>
    /// <li> Actions: An alphabetical list of all AWS Direct Connect actions.</li>
    /// <li> Data Types: An alphabetical list of all AWS Direct Connect data types.</li>
    /// <li> Common Parameters: Parameters that all Query actions can use.</li>
    /// <li> Common Errors: Client and server errors that all actions can return.</li>
    /// <li> Regions and Endpoints: Itemized regions and endpoints for all AWS products.</li>
    /// 
    /// </ul>
    /// </summary>
    public interface AmazonDirectConnect : IDisposable
    {
        

        #region DescribeVirtualInterfaces

        /// <summary>
        /// <para>Displays all virtual interfaces for an AWS account. Virtual interfaces deleted for less than 15 minutes are also returned. If virtual
        /// interface ID is included then only a single virtual interface will be returned.</para> <para> A virtual interface (VLAN) transmits the
        /// traffic between the Direct Connect location and the customer.</para>
        /// </summary>
        /// 
        /// <param name="describeVirtualInterfacesRequest">Container for the necessary parameters to execute the DescribeVirtualInterfaces service
        ///          method on AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the DescribeVirtualInterfaces service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="DirectConnectServerException"/>
        /// <exception cref="DirectConnectClientException"/>
        DescribeVirtualInterfacesResponse DescribeVirtualInterfaces(DescribeVirtualInterfacesRequest describeVirtualInterfacesRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVirtualInterfaces operation.
        /// <seealso cref="Amazon.DirectConnect.AmazonDirectConnect.DescribeVirtualInterfaces"/>
        /// </summary>
        /// 
        /// <param name="describeVirtualInterfacesRequest">Container for the necessary parameters to execute the DescribeVirtualInterfaces operation on
        ///          AmazonDirectConnect.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeVirtualInterfaces operation.</returns>
        IAsyncResult BeginDescribeVirtualInterfaces(DescribeVirtualInterfacesRequest describeVirtualInterfacesRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeVirtualInterfaces operation.
        /// <seealso cref="Amazon.DirectConnect.AmazonDirectConnect.DescribeVirtualInterfaces"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVirtualInterfaces.</param>
        /// 
        /// <returns>Returns a DescribeVirtualInterfacesResult from AmazonDirectConnect.</returns>
        DescribeVirtualInterfacesResponse EndDescribeVirtualInterfaces(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Displays all virtual interfaces for an AWS account. Virtual interfaces deleted for less than 15 minutes are also returned. If virtual
        /// interface ID is included then only a single virtual interface will be returned.</para> <para> A virtual interface (VLAN) transmits the
        /// traffic between the Direct Connect location and the customer.</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeVirtualInterfaces service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="DirectConnectServerException"/>
        /// <exception cref="DirectConnectClientException"/>
        DescribeVirtualInterfacesResponse DescribeVirtualInterfaces();
        
        #endregion
        
    

        #region DescribeVirtualGateways

        /// <summary>
        /// <para>Returns a list of virtual private gateways owned by the AWS account.</para> <para>You can create one or more Direct Connect private
        /// virtual interfaces linking to a virtual private gateway. Virtual private gateway can be managed via AWS Virtual Private Cloud Console or the
        /// EC2 CreateVpnGateway API.</para>
        /// </summary>
        /// 
        /// <param name="describeVirtualGatewaysRequest">Container for the necessary parameters to execute the DescribeVirtualGateways service method on
        ///          AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the DescribeVirtualGateways service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="DirectConnectServerException"/>
        /// <exception cref="DirectConnectClientException"/>
        DescribeVirtualGatewaysResponse DescribeVirtualGateways(DescribeVirtualGatewaysRequest describeVirtualGatewaysRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVirtualGateways operation.
        /// <seealso cref="Amazon.DirectConnect.AmazonDirectConnect.DescribeVirtualGateways"/>
        /// </summary>
        /// 
        /// <param name="describeVirtualGatewaysRequest">Container for the necessary parameters to execute the DescribeVirtualGateways operation on
        ///          AmazonDirectConnect.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeVirtualGateways operation.</returns>
        IAsyncResult BeginDescribeVirtualGateways(DescribeVirtualGatewaysRequest describeVirtualGatewaysRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeVirtualGateways operation.
        /// <seealso cref="Amazon.DirectConnect.AmazonDirectConnect.DescribeVirtualGateways"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVirtualGateways.</param>
        /// 
        /// <returns>Returns a DescribeVirtualGatewaysResult from AmazonDirectConnect.</returns>
        DescribeVirtualGatewaysResponse EndDescribeVirtualGateways(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Returns a list of virtual private gateways owned by the AWS account.</para> <para>You can create one or more Direct Connect private
        /// virtual interfaces linking to a virtual private gateway. Virtual private gateway can be managed via AWS Virtual Private Cloud Console or the
        /// EC2 CreateVpnGateway API.</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeVirtualGateways service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="DirectConnectServerException"/>
        /// <exception cref="DirectConnectClientException"/>
        DescribeVirtualGatewaysResponse DescribeVirtualGateways();
        
        #endregion
        
    

        #region DescribeConnectionDetail

        /// <summary>
        /// <para>Displays details about a specific Connection including the order steps for the connection and the current state of the connection
        /// order.</para>
        /// </summary>
        /// 
        /// <param name="describeConnectionDetailRequest">Container for the necessary parameters to execute the DescribeConnectionDetail service method
        ///          on AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the DescribeConnectionDetail service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="DirectConnectServerException"/>
        /// <exception cref="DirectConnectClientException"/>
        DescribeConnectionDetailResponse DescribeConnectionDetail(DescribeConnectionDetailRequest describeConnectionDetailRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConnectionDetail operation.
        /// <seealso cref="Amazon.DirectConnect.AmazonDirectConnect.DescribeConnectionDetail"/>
        /// </summary>
        /// 
        /// <param name="describeConnectionDetailRequest">Container for the necessary parameters to execute the DescribeConnectionDetail operation on
        ///          AmazonDirectConnect.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeConnectionDetail operation.</returns>
        IAsyncResult BeginDescribeConnectionDetail(DescribeConnectionDetailRequest describeConnectionDetailRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeConnectionDetail operation.
        /// <seealso cref="Amazon.DirectConnect.AmazonDirectConnect.DescribeConnectionDetail"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeConnectionDetail.</param>
        /// 
        /// <returns>Returns a DescribeConnectionDetailResult from AmazonDirectConnect.</returns>
        DescribeConnectionDetailResponse EndDescribeConnectionDetail(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DescribeOfferings

        /// <summary>
        /// <para>Describes one or more of the Offerings that are currently available for creating new Connections. The results include offerings for
        /// all regions.</para> <para>To order a new Connection you will need to select a specific Offering ID.</para>
        /// </summary>
        /// 
        /// <param name="describeOfferingsRequest">Container for the necessary parameters to execute the DescribeOfferings service method on
        ///          AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the DescribeOfferings service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="DirectConnectServerException"/>
        /// <exception cref="DirectConnectClientException"/>
        DescribeOfferingsResponse DescribeOfferings(DescribeOfferingsRequest describeOfferingsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeOfferings operation.
        /// <seealso cref="Amazon.DirectConnect.AmazonDirectConnect.DescribeOfferings"/>
        /// </summary>
        /// 
        /// <param name="describeOfferingsRequest">Container for the necessary parameters to execute the DescribeOfferings operation on
        ///          AmazonDirectConnect.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeOfferings
        ///         operation.</returns>
        IAsyncResult BeginDescribeOfferings(DescribeOfferingsRequest describeOfferingsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeOfferings operation.
        /// <seealso cref="Amazon.DirectConnect.AmazonDirectConnect.DescribeOfferings"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeOfferings.</param>
        /// 
        /// <returns>Returns a DescribeOfferingsResult from AmazonDirectConnect.</returns>
        DescribeOfferingsResponse EndDescribeOfferings(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Describes one or more of the Offerings that are currently available for creating new Connections. The results include offerings for
        /// all regions.</para> <para>To order a new Connection you will need to select a specific Offering ID.</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeOfferings service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="DirectConnectServerException"/>
        /// <exception cref="DirectConnectClientException"/>
        DescribeOfferingsResponse DescribeOfferings();
        
        #endregion
        
    

        #region DescribeConnections

        /// <summary>
        /// <para>Displays all connections in this region.</para> <para>If a connection ID is provided, it will only return this particular
        /// connection.</para>
        /// </summary>
        /// 
        /// <param name="describeConnectionsRequest">Container for the necessary parameters to execute the DescribeConnections service method on
        ///          AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the DescribeConnections service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="DirectConnectServerException"/>
        /// <exception cref="DirectConnectClientException"/>
        DescribeConnectionsResponse DescribeConnections(DescribeConnectionsRequest describeConnectionsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConnections operation.
        /// <seealso cref="Amazon.DirectConnect.AmazonDirectConnect.DescribeConnections"/>
        /// </summary>
        /// 
        /// <param name="describeConnectionsRequest">Container for the necessary parameters to execute the DescribeConnections operation on
        ///          AmazonDirectConnect.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeConnections operation.</returns>
        IAsyncResult BeginDescribeConnections(DescribeConnectionsRequest describeConnectionsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeConnections operation.
        /// <seealso cref="Amazon.DirectConnect.AmazonDirectConnect.DescribeConnections"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeConnections.</param>
        /// 
        /// <returns>Returns a DescribeConnectionsResult from AmazonDirectConnect.</returns>
        DescribeConnectionsResponse EndDescribeConnections(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Displays all connections in this region.</para> <para>If a connection ID is provided, it will only return this particular
        /// connection.</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeConnections service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="DirectConnectServerException"/>
        /// <exception cref="DirectConnectClientException"/>
        DescribeConnectionsResponse DescribeConnections();
        
        #endregion
        
    

        #region DescribeOfferingDetail

        /// <summary>
        /// <para>Displays additional ordering step details for a specified Offering.</para>
        /// </summary>
        /// 
        /// <param name="describeOfferingDetailRequest">Container for the necessary parameters to execute the DescribeOfferingDetail service method on
        ///          AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the DescribeOfferingDetail service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="DirectConnectServerException"/>
        /// <exception cref="DirectConnectClientException"/>
        DescribeOfferingDetailResponse DescribeOfferingDetail(DescribeOfferingDetailRequest describeOfferingDetailRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeOfferingDetail operation.
        /// <seealso cref="Amazon.DirectConnect.AmazonDirectConnect.DescribeOfferingDetail"/>
        /// </summary>
        /// 
        /// <param name="describeOfferingDetailRequest">Container for the necessary parameters to execute the DescribeOfferingDetail operation on
        ///          AmazonDirectConnect.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeOfferingDetail operation.</returns>
        IAsyncResult BeginDescribeOfferingDetail(DescribeOfferingDetailRequest describeOfferingDetailRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeOfferingDetail operation.
        /// <seealso cref="Amazon.DirectConnect.AmazonDirectConnect.DescribeOfferingDetail"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeOfferingDetail.</param>
        /// 
        /// <returns>Returns a DescribeOfferingDetailResult from AmazonDirectConnect.</returns>
        DescribeOfferingDetailResponse EndDescribeOfferingDetail(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeleteConnection

        /// <summary>
        /// <para>Deletes the Connection.</para> <para>Deleting a connection only stops the AWS Direct Connect Port and Data Transfer charges. You
        /// separately need to cancel any services or charges for cross-connects or network circuits that connect you to the AWS Direct Connect location
        /// with those providers.</para>
        /// </summary>
        /// 
        /// <param name="deleteConnectionRequest">Container for the necessary parameters to execute the DeleteConnection service method on
        ///          AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the DeleteConnection service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="DirectConnectServerException"/>
        /// <exception cref="DirectConnectClientException"/>
        DeleteConnectionResponse DeleteConnection(DeleteConnectionRequest deleteConnectionRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConnection operation.
        /// <seealso cref="Amazon.DirectConnect.AmazonDirectConnect.DeleteConnection"/>
        /// </summary>
        /// 
        /// <param name="deleteConnectionRequest">Container for the necessary parameters to execute the DeleteConnection operation on
        ///          AmazonDirectConnect.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteConnection
        ///         operation.</returns>
        IAsyncResult BeginDeleteConnection(DeleteConnectionRequest deleteConnectionRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteConnection operation.
        /// <seealso cref="Amazon.DirectConnect.AmazonDirectConnect.DeleteConnection"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConnection.</param>
        /// 
        /// <returns>Returns a DeleteConnectionResult from AmazonDirectConnect.</returns>
        DeleteConnectionResponse EndDeleteConnection(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CreateConnection

        /// <summary>
        /// <para>Creates a new network connection between the customer network and a specific AWS Direct Connect location.</para> <para>A connection
        /// links your internal network to an AWS Direct Connect location over a standard 1 gigabit or 10 gigabit Ethernet fiber-optic cable. One end of
        /// the cable is connected to your router, the other to an AWS Direct Connect router. A Direct Connect location provides access to Amazon Web
        /// Services in the region it is associated with. You can establish connections with AWS Direct Connect locations in multiple regions, but a
        /// connection in one region does not provide connectivity to other regions.</para>
        /// </summary>
        /// 
        /// <param name="createConnectionRequest">Container for the necessary parameters to execute the CreateConnection service method on
        ///          AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the CreateConnection service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="DirectConnectServerException"/>
        /// <exception cref="DirectConnectClientException"/>
        CreateConnectionResponse CreateConnection(CreateConnectionRequest createConnectionRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateConnection operation.
        /// <seealso cref="Amazon.DirectConnect.AmazonDirectConnect.CreateConnection"/>
        /// </summary>
        /// 
        /// <param name="createConnectionRequest">Container for the necessary parameters to execute the CreateConnection operation on
        ///          AmazonDirectConnect.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateConnection
        ///         operation.</returns>
        IAsyncResult BeginCreateConnection(CreateConnectionRequest createConnectionRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreateConnection operation.
        /// <seealso cref="Amazon.DirectConnect.AmazonDirectConnect.CreateConnection"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateConnection.</param>
        /// 
        /// <returns>Returns a CreateConnectionResult from AmazonDirectConnect.</returns>
        CreateConnectionResponse EndCreateConnection(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CreatePrivateVirtualInterface

        /// <summary>
        /// <para> Creates a new private virtual interface. A virtual interface is the VLAN that transports Direct Connect traffic. A private virtual
        /// interface supports sending traffic to a single VPC. </para>
        /// </summary>
        /// 
        /// <param name="createPrivateVirtualInterfaceRequest">Container for the necessary parameters to execute the CreatePrivateVirtualInterface
        ///          service method on AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the CreatePrivateVirtualInterface service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="DirectConnectServerException"/>
        /// <exception cref="DirectConnectClientException"/>
        CreatePrivateVirtualInterfaceResponse CreatePrivateVirtualInterface(CreatePrivateVirtualInterfaceRequest createPrivateVirtualInterfaceRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePrivateVirtualInterface operation.
        /// <seealso cref="Amazon.DirectConnect.AmazonDirectConnect.CreatePrivateVirtualInterface"/>
        /// </summary>
        /// 
        /// <param name="createPrivateVirtualInterfaceRequest">Container for the necessary parameters to execute the CreatePrivateVirtualInterface
        ///          operation on AmazonDirectConnect.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreatePrivateVirtualInterface operation.</returns>
        IAsyncResult BeginCreatePrivateVirtualInterface(CreatePrivateVirtualInterfaceRequest createPrivateVirtualInterfaceRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreatePrivateVirtualInterface operation.
        /// <seealso cref="Amazon.DirectConnect.AmazonDirectConnect.CreatePrivateVirtualInterface"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePrivateVirtualInterface.</param>
        /// 
        /// <returns>Returns a CreatePrivateVirtualInterfaceResult from AmazonDirectConnect.</returns>
        CreatePrivateVirtualInterfaceResponse EndCreatePrivateVirtualInterface(IAsyncResult asyncResult);

        /// <summary>
        /// <para> Creates a new private virtual interface. A virtual interface is the VLAN that transports Direct Connect traffic. A private virtual
        /// interface supports sending traffic to a single VPC. </para>
        /// </summary>
        /// 
        /// <returns>The response from the CreatePrivateVirtualInterface service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="DirectConnectServerException"/>
        /// <exception cref="DirectConnectClientException"/>
        CreatePrivateVirtualInterfaceResponse CreatePrivateVirtualInterface();
        
        #endregion
        
    

        #region DeleteVirtualInterface

        /// <summary>
        /// <para> Deletes a virtual interface. </para>
        /// </summary>
        /// 
        /// <param name="deleteVirtualInterfaceRequest">Container for the necessary parameters to execute the DeleteVirtualInterface service method on
        ///          AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the DeleteVirtualInterface service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="DirectConnectServerException"/>
        /// <exception cref="DirectConnectClientException"/>
        DeleteVirtualInterfaceResponse DeleteVirtualInterface(DeleteVirtualInterfaceRequest deleteVirtualInterfaceRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVirtualInterface operation.
        /// <seealso cref="Amazon.DirectConnect.AmazonDirectConnect.DeleteVirtualInterface"/>
        /// </summary>
        /// 
        /// <param name="deleteVirtualInterfaceRequest">Container for the necessary parameters to execute the DeleteVirtualInterface operation on
        ///          AmazonDirectConnect.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDeleteVirtualInterface operation.</returns>
        IAsyncResult BeginDeleteVirtualInterface(DeleteVirtualInterfaceRequest deleteVirtualInterfaceRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteVirtualInterface operation.
        /// <seealso cref="Amazon.DirectConnect.AmazonDirectConnect.DeleteVirtualInterface"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVirtualInterface.</param>
        /// 
        /// <returns>Returns a DeleteVirtualInterfaceResult from AmazonDirectConnect.</returns>
        DeleteVirtualInterfaceResponse EndDeleteVirtualInterface(IAsyncResult asyncResult);

        /// <summary>
        /// <para> Deletes a virtual interface. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DeleteVirtualInterface service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="DirectConnectServerException"/>
        /// <exception cref="DirectConnectClientException"/>
        DeleteVirtualInterfaceResponse DeleteVirtualInterface();
        
        #endregion
        
    

        #region CreatePublicVirtualInterface

        /// <summary>
        /// <para> Creates a new public virtual interface. A virtual interface is the VLAN that transports Direct Connect traffic. A public virtual
        /// interface supports sending traffic to public AWS services such as S3. </para>
        /// </summary>
        /// 
        /// <param name="createPublicVirtualInterfaceRequest">Container for the necessary parameters to execute the CreatePublicVirtualInterface service
        ///          method on AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the CreatePublicVirtualInterface service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="DirectConnectServerException"/>
        /// <exception cref="DirectConnectClientException"/>
        CreatePublicVirtualInterfaceResponse CreatePublicVirtualInterface(CreatePublicVirtualInterfaceRequest createPublicVirtualInterfaceRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePublicVirtualInterface operation.
        /// <seealso cref="Amazon.DirectConnect.AmazonDirectConnect.CreatePublicVirtualInterface"/>
        /// </summary>
        /// 
        /// <param name="createPublicVirtualInterfaceRequest">Container for the necessary parameters to execute the CreatePublicVirtualInterface
        ///          operation on AmazonDirectConnect.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreatePublicVirtualInterface operation.</returns>
        IAsyncResult BeginCreatePublicVirtualInterface(CreatePublicVirtualInterfaceRequest createPublicVirtualInterfaceRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreatePublicVirtualInterface operation.
        /// <seealso cref="Amazon.DirectConnect.AmazonDirectConnect.CreatePublicVirtualInterface"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePublicVirtualInterface.</param>
        /// 
        /// <returns>Returns a CreatePublicVirtualInterfaceResult from AmazonDirectConnect.</returns>
        CreatePublicVirtualInterfaceResponse EndCreatePublicVirtualInterface(IAsyncResult asyncResult);

        /// <summary>
        /// <para> Creates a new public virtual interface. A virtual interface is the VLAN that transports Direct Connect traffic. A public virtual
        /// interface supports sending traffic to public AWS services such as S3. </para>
        /// </summary>
        /// 
        /// <returns>The response from the CreatePublicVirtualInterface service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="DirectConnectServerException"/>
        /// <exception cref="DirectConnectClientException"/>
        CreatePublicVirtualInterfaceResponse CreatePublicVirtualInterface();
        
        #endregion
        
    
    }
}
    
