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
    ///  <para>AWS Direct Connect makes it easy to establish a dedicated network connection from your premises to Amazon Web Services (AWS). Using
    /// AWS Direct Connect, you can establish private connectivity between AWS and your data center, office, or colocation environment, which in
    /// many cases can reduce your network costs, increase bandwidth throughput, and provide a more consistent network experience than
    /// Internet-based connections.</para> <para>The AWS Direct Connect API Reference provides descriptions, syntax, and usage examples for each of
    /// the actions and data types for AWS Direct Connect. Use the following links to get started using the <i>AWS Direct Connect API Reference</i>
    /// :</para>
    /// <ul>
    /// <li> <a href="http://docs.aws.amazon.com/directconnect/latest/APIReference/API_Operations.html" >Actions</a> : An alphabetical list of all
    /// AWS Direct Connect actions.</li>
    /// <li> <a href="http://docs.aws.amazon.com/directconnect/latest/APIReference/API_Types.html" >Data Types</a> : An alphabetical list of all
    /// AWS Direct Connect data types.</li>
    /// <li> <a href="http://docs.aws.amazon.com/directconnect/latest/APIReference/CommonParameters.html" >Common Query Parameters</a> : Parameters
    /// that all Query actions can use.</li>
    /// <li> <a href="http://docs.aws.amazon.com/directconnect/latest/APIReference/CommonErrors.html" >Common Errors</a> : Client and server errors
    /// that all actions can return.</li>
    /// 
    /// </ul>
    /// </summary>
    public interface IAmazonDirectConnect : IDisposable
    {


        #region AllocateConnectionOnInterconnect

        /// <summary>
        /// <para>Creates a hosted connection on an interconnect.</para> <para>Allocates a VLAN number and a specified amount of bandwidth for use by a
        /// hosted connection on the given interconnect.</para>
        /// </summary>
        /// 
        /// <param name="allocateConnectionOnInterconnectRequest">Container for the necessary parameters to execute the AllocateConnectionOnInterconnect
        ///          service method on AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the AllocateConnectionOnInterconnect service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="DirectConnectServerException"/>
        /// <exception cref="DirectConnectClientException"/>
        AllocateConnectionOnInterconnectResponse AllocateConnectionOnInterconnect(AllocateConnectionOnInterconnectRequest allocateConnectionOnInterconnectRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the AllocateConnectionOnInterconnect operation.
        /// <seealso cref="Amazon.DirectConnect.IAmazonDirectConnect.AllocateConnectionOnInterconnect"/>
        /// </summary>
        /// 
        /// <param name="allocateConnectionOnInterconnectRequest">Container for the necessary parameters to execute the AllocateConnectionOnInterconnect
        ///          operation on AmazonDirectConnect.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndAllocateConnectionOnInterconnect operation.</returns>
        IAsyncResult BeginAllocateConnectionOnInterconnect(AllocateConnectionOnInterconnectRequest allocateConnectionOnInterconnectRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the AllocateConnectionOnInterconnect operation.
        /// <seealso cref="Amazon.DirectConnect.IAmazonDirectConnect.AllocateConnectionOnInterconnect"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAllocateConnectionOnInterconnect.</param>
        /// 
        /// <returns>Returns a AllocateConnectionOnInterconnectResult from AmazonDirectConnect.</returns>
        AllocateConnectionOnInterconnectResponse EndAllocateConnectionOnInterconnect(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region AllocatePrivateVirtualInterface

        /// <summary>
        /// <para>Provisions a private virtual interface to be owned by a different customer.</para> <para>The owner of a connection calls this function
        /// to provision a private virtual interface which will be owned by another AWS customer.</para> <para>Virtual interfaces created using this
        /// function must be confirmed by the virtual interface owner by calling ConfirmPrivateVirtualInterface. Until this step has been completed,
        /// the virtual interface will be in 'Confirming' state, and will not be available for handling traffic.</para>
        /// </summary>
        /// 
        /// <param name="allocatePrivateVirtualInterfaceRequest">Container for the necessary parameters to execute the AllocatePrivateVirtualInterface
        ///          service method on AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the AllocatePrivateVirtualInterface service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="DirectConnectServerException"/>
        /// <exception cref="DirectConnectClientException"/>
        AllocatePrivateVirtualInterfaceResponse AllocatePrivateVirtualInterface(AllocatePrivateVirtualInterfaceRequest allocatePrivateVirtualInterfaceRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the AllocatePrivateVirtualInterface operation.
        /// <seealso cref="Amazon.DirectConnect.IAmazonDirectConnect.AllocatePrivateVirtualInterface"/>
        /// </summary>
        /// 
        /// <param name="allocatePrivateVirtualInterfaceRequest">Container for the necessary parameters to execute the AllocatePrivateVirtualInterface
        ///          operation on AmazonDirectConnect.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndAllocatePrivateVirtualInterface operation.</returns>
        IAsyncResult BeginAllocatePrivateVirtualInterface(AllocatePrivateVirtualInterfaceRequest allocatePrivateVirtualInterfaceRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the AllocatePrivateVirtualInterface operation.
        /// <seealso cref="Amazon.DirectConnect.IAmazonDirectConnect.AllocatePrivateVirtualInterface"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAllocatePrivateVirtualInterface.</param>
        /// 
        /// <returns>Returns a AllocatePrivateVirtualInterfaceResult from AmazonDirectConnect.</returns>
        AllocatePrivateVirtualInterfaceResponse EndAllocatePrivateVirtualInterface(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region AllocatePublicVirtualInterface

        /// <summary>
        /// <para>Provisions a public virtual interface to be owned by a different customer.</para> <para>The owner of a connection calls this function
        /// to provision a public virtual interface which will be owned by another AWS customer.</para> <para>Virtual interfaces created using this
        /// function must be confirmed by the virtual interface owner by calling ConfirmPublicVirtualInterface. Until this step has been completed, the
        /// virtual interface will be in 'Confirming' state, and will not be available for handling traffic.</para>
        /// </summary>
        /// 
        /// <param name="allocatePublicVirtualInterfaceRequest">Container for the necessary parameters to execute the AllocatePublicVirtualInterface
        ///          service method on AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the AllocatePublicVirtualInterface service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="DirectConnectServerException"/>
        /// <exception cref="DirectConnectClientException"/>
        AllocatePublicVirtualInterfaceResponse AllocatePublicVirtualInterface(AllocatePublicVirtualInterfaceRequest allocatePublicVirtualInterfaceRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the AllocatePublicVirtualInterface operation.
        /// <seealso cref="Amazon.DirectConnect.IAmazonDirectConnect.AllocatePublicVirtualInterface"/>
        /// </summary>
        /// 
        /// <param name="allocatePublicVirtualInterfaceRequest">Container for the necessary parameters to execute the AllocatePublicVirtualInterface
        ///          operation on AmazonDirectConnect.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndAllocatePublicVirtualInterface operation.</returns>
        IAsyncResult BeginAllocatePublicVirtualInterface(AllocatePublicVirtualInterfaceRequest allocatePublicVirtualInterfaceRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the AllocatePublicVirtualInterface operation.
        /// <seealso cref="Amazon.DirectConnect.IAmazonDirectConnect.AllocatePublicVirtualInterface"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAllocatePublicVirtualInterface.</param>
        /// 
        /// <returns>Returns a AllocatePublicVirtualInterfaceResult from AmazonDirectConnect.</returns>
        AllocatePublicVirtualInterfaceResponse EndAllocatePublicVirtualInterface(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region ConfirmConnection

        /// <summary>
        /// <para>Confirm the creation of a hosted connection on an interconnect.</para> <para>Upon creation, the hosted connection is initially in the
        /// 'Ordering' state, and will remain in this state until the owner calls ConfirmConnection to confirm creation of the hosted connection.</para>
        /// </summary>
        /// 
        /// <param name="confirmConnectionRequest">Container for the necessary parameters to execute the ConfirmConnection service method on
        ///          AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the ConfirmConnection service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="DirectConnectServerException"/>
        /// <exception cref="DirectConnectClientException"/>
        ConfirmConnectionResponse ConfirmConnection(ConfirmConnectionRequest confirmConnectionRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ConfirmConnection operation.
        /// <seealso cref="Amazon.DirectConnect.IAmazonDirectConnect.ConfirmConnection"/>
        /// </summary>
        /// 
        /// <param name="confirmConnectionRequest">Container for the necessary parameters to execute the ConfirmConnection operation on
        ///          AmazonDirectConnect.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndConfirmConnection
        ///         operation.</returns>
        IAsyncResult BeginConfirmConnection(ConfirmConnectionRequest confirmConnectionRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ConfirmConnection operation.
        /// <seealso cref="Amazon.DirectConnect.IAmazonDirectConnect.ConfirmConnection"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginConfirmConnection.</param>
        /// 
        /// <returns>Returns a ConfirmConnectionResult from AmazonDirectConnect.</returns>
        ConfirmConnectionResponse EndConfirmConnection(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region ConfirmPrivateVirtualInterface

        /// <summary>
        /// <para>Accept ownership of a private virtual interface created by another customer.</para> <para>After the virtual interface owner calls this
        /// function, the virtual interface will be created and attached to the given virtual private gateway, and will be available for handling
        /// traffic.</para>
        /// </summary>
        /// 
        /// <param name="confirmPrivateVirtualInterfaceRequest">Container for the necessary parameters to execute the ConfirmPrivateVirtualInterface
        ///          service method on AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the ConfirmPrivateVirtualInterface service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="DirectConnectServerException"/>
        /// <exception cref="DirectConnectClientException"/>
        ConfirmPrivateVirtualInterfaceResponse ConfirmPrivateVirtualInterface(ConfirmPrivateVirtualInterfaceRequest confirmPrivateVirtualInterfaceRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ConfirmPrivateVirtualInterface operation.
        /// <seealso cref="Amazon.DirectConnect.IAmazonDirectConnect.ConfirmPrivateVirtualInterface"/>
        /// </summary>
        /// 
        /// <param name="confirmPrivateVirtualInterfaceRequest">Container for the necessary parameters to execute the ConfirmPrivateVirtualInterface
        ///          operation on AmazonDirectConnect.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndConfirmPrivateVirtualInterface operation.</returns>
        IAsyncResult BeginConfirmPrivateVirtualInterface(ConfirmPrivateVirtualInterfaceRequest confirmPrivateVirtualInterfaceRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ConfirmPrivateVirtualInterface operation.
        /// <seealso cref="Amazon.DirectConnect.IAmazonDirectConnect.ConfirmPrivateVirtualInterface"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginConfirmPrivateVirtualInterface.</param>
        /// 
        /// <returns>Returns a ConfirmPrivateVirtualInterfaceResult from AmazonDirectConnect.</returns>
        ConfirmPrivateVirtualInterfaceResponse EndConfirmPrivateVirtualInterface(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region ConfirmPublicVirtualInterface

        /// <summary>
        /// <para>Accept ownership of a public virtual interface created by another customer.</para> <para>After the virtual interface owner calls this
        /// function, the specified virtual interface will be created and made available for handling traffic.</para>
        /// </summary>
        /// 
        /// <param name="confirmPublicVirtualInterfaceRequest">Container for the necessary parameters to execute the ConfirmPublicVirtualInterface
        ///          service method on AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the ConfirmPublicVirtualInterface service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="DirectConnectServerException"/>
        /// <exception cref="DirectConnectClientException"/>
        ConfirmPublicVirtualInterfaceResponse ConfirmPublicVirtualInterface(ConfirmPublicVirtualInterfaceRequest confirmPublicVirtualInterfaceRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ConfirmPublicVirtualInterface operation.
        /// <seealso cref="Amazon.DirectConnect.IAmazonDirectConnect.ConfirmPublicVirtualInterface"/>
        /// </summary>
        /// 
        /// <param name="confirmPublicVirtualInterfaceRequest">Container for the necessary parameters to execute the ConfirmPublicVirtualInterface
        ///          operation on AmazonDirectConnect.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndConfirmPublicVirtualInterface operation.</returns>
        IAsyncResult BeginConfirmPublicVirtualInterface(ConfirmPublicVirtualInterfaceRequest confirmPublicVirtualInterfaceRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ConfirmPublicVirtualInterface operation.
        /// <seealso cref="Amazon.DirectConnect.IAmazonDirectConnect.ConfirmPublicVirtualInterface"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginConfirmPublicVirtualInterface.</param>
        /// 
        /// <returns>Returns a ConfirmPublicVirtualInterfaceResult from AmazonDirectConnect.</returns>
        ConfirmPublicVirtualInterfaceResponse EndConfirmPublicVirtualInterface(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CreateConnection

        /// <summary>
        /// <para>Creates a new connection between the customer network and a specific AWS Direct Connect location.</para> <para>A connection links your
        /// internal network to an AWS Direct Connect location over a standard 1 gigabit or 10 gigabit Ethernet fiber-optic cable. One end of the cable
        /// is connected to your router, the other to an AWS Direct Connect router. A Direct Connect location provides access to Amazon Web Services in
        /// the region it is associated with. You can establish connections with AWS Direct Connect locations in multiple regions, but a connection in
        /// one region does not provide connectivity to other regions.</para>
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
        /// <seealso cref="Amazon.DirectConnect.IAmazonDirectConnect.CreateConnection"/>
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
        /// <seealso cref="Amazon.DirectConnect.IAmazonDirectConnect.CreateConnection"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateConnection.</param>
        /// 
        /// <returns>Returns a CreateConnectionResult from AmazonDirectConnect.</returns>
        CreateConnectionResponse EndCreateConnection(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CreateInterconnect

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
        /// <param name="createInterconnectRequest">Container for the necessary parameters to execute the CreateInterconnect service method on
        ///          AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the CreateInterconnect service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="DirectConnectServerException"/>
        /// <exception cref="DirectConnectClientException"/>
        CreateInterconnectResponse CreateInterconnect(CreateInterconnectRequest createInterconnectRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateInterconnect operation.
        /// <seealso cref="Amazon.DirectConnect.IAmazonDirectConnect.CreateInterconnect"/>
        /// </summary>
        /// 
        /// <param name="createInterconnectRequest">Container for the necessary parameters to execute the CreateInterconnect operation on
        ///          AmazonDirectConnect.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreateInterconnect operation.</returns>
        IAsyncResult BeginCreateInterconnect(CreateInterconnectRequest createInterconnectRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreateInterconnect operation.
        /// <seealso cref="Amazon.DirectConnect.IAmazonDirectConnect.CreateInterconnect"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateInterconnect.</param>
        /// 
        /// <returns>Returns a CreateInterconnectResult from AmazonDirectConnect.</returns>
        CreateInterconnectResponse EndCreateInterconnect(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CreatePrivateVirtualInterface

        /// <summary>
        /// <para>Creates a new private virtual interface. A virtual interface is the VLAN that transports AWS Direct Connect traffic. A private
        /// virtual interface supports sending traffic to a single Virtual Private Cloud (VPC).</para>
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
        /// <seealso cref="Amazon.DirectConnect.IAmazonDirectConnect.CreatePrivateVirtualInterface"/>
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
        /// <seealso cref="Amazon.DirectConnect.IAmazonDirectConnect.CreatePrivateVirtualInterface"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePrivateVirtualInterface.</param>
        /// 
        /// <returns>Returns a CreatePrivateVirtualInterfaceResult from AmazonDirectConnect.</returns>
        CreatePrivateVirtualInterfaceResponse EndCreatePrivateVirtualInterface(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CreatePublicVirtualInterface

        /// <summary>
        /// <para>Creates a new public virtual interface. A virtual interface is the VLAN that transports AWS Direct Connect traffic. A public virtual
        /// interface supports sending traffic to public services of AWS such as Amazon Simple Storage Service (Amazon S3).</para>
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
        /// <seealso cref="Amazon.DirectConnect.IAmazonDirectConnect.CreatePublicVirtualInterface"/>
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
        /// <seealso cref="Amazon.DirectConnect.IAmazonDirectConnect.CreatePublicVirtualInterface"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePublicVirtualInterface.</param>
        /// 
        /// <returns>Returns a CreatePublicVirtualInterfaceResult from AmazonDirectConnect.</returns>
        CreatePublicVirtualInterfaceResponse EndCreatePublicVirtualInterface(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeleteConnection

        /// <summary>
        /// <para>Deletes the connection.</para> <para>Deleting a connection only stops the AWS Direct Connect port hour and data transfer charges. You
        /// separately need to cancel any services or charges for cross-connects or network circuits that connect you to the AWS Direct Connect location
        /// with the providers of those services.</para>
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
        /// <seealso cref="Amazon.DirectConnect.IAmazonDirectConnect.DeleteConnection"/>
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
        /// <seealso cref="Amazon.DirectConnect.IAmazonDirectConnect.DeleteConnection"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConnection.</param>
        /// 
        /// <returns>Returns a DeleteConnectionResult from AmazonDirectConnect.</returns>
        DeleteConnectionResponse EndDeleteConnection(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeleteInterconnect

        /// <summary>
        /// <para>Deletes the specified interconnect.</para>
        /// </summary>
        /// 
        /// <param name="deleteInterconnectRequest">Container for the necessary parameters to execute the DeleteInterconnect service method on
        ///          AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the DeleteInterconnect service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="DirectConnectServerException"/>
        /// <exception cref="DirectConnectClientException"/>
        DeleteInterconnectResponse DeleteInterconnect(DeleteInterconnectRequest deleteInterconnectRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInterconnect operation.
        /// <seealso cref="Amazon.DirectConnect.IAmazonDirectConnect.DeleteInterconnect"/>
        /// </summary>
        /// 
        /// <param name="deleteInterconnectRequest">Container for the necessary parameters to execute the DeleteInterconnect operation on
        ///          AmazonDirectConnect.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDeleteInterconnect operation.</returns>
        IAsyncResult BeginDeleteInterconnect(DeleteInterconnectRequest deleteInterconnectRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteInterconnect operation.
        /// <seealso cref="Amazon.DirectConnect.IAmazonDirectConnect.DeleteInterconnect"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteInterconnect.</param>
        /// 
        /// <returns>Returns a DeleteInterconnectResult from AmazonDirectConnect.</returns>
        DeleteInterconnectResponse EndDeleteInterconnect(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeleteVirtualInterface

        /// <summary>
        /// <para>Deletes a virtual interface.</para>
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
        /// <seealso cref="Amazon.DirectConnect.IAmazonDirectConnect.DeleteVirtualInterface"/>
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
        /// <seealso cref="Amazon.DirectConnect.IAmazonDirectConnect.DeleteVirtualInterface"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVirtualInterface.</param>
        /// 
        /// <returns>Returns a DeleteVirtualInterfaceResult from AmazonDirectConnect.</returns>
        DeleteVirtualInterfaceResponse EndDeleteVirtualInterface(IAsyncResult asyncResult);
        
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
        /// <seealso cref="Amazon.DirectConnect.IAmazonDirectConnect.DescribeConnections"/>
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
        /// <seealso cref="Amazon.DirectConnect.IAmazonDirectConnect.DescribeConnections"/>
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
        
    

        #region DescribeConnectionsOnInterconnect

        /// <summary>
        /// <para>Return a list of connections that have been provisioned on the given interconnect.</para>
        /// </summary>
        /// 
        /// <param name="describeConnectionsOnInterconnectRequest">Container for the necessary parameters to execute the
        ///          DescribeConnectionsOnInterconnect service method on AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the DescribeConnectionsOnInterconnect service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="DirectConnectServerException"/>
        /// <exception cref="DirectConnectClientException"/>
        DescribeConnectionsOnInterconnectResponse DescribeConnectionsOnInterconnect(DescribeConnectionsOnInterconnectRequest describeConnectionsOnInterconnectRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConnectionsOnInterconnect operation.
        /// <seealso cref="Amazon.DirectConnect.IAmazonDirectConnect.DescribeConnectionsOnInterconnect"/>
        /// </summary>
        /// 
        /// <param name="describeConnectionsOnInterconnectRequest">Container for the necessary parameters to execute the
        ///          DescribeConnectionsOnInterconnect operation on AmazonDirectConnect.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeConnectionsOnInterconnect operation.</returns>
        IAsyncResult BeginDescribeConnectionsOnInterconnect(DescribeConnectionsOnInterconnectRequest describeConnectionsOnInterconnectRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeConnectionsOnInterconnect operation.
        /// <seealso cref="Amazon.DirectConnect.IAmazonDirectConnect.DescribeConnectionsOnInterconnect"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeConnectionsOnInterconnect.</param>
        /// 
        /// <returns>Returns a DescribeConnectionsOnInterconnectResult from AmazonDirectConnect.</returns>
        DescribeConnectionsOnInterconnectResponse EndDescribeConnectionsOnInterconnect(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DescribeInterconnects

        /// <summary>
        /// <para>Returns a list of interconnects owned by the AWS account.</para> <para>If an interconnect ID is provided, it will only return this
        /// particular interconnect.</para>
        /// </summary>
        /// 
        /// <param name="describeInterconnectsRequest">Container for the necessary parameters to execute the DescribeInterconnects service method on
        ///          AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the DescribeInterconnects service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="DirectConnectServerException"/>
        /// <exception cref="DirectConnectClientException"/>
        DescribeInterconnectsResponse DescribeInterconnects(DescribeInterconnectsRequest describeInterconnectsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInterconnects operation.
        /// <seealso cref="Amazon.DirectConnect.IAmazonDirectConnect.DescribeInterconnects"/>
        /// </summary>
        /// 
        /// <param name="describeInterconnectsRequest">Container for the necessary parameters to execute the DescribeInterconnects operation on
        ///          AmazonDirectConnect.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeInterconnects operation.</returns>
        IAsyncResult BeginDescribeInterconnects(DescribeInterconnectsRequest describeInterconnectsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeInterconnects operation.
        /// <seealso cref="Amazon.DirectConnect.IAmazonDirectConnect.DescribeInterconnects"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeInterconnects.</param>
        /// 
        /// <returns>Returns a DescribeInterconnectsResult from AmazonDirectConnect.</returns>
        DescribeInterconnectsResponse EndDescribeInterconnects(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Returns a list of interconnects owned by the AWS account.</para> <para>If an interconnect ID is provided, it will only return this
        /// particular interconnect.</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeInterconnects service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="DirectConnectServerException"/>
        /// <exception cref="DirectConnectClientException"/>
        DescribeInterconnectsResponse DescribeInterconnects();
        
        #endregion
        
    

        #region DescribeLocations

        /// <summary>
        /// <para>Returns the list of Direct Connect locations in the current AWS region. These are the locations that may be selected when calling
        /// CreateConnection or CreateInterconnect.</para>
        /// </summary>
        /// 
        /// <param name="describeLocationsRequest">Container for the necessary parameters to execute the DescribeLocations service method on
        ///          AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the DescribeLocations service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="DirectConnectServerException"/>
        /// <exception cref="DirectConnectClientException"/>
        DescribeLocationsResponse DescribeLocations(DescribeLocationsRequest describeLocationsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLocations operation.
        /// <seealso cref="Amazon.DirectConnect.IAmazonDirectConnect.DescribeLocations"/>
        /// </summary>
        /// 
        /// <param name="describeLocationsRequest">Container for the necessary parameters to execute the DescribeLocations operation on
        ///          AmazonDirectConnect.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLocations
        ///         operation.</returns>
        IAsyncResult BeginDescribeLocations(DescribeLocationsRequest describeLocationsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeLocations operation.
        /// <seealso cref="Amazon.DirectConnect.IAmazonDirectConnect.DescribeLocations"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLocations.</param>
        /// 
        /// <returns>Returns a DescribeLocationsResult from AmazonDirectConnect.</returns>
        DescribeLocationsResponse EndDescribeLocations(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Returns the list of Direct Connect locations in the current AWS region. These are the locations that may be selected when calling
        /// CreateConnection or CreateInterconnect.</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeLocations service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="DirectConnectServerException"/>
        /// <exception cref="DirectConnectClientException"/>
        DescribeLocationsResponse DescribeLocations();
        
        #endregion
        
    

        #region DescribeVirtualGateways

        /// <summary>
        /// <para>Returns a list of virtual private gateways owned by the AWS account.</para> <para>You can create one or more AWS Direct Connect
        /// private virtual interfaces linking to a virtual private gateway. A virtual private gateway can be managed via Amazon Virtual Private Cloud
        /// (VPC) console or the <a href="http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-CreateVpnGateway.html" >EC2
        /// CreateVpnGateway</a> action.</para>
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
        /// <seealso cref="Amazon.DirectConnect.IAmazonDirectConnect.DescribeVirtualGateways"/>
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
        /// <seealso cref="Amazon.DirectConnect.IAmazonDirectConnect.DescribeVirtualGateways"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVirtualGateways.</param>
        /// 
        /// <returns>Returns a DescribeVirtualGatewaysResult from AmazonDirectConnect.</returns>
        DescribeVirtualGatewaysResponse EndDescribeVirtualGateways(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Returns a list of virtual private gateways owned by the AWS account.</para> <para>You can create one or more AWS Direct Connect
        /// private virtual interfaces linking to a virtual private gateway. A virtual private gateway can be managed via Amazon Virtual Private Cloud
        /// (VPC) console or the <a href="http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-CreateVpnGateway.html" >EC2
        /// CreateVpnGateway</a> action.</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeVirtualGateways service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="DirectConnectServerException"/>
        /// <exception cref="DirectConnectClientException"/>
        DescribeVirtualGatewaysResponse DescribeVirtualGateways();
        
        #endregion
        
    

        #region DescribeVirtualInterfaces

        /// <summary>
        /// <para>Displays all virtual interfaces for an AWS account. Virtual interfaces deleted fewer than 15 minutes before DescribeVirtualInterfaces
        /// is called are also returned. If a connection ID is included then only virtual interfaces associated with this connection will be returned.
        /// If a virtual interface ID is included then only a single virtual interface will be returned.</para> <para> A virtual interface (VLAN)
        /// transmits the traffic between the Direct Connect location and the customer.</para> <para>If a connection ID is provided, only virtual
        /// interfaces provisioned on the specified connection will be returned. If a virtual interface ID is provided, only this particular virtual
        /// interface will be returned.</para>
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
        /// <seealso cref="Amazon.DirectConnect.IAmazonDirectConnect.DescribeVirtualInterfaces"/>
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
        /// <seealso cref="Amazon.DirectConnect.IAmazonDirectConnect.DescribeVirtualInterfaces"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVirtualInterfaces.</param>
        /// 
        /// <returns>Returns a DescribeVirtualInterfacesResult from AmazonDirectConnect.</returns>
        DescribeVirtualInterfacesResponse EndDescribeVirtualInterfaces(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Displays all virtual interfaces for an AWS account. Virtual interfaces deleted fewer than 15 minutes before DescribeVirtualInterfaces
        /// is called are also returned. If a connection ID is included then only virtual interfaces associated with this connection will be returned.
        /// If a virtual interface ID is included then only a single virtual interface will be returned.</para> <para> A virtual interface (VLAN)
        /// transmits the traffic between the Direct Connect location and the customer.</para> <para>If a connection ID is provided, only virtual
        /// interfaces provisioned on the specified connection will be returned. If a virtual interface ID is provided, only this particular virtual
        /// interface will be returned.</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeVirtualInterfaces service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="DirectConnectServerException"/>
        /// <exception cref="DirectConnectClientException"/>
        DescribeVirtualInterfacesResponse DescribeVirtualInterfaces();
        
        #endregion
        
    
    }
}
    
